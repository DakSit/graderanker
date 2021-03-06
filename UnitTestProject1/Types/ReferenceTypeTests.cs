﻿using graderanker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Types
{

    [TestClass]
    public class ReferenceTypeTests
    {

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;
            x1 = 5;
            Assert.AreEqual(x1, x2);

        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;
            g1.Name = "Dak's Grade Book";
            Assert.AreEqual(g1.Name, g2.Name);

        }
    }
}
