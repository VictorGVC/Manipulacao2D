namespace TrabalhoCG
{
	partial class TelaPrincipal
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
			this.btLuminancia = new System.Windows.Forms.Button();
			this.btAbrirImagem = new System.Windows.Forms.Button();
			this.btLimpar = new System.Windows.Forms.Button();
			this.pictBoxImg1 = new System.Windows.Forms.PictureBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btLuminancia
			// 
			this.btLuminancia.BackColor = System.Drawing.Color.White;
			this.btLuminancia.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btLuminancia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btLuminancia.Location = new System.Drawing.Point(611, 72);
			this.btLuminancia.Name = "btLuminancia";
			this.btLuminancia.Size = new System.Drawing.Size(106, 23);
			this.btLuminancia.TabIndex = 111;
			this.btLuminancia.Text = "Luminância";
			this.btLuminancia.UseVisualStyleBackColor = false;
			this.btLuminancia.Click += new System.EventHandler(this.btLuminancia_Click);
			// 
			// btAbrirImagem
			// 
			this.btAbrirImagem.BackColor = System.Drawing.Color.White;
			this.btAbrirImagem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btAbrirImagem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btAbrirImagem.Image = ((System.Drawing.Image)(resources.GetObject("btAbrirImagem.Image")));
			this.btAbrirImagem.Location = new System.Drawing.Point(6, 19);
			this.btAbrirImagem.Name = "btAbrirImagem";
			this.btAbrirImagem.Size = new System.Drawing.Size(106, 23);
			this.btAbrirImagem.TabIndex = 106;
			this.btAbrirImagem.Text = "Abrir Imagem";
			this.btAbrirImagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btAbrirImagem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btAbrirImagem.UseVisualStyleBackColor = false;
			this.btAbrirImagem.Click += new System.EventHandler(this.btAbrirImagem_Click);
			// 
			// btLimpar
			// 
			this.btLimpar.BackColor = System.Drawing.Color.White;
			this.btLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btLimpar.Image")));
			this.btLimpar.Location = new System.Drawing.Point(118, 19);
			this.btLimpar.Name = "btLimpar";
			this.btLimpar.Size = new System.Drawing.Size(106, 23);
			this.btLimpar.TabIndex = 107;
			this.btLimpar.Text = "Limpar";
			this.btLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btLimpar.UseVisualStyleBackColor = false;
			this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
			// 
			// pictBoxImg1
			// 
			this.pictBoxImg1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pictBoxImg1.Location = new System.Drawing.Point(9, 12);
			this.pictBoxImg1.Name = "pictBoxImg1";
			this.pictBoxImg1.Size = new System.Drawing.Size(590, 500);
			this.pictBoxImg1.TabIndex = 112;
			this.pictBoxImg1.TabStop = false;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btAbrirImagem);
			this.groupBox1.Controls.Add(this.btLimpar);
			this.groupBox1.Location = new System.Drawing.Point(605, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(230, 54);
			this.groupBox1.TabIndex = 113;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Imagem";
			// 
			// TelaPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(844, 525);
			this.Controls.Add(this.btLuminancia);
			this.Controls.Add(this.pictBoxImg1);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TelaPrincipal";
			this.Text = "Trabalho CG";
			((System.ComponentModel.ISupportInitialize)(this.pictBoxImg1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btLuminancia;
		private System.Windows.Forms.Button btAbrirImagem;
		private System.Windows.Forms.Button btLimpar;
		private System.Windows.Forms.PictureBox pictBoxImg1;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}

