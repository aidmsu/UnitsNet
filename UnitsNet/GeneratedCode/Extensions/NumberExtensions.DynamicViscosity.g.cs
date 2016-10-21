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
        #region Centipoise

        /// <inheritdoc cref="DynamicViscosity.FromCentipoise(double)"/>
        public static DynamicViscosity Centipoise(this int value) => DynamicViscosity.FromCentipoise(value);

        /// <inheritdoc cref="DynamicViscosity.FromCentipoise(double?)"/>
        public static DynamicViscosity? Centipoise(this int? value) => DynamicViscosity.FromCentipoise(value);

        /// <inheritdoc cref="DynamicViscosity.FromCentipoise(double)"/>
        public static DynamicViscosity Centipoise(this long value) => DynamicViscosity.FromCentipoise(value);

        /// <inheritdoc cref="DynamicViscosity.FromCentipoise(double?)"/>
        public static DynamicViscosity? Centipoise(this long? value) => DynamicViscosity.FromCentipoise(value);

        /// <inheritdoc cref="DynamicViscosity.FromCentipoise(double)"/>
        public static DynamicViscosity Centipoise(this double value) => DynamicViscosity.FromCentipoise(value);

        /// <inheritdoc cref="DynamicViscosity.FromCentipoise(double?)"/>
        public static DynamicViscosity? Centipoise(this double? value) => DynamicViscosity.FromCentipoise(value);

        /// <inheritdoc cref="DynamicViscosity.FromCentipoise(double)"/>
        public static DynamicViscosity Centipoise(this float value) => DynamicViscosity.FromCentipoise(value);

        /// <inheritdoc cref="DynamicViscosity.FromCentipoise(double?)"/>
        public static DynamicViscosity? Centipoise(this float? value) => DynamicViscosity.FromCentipoise(value);

        /// <inheritdoc cref="DynamicViscosity.FromCentipoise(double)"/>
        public static DynamicViscosity Centipoise(this decimal value) => DynamicViscosity.FromCentipoise(Convert.ToDouble(value));

        /// <inheritdoc cref="DynamicViscosity.FromCentipoise(double?)"/>
        public static DynamicViscosity? Centipoise(this decimal? value) => DynamicViscosity.FromCentipoise(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillipascalSecond

        /// <inheritdoc cref="DynamicViscosity.FromMillipascalSeconds(double)"/>
        public static DynamicViscosity MillipascalSeconds(this int value) => DynamicViscosity.FromMillipascalSeconds(value);

        /// <inheritdoc cref="DynamicViscosity.FromMillipascalSeconds(double?)"/>
        public static DynamicViscosity? MillipascalSeconds(this int? value) => DynamicViscosity.FromMillipascalSeconds(value);

        /// <inheritdoc cref="DynamicViscosity.FromMillipascalSeconds(double)"/>
        public static DynamicViscosity MillipascalSeconds(this long value) => DynamicViscosity.FromMillipascalSeconds(value);

        /// <inheritdoc cref="DynamicViscosity.FromMillipascalSeconds(double?)"/>
        public static DynamicViscosity? MillipascalSeconds(this long? value) => DynamicViscosity.FromMillipascalSeconds(value);

        /// <inheritdoc cref="DynamicViscosity.FromMillipascalSeconds(double)"/>
        public static DynamicViscosity MillipascalSeconds(this double value) => DynamicViscosity.FromMillipascalSeconds(value);

        /// <inheritdoc cref="DynamicViscosity.FromMillipascalSeconds(double?)"/>
        public static DynamicViscosity? MillipascalSeconds(this double? value) => DynamicViscosity.FromMillipascalSeconds(value);

        /// <inheritdoc cref="DynamicViscosity.FromMillipascalSeconds(double)"/>
        public static DynamicViscosity MillipascalSeconds(this float value) => DynamicViscosity.FromMillipascalSeconds(value);

        /// <inheritdoc cref="DynamicViscosity.FromMillipascalSeconds(double?)"/>
        public static DynamicViscosity? MillipascalSeconds(this float? value) => DynamicViscosity.FromMillipascalSeconds(value);

        /// <inheritdoc cref="DynamicViscosity.FromMillipascalSeconds(double)"/>
        public static DynamicViscosity MillipascalSeconds(this decimal value) => DynamicViscosity.FromMillipascalSeconds(Convert.ToDouble(value));

        /// <inheritdoc cref="DynamicViscosity.FromMillipascalSeconds(double?)"/>
        public static DynamicViscosity? MillipascalSeconds(this decimal? value) => DynamicViscosity.FromMillipascalSeconds(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NewtonSecondPerMeterSquared

        /// <inheritdoc cref="DynamicViscosity.FromNewtonSecondsPerMeterSquared(double)"/>
        public static DynamicViscosity NewtonSecondsPerMeterSquared(this int value) => DynamicViscosity.FromNewtonSecondsPerMeterSquared(value);

        /// <inheritdoc cref="DynamicViscosity.FromNewtonSecondsPerMeterSquared(double?)"/>
        public static DynamicViscosity? NewtonSecondsPerMeterSquared(this int? value) => DynamicViscosity.FromNewtonSecondsPerMeterSquared(value);

        /// <inheritdoc cref="DynamicViscosity.FromNewtonSecondsPerMeterSquared(double)"/>
        public static DynamicViscosity NewtonSecondsPerMeterSquared(this long value) => DynamicViscosity.FromNewtonSecondsPerMeterSquared(value);

        /// <inheritdoc cref="DynamicViscosity.FromNewtonSecondsPerMeterSquared(double?)"/>
        public static DynamicViscosity? NewtonSecondsPerMeterSquared(this long? value) => DynamicViscosity.FromNewtonSecondsPerMeterSquared(value);

        /// <inheritdoc cref="DynamicViscosity.FromNewtonSecondsPerMeterSquared(double)"/>
        public static DynamicViscosity NewtonSecondsPerMeterSquared(this double value) => DynamicViscosity.FromNewtonSecondsPerMeterSquared(value);

        /// <inheritdoc cref="DynamicViscosity.FromNewtonSecondsPerMeterSquared(double?)"/>
        public static DynamicViscosity? NewtonSecondsPerMeterSquared(this double? value) => DynamicViscosity.FromNewtonSecondsPerMeterSquared(value);

        /// <inheritdoc cref="DynamicViscosity.FromNewtonSecondsPerMeterSquared(double)"/>
        public static DynamicViscosity NewtonSecondsPerMeterSquared(this float value) => DynamicViscosity.FromNewtonSecondsPerMeterSquared(value);

        /// <inheritdoc cref="DynamicViscosity.FromNewtonSecondsPerMeterSquared(double?)"/>
        public static DynamicViscosity? NewtonSecondsPerMeterSquared(this float? value) => DynamicViscosity.FromNewtonSecondsPerMeterSquared(value);

        /// <inheritdoc cref="DynamicViscosity.FromNewtonSecondsPerMeterSquared(double)"/>
        public static DynamicViscosity NewtonSecondsPerMeterSquared(this decimal value) => DynamicViscosity.FromNewtonSecondsPerMeterSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="DynamicViscosity.FromNewtonSecondsPerMeterSquared(double?)"/>
        public static DynamicViscosity? NewtonSecondsPerMeterSquared(this decimal? value) => DynamicViscosity.FromNewtonSecondsPerMeterSquared(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PascalSecond

        /// <inheritdoc cref="DynamicViscosity.FromPascalSeconds(double)"/>
        public static DynamicViscosity PascalSeconds(this int value) => DynamicViscosity.FromPascalSeconds(value);

        /// <inheritdoc cref="DynamicViscosity.FromPascalSeconds(double?)"/>
        public static DynamicViscosity? PascalSeconds(this int? value) => DynamicViscosity.FromPascalSeconds(value);

        /// <inheritdoc cref="DynamicViscosity.FromPascalSeconds(double)"/>
        public static DynamicViscosity PascalSeconds(this long value) => DynamicViscosity.FromPascalSeconds(value);

        /// <inheritdoc cref="DynamicViscosity.FromPascalSeconds(double?)"/>
        public static DynamicViscosity? PascalSeconds(this long? value) => DynamicViscosity.FromPascalSeconds(value);

        /// <inheritdoc cref="DynamicViscosity.FromPascalSeconds(double)"/>
        public static DynamicViscosity PascalSeconds(this double value) => DynamicViscosity.FromPascalSeconds(value);

        /// <inheritdoc cref="DynamicViscosity.FromPascalSeconds(double?)"/>
        public static DynamicViscosity? PascalSeconds(this double? value) => DynamicViscosity.FromPascalSeconds(value);

        /// <inheritdoc cref="DynamicViscosity.FromPascalSeconds(double)"/>
        public static DynamicViscosity PascalSeconds(this float value) => DynamicViscosity.FromPascalSeconds(value);

        /// <inheritdoc cref="DynamicViscosity.FromPascalSeconds(double?)"/>
        public static DynamicViscosity? PascalSeconds(this float? value) => DynamicViscosity.FromPascalSeconds(value);

        /// <inheritdoc cref="DynamicViscosity.FromPascalSeconds(double)"/>
        public static DynamicViscosity PascalSeconds(this decimal value) => DynamicViscosity.FromPascalSeconds(Convert.ToDouble(value));

        /// <inheritdoc cref="DynamicViscosity.FromPascalSeconds(double?)"/>
        public static DynamicViscosity? PascalSeconds(this decimal? value) => DynamicViscosity.FromPascalSeconds(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Poise

        /// <inheritdoc cref="DynamicViscosity.FromPoise(double)"/>
        public static DynamicViscosity Poise(this int value) => DynamicViscosity.FromPoise(value);

        /// <inheritdoc cref="DynamicViscosity.FromPoise(double?)"/>
        public static DynamicViscosity? Poise(this int? value) => DynamicViscosity.FromPoise(value);

        /// <inheritdoc cref="DynamicViscosity.FromPoise(double)"/>
        public static DynamicViscosity Poise(this long value) => DynamicViscosity.FromPoise(value);

        /// <inheritdoc cref="DynamicViscosity.FromPoise(double?)"/>
        public static DynamicViscosity? Poise(this long? value) => DynamicViscosity.FromPoise(value);

        /// <inheritdoc cref="DynamicViscosity.FromPoise(double)"/>
        public static DynamicViscosity Poise(this double value) => DynamicViscosity.FromPoise(value);

        /// <inheritdoc cref="DynamicViscosity.FromPoise(double?)"/>
        public static DynamicViscosity? Poise(this double? value) => DynamicViscosity.FromPoise(value);

        /// <inheritdoc cref="DynamicViscosity.FromPoise(double)"/>
        public static DynamicViscosity Poise(this float value) => DynamicViscosity.FromPoise(value);

        /// <inheritdoc cref="DynamicViscosity.FromPoise(double?)"/>
        public static DynamicViscosity? Poise(this float? value) => DynamicViscosity.FromPoise(value);

        /// <inheritdoc cref="DynamicViscosity.FromPoise(double)"/>
        public static DynamicViscosity Poise(this decimal value) => DynamicViscosity.FromPoise(Convert.ToDouble(value));

        /// <inheritdoc cref="DynamicViscosity.FromPoise(double?)"/>
        public static DynamicViscosity? Poise(this decimal? value) => DynamicViscosity.FromPoise(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
