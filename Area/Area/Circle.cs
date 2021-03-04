using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
	public class Circle
	{
		private double _radius;
		private const double pi = 3.14;

		public Circle(double radius)
		{
			_radius = radius;

		}

		public double GetArea()
		{
			double area = pi * _radius * _radius;
			return area;
		}
	}
}
