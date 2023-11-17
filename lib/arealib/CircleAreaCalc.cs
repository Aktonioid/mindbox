namespace arealib
{
    public class CircleAreaCalc : IAreaCalculation
    {
        int radius{get;set;}
        
        public CircleAreaCalc(int radius)
        {
            this.radius = radius;
        }

        public float getArea()
        {
            return (float)(Math.PI*radius*radius) ;
        }


    }
}