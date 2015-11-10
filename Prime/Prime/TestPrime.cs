using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prime
{
    [TestClass]
    public class TestPrime
    {
        //AAA:Arrange, Action, Assert
        //Readable name
        [TestMethod]
        public void return_empty_for_1()
        {
            CollectionAssert.AreEqual(new List<int>(), PrimeFactor.Generate(1));
        }
    }

    public class PrimeFactor
    {
        public static List<int> Generate(int input)
        {
            return new List<int>();
        }
    }
}
