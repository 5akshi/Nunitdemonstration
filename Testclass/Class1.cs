using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Legacy;
using NUnit.Framework;
using Nunitdemonstration;
using static Nunitdemonstration.Class1;

namespace Nunitdemonstration
{
    public class TriangleTest
    {
        // PROG8041-Sakshi Desai- 8995937 -LAB 2
        [TestFixture]
        public class TriangleTest2
        {
            [Test]
            public void ValidTriangle_Input60and60and60_OutputValidTriangle()
            { 
                //Arrange
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 60;

                string expected = "The triangle is valid.";
                //Act 
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                ClassicAssert.AreEqual(expected, actual);
           }
        }

    }
}