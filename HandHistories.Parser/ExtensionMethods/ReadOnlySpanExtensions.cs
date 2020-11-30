using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HandHistories.Parser
{
    static class ReadOnlySpanExtensions
    {
        public static bool EndsWith(this ReadOnlySpan<char> str, char end)
        {
            return str[str.Length - 1] == end;
        }

        public static bool StartsWith(this ReadOnlySpan<char> str, char start)
        {
            return str[0] == start;
        }

        public static char GetLast(this ReadOnlySpan<char> str)
        {
            return str[str.Length - 1];
        }

        public static ReadOnlySpan<char> SliceBetween(this ReadOnlySpan<char> str, int startIndex, int endIndex)
        {
            return str.Slice(startIndex, endIndex - startIndex);
        }

        public static ReadOnlySpan<char> Remove(this ReadOnlySpan<char> str, int startIndex)
        {
            return str.Slice(0, startIndex);
        }

        public static string ReadString(this ref ReadOnlySpan<char> str, int size)
        {
            var result = str.Slice(0, size);
            str = str.Slice(size);
            return result.ToString();
        }

        public static int ReadInt(this ref ReadOnlySpan<char> str, int size)
        {
            var result = str.Slice(0, size);
            str = str.Slice(size);
            return int.Parse(result);
        }

        public static long ReadLong(this ref ReadOnlySpan<char> str, int size)
        {
            var result = str.Slice(0, size);
            str = str.Slice(size);
            return long.Parse(result);
        }

        public static ReadOnlySpan<char> Read(this ref ReadOnlySpan<char> str, int size)
        {
            var result = str.Slice(0, size);
            str = str.Slice(size);
            return result;
        }

        public static void Advance(this ref ReadOnlySpan<char> str, int size)
        {
            str = str.Slice(size);
        }

        public static void AdvanceTo(this ref ReadOnlySpan<char> str, char c, int offset = 0)
        {
            Advance(ref str, str.IndexOf(c) + offset);
        }
        public static void AdvanceTo(this ref ReadOnlySpan<char> str, ReadOnlySpan<char> c, int offset = 0)
        {
            Advance(ref str, str.IndexOf(c) + offset);
        }

        public static void Shrink(this ref ReadOnlySpan<char> str, int size)
        {
            str = str.Slice(0, str.Length - size);
        }

        static char[] CurrencyChars = new char[] { '£', '€', '$', '¥' };

        public static decimal ParseAmount(this ReadOnlySpan<char> str)
        {
            str = str.Trim(CurrencyChars);
            return decimal.Parse(str, provider: CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Removes any currency symbols before parsing
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static decimal ParseAmount(this ReadOnlySpan<char> str, NumberFormatInfo numberFormat)
        {
            str = str.Trim(CurrencyChars);
            return decimal.Parse(str, provider: numberFormat);
        }

        static readonly char[] ParseWSTrimChars = new char[]
        {
            '£', '€', '$', ' ', '¥', (char)160
        };

        /// <summary>
        /// Removes any currency symbols and whitespaces before parsing
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static decimal ParseAmountWS(this ReadOnlySpan<char> str)
        {
            str = str.Trim(ParseWSTrimChars);
            return decimal.Parse(str, provider: CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Removes any currency symbols and whitespaces before parsing
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static decimal ParseAmountWS(this ReadOnlySpan<char> str, NumberFormatInfo numberFormat)
        {
            str = str.Trim(ParseWSTrimChars);
            return decimal.Parse(str, provider: numberFormat);
        }
    }
}
