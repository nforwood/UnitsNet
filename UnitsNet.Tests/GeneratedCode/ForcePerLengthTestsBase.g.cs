﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/anjdreas/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\UnitClasses\MyUnit.extra.cs files to add code to generated unit classes.
//     Add Extensions\MyUnitExtensions.cs to decorate unit classes with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or unit classes.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
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
using NUnit.Framework;
using UnitsNet.Units;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ForcePerLength.
    /// </summary>
    [TestFixture]
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ForcePerLengthTestsBase
    {
        protected abstract double CentinewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double DecinewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double KilogramsForcePerMeterInOneNewtonPerMeter { get; }
        protected abstract double KilonewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double MicronewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double MillinewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double NanonewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double NewtonsPerMeterInOneNewtonPerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentinewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double DecinewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double KilogramsForcePerMeterTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double MicronewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double MillinewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double NanonewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double NewtonsPerMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Test]
        public void NewtonPerMeterToForcePerLengthUnits()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.AreEqual(CentinewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.CentinewtonsPerMeter, CentinewtonsPerMeterTolerance);
            Assert.AreEqual(DecinewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.DecinewtonsPerMeter, DecinewtonsPerMeterTolerance);
            Assert.AreEqual(KilogramsForcePerMeterInOneNewtonPerMeter, newtonpermeter.KilogramsForcePerMeter, KilogramsForcePerMeterTolerance);
            Assert.AreEqual(KilonewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.KilonewtonsPerMeter, KilonewtonsPerMeterTolerance);
            Assert.AreEqual(MicronewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.MicronewtonsPerMeter, MicronewtonsPerMeterTolerance);
            Assert.AreEqual(MillinewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.MillinewtonsPerMeter, MillinewtonsPerMeterTolerance);
            Assert.AreEqual(NanonewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.NanonewtonsPerMeter, NanonewtonsPerMeterTolerance);
            Assert.AreEqual(NewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.NewtonsPerMeter, NewtonsPerMeterTolerance);
        }

        [Test]
        public void FromValueAndUnit()
        {
            Assert.AreEqual(1, ForcePerLength.From(1, ForcePerLengthUnit.CentinewtonPerMeter).CentinewtonsPerMeter, CentinewtonsPerMeterTolerance);
            Assert.AreEqual(1, ForcePerLength.From(1, ForcePerLengthUnit.DecinewtonPerMeter).DecinewtonsPerMeter, DecinewtonsPerMeterTolerance);
            Assert.AreEqual(1, ForcePerLength.From(1, ForcePerLengthUnit.KilogramForcePerMeter).KilogramsForcePerMeter, KilogramsForcePerMeterTolerance);
            Assert.AreEqual(1, ForcePerLength.From(1, ForcePerLengthUnit.KilonewtonPerMeter).KilonewtonsPerMeter, KilonewtonsPerMeterTolerance);
            Assert.AreEqual(1, ForcePerLength.From(1, ForcePerLengthUnit.MicronewtonPerMeter).MicronewtonsPerMeter, MicronewtonsPerMeterTolerance);
            Assert.AreEqual(1, ForcePerLength.From(1, ForcePerLengthUnit.MillinewtonPerMeter).MillinewtonsPerMeter, MillinewtonsPerMeterTolerance);
            Assert.AreEqual(1, ForcePerLength.From(1, ForcePerLengthUnit.NanonewtonPerMeter).NanonewtonsPerMeter, NanonewtonsPerMeterTolerance);
            Assert.AreEqual(1, ForcePerLength.From(1, ForcePerLengthUnit.NewtonPerMeter).NewtonsPerMeter, NewtonsPerMeterTolerance);
        }

        [Test]
        public void As()
        {
            var newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.AreEqual(CentinewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.CentinewtonPerMeter), CentinewtonsPerMeterTolerance);
            Assert.AreEqual(DecinewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.DecinewtonPerMeter), DecinewtonsPerMeterTolerance);
            Assert.AreEqual(KilogramsForcePerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.KilogramForcePerMeter), KilogramsForcePerMeterTolerance);
            Assert.AreEqual(KilonewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.KilonewtonPerMeter), KilonewtonsPerMeterTolerance);
            Assert.AreEqual(MicronewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.MicronewtonPerMeter), MicronewtonsPerMeterTolerance);
            Assert.AreEqual(MillinewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.MillinewtonPerMeter), MillinewtonsPerMeterTolerance);
            Assert.AreEqual(NanonewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.NanonewtonPerMeter), NanonewtonsPerMeterTolerance);
            Assert.AreEqual(NewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.NewtonPerMeter), NewtonsPerMeterTolerance);
        }

        [Test]
        public void ConversionRoundTrip()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.AreEqual(1, ForcePerLength.FromCentinewtonsPerMeter(newtonpermeter.CentinewtonsPerMeter).NewtonsPerMeter, CentinewtonsPerMeterTolerance);
            Assert.AreEqual(1, ForcePerLength.FromDecinewtonsPerMeter(newtonpermeter.DecinewtonsPerMeter).NewtonsPerMeter, DecinewtonsPerMeterTolerance);
            Assert.AreEqual(1, ForcePerLength.FromKilogramsForcePerMeter(newtonpermeter.KilogramsForcePerMeter).NewtonsPerMeter, KilogramsForcePerMeterTolerance);
            Assert.AreEqual(1, ForcePerLength.FromKilonewtonsPerMeter(newtonpermeter.KilonewtonsPerMeter).NewtonsPerMeter, KilonewtonsPerMeterTolerance);
            Assert.AreEqual(1, ForcePerLength.FromMicronewtonsPerMeter(newtonpermeter.MicronewtonsPerMeter).NewtonsPerMeter, MicronewtonsPerMeterTolerance);
            Assert.AreEqual(1, ForcePerLength.FromMillinewtonsPerMeter(newtonpermeter.MillinewtonsPerMeter).NewtonsPerMeter, MillinewtonsPerMeterTolerance);
            Assert.AreEqual(1, ForcePerLength.FromNanonewtonsPerMeter(newtonpermeter.NanonewtonsPerMeter).NewtonsPerMeter, NanonewtonsPerMeterTolerance);
            Assert.AreEqual(1, ForcePerLength.FromNewtonsPerMeter(newtonpermeter.NewtonsPerMeter).NewtonsPerMeter, NewtonsPerMeterTolerance);
        }

        [Test]
        public void ArithmeticOperators()
        {
            ForcePerLength v = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.AreEqual(-1, -v.NewtonsPerMeter, NewtonsPerMeterTolerance);
            Assert.AreEqual(2, (ForcePerLength.FromNewtonsPerMeter(3)-v).NewtonsPerMeter, NewtonsPerMeterTolerance);
            Assert.AreEqual(2, (v + v).NewtonsPerMeter, NewtonsPerMeterTolerance);
            Assert.AreEqual(10, (v*10).NewtonsPerMeter, NewtonsPerMeterTolerance);
            Assert.AreEqual(10, (10*v).NewtonsPerMeter, NewtonsPerMeterTolerance);
            Assert.AreEqual(2, (ForcePerLength.FromNewtonsPerMeter(10)/5).NewtonsPerMeter, NewtonsPerMeterTolerance);
            Assert.AreEqual(2, ForcePerLength.FromNewtonsPerMeter(10)/ForcePerLength.FromNewtonsPerMeter(5), NewtonsPerMeterTolerance);
        }

        [Test]
        public void ComparisonOperators()
        {
            ForcePerLength oneNewtonPerMeter = ForcePerLength.FromNewtonsPerMeter(1);
            ForcePerLength twoNewtonsPerMeter = ForcePerLength.FromNewtonsPerMeter(2);

            Assert.True(oneNewtonPerMeter < twoNewtonsPerMeter);
            Assert.True(oneNewtonPerMeter <= twoNewtonsPerMeter);
            Assert.True(twoNewtonsPerMeter > oneNewtonPerMeter);
            Assert.True(twoNewtonsPerMeter >= oneNewtonPerMeter);

            Assert.False(oneNewtonPerMeter > twoNewtonsPerMeter);
            Assert.False(oneNewtonPerMeter >= twoNewtonsPerMeter);
            Assert.False(twoNewtonsPerMeter < oneNewtonPerMeter);
            Assert.False(twoNewtonsPerMeter <= oneNewtonPerMeter);
        }

        [Test]
        public void CompareToIsImplemented()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.AreEqual(0, newtonpermeter.CompareTo(newtonpermeter));
            Assert.Greater(newtonpermeter.CompareTo(ForcePerLength.Zero), 0);
            Assert.Less(ForcePerLength.Zero.CompareTo(newtonpermeter), 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void CompareToThrowsOnTypeMismatch()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
// ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            newtonpermeter.CompareTo(new object());
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CompareToThrowsOnNull()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
// ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            newtonpermeter.CompareTo(null);
        }


        [Test]
        public void EqualityOperators()
        {
            ForcePerLength a = ForcePerLength.FromNewtonsPerMeter(1);
            ForcePerLength b = ForcePerLength.FromNewtonsPerMeter(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Test]
        public void EqualsIsImplemented()
        {
            ForcePerLength v = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.IsTrue(v.Equals(ForcePerLength.FromNewtonsPerMeter(1)));
            Assert.IsFalse(v.Equals(ForcePerLength.Zero));
        }

        [Test]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.IsFalse(newtonpermeter.Equals(new object()));
        }

        [Test]
        public void EqualsReturnsFalseOnNull()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.IsFalse(newtonpermeter.Equals(null));
        }
    }
}