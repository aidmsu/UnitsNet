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
        #region Dyn

        /// <inheritdoc cref="Force.FromDyne(double)"/>
        public static Force Dyne(this int value) => Force.FromDyne(value);

        /// <inheritdoc cref="Force.FromDyne(double?)"/>
        public static Force? Dyne(this int? value) => Force.FromDyne(value);

        /// <inheritdoc cref="Force.FromDyne(double)"/>
        public static Force Dyne(this long value) => Force.FromDyne(value);

        /// <inheritdoc cref="Force.FromDyne(double?)"/>
        public static Force? Dyne(this long? value) => Force.FromDyne(value);

        /// <inheritdoc cref="Force.FromDyne(double)"/>
        public static Force Dyne(this double value) => Force.FromDyne(value);

        /// <inheritdoc cref="Force.FromDyne(double?)"/>
        public static Force? Dyne(this double? value) => Force.FromDyne(value);

        /// <inheritdoc cref="Force.FromDyne(double)"/>
        public static Force Dyne(this float value) => Force.FromDyne(value);

        /// <inheritdoc cref="Force.FromDyne(double?)"/>
        public static Force? Dyne(this float? value) => Force.FromDyne(value);

        /// <inheritdoc cref="Force.FromDyne(double)"/>
        public static Force Dyne(this decimal value) => Force.FromDyne(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromDyne(double?)"/>
        public static Force? Dyne(this decimal? value) => Force.FromDyne(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramForce

        /// <inheritdoc cref="Force.FromKilogramsForce(double)"/>
        public static Force KilogramsForce(this int value) => Force.FromKilogramsForce(value);

        /// <inheritdoc cref="Force.FromKilogramsForce(double?)"/>
        public static Force? KilogramsForce(this int? value) => Force.FromKilogramsForce(value);

        /// <inheritdoc cref="Force.FromKilogramsForce(double)"/>
        public static Force KilogramsForce(this long value) => Force.FromKilogramsForce(value);

        /// <inheritdoc cref="Force.FromKilogramsForce(double?)"/>
        public static Force? KilogramsForce(this long? value) => Force.FromKilogramsForce(value);

        /// <inheritdoc cref="Force.FromKilogramsForce(double)"/>
        public static Force KilogramsForce(this double value) => Force.FromKilogramsForce(value);

        /// <inheritdoc cref="Force.FromKilogramsForce(double?)"/>
        public static Force? KilogramsForce(this double? value) => Force.FromKilogramsForce(value);

        /// <inheritdoc cref="Force.FromKilogramsForce(double)"/>
        public static Force KilogramsForce(this float value) => Force.FromKilogramsForce(value);

        /// <inheritdoc cref="Force.FromKilogramsForce(double?)"/>
        public static Force? KilogramsForce(this float? value) => Force.FromKilogramsForce(value);

        /// <inheritdoc cref="Force.FromKilogramsForce(double)"/>
        public static Force KilogramsForce(this decimal value) => Force.FromKilogramsForce(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromKilogramsForce(double?)"/>
        public static Force? KilogramsForce(this decimal? value) => Force.FromKilogramsForce(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kilonewton

        /// <inheritdoc cref="Force.FromKilonewtons(double)"/>
        public static Force Kilonewtons(this int value) => Force.FromKilonewtons(value);

        /// <inheritdoc cref="Force.FromKilonewtons(double?)"/>
        public static Force? Kilonewtons(this int? value) => Force.FromKilonewtons(value);

        /// <inheritdoc cref="Force.FromKilonewtons(double)"/>
        public static Force Kilonewtons(this long value) => Force.FromKilonewtons(value);

        /// <inheritdoc cref="Force.FromKilonewtons(double?)"/>
        public static Force? Kilonewtons(this long? value) => Force.FromKilonewtons(value);

        /// <inheritdoc cref="Force.FromKilonewtons(double)"/>
        public static Force Kilonewtons(this double value) => Force.FromKilonewtons(value);

        /// <inheritdoc cref="Force.FromKilonewtons(double?)"/>
        public static Force? Kilonewtons(this double? value) => Force.FromKilonewtons(value);

        /// <inheritdoc cref="Force.FromKilonewtons(double)"/>
        public static Force Kilonewtons(this float value) => Force.FromKilonewtons(value);

        /// <inheritdoc cref="Force.FromKilonewtons(double?)"/>
        public static Force? Kilonewtons(this float? value) => Force.FromKilonewtons(value);

        /// <inheritdoc cref="Force.FromKilonewtons(double)"/>
        public static Force Kilonewtons(this decimal value) => Force.FromKilonewtons(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromKilonewtons(double?)"/>
        public static Force? Kilonewtons(this decimal? value) => Force.FromKilonewtons(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KiloPond

        /// <inheritdoc cref="Force.FromKiloPonds(double)"/>
        public static Force KiloPonds(this int value) => Force.FromKiloPonds(value);

        /// <inheritdoc cref="Force.FromKiloPonds(double?)"/>
        public static Force? KiloPonds(this int? value) => Force.FromKiloPonds(value);

        /// <inheritdoc cref="Force.FromKiloPonds(double)"/>
        public static Force KiloPonds(this long value) => Force.FromKiloPonds(value);

        /// <inheritdoc cref="Force.FromKiloPonds(double?)"/>
        public static Force? KiloPonds(this long? value) => Force.FromKiloPonds(value);

        /// <inheritdoc cref="Force.FromKiloPonds(double)"/>
        public static Force KiloPonds(this double value) => Force.FromKiloPonds(value);

        /// <inheritdoc cref="Force.FromKiloPonds(double?)"/>
        public static Force? KiloPonds(this double? value) => Force.FromKiloPonds(value);

        /// <inheritdoc cref="Force.FromKiloPonds(double)"/>
        public static Force KiloPonds(this float value) => Force.FromKiloPonds(value);

        /// <inheritdoc cref="Force.FromKiloPonds(double?)"/>
        public static Force? KiloPonds(this float? value) => Force.FromKiloPonds(value);

        /// <inheritdoc cref="Force.FromKiloPonds(double)"/>
        public static Force KiloPonds(this decimal value) => Force.FromKiloPonds(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromKiloPonds(double?)"/>
        public static Force? KiloPonds(this decimal? value) => Force.FromKiloPonds(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Newton

        /// <inheritdoc cref="Force.FromNewtons(double)"/>
        public static Force Newtons(this int value) => Force.FromNewtons(value);

        /// <inheritdoc cref="Force.FromNewtons(double?)"/>
        public static Force? Newtons(this int? value) => Force.FromNewtons(value);

        /// <inheritdoc cref="Force.FromNewtons(double)"/>
        public static Force Newtons(this long value) => Force.FromNewtons(value);

        /// <inheritdoc cref="Force.FromNewtons(double?)"/>
        public static Force? Newtons(this long? value) => Force.FromNewtons(value);

        /// <inheritdoc cref="Force.FromNewtons(double)"/>
        public static Force Newtons(this double value) => Force.FromNewtons(value);

        /// <inheritdoc cref="Force.FromNewtons(double?)"/>
        public static Force? Newtons(this double? value) => Force.FromNewtons(value);

        /// <inheritdoc cref="Force.FromNewtons(double)"/>
        public static Force Newtons(this float value) => Force.FromNewtons(value);

        /// <inheritdoc cref="Force.FromNewtons(double?)"/>
        public static Force? Newtons(this float? value) => Force.FromNewtons(value);

        /// <inheritdoc cref="Force.FromNewtons(double)"/>
        public static Force Newtons(this decimal value) => Force.FromNewtons(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromNewtons(double?)"/>
        public static Force? Newtons(this decimal? value) => Force.FromNewtons(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Poundal

        /// <inheritdoc cref="Force.FromPoundals(double)"/>
        public static Force Poundals(this int value) => Force.FromPoundals(value);

        /// <inheritdoc cref="Force.FromPoundals(double?)"/>
        public static Force? Poundals(this int? value) => Force.FromPoundals(value);

        /// <inheritdoc cref="Force.FromPoundals(double)"/>
        public static Force Poundals(this long value) => Force.FromPoundals(value);

        /// <inheritdoc cref="Force.FromPoundals(double?)"/>
        public static Force? Poundals(this long? value) => Force.FromPoundals(value);

        /// <inheritdoc cref="Force.FromPoundals(double)"/>
        public static Force Poundals(this double value) => Force.FromPoundals(value);

        /// <inheritdoc cref="Force.FromPoundals(double?)"/>
        public static Force? Poundals(this double? value) => Force.FromPoundals(value);

        /// <inheritdoc cref="Force.FromPoundals(double)"/>
        public static Force Poundals(this float value) => Force.FromPoundals(value);

        /// <inheritdoc cref="Force.FromPoundals(double?)"/>
        public static Force? Poundals(this float? value) => Force.FromPoundals(value);

        /// <inheritdoc cref="Force.FromPoundals(double)"/>
        public static Force Poundals(this decimal value) => Force.FromPoundals(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromPoundals(double?)"/>
        public static Force? Poundals(this decimal? value) => Force.FromPoundals(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundForce

        /// <inheritdoc cref="Force.FromPoundsForce(double)"/>
        public static Force PoundsForce(this int value) => Force.FromPoundsForce(value);

        /// <inheritdoc cref="Force.FromPoundsForce(double?)"/>
        public static Force? PoundsForce(this int? value) => Force.FromPoundsForce(value);

        /// <inheritdoc cref="Force.FromPoundsForce(double)"/>
        public static Force PoundsForce(this long value) => Force.FromPoundsForce(value);

        /// <inheritdoc cref="Force.FromPoundsForce(double?)"/>
        public static Force? PoundsForce(this long? value) => Force.FromPoundsForce(value);

        /// <inheritdoc cref="Force.FromPoundsForce(double)"/>
        public static Force PoundsForce(this double value) => Force.FromPoundsForce(value);

        /// <inheritdoc cref="Force.FromPoundsForce(double?)"/>
        public static Force? PoundsForce(this double? value) => Force.FromPoundsForce(value);

        /// <inheritdoc cref="Force.FromPoundsForce(double)"/>
        public static Force PoundsForce(this float value) => Force.FromPoundsForce(value);

        /// <inheritdoc cref="Force.FromPoundsForce(double?)"/>
        public static Force? PoundsForce(this float? value) => Force.FromPoundsForce(value);

        /// <inheritdoc cref="Force.FromPoundsForce(double)"/>
        public static Force PoundsForce(this decimal value) => Force.FromPoundsForce(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromPoundsForce(double?)"/>
        public static Force? PoundsForce(this decimal? value) => Force.FromPoundsForce(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TonneForce

        /// <inheritdoc cref="Force.FromTonnesForce(double)"/>
        public static Force TonnesForce(this int value) => Force.FromTonnesForce(value);

        /// <inheritdoc cref="Force.FromTonnesForce(double?)"/>
        public static Force? TonnesForce(this int? value) => Force.FromTonnesForce(value);

        /// <inheritdoc cref="Force.FromTonnesForce(double)"/>
        public static Force TonnesForce(this long value) => Force.FromTonnesForce(value);

        /// <inheritdoc cref="Force.FromTonnesForce(double?)"/>
        public static Force? TonnesForce(this long? value) => Force.FromTonnesForce(value);

        /// <inheritdoc cref="Force.FromTonnesForce(double)"/>
        public static Force TonnesForce(this double value) => Force.FromTonnesForce(value);

        /// <inheritdoc cref="Force.FromTonnesForce(double?)"/>
        public static Force? TonnesForce(this double? value) => Force.FromTonnesForce(value);

        /// <inheritdoc cref="Force.FromTonnesForce(double)"/>
        public static Force TonnesForce(this float value) => Force.FromTonnesForce(value);

        /// <inheritdoc cref="Force.FromTonnesForce(double?)"/>
        public static Force? TonnesForce(this float? value) => Force.FromTonnesForce(value);

        /// <inheritdoc cref="Force.FromTonnesForce(double)"/>
        public static Force TonnesForce(this decimal value) => Force.FromTonnesForce(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromTonnesForce(double?)"/>
        public static Force? TonnesForce(this decimal? value) => Force.FromTonnesForce(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
