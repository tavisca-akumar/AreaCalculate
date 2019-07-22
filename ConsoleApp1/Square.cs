using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Square:IShape
    {
        int side;

       public Square(int side)
        {
            this.side = side;

        }
        

        public  double FindArea()
        {
            int ans = this.side * this.side;
           
            return ans;
        }
    }
}
