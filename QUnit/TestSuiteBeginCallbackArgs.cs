﻿using System;
using Bridge;

namespace Bridge.QUnit
{
    [Ignore]
    [ObjectLiteral]
    public class TestSuiteBeginCallbackArgs
    {
        /// <summary>
        /// The number of total tests in the test suite.
        /// </summary>
        public int TotalTests { get; set; }
    }
}