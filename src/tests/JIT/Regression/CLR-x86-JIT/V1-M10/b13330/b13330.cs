// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
//

namespace D
{
    //@BEGINRENAME; Verify this renames
    //@ENDRENAME; Verify this renames
    using System;

    class X
    {
        internal static char f(int x)
        {
            return (char)(x >> 8);
        }

        public static int Main()
        {
            f(123);
            return 100;
        }
    }
}
