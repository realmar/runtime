// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Runtime.Intrinsics
{
    [Intrinsic]
    [StructLayout(LayoutKind.Sequential, Size = 8)]
    public struct Vector64<T> where T : struct {}
}
