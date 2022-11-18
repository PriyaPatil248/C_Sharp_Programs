using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Shape
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }
    //Derived class
    class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }
        class RectangleTester
        {
            static void Main(string[] args)
            {
                Rectangle Rect = new Rectangle();
                Rect.setWidth(65);
                Rect.setHight(23);
                //print the area of the object:
                Console.WriteLine("Total area:{0}", Rect.getArea());
                Console.ReadKey();
            }
        }
    }

}
