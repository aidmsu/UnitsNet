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
        #region DecibelMilliwatt

        /// <inheritdoc cref="PowerRatio.FromDecibelMilliwatts(double)"/>
        public static PowerRatio DecibelMilliwatts(this int value) => PowerRatio.FromDecibelMilliwatts(value);

        /// <inheritdoc cref="PowerRatio.FromDecibelMilliwatts(double?)"/>
        public static PowerRatio? DecibelMilliwatts(this int? value) => PowerRatio.FromDecibelMilliwatts(value);

        /// <inheritdoc cref="PowerRatio.FromDecibelMilliwatts(double)"/>
        public static PowerRatio DecibelMilliwatts(this long value) => PowerRatio.FromDecibelMilliwatts(value);

        /// <inheritdoc cref="PowerRatio.FromDecibelMilliwatts(double?)"/>
        public static PowerRatio? DecibelMilliwatts(this long? value) => PowerRatio.FromDecibelMilliwatts(value);

        /// <inheritdoc cref="PowerRatio.FromDecibelMilliwatts(double)"/>
        public static PowerRatio DecibelMilliwatts(this double value) => PowerRatio.FromDecibelMilliwatts(value);

        /// <inheritdoc cref="PowerRatio.FromDecibelMilliwatts(double?)"/>
        public static PowerRatio? DecibelMilliwatts(this double? value) => PowerRatio.FromDecibelMilliwatts(value);

        /// <inheritdoc cref="PowerRatio.FromDecibelMilliwatts(double)"/>
        public static PowerRatio DecibelMilliwatts(this float value) => PowerRatio.FromDecibelMilliwatts(value);

        /// <inheritdoc cref="PowerRatio.FromDecibelMilliwatts(double?)"/>
        public static PowerRatio? DecibelMilliwatts(this float? value) => PowerRatio.FromDecibelMilliwatts(value);

        /// <inheritdoc cref="PowerRatio.FromDecibelMilliwatts(double)"/>
        public static PowerRatio DecibelMilliwatts(this decimal value) => PowerRatio.FromDecibelMilliwatts(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerRatio.FromDecibelMilliwatts(double?)"/>
        public static PowerRatio? DecibelMilliwatts(this decimal? value) => PowerRatio.FromDecibelMilliwatts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecibelWatt

        /// <inheritdoc cref="PowerRatio.FromDecibelWatts(double)"/>
        public static PowerRatio DecibelWatts(this int value) => PowerRatio.FromDecibelWatts(value);

        /// <inheritdoc cref="PowerRatio.FromDecibelWatts(double?)"/>
        public static PowerRatio? DecibelWatts(this int? value) => PowerRatio.FromDecibelWatts(value);

        /// <inheritdoc cref="PowerRatio.FromDecibelWatts(double)"/>
        public static PowerRatio DecibelWatts(this long value) => PowerRatio.FromDecibelWatts(value);

        /// <inheritdoc cref="PowerRatio.FromDecibelWatts(double?)"/>
        public static PowerRatio? DecibelWatts(this long? value) => PowerRatio.FromDecibelWatts(value);

        /// <inheritdoc cref="PowerRatio.FromDecibelWatts(double)"/>
        public static PowerRatio DecibelWatts(this double value) => PowerRatio.FromDecibelWatts(value);

        /// <inheritdoc cref="PowerRatio.FromDecibelWatts(double?)"/>
        public static PowerRatio? DecibelWatts(this double? value) => PowerRatio.FromDecibelWatts(value);

        /// <inheritdoc cref="PowerRatio.FromDecibelWatts(double)"/>
        public static PowerRatio DecibelWatts(this float value) => PowerRatio.FromDecibelWatts(value);

        /// <inheritdoc cref="PowerRatio.FromDecibelWatts(double?)"/>
        public static PowerRatio? DecibelWatts(this float? value) => PowerRatio.FromDecibelWatts(value);

        /// <inheritdoc cref="PowerRatio.FromDecibelWatts(double)"/>
        public static PowerRatio DecibelWatts(this decimal value) => PowerRatio.FromDecibelWatts(Convert.ToDouble(value));

        /// <inheritdoc cref="PowerRatio.FromDecibelWatts(double?)"/>
        public static PowerRatio? DecibelWatts(this decimal? value) => PowerRatio.FromDecibelWatts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
