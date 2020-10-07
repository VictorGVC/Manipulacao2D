using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCG
{
	class NoScan
	{
		private int ymax;
		private double incx, xmin;

		public NoScan(int ymax, double xmin, double incx)
		{
			this.ymax = ymax;
			this.xmin = xmin;
			this.incx = incx;
		}

		public int Ymax { get => ymax; set => ymax = value; }
		public double Xmin { get => xmin; set => xmin = value; }
		public double Incx { get => incx; set => incx = value; }
	}
}
