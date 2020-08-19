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
			openFileDialog.FileName = "";
			openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.gif;*.bmp;*.png)|*.jpg;*.gif;*.bmp;*.png";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				image = Image.FromFile(openFileDialog.FileName);
				pictBoxImg1.Image = image;
				pictBoxImg1.SizeMode = PictureBoxSizeMode.Normal;
			}
		}

		private void btLimpar_Click(object sender, EventArgs e)
		{
			pictBoxImg1.Image = null;
		}

		private void btLuminancia_Click(object sender, EventArgs e)
		{
			Bitmap imgDest = new Bitmap(image);
			imageBitmap = (Bitmap)image;
			Filtros.luminancia(imageBitmap, imgDest);
			pictBoxImg1.Image = imgDest;
		}
	}
}
