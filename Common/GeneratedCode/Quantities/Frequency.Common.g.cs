﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
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
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.InternalHelpers;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     The number of occurrences of a repeating event per unit time.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class Frequency : IQuantity
#else
    public partial struct Frequency : IQuantity, IComparable, IComparable<Frequency>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly FrequencyUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public FrequencyUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static Frequency()
        {
            BaseDimensions = new BaseDimensions(0, 0, -1, 0, 0, 0, 0);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">The numeric value  to contruct this quantity with.</param>
        /// <param name="unit">The unit representation to contruct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
        /// <exception cref="ArgumentException>If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        private
#else
        public
#endif
        Frequency(double numericValue, FrequencyUnit unit)
        {
            if(unit == FrequencyUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(numericValue, nameof(numericValue));
            _unit = unit;
        }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.Frequency;

        /// <summary>
        ///     The base unit of Frequency, which is Hertz. All conversions go via this value.
        /// </summary>
        public static FrequencyUnit BaseUnit => FrequencyUnit.Hertz;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the Frequency quantity.
        /// </summary>
        public static FrequencyUnit[] Units { get; } = Enum.GetValues(typeof(FrequencyUnit)).Cast<FrequencyUnit>().Except(new FrequencyUnit[]{ FrequencyUnit.Undefined }).ToArray();

        /// <summary>
        ///     Get Frequency in CyclesPerHour.
        /// </summary>
        public double CyclesPerHour => As(FrequencyUnit.CyclePerHour);

        /// <summary>
        ///     Get Frequency in CyclesPerMinute.
        /// </summary>
        public double CyclesPerMinute => As(FrequencyUnit.CyclePerMinute);

        /// <summary>
        ///     Get Frequency in Gigahertz.
        /// </summary>
        public double Gigahertz => As(FrequencyUnit.Gigahertz);

        /// <summary>
        ///     Get Frequency in Hertz.
        /// </summary>
        public double Hertz => As(FrequencyUnit.Hertz);

        /// <summary>
        ///     Get Frequency in Kilohertz.
        /// </summary>
        public double Kilohertz => As(FrequencyUnit.Kilohertz);

        /// <summary>
        ///     Get Frequency in Megahertz.
        /// </summary>
        public double Megahertz => As(FrequencyUnit.Megahertz);

        /// <summary>
        ///     Get Frequency in RadiansPerSecond.
        /// </summary>
        public double RadiansPerSecond => As(FrequencyUnit.RadianPerSecond);

        /// <summary>
        ///     Get Frequency in Terahertz.
        /// </summary>
        public double Terahertz => As(FrequencyUnit.Terahertz);

        #endregion

        #region Static

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Hertz.
        /// </summary>
        public static Frequency Zero => new Frequency(0, BaseUnit);

        /// <summary>
        ///     Get Frequency from CyclesPerHour.
        /// </summary>
        /// <exception cref="ArgumentException>If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromCyclesPerHour(double cyclesperhour)
#else
        public static Frequency FromCyclesPerHour(QuantityValue cyclesperhour)
#endif
        {
            double value = (double) cyclesperhour;
            return new Frequency(value, FrequencyUnit.CyclePerHour);
        }

        /// <summary>
        ///     Get Frequency from CyclesPerMinute.
        /// </summary>
        /// <exception cref="ArgumentException>If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromCyclesPerMinute(double cyclesperminute)
#else
        public static Frequency FromCyclesPerMinute(QuantityValue cyclesperminute)
#endif
        {
            double value = (double) cyclesperminute;
            return new Frequency(value, FrequencyUnit.CyclePerMinute);
        }

        /// <summary>
        ///     Get Frequency from Gigahertz.
        /// </summary>
        /// <exception cref="ArgumentException>If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromGigahertz(double gigahertz)
#else
        public static Frequency FromGigahertz(QuantityValue gigahertz)
#endif
        {
            double value = (double) gigahertz;
            return new Frequency(value, FrequencyUnit.Gigahertz);
        }

        /// <summary>
        ///     Get Frequency from Hertz.
        /// </summary>
        /// <exception cref="ArgumentException>If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromHertz(double hertz)
#else
        public static Frequency FromHertz(QuantityValue hertz)
#endif
        {
            double value = (double) hertz;
            return new Frequency(value, FrequencyUnit.Hertz);
        }

        /// <summary>
        ///     Get Frequency from Kilohertz.
        /// </summary>
        /// <exception cref="ArgumentException>If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromKilohertz(double kilohertz)
#else
        public static Frequency FromKilohertz(QuantityValue kilohertz)
#endif
        {
            double value = (double) kilohertz;
            return new Frequency(value, FrequencyUnit.Kilohertz);
        }

        /// <summary>
        ///     Get Frequency from Megahertz.
        /// </summary>
        /// <exception cref="ArgumentException>If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromMegahertz(double megahertz)
#else
        public static Frequency FromMegahertz(QuantityValue megahertz)
#endif
        {
            double value = (double) megahertz;
            return new Frequency(value, FrequencyUnit.Megahertz);
        }

        /// <summary>
        ///     Get Frequency from RadiansPerSecond.
        /// </summary>
        /// <exception cref="ArgumentException>If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromRadiansPerSecond(double radianspersecond)
#else
        public static Frequency FromRadiansPerSecond(QuantityValue radianspersecond)
#endif
        {
            double value = (double) radianspersecond;
            return new Frequency(value, FrequencyUnit.RadianPerSecond);
        }

        /// <summary>
        ///     Get Frequency from Terahertz.
        /// </summary>
        /// <exception cref="ArgumentException>If value is NaN or Infinity.</exception>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Frequency FromTerahertz(double terahertz)
#else
        public static Frequency FromTerahertz(QuantityValue terahertz)
#endif
        {
            double value = (double) terahertz;
            return new Frequency(value, FrequencyUnit.Terahertz);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="FrequencyUnit" /> to <see cref="Frequency" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Frequency unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static Frequency From(double value, FrequencyUnit fromUnit)
#else
        public static Frequency From(QuantityValue value, FrequencyUnit fromUnit)
#endif
        {
            return new Frequency((double)value, fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(FrequencyUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is Frequency)) throw new ArgumentException("Expected type Frequency.", nameof(obj));

            return CompareTo((Frequency)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(Frequency other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Frequency within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(Frequency other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current Frequency.</returns>
        public override int GetHashCode()
        {
            return new { Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(FrequencyUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this Frequency to another Frequency with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Frequency with the specified unit.</returns>
        public Frequency ToUnit(FrequencyUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new Frequency(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case FrequencyUnit.CyclePerHour: return _value/3600;
                case FrequencyUnit.CyclePerMinute: return _value/60;
                case FrequencyUnit.Gigahertz: return (_value) * 1e9d;
                case FrequencyUnit.Hertz: return _value;
                case FrequencyUnit.Kilohertz: return (_value) * 1e3d;
                case FrequencyUnit.Megahertz: return (_value) * 1e6d;
                case FrequencyUnit.RadianPerSecond: return _value/6.2831853072;
                case FrequencyUnit.Terahertz: return (_value) * 1e12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(FrequencyUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case FrequencyUnit.CyclePerHour: return baseUnitValue*3600;
                case FrequencyUnit.CyclePerMinute: return baseUnitValue*60;
                case FrequencyUnit.Gigahertz: return (baseUnitValue) / 1e9d;
                case FrequencyUnit.Hertz: return baseUnitValue;
                case FrequencyUnit.Kilohertz: return (baseUnitValue) / 1e3d;
                case FrequencyUnit.Megahertz: return (baseUnitValue) / 1e6d;
                case FrequencyUnit.RadianPerSecond: return baseUnitValue*6.2831853072;
                case FrequencyUnit.Terahertz: return (baseUnitValue) / 1e12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Frequency Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out Frequency result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static FrequencyUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        #endregion

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(Unit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(FrequencyUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of Frequency
        /// </summary>
        public static Frequency MaxValue => new Frequency(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Frequency
        /// </summary>
        public static Frequency MinValue => new Frequency(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => Frequency.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Frequency.BaseDimensions;
    }
}
