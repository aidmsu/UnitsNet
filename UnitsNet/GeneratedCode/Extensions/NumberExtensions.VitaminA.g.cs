﻿// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

#if !WINDOWS_UWP
// Extension methods/overloads not supported in Universal Windows Platform (WinRT Components)
namespace UnitsNet.Extensions
{
    public static partial class NumberExtensions
    {
        #region InternationalUnit

        /// <inheritdoc cref="VitaminA.FromInternationalUnits(double)"/>
        public static VitaminA InternationalUnits(this int value) => VitaminA.FromInternationalUnits(value);

        /// <inheritdoc cref="VitaminA.FromInternationalUnits(double?)"/>
        public static VitaminA? InternationalUnits(this int? value) => VitaminA.FromInternationalUnits(value);

        /// <inheritdoc cref="VitaminA.FromInternationalUnits(double)"/>
        public static VitaminA InternationalUnits(this long value) => VitaminA.FromInternationalUnits(value);

        /// <inheritdoc cref="VitaminA.FromInternationalUnits(double?)"/>
        public static VitaminA? InternationalUnits(this long? value) => VitaminA.FromInternationalUnits(value);

        /// <inheritdoc cref="VitaminA.FromInternationalUnits(double)"/>
        public static VitaminA InternationalUnits(this double value) => VitaminA.FromInternationalUnits(value);

        /// <inheritdoc cref="VitaminA.FromInternationalUnits(double?)"/>
        public static VitaminA? InternationalUnits(this double? value) => VitaminA.FromInternationalUnits(value);

        /// <inheritdoc cref="VitaminA.FromInternationalUnits(double)"/>
        public static VitaminA InternationalUnits(this float value) => VitaminA.FromInternationalUnits(value);

        /// <inheritdoc cref="VitaminA.FromInternationalUnits(double?)"/>
        public static VitaminA? InternationalUnits(this float? value) => VitaminA.FromInternationalUnits(value);

        /// <inheritdoc cref="VitaminA.FromInternationalUnits(double)"/>
        public static VitaminA InternationalUnits(this decimal value) => VitaminA.FromInternationalUnits(Convert.ToDouble(value));

        /// <inheritdoc cref="VitaminA.FromInternationalUnits(double?)"/>
        public static VitaminA? InternationalUnits(this decimal? value) => VitaminA.FromInternationalUnits(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
