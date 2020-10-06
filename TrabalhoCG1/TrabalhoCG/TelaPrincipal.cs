using System;
using System.Collections;
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
		private int x1, x2, y1, y2, x1pol, y1pol, valori = 0, valorh = 0,idpol = 0;
		private bool mstatus;
		private String modoseg;
		private Image image;
		private Bitmap imageBitmap, bitmaprgb, bitmaph, bitmaps, bitmapi, bitmapcmy, b, aux;
		private List<Bitmap> ctrlz;
		private Color corpintura;
		private List<Poligono> poligonos;
		private Poligono polatual;
		private DataTable dtpontos,dtma;

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
			ctrlz = new List<Bitmap>();
			ctrlz.Add(new Bitmap(795, 462));
			poligonos = new List<Poligono>();
			polatual = null;

			dtpontos = new DataTable();
			dtpontos.Columns.Add("X");
			dtpontos.Columns.Add("Y");

			dgvpontos.DataSource = dtpontos;

			dtma = new DataTable();
			dtma.Columns.Add("a");
			dtma.Columns.Add("c");
			dtma.Columns.Add("d");

			dgvma.DataSource = dtma;
			dgvma.RowTemplate.Height = 46;
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

		private void equaçãoGeralRetaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			modoseg = "er";
		}

		private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			modoseg = "dr";
		}

		private void bresenhamToolStripMenuItem_Click(object sender, EventArgs e)
		{
			modoseg = "br";
		}

		private void equaçãoGeralCircToolStripMenuItem_Click(object sender, EventArgs e)
		{
			modoseg = "ec";
		}

		private void trigonometriaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			modoseg = "tr";
		}

		private void pontoMedioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			modoseg = "pm";
		}

		private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			modoseg = "el";
		}

		private void poligonoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			x1 = y1 = 0;
			modoseg = "po";
		}

		private void limparToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pbsegmentos.Image = b = aux = null;
			initSegmento();
		}

		private void floodFillToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog colorPicker = new ColorDialog();

			if (colorPicker.ShowDialog() == DialogResult.OK)
			{
				pbsegmentos.Cursor = Cursors.UpArrow;
				modoseg = "fo";
				corpintura = colorPicker.Color;
			}
		}

		private void scanLineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool b = true;
			String id;

			if(lvPoligonos.SelectedItems.Count > 0)
			{
				ColorDialog colorPicker = new ColorDialog();

				id = lvPoligonos.SelectedItems[0].Text;
				if (colorPicker.ShowDialog() == DialogResult.OK)
				{
					pbsegmentos.Cursor = Cursors.UpArrow;
					corpintura = colorPicker.Color;
					for (int i = 0; i < poligonos.Count && b; i++)
					{
						if (id.Equals(poligonos[i].getId().ToString()))
						{
							FiltroM.scanLine(poligonos[i], corpintura,this.b);
							b = false;
						}
					}
				}
			}
			else
				MessageBox.Show("Selecione um Polígono!", "Nenhum Polígono Selecionado", MessageBoxButtons.OK);
		}

		private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ctrlz.Count > 1)
			{
				pbsegmentos.Image = ctrlz[ctrlz.Count - 2];
				aux = ctrlz[ctrlz.Count - 2];
				ctrlz.RemoveAt(ctrlz.Count - 1);
			}
		}

        private void lvPoligonos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
			bool b = true;
			String id;
			if (lvPoligonos.SelectedItems.Count > 0)
            {
				id = lvPoligonos.SelectedItems[0].Text;

				for (int i = 0; i < poligonos.Count && b; i++)
				{
					if (id.Equals(poligonos[i].getId().ToString()))
                    {
						dtpontos.Rows.Clear();
						for (int j = 0; j < poligonos[i].getOriginais().Count; j++)
                        {
							dtpontos.Rows.Add(poligonos[i].getOriginais()[j].getX(), poligonos[i].getOriginais()[j].getX());
                        }
						dtma.Rows.Clear();
						dtma.Rows.Add(poligonos[i].getMa()[0, 0],poligonos[i].getMa()[0, 1], poligonos[i].getMa()[0, 2]);
						dtma.Rows.Add(poligonos[i].getMa()[1, 0], poligonos[i].getMa()[1, 1], poligonos[i].getMa()[1, 2]);
						dtma.Rows.Add(poligonos[i].getMa()[2, 0], poligonos[i].getMa()[2, 1], poligonos[i].getMa()[2, 2]);
						b = false;
                    }
				}
			}
        }

        private void btApplyTransla_Click(object sender, EventArgs e)
		{

		}

		private void btApplyEscala_Click(object sender, EventArgs e)
		{

		}

		private void btRotateLeft_Click(object sender, EventArgs e)
		{

		}

		private void btRotateRight_Click(object sender, EventArgs e)
		{

		}

		private void btApplyCis_Click(object sender, EventArgs e)
		{

		}

		private void btApplyEsp_Click(object sender, EventArgs e)
		{

		}

		private void rbCentro_CheckedChanged(object sender, EventArgs e)
		{
			tbxPonto.Enabled = false;
			tbyPonto.Enabled = false;
		}

		private void rbOrigem_CheckedChanged(object sender, EventArgs e)
		{
			tbxPonto.Enabled = false;
			tbyPonto.Enabled = false;
		}

		private void rbPonto_CheckedChanged(object sender, EventArgs e)
		{
			tbxPonto.Enabled = true;
			tbyPonto.Enabled = true;
		}

		private void pbsegmentos_Click(object sender, EventArgs e)
        {
			
			if (modoseg.Equals("po"))
            {
				
				if (x1 == 0 && y1 == 0)
				{
					polatual = new Poligono(idpol++);
					x1 = (e as MouseEventArgs).X;
					y1 = (e as MouseEventArgs).Y;
					polatual.addOriginais(new Ponto(x1, y1));
					x1pol = x1;
					y1pol = y1;
				}
				else
				{
					
					x1 = x2;
					y1 = y2;
					if (Math.Abs(x2 - x1pol) < 10 && Math.Abs(y2 - y1pol) < 10)
					{
						x1 = 0;
						y1 = 0;
						poligonos.Add(polatual);
						lvPoligonos.Items.Add(polatual.getId().ToString());
					}
					else
						polatual.addOriginais(new Ponto(x2, y2));
				}
				aux = b;
			}
			else if (modoseg.Equals("fo"))
			{
				pbsegmentos.Cursor = Cursors.Cross;
			}
		}

		private void pbsegmentos_MouseUp(object sender, MouseEventArgs e)
		{
			if (!modoseg.Equals("po"))
			{
				mstatus = false;
				aux = b;
				ctrlZ(aux);
			}
		}

		private void pbsegmentos_MouseDown(object sender, MouseEventArgs e)
        {
			if (!modoseg.Equals("po"))
			{
				x1 = e.X; y1 = e.Y;
				mstatus = true;
			}
        }

		private void bresenham(double dx, double dy, Bitmap b)
		{
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
		}

        private void pbsegmentos_MouseMove(object sender, MouseEventArgs e)
        {
			x2 = e.X;
			y2 = e.Y;
			b = (Bitmap)aux.Clone();
			

			double dx = x2 - x1;
			double dy = y2 - y1;

			if (x1 !=0 && y1 != 0 && modoseg.Equals("po"))
            {
				bresenham(dx, dy, b);
			}
			else if (mstatus)
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
								FiltroM.retaDda(b, x2, x1, y2, y1);
							else
								FiltroM.retaDda(b, x1, x2, y1, y2);
							pbsegmentos.Image = b;
						}
					break;

					case "br":
						bresenham(dx, dy, b);
						break;
					case "ec": 
						FiltroC.EqGeralCircunferencia(x1, y1, x2, y2, b); 
						pbsegmentos.Image = b;
						break;
					case "tr":
						FiltroM.circTrigonometria(x1, y1, x2, y2, b);
						pbsegmentos.Image = b;
						break;
					case "pm":
						FiltroM.circPontomedio(x1, y1, x2, y2, b);
						pbsegmentos.Image = b;
						break;
					case "el":
						FiltroM.elipse(Math.Abs(x2-x1), Math.Abs(y2 - y1), x1, y1, b);
						pbsegmentos.Image = b;
						break;
				}
			}
		}

		private void ctrlZ(Bitmap b)
        {
			if (ctrlz.Count > 10)
				ctrlz.RemoveAt(0);
			ctrlz.Add(b);
		}
    }
}