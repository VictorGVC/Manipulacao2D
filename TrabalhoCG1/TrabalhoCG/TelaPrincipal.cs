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

				Bitmap imgDest = new Bitmap(image);
				imageBitmap = (Bitmap)image;
				Filtros.convertH(imageBitmap, imgDest);
				pbMiniH.Image = Filtros.ResizeImage(imgDest, 150, 100);
				Filtros.convertS(imageBitmap, imgDest);
				pbMiniS.Image = Filtros.ResizeImage(imgDest, 150, 100);
				Filtros.convertI(imageBitmap, imgDest);
				pbMiniI.Image = Filtros.ResizeImage(imgDest, 150, 100);
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
			}
		}
	}
}
