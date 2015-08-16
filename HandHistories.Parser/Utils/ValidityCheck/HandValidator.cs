﻿using HandHistories.Objects.Actions;
using HandHistories.Objects.Cards;
using HandHistories.Objects.Hand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandHistories.Parser.Utils
{
    public static class HandIntegrity
    {
        public static bool Check(HandHistory hand, out string reason)
        {
            reason = null;

            return CheckTotalPot(hand, out reason) && CheckActionOrder(hand.HandActions, out reason);
        }

        static bool CheckActionOrder(List<HandAction> list, out string reason)
        {
            reason = null;
            bool BetOccured = true;
            int blindEndIndex = -1;

            for (int i = 0; i < list.Count; i++)
			{
                var item = list[i];
			    if (!item.IsBlinds && item.HandActionType != HandActionType.ANTE)
	            {
		            blindEndIndex = i;
                    break;
                }
			}


            Street currentStreet = Street.Preflop;
            for (int i = blindEndIndex; i < list.Count; i++)
			{
			    var item = list[i];
			    if (item.IsBlinds || item.HandActionType == HandActionType.ANTE)
	            {
		            return false;
                }

                if (item.Street != currentStreet)
                {
                    if ((int)item.Street < (int)currentStreet)
                    {
                        return false;
                    }

                    BetOccured = false;
                    currentStreet = item.Street;
                }

                if (item.HandActionType == HandActionType.BET)
                {
                    if (BetOccured)
                    {
                        return false;
                    }
                    else
                    {
                        BetOccured = true;
                    }
                }

                if (item.HandActionType == HandActionType.RAISE || item.HandActionType == HandActionType.CALL)
                {
                    if (!BetOccured)
                    {
                        return false;
                    }
                }
			}

            return true;
        }

        static bool CheckTotalPot(HandHistory hand, out string reason)
        {
            var totalPot = hand.HandActions
                .Where(p => p.IsGameAction || p.IsBlinds)
                .Sum(p => p.Amount);

            bool PotValid = Math.Abs(totalPot) == hand.TotalPot;

            if (PotValid)
            {
                reason = null;
            }
            else
            {
                reason = string.Format("Total Pot not correct: {0} actions: {1}", hand.TotalPot, totalPot);
            }

            return PotValid;
        }
    }
}