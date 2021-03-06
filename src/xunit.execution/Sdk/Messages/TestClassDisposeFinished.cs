﻿using Xunit.Abstractions;

namespace Xunit.Sdk
{
    /// <summary>
    /// Default implementation of <see cref="ITestClassDisposeFinished"/>.
    /// </summary>
    internal class TestClassDisposeFinished : TestMessage, ITestClassDisposeFinished
    {
        public TestClassDisposeFinished(ITestCase testCase, string testDisplayName)
            : base(testCase, testDisplayName) { }
    }
}