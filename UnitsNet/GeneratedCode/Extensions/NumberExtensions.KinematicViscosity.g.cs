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
        #region Centistokes

        /// <inheritdoc cref="KinematicViscosity.FromCentistokes(double)"/>
        public static KinematicViscosity Centistokes(this int value) => KinematicViscosity.FromCentistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromCentistokes(double?)"/>
        public static KinematicViscosity? Centistokes(this int? value) => KinematicViscosity.FromCentistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromCentistokes(double)"/>
        public static KinematicViscosity Centistokes(this long value) => KinematicViscosity.FromCentistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromCentistokes(double?)"/>
        public static KinematicViscosity? Centistokes(this long? value) => KinematicViscosity.FromCentistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromCentistokes(double)"/>
        public static KinematicViscosity Centistokes(this double value) => KinematicViscosity.FromCentistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromCentistokes(double?)"/>
        public static KinematicViscosity? Centistokes(this double? value) => KinematicViscosity.FromCentistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromCentistokes(double)"/>
        public static KinematicViscosity Centistokes(this float value) => KinematicViscosity.FromCentistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromCentistokes(double?)"/>
        public static KinematicViscosity? Centistokes(this float? value) => KinematicViscosity.FromCentistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromCentistokes(double)"/>
        public static KinematicViscosity Centistokes(this decimal value) => KinematicViscosity.FromCentistokes(Convert.ToDouble(value));

        /// <inheritdoc cref="KinematicViscosity.FromCentistokes(double?)"/>
        public static KinematicViscosity? Centistokes(this decimal? value) => KinematicViscosity.FromCentistokes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Decistokes

        /// <inheritdoc cref="KinematicViscosity.FromDecistokes(double)"/>
        public static KinematicViscosity Decistokes(this int value) => KinematicViscosity.FromDecistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromDecistokes(double?)"/>
        public static KinematicViscosity? Decistokes(this int? value) => KinematicViscosity.FromDecistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromDecistokes(double)"/>
        public static KinematicViscosity Decistokes(this long value) => KinematicViscosity.FromDecistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromDecistokes(double?)"/>
        public static KinematicViscosity? Decistokes(this long? value) => KinematicViscosity.FromDecistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromDecistokes(double)"/>
        public static KinematicViscosity Decistokes(this double value) => KinematicViscosity.FromDecistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromDecistokes(double?)"/>
        public static KinematicViscosity? Decistokes(this double? value) => KinematicViscosity.FromDecistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromDecistokes(double)"/>
        public static KinematicViscosity Decistokes(this float value) => KinematicViscosity.FromDecistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromDecistokes(double?)"/>
        public static KinematicViscosity? Decistokes(this float? value) => KinematicViscosity.FromDecistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromDecistokes(double)"/>
        public static KinematicViscosity Decistokes(this decimal value) => KinematicViscosity.FromDecistokes(Convert.ToDouble(value));

        /// <inheritdoc cref="KinematicViscosity.FromDecistokes(double?)"/>
        public static KinematicViscosity? Decistokes(this decimal? value) => KinematicViscosity.FromDecistokes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kilostokes

        /// <inheritdoc cref="KinematicViscosity.FromKilostokes(double)"/>
        public static KinematicViscosity Kilostokes(this int value) => KinematicViscosity.FromKilostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromKilostokes(double?)"/>
        public static KinematicViscosity? Kilostokes(this int? value) => KinematicViscosity.FromKilostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromKilostokes(double)"/>
        public static KinematicViscosity Kilostokes(this long value) => KinematicViscosity.FromKilostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromKilostokes(double?)"/>
        public static KinematicViscosity? Kilostokes(this long? value) => KinematicViscosity.FromKilostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromKilostokes(double)"/>
        public static KinematicViscosity Kilostokes(this double value) => KinematicViscosity.FromKilostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromKilostokes(double?)"/>
        public static KinematicViscosity? Kilostokes(this double? value) => KinematicViscosity.FromKilostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromKilostokes(double)"/>
        public static KinematicViscosity Kilostokes(this float value) => KinematicViscosity.FromKilostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromKilostokes(double?)"/>
        public static KinematicViscosity? Kilostokes(this float? value) => KinematicViscosity.FromKilostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromKilostokes(double)"/>
        public static KinematicViscosity Kilostokes(this decimal value) => KinematicViscosity.FromKilostokes(Convert.ToDouble(value));

        /// <inheritdoc cref="KinematicViscosity.FromKilostokes(double?)"/>
        public static KinematicViscosity? Kilostokes(this decimal? value) => KinematicViscosity.FromKilostokes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Microstokes

        /// <inheritdoc cref="KinematicViscosity.FromMicrostokes(double)"/>
        public static KinematicViscosity Microstokes(this int value) => KinematicViscosity.FromMicrostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromMicrostokes(double?)"/>
        public static KinematicViscosity? Microstokes(this int? value) => KinematicViscosity.FromMicrostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromMicrostokes(double)"/>
        public static KinematicViscosity Microstokes(this long value) => KinematicViscosity.FromMicrostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromMicrostokes(double?)"/>
        public static KinematicViscosity? Microstokes(this long? value) => KinematicViscosity.FromMicrostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromMicrostokes(double)"/>
        public static KinematicViscosity Microstokes(this double value) => KinematicViscosity.FromMicrostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromMicrostokes(double?)"/>
        public static KinematicViscosity? Microstokes(this double? value) => KinematicViscosity.FromMicrostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromMicrostokes(double)"/>
        public static KinematicViscosity Microstokes(this float value) => KinematicViscosity.FromMicrostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromMicrostokes(double?)"/>
        public static KinematicViscosity? Microstokes(this float? value) => KinematicViscosity.FromMicrostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromMicrostokes(double)"/>
        public static KinematicViscosity Microstokes(this decimal value) => KinematicViscosity.FromMicrostokes(Convert.ToDouble(value));

        /// <inheritdoc cref="KinematicViscosity.FromMicrostokes(double?)"/>
        public static KinematicViscosity? Microstokes(this decimal? value) => KinematicViscosity.FromMicrostokes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Millistokes

        /// <inheritdoc cref="KinematicViscosity.FromMillistokes(double)"/>
        public static KinematicViscosity Millistokes(this int value) => KinematicViscosity.FromMillistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromMillistokes(double?)"/>
        public static KinematicViscosity? Millistokes(this int? value) => KinematicViscosity.FromMillistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromMillistokes(double)"/>
        public static KinematicViscosity Millistokes(this long value) => KinematicViscosity.FromMillistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromMillistokes(double?)"/>
        public static KinematicViscosity? Millistokes(this long? value) => KinematicViscosity.FromMillistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromMillistokes(double)"/>
        public static KinematicViscosity Millistokes(this double value) => KinematicViscosity.FromMillistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromMillistokes(double?)"/>
        public static KinematicViscosity? Millistokes(this double? value) => KinematicViscosity.FromMillistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromMillistokes(double)"/>
        public static KinematicViscosity Millistokes(this float value) => KinematicViscosity.FromMillistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromMillistokes(double?)"/>
        public static KinematicViscosity? Millistokes(this float? value) => KinematicViscosity.FromMillistokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromMillistokes(double)"/>
        public static KinematicViscosity Millistokes(this decimal value) => KinematicViscosity.FromMillistokes(Convert.ToDouble(value));

        /// <inheritdoc cref="KinematicViscosity.FromMillistokes(double?)"/>
        public static KinematicViscosity? Millistokes(this decimal? value) => KinematicViscosity.FromMillistokes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Nanostokes

        /// <inheritdoc cref="KinematicViscosity.FromNanostokes(double)"/>
        public static KinematicViscosity Nanostokes(this int value) => KinematicViscosity.FromNanostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromNanostokes(double?)"/>
        public static KinematicViscosity? Nanostokes(this int? value) => KinematicViscosity.FromNanostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromNanostokes(double)"/>
        public static KinematicViscosity Nanostokes(this long value) => KinematicViscosity.FromNanostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromNanostokes(double?)"/>
        public static KinematicViscosity? Nanostokes(this long? value) => KinematicViscosity.FromNanostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromNanostokes(double)"/>
        public static KinematicViscosity Nanostokes(this double value) => KinematicViscosity.FromNanostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromNanostokes(double?)"/>
        public static KinematicViscosity? Nanostokes(this double? value) => KinematicViscosity.FromNanostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromNanostokes(double)"/>
        public static KinematicViscosity Nanostokes(this float value) => KinematicViscosity.FromNanostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromNanostokes(double?)"/>
        public static KinematicViscosity? Nanostokes(this float? value) => KinematicViscosity.FromNanostokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromNanostokes(double)"/>
        public static KinematicViscosity Nanostokes(this decimal value) => KinematicViscosity.FromNanostokes(Convert.ToDouble(value));

        /// <inheritdoc cref="KinematicViscosity.FromNanostokes(double?)"/>
        public static KinematicViscosity? Nanostokes(this decimal? value) => KinematicViscosity.FromNanostokes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region SquareMeterPerSecond

        /// <inheritdoc cref="KinematicViscosity.FromSquareMetersPerSecond(double)"/>
        public static KinematicViscosity SquareMetersPerSecond(this int value) => KinematicViscosity.FromSquareMetersPerSecond(value);

        /// <inheritdoc cref="KinematicViscosity.FromSquareMetersPerSecond(double?)"/>
        public static KinematicViscosity? SquareMetersPerSecond(this int? value) => KinematicViscosity.FromSquareMetersPerSecond(value);

        /// <inheritdoc cref="KinematicViscosity.FromSquareMetersPerSecond(double)"/>
        public static KinematicViscosity SquareMetersPerSecond(this long value) => KinematicViscosity.FromSquareMetersPerSecond(value);

        /// <inheritdoc cref="KinematicViscosity.FromSquareMetersPerSecond(double?)"/>
        public static KinematicViscosity? SquareMetersPerSecond(this long? value) => KinematicViscosity.FromSquareMetersPerSecond(value);

        /// <inheritdoc cref="KinematicViscosity.FromSquareMetersPerSecond(double)"/>
        public static KinematicViscosity SquareMetersPerSecond(this double value) => KinematicViscosity.FromSquareMetersPerSecond(value);

        /// <inheritdoc cref="KinematicViscosity.FromSquareMetersPerSecond(double?)"/>
        public static KinematicViscosity? SquareMetersPerSecond(this double? value) => KinematicViscosity.FromSquareMetersPerSecond(value);

        /// <inheritdoc cref="KinematicViscosity.FromSquareMetersPerSecond(double)"/>
        public static KinematicViscosity SquareMetersPerSecond(this float value) => KinematicViscosity.FromSquareMetersPerSecond(value);

        /// <inheritdoc cref="KinematicViscosity.FromSquareMetersPerSecond(double?)"/>
        public static KinematicViscosity? SquareMetersPerSecond(this float? value) => KinematicViscosity.FromSquareMetersPerSecond(value);

        /// <inheritdoc cref="KinematicViscosity.FromSquareMetersPerSecond(double)"/>
        public static KinematicViscosity SquareMetersPerSecond(this decimal value) => KinematicViscosity.FromSquareMetersPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="KinematicViscosity.FromSquareMetersPerSecond(double?)"/>
        public static KinematicViscosity? SquareMetersPerSecond(this decimal? value) => KinematicViscosity.FromSquareMetersPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Stokes

        /// <inheritdoc cref="KinematicViscosity.FromStokes(double)"/>
        public static KinematicViscosity Stokes(this int value) => KinematicViscosity.FromStokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromStokes(double?)"/>
        public static KinematicViscosity? Stokes(this int? value) => KinematicViscosity.FromStokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromStokes(double)"/>
        public static KinematicViscosity Stokes(this long value) => KinematicViscosity.FromStokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromStokes(double?)"/>
        public static KinematicViscosity? Stokes(this long? value) => KinematicViscosity.FromStokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromStokes(double)"/>
        public static KinematicViscosity Stokes(this double value) => KinematicViscosity.FromStokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromStokes(double?)"/>
        public static KinematicViscosity? Stokes(this double? value) => KinematicViscosity.FromStokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromStokes(double)"/>
        public static KinematicViscosity Stokes(this float value) => KinematicViscosity.FromStokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromStokes(double?)"/>
        public static KinematicViscosity? Stokes(this float? value) => KinematicViscosity.FromStokes(value);

        /// <inheritdoc cref="KinematicViscosity.FromStokes(double)"/>
        public static KinematicViscosity Stokes(this decimal value) => KinematicViscosity.FromStokes(Convert.ToDouble(value));

        /// <inheritdoc cref="KinematicViscosity.FromStokes(double?)"/>
        public static KinematicViscosity? Stokes(this decimal? value) => KinematicViscosity.FromStokes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
