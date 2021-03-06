﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sub.cs" company="GLPM">
//   Copyright (c) GLPM. All rights reserved.
// </copyright>
// <summary>
//   Defines Sub.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GLPM.TechnicalAnalysis
{
    public partial class TAMath
    {
        public static Sub Sub(int startIdx, int endIdx, double[] real0, double[] real1)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.Sub(startIdx, endIdx, real0, real1, ref outBegIdx, ref outNBElement, outReal);
            return new Sub(retCode, outBegIdx, outNBElement, outReal);
        }

        public static Sub Sub(int startIdx, int endIdx, float[] real0, float[] real1)
        {
            int outBegIdx = default(int);
            int outNBElement = default(int);
            double[] outReal = new double[endIdx - startIdx + 1];

            var retCode = TACore.Sub(startIdx, endIdx, real0, real1, ref outBegIdx, ref outNBElement, outReal);
            return new Sub(retCode, outBegIdx, outNBElement, outReal);
        }
    }

    public class Sub : IndicatorBase
    {
        public Sub(RetCode retCode, int begIdx, int nbElement, double[] real)
            : base(retCode, begIdx, nbElement)
        {
            this.Real = real;
        }

        public double[] Real { get; }
    }
}