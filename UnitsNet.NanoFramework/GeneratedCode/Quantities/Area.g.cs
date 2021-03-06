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

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     Area is a quantity that expresses the extent of a two-dimensional surface or shape, or planar lamina, in the plane. Area can be understood as the amount of material with a given thickness that would be necessary to fashion a model of the shape, or the amount of paint necessary to cover the surface with a single coat.[1] It is the two-dimensional analog of the length of a curve (a one-dimensional concept) or the volume of a solid (a three-dimensional concept).
    /// </summary>
    public struct  Area
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly AreaUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public AreaUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Area(double value, AreaUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static AreaUnit BaseUnit { get; } = AreaUnit.SquareMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Area MaxValue { get; } = new Area(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Area MinValue { get; } = new Area(double.MinValue, BaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Area Zero { get; } = new Area(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get Area in Acres.
        /// </summary>
        public double Acres => As(AreaUnit.Acre);

        /// <summary>
        ///     Get Area in Hectares.
        /// </summary>
        public double Hectares => As(AreaUnit.Hectare);

        /// <summary>
        ///     Get Area in SquareCentimeters.
        /// </summary>
        public double SquareCentimeters => As(AreaUnit.SquareCentimeter);

        /// <summary>
        ///     Get Area in SquareDecimeters.
        /// </summary>
        public double SquareDecimeters => As(AreaUnit.SquareDecimeter);

        /// <summary>
        ///     Get Area in SquareFeet.
        /// </summary>
        public double SquareFeet => As(AreaUnit.SquareFoot);

        /// <summary>
        ///     Get Area in SquareInches.
        /// </summary>
        public double SquareInches => As(AreaUnit.SquareInch);

        /// <summary>
        ///     Get Area in SquareKilometers.
        /// </summary>
        public double SquareKilometers => As(AreaUnit.SquareKilometer);

        /// <summary>
        ///     Get Area in SquareMeters.
        /// </summary>
        public double SquareMeters => As(AreaUnit.SquareMeter);

        /// <summary>
        ///     Get Area in SquareMicrometers.
        /// </summary>
        public double SquareMicrometers => As(AreaUnit.SquareMicrometer);

        /// <summary>
        ///     Get Area in SquareMiles.
        /// </summary>
        public double SquareMiles => As(AreaUnit.SquareMile);

        /// <summary>
        ///     Get Area in SquareMillimeters.
        /// </summary>
        public double SquareMillimeters => As(AreaUnit.SquareMillimeter);

        /// <summary>
        ///     Get Area in SquareNauticalMiles.
        /// </summary>
        public double SquareNauticalMiles => As(AreaUnit.SquareNauticalMile);

        /// <summary>
        ///     Get Area in SquareYards.
        /// </summary>
        public double SquareYards => As(AreaUnit.SquareYard);

        /// <summary>
        ///     Get Area in UsSurveySquareFeet.
        /// </summary>
        public double UsSurveySquareFeet => As(AreaUnit.UsSurveySquareFoot);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get Area from Acres.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Area FromAcres(double acres) => new Area(acres, AreaUnit.Acre);

        /// <summary>
        ///     Get Area from Hectares.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Area FromHectares(double hectares) => new Area(hectares, AreaUnit.Hectare);

        /// <summary>
        ///     Get Area from SquareCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Area FromSquareCentimeters(double squarecentimeters) => new Area(squarecentimeters, AreaUnit.SquareCentimeter);

        /// <summary>
        ///     Get Area from SquareDecimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Area FromSquareDecimeters(double squaredecimeters) => new Area(squaredecimeters, AreaUnit.SquareDecimeter);

        /// <summary>
        ///     Get Area from SquareFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Area FromSquareFeet(double squarefeet) => new Area(squarefeet, AreaUnit.SquareFoot);

        /// <summary>
        ///     Get Area from SquareInches.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Area FromSquareInches(double squareinches) => new Area(squareinches, AreaUnit.SquareInch);

        /// <summary>
        ///     Get Area from SquareKilometers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Area FromSquareKilometers(double squarekilometers) => new Area(squarekilometers, AreaUnit.SquareKilometer);

        /// <summary>
        ///     Get Area from SquareMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Area FromSquareMeters(double squaremeters) => new Area(squaremeters, AreaUnit.SquareMeter);

        /// <summary>
        ///     Get Area from SquareMicrometers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Area FromSquareMicrometers(double squaremicrometers) => new Area(squaremicrometers, AreaUnit.SquareMicrometer);

        /// <summary>
        ///     Get Area from SquareMiles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Area FromSquareMiles(double squaremiles) => new Area(squaremiles, AreaUnit.SquareMile);

        /// <summary>
        ///     Get Area from SquareMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Area FromSquareMillimeters(double squaremillimeters) => new Area(squaremillimeters, AreaUnit.SquareMillimeter);

        /// <summary>
        ///     Get Area from SquareNauticalMiles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Area FromSquareNauticalMiles(double squarenauticalmiles) => new Area(squarenauticalmiles, AreaUnit.SquareNauticalMile);

        /// <summary>
        ///     Get Area from SquareYards.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Area FromSquareYards(double squareyards) => new Area(squareyards, AreaUnit.SquareYard);

        /// <summary>
        ///     Get Area from UsSurveySquareFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Area FromUsSurveySquareFeet(double ussurveysquarefeet) => new Area(ussurveysquarefeet, AreaUnit.UsSurveySquareFoot);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="AreaUnit" /> to <see cref="Area" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Area unit value.</returns>
        public static Area From(double value, AreaUnit fromUnit)
        {
            return new Area(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(AreaUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Area ToUnit(AreaUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new Area(convertedValue, unit);
        }


        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            switch(Unit)
            {
                case AreaUnit.Acre: return _value*4046.85642;
                case AreaUnit.Hectare: return _value*1e4;
                case AreaUnit.SquareCentimeter: return _value*1e-4;
                case AreaUnit.SquareDecimeter: return _value*1e-2;
                case AreaUnit.SquareFoot: return _value*0.092903;
                case AreaUnit.SquareInch: return _value*0.00064516;
                case AreaUnit.SquareKilometer: return _value*1e6;
                case AreaUnit.SquareMeter: return _value;
                case AreaUnit.SquareMicrometer: return _value*1e-12;
                case AreaUnit.SquareMile: return _value*2.59e6;
                case AreaUnit.SquareMillimeter: return _value*1e-6;
                case AreaUnit.SquareNauticalMile: return _value*3429904;
                case AreaUnit.SquareYard: return _value*0.836127;
                case AreaUnit.UsSurveySquareFoot: return _value*0.09290341161;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(AreaUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case AreaUnit.Acre: return baseUnitValue/4046.85642;
                case AreaUnit.Hectare: return baseUnitValue/1e4;
                case AreaUnit.SquareCentimeter: return baseUnitValue/1e-4;
                case AreaUnit.SquareDecimeter: return baseUnitValue/1e-2;
                case AreaUnit.SquareFoot: return baseUnitValue/0.092903;
                case AreaUnit.SquareInch: return baseUnitValue/0.00064516;
                case AreaUnit.SquareKilometer: return baseUnitValue/1e6;
                case AreaUnit.SquareMeter: return baseUnitValue;
                case AreaUnit.SquareMicrometer: return baseUnitValue/1e-12;
                case AreaUnit.SquareMile: return baseUnitValue/2.59e6;
                case AreaUnit.SquareMillimeter: return baseUnitValue/1e-6;
                case AreaUnit.SquareNauticalMile: return baseUnitValue/3429904;
                case AreaUnit.SquareYard: return baseUnitValue/0.836127;
                case AreaUnit.UsSurveySquareFoot: return baseUnitValue/0.09290341161;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

