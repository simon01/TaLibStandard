﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Asin.cs" company="GLPM">
//   Copyright (c) GLPM. All rights reserved.
// </copyright>
// <summary>
//   Defines Asin.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GLPM.TechnicalAnalysis
{
    public partial class TAMath
    {
        public static Asin Asin(int startIdx, int endIdx, double[] real)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.Asin(startIdx, endIdx, real, ref outBegIdx, ref outNBElement, outReal);
            return new Asin(retCode, outBegIdx, outNBElement, outReal);
        }

        public static Asin Asin(int startIdx, int endIdx, float[] real)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.Asin(startIdx, endIdx, real, ref outBegIdx, ref outNBElement, outReal);
            return new Asin(retCode, outBegIdx, outNBElement, outReal);
        }
    }

    public class Asin : IndicatorBase
    {
        public Asin(RetCode retCode, int begIdx, int nbElement, double[] real)
            : base(retCode, begIdx, nbElement)
        {
            this.Real = real;
        }

        public double[] Real { get; }
    }
}