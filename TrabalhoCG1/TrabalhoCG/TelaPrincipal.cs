using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoCG
{
	public partial class TelaPrincipal : Form
	{
		private Image image;
		private Bitmap imageBitmap;
		private Bitmap bitmaprgb;
		private Bitmap bitmaph;
		private Bitmap bitmaps;
		private Bitmap bitmapi;
		private Bitmap bitmapcmy;
		private int valori = 0;
		private int valorh = 0;

		private string modoseg;
		private int x1, x2, y1, y2;
		private bool mstatus;
		private Bitmap b,aux;

		public TelaPrincipal()
		{
			InitializeComponent();
			initSegmento();
		}

		private void initSegmento()
        {
			modoseg = "er";
			mstatus = false;
			aux = new Bitmap(795, 462);
			b = new Bitmap(795, 462);
			pbsegmentos.Image = new Bitmap(795, 462);
			rbeqreta.Checked = true;
		}

		private void btAbrirImagem_Click(object sender, EventArgs e)
		{

			//Filtros de cor em imagem
			btLuminancia.Text = "Luminância";
			openFileDialog.FileName = "";
			openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				image = Image.FromFile(openFileDialog.FileName);
				pbOriginal.Image = image;
				pbOriginal.SizeMode = PictureBoxSizeMode.Normal;

				Bitmap imgDestH = new Bitmap(image);
				Bitmap imgDestS = new Bitmap(image);
				Bitmap imgDestI = new Bitmap(image);
				Bitmap imgDestFim = new Bitmap(image);
				bitmapcmy = new Bitmap(image);

				imageBitmap = (Bitmap)image;
				Filtros.convertHSI(imageBitmap, imgDestH, imgDestS, imgDestI, bitmapcmy);
				pbMiniH.Image = imgDestH;
				pbMiniS.Image = imgDestS;
				pbMiniI.Image = imgDestI;

				bitmaprgb = new Bitmap(pbOriginal.Image);
				bitmaph = new Bitmap(pbMiniH.Image);
				bitmaps = new Bitmap(pbMiniS.Image);
				bitmapi = new Bitmap(pbMiniI.Image);
				Filtros.convertHSItoRGB(bitmaph, bitmaps, bitmapi, imgDestFim,valorh,valori);
				pbmodified.Image = imgDestFim;
			}
		}

		private void btLimpar_Click(object sender, EventArgs e)
		{
			pbOriginal.Image = null;
			pbMiniH.Image = null;
			pbMiniS.Image = null;
			pbMiniI.Image = null;
			pbmodified.Image = null;
			btLuminancia.Text = "Luminância";
		}

		private void btLuminancia_Click(object sender, EventArgs e)
		{
			if(btLuminancia.Text == "Luminância")
			{
				Bitmap imgDest = new Bitmap(image);
				imageBitmap = (Bitmap)image;
				Filtros.luminancia(imageBitmap, imgDest);
				pbOriginal.Image = imgDest;
				btLuminancia.Text = "Reset";
			}
			else
			{
				pbOriginal.Image = image;
				btLuminancia.Text = "Luminância";
			}
		}

        private void pbOriginal_MouseMove(object sender, MouseEventArgs e)
        {
			if(pbOriginal.Image != null && e.X < pbOriginal.Image.Width && e.Y < pbOriginal.Image.Height)
            {
				var px = bitmaprgb.GetPixel(e.X, e.Y);
				tbR.Text = px.R.ToString();
				tbG.Text = px.G.ToString();
				tbB.Text = px.B.ToString();
				px = bitmaph.GetPixel(e.X, e.Y);
				tbH.Text = px.R.ToString();
				px = bitmaps.GetPixel(e.X, e.Y);
				tbS.Text = px.R.ToString();
				px = bitmapi.GetPixel(e.X, e.Y);
				tbI.Text = px.R.ToString();
				px = bitmapcmy.GetPixel(e.X, e.Y);
				tbC.Text = px.R.ToString();
				tbM.Text = px.G.ToString();
				tbY.Text = px.B.ToString();
			}
		}

        private void pbOriginal_MouseLeave(object sender, EventArgs e)
        {
			tbB.Text = "0";
			tbC.Text = "0";
			tbG.Text = "0";
			tbH.Text = "0";
			tbI.Text = "0";
			tbM.Text = "0";
			tbR.Text = "0";
			tbS.Text = "0";
			tbY.Text = "0";
		}

		private void btmenhue_Click_1(object sender, EventArgs e)
		{
			valorh -= 100;
			Filtros.convertRGBtoRGBH(bitmaprgb, -10);
			pbmodified.Image = bitmaprgb;
		}

		private void btmaihue_Click_1(object sender, EventArgs e)
		{
			valorh += 100;
			Filtros.convertRGBtoRGBH(bitmaprgb, 10);
			pbmodified.Image = bitmaprgb;
		}

		private void btmenbri_Click_1(object sender, EventArgs e)
		{
			valori -= 100;
			Filtros.convertHSItoRGB(bitmaph, bitmaps, bitmapi, bitmaprgb, -10, -10);
			pbmodified.Image = bitmaprgb;
		}

		private void btmaibri_Click_1(object sender, EventArgs e)
		{
			valori += 100;
			Filtros.convertHSItoRGB(bitmaph, bitmaps, bitmapi, bitmaprgb, 10, 10);
			pbmodified.Image = bitmaprgb;
		}

        private void rbeqreta_CheckedChanged(object sender, EventArgs e)
        {
			modoseg = "er";
			rbeqcircunferencia.Checked = false;
			rbtrigonometria.Checked = false;
			rbpontomedio.Checked = false;
			rbelipsepm.Checked = false;
		}

		private void rbddareta_CheckedChanged(object sender, EventArgs e)
		{
			modoseg = "dr";
			rbeqcircunferencia.Checked = false;
			rbtrigonometria.Checked = false;
			rbpontomedio.Checked = false;
			rbelipsepm.Checked = false;
		}

		private void rbeqcircunferencia_CheckedChanged(object sender, EventArgs e)
		{
			modoseg = "ec";
			rbeqreta.Checked = false;
			rbddareta.Checked = false;
			rbBres.Checked = false;
			rbelipsepm.Checked = false;
		}

		private void rbtrigonometria_CheckedChanged(object sender, EventArgs e)
		{
			modoseg = "tr";
			rbeqreta.Checked = false;
			rbddareta.Checked = false;
			rbBres.Checked = false;
			rbelipsepm.Checked = false;
		}

		private void rbpontomedio_CheckedChanged(object sender, EventArgs e)
		{
			modoseg = "pm";
			rbeqreta.Checked = false;
			rbddareta.Checked = false;
			rbBres.Checked = false;
			rbelipsepm.Checked = false;
		}

		private void rbBres_CheckedChanged(object sender, EventArgs e)
		{
			modoseg = "br";
			rbeqcircunferencia.Checked = false;
			rbtrigonometria.Checked = false;
			rbpontomedio.Checked = false;
			rbelipsepm.Checked = false;
		}

		private void pbsegmentos_MouseDown(object sender, MouseEventArgs e)
        {
			x1 = e.X; y1 = e.Y;
			mstatus = true;
        }

        private void pbsegmentos_MouseUp(object sender, MouseEventArgs e)
        {
			mstatus = false;
			aux = b;
		}

        private void pbsegmentos_MouseMove(object sender, MouseEventArgs e)
        {
			x2 = e.X;
			y2 = e.Y;
			b = (Bitmap)aux.Clone();


			double dy;
			double dx;
			dy = y2 - y1;
			dx = x2 - x1;

			if (mstatus)
			{
                switch (modoseg)
                {
					case "er":
						if (dx != 0)
						{
							double m = dy / dx;

							if (x1 < x2)
								FiltroV.EqGeralRetaQ1(m, x1, y1, dx, b, 1);
							else
							{
								dx *= -1;
								FiltroV.EqGeralRetaQ1(m, x1, y1, dx, b, -1);
							}
							if (y1 < y2)
								FiltroV.EqGeralRetaQ2(m, x1, y1, dy, b, 1);
							else
							{
								dy *= -1;
								FiltroV.EqGeralRetaQ2(m, x1, y1, dy, b, -1);
							}
							pbsegmentos.Image = b;
						}
					break;

					case "dr":
						if (dx != 0)
						{
							if(x1 > x2)
								FiltroM.dda(b, x2, x1, y2, y1);
							else
								FiltroM.dda(b, x1, x2, y1, y2);
							pbsegmentos.Image = b;
						}
					break;

					case "br":
						if (dx != 0 && dy != 0)
                        {
							if (Math.Abs(dy) > Math.Abs(dx))
							{
								if (x1 < x2)
                                {
									if (y1 < y2)
										FiltroV.BresenhamHigh(x1, y1, b, dx, dy, 1, 1);
									else
                                    {
										dy *= -1;
										FiltroV.BresenhamHigh(x1, y1, b, dx, dy, 1, -1);
									}
								}
								else
                                {
									dx *= -1;
									if (y1 < y2)
										FiltroV.BresenhamHigh(x1, y1, b, dx, dy, -1, 1);
									else
                                    {
										dy *= -1;
										FiltroV.BresenhamHigh(x1, y1, b, dx, dy, -1, -1);
									}
								}
							}
							else
							{
								if (x1 < x2)
								{
									if (y1 < y2)
										FiltroV.BresenhamLow(x1, y1, b, dx, dy, 1, 1);
									else
                                    {
										dy *= -1;
										FiltroV.BresenhamLow(x1, y1, b, dx, dy, 1, -1);
									}
								}
								else
								{
									dx *= -1;
									if (y1 < y2)
										FiltroV.BresenhamLow(x1, y1, b, dx, dy, -1, 1);
									else
                                    {
										dy *= -1;
										FiltroV.BresenhamLow(x1, y1, b, dx, dy, -1, -1);
									}
								}
							}
							pbsegmentos.Image = b;
						}
					break;
					case "ec": 
						FiltroC.EqGeralCircunferencia(x1, y1, x2, y2, b); 
						pbsegmentos.Image = b; 
						break;
					case "tr":
						FiltroM.Trigonometria(x1, y1, x2, y2, b);
						pbsegmentos.Image = b; 
						break;
					case "pm":
						FiltroM.pontomedio(x1, y1, x2, y2, b);
						pbsegmentos.Image = b;
						break;
				}
			}
		}
    }
}