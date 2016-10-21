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
        #region Day

        /// <inheritdoc cref="Duration.FromDays(double)"/>
        public static Duration Days(this int value) => Duration.FromDays(value);

        /// <inheritdoc cref="Duration.FromDays(double?)"/>
        public static Duration? Days(this int? value) => Duration.FromDays(value);

        /// <inheritdoc cref="Duration.FromDays(double)"/>
        public static Duration Days(this long value) => Duration.FromDays(value);

        /// <inheritdoc cref="Duration.FromDays(double?)"/>
        public static Duration? Days(this long? value) => Duration.FromDays(value);

        /// <inheritdoc cref="Duration.FromDays(double)"/>
        public static Duration Days(this double value) => Duration.FromDays(value);

        /// <inheritdoc cref="Duration.FromDays(double?)"/>
        public static Duration? Days(this double? value) => Duration.FromDays(value);

        /// <inheritdoc cref="Duration.FromDays(double)"/>
        public static Duration Days(this float value) => Duration.FromDays(value);

        /// <inheritdoc cref="Duration.FromDays(double?)"/>
        public static Duration? Days(this float? value) => Duration.FromDays(value);

        /// <inheritdoc cref="Duration.FromDays(double)"/>
        public static Duration Days(this decimal value) => Duration.FromDays(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromDays(double?)"/>
        public static Duration? Days(this decimal? value) => Duration.FromDays(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Hour

        /// <inheritdoc cref="Duration.FromHours(double)"/>
        public static Duration Hours(this int value) => Duration.FromHours(value);

        /// <inheritdoc cref="Duration.FromHours(double?)"/>
        public static Duration? Hours(this int? value) => Duration.FromHours(value);

        /// <inheritdoc cref="Duration.FromHours(double)"/>
        public static Duration Hours(this long value) => Duration.FromHours(value);

        /// <inheritdoc cref="Duration.FromHours(double?)"/>
        public static Duration? Hours(this long? value) => Duration.FromHours(value);

        /// <inheritdoc cref="Duration.FromHours(double)"/>
        public static Duration Hours(this double value) => Duration.FromHours(value);

        /// <inheritdoc cref="Duration.FromHours(double?)"/>
        public static Duration? Hours(this double? value) => Duration.FromHours(value);

        /// <inheritdoc cref="Duration.FromHours(double)"/>
        public static Duration Hours(this float value) => Duration.FromHours(value);

        /// <inheritdoc cref="Duration.FromHours(double?)"/>
        public static Duration? Hours(this float? value) => Duration.FromHours(value);

        /// <inheritdoc cref="Duration.FromHours(double)"/>
        public static Duration Hours(this decimal value) => Duration.FromHours(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromHours(double?)"/>
        public static Duration? Hours(this decimal? value) => Duration.FromHours(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Microsecond

        /// <inheritdoc cref="Duration.FromMicroseconds(double)"/>
        public static Duration Microseconds(this int value) => Duration.FromMicroseconds(value);

        /// <inheritdoc cref="Duration.FromMicroseconds(double?)"/>
        public static Duration? Microseconds(this int? value) => Duration.FromMicroseconds(value);

        /// <inheritdoc cref="Duration.FromMicroseconds(double)"/>
        public static Duration Microseconds(this long value) => Duration.FromMicroseconds(value);

        /// <inheritdoc cref="Duration.FromMicroseconds(double?)"/>
        public static Duration? Microseconds(this long? value) => Duration.FromMicroseconds(value);

        /// <inheritdoc cref="Duration.FromMicroseconds(double)"/>
        public static Duration Microseconds(this double value) => Duration.FromMicroseconds(value);

        /// <inheritdoc cref="Duration.FromMicroseconds(double?)"/>
        public static Duration? Microseconds(this double? value) => Duration.FromMicroseconds(value);

        /// <inheritdoc cref="Duration.FromMicroseconds(double)"/>
        public static Duration Microseconds(this float value) => Duration.FromMicroseconds(value);

        /// <inheritdoc cref="Duration.FromMicroseconds(double?)"/>
        public static Duration? Microseconds(this float? value) => Duration.FromMicroseconds(value);

        /// <inheritdoc cref="Duration.FromMicroseconds(double)"/>
        public static Duration Microseconds(this decimal value) => Duration.FromMicroseconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromMicroseconds(double?)"/>
        public static Duration? Microseconds(this decimal? value) => Duration.FromMicroseconds(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Millisecond

        /// <inheritdoc cref="Duration.FromMilliseconds(double)"/>
        public static Duration Milliseconds(this int value) => Duration.FromMilliseconds(value);

        /// <inheritdoc cref="Duration.FromMilliseconds(double?)"/>
        public static Duration? Milliseconds(this int? value) => Duration.FromMilliseconds(value);

        /// <inheritdoc cref="Duration.FromMilliseconds(double)"/>
        public static Duration Milliseconds(this long value) => Duration.FromMilliseconds(value);

        /// <inheritdoc cref="Duration.FromMilliseconds(double?)"/>
        public static Duration? Milliseconds(this long? value) => Duration.FromMilliseconds(value);

        /// <inheritdoc cref="Duration.FromMilliseconds(double)"/>
        public static Duration Milliseconds(this double value) => Duration.FromMilliseconds(value);

        /// <inheritdoc cref="Duration.FromMilliseconds(double?)"/>
        public static Duration? Milliseconds(this double? value) => Duration.FromMilliseconds(value);

        /// <inheritdoc cref="Duration.FromMilliseconds(double)"/>
        public static Duration Milliseconds(this float value) => Duration.FromMilliseconds(value);

        /// <inheritdoc cref="Duration.FromMilliseconds(double?)"/>
        public static Duration? Milliseconds(this float? value) => Duration.FromMilliseconds(value);

        /// <inheritdoc cref="Duration.FromMilliseconds(double)"/>
        public static Duration Milliseconds(this decimal value) => Duration.FromMilliseconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromMilliseconds(double?)"/>
        public static Duration? Milliseconds(this decimal? value) => Duration.FromMilliseconds(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Minute

        /// <inheritdoc cref="Duration.FromMinutes(double)"/>
        public static Duration Minutes(this int value) => Duration.FromMinutes(value);

        /// <inheritdoc cref="Duration.FromMinutes(double?)"/>
        public static Duration? Minutes(this int? value) => Duration.FromMinutes(value);

        /// <inheritdoc cref="Duration.FromMinutes(double)"/>
        public static Duration Minutes(this long value) => Duration.FromMinutes(value);

        /// <inheritdoc cref="Duration.FromMinutes(double?)"/>
        public static Duration? Minutes(this long? value) => Duration.FromMinutes(value);

        /// <inheritdoc cref="Duration.FromMinutes(double)"/>
        public static Duration Minutes(this double value) => Duration.FromMinutes(value);

        /// <inheritdoc cref="Duration.FromMinutes(double?)"/>
        public static Duration? Minutes(this double? value) => Duration.FromMinutes(value);

        /// <inheritdoc cref="Duration.FromMinutes(double)"/>
        public static Duration Minutes(this float value) => Duration.FromMinutes(value);

        /// <inheritdoc cref="Duration.FromMinutes(double?)"/>
        public static Duration? Minutes(this float? value) => Duration.FromMinutes(value);

        /// <inheritdoc cref="Duration.FromMinutes(double)"/>
        public static Duration Minutes(this decimal value) => Duration.FromMinutes(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromMinutes(double?)"/>
        public static Duration? Minutes(this decimal? value) => Duration.FromMinutes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Month

        /// <inheritdoc cref="Duration.FromMonths(double)"/>
        public static Duration Months(this int value) => Duration.FromMonths(value);

        /// <inheritdoc cref="Duration.FromMonths(double?)"/>
        public static Duration? Months(this int? value) => Duration.FromMonths(value);

        /// <inheritdoc cref="Duration.FromMonths(double)"/>
        public static Duration Months(this long value) => Duration.FromMonths(value);

        /// <inheritdoc cref="Duration.FromMonths(double?)"/>
        public static Duration? Months(this long? value) => Duration.FromMonths(value);

        /// <inheritdoc cref="Duration.FromMonths(double)"/>
        public static Duration Months(this double value) => Duration.FromMonths(value);

        /// <inheritdoc cref="Duration.FromMonths(double?)"/>
        public static Duration? Months(this double? value) => Duration.FromMonths(value);

        /// <inheritdoc cref="Duration.FromMonths(double)"/>
        public static Duration Months(this float value) => Duration.FromMonths(value);

        /// <inheritdoc cref="Duration.FromMonths(double?)"/>
        public static Duration? Months(this float? value) => Duration.FromMonths(value);

        /// <inheritdoc cref="Duration.FromMonths(double)"/>
        public static Duration Months(this decimal value) => Duration.FromMonths(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromMonths(double?)"/>
        public static Duration? Months(this decimal? value) => Duration.FromMonths(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Nanosecond

        /// <inheritdoc cref="Duration.FromNanoseconds(double)"/>
        public static Duration Nanoseconds(this int value) => Duration.FromNanoseconds(value);

        /// <inheritdoc cref="Duration.FromNanoseconds(double?)"/>
        public static Duration? Nanoseconds(this int? value) => Duration.FromNanoseconds(value);

        /// <inheritdoc cref="Duration.FromNanoseconds(double)"/>
        public static Duration Nanoseconds(this long value) => Duration.FromNanoseconds(value);

        /// <inheritdoc cref="Duration.FromNanoseconds(double?)"/>
        public static Duration? Nanoseconds(this long? value) => Duration.FromNanoseconds(value);

        /// <inheritdoc cref="Duration.FromNanoseconds(double)"/>
        public static Duration Nanoseconds(this double value) => Duration.FromNanoseconds(value);

        /// <inheritdoc cref="Duration.FromNanoseconds(double?)"/>
        public static Duration? Nanoseconds(this double? value) => Duration.FromNanoseconds(value);

        /// <inheritdoc cref="Duration.FromNanoseconds(double)"/>
        public static Duration Nanoseconds(this float value) => Duration.FromNanoseconds(value);

        /// <inheritdoc cref="Duration.FromNanoseconds(double?)"/>
        public static Duration? Nanoseconds(this float? value) => Duration.FromNanoseconds(value);

        /// <inheritdoc cref="Duration.FromNanoseconds(double)"/>
        public static Duration Nanoseconds(this decimal value) => Duration.FromNanoseconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromNanoseconds(double?)"/>
        public static Duration? Nanoseconds(this decimal? value) => Duration.FromNanoseconds(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Second

        /// <inheritdoc cref="Duration.FromSeconds(double)"/>
        public static Duration Seconds(this int value) => Duration.FromSeconds(value);

        /// <inheritdoc cref="Duration.FromSeconds(double?)"/>
        public static Duration? Seconds(this int? value) => Duration.FromSeconds(value);

        /// <inheritdoc cref="Duration.FromSeconds(double)"/>
        public static Duration Seconds(this long value) => Duration.FromSeconds(value);

        /// <inheritdoc cref="Duration.FromSeconds(double?)"/>
        public static Duration? Seconds(this long? value) => Duration.FromSeconds(value);

        /// <inheritdoc cref="Duration.FromSeconds(double)"/>
        public static Duration Seconds(this double value) => Duration.FromSeconds(value);

        /// <inheritdoc cref="Duration.FromSeconds(double?)"/>
        public static Duration? Seconds(this double? value) => Duration.FromSeconds(value);

        /// <inheritdoc cref="Duration.FromSeconds(double)"/>
        public static Duration Seconds(this float value) => Duration.FromSeconds(value);

        /// <inheritdoc cref="Duration.FromSeconds(double?)"/>
        public static Duration? Seconds(this float? value) => Duration.FromSeconds(value);

        /// <inheritdoc cref="Duration.FromSeconds(double)"/>
        public static Duration Seconds(this decimal value) => Duration.FromSeconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromSeconds(double?)"/>
        public static Duration? Seconds(this decimal? value) => Duration.FromSeconds(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Week

        /// <inheritdoc cref="Duration.FromWeeks(double)"/>
        public static Duration Weeks(this int value) => Duration.FromWeeks(value);

        /// <inheritdoc cref="Duration.FromWeeks(double?)"/>
        public static Duration? Weeks(this int? value) => Duration.FromWeeks(value);

        /// <inheritdoc cref="Duration.FromWeeks(double)"/>
        public static Duration Weeks(this long value) => Duration.FromWeeks(value);

        /// <inheritdoc cref="Duration.FromWeeks(double?)"/>
        public static Duration? Weeks(this long? value) => Duration.FromWeeks(value);

        /// <inheritdoc cref="Duration.FromWeeks(double)"/>
        public static Duration Weeks(this double value) => Duration.FromWeeks(value);

        /// <inheritdoc cref="Duration.FromWeeks(double?)"/>
        public static Duration? Weeks(this double? value) => Duration.FromWeeks(value);

        /// <inheritdoc cref="Duration.FromWeeks(double)"/>
        public static Duration Weeks(this float value) => Duration.FromWeeks(value);

        /// <inheritdoc cref="Duration.FromWeeks(double?)"/>
        public static Duration? Weeks(this float? value) => Duration.FromWeeks(value);

        /// <inheritdoc cref="Duration.FromWeeks(double)"/>
        public static Duration Weeks(this decimal value) => Duration.FromWeeks(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromWeeks(double?)"/>
        public static Duration? Weeks(this decimal? value) => Duration.FromWeeks(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Year

        /// <inheritdoc cref="Duration.FromYears(double)"/>
        public static Duration Years(this int value) => Duration.FromYears(value);

        /// <inheritdoc cref="Duration.FromYears(double?)"/>
        public static Duration? Years(this int? value) => Duration.FromYears(value);

        /// <inheritdoc cref="Duration.FromYears(double)"/>
        public static Duration Years(this long value) => Duration.FromYears(value);

        /// <inheritdoc cref="Duration.FromYears(double?)"/>
        public static Duration? Years(this long? value) => Duration.FromYears(value);

        /// <inheritdoc cref="Duration.FromYears(double)"/>
        public static Duration Years(this double value) => Duration.FromYears(value);

        /// <inheritdoc cref="Duration.FromYears(double?)"/>
        public static Duration? Years(this double? value) => Duration.FromYears(value);

        /// <inheritdoc cref="Duration.FromYears(double)"/>
        public static Duration Years(this float value) => Duration.FromYears(value);

        /// <inheritdoc cref="Duration.FromYears(double?)"/>
        public static Duration? Years(this float? value) => Duration.FromYears(value);

        /// <inheritdoc cref="Duration.FromYears(double)"/>
        public static Duration Years(this decimal value) => Duration.FromYears(Convert.ToDouble(value));

        /// <inheritdoc cref="Duration.FromYears(double?)"/>
        public static Duration? Years(this decimal? value) => Duration.FromYears(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
