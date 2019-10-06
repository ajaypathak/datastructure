using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructure.UnitTest
{
    [TestClass]
    public class CountMinSketchTests
    {
        [TestMethod]
        public void Height_And_Width_Test()
        {
           CountMinSketch countMinSketch= new CountMinSketch();
           var calculateHeight = countMinSketch.CalculateHeight(99);
           var calculateWidth = countMinSketch.CalculateWidth(.9);
        }
    }
}
