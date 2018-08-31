﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

namespace Test.Utilities
{
    public static class Traits
    {
        public const string DataflowAnalysis = nameof(DataflowAnalysis);
#pragma warning disable CA1034 // Nested types should not be visible - test class matching the pattern used in Roslyn.
#pragma warning disable CA1724 // Type names should not match namespaces
        public static class Dataflow
#pragma warning restore CA1724 // Type names should not match namespaces
#pragma warning restore CA1034 // Nested types should not be visible
        {
            public const string CopyAnalysis = nameof(CopyAnalysis);
            public const string NullAnalysis = nameof(NullAnalysis);
            public const string PointsToAnalysis = nameof(PointsToAnalysis);
            public const string StringContentAnalysis = nameof(StringContentAnalysis);
            public const string DisposeAnalysis = nameof(DisposeAnalysis);
            public const string ParameterValidationAnalysis = nameof(ParameterValidationAnalysis);

            public const string PredicateAnalysis = nameof(PredicateAnalysis);
        }
    }
}