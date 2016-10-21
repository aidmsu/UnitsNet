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
        #region CentimeterPerMinute

        /// <inheritdoc cref="Speed.FromCentimetersPerMinutes(double)"/>
        public static Speed CentimetersPerMinutes(this int value) => Speed.FromCentimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromCentimetersPerMinutes(double?)"/>
        public static Speed? CentimetersPerMinutes(this int? value) => Speed.FromCentimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromCentimetersPerMinutes(double)"/>
        public static Speed CentimetersPerMinutes(this long value) => Speed.FromCentimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromCentimetersPerMinutes(double?)"/>
        public static Speed? CentimetersPerMinutes(this long? value) => Speed.FromCentimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromCentimetersPerMinutes(double)"/>
        public static Speed CentimetersPerMinutes(this double value) => Speed.FromCentimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromCentimetersPerMinutes(double?)"/>
        public static Speed? CentimetersPerMinutes(this double? value) => Speed.FromCentimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromCentimetersPerMinutes(double)"/>
        public static Speed CentimetersPerMinutes(this float value) => Speed.FromCentimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromCentimetersPerMinutes(double?)"/>
        public static Speed? CentimetersPerMinutes(this float? value) => Speed.FromCentimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromCentimetersPerMinutes(double)"/>
        public static Speed CentimetersPerMinutes(this decimal value) => Speed.FromCentimetersPerMinutes(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromCentimetersPerMinutes(double?)"/>
        public static Speed? CentimetersPerMinutes(this decimal? value) => Speed.FromCentimetersPerMinutes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CentimeterPerSecond

        /// <inheritdoc cref="Speed.FromCentimetersPerSecond(double)"/>
        public static Speed CentimetersPerSecond(this int value) => Speed.FromCentimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromCentimetersPerSecond(double?)"/>
        public static Speed? CentimetersPerSecond(this int? value) => Speed.FromCentimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromCentimetersPerSecond(double)"/>
        public static Speed CentimetersPerSecond(this long value) => Speed.FromCentimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromCentimetersPerSecond(double?)"/>
        public static Speed? CentimetersPerSecond(this long? value) => Speed.FromCentimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromCentimetersPerSecond(double)"/>
        public static Speed CentimetersPerSecond(this double value) => Speed.FromCentimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromCentimetersPerSecond(double?)"/>
        public static Speed? CentimetersPerSecond(this double? value) => Speed.FromCentimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromCentimetersPerSecond(double)"/>
        public static Speed CentimetersPerSecond(this float value) => Speed.FromCentimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromCentimetersPerSecond(double?)"/>
        public static Speed? CentimetersPerSecond(this float? value) => Speed.FromCentimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromCentimetersPerSecond(double)"/>
        public static Speed CentimetersPerSecond(this decimal value) => Speed.FromCentimetersPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromCentimetersPerSecond(double?)"/>
        public static Speed? CentimetersPerSecond(this decimal? value) => Speed.FromCentimetersPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecimeterPerMinute

        /// <inheritdoc cref="Speed.FromDecimetersPerMinutes(double)"/>
        public static Speed DecimetersPerMinutes(this int value) => Speed.FromDecimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromDecimetersPerMinutes(double?)"/>
        public static Speed? DecimetersPerMinutes(this int? value) => Speed.FromDecimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromDecimetersPerMinutes(double)"/>
        public static Speed DecimetersPerMinutes(this long value) => Speed.FromDecimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromDecimetersPerMinutes(double?)"/>
        public static Speed? DecimetersPerMinutes(this long? value) => Speed.FromDecimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromDecimetersPerMinutes(double)"/>
        public static Speed DecimetersPerMinutes(this double value) => Speed.FromDecimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromDecimetersPerMinutes(double?)"/>
        public static Speed? DecimetersPerMinutes(this double? value) => Speed.FromDecimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromDecimetersPerMinutes(double)"/>
        public static Speed DecimetersPerMinutes(this float value) => Speed.FromDecimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromDecimetersPerMinutes(double?)"/>
        public static Speed? DecimetersPerMinutes(this float? value) => Speed.FromDecimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromDecimetersPerMinutes(double)"/>
        public static Speed DecimetersPerMinutes(this decimal value) => Speed.FromDecimetersPerMinutes(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromDecimetersPerMinutes(double?)"/>
        public static Speed? DecimetersPerMinutes(this decimal? value) => Speed.FromDecimetersPerMinutes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecimeterPerSecond

        /// <inheritdoc cref="Speed.FromDecimetersPerSecond(double)"/>
        public static Speed DecimetersPerSecond(this int value) => Speed.FromDecimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromDecimetersPerSecond(double?)"/>
        public static Speed? DecimetersPerSecond(this int? value) => Speed.FromDecimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromDecimetersPerSecond(double)"/>
        public static Speed DecimetersPerSecond(this long value) => Speed.FromDecimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromDecimetersPerSecond(double?)"/>
        public static Speed? DecimetersPerSecond(this long? value) => Speed.FromDecimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromDecimetersPerSecond(double)"/>
        public static Speed DecimetersPerSecond(this double value) => Speed.FromDecimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromDecimetersPerSecond(double?)"/>
        public static Speed? DecimetersPerSecond(this double? value) => Speed.FromDecimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromDecimetersPerSecond(double)"/>
        public static Speed DecimetersPerSecond(this float value) => Speed.FromDecimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromDecimetersPerSecond(double?)"/>
        public static Speed? DecimetersPerSecond(this float? value) => Speed.FromDecimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromDecimetersPerSecond(double)"/>
        public static Speed DecimetersPerSecond(this decimal value) => Speed.FromDecimetersPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromDecimetersPerSecond(double?)"/>
        public static Speed? DecimetersPerSecond(this decimal? value) => Speed.FromDecimetersPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region FootPerSecond

        /// <inheritdoc cref="Speed.FromFeetPerSecond(double)"/>
        public static Speed FeetPerSecond(this int value) => Speed.FromFeetPerSecond(value);

        /// <inheritdoc cref="Speed.FromFeetPerSecond(double?)"/>
        public static Speed? FeetPerSecond(this int? value) => Speed.FromFeetPerSecond(value);

        /// <inheritdoc cref="Speed.FromFeetPerSecond(double)"/>
        public static Speed FeetPerSecond(this long value) => Speed.FromFeetPerSecond(value);

        /// <inheritdoc cref="Speed.FromFeetPerSecond(double?)"/>
        public static Speed? FeetPerSecond(this long? value) => Speed.FromFeetPerSecond(value);

        /// <inheritdoc cref="Speed.FromFeetPerSecond(double)"/>
        public static Speed FeetPerSecond(this double value) => Speed.FromFeetPerSecond(value);

        /// <inheritdoc cref="Speed.FromFeetPerSecond(double?)"/>
        public static Speed? FeetPerSecond(this double? value) => Speed.FromFeetPerSecond(value);

        /// <inheritdoc cref="Speed.FromFeetPerSecond(double)"/>
        public static Speed FeetPerSecond(this float value) => Speed.FromFeetPerSecond(value);

        /// <inheritdoc cref="Speed.FromFeetPerSecond(double?)"/>
        public static Speed? FeetPerSecond(this float? value) => Speed.FromFeetPerSecond(value);

        /// <inheritdoc cref="Speed.FromFeetPerSecond(double)"/>
        public static Speed FeetPerSecond(this decimal value) => Speed.FromFeetPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromFeetPerSecond(double?)"/>
        public static Speed? FeetPerSecond(this decimal? value) => Speed.FromFeetPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilometerPerHour

        /// <inheritdoc cref="Speed.FromKilometersPerHour(double)"/>
        public static Speed KilometersPerHour(this int value) => Speed.FromKilometersPerHour(value);

        /// <inheritdoc cref="Speed.FromKilometersPerHour(double?)"/>
        public static Speed? KilometersPerHour(this int? value) => Speed.FromKilometersPerHour(value);

        /// <inheritdoc cref="Speed.FromKilometersPerHour(double)"/>
        public static Speed KilometersPerHour(this long value) => Speed.FromKilometersPerHour(value);

        /// <inheritdoc cref="Speed.FromKilometersPerHour(double?)"/>
        public static Speed? KilometersPerHour(this long? value) => Speed.FromKilometersPerHour(value);

        /// <inheritdoc cref="Speed.FromKilometersPerHour(double)"/>
        public static Speed KilometersPerHour(this double value) => Speed.FromKilometersPerHour(value);

        /// <inheritdoc cref="Speed.FromKilometersPerHour(double?)"/>
        public static Speed? KilometersPerHour(this double? value) => Speed.FromKilometersPerHour(value);

        /// <inheritdoc cref="Speed.FromKilometersPerHour(double)"/>
        public static Speed KilometersPerHour(this float value) => Speed.FromKilometersPerHour(value);

        /// <inheritdoc cref="Speed.FromKilometersPerHour(double?)"/>
        public static Speed? KilometersPerHour(this float? value) => Speed.FromKilometersPerHour(value);

        /// <inheritdoc cref="Speed.FromKilometersPerHour(double)"/>
        public static Speed KilometersPerHour(this decimal value) => Speed.FromKilometersPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromKilometersPerHour(double?)"/>
        public static Speed? KilometersPerHour(this decimal? value) => Speed.FromKilometersPerHour(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilometerPerMinute

        /// <inheritdoc cref="Speed.FromKilometersPerMinutes(double)"/>
        public static Speed KilometersPerMinutes(this int value) => Speed.FromKilometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromKilometersPerMinutes(double?)"/>
        public static Speed? KilometersPerMinutes(this int? value) => Speed.FromKilometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromKilometersPerMinutes(double)"/>
        public static Speed KilometersPerMinutes(this long value) => Speed.FromKilometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromKilometersPerMinutes(double?)"/>
        public static Speed? KilometersPerMinutes(this long? value) => Speed.FromKilometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromKilometersPerMinutes(double)"/>
        public static Speed KilometersPerMinutes(this double value) => Speed.FromKilometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromKilometersPerMinutes(double?)"/>
        public static Speed? KilometersPerMinutes(this double? value) => Speed.FromKilometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromKilometersPerMinutes(double)"/>
        public static Speed KilometersPerMinutes(this float value) => Speed.FromKilometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromKilometersPerMinutes(double?)"/>
        public static Speed? KilometersPerMinutes(this float? value) => Speed.FromKilometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromKilometersPerMinutes(double)"/>
        public static Speed KilometersPerMinutes(this decimal value) => Speed.FromKilometersPerMinutes(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromKilometersPerMinutes(double?)"/>
        public static Speed? KilometersPerMinutes(this decimal? value) => Speed.FromKilometersPerMinutes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilometerPerSecond

        /// <inheritdoc cref="Speed.FromKilometersPerSecond(double)"/>
        public static Speed KilometersPerSecond(this int value) => Speed.FromKilometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromKilometersPerSecond(double?)"/>
        public static Speed? KilometersPerSecond(this int? value) => Speed.FromKilometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromKilometersPerSecond(double)"/>
        public static Speed KilometersPerSecond(this long value) => Speed.FromKilometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromKilometersPerSecond(double?)"/>
        public static Speed? KilometersPerSecond(this long? value) => Speed.FromKilometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromKilometersPerSecond(double)"/>
        public static Speed KilometersPerSecond(this double value) => Speed.FromKilometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromKilometersPerSecond(double?)"/>
        public static Speed? KilometersPerSecond(this double? value) => Speed.FromKilometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromKilometersPerSecond(double)"/>
        public static Speed KilometersPerSecond(this float value) => Speed.FromKilometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromKilometersPerSecond(double?)"/>
        public static Speed? KilometersPerSecond(this float? value) => Speed.FromKilometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromKilometersPerSecond(double)"/>
        public static Speed KilometersPerSecond(this decimal value) => Speed.FromKilometersPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromKilometersPerSecond(double?)"/>
        public static Speed? KilometersPerSecond(this decimal? value) => Speed.FromKilometersPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Knot

        /// <inheritdoc cref="Speed.FromKnots(double)"/>
        public static Speed Knots(this int value) => Speed.FromKnots(value);

        /// <inheritdoc cref="Speed.FromKnots(double?)"/>
        public static Speed? Knots(this int? value) => Speed.FromKnots(value);

        /// <inheritdoc cref="Speed.FromKnots(double)"/>
        public static Speed Knots(this long value) => Speed.FromKnots(value);

        /// <inheritdoc cref="Speed.FromKnots(double?)"/>
        public static Speed? Knots(this long? value) => Speed.FromKnots(value);

        /// <inheritdoc cref="Speed.FromKnots(double)"/>
        public static Speed Knots(this double value) => Speed.FromKnots(value);

        /// <inheritdoc cref="Speed.FromKnots(double?)"/>
        public static Speed? Knots(this double? value) => Speed.FromKnots(value);

        /// <inheritdoc cref="Speed.FromKnots(double)"/>
        public static Speed Knots(this float value) => Speed.FromKnots(value);

        /// <inheritdoc cref="Speed.FromKnots(double?)"/>
        public static Speed? Knots(this float? value) => Speed.FromKnots(value);

        /// <inheritdoc cref="Speed.FromKnots(double)"/>
        public static Speed Knots(this decimal value) => Speed.FromKnots(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromKnots(double?)"/>
        public static Speed? Knots(this decimal? value) => Speed.FromKnots(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MeterPerHour

        /// <inheritdoc cref="Speed.FromMetersPerHour(double)"/>
        public static Speed MetersPerHour(this int value) => Speed.FromMetersPerHour(value);

        /// <inheritdoc cref="Speed.FromMetersPerHour(double?)"/>
        public static Speed? MetersPerHour(this int? value) => Speed.FromMetersPerHour(value);

        /// <inheritdoc cref="Speed.FromMetersPerHour(double)"/>
        public static Speed MetersPerHour(this long value) => Speed.FromMetersPerHour(value);

        /// <inheritdoc cref="Speed.FromMetersPerHour(double?)"/>
        public static Speed? MetersPerHour(this long? value) => Speed.FromMetersPerHour(value);

        /// <inheritdoc cref="Speed.FromMetersPerHour(double)"/>
        public static Speed MetersPerHour(this double value) => Speed.FromMetersPerHour(value);

        /// <inheritdoc cref="Speed.FromMetersPerHour(double?)"/>
        public static Speed? MetersPerHour(this double? value) => Speed.FromMetersPerHour(value);

        /// <inheritdoc cref="Speed.FromMetersPerHour(double)"/>
        public static Speed MetersPerHour(this float value) => Speed.FromMetersPerHour(value);

        /// <inheritdoc cref="Speed.FromMetersPerHour(double?)"/>
        public static Speed? MetersPerHour(this float? value) => Speed.FromMetersPerHour(value);

        /// <inheritdoc cref="Speed.FromMetersPerHour(double)"/>
        public static Speed MetersPerHour(this decimal value) => Speed.FromMetersPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromMetersPerHour(double?)"/>
        public static Speed? MetersPerHour(this decimal? value) => Speed.FromMetersPerHour(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MeterPerMinute

        /// <inheritdoc cref="Speed.FromMetersPerMinutes(double)"/>
        public static Speed MetersPerMinutes(this int value) => Speed.FromMetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMetersPerMinutes(double?)"/>
        public static Speed? MetersPerMinutes(this int? value) => Speed.FromMetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMetersPerMinutes(double)"/>
        public static Speed MetersPerMinutes(this long value) => Speed.FromMetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMetersPerMinutes(double?)"/>
        public static Speed? MetersPerMinutes(this long? value) => Speed.FromMetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMetersPerMinutes(double)"/>
        public static Speed MetersPerMinutes(this double value) => Speed.FromMetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMetersPerMinutes(double?)"/>
        public static Speed? MetersPerMinutes(this double? value) => Speed.FromMetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMetersPerMinutes(double)"/>
        public static Speed MetersPerMinutes(this float value) => Speed.FromMetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMetersPerMinutes(double?)"/>
        public static Speed? MetersPerMinutes(this float? value) => Speed.FromMetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMetersPerMinutes(double)"/>
        public static Speed MetersPerMinutes(this decimal value) => Speed.FromMetersPerMinutes(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromMetersPerMinutes(double?)"/>
        public static Speed? MetersPerMinutes(this decimal? value) => Speed.FromMetersPerMinutes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MeterPerSecond

        /// <inheritdoc cref="Speed.FromMetersPerSecond(double)"/>
        public static Speed MetersPerSecond(this int value) => Speed.FromMetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMetersPerSecond(double?)"/>
        public static Speed? MetersPerSecond(this int? value) => Speed.FromMetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMetersPerSecond(double)"/>
        public static Speed MetersPerSecond(this long value) => Speed.FromMetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMetersPerSecond(double?)"/>
        public static Speed? MetersPerSecond(this long? value) => Speed.FromMetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMetersPerSecond(double)"/>
        public static Speed MetersPerSecond(this double value) => Speed.FromMetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMetersPerSecond(double?)"/>
        public static Speed? MetersPerSecond(this double? value) => Speed.FromMetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMetersPerSecond(double)"/>
        public static Speed MetersPerSecond(this float value) => Speed.FromMetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMetersPerSecond(double?)"/>
        public static Speed? MetersPerSecond(this float? value) => Speed.FromMetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMetersPerSecond(double)"/>
        public static Speed MetersPerSecond(this decimal value) => Speed.FromMetersPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromMetersPerSecond(double?)"/>
        public static Speed? MetersPerSecond(this decimal? value) => Speed.FromMetersPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicrometerPerMinute

        /// <inheritdoc cref="Speed.FromMicrometersPerMinutes(double)"/>
        public static Speed MicrometersPerMinutes(this int value) => Speed.FromMicrometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMicrometersPerMinutes(double?)"/>
        public static Speed? MicrometersPerMinutes(this int? value) => Speed.FromMicrometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMicrometersPerMinutes(double)"/>
        public static Speed MicrometersPerMinutes(this long value) => Speed.FromMicrometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMicrometersPerMinutes(double?)"/>
        public static Speed? MicrometersPerMinutes(this long? value) => Speed.FromMicrometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMicrometersPerMinutes(double)"/>
        public static Speed MicrometersPerMinutes(this double value) => Speed.FromMicrometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMicrometersPerMinutes(double?)"/>
        public static Speed? MicrometersPerMinutes(this double? value) => Speed.FromMicrometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMicrometersPerMinutes(double)"/>
        public static Speed MicrometersPerMinutes(this float value) => Speed.FromMicrometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMicrometersPerMinutes(double?)"/>
        public static Speed? MicrometersPerMinutes(this float? value) => Speed.FromMicrometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMicrometersPerMinutes(double)"/>
        public static Speed MicrometersPerMinutes(this decimal value) => Speed.FromMicrometersPerMinutes(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromMicrometersPerMinutes(double?)"/>
        public static Speed? MicrometersPerMinutes(this decimal? value) => Speed.FromMicrometersPerMinutes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicrometerPerSecond

        /// <inheritdoc cref="Speed.FromMicrometersPerSecond(double)"/>
        public static Speed MicrometersPerSecond(this int value) => Speed.FromMicrometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMicrometersPerSecond(double?)"/>
        public static Speed? MicrometersPerSecond(this int? value) => Speed.FromMicrometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMicrometersPerSecond(double)"/>
        public static Speed MicrometersPerSecond(this long value) => Speed.FromMicrometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMicrometersPerSecond(double?)"/>
        public static Speed? MicrometersPerSecond(this long? value) => Speed.FromMicrometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMicrometersPerSecond(double)"/>
        public static Speed MicrometersPerSecond(this double value) => Speed.FromMicrometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMicrometersPerSecond(double?)"/>
        public static Speed? MicrometersPerSecond(this double? value) => Speed.FromMicrometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMicrometersPerSecond(double)"/>
        public static Speed MicrometersPerSecond(this float value) => Speed.FromMicrometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMicrometersPerSecond(double?)"/>
        public static Speed? MicrometersPerSecond(this float? value) => Speed.FromMicrometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMicrometersPerSecond(double)"/>
        public static Speed MicrometersPerSecond(this decimal value) => Speed.FromMicrometersPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromMicrometersPerSecond(double?)"/>
        public static Speed? MicrometersPerSecond(this decimal? value) => Speed.FromMicrometersPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MilePerHour

        /// <inheritdoc cref="Speed.FromMilesPerHour(double)"/>
        public static Speed MilesPerHour(this int value) => Speed.FromMilesPerHour(value);

        /// <inheritdoc cref="Speed.FromMilesPerHour(double?)"/>
        public static Speed? MilesPerHour(this int? value) => Speed.FromMilesPerHour(value);

        /// <inheritdoc cref="Speed.FromMilesPerHour(double)"/>
        public static Speed MilesPerHour(this long value) => Speed.FromMilesPerHour(value);

        /// <inheritdoc cref="Speed.FromMilesPerHour(double?)"/>
        public static Speed? MilesPerHour(this long? value) => Speed.FromMilesPerHour(value);

        /// <inheritdoc cref="Speed.FromMilesPerHour(double)"/>
        public static Speed MilesPerHour(this double value) => Speed.FromMilesPerHour(value);

        /// <inheritdoc cref="Speed.FromMilesPerHour(double?)"/>
        public static Speed? MilesPerHour(this double? value) => Speed.FromMilesPerHour(value);

        /// <inheritdoc cref="Speed.FromMilesPerHour(double)"/>
        public static Speed MilesPerHour(this float value) => Speed.FromMilesPerHour(value);

        /// <inheritdoc cref="Speed.FromMilesPerHour(double?)"/>
        public static Speed? MilesPerHour(this float? value) => Speed.FromMilesPerHour(value);

        /// <inheritdoc cref="Speed.FromMilesPerHour(double)"/>
        public static Speed MilesPerHour(this decimal value) => Speed.FromMilesPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromMilesPerHour(double?)"/>
        public static Speed? MilesPerHour(this decimal? value) => Speed.FromMilesPerHour(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillimeterPerMinute

        /// <inheritdoc cref="Speed.FromMillimetersPerMinutes(double)"/>
        public static Speed MillimetersPerMinutes(this int value) => Speed.FromMillimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMillimetersPerMinutes(double?)"/>
        public static Speed? MillimetersPerMinutes(this int? value) => Speed.FromMillimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMillimetersPerMinutes(double)"/>
        public static Speed MillimetersPerMinutes(this long value) => Speed.FromMillimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMillimetersPerMinutes(double?)"/>
        public static Speed? MillimetersPerMinutes(this long? value) => Speed.FromMillimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMillimetersPerMinutes(double)"/>
        public static Speed MillimetersPerMinutes(this double value) => Speed.FromMillimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMillimetersPerMinutes(double?)"/>
        public static Speed? MillimetersPerMinutes(this double? value) => Speed.FromMillimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMillimetersPerMinutes(double)"/>
        public static Speed MillimetersPerMinutes(this float value) => Speed.FromMillimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMillimetersPerMinutes(double?)"/>
        public static Speed? MillimetersPerMinutes(this float? value) => Speed.FromMillimetersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromMillimetersPerMinutes(double)"/>
        public static Speed MillimetersPerMinutes(this decimal value) => Speed.FromMillimetersPerMinutes(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromMillimetersPerMinutes(double?)"/>
        public static Speed? MillimetersPerMinutes(this decimal? value) => Speed.FromMillimetersPerMinutes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillimeterPerSecond

        /// <inheritdoc cref="Speed.FromMillimetersPerSecond(double)"/>
        public static Speed MillimetersPerSecond(this int value) => Speed.FromMillimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMillimetersPerSecond(double?)"/>
        public static Speed? MillimetersPerSecond(this int? value) => Speed.FromMillimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMillimetersPerSecond(double)"/>
        public static Speed MillimetersPerSecond(this long value) => Speed.FromMillimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMillimetersPerSecond(double?)"/>
        public static Speed? MillimetersPerSecond(this long? value) => Speed.FromMillimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMillimetersPerSecond(double)"/>
        public static Speed MillimetersPerSecond(this double value) => Speed.FromMillimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMillimetersPerSecond(double?)"/>
        public static Speed? MillimetersPerSecond(this double? value) => Speed.FromMillimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMillimetersPerSecond(double)"/>
        public static Speed MillimetersPerSecond(this float value) => Speed.FromMillimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMillimetersPerSecond(double?)"/>
        public static Speed? MillimetersPerSecond(this float? value) => Speed.FromMillimetersPerSecond(value);

        /// <inheritdoc cref="Speed.FromMillimetersPerSecond(double)"/>
        public static Speed MillimetersPerSecond(this decimal value) => Speed.FromMillimetersPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromMillimetersPerSecond(double?)"/>
        public static Speed? MillimetersPerSecond(this decimal? value) => Speed.FromMillimetersPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NanometerPerMinute

        /// <inheritdoc cref="Speed.FromNanometersPerMinutes(double)"/>
        public static Speed NanometersPerMinutes(this int value) => Speed.FromNanometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromNanometersPerMinutes(double?)"/>
        public static Speed? NanometersPerMinutes(this int? value) => Speed.FromNanometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromNanometersPerMinutes(double)"/>
        public static Speed NanometersPerMinutes(this long value) => Speed.FromNanometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromNanometersPerMinutes(double?)"/>
        public static Speed? NanometersPerMinutes(this long? value) => Speed.FromNanometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromNanometersPerMinutes(double)"/>
        public static Speed NanometersPerMinutes(this double value) => Speed.FromNanometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromNanometersPerMinutes(double?)"/>
        public static Speed? NanometersPerMinutes(this double? value) => Speed.FromNanometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromNanometersPerMinutes(double)"/>
        public static Speed NanometersPerMinutes(this float value) => Speed.FromNanometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromNanometersPerMinutes(double?)"/>
        public static Speed? NanometersPerMinutes(this float? value) => Speed.FromNanometersPerMinutes(value);

        /// <inheritdoc cref="Speed.FromNanometersPerMinutes(double)"/>
        public static Speed NanometersPerMinutes(this decimal value) => Speed.FromNanometersPerMinutes(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromNanometersPerMinutes(double?)"/>
        public static Speed? NanometersPerMinutes(this decimal? value) => Speed.FromNanometersPerMinutes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NanometerPerSecond

        /// <inheritdoc cref="Speed.FromNanometersPerSecond(double)"/>
        public static Speed NanometersPerSecond(this int value) => Speed.FromNanometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromNanometersPerSecond(double?)"/>
        public static Speed? NanometersPerSecond(this int? value) => Speed.FromNanometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromNanometersPerSecond(double)"/>
        public static Speed NanometersPerSecond(this long value) => Speed.FromNanometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromNanometersPerSecond(double?)"/>
        public static Speed? NanometersPerSecond(this long? value) => Speed.FromNanometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromNanometersPerSecond(double)"/>
        public static Speed NanometersPerSecond(this double value) => Speed.FromNanometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromNanometersPerSecond(double?)"/>
        public static Speed? NanometersPerSecond(this double? value) => Speed.FromNanometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromNanometersPerSecond(double)"/>
        public static Speed NanometersPerSecond(this float value) => Speed.FromNanometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromNanometersPerSecond(double?)"/>
        public static Speed? NanometersPerSecond(this float? value) => Speed.FromNanometersPerSecond(value);

        /// <inheritdoc cref="Speed.FromNanometersPerSecond(double)"/>
        public static Speed NanometersPerSecond(this decimal value) => Speed.FromNanometersPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="Speed.FromNanometersPerSecond(double?)"/>
        public static Speed? NanometersPerSecond(this decimal? value) => Speed.FromNanometersPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
