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
        #region KilogramForcePerCubicCentimeter

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicCentimeter(double)"/>
        public static SpecificWeight KilogramsForcePerCubicCentimeter(this int value) => SpecificWeight.FromKilogramsForcePerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicCentimeter(double?)"/>
        public static SpecificWeight? KilogramsForcePerCubicCentimeter(this int? value) => SpecificWeight.FromKilogramsForcePerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicCentimeter(double)"/>
        public static SpecificWeight KilogramsForcePerCubicCentimeter(this long value) => SpecificWeight.FromKilogramsForcePerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicCentimeter(double?)"/>
        public static SpecificWeight? KilogramsForcePerCubicCentimeter(this long? value) => SpecificWeight.FromKilogramsForcePerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicCentimeter(double)"/>
        public static SpecificWeight KilogramsForcePerCubicCentimeter(this double value) => SpecificWeight.FromKilogramsForcePerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicCentimeter(double?)"/>
        public static SpecificWeight? KilogramsForcePerCubicCentimeter(this double? value) => SpecificWeight.FromKilogramsForcePerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicCentimeter(double)"/>
        public static SpecificWeight KilogramsForcePerCubicCentimeter(this float value) => SpecificWeight.FromKilogramsForcePerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicCentimeter(double?)"/>
        public static SpecificWeight? KilogramsForcePerCubicCentimeter(this float? value) => SpecificWeight.FromKilogramsForcePerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicCentimeter(double)"/>
        public static SpecificWeight KilogramsForcePerCubicCentimeter(this decimal value) => SpecificWeight.FromKilogramsForcePerCubicCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicCentimeter(double?)"/>
        public static SpecificWeight? KilogramsForcePerCubicCentimeter(this decimal? value) => SpecificWeight.FromKilogramsForcePerCubicCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramForcePerCubicMeter

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMeter(double)"/>
        public static SpecificWeight KilogramsForcePerCubicMeter(this int value) => SpecificWeight.FromKilogramsForcePerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMeter(double?)"/>
        public static SpecificWeight? KilogramsForcePerCubicMeter(this int? value) => SpecificWeight.FromKilogramsForcePerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMeter(double)"/>
        public static SpecificWeight KilogramsForcePerCubicMeter(this long value) => SpecificWeight.FromKilogramsForcePerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMeter(double?)"/>
        public static SpecificWeight? KilogramsForcePerCubicMeter(this long? value) => SpecificWeight.FromKilogramsForcePerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMeter(double)"/>
        public static SpecificWeight KilogramsForcePerCubicMeter(this double value) => SpecificWeight.FromKilogramsForcePerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMeter(double?)"/>
        public static SpecificWeight? KilogramsForcePerCubicMeter(this double? value) => SpecificWeight.FromKilogramsForcePerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMeter(double)"/>
        public static SpecificWeight KilogramsForcePerCubicMeter(this float value) => SpecificWeight.FromKilogramsForcePerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMeter(double?)"/>
        public static SpecificWeight? KilogramsForcePerCubicMeter(this float? value) => SpecificWeight.FromKilogramsForcePerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMeter(double)"/>
        public static SpecificWeight KilogramsForcePerCubicMeter(this decimal value) => SpecificWeight.FromKilogramsForcePerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMeter(double?)"/>
        public static SpecificWeight? KilogramsForcePerCubicMeter(this decimal? value) => SpecificWeight.FromKilogramsForcePerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramForcePerCubicMillimeter

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMillimeter(double)"/>
        public static SpecificWeight KilogramsForcePerCubicMillimeter(this int value) => SpecificWeight.FromKilogramsForcePerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMillimeter(double?)"/>
        public static SpecificWeight? KilogramsForcePerCubicMillimeter(this int? value) => SpecificWeight.FromKilogramsForcePerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMillimeter(double)"/>
        public static SpecificWeight KilogramsForcePerCubicMillimeter(this long value) => SpecificWeight.FromKilogramsForcePerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMillimeter(double?)"/>
        public static SpecificWeight? KilogramsForcePerCubicMillimeter(this long? value) => SpecificWeight.FromKilogramsForcePerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMillimeter(double)"/>
        public static SpecificWeight KilogramsForcePerCubicMillimeter(this double value) => SpecificWeight.FromKilogramsForcePerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMillimeter(double?)"/>
        public static SpecificWeight? KilogramsForcePerCubicMillimeter(this double? value) => SpecificWeight.FromKilogramsForcePerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMillimeter(double)"/>
        public static SpecificWeight KilogramsForcePerCubicMillimeter(this float value) => SpecificWeight.FromKilogramsForcePerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMillimeter(double?)"/>
        public static SpecificWeight? KilogramsForcePerCubicMillimeter(this float? value) => SpecificWeight.FromKilogramsForcePerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMillimeter(double)"/>
        public static SpecificWeight KilogramsForcePerCubicMillimeter(this decimal value) => SpecificWeight.FromKilogramsForcePerCubicMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificWeight.FromKilogramsForcePerCubicMillimeter(double?)"/>
        public static SpecificWeight? KilogramsForcePerCubicMillimeter(this decimal? value) => SpecificWeight.FromKilogramsForcePerCubicMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilonewtonPerCubicCentimeter

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicCentimeter(double)"/>
        public static SpecificWeight KilonewtonsPerCubicCentimeter(this int value) => SpecificWeight.FromKilonewtonsPerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicCentimeter(double?)"/>
        public static SpecificWeight? KilonewtonsPerCubicCentimeter(this int? value) => SpecificWeight.FromKilonewtonsPerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicCentimeter(double)"/>
        public static SpecificWeight KilonewtonsPerCubicCentimeter(this long value) => SpecificWeight.FromKilonewtonsPerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicCentimeter(double?)"/>
        public static SpecificWeight? KilonewtonsPerCubicCentimeter(this long? value) => SpecificWeight.FromKilonewtonsPerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicCentimeter(double)"/>
        public static SpecificWeight KilonewtonsPerCubicCentimeter(this double value) => SpecificWeight.FromKilonewtonsPerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicCentimeter(double?)"/>
        public static SpecificWeight? KilonewtonsPerCubicCentimeter(this double? value) => SpecificWeight.FromKilonewtonsPerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicCentimeter(double)"/>
        public static SpecificWeight KilonewtonsPerCubicCentimeter(this float value) => SpecificWeight.FromKilonewtonsPerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicCentimeter(double?)"/>
        public static SpecificWeight? KilonewtonsPerCubicCentimeter(this float? value) => SpecificWeight.FromKilonewtonsPerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicCentimeter(double)"/>
        public static SpecificWeight KilonewtonsPerCubicCentimeter(this decimal value) => SpecificWeight.FromKilonewtonsPerCubicCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicCentimeter(double?)"/>
        public static SpecificWeight? KilonewtonsPerCubicCentimeter(this decimal? value) => SpecificWeight.FromKilonewtonsPerCubicCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilonewtonPerCubicMeter

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMeter(double)"/>
        public static SpecificWeight KilonewtonsPerCubicMeter(this int value) => SpecificWeight.FromKilonewtonsPerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMeter(double?)"/>
        public static SpecificWeight? KilonewtonsPerCubicMeter(this int? value) => SpecificWeight.FromKilonewtonsPerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMeter(double)"/>
        public static SpecificWeight KilonewtonsPerCubicMeter(this long value) => SpecificWeight.FromKilonewtonsPerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMeter(double?)"/>
        public static SpecificWeight? KilonewtonsPerCubicMeter(this long? value) => SpecificWeight.FromKilonewtonsPerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMeter(double)"/>
        public static SpecificWeight KilonewtonsPerCubicMeter(this double value) => SpecificWeight.FromKilonewtonsPerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMeter(double?)"/>
        public static SpecificWeight? KilonewtonsPerCubicMeter(this double? value) => SpecificWeight.FromKilonewtonsPerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMeter(double)"/>
        public static SpecificWeight KilonewtonsPerCubicMeter(this float value) => SpecificWeight.FromKilonewtonsPerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMeter(double?)"/>
        public static SpecificWeight? KilonewtonsPerCubicMeter(this float? value) => SpecificWeight.FromKilonewtonsPerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMeter(double)"/>
        public static SpecificWeight KilonewtonsPerCubicMeter(this decimal value) => SpecificWeight.FromKilonewtonsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMeter(double?)"/>
        public static SpecificWeight? KilonewtonsPerCubicMeter(this decimal? value) => SpecificWeight.FromKilonewtonsPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilonewtonPerCubicMillimeter

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMillimeter(double)"/>
        public static SpecificWeight KilonewtonsPerCubicMillimeter(this int value) => SpecificWeight.FromKilonewtonsPerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMillimeter(double?)"/>
        public static SpecificWeight? KilonewtonsPerCubicMillimeter(this int? value) => SpecificWeight.FromKilonewtonsPerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMillimeter(double)"/>
        public static SpecificWeight KilonewtonsPerCubicMillimeter(this long value) => SpecificWeight.FromKilonewtonsPerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMillimeter(double?)"/>
        public static SpecificWeight? KilonewtonsPerCubicMillimeter(this long? value) => SpecificWeight.FromKilonewtonsPerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMillimeter(double)"/>
        public static SpecificWeight KilonewtonsPerCubicMillimeter(this double value) => SpecificWeight.FromKilonewtonsPerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMillimeter(double?)"/>
        public static SpecificWeight? KilonewtonsPerCubicMillimeter(this double? value) => SpecificWeight.FromKilonewtonsPerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMillimeter(double)"/>
        public static SpecificWeight KilonewtonsPerCubicMillimeter(this float value) => SpecificWeight.FromKilonewtonsPerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMillimeter(double?)"/>
        public static SpecificWeight? KilonewtonsPerCubicMillimeter(this float? value) => SpecificWeight.FromKilonewtonsPerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMillimeter(double)"/>
        public static SpecificWeight KilonewtonsPerCubicMillimeter(this decimal value) => SpecificWeight.FromKilonewtonsPerCubicMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificWeight.FromKilonewtonsPerCubicMillimeter(double?)"/>
        public static SpecificWeight? KilonewtonsPerCubicMillimeter(this decimal? value) => SpecificWeight.FromKilonewtonsPerCubicMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilopoundForcePerCubicFoot

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicFoot(double)"/>
        public static SpecificWeight KilopoundsForcePerCubicFoot(this int value) => SpecificWeight.FromKilopoundsForcePerCubicFoot(value);

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicFoot(double?)"/>
        public static SpecificWeight? KilopoundsForcePerCubicFoot(this int? value) => SpecificWeight.FromKilopoundsForcePerCubicFoot(value);

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicFoot(double)"/>
        public static SpecificWeight KilopoundsForcePerCubicFoot(this long value) => SpecificWeight.FromKilopoundsForcePerCubicFoot(value);

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicFoot(double?)"/>
        public static SpecificWeight? KilopoundsForcePerCubicFoot(this long? value) => SpecificWeight.FromKilopoundsForcePerCubicFoot(value);

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicFoot(double)"/>
        public static SpecificWeight KilopoundsForcePerCubicFoot(this double value) => SpecificWeight.FromKilopoundsForcePerCubicFoot(value);

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicFoot(double?)"/>
        public static SpecificWeight? KilopoundsForcePerCubicFoot(this double? value) => SpecificWeight.FromKilopoundsForcePerCubicFoot(value);

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicFoot(double)"/>
        public static SpecificWeight KilopoundsForcePerCubicFoot(this float value) => SpecificWeight.FromKilopoundsForcePerCubicFoot(value);

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicFoot(double?)"/>
        public static SpecificWeight? KilopoundsForcePerCubicFoot(this float? value) => SpecificWeight.FromKilopoundsForcePerCubicFoot(value);

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicFoot(double)"/>
        public static SpecificWeight KilopoundsForcePerCubicFoot(this decimal value) => SpecificWeight.FromKilopoundsForcePerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicFoot(double?)"/>
        public static SpecificWeight? KilopoundsForcePerCubicFoot(this decimal? value) => SpecificWeight.FromKilopoundsForcePerCubicFoot(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilopoundForcePerCubicInch

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicInch(double)"/>
        public static SpecificWeight KilopoundsForcePerCubicInch(this int value) => SpecificWeight.FromKilopoundsForcePerCubicInch(value);

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicInch(double?)"/>
        public static SpecificWeight? KilopoundsForcePerCubicInch(this int? value) => SpecificWeight.FromKilopoundsForcePerCubicInch(value);

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicInch(double)"/>
        public static SpecificWeight KilopoundsForcePerCubicInch(this long value) => SpecificWeight.FromKilopoundsForcePerCubicInch(value);

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicInch(double?)"/>
        public static SpecificWeight? KilopoundsForcePerCubicInch(this long? value) => SpecificWeight.FromKilopoundsForcePerCubicInch(value);

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicInch(double)"/>
        public static SpecificWeight KilopoundsForcePerCubicInch(this double value) => SpecificWeight.FromKilopoundsForcePerCubicInch(value);

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicInch(double?)"/>
        public static SpecificWeight? KilopoundsForcePerCubicInch(this double? value) => SpecificWeight.FromKilopoundsForcePerCubicInch(value);

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicInch(double)"/>
        public static SpecificWeight KilopoundsForcePerCubicInch(this float value) => SpecificWeight.FromKilopoundsForcePerCubicInch(value);

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicInch(double?)"/>
        public static SpecificWeight? KilopoundsForcePerCubicInch(this float? value) => SpecificWeight.FromKilopoundsForcePerCubicInch(value);

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicInch(double)"/>
        public static SpecificWeight KilopoundsForcePerCubicInch(this decimal value) => SpecificWeight.FromKilopoundsForcePerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificWeight.FromKilopoundsForcePerCubicInch(double?)"/>
        public static SpecificWeight? KilopoundsForcePerCubicInch(this decimal? value) => SpecificWeight.FromKilopoundsForcePerCubicInch(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NewtonPerCubicCentimeter

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicCentimeter(double)"/>
        public static SpecificWeight NewtonsPerCubicCentimeter(this int value) => SpecificWeight.FromNewtonsPerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicCentimeter(double?)"/>
        public static SpecificWeight? NewtonsPerCubicCentimeter(this int? value) => SpecificWeight.FromNewtonsPerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicCentimeter(double)"/>
        public static SpecificWeight NewtonsPerCubicCentimeter(this long value) => SpecificWeight.FromNewtonsPerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicCentimeter(double?)"/>
        public static SpecificWeight? NewtonsPerCubicCentimeter(this long? value) => SpecificWeight.FromNewtonsPerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicCentimeter(double)"/>
        public static SpecificWeight NewtonsPerCubicCentimeter(this double value) => SpecificWeight.FromNewtonsPerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicCentimeter(double?)"/>
        public static SpecificWeight? NewtonsPerCubicCentimeter(this double? value) => SpecificWeight.FromNewtonsPerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicCentimeter(double)"/>
        public static SpecificWeight NewtonsPerCubicCentimeter(this float value) => SpecificWeight.FromNewtonsPerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicCentimeter(double?)"/>
        public static SpecificWeight? NewtonsPerCubicCentimeter(this float? value) => SpecificWeight.FromNewtonsPerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicCentimeter(double)"/>
        public static SpecificWeight NewtonsPerCubicCentimeter(this decimal value) => SpecificWeight.FromNewtonsPerCubicCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicCentimeter(double?)"/>
        public static SpecificWeight? NewtonsPerCubicCentimeter(this decimal? value) => SpecificWeight.FromNewtonsPerCubicCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NewtonPerCubicMeter

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMeter(double)"/>
        public static SpecificWeight NewtonsPerCubicMeter(this int value) => SpecificWeight.FromNewtonsPerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMeter(double?)"/>
        public static SpecificWeight? NewtonsPerCubicMeter(this int? value) => SpecificWeight.FromNewtonsPerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMeter(double)"/>
        public static SpecificWeight NewtonsPerCubicMeter(this long value) => SpecificWeight.FromNewtonsPerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMeter(double?)"/>
        public static SpecificWeight? NewtonsPerCubicMeter(this long? value) => SpecificWeight.FromNewtonsPerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMeter(double)"/>
        public static SpecificWeight NewtonsPerCubicMeter(this double value) => SpecificWeight.FromNewtonsPerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMeter(double?)"/>
        public static SpecificWeight? NewtonsPerCubicMeter(this double? value) => SpecificWeight.FromNewtonsPerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMeter(double)"/>
        public static SpecificWeight NewtonsPerCubicMeter(this float value) => SpecificWeight.FromNewtonsPerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMeter(double?)"/>
        public static SpecificWeight? NewtonsPerCubicMeter(this float? value) => SpecificWeight.FromNewtonsPerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMeter(double)"/>
        public static SpecificWeight NewtonsPerCubicMeter(this decimal value) => SpecificWeight.FromNewtonsPerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMeter(double?)"/>
        public static SpecificWeight? NewtonsPerCubicMeter(this decimal? value) => SpecificWeight.FromNewtonsPerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NewtonPerCubicMillimeter

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMillimeter(double)"/>
        public static SpecificWeight NewtonsPerCubicMillimeter(this int value) => SpecificWeight.FromNewtonsPerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMillimeter(double?)"/>
        public static SpecificWeight? NewtonsPerCubicMillimeter(this int? value) => SpecificWeight.FromNewtonsPerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMillimeter(double)"/>
        public static SpecificWeight NewtonsPerCubicMillimeter(this long value) => SpecificWeight.FromNewtonsPerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMillimeter(double?)"/>
        public static SpecificWeight? NewtonsPerCubicMillimeter(this long? value) => SpecificWeight.FromNewtonsPerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMillimeter(double)"/>
        public static SpecificWeight NewtonsPerCubicMillimeter(this double value) => SpecificWeight.FromNewtonsPerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMillimeter(double?)"/>
        public static SpecificWeight? NewtonsPerCubicMillimeter(this double? value) => SpecificWeight.FromNewtonsPerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMillimeter(double)"/>
        public static SpecificWeight NewtonsPerCubicMillimeter(this float value) => SpecificWeight.FromNewtonsPerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMillimeter(double?)"/>
        public static SpecificWeight? NewtonsPerCubicMillimeter(this float? value) => SpecificWeight.FromNewtonsPerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMillimeter(double)"/>
        public static SpecificWeight NewtonsPerCubicMillimeter(this decimal value) => SpecificWeight.FromNewtonsPerCubicMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificWeight.FromNewtonsPerCubicMillimeter(double?)"/>
        public static SpecificWeight? NewtonsPerCubicMillimeter(this decimal? value) => SpecificWeight.FromNewtonsPerCubicMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundForcePerCubicFoot

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicFoot(double)"/>
        public static SpecificWeight PoundsForcePerCubicFoot(this int value) => SpecificWeight.FromPoundsForcePerCubicFoot(value);

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicFoot(double?)"/>
        public static SpecificWeight? PoundsForcePerCubicFoot(this int? value) => SpecificWeight.FromPoundsForcePerCubicFoot(value);

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicFoot(double)"/>
        public static SpecificWeight PoundsForcePerCubicFoot(this long value) => SpecificWeight.FromPoundsForcePerCubicFoot(value);

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicFoot(double?)"/>
        public static SpecificWeight? PoundsForcePerCubicFoot(this long? value) => SpecificWeight.FromPoundsForcePerCubicFoot(value);

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicFoot(double)"/>
        public static SpecificWeight PoundsForcePerCubicFoot(this double value) => SpecificWeight.FromPoundsForcePerCubicFoot(value);

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicFoot(double?)"/>
        public static SpecificWeight? PoundsForcePerCubicFoot(this double? value) => SpecificWeight.FromPoundsForcePerCubicFoot(value);

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicFoot(double)"/>
        public static SpecificWeight PoundsForcePerCubicFoot(this float value) => SpecificWeight.FromPoundsForcePerCubicFoot(value);

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicFoot(double?)"/>
        public static SpecificWeight? PoundsForcePerCubicFoot(this float? value) => SpecificWeight.FromPoundsForcePerCubicFoot(value);

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicFoot(double)"/>
        public static SpecificWeight PoundsForcePerCubicFoot(this decimal value) => SpecificWeight.FromPoundsForcePerCubicFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicFoot(double?)"/>
        public static SpecificWeight? PoundsForcePerCubicFoot(this decimal? value) => SpecificWeight.FromPoundsForcePerCubicFoot(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundForcePerCubicInch

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicInch(double)"/>
        public static SpecificWeight PoundsForcePerCubicInch(this int value) => SpecificWeight.FromPoundsForcePerCubicInch(value);

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicInch(double?)"/>
        public static SpecificWeight? PoundsForcePerCubicInch(this int? value) => SpecificWeight.FromPoundsForcePerCubicInch(value);

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicInch(double)"/>
        public static SpecificWeight PoundsForcePerCubicInch(this long value) => SpecificWeight.FromPoundsForcePerCubicInch(value);

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicInch(double?)"/>
        public static SpecificWeight? PoundsForcePerCubicInch(this long? value) => SpecificWeight.FromPoundsForcePerCubicInch(value);

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicInch(double)"/>
        public static SpecificWeight PoundsForcePerCubicInch(this double value) => SpecificWeight.FromPoundsForcePerCubicInch(value);

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicInch(double?)"/>
        public static SpecificWeight? PoundsForcePerCubicInch(this double? value) => SpecificWeight.FromPoundsForcePerCubicInch(value);

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicInch(double)"/>
        public static SpecificWeight PoundsForcePerCubicInch(this float value) => SpecificWeight.FromPoundsForcePerCubicInch(value);

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicInch(double?)"/>
        public static SpecificWeight? PoundsForcePerCubicInch(this float? value) => SpecificWeight.FromPoundsForcePerCubicInch(value);

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicInch(double)"/>
        public static SpecificWeight PoundsForcePerCubicInch(this decimal value) => SpecificWeight.FromPoundsForcePerCubicInch(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificWeight.FromPoundsForcePerCubicInch(double?)"/>
        public static SpecificWeight? PoundsForcePerCubicInch(this decimal? value) => SpecificWeight.FromPoundsForcePerCubicInch(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TonneForcePerCubicCentimeter

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicCentimeter(double)"/>
        public static SpecificWeight TonnesForcePerCubicCentimeter(this int value) => SpecificWeight.FromTonnesForcePerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicCentimeter(double?)"/>
        public static SpecificWeight? TonnesForcePerCubicCentimeter(this int? value) => SpecificWeight.FromTonnesForcePerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicCentimeter(double)"/>
        public static SpecificWeight TonnesForcePerCubicCentimeter(this long value) => SpecificWeight.FromTonnesForcePerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicCentimeter(double?)"/>
        public static SpecificWeight? TonnesForcePerCubicCentimeter(this long? value) => SpecificWeight.FromTonnesForcePerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicCentimeter(double)"/>
        public static SpecificWeight TonnesForcePerCubicCentimeter(this double value) => SpecificWeight.FromTonnesForcePerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicCentimeter(double?)"/>
        public static SpecificWeight? TonnesForcePerCubicCentimeter(this double? value) => SpecificWeight.FromTonnesForcePerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicCentimeter(double)"/>
        public static SpecificWeight TonnesForcePerCubicCentimeter(this float value) => SpecificWeight.FromTonnesForcePerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicCentimeter(double?)"/>
        public static SpecificWeight? TonnesForcePerCubicCentimeter(this float? value) => SpecificWeight.FromTonnesForcePerCubicCentimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicCentimeter(double)"/>
        public static SpecificWeight TonnesForcePerCubicCentimeter(this decimal value) => SpecificWeight.FromTonnesForcePerCubicCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicCentimeter(double?)"/>
        public static SpecificWeight? TonnesForcePerCubicCentimeter(this decimal? value) => SpecificWeight.FromTonnesForcePerCubicCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TonneForcePerCubicMeter

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMeter(double)"/>
        public static SpecificWeight TonnesForcePerCubicMeter(this int value) => SpecificWeight.FromTonnesForcePerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMeter(double?)"/>
        public static SpecificWeight? TonnesForcePerCubicMeter(this int? value) => SpecificWeight.FromTonnesForcePerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMeter(double)"/>
        public static SpecificWeight TonnesForcePerCubicMeter(this long value) => SpecificWeight.FromTonnesForcePerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMeter(double?)"/>
        public static SpecificWeight? TonnesForcePerCubicMeter(this long? value) => SpecificWeight.FromTonnesForcePerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMeter(double)"/>
        public static SpecificWeight TonnesForcePerCubicMeter(this double value) => SpecificWeight.FromTonnesForcePerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMeter(double?)"/>
        public static SpecificWeight? TonnesForcePerCubicMeter(this double? value) => SpecificWeight.FromTonnesForcePerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMeter(double)"/>
        public static SpecificWeight TonnesForcePerCubicMeter(this float value) => SpecificWeight.FromTonnesForcePerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMeter(double?)"/>
        public static SpecificWeight? TonnesForcePerCubicMeter(this float? value) => SpecificWeight.FromTonnesForcePerCubicMeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMeter(double)"/>
        public static SpecificWeight TonnesForcePerCubicMeter(this decimal value) => SpecificWeight.FromTonnesForcePerCubicMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMeter(double?)"/>
        public static SpecificWeight? TonnesForcePerCubicMeter(this decimal? value) => SpecificWeight.FromTonnesForcePerCubicMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TonneForcePerCubicMillimeter

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMillimeter(double)"/>
        public static SpecificWeight TonnesForcePerCubicMillimeter(this int value) => SpecificWeight.FromTonnesForcePerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMillimeter(double?)"/>
        public static SpecificWeight? TonnesForcePerCubicMillimeter(this int? value) => SpecificWeight.FromTonnesForcePerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMillimeter(double)"/>
        public static SpecificWeight TonnesForcePerCubicMillimeter(this long value) => SpecificWeight.FromTonnesForcePerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMillimeter(double?)"/>
        public static SpecificWeight? TonnesForcePerCubicMillimeter(this long? value) => SpecificWeight.FromTonnesForcePerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMillimeter(double)"/>
        public static SpecificWeight TonnesForcePerCubicMillimeter(this double value) => SpecificWeight.FromTonnesForcePerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMillimeter(double?)"/>
        public static SpecificWeight? TonnesForcePerCubicMillimeter(this double? value) => SpecificWeight.FromTonnesForcePerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMillimeter(double)"/>
        public static SpecificWeight TonnesForcePerCubicMillimeter(this float value) => SpecificWeight.FromTonnesForcePerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMillimeter(double?)"/>
        public static SpecificWeight? TonnesForcePerCubicMillimeter(this float? value) => SpecificWeight.FromTonnesForcePerCubicMillimeter(value);

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMillimeter(double)"/>
        public static SpecificWeight TonnesForcePerCubicMillimeter(this decimal value) => SpecificWeight.FromTonnesForcePerCubicMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="SpecificWeight.FromTonnesForcePerCubicMillimeter(double?)"/>
        public static SpecificWeight? TonnesForcePerCubicMillimeter(this decimal? value) => SpecificWeight.FromTonnesForcePerCubicMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
