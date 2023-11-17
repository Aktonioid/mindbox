namespace arealib
{
    // класс для вычисления площади круга
    public class CircleAreaCalc : IAreaCalculation
    {
        int radius{get;set;}
        
        public CircleAreaCalc(int radius)
        {
            this.radius = radius;
        }

        //вычисление площади круга
        public float getArea()
        {
            return (float)(Math.PI*radius*radius) ;
        }


    }
}
