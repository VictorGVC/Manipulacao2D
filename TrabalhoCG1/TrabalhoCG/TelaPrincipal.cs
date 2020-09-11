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
		private Bitmap b;

		public TelaPrincipal()
		{
			InitializeComponent();
			initSegmento();
		}

		private void initSegmento()
        {
			modoseg = "er";
			mstatus = false;
			b = new Bitmap(795, 462);
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

        private void btmaihue_Click(object sender, EventArgs e)
        {
			valorh += 100;
			Filtros.convertRGBtoRGBH(bitmaprgb,10);
			pbmodified.Image = bitmaprgb;
		}

        private void btmenhue_Click(object sender, EventArgs e)
        {
			valorh -= 100;
			Filtros.convertRGBtoRGBH(bitmaprgb, -10);
			pbmodified.Image = bitmaprgb;
		}

        private void btmenbri_Click(object sender, EventArgs e)
        {
			valori -= 100;
			Filtros.convertHSItoRGB(bitmaph, bitmaps, bitmapi, bitmaprgb, -10, -10);
			pbmodified.Image = bitmaprgb;
		}

        private void btmaibri_Click(object sender, EventArgs e)
        {
			valori += 100;
			Filtros.convertHSItoRGB(bitmaph, bitmaps, bitmapi, bitmaprgb, 10, 10);
			pbmodified.Image = bitmaprgb;
		}

        private void rbeqreta_CheckedChanged(object sender, EventArgs e)
        {
			modoseg = "er";
        }

        private void pbsegmentos_MouseDown(object sender, MouseEventArgs e)
        {
			x1 = e.X; y1 = e.Y;
			mstatus = true;
        }

        private void pbsegmentos_MouseUp(object sender, MouseEventArgs e)
        {
			mstatus = false;
        }

        private void pbsegmentos_MouseMove(object sender, MouseEventArgs e)
        {
			if (mstatus && modoseg.Equals("er"))
			{
				x2 = e.X;
				y2 = e.Y;

				double dy = y2 - y1;
				double dx = x2 - x1;
				if(dx != 0 && x2 < b.Width && y2 < b.Height && x2 > 0 && y2 > 0 )
                {
					double m = dy / dx;
					for (int x = x1; x <= x2; x++)
					{
						double y = y1 + m * (x - x1);
						b.SetPixel(x, (int)Math.Round(y), BackColor);
					}
					pbsegmentos.Image = b;
				}
			}
		}

        private void rbddareta_CheckedChanged(object sender, EventArgs e)
        {
			modoseg = "dr";
		}

		private void rbBres_CheckedChanged(object sender, EventArgs e)
		{
			modoseg = "br";
		}

    }
}