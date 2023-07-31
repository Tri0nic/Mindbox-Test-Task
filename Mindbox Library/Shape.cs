using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox_Library
{
    public abstract class Shape
    {
        public string ShapeName { get;}
        public abstract double Area();
        public abstract void Print();
        public Shape(string name)
        {
            ShapeName = name;
        }
    }
}
