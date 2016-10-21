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
        #region Atmosphere

        /// <inheritdoc cref="Pressure.FromAtmospheres(double)"/>
        public static Pressure Atmospheres(this int value) => Pressure.FromAtmospheres(value);

        /// <inheritdoc cref="Pressure.FromAtmospheres(double?)"/>
        public static Pressure? Atmospheres(this int? value) => Pressure.FromAtmospheres(value);

        /// <inheritdoc cref="Pressure.FromAtmospheres(double)"/>
        public static Pressure Atmospheres(this long value) => Pressure.FromAtmospheres(value);

        /// <inheritdoc cref="Pressure.FromAtmospheres(double?)"/>
        public static Pressure? Atmospheres(this long? value) => Pressure.FromAtmospheres(value);

        /// <inheritdoc cref="Pressure.FromAtmospheres(double)"/>
        public static Pressure Atmospheres(this double value) => Pressure.FromAtmospheres(value);

        /// <inheritdoc cref="Pressure.FromAtmospheres(double?)"/>
        public static Pressure? Atmospheres(this double? value) => Pressure.FromAtmospheres(value);

        /// <inheritdoc cref="Pressure.FromAtmospheres(double)"/>
        public static Pressure Atmospheres(this float value) => Pressure.FromAtmospheres(value);

        /// <inheritdoc cref="Pressure.FromAtmospheres(double?)"/>
        public static Pressure? Atmospheres(this float? value) => Pressure.FromAtmospheres(value);

        /// <inheritdoc cref="Pressure.FromAtmospheres(double)"/>
        public static Pressure Atmospheres(this decimal value) => Pressure.FromAtmospheres(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromAtmospheres(double?)"/>
        public static Pressure? Atmospheres(this decimal? value) => Pressure.FromAtmospheres(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Bar

        /// <inheritdoc cref="Pressure.FromBars(double)"/>
        public static Pressure Bars(this int value) => Pressure.FromBars(value);

        /// <inheritdoc cref="Pressure.FromBars(double?)"/>
        public static Pressure? Bars(this int? value) => Pressure.FromBars(value);

        /// <inheritdoc cref="Pressure.FromBars(double)"/>
        public static Pressure Bars(this long value) => Pressure.FromBars(value);

        /// <inheritdoc cref="Pressure.FromBars(double?)"/>
        public static Pressure? Bars(this long? value) => Pressure.FromBars(value);

        /// <inheritdoc cref="Pressure.FromBars(double)"/>
        public static Pressure Bars(this double value) => Pressure.FromBars(value);

        /// <inheritdoc cref="Pressure.FromBars(double?)"/>
        public static Pressure? Bars(this double? value) => Pressure.FromBars(value);

        /// <inheritdoc cref="Pressure.FromBars(double)"/>
        public static Pressure Bars(this float value) => Pressure.FromBars(value);

        /// <inheritdoc cref="Pressure.FromBars(double?)"/>
        public static Pressure? Bars(this float? value) => Pressure.FromBars(value);

        /// <inheritdoc cref="Pressure.FromBars(double)"/>
        public static Pressure Bars(this decimal value) => Pressure.FromBars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromBars(double?)"/>
        public static Pressure? Bars(this decimal? value) => Pressure.FromBars(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Centibar

        /// <inheritdoc cref="Pressure.FromCentibars(double)"/>
        public static Pressure Centibars(this int value) => Pressure.FromCentibars(value);

        /// <inheritdoc cref="Pressure.FromCentibars(double?)"/>
        public static Pressure? Centibars(this int? value) => Pressure.FromCentibars(value);

        /// <inheritdoc cref="Pressure.FromCentibars(double)"/>
        public static Pressure Centibars(this long value) => Pressure.FromCentibars(value);

        /// <inheritdoc cref="Pressure.FromCentibars(double?)"/>
        public static Pressure? Centibars(this long? value) => Pressure.FromCentibars(value);

        /// <inheritdoc cref="Pressure.FromCentibars(double)"/>
        public static Pressure Centibars(this double value) => Pressure.FromCentibars(value);

        /// <inheritdoc cref="Pressure.FromCentibars(double?)"/>
        public static Pressure? Centibars(this double? value) => Pressure.FromCentibars(value);

        /// <inheritdoc cref="Pressure.FromCentibars(double)"/>
        public static Pressure Centibars(this float value) => Pressure.FromCentibars(value);

        /// <inheritdoc cref="Pressure.FromCentibars(double?)"/>
        public static Pressure? Centibars(this float? value) => Pressure.FromCentibars(value);

        /// <inheritdoc cref="Pressure.FromCentibars(double)"/>
        public static Pressure Centibars(this decimal value) => Pressure.FromCentibars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromCentibars(double?)"/>
        public static Pressure? Centibars(this decimal? value) => Pressure.FromCentibars(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Decapascal

        /// <inheritdoc cref="Pressure.FromDecapascals(double)"/>
        public static Pressure Decapascals(this int value) => Pressure.FromDecapascals(value);

        /// <inheritdoc cref="Pressure.FromDecapascals(double?)"/>
        public static Pressure? Decapascals(this int? value) => Pressure.FromDecapascals(value);

        /// <inheritdoc cref="Pressure.FromDecapascals(double)"/>
        public static Pressure Decapascals(this long value) => Pressure.FromDecapascals(value);

        /// <inheritdoc cref="Pressure.FromDecapascals(double?)"/>
        public static Pressure? Decapascals(this long? value) => Pressure.FromDecapascals(value);

        /// <inheritdoc cref="Pressure.FromDecapascals(double)"/>
        public static Pressure Decapascals(this double value) => Pressure.FromDecapascals(value);

        /// <inheritdoc cref="Pressure.FromDecapascals(double?)"/>
        public static Pressure? Decapascals(this double? value) => Pressure.FromDecapascals(value);

        /// <inheritdoc cref="Pressure.FromDecapascals(double)"/>
        public static Pressure Decapascals(this float value) => Pressure.FromDecapascals(value);

        /// <inheritdoc cref="Pressure.FromDecapascals(double?)"/>
        public static Pressure? Decapascals(this float? value) => Pressure.FromDecapascals(value);

        /// <inheritdoc cref="Pressure.FromDecapascals(double)"/>
        public static Pressure Decapascals(this decimal value) => Pressure.FromDecapascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromDecapascals(double?)"/>
        public static Pressure? Decapascals(this decimal? value) => Pressure.FromDecapascals(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Decibar

        /// <inheritdoc cref="Pressure.FromDecibars(double)"/>
        public static Pressure Decibars(this int value) => Pressure.FromDecibars(value);

        /// <inheritdoc cref="Pressure.FromDecibars(double?)"/>
        public static Pressure? Decibars(this int? value) => Pressure.FromDecibars(value);

        /// <inheritdoc cref="Pressure.FromDecibars(double)"/>
        public static Pressure Decibars(this long value) => Pressure.FromDecibars(value);

        /// <inheritdoc cref="Pressure.FromDecibars(double?)"/>
        public static Pressure? Decibars(this long? value) => Pressure.FromDecibars(value);

        /// <inheritdoc cref="Pressure.FromDecibars(double)"/>
        public static Pressure Decibars(this double value) => Pressure.FromDecibars(value);

        /// <inheritdoc cref="Pressure.FromDecibars(double?)"/>
        public static Pressure? Decibars(this double? value) => Pressure.FromDecibars(value);

        /// <inheritdoc cref="Pressure.FromDecibars(double)"/>
        public static Pressure Decibars(this float value) => Pressure.FromDecibars(value);

        /// <inheritdoc cref="Pressure.FromDecibars(double?)"/>
        public static Pressure? Decibars(this float? value) => Pressure.FromDecibars(value);

        /// <inheritdoc cref="Pressure.FromDecibars(double)"/>
        public static Pressure Decibars(this decimal value) => Pressure.FromDecibars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromDecibars(double?)"/>
        public static Pressure? Decibars(this decimal? value) => Pressure.FromDecibars(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Gigapascal

        /// <inheritdoc cref="Pressure.FromGigapascals(double)"/>
        public static Pressure Gigapascals(this int value) => Pressure.FromGigapascals(value);

        /// <inheritdoc cref="Pressure.FromGigapascals(double?)"/>
        public static Pressure? Gigapascals(this int? value) => Pressure.FromGigapascals(value);

        /// <inheritdoc cref="Pressure.FromGigapascals(double)"/>
        public static Pressure Gigapascals(this long value) => Pressure.FromGigapascals(value);

        /// <inheritdoc cref="Pressure.FromGigapascals(double?)"/>
        public static Pressure? Gigapascals(this long? value) => Pressure.FromGigapascals(value);

        /// <inheritdoc cref="Pressure.FromGigapascals(double)"/>
        public static Pressure Gigapascals(this double value) => Pressure.FromGigapascals(value);

        /// <inheritdoc cref="Pressure.FromGigapascals(double?)"/>
        public static Pressure? Gigapascals(this double? value) => Pressure.FromGigapascals(value);

        /// <inheritdoc cref="Pressure.FromGigapascals(double)"/>
        public static Pressure Gigapascals(this float value) => Pressure.FromGigapascals(value);

        /// <inheritdoc cref="Pressure.FromGigapascals(double?)"/>
        public static Pressure? Gigapascals(this float? value) => Pressure.FromGigapascals(value);

        /// <inheritdoc cref="Pressure.FromGigapascals(double)"/>
        public static Pressure Gigapascals(this decimal value) => Pressure.FromGigapascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromGigapascals(double?)"/>
        public static Pressure? Gigapascals(this decimal? value) => Pressure.FromGigapascals(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Hectopascal

        /// <inheritdoc cref="Pressure.FromHectopascals(double)"/>
        public static Pressure Hectopascals(this int value) => Pressure.FromHectopascals(value);

        /// <inheritdoc cref="Pressure.FromHectopascals(double?)"/>
        public static Pressure? Hectopascals(this int? value) => Pressure.FromHectopascals(value);

        /// <inheritdoc cref="Pressure.FromHectopascals(double)"/>
        public static Pressure Hectopascals(this long value) => Pressure.FromHectopascals(value);

        /// <inheritdoc cref="Pressure.FromHectopascals(double?)"/>
        public static Pressure? Hectopascals(this long? value) => Pressure.FromHectopascals(value);

        /// <inheritdoc cref="Pressure.FromHectopascals(double)"/>
        public static Pressure Hectopascals(this double value) => Pressure.FromHectopascals(value);

        /// <inheritdoc cref="Pressure.FromHectopascals(double?)"/>
        public static Pressure? Hectopascals(this double? value) => Pressure.FromHectopascals(value);

        /// <inheritdoc cref="Pressure.FromHectopascals(double)"/>
        public static Pressure Hectopascals(this float value) => Pressure.FromHectopascals(value);

        /// <inheritdoc cref="Pressure.FromHectopascals(double?)"/>
        public static Pressure? Hectopascals(this float? value) => Pressure.FromHectopascals(value);

        /// <inheritdoc cref="Pressure.FromHectopascals(double)"/>
        public static Pressure Hectopascals(this decimal value) => Pressure.FromHectopascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromHectopascals(double?)"/>
        public static Pressure? Hectopascals(this decimal? value) => Pressure.FromHectopascals(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kilobar

        /// <inheritdoc cref="Pressure.FromKilobars(double)"/>
        public static Pressure Kilobars(this int value) => Pressure.FromKilobars(value);

        /// <inheritdoc cref="Pressure.FromKilobars(double?)"/>
        public static Pressure? Kilobars(this int? value) => Pressure.FromKilobars(value);

        /// <inheritdoc cref="Pressure.FromKilobars(double)"/>
        public static Pressure Kilobars(this long value) => Pressure.FromKilobars(value);

        /// <inheritdoc cref="Pressure.FromKilobars(double?)"/>
        public static Pressure? Kilobars(this long? value) => Pressure.FromKilobars(value);

        /// <inheritdoc cref="Pressure.FromKilobars(double)"/>
        public static Pressure Kilobars(this double value) => Pressure.FromKilobars(value);

        /// <inheritdoc cref="Pressure.FromKilobars(double?)"/>
        public static Pressure? Kilobars(this double? value) => Pressure.FromKilobars(value);

        /// <inheritdoc cref="Pressure.FromKilobars(double)"/>
        public static Pressure Kilobars(this float value) => Pressure.FromKilobars(value);

        /// <inheritdoc cref="Pressure.FromKilobars(double?)"/>
        public static Pressure? Kilobars(this float? value) => Pressure.FromKilobars(value);

        /// <inheritdoc cref="Pressure.FromKilobars(double)"/>
        public static Pressure Kilobars(this decimal value) => Pressure.FromKilobars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilobars(double?)"/>
        public static Pressure? Kilobars(this decimal? value) => Pressure.FromKilobars(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramForcePerSquareCentimeter

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareCentimeter(double)"/>
        public static Pressure KilogramsForcePerSquareCentimeter(this int value) => Pressure.FromKilogramsForcePerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareCentimeter(double?)"/>
        public static Pressure? KilogramsForcePerSquareCentimeter(this int? value) => Pressure.FromKilogramsForcePerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareCentimeter(double)"/>
        public static Pressure KilogramsForcePerSquareCentimeter(this long value) => Pressure.FromKilogramsForcePerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareCentimeter(double?)"/>
        public static Pressure? KilogramsForcePerSquareCentimeter(this long? value) => Pressure.FromKilogramsForcePerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareCentimeter(double)"/>
        public static Pressure KilogramsForcePerSquareCentimeter(this double value) => Pressure.FromKilogramsForcePerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareCentimeter(double?)"/>
        public static Pressure? KilogramsForcePerSquareCentimeter(this double? value) => Pressure.FromKilogramsForcePerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareCentimeter(double)"/>
        public static Pressure KilogramsForcePerSquareCentimeter(this float value) => Pressure.FromKilogramsForcePerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareCentimeter(double?)"/>
        public static Pressure? KilogramsForcePerSquareCentimeter(this float? value) => Pressure.FromKilogramsForcePerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareCentimeter(double)"/>
        public static Pressure KilogramsForcePerSquareCentimeter(this decimal value) => Pressure.FromKilogramsForcePerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareCentimeter(double?)"/>
        public static Pressure? KilogramsForcePerSquareCentimeter(this decimal? value) => Pressure.FromKilogramsForcePerSquareCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramForcePerSquareMeter

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMeter(double)"/>
        public static Pressure KilogramsForcePerSquareMeter(this int value) => Pressure.FromKilogramsForcePerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMeter(double?)"/>
        public static Pressure? KilogramsForcePerSquareMeter(this int? value) => Pressure.FromKilogramsForcePerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMeter(double)"/>
        public static Pressure KilogramsForcePerSquareMeter(this long value) => Pressure.FromKilogramsForcePerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMeter(double?)"/>
        public static Pressure? KilogramsForcePerSquareMeter(this long? value) => Pressure.FromKilogramsForcePerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMeter(double)"/>
        public static Pressure KilogramsForcePerSquareMeter(this double value) => Pressure.FromKilogramsForcePerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMeter(double?)"/>
        public static Pressure? KilogramsForcePerSquareMeter(this double? value) => Pressure.FromKilogramsForcePerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMeter(double)"/>
        public static Pressure KilogramsForcePerSquareMeter(this float value) => Pressure.FromKilogramsForcePerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMeter(double?)"/>
        public static Pressure? KilogramsForcePerSquareMeter(this float? value) => Pressure.FromKilogramsForcePerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMeter(double)"/>
        public static Pressure KilogramsForcePerSquareMeter(this decimal value) => Pressure.FromKilogramsForcePerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMeter(double?)"/>
        public static Pressure? KilogramsForcePerSquareMeter(this decimal? value) => Pressure.FromKilogramsForcePerSquareMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilogramForcePerSquareMillimeter

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMillimeter(double)"/>
        public static Pressure KilogramsForcePerSquareMillimeter(this int value) => Pressure.FromKilogramsForcePerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMillimeter(double?)"/>
        public static Pressure? KilogramsForcePerSquareMillimeter(this int? value) => Pressure.FromKilogramsForcePerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMillimeter(double)"/>
        public static Pressure KilogramsForcePerSquareMillimeter(this long value) => Pressure.FromKilogramsForcePerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMillimeter(double?)"/>
        public static Pressure? KilogramsForcePerSquareMillimeter(this long? value) => Pressure.FromKilogramsForcePerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMillimeter(double)"/>
        public static Pressure KilogramsForcePerSquareMillimeter(this double value) => Pressure.FromKilogramsForcePerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMillimeter(double?)"/>
        public static Pressure? KilogramsForcePerSquareMillimeter(this double? value) => Pressure.FromKilogramsForcePerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMillimeter(double)"/>
        public static Pressure KilogramsForcePerSquareMillimeter(this float value) => Pressure.FromKilogramsForcePerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMillimeter(double?)"/>
        public static Pressure? KilogramsForcePerSquareMillimeter(this float? value) => Pressure.FromKilogramsForcePerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMillimeter(double)"/>
        public static Pressure KilogramsForcePerSquareMillimeter(this decimal value) => Pressure.FromKilogramsForcePerSquareMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilogramsForcePerSquareMillimeter(double?)"/>
        public static Pressure? KilogramsForcePerSquareMillimeter(this decimal? value) => Pressure.FromKilogramsForcePerSquareMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilonewtonPerSquareCentimeter

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareCentimeter(double)"/>
        public static Pressure KilonewtonsPerSquareCentimeter(this int value) => Pressure.FromKilonewtonsPerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareCentimeter(double?)"/>
        public static Pressure? KilonewtonsPerSquareCentimeter(this int? value) => Pressure.FromKilonewtonsPerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareCentimeter(double)"/>
        public static Pressure KilonewtonsPerSquareCentimeter(this long value) => Pressure.FromKilonewtonsPerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareCentimeter(double?)"/>
        public static Pressure? KilonewtonsPerSquareCentimeter(this long? value) => Pressure.FromKilonewtonsPerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareCentimeter(double)"/>
        public static Pressure KilonewtonsPerSquareCentimeter(this double value) => Pressure.FromKilonewtonsPerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareCentimeter(double?)"/>
        public static Pressure? KilonewtonsPerSquareCentimeter(this double? value) => Pressure.FromKilonewtonsPerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareCentimeter(double)"/>
        public static Pressure KilonewtonsPerSquareCentimeter(this float value) => Pressure.FromKilonewtonsPerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareCentimeter(double?)"/>
        public static Pressure? KilonewtonsPerSquareCentimeter(this float? value) => Pressure.FromKilonewtonsPerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareCentimeter(double)"/>
        public static Pressure KilonewtonsPerSquareCentimeter(this decimal value) => Pressure.FromKilonewtonsPerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareCentimeter(double?)"/>
        public static Pressure? KilonewtonsPerSquareCentimeter(this decimal? value) => Pressure.FromKilonewtonsPerSquareCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilonewtonPerSquareMeter

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMeter(double)"/>
        public static Pressure KilonewtonsPerSquareMeter(this int value) => Pressure.FromKilonewtonsPerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMeter(double?)"/>
        public static Pressure? KilonewtonsPerSquareMeter(this int? value) => Pressure.FromKilonewtonsPerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMeter(double)"/>
        public static Pressure KilonewtonsPerSquareMeter(this long value) => Pressure.FromKilonewtonsPerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMeter(double?)"/>
        public static Pressure? KilonewtonsPerSquareMeter(this long? value) => Pressure.FromKilonewtonsPerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMeter(double)"/>
        public static Pressure KilonewtonsPerSquareMeter(this double value) => Pressure.FromKilonewtonsPerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMeter(double?)"/>
        public static Pressure? KilonewtonsPerSquareMeter(this double? value) => Pressure.FromKilonewtonsPerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMeter(double)"/>
        public static Pressure KilonewtonsPerSquareMeter(this float value) => Pressure.FromKilonewtonsPerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMeter(double?)"/>
        public static Pressure? KilonewtonsPerSquareMeter(this float? value) => Pressure.FromKilonewtonsPerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMeter(double)"/>
        public static Pressure KilonewtonsPerSquareMeter(this decimal value) => Pressure.FromKilonewtonsPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMeter(double?)"/>
        public static Pressure? KilonewtonsPerSquareMeter(this decimal? value) => Pressure.FromKilonewtonsPerSquareMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilonewtonPerSquareMillimeter

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMillimeter(double)"/>
        public static Pressure KilonewtonsPerSquareMillimeter(this int value) => Pressure.FromKilonewtonsPerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMillimeter(double?)"/>
        public static Pressure? KilonewtonsPerSquareMillimeter(this int? value) => Pressure.FromKilonewtonsPerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMillimeter(double)"/>
        public static Pressure KilonewtonsPerSquareMillimeter(this long value) => Pressure.FromKilonewtonsPerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMillimeter(double?)"/>
        public static Pressure? KilonewtonsPerSquareMillimeter(this long? value) => Pressure.FromKilonewtonsPerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMillimeter(double)"/>
        public static Pressure KilonewtonsPerSquareMillimeter(this double value) => Pressure.FromKilonewtonsPerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMillimeter(double?)"/>
        public static Pressure? KilonewtonsPerSquareMillimeter(this double? value) => Pressure.FromKilonewtonsPerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMillimeter(double)"/>
        public static Pressure KilonewtonsPerSquareMillimeter(this float value) => Pressure.FromKilonewtonsPerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMillimeter(double?)"/>
        public static Pressure? KilonewtonsPerSquareMillimeter(this float? value) => Pressure.FromKilonewtonsPerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMillimeter(double)"/>
        public static Pressure KilonewtonsPerSquareMillimeter(this decimal value) => Pressure.FromKilonewtonsPerSquareMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilonewtonsPerSquareMillimeter(double?)"/>
        public static Pressure? KilonewtonsPerSquareMillimeter(this decimal? value) => Pressure.FromKilonewtonsPerSquareMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kilopascal

        /// <inheritdoc cref="Pressure.FromKilopascals(double)"/>
        public static Pressure Kilopascals(this int value) => Pressure.FromKilopascals(value);

        /// <inheritdoc cref="Pressure.FromKilopascals(double?)"/>
        public static Pressure? Kilopascals(this int? value) => Pressure.FromKilopascals(value);

        /// <inheritdoc cref="Pressure.FromKilopascals(double)"/>
        public static Pressure Kilopascals(this long value) => Pressure.FromKilopascals(value);

        /// <inheritdoc cref="Pressure.FromKilopascals(double?)"/>
        public static Pressure? Kilopascals(this long? value) => Pressure.FromKilopascals(value);

        /// <inheritdoc cref="Pressure.FromKilopascals(double)"/>
        public static Pressure Kilopascals(this double value) => Pressure.FromKilopascals(value);

        /// <inheritdoc cref="Pressure.FromKilopascals(double?)"/>
        public static Pressure? Kilopascals(this double? value) => Pressure.FromKilopascals(value);

        /// <inheritdoc cref="Pressure.FromKilopascals(double)"/>
        public static Pressure Kilopascals(this float value) => Pressure.FromKilopascals(value);

        /// <inheritdoc cref="Pressure.FromKilopascals(double?)"/>
        public static Pressure? Kilopascals(this float? value) => Pressure.FromKilopascals(value);

        /// <inheritdoc cref="Pressure.FromKilopascals(double)"/>
        public static Pressure Kilopascals(this decimal value) => Pressure.FromKilopascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilopascals(double?)"/>
        public static Pressure? Kilopascals(this decimal? value) => Pressure.FromKilopascals(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilopoundForcePerSquareFoot

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareFoot(double)"/>
        public static Pressure KilopoundsForcePerSquareFoot(this int value) => Pressure.FromKilopoundsForcePerSquareFoot(value);

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareFoot(double?)"/>
        public static Pressure? KilopoundsForcePerSquareFoot(this int? value) => Pressure.FromKilopoundsForcePerSquareFoot(value);

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareFoot(double)"/>
        public static Pressure KilopoundsForcePerSquareFoot(this long value) => Pressure.FromKilopoundsForcePerSquareFoot(value);

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareFoot(double?)"/>
        public static Pressure? KilopoundsForcePerSquareFoot(this long? value) => Pressure.FromKilopoundsForcePerSquareFoot(value);

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareFoot(double)"/>
        public static Pressure KilopoundsForcePerSquareFoot(this double value) => Pressure.FromKilopoundsForcePerSquareFoot(value);

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareFoot(double?)"/>
        public static Pressure? KilopoundsForcePerSquareFoot(this double? value) => Pressure.FromKilopoundsForcePerSquareFoot(value);

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareFoot(double)"/>
        public static Pressure KilopoundsForcePerSquareFoot(this float value) => Pressure.FromKilopoundsForcePerSquareFoot(value);

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareFoot(double?)"/>
        public static Pressure? KilopoundsForcePerSquareFoot(this float? value) => Pressure.FromKilopoundsForcePerSquareFoot(value);

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareFoot(double)"/>
        public static Pressure KilopoundsForcePerSquareFoot(this decimal value) => Pressure.FromKilopoundsForcePerSquareFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareFoot(double?)"/>
        public static Pressure? KilopoundsForcePerSquareFoot(this decimal? value) => Pressure.FromKilopoundsForcePerSquareFoot(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilopoundForcePerSquareInch

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareInch(double)"/>
        public static Pressure KilopoundsForcePerSquareInch(this int value) => Pressure.FromKilopoundsForcePerSquareInch(value);

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareInch(double?)"/>
        public static Pressure? KilopoundsForcePerSquareInch(this int? value) => Pressure.FromKilopoundsForcePerSquareInch(value);

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareInch(double)"/>
        public static Pressure KilopoundsForcePerSquareInch(this long value) => Pressure.FromKilopoundsForcePerSquareInch(value);

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareInch(double?)"/>
        public static Pressure? KilopoundsForcePerSquareInch(this long? value) => Pressure.FromKilopoundsForcePerSquareInch(value);

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareInch(double)"/>
        public static Pressure KilopoundsForcePerSquareInch(this double value) => Pressure.FromKilopoundsForcePerSquareInch(value);

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareInch(double?)"/>
        public static Pressure? KilopoundsForcePerSquareInch(this double? value) => Pressure.FromKilopoundsForcePerSquareInch(value);

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareInch(double)"/>
        public static Pressure KilopoundsForcePerSquareInch(this float value) => Pressure.FromKilopoundsForcePerSquareInch(value);

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareInch(double?)"/>
        public static Pressure? KilopoundsForcePerSquareInch(this float? value) => Pressure.FromKilopoundsForcePerSquareInch(value);

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareInch(double)"/>
        public static Pressure KilopoundsForcePerSquareInch(this decimal value) => Pressure.FromKilopoundsForcePerSquareInch(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromKilopoundsForcePerSquareInch(double?)"/>
        public static Pressure? KilopoundsForcePerSquareInch(this decimal? value) => Pressure.FromKilopoundsForcePerSquareInch(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Megabar

        /// <inheritdoc cref="Pressure.FromMegabars(double)"/>
        public static Pressure Megabars(this int value) => Pressure.FromMegabars(value);

        /// <inheritdoc cref="Pressure.FromMegabars(double?)"/>
        public static Pressure? Megabars(this int? value) => Pressure.FromMegabars(value);

        /// <inheritdoc cref="Pressure.FromMegabars(double)"/>
        public static Pressure Megabars(this long value) => Pressure.FromMegabars(value);

        /// <inheritdoc cref="Pressure.FromMegabars(double?)"/>
        public static Pressure? Megabars(this long? value) => Pressure.FromMegabars(value);

        /// <inheritdoc cref="Pressure.FromMegabars(double)"/>
        public static Pressure Megabars(this double value) => Pressure.FromMegabars(value);

        /// <inheritdoc cref="Pressure.FromMegabars(double?)"/>
        public static Pressure? Megabars(this double? value) => Pressure.FromMegabars(value);

        /// <inheritdoc cref="Pressure.FromMegabars(double)"/>
        public static Pressure Megabars(this float value) => Pressure.FromMegabars(value);

        /// <inheritdoc cref="Pressure.FromMegabars(double?)"/>
        public static Pressure? Megabars(this float? value) => Pressure.FromMegabars(value);

        /// <inheritdoc cref="Pressure.FromMegabars(double)"/>
        public static Pressure Megabars(this decimal value) => Pressure.FromMegabars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMegabars(double?)"/>
        public static Pressure? Megabars(this decimal? value) => Pressure.FromMegabars(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Megapascal

        /// <inheritdoc cref="Pressure.FromMegapascals(double)"/>
        public static Pressure Megapascals(this int value) => Pressure.FromMegapascals(value);

        /// <inheritdoc cref="Pressure.FromMegapascals(double?)"/>
        public static Pressure? Megapascals(this int? value) => Pressure.FromMegapascals(value);

        /// <inheritdoc cref="Pressure.FromMegapascals(double)"/>
        public static Pressure Megapascals(this long value) => Pressure.FromMegapascals(value);

        /// <inheritdoc cref="Pressure.FromMegapascals(double?)"/>
        public static Pressure? Megapascals(this long? value) => Pressure.FromMegapascals(value);

        /// <inheritdoc cref="Pressure.FromMegapascals(double)"/>
        public static Pressure Megapascals(this double value) => Pressure.FromMegapascals(value);

        /// <inheritdoc cref="Pressure.FromMegapascals(double?)"/>
        public static Pressure? Megapascals(this double? value) => Pressure.FromMegapascals(value);

        /// <inheritdoc cref="Pressure.FromMegapascals(double)"/>
        public static Pressure Megapascals(this float value) => Pressure.FromMegapascals(value);

        /// <inheritdoc cref="Pressure.FromMegapascals(double?)"/>
        public static Pressure? Megapascals(this float? value) => Pressure.FromMegapascals(value);

        /// <inheritdoc cref="Pressure.FromMegapascals(double)"/>
        public static Pressure Megapascals(this decimal value) => Pressure.FromMegapascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMegapascals(double?)"/>
        public static Pressure? Megapascals(this decimal? value) => Pressure.FromMegapascals(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Micropascal

        /// <inheritdoc cref="Pressure.FromMicropascals(double)"/>
        public static Pressure Micropascals(this int value) => Pressure.FromMicropascals(value);

        /// <inheritdoc cref="Pressure.FromMicropascals(double?)"/>
        public static Pressure? Micropascals(this int? value) => Pressure.FromMicropascals(value);

        /// <inheritdoc cref="Pressure.FromMicropascals(double)"/>
        public static Pressure Micropascals(this long value) => Pressure.FromMicropascals(value);

        /// <inheritdoc cref="Pressure.FromMicropascals(double?)"/>
        public static Pressure? Micropascals(this long? value) => Pressure.FromMicropascals(value);

        /// <inheritdoc cref="Pressure.FromMicropascals(double)"/>
        public static Pressure Micropascals(this double value) => Pressure.FromMicropascals(value);

        /// <inheritdoc cref="Pressure.FromMicropascals(double?)"/>
        public static Pressure? Micropascals(this double? value) => Pressure.FromMicropascals(value);

        /// <inheritdoc cref="Pressure.FromMicropascals(double)"/>
        public static Pressure Micropascals(this float value) => Pressure.FromMicropascals(value);

        /// <inheritdoc cref="Pressure.FromMicropascals(double?)"/>
        public static Pressure? Micropascals(this float? value) => Pressure.FromMicropascals(value);

        /// <inheritdoc cref="Pressure.FromMicropascals(double)"/>
        public static Pressure Micropascals(this decimal value) => Pressure.FromMicropascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMicropascals(double?)"/>
        public static Pressure? Micropascals(this decimal? value) => Pressure.FromMicropascals(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Millibar

        /// <inheritdoc cref="Pressure.FromMillibars(double)"/>
        public static Pressure Millibars(this int value) => Pressure.FromMillibars(value);

        /// <inheritdoc cref="Pressure.FromMillibars(double?)"/>
        public static Pressure? Millibars(this int? value) => Pressure.FromMillibars(value);

        /// <inheritdoc cref="Pressure.FromMillibars(double)"/>
        public static Pressure Millibars(this long value) => Pressure.FromMillibars(value);

        /// <inheritdoc cref="Pressure.FromMillibars(double?)"/>
        public static Pressure? Millibars(this long? value) => Pressure.FromMillibars(value);

        /// <inheritdoc cref="Pressure.FromMillibars(double)"/>
        public static Pressure Millibars(this double value) => Pressure.FromMillibars(value);

        /// <inheritdoc cref="Pressure.FromMillibars(double?)"/>
        public static Pressure? Millibars(this double? value) => Pressure.FromMillibars(value);

        /// <inheritdoc cref="Pressure.FromMillibars(double)"/>
        public static Pressure Millibars(this float value) => Pressure.FromMillibars(value);

        /// <inheritdoc cref="Pressure.FromMillibars(double?)"/>
        public static Pressure? Millibars(this float? value) => Pressure.FromMillibars(value);

        /// <inheritdoc cref="Pressure.FromMillibars(double)"/>
        public static Pressure Millibars(this decimal value) => Pressure.FromMillibars(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromMillibars(double?)"/>
        public static Pressure? Millibars(this decimal? value) => Pressure.FromMillibars(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NewtonPerSquareCentimeter

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareCentimeter(double)"/>
        public static Pressure NewtonsPerSquareCentimeter(this int value) => Pressure.FromNewtonsPerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareCentimeter(double?)"/>
        public static Pressure? NewtonsPerSquareCentimeter(this int? value) => Pressure.FromNewtonsPerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareCentimeter(double)"/>
        public static Pressure NewtonsPerSquareCentimeter(this long value) => Pressure.FromNewtonsPerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareCentimeter(double?)"/>
        public static Pressure? NewtonsPerSquareCentimeter(this long? value) => Pressure.FromNewtonsPerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareCentimeter(double)"/>
        public static Pressure NewtonsPerSquareCentimeter(this double value) => Pressure.FromNewtonsPerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareCentimeter(double?)"/>
        public static Pressure? NewtonsPerSquareCentimeter(this double? value) => Pressure.FromNewtonsPerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareCentimeter(double)"/>
        public static Pressure NewtonsPerSquareCentimeter(this float value) => Pressure.FromNewtonsPerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareCentimeter(double?)"/>
        public static Pressure? NewtonsPerSquareCentimeter(this float? value) => Pressure.FromNewtonsPerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareCentimeter(double)"/>
        public static Pressure NewtonsPerSquareCentimeter(this decimal value) => Pressure.FromNewtonsPerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareCentimeter(double?)"/>
        public static Pressure? NewtonsPerSquareCentimeter(this decimal? value) => Pressure.FromNewtonsPerSquareCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NewtonPerSquareMeter

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMeter(double)"/>
        public static Pressure NewtonsPerSquareMeter(this int value) => Pressure.FromNewtonsPerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMeter(double?)"/>
        public static Pressure? NewtonsPerSquareMeter(this int? value) => Pressure.FromNewtonsPerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMeter(double)"/>
        public static Pressure NewtonsPerSquareMeter(this long value) => Pressure.FromNewtonsPerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMeter(double?)"/>
        public static Pressure? NewtonsPerSquareMeter(this long? value) => Pressure.FromNewtonsPerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMeter(double)"/>
        public static Pressure NewtonsPerSquareMeter(this double value) => Pressure.FromNewtonsPerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMeter(double?)"/>
        public static Pressure? NewtonsPerSquareMeter(this double? value) => Pressure.FromNewtonsPerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMeter(double)"/>
        public static Pressure NewtonsPerSquareMeter(this float value) => Pressure.FromNewtonsPerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMeter(double?)"/>
        public static Pressure? NewtonsPerSquareMeter(this float? value) => Pressure.FromNewtonsPerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMeter(double)"/>
        public static Pressure NewtonsPerSquareMeter(this decimal value) => Pressure.FromNewtonsPerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMeter(double?)"/>
        public static Pressure? NewtonsPerSquareMeter(this decimal? value) => Pressure.FromNewtonsPerSquareMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NewtonPerSquareMillimeter

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMillimeter(double)"/>
        public static Pressure NewtonsPerSquareMillimeter(this int value) => Pressure.FromNewtonsPerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMillimeter(double?)"/>
        public static Pressure? NewtonsPerSquareMillimeter(this int? value) => Pressure.FromNewtonsPerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMillimeter(double)"/>
        public static Pressure NewtonsPerSquareMillimeter(this long value) => Pressure.FromNewtonsPerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMillimeter(double?)"/>
        public static Pressure? NewtonsPerSquareMillimeter(this long? value) => Pressure.FromNewtonsPerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMillimeter(double)"/>
        public static Pressure NewtonsPerSquareMillimeter(this double value) => Pressure.FromNewtonsPerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMillimeter(double?)"/>
        public static Pressure? NewtonsPerSquareMillimeter(this double? value) => Pressure.FromNewtonsPerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMillimeter(double)"/>
        public static Pressure NewtonsPerSquareMillimeter(this float value) => Pressure.FromNewtonsPerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMillimeter(double?)"/>
        public static Pressure? NewtonsPerSquareMillimeter(this float? value) => Pressure.FromNewtonsPerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMillimeter(double)"/>
        public static Pressure NewtonsPerSquareMillimeter(this decimal value) => Pressure.FromNewtonsPerSquareMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromNewtonsPerSquareMillimeter(double?)"/>
        public static Pressure? NewtonsPerSquareMillimeter(this decimal? value) => Pressure.FromNewtonsPerSquareMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Pascal

        /// <inheritdoc cref="Pressure.FromPascals(double)"/>
        public static Pressure Pascals(this int value) => Pressure.FromPascals(value);

        /// <inheritdoc cref="Pressure.FromPascals(double?)"/>
        public static Pressure? Pascals(this int? value) => Pressure.FromPascals(value);

        /// <inheritdoc cref="Pressure.FromPascals(double)"/>
        public static Pressure Pascals(this long value) => Pressure.FromPascals(value);

        /// <inheritdoc cref="Pressure.FromPascals(double?)"/>
        public static Pressure? Pascals(this long? value) => Pressure.FromPascals(value);

        /// <inheritdoc cref="Pressure.FromPascals(double)"/>
        public static Pressure Pascals(this double value) => Pressure.FromPascals(value);

        /// <inheritdoc cref="Pressure.FromPascals(double?)"/>
        public static Pressure? Pascals(this double? value) => Pressure.FromPascals(value);

        /// <inheritdoc cref="Pressure.FromPascals(double)"/>
        public static Pressure Pascals(this float value) => Pressure.FromPascals(value);

        /// <inheritdoc cref="Pressure.FromPascals(double?)"/>
        public static Pressure? Pascals(this float? value) => Pressure.FromPascals(value);

        /// <inheritdoc cref="Pressure.FromPascals(double)"/>
        public static Pressure Pascals(this decimal value) => Pressure.FromPascals(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromPascals(double?)"/>
        public static Pressure? Pascals(this decimal? value) => Pressure.FromPascals(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundForcePerSquareFoot

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareFoot(double)"/>
        public static Pressure PoundsForcePerSquareFoot(this int value) => Pressure.FromPoundsForcePerSquareFoot(value);

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareFoot(double?)"/>
        public static Pressure? PoundsForcePerSquareFoot(this int? value) => Pressure.FromPoundsForcePerSquareFoot(value);

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareFoot(double)"/>
        public static Pressure PoundsForcePerSquareFoot(this long value) => Pressure.FromPoundsForcePerSquareFoot(value);

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareFoot(double?)"/>
        public static Pressure? PoundsForcePerSquareFoot(this long? value) => Pressure.FromPoundsForcePerSquareFoot(value);

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareFoot(double)"/>
        public static Pressure PoundsForcePerSquareFoot(this double value) => Pressure.FromPoundsForcePerSquareFoot(value);

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareFoot(double?)"/>
        public static Pressure? PoundsForcePerSquareFoot(this double? value) => Pressure.FromPoundsForcePerSquareFoot(value);

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareFoot(double)"/>
        public static Pressure PoundsForcePerSquareFoot(this float value) => Pressure.FromPoundsForcePerSquareFoot(value);

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareFoot(double?)"/>
        public static Pressure? PoundsForcePerSquareFoot(this float? value) => Pressure.FromPoundsForcePerSquareFoot(value);

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareFoot(double)"/>
        public static Pressure PoundsForcePerSquareFoot(this decimal value) => Pressure.FromPoundsForcePerSquareFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareFoot(double?)"/>
        public static Pressure? PoundsForcePerSquareFoot(this decimal? value) => Pressure.FromPoundsForcePerSquareFoot(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region PoundForcePerSquareInch

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareInch(double)"/>
        public static Pressure PoundsForcePerSquareInch(this int value) => Pressure.FromPoundsForcePerSquareInch(value);

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareInch(double?)"/>
        public static Pressure? PoundsForcePerSquareInch(this int? value) => Pressure.FromPoundsForcePerSquareInch(value);

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareInch(double)"/>
        public static Pressure PoundsForcePerSquareInch(this long value) => Pressure.FromPoundsForcePerSquareInch(value);

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareInch(double?)"/>
        public static Pressure? PoundsForcePerSquareInch(this long? value) => Pressure.FromPoundsForcePerSquareInch(value);

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareInch(double)"/>
        public static Pressure PoundsForcePerSquareInch(this double value) => Pressure.FromPoundsForcePerSquareInch(value);

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareInch(double?)"/>
        public static Pressure? PoundsForcePerSquareInch(this double? value) => Pressure.FromPoundsForcePerSquareInch(value);

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareInch(double)"/>
        public static Pressure PoundsForcePerSquareInch(this float value) => Pressure.FromPoundsForcePerSquareInch(value);

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareInch(double?)"/>
        public static Pressure? PoundsForcePerSquareInch(this float? value) => Pressure.FromPoundsForcePerSquareInch(value);

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareInch(double)"/>
        public static Pressure PoundsForcePerSquareInch(this decimal value) => Pressure.FromPoundsForcePerSquareInch(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromPoundsForcePerSquareInch(double?)"/>
        public static Pressure? PoundsForcePerSquareInch(this decimal? value) => Pressure.FromPoundsForcePerSquareInch(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Psi

        /// <inheritdoc cref="Pressure.FromPsi(double)"/>
        public static Pressure Psi(this int value) => Pressure.FromPsi(value);

        /// <inheritdoc cref="Pressure.FromPsi(double?)"/>
        public static Pressure? Psi(this int? value) => Pressure.FromPsi(value);

        /// <inheritdoc cref="Pressure.FromPsi(double)"/>
        public static Pressure Psi(this long value) => Pressure.FromPsi(value);

        /// <inheritdoc cref="Pressure.FromPsi(double?)"/>
        public static Pressure? Psi(this long? value) => Pressure.FromPsi(value);

        /// <inheritdoc cref="Pressure.FromPsi(double)"/>
        public static Pressure Psi(this double value) => Pressure.FromPsi(value);

        /// <inheritdoc cref="Pressure.FromPsi(double?)"/>
        public static Pressure? Psi(this double? value) => Pressure.FromPsi(value);

        /// <inheritdoc cref="Pressure.FromPsi(double)"/>
        public static Pressure Psi(this float value) => Pressure.FromPsi(value);

        /// <inheritdoc cref="Pressure.FromPsi(double?)"/>
        public static Pressure? Psi(this float? value) => Pressure.FromPsi(value);

        /// <inheritdoc cref="Pressure.FromPsi(double)"/>
        public static Pressure Psi(this decimal value) => Pressure.FromPsi(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromPsi(double?)"/>
        public static Pressure? Psi(this decimal? value) => Pressure.FromPsi(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TechnicalAtmosphere

        /// <inheritdoc cref="Pressure.FromTechnicalAtmospheres(double)"/>
        public static Pressure TechnicalAtmospheres(this int value) => Pressure.FromTechnicalAtmospheres(value);

        /// <inheritdoc cref="Pressure.FromTechnicalAtmospheres(double?)"/>
        public static Pressure? TechnicalAtmospheres(this int? value) => Pressure.FromTechnicalAtmospheres(value);

        /// <inheritdoc cref="Pressure.FromTechnicalAtmospheres(double)"/>
        public static Pressure TechnicalAtmospheres(this long value) => Pressure.FromTechnicalAtmospheres(value);

        /// <inheritdoc cref="Pressure.FromTechnicalAtmospheres(double?)"/>
        public static Pressure? TechnicalAtmospheres(this long? value) => Pressure.FromTechnicalAtmospheres(value);

        /// <inheritdoc cref="Pressure.FromTechnicalAtmospheres(double)"/>
        public static Pressure TechnicalAtmospheres(this double value) => Pressure.FromTechnicalAtmospheres(value);

        /// <inheritdoc cref="Pressure.FromTechnicalAtmospheres(double?)"/>
        public static Pressure? TechnicalAtmospheres(this double? value) => Pressure.FromTechnicalAtmospheres(value);

        /// <inheritdoc cref="Pressure.FromTechnicalAtmospheres(double)"/>
        public static Pressure TechnicalAtmospheres(this float value) => Pressure.FromTechnicalAtmospheres(value);

        /// <inheritdoc cref="Pressure.FromTechnicalAtmospheres(double?)"/>
        public static Pressure? TechnicalAtmospheres(this float? value) => Pressure.FromTechnicalAtmospheres(value);

        /// <inheritdoc cref="Pressure.FromTechnicalAtmospheres(double)"/>
        public static Pressure TechnicalAtmospheres(this decimal value) => Pressure.FromTechnicalAtmospheres(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTechnicalAtmospheres(double?)"/>
        public static Pressure? TechnicalAtmospheres(this decimal? value) => Pressure.FromTechnicalAtmospheres(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TonneForcePerSquareCentimeter

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareCentimeter(double)"/>
        public static Pressure TonnesForcePerSquareCentimeter(this int value) => Pressure.FromTonnesForcePerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareCentimeter(double?)"/>
        public static Pressure? TonnesForcePerSquareCentimeter(this int? value) => Pressure.FromTonnesForcePerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareCentimeter(double)"/>
        public static Pressure TonnesForcePerSquareCentimeter(this long value) => Pressure.FromTonnesForcePerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareCentimeter(double?)"/>
        public static Pressure? TonnesForcePerSquareCentimeter(this long? value) => Pressure.FromTonnesForcePerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareCentimeter(double)"/>
        public static Pressure TonnesForcePerSquareCentimeter(this double value) => Pressure.FromTonnesForcePerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareCentimeter(double?)"/>
        public static Pressure? TonnesForcePerSquareCentimeter(this double? value) => Pressure.FromTonnesForcePerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareCentimeter(double)"/>
        public static Pressure TonnesForcePerSquareCentimeter(this float value) => Pressure.FromTonnesForcePerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareCentimeter(double?)"/>
        public static Pressure? TonnesForcePerSquareCentimeter(this float? value) => Pressure.FromTonnesForcePerSquareCentimeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareCentimeter(double)"/>
        public static Pressure TonnesForcePerSquareCentimeter(this decimal value) => Pressure.FromTonnesForcePerSquareCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareCentimeter(double?)"/>
        public static Pressure? TonnesForcePerSquareCentimeter(this decimal? value) => Pressure.FromTonnesForcePerSquareCentimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TonneForcePerSquareMeter

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMeter(double)"/>
        public static Pressure TonnesForcePerSquareMeter(this int value) => Pressure.FromTonnesForcePerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMeter(double?)"/>
        public static Pressure? TonnesForcePerSquareMeter(this int? value) => Pressure.FromTonnesForcePerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMeter(double)"/>
        public static Pressure TonnesForcePerSquareMeter(this long value) => Pressure.FromTonnesForcePerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMeter(double?)"/>
        public static Pressure? TonnesForcePerSquareMeter(this long? value) => Pressure.FromTonnesForcePerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMeter(double)"/>
        public static Pressure TonnesForcePerSquareMeter(this double value) => Pressure.FromTonnesForcePerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMeter(double?)"/>
        public static Pressure? TonnesForcePerSquareMeter(this double? value) => Pressure.FromTonnesForcePerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMeter(double)"/>
        public static Pressure TonnesForcePerSquareMeter(this float value) => Pressure.FromTonnesForcePerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMeter(double?)"/>
        public static Pressure? TonnesForcePerSquareMeter(this float? value) => Pressure.FromTonnesForcePerSquareMeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMeter(double)"/>
        public static Pressure TonnesForcePerSquareMeter(this decimal value) => Pressure.FromTonnesForcePerSquareMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMeter(double?)"/>
        public static Pressure? TonnesForcePerSquareMeter(this decimal? value) => Pressure.FromTonnesForcePerSquareMeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region TonneForcePerSquareMillimeter

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMillimeter(double)"/>
        public static Pressure TonnesForcePerSquareMillimeter(this int value) => Pressure.FromTonnesForcePerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMillimeter(double?)"/>
        public static Pressure? TonnesForcePerSquareMillimeter(this int? value) => Pressure.FromTonnesForcePerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMillimeter(double)"/>
        public static Pressure TonnesForcePerSquareMillimeter(this long value) => Pressure.FromTonnesForcePerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMillimeter(double?)"/>
        public static Pressure? TonnesForcePerSquareMillimeter(this long? value) => Pressure.FromTonnesForcePerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMillimeter(double)"/>
        public static Pressure TonnesForcePerSquareMillimeter(this double value) => Pressure.FromTonnesForcePerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMillimeter(double?)"/>
        public static Pressure? TonnesForcePerSquareMillimeter(this double? value) => Pressure.FromTonnesForcePerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMillimeter(double)"/>
        public static Pressure TonnesForcePerSquareMillimeter(this float value) => Pressure.FromTonnesForcePerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMillimeter(double?)"/>
        public static Pressure? TonnesForcePerSquareMillimeter(this float? value) => Pressure.FromTonnesForcePerSquareMillimeter(value);

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMillimeter(double)"/>
        public static Pressure TonnesForcePerSquareMillimeter(this decimal value) => Pressure.FromTonnesForcePerSquareMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTonnesForcePerSquareMillimeter(double?)"/>
        public static Pressure? TonnesForcePerSquareMillimeter(this decimal? value) => Pressure.FromTonnesForcePerSquareMillimeter(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Torr

        /// <inheritdoc cref="Pressure.FromTorrs(double)"/>
        public static Pressure Torrs(this int value) => Pressure.FromTorrs(value);

        /// <inheritdoc cref="Pressure.FromTorrs(double?)"/>
        public static Pressure? Torrs(this int? value) => Pressure.FromTorrs(value);

        /// <inheritdoc cref="Pressure.FromTorrs(double)"/>
        public static Pressure Torrs(this long value) => Pressure.FromTorrs(value);

        /// <inheritdoc cref="Pressure.FromTorrs(double?)"/>
        public static Pressure? Torrs(this long? value) => Pressure.FromTorrs(value);

        /// <inheritdoc cref="Pressure.FromTorrs(double)"/>
        public static Pressure Torrs(this double value) => Pressure.FromTorrs(value);

        /// <inheritdoc cref="Pressure.FromTorrs(double?)"/>
        public static Pressure? Torrs(this double? value) => Pressure.FromTorrs(value);

        /// <inheritdoc cref="Pressure.FromTorrs(double)"/>
        public static Pressure Torrs(this float value) => Pressure.FromTorrs(value);

        /// <inheritdoc cref="Pressure.FromTorrs(double?)"/>
        public static Pressure? Torrs(this float? value) => Pressure.FromTorrs(value);

        /// <inheritdoc cref="Pressure.FromTorrs(double)"/>
        public static Pressure Torrs(this decimal value) => Pressure.FromTorrs(Convert.ToDouble(value));

        /// <inheritdoc cref="Pressure.FromTorrs(double?)"/>
        public static Pressure? Torrs(this decimal? value) => Pressure.FromTorrs(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
