using System;

namespace Glad
{
    [Flags]
    public enum FeatureType : byte
    {
        Unknown = 0x00,
        Command = 0x01,
        Enum = 0x02,
        Type = 0x04,
        All = 0xFF
    }
}