using System;
using System.Collections.Generic;
using System.Text;
using System.Buffers;
using System.Xml.Schema;

namespace HandHistories.Parser.Utils
{
    ref struct SpanParser
    {
        ReadOnlySpan<char> _span;

        public ReadOnlySpan<char> Current => _span;

        public int Length => _span.Length;

        public SpanParser(ReadOnlySpan<char> span)
        {
            _span = span;
        }

        #region String methods
        public bool EndsWith(char end) => _span[_span.Length - 1] == end;
        public bool EndsWith(ReadOnlySpan<char> end) => _span.EndsWith(end);

        public bool StartsWith(char start) => _span[0] == start;
        public bool StartsWith(ReadOnlySpan<char> start) => _span.StartsWith(start);

        public int IndexOf(char c) => _span.IndexOf(c);
        public int IndexOf(ReadOnlySpan<char> c) => _span.IndexOf(c);

        public int LastIndexOf(char c) => _span.LastIndexOf(c);
        public int LastIndexOf(ReadOnlySpan<char> c) => _span.LastIndexOf(c);
        #endregion

        public char GetLast() =>  _span[_span.Length - 1];

        public string ReadString(int size, int offset = 0) => new string(Read(size, offset));

        public byte ReadByte(int size, int offset = 0) => byte.Parse(Read(size, offset));

        public short ReadShort(int size, int offset = 0) => short.Parse(Read(size, offset));

        public int ReadInt(int size, int offset = 0) => int.Parse(Read(size, offset));

        public long ReadLong(int size, int offset = 0) => long.Parse(Read(size, offset));

        public float ReadSingle(int size, int offset = 0) => float.Parse(Read(size, offset));

        public double ReadDouble(int size, int offset = 0) => double.Parse(Read(size, offset));

        public decimal ReadDecimal(int size, int offset = 0) => decimal.Parse(Read(size, offset));

        public ReadOnlySpan<char> Read(int size, int offset = 0)
        {
            var result = _span.Slice(0, size);
            _span = _span.Slice(size + offset);
            return result;
        }

        public void Advance(int size) => _span = _span.Slice(size);

        public void AdvanceTo(char c, int offset = 0)
        {
            Advance(_span.IndexOf(c) + offset);
        }
        public void AdvanceTo(ReadOnlySpan<char> c, int offset = 0)
        {
            Advance(_span.IndexOf(c) + offset);
        }

        public void Shrink(int size)
        {
            _span = _span.Slice(0, _span.Length - size);
        }
    }
}
