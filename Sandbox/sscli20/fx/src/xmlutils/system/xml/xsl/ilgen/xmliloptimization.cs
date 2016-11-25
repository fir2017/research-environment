//------------------------------------------------------------------------------
// <copyright file="XmlILOptimization.cs" company="Microsoft">
//     
//      Copyright (c) 2006 Microsoft Corporation.  All rights reserved.
//     
//      The use and distribution terms for this software are contained in the file
//      named license.txt, which can be found in the root of this distribution.
//      By using this software in any fashion, you are agreeing to be bound by the
//      terms of this license.
//     
//      You must not remove this notice, or any other, from this software.
//     
// </copyright>
//------------------------------------------------------------------------------

namespace System.Xml.Xsl.IlGen {

    /// <summary>
    /// Xml IL patterns.
    /// </summary>
    internal enum XmlILOptimization {
        None,
        FoldConstant,
        TailCall,

        // Do not edit this region
        // It is auto-generated
        #region AUTOGENERATED
        AnnotateAncestor,
        AnnotateAncestorSelf,
        AnnotateAttribute,
        AnnotateAttrNmspLoop,
        AnnotateBarrier,
        AnnotateConstruction,
        AnnotateContent,
        AnnotateContentLoop,
        AnnotateDescendant,
        AnnotateDescendantLoop,
        AnnotateDescendantSelf,
        AnnotateDifference,
        AnnotateDod,
        AnnotateDodMerge,
        AnnotateDodReverse,
        AnnotateFilter,
        AnnotateFilterAttributeKind,
        AnnotateFilterContentKind,
        AnnotateFilterElements,
        AnnotateFollowingSibling,
        AnnotateIndex1,
        AnnotateIndex2,
        AnnotateIntersect,
        AnnotateInvoke,
        AnnotateJoinAndDod,
        AnnotateLet,
        AnnotateMaxLengthEq,
        AnnotateMaxLengthGe,
        AnnotateMaxLengthGt,
        AnnotateMaxLengthLe,
        AnnotateMaxLengthLt,
        AnnotateMaxLengthNe,
        AnnotateMaxPositionEq,
        AnnotateMaxPositionLe,
        AnnotateMaxPositionLt,
        AnnotateNamespace,
        AnnotateNodeRange,
        AnnotateParent,
        AnnotatePositionalIterator,
        AnnotatePreceding,
        AnnotatePrecedingSibling,
        AnnotateRoot,
        AnnotateRootLoop,
        AnnotateSingleTextRtf,
        AnnotateSingletonLoop,
        AnnotateTrackCallers,
        AnnotateUnion,
        AnnotateUnionContent,
        AnnotateXPathFollowing,
        AnnotateXPathPreceding,
        CommuteDodFilter,
        CommuteFilterLoop,
        EliminateAdd,
        EliminateAfter,
        EliminateAnd,
        EliminateAverage,
        EliminateBefore,
        EliminateConditional,
        EliminateDifference,
        EliminateDivide,
        EliminateDod,
        EliminateEq,
        EliminateFilter,
        EliminateGe,
        EliminateGt,
        EliminateIntersection,
        EliminateIs,
        EliminateIsEmpty,
        EliminateIsType,
        EliminateIterator,
        EliminateIteratorUsedAtMostOnce,
        EliminateLe,
        EliminateLength,
        EliminateLoop,
        EliminateLt,
        EliminateMaximum,
        EliminateMinimum,
        EliminateModulo,
        EliminateMultiply,
        EliminateNamespaceDecl,
        EliminateNe,
        EliminateNegate,
        EliminateNop,
        EliminateNot,
        EliminateOr,
        EliminatePositionOf,
        EliminateReturnDod,
        EliminateSequence,
        EliminateSort,
        EliminateStrConcat,
        EliminateStrConcatSingle,
        EliminateStrLength,
        EliminateSubtract,
        EliminateSum,
        EliminateTypeAssert,
        EliminateTypeAssertOptional,
        EliminateUnion,
        EliminateUnusedFunctions,
        EliminateXsltConvert,
        FoldConditionalNot,
        FoldNamedDescendants,
        FoldNone,
        FoldXsltConvertLiteral,
        IntroduceDod,
        IntroducePrecedingDod,
        NormalizeAddEq,
        NormalizeAddLiteral,
        NormalizeAttribute,
        NormalizeConditionalText,
        NormalizeDifference,
        NormalizeEqLiteral,
        NormalizeGeLiteral,
        NormalizeGtLiteral,
        NormalizeIdEq,
        NormalizeIdNe,
        NormalizeIntersect,
        NormalizeInvokeEmpty,
        NormalizeLeLiteral,
        NormalizeLengthGt,
        NormalizeLengthNe,
        NormalizeLoopConditional,
        NormalizeLoopInvariant,
        NormalizeLoopLoop,
        NormalizeLoopText,
        NormalizeLtLiteral,
        NormalizeMuenchian,
        NormalizeMultiplyLiteral,
        NormalizeNeLiteral,
        NormalizeNestedSequences,
        NormalizeSingletonLet,
        NormalizeSortXsltConvert,
        NormalizeUnion,
        NormalizeXsltConvertEq,
        NormalizeXsltConvertGe,
        NormalizeXsltConvertGt,
        NormalizeXsltConvertLe,
        NormalizeXsltConvertLt,
        NormalizeXsltConvertNe,
        #endregion // AUTOGENERATED

        // Must appear last in the enum
        Last_,
    }
}