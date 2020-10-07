using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCG
{
	class NoScan
	{
		private int ymax, xmin;
		private double incx;

		public NoScan(int ymax, int xmin, double incx)
		{
			this.ymax = ymax;
			this.xmin = xmin;
			this.incx = incx;
		}

		public int Ymax { get => ymax; set => ymax = value; }
		public int Xmin { get => xmin; set => xmin = value; }
		public double Incx { get => incx; set => incx = value; }
	}
}
