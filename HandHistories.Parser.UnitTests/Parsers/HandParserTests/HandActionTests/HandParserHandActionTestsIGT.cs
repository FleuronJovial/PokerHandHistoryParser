﻿using HandHistories.Objects.Actions;
using HandHistories.Objects.Cards;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace HandHistories.Parser.UnitTests.Parsers.HandParserTests.HandActionTests
{
    class HandParserHandActionTestsIGT : HandParserHandActionTests
    {
        public HandParserHandActionTestsIGT()
            : base("IGT")
        {

        }

        protected override List<HandAction> ExpectedHandActionsBasicHand
        {
            get
            {
                Assert.Ignore();
                return new List<HandAction>()
                { 
                };
            }
        }

        protected override List<HandAction> ExpectedHandActionsFoldedPreflop
        {
            get
            {
                return new List<HandAction>()
                {
                    new HandAction("PLAYER4", HandActionType.SMALL_BLIND, 2.5m, Street.Preflop),
                    new HandAction("HERO", HandActionType.BIG_BLIND, 5m, Street.Preflop),

                    new HandAction("PLAYER1", HandActionType.FOLD, 0, Street.Preflop),
                    new HandAction("PLAYER2", HandActionType.FOLD, 0, Street.Preflop),
                    new HandAction("PLAYER3", HandActionType.FOLD, 0, Street.Preflop),
                    new HandAction("PLAYER4", HandActionType.FOLD, 0, Street.Preflop),

                    new HandAction("HERO", HandActionType.UNCALLED_BET, 2.5m, Street.Preflop),
                    new WinningsAction("HERO", HandActionType.WINS, 5m, 0),  
                };
            }
        }

        protected override List<HandAction> ExpectedHandActions3BetHand
        {
            get
            {
                return new List<HandAction>()
                {
                    new HandAction("PLAYER1", HandActionType.SMALL_BLIND, 10m, Street.Preflop),
                    new HandAction("PLAYER2", HandActionType.BIG_BLIND, 20m, Street.Preflop),

                    new HandAction("HERO", HandActionType.FOLD, 0m, Street.Preflop),
                    new HandAction("PLAYER4", HandActionType.RAISE, 70m, Street.Preflop),
                    new HandAction("PLAYER5", HandActionType.RAISE, 240m, Street.Preflop),
                    new HandAction("PLAYER1", HandActionType.CALL, 230m, Street.Preflop),
                    new HandAction("PLAYER2", HandActionType.FOLD, 0, Street.Preflop),
                    new HandAction("PLAYER4", HandActionType.CALL, 170m, Street.Preflop),

                    new HandAction("PLAYER1", HandActionType.CHECK, 0m, Street.Flop),
                    new HandAction("PLAYER4", HandActionType.CHECK, 0m, Street.Flop),
                    new HandAction("PLAYER5", HandActionType.CHECK, 0m, Street.Flop),

                    new HandAction("PLAYER1", HandActionType.BET, 260m, Street.Turn),
                    new HandAction("PLAYER4", HandActionType.CALL, 260m, Street.Turn),
                    new HandAction("PLAYER5", HandActionType.FOLD, 0m, Street.Turn),

                    new HandAction("PLAYER1", HandActionType.CHECK, 0m, Street.River),
                    new HandAction("PLAYER4", HandActionType.CHECK, 0m, Street.River),

                    new WinningsAction("PLAYER4", HandActionType.WINS, 1240m, 0)
                };
            }
        }

        protected override List<HandAction> ExpectedHandActionsAllInHand
        {
            get
            {
                Assert.Ignore();
                return new List<HandAction>()
                { 
                };
            }
        }

        protected override List<HandAction> ExpectedHandActionsUncalledBetHand
        {
            get
            {
                Assert.Ignore();
                return new List<HandAction>()
                {
                };
            }
        }

        protected override List<HandAction> ExpectedOmahaHiLoHand
        {
            get
            {
                Assert.Ignore();
                return new List<HandAction>()
                {  
                };
            }
        }
    }
}
