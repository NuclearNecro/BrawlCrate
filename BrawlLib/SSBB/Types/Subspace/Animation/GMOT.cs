﻿using BrawlLib.Internal;
using System.Runtime.InteropServices;

namespace BrawlLib.SSBB.Types.Subspace.Animation
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct GMOTEntry
    {
        public const int Size = 0x1E4;

        public bfloat _unknown0x000;
        public bfloat _unknown0x004;
        public bfloat _unknown0x008;
        public bfloat _unknown0x00C;
        public bfloat _unknown0x010;
        public bfloat _unknown0x014;
        public bfloat _unknown0x018;
        public bfloat _unknown0x01C;
        public bfloat _unknown0x020;
        public bfloat _unknown0x024;
        public bfloat _unknown0x028;
        public bfloat _unknown0x02C;
        public bfloat _unknown0x030;
        public bfloat _unknown0x034;
        public bfloat _unknown0x038;
        public byte _modelDataIndex;        // 0x3C
        public byte _collisionDataIndex;    // 0x3D
        public byte _unknown0x03E;
        public byte _unknown0x03F;
        public buint _unknown0x040;
        public buint _unknown0x044;
        public buint _unknown0x048;
        public buint _unknown0x04C;
        public buint _unknown0x050;
        public buint _unknown0x054;
        public buint _unknown0x058;
        public buint _unknown0x05C;
        public buint _unknown0x060;
        public buint _unknown0x064;
        public buint _unknown0x068;
        public buint _unknown0x06C;
        public buint _unknown0x070;
        public buint _unknown0x074;
        public buint _unknown0x078;
        public buint _unknown0x07C;
        public buint _unknown0x080;
        public buint _unknown0x084;
        public buint _unknown0x088;
        public buint _unknown0x08C;
        public buint _unknown0x090;
        public buint _unknown0x094;
        public buint _unknown0x098;
        public buint _unknown0x09C;
        public buint _unknown0x0A0;
        public buint _unknown0x0A4;
        public buint _unknown0x0A8;
        public buint _unknown0x0AC;
        public buint _unknown0x0B0;
        public buint _unknown0x0B4;
        public buint _unknown0x0B8;
        public buint _unknown0x0BC;
        public buint _unknown0x0C0;
        public buint _unknown0x0C4;
        public buint _unknown0x0C8;
        public buint _unknown0x0CC;
        public buint _unknown0x0D0;
        public buint _unknown0x0D4;
        public buint _unknown0x0D8;
        public buint _unknown0x0DC;
        public buint _unknown0x0E0;
        public buint _unknown0x0E4;
        public buint _unknown0x0E8;
        public buint _unknown0x0EC;
        public buint _unknown0x0F0;
        public buint _unknown0x0F4;
        public buint _unknown0x0F8;
        public buint _unknown0x0FC;
        public buint _unknown0x100;
        public buint _unknown0x104;
        public buint _unknown0x108;
        public buint _unknown0x10C;
        public buint _unknown0x110;
        public buint _unknown0x114;
        public bint _soundInfoIndex;        // 0x118
        public buint _unknown0x11C;
        public buint _unknown0x120;
        public buint _unknown0x124;
        public buint _unknown0x128;
        public buint _unknown0x12C;
        public buint _unknown0x130;
        public buint _unknown0x134;
        public buint _unknown0x138;
        public buint _unknown0x13C;
        public buint _unknown0x140;
        public buint _unknown0x144;
        public buint _unknown0x148;
        public buint _unknown0x14C;
        public buint _unknown0x150;
        public buint _unknown0x154;
        public buint _unknown0x158;
        public buint _unknown0x15C;
        public buint _unknown0x160;
        public buint _unknown0x164;
        public buint _unknown0x168;
        public buint _unknown0x16C;
        public buint _unknown0x170;
        public buint _unknown0x174;
        public buint _unknown0x178;
        public buint _unknown0x17C;
        public buint _unknown0x180;
        public buint _unknown0x184;
        public buint _unknown0x188;
        public buint _unknown0x18C;
        public buint _unknown0x190;
        public buint _unknown0x194;
        public buint _unknown0x198;
        public buint _unknown0x19C;
        public buint _unknown0x1A0;
        public buint _unknown0x1A4;
        public buint _unknown0x1A8;
        public buint _unknown0x1AC;
        public buint _unknown0x1B0;
        public buint _unknown0x1B4;
        public buint _unknown0x1B8;
        public buint _unknown0x1BC;
        public buint _unknown0x1C0;
        public buint _unknown0x1C4;
        public buint _unknown0x1C8;
        public buint _unknown0x1CC;
        public buint _unknown0x1D0;
        public buint _unknown0x1D4;
        public buint _unknown0x1D8;
        public buint _unknown0x1DC;
        public buint _unknown0x1E0;
        
        private VoidPtr Address
        {
            get
            {
                fixed (void* ptr = &this)
                {
                    return ptr;
                }
            }
        }
    }
}