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
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using UnitsNet.NumberExtensions.NumberToEntropy;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToEntropyExtensionsTests
    {
        [Fact]
        public void NumberToCaloriesPerKelvinTest() =>
            Assert.Equal(Entropy.FromCaloriesPerKelvin(2), 2.CaloriesPerKelvin());

        [Fact]
        public void NumberToJoulesPerDegreeCelsiusTest() =>
            Assert.Equal(Entropy.FromJoulesPerDegreeCelsius(2), 2.JoulesPerDegreeCelsius());

        [Fact]
        public void NumberToJoulesPerKelvinTest() =>
            Assert.Equal(Entropy.FromJoulesPerKelvin(2), 2.JoulesPerKelvin());

        [Fact]
        public void NumberToKilocaloriesPerKelvinTest() =>
            Assert.Equal(Entropy.FromKilocaloriesPerKelvin(2), 2.KilocaloriesPerKelvin());

        [Fact]
        public void NumberToKilojoulesPerDegreeCelsiusTest() =>
            Assert.Equal(Entropy.FromKilojoulesPerDegreeCelsius(2), 2.KilojoulesPerDegreeCelsius());

        [Fact]
        public void NumberToKilojoulesPerKelvinTest() =>
            Assert.Equal(Entropy.FromKilojoulesPerKelvin(2), 2.KilojoulesPerKelvin());

        [Fact]
        public void NumberToMegajoulesPerKelvinTest() =>
            Assert.Equal(Entropy.FromMegajoulesPerKelvin(2), 2.MegajoulesPerKelvin());

    }
}