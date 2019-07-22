using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public class Circle:IShape
    {
         int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
       

        public  double FindArea()
        {
            double ans = (3.14) * this.radius * this.radius;
           
            return ans;
        }
    }
}
