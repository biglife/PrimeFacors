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
    }

    
}
