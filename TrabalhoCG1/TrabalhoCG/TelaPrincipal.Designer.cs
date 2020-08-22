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
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbMiniH = new System.Windows.Forms.PictureBox();
            this.pbMiniS = new System.Windows.Forms.PictureBox();
            this.pbMiniI = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbI = new System.Windows.Forms.TextBox();
            this.tbM = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbG = new System.Windows.Forms.TextBox();
            this.tbH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbmodified = new System.Windows.Forms.PictureBox();
            this.btmenhue = new System.Windows.Forms.Button();
            this.btmaihue = new System.Windows.Forms.Button();
            this.btmenbri = new System.Windows.Forms.Button();
            this.btmaibri = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniI)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmodified)).BeginInit();
            this.SuspendLayout();
            // 
            // btLuminancia
            // 
            this.btLuminancia.BackColor = System.Drawing.Color.White;
            this.btLuminancia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLuminancia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLuminancia.Location = new System.Drawing.Point(294, 382);
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
            this.btLimpar.Location = new System.Drawing.Point(6, 61);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(106, 23);
            this.btLimpar.TabIndex = 107;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // pbOriginal
            // 
            this.pbOriginal.BackColor = System.Drawing.Color.White;
            this.pbOriginal.Location = new System.Drawing.Point(9, 12);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(450, 350);
            this.pbOriginal.TabIndex = 112;
            this.pbOriginal.TabStop = false;
            this.pbOriginal.MouseLeave += new System.EventHandler(this.pbOriginal_MouseLeave);
            this.pbOriginal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbOriginal_MouseMove);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAbrirImagem);
            this.groupBox1.Controls.Add(this.btLimpar);
            this.groupBox1.Location = new System.Drawing.Point(9, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 96);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagem";
            // 
            // pbMiniH
            // 
            this.pbMiniH.BackColor = System.Drawing.Color.White;
            this.pbMiniH.Location = new System.Drawing.Point(465, 12);
            this.pbMiniH.Name = "pbMiniH";
            this.pbMiniH.Size = new System.Drawing.Size(150, 100);
            this.pbMiniH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMiniH.TabIndex = 114;
            this.pbMiniH.TabStop = false;
            // 
            // pbMiniS
            // 
            this.pbMiniS.BackColor = System.Drawing.Color.White;
            this.pbMiniS.Location = new System.Drawing.Point(465, 136);
            this.pbMiniS.Name = "pbMiniS";
            this.pbMiniS.Size = new System.Drawing.Size(150, 100);
            this.pbMiniS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMiniS.TabIndex = 114;
            this.pbMiniS.TabStop = false;
            // 
            // pbMiniI
            // 
            this.pbMiniI.BackColor = System.Drawing.Color.White;
            this.pbMiniI.Location = new System.Drawing.Point(465, 262);
            this.pbMiniI.Name = "pbMiniI";
            this.pbMiniI.Size = new System.Drawing.Size(150, 100);
            this.pbMiniI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMiniI.TabIndex = 114;
            this.pbMiniI.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbY);
            this.groupBox2.Controls.Add(this.tbI);
            this.groupBox2.Controls.Add(this.tbM);
            this.groupBox2.Controls.Add(this.tbB);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbS);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbC);
            this.groupBox2.Controls.Add(this.tbG);
            this.groupBox2.Controls.Add(this.tbH);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbR);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(135, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 96);
            this.groupBox2.TabIndex = 115;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cores";
            // 
            // tbY
            // 
            this.tbY.Enabled = false;
            this.tbY.Location = new System.Drawing.Point(113, 68);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(28, 20);
            this.tbY.TabIndex = 116;
            this.tbY.Text = "0";
            // 
            // tbI
            // 
            this.tbI.Enabled = false;
            this.tbI.Location = new System.Drawing.Point(113, 42);
            this.tbI.Name = "tbI";
            this.tbI.Size = new System.Drawing.Size(28, 20);
            this.tbI.TabIndex = 116;
            this.tbI.Text = "0";
            // 
            // tbM
            // 
            this.tbM.Enabled = false;
            this.tbM.Location = new System.Drawing.Point(65, 68);
            this.tbM.Name = "tbM";
            this.tbM.Size = new System.Drawing.Size(28, 20);
            this.tbM.TabIndex = 116;
            this.tbM.Text = "0";
            // 
            // tbB
            // 
            this.tbB.Enabled = false;
            this.tbB.Location = new System.Drawing.Point(113, 16);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(28, 20);
            this.tbB.TabIndex = 116;
            this.tbB.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Y";
            // 
            // tbS
            // 
            this.tbS.Enabled = false;
            this.tbS.Location = new System.Drawing.Point(65, 42);
            this.tbS.Name = "tbS";
            this.tbS.Size = new System.Drawing.Size(28, 20);
            this.tbS.TabIndex = 116;
            this.tbS.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "I";
            // 
            // tbC
            // 
            this.tbC.Enabled = false;
            this.tbC.Location = new System.Drawing.Point(19, 68);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(28, 20);
            this.tbC.TabIndex = 116;
            this.tbC.Text = "0";
            // 
            // tbG
            // 
            this.tbG.Enabled = false;
            this.tbG.Location = new System.Drawing.Point(65, 16);
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(28, 20);
            this.tbG.TabIndex = 116;
            this.tbG.Text = "0";
            // 
            // tbH
            // 
            this.tbH.Enabled = false;
            this.tbH.Location = new System.Drawing.Point(19, 42);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(28, 20);
            this.tbH.TabIndex = 116;
            this.tbH.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "M";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "S";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "C";
            // 
            // tbR
            // 
            this.tbR.Enabled = false;
            this.tbR.Location = new System.Drawing.Point(19, 16);
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(28, 20);
            this.tbR.TabIndex = 116;
            this.tbR.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "G";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "R";
            // 
            // pbmodified
            // 
            this.pbmodified.BackColor = System.Drawing.Color.White;
            this.pbmodified.Location = new System.Drawing.Point(632, 12);
            this.pbmodified.Name = "pbmodified";
            this.pbmodified.Size = new System.Drawing.Size(237, 158);
            this.pbmodified.TabIndex = 112;
            this.pbmodified.TabStop = false;
            // 
            // btmenhue
            // 
            this.btmenhue.AutoEllipsis = true;
            this.btmenhue.Location = new System.Drawing.Point(711, 198);
            this.btmenhue.Name = "btmenhue";
            this.btmenhue.Size = new System.Drawing.Size(35, 23);
            this.btmenhue.TabIndex = 116;
            this.btmenhue.Text = "-";
            this.btmenhue.UseVisualStyleBackColor = true;
            // 
            // btmaihue
            // 
            this.btmaihue.Location = new System.Drawing.Point(752, 198);
            this.btmaihue.Name = "btmaihue";
            this.btmaihue.Size = new System.Drawing.Size(35, 23);
            this.btmaihue.TabIndex = 117;
            this.btmaihue.Text = "+";
            this.btmaihue.UseVisualStyleBackColor = true;
            // 
            // btmenbri
            // 
            this.btmenbri.Location = new System.Drawing.Point(711, 262);
            this.btmenbri.Name = "btmenbri";
            this.btmenbri.Size = new System.Drawing.Size(35, 23);
            this.btmenbri.TabIndex = 118;
            this.btmenbri.Text = "-";
            this.btmenbri.UseVisualStyleBackColor = true;
            // 
            // btmaibri
            // 
            this.btmaibri.Location = new System.Drawing.Point(752, 262);
            this.btmaibri.Name = "btmaibri";
            this.btmaibri.Size = new System.Drawing.Size(35, 23);
            this.btmaibri.TabIndex = 119;
            this.btmaibri.Text = "+";
            this.btmaibri.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(735, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 120;
            this.label10.Text = "HUE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(732, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 121;
            this.label11.Text = "Brilho";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(881, 476);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btmaibri);
            this.Controls.Add(this.btmenbri);
            this.Controls.Add(this.btmaihue);
            this.Controls.Add(this.btmenhue);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pbMiniI);
            this.Controls.Add(this.pbMiniS);
            this.Controls.Add(this.pbMiniH);
            this.Controls.Add(this.btLuminancia);
            this.Controls.Add(this.pbmodified);
            this.Controls.Add(this.pbOriginal);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.Text = "Trabalho CG";
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniI)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbmodified)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btLuminancia;
		private System.Windows.Forms.Button btAbrirImagem;
		private System.Windows.Forms.Button btLimpar;
		private System.Windows.Forms.PictureBox pbOriginal;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pbMiniH;
		private System.Windows.Forms.PictureBox pbMiniS;
		private System.Windows.Forms.PictureBox pbMiniI;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox tbG;
		private System.Windows.Forms.TextBox tbR;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbY;
		private System.Windows.Forms.TextBox tbI;
		private System.Windows.Forms.TextBox tbM;
		private System.Windows.Forms.TextBox tbB;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbS;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbC;
		private System.Windows.Forms.TextBox tbH;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbmodified;
        private System.Windows.Forms.Button btmenhue;
        private System.Windows.Forms.Button btmaihue;
        private System.Windows.Forms.Button btmenbri;
        private System.Windows.Forms.Button btmaibri;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

