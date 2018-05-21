using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using task_4;

namespace task_4test
{
    [TestClass]
    public class Task_4_Test
    {
        AgeCounter agecouner = new AgeCounter();
        

        [TestMethod]
        public void AgeCounetTests()
        {
            Assert.AreEqual("21.25", new AgeCounter().MiddleAge(person));
        }

        public void GetSubstringWithEvenIndexes_Test()
        {
            Assert.AreEqual("aaaaaa", new SubstringWithEvenIndexes().GetSubstringWithEvenIndexes("abababababa"));
        }
    }
}
