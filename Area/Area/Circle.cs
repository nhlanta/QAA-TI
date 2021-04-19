using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
	public class Circle
	{
		private double _radius;

		public Circle(double radius)
		{
			_radius = radius;
		}

		public double GetArea()
		{
			double area = Math.PI * Math.Pow(_radius, _radius);
			return area;
		}
	}
}
