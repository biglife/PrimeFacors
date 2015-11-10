﻿using System.Collections.Generic;
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

        [TestMethod]
        public void return_2_for_2()
        {
            CollectionAssert.AreEqual(new List<int>{2}, PrimeFactor.Generate(2));
        }

        //TDD Rules
        //1. You are not allowed to write any production code unless it is to make a failing unit test pass
        //2. You are not allowed to write any more of a unit test than is sufficient to fail; and compilation failures are failures. 
        //3. You are not allowed to write any more production code than is sufficient to pass the one failing unit test.
        [TestMethod]
        public void return_3_for_3()
        {
            CollectionAssert.AreEqual(new List<int> { 3 }, PrimeFactor.Generate(3));
        }
    }

    
}
