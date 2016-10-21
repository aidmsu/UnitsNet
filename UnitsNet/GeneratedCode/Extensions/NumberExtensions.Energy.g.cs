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
        #region BritishThermalUnit

        /// <inheritdoc cref="Energy.FromBritishThermalUnits(double)"/>
        public static Energy BritishThermalUnits(this int value) => Energy.FromBritishThermalUnits(value);

        /// <inheritdoc cref="Energy.FromBritishThermalUnits(double?)"/>
        public static Energy? BritishThermalUnits(this int? value) => Energy.FromBritishThermalUnits(value);

        /// <inheritdoc cref="Energy.FromBritishThermalUnits(double)"/>
        public static Energy BritishThermalUnits(this long value) => Energy.FromBritishThermalUnits(value);

        /// <inheritdoc cref="Energy.FromBritishThermalUnits(double?)"/>
        public static Energy? BritishThermalUnits(this long? value) => Energy.FromBritishThermalUnits(value);

        /// <inheritdoc cref="Energy.FromBritishThermalUnits(double)"/>
        public static Energy BritishThermalUnits(this double value) => Energy.FromBritishThermalUnits(value);

        /// <inheritdoc cref="Energy.FromBritishThermalUnits(double?)"/>
        public static Energy? BritishThermalUnits(this double? value) => Energy.FromBritishThermalUnits(value);

        /// <inheritdoc cref="Energy.FromBritishThermalUnits(double)"/>
        public static Energy BritishThermalUnits(this float value) => Energy.FromBritishThermalUnits(value);

        /// <inheritdoc cref="Energy.FromBritishThermalUnits(double?)"/>
        public static Energy? BritishThermalUnits(this float? value) => Energy.FromBritishThermalUnits(value);

        /// <inheritdoc cref="Energy.FromBritishThermalUnits(double)"/>
        public static Energy BritishThermalUnits(this decimal value) => Energy.FromBritishThermalUnits(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromBritishThermalUnits(double?)"/>
        public static Energy? BritishThermalUnits(this decimal? value) => Energy.FromBritishThermalUnits(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Calorie

        /// <inheritdoc cref="Energy.FromCalories(double)"/>
        public static Energy Calories(this int value) => Energy.FromCalories(value);

        /// <inheritdoc cref="Energy.FromCalories(double?)"/>
        public static Energy? Calories(this int? value) => Energy.FromCalories(value);

        /// <inheritdoc cref="Energy.FromCalories(double)"/>
        public static Energy Calories(this long value) => Energy.FromCalories(value);

        /// <inheritdoc cref="Energy.FromCalories(double?)"/>
        public static Energy? Calories(this long? value) => Energy.FromCalories(value);

        /// <inheritdoc cref="Energy.FromCalories(double)"/>
        public static Energy Calories(this double value) => Energy.FromCalories(value);

        /// <inheritdoc cref="Energy.FromCalories(double?)"/>
        public static Energy? Calories(this double? value) => Energy.FromCalories(value);

        /// <inheritdoc cref="Energy.FromCalories(double)"/>
        public static Energy Calories(this float value) => Energy.FromCalories(value);

        /// <inheritdoc cref="Energy.FromCalories(double?)"/>
        public static Energy? Calories(this float? value) => Energy.FromCalories(value);

        /// <inheritdoc cref="Energy.FromCalories(double)"/>
        public static Energy Calories(this decimal value) => Energy.FromCalories(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromCalories(double?)"/>
        public static Energy? Calories(this decimal? value) => Energy.FromCalories(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region ElectronVolt

        /// <inheritdoc cref="Energy.FromElectronVolts(double)"/>
        public static Energy ElectronVolts(this int value) => Energy.FromElectronVolts(value);

        /// <inheritdoc cref="Energy.FromElectronVolts(double?)"/>
        public static Energy? ElectronVolts(this int? value) => Energy.FromElectronVolts(value);

        /// <inheritdoc cref="Energy.FromElectronVolts(double)"/>
        public static Energy ElectronVolts(this long value) => Energy.FromElectronVolts(value);

        /// <inheritdoc cref="Energy.FromElectronVolts(double?)"/>
        public static Energy? ElectronVolts(this long? value) => Energy.FromElectronVolts(value);

        /// <inheritdoc cref="Energy.FromElectronVolts(double)"/>
        public static Energy ElectronVolts(this double value) => Energy.FromElectronVolts(value);

        /// <inheritdoc cref="Energy.FromElectronVolts(double?)"/>
        public static Energy? ElectronVolts(this double? value) => Energy.FromElectronVolts(value);

        /// <inheritdoc cref="Energy.FromElectronVolts(double)"/>
        public static Energy ElectronVolts(this float value) => Energy.FromElectronVolts(value);

        /// <inheritdoc cref="Energy.FromElectronVolts(double?)"/>
        public static Energy? ElectronVolts(this float? value) => Energy.FromElectronVolts(value);

        /// <inheritdoc cref="Energy.FromElectronVolts(double)"/>
        public static Energy ElectronVolts(this decimal value) => Energy.FromElectronVolts(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromElectronVolts(double?)"/>
        public static Energy? ElectronVolts(this decimal? value) => Energy.FromElectronVolts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Erg

        /// <inheritdoc cref="Energy.FromErgs(double)"/>
        public static Energy Ergs(this int value) => Energy.FromErgs(value);

        /// <inheritdoc cref="Energy.FromErgs(double?)"/>
        public static Energy? Ergs(this int? value) => Energy.FromErgs(value);

        /// <inheritdoc cref="Energy.FromErgs(double)"/>
        public static Energy Ergs(this long value) => Energy.FromErgs(value);

        /// <inheritdoc cref="Energy.FromErgs(double?)"/>
        public static Energy? Ergs(this long? value) => Energy.FromErgs(value);

        /// <inheritdoc cref="Energy.FromErgs(double)"/>
        public static Energy Ergs(this double value) => Energy.FromErgs(value);

        /// <inheritdoc cref="Energy.FromErgs(double?)"/>
        public static Energy? Ergs(this double? value) => Energy.FromErgs(value);

        /// <inheritdoc cref="Energy.FromErgs(double)"/>
        public static Energy Ergs(this float value) => Energy.FromErgs(value);

        /// <inheritdoc cref="Energy.FromErgs(double?)"/>
        public static Energy? Ergs(this float? value) => Energy.FromErgs(value);

        /// <inheritdoc cref="Energy.FromErgs(double)"/>
        public static Energy Ergs(this decimal value) => Energy.FromErgs(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromErgs(double?)"/>
        public static Energy? Ergs(this decimal? value) => Energy.FromErgs(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region FootPound

        /// <inheritdoc cref="Energy.FromFootPounds(double)"/>
        public static Energy FootPounds(this int value) => Energy.FromFootPounds(value);

        /// <inheritdoc cref="Energy.FromFootPounds(double?)"/>
        public static Energy? FootPounds(this int? value) => Energy.FromFootPounds(value);

        /// <inheritdoc cref="Energy.FromFootPounds(double)"/>
        public static Energy FootPounds(this long value) => Energy.FromFootPounds(value);

        /// <inheritdoc cref="Energy.FromFootPounds(double?)"/>
        public static Energy? FootPounds(this long? value) => Energy.FromFootPounds(value);

        /// <inheritdoc cref="Energy.FromFootPounds(double)"/>
        public static Energy FootPounds(this double value) => Energy.FromFootPounds(value);

        /// <inheritdoc cref="Energy.FromFootPounds(double?)"/>
        public static Energy? FootPounds(this double? value) => Energy.FromFootPounds(value);

        /// <inheritdoc cref="Energy.FromFootPounds(double)"/>
        public static Energy FootPounds(this float value) => Energy.FromFootPounds(value);

        /// <inheritdoc cref="Energy.FromFootPounds(double?)"/>
        public static Energy? FootPounds(this float? value) => Energy.FromFootPounds(value);

        /// <inheritdoc cref="Energy.FromFootPounds(double)"/>
        public static Energy FootPounds(this decimal value) => Energy.FromFootPounds(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromFootPounds(double?)"/>
        public static Energy? FootPounds(this decimal? value) => Energy.FromFootPounds(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region GigawattHour

        /// <inheritdoc cref="Energy.FromGigawattHours(double)"/>
        public static Energy GigawattHours(this int value) => Energy.FromGigawattHours(value);

        /// <inheritdoc cref="Energy.FromGigawattHours(double?)"/>
        public static Energy? GigawattHours(this int? value) => Energy.FromGigawattHours(value);

        /// <inheritdoc cref="Energy.FromGigawattHours(double)"/>
        public static Energy GigawattHours(this long value) => Energy.FromGigawattHours(value);

        /// <inheritdoc cref="Energy.FromGigawattHours(double?)"/>
        public static Energy? GigawattHours(this long? value) => Energy.FromGigawattHours(value);

        /// <inheritdoc cref="Energy.FromGigawattHours(double)"/>
        public static Energy GigawattHours(this double value) => Energy.FromGigawattHours(value);

        /// <inheritdoc cref="Energy.FromGigawattHours(double?)"/>
        public static Energy? GigawattHours(this double? value) => Energy.FromGigawattHours(value);

        /// <inheritdoc cref="Energy.FromGigawattHours(double)"/>
        public static Energy GigawattHours(this float value) => Energy.FromGigawattHours(value);

        /// <inheritdoc cref="Energy.FromGigawattHours(double?)"/>
        public static Energy? GigawattHours(this float? value) => Energy.FromGigawattHours(value);

        /// <inheritdoc cref="Energy.FromGigawattHours(double)"/>
        public static Energy GigawattHours(this decimal value) => Energy.FromGigawattHours(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromGigawattHours(double?)"/>
        public static Energy? GigawattHours(this decimal? value) => Energy.FromGigawattHours(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Joule

        /// <inheritdoc cref="Energy.FromJoules(double)"/>
        public static Energy Joules(this int value) => Energy.FromJoules(value);

        /// <inheritdoc cref="Energy.FromJoules(double?)"/>
        public static Energy? Joules(this int? value) => Energy.FromJoules(value);

        /// <inheritdoc cref="Energy.FromJoules(double)"/>
        public static Energy Joules(this long value) => Energy.FromJoules(value);

        /// <inheritdoc cref="Energy.FromJoules(double?)"/>
        public static Energy? Joules(this long? value) => Energy.FromJoules(value);

        /// <inheritdoc cref="Energy.FromJoules(double)"/>
        public static Energy Joules(this double value) => Energy.FromJoules(value);

        /// <inheritdoc cref="Energy.FromJoules(double?)"/>
        public static Energy? Joules(this double? value) => Energy.FromJoules(value);

        /// <inheritdoc cref="Energy.FromJoules(double)"/>
        public static Energy Joules(this float value) => Energy.FromJoules(value);

        /// <inheritdoc cref="Energy.FromJoules(double?)"/>
        public static Energy? Joules(this float? value) => Energy.FromJoules(value);

        /// <inheritdoc cref="Energy.FromJoules(double)"/>
        public static Energy Joules(this decimal value) => Energy.FromJoules(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromJoules(double?)"/>
        public static Energy? Joules(this decimal? value) => Energy.FromJoules(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kilocalorie

        /// <inheritdoc cref="Energy.FromKilocalories(double)"/>
        public static Energy Kilocalories(this int value) => Energy.FromKilocalories(value);

        /// <inheritdoc cref="Energy.FromKilocalories(double?)"/>
        public static Energy? Kilocalories(this int? value) => Energy.FromKilocalories(value);

        /// <inheritdoc cref="Energy.FromKilocalories(double)"/>
        public static Energy Kilocalories(this long value) => Energy.FromKilocalories(value);

        /// <inheritdoc cref="Energy.FromKilocalories(double?)"/>
        public static Energy? Kilocalories(this long? value) => Energy.FromKilocalories(value);

        /// <inheritdoc cref="Energy.FromKilocalories(double)"/>
        public static Energy Kilocalories(this double value) => Energy.FromKilocalories(value);

        /// <inheritdoc cref="Energy.FromKilocalories(double?)"/>
        public static Energy? Kilocalories(this double? value) => Energy.FromKilocalories(value);

        /// <inheritdoc cref="Energy.FromKilocalories(double)"/>
        public static Energy Kilocalories(this float value) => Energy.FromKilocalories(value);

        /// <inheritdoc cref="Energy.FromKilocalories(double?)"/>
        public static Energy? Kilocalories(this float? value) => Energy.FromKilocalories(value);

        /// <inheritdoc cref="Energy.FromKilocalories(double)"/>
        public static Energy Kilocalories(this decimal value) => Energy.FromKilocalories(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromKilocalories(double?)"/>
        public static Energy? Kilocalories(this decimal? value) => Energy.FromKilocalories(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kilojoule

        /// <inheritdoc cref="Energy.FromKilojoules(double)"/>
        public static Energy Kilojoules(this int value) => Energy.FromKilojoules(value);

        /// <inheritdoc cref="Energy.FromKilojoules(double?)"/>
        public static Energy? Kilojoules(this int? value) => Energy.FromKilojoules(value);

        /// <inheritdoc cref="Energy.FromKilojoules(double)"/>
        public static Energy Kilojoules(this long value) => Energy.FromKilojoules(value);

        /// <inheritdoc cref="Energy.FromKilojoules(double?)"/>
        public static Energy? Kilojoules(this long? value) => Energy.FromKilojoules(value);

        /// <inheritdoc cref="Energy.FromKilojoules(double)"/>
        public static Energy Kilojoules(this double value) => Energy.FromKilojoules(value);

        /// <inheritdoc cref="Energy.FromKilojoules(double?)"/>
        public static Energy? Kilojoules(this double? value) => Energy.FromKilojoules(value);

        /// <inheritdoc cref="Energy.FromKilojoules(double)"/>
        public static Energy Kilojoules(this float value) => Energy.FromKilojoules(value);

        /// <inheritdoc cref="Energy.FromKilojoules(double?)"/>
        public static Energy? Kilojoules(this float? value) => Energy.FromKilojoules(value);

        /// <inheritdoc cref="Energy.FromKilojoules(double)"/>
        public static Energy Kilojoules(this decimal value) => Energy.FromKilojoules(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromKilojoules(double?)"/>
        public static Energy? Kilojoules(this decimal? value) => Energy.FromKilojoules(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilowattHour

        /// <inheritdoc cref="Energy.FromKilowattHours(double)"/>
        public static Energy KilowattHours(this int value) => Energy.FromKilowattHours(value);

        /// <inheritdoc cref="Energy.FromKilowattHours(double?)"/>
        public static Energy? KilowattHours(this int? value) => Energy.FromKilowattHours(value);

        /// <inheritdoc cref="Energy.FromKilowattHours(double)"/>
        public static Energy KilowattHours(this long value) => Energy.FromKilowattHours(value);

        /// <inheritdoc cref="Energy.FromKilowattHours(double?)"/>
        public static Energy? KilowattHours(this long? value) => Energy.FromKilowattHours(value);

        /// <inheritdoc cref="Energy.FromKilowattHours(double)"/>
        public static Energy KilowattHours(this double value) => Energy.FromKilowattHours(value);

        /// <inheritdoc cref="Energy.FromKilowattHours(double?)"/>
        public static Energy? KilowattHours(this double? value) => Energy.FromKilowattHours(value);

        /// <inheritdoc cref="Energy.FromKilowattHours(double)"/>
        public static Energy KilowattHours(this float value) => Energy.FromKilowattHours(value);

        /// <inheritdoc cref="Energy.FromKilowattHours(double?)"/>
        public static Energy? KilowattHours(this float? value) => Energy.FromKilowattHours(value);

        /// <inheritdoc cref="Energy.FromKilowattHours(double)"/>
        public static Energy KilowattHours(this decimal value) => Energy.FromKilowattHours(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromKilowattHours(double?)"/>
        public static Energy? KilowattHours(this decimal? value) => Energy.FromKilowattHours(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Megajoule

        /// <inheritdoc cref="Energy.FromMegajoules(double)"/>
        public static Energy Megajoules(this int value) => Energy.FromMegajoules(value);

        /// <inheritdoc cref="Energy.FromMegajoules(double?)"/>
        public static Energy? Megajoules(this int? value) => Energy.FromMegajoules(value);

        /// <inheritdoc cref="Energy.FromMegajoules(double)"/>
        public static Energy Megajoules(this long value) => Energy.FromMegajoules(value);

        /// <inheritdoc cref="Energy.FromMegajoules(double?)"/>
        public static Energy? Megajoules(this long? value) => Energy.FromMegajoules(value);

        /// <inheritdoc cref="Energy.FromMegajoules(double)"/>
        public static Energy Megajoules(this double value) => Energy.FromMegajoules(value);

        /// <inheritdoc cref="Energy.FromMegajoules(double?)"/>
        public static Energy? Megajoules(this double? value) => Energy.FromMegajoules(value);

        /// <inheritdoc cref="Energy.FromMegajoules(double)"/>
        public static Energy Megajoules(this float value) => Energy.FromMegajoules(value);

        /// <inheritdoc cref="Energy.FromMegajoules(double?)"/>
        public static Energy? Megajoules(this float? value) => Energy.FromMegajoules(value);

        /// <inheritdoc cref="Energy.FromMegajoules(double)"/>
        public static Energy Megajoules(this decimal value) => Energy.FromMegajoules(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromMegajoules(double?)"/>
        public static Energy? Megajoules(this decimal? value) => Energy.FromMegajoules(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MegawattHour

        /// <inheritdoc cref="Energy.FromMegawattHours(double)"/>
        public static Energy MegawattHours(this int value) => Energy.FromMegawattHours(value);

        /// <inheritdoc cref="Energy.FromMegawattHours(double?)"/>
        public static Energy? MegawattHours(this int? value) => Energy.FromMegawattHours(value);

        /// <inheritdoc cref="Energy.FromMegawattHours(double)"/>
        public static Energy MegawattHours(this long value) => Energy.FromMegawattHours(value);

        /// <inheritdoc cref="Energy.FromMegawattHours(double?)"/>
        public static Energy? MegawattHours(this long? value) => Energy.FromMegawattHours(value);

        /// <inheritdoc cref="Energy.FromMegawattHours(double)"/>
        public static Energy MegawattHours(this double value) => Energy.FromMegawattHours(value);

        /// <inheritdoc cref="Energy.FromMegawattHours(double?)"/>
        public static Energy? MegawattHours(this double? value) => Energy.FromMegawattHours(value);

        /// <inheritdoc cref="Energy.FromMegawattHours(double)"/>
        public static Energy MegawattHours(this float value) => Energy.FromMegawattHours(value);

        /// <inheritdoc cref="Energy.FromMegawattHours(double?)"/>
        public static Energy? MegawattHours(this float? value) => Energy.FromMegawattHours(value);

        /// <inheritdoc cref="Energy.FromMegawattHours(double)"/>
        public static Energy MegawattHours(this decimal value) => Energy.FromMegawattHours(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromMegawattHours(double?)"/>
        public static Energy? MegawattHours(this decimal? value) => Energy.FromMegawattHours(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region WattHour

        /// <inheritdoc cref="Energy.FromWattHours(double)"/>
        public static Energy WattHours(this int value) => Energy.FromWattHours(value);

        /// <inheritdoc cref="Energy.FromWattHours(double?)"/>
        public static Energy? WattHours(this int? value) => Energy.FromWattHours(value);

        /// <inheritdoc cref="Energy.FromWattHours(double)"/>
        public static Energy WattHours(this long value) => Energy.FromWattHours(value);

        /// <inheritdoc cref="Energy.FromWattHours(double?)"/>
        public static Energy? WattHours(this long? value) => Energy.FromWattHours(value);

        /// <inheritdoc cref="Energy.FromWattHours(double)"/>
        public static Energy WattHours(this double value) => Energy.FromWattHours(value);

        /// <inheritdoc cref="Energy.FromWattHours(double?)"/>
        public static Energy? WattHours(this double? value) => Energy.FromWattHours(value);

        /// <inheritdoc cref="Energy.FromWattHours(double)"/>
        public static Energy WattHours(this float value) => Energy.FromWattHours(value);

        /// <inheritdoc cref="Energy.FromWattHours(double?)"/>
        public static Energy? WattHours(this float? value) => Energy.FromWattHours(value);

        /// <inheritdoc cref="Energy.FromWattHours(double)"/>
        public static Energy WattHours(this decimal value) => Energy.FromWattHours(Convert.ToDouble(value));

        /// <inheritdoc cref="Energy.FromWattHours(double?)"/>
        public static Energy? WattHours(this decimal? value) => Energy.FromWattHours(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
