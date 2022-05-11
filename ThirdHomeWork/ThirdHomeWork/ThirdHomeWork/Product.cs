using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdHomeWork;

public class Product
{
    // Un ir jābūt arī konstruktors ar parametriem:
    public Product(double height, double width, double weight)
    {
        Height = height;
        Width = width;
        Weight = weight;
    }
    // Lai to panāktu ir jābūt propertiji bez "set" metodes:
    public double Height { get; }
    public double Width { get; }
    public double Weight { get; }
}

