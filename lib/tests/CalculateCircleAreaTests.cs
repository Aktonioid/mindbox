using arealib;
namespace tests{
    //тесты для класса CircleAreaCalc, вычисляющего плошадь круга
public class CalculateCircleAreaTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CalculateCircleArea_9Radius_returned254()
    {
        CircleAreaCalc circle = new CircleAreaCalc(9);
        Assert.AreEqual((float)254.4690049,circle.getArea());
    }
    [Test]
    public void CalculateCircleArea_3Radius_returned28()
    {
        CircleAreaCalc circle = new CircleAreaCalc(3);
        Assert.AreEqual((float)28.27433388,circle.getArea());
    }
    [Test]
    public void CalculateCircleArea_16Radius_returned803()
    {
        CircleAreaCalc circle = new CircleAreaCalc(16);
        Assert.AreEqual((float)804.2477193,circle.getArea());
    }
}
}