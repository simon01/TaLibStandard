﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cosh.cs" company="GLPM">
//   Copyright (c) GLPM. All rights reserved.
// </copyright>
// <summary>
//   Defines Cosh.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GLPM.TechnicalAnalysis
{
    public partial class TAMath
    {
        public static Cosh Cosh(int startIdx, int endIdx, double[] real)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.Cosh(startIdx, endIdx, real, ref outBegIdx, ref outNBElement, outReal);
            return new Cosh(retCode, outBegIdx, outNBElement, outReal);
        }

        public static Cosh Cosh(int startIdx, int endIdx, float[] real)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.Cosh(startIdx, endIdx, real, ref outBegIdx, ref outNBElement, outReal);
            return new Cosh(retCode, outBegIdx, outNBElement, outReal);
        }
    }

    public class Cosh : IndicatorBase
    {
        public Cosh(RetCode retCode, int begIdx, int nbElement, double[] real)
            : base(retCode, begIdx, nbElement)
        {
            this.Real = real;
        }

        public double[] Real { get; }
    }
}