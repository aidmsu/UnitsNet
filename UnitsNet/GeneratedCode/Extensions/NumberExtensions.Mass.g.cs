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
        #region Centigram

        /// <inheritdoc cref="Mass.FromCentigrams(double)"/>
        public static Mass Centigrams(this int value) => Mass.FromCentigrams(value);

        /// <inheritdoc cref="Mass.FromCentigrams(double?)"/>
        public static Mass? Centigrams(this int? value) => Mass.FromCentigrams(value);

        /// <inheritdoc cref="Mass.FromCentigrams(double)"/>
        public static Mass Centigrams(this long value) => Mass.FromCentigrams(value);

        /// <inheritdoc cref="Mass.FromCentigrams(double?)"/>
        public static Mass? Centigrams(this long? value) => Mass.FromCentigrams(value);

        /// <inheritdoc cref="Mass.FromCentigrams(double)"/>
        public static Mass Centigrams(this double value) => Mass.FromCentigrams(value);

        /// <inheritdoc cref="Mass.FromCentigrams(double?)"/>
        public static Mass? Centigrams(this double? value) => Mass.FromCentigrams(value);

        /// <inheritdoc cref="Mass.FromCentigrams(double)"/>
        public static Mass Centigrams(this float value) => Mass.FromCentigrams(value);

        /// <inheritdoc cref="Mass.FromCentigrams(double?)"/>
        public static Mass? Centigrams(this float? value) => Mass.FromCentigrams(value);

        /// <inheritdoc cref="Mass.FromCentigrams(double)"/>
        public static Mass Centigrams(this decimal value) => Mass.FromCentigrams(Convert.ToDouble(value));

        /// <inheritdoc cref="Mass.FromCentigrams(double?)"/>
        public static Mass? Centigrams(this decimal? value) => Mass.FromCentigrams(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Decagram

        /// <inheritdoc cref="Mass.FromDecagrams(double)"/>
        public static Mass Decagrams(this int value) => Mass.FromDecagrams(value);

        /// <inheritdoc cref="Mass.FromDecagrams(double?)"/>
        public static Mass? Decagrams(this int? value) => Mass.FromDecagrams(value);

        /// <inheritdoc cref="Mass.FromDecagrams(double)"/>
        public static Mass Decagrams(this long value) => Mass.FromDecagrams(value);

        /// <inheritdoc cref="Mass.FromDecagrams(double?)"/>
        public static Mass? Decagrams(this long? value) => Mass.FromDecagrams(value);

        /// <inheritdoc cref="Mass.FromDecagrams(double)"/>
        public static Mass Decagrams(this double value) => Mass.FromDecagrams(value);

        /// <inheritdoc cref="Mass.FromDecagrams(double?)"/>
        public static Mass? Decagrams(this double? value) => Mass.FromDecagrams(value);

        /// <inheritdoc cref="Mass.FromDecagrams(double)"/>
        public static Mass Decagrams(this float value) => Mass.FromDecagrams(value);

        /// <inheritdoc cref="Mass.FromDecagrams(double?)"/>
        public static Mass? Decagrams(this float? value) => Mass.FromDecagrams(value);

        /// <inheritdoc cref="Mass.FromDecagrams(double)"/>
        public static Mass Decagrams(this decimal value) => Mass.FromDecagrams(Convert.ToDouble(value));

        /// <inheritdoc cref="Mass.FromDecagrams(double?)"/>
        public static Mass? Decagrams(this decimal? value) => Mass.FromDecagrams(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Decigram

        /// <inheritdoc cref="Mass.FromDecigrams(double)"/>
        public static Mass Decigrams(this int value) => Mass.FromDecigrams(value);

        /// <inheritdoc cref="Mass.FromDecigrams(double?)"/>
        public static Mass? Decigrams(this int? value) => Mass.FromDecigrams(value);

        /// <inheritdoc cref="Mass.FromDecigrams(double)"/>
        public static Mass Decigrams(this long value) => Mass.FromDecigrams(value);

        /// <inheritdoc cref="Mass.FromDecigrams(double?)"/>
        public static Mass? Decigrams(this long? value) => Mass.FromDecigrams(value);

        /// <inheritdoc cref="Mass.FromDecigrams(double)"/>
        public static Mass Decigrams(this double value) => Mass.FromDecigrams(value);

        /// <inheritdoc cref="Mass.FromDecigrams(double?)"/>
        public static Mass? Decigrams(this double? value) => Mass.FromDecigrams(value);

        /// <inheritdoc cref="Mass.FromDecigrams(double)"/>
        public static Mass Decigrams(this float value) => Mass.FromDecigrams(value);

        /// <inheritdoc cref="Mass.FromDecigrams(double?)"/>
        public static Mass? Decigrams(this float? value) => Mass.FromDecigrams(value);

        /// <inheritdoc cref="Mass.FromDecigrams(double)"/>
        public static Mass Decigrams(this decimal value) => Mass.FromDecigrams(Convert.ToDouble(value));

        /// <inheritdoc cref="Mass.FromDecigrams(double?)"/>
        public static Mass? Decigrams(this decimal? value) => Mass.FromDecigrams(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Gram

        /// <inheritdoc cref="Mass.FromGrams(double)"/>
        public static Mass Grams(this int value) => Mass.FromGrams(value);

        /// <inheritdoc cref="Mass.FromGrams(double?)"/>
        public static Mass? Grams(this int? value) => Mass.FromGrams(value);

        /// <inheritdoc cref="Mass.FromGrams(double)"/>
        public static Mass Grams(this long value) => Mass.FromGrams(value);

        /// <inheritdoc cref="Mass.FromGrams(double?)"/>
        public static Mass? Grams(this long? value) => Mass.FromGrams(value);

        /// <inheritdoc cref="Mass.FromGrams(double)"/>
        public static Mass Grams(this double value) => Mass.FromGrams(value);

        /// <inheritdoc cref="Mass.FromGrams(double?)"/>
        public static Mass? Grams(this double? value) => Mass.FromGrams(value);

        /// <inheritdoc cref="Mass.FromGrams(double)"/>
        public static Mass Grams(this float value) => Mass.FromGrams(value);

        /// <inheritdoc cref="Mass.FromGrams(double?)"/>
        public static Mass? Grams(this float? value) => Mass.FromGrams(value);

        /// <inheritdoc cref="Mass.FromGrams(double)"/>
        public static Mass Grams(this decimal value) => Mass.FromGrams(Convert.ToDouble(value));

        /// <inheritdoc cref="Mass.FromGrams(double?)"/>
        public static Mass? Grams(this decimal? value) => Mass.FromGrams(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Hectogram

        /// <inheritdoc cref="Mass.FromHectograms(double)"/>
        public static Mass Hectograms(this int value) => Mass.FromHectograms(value);

        /// <inheritdoc cref="Mass.FromHectograms(double?)"/>
        public static Mass? Hectograms(this int? value) => Mass.FromHectograms(value);

        /// <inheritdoc cref="Mass.FromHectograms(double)"/>
        public static Mass Hectograms(this long value) => Mass.FromHectograms(value);

        /// <inheritdoc cref="Mass.FromHectograms(double?)"/>
        public static Mass? Hectograms(this long? value) => Mass.FromHectograms(value);

        /// <inheritdoc cref="Mass.FromHectograms(double)"/>
        public static Mass Hectograms(this double value) => Mass.FromHectograms(value);

        /// <inheritdoc cref="Mass.FromHectograms(double?)"/>
        public static Mass? Hectograms(this double? value) => Mass.FromHectograms(value);

        /// <inheritdoc cref="Mass.FromHectograms(double)"/>
        public static Mass Hectograms(this float value) => Mass.FromHectograms(value);

        /// <inheritdoc cref="Mass.FromHectograms(double?)"/>
        public static Mass? Hectograms(this float? value) => Mass.FromHectograms(value);

        /// <inheritdoc cref="Mass.FromHectograms(double)"/>
        public static Mass Hectograms(this decimal value) => Mass.FromHectograms(Convert.ToDouble(value));

        /// <inheritdoc cref="Mass.FromHectograms(double?)"/>
        public static Mass? Hectograms(this decimal? value) => Mass.FromHectograms(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kilogram

        /// <inheritdoc cref="Mass.FromKilograms(double)"/>
        public static Mass Kilograms(this int value) => Mass.FromKilograms(value);

        /// <inheritdoc cref="Mass.FromKilograms(double?)"/>
        public static Mass? Kilograms(this int? value) => Mass.FromKilograms(value);

        /// <inheritdoc cref="Mass.FromKilograms(double)"/>
        public static Mass Kilograms(this long value) => Mass.FromKilograms(value);

        /// <inheritdoc cref="Mass.FromKilograms(double?)"/>
        public static Mass? Kilograms(this long? value) => Mass.FromKilograms(value);

        /// <inheritdoc cref="Mass.FromKilograms(double)"/>
        public static Mass Kilograms(this double value) => Mass.FromKilograms(value);

        /// <inheritdoc cref="Mass.FromKilograms(double?)"/>
        public static Mass? Kilograms(this double? value) => Mass.FromKilograms(value);

        /// <inheritdoc cref="Mass.FromKilograms(double)"/>
        public static Mass Kilograms(this float value) => Mass.FromKilograms(value);

        /// <inheritdoc cref="Mass.FromKilograms(double?)"/>
        public static Mass? Kilograms(this float? value) => Mass.FromKilograms(value);

        /// <inheritdoc cref="Mass.FromKilograms(double)"/>
        public static Mass Kilograms(this decimal value) => Mass.FromKilograms(Convert.ToDouble(value));

        /// <inheritdoc cref="Mass.FromKilograms(double?)"/>
        public static Mass? Kilograms(this decimal? value) => Mass.FromKilograms(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kilotonne

        /// <inheritdoc cref="Mass.FromKilotonnes(double)"/>
        public static Mass Kilotonnes(this int value) => Mass.FromKilotonnes(value);

        /// <inheritdoc cref="Mass.FromKilotonnes(double?)"/>
        public static Mass? Kilotonnes(this int? value) => Mass.FromKilotonnes(value);

        /// <inheritdoc cref="Mass.FromKilotonnes(double)"/>
        public static Mass Kilotonnes(this long value) => Mass.FromKilotonnes(value);

        /// <inheritdoc cref="Mass.FromKilotonnes(double?)"/>
        public static Mass? Kilotonnes(this long? value) => Mass.FromKilotonnes(value);

        /// <inheritdoc cref="Mass.FromKilotonnes(double)"/>
        public static Mass Kilotonnes(this double value) => Mass.FromKilotonnes(value);

        /// <inheritdoc cref="Mass.FromKilotonnes(double?)"/>
        public static Mass? Kilotonnes(this double? value) => Mass.FromKilotonnes(value);

        /// <inheritdoc cref="Mass.FromKilotonnes(double)"/>
        public static Mass Kilotonnes(this float value) => Mass.FromKilotonnes(value);

        /// <inheritdoc cref="Mass.FromKilotonnes(double?)"/>
        public static Mass? Kilotonnes(this float? value) => Mass.FromKilotonnes(value);

        /// <inheritdoc cref="Mass.FromKilotonnes(double)"/>
        public static Mass Kilotonnes(this decimal value) => Mass.FromKilotonnes(Convert.ToDouble(value));

        /// <inheritdoc cref="Mass.FromKilotonnes(double?)"/>
        public static Mass? Kilotonnes(this decimal? value) => Mass.FromKilotonnes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region LongTon

        /// <inheritdoc cref="Mass.FromLongTons(double)"/>
        public static Mass LongTons(this int value) => Mass.FromLongTons(value);

        /// <inheritdoc cref="Mass.FromLongTons(double?)"/>
        public static Mass? LongTons(this int? value) => Mass.FromLongTons(value);

        /// <inheritdoc cref="Mass.FromLongTons(double)"/>
        public static Mass LongTons(this long value) => Mass.FromLongTons(value);

        /// <inheritdoc cref="Mass.FromLongTons(double?)"/>
        public static Mass? LongTons(this long? value) => Mass.FromLongTons(value);

        /// <inheritdoc cref="Mass.FromLongTons(double)"/>
        public static Mass LongTons(this double value) => Mass.FromLongTons(value);

        /// <inheritdoc cref="Mass.FromLongTons(double?)"/>
        public static Mass? LongTons(this double? value) => Mass.FromLongTons(value);

        /// <inheritdoc cref="Mass.FromLongTons(double)"/>
        public static Mass LongTons(this float value) => Mass.FromLongTons(value);

        /// <inheritdoc cref="Mass.FromLongTons(double?)"/>
        public static Mass? LongTons(this float? value) => Mass.FromLongTons(value);

        /// <inheritdoc cref="Mass.FromLongTons(double)"/>
        public static Mass LongTons(this decimal value) => Mass.FromLongTons(Convert.ToDouble(value));

        /// <inheritdoc cref="Mass.FromLongTons(double?)"/>
        public static Mass? LongTons(this decimal? value) => Mass.FromLongTons(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Megatonne

        /// <inheritdoc cref="Mass.FromMegatonnes(double)"/>
        public static Mass Megatonnes(this int value) => Mass.FromMegatonnes(value);

        /// <inheritdoc cref="Mass.FromMegatonnes(double?)"/>
        public static Mass? Megatonnes(this int? value) => Mass.FromMegatonnes(value);

        /// <inheritdoc cref="Mass.FromMegatonnes(double)"/>
        public static Mass Megatonnes(this long value) => Mass.FromMegatonnes(value);

        /// <inheritdoc cref="Mass.FromMegatonnes(double?)"/>
        public static Mass? Megatonnes(this long? value) => Mass.FromMegatonnes(value);

        /// <inheritdoc cref="Mass.FromMegatonnes(double)"/>
        public static Mass Megatonnes(this double value) => Mass.FromMegatonnes(value);

        /// <inheritdoc cref="Mass.FromMegatonnes(double?)"/>
        public static Mass? Megatonnes(this double? value) => Mass.FromMegatonnes(value);

        /// <inheritdoc cref="Mass.FromMegatonnes(double)"/>
        public static Mass Megatonnes(this float value) => Mass.FromMegatonnes(value);

        /// <inheritdoc cref="Mass.FromMegatonnes(double?)"/>
        public static Mass? Megatonnes(this float? value) => Mass.FromMegatonnes(value);

        /// <inheritdoc cref="Mass.FromMegatonnes(double)"/>
        public static Mass Megatonnes(this decimal value) => Mass.FromMegatonnes(Convert.ToDouble(value));

        /// <inheritdoc cref="Mass.FromMegatonnes(double?)"/>
        public static Mass? Megatonnes(this decimal? value) => Mass.FromMegatonnes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Microgram

        /// <inheritdoc cref="Mass.FromMicrograms(double)"/>
        public static Mass Micrograms(this int value) => Mass.FromMicrograms(value);

        /// <inheritdoc cref="Mass.FromMicrograms(double?)"/>
        public static Mass? Micrograms(this int? value) => Mass.FromMicrograms(value);

        /// <inheritdoc cref="Mass.FromMicrograms(double)"/>
        public static Mass Micrograms(this long value) => Mass.FromMicrograms(value);

        /// <inheritdoc cref="Mass.FromMicrograms(double?)"/>
        public static Mass? Micrograms(this long? value) => Mass.FromMicrograms(value);

        /// <inheritdoc cref="Mass.FromMicrograms(double)"/>
        public static Mass Micrograms(this double value) => Mass.FromMicrograms(value);

        /// <inheritdoc cref="Mass.FromMicrograms(double?)"/>
        public static Mass? Micrograms(this double? value) => Mass.FromMicrograms(value);

        /// <inheritdoc cref="Mass.FromMicrograms(double)"/>
        public static Mass Micrograms(this float value) => Mass.FromMicrograms(value);

        /// <inheritdoc cref="Mass.FromMicrograms(double?)"/>
        public static Mass? Micrograms(this float? value) => Mass.FromMicrograms(value);

        /// <inheritdoc cref="Mass.FromMicrograms(double)"/>
        public static Mass Micrograms(this decimal value) => Mass.FromMicrograms(Convert.ToDouble(value));

        /// <inheritdoc cref="Mass.FromMicrograms(double?)"/>
        public static Mass? Micrograms(this decimal? value) => Mass.FromMicrograms(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Milligram

        /// <inheritdoc cref="Mass.FromMilligrams(double)"/>
        public static Mass Milligrams(this int value) => Mass.FromMilligrams(value);

        /// <inheritdoc cref="Mass.FromMilligrams(double?)"/>
        public static Mass? Milligrams(this int? value) => Mass.FromMilligrams(value);

        /// <inheritdoc cref="Mass.FromMilligrams(double)"/>
        public static Mass Milligrams(this long value) => Mass.FromMilligrams(value);

        /// <inheritdoc cref="Mass.FromMilligrams(double?)"/>
        public static Mass? Milligrams(this long? value) => Mass.FromMilligrams(value);

        /// <inheritdoc cref="Mass.FromMilligrams(double)"/>
        public static Mass Milligrams(this double value) => Mass.FromMilligrams(value);

        /// <inheritdoc cref="Mass.FromMilligrams(double?)"/>
        public static Mass? Milligrams(this double? value) => Mass.FromMilligrams(value);

        /// <inheritdoc cref="Mass.FromMilligrams(double)"/>
        public static Mass Milligrams(this float value) => Mass.FromMilligrams(value);

        /// <inheritdoc cref="Mass.FromMilligrams(double?)"/>
        public static Mass? Milligrams(this float? value) => Mass.FromMilligrams(value);

        /// <inheritdoc cref="Mass.FromMilligrams(double)"/>
        public static Mass Milligrams(this decimal value) => Mass.FromMilligrams(Convert.ToDouble(value));

        /// <inheritdoc cref="Mass.FromMilligrams(double?)"/>
        public static Mass? Milligrams(this decimal? value) => Mass.FromMilligrams(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Nanogram

        /// <inheritdoc cref="Mass.FromNanograms(double)"/>
        public static Mass Nanograms(this int value) => Mass.FromNanograms(value);

        /// <inheritdoc cref="Mass.FromNanograms(double?)"/>
        public static Mass? Nanograms(this int? value) => Mass.FromNanograms(value);

        /// <inheritdoc cref="Mass.FromNanograms(double)"/>
        public static Mass Nanograms(this long value) => Mass.FromNanograms(value);

        /// <inheritdoc cref="Mass.FromNanograms(double?)"/>
        public static Mass? Nanograms(this long? value) => Mass.FromNanograms(value);

        /// <inheritdoc cref="Mass.FromNanograms(double)"/>
        public static Mass Nanograms(this double value) => Mass.FromNanograms(value);

        /// <inheritdoc cref="Mass.FromNanograms(double?)"/>
        public static Mass? Nanograms(this double? value) => Mass.FromNanograms(value);

        /// <inheritdoc cref="Mass.FromNanograms(double)"/>
        public static Mass Nanograms(this float value) => Mass.FromNanograms(value);

        /// <inheritdoc cref="Mass.FromNanograms(double?)"/>
        public static Mass? Nanograms(this float? value) => Mass.FromNanograms(value);

        /// <inheritdoc cref="Mass.FromNanograms(double)"/>
        public static Mass Nanograms(this decimal value) => Mass.FromNanograms(Convert.ToDouble(value));

        /// <inheritdoc cref="Mass.FromNanograms(double?)"/>
        public static Mass? Nanograms(this decimal? value) => Mass.FromNanograms(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Ounce

        /// <inheritdoc cref="Mass.FromOunces(double)"/>
        public static Mass Ounces(this int value) => Mass.FromOunces(value);

        /// <inheritdoc cref="Mass.FromOunces(double?)"/>
        public static Mass? Ounces(this int? value) => Mass.FromOunces(value);

        /// <inheritdoc cref="Mass.FromOunces(double)"/>
        public static Mass Ounces(this long value) => Mass.FromOunces(value);

        /// <inheritdoc cref="Mass.FromOunces(double?)"/>
        public static Mass? Ounces(this long? value) => Mass.FromOunces(value);

        /// <inheritdoc cref="Mass.FromOunces(double)"/>
        public static Mass Ounces(this double value) => Mass.FromOunces(value);

        /// <inheritdoc cref="Mass.FromOunces(double?)"/>
        public static Mass? Ounces(this double? value) => Mass.FromOunces(value);

        /// <inheritdoc cref="Mass.FromOunces(double)"/>
        public static Mass Ounces(this float value) => Mass.FromOunces(value);

        /// <inheritdoc cref="Mass.FromOunces(double?)"/>
        public static Mass? Ounces(this float? value) => Mass.FromOunces(value);

        /// <inheritdoc cref="Mass.FromOunces(double)"/>
        public static Mass Ounces(this decimal value) => Mass.FromOunces(Convert.ToDouble(value));

        /// <inheritdoc cref="Mass.FromOunces(double?)"/>
        public static Mass? Ounces(this decimal? value) => Mass.FromOunces(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Pound

        /// <inheritdoc cref="Mass.FromPounds(double)"/>
        public static Mass Pounds(this int value) => Mass.FromPounds(value);

        /// <inheritdoc cref="Mass.FromPounds(double?)"/>
        public static Mass? Pounds(this int? value) => Mass.FromPounds(value);

        /// <inheritdoc cref="Mass.FromPounds(double)"/>
        public static Mass Pounds(this long value) => Mass.FromPounds(value);

        /// <inheritdoc cref="Mass.FromPounds(double?)"/>
        public static Mass? Pounds(this long? value) => Mass.FromPounds(value);

        /// <inheritdoc cref="Mass.FromPounds(double)"/>
        public static Mass Pounds(this double value) => Mass.FromPounds(value);

        /// <inheritdoc cref="Mass.FromPounds(double?)"/>
        public static Mass? Pounds(this double? value) => Mass.FromPounds(value);

        /// <inheritdoc cref="Mass.FromPounds(double)"/>
        public static Mass Pounds(this float value) => Mass.FromPounds(value);

        /// <inheritdoc cref="Mass.FromPounds(double?)"/>
        public static Mass? Pounds(this float? value) => Mass.FromPounds(value);

        /// <inheritdoc cref="Mass.FromPounds(double)"/>
        public static Mass Pounds(this decimal value) => Mass.FromPounds(Convert.ToDouble(value));

        /// <inheritdoc cref="Mass.FromPounds(double?)"/>
        public static Mass? Pounds(this decimal? value) => Mass.FromPounds(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region ShortTon

        /// <inheritdoc cref="Mass.FromShortTons(double)"/>
        public static Mass ShortTons(this int value) => Mass.FromShortTons(value);

        /// <inheritdoc cref="Mass.FromShortTons(double?)"/>
        public static Mass? ShortTons(this int? value) => Mass.FromShortTons(value);

        /// <inheritdoc cref="Mass.FromShortTons(double)"/>
        public static Mass ShortTons(this long value) => Mass.FromShortTons(value);

        /// <inheritdoc cref="Mass.FromShortTons(double?)"/>
        public static Mass? ShortTons(this long? value) => Mass.FromShortTons(value);

        /// <inheritdoc cref="Mass.FromShortTons(double)"/>
        public static Mass ShortTons(this double value) => Mass.FromShortTons(value);

        /// <inheritdoc cref="Mass.FromShortTons(double?)"/>
        public static Mass? ShortTons(this double? value) => Mass.FromShortTons(value);

        /// <inheritdoc cref="Mass.FromShortTons(double)"/>
        public static Mass ShortTons(this float value) => Mass.FromShortTons(value);

        /// <inheritdoc cref="Mass.FromShortTons(double?)"/>
        public static Mass? ShortTons(this float? value) => Mass.FromShortTons(value);

        /// <inheritdoc cref="Mass.FromShortTons(double)"/>
        public static Mass ShortTons(this decimal value) => Mass.FromShortTons(Convert.ToDouble(value));

        /// <inheritdoc cref="Mass.FromShortTons(double?)"/>
        public static Mass? ShortTons(this decimal? value) => Mass.FromShortTons(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Stone

        /// <inheritdoc cref="Mass.FromStone(double)"/>
        public static Mass Stone(this int value) => Mass.FromStone(value);

        /// <inheritdoc cref="Mass.FromStone(double?)"/>
        public static Mass? Stone(this int? value) => Mass.FromStone(value);

        /// <inheritdoc cref="Mass.FromStone(double)"/>
        public static Mass Stone(this long value) => Mass.FromStone(value);

        /// <inheritdoc cref="Mass.FromStone(double?)"/>
        public static Mass? Stone(this long? value) => Mass.FromStone(value);

        /// <inheritdoc cref="Mass.FromStone(double)"/>
        public static Mass Stone(this double value) => Mass.FromStone(value);

        /// <inheritdoc cref="Mass.FromStone(double?)"/>
        public static Mass? Stone(this double? value) => Mass.FromStone(value);

        /// <inheritdoc cref="Mass.FromStone(double)"/>
        public static Mass Stone(this float value) => Mass.FromStone(value);

        /// <inheritdoc cref="Mass.FromStone(double?)"/>
        public static Mass? Stone(this float? value) => Mass.FromStone(value);

        /// <inheritdoc cref="Mass.FromStone(double)"/>
        public static Mass Stone(this decimal value) => Mass.FromStone(Convert.ToDouble(value));

        /// <inheritdoc cref="Mass.FromStone(double?)"/>
        public static Mass? Stone(this decimal? value) => Mass.FromStone(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Tonne

        /// <inheritdoc cref="Mass.FromTonnes(double)"/>
        public static Mass Tonnes(this int value) => Mass.FromTonnes(value);

        /// <inheritdoc cref="Mass.FromTonnes(double?)"/>
        public static Mass? Tonnes(this int? value) => Mass.FromTonnes(value);

        /// <inheritdoc cref="Mass.FromTonnes(double)"/>
        public static Mass Tonnes(this long value) => Mass.FromTonnes(value);

        /// <inheritdoc cref="Mass.FromTonnes(double?)"/>
        public static Mass? Tonnes(this long? value) => Mass.FromTonnes(value);

        /// <inheritdoc cref="Mass.FromTonnes(double)"/>
        public static Mass Tonnes(this double value) => Mass.FromTonnes(value);

        /// <inheritdoc cref="Mass.FromTonnes(double?)"/>
        public static Mass? Tonnes(this double? value) => Mass.FromTonnes(value);

        /// <inheritdoc cref="Mass.FromTonnes(double)"/>
        public static Mass Tonnes(this float value) => Mass.FromTonnes(value);

        /// <inheritdoc cref="Mass.FromTonnes(double?)"/>
        public static Mass? Tonnes(this float? value) => Mass.FromTonnes(value);

        /// <inheritdoc cref="Mass.FromTonnes(double)"/>
        public static Mass Tonnes(this decimal value) => Mass.FromTonnes(Convert.ToDouble(value));

        /// <inheritdoc cref="Mass.FromTonnes(double?)"/>
        public static Mass? Tonnes(this decimal? value) => Mass.FromTonnes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
