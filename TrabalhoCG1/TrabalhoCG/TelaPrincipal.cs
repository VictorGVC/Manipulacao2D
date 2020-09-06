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
		private Bitmap bitmaphsi;
		private Bitmap bitmapcmy;
		private int valori = 0;
		private int valorh = 0;
		public TelaPrincipal()
		{
			InitializeComponent();
		}

		private void btAbrirImagem_Click(object sender, EventArgs e)
		{
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
				bitmaphsi = new Bitmap(image);
				bitmapcmy = new Bitmap(image);

				imageBitmap = (Bitmap)image;
				Filtros.convertHSI(imageBitmap, imgDestH, imgDestS, imgDestI, bitmapcmy, bitmaphsi);
				pbMiniH.Image = imgDestH;
				pbMiniS.Image = imgDestS;
				pbMiniI.Image = imgDestI;

				bitmaprgb = new Bitmap(pbOriginal.Image);
				bitmaph = new Bitmap(pbMiniH.Image);
				bitmaps = new Bitmap(pbMiniS.Image);
				bitmapi = new Bitmap(pbMiniI.Image);
				Filtros.convertHSItoRGB(bitmaph, bitmaps, bitmapi, imgDestFim);
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
			valorh += 10;
			Filtros.matiz(bitmaphsi, bitmaph, valorh);
			pbMiniH.Image = bitmaph;
			Filtros.convertHSItoRGB(bitmaph, bitmaps, bitmapi, bitmaprgb);
			pbmodified.Image = bitmaprgb;
		}

        private void btmenhue_Click(object sender, EventArgs e)
        {
			valorh -= 10;
			Filtros.matiz(bitmaphsi, bitmaph, valorh);
			pbMiniH.Image = bitmaph;
			Filtros.convertHSItoRGB(bitmaph, bitmaps, bitmapi, bitmaprgb);
			pbmodified.Image = bitmaprgb;
		}

        private void btmenbri_Click(object sender, EventArgs e)
        {
			valori -= 10;
			Filtros.brilho(bitmaphsi, bitmapi, valori);
			pbMiniI.Image = bitmapi;
			Filtros.convertHSItoRGB(bitmaph, bitmaps, bitmapi, bitmaprgb);
			pbmodified.Image = bitmaprgb;
		}

        private void btmaibri_Click(object sender, EventArgs e)
        {
			valori += 10;
			Filtros.brilho(bitmaphsi, bitmapi, valori);
			pbMiniI.Image = bitmapi;
			Filtros.convertHSItoRGB(bitmaph, bitmaps, bitmapi, bitmaprgb);
			pbmodified.Image = bitmaprgb;
		}
	}
}