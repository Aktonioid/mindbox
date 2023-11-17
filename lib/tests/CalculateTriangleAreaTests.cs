using arealib;

namespace tests
{
    //Тесты для подсчета площади треугольника и тесты для проверки его на прямоугольность
    class CalculateTriangleAreaTests
    {
        [Test]
        public void CalculateTriangleArea_firstSide3SecondSide4ThirdSide5_retured6()
        {
            TriangleAreaCalc triangle = new TriangleAreaCalc(3,4,5);
            Assert.AreEqual(6, triangle.getArea());
        }

        [Test]
        public void CalculateTriangleArea_firstSide4SecondSide3ThirdSide5_retured6()
        {
            TriangleAreaCalc triangle = new TriangleAreaCalc(4,3,5);
            Assert.AreEqual(6, triangle.getArea());
        }

        [Test]
        public void CalculateTriangleArea_firstSide5SecondSide4ThirdSide3_retured6()
        {
            TriangleAreaCalc triangle = new TriangleAreaCalc(5,4,3);
            Assert.AreEqual(6, triangle.getArea());
        }

        [Test]
        public void CalculateTriangleArea_firstSide8econdSide4ThirdSide5_retured8()
        {
            TriangleAreaCalc triangle = new TriangleAreaCalc(8,4,5);
            Assert.AreEqual((float)8.181534, triangle.getArea());
        }
        [Test]
        public void CalculateTriangleArea_firstSide1econdSide4ThirdSide5_returedMinus1()
        {
            TriangleAreaCalc triangle = new TriangleAreaCalc(1,4,5);
            Assert.AreEqual(-1,triangle.getArea());
        }

        [Test]
        public void CalculateTriangleArea_isRight_firstSide3SecondSide4ThirdSide5_returedTrue()
        {
            TriangleAreaCalc triangle = new TriangleAreaCalc(3,4,5);
            Assert.AreEqual(true, triangle.isRight());
        }

        [Test]
        public void CalculateTriangleArea_isRight_firstSide8econdSide4ThirdSide5_returedFalse()
        {
            TriangleAreaCalc triangle = new TriangleAreaCalc(8,4,5);
            Assert.AreEqual(false, triangle.isRight());
        }
    }
}