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
        #region CentidegreeCelsiusPerSecond

        /// <inheritdoc cref="TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate CentidegreesCelsiusPerSecond(this int value) => TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? CentidegreesCelsiusPerSecond(this int? value) => TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate CentidegreesCelsiusPerSecond(this long value) => TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? CentidegreesCelsiusPerSecond(this long? value) => TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate CentidegreesCelsiusPerSecond(this double value) => TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? CentidegreesCelsiusPerSecond(this double? value) => TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate CentidegreesCelsiusPerSecond(this float value) => TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? CentidegreesCelsiusPerSecond(this float? value) => TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate CentidegreesCelsiusPerSecond(this decimal value) => TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? CentidegreesCelsiusPerSecond(this decimal? value) => TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecadegreeCelsiusPerSecond

        /// <inheritdoc cref="TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate DecadegreesCelsiusPerSecond(this int value) => TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? DecadegreesCelsiusPerSecond(this int? value) => TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate DecadegreesCelsiusPerSecond(this long value) => TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? DecadegreesCelsiusPerSecond(this long? value) => TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate DecadegreesCelsiusPerSecond(this double value) => TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? DecadegreesCelsiusPerSecond(this double? value) => TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate DecadegreesCelsiusPerSecond(this float value) => TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? DecadegreesCelsiusPerSecond(this float? value) => TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate DecadegreesCelsiusPerSecond(this decimal value) => TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? DecadegreesCelsiusPerSecond(this decimal? value) => TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecidegreeCelsiusPerSecond

        /// <inheritdoc cref="TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate DecidegreesCelsiusPerSecond(this int value) => TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? DecidegreesCelsiusPerSecond(this int? value) => TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate DecidegreesCelsiusPerSecond(this long value) => TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? DecidegreesCelsiusPerSecond(this long? value) => TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate DecidegreesCelsiusPerSecond(this double value) => TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? DecidegreesCelsiusPerSecond(this double? value) => TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate DecidegreesCelsiusPerSecond(this float value) => TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? DecidegreesCelsiusPerSecond(this float? value) => TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate DecidegreesCelsiusPerSecond(this decimal value) => TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? DecidegreesCelsiusPerSecond(this decimal? value) => TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DegreeCelsiusPerSecond

        /// <inheritdoc cref="TemperatureChangeRate.FromDegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate DegreesCelsiusPerSecond(this int value) => TemperatureChangeRate.FromDegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? DegreesCelsiusPerSecond(this int? value) => TemperatureChangeRate.FromDegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate DegreesCelsiusPerSecond(this long value) => TemperatureChangeRate.FromDegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? DegreesCelsiusPerSecond(this long? value) => TemperatureChangeRate.FromDegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate DegreesCelsiusPerSecond(this double value) => TemperatureChangeRate.FromDegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? DegreesCelsiusPerSecond(this double? value) => TemperatureChangeRate.FromDegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate DegreesCelsiusPerSecond(this float value) => TemperatureChangeRate.FromDegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? DegreesCelsiusPerSecond(this float? value) => TemperatureChangeRate.FromDegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromDegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate DegreesCelsiusPerSecond(this decimal value) => TemperatureChangeRate.FromDegreesCelsiusPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureChangeRate.FromDegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? DegreesCelsiusPerSecond(this decimal? value) => TemperatureChangeRate.FromDegreesCelsiusPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region HectodegreeCelsiusPerSecond

        /// <inheritdoc cref="TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate HectodegreesCelsiusPerSecond(this int value) => TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? HectodegreesCelsiusPerSecond(this int? value) => TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate HectodegreesCelsiusPerSecond(this long value) => TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? HectodegreesCelsiusPerSecond(this long? value) => TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate HectodegreesCelsiusPerSecond(this double value) => TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? HectodegreesCelsiusPerSecond(this double? value) => TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate HectodegreesCelsiusPerSecond(this float value) => TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? HectodegreesCelsiusPerSecond(this float? value) => TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate HectodegreesCelsiusPerSecond(this decimal value) => TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? HectodegreesCelsiusPerSecond(this decimal? value) => TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilodegreeCelsiusPerSecond

        /// <inheritdoc cref="TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate KilodegreesCelsiusPerSecond(this int value) => TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? KilodegreesCelsiusPerSecond(this int? value) => TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate KilodegreesCelsiusPerSecond(this long value) => TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? KilodegreesCelsiusPerSecond(this long? value) => TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate KilodegreesCelsiusPerSecond(this double value) => TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? KilodegreesCelsiusPerSecond(this double? value) => TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate KilodegreesCelsiusPerSecond(this float value) => TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? KilodegreesCelsiusPerSecond(this float? value) => TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate KilodegreesCelsiusPerSecond(this decimal value) => TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? KilodegreesCelsiusPerSecond(this decimal? value) => TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicrodegreeCelsiusPerSecond

        /// <inheritdoc cref="TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate MicrodegreesCelsiusPerSecond(this int value) => TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? MicrodegreesCelsiusPerSecond(this int? value) => TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate MicrodegreesCelsiusPerSecond(this long value) => TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? MicrodegreesCelsiusPerSecond(this long? value) => TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate MicrodegreesCelsiusPerSecond(this double value) => TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? MicrodegreesCelsiusPerSecond(this double? value) => TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate MicrodegreesCelsiusPerSecond(this float value) => TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? MicrodegreesCelsiusPerSecond(this float? value) => TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate MicrodegreesCelsiusPerSecond(this decimal value) => TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? MicrodegreesCelsiusPerSecond(this decimal? value) => TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillidegreeCelsiusPerSecond

        /// <inheritdoc cref="TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate MillidegreesCelsiusPerSecond(this int value) => TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? MillidegreesCelsiusPerSecond(this int? value) => TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate MillidegreesCelsiusPerSecond(this long value) => TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? MillidegreesCelsiusPerSecond(this long? value) => TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate MillidegreesCelsiusPerSecond(this double value) => TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? MillidegreesCelsiusPerSecond(this double? value) => TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate MillidegreesCelsiusPerSecond(this float value) => TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? MillidegreesCelsiusPerSecond(this float? value) => TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate MillidegreesCelsiusPerSecond(this decimal value) => TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? MillidegreesCelsiusPerSecond(this decimal? value) => TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NanodegreeCelsiusPerSecond

        /// <inheritdoc cref="TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate NanodegreesCelsiusPerSecond(this int value) => TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? NanodegreesCelsiusPerSecond(this int? value) => TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate NanodegreesCelsiusPerSecond(this long value) => TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? NanodegreesCelsiusPerSecond(this long? value) => TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate NanodegreesCelsiusPerSecond(this double value) => TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? NanodegreesCelsiusPerSecond(this double? value) => TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate NanodegreesCelsiusPerSecond(this float value) => TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? NanodegreesCelsiusPerSecond(this float? value) => TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(value);

        /// <inheritdoc cref="TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(double)"/>
        public static TemperatureChangeRate NanodegreesCelsiusPerSecond(this decimal value) => TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(double?)"/>
        public static TemperatureChangeRate? NanodegreesCelsiusPerSecond(this decimal? value) => TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
