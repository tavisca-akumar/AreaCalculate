using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   public class Rectangle:IShape
    {
         int length;
         int breadth;
       public Rectangle(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        
        public  void FindArea()
        {
            int ans=(this.breadth*this.length);
            Console.WriteLine(ans);
            Console.ReadLine();

        }
    }
}
