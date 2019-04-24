using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Diagnostics.CodeAnalysis;

namespace OpenGL
{
    public delegate IntPtr GetProcAddressHandler(string funcName);
    public delegate void DebugProc(int source, int type, uint id, int severity, IntPtr length, byte[] message, IntPtr userParam);
    public delegate void DebugProcAMD(uint id, int category, int severity, IntPtr length, byte[] message, IntPtr userParam);
    public delegate void VulkanDebugProcNV();


    [Flags]
    public enum AttribMask : uint
    {
        CurrentBit = 0x00000001,
        PointBit = 0x00000002,
        LineBit = 0x00000004,
        PolygonBit = 0x00000008,
        PolygonStippleBit = 0x00000010,
        PixelModeBit = 0x00000020,
        LightingBit = 0x00000040,
        FogBit = 0x00000080,
        DepthBufferBit = 0x00000100,
        AccumBufferBit = 0x00000200,
        StencilBufferBit = 0x00000400,
        ViewportBit = 0x00000800,
        TransformBit = 0x00001000,
        EnableBit = 0x00002000,
        ColorBufferBit = 0x00004000,
        HintBit = 0x00008000,
        EvalBit = 0x00010000,
        ListBit = 0x00020000,
        TextureBit = 0x00040000,
        ScissorBit = 0x00080000,
        MultisampleBit = 0x20000000,
        MultisampleBitARB = 0x20000000,
        MultisampleBitEXT = 0x20000000,
        MultisampleBit3DFX = 0x20000000,
        AllAttribBits = 0xFFFFFFFF
    }

    [Flags]
    public enum BufferStorageMask : uint
    {
        DynamicStorageBit = 0x0100,
        DynamicStorageBitEXT = 0x0100,
        ClientStorageBit = 0x0200,
        ClientStorageBitEXT = 0x0200,
        SparseStorageBitARB = 0x0400,
        LgpuSeparateStorageBitNvx = 0x0800,
        PerGpuStorageBitNV = 0x0800,
        ExternalStorageBitNvx = 0x2000
    }

    [Flags]
    public enum ClearBufferMask : uint
    {
        CoverageBufferBitNV = 0x00008000
    }

    [Flags]
    public enum ClientAttribMask : uint
    {
        ClientPixelStoreBit = 0x00000001,
        ClientVertexArrayBit = 0x00000002,
        ClientAllAttribBits = 0xFFFFFFFF
    }

    [Flags]
    public enum ContextFlagMask : uint
    {
        ContextFlagForwardCompatibleBit = 0x00000001,
        ContextFlagDebugBit = 0x00000002,
        ContextFlagDebugBitKhr = 0x00000002,
        ContextFlagRobustAccessBit = 0x00000004,
        ContextFlagRobustAccessBitARB = 0x00000004,
        ContextFlagNoErrorBit = 0x00000008,
        ContextFlagNoErrorBitKhr = 0x00000008,
        ContextFlagProtectedContentBitEXT = 0x00000010
    }

    [Flags]
    public enum ContextProfileMask : uint
    {
        ContextCoreProfileBit = 0x00000001,
        ContextCompatibilityProfileBit = 0x00000002
    }

    [Flags]
    public enum MapBufferAccessMask : uint
    {
        MapReadBit = 0x0001,
        MapReadBitEXT = 0x0001,
        MapWriteBit = 0x0002,
        MapWriteBitEXT = 0x0002,
        MapInvalidateRangeBit = 0x0004,
        MapInvalidateRangeBitEXT = 0x0004,
        MapInvalidateBufferBit = 0x0008,
        MapInvalidateBufferBitEXT = 0x0008,
        MapFlushExplicitBit = 0x0010,
        MapFlushExplicitBitEXT = 0x0010,
        MapUnsynchronizedBit = 0x0020,
        MapUnsynchronizedBitEXT = 0x0020,
        MapPersistentBit = 0x0040,
        MapPersistentBitEXT = 0x0040,
        MapCoherentBit = 0x0080,
        MapCoherentBitEXT = 0x0080
    }

    [Flags]
    public enum MemoryBarrierMask : uint
    {
        VertexAttribArrayBarrierBit = 0x00000001,
        VertexAttribArrayBarrierBitEXT = 0x00000001,
        ElementArrayBarrierBit = 0x00000002,
        ElementArrayBarrierBitEXT = 0x00000002,
        UniformBarrierBit = 0x00000004,
        UniformBarrierBitEXT = 0x00000004,
        TextureFetchBarrierBit = 0x00000008,
        TextureFetchBarrierBitEXT = 0x00000008,
        ShaderGlobalAccessBarrierBitNV = 0x00000010,
        ShaderImageAccessBarrierBit = 0x00000020,
        ShaderImageAccessBarrierBitEXT = 0x00000020,
        CommandBarrierBit = 0x00000040,
        CommandBarrierBitEXT = 0x00000040,
        PixelBufferBarrierBit = 0x00000080,
        PixelBufferBarrierBitEXT = 0x00000080,
        TextureUpdateBarrierBit = 0x00000100,
        TextureUpdateBarrierBitEXT = 0x00000100,
        BufferUpdateBarrierBit = 0x00000200,
        BufferUpdateBarrierBitEXT = 0x00000200,
        FramebufferBarrierBit = 0x00000400,
        FramebufferBarrierBitEXT = 0x00000400,
        TransformFeedbackBarrierBit = 0x00000800,
        TransformFeedbackBarrierBitEXT = 0x00000800,
        AtomicCounterBarrierBit = 0x00001000,
        AtomicCounterBarrierBitEXT = 0x00001000,
        ShaderStorageBarrierBit = 0x00002000,
        ClientMappedBufferBarrierBit = 0x00004000,
        ClientMappedBufferBarrierBitEXT = 0x00004000,
        QueryBufferBarrierBit = 0x00008000,
        AllBarrierBits = 0xFFFFFFFF,
        AllBarrierBitsEXT = 0xFFFFFFFF
    }

    [Flags]
    public enum OcclusionQueryEventMaskAMD : uint
    {
        QueryDepthPassEventBitAMD = 0x00000001,
        QueryDepthFailEventBitAMD = 0x00000002,
        QueryStencilFailEventBitAMD = 0x00000004,
        QueryDepthBoundsFailEventBitAMD = 0x00000008,
        QueryAllEventBitsAMD = 0xFFFFFFFF
    }

    [Flags]
    public enum SyncObjectMask : uint
    {
        SyncFlushCommandsBit = 0x00000001,
        SyncFlushCommandsBitAPPLE = 0x00000001
    }

    [Flags]
    public enum UseProgramStageMask : uint
    {
        VertexShaderBit = 0x00000001,
        VertexShaderBitEXT = 0x00000001,
        FragmentShaderBit = 0x00000002,
        FragmentShaderBitEXT = 0x00000002,
        GeometryShaderBit = 0x00000004,
        GeometryShaderBitEXT = 0x00000004,
        GeometryShaderBitOES = 0x00000004,
        TessControlShaderBit = 0x00000008,
        TessControlShaderBitEXT = 0x00000008,
        TessControlShaderBitOES = 0x00000008,
        TessEvaluationShaderBit = 0x00000010,
        TessEvaluationShaderBitEXT = 0x00000010,
        TessEvaluationShaderBitOES = 0x00000010,
        ComputeShaderBit = 0x00000020,
        MeshShaderBitNV = 0x00000040,
        TaskShaderBitNV = 0x00000080,
        AllShaderBits = 0xFFFFFFFF,
        AllShaderBitsEXT = 0xFFFFFFFF
    }

    [Flags]
    public enum TextureStorageMaskAMD : uint
    {
        TextureStorageSparseBitAMD = 0x00000001
    }

    [Flags]
    public enum FragmentShaderDestMaskATI : uint
    {
        RedBitATI = 0x00000001,
        GreenBitATI = 0x00000002,
        BlueBitATI = 0x00000004
    }

    [Flags]
    public enum FragmentShaderDestModMaskATI : uint
    {
        TwoXBitATI = 0x00000001,
        FourXBitATI = 0x00000002,
        EightXBitATI = 0x00000004,
        HalfBitATI = 0x00000008,
        QuarterBitATI = 0x00000010,
        EighthBitATI = 0x00000020,
        SaturateBitATI = 0x00000040
    }

    [Flags]
    public enum FragmentShaderColorModMaskATI : uint
    {
        CompBitATI = 0x00000002,
        NegateBitATI = 0x00000004,
        BiasBitATI = 0x00000008
    }

    [Flags]
    public enum TraceMaskMESA : uint
    {
        TraceOperationsBitMESA = 0x0001,
        TracePrimitivesBitMESA = 0x0002,
        TraceArraysBitMESA = 0x0004,
        TraceTexturesBitMESA = 0x0008,
        TracePixelsBitMESA = 0x0010,
        TraceErrorsBitMESA = 0x0020,
        TraceAllBitsMESA = 0xFFFF
    }

    [Flags]
    public enum PathRenderingMaskNV : uint
    {
        BoldBitNV = 0x01,
        ItalicBitNV = 0x02,
        GlyphWidthBitNV = 0x01,
        GlyphHeightBitNV = 0x02,
        GlyphHorizontalBearingXBitNV = 0x04,
        GlyphHorizontalBearingYBitNV = 0x08,
        GlyphHorizontalBearingAdvanceBitNV = 0x10,
        GlyphVerticalBearingXBitNV = 0x20,
        GlyphVerticalBearingYBitNV = 0x40,
        GlyphVerticalBearingAdvanceBitNV = 0x80,
        GlyphHasKerningBitNV = 0x100,
        FontXMinBoundsBitNV = 0x00010000,
        FontYMinBoundsBitNV = 0x00020000,
        FontXMaxBoundsBitNV = 0x00040000,
        FontYMaxBoundsBitNV = 0x00080000,
        FontUnitsPerEmBitNV = 0x00100000,
        FontAscenderBitNV = 0x00200000,
        FontDescenderBitNV = 0x00400000,
        FontHeightBitNV = 0x00800000,
        FontMaxAdvanceWidthBitNV = 0x01000000,
        FontMaxAdvanceHeightBitNV = 0x02000000,
        FontUnderlinePositionBitNV = 0x04000000,
        FontUnderlineThicknessBitNV = 0x08000000,
        FontHasKerningBitNV = 0x10000000,
        FontNumGlyphIndicesBitNV = 0x20000000
    }

    [Flags]
    public enum PerformanceQueryCapsMaskINTEL : uint
    {
        PerfquerySingleContextINTEL = 0x00000000,
        PerfqueryGlobalContextINTEL = 0x00000001
    }

    [Flags]
    public enum VertexHintsMaskPGI : uint
    {
        Vertex23BitPGI = 0x00000004,
        Vertex4BitPGI = 0x00000008,
        Color3BitPGI = 0x00010000,
        Color4BitPGI = 0x00020000,
        EdgeflagBitPGI = 0x00040000,
        IndexBitPGI = 0x00080000,
        MatAmbientBitPGI = 0x00100000,
        MatAmbientAndDiffuseBitPGI = 0x00200000,
        MatDiffuseBitPGI = 0x00400000,
        MatEmissionBitPGI = 0x00800000,
        MatColorIndexesBitPGI = 0x01000000,
        MatShininessBitPGI = 0x02000000,
        MatSpecularBitPGI = 0x04000000,
        NormalBitPGI = 0x08000000,
        Texcoord1BitPGI = 0x10000000,
        Texcoord2BitPGI = 0x20000000,
        Texcoord3BitPGI = 0x40000000,
        Texcoord4BitPGI = 0x80000000
    }

    [Flags]
    public enum BufferBitQCOM : uint
    {
        ColorBufferBit0QCOM = 0x00000001,
        ColorBufferBit1QCOM = 0x00000002,
        ColorBufferBit2QCOM = 0x00000004,
        ColorBufferBit3QCOM = 0x00000008,
        ColorBufferBit4QCOM = 0x00000010,
        ColorBufferBit5QCOM = 0x00000020,
        ColorBufferBit6QCOM = 0x00000040,
        ColorBufferBit7QCOM = 0x00000080,
        DepthBufferBit0QCOM = 0x00000100,
        DepthBufferBit1QCOM = 0x00000200,
        DepthBufferBit2QCOM = 0x00000400,
        DepthBufferBit3QCOM = 0x00000800,
        DepthBufferBit4QCOM = 0x00001000,
        DepthBufferBit5QCOM = 0x00002000,
        DepthBufferBit6QCOM = 0x00004000,
        DepthBufferBit7QCOM = 0x00008000,
        StencilBufferBit0QCOM = 0x00010000,
        StencilBufferBit1QCOM = 0x00020000,
        StencilBufferBit2QCOM = 0x00040000,
        StencilBufferBit3QCOM = 0x00080000,
        StencilBufferBit4QCOM = 0x00100000,
        StencilBufferBit5QCOM = 0x00200000,
        StencilBufferBit6QCOM = 0x00400000,
        StencilBufferBit7QCOM = 0x00800000,
        MultisampleBufferBit0QCOM = 0x01000000,
        MultisampleBufferBit1QCOM = 0x02000000,
        MultisampleBufferBit2QCOM = 0x04000000,
        MultisampleBufferBit3QCOM = 0x08000000,
        MultisampleBufferBit4QCOM = 0x10000000,
        MultisampleBufferBit5QCOM = 0x20000000,
        MultisampleBufferBit6QCOM = 0x40000000,
        MultisampleBufferBit7QCOM = 0x80000000
    }

    [Flags]
    public enum FoveationConfigBitQCOM : uint
    {
        FoveationEnableBitQCOM = 0x00000001,
        FoveationScaledBinMethodBitQCOM = 0x00000002,
        FoveationSubsampledLayoutMethodBitQCOM = 0x00000004
    }

    [Flags]
    public enum FfdMaskSGIX : uint
    {
        TextureDeformationBitSGIX = 0x00000001,
        GeometryDeformationBitSGIX = 0x00000002
    }

    public enum CommandOpcodesNV
    {
        TerminateSequenceCommandNV = 0x0000,
        NopCommandNV = 0x0001,
        DrawElementsCommandNV = 0x0002,
        DrawArraysCommandNV = 0x0003,
        DrawElementsStripCommandNV = 0x0004,
        DrawArraysStripCommandNV = 0x0005,
        DrawElementsInstancedCommandNV = 0x0006,
        DrawArraysInstancedCommandNV = 0x0007,
        ElementAddressCommandNV = 0x0008,
        AttributeAddressCommandNV = 0x0009,
        UniformAddressCommandNV = 0x000A,
        BlendColorCommandNV = 0x000B,
        StencilRefCommandNV = 0x000C,
        LineWidthCommandNV = 0x000D,
        PolygonOffsetCommandNV = 0x000E,
        AlphaRefCommandNV = 0x000F,
        ViewportCommandNV = 0x0010,
        ScissorCommandNV = 0x0011,
        FrontFaceCommandNV = 0x0012
    }

    public enum MapTextureFormatINTEL
    {
        LayoutDefaultINTEL = 0,
        LayoutLinearINTEL = 1,
        LayoutLinearCpuCachedINTEL = 2
    }

    public enum PathRenderingTokenNV
    {
        ClosePathNV = 0x00,
        MoveToNV = 0x02,
        RelativeMoveToNV = 0x03,
        LineToNV = 0x04,
        RelativeLineToNV = 0x05,
        HorizontalLineToNV = 0x06,
        RelativeHorizontalLineToNV = 0x07,
        VerticalLineToNV = 0x08,
        RelativeVerticalLineToNV = 0x09,
        QuadraticCurveToNV = 0x0A,
        RelativeQuadraticCurveToNV = 0x0B,
        CubicCurveToNV = 0x0C,
        RelativeCubicCurveToNV = 0x0D,
        SmoothQuadraticCurveToNV = 0x0E,
        RelativeSmoothQuadraticCurveToNV = 0x0F,
        SmoothCubicCurveToNV = 0x10,
        RelativeSmoothCubicCurveToNV = 0x11,
        SmallCcwArcToNV = 0x12,
        RelativeSmallCcwArcToNV = 0x13,
        SmallCwArcToNV = 0x14,
        RelativeSmallCwArcToNV = 0x15,
        LargeCcwArcToNV = 0x16,
        RelativeLargeCcwArcToNV = 0x17,
        LargeCwArcToNV = 0x18,
        RelativeLargeCwArcToNV = 0x19,
        ConicCurveToNV = 0x1A,
        RelativeConicCurveToNV = 0x1B,
        SharedEdgeNV = 0xC0,
        RoundedRectNV = 0xE8,
        RelativeRoundedRectNV = 0xE9,
        RoundedRect2NV = 0xEA,
        RelativeRoundedRect2NV = 0xEB,
        RoundedRect4NV = 0xEC,
        RelativeRoundedRect4NV = 0xED,
        RoundedRect8NV = 0xEE,
        RelativeRoundedRect8NV = 0xEF,
        RestartPathNV = 0xF0,
        DupFirstCubicCurveToNV = 0xF2,
        DupLastCubicCurveToNV = 0xF4,
        RectNV = 0xF6,
        RelativeRectNV = 0xF7,
        CircularCcwArcToNV = 0xF8,
        CircularCwArcToNV = 0xFA,
        CircularTangentArcToNV = 0xFC,
        ArcToNV = 0xFE,
        RelativeArcToNV = 0xFF
    }

    public enum TransformFeedbackTokenNV
    {
        NextBufferNV = -2,
        SkipComponents4NV = -3,
        SkipComponents3NV = -4,
        SkipComponents2NV = -5,
        SkipComponents1NV = -6
    }

    public enum TriangleListSUN
    {
        RestartSUN = 0x0001,
        ReplaceMiddleSUN = 0x0002,
        ReplaceOldestSUN = 0x0003
    }

    public enum RegisterCombinerPname
    {
        Combine = 0x8570,
        CombineARB = 0x8570,
        CombineEXT = 0x8570,
        CombineRgb = 0x8571,
        CombineRgbARB = 0x8571,
        CombineRgbEXT = 0x8571,
        CombineAlpha = 0x8572,
        CombineAlphaARB = 0x8572,
        CombineAlphaEXT = 0x8572,
        RgbScale = 0x8573,
        RgbScaleARB = 0x8573,
        RgbScaleEXT = 0x8573,
        AddSigned = 0x8574,
        AddSignedARB = 0x8574,
        AddSignedEXT = 0x8574,
        Interpolate = 0x8575,
        InterpolateARB = 0x8575,
        InterpolateEXT = 0x8575,
        Constant = 0x8576,
        ConstantARB = 0x8576,
        ConstantEXT = 0x8576,
        ConstantNV = 0x8576,
        PrimaryColor = 0x8577,
        PrimaryColorARB = 0x8577,
        PrimaryColorEXT = 0x8577,
        Previous = 0x8578,
        PreviousARB = 0x8578,
        PreviousEXT = 0x8578,
        Source0Rgb = 0x8580,
        Source0RgbARB = 0x8580,
        Source0RgbEXT = 0x8580,
        Src0Rgb = 0x8580,
        Source1Rgb = 0x8581,
        Source1RgbARB = 0x8581,
        Source1RgbEXT = 0x8581,
        Src1Rgb = 0x8581,
        Source2Rgb = 0x8582,
        Source2RgbARB = 0x8582,
        Source2RgbEXT = 0x8582,
        Src2Rgb = 0x8582,
        Source3RgbNV = 0x8583,
        Source0Alpha = 0x8588,
        Source0AlphaARB = 0x8588,
        Source0AlphaEXT = 0x8588,
        Src0Alpha = 0x8588,
        Source1Alpha = 0x8589,
        Source1AlphaARB = 0x8589,
        Source1AlphaEXT = 0x8589,
        Src1Alpha = 0x8589,
        Src1AlphaEXT = 0x8589,
        Source2Alpha = 0x858A,
        Source2AlphaARB = 0x858A,
        Source2AlphaEXT = 0x858A,
        Src2Alpha = 0x858A,
        Source3AlphaNV = 0x858B,
        Operand0Rgb = 0x8590,
        Operand0RgbARB = 0x8590,
        Operand0RgbEXT = 0x8590,
        Operand1Rgb = 0x8591,
        Operand1RgbARB = 0x8591,
        Operand1RgbEXT = 0x8591,
        Operand2Rgb = 0x8592,
        Operand2RgbARB = 0x8592,
        Operand2RgbEXT = 0x8592,
        Operand3RgbNV = 0x8593,
        Operand0Alpha = 0x8598,
        Operand0AlphaARB = 0x8598,
        Operand0AlphaEXT = 0x8598,
        Operand1Alpha = 0x8599,
        Operand1AlphaARB = 0x8599,
        Operand1AlphaEXT = 0x8599,
        Operand2Alpha = 0x859A,
        Operand2AlphaARB = 0x859A,
        Operand2AlphaEXT = 0x859A,
        Operand3AlphaNV = 0x859B
    }

    public enum ShaderType
    {
        FragmentShader = 0x8B30,
        FragmentShaderARB = 0x8B30,
        VertexShader = 0x8B31,
        VertexShaderARB = 0x8B31
    }

    public enum ContainerType
    {
        ProgramObjectARB = 0x8B40,
        ProgramObjectEXT = 0x8B40
    }

    public enum AttributeType
    {
        FloatVec2 = 0x8B50,
        FloatVec2ARB = 0x8B50,
        FloatVec3 = 0x8B51,
        FloatVec3ARB = 0x8B51,
        FloatVec4 = 0x8B52,
        FloatVec4ARB = 0x8B52,
        IntVec2 = 0x8B53,
        IntVec2ARB = 0x8B53,
        IntVec3 = 0x8B54,
        IntVec3ARB = 0x8B54,
        IntVec4 = 0x8B55,
        IntVec4ARB = 0x8B55,
        Bool = 0x8B56,
        BoolARB = 0x8B56,
        BoolVec2 = 0x8B57,
        BoolVec2ARB = 0x8B57,
        BoolVec3 = 0x8B58,
        BoolVec3ARB = 0x8B58,
        BoolVec4 = 0x8B59,
        BoolVec4ARB = 0x8B59,
        FloatMat2 = 0x8B5A,
        FloatMat2ARB = 0x8B5A,
        FloatMat3 = 0x8B5B,
        FloatMat3ARB = 0x8B5B,
        FloatMat4 = 0x8B5C,
        FloatMat4ARB = 0x8B5C,
        Sampler1D = 0x8B5D,
        Sampler1DARB = 0x8B5D,
        Sampler2D = 0x8B5E,
        Sampler2DARB = 0x8B5E,
        Sampler3D = 0x8B5F,
        Sampler3DARB = 0x8B5F,
        Sampler3DOES = 0x8B5F,
        SamplerCube = 0x8B60,
        SamplerCubeARB = 0x8B60,
        Sampler1DShadow = 0x8B61,
        Sampler1DShadowARB = 0x8B61,
        Sampler2DShadow = 0x8B62,
        Sampler2DShadowARB = 0x8B62,
        Sampler2DShadowEXT = 0x8B62,
        Sampler2DRect = 0x8B63,
        Sampler2DRectARB = 0x8B63,
        Sampler2DRectShadow = 0x8B64,
        Sampler2DRectShadowARB = 0x8B64,
        FloatMat2x3 = 0x8B65,
        FloatMat2x3NV = 0x8B65,
        FloatMat2x4 = 0x8B66,
        FloatMat2x4NV = 0x8B66,
        FloatMat3x2 = 0x8B67,
        FloatMat3x2NV = 0x8B67,
        FloatMat3x4 = 0x8B68,
        FloatMat3x4NV = 0x8B68,
        FloatMat4x2 = 0x8B69,
        FloatMat4x2NV = 0x8B69,
        FloatMat4x3 = 0x8B6A,
        FloatMat4x3NV = 0x8B6A
    }
    public enum AccumOp
    {
        Accum = 0x0100,
        Load = 0x0101,
        Return = 0x0102,
        Mult = 0x0103,
        Add = 0x0104,
    }

    public enum AlphaFunction
    {
        Always = 0x0207,
        Equal = 0x0202,
        Gequal = 0x0206,
        Greater = 0x0204,
        Lequal = 0x0203,
        Less = 0x0201,
        Never = 0x0200,
        Notequal = 0x0205,
    }

    public enum BlendEquationModeEXT
    {
        AlphaMaxSGIX = 0x8321,
        AlphaMinSGIX = 0x8320,
        FuncAdd = 0x8006,
        FuncAddEXT = 0x8006,
        FuncReverseSubtract = 0x800B,
        FuncReverseSubtractEXT = 0x800B,
        FuncSubtract = 0x800A,
        FuncSubtractEXT = 0x800A,
        Max = 0x8008,
        MaxEXT = 0x8008,
        Min = 0x8007,
        MinEXT = 0x8007,
    }

    public enum Boolean
    {
        False = 0,
        True = 1,
    }

    public enum BufferTargetARB
    {
        ArrayBuffer = 0x8892,
        AtomicCounterBuffer = 0x92C0,
        CopyReadBuffer = 0x8F36,
        CopyWriteBuffer = 0x8F37,
        DispatchIndirectBuffer = 0x90EE,
        DrawIndirectBuffer = 0x8F3F,
        ElementArrayBuffer = 0x8893,
        PixelPackBuffer = 0x88EB,
        PixelUnpackBuffer = 0x88EC,
        QueryBuffer = 0x9192,
        ShaderStorageBuffer = 0x90D2,
        TextureBuffer = 0x8C2A,
        TransformFeedbackBuffer = 0x8C8E,
        UniformBuffer = 0x8A11,
        ParameterBuffer = 0x80EE,
    }

    public enum BufferUsageARB
    {
        StreamDraw = 0x88E0,
        StreamRead = 0x88E1,
        StreamCopy = 0x88E2,
        StaticDraw = 0x88E4,
        StaticRead = 0x88E5,
        StaticCopy = 0x88E6,
        DynamicDraw = 0x88E8,
        DynamicRead = 0x88E9,
        DynamicCopy = 0x88EA,
    }

    public enum BufferAccessARB
    {
        ReadOnly = 0x88B8,
        WriteOnly = 0x88B9,
        ReadWrite = 0x88BA,
    }

    public enum ClipPlaneName
    {
        ClipDistance0 = 0x3000,
        ClipDistance1 = 0x3001,
        ClipDistance2 = 0x3002,
        ClipDistance3 = 0x3003,
        ClipDistance4 = 0x3004,
        ClipDistance5 = 0x3005,
        ClipDistance6 = 0x3006,
        ClipDistance7 = 0x3007,
        ClipPlane0 = 0x3000,
        ClipPlane1 = 0x3001,
        ClipPlane2 = 0x3002,
        ClipPlane3 = 0x3003,
        ClipPlane4 = 0x3004,
        ClipPlane5 = 0x3005,
    }

    public enum ColorMaterialFace
    {
        Back = 0x0405,
        Front = 0x0404,
        FrontAndBack = 0x0408,
    }

    public enum ColorMaterialParameter
    {
        Ambient = 0x1200,
        AmbientAndDiffuse = 0x1602,
        Diffuse = 0x1201,
        Emission = 0x1600,
        Specular = 0x1202,
    }

    public enum ColorPointerType
    {
        Byte = 0x1400,
        Double = 0x140A,
        Float = 0x1406,
        Int = 0x1404,
        Short = 0x1402,
        UnsignedByte = 0x1401,
        UnsignedInt = 0x1405,
        UnsignedShort = 0x1403,
    }

    public enum ColorTableParameterPNameSGI
    {
        ColorTableBias = 0x80D7,
        ColorTableBiasSGI = 0x80D7,
        ColorTableScale = 0x80D6,
        ColorTableScaleSGI = 0x80D6,
    }

    public enum ColorTableTargetSGI
    {
        ColorTable = 0x80D0,
        ColorTableSGI = 0x80D0,
        PostColorMatrixColorTable = 0x80D2,
        PostColorMatrixColorTableSGI = 0x80D2,
        PostConvolutionColorTable = 0x80D1,
        PostConvolutionColorTableSGI = 0x80D1,
        ProxyColorTable = 0x80D3,
        ProxyColorTableSGI = 0x80D3,
        ProxyPostColorMatrixColorTable = 0x80D5,
        ProxyPostColorMatrixColorTableSGI = 0x80D5,
        ProxyPostConvolutionColorTable = 0x80D4,
        ProxyPostConvolutionColorTableSGI = 0x80D4,
        ProxyTextureColorTableSGI = 0x80BD,
        TextureColorTableSGI = 0x80BC,
    }

    public enum ConvolutionBorderModeEXT
    {
        Reduce = 0x8016,
        ReduceEXT = 0x8016,
    }

    public enum ConvolutionParameterEXT
    {
        ConvolutionBorderMode = 0x8013,
        ConvolutionBorderModeEXT = 0x8013,
        ConvolutionFilterBias = 0x8015,
        ConvolutionFilterBiasEXT = 0x8015,
        ConvolutionFilterScale = 0x8014,
        ConvolutionFilterScaleEXT = 0x8014,
    }

    public enum ConvolutionTargetEXT
    {
        Convolution1D = 0x8010,
        Convolution1DEXT = 0x8010,
        Convolution2D = 0x8011,
        Convolution2DEXT = 0x8011,
    }

    public enum CullFaceMode
    {
        Back = 0x0405,
        Front = 0x0404,
        FrontAndBack = 0x0408,
    }

    public enum DataType
    {
    }

    public enum DepthFunction
    {
        Always = 0x0207,
        Equal = 0x0202,
        Gequal = 0x0206,
        Greater = 0x0204,
        Lequal = 0x0203,
        Less = 0x0201,
        Never = 0x0200,
        Notequal = 0x0205,
    }

    public enum DrawBufferMode
    {
        Aux0 = 0x0409,
        Aux1 = 0x040A,
        Aux2 = 0x040B,
        Aux3 = 0x040C,
        Back = 0x0405,
        BackLeft = 0x0402,
        BackRight = 0x0403,
        Front = 0x0404,
        FrontAndBack = 0x0408,
        FrontLeft = 0x0400,
        FrontRight = 0x0401,
        Left = 0x0406,
        None = 0,
        NoneOES = 0,
        Right = 0x0407,
    }

    public enum DrawElementsType
    {
        UnsignedByte = 0x1401,
        UnsignedShort = 0x1403,
        UnsignedInt = 0x1405,
    }

    public enum EnableCap
    {
        AlphaTest = 0x0BC0,
        AsyncDrawPixelsSGIX = 0x835D,
        AsyncHistogramSGIX = 0x832C,
        AsyncReadPixelsSGIX = 0x835E,
        AsyncTexImageSGIX = 0x835C,
        AutoNormal = 0x0D80,
        Blend = 0x0BE2,
        CalligraphicFragmentSGIX = 0x8183,
        ClipPlane0 = 0x3000,
        ClipPlane1 = 0x3001,
        ClipPlane2 = 0x3002,
        ClipPlane3 = 0x3003,
        ClipPlane4 = 0x3004,
        ClipPlane5 = 0x3005,
        ColorArray = 0x8076,
        ColorLogicOp = 0x0BF2,
        ColorMaterial = 0x0B57,
        ColorTableSGI = 0x80D0,
        Convolution1DEXT = 0x8010,
        Convolution2DEXT = 0x8011,
        CullFace = 0x0B44,
        DebugOutput = 0x92E0,
        DebugOutputSynchronous = 0x8242,
        DepthClamp = 0x864F,
        DepthTest = 0x0B71,
        Dither = 0x0BD0,
        EdgeFlagArray = 0x8079,
        Fog = 0x0B60,
        FogOffsetSGIX = 0x8198,
        FragmentColorMaterialSGIX = 0x8401,
        FragmentLight0SGIX = 0x840C,
        FragmentLight1SGIX = 0x840D,
        FragmentLight2SGIX = 0x840E,
        FragmentLight3SGIX = 0x840F,
        FragmentLight4SGIX = 0x8410,
        FragmentLight5SGIX = 0x8411,
        FragmentLight6SGIX = 0x8412,
        FragmentLight7SGIX = 0x8413,
        FragmentLightingSGIX = 0x8400,
        FramebufferSrgb = 0x8DB9,
        FramezoomSGIX = 0x818B,
        HistogramEXT = 0x8024,
        IndexArray = 0x8077,
        IndexLogicOp = 0x0BF1,
        InterlaceSGIX = 0x8094,
        IrInstrument1SGIX = 0x817F,
        Light0 = 0x4000,
        Light1 = 0x4001,
        Light2 = 0x4002,
        Light3 = 0x4003,
        Light4 = 0x4004,
        Light5 = 0x4005,
        Light6 = 0x4006,
        Light7 = 0x4007,
        Lighting = 0x0B50,
        LineSmooth = 0x0B20,
        LineStipple = 0x0B24,
        Map1Color4 = 0x0D90,
        Map1Index = 0x0D91,
        Map1Normal = 0x0D92,
        Map1TextureCoord1 = 0x0D93,
        Map1TextureCoord2 = 0x0D94,
        Map1TextureCoord3 = 0x0D95,
        Map1TextureCoord4 = 0x0D96,
        Map1Vertex3 = 0x0D97,
        Map1Vertex4 = 0x0D98,
        Map2Color4 = 0x0DB0,
        Map2Index = 0x0DB1,
        Map2Normal = 0x0DB2,
        Map2TextureCoord1 = 0x0DB3,
        Map2TextureCoord2 = 0x0DB4,
        Map2TextureCoord3 = 0x0DB5,
        Map2TextureCoord4 = 0x0DB6,
        Map2Vertex3 = 0x0DB7,
        Map2Vertex4 = 0x0DB8,
        MinmaxEXT = 0x802E,
        Multisample = 0x809D,
        MultisampleSgis = 0x809D,
        Normalize = 0x0BA1,
        NormalArray = 0x8075,
        PixelTextureSgis = 0x8353,
        PixelTexGenSGIX = 0x8139,
        PointSmooth = 0x0B10,
        PolygonOffsetFill = 0x8037,
        PolygonOffsetLine = 0x2A02,
        PolygonOffsetPoint = 0x2A01,
        PolygonSmooth = 0x0B41,
        PolygonStipple = 0x0B42,
        PostColorMatrixColorTableSGI = 0x80D2,
        PostConvolutionColorTableSGI = 0x80D1,
        PrimitiveRestart = 0x8F9D,
        PrimitiveRestartFixedIndex = 0x8D69,
        ProgramPointSize = 0x8642,
        RasterizerDiscard = 0x8C89,
        ReferencePlaneSGIX = 0x817D,
        RescaleNormalEXT = 0x803A,
        SampleAlphaToCoverage = 0x809E,
        SampleAlphaToMaskSgis = 0x809E,
        SampleAlphaToOne = 0x809F,
        SampleAlphaToOneSgis = 0x809F,
        SampleCoverage = 0x80A0,
        SampleMask = 0x8E51,
        SampleMaskSgis = 0x80A0,
        SampleShading = 0x8C36,
        ScissorTest = 0x0C11,
        Separable2DEXT = 0x8012,
        SharedTexturePaletteEXT = 0x81FB,
        SpriteSGIX = 0x8148,
        StencilTest = 0x0B90,
        Texture1D = 0x0DE0,
        Texture2D = 0x0DE1,
        Texture3DEXT = 0x806F,
        Texture4dSgis = 0x8134,
        TextureColorTableSGI = 0x80BC,
        TextureCoordArray = 0x8078,
        TextureCubeMapSeamless = 0x884F,
        TextureGenQ = 0x0C63,
        TextureGenR = 0x0C62,
        TextureGenS = 0x0C60,
        TextureGenT = 0x0C61,
        VertexArray = 0x8074,
    }

    public enum ErrorCode
    {
        InvalidEnum = 0x0500,
        InvalidFramebufferOperation = 0x0506,
        InvalidFramebufferOperationEXT = 0x0506,
        InvalidFramebufferOperationOES = 0x0506,
        InvalidOperation = 0x0502,
        InvalidValue = 0x0501,
        NoError = 0,
        OutOfMemory = 0x0505,
        StackOverflow = 0x0503,
        StackUnderflow = 0x0504,
        TableTooLarge = 0x8031,
        TableTooLargeEXT = 0x8031,
        TextureTooLargeEXT = 0x8065,
    }

    public enum ExternalHandleType
    {
        HandleTypeOpaqueFdEXT = 0x9586,
        HandleTypeOpaqueWin32EXT = 0x9587,
        HandleTypeOpaqueWin32KmtEXT = 0x9588,
        HandleTypeD3d12TilepoolEXT = 0x9589,
        HandleTypeD3d12ResourceEXT = 0x958A,
        HandleTypeD3d11ImageEXT = 0x958B,
        HandleTypeD3d11ImageKmtEXT = 0x958C,
        HandleTypeD3d12FenceEXT = 0x9594,
    }

    public enum FeedbackType
    {
        2D = 0x0600,
        3D = 0x0601,
        3DColor = 0x0602,
        3DColorTexture = 0x0603,
        4dColorTexture = 0x0604,
    }

    public enum FeedBackToken
    {
        BitmapToken = 0x0704,
        CopyPixelToken = 0x0706,
        DrawPixelToken = 0x0705,
        LineResetToken = 0x0707,
        LineToken = 0x0702,
        PassThroughToken = 0x0700,
        PointToken = 0x0701,
        PolygonToken = 0x0703,
    }

    public enum FfdTargetSGIX
    {
        GeometryDeformationSGIX = 0x8194,
        TextureDeformationSGIX = 0x8195,
    }

    public enum FogCoordinatePointerType
    {
        Float = 0x1406,
        Double = 0x140A,
    }

    public enum FogMode
    {
        Exp = 0x0800,
        Exp2 = 0x0801,
        FogFuncSgis = 0x812A,
        Linear = 0x2601,
    }

    public enum FogParameter
    {
        FogColor = 0x0B66,
        FogDensity = 0x0B62,
        FogEnd = 0x0B64,
        FogIndex = 0x0B61,
        FogMode = 0x0B65,
        FogOffsetValueSGIX = 0x8199,
        FogStart = 0x0B63,
    }

