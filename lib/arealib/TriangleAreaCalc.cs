namespace arealib
{
    public class TriangleAreaCalc : IAreaCalculation
    {
        double fstSide{get;set;}
        double secSide{get;set;}
        double thrdSide{get;set;}

        public TriangleAreaCalc(double fstSide, double secSide, double thrdSide)
        {
            this.fstSide = fstSide;
            this.secSide = secSide;
            this.thrdSide = thrdSide;
        }

        public float getArea()
        {
            if(!((fstSide + secSide > thrdSide) & (secSide+thrdSide >fstSide) & (fstSide+secSide > thrdSide)))
            {
                return -1;
            }
            double p = (fstSide+secSide+thrdSide)/2;
            return (float)Math.Sqrt(p*(p-fstSide)*(p-secSide)*(p-thrdSide));
        }
        // проверка на то является ли треугольник равнобедренным
        public bool isRight()
        {
            if(fstSide > secSide & fstSide > thrdSide)
            {
                if(fstSide*fstSide == (secSide*secSide+thrdSide*thrdSide))
                {
                    return true;
                }
            }
            else if (secSide > fstSide & secSide > thrdSide)
            {
                if(secSide*secSide == (fstSide*fstSide+thrdSide*thrdSide))
                {
                    return true;
                }
            }
            else
            {
                if(thrdSide*thrdSide == (secSide*secSide+fstSide*fstSide))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
