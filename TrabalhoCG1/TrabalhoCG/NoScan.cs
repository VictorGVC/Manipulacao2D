using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCG
{
	class NoScan
	{
		private int ymax, xmin, incx;

		public NoScan(int ymax, int xmin, int incx
		{
			this.ymax = ymax;
			this.xmin = xmin;
			this.incx = incx;
		}

		public int Ymax { get => ymax; set => ymax = value; }
		public int Xmin { get => xmin; set => xmin = value; }
		public int Incx { get => incx; set => incx = value; }
	}
}