    public enum FogPointerTypeEXT
    {
        Float = 0x1406,
        Double = 0x140A,
    }

    public enum FogPointerTypeIBM
    {
        Float = 0x1406,
        Double = 0x140A,
    }

    public enum FragmentLightModelParameterSGIX
    {
        FragmentLightModelAmbientSGIX = 0x840A,
        FragmentLightModelLocalViewerSGIX = 0x8408,
        FragmentLightModelNormalInterpolationSGIX = 0x840B,
        FragmentLightModelTwoSideSGIX = 0x8409,
    }

    public enum FramebufferFetchNoncoherent
    {
        FramebufferFetchNoncoherentQCOM = 0x96A2,
    }

    public enum FrontFaceDirection
    {
        Ccw = 0x0901,
        Cw = 0x0900,
    }

    public enum GetColorTableParameterPNameSGI
    {
        ColorTableAlphaSizeSGI = 0x80DD,
        ColorTableBiasSGI = 0x80D7,
        ColorTableBlueSizeSGI = 0x80DC,
        ColorTableFormatSGI = 0x80D8,
        ColorTableGreenSizeSGI = 0x80DB,
        ColorTableIntensitySizeSGI = 0x80DF,
        ColorTableLuminanceSizeSGI = 0x80DE,
        ColorTableRedSizeSGI = 0x80DA,
        ColorTableScaleSGI = 0x80D6,
        ColorTableWidthSGI = 0x80D9,
        ColorTableBias = 0x80D7,
        ColorTableScale = 0x80D6,
        ColorTableFormat = 0x80D8,
        ColorTableWidth = 0x80D9,
        ColorTableRedSize = 0x80DA,
        ColorTableGreenSize = 0x80DB,
        ColorTableBlueSize = 0x80DC,
        ColorTableAlphaSize = 0x80DD,
        ColorTableLuminanceSize = 0x80DE,
        ColorTableIntensitySize = 0x80DF,
    }

    public enum GetConvolutionParameter
    {
        ConvolutionBorderModeEXT = 0x8013,
        ConvolutionFilterBiasEXT = 0x8015,
        ConvolutionFilterScaleEXT = 0x8014,
        ConvolutionFormatEXT = 0x8017,
        ConvolutionHeightEXT = 0x8019,
        ConvolutionWidthEXT = 0x8018,
        MaxConvolutionHeightEXT = 0x801B,
        MaxConvolutionWidthEXT = 0x801A,
        ConvolutionBorderMode = 0x8013,
        ConvolutionBorderColor = 0x8154,
        ConvolutionFilterScale = 0x8014,
        ConvolutionFilterBias = 0x8015,
        ConvolutionFormat = 0x8017,
        ConvolutionWidth = 0x8018,
        ConvolutionHeight = 0x8019,
        MaxConvolutionWidth = 0x801A,
        MaxConvolutionHeight = 0x801B,
    }

    public enum GetHistogramParameterPNameEXT
    {
        HistogramAlphaSizeEXT = 0x802B,
        HistogramBlueSizeEXT = 0x802A,
        HistogramFormatEXT = 0x8027,
        HistogramGreenSizeEXT = 0x8029,
        HistogramLuminanceSizeEXT = 0x802C,
        HistogramRedSizeEXT = 0x8028,
        HistogramSinkEXT = 0x802D,
        HistogramWidthEXT = 0x8026,
        HistogramWidth = 0x8026,
        HistogramFormat = 0x8027,
        HistogramRedSize = 0x8028,
        HistogramGreenSize = 0x8029,
        HistogramBlueSize = 0x802A,
        HistogramAlphaSize = 0x802B,
        HistogramLuminanceSize = 0x802C,
        HistogramSink = 0x802D,
        HistogramAlphaSizeEXT = 0x802B,
        HistogramBlueSizeEXT = 0x802A,
        HistogramFormatEXT = 0x8027,
        HistogramGreenSizeEXT = 0x8029,
        HistogramLuminanceSizeEXT = 0x802C,
        HistogramRedSizeEXT = 0x8028,
        HistogramSinkEXT = 0x802D,
        HistogramWidthEXT = 0x8026,
    }

    public enum GetMapQuery
    {
        Coeff = 0x0A00,
        Domain = 0x0A02,
        Order = 0x0A01,
    }

    public enum GetMinmaxParameterPNameEXT
    {
        MinmaxFormat = 0x802F,
        MinmaxFormatEXT = 0x802F,
        MinmaxSink = 0x8030,
        MinmaxSinkEXT = 0x8030,
        MinmaxFormat = 0x802F,
        MinmaxSink = 0x8030,
    }

    public enum GetPixelMap
    {
        PixelMapAToA = 0x0C79,
        PixelMapBToB = 0x0C78,
        PixelMapGToG = 0x0C77,
        PixelMapIToA = 0x0C75,
        PixelMapIToB = 0x0C74,
        PixelMapIToG = 0x0C73,
        PixelMapIToI = 0x0C70,
        PixelMapIToR = 0x0C72,
        PixelMapRToR = 0x0C76,
        PixelMapSToS = 0x0C71,
    }

    public enum GetPName
    {
        AccumAlphaBits = 0x0D5B,
        AccumBlueBits = 0x0D5A,
        AccumClearValue = 0x0B80,
        AccumGreenBits = 0x0D59,
        AccumRedBits = 0x0D58,
        ActiveTexture = 0x84E0,
        AliasedLineWidthRange = 0x846E,
        AliasedPointSizeRange = 0x846D,
        AlphaBias = 0x0D1D,
        AlphaBits = 0x0D55,
        AlphaScale = 0x0D1C,
        AlphaTest = 0x0BC0,
        AlphaTestFunc = 0x0BC1,
        AlphaTestFuncQCOM = 0x0BC1,
        AlphaTestQCOM = 0x0BC0,
        AlphaTestRef = 0x0BC2,
        AlphaTestRefQCOM = 0x0BC2,
        ArrayBufferBinding = 0x8894,
        AsyncDrawPixelsSGIX = 0x835D,
        AsyncHistogramSGIX = 0x832C,
        AsyncMarkerSGIX = 0x8329,
        AsyncReadPixelsSGIX = 0x835E,
        AsyncTexImageSGIX = 0x835C,
        AttribStackDepth = 0x0BB0,
        AutoNormal = 0x0D80,
        AuxBuffers = 0x0C00,
        Blend = 0x0BE2,
        BlendColor = 0x8005,
        BlendColorEXT = 0x8005,
        BlendDst = 0x0BE0,
        BlendDstAlpha = 0x80CA,
        BlendDstRgb = 0x80C8,
        BlendEquationAlpha = 0x883D,
        BlendEquationEXT = 0x8009,
        BlendEquationRgb = 0x8009,
        BlendSrc = 0x0BE1,
        BlendSrcAlpha = 0x80CB,
        BlendSrcRgb = 0x80C9,
        BlueBias = 0x0D1B,
        BlueBits = 0x0D54,
        BlueScale = 0x0D1A,
        CalligraphicFragmentSGIX = 0x8183,
        ClientAttribStackDepth = 0x0BB1,
        ClipPlane0 = 0x3000,
        ClipPlane1 = 0x3001,
        ClipPlane2 = 0x3002,
        ClipPlane3 = 0x3003,
        ClipPlane4 = 0x3004,
        ClipPlane5 = 0x3005,
        ColorArray = 0x8076,
        ColorArrayCountEXT = 0x8084,
        ColorArraySize = 0x8081,
        ColorArrayStride = 0x8083,
        ColorArrayType = 0x8082,
        ColorClearValue = 0x0C22,
        ColorLogicOp = 0x0BF2,
        ColorMaterial = 0x0B57,
        ColorMaterialFace = 0x0B55,
        ColorMaterialParameter = 0x0B56,
        ColorMatrixSGI = 0x80B1,
        ColorMatrixStackDepthSGI = 0x80B2,
        ColorTableSGI = 0x80D0,
        ColorWritemask = 0x0C23,
        CompressedTextureFormats = 0x86A3,
        ContextFlags = 0x821E,
        Convolution1DEXT = 0x8010,
        Convolution2DEXT = 0x8011,
        ConvolutionHintSGIX = 0x8316,
        CullFace = 0x0B44,
        CullFaceMode = 0x0B45,
        CurrentColor = 0x0B00,
        CurrentIndex = 0x0B01,
        CurrentNormal = 0x0B02,
        CurrentProgram = 0x8B8D,
        CurrentRasterColor = 0x0B04,
        CurrentRasterDistance = 0x0B09,
        CurrentRasterIndex = 0x0B05,
        CurrentRasterPosition = 0x0B07,
        CurrentRasterPositionValid = 0x0B08,
        CurrentRasterTextureCoords = 0x0B06,
        CurrentTextureCoords = 0x0B03,
        DebugGroupStackDepth = 0x826D,
        DeformationsMaskSGIX = 0x8196,
        DepthBias = 0x0D1F,
        DepthBits = 0x0D56,
        DepthClearValue = 0x0B73,
        DepthFunc = 0x0B74,
        DepthRange = 0x0B70,
        DepthScale = 0x0D1E,
        DepthTest = 0x0B71,
        DepthWritemask = 0x0B72,
        DetailTexture2DBindingSgis = 0x8096,
        DeviceLuidEXT = 0x9599,
        DeviceNodeMaskEXT = 0x959A,
        DeviceUuidEXT = 0x9597,
        DispatchIndirectBufferBinding = 0x90EF,
        DistanceAttenuationSgis = 0x8129,
        Dither = 0x0BD0,
        Doublebuffer = 0x0C32,
        DrawBuffer = 0x0C01,
        DrawBufferEXT = 0x0C01,
        DrawFramebufferBinding = 0x8CA6,
        DriverUuidEXT = 0x9598,
        EdgeFlag = 0x0B43,
        EdgeFlagArray = 0x8079,
        EdgeFlagArrayCountEXT = 0x808D,
        EdgeFlagArrayStride = 0x808C,
        ElementArrayBufferBinding = 0x8895,
        FeedbackBufferSize = 0x0DF1,
        FeedbackBufferType = 0x0DF2,
        Fog = 0x0B60,
        FogColor = 0x0B66,
        FogDensity = 0x0B62,
        FogEnd = 0x0B64,
        FogFuncPointsSgis = 0x812B,
        FogHint = 0x0C54,
        FogIndex = 0x0B61,
        FogMode = 0x0B65,
        FogOffsetSGIX = 0x8198,
        FogOffsetValueSGIX = 0x8199,
        FogStart = 0x0B63,
        FragmentColorMaterialFaceSGIX = 0x8402,
        FragmentColorMaterialParameterSGIX = 0x8403,
        FragmentColorMaterialSGIX = 0x8401,
        FragmentLight0SGIX = 0x840C,
        FragmentLightingSGIX = 0x8400,
        FragmentLightModelAmbientSGIX = 0x840A,
        FragmentLightModelLocalViewerSGIX = 0x8408,
        FragmentLightModelNormalInterpolationSGIX = 0x840B,
        FragmentLightModelTwoSideSGIX = 0x8409,
        FragmentShaderDerivativeHint = 0x8B8B,
        FramezoomFactorSGIX = 0x818C,
        FramezoomSGIX = 0x818B,
        FrontFace = 0x0B46,
        GenerateMipmapHintSgis = 0x8192,
        GreenBias = 0x0D19,
        GreenBits = 0x0D53,
        GreenScale = 0x0D18,
        HistogramEXT = 0x8024,
        ImplementationColorReadFormat = 0x8B9B,
        ImplementationColorReadType = 0x8B9A,
        IndexArray = 0x8077,
        IndexArrayCountEXT = 0x8087,
        IndexArrayStride = 0x8086,
        IndexArrayType = 0x8085,
        IndexBits = 0x0D51,
        IndexClearValue = 0x0C20,
        IndexLogicOp = 0x0BF1,
        IndexMode = 0x0C30,
        IndexOffset = 0x0D13,
        IndexShift = 0x0D12,
        IndexWritemask = 0x0C21,
        InstrumentMeasurementsSGIX = 0x8181,
        InterlaceSGIX = 0x8094,
        IrInstrument1SGIX = 0x817F,
        LayerProvokingVertex = 0x825E,
        Light0 = 0x4000,
        Light1 = 0x4001,
        Light2 = 0x4002,
        Light3 = 0x4003,
        Light4 = 0x4004,
        Light5 = 0x4005,
        Light6 = 0x4006,
        Light7 = 0x4007,
        Lighting = 0x0B50,
        LightEnvModeSGIX = 0x8407,
        LightModelAmbient = 0x0B53,
        LightModelColorControl = 0x81F8,
        LightModelLocalViewer = 0x0B51,
        LightModelTwoSide = 0x0B52,
        LineSmooth = 0x0B20,
        LineSmoothHint = 0x0C52,
        LineStipple = 0x0B24,
        LineStipplePattern = 0x0B25,
        LineStippleRepeat = 0x0B26,
        LineWidth = 0x0B21,
        LineWidthGranularity = 0x0B23,
        LineWidthRange = 0x0B22,
        ListBase = 0x0B32,
        ListIndex = 0x0B33,
        ListMode = 0x0B30,
        LogicOp = 0x0BF1,
        LogicOpMode = 0x0BF0,
        MajorVersion = 0x821B,
        Map1Color4 = 0x0D90,
        Map1GridDomain = 0x0DD0,
        Map1GridSegments = 0x0DD1,
        Map1Index = 0x0D91,
        Map1Normal = 0x0D92,
        Map1TextureCoord1 = 0x0D93,
        Map1TextureCoord2 = 0x0D94,
        Map1TextureCoord3 = 0x0D95,
        Map1TextureCoord4 = 0x0D96,
        Map1Vertex3 = 0x0D97,
        Map1Vertex4 = 0x0D98,
        Map2Color4 = 0x0DB0,
        Map2GridDomain = 0x0DD2,
        Map2GridSegments = 0x0DD3,
        Map2Index = 0x0DB1,
        Map2Normal = 0x0DB2,
        Map2TextureCoord1 = 0x0DB3,
        Map2TextureCoord2 = 0x0DB4,
        Map2TextureCoord3 = 0x0DB5,
        Map2TextureCoord4 = 0x0DB6,
        Map2Vertex3 = 0x0DB7,
        Map2Vertex4 = 0x0DB8,
        MapColor = 0x0D10,
        MapStencil = 0x0D11,
        MatrixMode = 0x0BA0,
        Max3DTextureSize = 0x8073,
        Max3DTextureSizeEXT = 0x8073,
        Max4dTextureSizeSgis = 0x8138,
        MaxActiveLightsSGIX = 0x8405,
        MaxArrayTextureLayers = 0x88FF,
        MaxAsyncDrawPixelsSGIX = 0x8360,
        MaxAsyncHistogramSGIX = 0x832D,
        MaxAsyncReadPixelsSGIX = 0x8361,
        MaxAsyncTexImageSGIX = 0x835F,
        MaxAttribStackDepth = 0x0D35,
        MaxClientAttribStackDepth = 0x0D3B,
        MaxClipmapDepthSGIX = 0x8177,
        MaxClipmapVirtualDepthSGIX = 0x8178,
        MaxClipDistances = 0x0D32,
        MaxClipPlanes = 0x0D32,
        MaxColorMatrixStackDepthSGI = 0x80B3,
        MaxColorTextureSamples = 0x910E,
        MaxCombinedAtomicCounters = 0x92D7,
        MaxCombinedComputeUniformComponents = 0x8266,
        MaxCombinedFragmentUniformComponents = 0x8A33,
        MaxCombinedGeometryUniformComponents = 0x8A32,
        MaxCombinedShaderStorageBlocks = 0x90DC,
        MaxCombinedTextureImageUnits = 0x8B4D,
        MaxCombinedUniformBlocks = 0x8A2E,
        MaxCombinedVertexUniformComponents = 0x8A31,
        MaxComputeAtomicCounters = 0x8265,
        MaxComputeAtomicCounterBuffers = 0x8264,
        MaxComputeShaderStorageBlocks = 0x90DB,
        MaxComputeTextureImageUnits = 0x91BC,
        MaxComputeUniformBlocks = 0x91BB,
        MaxComputeUniformComponents = 0x8263,
        MaxComputeWorkGroupCount = 0x91BE,
        MaxComputeWorkGroupInvocations = 0x90EB,
        MaxComputeWorkGroupSize = 0x91BF,
        MaxCubeMapTextureSize = 0x851C,
        MaxDebugGroupStackDepth = 0x826C,
        MaxDepthTextureSamples = 0x910F,
        MaxDrawBuffers = 0x8824,
        MaxDualSourceDrawBuffers = 0x88FC,
        MaxElementsIndices = 0x80E9,
        MaxElementsVertices = 0x80E8,
        MaxElementIndex = 0x8D6B,
        MaxEvalOrder = 0x0D30,
        MaxFogFuncPointsSgis = 0x812C,
        MaxFragmentAtomicCounters = 0x92D6,
        MaxFragmentInputComponents = 0x9125,
        MaxFragmentLightsSGIX = 0x8404,
        MaxFragmentShaderStorageBlocks = 0x90DA,
        MaxFragmentUniformBlocks = 0x8A2D,
        MaxFragmentUniformComponents = 0x8B49,
        MaxFragmentUniformVectors = 0x8DFD,
        MaxFramebufferHeight = 0x9316,
        MaxFramebufferLayers = 0x9317,
        MaxFramebufferSamples = 0x9318,
        MaxFramebufferWidth = 0x9315,
        MaxFramezoomFactorSGIX = 0x818D,
        MaxGeometryAtomicCounters = 0x92D5,
        MaxGeometryInputComponents = 0x9123,
        MaxGeometryOutputComponents = 0x9124,
        MaxGeometryShaderStorageBlocks = 0x90D7,
        MaxGeometryTextureImageUnits = 0x8C29,
        MaxGeometryUniformBlocks = 0x8A2C,
        MaxGeometryUniformComponents = 0x8DDF,
        MaxIntegerSamples = 0x9110,
        MaxLabelLength = 0x82E8,
        MaxLights = 0x0D31,
        MaxListNesting = 0x0B31,
        MaxModelviewStackDepth = 0x0D36,
        MaxNameStackDepth = 0x0D37,
        MaxPixelMapTable = 0x0D34,
        MaxProgramTexelOffset = 0x8905,
        MaxProjectionStackDepth = 0x0D38,
        MaxRectangleTextureSize = 0x84F8,
        MaxRenderbufferSize = 0x84E8,
        MaxSampleMaskWords = 0x8E59,
        MaxServerWaitTimeout = 0x9111,
        MaxShaderStorageBufferBindings = 0x90DD,
        MaxTessControlAtomicCounters = 0x92D3,
        MaxTessControlShaderStorageBlocks = 0x90D8,
        MaxTessEvaluationAtomicCounters = 0x92D4,
        MaxTessEvaluationShaderStorageBlocks = 0x90D9,
        MaxTextureBufferSize = 0x8C2B,
        MaxTextureImageUnits = 0x8872,
        MaxTextureLodBias = 0x84FD,
        MaxTextureSize = 0x0D33,
        MaxTextureStackDepth = 0x0D39,
        MaxUniformBlockSize = 0x8A30,
        MaxUniformBufferBindings = 0x8A2F,
        MaxUniformLocations = 0x826E,
        MaxVaryingComponents = 0x8B4B,
        MaxVaryingFloats = 0x8B4B,
        MaxVaryingVectors = 0x8DFC,
        MaxVertexAtomicCounters = 0x92D2,
        MaxVertexAttribs = 0x8869,
        MaxVertexAttribBindings = 0x82DA,
        MaxVertexAttribRelativeOffset = 0x82D9,
        MaxVertexOutputComponents = 0x9122,
        MaxVertexShaderStorageBlocks = 0x90D6,
        MaxVertexTextureImageUnits = 0x8B4C,
        MaxVertexUniformBlocks = 0x8A2B,
        MaxVertexUniformComponents = 0x8B4A,
        MaxVertexUniformVectors = 0x8DFB,
        MaxViewports = 0x825B,
        MaxViewportDims = 0x0D3A,
        MinmaxEXT = 0x802E,
        MinorVersion = 0x821C,
        MinMapBufferAlignment = 0x90BC,
        MinProgramTexelOffset = 0x8904,
        Modelview0MatrixEXT = 0x0BA6,
        Modelview0StackDepthEXT = 0x0BA3,
        ModelviewMatrix = 0x0BA6,
        ModelviewStackDepth = 0x0BA3,
        MultisampleSgis = 0x809D,
        NameStackDepth = 0x0D70,
        Normalize = 0x0BA1,
        NormalArray = 0x8075,
        NormalArrayCountEXT = 0x8080,
        NormalArrayStride = 0x807F,
        NormalArrayType = 0x807E,
        NumCompressedTextureFormats = 0x86A2,
        NumDeviceUuidsEXT = 0x9596,
        NumExtensions = 0x821D,
        NumProgramBinaryFormats = 0x87FE,
        NumShaderBinaryFormats = 0x8DF9,
        PackAlignment = 0x0D05,
        PackCmykHintEXT = 0x800E,
        PackImageDepthSgis = 0x8131,
        PackImageHeight = 0x806C,
        PackImageHeightEXT = 0x806C,
        PackLsbFirst = 0x0D01,
        PackResampleSGIX = 0x842E,
        PackRowLength = 0x0D02,
        PackSkipImages = 0x806B,
        PackSkipImagesEXT = 0x806B,
        PackSkipPixels = 0x0D04,
        PackSkipRows = 0x0D03,
        PackSkipVolumesSgis = 0x8130,
        PackSubsampleRateSGIX = 0x85A0,
        PackSwapBytes = 0x0D00,
        PerspectiveCorrectionHint = 0x0C50,
        PixelMapAToASize = 0x0CB9,
        PixelMapBToBSize = 0x0CB8,
        PixelMapGToGSize = 0x0CB7,
        PixelMapIToASize = 0x0CB5,
        PixelMapIToBSize = 0x0CB4,
        PixelMapIToGSize = 0x0CB3,
        PixelMapIToISize = 0x0CB0,
        PixelMapIToRSize = 0x0CB2,
        PixelMapRToRSize = 0x0CB6,
        PixelMapSToSSize = 0x0CB1,
        PixelPackBufferBinding = 0x88ED,
        PixelTextureSgis = 0x8353,
        PixelTexGenModeSGIX = 0x832B,
        PixelTexGenSGIX = 0x8139,
        PixelTileBestAlignmentSGIX = 0x813E,
        PixelTileCacheIncrementSGIX = 0x813F,
        PixelTileCacheSizeSGIX = 0x8145,
        PixelTileGridDepthSGIX = 0x8144,
        PixelTileGridHeightSGIX = 0x8143,
        PixelTileGridWidthSGIX = 0x8142,
        PixelTileHeightSGIX = 0x8141,
        PixelTileWidthSGIX = 0x8140,
        PixelUnpackBufferBinding = 0x88EF,
        PointFadeThresholdSize = 0x8128,
        PointFadeThresholdSizeSgis = 0x8128,
        PointSize = 0x0B11,
        PointSizeGranularity = 0x0B13,
        PointSizeMaxSgis = 0x8127,
        PointSizeMinSgis = 0x8126,
        PointSizeRange = 0x0B12,
        PointSmooth = 0x0B10,
        PointSmoothHint = 0x0C51,
        PolygonMode = 0x0B40,
        PolygonOffsetBiasEXT = 0x8039,
        PolygonOffsetFactor = 0x8038,
        PolygonOffsetFill = 0x8037,
        PolygonOffsetLine = 0x2A02,
        PolygonOffsetPoint = 0x2A01,
        PolygonOffsetUnits = 0x2A00,
        PolygonSmooth = 0x0B41,
        PolygonSmoothHint = 0x0C53,
        PolygonStipple = 0x0B42,
        PostColorMatrixAlphaBiasSGI = 0x80BB,
        PostColorMatrixAlphaScaleSGI = 0x80B7,
        PostColorMatrixBlueBiasSGI = 0x80BA,
        PostColorMatrixBlueScaleSGI = 0x80B6,
        PostColorMatrixColorTableSGI = 0x80D2,
        PostColorMatrixGreenBiasSGI = 0x80B9,
        PostColorMatrixGreenScaleSGI = 0x80B5,
        PostColorMatrixRedBiasSGI = 0x80B8,
        PostColorMatrixRedScaleSGI = 0x80B4,
        PostConvolutionAlphaBiasEXT = 0x8023,
        PostConvolutionAlphaScaleEXT = 0x801F,
        PostConvolutionBlueBiasEXT = 0x8022,
        PostConvolutionBlueScaleEXT = 0x801E,
        PostConvolutionColorTableSGI = 0x80D1,
        PostConvolutionGreenBiasEXT = 0x8021,
        PostConvolutionGreenScaleEXT = 0x801D,
        PostConvolutionRedBiasEXT = 0x8020,
        PostConvolutionRedScaleEXT = 0x801C,
        PostTextureFilterBiasRangeSGIX = 0x817B,
        PostTextureFilterScaleRangeSGIX = 0x817C,
        PrimitiveRestartIndex = 0x8F9E,
        ProgramBinaryFormats = 0x87FF,
        ProgramPipelineBinding = 0x825A,
        ProgramPointSize = 0x8642,
        ProjectionMatrix = 0x0BA7,
        ProjectionStackDepth = 0x0BA4,
        ProvokingVertex = 0x8E4F,
        ReadBuffer = 0x0C02,
        ReadBufferEXT = 0x0C02,
        ReadBufferNV = 0x0C02,
        ReadFramebufferBinding = 0x8CAA,
        RedBias = 0x0D15,
        RedBits = 0x0D52,
        RedScale = 0x0D14,
        ReferencePlaneEquationSGIX = 0x817E,
        ReferencePlaneSGIX = 0x817D,
        RenderbufferBinding = 0x8CA7,
        RenderMode = 0x0C40,
        RescaleNormalEXT = 0x803A,
        RgbaMode = 0x0C31,
        SamplerBinding = 0x8919,
        Samples = 0x80A9,
        SamplesSgis = 0x80A9,
        SampleAlphaToMaskSgis = 0x809E,
        SampleAlphaToOneSgis = 0x809F,
        SampleBuffers = 0x80A8,
        SampleBuffersSgis = 0x80A8,
        SampleCoverageInvert = 0x80AB,
        SampleCoverageValue = 0x80AA,
        SampleMaskInvertSgis = 0x80AB,
        SampleMaskSgis = 0x80A0,
        SampleMaskValueSgis = 0x80AA,
        SamplePatternSgis = 0x80AC,
        ScissorBox = 0x0C10,
        ScissorTest = 0x0C11,
        SelectionBufferSize = 0x0DF4,
        Separable2DEXT = 0x8012,
        ShaderCompiler = 0x8DFA,
        ShaderStorageBufferBinding = 0x90D3,
        ShaderStorageBufferOffsetAlignment = 0x90DF,
        ShaderStorageBufferSize = 0x90D5,
        ShaderStorageBufferStart = 0x90D4,
        ShadeModel = 0x0B54,
        SharedTexturePaletteEXT = 0x81FB,
        SmoothLineWidthGranularity = 0x0B23,
        SmoothLineWidthRange = 0x0B22,
        SmoothPointSizeGranularity = 0x0B13,
        SmoothPointSizeRange = 0x0B12,
        SpriteAxisSGIX = 0x814A,
        SpriteModeSGIX = 0x8149,
        SpriteSGIX = 0x8148,
        SpriteTranslationSGIX = 0x814B,
        StencilBackFail = 0x8801,
        StencilBackFunc = 0x8800,
        StencilBackPassDepthFail = 0x8802,
        StencilBackPassDepthPass = 0x8803,
        StencilBackRef = 0x8CA3,
        StencilBackValueMask = 0x8CA4,
        StencilBackWritemask = 0x8CA5,
        StencilBits = 0x0D57,
        StencilClearValue = 0x0B91,
        StencilFail = 0x0B94,
        StencilFunc = 0x0B92,
        StencilPassDepthFail = 0x0B95,
        StencilPassDepthPass = 0x0B96,
        StencilRef = 0x0B97,
        StencilTest = 0x0B90,
        StencilValueMask = 0x0B93,
        StencilWritemask = 0x0B98,
        Stereo = 0x0C33,
        SubpixelBits = 0x0D50,
        Texture1D = 0x0DE0,
        Texture2D = 0x0DE1,
        Texture3DBindingEXT = 0x806A,
        Texture3DEXT = 0x806F,
        Texture4dBindingSgis = 0x814F,
        Texture4dSgis = 0x8134,
        TextureBinding1D = 0x8068,
        TextureBinding1DArray = 0x8C1C,
        TextureBinding2D = 0x8069,
        TextureBinding2DArray = 0x8C1D,
        TextureBinding2DMultisample = 0x9104,
        TextureBinding2DMultisampleArray = 0x9105,
        TextureBinding3D = 0x806A,
        TextureBindingBuffer = 0x8C2C,
        TextureBindingCubeMap = 0x8514,
        TextureBindingRectangle = 0x84F6,
        TextureBufferOffsetAlignment = 0x919F,
        TextureColorTableSGI = 0x80BC,
        TextureCompressionHint = 0x84EF,
        TextureCoordArray = 0x8078,
        TextureCoordArrayCountEXT = 0x808B,
        TextureCoordArraySize = 0x8088,
        TextureCoordArrayStride = 0x808A,
        TextureCoordArrayType = 0x8089,
        TextureGenQ = 0x0C63,
        TextureGenR = 0x0C62,
        TextureGenS = 0x0C60,
        TextureGenT = 0x0C61,
        TextureMatrix = 0x0BA8,
        TextureStackDepth = 0x0BA5,
        Timestamp = 0x8E28,
        TransformFeedbackBufferBinding = 0x8C8F,
        TransformFeedbackBufferSize = 0x8C85,
        TransformFeedbackBufferStart = 0x8C84,
        UniformBufferBinding = 0x8A28,
        UniformBufferOffsetAlignment = 0x8A34,
        UniformBufferSize = 0x8A2A,
        UniformBufferStart = 0x8A29,
        UnpackAlignment = 0x0CF5,
        UnpackCmykHintEXT = 0x800F,
        UnpackImageDepthSgis = 0x8133,
        UnpackImageHeight = 0x806E,
        UnpackImageHeightEXT = 0x806E,
        UnpackLsbFirst = 0x0CF1,
        UnpackResampleSGIX = 0x842F,
        UnpackRowLength = 0x0CF2,
        UnpackSkipImages = 0x806D,
        UnpackSkipImagesEXT = 0x806D,
        UnpackSkipPixels = 0x0CF4,
        UnpackSkipRows = 0x0CF3,
        UnpackSkipVolumesSgis = 0x8132,
        UnpackSubsampleRateSGIX = 0x85A1,
        UnpackSwapBytes = 0x0CF0,
        VertexArray = 0x8074,
        VertexArrayBinding = 0x85B5,
        VertexArrayCountEXT = 0x807D,
        VertexArraySize = 0x807A,
        VertexArrayStride = 0x807C,
        VertexArrayType = 0x807B,
        VertexBindingDivisor = 0x82D6,
        VertexBindingOffset = 0x82D7,
        VertexBindingStride = 0x82D8,
        VertexPreclipHintSGIX = 0x83EF,
        VertexPreclipSGIX = 0x83EE,
        Viewport = 0x0BA2,
        ViewportBoundsRange = 0x825D,
        ViewportIndexProvokingVertex = 0x825F,
        ViewportSubpixelBits = 0x825C,
        ZoomX = 0x0D16,
        ZoomY = 0x0D17,
    }

    public enum GetPointervPName
    {
        ColorArrayPointer = 0x8090,
        ColorArrayPointerEXT = 0x8090,
        EdgeFlagArrayPointer = 0x8093,
        EdgeFlagArrayPointerEXT = 0x8093,
        FeedbackBufferPointer = 0x0DF0,
        IndexArrayPointer = 0x8091,
        IndexArrayPointerEXT = 0x8091,
        InstrumentBufferPointerSGIX = 0x8180,
        NormalArrayPointer = 0x808F,
        NormalArrayPointerEXT = 0x808F,
        SelectionBufferPointer = 0x0DF3,
        TextureCoordArrayPointer = 0x8092,
        TextureCoordArrayPointerEXT = 0x8092,
        VertexArrayPointer = 0x808E,
        VertexArrayPointerEXT = 0x808E,
        DebugCallbackFunction = 0x8244,
        DebugCallbackUserParam = 0x8245,
    }

    public enum GetTextureParameter
    {
        DetailTextureFuncPointsSgis = 0x809C,
        DetailTextureLevelSgis = 0x809A,
        DetailTextureModeSgis = 0x809B,
        DualTextureSelectSgis = 0x8124,
        GenerateMipmapSgis = 0x8191,
        PostTextureFilterBiasSGIX = 0x8179,
        PostTextureFilterScaleSGIX = 0x817A,
        QuadTextureSelectSgis = 0x8125,
        ShadowAmbientSGIX = 0x80BF,
        SharpenTextureFuncPointsSgis = 0x80B0,
        Texture4dsizeSgis = 0x8136,
        TextureAlphaSize = 0x805F,
        TextureBaseLevelSgis = 0x813C,
        TextureBlueSize = 0x805E,
        TextureBorder = 0x1005,
        TextureBorderColor = 0x1004,
        TextureBorderColorNV = 0x1004,
        TextureClipmapCenterSGIX = 0x8171,
        TextureClipmapDepthSGIX = 0x8176,
        TextureClipmapFrameSGIX = 0x8172,
        TextureClipmapLodOffsetSGIX = 0x8175,
        TextureClipmapOffsetSGIX = 0x8173,
        TextureClipmapVirtualDepthSGIX = 0x8174,
        TextureCompareOperatorSGIX = 0x819B,
        TextureCompareSGIX = 0x819A,
        TextureComponents = 0x1003,
        TextureDepthEXT = 0x8071,
        TextureFilter4SizeSgis = 0x8147,
        TextureGequalRSGIX = 0x819D,
        TextureGreenSize = 0x805D,
        TextureHeight = 0x1001,
        TextureIntensitySize = 0x8061,
        TextureInternalFormat = 0x1003,
        TextureLequalRSGIX = 0x819C,
        TextureLodBiasRSGIX = 0x8190,
        TextureLodBiasSSGIX = 0x818E,
        TextureLodBiasTSGIX = 0x818F,
        TextureLuminanceSize = 0x8060,
        TextureMagFilter = 0x2800,
        TextureMaxClampRSGIX = 0x836B,
        TextureMaxClampSSGIX = 0x8369,
        TextureMaxClampTSGIX = 0x836A,
        TextureMaxLevelSgis = 0x813D,
        TextureMaxLodSgis = 0x813B,
        TextureMinFilter = 0x2801,
        TextureMinLodSgis = 0x813A,
        TexturePriority = 0x8066,
        TextureRedSize = 0x805C,
        TextureResident = 0x8067,
        TextureWidth = 0x1000,
        TextureWrapQSgis = 0x8137,
        TextureWrapREXT = 0x8072,
        TextureWrapS = 0x2802,
        TextureWrapT = 0x2803,
    }

    public enum HintMode
    {
        DontCare = 0x1100,
        Fastest = 0x1101,
        Nicest = 0x1102,
    }

    public enum HintTarget
    {
        AllowDrawFrgHintPGI = 0x1A210,
        AllowDrawMemHintPGI = 0x1A211,
        AllowDrawObjHintPGI = 0x1A20E,
        AllowDrawWinHintPGI = 0x1A20F,
        AlwaysFastHintPGI = 0x1A20C,
        AlwaysSoftHintPGI = 0x1A20D,
        BackNormalsHintPGI = 0x1A223,
        BinningControlHintQCOM = 0x8FB0,
        ClipFarHintPGI = 0x1A221,
        ClipNearHintPGI = 0x1A220,
        ClipVolumeClippingHintEXT = 0x80F0,
        ConserveMemoryHintPGI = 0x1A1FD,
        ConvolutionHintSGIX = 0x8316,
        FogHint = 0x0C54,
        FragmentShaderDerivativeHint = 0x8B8B,
        FragmentShaderDerivativeHintARB = 0x8B8B,
        FragmentShaderDerivativeHintOES = 0x8B8B,
        FullStippleHintPGI = 0x1A219,
        GenerateMipmapHint = 0x8192,
        GenerateMipmapHintSgis = 0x8192,
        LineQualityHintSGIX = 0x835B,
        LineSmoothHint = 0x0C52,
        MaterialSideHintPGI = 0x1A22C,
        MaxVertexHintPGI = 0x1A22D,
        MultisampleFilterHintNV = 0x8534,
        NativeGraphicsBeginHintPGI = 0x1A203,
        NativeGraphicsEndHintPGI = 0x1A204,
        PackCmykHintEXT = 0x800E,
        PerspectiveCorrectionHint = 0x0C50,
        PhongHintWin = 0x80EB,
        PointSmoothHint = 0x0C51,
        PolygonSmoothHint = 0x0C53,
        PreferDoublebufferHintPGI = 0x1A1F8,
        ProgramBinaryRetrievableHint = 0x8257,
        ReclaimMemoryHintPGI = 0x1A1FE,
        ScalebiasHintSGIX = 0x8322,
        StrictDepthfuncHintPGI = 0x1A216,
        StrictLightingHintPGI = 0x1A217,
        StrictScissorHintPGI = 0x1A218,
        TextureCompressionHint = 0x84EF,
        TextureCompressionHintARB = 0x84EF,
        TextureMultiBufferHintSGIX = 0x812E,
        TextureStorageHintAPPLE = 0x85BC,
        TransformHintAPPLE = 0x85B1,
        UnpackCmykHintEXT = 0x800F,
        VertexArrayStorageHintAPPLE = 0x851F,
        VertexConsistentHintPGI = 0x1A22B,
        VertexDataHintPGI = 0x1A22A,
        VertexPreclipHintSGIX = 0x83EF,
        VertexPreclipSGIX = 0x83EE,
        WideLineHintPGI = 0x1A222,
    }

