﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Variance.cs" company="GLPM">
//   Copyright (c) GLPM. All rights reserved.
// </copyright>
// <summary>
//   Defines Variance.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GLPM.TechnicalAnalysis
{
    public partial class TAMath
    {
        public static Variance Variance(
            int startIdx,
            int endIdx,
            double[] real,
            int timePeriod = 5,
            double nbDev = 1.0)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.Variance(
                startIdx,
                endIdx,
                real,
                timePeriod,
                nbDev,
                ref outBegIdx,
                ref outNBElement,
                outReal);
            return new Variance(retCode, outBegIdx, outNBElement, outReal);
        }

        public static Variance Variance(
            int startIdx,
            int endIdx,
            float[] real,
            int timePeriod = 5,
            double nbDev = 1.0)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.Variance(
                startIdx,
                endIdx,
                real,
                timePeriod,
                nbDev,
                ref outBegIdx,
                ref outNBElement,
                outReal);
            return new Variance(retCode, outBegIdx, outNBElement, outReal);
        }
    }

    public class Variance : IndicatorBase
    {
        public Variance(RetCode retCode, int begIdx, int nbElement, double[] real)
            : base(retCode, begIdx, nbElement)
        {
            this.Real = real;
        }

        public double[] Real { get; }
    }
}