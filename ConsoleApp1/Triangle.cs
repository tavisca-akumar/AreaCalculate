using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public class Triangle:IShape
    {
        double base_;
        double height;
        public Triangle(double base_, double height)
        {
            this.base_ = base_;
            this.height = height;
        }
       

        public  double FindArea()
        {
            double ans = ((this.base_ * this.height)/2);
            
            return ans;
        }
    }
}