    public enum HistogramTargetEXT
    {
        Histogram = 0x8024,
        HistogramEXT = 0x8024,
        ProxyHistogram = 0x8025,
        ProxyHistogramEXT = 0x8025,
        Histogram = 0x8024,
        ProxyHistogram = 0x8025,
    }

    public enum IndexPointerType
    {
        Double = 0x140A,
        Float = 0x1406,
        Int = 0x1404,
        Short = 0x1402,
    }

    public enum InterleavedArrayFormat
    {
        C3fV3f = 0x2A24,
        C4fN3fV3f = 0x2A26,
        C4ubV2f = 0x2A22,
        C4ubV3f = 0x2A23,
        N3fV3f = 0x2A25,
        T2fC3fV3f = 0x2A2A,
        T2fC4fN3fV3f = 0x2A2C,
        T2fC4ubV3f = 0x2A29,
        T2fN3fV3f = 0x2A2B,
        T2fV3f = 0x2A27,
        T4fC4fN3fV4f = 0x2A2D,
        T4fV4f = 0x2A28,
        V2f = 0x2A20,
        V3f = 0x2A21,
    }

    public enum LightEnvModeSGIX
    {
        Add = 0x0104,
        Modulate = 0x2100,
        Replace = 0x1E01,
    }

    public enum LightEnvParameterSGIX
    {
        LightEnvModeSGIX = 0x8407,
    }

    public enum LightModelColorControl
    {
        SeparateSpecularColor = 0x81FA,
        SeparateSpecularColorEXT = 0x81FA,
        SingleColor = 0x81F9,
        SingleColorEXT = 0x81F9,
    }

    public enum LightModelParameter
    {
        LightModelAmbient = 0x0B53,
        LightModelColorControl = 0x81F8,
        LightModelColorControlEXT = 0x81F8,
        LightModelLocalViewer = 0x0B51,
        LightModelTwoSide = 0x0B52,
    }

    public enum LightName
    {
        FragmentLight0SGIX = 0x840C,
        FragmentLight1SGIX = 0x840D,
        FragmentLight2SGIX = 0x840E,
        FragmentLight3SGIX = 0x840F,
        FragmentLight4SGIX = 0x8410,
        FragmentLight5SGIX = 0x8411,
        FragmentLight6SGIX = 0x8412,
        FragmentLight7SGIX = 0x8413,
        Light0 = 0x4000,
        Light1 = 0x4001,
        Light2 = 0x4002,
        Light3 = 0x4003,
        Light4 = 0x4004,
        Light5 = 0x4005,
        Light6 = 0x4006,
        Light7 = 0x4007,
    }

    public enum LightParameter
    {
        Ambient = 0x1200,
        ConstantAttenuation = 0x1207,
        Diffuse = 0x1201,
        LinearAttenuation = 0x1208,
        Position = 0x1203,
        QuadraticAttenuation = 0x1209,
        Specular = 0x1202,
        SpotCutoff = 0x1206,
        SpotDirection = 0x1204,
        SpotExponent = 0x1205,
    }

    public enum ListMode
    {
        Compile = 0x1300,
        CompileAndExecute = 0x1301,
    }

    public enum ListNameType
    {
        2Bytes = 0x1407,
        3Bytes = 0x1408,
        4Bytes = 0x1409,
        Byte = 0x1400,
        Float = 0x1406,
        Int = 0x1404,
        Short = 0x1402,
        UnsignedByte = 0x1401,
        UnsignedInt = 0x1405,
        UnsignedShort = 0x1403,
    }

    public enum ListParameterName
    {
        ListPrioritySGIX = 0x8182,
    }

    public enum LogicOp
    {
        And = 0x1501,
        AndInverted = 0x1504,
        AndReverse = 0x1502,
        Clear = 0x1500,
        Copy = 0x1503,
        CopyInverted = 0x150C,
        Equiv = 0x1509,
        Invert = 0x150A,
        Nand = 0x150E,
        Noop = 0x1505,
        Nor = 0x1508,
        Or = 0x1507,
        OrInverted = 0x150D,
        OrReverse = 0x150B,
        Set = 0x150F,
        Xor = 0x1506,
    }

    public enum MapTarget
    {
        GeometryDeformationSGIX = 0x8194,
        Map1Color4 = 0x0D90,
        Map1Index = 0x0D91,
        Map1Normal = 0x0D92,
        Map1TextureCoord1 = 0x0D93,
        Map1TextureCoord2 = 0x0D94,
        Map1TextureCoord3 = 0x0D95,
        Map1TextureCoord4 = 0x0D96,
        Map1Vertex3 = 0x0D97,
        Map1Vertex4 = 0x0D98,
        Map2Color4 = 0x0DB0,
        Map2Index = 0x0DB1,
        Map2Normal = 0x0DB2,
        Map2TextureCoord1 = 0x0DB3,
        Map2TextureCoord2 = 0x0DB4,
        Map2TextureCoord3 = 0x0DB5,
        Map2TextureCoord4 = 0x0DB6,
        Map2Vertex3 = 0x0DB7,
        Map2Vertex4 = 0x0DB8,
        TextureDeformationSGIX = 0x8195,
    }

    public enum MaterialFace
    {
        Back = 0x0405,
        Front = 0x0404,
        FrontAndBack = 0x0408,
    }

    public enum MaterialParameter
    {
        Ambient = 0x1200,
        AmbientAndDiffuse = 0x1602,
        ColorIndexes = 0x1603,
        Diffuse = 0x1201,
        Emission = 0x1600,
        Shininess = 0x1601,
        Specular = 0x1202,
    }

    public enum MatrixMode
    {
        Modelview = 0x1700,
        Modelview0EXT = 0x1700,
        Projection = 0x1701,
        Texture = 0x1702,
    }

    public enum MemoryObjectParameterName
    {
        DedicatedMemoryObjectEXT = 0x9581,
        ProtectedMemoryObjectEXT = 0x959B,
    }

    public enum MeshMode1
    {
        Line = 0x1B01,
        Point = 0x1B00,
    }

    public enum MeshMode2
    {
        Fill = 0x1B02,
        Line = 0x1B01,
        Point = 0x1B00,
    }

    public enum MinmaxTargetEXT
    {
        Minmax = 0x802E,
        MinmaxEXT = 0x802E,
    }

    public enum NormalPointerType
    {
        Byte = 0x1400,
        Double = 0x140A,
        Float = 0x1406,
        Int = 0x1404,
        Short = 0x1402,
    }

    public enum PixelCopyType
    {
        Color = 0x1800,
        ColorEXT = 0x1800,
        Depth = 0x1801,
        DepthEXT = 0x1801,
        Stencil = 0x1802,
        StencilEXT = 0x1802,
    }

    public enum PixelFormat
    {
        AbgrEXT = 0x8000,
        Alpha = 0x1906,
        Bgr = 0x80E0,
        BgrInteger = 0x8D9A,
        Bgra = 0x80E1,
        BgraInteger = 0x8D9B,
        Blue = 0x1905,
        BlueInteger = 0x8D96,
        CmykaEXT = 0x800D,
        CmykEXT = 0x800C,
        ColorIndex = 0x1900,
        DepthComponent = 0x1902,
        DepthStencil = 0x84F9,
        Green = 0x1904,
        GreenInteger = 0x8D95,
        Luminance = 0x1909,
        LuminanceAlpha = 0x190A,
        Red = 0x1903,
        RedEXT = 0x1903,
        RedInteger = 0x8D94,
        Rg = 0x8227,
        RgInteger = 0x8228,
        Rgb = 0x1907,
        RgbInteger = 0x8D98,
        Rgba = 0x1908,
        RgbaInteger = 0x8D99,
        StencilIndex = 0x1901,
        UnsignedInt = 0x1405,
        UnsignedShort = 0x1403,
        Ycrcb422SGIX = 0x81BB,
        Ycrcb444SGIX = 0x81BC,
    }

    public enum InternalFormat
    {
        Alpha12 = 0x803D,
        Alpha16 = 0x803E,
        Alpha4 = 0x803B,
        Alpha8 = 0x803C,
        DualAlpha12Sgis = 0x8112,
        DualAlpha16Sgis = 0x8113,
        DualAlpha4Sgis = 0x8110,
        DualAlpha8Sgis = 0x8111,
        DualIntensity12Sgis = 0x811A,
        DualIntensity16Sgis = 0x811B,
        DualIntensity4Sgis = 0x8118,
        DualIntensity8Sgis = 0x8119,
        DualLuminance12Sgis = 0x8116,
        DualLuminance16Sgis = 0x8117,
        DualLuminance4Sgis = 0x8114,
        DualLuminance8Sgis = 0x8115,
        DualLuminanceAlpha4Sgis = 0x811C,
        DualLuminanceAlpha8Sgis = 0x811D,
        Intensity = 0x8049,
        Intensity12 = 0x804C,
        Intensity16 = 0x804D,
        Intensity4 = 0x804A,
        Intensity8 = 0x804B,
        Luminance12 = 0x8041,
        Luminance12Alpha12 = 0x8047,
        Luminance12Alpha4 = 0x8046,
        Luminance16 = 0x8042,
        Luminance16Alpha16 = 0x8048,
        Luminance4 = 0x803F,
        Luminance4Alpha4 = 0x8043,
        Luminance6Alpha2 = 0x8044,
        Luminance8 = 0x8040,
        Luminance8Alpha8 = 0x8045,
        QuadAlpha4Sgis = 0x811E,
        QuadAlpha8Sgis = 0x811F,
        QuadIntensity4Sgis = 0x8122,
        QuadIntensity8Sgis = 0x8123,
        QuadLuminance4Sgis = 0x8120,
        QuadLuminance8Sgis = 0x8121,
        Red = 0x1903,
        RedEXT = 0x1903,
        R8 = 0x8229,
        R8EXT = 0x8229,
        R8Snorm = 0x8F94,
        R16 = 0x822A,
        R16EXT = 0x822A,
        R16Snorm = 0x8F98,
        R16SnormEXT = 0x8F98,
        R16f = 0x822D,
        R16fEXT = 0x822D,
        R32f = 0x822E,
        R32fEXT = 0x822E,
        R8i = 0x8231,
        R16i = 0x8233,
        R32i = 0x8235,
        R8ui = 0x8232,
        R16ui = 0x8234,
        R32ui = 0x8236,
        Rg = 0x8227,
        Rg8 = 0x822B,
        Rg8EXT = 0x822B,
        Rg8Snorm = 0x8F95,
        Rg16 = 0x822C,
        Rg16EXT = 0x822C,
        Rg16Snorm = 0x8F99,
        Rg16SnormEXT = 0x8F99,
        Rg16f = 0x822F,
        Rg16fEXT = 0x822F,
        Rg32f = 0x8230,
        Rg32fEXT = 0x8230,
        Rg8i = 0x8237,
        Rg16i = 0x8239,
        Rg32i = 0x823B,
        Rg8ui = 0x8238,
        Rg16ui = 0x823A,
        Rg32ui = 0x823C,
        Rgb = 0x1907,
        Rgb2EXT = 0x804E,
        Rgb4 = 0x804F,
        Rgb4EXT = 0x804F,
        Rgb5 = 0x8050,
        Rgb5EXT = 0x8050,
        Rgb8 = 0x8051,
        Rgb8EXT = 0x8051,
        Rgb8OES = 0x8051,
        Rgb8Snorm = 0x8F96,
        Rgb10 = 0x8052,
        Rgb10EXT = 0x8052,
        Rgb12 = 0x8053,
        Rgb12EXT = 0x8053,
        Rgb16 = 0x8054,
        Rgb16EXT = 0x8054,
        Rgb16f = 0x881B,
        Rgb16fARB = 0x881B,
        Rgb16fEXT = 0x881B,
        Rgb16Snorm = 0x8F9A,
        Rgb16SnormEXT = 0x8F9A,
        Rgb8i = 0x8D8F,
        Rgb16i = 0x8D89,
        Rgb32i = 0x8D83,
        Rgb8ui = 0x8D7D,
        Rgb16ui = 0x8D77,
        Rgb32ui = 0x8D71,
        Srgb = 0x8C40,
        SrgbEXT = 0x8C40,
        SrgbAlpha = 0x8C42,
        SrgbAlphaEXT = 0x8C42,
        Srgb8 = 0x8C41,
        Srgb8EXT = 0x8C41,
        Srgb8NV = 0x8C41,
        Srgb8Alpha8 = 0x8C43,
        Srgb8Alpha8EXT = 0x8C43,
        R3G3B2 = 0x2A10,
        R11fG11fB10f = 0x8C3A,
        R11fG11fB10fAPPLE = 0x8C3A,
        R11fG11fB10fEXT = 0x8C3A,
        Rgb9E5 = 0x8C3D,
        Rgb9E5APPLE = 0x8C3D,
        Rgb9E5EXT = 0x8C3D,
        Rgba = 0x1908,
        Rgba4 = 0x8056,
        Rgba4EXT = 0x8056,
        Rgba4OES = 0x8056,
        Rgb5A1 = 0x8057,
        Rgb5A1EXT = 0x8057,
        Rgb5A1OES = 0x8057,
        Rgba8 = 0x8058,
        Rgba8EXT = 0x8058,
        Rgba8OES = 0x8058,
        Rgba8Snorm = 0x8F97,
        Rgb10A2 = 0x8059,
        Rgb10A2EXT = 0x8059,
        Rgba12 = 0x805A,
        Rgba12EXT = 0x805A,
        Rgba16 = 0x805B,
        Rgba16EXT = 0x805B,
        Rgba16f = 0x881A,
        Rgba16fARB = 0x881A,
        Rgba16fEXT = 0x881A,
        Rgba32f = 0x8814,
        Rgba32fARB = 0x8814,
        Rgba32fEXT = 0x8814,
        Rgba8i = 0x8D8E,
        Rgba16i = 0x8D88,
        Rgba32i = 0x8D82,
        Rgba8ui = 0x8D7C,
        Rgba16ui = 0x8D76,
        Rgba32ui = 0x8D70,
        Rgb10A2ui = 0x906F,
        DepthComponent = 0x1902,
        DepthComponent16 = 0x81A5,
        DepthComponent16ARB = 0x81A5,
        DepthComponent16OES = 0x81A5,
        DepthComponent16SGIX = 0x81A5,
        DepthComponent24ARB = 0x81A6,
        DepthComponent24OES = 0x81A6,
        DepthComponent24SGIX = 0x81A6,
        DepthComponent32ARB = 0x81A7,
        DepthComponent32OES = 0x81A7,
        DepthComponent32SGIX = 0x81A7,
        DepthComponent32f = 0x8CAC,
        DepthComponent32fNV = 0x8DAB,
        DepthComponent32fNV = 0x8DAB,
        DepthStencil = 0x84F9,
        DepthStencilEXT = 0x84F9,
        DepthStencilMESA = 0x8750,
        DepthStencilNV = 0x84F9,
        DepthStencilOES = 0x84F9,
        Depth24Stencil8 = 0x88F0,
        Depth24Stencil8EXT = 0x88F0,
        Depth24Stencil8OES = 0x88F0,
        Depth32fStencil8 = 0x8CAD,
        Depth32fStencil8NV = 0x8DAC,
        CompressedRed = 0x8225,
        CompressedRg = 0x8226,
        CompressedRgb = 0x84ED,
        CompressedRgba = 0x84EE,
        CompressedSrgb = 0x8C48,
        CompressedSrgbAlpha = 0x8C49,
        CompressedRedRgtc1 = 0x8DBB,
        CompressedRedRgtc1EXT = 0x8DBB,
        CompressedSignedRedRgtc1 = 0x8DBC,
        CompressedSignedRedRgtc1EXT = 0x8DBC,
        CompressedR11Eac = 0x9270,
        CompressedSignedR11Eac = 0x9271,
        CompressedRgRgtc2 = 0x8DBD,
        CompressedSignedRgRgtc2 = 0x8DBE,
        CompressedRgbaBptcUnorm = 0x8E8C,
        CompressedSrgbAlphaBptcUnorm = 0x8E8D,
        CompressedRgbBptcSignedFloat = 0x8E8E,
        CompressedRgbBptcUnsignedFloat = 0x8E8F,
        CompressedRgb8Etc2 = 0x9274,
        CompressedSrgb8Etc2 = 0x9275,
        CompressedRgb8PunchthroughAlpha1Etc2 = 0x9276,
        CompressedSrgb8PunchthroughAlpha1Etc2 = 0x9277,
        CompressedRgba8Etc2Eac = 0x9278,
        CompressedSrgb8Alpha8Etc2Eac = 0x9279,
        CompressedRg11Eac = 0x9272,
        CompressedSignedRg11Eac = 0x9273,
        CompressedRgbS3tcDxt1EXT = 0x83F0,
        CompressedSrgbS3tcDxt1EXT = 0x8C4C,
        CompressedRgbaS3tcDxt1EXT = 0x83F1,
        CompressedSrgbAlphaS3tcDxt1EXT = 0x8C4D,
        CompressedRgbaS3tcDxt3EXT = 0x83F2,
        CompressedSrgbAlphaS3tcDxt3EXT = 0x8C4E,
        CompressedRgbaS3tcDxt5EXT = 0x83F3,
        CompressedSrgbAlphaS3tcDxt5EXT = 0x8C4F,
    }

    public enum PixelMap
    {
        PixelMapAToA = 0x0C79,
        PixelMapBToB = 0x0C78,
        PixelMapGToG = 0x0C77,
        PixelMapIToA = 0x0C75,
        PixelMapIToB = 0x0C74,
        PixelMapIToG = 0x0C73,
        PixelMapIToI = 0x0C70,
        PixelMapIToR = 0x0C72,
        PixelMapRToR = 0x0C76,
        PixelMapSToS = 0x0C71,
    }

    public enum PixelStoreParameter
    {
        PackAlignment = 0x0D05,
        PackImageDepthSgis = 0x8131,
        PackImageHeight = 0x806C,
        PackImageHeightEXT = 0x806C,
        PackLsbFirst = 0x0D01,
        PackResampleOML = 0x8984,
        PackResampleSGIX = 0x842E,
        PackRowLength = 0x0D02,
        PackSkipImages = 0x806B,
        PackSkipImagesEXT = 0x806B,
        PackSkipPixels = 0x0D04,
        PackSkipRows = 0x0D03,
        PackSkipVolumesSgis = 0x8130,
        PackSubsampleRateSGIX = 0x85A0,
        PackSwapBytes = 0x0D00,
        PixelTileCacheSizeSGIX = 0x8145,
        PixelTileGridDepthSGIX = 0x8144,
        PixelTileGridHeightSGIX = 0x8143,
        PixelTileGridWidthSGIX = 0x8142,
        PixelTileHeightSGIX = 0x8141,
        PixelTileWidthSGIX = 0x8140,
        UnpackAlignment = 0x0CF5,
        UnpackImageDepthSgis = 0x8133,
        UnpackImageHeight = 0x806E,
        UnpackImageHeightEXT = 0x806E,
        UnpackLsbFirst = 0x0CF1,
        UnpackResampleOML = 0x8985,
        UnpackResampleSGIX = 0x842F,
        UnpackRowLength = 0x0CF2,
        UnpackRowLengthEXT = 0x0CF2,
        UnpackSkipImages = 0x806D,
        UnpackSkipImagesEXT = 0x806D,
        UnpackSkipPixels = 0x0CF4,
        UnpackSkipPixelsEXT = 0x0CF4,
        UnpackSkipRows = 0x0CF3,
        UnpackSkipRowsEXT = 0x0CF3,
        UnpackSkipVolumesSgis = 0x8132,
        UnpackSubsampleRateSGIX = 0x85A1,
        UnpackSwapBytes = 0x0CF0,
    }

    public enum PixelStoreResampleMode
    {
        ResampleDecimateSGIX = 0x8430,
        ResampleReplicateSGIX = 0x8433,
        ResampleZeroFillSGIX = 0x8434,
    }

    public enum PixelStoreSubsampleRate
    {
        PixelSubsample2424SGIX = 0x85A3,
        PixelSubsample4242SGIX = 0x85A4,
        PixelSubsample4444SGIX = 0x85A2,
    }

    public enum PixelTexGenMode
    {
        Luminance = 0x1909,
        LuminanceAlpha = 0x190A,
        None = 0,
        PixelTexGenAlphaLsSGIX = 0x8189,
        PixelTexGenAlphaMSSGIX = 0x818A,
        PixelTexGenAlphaNoReplaceSGIX = 0x8188,
        PixelTexGenAlphaReplaceSGIX = 0x8187,
        Rgb = 0x1907,
        Rgba = 0x1908,
    }

    public enum PixelTexGenParameterNameSGIS
    {
        PixelFragmentAlphaSourceSgis = 0x8355,
        PixelFragmentRgbSourceSgis = 0x8354,
    }

    public enum PixelTransferParameter
    {
        AlphaBias = 0x0D1D,
        AlphaScale = 0x0D1C,
        BlueBias = 0x0D1B,
        BlueScale = 0x0D1A,
        DepthBias = 0x0D1F,
        DepthScale = 0x0D1E,
        GreenBias = 0x0D19,
        GreenScale = 0x0D18,
        IndexOffset = 0x0D13,
        IndexShift = 0x0D12,
        MapColor = 0x0D10,
        MapStencil = 0x0D11,
        PostColorMatrixAlphaBias = 0x80BB,
        PostColorMatrixAlphaBiasSGI = 0x80BB,
        PostColorMatrixAlphaScale = 0x80B7,
        PostColorMatrixAlphaScaleSGI = 0x80B7,
        PostColorMatrixBlueBias = 0x80BA,
        PostColorMatrixBlueBiasSGI = 0x80BA,
        PostColorMatrixBlueScale = 0x80B6,
        PostColorMatrixBlueScaleSGI = 0x80B6,
        PostColorMatrixGreenBias = 0x80B9,
        PostColorMatrixGreenBiasSGI = 0x80B9,
        PostColorMatrixGreenScale = 0x80B5,
        PostColorMatrixGreenScaleSGI = 0x80B5,
        PostColorMatrixRedBias = 0x80B8,
        PostColorMatrixRedBiasSGI = 0x80B8,
        PostColorMatrixRedScale = 0x80B4,
        PostColorMatrixRedScaleSGI = 0x80B4,
        PostConvolutionAlphaBias = 0x8023,
        PostConvolutionAlphaBiasEXT = 0x8023,
        PostConvolutionAlphaScale = 0x801F,
        PostConvolutionAlphaScaleEXT = 0x801F,
        PostConvolutionBlueBias = 0x8022,
        PostConvolutionBlueBiasEXT = 0x8022,
        PostConvolutionBlueScale = 0x801E,
        PostConvolutionBlueScaleEXT = 0x801E,
        PostConvolutionGreenBias = 0x8021,
        PostConvolutionGreenBiasEXT = 0x8021,
        PostConvolutionGreenScale = 0x801D,
        PostConvolutionGreenScaleEXT = 0x801D,
        PostConvolutionRedBias = 0x8020,
        PostConvolutionRedBiasEXT = 0x8020,
        PostConvolutionRedScale = 0x801C,
        PostConvolutionRedScaleEXT = 0x801C,
        RedBias = 0x0D15,
        RedScale = 0x0D14,
    }

    public enum PixelType
    {
        Bitmap = 0x1A00,
        Byte = 0x1400,
        Float = 0x1406,
        Int = 0x1404,
        Short = 0x1402,
        UnsignedByte = 0x1401,
        UnsignedByte332 = 0x8032,
        UnsignedByte332EXT = 0x8032,
        UnsignedInt = 0x1405,
        UnsignedInt1010102 = 0x8036,
        UnsignedInt1010102EXT = 0x8036,
        UnsignedInt8888 = 0x8035,
        UnsignedInt8888EXT = 0x8035,
        UnsignedShort = 0x1403,
        UnsignedShort4444 = 0x8033,
        UnsignedShort4444EXT = 0x8033,
        UnsignedShort5551 = 0x8034,
        UnsignedShort5551EXT = 0x8034,
    }

    public enum PointParameterNameSGIS
    {
        DistanceAttenuationEXT = 0x8129,
        DistanceAttenuationSgis = 0x8129,
        PointDistanceAttenuation = 0x8129,
        PointDistanceAttenuationARB = 0x8129,
        PointFadeThresholdSize = 0x8128,
        PointFadeThresholdSizeARB = 0x8128,
        PointFadeThresholdSizeEXT = 0x8128,
        PointFadeThresholdSizeSgis = 0x8128,
        PointSizeMax = 0x8127,
        PointSizeMaxARB = 0x8127,
        PointSizeMaxEXT = 0x8127,
        PointSizeMaxSgis = 0x8127,
        PointSizeMin = 0x8126,
        PointSizeMinARB = 0x8126,
        PointSizeMinEXT = 0x8126,
        PointSizeMinSgis = 0x8126,
    }

    public enum PolygonMode
    {
        Fill = 0x1B02,
        Line = 0x1B01,
        Point = 0x1B00,
    }

    public enum PrimitiveType
    {
        Lines = 0x0001,
        LinesAdjacency = 0x000A,
        LinesAdjacencyARB = 0x000A,
        LinesAdjacencyEXT = 0x000A,
        LineLoop = 0x0002,
        LineStrip = 0x0003,
        LineStripAdjacency = 0x000B,
        LineStripAdjacencyARB = 0x000B,
        LineStripAdjacencyEXT = 0x000B,
        Patches = 0x000E,
        PatchesEXT = 0x000E,
        Points = 0x0000,
        Polygon = 0x0009,
        Quads = 0x0007,
        QuadsEXT = 0x0007,
        QuadStrip = 0x0008,
        Triangles = 0x0004,
        TrianglesAdjacency = 0x000C,
        TrianglesAdjacencyARB = 0x000C,
        TrianglesAdjacencyEXT = 0x000C,
        TriangleFan = 0x0006,
        TriangleStrip = 0x0005,
        TriangleStripAdjacency = 0x000D,
        TriangleStripAdjacencyARB = 0x000D,
        TriangleStripAdjacencyEXT = 0x000D,
    }

    public enum ReadBufferMode
    {
        Aux0 = 0x0409,
        Aux1 = 0x040A,
        Aux2 = 0x040B,
        Aux3 = 0x040C,
        Back = 0x0405,
        BackLeft = 0x0402,
        BackRight = 0x0403,
        Front = 0x0404,
        FrontLeft = 0x0400,
        FrontRight = 0x0401,
        Left = 0x0406,
        Right = 0x0407,
    }

    public enum RenderingMode
    {
        Feedback = 0x1C01,
        Render = 0x1C00,
        Select = 0x1C02,
    }

    public enum SamplePatternSGIS
    {
        1passEXT = 0x80A1,
        1passSgis = 0x80A1,
        2pass0EXT = 0x80A2,
        2pass0Sgis = 0x80A2,
        2pass1EXT = 0x80A3,
        2pass1Sgis = 0x80A3,
        4pass0EXT = 0x80A4,
        4pass0Sgis = 0x80A4,
        4pass1EXT = 0x80A5,
        4pass1Sgis = 0x80A5,
        4pass2EXT = 0x80A6,
        4pass2Sgis = 0x80A6,
        4pass3EXT = 0x80A7,
        4pass3Sgis = 0x80A7,
    }

    public enum SemaphoreParameterName
    {
        D3d12FenceValueEXT = 0x9595,
    }

    public enum SeparableTargetEXT
    {
        Separable2D = 0x8012,
        Separable2DEXT = 0x8012,
    }

    public enum ShadingModel
    {
        Flat = 0x1D00,
        Smooth = 0x1D01,
    }

    public enum StencilFaceDirection
    {
        Front = 0x0404,
        Back = 0x0405,
        FrontAndBack = 0x0408,
    }

    public enum StencilFunction
    {
        Always = 0x0207,
        Equal = 0x0202,
        Gequal = 0x0206,
        Greater = 0x0204,
        Lequal = 0x0203,
        Less = 0x0201,
        Never = 0x0200,
        Notequal = 0x0205,
    }

    public enum StencilOp
    {
        Decr = 0x1E03,
        DecrWrap = 0x8508,
        Incr = 0x1E02,
        IncrWrap = 0x8507,
        Invert = 0x150A,
        Keep = 0x1E00,
        Replace = 0x1E01,
        Zero = 0,
    }

    public enum StringName
    {
        Extensions = 0x1F03,
        Renderer = 0x1F01,
        Vendor = 0x1F00,
        Version = 0x1F02,
        ShadingLanguageVersion = 0x8B8C,
    }

    public enum TexCoordPointerType
    {
        Double = 0x140A,
        Float = 0x1406,
        Int = 0x1404,
        Short = 0x1402,
    }

    public enum TextureCoordName
    {
        S = 0x2000,
        T = 0x2001,
        R = 0x2002,
        Q = 0x2003,
    }

    public enum TextureEnvMode
    {
        Add = 0x0104,
        Blend = 0x0BE2,
        Decal = 0x2101,
        Modulate = 0x2100,
        ReplaceEXT = 0x8062,
        TextureEnvBiasSGIX = 0x80BE,
    }

    public enum TextureEnvParameter
    {
        TextureEnvColor = 0x2201,
        TextureEnvMode = 0x2200,
    }

    public enum TextureEnvTarget
    {
        TextureEnv = 0x2300,
    }

    public enum TextureFilterFuncSGIS
    {
        Filter4Sgis = 0x8146,
    }

    public enum TextureGenMode
    {
        EyeDistanceToLineSgis = 0x81F2,
        EyeDistanceToPointSgis = 0x81F0,
        EyeLinear = 0x2400,
        ObjectDistanceToLineSgis = 0x81F3,
        ObjectDistanceToPointSgis = 0x81F1,
        ObjectLinear = 0x2401,
        SphereMap = 0x2402,
    }

    public enum TextureGenParameter
    {
        EyeLineSgis = 0x81F6,
        EyePlane = 0x2502,
        EyePointSgis = 0x81F4,
        ObjectLineSgis = 0x81F7,
        ObjectPlane = 0x2501,
        ObjectPointSgis = 0x81F5,
        TextureGenMode = 0x2500,
    }

    public enum TextureMagFilter
    {
        Filter4Sgis = 0x8146,
        Linear = 0x2601,
        LinearDetailAlphaSgis = 0x8098,
        LinearDetailColorSgis = 0x8099,
        LinearDetailSgis = 0x8097,
        LinearSharpenAlphaSgis = 0x80AE,
        LinearSharpenColorSgis = 0x80AF,
        LinearSharpenSgis = 0x80AD,
        Nearest = 0x2600,
        PixelTexGenQCeilingSGIX = 0x8184,
        PixelTexGenQFloorSGIX = 0x8186,
        PixelTexGenQRoundSGIX = 0x8185,
    }

    public enum TextureMinFilter
    {
        Filter4Sgis = 0x8146,
        Linear = 0x2601,
        LinearClipmapLinearSGIX = 0x8170,
        LinearClipmapNearestSGIX = 0x844F,
        LinearMipmapLinear = 0x2703,
        LinearMipmapNearest = 0x2701,
        Nearest = 0x2600,
        NearestClipmapLinearSGIX = 0x844E,
        NearestClipmapNearestSGIX = 0x844D,
        NearestMipmapLinear = 0x2702,
        NearestMipmapNearest = 0x2700,
        PixelTexGenQCeilingSGIX = 0x8184,
        PixelTexGenQFloorSGIX = 0x8186,
        PixelTexGenQRoundSGIX = 0x8185,
    }

    public enum TextureParameterName
    {
        DetailTextureLevelSgis = 0x809A,
        DetailTextureModeSgis = 0x809B,
        DualTextureSelectSgis = 0x8124,
        GenerateMipmap = 0x8191,
        GenerateMipmapSgis = 0x8191,
        PostTextureFilterBiasSGIX = 0x8179,
        PostTextureFilterScaleSGIX = 0x817A,
        QuadTextureSelectSgis = 0x8125,
        ShadowAmbientSGIX = 0x80BF,
        TextureBorderColor = 0x1004,
        TextureClipmapCenterSGIX = 0x8171,
        TextureClipmapDepthSGIX = 0x8176,
        TextureClipmapFrameSGIX = 0x8172,
        TextureClipmapLodOffsetSGIX = 0x8175,
        TextureClipmapOffsetSGIX = 0x8173,
        TextureClipmapVirtualDepthSGIX = 0x8174,
        TextureCompareSGIX = 0x819A,
        TextureLodBiasRSGIX = 0x8190,
        TextureLodBiasSSGIX = 0x818E,
        TextureLodBiasTSGIX = 0x818F,
        TextureMagFilter = 0x2800,
        TextureMaxClampRSGIX = 0x836B,
        TextureMaxClampSSGIX = 0x8369,
        TextureMaxClampTSGIX = 0x836A,
        TextureMinFilter = 0x2801,
        TexturePriority = 0x8066,
        TexturePriorityEXT = 0x8066,
        TextureWrapQSgis = 0x8137,
        TextureWrapR = 0x8072,
        TextureWrapREXT = 0x8072,
        TextureWrapROES = 0x8072,
        TextureWrapS = 0x2802,
        TextureWrapT = 0x2803,
        TextureBaseLevel = 0x813C,
        TextureCompareMode = 0x884C,
        TextureCompareFunc = 0x884D,
        TextureLodBias = 0x8501,
        TextureMinLod = 0x813A,
        TextureMaxLod = 0x813B,
        TextureMaxLevel = 0x813D,
        TextureSwizzleR = 0x8E42,
        TextureSwizzleG = 0x8E43,
        TextureSwizzleB = 0x8E44,
        TextureSwizzleA = 0x8E45,
        TextureSwizzleRgba = 0x8E46,
        TextureTilingEXT = 0x9580,
        DepthStencilTextureMode = 0x90EA,
        DetailTextureFuncPointsSgis = 0x809C,
        SharpenTextureFuncPointsSgis = 0x80B0,
        Texture4dsizeSgis = 0x8136,
        TextureAlphaSize = 0x805F,
        TextureBaseLevelSgis = 0x813C,
        TextureBlueSize = 0x805E,
        TextureBorder = 0x1005,
        TextureBorderColorNV = 0x1004,
        TextureCompareOperatorSGIX = 0x819B,
        TextureComponents = 0x1003,
        TextureDepthEXT = 0x8071,
        TextureFilter4SizeSgis = 0x8147,
        TextureGequalRSGIX = 0x819D,
        TextureGreenSize = 0x805D,
        TextureHeight = 0x1001,
        TextureIntensitySize = 0x8061,
        TextureInternalFormat = 0x1003,
        TextureLequalRSGIX = 0x819C,
        TextureLuminanceSize = 0x8060,
        TextureMaxLevelSgis = 0x813D,
        TextureMaxLodSgis = 0x813B,
        TextureMinLodSgis = 0x813A,
        TextureRedSize = 0x805C,
        TextureResident = 0x8067,
        TextureWidth = 0x1000,
    }

    public enum TextureTarget
    {
        DetailTexture2DSgis = 0x8095,
        ProxyTexture1D = 0x8063,
        ProxyTexture1DArray = 0x8C19,
        ProxyTexture1DArrayEXT = 0x8C19,
        ProxyTexture1DEXT = 0x8063,
        ProxyTexture2D = 0x8064,
        ProxyTexture2DArray = 0x8C1B,
        ProxyTexture2DArrayEXT = 0x8C1B,
        ProxyTexture2DEXT = 0x8064,
        ProxyTexture2DMultisample = 0x9101,
        ProxyTexture2DMultisampleArray = 0x9103,
        ProxyTexture3D = 0x8070,
        ProxyTexture3DEXT = 0x8070,
        ProxyTexture4dSgis = 0x8135,
        ProxyTextureCubeMap = 0x851B,
        ProxyTextureCubeMapARB = 0x851B,
        ProxyTextureCubeMapEXT = 0x851B,
        ProxyTextureCubeMapArray = 0x900B,
        ProxyTextureCubeMapArrayARB = 0x900B,
        ProxyTextureRectangle = 0x84F7,
        ProxyTextureRectangleARB = 0x84F7,
        ProxyTextureRectangleNV = 0x84F7,
        Texture1D = 0x0DE0,
        Texture2D = 0x0DE1,
        Texture3D = 0x806F,
        Texture3DEXT = 0x806F,
        Texture3DOES = 0x806F,
        Texture4dSgis = 0x8134,
        TextureRectangle = 0x84F5,
        TextureCubeMap = 0x8513,
        TextureCubeMapPositiveX = 0x8515,
        TextureCubeMapNegativeX = 0x8516,
        TextureCubeMapPositiveY = 0x8517,
        TextureCubeMapNegativeY = 0x8518,
        TextureCubeMapPositiveZ = 0x8519,
        TextureCubeMapNegativeZ = 0x851A,
        TextureCubeMapArray = 0x9009,
        TextureCubeMapArrayARB = 0x9009,
        TextureCubeMapArrayEXT = 0x9009,
        TextureCubeMapArrayOES = 0x9009,
        Texture1DArray = 0x8C18,
        Texture2DArray = 0x8C1A,
        Texture2DMultisample = 0x9100,
        Texture2DMultisampleArray = 0x9102,
    }

    public enum TextureWrapMode
    {
        Clamp = 0x2900,
        ClampToBorder = 0x812D,
        ClampToBorderARB = 0x812D,
        ClampToBorderNV = 0x812D,
        ClampToBorderSgis = 0x812D,
        ClampToEdge = 0x812F,
        ClampToEdgeSgis = 0x812F,
        Repeat = 0x2901,
    }

    public enum VertexPointerType
    {
        Double = 0x140A,
        Float = 0x1406,
        Int = 0x1404,
        Short = 0x1402,
    }

