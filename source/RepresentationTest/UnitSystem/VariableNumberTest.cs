﻿/*******************************************************************************
  * Copyright (C) 2015 AgGateway and ADAPT Contributors
  * Copyright (C) 2015 Deere and Company
  * All rights reserved. This program and the accompanying materials
  * are made available under the terms of the Eclipse Public License v1.0
  * which accompanies this distribution, and is available at
  * http://www.eclipse.org/legal/epl-v10.html <http://www.eclipse.org/legal/epl-v10.html> 
  *
  * Contributors:
  *    Tarak Reddy, Tim Shearouse - initial API and implementation
  *******************************************************************************/

using System;
using AgGateway.ADAPT.Representation.UnitSystem;
using Moq;
using NUnit.Framework;

namespace AgGateway.ADAPT.RepresentationTest.UnitSystem
{
//    [TestFixture]
//    public class VariableNumberTest
//    {
//        private Mock<IUnitOfMeasureConverter> _unitOfMeasureConverterMock;
//        private UnitOfMeasure _ftUnitOfMeasure = UnitSystemManager.Instance.UnitOfMeasures["ft"];
//        private const double Epsilon = 0.005;
//
//        [SetUp]
//        public void Setup()
//        {
//            _unitOfMeasureConverterMock = new Mock<IUnitOfMeasureConverter>();
//        }
//
//        [Test]
//        public void GivenRepresentationTagAndUomWhenCreateVariableNumberShouldSetRepAndUom()
//        {
//            var representationTag = RepresentationTagList.vrAirTemperature;
//            var uom = UnitSystemManager.Instance.UnitOfMeasures["C"];
//
//            var number = new NumericRepresentationValue(representationTag, uom, 1.23);
//
//            Assert.AreEqual(representationTag, number.Representation.DomainTag);
//            Assert.AreEqual(uom.DomainID, number.Unit.DomainID);
//        }
//
//        [Test]
//        public void GivenRepresentationTagAndUomDomainIdWhenCreateVariableNumberShouldSetRepAndUom()
//        {
//            var representationTag = RepresentationTagList.vrAirTemperature;
//            var uom = UnitSystemManager.Instance.UnitOfMeasures["C"].DomainID;
//
//            var number = new NumericRepresentationValue(representationTag, uom, 1.23);
//
//            Assert.AreEqual(representationTag, number.Representation.DomainTag);
//            Assert.AreEqual(uom, number.Unit.DomainID);
//        }
//
//        [Test]
//        public void GivenRepresentationDomainIdWhenCreatedThenRepresentationInstance()
//        {
//            var variableNumber = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled.DomainId, _ftUnitOfMeasure.DomainID, 5);
//            Assert.AreSame(RepresentationInstanceList.vrDistanceTraveled, variableNumber.Representation);
//        }
//
//        [Test]
//        public void GivenSourceUnitOfMeasureDomainIdWhenCreatedThenSourceUnitOfMeasureInstance()
//        {
//            var variableNumber = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled.DomainId, _ftUnitOfMeasure.DomainID, 5);
//            Assert.AreSame(_ftUnitOfMeasure, variableNumber.Unit);
//        }
//
//        [Test]
//        public void GivenSourceValueWhenCreatedThenSourceValue()
//        {
//            var variableNumber = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled.DomainId, _ftUnitOfMeasure.DomainID, 5);
//            Assert.AreEqual(5, variableNumber.Value);
//        }
//
//        [Test]
//        public void GivenRepresentationWhenCreatedThenRepresentationIsSet()
//        {
//            var sourceUom = _ftUnitOfMeasure;
//            var variableNumber = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, sourceUom, 47.16516);
//            Assert.AreSame(RepresentationInstanceList.vrDistanceTraveled, variableNumber.Representation);
//        }
//
//        [Test]
//        public void GivenUnitOfMeasureWhenCreatedThenSourceUnitOfMeasureIsSet()
//        {
//            var sourceUom = _ftUnitOfMeasure;
//            var variableNumber = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, sourceUom, 1.58);
//            Assert.AreSame(sourceUom, variableNumber.Unit);
//        }
//
//        [Test]
//        public void GivenValueWhenCreatedThenSourceValueIsSet()
//        {
//            var sourceUom = _ftUnitOfMeasure;
//            var variableNumber = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, sourceUom, 12.0);
//            Assert.AreEqual(12.0, variableNumber.Value);
//        }
//
//        [Test]
//        public void GivenUnitOfMeasureWhenCreatedThenTargetUnitOfMeasureDefaultsToSourceUnitOfMeasure()
//        {
//            var sourceUom = _ftUnitOfMeasure;
//            var baseNumber = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, sourceUom, 1.58);
//            Assert.AreSame(baseNumber.Unit, baseNumber.TargetUnitOfMeasure);
//        }
//
//        [Test]
//        public void GivenUnitOfMeasureWhenCreatedThenTargetValueDefaultsToSourceValue()
//        {
//            var sourceUom = UnitSystemManager.Instance.UnitOfMeasures["m"];
//            var baseNumber = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, sourceUom, 6.89);
//            Assert.AreEqual(baseNumber.Value, baseNumber.TargetValue);
//        }
//
//        [Test]
//        public void GivenVariableNumberWhenSetTargetThenTargetUnitOfMeasureIsSet()
//        {
//            var sourceUom = _ftUnitOfMeasure;
//            var targetUom = UnitSystemManager.Instance.UnitOfMeasures["in"];
//            var variableNumber = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, sourceUom, 12.0);
//            
//            variableNumber.ConvertToUnit(targetUom);
//            Assert.AreSame(targetUom, variableNumber.TargetUnitOfMeasure);
//        }
//
//        [Test]
//        public void GivenVariableNumberWhenSetTargetThenTargetValueIsSet()
//        {
//            var sourceUom = _ftUnitOfMeasure;
//            var targetUom = UnitSystemManager.Instance.UnitOfMeasures["in"];
//            var variableNumber = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, sourceUom, 12.0, _unitOfMeasureConverterMock.Object);
//
//            _unitOfMeasureConverterMock.Setup(s => s.Convert(sourceUom, targetUom, 12.0)).Returns(50.0);
//            variableNumber.ConvertToUnit(targetUom);
//            Assert.AreEqual(50.0, variableNumber.TargetValue);
//        }
//
//        [Test]
//        public void GivenTwoVariableNumbersWithSameUomWhenAddedThenSourceValueIsSum()
//        {
//            var uom = UnitSystemManager.Instance.UnitOfMeasures["C"];
//            var originalNumber = new NumericRepresentationValue(RepresentationInstanceList.vrAirTemperature, uom, 22);
//            var secondNumber = new NumericalValue(uom, 11);
//
//            var result = originalNumber.Add(secondNumber);
//            Assert.IsInstanceOf<NumericRepresentationValue>(result);
//            Assert.AreEqual(33, result.Value);
//        }
//
//        [Test]
//        public void GivenTwoVariableNumbersWhenAddedThenRepresentationIsOriginal()
//        {
//            var originalNumber = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, _ftUnitOfMeasure, 22);
//            var secondNumber = new NumericRepresentationValue(RepresentationInstanceList.vrElevation, UnitSystemManager.Instance.UnitOfMeasures["m"], 11);
//
//            var result = originalNumber.Add(secondNumber);
//            Assert.AreSame(RepresentationInstanceList.vrDistanceTraveled, result.Representation);
//        }
//
//        [Test]
//        public void GivenVariableNumberWhenAddVariableNumberThenResultIsInOriginalUom()
//        {
//            var originalUom = UnitSystemManager.Instance.UnitOfMeasures["m"];
//            var originalNumber = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, originalUom, 1.75);
//
//            var secondUom = _ftUnitOfMeasure;
//            var secondNumber = new NumericalValue(secondUom, 3.5);
//
//            var expected = 2.8168; //1.75m + (3.5ft -> m)
//            var actual = originalNumber.Add(secondNumber);
//            Assert.IsInstanceOf<NumericRepresentationValue>(actual);
//            Assert.AreEqual(expected, actual.Value, 0.005);
//            Assert.AreSame(originalUom, actual.Unit);
//        }
//
//        [Test]
//        public void GivenVariableNumberWhenAddDoubleShouldReturnNewVariableNumberWithSourceAddedToDouble()
//        {
//            var uom = UnitSystemManager.Instance.UnitOfMeasures["mi"];
//            var number = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, uom, 3.62);
//
//            var result = number.Add(1.23);
//
//            Assert.IsInstanceOf<NumericRepresentationValue>(result);
//            Assert.AreEqual(4.85, result.Value, Epsilon);
//        }
//
//        [Test]
//        [ExpectedException(typeof (InvalidOperationException))]
//        public void GivenVariableNumbersWithIncompatibleUnitsWhenAddThenException()
//        {
//            var originalUom = UnitSystemManager.Instance.UnitOfMeasures["m"];
//            var originalNumber = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, originalUom, 1.75);
//
//            var secondUom = UnitSystemManager.Instance.UnitOfMeasures["C"];
//            var secondNumber = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, secondUom, 3.5);
//
//            originalNumber.Add(secondNumber);
//        }
//
//        [Test]
//        public void GivenTwoVariableNumbersWithSameUomWhenSubtractedThenSourceValueIsDifference()
//        {
//            var uom = UnitSystemManager.Instance.UnitOfMeasures["C"];
//            var originalNumber = new NumericRepresentationValue(RepresentationInstanceList.vrAirTemperature, uom, 22);
//            var secondNumber = new NumericalValue(uom, 13);
//
//            var result = originalNumber.Subtract(secondNumber);
//            Assert.IsInstanceOf<NumericRepresentationValue>(result);
//            Assert.AreEqual(9, result.Value);
//        }
//
//        [Test]
//        public void GivenVariableNumberWhenSubtractVariableNumberThenResultIsInOriginalUom()
//        {
//            var originalUom = UnitSystemManager.Instance.UnitOfMeasures["m"];
//            var originalNumber = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, originalUom, 1.75);
//
//            var secondUom = _ftUnitOfMeasure;
//            var secondNumber = new NumericalValue(secondUom, 3.5);
//
//            var expected = 0.6832; //1.75m + (3.5ft -> m)
//            var actual = originalNumber.Subtract(secondNumber);
//            Assert.IsInstanceOf<NumericRepresentationValue>(actual);
//            Assert.AreEqual(expected, actual.Value, Epsilon);
//            Assert.AreSame(originalUom, actual.Unit);
//        }
//
//        [Test]
//        public void GivenTwoVariableNubmersWhenSubtractedThenRepresentationIsOriginal()
//        {
//            var originalNumber = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, _ftUnitOfMeasure, 22);
//            var secondNumber = new NumericRepresentationValue(RepresentationInstanceList.vrElevation, UnitSystemManager.Instance.UnitOfMeasures["m"], 11);
//
//            var result = originalNumber.Subtract(secondNumber);
//            Assert.AreSame(RepresentationInstanceList.vrDistanceTraveled, result.Representation);
//        }
//
//        [Test]
//        [ExpectedException(typeof(InvalidOperationException))]
//        public void GivenVariableNumbersWithIncompatibleUnitsWhenSubtractThenException()
//        {
//            var originalUom = UnitSystemManager.Instance.UnitOfMeasures["m"];
//            var originalNumber = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, originalUom, 1.75);
//
//            var secondUom = UnitSystemManager.Instance.UnitOfMeasures["C"];
//            var secondNumber = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, secondUom, 3.5);
//
//            originalNumber.Subtract(secondNumber);
//        }
//
//        [Test]
//        public void GivenVariableNumberWhenSubtractDoubleShouldReturnNewVariableNumberWithDoubleSubtractedFromSource()
//        {
//            var uom = UnitSystemManager.Instance.UnitOfMeasures["mi"];
//            var number = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, uom, 3.62);
//
//            var result = number.Subtract(1.23);
//
//            Assert.IsInstanceOf<NumericRepresentationValue>(result);
//            Assert.AreEqual(2.39, result.Value, Epsilon);
//        }
//
//        [Test]
//        public void GivenVariableNumberWhenDivideDoubleThenSourceValueIsQuotient()
//        {
//            var uom = UnitSystemManager.Instance.UnitOfMeasures["mi"];
//            var number = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, uom, 3.62);
//
//            var result = number.Divide(1.23);
//
//            Assert.IsInstanceOf<NumericRepresentationValue>(result);
//            Assert.AreEqual(3.62 / 1.23, result.Value, Epsilon);
//        }
//
//        [Test]
//        [ExpectedException(typeof(DivideByZeroException))]
//        public void GivenVariableNumberWhenDivideByZeroShouldThrowException()
//        {
//            var uom = UnitSystemManager.Instance.UnitOfMeasures["mi"];
//            var number = new NumericRepresentationValue(RepresentationInstanceList.vrRoverDistance, uom, 3.62);
//
//            number.Divide(0);
//        }
//
//        [Test]
//        public void GivenVariableNumberWhenDivideVariableNumberThenUnitOfMeasuresCombined()
//        {
//            var numerator = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, _ftUnitOfMeasure, 12);
//            var denominator = new NumericalValue(UnitSystemManager.Instance.UnitOfMeasures["sec"], 5);
//
//            var quotient = numerator.Divide(denominator);
//            Assert.IsInstanceOf<NumericRepresentationValue>(quotient);
//            Assert.AreEqual("ft1sec-1", quotient.Unit.DomainID);
//            Assert.AreEqual(2.4, quotient.Value, Epsilon);
//        }
//
//        [Test]
//        public void GivenVariableNumberWhenDivideNumberWithSameUnitThenSourceValueIsQuotient()
//        {
//            var numerator = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, _ftUnitOfMeasure, 12);
//            var denominator = new NumericalValue(_ftUnitOfMeasure, 6);
//
//            var quotient = numerator.Divide(denominator);
//            Assert.IsInstanceOf<NumericRepresentationValue>(quotient);
//            Assert.AreEqual("ratio", quotient.Unit.DomainID);
//            Assert.AreEqual(2, quotient.Value, Epsilon);
//        }
//
//        [Test]
//        [ExpectedException(typeof(DivideByZeroException))]
//        public void GivenVariableNumberWhenDivideVariableNumberWithZeroValueThenDivideByZeroException()
//        {
//            var numerator = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, _ftUnitOfMeasure, 3);
//            var denominator = new NumericRepresentationValue(RepresentationInstanceList.vrDeltaTime, UnitSystemManager.Instance.UnitOfMeasures["sec"], 0);
//
//            numerator.Divide(denominator, RepresentationInstanceList.vrVehicleSpeed);
//        }
//
//        [Test]
//        public void GivenVariableNunmberWithCompositeUnitOfMeasureWhenDivideVariableNumberThenUnitOfMeasuresCombined()
//        {
//            var numerator = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, UnitSystemManager.Instance.UnitOfMeasures["ft1sec-1"], 2.4);
//            var denominator = new NumericRepresentationValue(RepresentationInstanceList.vrDeltaTime, UnitSystemManager.Instance.UnitOfMeasures["sec"], 5);
//
//            var quotient = numerator.Divide(denominator, RepresentationInstanceList.vrDistanceTraveled);
//            Assert.AreEqual("ft1[sec2]-1", quotient.Unit.DomainID);
//            Assert.AreSame(RepresentationInstanceList.vrDistanceTraveled, quotient.Representation);
//            Assert.AreEqual(.48, quotient.Value, Epsilon);
//        }
//
//        [Test]
//        public void GivenVariableNumberWhenWhenDivideVariableNumberWithCompositeUnitOfMeasureThenUnitOfMeasuresSimplified()
//        {
//            var numerator = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, _ftUnitOfMeasure, 12.54);
//            var denominator = new NumericRepresentationValue(RepresentationInstanceList.vrDeltaTime, UnitSystemManager.Instance.UnitOfMeasures["[sec2]-1"], 5);
//
//            var quotient = numerator.Divide(denominator, RepresentationInstanceList.vrDeltaTime);
//            Assert.AreEqual("ft1sec2", quotient.Unit.DomainID);
//            Assert.AreSame(RepresentationInstanceList.vrDeltaTime, quotient.Representation);
//            Assert.AreEqual(2.508, quotient.Value, Epsilon);
//        }
//
//        [Test]
//        public void GivenVariableNumberWithCompositeUnitOfMeasureWhenDivdeVariableNumberWithCompositeUnitOfMeasureThenUnitOfMeasuresSimplified()
//        {
//            var numerator = new NumericRepresentationValue(RepresentationInstanceList.vrEngineSpeed, UnitSystemManager.Instance.UnitOfMeasures["ft1sec-1"], 52.15);
//            var denominator = new NumericRepresentationValue(RepresentationInstanceList.vrFuelRatePerHour, UnitSystemManager.Instance.UnitOfMeasures["gal1sec-1"], 12);
//
//            var quotient = numerator.Divide(denominator, RepresentationInstanceList.vrEngineSpeed);
//            Assert.AreEqual("ft1gal-1", quotient.Unit.DomainID);
//            Assert.AreSame(RepresentationInstanceList.vrEngineSpeed, quotient.Representation);
//            Assert.AreEqual(4.345833333333333, quotient.Value, Epsilon);
//        }
//
//        [Test]
//        public void GivenVariableNumberWhenMultiplyNumberThenUnitOfMeasuresCombined()
//        {
//            var left = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, _ftUnitOfMeasure, 12);
//            var right = new NumericalValue(_ftUnitOfMeasure, 4);
//
//            var product = left.Multiply(right);
//            Assert.IsInstanceOf<NumericRepresentationValue>(product);
//            Assert.AreEqual("ft2", product.Unit.DomainID);
//            Assert.AreEqual(48, product.Value);
//        }
//
//        [Test]
//        public void GivenVariableNumberWhenMultiplyDoubleThenSourceValueIsProduct()
//        {
//            var uom = UnitSystemManager.Instance.UnitOfMeasures["mi"];
//            var number = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, uom, 3.62);
//
//            var result = number.Multiply(1.23);
//
//            Assert.AreEqual(3.62 * 1.23, result.Value, Epsilon);
//        }
//
//        [Test]
//        public void GivenVariableNumberWithCompositeUnitOfMeasureWhenMultiplyVariableNumberThenCombinedUnitOfMeasure()
//        {
//            var left = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, UnitSystemManager.Instance.UnitOfMeasures["ft1sec-1"], 47.5);
//            var right = new NumericalValue(_ftUnitOfMeasure, 3);
//
//            var product = left.Multiply(right);
//            Assert.IsInstanceOf<NumericRepresentationValue>(product);
//            Assert.AreEqual("ft2sec-1", product.Unit.DomainID);
//            Assert.AreEqual(142.5, product.Value);
//        }
//
//        [Test]
//        public void GivenVariableNumberWhenMultiplyVariableNumberWithCompositeUnitOfMeasureThenCombinedUnitOfMeasure()
//        {
//            var left = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, _ftUnitOfMeasure, 52.78);
//            var right = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, UnitSystemManager.Instance.UnitOfMeasures["ft1sec-1"], 2.85);
//
//            var product = left.Multiply(right, RepresentationInstanceList.vrDistanceTraveled);
//            Assert.AreSame(RepresentationInstanceList.vrDistanceTraveled, product.Representation);
//            Assert.AreEqual("ft2sec-1", product.Unit.DomainID);
//            Assert.AreEqual(150.423, product.Value);
//        }
//
//        [Test]
//        public void GivenVariableNumberWithCompositeUnitOfMeasureWhenMultiplyVariableNumberWithCompositeUnitOfMeasureThenUnitsCancel()
//        {
//            var left = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, UnitSystemManager.Instance.UnitOfMeasures["ft1sec1"], 5.15);
//            var right = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, UnitSystemManager.Instance.UnitOfMeasures["ft1sec-1"], 7.89);
//
//            var product = left.Multiply(right, RepresentationInstanceList.vrDistanceTraveled);
//            Assert.AreSame(RepresentationInstanceList.vrDistanceTraveled, product.Representation);
//            Assert.AreEqual("ft2", product.Unit.DomainID);
//            Assert.AreEqual(40.6335, product.Value);
//        }
//
//        [Test]
//        public void GivenVariableNumberWithCompositeUnitOfMeasureWhenMultiplyVariableNumberWithCompositeUnitOfMeasureThenCombinedUnitOfMeasure()
//        {
//            var left = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, UnitSystemManager.Instance.UnitOfMeasures["ft1sec-1"], 21.848);
//            var right = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, UnitSystemManager.Instance.UnitOfMeasures["ft1sec-1"], 9.18);
//
//            var product = left.Multiply(right, RepresentationInstanceList.vrDistanceTraveled);
//            Assert.AreSame(RepresentationInstanceList.vrDistanceTraveled, product.Representation);
//            Assert.AreEqual("ft2[sec2]-1", product.Unit.DomainID);
//            Assert.AreEqual(200.56464, product.Value);
//        }
//
//        [Test]
//        public void GivenVariableNumbersWithTypesThatSimplifyToScalarTypeWhenMultiplyThenShouldHaveScalarUnit()
//        {
//            var left = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, UnitSystemManager.Instance.UnitOfMeasures["ft1sec-1"], 21.848);
//            var right = new NumericRepresentationValue(RepresentationInstanceList.vrDistanceTraveled, UnitSystemManager.Instance.UnitOfMeasures["sec"], 9.18);
//
//            var product = left.Multiply(right, RepresentationInstanceList.vrDistanceTraveled);
//            Assert.AreEqual("ft", product.Unit.DomainID);
//            Assert.IsInstanceOf<ScalarUnitOfMeasure>(product.Unit);
//        }
//
//        [Test]
//        public void GivenVariableNumberAndDoubleWhenAddToSourceShouldDoThat()
//        {
//            var number = new NumericRepresentationValue(RepresentationInstanceList.vrABShiftTrack, _ftUnitOfMeasure, 24.68);
//            number.AddToSource(10.11);
//
//            Assert.AreEqual(34.79, number.Value);
//        }
//
//        [Test]
//        public void GivenVariableNumberAndDoubleWhenSubtractFromSourceShouldDoThat()
//        {
//            var number = new NumericRepresentationValue(RepresentationInstanceList.vrABShiftTrack, _ftUnitOfMeasure, 24.68);
//            number.SubtractFromSource(10.11);
//
//            Assert.AreEqual(14.57, number.Value);
//        }
//
//        [Test]
//        public void GivenVariableNumberWhenSubtractVariableNumberFromSourceShouldDoThat()
//        {
//            var firstNumber = new NumericRepresentationValue(RepresentationInstanceList.vrABShiftTrack, _ftUnitOfMeasure, 24.68);
//            var secondNumber = new NumericRepresentationValue(RepresentationInstanceList.vrABShiftTrack, _ftUnitOfMeasure, 10.11);
//
//            firstNumber.SubtractFromSource(secondNumber);
//            Assert.AreEqual(14.57, firstNumber.Value);
//        }
//
//        [Test]
//        public void GivenVariableNumberWhenAddVariableNumberToSourceShouldDoThat()
//        {
//            var firstNumber = new NumericRepresentationValue(RepresentationInstanceList.vrABShiftTrack, _ftUnitOfMeasure, 24.68);
//            var secondNumber = new NumericRepresentationValue(RepresentationInstanceList.vrABShiftTrack, _ftUnitOfMeasure, 10.11);
//
//            firstNumber.AddToSource(secondNumber);
//            Assert.AreEqual(34.79, firstNumber.Value);
//        }
//
//        [Test]
//        public void GivenVariableNumberWhenToStringShouldPrettyPrint()
//        {
//            var number = new NumericRepresentationValue(RepresentationInstanceList.vrABShiftTrack, _ftUnitOfMeasure, 12.34);
//
//            var result = number.ToString();
//
//            Assert.AreEqual("12.34 ft (vrABShiftTrack)", result);
//        }
//    }
}