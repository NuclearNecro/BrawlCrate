﻿using BrawlLib.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BrawlLib.SSBB.Types
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct MuEvent
    {
        public const int Size = 0x10;

        public buint _titleMsgLineIndex;
        public buint _descriptionMsgLineIndex;
        public byte _p1CssId;
        public byte _unknown0x09;
        public byte _p2CssId;
        public byte _scoreType;
        public byte _eventId;
        public byte _unknown0x13;
        public byte _unknown0x14;
        public byte _unknown0x15;
    }
}
