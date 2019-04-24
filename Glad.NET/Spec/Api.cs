using System;
using System.Diagnostics.CodeAnalysis;

namespace Glad.Spec
{
    [Flags]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum Api : byte
    {
        Disabled = 0x00,
        GL = 0x01,
        GLES1 = 0x02,
        GLES2 = 0x04,
        GLSC2 = 0x08,
        GLCore = 0x10,
        All = 0xFF
    }
}