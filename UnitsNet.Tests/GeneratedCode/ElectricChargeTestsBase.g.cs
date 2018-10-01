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
    /// Test of ElectricCharge.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricChargeTestsBase
    {
        protected abstract double CoulombsInOneCoulomb { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CoulombsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricCharge((double)0.0, ElectricChargeUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricCharge(double.PositiveInfinity, ElectricChargeUnit.Coulomb));
            Assert.Throws<ArgumentException>(() => new ElectricCharge(double.NegativeInfinity, ElectricChargeUnit.Coulomb));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricCharge(double.NaN, ElectricChargeUnit.Coulomb));
        }

        [Fact]
        public void CoulombToElectricChargeUnits()
        {
            ElectricCharge coulomb = ElectricCharge.FromCoulombs(1);
            AssertEx.EqualTolerance(CoulombsInOneCoulomb, coulomb.Coulombs, CoulombsTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ElectricCharge.From(1, ElectricChargeUnit.Coulomb).Coulombs, CoulombsTolerance);
        }

        [Fact]
        public void FromCoulombs_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricCharge.FromCoulombs(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ElectricCharge.FromCoulombs(double.NegativeInfinity));
        }

        [Fact]
        public void FromCoulombs_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricCharge.FromCoulombs(double.NaN));
        }

        [Fact]
        public void As()
        {
            var coulomb = ElectricCharge.FromCoulombs(1);
            AssertEx.EqualTolerance(CoulombsInOneCoulomb, coulomb.As(ElectricChargeUnit.Coulomb), CoulombsTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var coulomb = ElectricCharge.FromCoulombs(1);

            var coulombQuantity = coulomb.ToUnit(ElectricChargeUnit.Coulomb);
            AssertEx.EqualTolerance(CoulombsInOneCoulomb, (double)coulombQuantity.Value, CoulombsTolerance);
            Assert.Equal(ElectricChargeUnit.Coulomb, coulombQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricCharge coulomb = ElectricCharge.FromCoulombs(1);
            AssertEx.EqualTolerance(1, ElectricCharge.FromCoulombs(coulomb.Coulombs).Coulombs, CoulombsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricCharge v = ElectricCharge.FromCoulombs(1);
            AssertEx.EqualTolerance(-1, -v.Coulombs, CoulombsTolerance);
            AssertEx.EqualTolerance(2, (ElectricCharge.FromCoulombs(3)-v).Coulombs, CoulombsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Coulombs, CoulombsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Coulombs, CoulombsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Coulombs, CoulombsTolerance);
            AssertEx.EqualTolerance(2, (ElectricCharge.FromCoulombs(10)/5).Coulombs, CoulombsTolerance);
            AssertEx.EqualTolerance(2, ElectricCharge.FromCoulombs(10)/ElectricCharge.FromCoulombs(5), CoulombsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricCharge oneCoulomb = ElectricCharge.FromCoulombs(1);
            ElectricCharge twoCoulombs = ElectricCharge.FromCoulombs(2);

            Assert.True(oneCoulomb < twoCoulombs);
            Assert.True(oneCoulomb <= twoCoulombs);
            Assert.True(twoCoulombs > oneCoulomb);
            Assert.True(twoCoulombs >= oneCoulomb);

            Assert.False(oneCoulomb > twoCoulombs);
            Assert.False(oneCoulomb >= twoCoulombs);
            Assert.False(twoCoulombs < oneCoulomb);
            Assert.False(twoCoulombs <= oneCoulomb);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricCharge coulomb = ElectricCharge.FromCoulombs(1);
            Assert.Equal(0, coulomb.CompareTo(coulomb));
            Assert.True(coulomb.CompareTo(ElectricCharge.Zero) > 0);
            Assert.True(ElectricCharge.Zero.CompareTo(coulomb) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricCharge coulomb = ElectricCharge.FromCoulombs(1);
            Assert.Throws<ArgumentException>(() => coulomb.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricCharge coulomb = ElectricCharge.FromCoulombs(1);
            Assert.Throws<ArgumentNullException>(() => coulomb.CompareTo(null));
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            ElectricCharge v = ElectricCharge.FromCoulombs(1);
            Assert.True(v.Equals(ElectricCharge.FromCoulombs(1), CoulombsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricCharge.Zero, CoulombsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricCharge coulomb = ElectricCharge.FromCoulombs(1);
            Assert.False(coulomb.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricCharge coulomb = ElectricCharge.FromCoulombs(1);
            Assert.False(coulomb.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ElectricChargeUnit.Undefined, ElectricCharge.Units);
        }
    }
}
