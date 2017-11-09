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
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
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
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of LapseRate.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class LapseRateTestsBase
    {
        protected abstract double DegreesCelciusPerMeterInOneDegreeCelsiusPerMeter { get; }
        protected abstract double KilodegreesCelciusPerMeterInOneDegreeCelsiusPerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DegreesCelciusPerMeterTolerance { get { return 1e-5; } }
        protected virtual double KilodegreesCelciusPerMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void DegreeCelsiusPerMeterToLapseRateUnits()
        {
            LapseRate degreecelsiuspermeter = LapseRate.FromDegreesCelciusPerMeter(1);
            AssertEx.EqualTolerance(DegreesCelciusPerMeterInOneDegreeCelsiusPerMeter, degreecelsiuspermeter.DegreesCelciusPerMeter, DegreesCelciusPerMeterTolerance);
            AssertEx.EqualTolerance(KilodegreesCelciusPerMeterInOneDegreeCelsiusPerMeter, degreecelsiuspermeter.KilodegreesCelciusPerMeter, KilodegreesCelciusPerMeterTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, LapseRate.From(1, LapseRateUnit.DegreeCelsiusPerMeter).DegreesCelciusPerMeter, DegreesCelciusPerMeterTolerance);
            AssertEx.EqualTolerance(1, LapseRate.From(1, LapseRateUnit.KilodegreeCelsiusPerMeter).KilodegreesCelciusPerMeter, KilodegreesCelciusPerMeterTolerance);
        }

        [Fact]
        public void As()
        {
            var degreecelsiuspermeter = LapseRate.FromDegreesCelciusPerMeter(1);
            AssertEx.EqualTolerance(DegreesCelciusPerMeterInOneDegreeCelsiusPerMeter, degreecelsiuspermeter.As(LapseRateUnit.DegreeCelsiusPerMeter), DegreesCelciusPerMeterTolerance);
            AssertEx.EqualTolerance(KilodegreesCelciusPerMeterInOneDegreeCelsiusPerMeter, degreecelsiuspermeter.As(LapseRateUnit.KilodegreeCelsiusPerMeter), KilodegreesCelciusPerMeterTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            LapseRate degreecelsiuspermeter = LapseRate.FromDegreesCelciusPerMeter(1);
            AssertEx.EqualTolerance(1, LapseRate.FromDegreesCelciusPerMeter(degreecelsiuspermeter.DegreesCelciusPerMeter).DegreesCelciusPerMeter, DegreesCelciusPerMeterTolerance);
            AssertEx.EqualTolerance(1, LapseRate.FromKilodegreesCelciusPerMeter(degreecelsiuspermeter.KilodegreesCelciusPerMeter).DegreesCelciusPerMeter, KilodegreesCelciusPerMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            LapseRate v = LapseRate.FromDegreesCelciusPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.DegreesCelciusPerMeter, DegreesCelciusPerMeterTolerance);
            AssertEx.EqualTolerance(2, (LapseRate.FromDegreesCelciusPerMeter(3)-v).DegreesCelciusPerMeter, DegreesCelciusPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).DegreesCelciusPerMeter, DegreesCelciusPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).DegreesCelciusPerMeter, DegreesCelciusPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).DegreesCelciusPerMeter, DegreesCelciusPerMeterTolerance);
            AssertEx.EqualTolerance(2, (LapseRate.FromDegreesCelciusPerMeter(10)/5).DegreesCelciusPerMeter, DegreesCelciusPerMeterTolerance);
            AssertEx.EqualTolerance(2, LapseRate.FromDegreesCelciusPerMeter(10)/LapseRate.FromDegreesCelciusPerMeter(5), DegreesCelciusPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            LapseRate oneDegreeCelsiusPerMeter = LapseRate.FromDegreesCelciusPerMeter(1);
            LapseRate twoDegreesCelciusPerMeter = LapseRate.FromDegreesCelciusPerMeter(2);

            Assert.True(oneDegreeCelsiusPerMeter < twoDegreesCelciusPerMeter);
            Assert.True(oneDegreeCelsiusPerMeter <= twoDegreesCelciusPerMeter);
            Assert.True(twoDegreesCelciusPerMeter > oneDegreeCelsiusPerMeter);
            Assert.True(twoDegreesCelciusPerMeter >= oneDegreeCelsiusPerMeter);

            Assert.False(oneDegreeCelsiusPerMeter > twoDegreesCelciusPerMeter);
            Assert.False(oneDegreeCelsiusPerMeter >= twoDegreesCelciusPerMeter);
            Assert.False(twoDegreesCelciusPerMeter < oneDegreeCelsiusPerMeter);
            Assert.False(twoDegreesCelciusPerMeter <= oneDegreeCelsiusPerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            LapseRate degreecelsiuspermeter = LapseRate.FromDegreesCelciusPerMeter(1);
            Assert.Equal(0, degreecelsiuspermeter.CompareTo(degreecelsiuspermeter));
            Assert.True(degreecelsiuspermeter.CompareTo(LapseRate.Zero) > 0);
            Assert.True(LapseRate.Zero.CompareTo(degreecelsiuspermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            LapseRate degreecelsiuspermeter = LapseRate.FromDegreesCelciusPerMeter(1);
            Assert.Throws<ArgumentException>(() => degreecelsiuspermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            LapseRate degreecelsiuspermeter = LapseRate.FromDegreesCelciusPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => degreecelsiuspermeter.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            LapseRate a = LapseRate.FromDegreesCelciusPerMeter(1);
            LapseRate b = LapseRate.FromDegreesCelciusPerMeter(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            LapseRate v = LapseRate.FromDegreesCelciusPerMeter(1);
            Assert.True(v.Equals(LapseRate.FromDegreesCelciusPerMeter(1)));
            Assert.False(v.Equals(LapseRate.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            LapseRate degreecelsiuspermeter = LapseRate.FromDegreesCelciusPerMeter(1);
            Assert.False(degreecelsiuspermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            LapseRate degreecelsiuspermeter = LapseRate.FromDegreesCelciusPerMeter(1);
            Assert.False(degreecelsiuspermeter.Equals(null));
        }
    }
}