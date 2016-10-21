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
        #region AuTablespoon

        /// <inheritdoc cref="Volume.FromAuTablespoons(double)"/>
        public static Volume AuTablespoons(this int value) => Volume.FromAuTablespoons(value);

        /// <inheritdoc cref="Volume.FromAuTablespoons(double?)"/>
        public static Volume? AuTablespoons(this int? value) => Volume.FromAuTablespoons(value);

        /// <inheritdoc cref="Volume.FromAuTablespoons(double)"/>
        public static Volume AuTablespoons(this long value) => Volume.FromAuTablespoons(value);

        /// <inheritdoc cref="Volume.FromAuTablespoons(double?)"/>
        public static Volume? AuTablespoons(this long? value) => Volume.FromAuTablespoons(value);

        /// <inheritdoc cref="Volume.FromAuTablespoons(double)"/>
        public static Volume AuTablespoons(this double value) => Volume.FromAuTablespoons(value);

        /// <inheritdoc cref="Volume.FromAuTablespoons(double?)"/>
        public static Volume? AuTablespoons(this double? value) => Volume.FromAuTablespoons(value);

        /// <inheritdoc cref="Volume.FromAuTablespoons(double)"/>
        public static Volume AuTablespoons(this float value) => Volume.FromAuTablespoons(value);

        /// <inheritdoc cref="Volume.FromAuTablespoons(double?)"/>
        public static Volume? AuTablespoons(this float? value) => Volume.FromAuTablespoons(value);

        /// <inheritdoc cref="Volume.FromAuTablespoons(double)"/>
        public static Volume AuTablespoons(this decimal value) => Volume.FromAuTablespoons(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromAuTablespoons(double?)"/>
        public static Volume? AuTablespoons(this decimal? value) => Volume.FromAuTablespoons(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Centiliter

        /// <inheritdoc cref="Volume.FromCentiliters(double)"/>
        public static Volume Centiliters(this int value) => Volume.FromCentiliters(value);

        /// <inheritdoc cref="Volume.FromCentiliters(double?)"/>
        public static Volume? Centiliters(this int? value) => Volume.FromCentiliters(value);

        /// <inheritdoc cref="Volume.FromCentiliters(double)"/>
        public static Volume Centiliters(this long value) => Volume.FromCentiliters(value);

        /// <inheritdoc cref="Volume.FromCentiliters(double?)"/>
        public static Volume? Centiliters(this long? value) => Volume.FromCentiliters(value);

        /// <inheritdoc cref="Volume.FromCentiliters(double)"/>
        public static Volume Centiliters(this double value) => Volume.FromCentiliters(value);

        /// <inheritdoc cref="Volume.FromCentiliters(double?)"/>
        public static Volume? Centiliters(this double? value) => Volume.FromCentiliters(value);

        /// <inheritdoc cref="Volume.FromCentiliters(double)"/>
        public static Volume Centiliters(this float value) => Volume.FromCentiliters(value);

        /// <inheritdoc cref="Volume.FromCentiliters(double?)"/>
        public static Volume? Centiliters(this float? value) => Volume.FromCentiliters(value);

        /// <inheritdoc cref="Volume.FromCentiliters(double)"/>
        public static Volume Centiliters(this decimal value) => Volume.FromCentiliters(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromCentiliters(double?)"/>
        public static Volume? Centiliters(this decimal? value) => Volume.FromCentiliters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CubicCentimeter

        /// <inheritdoc cref="Volume.FromCubicCentimeters(double)"/>
        public static Volume CubicCentimeters(this int value) => Volume.FromCubicCentimeters(value);

        /// <inheritdoc cref="Volume.FromCubicCentimeters(double?)"/>
        public static Volume? CubicCentimeters(this int? value) => Volume.FromCubicCentimeters(value);

        /// <inheritdoc cref="Volume.FromCubicCentimeters(double)"/>
        public static Volume CubicCentimeters(this long value) => Volume.FromCubicCentimeters(value);

        /// <inheritdoc cref="Volume.FromCubicCentimeters(double?)"/>
        public static Volume? CubicCentimeters(this long? value) => Volume.FromCubicCentimeters(value);

        /// <inheritdoc cref="Volume.FromCubicCentimeters(double)"/>
        public static Volume CubicCentimeters(this double value) => Volume.FromCubicCentimeters(value);

        /// <inheritdoc cref="Volume.FromCubicCentimeters(double?)"/>
        public static Volume? CubicCentimeters(this double? value) => Volume.FromCubicCentimeters(value);

        /// <inheritdoc cref="Volume.FromCubicCentimeters(double)"/>
        public static Volume CubicCentimeters(this float value) => Volume.FromCubicCentimeters(value);

        /// <inheritdoc cref="Volume.FromCubicCentimeters(double?)"/>
        public static Volume? CubicCentimeters(this float? value) => Volume.FromCubicCentimeters(value);

        /// <inheritdoc cref="Volume.FromCubicCentimeters(double)"/>
        public static Volume CubicCentimeters(this decimal value) => Volume.FromCubicCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromCubicCentimeters(double?)"/>
        public static Volume? CubicCentimeters(this decimal? value) => Volume.FromCubicCentimeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CubicDecimeter

        /// <inheritdoc cref="Volume.FromCubicDecimeters(double)"/>
        public static Volume CubicDecimeters(this int value) => Volume.FromCubicDecimeters(value);

        /// <inheritdoc cref="Volume.FromCubicDecimeters(double?)"/>
        public static Volume? CubicDecimeters(this int? value) => Volume.FromCubicDecimeters(value);

        /// <inheritdoc cref="Volume.FromCubicDecimeters(double)"/>
        public static Volume CubicDecimeters(this long value) => Volume.FromCubicDecimeters(value);

        /// <inheritdoc cref="Volume.FromCubicDecimeters(double?)"/>
        public static Volume? CubicDecimeters(this long? value) => Volume.FromCubicDecimeters(value);

        /// <inheritdoc cref="Volume.FromCubicDecimeters(double)"/>
        public static Volume CubicDecimeters(this double value) => Volume.FromCubicDecimeters(value);

        /// <inheritdoc cref="Volume.FromCubicDecimeters(double?)"/>
        public static Volume? CubicDecimeters(this double? value) => Volume.FromCubicDecimeters(value);

        /// <inheritdoc cref="Volume.FromCubicDecimeters(double)"/>
        public static Volume CubicDecimeters(this float value) => Volume.FromCubicDecimeters(value);

        /// <inheritdoc cref="Volume.FromCubicDecimeters(double?)"/>
        public static Volume? CubicDecimeters(this float? value) => Volume.FromCubicDecimeters(value);

        /// <inheritdoc cref="Volume.FromCubicDecimeters(double)"/>
        public static Volume CubicDecimeters(this decimal value) => Volume.FromCubicDecimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromCubicDecimeters(double?)"/>
        public static Volume? CubicDecimeters(this decimal? value) => Volume.FromCubicDecimeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CubicFoot

        /// <inheritdoc cref="Volume.FromCubicFeet(double)"/>
        public static Volume CubicFeet(this int value) => Volume.FromCubicFeet(value);

        /// <inheritdoc cref="Volume.FromCubicFeet(double?)"/>
        public static Volume? CubicFeet(this int? value) => Volume.FromCubicFeet(value);

        /// <inheritdoc cref="Volume.FromCubicFeet(double)"/>
        public static Volume CubicFeet(this long value) => Volume.FromCubicFeet(value);

        /// <inheritdoc cref="Volume.FromCubicFeet(double?)"/>
        public static Volume? CubicFeet(this long? value) => Volume.FromCubicFeet(value);

        /// <inheritdoc cref="Volume.FromCubicFeet(double)"/>
        public static Volume CubicFeet(this double value) => Volume.FromCubicFeet(value);

        /// <inheritdoc cref="Volume.FromCubicFeet(double?)"/>
        public static Volume? CubicFeet(this double? value) => Volume.FromCubicFeet(value);

        /// <inheritdoc cref="Volume.FromCubicFeet(double)"/>
        public static Volume CubicFeet(this float value) => Volume.FromCubicFeet(value);

        /// <inheritdoc cref="Volume.FromCubicFeet(double?)"/>
        public static Volume? CubicFeet(this float? value) => Volume.FromCubicFeet(value);

        /// <inheritdoc cref="Volume.FromCubicFeet(double)"/>
        public static Volume CubicFeet(this decimal value) => Volume.FromCubicFeet(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromCubicFeet(double?)"/>
        public static Volume? CubicFeet(this decimal? value) => Volume.FromCubicFeet(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CubicInch

        /// <inheritdoc cref="Volume.FromCubicInches(double)"/>
        public static Volume CubicInches(this int value) => Volume.FromCubicInches(value);

        /// <inheritdoc cref="Volume.FromCubicInches(double?)"/>
        public static Volume? CubicInches(this int? value) => Volume.FromCubicInches(value);

        /// <inheritdoc cref="Volume.FromCubicInches(double)"/>
        public static Volume CubicInches(this long value) => Volume.FromCubicInches(value);

        /// <inheritdoc cref="Volume.FromCubicInches(double?)"/>
        public static Volume? CubicInches(this long? value) => Volume.FromCubicInches(value);

        /// <inheritdoc cref="Volume.FromCubicInches(double)"/>
        public static Volume CubicInches(this double value) => Volume.FromCubicInches(value);

        /// <inheritdoc cref="Volume.FromCubicInches(double?)"/>
        public static Volume? CubicInches(this double? value) => Volume.FromCubicInches(value);

        /// <inheritdoc cref="Volume.FromCubicInches(double)"/>
        public static Volume CubicInches(this float value) => Volume.FromCubicInches(value);

        /// <inheritdoc cref="Volume.FromCubicInches(double?)"/>
        public static Volume? CubicInches(this float? value) => Volume.FromCubicInches(value);

        /// <inheritdoc cref="Volume.FromCubicInches(double)"/>
        public static Volume CubicInches(this decimal value) => Volume.FromCubicInches(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromCubicInches(double?)"/>
        public static Volume? CubicInches(this decimal? value) => Volume.FromCubicInches(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CubicKilometer

        /// <inheritdoc cref="Volume.FromCubicKilometers(double)"/>
        public static Volume CubicKilometers(this int value) => Volume.FromCubicKilometers(value);

        /// <inheritdoc cref="Volume.FromCubicKilometers(double?)"/>
        public static Volume? CubicKilometers(this int? value) => Volume.FromCubicKilometers(value);

        /// <inheritdoc cref="Volume.FromCubicKilometers(double)"/>
        public static Volume CubicKilometers(this long value) => Volume.FromCubicKilometers(value);

        /// <inheritdoc cref="Volume.FromCubicKilometers(double?)"/>
        public static Volume? CubicKilometers(this long? value) => Volume.FromCubicKilometers(value);

        /// <inheritdoc cref="Volume.FromCubicKilometers(double)"/>
        public static Volume CubicKilometers(this double value) => Volume.FromCubicKilometers(value);

        /// <inheritdoc cref="Volume.FromCubicKilometers(double?)"/>
        public static Volume? CubicKilometers(this double? value) => Volume.FromCubicKilometers(value);

        /// <inheritdoc cref="Volume.FromCubicKilometers(double)"/>
        public static Volume CubicKilometers(this float value) => Volume.FromCubicKilometers(value);

        /// <inheritdoc cref="Volume.FromCubicKilometers(double?)"/>
        public static Volume? CubicKilometers(this float? value) => Volume.FromCubicKilometers(value);

        /// <inheritdoc cref="Volume.FromCubicKilometers(double)"/>
        public static Volume CubicKilometers(this decimal value) => Volume.FromCubicKilometers(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromCubicKilometers(double?)"/>
        public static Volume? CubicKilometers(this decimal? value) => Volume.FromCubicKilometers(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CubicMeter

        /// <inheritdoc cref="Volume.FromCubicMeters(double)"/>
        public static Volume CubicMeters(this int value) => Volume.FromCubicMeters(value);

        /// <inheritdoc cref="Volume.FromCubicMeters(double?)"/>
        public static Volume? CubicMeters(this int? value) => Volume.FromCubicMeters(value);

        /// <inheritdoc cref="Volume.FromCubicMeters(double)"/>
        public static Volume CubicMeters(this long value) => Volume.FromCubicMeters(value);

        /// <inheritdoc cref="Volume.FromCubicMeters(double?)"/>
        public static Volume? CubicMeters(this long? value) => Volume.FromCubicMeters(value);

        /// <inheritdoc cref="Volume.FromCubicMeters(double)"/>
        public static Volume CubicMeters(this double value) => Volume.FromCubicMeters(value);

        /// <inheritdoc cref="Volume.FromCubicMeters(double?)"/>
        public static Volume? CubicMeters(this double? value) => Volume.FromCubicMeters(value);

        /// <inheritdoc cref="Volume.FromCubicMeters(double)"/>
        public static Volume CubicMeters(this float value) => Volume.FromCubicMeters(value);

        /// <inheritdoc cref="Volume.FromCubicMeters(double?)"/>
        public static Volume? CubicMeters(this float? value) => Volume.FromCubicMeters(value);

        /// <inheritdoc cref="Volume.FromCubicMeters(double)"/>
        public static Volume CubicMeters(this decimal value) => Volume.FromCubicMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromCubicMeters(double?)"/>
        public static Volume? CubicMeters(this decimal? value) => Volume.FromCubicMeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CubicMicrometer

        /// <inheritdoc cref="Volume.FromCubicMicrometers(double)"/>
        public static Volume CubicMicrometers(this int value) => Volume.FromCubicMicrometers(value);

        /// <inheritdoc cref="Volume.FromCubicMicrometers(double?)"/>
        public static Volume? CubicMicrometers(this int? value) => Volume.FromCubicMicrometers(value);

        /// <inheritdoc cref="Volume.FromCubicMicrometers(double)"/>
        public static Volume CubicMicrometers(this long value) => Volume.FromCubicMicrometers(value);

        /// <inheritdoc cref="Volume.FromCubicMicrometers(double?)"/>
        public static Volume? CubicMicrometers(this long? value) => Volume.FromCubicMicrometers(value);

        /// <inheritdoc cref="Volume.FromCubicMicrometers(double)"/>
        public static Volume CubicMicrometers(this double value) => Volume.FromCubicMicrometers(value);

        /// <inheritdoc cref="Volume.FromCubicMicrometers(double?)"/>
        public static Volume? CubicMicrometers(this double? value) => Volume.FromCubicMicrometers(value);

        /// <inheritdoc cref="Volume.FromCubicMicrometers(double)"/>
        public static Volume CubicMicrometers(this float value) => Volume.FromCubicMicrometers(value);

        /// <inheritdoc cref="Volume.FromCubicMicrometers(double?)"/>
        public static Volume? CubicMicrometers(this float? value) => Volume.FromCubicMicrometers(value);

        /// <inheritdoc cref="Volume.FromCubicMicrometers(double)"/>
        public static Volume CubicMicrometers(this decimal value) => Volume.FromCubicMicrometers(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromCubicMicrometers(double?)"/>
        public static Volume? CubicMicrometers(this decimal? value) => Volume.FromCubicMicrometers(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CubicMile

        /// <inheritdoc cref="Volume.FromCubicMiles(double)"/>
        public static Volume CubicMiles(this int value) => Volume.FromCubicMiles(value);

        /// <inheritdoc cref="Volume.FromCubicMiles(double?)"/>
        public static Volume? CubicMiles(this int? value) => Volume.FromCubicMiles(value);

        /// <inheritdoc cref="Volume.FromCubicMiles(double)"/>
        public static Volume CubicMiles(this long value) => Volume.FromCubicMiles(value);

        /// <inheritdoc cref="Volume.FromCubicMiles(double?)"/>
        public static Volume? CubicMiles(this long? value) => Volume.FromCubicMiles(value);

        /// <inheritdoc cref="Volume.FromCubicMiles(double)"/>
        public static Volume CubicMiles(this double value) => Volume.FromCubicMiles(value);

        /// <inheritdoc cref="Volume.FromCubicMiles(double?)"/>
        public static Volume? CubicMiles(this double? value) => Volume.FromCubicMiles(value);

        /// <inheritdoc cref="Volume.FromCubicMiles(double)"/>
        public static Volume CubicMiles(this float value) => Volume.FromCubicMiles(value);

        /// <inheritdoc cref="Volume.FromCubicMiles(double?)"/>
        public static Volume? CubicMiles(this float? value) => Volume.FromCubicMiles(value);

        /// <inheritdoc cref="Volume.FromCubicMiles(double)"/>
        public static Volume CubicMiles(this decimal value) => Volume.FromCubicMiles(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromCubicMiles(double?)"/>
        public static Volume? CubicMiles(this decimal? value) => Volume.FromCubicMiles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CubicMillimeter

        /// <inheritdoc cref="Volume.FromCubicMillimeters(double)"/>
        public static Volume CubicMillimeters(this int value) => Volume.FromCubicMillimeters(value);

        /// <inheritdoc cref="Volume.FromCubicMillimeters(double?)"/>
        public static Volume? CubicMillimeters(this int? value) => Volume.FromCubicMillimeters(value);

        /// <inheritdoc cref="Volume.FromCubicMillimeters(double)"/>
        public static Volume CubicMillimeters(this long value) => Volume.FromCubicMillimeters(value);

        /// <inheritdoc cref="Volume.FromCubicMillimeters(double?)"/>
        public static Volume? CubicMillimeters(this long? value) => Volume.FromCubicMillimeters(value);

        /// <inheritdoc cref="Volume.FromCubicMillimeters(double)"/>
        public static Volume CubicMillimeters(this double value) => Volume.FromCubicMillimeters(value);

        /// <inheritdoc cref="Volume.FromCubicMillimeters(double?)"/>
        public static Volume? CubicMillimeters(this double? value) => Volume.FromCubicMillimeters(value);

        /// <inheritdoc cref="Volume.FromCubicMillimeters(double)"/>
        public static Volume CubicMillimeters(this float value) => Volume.FromCubicMillimeters(value);

        /// <inheritdoc cref="Volume.FromCubicMillimeters(double?)"/>
        public static Volume? CubicMillimeters(this float? value) => Volume.FromCubicMillimeters(value);

        /// <inheritdoc cref="Volume.FromCubicMillimeters(double)"/>
        public static Volume CubicMillimeters(this decimal value) => Volume.FromCubicMillimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromCubicMillimeters(double?)"/>
        public static Volume? CubicMillimeters(this decimal? value) => Volume.FromCubicMillimeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CubicYard

        /// <inheritdoc cref="Volume.FromCubicYards(double)"/>
        public static Volume CubicYards(this int value) => Volume.FromCubicYards(value);

        /// <inheritdoc cref="Volume.FromCubicYards(double?)"/>
        public static Volume? CubicYards(this int? value) => Volume.FromCubicYards(value);

        /// <inheritdoc cref="Volume.FromCubicYards(double)"/>
        public static Volume CubicYards(this long value) => Volume.FromCubicYards(value);

        /// <inheritdoc cref="Volume.FromCubicYards(double?)"/>
        public static Volume? CubicYards(this long? value) => Volume.FromCubicYards(value);

        /// <inheritdoc cref="Volume.FromCubicYards(double)"/>
        public static Volume CubicYards(this double value) => Volume.FromCubicYards(value);

        /// <inheritdoc cref="Volume.FromCubicYards(double?)"/>
        public static Volume? CubicYards(this double? value) => Volume.FromCubicYards(value);

        /// <inheritdoc cref="Volume.FromCubicYards(double)"/>
        public static Volume CubicYards(this float value) => Volume.FromCubicYards(value);

        /// <inheritdoc cref="Volume.FromCubicYards(double?)"/>
        public static Volume? CubicYards(this float? value) => Volume.FromCubicYards(value);

        /// <inheritdoc cref="Volume.FromCubicYards(double)"/>
        public static Volume CubicYards(this decimal value) => Volume.FromCubicYards(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromCubicYards(double?)"/>
        public static Volume? CubicYards(this decimal? value) => Volume.FromCubicYards(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Deciliter

        /// <inheritdoc cref="Volume.FromDeciliters(double)"/>
        public static Volume Deciliters(this int value) => Volume.FromDeciliters(value);

        /// <inheritdoc cref="Volume.FromDeciliters(double?)"/>
        public static Volume? Deciliters(this int? value) => Volume.FromDeciliters(value);

        /// <inheritdoc cref="Volume.FromDeciliters(double)"/>
        public static Volume Deciliters(this long value) => Volume.FromDeciliters(value);

        /// <inheritdoc cref="Volume.FromDeciliters(double?)"/>
        public static Volume? Deciliters(this long? value) => Volume.FromDeciliters(value);

        /// <inheritdoc cref="Volume.FromDeciliters(double)"/>
        public static Volume Deciliters(this double value) => Volume.FromDeciliters(value);

        /// <inheritdoc cref="Volume.FromDeciliters(double?)"/>
        public static Volume? Deciliters(this double? value) => Volume.FromDeciliters(value);

        /// <inheritdoc cref="Volume.FromDeciliters(double)"/>
        public static Volume Deciliters(this float value) => Volume.FromDeciliters(value);

        /// <inheritdoc cref="Volume.FromDeciliters(double?)"/>
        public static Volume? Deciliters(this float? value) => Volume.FromDeciliters(value);

        /// <inheritdoc cref="Volume.FromDeciliters(double)"/>
        public static Volume Deciliters(this decimal value) => Volume.FromDeciliters(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromDeciliters(double?)"/>
        public static Volume? Deciliters(this decimal? value) => Volume.FromDeciliters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Hectoliter

        /// <inheritdoc cref="Volume.FromHectoliters(double)"/>
        public static Volume Hectoliters(this int value) => Volume.FromHectoliters(value);

        /// <inheritdoc cref="Volume.FromHectoliters(double?)"/>
        public static Volume? Hectoliters(this int? value) => Volume.FromHectoliters(value);

        /// <inheritdoc cref="Volume.FromHectoliters(double)"/>
        public static Volume Hectoliters(this long value) => Volume.FromHectoliters(value);

        /// <inheritdoc cref="Volume.FromHectoliters(double?)"/>
        public static Volume? Hectoliters(this long? value) => Volume.FromHectoliters(value);

        /// <inheritdoc cref="Volume.FromHectoliters(double)"/>
        public static Volume Hectoliters(this double value) => Volume.FromHectoliters(value);

        /// <inheritdoc cref="Volume.FromHectoliters(double?)"/>
        public static Volume? Hectoliters(this double? value) => Volume.FromHectoliters(value);

        /// <inheritdoc cref="Volume.FromHectoliters(double)"/>
        public static Volume Hectoliters(this float value) => Volume.FromHectoliters(value);

        /// <inheritdoc cref="Volume.FromHectoliters(double?)"/>
        public static Volume? Hectoliters(this float? value) => Volume.FromHectoliters(value);

        /// <inheritdoc cref="Volume.FromHectoliters(double)"/>
        public static Volume Hectoliters(this decimal value) => Volume.FromHectoliters(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromHectoliters(double?)"/>
        public static Volume? Hectoliters(this decimal? value) => Volume.FromHectoliters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region ImperialGallon

        /// <inheritdoc cref="Volume.FromImperialGallons(double)"/>
        public static Volume ImperialGallons(this int value) => Volume.FromImperialGallons(value);

        /// <inheritdoc cref="Volume.FromImperialGallons(double?)"/>
        public static Volume? ImperialGallons(this int? value) => Volume.FromImperialGallons(value);

        /// <inheritdoc cref="Volume.FromImperialGallons(double)"/>
        public static Volume ImperialGallons(this long value) => Volume.FromImperialGallons(value);

        /// <inheritdoc cref="Volume.FromImperialGallons(double?)"/>
        public static Volume? ImperialGallons(this long? value) => Volume.FromImperialGallons(value);

        /// <inheritdoc cref="Volume.FromImperialGallons(double)"/>
        public static Volume ImperialGallons(this double value) => Volume.FromImperialGallons(value);

        /// <inheritdoc cref="Volume.FromImperialGallons(double?)"/>
        public static Volume? ImperialGallons(this double? value) => Volume.FromImperialGallons(value);

        /// <inheritdoc cref="Volume.FromImperialGallons(double)"/>
        public static Volume ImperialGallons(this float value) => Volume.FromImperialGallons(value);

        /// <inheritdoc cref="Volume.FromImperialGallons(double?)"/>
        public static Volume? ImperialGallons(this float? value) => Volume.FromImperialGallons(value);

        /// <inheritdoc cref="Volume.FromImperialGallons(double)"/>
        public static Volume ImperialGallons(this decimal value) => Volume.FromImperialGallons(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromImperialGallons(double?)"/>
        public static Volume? ImperialGallons(this decimal? value) => Volume.FromImperialGallons(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region ImperialOunce

        /// <inheritdoc cref="Volume.FromImperialOunces(double)"/>
        public static Volume ImperialOunces(this int value) => Volume.FromImperialOunces(value);

        /// <inheritdoc cref="Volume.FromImperialOunces(double?)"/>
        public static Volume? ImperialOunces(this int? value) => Volume.FromImperialOunces(value);

        /// <inheritdoc cref="Volume.FromImperialOunces(double)"/>
        public static Volume ImperialOunces(this long value) => Volume.FromImperialOunces(value);

        /// <inheritdoc cref="Volume.FromImperialOunces(double?)"/>
        public static Volume? ImperialOunces(this long? value) => Volume.FromImperialOunces(value);

        /// <inheritdoc cref="Volume.FromImperialOunces(double)"/>
        public static Volume ImperialOunces(this double value) => Volume.FromImperialOunces(value);

        /// <inheritdoc cref="Volume.FromImperialOunces(double?)"/>
        public static Volume? ImperialOunces(this double? value) => Volume.FromImperialOunces(value);

        /// <inheritdoc cref="Volume.FromImperialOunces(double)"/>
        public static Volume ImperialOunces(this float value) => Volume.FromImperialOunces(value);

        /// <inheritdoc cref="Volume.FromImperialOunces(double?)"/>
        public static Volume? ImperialOunces(this float? value) => Volume.FromImperialOunces(value);

        /// <inheritdoc cref="Volume.FromImperialOunces(double)"/>
        public static Volume ImperialOunces(this decimal value) => Volume.FromImperialOunces(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromImperialOunces(double?)"/>
        public static Volume? ImperialOunces(this decimal? value) => Volume.FromImperialOunces(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Liter

        /// <inheritdoc cref="Volume.FromLiters(double)"/>
        public static Volume Liters(this int value) => Volume.FromLiters(value);

        /// <inheritdoc cref="Volume.FromLiters(double?)"/>
        public static Volume? Liters(this int? value) => Volume.FromLiters(value);

        /// <inheritdoc cref="Volume.FromLiters(double)"/>
        public static Volume Liters(this long value) => Volume.FromLiters(value);

        /// <inheritdoc cref="Volume.FromLiters(double?)"/>
        public static Volume? Liters(this long? value) => Volume.FromLiters(value);

        /// <inheritdoc cref="Volume.FromLiters(double)"/>
        public static Volume Liters(this double value) => Volume.FromLiters(value);

        /// <inheritdoc cref="Volume.FromLiters(double?)"/>
        public static Volume? Liters(this double? value) => Volume.FromLiters(value);

        /// <inheritdoc cref="Volume.FromLiters(double)"/>
        public static Volume Liters(this float value) => Volume.FromLiters(value);

        /// <inheritdoc cref="Volume.FromLiters(double?)"/>
        public static Volume? Liters(this float? value) => Volume.FromLiters(value);

        /// <inheritdoc cref="Volume.FromLiters(double)"/>
        public static Volume Liters(this decimal value) => Volume.FromLiters(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromLiters(double?)"/>
        public static Volume? Liters(this decimal? value) => Volume.FromLiters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MetricCup

        /// <inheritdoc cref="Volume.FromMetricCups(double)"/>
        public static Volume MetricCups(this int value) => Volume.FromMetricCups(value);

        /// <inheritdoc cref="Volume.FromMetricCups(double?)"/>
        public static Volume? MetricCups(this int? value) => Volume.FromMetricCups(value);

        /// <inheritdoc cref="Volume.FromMetricCups(double)"/>
        public static Volume MetricCups(this long value) => Volume.FromMetricCups(value);

        /// <inheritdoc cref="Volume.FromMetricCups(double?)"/>
        public static Volume? MetricCups(this long? value) => Volume.FromMetricCups(value);

        /// <inheritdoc cref="Volume.FromMetricCups(double)"/>
        public static Volume MetricCups(this double value) => Volume.FromMetricCups(value);

        /// <inheritdoc cref="Volume.FromMetricCups(double?)"/>
        public static Volume? MetricCups(this double? value) => Volume.FromMetricCups(value);

        /// <inheritdoc cref="Volume.FromMetricCups(double)"/>
        public static Volume MetricCups(this float value) => Volume.FromMetricCups(value);

        /// <inheritdoc cref="Volume.FromMetricCups(double?)"/>
        public static Volume? MetricCups(this float? value) => Volume.FromMetricCups(value);

        /// <inheritdoc cref="Volume.FromMetricCups(double)"/>
        public static Volume MetricCups(this decimal value) => Volume.FromMetricCups(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromMetricCups(double?)"/>
        public static Volume? MetricCups(this decimal? value) => Volume.FromMetricCups(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MetricTeaspoon

        /// <inheritdoc cref="Volume.FromMetricTeaspoons(double)"/>
        public static Volume MetricTeaspoons(this int value) => Volume.FromMetricTeaspoons(value);

        /// <inheritdoc cref="Volume.FromMetricTeaspoons(double?)"/>
        public static Volume? MetricTeaspoons(this int? value) => Volume.FromMetricTeaspoons(value);

        /// <inheritdoc cref="Volume.FromMetricTeaspoons(double)"/>
        public static Volume MetricTeaspoons(this long value) => Volume.FromMetricTeaspoons(value);

        /// <inheritdoc cref="Volume.FromMetricTeaspoons(double?)"/>
        public static Volume? MetricTeaspoons(this long? value) => Volume.FromMetricTeaspoons(value);

        /// <inheritdoc cref="Volume.FromMetricTeaspoons(double)"/>
        public static Volume MetricTeaspoons(this double value) => Volume.FromMetricTeaspoons(value);

        /// <inheritdoc cref="Volume.FromMetricTeaspoons(double?)"/>
        public static Volume? MetricTeaspoons(this double? value) => Volume.FromMetricTeaspoons(value);

        /// <inheritdoc cref="Volume.FromMetricTeaspoons(double)"/>
        public static Volume MetricTeaspoons(this float value) => Volume.FromMetricTeaspoons(value);

        /// <inheritdoc cref="Volume.FromMetricTeaspoons(double?)"/>
        public static Volume? MetricTeaspoons(this float? value) => Volume.FromMetricTeaspoons(value);

        /// <inheritdoc cref="Volume.FromMetricTeaspoons(double)"/>
        public static Volume MetricTeaspoons(this decimal value) => Volume.FromMetricTeaspoons(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromMetricTeaspoons(double?)"/>
        public static Volume? MetricTeaspoons(this decimal? value) => Volume.FromMetricTeaspoons(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Microliter

        /// <inheritdoc cref="Volume.FromMicroliters(double)"/>
        public static Volume Microliters(this int value) => Volume.FromMicroliters(value);

        /// <inheritdoc cref="Volume.FromMicroliters(double?)"/>
        public static Volume? Microliters(this int? value) => Volume.FromMicroliters(value);

        /// <inheritdoc cref="Volume.FromMicroliters(double)"/>
        public static Volume Microliters(this long value) => Volume.FromMicroliters(value);

        /// <inheritdoc cref="Volume.FromMicroliters(double?)"/>
        public static Volume? Microliters(this long? value) => Volume.FromMicroliters(value);

        /// <inheritdoc cref="Volume.FromMicroliters(double)"/>
        public static Volume Microliters(this double value) => Volume.FromMicroliters(value);

        /// <inheritdoc cref="Volume.FromMicroliters(double?)"/>
        public static Volume? Microliters(this double? value) => Volume.FromMicroliters(value);

        /// <inheritdoc cref="Volume.FromMicroliters(double)"/>
        public static Volume Microliters(this float value) => Volume.FromMicroliters(value);

        /// <inheritdoc cref="Volume.FromMicroliters(double?)"/>
        public static Volume? Microliters(this float? value) => Volume.FromMicroliters(value);

        /// <inheritdoc cref="Volume.FromMicroliters(double)"/>
        public static Volume Microliters(this decimal value) => Volume.FromMicroliters(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromMicroliters(double?)"/>
        public static Volume? Microliters(this decimal? value) => Volume.FromMicroliters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Milliliter

        /// <inheritdoc cref="Volume.FromMilliliters(double)"/>
        public static Volume Milliliters(this int value) => Volume.FromMilliliters(value);

        /// <inheritdoc cref="Volume.FromMilliliters(double?)"/>
        public static Volume? Milliliters(this int? value) => Volume.FromMilliliters(value);

        /// <inheritdoc cref="Volume.FromMilliliters(double)"/>
        public static Volume Milliliters(this long value) => Volume.FromMilliliters(value);

        /// <inheritdoc cref="Volume.FromMilliliters(double?)"/>
        public static Volume? Milliliters(this long? value) => Volume.FromMilliliters(value);

        /// <inheritdoc cref="Volume.FromMilliliters(double)"/>
        public static Volume Milliliters(this double value) => Volume.FromMilliliters(value);

        /// <inheritdoc cref="Volume.FromMilliliters(double?)"/>
        public static Volume? Milliliters(this double? value) => Volume.FromMilliliters(value);

        /// <inheritdoc cref="Volume.FromMilliliters(double)"/>
        public static Volume Milliliters(this float value) => Volume.FromMilliliters(value);

        /// <inheritdoc cref="Volume.FromMilliliters(double?)"/>
        public static Volume? Milliliters(this float? value) => Volume.FromMilliliters(value);

        /// <inheritdoc cref="Volume.FromMilliliters(double)"/>
        public static Volume Milliliters(this decimal value) => Volume.FromMilliliters(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromMilliliters(double?)"/>
        public static Volume? Milliliters(this decimal? value) => Volume.FromMilliliters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region OilBarrel

        /// <inheritdoc cref="Volume.FromOilBarrels(double)"/>
        public static Volume OilBarrels(this int value) => Volume.FromOilBarrels(value);

        /// <inheritdoc cref="Volume.FromOilBarrels(double?)"/>
        public static Volume? OilBarrels(this int? value) => Volume.FromOilBarrels(value);

        /// <inheritdoc cref="Volume.FromOilBarrels(double)"/>
        public static Volume OilBarrels(this long value) => Volume.FromOilBarrels(value);

        /// <inheritdoc cref="Volume.FromOilBarrels(double?)"/>
        public static Volume? OilBarrels(this long? value) => Volume.FromOilBarrels(value);

        /// <inheritdoc cref="Volume.FromOilBarrels(double)"/>
        public static Volume OilBarrels(this double value) => Volume.FromOilBarrels(value);

        /// <inheritdoc cref="Volume.FromOilBarrels(double?)"/>
        public static Volume? OilBarrels(this double? value) => Volume.FromOilBarrels(value);

        /// <inheritdoc cref="Volume.FromOilBarrels(double)"/>
        public static Volume OilBarrels(this float value) => Volume.FromOilBarrels(value);

        /// <inheritdoc cref="Volume.FromOilBarrels(double?)"/>
        public static Volume? OilBarrels(this float? value) => Volume.FromOilBarrels(value);

        /// <inheritdoc cref="Volume.FromOilBarrels(double)"/>
        public static Volume OilBarrels(this decimal value) => Volume.FromOilBarrels(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromOilBarrels(double?)"/>
        public static Volume? OilBarrels(this decimal? value) => Volume.FromOilBarrels(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Tablespoon

        /// <inheritdoc cref="Volume.FromTablespoons(double)"/>
        public static Volume Tablespoons(this int value) => Volume.FromTablespoons(value);

        /// <inheritdoc cref="Volume.FromTablespoons(double?)"/>
        public static Volume? Tablespoons(this int? value) => Volume.FromTablespoons(value);

        /// <inheritdoc cref="Volume.FromTablespoons(double)"/>
        public static Volume Tablespoons(this long value) => Volume.FromTablespoons(value);

        /// <inheritdoc cref="Volume.FromTablespoons(double?)"/>
        public static Volume? Tablespoons(this long? value) => Volume.FromTablespoons(value);

        /// <inheritdoc cref="Volume.FromTablespoons(double)"/>
        public static Volume Tablespoons(this double value) => Volume.FromTablespoons(value);

        /// <inheritdoc cref="Volume.FromTablespoons(double?)"/>
        public static Volume? Tablespoons(this double? value) => Volume.FromTablespoons(value);

        /// <inheritdoc cref="Volume.FromTablespoons(double)"/>
        public static Volume Tablespoons(this float value) => Volume.FromTablespoons(value);

        /// <inheritdoc cref="Volume.FromTablespoons(double?)"/>
        public static Volume? Tablespoons(this float? value) => Volume.FromTablespoons(value);

        /// <inheritdoc cref="Volume.FromTablespoons(double)"/>
        public static Volume Tablespoons(this decimal value) => Volume.FromTablespoons(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromTablespoons(double?)"/>
        public static Volume? Tablespoons(this decimal? value) => Volume.FromTablespoons(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Teaspoon

        /// <inheritdoc cref="Volume.FromTeaspoons(double)"/>
        public static Volume Teaspoons(this int value) => Volume.FromTeaspoons(value);

        /// <inheritdoc cref="Volume.FromTeaspoons(double?)"/>
        public static Volume? Teaspoons(this int? value) => Volume.FromTeaspoons(value);

        /// <inheritdoc cref="Volume.FromTeaspoons(double)"/>
        public static Volume Teaspoons(this long value) => Volume.FromTeaspoons(value);

        /// <inheritdoc cref="Volume.FromTeaspoons(double?)"/>
        public static Volume? Teaspoons(this long? value) => Volume.FromTeaspoons(value);

        /// <inheritdoc cref="Volume.FromTeaspoons(double)"/>
        public static Volume Teaspoons(this double value) => Volume.FromTeaspoons(value);

        /// <inheritdoc cref="Volume.FromTeaspoons(double?)"/>
        public static Volume? Teaspoons(this double? value) => Volume.FromTeaspoons(value);

        /// <inheritdoc cref="Volume.FromTeaspoons(double)"/>
        public static Volume Teaspoons(this float value) => Volume.FromTeaspoons(value);

        /// <inheritdoc cref="Volume.FromTeaspoons(double?)"/>
        public static Volume? Teaspoons(this float? value) => Volume.FromTeaspoons(value);

        /// <inheritdoc cref="Volume.FromTeaspoons(double)"/>
        public static Volume Teaspoons(this decimal value) => Volume.FromTeaspoons(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromTeaspoons(double?)"/>
        public static Volume? Teaspoons(this decimal? value) => Volume.FromTeaspoons(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region UkTablespoon

        /// <inheritdoc cref="Volume.FromUkTablespoons(double)"/>
        public static Volume UkTablespoons(this int value) => Volume.FromUkTablespoons(value);

        /// <inheritdoc cref="Volume.FromUkTablespoons(double?)"/>
        public static Volume? UkTablespoons(this int? value) => Volume.FromUkTablespoons(value);

        /// <inheritdoc cref="Volume.FromUkTablespoons(double)"/>
        public static Volume UkTablespoons(this long value) => Volume.FromUkTablespoons(value);

        /// <inheritdoc cref="Volume.FromUkTablespoons(double?)"/>
        public static Volume? UkTablespoons(this long? value) => Volume.FromUkTablespoons(value);

        /// <inheritdoc cref="Volume.FromUkTablespoons(double)"/>
        public static Volume UkTablespoons(this double value) => Volume.FromUkTablespoons(value);

        /// <inheritdoc cref="Volume.FromUkTablespoons(double?)"/>
        public static Volume? UkTablespoons(this double? value) => Volume.FromUkTablespoons(value);

        /// <inheritdoc cref="Volume.FromUkTablespoons(double)"/>
        public static Volume UkTablespoons(this float value) => Volume.FromUkTablespoons(value);

        /// <inheritdoc cref="Volume.FromUkTablespoons(double?)"/>
        public static Volume? UkTablespoons(this float? value) => Volume.FromUkTablespoons(value);

        /// <inheritdoc cref="Volume.FromUkTablespoons(double)"/>
        public static Volume UkTablespoons(this decimal value) => Volume.FromUkTablespoons(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromUkTablespoons(double?)"/>
        public static Volume? UkTablespoons(this decimal? value) => Volume.FromUkTablespoons(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region UsCustomaryCup

        /// <inheritdoc cref="Volume.FromUsCustomaryCups(double)"/>
        public static Volume UsCustomaryCups(this int value) => Volume.FromUsCustomaryCups(value);

        /// <inheritdoc cref="Volume.FromUsCustomaryCups(double?)"/>
        public static Volume? UsCustomaryCups(this int? value) => Volume.FromUsCustomaryCups(value);

        /// <inheritdoc cref="Volume.FromUsCustomaryCups(double)"/>
        public static Volume UsCustomaryCups(this long value) => Volume.FromUsCustomaryCups(value);

        /// <inheritdoc cref="Volume.FromUsCustomaryCups(double?)"/>
        public static Volume? UsCustomaryCups(this long? value) => Volume.FromUsCustomaryCups(value);

        /// <inheritdoc cref="Volume.FromUsCustomaryCups(double)"/>
        public static Volume UsCustomaryCups(this double value) => Volume.FromUsCustomaryCups(value);

        /// <inheritdoc cref="Volume.FromUsCustomaryCups(double?)"/>
        public static Volume? UsCustomaryCups(this double? value) => Volume.FromUsCustomaryCups(value);

        /// <inheritdoc cref="Volume.FromUsCustomaryCups(double)"/>
        public static Volume UsCustomaryCups(this float value) => Volume.FromUsCustomaryCups(value);

        /// <inheritdoc cref="Volume.FromUsCustomaryCups(double?)"/>
        public static Volume? UsCustomaryCups(this float? value) => Volume.FromUsCustomaryCups(value);

        /// <inheritdoc cref="Volume.FromUsCustomaryCups(double)"/>
        public static Volume UsCustomaryCups(this decimal value) => Volume.FromUsCustomaryCups(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromUsCustomaryCups(double?)"/>
        public static Volume? UsCustomaryCups(this decimal? value) => Volume.FromUsCustomaryCups(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region UsGallon

        /// <inheritdoc cref="Volume.FromUsGallons(double)"/>
        public static Volume UsGallons(this int value) => Volume.FromUsGallons(value);

        /// <inheritdoc cref="Volume.FromUsGallons(double?)"/>
        public static Volume? UsGallons(this int? value) => Volume.FromUsGallons(value);

        /// <inheritdoc cref="Volume.FromUsGallons(double)"/>
        public static Volume UsGallons(this long value) => Volume.FromUsGallons(value);

        /// <inheritdoc cref="Volume.FromUsGallons(double?)"/>
        public static Volume? UsGallons(this long? value) => Volume.FromUsGallons(value);

        /// <inheritdoc cref="Volume.FromUsGallons(double)"/>
        public static Volume UsGallons(this double value) => Volume.FromUsGallons(value);

        /// <inheritdoc cref="Volume.FromUsGallons(double?)"/>
        public static Volume? UsGallons(this double? value) => Volume.FromUsGallons(value);

        /// <inheritdoc cref="Volume.FromUsGallons(double)"/>
        public static Volume UsGallons(this float value) => Volume.FromUsGallons(value);

        /// <inheritdoc cref="Volume.FromUsGallons(double?)"/>
        public static Volume? UsGallons(this float? value) => Volume.FromUsGallons(value);

        /// <inheritdoc cref="Volume.FromUsGallons(double)"/>
        public static Volume UsGallons(this decimal value) => Volume.FromUsGallons(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromUsGallons(double?)"/>
        public static Volume? UsGallons(this decimal? value) => Volume.FromUsGallons(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region UsLegalCup

        /// <inheritdoc cref="Volume.FromUsLegalCups(double)"/>
        public static Volume UsLegalCups(this int value) => Volume.FromUsLegalCups(value);

        /// <inheritdoc cref="Volume.FromUsLegalCups(double?)"/>
        public static Volume? UsLegalCups(this int? value) => Volume.FromUsLegalCups(value);

        /// <inheritdoc cref="Volume.FromUsLegalCups(double)"/>
        public static Volume UsLegalCups(this long value) => Volume.FromUsLegalCups(value);

        /// <inheritdoc cref="Volume.FromUsLegalCups(double?)"/>
        public static Volume? UsLegalCups(this long? value) => Volume.FromUsLegalCups(value);

        /// <inheritdoc cref="Volume.FromUsLegalCups(double)"/>
        public static Volume UsLegalCups(this double value) => Volume.FromUsLegalCups(value);

        /// <inheritdoc cref="Volume.FromUsLegalCups(double?)"/>
        public static Volume? UsLegalCups(this double? value) => Volume.FromUsLegalCups(value);

        /// <inheritdoc cref="Volume.FromUsLegalCups(double)"/>
        public static Volume UsLegalCups(this float value) => Volume.FromUsLegalCups(value);

        /// <inheritdoc cref="Volume.FromUsLegalCups(double?)"/>
        public static Volume? UsLegalCups(this float? value) => Volume.FromUsLegalCups(value);

        /// <inheritdoc cref="Volume.FromUsLegalCups(double)"/>
        public static Volume UsLegalCups(this decimal value) => Volume.FromUsLegalCups(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromUsLegalCups(double?)"/>
        public static Volume? UsLegalCups(this decimal? value) => Volume.FromUsLegalCups(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region UsOunce

        /// <inheritdoc cref="Volume.FromUsOunces(double)"/>
        public static Volume UsOunces(this int value) => Volume.FromUsOunces(value);

        /// <inheritdoc cref="Volume.FromUsOunces(double?)"/>
        public static Volume? UsOunces(this int? value) => Volume.FromUsOunces(value);

        /// <inheritdoc cref="Volume.FromUsOunces(double)"/>
        public static Volume UsOunces(this long value) => Volume.FromUsOunces(value);

        /// <inheritdoc cref="Volume.FromUsOunces(double?)"/>
        public static Volume? UsOunces(this long? value) => Volume.FromUsOunces(value);

        /// <inheritdoc cref="Volume.FromUsOunces(double)"/>
        public static Volume UsOunces(this double value) => Volume.FromUsOunces(value);

        /// <inheritdoc cref="Volume.FromUsOunces(double?)"/>
        public static Volume? UsOunces(this double? value) => Volume.FromUsOunces(value);

        /// <inheritdoc cref="Volume.FromUsOunces(double)"/>
        public static Volume UsOunces(this float value) => Volume.FromUsOunces(value);

        /// <inheritdoc cref="Volume.FromUsOunces(double?)"/>
        public static Volume? UsOunces(this float? value) => Volume.FromUsOunces(value);

        /// <inheritdoc cref="Volume.FromUsOunces(double)"/>
        public static Volume UsOunces(this decimal value) => Volume.FromUsOunces(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromUsOunces(double?)"/>
        public static Volume? UsOunces(this decimal? value) => Volume.FromUsOunces(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region UsTablespoon

        /// <inheritdoc cref="Volume.FromUsTablespoons(double)"/>
        public static Volume UsTablespoons(this int value) => Volume.FromUsTablespoons(value);

        /// <inheritdoc cref="Volume.FromUsTablespoons(double?)"/>
        public static Volume? UsTablespoons(this int? value) => Volume.FromUsTablespoons(value);

        /// <inheritdoc cref="Volume.FromUsTablespoons(double)"/>
        public static Volume UsTablespoons(this long value) => Volume.FromUsTablespoons(value);

        /// <inheritdoc cref="Volume.FromUsTablespoons(double?)"/>
        public static Volume? UsTablespoons(this long? value) => Volume.FromUsTablespoons(value);

        /// <inheritdoc cref="Volume.FromUsTablespoons(double)"/>
        public static Volume UsTablespoons(this double value) => Volume.FromUsTablespoons(value);

        /// <inheritdoc cref="Volume.FromUsTablespoons(double?)"/>
        public static Volume? UsTablespoons(this double? value) => Volume.FromUsTablespoons(value);

        /// <inheritdoc cref="Volume.FromUsTablespoons(double)"/>
        public static Volume UsTablespoons(this float value) => Volume.FromUsTablespoons(value);

        /// <inheritdoc cref="Volume.FromUsTablespoons(double?)"/>
        public static Volume? UsTablespoons(this float? value) => Volume.FromUsTablespoons(value);

        /// <inheritdoc cref="Volume.FromUsTablespoons(double)"/>
        public static Volume UsTablespoons(this decimal value) => Volume.FromUsTablespoons(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromUsTablespoons(double?)"/>
        public static Volume? UsTablespoons(this decimal? value) => Volume.FromUsTablespoons(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region UsTeaspoon

        /// <inheritdoc cref="Volume.FromUsTeaspoons(double)"/>
        public static Volume UsTeaspoons(this int value) => Volume.FromUsTeaspoons(value);

        /// <inheritdoc cref="Volume.FromUsTeaspoons(double?)"/>
        public static Volume? UsTeaspoons(this int? value) => Volume.FromUsTeaspoons(value);

        /// <inheritdoc cref="Volume.FromUsTeaspoons(double)"/>
        public static Volume UsTeaspoons(this long value) => Volume.FromUsTeaspoons(value);

        /// <inheritdoc cref="Volume.FromUsTeaspoons(double?)"/>
        public static Volume? UsTeaspoons(this long? value) => Volume.FromUsTeaspoons(value);

        /// <inheritdoc cref="Volume.FromUsTeaspoons(double)"/>
        public static Volume UsTeaspoons(this double value) => Volume.FromUsTeaspoons(value);

        /// <inheritdoc cref="Volume.FromUsTeaspoons(double?)"/>
        public static Volume? UsTeaspoons(this double? value) => Volume.FromUsTeaspoons(value);

        /// <inheritdoc cref="Volume.FromUsTeaspoons(double)"/>
        public static Volume UsTeaspoons(this float value) => Volume.FromUsTeaspoons(value);

        /// <inheritdoc cref="Volume.FromUsTeaspoons(double?)"/>
        public static Volume? UsTeaspoons(this float? value) => Volume.FromUsTeaspoons(value);

        /// <inheritdoc cref="Volume.FromUsTeaspoons(double)"/>
        public static Volume UsTeaspoons(this decimal value) => Volume.FromUsTeaspoons(Convert.ToDouble(value));

        /// <inheritdoc cref="Volume.FromUsTeaspoons(double?)"/>
        public static Volume? UsTeaspoons(this decimal? value) => Volume.FromUsTeaspoons(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
