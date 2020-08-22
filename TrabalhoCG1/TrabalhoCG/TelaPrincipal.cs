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

				Bitmap imgDest1 = new Bitmap(image);
				Bitmap imgDest2 = new Bitmap(image);
				Bitmap imgDest3 = new Bitmap(image);
				Bitmap imgDest4 = new Bitmap(image);
				

				imageBitmap = (Bitmap)image;
				Filtros.convertH(imageBitmap, imgDest1);
				pbMiniH.Image = imgDest1;
				Filtros.convertS(imageBitmap, imgDest2);
				pbMiniS.Image = imgDest2;
				Filtros.convertI(imageBitmap, imgDest3);
				pbMiniI.Image = imgDest3;
				//Filtros.getHSI(imageBitmap, bitmaphsi);
				//Filtros.getCMY(imageBitmap, bitmapcmy);

				bitmaprgb = new Bitmap(pbOriginal.Image);
				bitmaph = new Bitmap(pbMiniH.Image);
				bitmaps = new Bitmap(pbMiniS.Image);
				bitmapi = new Bitmap(pbMiniI.Image);
				Filtros.convertHSItoRGB(bitmaph, bitmaps, bitmapi, imgDest4);
				pbmodified.Image = imgDest4;
			}
		}

		private void btLimpar_Click(object sender, EventArgs e)
		{
			pbOriginal.Image = null;
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

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
