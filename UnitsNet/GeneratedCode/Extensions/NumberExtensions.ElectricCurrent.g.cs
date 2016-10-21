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
        #region Ampere

        /// <inheritdoc cref="ElectricCurrent.FromAmperes(double)"/>
        public static ElectricCurrent Amperes(this int value) => ElectricCurrent.FromAmperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromAmperes(double?)"/>
        public static ElectricCurrent? Amperes(this int? value) => ElectricCurrent.FromAmperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromAmperes(double)"/>
        public static ElectricCurrent Amperes(this long value) => ElectricCurrent.FromAmperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromAmperes(double?)"/>
        public static ElectricCurrent? Amperes(this long? value) => ElectricCurrent.FromAmperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromAmperes(double)"/>
        public static ElectricCurrent Amperes(this double value) => ElectricCurrent.FromAmperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromAmperes(double?)"/>
        public static ElectricCurrent? Amperes(this double? value) => ElectricCurrent.FromAmperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromAmperes(double)"/>
        public static ElectricCurrent Amperes(this float value) => ElectricCurrent.FromAmperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromAmperes(double?)"/>
        public static ElectricCurrent? Amperes(this float? value) => ElectricCurrent.FromAmperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromAmperes(double)"/>
        public static ElectricCurrent Amperes(this decimal value) => ElectricCurrent.FromAmperes(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCurrent.FromAmperes(double?)"/>
        public static ElectricCurrent? Amperes(this decimal? value) => ElectricCurrent.FromAmperes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kiloampere

        /// <inheritdoc cref="ElectricCurrent.FromKiloamperes(double)"/>
        public static ElectricCurrent Kiloamperes(this int value) => ElectricCurrent.FromKiloamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromKiloamperes(double?)"/>
        public static ElectricCurrent? Kiloamperes(this int? value) => ElectricCurrent.FromKiloamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromKiloamperes(double)"/>
        public static ElectricCurrent Kiloamperes(this long value) => ElectricCurrent.FromKiloamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromKiloamperes(double?)"/>
        public static ElectricCurrent? Kiloamperes(this long? value) => ElectricCurrent.FromKiloamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromKiloamperes(double)"/>
        public static ElectricCurrent Kiloamperes(this double value) => ElectricCurrent.FromKiloamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromKiloamperes(double?)"/>
        public static ElectricCurrent? Kiloamperes(this double? value) => ElectricCurrent.FromKiloamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromKiloamperes(double)"/>
        public static ElectricCurrent Kiloamperes(this float value) => ElectricCurrent.FromKiloamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromKiloamperes(double?)"/>
        public static ElectricCurrent? Kiloamperes(this float? value) => ElectricCurrent.FromKiloamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromKiloamperes(double)"/>
        public static ElectricCurrent Kiloamperes(this decimal value) => ElectricCurrent.FromKiloamperes(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCurrent.FromKiloamperes(double?)"/>
        public static ElectricCurrent? Kiloamperes(this decimal? value) => ElectricCurrent.FromKiloamperes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Megaampere

        /// <inheritdoc cref="ElectricCurrent.FromMegaamperes(double)"/>
        public static ElectricCurrent Megaamperes(this int value) => ElectricCurrent.FromMegaamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMegaamperes(double?)"/>
        public static ElectricCurrent? Megaamperes(this int? value) => ElectricCurrent.FromMegaamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMegaamperes(double)"/>
        public static ElectricCurrent Megaamperes(this long value) => ElectricCurrent.FromMegaamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMegaamperes(double?)"/>
        public static ElectricCurrent? Megaamperes(this long? value) => ElectricCurrent.FromMegaamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMegaamperes(double)"/>
        public static ElectricCurrent Megaamperes(this double value) => ElectricCurrent.FromMegaamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMegaamperes(double?)"/>
        public static ElectricCurrent? Megaamperes(this double? value) => ElectricCurrent.FromMegaamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMegaamperes(double)"/>
        public static ElectricCurrent Megaamperes(this float value) => ElectricCurrent.FromMegaamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMegaamperes(double?)"/>
        public static ElectricCurrent? Megaamperes(this float? value) => ElectricCurrent.FromMegaamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMegaamperes(double)"/>
        public static ElectricCurrent Megaamperes(this decimal value) => ElectricCurrent.FromMegaamperes(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCurrent.FromMegaamperes(double?)"/>
        public static ElectricCurrent? Megaamperes(this decimal? value) => ElectricCurrent.FromMegaamperes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Microampere

        /// <inheritdoc cref="ElectricCurrent.FromMicroamperes(double)"/>
        public static ElectricCurrent Microamperes(this int value) => ElectricCurrent.FromMicroamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMicroamperes(double?)"/>
        public static ElectricCurrent? Microamperes(this int? value) => ElectricCurrent.FromMicroamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMicroamperes(double)"/>
        public static ElectricCurrent Microamperes(this long value) => ElectricCurrent.FromMicroamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMicroamperes(double?)"/>
        public static ElectricCurrent? Microamperes(this long? value) => ElectricCurrent.FromMicroamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMicroamperes(double)"/>
        public static ElectricCurrent Microamperes(this double value) => ElectricCurrent.FromMicroamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMicroamperes(double?)"/>
        public static ElectricCurrent? Microamperes(this double? value) => ElectricCurrent.FromMicroamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMicroamperes(double)"/>
        public static ElectricCurrent Microamperes(this float value) => ElectricCurrent.FromMicroamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMicroamperes(double?)"/>
        public static ElectricCurrent? Microamperes(this float? value) => ElectricCurrent.FromMicroamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMicroamperes(double)"/>
        public static ElectricCurrent Microamperes(this decimal value) => ElectricCurrent.FromMicroamperes(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCurrent.FromMicroamperes(double?)"/>
        public static ElectricCurrent? Microamperes(this decimal? value) => ElectricCurrent.FromMicroamperes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Milliampere

        /// <inheritdoc cref="ElectricCurrent.FromMilliamperes(double)"/>
        public static ElectricCurrent Milliamperes(this int value) => ElectricCurrent.FromMilliamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMilliamperes(double?)"/>
        public static ElectricCurrent? Milliamperes(this int? value) => ElectricCurrent.FromMilliamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMilliamperes(double)"/>
        public static ElectricCurrent Milliamperes(this long value) => ElectricCurrent.FromMilliamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMilliamperes(double?)"/>
        public static ElectricCurrent? Milliamperes(this long? value) => ElectricCurrent.FromMilliamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMilliamperes(double)"/>
        public static ElectricCurrent Milliamperes(this double value) => ElectricCurrent.FromMilliamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMilliamperes(double?)"/>
        public static ElectricCurrent? Milliamperes(this double? value) => ElectricCurrent.FromMilliamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMilliamperes(double)"/>
        public static ElectricCurrent Milliamperes(this float value) => ElectricCurrent.FromMilliamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMilliamperes(double?)"/>
        public static ElectricCurrent? Milliamperes(this float? value) => ElectricCurrent.FromMilliamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromMilliamperes(double)"/>
        public static ElectricCurrent Milliamperes(this decimal value) => ElectricCurrent.FromMilliamperes(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCurrent.FromMilliamperes(double?)"/>
        public static ElectricCurrent? Milliamperes(this decimal? value) => ElectricCurrent.FromMilliamperes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Nanoampere

        /// <inheritdoc cref="ElectricCurrent.FromNanoamperes(double)"/>
        public static ElectricCurrent Nanoamperes(this int value) => ElectricCurrent.FromNanoamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromNanoamperes(double?)"/>
        public static ElectricCurrent? Nanoamperes(this int? value) => ElectricCurrent.FromNanoamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromNanoamperes(double)"/>
        public static ElectricCurrent Nanoamperes(this long value) => ElectricCurrent.FromNanoamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromNanoamperes(double?)"/>
        public static ElectricCurrent? Nanoamperes(this long? value) => ElectricCurrent.FromNanoamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromNanoamperes(double)"/>
        public static ElectricCurrent Nanoamperes(this double value) => ElectricCurrent.FromNanoamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromNanoamperes(double?)"/>
        public static ElectricCurrent? Nanoamperes(this double? value) => ElectricCurrent.FromNanoamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromNanoamperes(double)"/>
        public static ElectricCurrent Nanoamperes(this float value) => ElectricCurrent.FromNanoamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromNanoamperes(double?)"/>
        public static ElectricCurrent? Nanoamperes(this float? value) => ElectricCurrent.FromNanoamperes(value);

        /// <inheritdoc cref="ElectricCurrent.FromNanoamperes(double)"/>
        public static ElectricCurrent Nanoamperes(this decimal value) => ElectricCurrent.FromNanoamperes(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricCurrent.FromNanoamperes(double?)"/>
        public static ElectricCurrent? Nanoamperes(this decimal? value) => ElectricCurrent.FromNanoamperes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
