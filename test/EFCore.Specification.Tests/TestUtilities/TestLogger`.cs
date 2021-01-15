﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Microsoft.EntityFrameworkCore.TestUtilities
{
    public class TestLogger<TDefinitions> : TestLogger
        where TDefinitions : LoggingDefinitions, new()
    {
        public TestLogger()
            : base(new TDefinitions())
        { }

        public TestLogger(LoggingDefinitions definitions)
            : base(definitions)
        {
        }
    }
}
