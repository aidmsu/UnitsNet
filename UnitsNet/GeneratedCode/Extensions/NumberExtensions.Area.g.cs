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
        #region Acre

        /// <inheritdoc cref="Area.FromAcres(double)"/>
        public static Area Acres(this int value) => Area.FromAcres(value);

        /// <inheritdoc cref="Area.FromAcres(double?)"/>
        public static Area? Acres(this int? value) => Area.FromAcres(value);

        /// <inheritdoc cref="Area.FromAcres(double)"/>
        public static Area Acres(this long value) => Area.FromAcres(value);

        /// <inheritdoc cref="Area.FromAcres(double?)"/>
        public static Area? Acres(this long? value) => Area.FromAcres(value);

        /// <inheritdoc cref="Area.FromAcres(double)"/>
        public static Area Acres(this double value) => Area.FromAcres(value);

        /// <inheritdoc cref="Area.FromAcres(double?)"/>
        public static Area? Acres(this double? value) => Area.FromAcres(value);

        /// <inheritdoc cref="Area.FromAcres(double)"/>
        public static Area Acres(this float value) => Area.FromAcres(value);

        /// <inheritdoc cref="Area.FromAcres(double?)"/>
        public static Area? Acres(this float? value) => Area.FromAcres(value);

        /// <inheritdoc cref="Area.FromAcres(double)"/>
        public static Area Acres(this decimal value) => Area.FromAcres(Convert.ToDouble(value));

        /// <inheritdoc cref="Area.FromAcres(double?)"/>
        public static Area? Acres(this decimal? value) => Area.FromAcres(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Hectare

        /// <inheritdoc cref="Area.FromHectares(double)"/>
        public static Area Hectares(this int value) => Area.FromHectares(value);

        /// <inheritdoc cref="Area.FromHectares(double?)"/>
        public static Area? Hectares(this int? value) => Area.FromHectares(value);

        /// <inheritdoc cref="Area.FromHectares(double)"/>
        public static Area Hectares(this long value) => Area.FromHectares(value);

        /// <inheritdoc cref="Area.FromHectares(double?)"/>
        public static Area? Hectares(this long? value) => Area.FromHectares(value);

        /// <inheritdoc cref="Area.FromHectares(double)"/>
        public static Area Hectares(this double value) => Area.FromHectares(value);

        /// <inheritdoc cref="Area.FromHectares(double?)"/>
        public static Area? Hectares(this double? value) => Area.FromHectares(value);

        /// <inheritdoc cref="Area.FromHectares(double)"/>
        public static Area Hectares(this float value) => Area.FromHectares(value);

        /// <inheritdoc cref="Area.FromHectares(double?)"/>
        public static Area? Hectares(this float? value) => Area.FromHectares(value);

        /// <inheritdoc cref="Area.FromHectares(double)"/>
        public static Area Hectares(this decimal value) => Area.FromHectares(Convert.ToDouble(value));

        /// <inheritdoc cref="Area.FromHectares(double?)"/>
        public static Area? Hectares(this decimal? value) => Area.FromHectares(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region SquareCentimeter

        /// <inheritdoc cref="Area.FromSquareCentimeters(double)"/>
        public static Area SquareCentimeters(this int value) => Area.FromSquareCentimeters(value);

        /// <inheritdoc cref="Area.FromSquareCentimeters(double?)"/>
        public static Area? SquareCentimeters(this int? value) => Area.FromSquareCentimeters(value);

        /// <inheritdoc cref="Area.FromSquareCentimeters(double)"/>
        public static Area SquareCentimeters(this long value) => Area.FromSquareCentimeters(value);

        /// <inheritdoc cref="Area.FromSquareCentimeters(double?)"/>
        public static Area? SquareCentimeters(this long? value) => Area.FromSquareCentimeters(value);

        /// <inheritdoc cref="Area.FromSquareCentimeters(double)"/>
        public static Area SquareCentimeters(this double value) => Area.FromSquareCentimeters(value);

        /// <inheritdoc cref="Area.FromSquareCentimeters(double?)"/>
        public static Area? SquareCentimeters(this double? value) => Area.FromSquareCentimeters(value);

        /// <inheritdoc cref="Area.FromSquareCentimeters(double)"/>
        public static Area SquareCentimeters(this float value) => Area.FromSquareCentimeters(value);

        /// <inheritdoc cref="Area.FromSquareCentimeters(double?)"/>
        public static Area? SquareCentimeters(this float? value) => Area.FromSquareCentimeters(value);

        /// <inheritdoc cref="Area.FromSquareCentimeters(double)"/>
        public static Area SquareCentimeters(this decimal value) => Area.FromSquareCentimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Area.FromSquareCentimeters(double?)"/>
        public static Area? SquareCentimeters(this decimal? value) => Area.FromSquareCentimeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region SquareDecimeter

        /// <inheritdoc cref="Area.FromSquareDecimeters(double)"/>
        public static Area SquareDecimeters(this int value) => Area.FromSquareDecimeters(value);

        /// <inheritdoc cref="Area.FromSquareDecimeters(double?)"/>
        public static Area? SquareDecimeters(this int? value) => Area.FromSquareDecimeters(value);

        /// <inheritdoc cref="Area.FromSquareDecimeters(double)"/>
        public static Area SquareDecimeters(this long value) => Area.FromSquareDecimeters(value);

        /// <inheritdoc cref="Area.FromSquareDecimeters(double?)"/>
        public static Area? SquareDecimeters(this long? value) => Area.FromSquareDecimeters(value);

        /// <inheritdoc cref="Area.FromSquareDecimeters(double)"/>
        public static Area SquareDecimeters(this double value) => Area.FromSquareDecimeters(value);

        /// <inheritdoc cref="Area.FromSquareDecimeters(double?)"/>
        public static Area? SquareDecimeters(this double? value) => Area.FromSquareDecimeters(value);

        /// <inheritdoc cref="Area.FromSquareDecimeters(double)"/>
        public static Area SquareDecimeters(this float value) => Area.FromSquareDecimeters(value);

        /// <inheritdoc cref="Area.FromSquareDecimeters(double?)"/>
        public static Area? SquareDecimeters(this float? value) => Area.FromSquareDecimeters(value);

        /// <inheritdoc cref="Area.FromSquareDecimeters(double)"/>
        public static Area SquareDecimeters(this decimal value) => Area.FromSquareDecimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Area.FromSquareDecimeters(double?)"/>
        public static Area? SquareDecimeters(this decimal? value) => Area.FromSquareDecimeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region SquareFoot

        /// <inheritdoc cref="Area.FromSquareFeet(double)"/>
        public static Area SquareFeet(this int value) => Area.FromSquareFeet(value);

        /// <inheritdoc cref="Area.FromSquareFeet(double?)"/>
        public static Area? SquareFeet(this int? value) => Area.FromSquareFeet(value);

        /// <inheritdoc cref="Area.FromSquareFeet(double)"/>
        public static Area SquareFeet(this long value) => Area.FromSquareFeet(value);

        /// <inheritdoc cref="Area.FromSquareFeet(double?)"/>
        public static Area? SquareFeet(this long? value) => Area.FromSquareFeet(value);

        /// <inheritdoc cref="Area.FromSquareFeet(double)"/>
        public static Area SquareFeet(this double value) => Area.FromSquareFeet(value);

        /// <inheritdoc cref="Area.FromSquareFeet(double?)"/>
        public static Area? SquareFeet(this double? value) => Area.FromSquareFeet(value);

        /// <inheritdoc cref="Area.FromSquareFeet(double)"/>
        public static Area SquareFeet(this float value) => Area.FromSquareFeet(value);

        /// <inheritdoc cref="Area.FromSquareFeet(double?)"/>
        public static Area? SquareFeet(this float? value) => Area.FromSquareFeet(value);

        /// <inheritdoc cref="Area.FromSquareFeet(double)"/>
        public static Area SquareFeet(this decimal value) => Area.FromSquareFeet(Convert.ToDouble(value));

        /// <inheritdoc cref="Area.FromSquareFeet(double?)"/>
        public static Area? SquareFeet(this decimal? value) => Area.FromSquareFeet(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region SquareInch

        /// <inheritdoc cref="Area.FromSquareInches(double)"/>
        public static Area SquareInches(this int value) => Area.FromSquareInches(value);

        /// <inheritdoc cref="Area.FromSquareInches(double?)"/>
        public static Area? SquareInches(this int? value) => Area.FromSquareInches(value);

        /// <inheritdoc cref="Area.FromSquareInches(double)"/>
        public static Area SquareInches(this long value) => Area.FromSquareInches(value);

        /// <inheritdoc cref="Area.FromSquareInches(double?)"/>
        public static Area? SquareInches(this long? value) => Area.FromSquareInches(value);

        /// <inheritdoc cref="Area.FromSquareInches(double)"/>
        public static Area SquareInches(this double value) => Area.FromSquareInches(value);

        /// <inheritdoc cref="Area.FromSquareInches(double?)"/>
        public static Area? SquareInches(this double? value) => Area.FromSquareInches(value);

        /// <inheritdoc cref="Area.FromSquareInches(double)"/>
        public static Area SquareInches(this float value) => Area.FromSquareInches(value);

        /// <inheritdoc cref="Area.FromSquareInches(double?)"/>
        public static Area? SquareInches(this float? value) => Area.FromSquareInches(value);

        /// <inheritdoc cref="Area.FromSquareInches(double)"/>
        public static Area SquareInches(this decimal value) => Area.FromSquareInches(Convert.ToDouble(value));

        /// <inheritdoc cref="Area.FromSquareInches(double?)"/>
        public static Area? SquareInches(this decimal? value) => Area.FromSquareInches(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region SquareKilometer

        /// <inheritdoc cref="Area.FromSquareKilometers(double)"/>
        public static Area SquareKilometers(this int value) => Area.FromSquareKilometers(value);

        /// <inheritdoc cref="Area.FromSquareKilometers(double?)"/>
        public static Area? SquareKilometers(this int? value) => Area.FromSquareKilometers(value);

        /// <inheritdoc cref="Area.FromSquareKilometers(double)"/>
        public static Area SquareKilometers(this long value) => Area.FromSquareKilometers(value);

        /// <inheritdoc cref="Area.FromSquareKilometers(double?)"/>
        public static Area? SquareKilometers(this long? value) => Area.FromSquareKilometers(value);

        /// <inheritdoc cref="Area.FromSquareKilometers(double)"/>
        public static Area SquareKilometers(this double value) => Area.FromSquareKilometers(value);

        /// <inheritdoc cref="Area.FromSquareKilometers(double?)"/>
        public static Area? SquareKilometers(this double? value) => Area.FromSquareKilometers(value);

        /// <inheritdoc cref="Area.FromSquareKilometers(double)"/>
        public static Area SquareKilometers(this float value) => Area.FromSquareKilometers(value);

        /// <inheritdoc cref="Area.FromSquareKilometers(double?)"/>
        public static Area? SquareKilometers(this float? value) => Area.FromSquareKilometers(value);

        /// <inheritdoc cref="Area.FromSquareKilometers(double)"/>
        public static Area SquareKilometers(this decimal value) => Area.FromSquareKilometers(Convert.ToDouble(value));

        /// <inheritdoc cref="Area.FromSquareKilometers(double?)"/>
        public static Area? SquareKilometers(this decimal? value) => Area.FromSquareKilometers(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region SquareMeter

        /// <inheritdoc cref="Area.FromSquareMeters(double)"/>
        public static Area SquareMeters(this int value) => Area.FromSquareMeters(value);

        /// <inheritdoc cref="Area.FromSquareMeters(double?)"/>
        public static Area? SquareMeters(this int? value) => Area.FromSquareMeters(value);

        /// <inheritdoc cref="Area.FromSquareMeters(double)"/>
        public static Area SquareMeters(this long value) => Area.FromSquareMeters(value);

        /// <inheritdoc cref="Area.FromSquareMeters(double?)"/>
        public static Area? SquareMeters(this long? value) => Area.FromSquareMeters(value);

        /// <inheritdoc cref="Area.FromSquareMeters(double)"/>
        public static Area SquareMeters(this double value) => Area.FromSquareMeters(value);

        /// <inheritdoc cref="Area.FromSquareMeters(double?)"/>
        public static Area? SquareMeters(this double? value) => Area.FromSquareMeters(value);

        /// <inheritdoc cref="Area.FromSquareMeters(double)"/>
        public static Area SquareMeters(this float value) => Area.FromSquareMeters(value);

        /// <inheritdoc cref="Area.FromSquareMeters(double?)"/>
        public static Area? SquareMeters(this float? value) => Area.FromSquareMeters(value);

        /// <inheritdoc cref="Area.FromSquareMeters(double)"/>
        public static Area SquareMeters(this decimal value) => Area.FromSquareMeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Area.FromSquareMeters(double?)"/>
        public static Area? SquareMeters(this decimal? value) => Area.FromSquareMeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region SquareMicrometer

        /// <inheritdoc cref="Area.FromSquareMicrometers(double)"/>
        public static Area SquareMicrometers(this int value) => Area.FromSquareMicrometers(value);

        /// <inheritdoc cref="Area.FromSquareMicrometers(double?)"/>
        public static Area? SquareMicrometers(this int? value) => Area.FromSquareMicrometers(value);

        /// <inheritdoc cref="Area.FromSquareMicrometers(double)"/>
        public static Area SquareMicrometers(this long value) => Area.FromSquareMicrometers(value);

        /// <inheritdoc cref="Area.FromSquareMicrometers(double?)"/>
        public static Area? SquareMicrometers(this long? value) => Area.FromSquareMicrometers(value);

        /// <inheritdoc cref="Area.FromSquareMicrometers(double)"/>
        public static Area SquareMicrometers(this double value) => Area.FromSquareMicrometers(value);

        /// <inheritdoc cref="Area.FromSquareMicrometers(double?)"/>
        public static Area? SquareMicrometers(this double? value) => Area.FromSquareMicrometers(value);

        /// <inheritdoc cref="Area.FromSquareMicrometers(double)"/>
        public static Area SquareMicrometers(this float value) => Area.FromSquareMicrometers(value);

        /// <inheritdoc cref="Area.FromSquareMicrometers(double?)"/>
        public static Area? SquareMicrometers(this float? value) => Area.FromSquareMicrometers(value);

        /// <inheritdoc cref="Area.FromSquareMicrometers(double)"/>
        public static Area SquareMicrometers(this decimal value) => Area.FromSquareMicrometers(Convert.ToDouble(value));

        /// <inheritdoc cref="Area.FromSquareMicrometers(double?)"/>
        public static Area? SquareMicrometers(this decimal? value) => Area.FromSquareMicrometers(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region SquareMile

        /// <inheritdoc cref="Area.FromSquareMiles(double)"/>
        public static Area SquareMiles(this int value) => Area.FromSquareMiles(value);

        /// <inheritdoc cref="Area.FromSquareMiles(double?)"/>
        public static Area? SquareMiles(this int? value) => Area.FromSquareMiles(value);

        /// <inheritdoc cref="Area.FromSquareMiles(double)"/>
        public static Area SquareMiles(this long value) => Area.FromSquareMiles(value);

        /// <inheritdoc cref="Area.FromSquareMiles(double?)"/>
        public static Area? SquareMiles(this long? value) => Area.FromSquareMiles(value);

        /// <inheritdoc cref="Area.FromSquareMiles(double)"/>
        public static Area SquareMiles(this double value) => Area.FromSquareMiles(value);

        /// <inheritdoc cref="Area.FromSquareMiles(double?)"/>
        public static Area? SquareMiles(this double? value) => Area.FromSquareMiles(value);

        /// <inheritdoc cref="Area.FromSquareMiles(double)"/>
        public static Area SquareMiles(this float value) => Area.FromSquareMiles(value);

        /// <inheritdoc cref="Area.FromSquareMiles(double?)"/>
        public static Area? SquareMiles(this float? value) => Area.FromSquareMiles(value);

        /// <inheritdoc cref="Area.FromSquareMiles(double)"/>
        public static Area SquareMiles(this decimal value) => Area.FromSquareMiles(Convert.ToDouble(value));

        /// <inheritdoc cref="Area.FromSquareMiles(double?)"/>
        public static Area? SquareMiles(this decimal? value) => Area.FromSquareMiles(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region SquareMillimeter

        /// <inheritdoc cref="Area.FromSquareMillimeters(double)"/>
        public static Area SquareMillimeters(this int value) => Area.FromSquareMillimeters(value);

        /// <inheritdoc cref="Area.FromSquareMillimeters(double?)"/>
        public static Area? SquareMillimeters(this int? value) => Area.FromSquareMillimeters(value);

        /// <inheritdoc cref="Area.FromSquareMillimeters(double)"/>
        public static Area SquareMillimeters(this long value) => Area.FromSquareMillimeters(value);

        /// <inheritdoc cref="Area.FromSquareMillimeters(double?)"/>
        public static Area? SquareMillimeters(this long? value) => Area.FromSquareMillimeters(value);

        /// <inheritdoc cref="Area.FromSquareMillimeters(double)"/>
        public static Area SquareMillimeters(this double value) => Area.FromSquareMillimeters(value);

        /// <inheritdoc cref="Area.FromSquareMillimeters(double?)"/>
        public static Area? SquareMillimeters(this double? value) => Area.FromSquareMillimeters(value);

        /// <inheritdoc cref="Area.FromSquareMillimeters(double)"/>
        public static Area SquareMillimeters(this float value) => Area.FromSquareMillimeters(value);

        /// <inheritdoc cref="Area.FromSquareMillimeters(double?)"/>
        public static Area? SquareMillimeters(this float? value) => Area.FromSquareMillimeters(value);

        /// <inheritdoc cref="Area.FromSquareMillimeters(double)"/>
        public static Area SquareMillimeters(this decimal value) => Area.FromSquareMillimeters(Convert.ToDouble(value));

        /// <inheritdoc cref="Area.FromSquareMillimeters(double?)"/>
        public static Area? SquareMillimeters(this decimal? value) => Area.FromSquareMillimeters(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region SquareYard

        /// <inheritdoc cref="Area.FromSquareYards(double)"/>
        public static Area SquareYards(this int value) => Area.FromSquareYards(value);

        /// <inheritdoc cref="Area.FromSquareYards(double?)"/>
        public static Area? SquareYards(this int? value) => Area.FromSquareYards(value);

        /// <inheritdoc cref="Area.FromSquareYards(double)"/>
        public static Area SquareYards(this long value) => Area.FromSquareYards(value);

        /// <inheritdoc cref="Area.FromSquareYards(double?)"/>
        public static Area? SquareYards(this long? value) => Area.FromSquareYards(value);

        /// <inheritdoc cref="Area.FromSquareYards(double)"/>
        public static Area SquareYards(this double value) => Area.FromSquareYards(value);

        /// <inheritdoc cref="Area.FromSquareYards(double?)"/>
        public static Area? SquareYards(this double? value) => Area.FromSquareYards(value);

        /// <inheritdoc cref="Area.FromSquareYards(double)"/>
        public static Area SquareYards(this float value) => Area.FromSquareYards(value);

        /// <inheritdoc cref="Area.FromSquareYards(double?)"/>
        public static Area? SquareYards(this float? value) => Area.FromSquareYards(value);

        /// <inheritdoc cref="Area.FromSquareYards(double)"/>
        public static Area SquareYards(this decimal value) => Area.FromSquareYards(Convert.ToDouble(value));

        /// <inheritdoc cref="Area.FromSquareYards(double?)"/>
        public static Area? SquareYards(this decimal? value) => Area.FromSquareYards(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
