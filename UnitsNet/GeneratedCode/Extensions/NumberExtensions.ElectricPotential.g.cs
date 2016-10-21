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
        #region Kilovolt

        /// <inheritdoc cref="ElectricPotential.FromKilovolts(double)"/>
        public static ElectricPotential Kilovolts(this int value) => ElectricPotential.FromKilovolts(value);

        /// <inheritdoc cref="ElectricPotential.FromKilovolts(double?)"/>
        public static ElectricPotential? Kilovolts(this int? value) => ElectricPotential.FromKilovolts(value);

        /// <inheritdoc cref="ElectricPotential.FromKilovolts(double)"/>
        public static ElectricPotential Kilovolts(this long value) => ElectricPotential.FromKilovolts(value);

        /// <inheritdoc cref="ElectricPotential.FromKilovolts(double?)"/>
        public static ElectricPotential? Kilovolts(this long? value) => ElectricPotential.FromKilovolts(value);

        /// <inheritdoc cref="ElectricPotential.FromKilovolts(double)"/>
        public static ElectricPotential Kilovolts(this double value) => ElectricPotential.FromKilovolts(value);

        /// <inheritdoc cref="ElectricPotential.FromKilovolts(double?)"/>
        public static ElectricPotential? Kilovolts(this double? value) => ElectricPotential.FromKilovolts(value);

        /// <inheritdoc cref="ElectricPotential.FromKilovolts(double)"/>
        public static ElectricPotential Kilovolts(this float value) => ElectricPotential.FromKilovolts(value);

        /// <inheritdoc cref="ElectricPotential.FromKilovolts(double?)"/>
        public static ElectricPotential? Kilovolts(this float? value) => ElectricPotential.FromKilovolts(value);

        /// <inheritdoc cref="ElectricPotential.FromKilovolts(double)"/>
        public static ElectricPotential Kilovolts(this decimal value) => ElectricPotential.FromKilovolts(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotential.FromKilovolts(double?)"/>
        public static ElectricPotential? Kilovolts(this decimal? value) => ElectricPotential.FromKilovolts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Megavolt

        /// <inheritdoc cref="ElectricPotential.FromMegavolts(double)"/>
        public static ElectricPotential Megavolts(this int value) => ElectricPotential.FromMegavolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMegavolts(double?)"/>
        public static ElectricPotential? Megavolts(this int? value) => ElectricPotential.FromMegavolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMegavolts(double)"/>
        public static ElectricPotential Megavolts(this long value) => ElectricPotential.FromMegavolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMegavolts(double?)"/>
        public static ElectricPotential? Megavolts(this long? value) => ElectricPotential.FromMegavolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMegavolts(double)"/>
        public static ElectricPotential Megavolts(this double value) => ElectricPotential.FromMegavolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMegavolts(double?)"/>
        public static ElectricPotential? Megavolts(this double? value) => ElectricPotential.FromMegavolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMegavolts(double)"/>
        public static ElectricPotential Megavolts(this float value) => ElectricPotential.FromMegavolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMegavolts(double?)"/>
        public static ElectricPotential? Megavolts(this float? value) => ElectricPotential.FromMegavolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMegavolts(double)"/>
        public static ElectricPotential Megavolts(this decimal value) => ElectricPotential.FromMegavolts(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotential.FromMegavolts(double?)"/>
        public static ElectricPotential? Megavolts(this decimal? value) => ElectricPotential.FromMegavolts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Microvolt

        /// <inheritdoc cref="ElectricPotential.FromMicrovolts(double)"/>
        public static ElectricPotential Microvolts(this int value) => ElectricPotential.FromMicrovolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMicrovolts(double?)"/>
        public static ElectricPotential? Microvolts(this int? value) => ElectricPotential.FromMicrovolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMicrovolts(double)"/>
        public static ElectricPotential Microvolts(this long value) => ElectricPotential.FromMicrovolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMicrovolts(double?)"/>
        public static ElectricPotential? Microvolts(this long? value) => ElectricPotential.FromMicrovolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMicrovolts(double)"/>
        public static ElectricPotential Microvolts(this double value) => ElectricPotential.FromMicrovolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMicrovolts(double?)"/>
        public static ElectricPotential? Microvolts(this double? value) => ElectricPotential.FromMicrovolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMicrovolts(double)"/>
        public static ElectricPotential Microvolts(this float value) => ElectricPotential.FromMicrovolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMicrovolts(double?)"/>
        public static ElectricPotential? Microvolts(this float? value) => ElectricPotential.FromMicrovolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMicrovolts(double)"/>
        public static ElectricPotential Microvolts(this decimal value) => ElectricPotential.FromMicrovolts(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotential.FromMicrovolts(double?)"/>
        public static ElectricPotential? Microvolts(this decimal? value) => ElectricPotential.FromMicrovolts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Millivolt

        /// <inheritdoc cref="ElectricPotential.FromMillivolts(double)"/>
        public static ElectricPotential Millivolts(this int value) => ElectricPotential.FromMillivolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMillivolts(double?)"/>
        public static ElectricPotential? Millivolts(this int? value) => ElectricPotential.FromMillivolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMillivolts(double)"/>
        public static ElectricPotential Millivolts(this long value) => ElectricPotential.FromMillivolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMillivolts(double?)"/>
        public static ElectricPotential? Millivolts(this long? value) => ElectricPotential.FromMillivolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMillivolts(double)"/>
        public static ElectricPotential Millivolts(this double value) => ElectricPotential.FromMillivolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMillivolts(double?)"/>
        public static ElectricPotential? Millivolts(this double? value) => ElectricPotential.FromMillivolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMillivolts(double)"/>
        public static ElectricPotential Millivolts(this float value) => ElectricPotential.FromMillivolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMillivolts(double?)"/>
        public static ElectricPotential? Millivolts(this float? value) => ElectricPotential.FromMillivolts(value);

        /// <inheritdoc cref="ElectricPotential.FromMillivolts(double)"/>
        public static ElectricPotential Millivolts(this decimal value) => ElectricPotential.FromMillivolts(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotential.FromMillivolts(double?)"/>
        public static ElectricPotential? Millivolts(this decimal? value) => ElectricPotential.FromMillivolts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Volt

        /// <inheritdoc cref="ElectricPotential.FromVolts(double)"/>
        public static ElectricPotential Volts(this int value) => ElectricPotential.FromVolts(value);

        /// <inheritdoc cref="ElectricPotential.FromVolts(double?)"/>
        public static ElectricPotential? Volts(this int? value) => ElectricPotential.FromVolts(value);

        /// <inheritdoc cref="ElectricPotential.FromVolts(double)"/>
        public static ElectricPotential Volts(this long value) => ElectricPotential.FromVolts(value);

        /// <inheritdoc cref="ElectricPotential.FromVolts(double?)"/>
        public static ElectricPotential? Volts(this long? value) => ElectricPotential.FromVolts(value);

        /// <inheritdoc cref="ElectricPotential.FromVolts(double)"/>
        public static ElectricPotential Volts(this double value) => ElectricPotential.FromVolts(value);

        /// <inheritdoc cref="ElectricPotential.FromVolts(double?)"/>
        public static ElectricPotential? Volts(this double? value) => ElectricPotential.FromVolts(value);

        /// <inheritdoc cref="ElectricPotential.FromVolts(double)"/>
        public static ElectricPotential Volts(this float value) => ElectricPotential.FromVolts(value);

        /// <inheritdoc cref="ElectricPotential.FromVolts(double?)"/>
        public static ElectricPotential? Volts(this float? value) => ElectricPotential.FromVolts(value);

        /// <inheritdoc cref="ElectricPotential.FromVolts(double)"/>
        public static ElectricPotential Volts(this decimal value) => ElectricPotential.FromVolts(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotential.FromVolts(double?)"/>
        public static ElectricPotential? Volts(this decimal? value) => ElectricPotential.FromVolts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
