using System;
using System.Collections.Generic;
using System.Text;

namespace Area
{
	public class Square
	{
		private double _side;
		public Square(double side)
		{
			_side = side;
		}

		public double GetArea()
		{
			double area = _side * _side;
			return area;
		}

	}
}
