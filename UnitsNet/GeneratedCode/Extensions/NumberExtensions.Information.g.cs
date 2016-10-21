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
        #region Bit

        /// <inheritdoc cref="Information.FromBits(double)"/>
        public static Information Bits(this int value) => Information.FromBits(value);

        /// <inheritdoc cref="Information.FromBits(double?)"/>
        public static Information? Bits(this int? value) => Information.FromBits(value);

        /// <inheritdoc cref="Information.FromBits(double)"/>
        public static Information Bits(this long value) => Information.FromBits(value);

        /// <inheritdoc cref="Information.FromBits(double?)"/>
        public static Information? Bits(this long? value) => Information.FromBits(value);

        /// <inheritdoc cref="Information.FromBits(double)"/>
        public static Information Bits(this double value) => Information.FromBits(value);

        /// <inheritdoc cref="Information.FromBits(double?)"/>
        public static Information? Bits(this double? value) => Information.FromBits(value);

        /// <inheritdoc cref="Information.FromBits(double)"/>
        public static Information Bits(this float value) => Information.FromBits(value);

        /// <inheritdoc cref="Information.FromBits(double?)"/>
        public static Information? Bits(this float? value) => Information.FromBits(value);

        /// <inheritdoc cref="Information.FromBits(double)"/>
        public static Information Bits(this decimal value) => Information.FromBits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromBits(double?)"/>
        public static Information? Bits(this decimal? value) => Information.FromBits(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Byte

        /// <inheritdoc cref="Information.FromBytes(double)"/>
        public static Information Bytes(this int value) => Information.FromBytes(value);

        /// <inheritdoc cref="Information.FromBytes(double?)"/>
        public static Information? Bytes(this int? value) => Information.FromBytes(value);

        /// <inheritdoc cref="Information.FromBytes(double)"/>
        public static Information Bytes(this long value) => Information.FromBytes(value);

        /// <inheritdoc cref="Information.FromBytes(double?)"/>
        public static Information? Bytes(this long? value) => Information.FromBytes(value);

        /// <inheritdoc cref="Information.FromBytes(double)"/>
        public static Information Bytes(this double value) => Information.FromBytes(value);

        /// <inheritdoc cref="Information.FromBytes(double?)"/>
        public static Information? Bytes(this double? value) => Information.FromBytes(value);

        /// <inheritdoc cref="Information.FromBytes(double)"/>
        public static Information Bytes(this float value) => Information.FromBytes(value);

        /// <inheritdoc cref="Information.FromBytes(double?)"/>
        public static Information? Bytes(this float? value) => Information.FromBytes(value);

        /// <inheritdoc cref="Information.FromBytes(double)"/>
        public static Information Bytes(this decimal value) => Information.FromBytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromBytes(double?)"/>
        public static Information? Bytes(this decimal? value) => Information.FromBytes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Exabit

        /// <inheritdoc cref="Information.FromExabits(double)"/>
        public static Information Exabits(this int value) => Information.FromExabits(value);

        /// <inheritdoc cref="Information.FromExabits(double?)"/>
        public static Information? Exabits(this int? value) => Information.FromExabits(value);

        /// <inheritdoc cref="Information.FromExabits(double)"/>
        public static Information Exabits(this long value) => Information.FromExabits(value);

        /// <inheritdoc cref="Information.FromExabits(double?)"/>
        public static Information? Exabits(this long? value) => Information.FromExabits(value);

        /// <inheritdoc cref="Information.FromExabits(double)"/>
        public static Information Exabits(this double value) => Information.FromExabits(value);

        /// <inheritdoc cref="Information.FromExabits(double?)"/>
        public static Information? Exabits(this double? value) => Information.FromExabits(value);

        /// <inheritdoc cref="Information.FromExabits(double)"/>
        public static Information Exabits(this float value) => Information.FromExabits(value);

        /// <inheritdoc cref="Information.FromExabits(double?)"/>
        public static Information? Exabits(this float? value) => Information.FromExabits(value);

        /// <inheritdoc cref="Information.FromExabits(double)"/>
        public static Information Exabits(this decimal value) => Information.FromExabits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromExabits(double?)"/>
        public static Information? Exabits(this decimal? value) => Information.FromExabits(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Exabyte

        /// <inheritdoc cref="Information.FromExabytes(double)"/>
        public static Information Exabytes(this int value) => Information.FromExabytes(value);

        /// <inheritdoc cref="Information.FromExabytes(double?)"/>
        public static Information? Exabytes(this int? value) => Information.FromExabytes(value);

        /// <inheritdoc cref="Information.FromExabytes(double)"/>
        public static Information Exabytes(this long value) => Information.FromExabytes(value);

        /// <inheritdoc cref="Information.FromExabytes(double?)"/>
        public static Information? Exabytes(this long? value) => Information.FromExabytes(value);

        /// <inheritdoc cref="Information.FromExabytes(double)"/>
        public static Information Exabytes(this double value) => Information.FromExabytes(value);

        /// <inheritdoc cref="Information.FromExabytes(double?)"/>
        public static Information? Exabytes(this double? value) => Information.FromExabytes(value);

        /// <inheritdoc cref="Information.FromExabytes(double)"/>
        public static Information Exabytes(this float value) => Information.FromExabytes(value);

        /// <inheritdoc cref="Information.FromExabytes(double?)"/>
        public static Information? Exabytes(this float? value) => Information.FromExabytes(value);

        /// <inheritdoc cref="Information.FromExabytes(double)"/>
        public static Information Exabytes(this decimal value) => Information.FromExabytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromExabytes(double?)"/>
        public static Information? Exabytes(this decimal? value) => Information.FromExabytes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Exbibit

        /// <inheritdoc cref="Information.FromExbibits(double)"/>
        public static Information Exbibits(this int value) => Information.FromExbibits(value);

        /// <inheritdoc cref="Information.FromExbibits(double?)"/>
        public static Information? Exbibits(this int? value) => Information.FromExbibits(value);

        /// <inheritdoc cref="Information.FromExbibits(double)"/>
        public static Information Exbibits(this long value) => Information.FromExbibits(value);

        /// <inheritdoc cref="Information.FromExbibits(double?)"/>
        public static Information? Exbibits(this long? value) => Information.FromExbibits(value);

        /// <inheritdoc cref="Information.FromExbibits(double)"/>
        public static Information Exbibits(this double value) => Information.FromExbibits(value);

        /// <inheritdoc cref="Information.FromExbibits(double?)"/>
        public static Information? Exbibits(this double? value) => Information.FromExbibits(value);

        /// <inheritdoc cref="Information.FromExbibits(double)"/>
        public static Information Exbibits(this float value) => Information.FromExbibits(value);

        /// <inheritdoc cref="Information.FromExbibits(double?)"/>
        public static Information? Exbibits(this float? value) => Information.FromExbibits(value);

        /// <inheritdoc cref="Information.FromExbibits(double)"/>
        public static Information Exbibits(this decimal value) => Information.FromExbibits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromExbibits(double?)"/>
        public static Information? Exbibits(this decimal? value) => Information.FromExbibits(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Exbibyte

        /// <inheritdoc cref="Information.FromExbibytes(double)"/>
        public static Information Exbibytes(this int value) => Information.FromExbibytes(value);

        /// <inheritdoc cref="Information.FromExbibytes(double?)"/>
        public static Information? Exbibytes(this int? value) => Information.FromExbibytes(value);

        /// <inheritdoc cref="Information.FromExbibytes(double)"/>
        public static Information Exbibytes(this long value) => Information.FromExbibytes(value);

        /// <inheritdoc cref="Information.FromExbibytes(double?)"/>
        public static Information? Exbibytes(this long? value) => Information.FromExbibytes(value);

        /// <inheritdoc cref="Information.FromExbibytes(double)"/>
        public static Information Exbibytes(this double value) => Information.FromExbibytes(value);

        /// <inheritdoc cref="Information.FromExbibytes(double?)"/>
        public static Information? Exbibytes(this double? value) => Information.FromExbibytes(value);

        /// <inheritdoc cref="Information.FromExbibytes(double)"/>
        public static Information Exbibytes(this float value) => Information.FromExbibytes(value);

        /// <inheritdoc cref="Information.FromExbibytes(double?)"/>
        public static Information? Exbibytes(this float? value) => Information.FromExbibytes(value);

        /// <inheritdoc cref="Information.FromExbibytes(double)"/>
        public static Information Exbibytes(this decimal value) => Information.FromExbibytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromExbibytes(double?)"/>
        public static Information? Exbibytes(this decimal? value) => Information.FromExbibytes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Gibibit

        /// <inheritdoc cref="Information.FromGibibits(double)"/>
        public static Information Gibibits(this int value) => Information.FromGibibits(value);

        /// <inheritdoc cref="Information.FromGibibits(double?)"/>
        public static Information? Gibibits(this int? value) => Information.FromGibibits(value);

        /// <inheritdoc cref="Information.FromGibibits(double)"/>
        public static Information Gibibits(this long value) => Information.FromGibibits(value);

        /// <inheritdoc cref="Information.FromGibibits(double?)"/>
        public static Information? Gibibits(this long? value) => Information.FromGibibits(value);

        /// <inheritdoc cref="Information.FromGibibits(double)"/>
        public static Information Gibibits(this double value) => Information.FromGibibits(value);

        /// <inheritdoc cref="Information.FromGibibits(double?)"/>
        public static Information? Gibibits(this double? value) => Information.FromGibibits(value);

        /// <inheritdoc cref="Information.FromGibibits(double)"/>
        public static Information Gibibits(this float value) => Information.FromGibibits(value);

        /// <inheritdoc cref="Information.FromGibibits(double?)"/>
        public static Information? Gibibits(this float? value) => Information.FromGibibits(value);

        /// <inheritdoc cref="Information.FromGibibits(double)"/>
        public static Information Gibibits(this decimal value) => Information.FromGibibits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromGibibits(double?)"/>
        public static Information? Gibibits(this decimal? value) => Information.FromGibibits(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Gibibyte

        /// <inheritdoc cref="Information.FromGibibytes(double)"/>
        public static Information Gibibytes(this int value) => Information.FromGibibytes(value);

        /// <inheritdoc cref="Information.FromGibibytes(double?)"/>
        public static Information? Gibibytes(this int? value) => Information.FromGibibytes(value);

        /// <inheritdoc cref="Information.FromGibibytes(double)"/>
        public static Information Gibibytes(this long value) => Information.FromGibibytes(value);

        /// <inheritdoc cref="Information.FromGibibytes(double?)"/>
        public static Information? Gibibytes(this long? value) => Information.FromGibibytes(value);

        /// <inheritdoc cref="Information.FromGibibytes(double)"/>
        public static Information Gibibytes(this double value) => Information.FromGibibytes(value);

        /// <inheritdoc cref="Information.FromGibibytes(double?)"/>
        public static Information? Gibibytes(this double? value) => Information.FromGibibytes(value);

        /// <inheritdoc cref="Information.FromGibibytes(double)"/>
        public static Information Gibibytes(this float value) => Information.FromGibibytes(value);

        /// <inheritdoc cref="Information.FromGibibytes(double?)"/>
        public static Information? Gibibytes(this float? value) => Information.FromGibibytes(value);

        /// <inheritdoc cref="Information.FromGibibytes(double)"/>
        public static Information Gibibytes(this decimal value) => Information.FromGibibytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromGibibytes(double?)"/>
        public static Information? Gibibytes(this decimal? value) => Information.FromGibibytes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Gigabit

        /// <inheritdoc cref="Information.FromGigabits(double)"/>
        public static Information Gigabits(this int value) => Information.FromGigabits(value);

        /// <inheritdoc cref="Information.FromGigabits(double?)"/>
        public static Information? Gigabits(this int? value) => Information.FromGigabits(value);

        /// <inheritdoc cref="Information.FromGigabits(double)"/>
        public static Information Gigabits(this long value) => Information.FromGigabits(value);

        /// <inheritdoc cref="Information.FromGigabits(double?)"/>
        public static Information? Gigabits(this long? value) => Information.FromGigabits(value);

        /// <inheritdoc cref="Information.FromGigabits(double)"/>
        public static Information Gigabits(this double value) => Information.FromGigabits(value);

        /// <inheritdoc cref="Information.FromGigabits(double?)"/>
        public static Information? Gigabits(this double? value) => Information.FromGigabits(value);

        /// <inheritdoc cref="Information.FromGigabits(double)"/>
        public static Information Gigabits(this float value) => Information.FromGigabits(value);

        /// <inheritdoc cref="Information.FromGigabits(double?)"/>
        public static Information? Gigabits(this float? value) => Information.FromGigabits(value);

        /// <inheritdoc cref="Information.FromGigabits(double)"/>
        public static Information Gigabits(this decimal value) => Information.FromGigabits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromGigabits(double?)"/>
        public static Information? Gigabits(this decimal? value) => Information.FromGigabits(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Gigabyte

        /// <inheritdoc cref="Information.FromGigabytes(double)"/>
        public static Information Gigabytes(this int value) => Information.FromGigabytes(value);

        /// <inheritdoc cref="Information.FromGigabytes(double?)"/>
        public static Information? Gigabytes(this int? value) => Information.FromGigabytes(value);

        /// <inheritdoc cref="Information.FromGigabytes(double)"/>
        public static Information Gigabytes(this long value) => Information.FromGigabytes(value);

        /// <inheritdoc cref="Information.FromGigabytes(double?)"/>
        public static Information? Gigabytes(this long? value) => Information.FromGigabytes(value);

        /// <inheritdoc cref="Information.FromGigabytes(double)"/>
        public static Information Gigabytes(this double value) => Information.FromGigabytes(value);

        /// <inheritdoc cref="Information.FromGigabytes(double?)"/>
        public static Information? Gigabytes(this double? value) => Information.FromGigabytes(value);

        /// <inheritdoc cref="Information.FromGigabytes(double)"/>
        public static Information Gigabytes(this float value) => Information.FromGigabytes(value);

        /// <inheritdoc cref="Information.FromGigabytes(double?)"/>
        public static Information? Gigabytes(this float? value) => Information.FromGigabytes(value);

        /// <inheritdoc cref="Information.FromGigabytes(double)"/>
        public static Information Gigabytes(this decimal value) => Information.FromGigabytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromGigabytes(double?)"/>
        public static Information? Gigabytes(this decimal? value) => Information.FromGigabytes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kibibit

        /// <inheritdoc cref="Information.FromKibibits(double)"/>
        public static Information Kibibits(this int value) => Information.FromKibibits(value);

        /// <inheritdoc cref="Information.FromKibibits(double?)"/>
        public static Information? Kibibits(this int? value) => Information.FromKibibits(value);

        /// <inheritdoc cref="Information.FromKibibits(double)"/>
        public static Information Kibibits(this long value) => Information.FromKibibits(value);

        /// <inheritdoc cref="Information.FromKibibits(double?)"/>
        public static Information? Kibibits(this long? value) => Information.FromKibibits(value);

        /// <inheritdoc cref="Information.FromKibibits(double)"/>
        public static Information Kibibits(this double value) => Information.FromKibibits(value);

        /// <inheritdoc cref="Information.FromKibibits(double?)"/>
        public static Information? Kibibits(this double? value) => Information.FromKibibits(value);

        /// <inheritdoc cref="Information.FromKibibits(double)"/>
        public static Information Kibibits(this float value) => Information.FromKibibits(value);

        /// <inheritdoc cref="Information.FromKibibits(double?)"/>
        public static Information? Kibibits(this float? value) => Information.FromKibibits(value);

        /// <inheritdoc cref="Information.FromKibibits(double)"/>
        public static Information Kibibits(this decimal value) => Information.FromKibibits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromKibibits(double?)"/>
        public static Information? Kibibits(this decimal? value) => Information.FromKibibits(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kibibyte

        /// <inheritdoc cref="Information.FromKibibytes(double)"/>
        public static Information Kibibytes(this int value) => Information.FromKibibytes(value);

        /// <inheritdoc cref="Information.FromKibibytes(double?)"/>
        public static Information? Kibibytes(this int? value) => Information.FromKibibytes(value);

        /// <inheritdoc cref="Information.FromKibibytes(double)"/>
        public static Information Kibibytes(this long value) => Information.FromKibibytes(value);

        /// <inheritdoc cref="Information.FromKibibytes(double?)"/>
        public static Information? Kibibytes(this long? value) => Information.FromKibibytes(value);

        /// <inheritdoc cref="Information.FromKibibytes(double)"/>
        public static Information Kibibytes(this double value) => Information.FromKibibytes(value);

        /// <inheritdoc cref="Information.FromKibibytes(double?)"/>
        public static Information? Kibibytes(this double? value) => Information.FromKibibytes(value);

        /// <inheritdoc cref="Information.FromKibibytes(double)"/>
        public static Information Kibibytes(this float value) => Information.FromKibibytes(value);

        /// <inheritdoc cref="Information.FromKibibytes(double?)"/>
        public static Information? Kibibytes(this float? value) => Information.FromKibibytes(value);

        /// <inheritdoc cref="Information.FromKibibytes(double)"/>
        public static Information Kibibytes(this decimal value) => Information.FromKibibytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromKibibytes(double?)"/>
        public static Information? Kibibytes(this decimal? value) => Information.FromKibibytes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kilobit

        /// <inheritdoc cref="Information.FromKilobits(double)"/>
        public static Information Kilobits(this int value) => Information.FromKilobits(value);

        /// <inheritdoc cref="Information.FromKilobits(double?)"/>
        public static Information? Kilobits(this int? value) => Information.FromKilobits(value);

        /// <inheritdoc cref="Information.FromKilobits(double)"/>
        public static Information Kilobits(this long value) => Information.FromKilobits(value);

        /// <inheritdoc cref="Information.FromKilobits(double?)"/>
        public static Information? Kilobits(this long? value) => Information.FromKilobits(value);

        /// <inheritdoc cref="Information.FromKilobits(double)"/>
        public static Information Kilobits(this double value) => Information.FromKilobits(value);

        /// <inheritdoc cref="Information.FromKilobits(double?)"/>
        public static Information? Kilobits(this double? value) => Information.FromKilobits(value);

        /// <inheritdoc cref="Information.FromKilobits(double)"/>
        public static Information Kilobits(this float value) => Information.FromKilobits(value);

        /// <inheritdoc cref="Information.FromKilobits(double?)"/>
        public static Information? Kilobits(this float? value) => Information.FromKilobits(value);

        /// <inheritdoc cref="Information.FromKilobits(double)"/>
        public static Information Kilobits(this decimal value) => Information.FromKilobits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromKilobits(double?)"/>
        public static Information? Kilobits(this decimal? value) => Information.FromKilobits(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kilobyte

        /// <inheritdoc cref="Information.FromKilobytes(double)"/>
        public static Information Kilobytes(this int value) => Information.FromKilobytes(value);

        /// <inheritdoc cref="Information.FromKilobytes(double?)"/>
        public static Information? Kilobytes(this int? value) => Information.FromKilobytes(value);

        /// <inheritdoc cref="Information.FromKilobytes(double)"/>
        public static Information Kilobytes(this long value) => Information.FromKilobytes(value);

        /// <inheritdoc cref="Information.FromKilobytes(double?)"/>
        public static Information? Kilobytes(this long? value) => Information.FromKilobytes(value);

        /// <inheritdoc cref="Information.FromKilobytes(double)"/>
        public static Information Kilobytes(this double value) => Information.FromKilobytes(value);

        /// <inheritdoc cref="Information.FromKilobytes(double?)"/>
        public static Information? Kilobytes(this double? value) => Information.FromKilobytes(value);

        /// <inheritdoc cref="Information.FromKilobytes(double)"/>
        public static Information Kilobytes(this float value) => Information.FromKilobytes(value);

        /// <inheritdoc cref="Information.FromKilobytes(double?)"/>
        public static Information? Kilobytes(this float? value) => Information.FromKilobytes(value);

        /// <inheritdoc cref="Information.FromKilobytes(double)"/>
        public static Information Kilobytes(this decimal value) => Information.FromKilobytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromKilobytes(double?)"/>
        public static Information? Kilobytes(this decimal? value) => Information.FromKilobytes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Mebibit

        /// <inheritdoc cref="Information.FromMebibits(double)"/>
        public static Information Mebibits(this int value) => Information.FromMebibits(value);

        /// <inheritdoc cref="Information.FromMebibits(double?)"/>
        public static Information? Mebibits(this int? value) => Information.FromMebibits(value);

        /// <inheritdoc cref="Information.FromMebibits(double)"/>
        public static Information Mebibits(this long value) => Information.FromMebibits(value);

        /// <inheritdoc cref="Information.FromMebibits(double?)"/>
        public static Information? Mebibits(this long? value) => Information.FromMebibits(value);

        /// <inheritdoc cref="Information.FromMebibits(double)"/>
        public static Information Mebibits(this double value) => Information.FromMebibits(value);

        /// <inheritdoc cref="Information.FromMebibits(double?)"/>
        public static Information? Mebibits(this double? value) => Information.FromMebibits(value);

        /// <inheritdoc cref="Information.FromMebibits(double)"/>
        public static Information Mebibits(this float value) => Information.FromMebibits(value);

        /// <inheritdoc cref="Information.FromMebibits(double?)"/>
        public static Information? Mebibits(this float? value) => Information.FromMebibits(value);

        /// <inheritdoc cref="Information.FromMebibits(double)"/>
        public static Information Mebibits(this decimal value) => Information.FromMebibits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromMebibits(double?)"/>
        public static Information? Mebibits(this decimal? value) => Information.FromMebibits(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Mebibyte

        /// <inheritdoc cref="Information.FromMebibytes(double)"/>
        public static Information Mebibytes(this int value) => Information.FromMebibytes(value);

        /// <inheritdoc cref="Information.FromMebibytes(double?)"/>
        public static Information? Mebibytes(this int? value) => Information.FromMebibytes(value);

        /// <inheritdoc cref="Information.FromMebibytes(double)"/>
        public static Information Mebibytes(this long value) => Information.FromMebibytes(value);

        /// <inheritdoc cref="Information.FromMebibytes(double?)"/>
        public static Information? Mebibytes(this long? value) => Information.FromMebibytes(value);

        /// <inheritdoc cref="Information.FromMebibytes(double)"/>
        public static Information Mebibytes(this double value) => Information.FromMebibytes(value);

        /// <inheritdoc cref="Information.FromMebibytes(double?)"/>
        public static Information? Mebibytes(this double? value) => Information.FromMebibytes(value);

        /// <inheritdoc cref="Information.FromMebibytes(double)"/>
        public static Information Mebibytes(this float value) => Information.FromMebibytes(value);

        /// <inheritdoc cref="Information.FromMebibytes(double?)"/>
        public static Information? Mebibytes(this float? value) => Information.FromMebibytes(value);

        /// <inheritdoc cref="Information.FromMebibytes(double)"/>
        public static Information Mebibytes(this decimal value) => Information.FromMebibytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromMebibytes(double?)"/>
        public static Information? Mebibytes(this decimal? value) => Information.FromMebibytes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Megabit

        /// <inheritdoc cref="Information.FromMegabits(double)"/>
        public static Information Megabits(this int value) => Information.FromMegabits(value);

        /// <inheritdoc cref="Information.FromMegabits(double?)"/>
        public static Information? Megabits(this int? value) => Information.FromMegabits(value);

        /// <inheritdoc cref="Information.FromMegabits(double)"/>
        public static Information Megabits(this long value) => Information.FromMegabits(value);

        /// <inheritdoc cref="Information.FromMegabits(double?)"/>
        public static Information? Megabits(this long? value) => Information.FromMegabits(value);

        /// <inheritdoc cref="Information.FromMegabits(double)"/>
        public static Information Megabits(this double value) => Information.FromMegabits(value);

        /// <inheritdoc cref="Information.FromMegabits(double?)"/>
        public static Information? Megabits(this double? value) => Information.FromMegabits(value);

        /// <inheritdoc cref="Information.FromMegabits(double)"/>
        public static Information Megabits(this float value) => Information.FromMegabits(value);

        /// <inheritdoc cref="Information.FromMegabits(double?)"/>
        public static Information? Megabits(this float? value) => Information.FromMegabits(value);

        /// <inheritdoc cref="Information.FromMegabits(double)"/>
        public static Information Megabits(this decimal value) => Information.FromMegabits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromMegabits(double?)"/>
        public static Information? Megabits(this decimal? value) => Information.FromMegabits(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Megabyte

        /// <inheritdoc cref="Information.FromMegabytes(double)"/>
        public static Information Megabytes(this int value) => Information.FromMegabytes(value);

        /// <inheritdoc cref="Information.FromMegabytes(double?)"/>
        public static Information? Megabytes(this int? value) => Information.FromMegabytes(value);

        /// <inheritdoc cref="Information.FromMegabytes(double)"/>
        public static Information Megabytes(this long value) => Information.FromMegabytes(value);

        /// <inheritdoc cref="Information.FromMegabytes(double?)"/>
        public static Information? Megabytes(this long? value) => Information.FromMegabytes(value);

        /// <inheritdoc cref="Information.FromMegabytes(double)"/>
        public static Information Megabytes(this double value) => Information.FromMegabytes(value);

        /// <inheritdoc cref="Information.FromMegabytes(double?)"/>
        public static Information? Megabytes(this double? value) => Information.FromMegabytes(value);

        /// <inheritdoc cref="Information.FromMegabytes(double)"/>
        public static Information Megabytes(this float value) => Information.FromMegabytes(value);

        /// <inheritdoc cref="Information.FromMegabytes(double?)"/>
        public static Information? Megabytes(this float? value) => Information.FromMegabytes(value);

        /// <inheritdoc cref="Information.FromMegabytes(double)"/>
        public static Information Megabytes(this decimal value) => Information.FromMegabytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromMegabytes(double?)"/>
        public static Information? Megabytes(this decimal? value) => Information.FromMegabytes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Pebibit

        /// <inheritdoc cref="Information.FromPebibits(double)"/>
        public static Information Pebibits(this int value) => Information.FromPebibits(value);

        /// <inheritdoc cref="Information.FromPebibits(double?)"/>
        public static Information? Pebibits(this int? value) => Information.FromPebibits(value);

        /// <inheritdoc cref="Information.FromPebibits(double)"/>
        public static Information Pebibits(this long value) => Information.FromPebibits(value);

        /// <inheritdoc cref="Information.FromPebibits(double?)"/>
        public static Information? Pebibits(this long? value) => Information.FromPebibits(value);

        /// <inheritdoc cref="Information.FromPebibits(double)"/>
        public static Information Pebibits(this double value) => Information.FromPebibits(value);

        /// <inheritdoc cref="Information.FromPebibits(double?)"/>
        public static Information? Pebibits(this double? value) => Information.FromPebibits(value);

        /// <inheritdoc cref="Information.FromPebibits(double)"/>
        public static Information Pebibits(this float value) => Information.FromPebibits(value);

        /// <inheritdoc cref="Information.FromPebibits(double?)"/>
        public static Information? Pebibits(this float? value) => Information.FromPebibits(value);

        /// <inheritdoc cref="Information.FromPebibits(double)"/>
        public static Information Pebibits(this decimal value) => Information.FromPebibits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromPebibits(double?)"/>
        public static Information? Pebibits(this decimal? value) => Information.FromPebibits(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Pebibyte

        /// <inheritdoc cref="Information.FromPebibytes(double)"/>
        public static Information Pebibytes(this int value) => Information.FromPebibytes(value);

        /// <inheritdoc cref="Information.FromPebibytes(double?)"/>
        public static Information? Pebibytes(this int? value) => Information.FromPebibytes(value);

        /// <inheritdoc cref="Information.FromPebibytes(double)"/>
        public static Information Pebibytes(this long value) => Information.FromPebibytes(value);

        /// <inheritdoc cref="Information.FromPebibytes(double?)"/>
        public static Information? Pebibytes(this long? value) => Information.FromPebibytes(value);

        /// <inheritdoc cref="Information.FromPebibytes(double)"/>
        public static Information Pebibytes(this double value) => Information.FromPebibytes(value);

        /// <inheritdoc cref="Information.FromPebibytes(double?)"/>
        public static Information? Pebibytes(this double? value) => Information.FromPebibytes(value);

        /// <inheritdoc cref="Information.FromPebibytes(double)"/>
        public static Information Pebibytes(this float value) => Information.FromPebibytes(value);

        /// <inheritdoc cref="Information.FromPebibytes(double?)"/>
        public static Information? Pebibytes(this float? value) => Information.FromPebibytes(value);

        /// <inheritdoc cref="Information.FromPebibytes(double)"/>
        public static Information Pebibytes(this decimal value) => Information.FromPebibytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromPebibytes(double?)"/>
        public static Information? Pebibytes(this decimal? value) => Information.FromPebibytes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Petabit

        /// <inheritdoc cref="Information.FromPetabits(double)"/>
        public static Information Petabits(this int value) => Information.FromPetabits(value);

        /// <inheritdoc cref="Information.FromPetabits(double?)"/>
        public static Information? Petabits(this int? value) => Information.FromPetabits(value);

        /// <inheritdoc cref="Information.FromPetabits(double)"/>
        public static Information Petabits(this long value) => Information.FromPetabits(value);

        /// <inheritdoc cref="Information.FromPetabits(double?)"/>
        public static Information? Petabits(this long? value) => Information.FromPetabits(value);

        /// <inheritdoc cref="Information.FromPetabits(double)"/>
        public static Information Petabits(this double value) => Information.FromPetabits(value);

        /// <inheritdoc cref="Information.FromPetabits(double?)"/>
        public static Information? Petabits(this double? value) => Information.FromPetabits(value);

        /// <inheritdoc cref="Information.FromPetabits(double)"/>
        public static Information Petabits(this float value) => Information.FromPetabits(value);

        /// <inheritdoc cref="Information.FromPetabits(double?)"/>
        public static Information? Petabits(this float? value) => Information.FromPetabits(value);

        /// <inheritdoc cref="Information.FromPetabits(double)"/>
        public static Information Petabits(this decimal value) => Information.FromPetabits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromPetabits(double?)"/>
        public static Information? Petabits(this decimal? value) => Information.FromPetabits(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Petabyte

        /// <inheritdoc cref="Information.FromPetabytes(double)"/>
        public static Information Petabytes(this int value) => Information.FromPetabytes(value);

        /// <inheritdoc cref="Information.FromPetabytes(double?)"/>
        public static Information? Petabytes(this int? value) => Information.FromPetabytes(value);

        /// <inheritdoc cref="Information.FromPetabytes(double)"/>
        public static Information Petabytes(this long value) => Information.FromPetabytes(value);

        /// <inheritdoc cref="Information.FromPetabytes(double?)"/>
        public static Information? Petabytes(this long? value) => Information.FromPetabytes(value);

        /// <inheritdoc cref="Information.FromPetabytes(double)"/>
        public static Information Petabytes(this double value) => Information.FromPetabytes(value);

        /// <inheritdoc cref="Information.FromPetabytes(double?)"/>
        public static Information? Petabytes(this double? value) => Information.FromPetabytes(value);

        /// <inheritdoc cref="Information.FromPetabytes(double)"/>
        public static Information Petabytes(this float value) => Information.FromPetabytes(value);

        /// <inheritdoc cref="Information.FromPetabytes(double?)"/>
        public static Information? Petabytes(this float? value) => Information.FromPetabytes(value);

        /// <inheritdoc cref="Information.FromPetabytes(double)"/>
        public static Information Petabytes(this decimal value) => Information.FromPetabytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromPetabytes(double?)"/>
        public static Information? Petabytes(this decimal? value) => Information.FromPetabytes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Tebibit

        /// <inheritdoc cref="Information.FromTebibits(double)"/>
        public static Information Tebibits(this int value) => Information.FromTebibits(value);

        /// <inheritdoc cref="Information.FromTebibits(double?)"/>
        public static Information? Tebibits(this int? value) => Information.FromTebibits(value);

        /// <inheritdoc cref="Information.FromTebibits(double)"/>
        public static Information Tebibits(this long value) => Information.FromTebibits(value);

        /// <inheritdoc cref="Information.FromTebibits(double?)"/>
        public static Information? Tebibits(this long? value) => Information.FromTebibits(value);

        /// <inheritdoc cref="Information.FromTebibits(double)"/>
        public static Information Tebibits(this double value) => Information.FromTebibits(value);

        /// <inheritdoc cref="Information.FromTebibits(double?)"/>
        public static Information? Tebibits(this double? value) => Information.FromTebibits(value);

        /// <inheritdoc cref="Information.FromTebibits(double)"/>
        public static Information Tebibits(this float value) => Information.FromTebibits(value);

        /// <inheritdoc cref="Information.FromTebibits(double?)"/>
        public static Information? Tebibits(this float? value) => Information.FromTebibits(value);

        /// <inheritdoc cref="Information.FromTebibits(double)"/>
        public static Information Tebibits(this decimal value) => Information.FromTebibits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromTebibits(double?)"/>
        public static Information? Tebibits(this decimal? value) => Information.FromTebibits(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Tebibyte

        /// <inheritdoc cref="Information.FromTebibytes(double)"/>
        public static Information Tebibytes(this int value) => Information.FromTebibytes(value);

        /// <inheritdoc cref="Information.FromTebibytes(double?)"/>
        public static Information? Tebibytes(this int? value) => Information.FromTebibytes(value);

        /// <inheritdoc cref="Information.FromTebibytes(double)"/>
        public static Information Tebibytes(this long value) => Information.FromTebibytes(value);

        /// <inheritdoc cref="Information.FromTebibytes(double?)"/>
        public static Information? Tebibytes(this long? value) => Information.FromTebibytes(value);

        /// <inheritdoc cref="Information.FromTebibytes(double)"/>
        public static Information Tebibytes(this double value) => Information.FromTebibytes(value);

        /// <inheritdoc cref="Information.FromTebibytes(double?)"/>
        public static Information? Tebibytes(this double? value) => Information.FromTebibytes(value);

        /// <inheritdoc cref="Information.FromTebibytes(double)"/>
        public static Information Tebibytes(this float value) => Information.FromTebibytes(value);

        /// <inheritdoc cref="Information.FromTebibytes(double?)"/>
        public static Information? Tebibytes(this float? value) => Information.FromTebibytes(value);

        /// <inheritdoc cref="Information.FromTebibytes(double)"/>
        public static Information Tebibytes(this decimal value) => Information.FromTebibytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromTebibytes(double?)"/>
        public static Information? Tebibytes(this decimal? value) => Information.FromTebibytes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Terabit

        /// <inheritdoc cref="Information.FromTerabits(double)"/>
        public static Information Terabits(this int value) => Information.FromTerabits(value);

        /// <inheritdoc cref="Information.FromTerabits(double?)"/>
        public static Information? Terabits(this int? value) => Information.FromTerabits(value);

        /// <inheritdoc cref="Information.FromTerabits(double)"/>
        public static Information Terabits(this long value) => Information.FromTerabits(value);

        /// <inheritdoc cref="Information.FromTerabits(double?)"/>
        public static Information? Terabits(this long? value) => Information.FromTerabits(value);

        /// <inheritdoc cref="Information.FromTerabits(double)"/>
        public static Information Terabits(this double value) => Information.FromTerabits(value);

        /// <inheritdoc cref="Information.FromTerabits(double?)"/>
        public static Information? Terabits(this double? value) => Information.FromTerabits(value);

        /// <inheritdoc cref="Information.FromTerabits(double)"/>
        public static Information Terabits(this float value) => Information.FromTerabits(value);

        /// <inheritdoc cref="Information.FromTerabits(double?)"/>
        public static Information? Terabits(this float? value) => Information.FromTerabits(value);

        /// <inheritdoc cref="Information.FromTerabits(double)"/>
        public static Information Terabits(this decimal value) => Information.FromTerabits(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromTerabits(double?)"/>
        public static Information? Terabits(this decimal? value) => Information.FromTerabits(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Terabyte

        /// <inheritdoc cref="Information.FromTerabytes(double)"/>
        public static Information Terabytes(this int value) => Information.FromTerabytes(value);

        /// <inheritdoc cref="Information.FromTerabytes(double?)"/>
        public static Information? Terabytes(this int? value) => Information.FromTerabytes(value);

        /// <inheritdoc cref="Information.FromTerabytes(double)"/>
        public static Information Terabytes(this long value) => Information.FromTerabytes(value);

        /// <inheritdoc cref="Information.FromTerabytes(double?)"/>
        public static Information? Terabytes(this long? value) => Information.FromTerabytes(value);

        /// <inheritdoc cref="Information.FromTerabytes(double)"/>
        public static Information Terabytes(this double value) => Information.FromTerabytes(value);

        /// <inheritdoc cref="Information.FromTerabytes(double?)"/>
        public static Information? Terabytes(this double? value) => Information.FromTerabytes(value);

        /// <inheritdoc cref="Information.FromTerabytes(double)"/>
        public static Information Terabytes(this float value) => Information.FromTerabytes(value);

        /// <inheritdoc cref="Information.FromTerabytes(double?)"/>
        public static Information? Terabytes(this float? value) => Information.FromTerabytes(value);

        /// <inheritdoc cref="Information.FromTerabytes(double)"/>
        public static Information Terabytes(this decimal value) => Information.FromTerabytes(Convert.ToDouble(value));

        /// <inheritdoc cref="Information.FromTerabytes(double?)"/>
        public static Information? Terabytes(this decimal? value) => Information.FromTerabytes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
