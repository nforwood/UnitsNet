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
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of BrakeSpecificFuelConsumption.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class BrakeSpecificFuelConsumptionTestsBase
    {
        protected abstract double GramsPerKiloWattHourInOneKilogramPerJoule { get; }
        protected abstract double KilogramsPerJouleInOneKilogramPerJoule { get; }
        protected abstract double PoundsPerMechanicalHorsepowerHourInOneKilogramPerJoule { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double GramsPerKiloWattHourTolerance { get { return 1e-5; } }
        protected virtual double KilogramsPerJouleTolerance { get { return 1e-5; } }
        protected virtual double PoundsPerMechanicalHorsepowerHourTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new BrakeSpecificFuelConsumption((double)0.0, BrakeSpecificFuelConsumptionUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new BrakeSpecificFuelConsumption(double.PositiveInfinity, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule));
            Assert.Throws<ArgumentException>(() => new BrakeSpecificFuelConsumption(double.NegativeInfinity, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new BrakeSpecificFuelConsumption(double.NaN, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule));
        }

        [Fact]
        public void KilogramPerJouleToBrakeSpecificFuelConsumptionUnits()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            AssertEx.EqualTolerance(GramsPerKiloWattHourInOneKilogramPerJoule, kilogramperjoule.GramsPerKiloWattHour, GramsPerKiloWattHourTolerance);
            AssertEx.EqualTolerance(KilogramsPerJouleInOneKilogramPerJoule, kilogramperjoule.KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(PoundsPerMechanicalHorsepowerHourInOneKilogramPerJoule, kilogramperjoule.PoundsPerMechanicalHorsepowerHour, PoundsPerMechanicalHorsepowerHourTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, BrakeSpecificFuelConsumption.From(1, BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour).GramsPerKiloWattHour, GramsPerKiloWattHourTolerance);
            AssertEx.EqualTolerance(1, BrakeSpecificFuelConsumption.From(1, BrakeSpecificFuelConsumptionUnit.KilogramPerJoule).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(1, BrakeSpecificFuelConsumption.From(1, BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour).PoundsPerMechanicalHorsepowerHour, PoundsPerMechanicalHorsepowerHourTolerance);
        }

        [Fact]
        public void FromKilogramsPerJoule_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double.NegativeInfinity));
        }

        [Fact]
        public void FromKilogramsPerJoule_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => BrakeSpecificFuelConsumption.FromKilogramsPerJoule(double.NaN));
        }

        [Fact]
        public void As()
        {
            var kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            AssertEx.EqualTolerance(GramsPerKiloWattHourInOneKilogramPerJoule, kilogramperjoule.As(BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour), GramsPerKiloWattHourTolerance);
            AssertEx.EqualTolerance(KilogramsPerJouleInOneKilogramPerJoule, kilogramperjoule.As(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule), KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(PoundsPerMechanicalHorsepowerHourInOneKilogramPerJoule, kilogramperjoule.As(BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour), PoundsPerMechanicalHorsepowerHourTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);

            var gramperkilowatthourQuantity = kilogramperjoule.ToUnit(BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour);
            AssertEx.EqualTolerance(GramsPerKiloWattHourInOneKilogramPerJoule, (double)gramperkilowatthourQuantity.Value, GramsPerKiloWattHourTolerance);
            Assert.Equal(BrakeSpecificFuelConsumptionUnit.GramPerKiloWattHour, gramperkilowatthourQuantity.Unit);

            var kilogramperjouleQuantity = kilogramperjoule.ToUnit(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule);
            AssertEx.EqualTolerance(KilogramsPerJouleInOneKilogramPerJoule, (double)kilogramperjouleQuantity.Value, KilogramsPerJouleTolerance);
            Assert.Equal(BrakeSpecificFuelConsumptionUnit.KilogramPerJoule, kilogramperjouleQuantity.Unit);

            var poundpermechanicalhorsepowerhourQuantity = kilogramperjoule.ToUnit(BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour);
            AssertEx.EqualTolerance(PoundsPerMechanicalHorsepowerHourInOneKilogramPerJoule, (double)poundpermechanicalhorsepowerhourQuantity.Value, PoundsPerMechanicalHorsepowerHourTolerance);
            Assert.Equal(BrakeSpecificFuelConsumptionUnit.PoundPerMechanicalHorsepowerHour, poundpermechanicalhorsepowerhourQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            AssertEx.EqualTolerance(1, BrakeSpecificFuelConsumption.FromGramsPerKiloWattHour(kilogramperjoule.GramsPerKiloWattHour).KilogramsPerJoule, GramsPerKiloWattHourTolerance);
            AssertEx.EqualTolerance(1, BrakeSpecificFuelConsumption.FromKilogramsPerJoule(kilogramperjoule.KilogramsPerJoule).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(1, BrakeSpecificFuelConsumption.FromPoundsPerMechanicalHorsepowerHour(kilogramperjoule.PoundsPerMechanicalHorsepowerHour).KilogramsPerJoule, PoundsPerMechanicalHorsepowerHourTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            BrakeSpecificFuelConsumption v = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            AssertEx.EqualTolerance(-1, -v.KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(2, (BrakeSpecificFuelConsumption.FromKilogramsPerJoule(3)-v).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(2, (v + v).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(10, (v*10).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(10, (10*v).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(2, (BrakeSpecificFuelConsumption.FromKilogramsPerJoule(10)/5).KilogramsPerJoule, KilogramsPerJouleTolerance);
            AssertEx.EqualTolerance(2, BrakeSpecificFuelConsumption.FromKilogramsPerJoule(10)/BrakeSpecificFuelConsumption.FromKilogramsPerJoule(5), KilogramsPerJouleTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            BrakeSpecificFuelConsumption oneKilogramPerJoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            BrakeSpecificFuelConsumption twoKilogramsPerJoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(2);

            Assert.True(oneKilogramPerJoule < twoKilogramsPerJoule);
            Assert.True(oneKilogramPerJoule <= twoKilogramsPerJoule);
            Assert.True(twoKilogramsPerJoule > oneKilogramPerJoule);
            Assert.True(twoKilogramsPerJoule >= oneKilogramPerJoule);

            Assert.False(oneKilogramPerJoule > twoKilogramsPerJoule);
            Assert.False(oneKilogramPerJoule >= twoKilogramsPerJoule);
            Assert.False(twoKilogramsPerJoule < oneKilogramPerJoule);
            Assert.False(twoKilogramsPerJoule <= oneKilogramPerJoule);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.Equal(0, kilogramperjoule.CompareTo(kilogramperjoule));
            Assert.True(kilogramperjoule.CompareTo(BrakeSpecificFuelConsumption.Zero) > 0);
            Assert.True(BrakeSpecificFuelConsumption.Zero.CompareTo(kilogramperjoule) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.Throws<ArgumentException>(() => kilogramperjoule.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.Throws<ArgumentNullException>(() => kilogramperjoule.CompareTo(null));
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            BrakeSpecificFuelConsumption v = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.True(v.Equals(BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1), KilogramsPerJouleTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(BrakeSpecificFuelConsumption.Zero, KilogramsPerJouleTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.False(kilogramperjoule.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            BrakeSpecificFuelConsumption kilogramperjoule = BrakeSpecificFuelConsumption.FromKilogramsPerJoule(1);
            Assert.False(kilogramperjoule.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(BrakeSpecificFuelConsumptionUnit.Undefined, BrakeSpecificFuelConsumption.Units);
        }
    }
}
