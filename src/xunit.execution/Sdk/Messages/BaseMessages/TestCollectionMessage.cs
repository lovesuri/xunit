﻿using System;
using System.Linq;
using Xunit.Abstractions;

namespace Xunit.Sdk
{
    internal class TestCollectionMessage : LongLivedMarshalByRefObject, ITestCollectionMessage
    {
        public TestCollectionMessage(ITestCollection testCollection)
        {
            TestCollection = testCollection;
        }

        /// <inheritdoc/>
        public ITestCollection TestCollection { get; private set; }
    }
}