    public enum FramebufferAttachment
    {
        MaxColorAttachments = 0x8CDF,
        MaxColorAttachmentsEXT = 0x8CDF,
        MaxColorAttachmentsNV = 0x8CDF,
        ColorAttachment0 = 0x8CE0,
        ColorAttachment0EXT = 0x8CE0,
        ColorAttachment0NV = 0x8CE0,
        ColorAttachment0OES = 0x8CE0,
        ColorAttachment1 = 0x8CE1,
        ColorAttachment1EXT = 0x8CE1,
        ColorAttachment1NV = 0x8CE1,
        ColorAttachment2 = 0x8CE2,
        ColorAttachment2EXT = 0x8CE2,
        ColorAttachment2NV = 0x8CE2,
        ColorAttachment3 = 0x8CE3,
        ColorAttachment3EXT = 0x8CE3,
        ColorAttachment3NV = 0x8CE3,
        ColorAttachment4 = 0x8CE4,
        ColorAttachment4EXT = 0x8CE4,
        ColorAttachment4NV = 0x8CE4,
        ColorAttachment5 = 0x8CE5,
        ColorAttachment5EXT = 0x8CE5,
        ColorAttachment5NV = 0x8CE5,
        ColorAttachment6 = 0x8CE6,
        ColorAttachment6EXT = 0x8CE6,
        ColorAttachment6NV = 0x8CE6,
        ColorAttachment7 = 0x8CE7,
        ColorAttachment7EXT = 0x8CE7,
        ColorAttachment7NV = 0x8CE7,
        ColorAttachment8 = 0x8CE8,
        ColorAttachment8EXT = 0x8CE8,
        ColorAttachment8NV = 0x8CE8,
        ColorAttachment9 = 0x8CE9,
        ColorAttachment9EXT = 0x8CE9,
        ColorAttachment9NV = 0x8CE9,
        ColorAttachment10 = 0x8CEA,
        ColorAttachment10EXT = 0x8CEA,
        ColorAttachment10NV = 0x8CEA,
        ColorAttachment11 = 0x8CEB,
        ColorAttachment11EXT = 0x8CEB,
        ColorAttachment11NV = 0x8CEB,
        ColorAttachment12 = 0x8CEC,
        ColorAttachment12EXT = 0x8CEC,
        ColorAttachment12NV = 0x8CEC,
        ColorAttachment13 = 0x8CED,
        ColorAttachment13EXT = 0x8CED,
        ColorAttachment13NV = 0x8CED,
        ColorAttachment14 = 0x8CEE,
        ColorAttachment14EXT = 0x8CEE,
        ColorAttachment14NV = 0x8CEE,
        ColorAttachment15 = 0x8CEF,
        ColorAttachment15EXT = 0x8CEF,
        ColorAttachment15NV = 0x8CEF,
        ColorAttachment16 = 0x8CF0,
        ColorAttachment17 = 0x8CF1,
        ColorAttachment18 = 0x8CF2,
        ColorAttachment19 = 0x8CF3,
        ColorAttachment20 = 0x8CF4,
        ColorAttachment21 = 0x8CF5,
        ColorAttachment22 = 0x8CF6,
        ColorAttachment23 = 0x8CF7,
        ColorAttachment24 = 0x8CF8,
        ColorAttachment25 = 0x8CF9,
        ColorAttachment26 = 0x8CFA,
        ColorAttachment27 = 0x8CFB,
        ColorAttachment28 = 0x8CFC,
        ColorAttachment29 = 0x8CFD,
        ColorAttachment30 = 0x8CFE,
        ColorAttachment31 = 0x8CFF,
        DepthAttachment = 0x8D00,
        DepthStencilAttachment = 0x821A,
        DepthAttachmentEXT = 0x8D00,
        DepthAttachmentOES = 0x8D00,
    }

    public enum RenderbufferTarget
    {
        Renderbuffer = 0x8D41,
    }

    public enum FramebufferTarget
    {
        Framebuffer = 0x8D40,
        DrawFramebuffer = 0x8CA9,
        ReadFramebuffer = 0x8CA8,
    }

    public enum TextureUnit
    {
        Texture0 = 0x84C0,
        Texture1 = 0x84C1,
        Texture2 = 0x84C2,
        Texture3 = 0x84C3,
        Texture4 = 0x84C4,
        Texture5 = 0x84C5,
        Texture6 = 0x84C6,
        Texture7 = 0x84C7,
        Texture8 = 0x84C8,
        Texture9 = 0x84C9,
        Texture10 = 0x84CA,
        Texture11 = 0x84CB,
        Texture12 = 0x84CC,
        Texture13 = 0x84CD,
        Texture14 = 0x84CE,
        Texture15 = 0x84CF,
        Texture16 = 0x84D0,
        Texture17 = 0x84D1,
        Texture18 = 0x84D2,
        Texture19 = 0x84D3,
        Texture20 = 0x84D4,
        Texture21 = 0x84D5,
        Texture22 = 0x84D6,
        Texture23 = 0x84D7,
        Texture24 = 0x84D8,
        Texture25 = 0x84D9,
        Texture26 = 0x84DA,
        Texture27 = 0x84DB,
        Texture28 = 0x84DC,
        Texture29 = 0x84DD,
        Texture30 = 0x84DE,
        Texture31 = 0x84DF,
    }

    public enum TypeEnum
    {
        QueryWait = 0x8E13,
        QueryNoWait = 0x8E14,
        QueryByRegionWait = 0x8E15,
        QueryByRegionNoWait = 0x8E16,
    }

    public enum FragmentOpATI
    {
        MovATI = 0x8961,
        AddATI = 0x8963,
        MulATI = 0x8964,
        SubATI = 0x8965,
        Dot3ATI = 0x8966,
        Dot4ATI = 0x8967,
        MadATI = 0x8968,
        LerpATI = 0x8969,
        CndATI = 0x896A,
        Cnd0ATI = 0x896B,
        Dot2AddATI = 0x896C,
    }

    public enum FramebufferStatus
    {
        FramebufferComplete = 0x8CD5,
        FramebufferUndefined = 0x8219,
        FramebufferIncompleteAttachment = 0x8CD6,
        FramebufferIncompleteMissingAttachment = 0x8CD7,
        FramebufferIncompleteDrawBuffer = 0x8CDB,
        FramebufferIncompleteReadBuffer = 0x8CDC,
        FramebufferUnsupported = 0x8CDD,
        FramebufferIncompleteMultisample = 0x8D56,
        FramebufferIncompleteMultisample = 0x8D56,
        FramebufferIncompleteLayerTargets = 0x8DA8,
    }

    public enum GraphicsResetStatus
    {
        NoError = 0,
        GuiltyContextReset = 0x8253,
        InnocentContextReset = 0x8254,
        UnknownContextReset = 0x8255,
    }

    public enum SyncStatus
    {
        AlreadySignaled = 0x911A,
        TimeoutExpired = 0x911B,
        ConditionSatisfied = 0x911C,
        WaitFailed = 0x911D,
    }

    public enum QueryTarget
    {
        SamplesPassed = 0x8914,
        AnySamplesPassed = 0x8C2F,
        AnySamplesPassedConservative = 0x8D6A,
        PrimitivesGenerated = 0x8C87,
        TransformFeedbackPrimitivesWritten = 0x8C88,
        TimeElapsed = 0x88BF,
    }

    public enum QueryCounterTarget
    {
        Timestamp = 0x8E28,
    }

    public enum ConvolutionTarget
    {
        Convolution1D = 0x8010,
        Convolution2D = 0x8011,
    }

    public enum PathFillMode
    {
        Invert = 0x150A,
        CountUpNV = 0x9088,
        CountDownNV = 0x9089,
        PathFillModeNV = 0x9080,
    }

    public enum ColorTableTarget
    {
        ColorTable = 0x80D0,
        PostConvolutionColorTable = 0x80D1,
        PostColorMatrixColorTable = 0x80D2,
    }

    public enum VertexBufferObjectParameter
    {
        BufferAccess = 0x88BB,
        BufferAccessFlags = 0x911F,
        BufferImmutableStorage = 0x821F,
        BufferMapped = 0x88BC,
        BufferMapLength = 0x9120,
        BufferMapOffset = 0x9121,
        BufferSize = 0x8764,
        BufferStorageFlags = 0x8220,
        BufferUsage = 0x8765,
    }

    public enum RenderbufferParameterName
    {
        RenderbufferWidth = 0x8D42,
        RenderbufferHeight = 0x8D43,
        RenderbufferInternalFormat = 0x8D44,
        RenderbufferSamples = 0x8CAB,
        RenderbufferRedSize = 0x8D50,
        RenderbufferGreenSize = 0x8D51,
        RenderbufferBlueSize = 0x8D52,
        RenderbufferAlphaSize = 0x8D53,
        RenderbufferDepthSize = 0x8D54,
        RenderbufferStencilSize = 0x8D55,
    }

    public enum VertexBufferObjectUsage
    {
        StreamDraw = 0x88E0,
        StreamRead = 0x88E1,
        StreamCopy = 0x88E2,
        StaticDraw = 0x88E4,
        StaticRead = 0x88E5,
        StaticCopy = 0x88E6,
        DynamicDraw = 0x88E8,
        DynamicRead = 0x88E9,
        DynamicCopy = 0x88EA,
    }

    public enum FramebufferParameterName
    {
        FramebufferDefaultWidth = 0x9310,
        FramebufferDefaultHeight = 0x9311,
        FramebufferDefaultLayers = 0x9312,
        FramebufferDefaultSamples = 0x9313,
        FramebufferDefaultFixedSampleLocations = 0x9314,
    }

    public enum ProgramParameterPName
    {
        ProgramBinaryRetrievableHint = 0x8257,
        ProgramSeparable = 0x8258,
    }

    public enum BlendingFactor
    {
        Zero = 0,
        One = 1,
        SrcColor = 0x0300,
        OneMinusSrcColor = 0x0301,
        DstColor = 0x0306,
        OneMinusDstColor = 0x0307,
        SrcAlpha = 0x0302,
        OneMinusSrcAlpha = 0x0303,
        DstAlpha = 0x0304,
        OneMinusDstAlpha = 0x0305,
        ConstantColor = 0x8001,
        OneMinusConstantColor = 0x8002,
        ConstantAlpha = 0x8003,
        OneMinusConstantAlpha = 0x8004,
        SrcAlphaSaturate = 0x0308,
        Src1Color = 0x88F9,
        OneMinusSrc1Color = 0x88FA,
        Src1Alpha = 0x8589,
        OneMinusSrc1Alpha = 0x88FB,
    }

    public enum BindTransformFeedbackTarget
    {
        TransformFeedback = 0x8E22,
    }

    public enum BlitFramebufferFilter
    {
        Nearest = 0x2600,
        Linear = 0x2601,
    }

    public enum BufferStorageTarget
    {
        ArrayBuffer = 0x8892,
        AtomicCounterBuffer = 0x92C0,
        CopyReadBuffer = 0x8F36,
        CopyWriteBuffer = 0x8F37,
        DispatchIndirectBuffer = 0x90EE,
        DrawIndirectBuffer = 0x8F3F,
        ElementArrayBuffer = 0x8893,
        PixelPackBuffer = 0x88EB,
        PixelUnpackBuffer = 0x88EC,
        QueryBuffer = 0x9192,
        ShaderStorageBuffer = 0x90D2,
        TextureBuffer = 0x8C2A,
        TransformFeedbackBuffer = 0x8C8E,
        UniformBuffer = 0x8A11,
    }

    public enum CheckFramebufferStatusTarget
    {
        DrawFramebuffer = 0x8CA9,
        ReadFramebuffer = 0x8CA8,
        Framebuffer = 0x8D40,
    }

    public enum Buffer
    {
        Color = 0x1800,
        Depth = 0x1801,
        Stencil = 0x1802,
    }

    public enum ClipControlOrigin
    {
        LowerLeft = 0x8CA1,
        UpperLeft = 0x8CA2,
    }

    public enum ClipControlDepth
    {
        NegativeOneToOne = 0x935E,
        ZeroToOne = 0x935F,
    }

    public enum CopyBufferSubDataTarget
    {
        ArrayBuffer = 0x8892,
        AtomicCounterBuffer = 0x92C0,
        CopyReadBuffer = 0x8F36,
        CopyWriteBuffer = 0x8F37,
        DispatchIndirectBuffer = 0x90EE,
        DrawIndirectBuffer = 0x8F3F,
        ElementArrayBuffer = 0x8893,
        PixelPackBuffer = 0x88EB,
        PixelUnpackBuffer = 0x88EC,
        QueryBuffer = 0x9192,
        ShaderStorageBuffer = 0x90D2,
        TextureBuffer = 0x8C2A,
        TransformFeedbackBuffer = 0x8C8E,
        UniformBuffer = 0x8A11,
    }

    public enum DebugSource
    {
        DebugSourceApi = 0x8246,
        DebugSourceWindowSystem = 0x8247,
        DebugSourceShaderCompiler = 0x8248,
        DebugSourceThirdParty = 0x8249,
        DebugSourceApplication = 0x824A,
        DebugSourceOther = 0x824B,
        DontCare = 0x1100,
    }

    public enum DebugType
    {
        DebugTypeError = 0x824C,
        DebugTypeDeprecatedBehavior = 0x824D,
        DebugTypeUndefinedBehavior = 0x824E,
        DebugTypePortability = 0x824F,
        DebugTypePerformance = 0x8250,
        DebugTypeMarker = 0x8268,
        DebugTypePushGroup = 0x8269,
        DebugTypePopGroup = 0x826A,
        DebugTypeOther = 0x8251,
        DontCare = 0x1100,
    }

    public enum DebugSeverity
    {
        DebugSeverityLow = 0x9148,
        DebugSeverityMedium = 0x9147,
        DebugSeverityHigh = 0x9146,
        DebugSeverityNotification = 0x826B,
        DontCare = 0x1100,
    }

    public enum SyncCondition
    {
        SyncGpuCommandsComplete = 0x9117,
    }

    public enum FogPName
    {
        FogMode = 0x0B65,
        FogDensity = 0x0B62,
        FogStart = 0x0B63,
        FogEnd = 0x0B64,
        FogIndex = 0x0B61,
        FogCoordSrc = 0x8450,
    }

    public enum AtomicCounterBufferPName
    {
        AtomicCounterBufferBinding = 0x92C1,
        AtomicCounterBufferDataSize = 0x92C4,
        AtomicCounterBufferActiveAtomicCounters = 0x92C5,
        AtomicCounterBufferActiveAtomicCounterIndices = 0x92C6,
        AtomicCounterBufferReferencedByVertexShader = 0x92C7,
        AtomicCounterBufferReferencedByTessControlShader = 0x92C8,
        AtomicCounterBufferReferencedByTessEvaluationShader = 0x92C9,
        AtomicCounterBufferReferencedByGeometryShader = 0x92CA,
        AtomicCounterBufferReferencedByFragmentShader = 0x92CB,
        AtomicCounterBufferReferencedByComputeShader = 0x90ED,
    }

    public enum UniformBlockPName
    {
        UniformBlockBinding = 0x8A3F,
        UniformBlockDataSize = 0x8A40,
        UniformBlockNameLength = 0x8A41,
        UniformBlockActiveUniforms = 0x8A42,
        UniformBlockActiveUniformIndices = 0x8A43,
        UniformBlockReferencedByVertexShader = 0x8A44,
        UniformBlockReferencedByTessControlShader = 0x84F0,
        UniformBlockReferencedByTessEvaluationShader = 0x84F1,
        UniformBlockReferencedByGeometryShader = 0x8A45,
        UniformBlockReferencedByFragmentShader = 0x8A46,
        UniformBlockReferencedByComputeShader = 0x90EC,
    }

    public enum UniformPName
    {
        UniformType = 0x8A37,
        UniformSize = 0x8A38,
        UniformNameLength = 0x8A39,
        UniformBlockIndex = 0x8A3A,
        UniformOffset = 0x8A3B,
        UniformArrayStride = 0x8A3C,
        UniformMatrixStride = 0x8A3D,
        UniformIsRowMajor = 0x8A3E,
        UniformAtomicCounterBufferIndex = 0x92DA,
    }

    public enum SamplerParameterName
    {
        TextureWrapS = 0x2802,
        TextureWrapT = 0x2803,
        TextureWrapR = 0x8072,
        TextureMinFilter = 0x2801,
        TextureMagFilter = 0x2800,
        TextureBorderColor = 0x1004,
        TextureMinLod = 0x813A,
        TextureMaxLod = 0x813B,
        TextureCompareMode = 0x884C,
        TextureCompareFunc = 0x884D,
    }

    public enum VertexProvokingMode
    {
        FirstVertexConvention = 0x8E4D,
        LastVertexConvention = 0x8E4E,
    }

    public enum PatchParameterName
    {
        PatchVertices = 0x8E72,
        PatchDefaultOuterLevel = 0x8E74,
        PatchDefaultInnerLevel = 0x8E73,
    }

    public enum ObjectIdentifier
    {
        Buffer = 0x82E0,
        Shader = 0x82E1,
        Program = 0x82E2,
        VertexArray = 0x8074,
        Query = 0x82E3,
        ProgramPipeline = 0x82E4,
        TransformFeedback = 0x8E22,
        Sampler = 0x82E6,
        Texture = 0x1702,
        Renderbuffer = 0x8D41,
        Framebuffer = 0x8D40,
    }

    public enum ColorBuffer
    {
        None = 0,
        FrontLeft = 0x0400,
        FrontRight = 0x0401,
        BackLeft = 0x0402,
        BackRight = 0x0403,
        Front = 0x0404,
        Back = 0x0405,
        Left = 0x0406,
        Right = 0x0407,
        FrontAndBack = 0x0408,
        None = 0,
        ColorAttachment0 = 0x8CE0,
        ColorAttachment1 = 0x8CE1,
        ColorAttachment2 = 0x8CE2,
        ColorAttachment3 = 0x8CE3,
        ColorAttachment4 = 0x8CE4,
        ColorAttachment5 = 0x8CE5,
        ColorAttachment6 = 0x8CE6,
        ColorAttachment7 = 0x8CE7,
        ColorAttachment8 = 0x8CE8,
        ColorAttachment9 = 0x8CE9,
        ColorAttachment10 = 0x8CEA,
        ColorAttachment11 = 0x8CEB,
        ColorAttachment12 = 0x8CEC,
        ColorAttachment13 = 0x8CED,
        ColorAttachment14 = 0x8CEE,
        ColorAttachment15 = 0x8CEF,
        ColorAttachment16 = 0x8CF0,
        ColorAttachment17 = 0x8CF1,
        ColorAttachment18 = 0x8CF2,
        ColorAttachment19 = 0x8CF3,
        ColorAttachment20 = 0x8CF4,
        ColorAttachment21 = 0x8CF5,
        ColorAttachment22 = 0x8CF6,
        ColorAttachment23 = 0x8CF7,
        ColorAttachment24 = 0x8CF8,
        ColorAttachment25 = 0x8CF9,
        ColorAttachment26 = 0x8CFA,
        ColorAttachment27 = 0x8CFB,
        ColorAttachment28 = 0x8CFC,
        ColorAttachment29 = 0x8CFD,
        ColorAttachment30 = 0x8CFE,
        ColorAttachment31 = 0x8CFF,
    }

    public enum MapQuery
    {
        Coeff = 0x0A00,
        Order = 0x0A01,
        Domain = 0x0A02,
    }

    public enum VertexArrayPName
    {
        VertexAttribArrayEnabled = 0x8622,
        VertexAttribArraySize = 0x8623,
        VertexAttribArrayStride = 0x8624,
        VertexAttribArrayType = 0x8625,
        VertexAttribArrayNormalized = 0x886A,
        VertexAttribArrayInteger = 0x88FD,
        VertexAttribArrayLong = 0x874E,
        VertexAttribArrayDivisor = 0x88FE,
        VertexAttribRelativeOffset = 0x82D5,
    }

    public enum TransformFeedbackPName
    {
        TransformFeedbackBufferBinding = 0x8C8F,
        TransformFeedbackBufferStart = 0x8C84,
        TransformFeedbackBufferSize = 0x8C85,
        TransformFeedbackPaused = 0x8E23,
        TransformFeedbackActive = 0x8E24,
    }

    public enum SyncParameterName
    {
        ObjectType = 0x9112,
        SyncStatus = 0x9114,
        SyncCondition = 0x9113,
        SyncFlags = 0x9115,
    }

    public enum ShaderParameterName
    {
        ShaderType = 0x8B4F,
        DeleteStatus = 0x8B80,
        CompileStatus = 0x8B81,
        InfoLogLength = 0x8B84,
        ShaderSourceLength = 0x8B88,
    }

    public enum QueryObjectParameterName
    {
        QueryResultAvailable = 0x8867,
        QueryResult = 0x8866,
        QueryResultNoWait = 0x9194,
        QueryTarget = 0x82EA,
    }

    public enum QueryParameterName
    {
        CurrentQuery = 0x8865,
        QueryCounterBits = 0x8864,
    }

    public enum ProgramStagePName
    {
        ActiveSubroutineUniforms = 0x8DE6,
        ActiveSubroutineUniformLocations = 0x8E47,
        ActiveSubroutines = 0x8DE5,
        ActiveSubroutineUniformMaxLength = 0x8E49,
        ActiveSubroutineMaxLength = 0x8E48,
    }

    public enum PipelineParameterName
    {
        ActiveProgram = 0x8259,
        VertexShader = 0x8B31,
        TessControlShader = 0x8E88,
        TessEvaluationShader = 0x8E87,
        GeometryShader = 0x8DD9,
        FragmentShader = 0x8B30,
        InfoLogLength = 0x8B84,
    }

    public enum ProgramInterface
    {
        Uniform = 0x92E1,
        UniformBlock = 0x92E2,
        ProgramInput = 0x92E3,
        ProgramOutput = 0x92E4,
        VertexSubroutine = 0x92E8,
        TessControlSubroutine = 0x92E9,
        TessEvaluationSubroutine = 0x92EA,
        GeometrySubroutine = 0x92EB,
        FragmentSubroutine = 0x92EC,
        ComputeSubroutine = 0x92ED,
        VertexSubroutineUniform = 0x92EE,
        TessControlSubroutineUniform = 0x92EF,
        TessEvaluationSubroutineUniform = 0x92F0,
        GeometrySubroutineUniform = 0x92F1,
        FragmentSubroutineUniform = 0x92F2,
        ComputeSubroutineUniform = 0x92F3,
        TransformFeedbackVarying = 0x92F4,
        TransformFeedbackBuffer = 0x8C8E,
        BufferVariable = 0x92E5,
        ShaderStorageBlock = 0x92E6,
    }

    public enum VertexAttribEnum
    {
        VertexAttribArrayBufferBinding = 0x889F,
        VertexAttribArrayEnabled = 0x8622,
        VertexAttribArraySize = 0x8623,
        VertexAttribArrayStride = 0x8624,
        VertexAttribArrayType = 0x8625,
        VertexAttribArrayNormalized = 0x886A,
        VertexAttribArrayInteger = 0x88FD,
        VertexAttribArrayDivisor = 0x88FE,
        CurrentVertexAttrib = 0x8626,
    }

    public enum VertexAttribType
    {
        Byte = 0x1400,
        Short = 0x1402,
        Int = 0x1404,
        Fixed = 0x140C,
        Float = 0x1406,
        HalfFloat = 0x140B,
        Double = 0x140A,
        UnsignedByte = 0x1401,
        UnsignedShort = 0x1403,
        UnsignedInt = 0x1405,
        Int2101010Rev = 0x8D9F,
        UnsignedInt2101010Rev = 0x8368,
        UnsignedInt10f11f11fRev = 0x8C3B,
    }

    public enum InternalFormatPName
    {
        NumSampleCounts = 0x9380,
        Samples = 0x80A9,
        InternalformatSupported = 0x826F,
        InternalformatPreferred = 0x8270,
        InternalformatRedSize = 0x8271,
        InternalformatGreenSize = 0x8272,
        InternalformatBlueSize = 0x8273,
        InternalformatAlphaSize = 0x8274,
        InternalformatDepthSize = 0x8275,
        InternalformatStencilSize = 0x8276,
        InternalformatSharedSize = 0x8277,
        InternalformatRedType = 0x8278,
        InternalformatGreenType = 0x8279,
        InternalformatBlueType = 0x827A,
        InternalformatAlphaType = 0x827B,
        InternalformatDepthType = 0x827C,
        InternalformatStencilType = 0x827D,
        MaxWidth = 0x827E,
        MaxHeight = 0x827F,
        MaxDepth = 0x8280,
        MaxLayers = 0x8281,
        ColorComponents = 0x8283,
        ColorRenderable = 0x8286,
        DepthRenderable = 0x8287,
        StencilRenderable = 0x8288,
        FramebufferRenderable = 0x8289,
        FramebufferRenderableLayered = 0x828A,
        FramebufferBlend = 0x828B,
        ReadPixels = 0x828C,
        ReadPixelsFormat = 0x828D,
        ReadPixelsType = 0x828E,
        TextureImageFormat = 0x828F,
        TextureImageType = 0x8290,
        GetTextureImageFormat = 0x8291,
        GetTextureImageType = 0x8292,
        Mipmap = 0x8293,
        GenerateMipmap = 0x8191,
        AutoGenerateMipmap = 0x8295,
        ColorEncoding = 0x8296,
        SrgbRead = 0x8297,
        SrgbWrite = 0x8298,
        Filter = 0x829A,
        VertexTexture = 0x829B,
        TessControlTexture = 0x829C,
        TessEvaluationTexture = 0x829D,
        GeometryTexture = 0x829E,
        FragmentTexture = 0x829F,
        ComputeTexture = 0x82A0,
        TextureShadow = 0x82A1,
        TextureGather = 0x82A2,
        TextureGatherShadow = 0x82A3,
        ShaderImageLoad = 0x82A4,
        ShaderImageStore = 0x82A5,
        ShaderImageAtomic = 0x82A6,
        ImageTexelSize = 0x82A7,
        ImageCompatibilityClass = 0x82A8,
        ImagePixelFormat = 0x82A9,
        ImagePixelType = 0x82AA,
        ImageFormatCompatibilityType = 0x90C7,
        SimultaneousTextureAndDepthTest = 0x82AC,
        SimultaneousTextureAndStencilTest = 0x82AD,
        SimultaneousTextureAndDepthWrite = 0x82AE,
        SimultaneousTextureAndStencilWrite = 0x82AF,
        TextureCompressed = 0x86A1,
        TextureCompressedBlockWidth = 0x82B1,
        TextureCompressedBlockHeight = 0x82B2,
        TextureCompressedBlockSize = 0x82B3,
        ClearBuffer = 0x82B4,
        TextureView = 0x82B5,
        ViewCompatibilityClass = 0x82B6,
        ClearTexture = 0x9365,
    }

    public enum FramebufferAttachmentParameterName
    {
        FramebufferAttachmentRedSize = 0x8212,
        FramebufferAttachmentGreenSize = 0x8213,
        FramebufferAttachmentBlueSize = 0x8214,
        FramebufferAttachmentAlphaSize = 0x8215,
        FramebufferAttachmentDepthSize = 0x8216,
        FramebufferAttachmentStencilSize = 0x8217,
        FramebufferAttachmentComponentType = 0x8211,
        FramebufferAttachmentColorEncoding = 0x8210,
        FramebufferAttachmentObjectName = 0x8CD1,
        FramebufferAttachmentObjectName = 0x8CD1,
        FramebufferAttachmentTextureLevel = 0x8CD2,
        FramebufferAttachmentTextureCubeMapFace = 0x8CD3,
        FramebufferAttachmentLayered = 0x8DA7,
        FramebufferAttachmentTextureLayer = 0x8CD4,
    }

    public enum ProgramInterfacePName
    {
        ActiveResources = 0x92F5,
        MaxNameLength = 0x92F6,
        MaxNumActiveVariables = 0x92F7,
        MaxNumCompatibleSubroutines = 0x92F8,
    }

    public enum PrecisionType
    {
        LowFloat = 0x8DF0,
        MediumFloat = 0x8DF1,
        HighFloat = 0x8DF2,
        LowInt = 0x8DF3,
        MediumInt = 0x8DF4,
        HighInt = 0x8DF5,
    }

    public enum VertexAttribPointerType
    {
        Byte = 0x1400,
        UnsignedByte = 0x1401,
        Short = 0x1402,
        UnsignedShort = 0x1403,
        Int = 0x1404,
        UnsignedInt = 0x1405,
        Float = 0x1406,
        Double = 0x140A,
        HalfFloat = 0x140B,
        Fixed = 0x140C,
        Int2101010Rev = 0x8D9F,
        UnsignedInt2101010Rev = 0x8368,
        UnsignedInt10f11f11fRev = 0x8C3B,
    }

    public enum SubroutineParameterName
    {
        NumCompatibleSubroutines = 0x8E4A,
        CompatibleSubroutines = 0x8E4B,
        UniformSize = 0x8A38,
        UniformNameLength = 0x8A39,
    }

    public enum GetFramebufferParameter
    {
        FramebufferDefaultWidth = 0x9310,
        FramebufferDefaultHeight = 0x9311,
        FramebufferDefaultLayers = 0x9312,
        FramebufferDefaultSamples = 0x9313,
        FramebufferDefaultFixedSampleLocations = 0x9314,
        Doublebuffer = 0x0C32,
        ImplementationColorReadFormat = 0x8B9B,
        ImplementationColorReadType = 0x8B9A,
        Samples = 0x80A9,
        SampleBuffers = 0x80A8,
        Stereo = 0x0C33,
    }

    public enum PathStringFormat
    {
        PathFormatSvgNV = 0x9070,
        PathFormatPsNV = 0x9071,
    }

    public enum PathFontTarget
    {
        StandardFontNameNV = 0x9072,
        SystemFontNameNV = 0x9073,
        FileNameNV = 0x9074,
    }

    public enum PathHandleMissingGlyphs
    {
        SkipMissingGlyphNV = 0x90A9,
        UseMissingGlyphNV = 0x90AA,
    }

    public enum PathParameter
    {
        PathStrokeWidthNV = 0x9075,
        PathInitialEndCapNV = 0x9077,
        PathTerminalEndCapNV = 0x9078,
        PathJoinStyleNV = 0x9079,
        PathMiterLimitNV = 0x907A,
        PathInitialDashCapNV = 0x907C,
        PathTerminalDashCapNV = 0x907D,
        PathDashOffsetNV = 0x907E,
        PathClientLengthNV = 0x907F,
        PathDashOffsetResetNV = 0x90B4,
        PathFillModeNV = 0x9080,
        PathFillMaskNV = 0x9081,
        PathFillCoverModeNV = 0x9082,
        PathStrokeCoverModeNV = 0x9083,
        PathStrokeMaskNV = 0x9084,
        PathEndCapsNV = 0x9076,
        PathDashCapsNV = 0x907B,
        PathCommandCountNV = 0x909D,
        PathCoordCountNV = 0x909E,
        PathDashArrayCountNV = 0x909F,
        PathComputedLengthNV = 0x90A0,
        PathObjectBoundingBoxNV = 0x908A,
        PathFillBoundingBoxNV = 0x90A1,
        PathStrokeBoundingBoxNV = 0x90A2,
    }

    public enum PathColor
    {
        PrimaryColor = 0x8577,
        PrimaryColorNV = 0x852C,
        SecondaryColorNV = 0x852D,
    }

    public enum PathGenMode
    {
        None = 0,
        EyeLinear = 0x2400,
        ObjectLinear = 0x2401,
        PathObjectBoundingBoxNV = 0x908A,
        Constant = 0x8576,
    }

    public enum TextureLayout
    {
        LayoutGeneralEXT = 0x958D,
        LayoutColorAttachmentEXT = 0x958E,
        LayoutDepthStencilAttachmentEXT = 0x958F,
        LayoutDepthStencilReadOnlyEXT = 0x9590,
        LayoutShaderReadOnlyEXT = 0x9591,
        LayoutTransferSrcEXT = 0x9592,
        LayoutTransferDstEXT = 0x9593,
        LayoutDepthReadOnlyStencilAttachmentEXT = 0x9530,
        LayoutDepthAttachmentStencilReadOnlyEXT = 0x9531,
    }

    public enum PathTransformType
    {
        None = 0,
        TranslateXNV = 0x908E,
        TranslateYNV = 0x908F,
        Translate2DNV = 0x9090,
        Translate3DNV = 0x9091,
        Affine2DNV = 0x9092,
        Affine3DNV = 0x9094,
        TransposeAffine2DNV = 0x9096,
        TransposeAffine3DNV = 0x9098,
    }

    public enum PathElementType
    {
        Utf8NV = 0x909A,
        Utf16NV = 0x909B,
    }

    public enum PathCoverMode
    {
        ConvexHullNV = 0x908B,
        BoundingBoxNV = 0x908D,
        BoundingBoxOfBoundingBoxesNV = 0x909C,
        PathFillCoverModeNV = 0x9082,
    }

    public enum PathFontStyle
    {
        None = 0,
        BoldBitNV = 0x01,
        ItalicBitNV = 0x02,
    }

    public enum PathMetricMask
    {
        GlyphWidthBitNV = 0x01,
        GlyphHeightBitNV = 0x02,
        GlyphHorizontalBearingXBitNV = 0x04,
        GlyphHorizontalBearingYBitNV = 0x08,
        GlyphHorizontalBearingAdvanceBitNV = 0x10,
        GlyphVerticalBearingXBitNV = 0x20,
        GlyphVerticalBearingYBitNV = 0x40,
        GlyphVerticalBearingAdvanceBitNV = 0x80,
        GlyphHasKerningBitNV = 0x100,
        FontXMinBoundsBitNV = 0x00010000,
        FontYMinBoundsBitNV = 0x00020000,
        FontXMaxBoundsBitNV = 0x00040000,
        FontYMaxBoundsBitNV = 0x00080000,
        FontUnitsPerEmBitNV = 0x00100000,
        FontAscenderBitNV = 0x00200000,
        FontDescenderBitNV = 0x00400000,
        FontHeightBitNV = 0x00800000,
        FontMaxAdvanceWidthBitNV = 0x01000000,
        FontMaxAdvanceHeightBitNV = 0x02000000,
        FontUnderlinePositionBitNV = 0x04000000,
        FontUnderlineThicknessBitNV = 0x08000000,
        FontHasKerningBitNV = 0x10000000,
        FontNumGlyphIndicesBitNV = 0x20000000,
    }

    public enum PathListMode
    {
        AccumAdjacentPairsNV = 0x90AD,
        AdjacentPairsNV = 0x90AE,
        FirstToRestNV = 0x90AF,
    }

    public enum ProgramPropertyARB
    {
        DeleteStatus = 0x8B80,
        LinkStatus = 0x8B82,
        ValidateStatus = 0x8B83,
        InfoLogLength = 0x8B84,
        AttachedShaders = 0x8B85,
        ActiveAtomicCounterBuffers = 0x92D9,
        ActiveAttributes = 0x8B89,
        ActiveAttributeMaxLength = 0x8B8A,
        ActiveUniforms = 0x8B86,
        ActiveUniformBlocks = 0x8A36,
        ActiveUniformBlockMaxNameLength = 0x8A35,
        ActiveUniformMaxLength = 0x8B87,
        ComputeWorkGroupSize = 0x8267,
        ProgramBinaryLength = 0x8741,
        TransformFeedbackBufferMode = 0x8C7F,
        TransformFeedbackVaryings = 0x8C83,
        TransformFeedbackVaryingMaxLength = 0x8C76,
        GeometryVerticesOut = 0x8916,
        GeometryInputType = 0x8917,
        GeometryOutputType = 0x8918,
    }


