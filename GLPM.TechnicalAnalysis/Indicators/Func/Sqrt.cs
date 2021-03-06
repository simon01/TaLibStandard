﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sqrt.cs" company="GLPM">
//   Copyright (c) GLPM. All rights reserved.
// </copyright>
// <summary>
//   Defines Sqrt.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GLPM.TechnicalAnalysis
{
    public partial class TAMath
    {
        public static Sqrt Sqrt(int startIdx, int endIdx, double[] real)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.Sqrt(startIdx, endIdx, real, ref outBegIdx, ref outNBElement, outReal);
            return new Sqrt(retCode, outBegIdx, outNBElement, outReal);
        }

        public static Sqrt Sqrt(int startIdx, int endIdx, float[] real)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.Sqrt(startIdx, endIdx, real, ref outBegIdx, ref outNBElement, outReal);
            return new Sqrt(retCode, outBegIdx, outNBElement, outReal);
        }
    }

    public class Sqrt : IndicatorBase
    {
        public Sqrt(RetCode retCode, int begIdx, int nbElement, double[] real)
            : base(retCode, begIdx, nbElement)
        {
            this.Real = real;
        }

        public double[] Real { get; }
    }
}