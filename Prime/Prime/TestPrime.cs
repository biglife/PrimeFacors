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

        [TestMethod]
        public void return_2_2_for_4()
        {
            CollectionAssert.AreEqual(new List<int> { 2,2 }, PrimeFactor.Generate(4));
        }

        [TestMethod]
        public void return_2_3_for_6()
        {
            CollectionAssert.AreEqual(new List<int> { 2, 3 }, PrimeFactor.Generate(6));
        }

        [TestMethod]
        public void return_2_2_2_for_8()
        {
            CollectionAssert.AreEqual(new List<int> { 2, 2,2 }, PrimeFactor.Generate(8));
        }

        [TestMethod]
        public void return_3_3_for_9()
        {
            CollectionAssert.AreEqual(new List<int> { 3,3 }, PrimeFactor.Generate(9));
        }

        [TestMethod]
        public void return_for_bigdata()
        {
            CollectionAssert.AreEqual(new List<int> { 2,3,7,11,13,17}, PrimeFactor.Generate(2*3*7*11*13*17));
        }
    }

    
}