    [SuppressUnmanagedCodeSecurity]
    [SuppressMessage("ReSharper", "StringLiteralTypo")]
    [SuppressMessage("ReSharper", "IdentifierTypo")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static class Gl
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCULLFACEPROC(CullFaceMode mode);
        private static PFNGLCULLFACEPROC glCullFace;

        public static void CullFace(CullFaceMode mode)
        {
            glCullFace.Invoke(mode);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFRONTFACEPROC(FrontFaceDirection mode);
        private static PFNGLFRONTFACEPROC glFrontFace;

        public static void FrontFace(FrontFaceDirection mode)
        {
            glFrontFace.Invoke(mode);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLHINTPROC(HintTarget target, HintMode mode);
        private static PFNGLHINTPROC glHint;

        public static void Hint(HintTarget target, HintMode mode)
        {
            glHint.Invoke(target, mode);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLLINEWIDTHPROC(float width);
        private static PFNGLLINEWIDTHPROC glLineWidth;

        public static void LineWidth(float width)
        {
            glLineWidth.Invoke(width);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPOINTSIZEPROC(float size);
        private static PFNGLPOINTSIZEPROC glPointSize;

        public static void PointSize(float size)
        {
            glPointSize.Invoke(size);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPOLYGONMODEPROC(MaterialFace face, PolygonMode mode);
        private static PFNGLPOLYGONMODEPROC glPolygonMode;

        public static void PolygonMode(MaterialFace face, PolygonMode mode)
        {
            glPolygonMode.Invoke(face, mode);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSCISSORPROC(int x, int y, int width, int height);
        private static PFNGLSCISSORPROC glScissor;

        public static void Scissor(int x, int y, int width, int height)
        {
            glScissor.Invoke(x, y, width, height);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXPARAMETERFPROC(TextureTarget target, TextureParameterName pname, float param);
        private static PFNGLTEXPARAMETERFPROC glTexParameterf;

        public static void TexParameterf(TextureTarget target, TextureParameterName pname, float param)
        {
            glTexParameterf.Invoke(target, pname, param);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXPARAMETERFVPROC(TextureTarget target, TextureParameterName pname, float[] parameters);
        private static PFNGLTEXPARAMETERFVPROC glTexParameterfv;

        public static void TexParameterfv(TextureTarget target, TextureParameterName pname, float[] parameters)
        {
            glTexParameterfv.Invoke(target, pname, parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXPARAMETERIPROC(TextureTarget target, TextureParameterName pname, int param);
        private static PFNGLTEXPARAMETERIPROC glTexParameteri;

        public static void TexParameteri(TextureTarget target, TextureParameterName pname, int param)
        {
            glTexParameteri.Invoke(target, pname, param);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXPARAMETERIVPROC(TextureTarget target, TextureParameterName pname, int[] parameters);
        private static PFNGLTEXPARAMETERIVPROC glTexParameteriv;

        public static void TexParameteriv(TextureTarget target, TextureParameterName pname, int[] parameters)
        {
            glTexParameteriv.Invoke(target, pname, parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXIMAGE1DPROC(TextureTarget target, int level, int internalformat, int width, int border, PixelFormat format, PixelType type, IntPtr pixels);
        private static PFNGLTEXIMAGE1DPROC glTexImage1D;

        public static void TexImage1D(TextureTarget target, int level, int internalformat, int width, int border, PixelFormat format, PixelType type, IntPtr pixels)
        {
            glTexImage1D.Invoke(target, level, internalformat, width, border, format, type, pixels);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXIMAGE2DPROC(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels);
        private static PFNGLTEXIMAGE2DPROC glTexImage2D;

        public static void TexImage2D(TextureTarget target, int level, int internalformat, int width, int height, int border, PixelFormat format, PixelType type, IntPtr pixels)
        {
            glTexImage2D.Invoke(target, level, internalformat, width, height, border, format, type, pixels);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWBUFFERPROC(DrawBufferMode buf);
        private static PFNGLDRAWBUFFERPROC glDrawBuffer;

        public static void DrawBuffer(DrawBufferMode buf)
        {
            glDrawBuffer.Invoke(buf);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCLEARPROC(ClearBufferMask mask);
        private static PFNGLCLEARPROC glClear;

        public static void Clear(ClearBufferMask mask)
        {
            glClear.Invoke(mask);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCLEARCOLORPROC(float red, float green, float blue, float alpha);
        private static PFNGLCLEARCOLORPROC glClearColor;

        public static void ClearColor(float red, float green, float blue, float alpha)
        {
            glClearColor.Invoke(red, green, blue, alpha);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCLEARSTENCILPROC(int s);
        private static PFNGLCLEARSTENCILPROC glClearStencil;

        public static void ClearStencil(int s)
        {
            glClearStencil.Invoke(s);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCLEARDEPTHPROC(double depth);
        private static PFNGLCLEARDEPTHPROC glClearDepth;

        public static void ClearDepth(double depth)
        {
            glClearDepth.Invoke(depth);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSTENCILMASKPROC(uint mask);
        private static PFNGLSTENCILMASKPROC glStencilMask;

        public static void StencilMask(uint mask)
        {
            glStencilMask.Invoke(mask);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOLORMASKPROC(bool red, bool green, bool blue, bool alpha);
        private static PFNGLCOLORMASKPROC glColorMask;

        public static void ColorMask(bool red, bool green, bool blue, bool alpha)
        {
            glColorMask.Invoke(red, green, blue, alpha);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDEPTHMASKPROC(bool flag);
        private static PFNGLDEPTHMASKPROC glDepthMask;

        public static void DepthMask(bool flag)
        {
            glDepthMask.Invoke(flag);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDISABLEPROC(EnableCap cap);
        private static PFNGLDISABLEPROC glDisable;

        public static void Disable(EnableCap cap)
        {
            glDisable.Invoke(cap);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLENABLEPROC(EnableCap cap);
        private static PFNGLENABLEPROC glEnable;

        public static void Enable(EnableCap cap)
        {
            glEnable.Invoke(cap);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFINISHPROC();
        private static PFNGLFINISHPROC glFinish;

        public static void Finish()
        {
            glFinish.Invoke();
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFLUSHPROC();
        private static PFNGLFLUSHPROC glFlush;

        public static void Flush()
        {
            glFlush.Invoke();
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBLENDFUNCPROC(BlendingFactor sfactor, BlendingFactor dfactor);
        private static PFNGLBLENDFUNCPROC glBlendFunc;

        public static void BlendFunc(BlendingFactor sfactor, BlendingFactor dfactor)
        {
            glBlendFunc.Invoke(sfactor, dfactor);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLLOGICOPPROC(LogicOp opcode);
        private static PFNGLLOGICOPPROC glLogicOp;

        public static void LogicOp(LogicOp opcode)
        {
            glLogicOp.Invoke(opcode);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSTENCILFUNCPROC(StencilFunction func, int reference, uint mask);
        private static PFNGLSTENCILFUNCPROC glStencilFunc;

        public static void StencilFunc(StencilFunction func, int reference, uint mask)
        {
            glStencilFunc.Invoke(func, reference, mask);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSTENCILOPPROC(StencilOp fail, StencilOp zfail, StencilOp zpass);
        private static PFNGLSTENCILOPPROC glStencilOp;

        public static void StencilOp(StencilOp fail, StencilOp zfail, StencilOp zpass)
        {
            glStencilOp.Invoke(fail, zfail, zpass);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDEPTHFUNCPROC(DepthFunction func);
        private static PFNGLDEPTHFUNCPROC glDepthFunc;

        public static void DepthFunc(DepthFunction func)
        {
            glDepthFunc.Invoke(func);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPIXELSTOREFPROC(PixelStoreParameter pname, float param);
        private static PFNGLPIXELSTOREFPROC glPixelStoref;

        public static void PixelStoref(PixelStoreParameter pname, float param)
        {
            glPixelStoref.Invoke(pname, param);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPIXELSTOREIPROC(PixelStoreParameter pname, int param);
        private static PFNGLPIXELSTOREIPROC glPixelStorei;

        public static void PixelStorei(PixelStoreParameter pname, int param)
        {
            glPixelStorei.Invoke(pname, param);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLREADBUFFERPROC(ReadBufferMode src);
        private static PFNGLREADBUFFERPROC glReadBuffer;

        public static void ReadBuffer(ReadBufferMode src)
        {
            glReadBuffer.Invoke(src);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLREADPIXELSPROC(int x, int y, int width, int height, PixelFormat format, PixelType type, out IntPtr pixels);
        private static PFNGLREADPIXELSPROC glReadPixels;

        public static void ReadPixels(int x, int y, int width, int height, PixelFormat format, PixelType type, out IntPtr pixels)
        {
            glReadPixels.Invoke(x, y, width, height, format, type, out pixels);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETBOOLEANVPROC(GetPName pname, out bool data);
        private static PFNGLGETBOOLEANVPROC glGetBooleanv;

        public static void GetBooleanv(GetPName pname, out bool data)
        {
            glGetBooleanv.Invoke(pname, out data);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETDOUBLEVPROC(GetPName pname, out double data);
        private static PFNGLGETDOUBLEVPROC glGetDoublev;

        public static void GetDoublev(GetPName pname, out double data)
        {
            glGetDoublev.Invoke(pname, out data);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate ErrorCode PFNGLGETERRORPROC();
        private static PFNGLGETERRORPROC glGetError;

        public static ErrorCode GetError()
        {
            return glGetError.Invoke();
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETFLOATVPROC(GetPName pname, out float data);
        private static PFNGLGETFLOATVPROC glGetFloatv;

        public static void GetFloatv(GetPName pname, out float data)
        {
            glGetFloatv.Invoke(pname, out data);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETINTEGERVPROC(GetPName pname, out int data);
        private static PFNGLGETINTEGERVPROC glGetIntegerv;

        public static void GetIntegerv(GetPName pname, out int data)
        {
            glGetIntegerv.Invoke(pname, out data);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr PFNGLGETSTRINGPROC(StringName name);
        private static PFNGLGETSTRINGPROC glGetString;

        public static IntPtr GetString(StringName name)
        {
            return glGetString.Invoke(name);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETTEXIMAGEPROC(TextureTarget target, int level, PixelFormat format, PixelType type, out IntPtr pixels);
        private static PFNGLGETTEXIMAGEPROC glGetTexImage;

        public static void GetTexImage(TextureTarget target, int level, PixelFormat format, PixelType type, out IntPtr pixels)
        {
            glGetTexImage.Invoke(target, level, format, type, out pixels);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETTEXPARAMETERFVPROC(TextureTarget target, GetTextureParameter pname, out float parameters);
        private static PFNGLGETTEXPARAMETERFVPROC glGetTexParameterfv;

        public static void GetTexParameterfv(TextureTarget target, GetTextureParameter pname, out float parameters)
        {
            glGetTexParameterfv.Invoke(target, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETTEXPARAMETERIVPROC(TextureTarget target, GetTextureParameter pname, out int parameters);
        private static PFNGLGETTEXPARAMETERIVPROC glGetTexParameteriv;

        public static void GetTexParameteriv(TextureTarget target, GetTextureParameter pname, out int parameters)
        {
            glGetTexParameteriv.Invoke(target, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETTEXLEVELPARAMETERFVPROC(TextureTarget target, int level, GetTextureParameter pname, out float parameters);
        private static PFNGLGETTEXLEVELPARAMETERFVPROC glGetTexLevelParameterfv;

        public static void GetTexLevelParameterfv(TextureTarget target, int level, GetTextureParameter pname, out float parameters)
        {
            glGetTexLevelParameterfv.Invoke(target, level, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETTEXLEVELPARAMETERIVPROC(TextureTarget target, int level, GetTextureParameter pname, out int parameters);
        private static PFNGLGETTEXLEVELPARAMETERIVPROC glGetTexLevelParameteriv;

        public static void GetTexLevelParameteriv(TextureTarget target, int level, GetTextureParameter pname, out int parameters)
        {
            glGetTexLevelParameteriv.Invoke(target, level, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISENABLEDPROC(EnableCap cap);
        private static PFNGLISENABLEDPROC glIsEnabled;

        public static bool IsEnabled(EnableCap cap)
        {
            return glIsEnabled.Invoke(cap);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDEPTHRANGEPROC(double n, double f);
        private static PFNGLDEPTHRANGEPROC glDepthRange;

        public static void DepthRange(double n, double f)
        {
            glDepthRange.Invoke(n, f);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVIEWPORTPROC(int x, int y, int width, int height);
        private static PFNGLVIEWPORTPROC glViewport;

        public static void Viewport(int x, int y, int width, int height)
        {
            glViewport.Invoke(x, y, width, height);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWARRAYSPROC(PrimitiveType mode, int first, int count);
        private static PFNGLDRAWARRAYSPROC glDrawArrays;

        public static void DrawArrays(PrimitiveType mode, int first, int count)
        {
            glDrawArrays.Invoke(mode, first, count);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWELEMENTSPROC(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices);
        private static PFNGLDRAWELEMENTSPROC glDrawElements;

        public static void DrawElements(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices)
        {
            glDrawElements.Invoke(mode, count, type, indices);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPOLYGONOFFSETPROC(float factor, float units);
        private static PFNGLPOLYGONOFFSETPROC glPolygonOffset;

        public static void PolygonOffset(float factor, float units)
        {
            glPolygonOffset.Invoke(factor, units);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOPYTEXIMAGE1DPROC(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int border);
        private static PFNGLCOPYTEXIMAGE1DPROC glCopyTexImage1D;

        public static void CopyTexImage1D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int border)
        {
            glCopyTexImage1D.Invoke(target, level, internalformat, x, y, width, border);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOPYTEXIMAGE2DPROC(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border);
        private static PFNGLCOPYTEXIMAGE2DPROC glCopyTexImage2D;

        public static void CopyTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int x, int y, int width, int height, int border)
        {
            glCopyTexImage2D.Invoke(target, level, internalformat, x, y, width, height, border);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOPYTEXSUBIMAGE1DPROC(TextureTarget target, int level, int xoffset, int x, int y, int width);
        private static PFNGLCOPYTEXSUBIMAGE1DPROC glCopyTexSubImage1D;

        public static void CopyTexSubImage1D(TextureTarget target, int level, int xoffset, int x, int y, int width)
        {
            glCopyTexSubImage1D.Invoke(target, level, xoffset, x, y, width);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOPYTEXSUBIMAGE2DPROC(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height);
        private static PFNGLCOPYTEXSUBIMAGE2DPROC glCopyTexSubImage2D;

        public static void CopyTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height)
        {
            glCopyTexSubImage2D.Invoke(target, level, xoffset, yoffset, x, y, width, height);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXSUBIMAGE1DPROC(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr pixels);
        private static PFNGLTEXSUBIMAGE1DPROC glTexSubImage1D;

        public static void TexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, PixelType type, IntPtr pixels)
        {
            glTexSubImage1D.Invoke(target, level, xoffset, width, format, type, pixels);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXSUBIMAGE2DPROC(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels);
        private static PFNGLTEXSUBIMAGE2DPROC glTexSubImage2D;

        public static void TexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, PixelType type, IntPtr pixels)
        {
            glTexSubImage2D.Invoke(target, level, xoffset, yoffset, width, height, format, type, pixels);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDTEXTUREPROC(TextureTarget target, uint texture);
        private static PFNGLBINDTEXTUREPROC glBindTexture;

        public static void BindTexture(TextureTarget target, uint texture)
        {
            glBindTexture.Invoke(target, texture);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETETEXTURESPROC(int n, uint[] textures);
        private static PFNGLDELETETEXTURESPROC glDeleteTextures;

        public static void DeleteTextures(int n, uint[] textures)
        {
            glDeleteTextures.Invoke(n, textures);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGENTEXTURESPROC(int n, out uint textures);
        private static PFNGLGENTEXTURESPROC glGenTextures;

        public static void GenTextures(int n, out uint textures)
        {
            glGenTextures.Invoke(n, out textures);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISTEXTUREPROC(uint texture);
        private static PFNGLISTEXTUREPROC glIsTexture;

        public static bool IsTexture(uint texture)
        {
            return glIsTexture.Invoke(texture);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWRANGEELEMENTSPROC(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices);
        private static PFNGLDRAWRANGEELEMENTSPROC glDrawRangeElements;

        public static void DrawRangeElements(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices)
        {
            glDrawRangeElements.Invoke(mode, start, end, count, type, indices);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXIMAGE3DPROC(TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels);
        private static PFNGLTEXIMAGE3DPROC glTexImage3D;

        public static void TexImage3D(TextureTarget target, int level, int internalformat, int width, int height, int depth, int border, PixelFormat format, PixelType type, IntPtr pixels)
        {
            glTexImage3D.Invoke(target, level, internalformat, width, height, depth, border, format, type, pixels);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXSUBIMAGE3DPROC(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels);
        private static PFNGLTEXSUBIMAGE3DPROC glTexSubImage3D;

        public static void TexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, PixelType type, IntPtr pixels)
        {
            glTexSubImage3D.Invoke(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOPYTEXSUBIMAGE3DPROC(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
        private static PFNGLCOPYTEXSUBIMAGE3DPROC glCopyTexSubImage3D;

        public static void CopyTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
        {
            glCopyTexSubImage3D.Invoke(target, level, xoffset, yoffset, zoffset, x, y, width, height);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLACTIVETEXTUREPROC(TextureUnit texture);
        private static PFNGLACTIVETEXTUREPROC glActiveTexture;

        public static void ActiveTexture(TextureUnit texture)
        {
            glActiveTexture.Invoke(texture);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSAMPLECOVERAGEPROC(float value, bool invert);
        private static PFNGLSAMPLECOVERAGEPROC glSampleCoverage;

        public static void SampleCoverage(float value, bool invert)
        {
            glSampleCoverage.Invoke(value, invert);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOMPRESSEDTEXIMAGE3DPROC(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data);
        private static PFNGLCOMPRESSEDTEXIMAGE3DPROC glCompressedTexImage3D;

        public static void CompressedTexImage3D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
        {
            glCompressedTexImage3D.Invoke(target, level, internalformat, width, height, depth, border, imageSize, data);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOMPRESSEDTEXIMAGE2DPROC(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, IntPtr data);
        private static PFNGLCOMPRESSEDTEXIMAGE2DPROC glCompressedTexImage2D;

        public static void CompressedTexImage2D(TextureTarget target, int level, InternalFormat internalformat, int width, int height, int border, int imageSize, IntPtr data)
        {
            glCompressedTexImage2D.Invoke(target, level, internalformat, width, height, border, imageSize, data);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOMPRESSEDTEXIMAGE1DPROC(TextureTarget target, int level, InternalFormat internalformat, int width, int border, int imageSize, IntPtr data);
        private static PFNGLCOMPRESSEDTEXIMAGE1DPROC glCompressedTexImage1D;

        public static void CompressedTexImage1D(TextureTarget target, int level, InternalFormat internalformat, int width, int border, int imageSize, IntPtr data)
        {
            glCompressedTexImage1D.Invoke(target, level, internalformat, width, border, imageSize, data);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOMPRESSEDTEXSUBIMAGE3DPROC(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, IntPtr data);
        private static PFNGLCOMPRESSEDTEXSUBIMAGE3DPROC glCompressedTexSubImage3D;

        public static void CompressedTexSubImage3D(TextureTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, PixelFormat format, int imageSize, IntPtr data)
        {
            glCompressedTexSubImage3D.Invoke(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOMPRESSEDTEXSUBIMAGE2DPROC(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, IntPtr data);
        private static PFNGLCOMPRESSEDTEXSUBIMAGE2DPROC glCompressedTexSubImage2D;

        public static void CompressedTexSubImage2D(TextureTarget target, int level, int xoffset, int yoffset, int width, int height, PixelFormat format, int imageSize, IntPtr data)
        {
            glCompressedTexSubImage2D.Invoke(target, level, xoffset, yoffset, width, height, format, imageSize, data);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOMPRESSEDTEXSUBIMAGE1DPROC(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, IntPtr data);
        private static PFNGLCOMPRESSEDTEXSUBIMAGE1DPROC glCompressedTexSubImage1D;

        public static void CompressedTexSubImage1D(TextureTarget target, int level, int xoffset, int width, PixelFormat format, int imageSize, IntPtr data)
        {
            glCompressedTexSubImage1D.Invoke(target, level, xoffset, width, format, imageSize, data);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETCOMPRESSEDTEXIMAGEPROC(TextureTarget target, int level, out IntPtr img);
        private static PFNGLGETCOMPRESSEDTEXIMAGEPROC glGetCompressedTexImage;

        public static void GetCompressedTexImage(TextureTarget target, int level, out IntPtr img)
        {
            glGetCompressedTexImage.Invoke(target, level, out img);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBLENDFUNCSEPARATEPROC(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha);
        private static PFNGLBLENDFUNCSEPARATEPROC glBlendFuncSeparate;

        public static void BlendFuncSeparate(BlendingFactor sfactorRGB, BlendingFactor dfactorRGB, BlendingFactor sfactorAlpha, BlendingFactor dfactorAlpha)
        {
            glBlendFuncSeparate.Invoke(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLMULTIDRAWARRAYSPROC(PrimitiveType mode, int[] first, int[] count, int drawcount);
        private static PFNGLMULTIDRAWARRAYSPROC glMultiDrawArrays;

        public static void MultiDrawArrays(PrimitiveType mode, int[] first, int[] count, int drawcount)
        {
            glMultiDrawArrays.Invoke(mode, first, count, drawcount);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLMULTIDRAWELEMENTSPROC(PrimitiveType mode, int[] count, DrawElementsType type, IntPtr indices, int drawcount);
        private static PFNGLMULTIDRAWELEMENTSPROC glMultiDrawElements;

        public static void MultiDrawElements(PrimitiveType mode, int[] count, DrawElementsType type, IntPtr indices, int drawcount)
        {
            glMultiDrawElements.Invoke(mode, count, type, indices, drawcount);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPOINTPARAMETERFPROC(int pname, float param);
        private static PFNGLPOINTPARAMETERFPROC glPointParameterf;

        public static void PointParameterf(int pname, float param)
        {
            glPointParameterf.Invoke(pname, param);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPOINTPARAMETERFVPROC(int pname, float[] parameters);
        private static PFNGLPOINTPARAMETERFVPROC glPointParameterfv;

        public static void PointParameterfv(int pname, float[] parameters)
        {
            glPointParameterfv.Invoke(pname, parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPOINTPARAMETERIPROC(int pname, int param);
        private static PFNGLPOINTPARAMETERIPROC glPointParameteri;

        public static void PointParameteri(int pname, int param)
        {
            glPointParameteri.Invoke(pname, param);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPOINTPARAMETERIVPROC(int pname, int[] parameters);
        private static PFNGLPOINTPARAMETERIVPROC glPointParameteriv;

        public static void PointParameteriv(int pname, int[] parameters)
        {
            glPointParameteriv.Invoke(pname, parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBP4UIVPROC(uint index, VertexAttribPointerType type, bool normalized, uint[] value);
        private static PFNGLVERTEXATTRIBP4UIVPROC glVertexAttribP4uiv;

        public static void VertexAttribP4uiv(uint index, VertexAttribPointerType type, bool normalized, uint[] value)
        {
            glVertexAttribP4uiv.Invoke(index, type, normalized, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBP4UIPROC(uint index, VertexAttribPointerType type, bool normalized, uint value);
        private static PFNGLVERTEXATTRIBP4UIPROC glVertexAttribP4ui;

        public static void VertexAttribP4ui(uint index, VertexAttribPointerType type, bool normalized, uint value)
        {
            glVertexAttribP4ui.Invoke(index, type, normalized, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBP3UIVPROC(uint index, VertexAttribPointerType type, bool normalized, uint[] value);
        private static PFNGLVERTEXATTRIBP3UIVPROC glVertexAttribP3uiv;

        public static void VertexAttribP3uiv(uint index, VertexAttribPointerType type, bool normalized, uint[] value)
        {
            glVertexAttribP3uiv.Invoke(index, type, normalized, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBP3UIPROC(uint index, VertexAttribPointerType type, bool normalized, uint value);
        private static PFNGLVERTEXATTRIBP3UIPROC glVertexAttribP3ui;

        public static void VertexAttribP3ui(uint index, VertexAttribPointerType type, bool normalized, uint value)
        {
            glVertexAttribP3ui.Invoke(index, type, normalized, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBP2UIVPROC(uint index, VertexAttribPointerType type, bool normalized, uint[] value);
        private static PFNGLVERTEXATTRIBP2UIVPROC glVertexAttribP2uiv;

        public static void VertexAttribP2uiv(uint index, VertexAttribPointerType type, bool normalized, uint[] value)
        {
            glVertexAttribP2uiv.Invoke(index, type, normalized, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBP2UIPROC(uint index, VertexAttribPointerType type, bool normalized, uint value);
        private static PFNGLVERTEXATTRIBP2UIPROC glVertexAttribP2ui;

        public static void VertexAttribP2ui(uint index, VertexAttribPointerType type, bool normalized, uint value)
        {
            glVertexAttribP2ui.Invoke(index, type, normalized, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBP1UIVPROC(uint index, VertexAttribPointerType type, bool normalized, uint[] value);
        private static PFNGLVERTEXATTRIBP1UIVPROC glVertexAttribP1uiv;

        public static void VertexAttribP1uiv(uint index, VertexAttribPointerType type, bool normalized, uint[] value)
        {
            glVertexAttribP1uiv.Invoke(index, type, normalized, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBP1UIPROC(uint index, VertexAttribPointerType type, bool normalized, uint value);
        private static PFNGLVERTEXATTRIBP1UIPROC glVertexAttribP1ui;

        public static void VertexAttribP1ui(uint index, VertexAttribPointerType type, bool normalized, uint value)
        {
            glVertexAttribP1ui.Invoke(index, type, normalized, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBDIVISORPROC(uint index, uint divisor);
        private static PFNGLVERTEXATTRIBDIVISORPROC glVertexAttribDivisor;

        public static void VertexAttribDivisor(uint index, uint divisor)
        {
            glVertexAttribDivisor.Invoke(index, divisor);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETQUERYOBJECTUI64VPROC(uint id, QueryObjectParameterName pname, out ulong parameters);
        private static PFNGLGETQUERYOBJECTUI64VPROC glGetQueryObjectui64v;

        public static void GetQueryObjectui64v(uint id, QueryObjectParameterName pname, out ulong parameters)
        {
            glGetQueryObjectui64v.Invoke(id, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETQUERYOBJECTI64VPROC(uint id, QueryObjectParameterName pname, out long parameters);
        private static PFNGLGETQUERYOBJECTI64VPROC glGetQueryObjecti64v;

        public static void GetQueryObjecti64v(uint id, QueryObjectParameterName pname, out long parameters)
        {
            glGetQueryObjecti64v.Invoke(id, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLQUERYCOUNTERPROC(uint id, QueryCounterTarget target);
        private static PFNGLQUERYCOUNTERPROC glQueryCounter;

        public static void QueryCounter(uint id, QueryCounterTarget target)
        {
            glQueryCounter.Invoke(id, target);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETSAMPLERPARAMETERIUIVPROC(uint sampler, SamplerParameterName pname, out uint parameters);
        private static PFNGLGETSAMPLERPARAMETERIUIVPROC glGetSamplerParameterIuiv;

        public static void GetSamplerParameterIuiv(uint sampler, SamplerParameterName pname, out uint parameters)
        {
            glGetSamplerParameterIuiv.Invoke(sampler, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETSAMPLERPARAMETERFVPROC(uint sampler, SamplerParameterName pname, out float parameters);
        private static PFNGLGETSAMPLERPARAMETERFVPROC glGetSamplerParameterfv;

        public static void GetSamplerParameterfv(uint sampler, SamplerParameterName pname, out float parameters)
        {
            glGetSamplerParameterfv.Invoke(sampler, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETSAMPLERPARAMETERIIVPROC(uint sampler, SamplerParameterName pname, out int parameters);
        private static PFNGLGETSAMPLERPARAMETERIIVPROC glGetSamplerParameterIiv;

        public static void GetSamplerParameterIiv(uint sampler, SamplerParameterName pname, out int parameters)
        {
            glGetSamplerParameterIiv.Invoke(sampler, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETSAMPLERPARAMETERIVPROC(uint sampler, SamplerParameterName pname, out int parameters);
        private static PFNGLGETSAMPLERPARAMETERIVPROC glGetSamplerParameteriv;

        public static void GetSamplerParameteriv(uint sampler, SamplerParameterName pname, out int parameters)
        {
            glGetSamplerParameteriv.Invoke(sampler, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSAMPLERPARAMETERIUIVPROC(uint sampler, SamplerParameterName pname, uint[] param);
        private static PFNGLSAMPLERPARAMETERIUIVPROC glSamplerParameterIuiv;

        public static void SamplerParameterIuiv(uint sampler, SamplerParameterName pname, uint[] param)
        {
            glSamplerParameterIuiv.Invoke(sampler, pname, param);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSAMPLERPARAMETERIIVPROC(uint sampler, SamplerParameterName pname, int[] param);
        private static PFNGLSAMPLERPARAMETERIIVPROC glSamplerParameterIiv;

        public static void SamplerParameterIiv(uint sampler, SamplerParameterName pname, int[] param)
        {
            glSamplerParameterIiv.Invoke(sampler, pname, param);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSAMPLERPARAMETERFVPROC(uint sampler, SamplerParameterName pname, float[] param);
        private static PFNGLSAMPLERPARAMETERFVPROC glSamplerParameterfv;

        public static void SamplerParameterfv(uint sampler, SamplerParameterName pname, float[] param)
        {
            glSamplerParameterfv.Invoke(sampler, pname, param);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSAMPLERPARAMETERFPROC(uint sampler, SamplerParameterName pname, float param);
        private static PFNGLSAMPLERPARAMETERFPROC glSamplerParameterf;

        public static void SamplerParameterf(uint sampler, SamplerParameterName pname, float param)
        {
            glSamplerParameterf.Invoke(sampler, pname, param);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSAMPLERPARAMETERIVPROC(uint sampler, SamplerParameterName pname, int[] param);
        private static PFNGLSAMPLERPARAMETERIVPROC glSamplerParameteriv;

        public static void SamplerParameteriv(uint sampler, SamplerParameterName pname, int[] param)
        {
            glSamplerParameteriv.Invoke(sampler, pname, param);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSAMPLERPARAMETERIPROC(uint sampler, SamplerParameterName pname, int param);
        private static PFNGLSAMPLERPARAMETERIPROC glSamplerParameteri;

        public static void SamplerParameteri(uint sampler, SamplerParameterName pname, int param)
        {
            glSamplerParameteri.Invoke(sampler, pname, param);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDSAMPLERPROC(uint unit, uint sampler);
        private static PFNGLBINDSAMPLERPROC glBindSampler;

        public static void BindSampler(uint unit, uint sampler)
        {
            glBindSampler.Invoke(unit, sampler);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISSAMPLERPROC(uint sampler);
        private static PFNGLISSAMPLERPROC glIsSampler;

        public static bool IsSampler(uint sampler)
        {
            return glIsSampler.Invoke(sampler);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETESAMPLERSPROC(int count, uint[] samplers);
        private static PFNGLDELETESAMPLERSPROC glDeleteSamplers;

        public static void DeleteSamplers(int count, uint[] samplers)
        {
            glDeleteSamplers.Invoke(count, samplers);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGENSAMPLERSPROC(int count, out uint samplers);
        private static PFNGLGENSAMPLERSPROC glGenSamplers;

        public static void GenSamplers(int count, out uint samplers)
        {
            glGenSamplers.Invoke(count, out samplers);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int PFNGLGETFRAGDATAINDEXPROC(uint program, sbyte[] name);
        private static PFNGLGETFRAGDATAINDEXPROC glGetFragDataIndex;

        public static int GetFragDataIndex(uint program, sbyte[] name)
        {
            return glGetFragDataIndex.Invoke(program, name);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDFRAGDATALOCATIONINDEXEDPROC(uint program, uint colorNumber, uint index, sbyte[] name);
        private static PFNGLBINDFRAGDATALOCATIONINDEXEDPROC glBindFragDataLocationIndexed;

        public static void BindFragDataLocationIndexed(uint program, uint colorNumber, uint index, sbyte[] name)
        {
            glBindFragDataLocationIndexed.Invoke(program, colorNumber, index, name);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBLENDCOLORPROC(float red, float green, float blue, float alpha);
        private static PFNGLBLENDCOLORPROC glBlendColor;

        public static void BlendColor(float red, float green, float blue, float alpha)
        {
            glBlendColor.Invoke(red, green, blue, alpha);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBLENDEQUATIONPROC(BlendEquationModeEXT mode);
        private static PFNGLBLENDEQUATIONPROC glBlendEquation;

        public static void BlendEquation(BlendEquationModeEXT mode)
        {
            glBlendEquation.Invoke(mode);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGENQUERIESPROC(int n, out uint ids);
        private static PFNGLGENQUERIESPROC glGenQueries;

        public static void GenQueries(int n, out uint ids)
        {
            glGenQueries.Invoke(n, out ids);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETEQUERIESPROC(int n, uint[] ids);
        private static PFNGLDELETEQUERIESPROC glDeleteQueries;

        public static void DeleteQueries(int n, uint[] ids)
        {
            glDeleteQueries.Invoke(n, ids);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISQUERYPROC(uint id);
        private static PFNGLISQUERYPROC glIsQuery;

        public static bool IsQuery(uint id)
        {
            return glIsQuery.Invoke(id);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBEGINQUERYPROC(QueryTarget target, uint id);
        private static PFNGLBEGINQUERYPROC glBeginQuery;

        public static void BeginQuery(QueryTarget target, uint id)
        {
            glBeginQuery.Invoke(target, id);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLENDQUERYPROC(QueryTarget target);
        private static PFNGLENDQUERYPROC glEndQuery;

        public static void EndQuery(QueryTarget target)
        {
            glEndQuery.Invoke(target);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETQUERYIVPROC(QueryTarget target, QueryParameterName pname, out int parameters);
        private static PFNGLGETQUERYIVPROC glGetQueryiv;

        public static void GetQueryiv(QueryTarget target, QueryParameterName pname, out int parameters)
        {
            glGetQueryiv.Invoke(target, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETQUERYOBJECTIVPROC(uint id, QueryObjectParameterName pname, out int parameters);
        private static PFNGLGETQUERYOBJECTIVPROC glGetQueryObjectiv;

        public static void GetQueryObjectiv(uint id, QueryObjectParameterName pname, out int parameters)
        {
            glGetQueryObjectiv.Invoke(id, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETQUERYOBJECTUIVPROC(uint id, QueryObjectParameterName pname, out uint parameters);
        private static PFNGLGETQUERYOBJECTUIVPROC glGetQueryObjectuiv;

        public static void GetQueryObjectuiv(uint id, QueryObjectParameterName pname, out uint parameters)
        {
            glGetQueryObjectuiv.Invoke(id, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDBUFFERPROC(BufferTargetARB target, uint buffer);
        private static PFNGLBINDBUFFERPROC glBindBuffer;

        public static void BindBuffer(BufferTargetARB target, uint buffer)
        {
            glBindBuffer.Invoke(target, buffer);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETEBUFFERSPROC(int n, uint[] buffers);
        private static PFNGLDELETEBUFFERSPROC glDeleteBuffers;

        public static void DeleteBuffers(int n, uint[] buffers)
        {
            glDeleteBuffers.Invoke(n, buffers);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGENBUFFERSPROC(int n, out uint buffers);
        private static PFNGLGENBUFFERSPROC glGenBuffers;

        public static void GenBuffers(int n, out uint buffers)
        {
            glGenBuffers.Invoke(n, out buffers);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISBUFFERPROC(uint buffer);
        private static PFNGLISBUFFERPROC glIsBuffer;

        public static bool IsBuffer(uint buffer)
        {
            return glIsBuffer.Invoke(buffer);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBUFFERDATAPROC(BufferTargetARB target, IntPtr size, IntPtr data, BufferUsageARB usage);
        private static PFNGLBUFFERDATAPROC glBufferData;

        public static void BufferData(BufferTargetARB target, IntPtr size, IntPtr data, BufferUsageARB usage)
        {
            glBufferData.Invoke(target, size, data, usage);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBUFFERSUBDATAPROC(BufferTargetARB target, IntPtr offset, IntPtr size, IntPtr data);
        private static PFNGLBUFFERSUBDATAPROC glBufferSubData;

        public static void BufferSubData(BufferTargetARB target, IntPtr offset, IntPtr size, IntPtr data)
        {
            glBufferSubData.Invoke(target, offset, size, data);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETBUFFERSUBDATAPROC(BufferTargetARB target, IntPtr offset, IntPtr size, out IntPtr data);
        private static PFNGLGETBUFFERSUBDATAPROC glGetBufferSubData;

        public static void GetBufferSubData(BufferTargetARB target, IntPtr offset, IntPtr size, out IntPtr data)
        {
            glGetBufferSubData.Invoke(target, offset, size, out data);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr PFNGLMAPBUFFERPROC(BufferTargetARB target, BufferAccessARB access);
        private static PFNGLMAPBUFFERPROC glMapBuffer;

        public static IntPtr MapBuffer(BufferTargetARB target, BufferAccessARB access)
        {
            return glMapBuffer.Invoke(target, access);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLUNMAPBUFFERPROC(BufferTargetARB target);
        private static PFNGLUNMAPBUFFERPROC glUnmapBuffer;

        public static bool UnmapBuffer(BufferTargetARB target)
        {
            return glUnmapBuffer.Invoke(target);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETBUFFERPARAMETERIVPROC(BufferTargetARB target, int pname, out int parameters);
        private static PFNGLGETBUFFERPARAMETERIVPROC glGetBufferParameteriv;

        public static void GetBufferParameteriv(BufferTargetARB target, int pname, out int parameters)
        {
            glGetBufferParameteriv.Invoke(target, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETBUFFERPOINTERVPROC(BufferTargetARB target, int pname, out IntPtr parameters);
        private static PFNGLGETBUFFERPOINTERVPROC glGetBufferPointerv;

        public static void GetBufferPointerv(BufferTargetARB target, int pname, out IntPtr parameters)
        {
            glGetBufferPointerv.Invoke(target, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBLENDEQUATIONSEPARATEPROC(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha);
        private static PFNGLBLENDEQUATIONSEPARATEPROC glBlendEquationSeparate;

        public static void BlendEquationSeparate(BlendEquationModeEXT modeRGB, BlendEquationModeEXT modeAlpha)
        {
            glBlendEquationSeparate.Invoke(modeRGB, modeAlpha);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWBUFFERSPROC(int n, int[] bufs);
        private static PFNGLDRAWBUFFERSPROC glDrawBuffers;

        public static void DrawBuffers(int n, int[] bufs)
        {
            glDrawBuffers.Invoke(n, bufs);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSTENCILOPSEPARATEPROC(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass);
        private static PFNGLSTENCILOPSEPARATEPROC glStencilOpSeparate;

        public static void StencilOpSeparate(StencilFaceDirection face, StencilOp sfail, StencilOp dpfail, StencilOp dppass)
        {
            glStencilOpSeparate.Invoke(face, sfail, dpfail, dppass);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSTENCILFUNCSEPARATEPROC(StencilFaceDirection face, StencilFunction func, int reference, uint mask);
        private static PFNGLSTENCILFUNCSEPARATEPROC glStencilFuncSeparate;

        public static void StencilFuncSeparate(StencilFaceDirection face, StencilFunction func, int reference, uint mask)
        {
            glStencilFuncSeparate.Invoke(face, func, reference, mask);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSTENCILMASKSEPARATEPROC(StencilFaceDirection face, uint mask);
        private static PFNGLSTENCILMASKSEPARATEPROC glStencilMaskSeparate;

        public static void StencilMaskSeparate(StencilFaceDirection face, uint mask)
        {
            glStencilMaskSeparate.Invoke(face, mask);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLATTACHSHADERPROC(uint program, uint shader);
        private static PFNGLATTACHSHADERPROC glAttachShader;

        public static void AttachShader(uint program, uint shader)
        {
            glAttachShader.Invoke(program, shader);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDATTRIBLOCATIONPROC(uint program, uint index, sbyte[] name);
        private static PFNGLBINDATTRIBLOCATIONPROC glBindAttribLocation;

        public static void BindAttribLocation(uint program, uint index, sbyte[] name)
        {
            glBindAttribLocation.Invoke(program, index, name);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOMPILESHADERPROC(uint shader);
        private static PFNGLCOMPILESHADERPROC glCompileShader;

        public static void CompileShader(uint shader)
        {
            glCompileShader.Invoke(shader);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate uint PFNGLCREATEPROGRAMPROC();
        private static PFNGLCREATEPROGRAMPROC glCreateProgram;

        public static uint CreateProgram()
        {
            return glCreateProgram.Invoke();
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate uint PFNGLCREATESHADERPROC(ShaderType type);
        private static PFNGLCREATESHADERPROC glCreateShader;

        public static uint CreateShader(ShaderType type)
        {
            return glCreateShader.Invoke(type);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETEPROGRAMPROC(uint program);
        private static PFNGLDELETEPROGRAMPROC glDeleteProgram;

        public static void DeleteProgram(uint program)
        {
            glDeleteProgram.Invoke(program);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETESHADERPROC(uint shader);
        private static PFNGLDELETESHADERPROC glDeleteShader;

        public static void DeleteShader(uint shader)
        {
            glDeleteShader.Invoke(shader);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDETACHSHADERPROC(uint program, uint shader);
        private static PFNGLDETACHSHADERPROC glDetachShader;

        public static void DetachShader(uint program, uint shader)
        {
            glDetachShader.Invoke(program, shader);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDISABLEVERTEXATTRIBARRAYPROC(uint index);
        private static PFNGLDISABLEVERTEXATTRIBARRAYPROC glDisableVertexAttribArray;

        public static void DisableVertexAttribArray(uint index)
        {
            glDisableVertexAttribArray.Invoke(index);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLENABLEVERTEXATTRIBARRAYPROC(uint index);
        private static PFNGLENABLEVERTEXATTRIBARRAYPROC glEnableVertexAttribArray;

        public static void EnableVertexAttribArray(uint index)
        {
            glEnableVertexAttribArray.Invoke(index);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETACTIVEATTRIBPROC(uint program, uint index, int bufSize, out int length, out int size, out AttributeType type, out sbyte name);
        private static PFNGLGETACTIVEATTRIBPROC glGetActiveAttrib;

        public static void GetActiveAttrib(uint program, uint index, int bufSize, out int length, out int size, out AttributeType type, out sbyte name)
        {
            glGetActiveAttrib.Invoke(program, index, bufSize, out length, out size, out type, out name);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETACTIVEUNIFORMPROC(uint program, uint index, int bufSize, out int length, out int size, out AttributeType type, out sbyte name);
        private static PFNGLGETACTIVEUNIFORMPROC glGetActiveUniform;

        public static void GetActiveUniform(uint program, uint index, int bufSize, out int length, out int size, out AttributeType type, out sbyte name)
        {
            glGetActiveUniform.Invoke(program, index, bufSize, out length, out size, out type, out name);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETATTACHEDSHADERSPROC(uint program, int maxCount, out int count, out uint shaders);
        private static PFNGLGETATTACHEDSHADERSPROC glGetAttachedShaders;

        public static void GetAttachedShaders(uint program, int maxCount, out int count, out uint shaders)
        {
            glGetAttachedShaders.Invoke(program, maxCount, out count, out shaders);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int PFNGLGETATTRIBLOCATIONPROC(uint program, sbyte[] name);
        private static PFNGLGETATTRIBLOCATIONPROC glGetAttribLocation;

        public static int GetAttribLocation(uint program, sbyte[] name)
        {
            return glGetAttribLocation.Invoke(program, name);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETPROGRAMIVPROC(uint program, ProgramPropertyARB pname, out int parameters);
        private static PFNGLGETPROGRAMIVPROC glGetProgramiv;

        public static void GetProgramiv(uint program, ProgramPropertyARB pname, out int parameters)
        {
            glGetProgramiv.Invoke(program, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETPROGRAMINFOLOGPROC(uint program, int bufSize, out int length, out sbyte infoLog);
        private static PFNGLGETPROGRAMINFOLOGPROC glGetProgramInfoLog;

        public static void GetProgramInfoLog(uint program, int bufSize, out int length, out sbyte infoLog)
        {
            glGetProgramInfoLog.Invoke(program, bufSize, out length, out infoLog);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETSHADERIVPROC(uint shader, ShaderParameterName pname, out int parameters);
        private static PFNGLGETSHADERIVPROC glGetShaderiv;

        public static void GetShaderiv(uint shader, ShaderParameterName pname, out int parameters)
        {
            glGetShaderiv.Invoke(shader, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETSHADERINFOLOGPROC(uint shader, int bufSize, out int length, out sbyte infoLog);
        private static PFNGLGETSHADERINFOLOGPROC glGetShaderInfoLog;

        public static void GetShaderInfoLog(uint shader, int bufSize, out int length, out sbyte infoLog)
        {
            glGetShaderInfoLog.Invoke(shader, bufSize, out length, out infoLog);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETSHADERSOURCEPROC(uint shader, int bufSize, out int length, out sbyte source);
        private static PFNGLGETSHADERSOURCEPROC glGetShaderSource;

        public static void GetShaderSource(uint shader, int bufSize, out int length, out sbyte source)
        {
            glGetShaderSource.Invoke(shader, bufSize, out length, out source);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int PFNGLGETUNIFORMLOCATIONPROC(uint program, sbyte[] name);
        private static PFNGLGETUNIFORMLOCATIONPROC glGetUniformLocation;

        public static int GetUniformLocation(uint program, sbyte[] name)
        {
            return glGetUniformLocation.Invoke(program, name);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETUNIFORMFVPROC(uint program, int location, out float parameters);
        private static PFNGLGETUNIFORMFVPROC glGetUniformfv;

        public static void GetUniformfv(uint program, int location, out float parameters)
        {
            glGetUniformfv.Invoke(program, location, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETUNIFORMIVPROC(uint program, int location, out int parameters);
        private static PFNGLGETUNIFORMIVPROC glGetUniformiv;

        public static void GetUniformiv(uint program, int location, out int parameters)
        {
            glGetUniformiv.Invoke(program, location, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETVERTEXATTRIBDVPROC(uint index, int pname, out double parameters);
        private static PFNGLGETVERTEXATTRIBDVPROC glGetVertexAttribdv;

        public static void GetVertexAttribdv(uint index, int pname, out double parameters)
        {
            glGetVertexAttribdv.Invoke(index, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETVERTEXATTRIBFVPROC(uint index, int pname, out float parameters);
        private static PFNGLGETVERTEXATTRIBFVPROC glGetVertexAttribfv;

        public static void GetVertexAttribfv(uint index, int pname, out float parameters)
        {
            glGetVertexAttribfv.Invoke(index, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETVERTEXATTRIBIVPROC(uint index, int pname, out int parameters);
        private static PFNGLGETVERTEXATTRIBIVPROC glGetVertexAttribiv;

        public static void GetVertexAttribiv(uint index, int pname, out int parameters)
        {
            glGetVertexAttribiv.Invoke(index, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETVERTEXATTRIBPOINTERVPROC(uint index, int pname, out IntPtr pointer);
        private static PFNGLGETVERTEXATTRIBPOINTERVPROC glGetVertexAttribPointerv;

        public static void GetVertexAttribPointerv(uint index, int pname, out IntPtr pointer)
        {
            glGetVertexAttribPointerv.Invoke(index, pname, out pointer);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISPROGRAMPROC(uint program);
        private static PFNGLISPROGRAMPROC glIsProgram;

        public static bool IsProgram(uint program)
        {
            return glIsProgram.Invoke(program);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISSHADERPROC(uint shader);
        private static PFNGLISSHADERPROC glIsShader;

        public static bool IsShader(uint shader)
        {
            return glIsShader.Invoke(shader);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLLINKPROGRAMPROC(uint program);
        private static PFNGLLINKPROGRAMPROC glLinkProgram;

        public static void LinkProgram(uint program)
        {
            glLinkProgram.Invoke(program);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSHADERSOURCEPROC(uint shader, int count, sbyte str, int[] length);
        private static PFNGLSHADERSOURCEPROC glShaderSource;

        public static void ShaderSource(uint shader, int count, sbyte str, int[] length)
        {
            glShaderSource.Invoke(shader, count, str, length);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUSEPROGRAMPROC(uint program);
        private static PFNGLUSEPROGRAMPROC glUseProgram;

        public static void UseProgram(uint program)
        {
            glUseProgram.Invoke(program);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM1FPROC(int location, float v0);
        private static PFNGLUNIFORM1FPROC glUniform1f;

        public static void Uniform1f(int location, float v0)
        {
            glUniform1f.Invoke(location, v0);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM2FPROC(int location, float v0, float v1);
        private static PFNGLUNIFORM2FPROC glUniform2f;

        public static void Uniform2f(int location, float v0, float v1)
        {
            glUniform2f.Invoke(location, v0, v1);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM3FPROC(int location, float v0, float v1, float v2);
        private static PFNGLUNIFORM3FPROC glUniform3f;

        public static void Uniform3f(int location, float v0, float v1, float v2)
        {
            glUniform3f.Invoke(location, v0, v1, v2);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM4FPROC(int location, float v0, float v1, float v2, float v3);
        private static PFNGLUNIFORM4FPROC glUniform4f;

        public static void Uniform4f(int location, float v0, float v1, float v2, float v3)
        {
            glUniform4f.Invoke(location, v0, v1, v2, v3);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM1IPROC(int location, int v0);
        private static PFNGLUNIFORM1IPROC glUniform1i;

        public static void Uniform1i(int location, int v0)
        {
            glUniform1i.Invoke(location, v0);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM2IPROC(int location, int v0, int v1);
        private static PFNGLUNIFORM2IPROC glUniform2i;

        public static void Uniform2i(int location, int v0, int v1)
        {
            glUniform2i.Invoke(location, v0, v1);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM3IPROC(int location, int v0, int v1, int v2);
        private static PFNGLUNIFORM3IPROC glUniform3i;

        public static void Uniform3i(int location, int v0, int v1, int v2)
        {
            glUniform3i.Invoke(location, v0, v1, v2);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM4IPROC(int location, int v0, int v1, int v2, int v3);
        private static PFNGLUNIFORM4IPROC glUniform4i;

        public static void Uniform4i(int location, int v0, int v1, int v2, int v3)
        {
            glUniform4i.Invoke(location, v0, v1, v2, v3);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM1FVPROC(int location, int count, float[] value);
        private static PFNGLUNIFORM1FVPROC glUniform1fv;

        public static void Uniform1fv(int location, int count, float[] value)
        {
            glUniform1fv.Invoke(location, count, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM2FVPROC(int location, int count, float[] value);
        private static PFNGLUNIFORM2FVPROC glUniform2fv;

        public static void Uniform2fv(int location, int count, float[] value)
        {
            glUniform2fv.Invoke(location, count, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM3FVPROC(int location, int count, float[] value);
        private static PFNGLUNIFORM3FVPROC glUniform3fv;

        public static void Uniform3fv(int location, int count, float[] value)
        {
            glUniform3fv.Invoke(location, count, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM4FVPROC(int location, int count, float[] value);
        private static PFNGLUNIFORM4FVPROC glUniform4fv;

        public static void Uniform4fv(int location, int count, float[] value)
        {
            glUniform4fv.Invoke(location, count, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM1IVPROC(int location, int count, int[] value);
        private static PFNGLUNIFORM1IVPROC glUniform1iv;

        public static void Uniform1iv(int location, int count, int[] value)
        {
            glUniform1iv.Invoke(location, count, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM2IVPROC(int location, int count, int[] value);
        private static PFNGLUNIFORM2IVPROC glUniform2iv;

        public static void Uniform2iv(int location, int count, int[] value)
        {
            glUniform2iv.Invoke(location, count, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM3IVPROC(int location, int count, int[] value);
        private static PFNGLUNIFORM3IVPROC glUniform3iv;

        public static void Uniform3iv(int location, int count, int[] value)
        {
            glUniform3iv.Invoke(location, count, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM4IVPROC(int location, int count, int[] value);
        private static PFNGLUNIFORM4IVPROC glUniform4iv;

        public static void Uniform4iv(int location, int count, int[] value)
        {
            glUniform4iv.Invoke(location, count, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMMATRIX2FVPROC(int location, int count, bool transpose, float[] value);
        private static PFNGLUNIFORMMATRIX2FVPROC glUniformMatrix2fv;

        public static void UniformMatrix2fv(int location, int count, bool transpose, float[] value)
        {
            glUniformMatrix2fv.Invoke(location, count, transpose, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMMATRIX3FVPROC(int location, int count, bool transpose, float[] value);
        private static PFNGLUNIFORMMATRIX3FVPROC glUniformMatrix3fv;

        public static void UniformMatrix3fv(int location, int count, bool transpose, float[] value)
        {
            glUniformMatrix3fv.Invoke(location, count, transpose, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMMATRIX4FVPROC(int location, int count, bool transpose, float[] value);
        private static PFNGLUNIFORMMATRIX4FVPROC glUniformMatrix4fv;

        public static void UniformMatrix4fv(int location, int count, bool transpose, float[] value)
        {
            glUniformMatrix4fv.Invoke(location, count, transpose, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVALIDATEPROGRAMPROC(uint program);
        private static PFNGLVALIDATEPROGRAMPROC glValidateProgram;

        public static void ValidateProgram(uint program)
        {
            glValidateProgram.Invoke(program);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB1DPROC(uint index, double x);
        private static PFNGLVERTEXATTRIB1DPROC glVertexAttrib1d;

        public static void VertexAttrib1d(uint index, double x)
        {
            glVertexAttrib1d.Invoke(index, x);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB1DVPROC(uint index, double[] v);
        private static PFNGLVERTEXATTRIB1DVPROC glVertexAttrib1dv;

        public static void VertexAttrib1dv(uint index, double[] v)
        {
            glVertexAttrib1dv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB1FPROC(uint index, float x);
        private static PFNGLVERTEXATTRIB1FPROC glVertexAttrib1f;

        public static void VertexAttrib1f(uint index, float x)
        {
            glVertexAttrib1f.Invoke(index, x);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB1FVPROC(uint index, float[] v);
        private static PFNGLVERTEXATTRIB1FVPROC glVertexAttrib1fv;

        public static void VertexAttrib1fv(uint index, float[] v)
        {
            glVertexAttrib1fv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB1SPROC(uint index, short x);
        private static PFNGLVERTEXATTRIB1SPROC glVertexAttrib1s;

        public static void VertexAttrib1s(uint index, short x)
        {
            glVertexAttrib1s.Invoke(index, x);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB1SVPROC(uint index, short[] v);
        private static PFNGLVERTEXATTRIB1SVPROC glVertexAttrib1sv;

        public static void VertexAttrib1sv(uint index, short[] v)
        {
            glVertexAttrib1sv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB2DPROC(uint index, double x, double y);
        private static PFNGLVERTEXATTRIB2DPROC glVertexAttrib2d;

        public static void VertexAttrib2d(uint index, double x, double y)
        {
            glVertexAttrib2d.Invoke(index, x, y);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB2DVPROC(uint index, double[] v);
        private static PFNGLVERTEXATTRIB2DVPROC glVertexAttrib2dv;

        public static void VertexAttrib2dv(uint index, double[] v)
        {
            glVertexAttrib2dv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB2FPROC(uint index, float x, float y);
        private static PFNGLVERTEXATTRIB2FPROC glVertexAttrib2f;

        public static void VertexAttrib2f(uint index, float x, float y)
        {
            glVertexAttrib2f.Invoke(index, x, y);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB2FVPROC(uint index, float[] v);
        private static PFNGLVERTEXATTRIB2FVPROC glVertexAttrib2fv;

        public static void VertexAttrib2fv(uint index, float[] v)
        {
            glVertexAttrib2fv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB2SPROC(uint index, short x, short y);
        private static PFNGLVERTEXATTRIB2SPROC glVertexAttrib2s;

        public static void VertexAttrib2s(uint index, short x, short y)
        {
            glVertexAttrib2s.Invoke(index, x, y);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB2SVPROC(uint index, short[] v);
        private static PFNGLVERTEXATTRIB2SVPROC glVertexAttrib2sv;

        public static void VertexAttrib2sv(uint index, short[] v)
        {
            glVertexAttrib2sv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB3DPROC(uint index, double x, double y, double z);
        private static PFNGLVERTEXATTRIB3DPROC glVertexAttrib3d;

        public static void VertexAttrib3d(uint index, double x, double y, double z)
        {
            glVertexAttrib3d.Invoke(index, x, y, z);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB3DVPROC(uint index, double[] v);
        private static PFNGLVERTEXATTRIB3DVPROC glVertexAttrib3dv;

        public static void VertexAttrib3dv(uint index, double[] v)
        {
            glVertexAttrib3dv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB3FPROC(uint index, float x, float y, float z);
        private static PFNGLVERTEXATTRIB3FPROC glVertexAttrib3f;

        public static void VertexAttrib3f(uint index, float x, float y, float z)
        {
            glVertexAttrib3f.Invoke(index, x, y, z);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB3FVPROC(uint index, float[] v);
        private static PFNGLVERTEXATTRIB3FVPROC glVertexAttrib3fv;

        public static void VertexAttrib3fv(uint index, float[] v)
        {
            glVertexAttrib3fv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB3SPROC(uint index, short x, short y, short z);
        private static PFNGLVERTEXATTRIB3SPROC glVertexAttrib3s;

        public static void VertexAttrib3s(uint index, short x, short y, short z)
        {
            glVertexAttrib3s.Invoke(index, x, y, z);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB3SVPROC(uint index, short[] v);
        private static PFNGLVERTEXATTRIB3SVPROC glVertexAttrib3sv;

        public static void VertexAttrib3sv(uint index, short[] v)
        {
            glVertexAttrib3sv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4NBVPROC(uint index, sbyte[] v);
        private static PFNGLVERTEXATTRIB4NBVPROC glVertexAttrib4Nbv;

        public static void VertexAttrib4Nbv(uint index, sbyte[] v)
        {
            glVertexAttrib4Nbv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4NIVPROC(uint index, int[] v);
        private static PFNGLVERTEXATTRIB4NIVPROC glVertexAttrib4Niv;

        public static void VertexAttrib4Niv(uint index, int[] v)
        {
            glVertexAttrib4Niv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4NSVPROC(uint index, short[] v);
        private static PFNGLVERTEXATTRIB4NSVPROC glVertexAttrib4Nsv;

        public static void VertexAttrib4Nsv(uint index, short[] v)
        {
            glVertexAttrib4Nsv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4NUBPROC(uint index, byte x, byte y, byte z, byte w);
        private static PFNGLVERTEXATTRIB4NUBPROC glVertexAttrib4Nub;

        public static void VertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w)
        {
            glVertexAttrib4Nub.Invoke(index, x, y, z, w);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4NUBVPROC(uint index, byte[] v);
        private static PFNGLVERTEXATTRIB4NUBVPROC glVertexAttrib4Nubv;

        public static void VertexAttrib4Nubv(uint index, byte[] v)
        {
            glVertexAttrib4Nubv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4NUIVPROC(uint index, uint[] v);
        private static PFNGLVERTEXATTRIB4NUIVPROC glVertexAttrib4Nuiv;

        public static void VertexAttrib4Nuiv(uint index, uint[] v)
        {
            glVertexAttrib4Nuiv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4NUSVPROC(uint index, ushort[] v);
        private static PFNGLVERTEXATTRIB4NUSVPROC glVertexAttrib4Nusv;

        public static void VertexAttrib4Nusv(uint index, ushort[] v)
        {
            glVertexAttrib4Nusv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4BVPROC(uint index, sbyte[] v);
        private static PFNGLVERTEXATTRIB4BVPROC glVertexAttrib4bv;

        public static void VertexAttrib4bv(uint index, sbyte[] v)
        {
            glVertexAttrib4bv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4DPROC(uint index, double x, double y, double z, double w);
        private static PFNGLVERTEXATTRIB4DPROC glVertexAttrib4d;

        public static void VertexAttrib4d(uint index, double x, double y, double z, double w)
        {
            glVertexAttrib4d.Invoke(index, x, y, z, w);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4DVPROC(uint index, double[] v);
        private static PFNGLVERTEXATTRIB4DVPROC glVertexAttrib4dv;

        public static void VertexAttrib4dv(uint index, double[] v)
        {
            glVertexAttrib4dv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4FPROC(uint index, float x, float y, float z, float w);
        private static PFNGLVERTEXATTRIB4FPROC glVertexAttrib4f;

        public static void VertexAttrib4f(uint index, float x, float y, float z, float w)
        {
            glVertexAttrib4f.Invoke(index, x, y, z, w);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4FVPROC(uint index, float[] v);
        private static PFNGLVERTEXATTRIB4FVPROC glVertexAttrib4fv;

        public static void VertexAttrib4fv(uint index, float[] v)
        {
            glVertexAttrib4fv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4IVPROC(uint index, int[] v);
        private static PFNGLVERTEXATTRIB4IVPROC glVertexAttrib4iv;

        public static void VertexAttrib4iv(uint index, int[] v)
        {
            glVertexAttrib4iv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4SPROC(uint index, short x, short y, short z, short w);
        private static PFNGLVERTEXATTRIB4SPROC glVertexAttrib4s;

        public static void VertexAttrib4s(uint index, short x, short y, short z, short w)
        {
            glVertexAttrib4s.Invoke(index, x, y, z, w);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4SVPROC(uint index, short[] v);
        private static PFNGLVERTEXATTRIB4SVPROC glVertexAttrib4sv;

        public static void VertexAttrib4sv(uint index, short[] v)
        {
            glVertexAttrib4sv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4UBVPROC(uint index, byte[] v);
        private static PFNGLVERTEXATTRIB4UBVPROC glVertexAttrib4ubv;

        public static void VertexAttrib4ubv(uint index, byte[] v)
        {
            glVertexAttrib4ubv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4UIVPROC(uint index, uint[] v);
        private static PFNGLVERTEXATTRIB4UIVPROC glVertexAttrib4uiv;

        public static void VertexAttrib4uiv(uint index, uint[] v)
        {
            glVertexAttrib4uiv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIB4USVPROC(uint index, ushort[] v);
        private static PFNGLVERTEXATTRIB4USVPROC glVertexAttrib4usv;

        public static void VertexAttrib4usv(uint index, ushort[] v)
        {
            glVertexAttrib4usv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBPOINTERPROC(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, IntPtr pointer);
        private static PFNGLVERTEXATTRIBPOINTERPROC glVertexAttribPointer;

        public static void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, IntPtr pointer)
        {
            glVertexAttribPointer.Invoke(index, size, type, normalized, stride, pointer);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMMATRIX2X3FVPROC(int location, int count, bool transpose, float[] value);
        private static PFNGLUNIFORMMATRIX2X3FVPROC glUniformMatrix2x3fv;

        public static void UniformMatrix2x3fv(int location, int count, bool transpose, float[] value)
        {
            glUniformMatrix2x3fv.Invoke(location, count, transpose, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMMATRIX3X2FVPROC(int location, int count, bool transpose, float[] value);
        private static PFNGLUNIFORMMATRIX3X2FVPROC glUniformMatrix3x2fv;

        public static void UniformMatrix3x2fv(int location, int count, bool transpose, float[] value)
        {
            glUniformMatrix3x2fv.Invoke(location, count, transpose, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMMATRIX2X4FVPROC(int location, int count, bool transpose, float[] value);
        private static PFNGLUNIFORMMATRIX2X4FVPROC glUniformMatrix2x4fv;

        public static void UniformMatrix2x4fv(int location, int count, bool transpose, float[] value)
        {
            glUniformMatrix2x4fv.Invoke(location, count, transpose, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMMATRIX4X2FVPROC(int location, int count, bool transpose, float[] value);
        private static PFNGLUNIFORMMATRIX4X2FVPROC glUniformMatrix4x2fv;

        public static void UniformMatrix4x2fv(int location, int count, bool transpose, float[] value)
        {
            glUniformMatrix4x2fv.Invoke(location, count, transpose, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMMATRIX3X4FVPROC(int location, int count, bool transpose, float[] value);
        private static PFNGLUNIFORMMATRIX3X4FVPROC glUniformMatrix3x4fv;

        public static void UniformMatrix3x4fv(int location, int count, bool transpose, float[] value)
        {
            glUniformMatrix3x4fv.Invoke(location, count, transpose, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMMATRIX4X3FVPROC(int location, int count, bool transpose, float[] value);
        private static PFNGLUNIFORMMATRIX4X3FVPROC glUniformMatrix4x3fv;

        public static void UniformMatrix4x3fv(int location, int count, bool transpose, float[] value)
        {
            glUniformMatrix4x3fv.Invoke(location, count, transpose, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOLORMASKIPROC(uint index, bool r, bool g, bool b, bool a);
        private static PFNGLCOLORMASKIPROC glColorMaski;

        public static void ColorMaski(uint index, bool r, bool g, bool b, bool a)
        {
            glColorMaski.Invoke(index, r, g, b, a);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETBOOLEANI_VPROC(BufferTargetARB target, uint index, out bool data);
        private static PFNGLGETBOOLEANI_VPROC glGetBooleani_v;

        public static void GetBooleani_v(BufferTargetARB target, uint index, out bool data)
        {
            glGetBooleani_v.Invoke(target, index, out data);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETINTEGERI_VPROC(TypeEnum target, uint index, out int data);
        private static PFNGLGETINTEGERI_VPROC glGetIntegeri_v;

        public static void GetIntegeri_v(TypeEnum target, uint index, out int data)
        {
            glGetIntegeri_v.Invoke(target, index, out data);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLENABLEIPROC(EnableCap target, uint index);
        private static PFNGLENABLEIPROC glEnablei;

        public static void Enablei(EnableCap target, uint index)
        {
            glEnablei.Invoke(target, index);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDISABLEIPROC(EnableCap target, uint index);
        private static PFNGLDISABLEIPROC glDisablei;

        public static void Disablei(EnableCap target, uint index)
        {
            glDisablei.Invoke(target, index);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISENABLEDIPROC(EnableCap target, uint index);
        private static PFNGLISENABLEDIPROC glIsEnabledi;

        public static bool IsEnabledi(EnableCap target, uint index)
        {
            return glIsEnabledi.Invoke(target, index);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBEGINTRANSFORMFEEDBACKPROC(PrimitiveType primitiveMode);
        private static PFNGLBEGINTRANSFORMFEEDBACKPROC glBeginTransformFeedback;

        public static void BeginTransformFeedback(PrimitiveType primitiveMode)
        {
            glBeginTransformFeedback.Invoke(primitiveMode);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLENDTRANSFORMFEEDBACKPROC();
        private static PFNGLENDTRANSFORMFEEDBACKPROC glEndTransformFeedback;

        public static void EndTransformFeedback()
        {
            glEndTransformFeedback.Invoke();
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDBUFFERRANGEPROC(BufferTargetARB target, uint index, uint buffer, IntPtr offset, IntPtr size);
        private static PFNGLBINDBUFFERRANGEPROC glBindBufferRange;

        public static void BindBufferRange(BufferTargetARB target, uint index, uint buffer, IntPtr offset, IntPtr size)
        {
            glBindBufferRange.Invoke(target, index, buffer, offset, size);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDBUFFERBASEPROC(BufferTargetARB target, uint index, uint buffer);
        private static PFNGLBINDBUFFERBASEPROC glBindBufferBase;

        public static void BindBufferBase(BufferTargetARB target, uint index, uint buffer)
        {
            glBindBufferBase.Invoke(target, index, buffer);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTRANSFORMFEEDBACKVARYINGSPROC(uint program, int count, sbyte varyings, int bufferMode);
        private static PFNGLTRANSFORMFEEDBACKVARYINGSPROC glTransformFeedbackVaryings;

        public static void TransformFeedbackVaryings(uint program, int count, sbyte varyings, int bufferMode)
        {
            glTransformFeedbackVaryings.Invoke(program, count, varyings, bufferMode);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETTRANSFORMFEEDBACKVARYINGPROC(uint program, uint index, int bufSize, out int length, out int size, out int type, out sbyte name);
        private static PFNGLGETTRANSFORMFEEDBACKVARYINGPROC glGetTransformFeedbackVarying;

        public static void GetTransformFeedbackVarying(uint program, uint index, int bufSize, out int length, out int size, out int type, out sbyte name)
        {
            glGetTransformFeedbackVarying.Invoke(program, index, bufSize, out length, out size, out type, out name);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCLAMPCOLORPROC(int target, int clamp);
        private static PFNGLCLAMPCOLORPROC glClampColor;

        public static void ClampColor(int target, int clamp)
        {
            glClampColor.Invoke(target, clamp);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBEGINCONDITIONALRENDERPROC(uint id, TypeEnum mode);
        private static PFNGLBEGINCONDITIONALRENDERPROC glBeginConditionalRender;

        public static void BeginConditionalRender(uint id, TypeEnum mode)
        {
            glBeginConditionalRender.Invoke(id, mode);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLENDCONDITIONALRENDERPROC();
        private static PFNGLENDCONDITIONALRENDERPROC glEndConditionalRender;

        public static void EndConditionalRender()
        {
            glEndConditionalRender.Invoke();
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBIPOINTERPROC(uint index, int size, VertexAttribPointerType type, int stride, IntPtr pointer);
        private static PFNGLVERTEXATTRIBIPOINTERPROC glVertexAttribIPointer;

        public static void VertexAttribIPointer(uint index, int size, VertexAttribPointerType type, int stride, IntPtr pointer)
        {
            glVertexAttribIPointer.Invoke(index, size, type, stride, pointer);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETVERTEXATTRIBIIVPROC(uint index, VertexAttribEnum pname, out int parameters);
        private static PFNGLGETVERTEXATTRIBIIVPROC glGetVertexAttribIiv;

        public static void GetVertexAttribIiv(uint index, VertexAttribEnum pname, out int parameters)
        {
            glGetVertexAttribIiv.Invoke(index, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETVERTEXATTRIBIUIVPROC(uint index, VertexAttribEnum pname, out uint parameters);
        private static PFNGLGETVERTEXATTRIBIUIVPROC glGetVertexAttribIuiv;

        public static void GetVertexAttribIuiv(uint index, VertexAttribEnum pname, out uint parameters)
        {
            glGetVertexAttribIuiv.Invoke(index, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI1IPROC(uint index, int x);
        private static PFNGLVERTEXATTRIBI1IPROC glVertexAttribI1i;

        public static void VertexAttribI1i(uint index, int x)
        {
            glVertexAttribI1i.Invoke(index, x);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI2IPROC(uint index, int x, int y);
        private static PFNGLVERTEXATTRIBI2IPROC glVertexAttribI2i;

        public static void VertexAttribI2i(uint index, int x, int y)
        {
            glVertexAttribI2i.Invoke(index, x, y);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI3IPROC(uint index, int x, int y, int z);
        private static PFNGLVERTEXATTRIBI3IPROC glVertexAttribI3i;

        public static void VertexAttribI3i(uint index, int x, int y, int z)
        {
            glVertexAttribI3i.Invoke(index, x, y, z);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI4IPROC(uint index, int x, int y, int z, int w);
        private static PFNGLVERTEXATTRIBI4IPROC glVertexAttribI4i;

        public static void VertexAttribI4i(uint index, int x, int y, int z, int w)
        {
            glVertexAttribI4i.Invoke(index, x, y, z, w);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI1UIPROC(uint index, uint x);
        private static PFNGLVERTEXATTRIBI1UIPROC glVertexAttribI1ui;

        public static void VertexAttribI1ui(uint index, uint x)
        {
            glVertexAttribI1ui.Invoke(index, x);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI2UIPROC(uint index, uint x, uint y);
        private static PFNGLVERTEXATTRIBI2UIPROC glVertexAttribI2ui;

        public static void VertexAttribI2ui(uint index, uint x, uint y)
        {
            glVertexAttribI2ui.Invoke(index, x, y);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI3UIPROC(uint index, uint x, uint y, uint z);
        private static PFNGLVERTEXATTRIBI3UIPROC glVertexAttribI3ui;

        public static void VertexAttribI3ui(uint index, uint x, uint y, uint z)
        {
            glVertexAttribI3ui.Invoke(index, x, y, z);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI4UIPROC(uint index, uint x, uint y, uint z, uint w);
        private static PFNGLVERTEXATTRIBI4UIPROC glVertexAttribI4ui;

        public static void VertexAttribI4ui(uint index, uint x, uint y, uint z, uint w)
        {
            glVertexAttribI4ui.Invoke(index, x, y, z, w);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI1IVPROC(uint index, int[] v);
        private static PFNGLVERTEXATTRIBI1IVPROC glVertexAttribI1iv;

        public static void VertexAttribI1iv(uint index, int[] v)
        {
            glVertexAttribI1iv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI2IVPROC(uint index, int[] v);
        private static PFNGLVERTEXATTRIBI2IVPROC glVertexAttribI2iv;

        public static void VertexAttribI2iv(uint index, int[] v)
        {
            glVertexAttribI2iv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI3IVPROC(uint index, int[] v);
        private static PFNGLVERTEXATTRIBI3IVPROC glVertexAttribI3iv;

        public static void VertexAttribI3iv(uint index, int[] v)
        {
            glVertexAttribI3iv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI4IVPROC(uint index, int[] v);
        private static PFNGLVERTEXATTRIBI4IVPROC glVertexAttribI4iv;

        public static void VertexAttribI4iv(uint index, int[] v)
        {
            glVertexAttribI4iv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI1UIVPROC(uint index, uint[] v);
        private static PFNGLVERTEXATTRIBI1UIVPROC glVertexAttribI1uiv;

        public static void VertexAttribI1uiv(uint index, uint[] v)
        {
            glVertexAttribI1uiv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI2UIVPROC(uint index, uint[] v);
        private static PFNGLVERTEXATTRIBI2UIVPROC glVertexAttribI2uiv;

        public static void VertexAttribI2uiv(uint index, uint[] v)
        {
            glVertexAttribI2uiv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI3UIVPROC(uint index, uint[] v);
        private static PFNGLVERTEXATTRIBI3UIVPROC glVertexAttribI3uiv;

        public static void VertexAttribI3uiv(uint index, uint[] v)
        {
            glVertexAttribI3uiv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI4UIVPROC(uint index, uint[] v);
        private static PFNGLVERTEXATTRIBI4UIVPROC glVertexAttribI4uiv;

        public static void VertexAttribI4uiv(uint index, uint[] v)
        {
            glVertexAttribI4uiv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI4BVPROC(uint index, sbyte[] v);
        private static PFNGLVERTEXATTRIBI4BVPROC glVertexAttribI4bv;

        public static void VertexAttribI4bv(uint index, sbyte[] v)
        {
            glVertexAttribI4bv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI4SVPROC(uint index, short[] v);
        private static PFNGLVERTEXATTRIBI4SVPROC glVertexAttribI4sv;

        public static void VertexAttribI4sv(uint index, short[] v)
        {
            glVertexAttribI4sv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI4UBVPROC(uint index, byte[] v);
        private static PFNGLVERTEXATTRIBI4UBVPROC glVertexAttribI4ubv;

        public static void VertexAttribI4ubv(uint index, byte[] v)
        {
            glVertexAttribI4ubv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLVERTEXATTRIBI4USVPROC(uint index, ushort[] v);
        private static PFNGLVERTEXATTRIBI4USVPROC glVertexAttribI4usv;

        public static void VertexAttribI4usv(uint index, ushort[] v)
        {
            glVertexAttribI4usv.Invoke(index, v);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETUNIFORMUIVPROC(uint program, int location, out uint parameters);
        private static PFNGLGETUNIFORMUIVPROC glGetUniformuiv;

        public static void GetUniformuiv(uint program, int location, out uint parameters)
        {
            glGetUniformuiv.Invoke(program, location, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDFRAGDATALOCATIONPROC(uint program, uint color, sbyte[] name);
        private static PFNGLBINDFRAGDATALOCATIONPROC glBindFragDataLocation;

        public static void BindFragDataLocation(uint program, uint color, sbyte[] name)
        {
            glBindFragDataLocation.Invoke(program, color, name);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int PFNGLGETFRAGDATALOCATIONPROC(uint program, sbyte[] name);
        private static PFNGLGETFRAGDATALOCATIONPROC glGetFragDataLocation;

        public static int GetFragDataLocation(uint program, sbyte[] name)
        {
            return glGetFragDataLocation.Invoke(program, name);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM1UIPROC(int location, uint v0);
        private static PFNGLUNIFORM1UIPROC glUniform1ui;

        public static void Uniform1ui(int location, uint v0)
        {
            glUniform1ui.Invoke(location, v0);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM2UIPROC(int location, uint v0, uint v1);
        private static PFNGLUNIFORM2UIPROC glUniform2ui;

        public static void Uniform2ui(int location, uint v0, uint v1)
        {
            glUniform2ui.Invoke(location, v0, v1);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM3UIPROC(int location, uint v0, uint v1, uint v2);
        private static PFNGLUNIFORM3UIPROC glUniform3ui;

        public static void Uniform3ui(int location, uint v0, uint v1, uint v2)
        {
            glUniform3ui.Invoke(location, v0, v1, v2);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM4UIPROC(int location, uint v0, uint v1, uint v2, uint v3);
        private static PFNGLUNIFORM4UIPROC glUniform4ui;

        public static void Uniform4ui(int location, uint v0, uint v1, uint v2, uint v3)
        {
            glUniform4ui.Invoke(location, v0, v1, v2, v3);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM1UIVPROC(int location, int count, uint[] value);
        private static PFNGLUNIFORM1UIVPROC glUniform1uiv;

        public static void Uniform1uiv(int location, int count, uint[] value)
        {
            glUniform1uiv.Invoke(location, count, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM2UIVPROC(int location, int count, uint[] value);
        private static PFNGLUNIFORM2UIVPROC glUniform2uiv;

        public static void Uniform2uiv(int location, int count, uint[] value)
        {
            glUniform2uiv.Invoke(location, count, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM3UIVPROC(int location, int count, uint[] value);
        private static PFNGLUNIFORM3UIVPROC glUniform3uiv;

        public static void Uniform3uiv(int location, int count, uint[] value)
        {
            glUniform3uiv.Invoke(location, count, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORM4UIVPROC(int location, int count, uint[] value);
        private static PFNGLUNIFORM4UIVPROC glUniform4uiv;

        public static void Uniform4uiv(int location, int count, uint[] value)
        {
            glUniform4uiv.Invoke(location, count, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXPARAMETERIIVPROC(TextureTarget target, TextureParameterName pname, int[] parameters);
        private static PFNGLTEXPARAMETERIIVPROC glTexParameterIiv;

        public static void TexParameterIiv(TextureTarget target, TextureParameterName pname, int[] parameters)
        {
            glTexParameterIiv.Invoke(target, pname, parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXPARAMETERIUIVPROC(TextureTarget target, TextureParameterName pname, uint[] parameters);
        private static PFNGLTEXPARAMETERIUIVPROC glTexParameterIuiv;

        public static void TexParameterIuiv(TextureTarget target, TextureParameterName pname, uint[] parameters)
        {
            glTexParameterIuiv.Invoke(target, pname, parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETTEXPARAMETERIIVPROC(TextureTarget target, GetTextureParameter pname, out int parameters);
        private static PFNGLGETTEXPARAMETERIIVPROC glGetTexParameterIiv;

        public static void GetTexParameterIiv(TextureTarget target, GetTextureParameter pname, out int parameters)
        {
            glGetTexParameterIiv.Invoke(target, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETTEXPARAMETERIUIVPROC(TextureTarget target, GetTextureParameter pname, out uint parameters);
        private static PFNGLGETTEXPARAMETERIUIVPROC glGetTexParameterIuiv;

        public static void GetTexParameterIuiv(TextureTarget target, GetTextureParameter pname, out uint parameters)
        {
            glGetTexParameterIuiv.Invoke(target, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCLEARBUFFERIVPROC(Buffer buffer, int drawbuffer, int[] value);
        private static PFNGLCLEARBUFFERIVPROC glClearBufferiv;

        public static void ClearBufferiv(Buffer buffer, int drawbuffer, int[] value)
        {
            glClearBufferiv.Invoke(buffer, drawbuffer, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCLEARBUFFERUIVPROC(Buffer buffer, int drawbuffer, uint[] value);
        private static PFNGLCLEARBUFFERUIVPROC glClearBufferuiv;

        public static void ClearBufferuiv(Buffer buffer, int drawbuffer, uint[] value)
        {
            glClearBufferuiv.Invoke(buffer, drawbuffer, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCLEARBUFFERFVPROC(Buffer buffer, int drawbuffer, float[] value);
        private static PFNGLCLEARBUFFERFVPROC glClearBufferfv;

        public static void ClearBufferfv(Buffer buffer, int drawbuffer, float[] value)
        {
            glClearBufferfv.Invoke(buffer, drawbuffer, value);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCLEARBUFFERFIPROC(Buffer buffer, int drawbuffer, float depth, int stencil);
        private static PFNGLCLEARBUFFERFIPROC glClearBufferfi;

        public static void ClearBufferfi(Buffer buffer, int drawbuffer, float depth, int stencil)
        {
            glClearBufferfi.Invoke(buffer, drawbuffer, depth, stencil);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr PFNGLGETSTRINGIPROC(StringName name, uint index);
        private static PFNGLGETSTRINGIPROC glGetStringi;

        public static IntPtr GetStringi(StringName name, uint index)
        {
            return glGetStringi.Invoke(name, index);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISRENDERBUFFERPROC(uint renderbuffer);
        private static PFNGLISRENDERBUFFERPROC glIsRenderbuffer;

        public static bool IsRenderbuffer(uint renderbuffer)
        {
            return glIsRenderbuffer.Invoke(renderbuffer);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDRENDERBUFFERPROC(RenderbufferTarget target, uint renderbuffer);
        private static PFNGLBINDRENDERBUFFERPROC glBindRenderbuffer;

        public static void BindRenderbuffer(RenderbufferTarget target, uint renderbuffer)
        {
            glBindRenderbuffer.Invoke(target, renderbuffer);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETERENDERBUFFERSPROC(int n, uint[] renderbuffers);
        private static PFNGLDELETERENDERBUFFERSPROC glDeleteRenderbuffers;

        public static void DeleteRenderbuffers(int n, uint[] renderbuffers)
        {
            glDeleteRenderbuffers.Invoke(n, renderbuffers);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGENRENDERBUFFERSPROC(int n, out uint renderbuffers);
        private static PFNGLGENRENDERBUFFERSPROC glGenRenderbuffers;

        public static void GenRenderbuffers(int n, out uint renderbuffers)
        {
            glGenRenderbuffers.Invoke(n, out renderbuffers);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLRENDERBUFFERSTORAGEPROC(RenderbufferTarget target, InternalFormat internalformat, int width, int height);
        private static PFNGLRENDERBUFFERSTORAGEPROC glRenderbufferStorage;

        public static void RenderbufferStorage(RenderbufferTarget target, InternalFormat internalformat, int width, int height)
        {
            glRenderbufferStorage.Invoke(target, internalformat, width, height);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETRENDERBUFFERPARAMETERIVPROC(RenderbufferTarget target, RenderbufferParameterName pname, out int parameters);
        private static PFNGLGETRENDERBUFFERPARAMETERIVPROC glGetRenderbufferParameteriv;

        public static void GetRenderbufferParameteriv(RenderbufferTarget target, RenderbufferParameterName pname, out int parameters)
        {
            glGetRenderbufferParameteriv.Invoke(target, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISFRAMEBUFFERPROC(uint framebuffer);
        private static PFNGLISFRAMEBUFFERPROC glIsFramebuffer;

        public static bool IsFramebuffer(uint framebuffer)
        {
            return glIsFramebuffer.Invoke(framebuffer);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDFRAMEBUFFERPROC(FramebufferTarget target, uint framebuffer);
        private static PFNGLBINDFRAMEBUFFERPROC glBindFramebuffer;

        public static void BindFramebuffer(FramebufferTarget target, uint framebuffer)
        {
            glBindFramebuffer.Invoke(target, framebuffer);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETEFRAMEBUFFERSPROC(int n, uint[] framebuffers);
        private static PFNGLDELETEFRAMEBUFFERSPROC glDeleteFramebuffers;

        public static void DeleteFramebuffers(int n, uint[] framebuffers)
        {
            glDeleteFramebuffers.Invoke(n, framebuffers);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGENFRAMEBUFFERSPROC(int n, out uint framebuffers);
        private static PFNGLGENFRAMEBUFFERSPROC glGenFramebuffers;

        public static void GenFramebuffers(int n, out uint framebuffers)
        {
            glGenFramebuffers.Invoke(n, out framebuffers);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate FramebufferStatus PFNGLCHECKFRAMEBUFFERSTATUSPROC(FramebufferTarget target);
        private static PFNGLCHECKFRAMEBUFFERSTATUSPROC glCheckFramebufferStatus;

        public static FramebufferStatus CheckFramebufferStatus(FramebufferTarget target)
        {
            return glCheckFramebufferStatus.Invoke(target);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFRAMEBUFFERTEXTURE1DPROC(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);
        private static PFNGLFRAMEBUFFERTEXTURE1DPROC glFramebufferTexture1D;

        public static void FramebufferTexture1D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level)
        {
            glFramebufferTexture1D.Invoke(target, attachment, textarget, texture, level);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFRAMEBUFFERTEXTURE2DPROC(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level);
        private static PFNGLFRAMEBUFFERTEXTURE2DPROC glFramebufferTexture2D;

        public static void FramebufferTexture2D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level)
        {
            glFramebufferTexture2D.Invoke(target, attachment, textarget, texture, level);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFRAMEBUFFERTEXTURE3DPROC(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset);
        private static PFNGLFRAMEBUFFERTEXTURE3DPROC glFramebufferTexture3D;

        public static void FramebufferTexture3D(FramebufferTarget target, FramebufferAttachment attachment, TextureTarget textarget, uint texture, int level, int zoffset)
        {
            glFramebufferTexture3D.Invoke(target, attachment, textarget, texture, level, zoffset);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFRAMEBUFFERRENDERBUFFERPROC(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer);
        private static PFNGLFRAMEBUFFERRENDERBUFFERPROC glFramebufferRenderbuffer;

        public static void FramebufferRenderbuffer(FramebufferTarget target, FramebufferAttachment attachment, RenderbufferTarget renderbuffertarget, uint renderbuffer)
        {
            glFramebufferRenderbuffer.Invoke(target, attachment, renderbuffertarget, renderbuffer);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETFRAMEBUFFERATTACHMENTPARAMETERIVPROC(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, out int parameters);
        private static PFNGLGETFRAMEBUFFERATTACHMENTPARAMETERIVPROC glGetFramebufferAttachmentParameteriv;

        public static void GetFramebufferAttachmentParameteriv(FramebufferTarget target, FramebufferAttachment attachment, FramebufferAttachmentParameterName pname, out int parameters)
        {
            glGetFramebufferAttachmentParameteriv.Invoke(target, attachment, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGENERATEMIPMAPPROC(TextureTarget target);
        private static PFNGLGENERATEMIPMAPPROC glGenerateMipmap;

        public static void GenerateMipmap(TextureTarget target)
        {
            glGenerateMipmap.Invoke(target);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBLITFRAMEBUFFERPROC(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter);
        private static PFNGLBLITFRAMEBUFFERPROC glBlitFramebuffer;

        public static void BlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, ClearBufferMask mask, BlitFramebufferFilter filter)
        {
            glBlitFramebuffer.Invoke(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLRENDERBUFFERSTORAGEMULTISAMPLEPROC(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height);
        private static PFNGLRENDERBUFFERSTORAGEMULTISAMPLEPROC glRenderbufferStorageMultisample;

        public static void RenderbufferStorageMultisample(RenderbufferTarget target, int samples, InternalFormat internalformat, int width, int height)
        {
            glRenderbufferStorageMultisample.Invoke(target, samples, internalformat, width, height);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFRAMEBUFFERTEXTURELAYERPROC(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer);
        private static PFNGLFRAMEBUFFERTEXTURELAYERPROC glFramebufferTextureLayer;

        public static void FramebufferTextureLayer(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level, int layer)
        {
            glFramebufferTextureLayer.Invoke(target, attachment, texture, level, layer);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr PFNGLMAPBUFFERRANGEPROC(BufferTargetARB target, IntPtr offset, IntPtr length, MapBufferAccessMask access);
        private static PFNGLMAPBUFFERRANGEPROC glMapBufferRange;

        public static IntPtr MapBufferRange(BufferTargetARB target, IntPtr offset, IntPtr length, MapBufferAccessMask access)
        {
            return glMapBufferRange.Invoke(target, offset, length, access);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFLUSHMAPPEDBUFFERRANGEPROC(BufferTargetARB target, IntPtr offset, IntPtr length);
        private static PFNGLFLUSHMAPPEDBUFFERRANGEPROC glFlushMappedBufferRange;

        public static void FlushMappedBufferRange(BufferTargetARB target, IntPtr offset, IntPtr length)
        {
            glFlushMappedBufferRange.Invoke(target, offset, length);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLBINDVERTEXARRAYPROC(uint array);
        private static PFNGLBINDVERTEXARRAYPROC glBindVertexArray;

        public static void BindVertexArray(uint array)
        {
            glBindVertexArray.Invoke(array);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETEVERTEXARRAYSPROC(int n, uint[] arrays);
        private static PFNGLDELETEVERTEXARRAYSPROC glDeleteVertexArrays;

        public static void DeleteVertexArrays(int n, uint[] arrays)
        {
            glDeleteVertexArrays.Invoke(n, arrays);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGENVERTEXARRAYSPROC(int n, out uint arrays);
        private static PFNGLGENVERTEXARRAYSPROC glGenVertexArrays;

        public static void GenVertexArrays(int n, out uint arrays)
        {
            glGenVertexArrays.Invoke(n, out arrays);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISVERTEXARRAYPROC(uint array);
        private static PFNGLISVERTEXARRAYPROC glIsVertexArray;

        public static bool IsVertexArray(uint array)
        {
            return glIsVertexArray.Invoke(array);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWARRAYSINSTANCEDPROC(PrimitiveType mode, int first, int count, int instancecount);
        private static PFNGLDRAWARRAYSINSTANCEDPROC glDrawArraysInstanced;

        public static void DrawArraysInstanced(PrimitiveType mode, int first, int count, int instancecount)
        {
            glDrawArraysInstanced.Invoke(mode, first, count, instancecount);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWELEMENTSINSTANCEDPROC(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount);
        private static PFNGLDRAWELEMENTSINSTANCEDPROC glDrawElementsInstanced;

        public static void DrawElementsInstanced(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount)
        {
            glDrawElementsInstanced.Invoke(mode, count, type, indices, instancecount);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXBUFFERPROC(TextureTarget target, InternalFormat internalformat, uint buffer);
        private static PFNGLTEXBUFFERPROC glTexBuffer;

        public static void TexBuffer(TextureTarget target, InternalFormat internalformat, uint buffer)
        {
            glTexBuffer.Invoke(target, internalformat, buffer);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPRIMITIVERESTARTINDEXPROC(uint index);
        private static PFNGLPRIMITIVERESTARTINDEXPROC glPrimitiveRestartIndex;

        public static void PrimitiveRestartIndex(uint index)
        {
            glPrimitiveRestartIndex.Invoke(index);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLCOPYBUFFERSUBDATAPROC(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
        private static PFNGLCOPYBUFFERSUBDATAPROC glCopyBufferSubData;

        public static void CopyBufferSubData(CopyBufferSubDataTarget readTarget, CopyBufferSubDataTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size)
        {
            glCopyBufferSubData.Invoke(readTarget, writeTarget, readOffset, writeOffset, size);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETUNIFORMINDICESPROC(uint program, int uniformCount, sbyte uniformNames, out uint uniformIndices);
        private static PFNGLGETUNIFORMINDICESPROC glGetUniformIndices;

        public static void GetUniformIndices(uint program, int uniformCount, sbyte uniformNames, out uint uniformIndices)
        {
            glGetUniformIndices.Invoke(program, uniformCount, uniformNames, out uniformIndices);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETACTIVEUNIFORMSIVPROC(uint program, int uniformCount, uint[] uniformIndices, UniformPName pname, out int parameters);
        private static PFNGLGETACTIVEUNIFORMSIVPROC glGetActiveUniformsiv;

        public static void GetActiveUniformsiv(uint program, int uniformCount, uint[] uniformIndices, UniformPName pname, out int parameters)
        {
            glGetActiveUniformsiv.Invoke(program, uniformCount, uniformIndices, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETACTIVEUNIFORMNAMEPROC(uint program, uint uniformIndex, int bufSize, out int length, out sbyte uniformName);
        private static PFNGLGETACTIVEUNIFORMNAMEPROC glGetActiveUniformName;

        public static void GetActiveUniformName(uint program, uint uniformIndex, int bufSize, out int length, out sbyte uniformName)
        {
            glGetActiveUniformName.Invoke(program, uniformIndex, bufSize, out length, out uniformName);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate uint PFNGLGETUNIFORMBLOCKINDEXPROC(uint program, sbyte[] uniformBlockName);
        private static PFNGLGETUNIFORMBLOCKINDEXPROC glGetUniformBlockIndex;

        public static uint GetUniformBlockIndex(uint program, sbyte[] uniformBlockName)
        {
            return glGetUniformBlockIndex.Invoke(program, uniformBlockName);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETACTIVEUNIFORMBLOCKIVPROC(uint program, uint uniformBlockIndex, UniformBlockPName pname, out int parameters);
        private static PFNGLGETACTIVEUNIFORMBLOCKIVPROC glGetActiveUniformBlockiv;

        public static void GetActiveUniformBlockiv(uint program, uint uniformBlockIndex, UniformBlockPName pname, out int parameters)
        {
            glGetActiveUniformBlockiv.Invoke(program, uniformBlockIndex, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETACTIVEUNIFORMBLOCKNAMEPROC(uint program, uint uniformBlockIndex, int bufSize, out int length, out sbyte uniformBlockName);
        private static PFNGLGETACTIVEUNIFORMBLOCKNAMEPROC glGetActiveUniformBlockName;

        public static void GetActiveUniformBlockName(uint program, uint uniformBlockIndex, int bufSize, out int length, out sbyte uniformBlockName)
        {
            glGetActiveUniformBlockName.Invoke(program, uniformBlockIndex, bufSize, out length, out uniformBlockName);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLUNIFORMBLOCKBINDINGPROC(uint program, uint uniformBlockIndex, uint uniformBlockBinding);
        private static PFNGLUNIFORMBLOCKBINDINGPROC glUniformBlockBinding;

        public static void UniformBlockBinding(uint program, uint uniformBlockIndex, uint uniformBlockBinding)
        {
            glUniformBlockBinding.Invoke(program, uniformBlockIndex, uniformBlockBinding);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWELEMENTSBASEVERTEXPROC(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int basevertex);
        private static PFNGLDRAWELEMENTSBASEVERTEXPROC glDrawElementsBaseVertex;

        public static void DrawElementsBaseVertex(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int basevertex)
        {
            glDrawElementsBaseVertex.Invoke(mode, count, type, indices, basevertex);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWRANGEELEMENTSBASEVERTEXPROC(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices, int basevertex);
        private static PFNGLDRAWRANGEELEMENTSBASEVERTEXPROC glDrawRangeElementsBaseVertex;

        public static void DrawRangeElementsBaseVertex(PrimitiveType mode, uint start, uint end, int count, DrawElementsType type, IntPtr indices, int basevertex)
        {
            glDrawRangeElementsBaseVertex.Invoke(mode, start, end, count, type, indices, basevertex);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDRAWELEMENTSINSTANCEDBASEVERTEXPROC(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount, int basevertex);
        private static PFNGLDRAWELEMENTSINSTANCEDBASEVERTEXPROC glDrawElementsInstancedBaseVertex;

        public static void DrawElementsInstancedBaseVertex(PrimitiveType mode, int count, DrawElementsType type, IntPtr indices, int instancecount, int basevertex)
        {
            glDrawElementsInstancedBaseVertex.Invoke(mode, count, type, indices, instancecount, basevertex);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLMULTIDRAWELEMENTSBASEVERTEXPROC(PrimitiveType mode, int[] count, DrawElementsType type, IntPtr indices, int drawcount, int[] basevertex);
        private static PFNGLMULTIDRAWELEMENTSBASEVERTEXPROC glMultiDrawElementsBaseVertex;

        public static void MultiDrawElementsBaseVertex(PrimitiveType mode, int[] count, DrawElementsType type, IntPtr indices, int drawcount, int[] basevertex)
        {
            glMultiDrawElementsBaseVertex.Invoke(mode, count, type, indices, drawcount, basevertex);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLPROVOKINGVERTEXPROC(VertexProvokingMode mode);
        private static PFNGLPROVOKINGVERTEXPROC glProvokingVertex;

        public static void ProvokingVertex(VertexProvokingMode mode)
        {
            glProvokingVertex.Invoke(mode);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr PFNGLFENCESYNCPROC(SyncCondition condition, uint flags);
        private static PFNGLFENCESYNCPROC glFenceSync;

        public static IntPtr FenceSync(SyncCondition condition, uint flags)
        {
            return glFenceSync.Invoke(condition, flags);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate bool PFNGLISSYNCPROC(IntPtr sync);
        private static PFNGLISSYNCPROC glIsSync;

        public static bool IsSync(IntPtr sync)
        {
            return glIsSync.Invoke(sync);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLDELETESYNCPROC(IntPtr sync);
        private static PFNGLDELETESYNCPROC glDeleteSync;

        public static void DeleteSync(IntPtr sync)
        {
            glDeleteSync.Invoke(sync);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate SyncStatus PFNGLCLIENTWAITSYNCPROC(IntPtr sync, SyncObjectMask flags, ulong timeout);
        private static PFNGLCLIENTWAITSYNCPROC glClientWaitSync;

        public static SyncStatus ClientWaitSync(IntPtr sync, SyncObjectMask flags, ulong timeout)
        {
            return glClientWaitSync.Invoke(sync, flags, timeout);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLWAITSYNCPROC(IntPtr sync, uint flags, ulong timeout);
        private static PFNGLWAITSYNCPROC glWaitSync;

        public static void WaitSync(IntPtr sync, uint flags, ulong timeout)
        {
            glWaitSync.Invoke(sync, flags, timeout);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETINTEGER64VPROC(GetPName pname, out long data);
        private static PFNGLGETINTEGER64VPROC glGetInteger64v;

        public static void GetInteger64v(GetPName pname, out long data)
        {
            glGetInteger64v.Invoke(pname, out data);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETSYNCIVPROC(IntPtr sync, SyncParameterName pname, int bufSize, out int length, out int values);
        private static PFNGLGETSYNCIVPROC glGetSynciv;

        public static void GetSynciv(IntPtr sync, SyncParameterName pname, int bufSize, out int length, out int values)
        {
            glGetSynciv.Invoke(sync, pname, bufSize, out length, out values);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETINTEGER64I_VPROC(TypeEnum target, uint index, out long data);
        private static PFNGLGETINTEGER64I_VPROC glGetInteger64i_v;

        public static void GetInteger64i_v(TypeEnum target, uint index, out long data)
        {
            glGetInteger64i_v.Invoke(target, index, out data);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETBUFFERPARAMETERI64VPROC(BufferTargetARB target, int pname, out long parameters);
        private static PFNGLGETBUFFERPARAMETERI64VPROC glGetBufferParameteri64v;

        public static void GetBufferParameteri64v(BufferTargetARB target, int pname, out long parameters)
        {
            glGetBufferParameteri64v.Invoke(target, pname, out parameters);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLFRAMEBUFFERTEXTUREPROC(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level);
        private static PFNGLFRAMEBUFFERTEXTUREPROC glFramebufferTexture;

        public static void FramebufferTexture(FramebufferTarget target, FramebufferAttachment attachment, uint texture, int level)
        {
            glFramebufferTexture.Invoke(target, attachment, texture, level);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXIMAGE2DMULTISAMPLEPROC(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, bool fixedsamplelocations);
        private static PFNGLTEXIMAGE2DMULTISAMPLEPROC glTexImage2DMultisample;

        public static void TexImage2DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, bool fixedsamplelocations)
        {
            glTexImage2DMultisample.Invoke(target, samples, internalformat, width, height, fixedsamplelocations);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLTEXIMAGE3DMULTISAMPLEPROC(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations);
        private static PFNGLTEXIMAGE3DMULTISAMPLEPROC glTexImage3DMultisample;

        public static void TexImage3DMultisample(TextureTarget target, int samples, InternalFormat internalformat, int width, int height, int depth, bool fixedsamplelocations)
        {
            glTexImage3DMultisample.Invoke(target, samples, internalformat, width, height, depth, fixedsamplelocations);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLGETMULTISAMPLEFVPROC(int pname, uint index, out float val);
        private static PFNGLGETMULTISAMPLEFVPROC glGetMultisamplefv;

        public static void GetMultisamplefv(int pname, uint index, out float val)
        {
            glGetMultisamplefv.Invoke(pname, index, out val);
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate void PFNGLSAMPLEMASKIPROC(uint maskNumber, uint mask);
        private static PFNGLSAMPLEMASKIPROC glSampleMaski;

        public static void SampleMaski(uint maskNumber, uint mask)
        {
            glSampleMaski.Invoke(maskNumber, mask);
        }

        public static void Initialize(GetProcAddressHandler loader)
        {
            glCullFace = Marshal.GetDelegateForFunctionPointer<PFNGLCULLFACEPROC>(loader.Invoke("glCullFace"));
            glFrontFace = Marshal.GetDelegateForFunctionPointer<PFNGLFRONTFACEPROC>(loader.Invoke("glFrontFace"));
            glHint = Marshal.GetDelegateForFunctionPointer<PFNGLHINTPROC>(loader.Invoke("glHint"));
            glLineWidth = Marshal.GetDelegateForFunctionPointer<PFNGLLINEWIDTHPROC>(loader.Invoke("glLineWidth"));
            glPointSize = Marshal.GetDelegateForFunctionPointer<PFNGLPOINTSIZEPROC>(loader.Invoke("glPointSize"));
            glPolygonMode = Marshal.GetDelegateForFunctionPointer<PFNGLPOLYGONMODEPROC>(loader.Invoke("glPolygonMode"));
            glScissor = Marshal.GetDelegateForFunctionPointer<PFNGLSCISSORPROC>(loader.Invoke("glScissor"));
            glTexParameterf = Marshal.GetDelegateForFunctionPointer<PFNGLTEXPARAMETERFPROC>(loader.Invoke("glTexParameterf"));
            glTexParameterfv = Marshal.GetDelegateForFunctionPointer<PFNGLTEXPARAMETERFVPROC>(loader.Invoke("glTexParameterfv"));
            glTexParameteri = Marshal.GetDelegateForFunctionPointer<PFNGLTEXPARAMETERIPROC>(loader.Invoke("glTexParameteri"));
            glTexParameteriv = Marshal.GetDelegateForFunctionPointer<PFNGLTEXPARAMETERIVPROC>(loader.Invoke("glTexParameteriv"));
            glTexImage1D = Marshal.GetDelegateForFunctionPointer<PFNGLTEXIMAGE1DPROC>(loader.Invoke("glTexImage1D"));
            glTexImage2D = Marshal.GetDelegateForFunctionPointer<PFNGLTEXIMAGE2DPROC>(loader.Invoke("glTexImage2D"));
            glDrawBuffer = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWBUFFERPROC>(loader.Invoke("glDrawBuffer"));
            glClear = Marshal.GetDelegateForFunctionPointer<PFNGLCLEARPROC>(loader.Invoke("glClear"));
            glClearColor = Marshal.GetDelegateForFunctionPointer<PFNGLCLEARCOLORPROC>(loader.Invoke("glClearColor"));
            glClearStencil = Marshal.GetDelegateForFunctionPointer<PFNGLCLEARSTENCILPROC>(loader.Invoke("glClearStencil"));
            glClearDepth = Marshal.GetDelegateForFunctionPointer<PFNGLCLEARDEPTHPROC>(loader.Invoke("glClearDepth"));
            glStencilMask = Marshal.GetDelegateForFunctionPointer<PFNGLSTENCILMASKPROC>(loader.Invoke("glStencilMask"));
            glColorMask = Marshal.GetDelegateForFunctionPointer<PFNGLCOLORMASKPROC>(loader.Invoke("glColorMask"));
            glDepthMask = Marshal.GetDelegateForFunctionPointer<PFNGLDEPTHMASKPROC>(loader.Invoke("glDepthMask"));
            glDisable = Marshal.GetDelegateForFunctionPointer<PFNGLDISABLEPROC>(loader.Invoke("glDisable"));
            glEnable = Marshal.GetDelegateForFunctionPointer<PFNGLENABLEPROC>(loader.Invoke("glEnable"));
            glFinish = Marshal.GetDelegateForFunctionPointer<PFNGLFINISHPROC>(loader.Invoke("glFinish"));
            glFlush = Marshal.GetDelegateForFunctionPointer<PFNGLFLUSHPROC>(loader.Invoke("glFlush"));
            glBlendFunc = Marshal.GetDelegateForFunctionPointer<PFNGLBLENDFUNCPROC>(loader.Invoke("glBlendFunc"));
            glLogicOp = Marshal.GetDelegateForFunctionPointer<PFNGLLOGICOPPROC>(loader.Invoke("glLogicOp"));
            glStencilFunc = Marshal.GetDelegateForFunctionPointer<PFNGLSTENCILFUNCPROC>(loader.Invoke("glStencilFunc"));
            glStencilOp = Marshal.GetDelegateForFunctionPointer<PFNGLSTENCILOPPROC>(loader.Invoke("glStencilOp"));
            glDepthFunc = Marshal.GetDelegateForFunctionPointer<PFNGLDEPTHFUNCPROC>(loader.Invoke("glDepthFunc"));
            glPixelStoref = Marshal.GetDelegateForFunctionPointer<PFNGLPIXELSTOREFPROC>(loader.Invoke("glPixelStoref"));
            glPixelStorei = Marshal.GetDelegateForFunctionPointer<PFNGLPIXELSTOREIPROC>(loader.Invoke("glPixelStorei"));
            glReadBuffer = Marshal.GetDelegateForFunctionPointer<PFNGLREADBUFFERPROC>(loader.Invoke("glReadBuffer"));
            glReadPixels = Marshal.GetDelegateForFunctionPointer<PFNGLREADPIXELSPROC>(loader.Invoke("glReadPixels"));
            glGetBooleanv = Marshal.GetDelegateForFunctionPointer<PFNGLGETBOOLEANVPROC>(loader.Invoke("glGetBooleanv"));
            glGetDoublev = Marshal.GetDelegateForFunctionPointer<PFNGLGETDOUBLEVPROC>(loader.Invoke("glGetDoublev"));
            glGetError = Marshal.GetDelegateForFunctionPointer<PFNGLGETERRORPROC>(loader.Invoke("glGetError"));
            glGetFloatv = Marshal.GetDelegateForFunctionPointer<PFNGLGETFLOATVPROC>(loader.Invoke("glGetFloatv"));
            glGetIntegerv = Marshal.GetDelegateForFunctionPointer<PFNGLGETINTEGERVPROC>(loader.Invoke("glGetIntegerv"));
            glGetString = Marshal.GetDelegateForFunctionPointer<PFNGLGETSTRINGPROC>(loader.Invoke("glGetString"));
            glGetTexImage = Marshal.GetDelegateForFunctionPointer<PFNGLGETTEXIMAGEPROC>(loader.Invoke("glGetTexImage"));
            glGetTexParameterfv = Marshal.GetDelegateForFunctionPointer<PFNGLGETTEXPARAMETERFVPROC>(loader.Invoke("glGetTexParameterfv"));
            glGetTexParameteriv = Marshal.GetDelegateForFunctionPointer<PFNGLGETTEXPARAMETERIVPROC>(loader.Invoke("glGetTexParameteriv"));
            glGetTexLevelParameterfv = Marshal.GetDelegateForFunctionPointer<PFNGLGETTEXLEVELPARAMETERFVPROC>(loader.Invoke("glGetTexLevelParameterfv"));
            glGetTexLevelParameteriv = Marshal.GetDelegateForFunctionPointer<PFNGLGETTEXLEVELPARAMETERIVPROC>(loader.Invoke("glGetTexLevelParameteriv"));
            glIsEnabled = Marshal.GetDelegateForFunctionPointer<PFNGLISENABLEDPROC>(loader.Invoke("glIsEnabled"));
            glDepthRange = Marshal.GetDelegateForFunctionPointer<PFNGLDEPTHRANGEPROC>(loader.Invoke("glDepthRange"));
            glViewport = Marshal.GetDelegateForFunctionPointer<PFNGLVIEWPORTPROC>(loader.Invoke("glViewport"));
            glDrawArrays = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWARRAYSPROC>(loader.Invoke("glDrawArrays"));
            glDrawElements = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWELEMENTSPROC>(loader.Invoke("glDrawElements"));
            glPolygonOffset = Marshal.GetDelegateForFunctionPointer<PFNGLPOLYGONOFFSETPROC>(loader.Invoke("glPolygonOffset"));
            glCopyTexImage1D = Marshal.GetDelegateForFunctionPointer<PFNGLCOPYTEXIMAGE1DPROC>(loader.Invoke("glCopyTexImage1D"));
            glCopyTexImage2D = Marshal.GetDelegateForFunctionPointer<PFNGLCOPYTEXIMAGE2DPROC>(loader.Invoke("glCopyTexImage2D"));
            glCopyTexSubImage1D = Marshal.GetDelegateForFunctionPointer<PFNGLCOPYTEXSUBIMAGE1DPROC>(loader.Invoke("glCopyTexSubImage1D"));
            glCopyTexSubImage2D = Marshal.GetDelegateForFunctionPointer<PFNGLCOPYTEXSUBIMAGE2DPROC>(loader.Invoke("glCopyTexSubImage2D"));
            glTexSubImage1D = Marshal.GetDelegateForFunctionPointer<PFNGLTEXSUBIMAGE1DPROC>(loader.Invoke("glTexSubImage1D"));
            glTexSubImage2D = Marshal.GetDelegateForFunctionPointer<PFNGLTEXSUBIMAGE2DPROC>(loader.Invoke("glTexSubImage2D"));
            glBindTexture = Marshal.GetDelegateForFunctionPointer<PFNGLBINDTEXTUREPROC>(loader.Invoke("glBindTexture"));
            glDeleteTextures = Marshal.GetDelegateForFunctionPointer<PFNGLDELETETEXTURESPROC>(loader.Invoke("glDeleteTextures"));
            glGenTextures = Marshal.GetDelegateForFunctionPointer<PFNGLGENTEXTURESPROC>(loader.Invoke("glGenTextures"));
            glIsTexture = Marshal.GetDelegateForFunctionPointer<PFNGLISTEXTUREPROC>(loader.Invoke("glIsTexture"));
            glDrawRangeElements = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWRANGEELEMENTSPROC>(loader.Invoke("glDrawRangeElements"));
            glTexImage3D = Marshal.GetDelegateForFunctionPointer<PFNGLTEXIMAGE3DPROC>(loader.Invoke("glTexImage3D"));
            glTexSubImage3D = Marshal.GetDelegateForFunctionPointer<PFNGLTEXSUBIMAGE3DPROC>(loader.Invoke("glTexSubImage3D"));
            glCopyTexSubImage3D = Marshal.GetDelegateForFunctionPointer<PFNGLCOPYTEXSUBIMAGE3DPROC>(loader.Invoke("glCopyTexSubImage3D"));
            glActiveTexture = Marshal.GetDelegateForFunctionPointer<PFNGLACTIVETEXTUREPROC>(loader.Invoke("glActiveTexture"));
            glSampleCoverage = Marshal.GetDelegateForFunctionPointer<PFNGLSAMPLECOVERAGEPROC>(loader.Invoke("glSampleCoverage"));
            glCompressedTexImage3D = Marshal.GetDelegateForFunctionPointer<PFNGLCOMPRESSEDTEXIMAGE3DPROC>(loader.Invoke("glCompressedTexImage3D"));
            glCompressedTexImage2D = Marshal.GetDelegateForFunctionPointer<PFNGLCOMPRESSEDTEXIMAGE2DPROC>(loader.Invoke("glCompressedTexImage2D"));
            glCompressedTexImage1D = Marshal.GetDelegateForFunctionPointer<PFNGLCOMPRESSEDTEXIMAGE1DPROC>(loader.Invoke("glCompressedTexImage1D"));
            glCompressedTexSubImage3D = Marshal.GetDelegateForFunctionPointer<PFNGLCOMPRESSEDTEXSUBIMAGE3DPROC>(loader.Invoke("glCompressedTexSubImage3D"));
            glCompressedTexSubImage2D = Marshal.GetDelegateForFunctionPointer<PFNGLCOMPRESSEDTEXSUBIMAGE2DPROC>(loader.Invoke("glCompressedTexSubImage2D"));
            glCompressedTexSubImage1D = Marshal.GetDelegateForFunctionPointer<PFNGLCOMPRESSEDTEXSUBIMAGE1DPROC>(loader.Invoke("glCompressedTexSubImage1D"));
            glGetCompressedTexImage = Marshal.GetDelegateForFunctionPointer<PFNGLGETCOMPRESSEDTEXIMAGEPROC>(loader.Invoke("glGetCompressedTexImage"));
            glBlendFuncSeparate = Marshal.GetDelegateForFunctionPointer<PFNGLBLENDFUNCSEPARATEPROC>(loader.Invoke("glBlendFuncSeparate"));
            glMultiDrawArrays = Marshal.GetDelegateForFunctionPointer<PFNGLMULTIDRAWARRAYSPROC>(loader.Invoke("glMultiDrawArrays"));
            glMultiDrawElements = Marshal.GetDelegateForFunctionPointer<PFNGLMULTIDRAWELEMENTSPROC>(loader.Invoke("glMultiDrawElements"));
            glPointParameterf = Marshal.GetDelegateForFunctionPointer<PFNGLPOINTPARAMETERFPROC>(loader.Invoke("glPointParameterf"));
            glPointParameterfv = Marshal.GetDelegateForFunctionPointer<PFNGLPOINTPARAMETERFVPROC>(loader.Invoke("glPointParameterfv"));
            glPointParameteri = Marshal.GetDelegateForFunctionPointer<PFNGLPOINTPARAMETERIPROC>(loader.Invoke("glPointParameteri"));
            glPointParameteriv = Marshal.GetDelegateForFunctionPointer<PFNGLPOINTPARAMETERIVPROC>(loader.Invoke("glPointParameteriv"));
            glVertexAttribP4uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBP4UIVPROC>(loader.Invoke("glVertexAttribP4uiv"));
            glVertexAttribP4ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBP4UIPROC>(loader.Invoke("glVertexAttribP4ui"));
            glVertexAttribP3uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBP3UIVPROC>(loader.Invoke("glVertexAttribP3uiv"));
            glVertexAttribP3ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBP3UIPROC>(loader.Invoke("glVertexAttribP3ui"));
            glVertexAttribP2uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBP2UIVPROC>(loader.Invoke("glVertexAttribP2uiv"));
            glVertexAttribP2ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBP2UIPROC>(loader.Invoke("glVertexAttribP2ui"));
            glVertexAttribP1uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBP1UIVPROC>(loader.Invoke("glVertexAttribP1uiv"));
            glVertexAttribP1ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBP1UIPROC>(loader.Invoke("glVertexAttribP1ui"));
            glVertexAttribDivisor = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBDIVISORPROC>(loader.Invoke("glVertexAttribDivisor"));
            glGetQueryObjectui64v = Marshal.GetDelegateForFunctionPointer<PFNGLGETQUERYOBJECTUI64VPROC>(loader.Invoke("glGetQueryObjectui64v"));
            glGetQueryObjecti64v = Marshal.GetDelegateForFunctionPointer<PFNGLGETQUERYOBJECTI64VPROC>(loader.Invoke("glGetQueryObjecti64v"));
            glQueryCounter = Marshal.GetDelegateForFunctionPointer<PFNGLQUERYCOUNTERPROC>(loader.Invoke("glQueryCounter"));
            glGetSamplerParameterIuiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETSAMPLERPARAMETERIUIVPROC>(loader.Invoke("glGetSamplerParameterIuiv"));
            glGetSamplerParameterfv = Marshal.GetDelegateForFunctionPointer<PFNGLGETSAMPLERPARAMETERFVPROC>(loader.Invoke("glGetSamplerParameterfv"));
            glGetSamplerParameterIiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETSAMPLERPARAMETERIIVPROC>(loader.Invoke("glGetSamplerParameterIiv"));
            glGetSamplerParameteriv = Marshal.GetDelegateForFunctionPointer<PFNGLGETSAMPLERPARAMETERIVPROC>(loader.Invoke("glGetSamplerParameteriv"));
            glSamplerParameterIuiv = Marshal.GetDelegateForFunctionPointer<PFNGLSAMPLERPARAMETERIUIVPROC>(loader.Invoke("glSamplerParameterIuiv"));
            glSamplerParameterIiv = Marshal.GetDelegateForFunctionPointer<PFNGLSAMPLERPARAMETERIIVPROC>(loader.Invoke("glSamplerParameterIiv"));
            glSamplerParameterfv = Marshal.GetDelegateForFunctionPointer<PFNGLSAMPLERPARAMETERFVPROC>(loader.Invoke("glSamplerParameterfv"));
            glSamplerParameterf = Marshal.GetDelegateForFunctionPointer<PFNGLSAMPLERPARAMETERFPROC>(loader.Invoke("glSamplerParameterf"));
            glSamplerParameteriv = Marshal.GetDelegateForFunctionPointer<PFNGLSAMPLERPARAMETERIVPROC>(loader.Invoke("glSamplerParameteriv"));
            glSamplerParameteri = Marshal.GetDelegateForFunctionPointer<PFNGLSAMPLERPARAMETERIPROC>(loader.Invoke("glSamplerParameteri"));
            glBindSampler = Marshal.GetDelegateForFunctionPointer<PFNGLBINDSAMPLERPROC>(loader.Invoke("glBindSampler"));
            glIsSampler = Marshal.GetDelegateForFunctionPointer<PFNGLISSAMPLERPROC>(loader.Invoke("glIsSampler"));
            glDeleteSamplers = Marshal.GetDelegateForFunctionPointer<PFNGLDELETESAMPLERSPROC>(loader.Invoke("glDeleteSamplers"));
            glGenSamplers = Marshal.GetDelegateForFunctionPointer<PFNGLGENSAMPLERSPROC>(loader.Invoke("glGenSamplers"));
            glGetFragDataIndex = Marshal.GetDelegateForFunctionPointer<PFNGLGETFRAGDATAINDEXPROC>(loader.Invoke("glGetFragDataIndex"));
            glBindFragDataLocationIndexed = Marshal.GetDelegateForFunctionPointer<PFNGLBINDFRAGDATALOCATIONINDEXEDPROC>(loader.Invoke("glBindFragDataLocationIndexed"));
            glBlendColor = Marshal.GetDelegateForFunctionPointer<PFNGLBLENDCOLORPROC>(loader.Invoke("glBlendColor"));
            glBlendEquation = Marshal.GetDelegateForFunctionPointer<PFNGLBLENDEQUATIONPROC>(loader.Invoke("glBlendEquation"));
            glGenQueries = Marshal.GetDelegateForFunctionPointer<PFNGLGENQUERIESPROC>(loader.Invoke("glGenQueries"));
            glDeleteQueries = Marshal.GetDelegateForFunctionPointer<PFNGLDELETEQUERIESPROC>(loader.Invoke("glDeleteQueries"));
            glIsQuery = Marshal.GetDelegateForFunctionPointer<PFNGLISQUERYPROC>(loader.Invoke("glIsQuery"));
            glBeginQuery = Marshal.GetDelegateForFunctionPointer<PFNGLBEGINQUERYPROC>(loader.Invoke("glBeginQuery"));
            glEndQuery = Marshal.GetDelegateForFunctionPointer<PFNGLENDQUERYPROC>(loader.Invoke("glEndQuery"));
            glGetQueryiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETQUERYIVPROC>(loader.Invoke("glGetQueryiv"));
            glGetQueryObjectiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETQUERYOBJECTIVPROC>(loader.Invoke("glGetQueryObjectiv"));
            glGetQueryObjectuiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETQUERYOBJECTUIVPROC>(loader.Invoke("glGetQueryObjectuiv"));
            glBindBuffer = Marshal.GetDelegateForFunctionPointer<PFNGLBINDBUFFERPROC>(loader.Invoke("glBindBuffer"));
            glDeleteBuffers = Marshal.GetDelegateForFunctionPointer<PFNGLDELETEBUFFERSPROC>(loader.Invoke("glDeleteBuffers"));
            glGenBuffers = Marshal.GetDelegateForFunctionPointer<PFNGLGENBUFFERSPROC>(loader.Invoke("glGenBuffers"));
            glIsBuffer = Marshal.GetDelegateForFunctionPointer<PFNGLISBUFFERPROC>(loader.Invoke("glIsBuffer"));
            glBufferData = Marshal.GetDelegateForFunctionPointer<PFNGLBUFFERDATAPROC>(loader.Invoke("glBufferData"));
            glBufferSubData = Marshal.GetDelegateForFunctionPointer<PFNGLBUFFERSUBDATAPROC>(loader.Invoke("glBufferSubData"));
            glGetBufferSubData = Marshal.GetDelegateForFunctionPointer<PFNGLGETBUFFERSUBDATAPROC>(loader.Invoke("glGetBufferSubData"));
            glMapBuffer = Marshal.GetDelegateForFunctionPointer<PFNGLMAPBUFFERPROC>(loader.Invoke("glMapBuffer"));
            glUnmapBuffer = Marshal.GetDelegateForFunctionPointer<PFNGLUNMAPBUFFERPROC>(loader.Invoke("glUnmapBuffer"));
            glGetBufferParameteriv = Marshal.GetDelegateForFunctionPointer<PFNGLGETBUFFERPARAMETERIVPROC>(loader.Invoke("glGetBufferParameteriv"));
            glGetBufferPointerv = Marshal.GetDelegateForFunctionPointer<PFNGLGETBUFFERPOINTERVPROC>(loader.Invoke("glGetBufferPointerv"));
            glBlendEquationSeparate = Marshal.GetDelegateForFunctionPointer<PFNGLBLENDEQUATIONSEPARATEPROC>(loader.Invoke("glBlendEquationSeparate"));
            glDrawBuffers = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWBUFFERSPROC>(loader.Invoke("glDrawBuffers"));
            glStencilOpSeparate = Marshal.GetDelegateForFunctionPointer<PFNGLSTENCILOPSEPARATEPROC>(loader.Invoke("glStencilOpSeparate"));
            glStencilFuncSeparate = Marshal.GetDelegateForFunctionPointer<PFNGLSTENCILFUNCSEPARATEPROC>(loader.Invoke("glStencilFuncSeparate"));
            glStencilMaskSeparate = Marshal.GetDelegateForFunctionPointer<PFNGLSTENCILMASKSEPARATEPROC>(loader.Invoke("glStencilMaskSeparate"));
            glAttachShader = Marshal.GetDelegateForFunctionPointer<PFNGLATTACHSHADERPROC>(loader.Invoke("glAttachShader"));
            glBindAttribLocation = Marshal.GetDelegateForFunctionPointer<PFNGLBINDATTRIBLOCATIONPROC>(loader.Invoke("glBindAttribLocation"));
            glCompileShader = Marshal.GetDelegateForFunctionPointer<PFNGLCOMPILESHADERPROC>(loader.Invoke("glCompileShader"));
            glCreateProgram = Marshal.GetDelegateForFunctionPointer<PFNGLCREATEPROGRAMPROC>(loader.Invoke("glCreateProgram"));
            glCreateShader = Marshal.GetDelegateForFunctionPointer<PFNGLCREATESHADERPROC>(loader.Invoke("glCreateShader"));
            glDeleteProgram = Marshal.GetDelegateForFunctionPointer<PFNGLDELETEPROGRAMPROC>(loader.Invoke("glDeleteProgram"));
            glDeleteShader = Marshal.GetDelegateForFunctionPointer<PFNGLDELETESHADERPROC>(loader.Invoke("glDeleteShader"));
            glDetachShader = Marshal.GetDelegateForFunctionPointer<PFNGLDETACHSHADERPROC>(loader.Invoke("glDetachShader"));
            glDisableVertexAttribArray = Marshal.GetDelegateForFunctionPointer<PFNGLDISABLEVERTEXATTRIBARRAYPROC>(loader.Invoke("glDisableVertexAttribArray"));
            glEnableVertexAttribArray = Marshal.GetDelegateForFunctionPointer<PFNGLENABLEVERTEXATTRIBARRAYPROC>(loader.Invoke("glEnableVertexAttribArray"));
            glGetActiveAttrib = Marshal.GetDelegateForFunctionPointer<PFNGLGETACTIVEATTRIBPROC>(loader.Invoke("glGetActiveAttrib"));
            glGetActiveUniform = Marshal.GetDelegateForFunctionPointer<PFNGLGETACTIVEUNIFORMPROC>(loader.Invoke("glGetActiveUniform"));
            glGetAttachedShaders = Marshal.GetDelegateForFunctionPointer<PFNGLGETATTACHEDSHADERSPROC>(loader.Invoke("glGetAttachedShaders"));
            glGetAttribLocation = Marshal.GetDelegateForFunctionPointer<PFNGLGETATTRIBLOCATIONPROC>(loader.Invoke("glGetAttribLocation"));
            glGetProgramiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETPROGRAMIVPROC>(loader.Invoke("glGetProgramiv"));
            glGetProgramInfoLog = Marshal.GetDelegateForFunctionPointer<PFNGLGETPROGRAMINFOLOGPROC>(loader.Invoke("glGetProgramInfoLog"));
            glGetShaderiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETSHADERIVPROC>(loader.Invoke("glGetShaderiv"));
            glGetShaderInfoLog = Marshal.GetDelegateForFunctionPointer<PFNGLGETSHADERINFOLOGPROC>(loader.Invoke("glGetShaderInfoLog"));
            glGetShaderSource = Marshal.GetDelegateForFunctionPointer<PFNGLGETSHADERSOURCEPROC>(loader.Invoke("glGetShaderSource"));
            glGetUniformLocation = Marshal.GetDelegateForFunctionPointer<PFNGLGETUNIFORMLOCATIONPROC>(loader.Invoke("glGetUniformLocation"));
            glGetUniformfv = Marshal.GetDelegateForFunctionPointer<PFNGLGETUNIFORMFVPROC>(loader.Invoke("glGetUniformfv"));
            glGetUniformiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETUNIFORMIVPROC>(loader.Invoke("glGetUniformiv"));
            glGetVertexAttribdv = Marshal.GetDelegateForFunctionPointer<PFNGLGETVERTEXATTRIBDVPROC>(loader.Invoke("glGetVertexAttribdv"));
            glGetVertexAttribfv = Marshal.GetDelegateForFunctionPointer<PFNGLGETVERTEXATTRIBFVPROC>(loader.Invoke("glGetVertexAttribfv"));
            glGetVertexAttribiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETVERTEXATTRIBIVPROC>(loader.Invoke("glGetVertexAttribiv"));
            glGetVertexAttribPointerv = Marshal.GetDelegateForFunctionPointer<PFNGLGETVERTEXATTRIBPOINTERVPROC>(loader.Invoke("glGetVertexAttribPointerv"));
            glIsProgram = Marshal.GetDelegateForFunctionPointer<PFNGLISPROGRAMPROC>(loader.Invoke("glIsProgram"));
            glIsShader = Marshal.GetDelegateForFunctionPointer<PFNGLISSHADERPROC>(loader.Invoke("glIsShader"));
            glLinkProgram = Marshal.GetDelegateForFunctionPointer<PFNGLLINKPROGRAMPROC>(loader.Invoke("glLinkProgram"));
            glShaderSource = Marshal.GetDelegateForFunctionPointer<PFNGLSHADERSOURCEPROC>(loader.Invoke("glShaderSource"));
            glUseProgram = Marshal.GetDelegateForFunctionPointer<PFNGLUSEPROGRAMPROC>(loader.Invoke("glUseProgram"));
            glUniform1f = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM1FPROC>(loader.Invoke("glUniform1f"));
            glUniform2f = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM2FPROC>(loader.Invoke("glUniform2f"));
            glUniform3f = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM3FPROC>(loader.Invoke("glUniform3f"));
            glUniform4f = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM4FPROC>(loader.Invoke("glUniform4f"));
            glUniform1i = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM1IPROC>(loader.Invoke("glUniform1i"));
            glUniform2i = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM2IPROC>(loader.Invoke("glUniform2i"));
            glUniform3i = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM3IPROC>(loader.Invoke("glUniform3i"));
            glUniform4i = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM4IPROC>(loader.Invoke("glUniform4i"));
            glUniform1fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM1FVPROC>(loader.Invoke("glUniform1fv"));
            glUniform2fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM2FVPROC>(loader.Invoke("glUniform2fv"));
            glUniform3fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM3FVPROC>(loader.Invoke("glUniform3fv"));
            glUniform4fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM4FVPROC>(loader.Invoke("glUniform4fv"));
            glUniform1iv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM1IVPROC>(loader.Invoke("glUniform1iv"));
            glUniform2iv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM2IVPROC>(loader.Invoke("glUniform2iv"));
            glUniform3iv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM3IVPROC>(loader.Invoke("glUniform3iv"));
            glUniform4iv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM4IVPROC>(loader.Invoke("glUniform4iv"));
            glUniformMatrix2fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMMATRIX2FVPROC>(loader.Invoke("glUniformMatrix2fv"));
            glUniformMatrix3fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMMATRIX3FVPROC>(loader.Invoke("glUniformMatrix3fv"));
            glUniformMatrix4fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMMATRIX4FVPROC>(loader.Invoke("glUniformMatrix4fv"));
            glValidateProgram = Marshal.GetDelegateForFunctionPointer<PFNGLVALIDATEPROGRAMPROC>(loader.Invoke("glValidateProgram"));
            glVertexAttrib1d = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB1DPROC>(loader.Invoke("glVertexAttrib1d"));
            glVertexAttrib1dv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB1DVPROC>(loader.Invoke("glVertexAttrib1dv"));
            glVertexAttrib1f = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB1FPROC>(loader.Invoke("glVertexAttrib1f"));
            glVertexAttrib1fv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB1FVPROC>(loader.Invoke("glVertexAttrib1fv"));
            glVertexAttrib1s = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB1SPROC>(loader.Invoke("glVertexAttrib1s"));
            glVertexAttrib1sv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB1SVPROC>(loader.Invoke("glVertexAttrib1sv"));
            glVertexAttrib2d = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB2DPROC>(loader.Invoke("glVertexAttrib2d"));
            glVertexAttrib2dv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB2DVPROC>(loader.Invoke("glVertexAttrib2dv"));
            glVertexAttrib2f = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB2FPROC>(loader.Invoke("glVertexAttrib2f"));
            glVertexAttrib2fv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB2FVPROC>(loader.Invoke("glVertexAttrib2fv"));
            glVertexAttrib2s = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB2SPROC>(loader.Invoke("glVertexAttrib2s"));
            glVertexAttrib2sv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB2SVPROC>(loader.Invoke("glVertexAttrib2sv"));
            glVertexAttrib3d = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB3DPROC>(loader.Invoke("glVertexAttrib3d"));
            glVertexAttrib3dv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB3DVPROC>(loader.Invoke("glVertexAttrib3dv"));
            glVertexAttrib3f = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB3FPROC>(loader.Invoke("glVertexAttrib3f"));
            glVertexAttrib3fv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB3FVPROC>(loader.Invoke("glVertexAttrib3fv"));
            glVertexAttrib3s = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB3SPROC>(loader.Invoke("glVertexAttrib3s"));
            glVertexAttrib3sv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB3SVPROC>(loader.Invoke("glVertexAttrib3sv"));
            glVertexAttrib4Nbv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4NBVPROC>(loader.Invoke("glVertexAttrib4Nbv"));
            glVertexAttrib4Niv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4NIVPROC>(loader.Invoke("glVertexAttrib4Niv"));
            glVertexAttrib4Nsv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4NSVPROC>(loader.Invoke("glVertexAttrib4Nsv"));
            glVertexAttrib4Nub = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4NUBPROC>(loader.Invoke("glVertexAttrib4Nub"));
            glVertexAttrib4Nubv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4NUBVPROC>(loader.Invoke("glVertexAttrib4Nubv"));
            glVertexAttrib4Nuiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4NUIVPROC>(loader.Invoke("glVertexAttrib4Nuiv"));
            glVertexAttrib4Nusv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4NUSVPROC>(loader.Invoke("glVertexAttrib4Nusv"));
            glVertexAttrib4bv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4BVPROC>(loader.Invoke("glVertexAttrib4bv"));
            glVertexAttrib4d = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4DPROC>(loader.Invoke("glVertexAttrib4d"));
            glVertexAttrib4dv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4DVPROC>(loader.Invoke("glVertexAttrib4dv"));
            glVertexAttrib4f = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4FPROC>(loader.Invoke("glVertexAttrib4f"));
            glVertexAttrib4fv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4FVPROC>(loader.Invoke("glVertexAttrib4fv"));
            glVertexAttrib4iv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4IVPROC>(loader.Invoke("glVertexAttrib4iv"));
            glVertexAttrib4s = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4SPROC>(loader.Invoke("glVertexAttrib4s"));
            glVertexAttrib4sv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4SVPROC>(loader.Invoke("glVertexAttrib4sv"));
            glVertexAttrib4ubv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4UBVPROC>(loader.Invoke("glVertexAttrib4ubv"));
            glVertexAttrib4uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4UIVPROC>(loader.Invoke("glVertexAttrib4uiv"));
            glVertexAttrib4usv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIB4USVPROC>(loader.Invoke("glVertexAttrib4usv"));
            glVertexAttribPointer = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBPOINTERPROC>(loader.Invoke("glVertexAttribPointer"));
            glUniformMatrix2x3fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMMATRIX2X3FVPROC>(loader.Invoke("glUniformMatrix2x3fv"));
            glUniformMatrix3x2fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMMATRIX3X2FVPROC>(loader.Invoke("glUniformMatrix3x2fv"));
            glUniformMatrix2x4fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMMATRIX2X4FVPROC>(loader.Invoke("glUniformMatrix2x4fv"));
            glUniformMatrix4x2fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMMATRIX4X2FVPROC>(loader.Invoke("glUniformMatrix4x2fv"));
            glUniformMatrix3x4fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMMATRIX3X4FVPROC>(loader.Invoke("glUniformMatrix3x4fv"));
            glUniformMatrix4x3fv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMMATRIX4X3FVPROC>(loader.Invoke("glUniformMatrix4x3fv"));
            glColorMaski = Marshal.GetDelegateForFunctionPointer<PFNGLCOLORMASKIPROC>(loader.Invoke("glColorMaski"));
            glGetBooleani_v = Marshal.GetDelegateForFunctionPointer<PFNGLGETBOOLEANI_VPROC>(loader.Invoke("glGetBooleani_v"));
            glGetIntegeri_v = Marshal.GetDelegateForFunctionPointer<PFNGLGETINTEGERI_VPROC>(loader.Invoke("glGetIntegeri_v"));
            glEnablei = Marshal.GetDelegateForFunctionPointer<PFNGLENABLEIPROC>(loader.Invoke("glEnablei"));
            glDisablei = Marshal.GetDelegateForFunctionPointer<PFNGLDISABLEIPROC>(loader.Invoke("glDisablei"));
            glIsEnabledi = Marshal.GetDelegateForFunctionPointer<PFNGLISENABLEDIPROC>(loader.Invoke("glIsEnabledi"));
            glBeginTransformFeedback = Marshal.GetDelegateForFunctionPointer<PFNGLBEGINTRANSFORMFEEDBACKPROC>(loader.Invoke("glBeginTransformFeedback"));
            glEndTransformFeedback = Marshal.GetDelegateForFunctionPointer<PFNGLENDTRANSFORMFEEDBACKPROC>(loader.Invoke("glEndTransformFeedback"));
            glBindBufferRange = Marshal.GetDelegateForFunctionPointer<PFNGLBINDBUFFERRANGEPROC>(loader.Invoke("glBindBufferRange"));
            glBindBufferBase = Marshal.GetDelegateForFunctionPointer<PFNGLBINDBUFFERBASEPROC>(loader.Invoke("glBindBufferBase"));
            glTransformFeedbackVaryings = Marshal.GetDelegateForFunctionPointer<PFNGLTRANSFORMFEEDBACKVARYINGSPROC>(loader.Invoke("glTransformFeedbackVaryings"));
            glGetTransformFeedbackVarying = Marshal.GetDelegateForFunctionPointer<PFNGLGETTRANSFORMFEEDBACKVARYINGPROC>(loader.Invoke("glGetTransformFeedbackVarying"));
            glClampColor = Marshal.GetDelegateForFunctionPointer<PFNGLCLAMPCOLORPROC>(loader.Invoke("glClampColor"));
            glBeginConditionalRender = Marshal.GetDelegateForFunctionPointer<PFNGLBEGINCONDITIONALRENDERPROC>(loader.Invoke("glBeginConditionalRender"));
            glEndConditionalRender = Marshal.GetDelegateForFunctionPointer<PFNGLENDCONDITIONALRENDERPROC>(loader.Invoke("glEndConditionalRender"));
            glVertexAttribIPointer = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBIPOINTERPROC>(loader.Invoke("glVertexAttribIPointer"));
            glGetVertexAttribIiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETVERTEXATTRIBIIVPROC>(loader.Invoke("glGetVertexAttribIiv"));
            glGetVertexAttribIuiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETVERTEXATTRIBIUIVPROC>(loader.Invoke("glGetVertexAttribIuiv"));
            glVertexAttribI1i = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI1IPROC>(loader.Invoke("glVertexAttribI1i"));
            glVertexAttribI2i = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI2IPROC>(loader.Invoke("glVertexAttribI2i"));
            glVertexAttribI3i = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI3IPROC>(loader.Invoke("glVertexAttribI3i"));
            glVertexAttribI4i = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI4IPROC>(loader.Invoke("glVertexAttribI4i"));
            glVertexAttribI1ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI1UIPROC>(loader.Invoke("glVertexAttribI1ui"));
            glVertexAttribI2ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI2UIPROC>(loader.Invoke("glVertexAttribI2ui"));
            glVertexAttribI3ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI3UIPROC>(loader.Invoke("glVertexAttribI3ui"));
            glVertexAttribI4ui = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI4UIPROC>(loader.Invoke("glVertexAttribI4ui"));
            glVertexAttribI1iv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI1IVPROC>(loader.Invoke("glVertexAttribI1iv"));
            glVertexAttribI2iv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI2IVPROC>(loader.Invoke("glVertexAttribI2iv"));
            glVertexAttribI3iv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI3IVPROC>(loader.Invoke("glVertexAttribI3iv"));
            glVertexAttribI4iv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI4IVPROC>(loader.Invoke("glVertexAttribI4iv"));
            glVertexAttribI1uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI1UIVPROC>(loader.Invoke("glVertexAttribI1uiv"));
            glVertexAttribI2uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI2UIVPROC>(loader.Invoke("glVertexAttribI2uiv"));
            glVertexAttribI3uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI3UIVPROC>(loader.Invoke("glVertexAttribI3uiv"));
            glVertexAttribI4uiv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI4UIVPROC>(loader.Invoke("glVertexAttribI4uiv"));
            glVertexAttribI4bv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI4BVPROC>(loader.Invoke("glVertexAttribI4bv"));
            glVertexAttribI4sv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI4SVPROC>(loader.Invoke("glVertexAttribI4sv"));
            glVertexAttribI4ubv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI4UBVPROC>(loader.Invoke("glVertexAttribI4ubv"));
            glVertexAttribI4usv = Marshal.GetDelegateForFunctionPointer<PFNGLVERTEXATTRIBI4USVPROC>(loader.Invoke("glVertexAttribI4usv"));
            glGetUniformuiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETUNIFORMUIVPROC>(loader.Invoke("glGetUniformuiv"));
            glBindFragDataLocation = Marshal.GetDelegateForFunctionPointer<PFNGLBINDFRAGDATALOCATIONPROC>(loader.Invoke("glBindFragDataLocation"));
            glGetFragDataLocation = Marshal.GetDelegateForFunctionPointer<PFNGLGETFRAGDATALOCATIONPROC>(loader.Invoke("glGetFragDataLocation"));
            glUniform1ui = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM1UIPROC>(loader.Invoke("glUniform1ui"));
            glUniform2ui = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM2UIPROC>(loader.Invoke("glUniform2ui"));
            glUniform3ui = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM3UIPROC>(loader.Invoke("glUniform3ui"));
            glUniform4ui = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM4UIPROC>(loader.Invoke("glUniform4ui"));
            glUniform1uiv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM1UIVPROC>(loader.Invoke("glUniform1uiv"));
            glUniform2uiv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM2UIVPROC>(loader.Invoke("glUniform2uiv"));
            glUniform3uiv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM3UIVPROC>(loader.Invoke("glUniform3uiv"));
            glUniform4uiv = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORM4UIVPROC>(loader.Invoke("glUniform4uiv"));
            glTexParameterIiv = Marshal.GetDelegateForFunctionPointer<PFNGLTEXPARAMETERIIVPROC>(loader.Invoke("glTexParameterIiv"));
            glTexParameterIuiv = Marshal.GetDelegateForFunctionPointer<PFNGLTEXPARAMETERIUIVPROC>(loader.Invoke("glTexParameterIuiv"));
            glGetTexParameterIiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETTEXPARAMETERIIVPROC>(loader.Invoke("glGetTexParameterIiv"));
            glGetTexParameterIuiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETTEXPARAMETERIUIVPROC>(loader.Invoke("glGetTexParameterIuiv"));
            glClearBufferiv = Marshal.GetDelegateForFunctionPointer<PFNGLCLEARBUFFERIVPROC>(loader.Invoke("glClearBufferiv"));
            glClearBufferuiv = Marshal.GetDelegateForFunctionPointer<PFNGLCLEARBUFFERUIVPROC>(loader.Invoke("glClearBufferuiv"));
            glClearBufferfv = Marshal.GetDelegateForFunctionPointer<PFNGLCLEARBUFFERFVPROC>(loader.Invoke("glClearBufferfv"));
            glClearBufferfi = Marshal.GetDelegateForFunctionPointer<PFNGLCLEARBUFFERFIPROC>(loader.Invoke("glClearBufferfi"));
            glGetStringi = Marshal.GetDelegateForFunctionPointer<PFNGLGETSTRINGIPROC>(loader.Invoke("glGetStringi"));
            glIsRenderbuffer = Marshal.GetDelegateForFunctionPointer<PFNGLISRENDERBUFFERPROC>(loader.Invoke("glIsRenderbuffer"));
            glBindRenderbuffer = Marshal.GetDelegateForFunctionPointer<PFNGLBINDRENDERBUFFERPROC>(loader.Invoke("glBindRenderbuffer"));
            glDeleteRenderbuffers = Marshal.GetDelegateForFunctionPointer<PFNGLDELETERENDERBUFFERSPROC>(loader.Invoke("glDeleteRenderbuffers"));
            glGenRenderbuffers = Marshal.GetDelegateForFunctionPointer<PFNGLGENRENDERBUFFERSPROC>(loader.Invoke("glGenRenderbuffers"));
            glRenderbufferStorage = Marshal.GetDelegateForFunctionPointer<PFNGLRENDERBUFFERSTORAGEPROC>(loader.Invoke("glRenderbufferStorage"));
            glGetRenderbufferParameteriv = Marshal.GetDelegateForFunctionPointer<PFNGLGETRENDERBUFFERPARAMETERIVPROC>(loader.Invoke("glGetRenderbufferParameteriv"));
            glIsFramebuffer = Marshal.GetDelegateForFunctionPointer<PFNGLISFRAMEBUFFERPROC>(loader.Invoke("glIsFramebuffer"));
            glBindFramebuffer = Marshal.GetDelegateForFunctionPointer<PFNGLBINDFRAMEBUFFERPROC>(loader.Invoke("glBindFramebuffer"));
            glDeleteFramebuffers = Marshal.GetDelegateForFunctionPointer<PFNGLDELETEFRAMEBUFFERSPROC>(loader.Invoke("glDeleteFramebuffers"));
            glGenFramebuffers = Marshal.GetDelegateForFunctionPointer<PFNGLGENFRAMEBUFFERSPROC>(loader.Invoke("glGenFramebuffers"));
            glCheckFramebufferStatus = Marshal.GetDelegateForFunctionPointer<PFNGLCHECKFRAMEBUFFERSTATUSPROC>(loader.Invoke("glCheckFramebufferStatus"));
            glFramebufferTexture1D = Marshal.GetDelegateForFunctionPointer<PFNGLFRAMEBUFFERTEXTURE1DPROC>(loader.Invoke("glFramebufferTexture1D"));
            glFramebufferTexture2D = Marshal.GetDelegateForFunctionPointer<PFNGLFRAMEBUFFERTEXTURE2DPROC>(loader.Invoke("glFramebufferTexture2D"));
            glFramebufferTexture3D = Marshal.GetDelegateForFunctionPointer<PFNGLFRAMEBUFFERTEXTURE3DPROC>(loader.Invoke("glFramebufferTexture3D"));
            glFramebufferRenderbuffer = Marshal.GetDelegateForFunctionPointer<PFNGLFRAMEBUFFERRENDERBUFFERPROC>(loader.Invoke("glFramebufferRenderbuffer"));
            glGetFramebufferAttachmentParameteriv = Marshal.GetDelegateForFunctionPointer<PFNGLGETFRAMEBUFFERATTACHMENTPARAMETERIVPROC>(loader.Invoke("glGetFramebufferAttachmentParameteriv"));
            glGenerateMipmap = Marshal.GetDelegateForFunctionPointer<PFNGLGENERATEMIPMAPPROC>(loader.Invoke("glGenerateMipmap"));
            glBlitFramebuffer = Marshal.GetDelegateForFunctionPointer<PFNGLBLITFRAMEBUFFERPROC>(loader.Invoke("glBlitFramebuffer"));
            glRenderbufferStorageMultisample = Marshal.GetDelegateForFunctionPointer<PFNGLRENDERBUFFERSTORAGEMULTISAMPLEPROC>(loader.Invoke("glRenderbufferStorageMultisample"));
            glFramebufferTextureLayer = Marshal.GetDelegateForFunctionPointer<PFNGLFRAMEBUFFERTEXTURELAYERPROC>(loader.Invoke("glFramebufferTextureLayer"));
            glMapBufferRange = Marshal.GetDelegateForFunctionPointer<PFNGLMAPBUFFERRANGEPROC>(loader.Invoke("glMapBufferRange"));
            glFlushMappedBufferRange = Marshal.GetDelegateForFunctionPointer<PFNGLFLUSHMAPPEDBUFFERRANGEPROC>(loader.Invoke("glFlushMappedBufferRange"));
            glBindVertexArray = Marshal.GetDelegateForFunctionPointer<PFNGLBINDVERTEXARRAYPROC>(loader.Invoke("glBindVertexArray"));
            glDeleteVertexArrays = Marshal.GetDelegateForFunctionPointer<PFNGLDELETEVERTEXARRAYSPROC>(loader.Invoke("glDeleteVertexArrays"));
            glGenVertexArrays = Marshal.GetDelegateForFunctionPointer<PFNGLGENVERTEXARRAYSPROC>(loader.Invoke("glGenVertexArrays"));
            glIsVertexArray = Marshal.GetDelegateForFunctionPointer<PFNGLISVERTEXARRAYPROC>(loader.Invoke("glIsVertexArray"));
            glDrawArraysInstanced = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWARRAYSINSTANCEDPROC>(loader.Invoke("glDrawArraysInstanced"));
            glDrawElementsInstanced = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWELEMENTSINSTANCEDPROC>(loader.Invoke("glDrawElementsInstanced"));
            glTexBuffer = Marshal.GetDelegateForFunctionPointer<PFNGLTEXBUFFERPROC>(loader.Invoke("glTexBuffer"));
            glPrimitiveRestartIndex = Marshal.GetDelegateForFunctionPointer<PFNGLPRIMITIVERESTARTINDEXPROC>(loader.Invoke("glPrimitiveRestartIndex"));
            glCopyBufferSubData = Marshal.GetDelegateForFunctionPointer<PFNGLCOPYBUFFERSUBDATAPROC>(loader.Invoke("glCopyBufferSubData"));
            glGetUniformIndices = Marshal.GetDelegateForFunctionPointer<PFNGLGETUNIFORMINDICESPROC>(loader.Invoke("glGetUniformIndices"));
            glGetActiveUniformsiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETACTIVEUNIFORMSIVPROC>(loader.Invoke("glGetActiveUniformsiv"));
            glGetActiveUniformName = Marshal.GetDelegateForFunctionPointer<PFNGLGETACTIVEUNIFORMNAMEPROC>(loader.Invoke("glGetActiveUniformName"));
            glGetUniformBlockIndex = Marshal.GetDelegateForFunctionPointer<PFNGLGETUNIFORMBLOCKINDEXPROC>(loader.Invoke("glGetUniformBlockIndex"));
            glGetActiveUniformBlockiv = Marshal.GetDelegateForFunctionPointer<PFNGLGETACTIVEUNIFORMBLOCKIVPROC>(loader.Invoke("glGetActiveUniformBlockiv"));
            glGetActiveUniformBlockName = Marshal.GetDelegateForFunctionPointer<PFNGLGETACTIVEUNIFORMBLOCKNAMEPROC>(loader.Invoke("glGetActiveUniformBlockName"));
            glUniformBlockBinding = Marshal.GetDelegateForFunctionPointer<PFNGLUNIFORMBLOCKBINDINGPROC>(loader.Invoke("glUniformBlockBinding"));
            glDrawElementsBaseVertex = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWELEMENTSBASEVERTEXPROC>(loader.Invoke("glDrawElementsBaseVertex"));
            glDrawRangeElementsBaseVertex = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWRANGEELEMENTSBASEVERTEXPROC>(loader.Invoke("glDrawRangeElementsBaseVertex"));
            glDrawElementsInstancedBaseVertex = Marshal.GetDelegateForFunctionPointer<PFNGLDRAWELEMENTSINSTANCEDBASEVERTEXPROC>(loader.Invoke("glDrawElementsInstancedBaseVertex"));
            glMultiDrawElementsBaseVertex = Marshal.GetDelegateForFunctionPointer<PFNGLMULTIDRAWELEMENTSBASEVERTEXPROC>(loader.Invoke("glMultiDrawElementsBaseVertex"));
            glProvokingVertex = Marshal.GetDelegateForFunctionPointer<PFNGLPROVOKINGVERTEXPROC>(loader.Invoke("glProvokingVertex"));
            glFenceSync = Marshal.GetDelegateForFunctionPointer<PFNGLFENCESYNCPROC>(loader.Invoke("glFenceSync"));
            glIsSync = Marshal.GetDelegateForFunctionPointer<PFNGLISSYNCPROC>(loader.Invoke("glIsSync"));
            glDeleteSync = Marshal.GetDelegateForFunctionPointer<PFNGLDELETESYNCPROC>(loader.Invoke("glDeleteSync"));
            glClientWaitSync = Marshal.GetDelegateForFunctionPointer<PFNGLCLIENTWAITSYNCPROC>(loader.Invoke("glClientWaitSync"));
            glWaitSync = Marshal.GetDelegateForFunctionPointer<PFNGLWAITSYNCPROC>(loader.Invoke("glWaitSync"));
            glGetInteger64v = Marshal.GetDelegateForFunctionPointer<PFNGLGETINTEGER64VPROC>(loader.Invoke("glGetInteger64v"));
            glGetSynciv = Marshal.GetDelegateForFunctionPointer<PFNGLGETSYNCIVPROC>(loader.Invoke("glGetSynciv"));
            glGetInteger64i_v = Marshal.GetDelegateForFunctionPointer<PFNGLGETINTEGER64I_VPROC>(loader.Invoke("glGetInteger64i_v"));
            glGetBufferParameteri64v = Marshal.GetDelegateForFunctionPointer<PFNGLGETBUFFERPARAMETERI64VPROC>(loader.Invoke("glGetBufferParameteri64v"));
            glFramebufferTexture = Marshal.GetDelegateForFunctionPointer<PFNGLFRAMEBUFFERTEXTUREPROC>(loader.Invoke("glFramebufferTexture"));
            glTexImage2DMultisample = Marshal.GetDelegateForFunctionPointer<PFNGLTEXIMAGE2DMULTISAMPLEPROC>(loader.Invoke("glTexImage2DMultisample"));
            glTexImage3DMultisample = Marshal.GetDelegateForFunctionPointer<PFNGLTEXIMAGE3DMULTISAMPLEPROC>(loader.Invoke("glTexImage3DMultisample"));
            glGetMultisamplefv = Marshal.GetDelegateForFunctionPointer<PFNGLGETMULTISAMPLEFVPROC>(loader.Invoke("glGetMultisamplefv"));
            glSampleMaski = Marshal.GetDelegateForFunctionPointer<PFNGLSAMPLEMASKIPROC>(loader.Invoke("glSampleMaski"));
        }
    }
}
