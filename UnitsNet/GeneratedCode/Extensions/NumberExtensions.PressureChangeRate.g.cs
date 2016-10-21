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
        #region AtmospherePerSecond

        /// <inheritdoc cref="PressureChangeRate.FromAtmospheresPerSecond(double)"/>
        public static PressureChangeRate AtmospheresPerSecond(this int value) => PressureChangeRate.FromAtmospheresPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromAtmospheresPerSecond(double?)"/>
        public static PressureChangeRate? AtmospheresPerSecond(this int? value) => PressureChangeRate.FromAtmospheresPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromAtmospheresPerSecond(double)"/>
        public static PressureChangeRate AtmospheresPerSecond(this long value) => PressureChangeRate.FromAtmospheresPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromAtmospheresPerSecond(double?)"/>
        public static PressureChangeRate? AtmospheresPerSecond(this long? value) => PressureChangeRate.FromAtmospheresPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromAtmospheresPerSecond(double)"/>
        public static PressureChangeRate AtmospheresPerSecond(this double value) => PressureChangeRate.FromAtmospheresPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromAtmospheresPerSecond(double?)"/>
        public static PressureChangeRate? AtmospheresPerSecond(this double? value) => PressureChangeRate.FromAtmospheresPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromAtmospheresPerSecond(double)"/>
        public static PressureChangeRate AtmospheresPerSecond(this float value) => PressureChangeRate.FromAtmospheresPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromAtmospheresPerSecond(double?)"/>
        public static PressureChangeRate? AtmospheresPerSecond(this float? value) => PressureChangeRate.FromAtmospheresPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromAtmospheresPerSecond(double)"/>
        public static PressureChangeRate AtmospheresPerSecond(this decimal value) => PressureChangeRate.FromAtmospheresPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="PressureChangeRate.FromAtmospheresPerSecond(double?)"/>
        public static PressureChangeRate? AtmospheresPerSecond(this decimal? value) => PressureChangeRate.FromAtmospheresPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilopascalPerSecond

        /// <inheritdoc cref="PressureChangeRate.FromKilopascalsPerSecond(double)"/>
        public static PressureChangeRate KilopascalsPerSecond(this int value) => PressureChangeRate.FromKilopascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromKilopascalsPerSecond(double?)"/>
        public static PressureChangeRate? KilopascalsPerSecond(this int? value) => PressureChangeRate.FromKilopascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromKilopascalsPerSecond(double)"/>
        public static PressureChangeRate KilopascalsPerSecond(this long value) => PressureChangeRate.FromKilopascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromKilopascalsPerSecond(double?)"/>
        public static PressureChangeRate? KilopascalsPerSecond(this long? value) => PressureChangeRate.FromKilopascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromKilopascalsPerSecond(double)"/>
        public static PressureChangeRate KilopascalsPerSecond(this double value) => PressureChangeRate.FromKilopascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromKilopascalsPerSecond(double?)"/>
        public static PressureChangeRate? KilopascalsPerSecond(this double? value) => PressureChangeRate.FromKilopascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromKilopascalsPerSecond(double)"/>
        public static PressureChangeRate KilopascalsPerSecond(this float value) => PressureChangeRate.FromKilopascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromKilopascalsPerSecond(double?)"/>
        public static PressureChangeRate? KilopascalsPerSecond(this float? value) => PressureChangeRate.FromKilopascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromKilopascalsPerSecond(double)"/>
        public static PressureChangeRate KilopascalsPerSecond(this decimal value) => PressureChangeRate.FromKilopascalsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="PressureChangeRate.FromKilopascalsPerSecond(double?)"/>
        public static PressureChangeRate? KilopascalsPerSecond(this decimal? value) => PressureChangeRate.FromKilopascalsPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MegapascalPerSecond

        /// <inheritdoc cref="PressureChangeRate.FromMegapascalsPerSecond(double)"/>
        public static PressureChangeRate MegapascalsPerSecond(this int value) => PressureChangeRate.FromMegapascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromMegapascalsPerSecond(double?)"/>
        public static PressureChangeRate? MegapascalsPerSecond(this int? value) => PressureChangeRate.FromMegapascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromMegapascalsPerSecond(double)"/>
        public static PressureChangeRate MegapascalsPerSecond(this long value) => PressureChangeRate.FromMegapascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromMegapascalsPerSecond(double?)"/>
        public static PressureChangeRate? MegapascalsPerSecond(this long? value) => PressureChangeRate.FromMegapascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromMegapascalsPerSecond(double)"/>
        public static PressureChangeRate MegapascalsPerSecond(this double value) => PressureChangeRate.FromMegapascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromMegapascalsPerSecond(double?)"/>
        public static PressureChangeRate? MegapascalsPerSecond(this double? value) => PressureChangeRate.FromMegapascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromMegapascalsPerSecond(double)"/>
        public static PressureChangeRate MegapascalsPerSecond(this float value) => PressureChangeRate.FromMegapascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromMegapascalsPerSecond(double?)"/>
        public static PressureChangeRate? MegapascalsPerSecond(this float? value) => PressureChangeRate.FromMegapascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromMegapascalsPerSecond(double)"/>
        public static PressureChangeRate MegapascalsPerSecond(this decimal value) => PressureChangeRate.FromMegapascalsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="PressureChangeRate.FromMegapascalsPerSecond(double?)"/>
        public static PressureChangeRate? MegapascalsPerSecond(this decimal? value) => PressureChangeRate.FromMegapascalsPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PascalPerSecond

        /// <inheritdoc cref="PressureChangeRate.FromPascalsPerSecond(double)"/>
        public static PressureChangeRate PascalsPerSecond(this int value) => PressureChangeRate.FromPascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromPascalsPerSecond(double?)"/>
        public static PressureChangeRate? PascalsPerSecond(this int? value) => PressureChangeRate.FromPascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromPascalsPerSecond(double)"/>
        public static PressureChangeRate PascalsPerSecond(this long value) => PressureChangeRate.FromPascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromPascalsPerSecond(double?)"/>
        public static PressureChangeRate? PascalsPerSecond(this long? value) => PressureChangeRate.FromPascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromPascalsPerSecond(double)"/>
        public static PressureChangeRate PascalsPerSecond(this double value) => PressureChangeRate.FromPascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromPascalsPerSecond(double?)"/>
        public static PressureChangeRate? PascalsPerSecond(this double? value) => PressureChangeRate.FromPascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromPascalsPerSecond(double)"/>
        public static PressureChangeRate PascalsPerSecond(this float value) => PressureChangeRate.FromPascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromPascalsPerSecond(double?)"/>
        public static PressureChangeRate? PascalsPerSecond(this float? value) => PressureChangeRate.FromPascalsPerSecond(value);

        /// <inheritdoc cref="PressureChangeRate.FromPascalsPerSecond(double)"/>
        public static PressureChangeRate PascalsPerSecond(this decimal value) => PressureChangeRate.FromPascalsPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="PressureChangeRate.FromPascalsPerSecond(double?)"/>
        public static PressureChangeRate? PascalsPerSecond(this decimal? value) => PressureChangeRate.FromPascalsPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
