using System;

namespace Glad
{
    [Flags]
    public enum Profile : byte
    {
        None = 0x00,
        Compatibility = 0x01,
        Core = 0x02,
        Common = 0x04,
        All = 0xFF
    }
}