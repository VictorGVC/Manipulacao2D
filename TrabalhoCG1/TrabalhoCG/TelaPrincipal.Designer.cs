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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabcolors = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btmaibri = new System.Windows.Forms.Button();
            this.btmenbri = new System.Windows.Forms.Button();
            this.btmaihue = new System.Windows.Forms.Button();
            this.btmenhue = new System.Windows.Forms.Button();
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
            this.pbMiniI = new System.Windows.Forms.PictureBox();
            this.pbMiniS = new System.Windows.Forms.PictureBox();
            this.pbMiniH = new System.Windows.Forms.PictureBox();
            this.btLuminancia = new System.Windows.Forms.Button();
            this.pbmodified = new System.Windows.Forms.PictureBox();
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAbrirImagem = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.tabseg = new System.Windows.Forms.TabPage();
            this.gbcirculo = new System.Windows.Forms.GroupBox();
            this.gbreta = new System.Windows.Forms.GroupBox();
            this.rbBres = new System.Windows.Forms.RadioButton();
            this.rbddareta = new System.Windows.Forms.RadioButton();
            this.rbeqreta = new System.Windows.Forms.RadioButton();
            this.pbsegmentos = new System.Windows.Forms.PictureBox();
            this.rbeqcircunferencia = new System.Windows.Forms.RadioButton();
            this.rbtrigonometria = new System.Windows.Forms.RadioButton();
            this.rbpontomedio = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.tabs.SuspendLayout();
            this.tabcolors.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmodified)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabseg.SuspendLayout();
            this.gbcirculo.SuspendLayout();
            this.gbreta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbsegmentos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabcolors);
            this.tabs.Controls.Add(this.tabseg);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1019, 502);
            this.tabs.TabIndex = 0;
            // 
            // tabcolors
            // 
            this.tabcolors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(188)))));
            this.tabcolors.Controls.Add(this.label11);
            this.tabcolors.Controls.Add(this.label10);
            this.tabcolors.Controls.Add(this.btmaibri);
            this.tabcolors.Controls.Add(this.btmenbri);
            this.tabcolors.Controls.Add(this.btmaihue);
            this.tabcolors.Controls.Add(this.btmenhue);
            this.tabcolors.Controls.Add(this.groupBox2);
            this.tabcolors.Controls.Add(this.pbMiniI);
            this.tabcolors.Controls.Add(this.pbMiniS);
            this.tabcolors.Controls.Add(this.pbMiniH);
            this.tabcolors.Controls.Add(this.btLuminancia);
            this.tabcolors.Controls.Add(this.pbmodified);
            this.tabcolors.Controls.Add(this.pbOriginal);
            this.tabcolors.Controls.Add(this.groupBox1);
            this.tabcolors.Location = new System.Drawing.Point(4, 22);
            this.tabcolors.Name = "tabcolors";
            this.tabcolors.Padding = new System.Windows.Forms.Padding(3);
            this.tabcolors.Size = new System.Drawing.Size(1011, 476);
            this.tabcolors.TabIndex = 0;
            this.tabcolors.Text = "Processamento de Imagens";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(830, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 149;
            this.label11.Text = "Brilho";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(714, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 148;
            this.label10.Text = "HUE";
            // 
            // btmaibri
            // 
            this.btmaibri.BackColor = System.Drawing.Color.White;
            this.btmaibri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmaibri.Location = new System.Drawing.Point(850, 366);
            this.btmaibri.Name = "btmaibri";
            this.btmaibri.Size = new System.Drawing.Size(35, 23);
            this.btmaibri.TabIndex = 147;
            this.btmaibri.Text = "+";
            this.btmaibri.UseVisualStyleBackColor = false;
            this.btmaibri.Click += new System.EventHandler(this.btmaibri_Click);
            // 
            // btmenbri
            // 
            this.btmenbri.BackColor = System.Drawing.Color.White;
            this.btmenbri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmenbri.Location = new System.Drawing.Point(809, 366);
            this.btmenbri.Name = "btmenbri";
            this.btmenbri.Size = new System.Drawing.Size(35, 23);
            this.btmenbri.TabIndex = 146;
            this.btmenbri.Text = "-";
            this.btmenbri.UseVisualStyleBackColor = false;
            this.btmenbri.Click += new System.EventHandler(this.btmenbri_Click);
            // 
            // btmaihue
            // 
            this.btmaihue.BackColor = System.Drawing.Color.White;
            this.btmaihue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmaihue.Location = new System.Drawing.Point(731, 366);
            this.btmaihue.Name = "btmaihue";
            this.btmaihue.Size = new System.Drawing.Size(35, 23);
            this.btmaihue.TabIndex = 145;
            this.btmaihue.Text = "+";
            this.btmaihue.UseVisualStyleBackColor = false;
            this.btmaihue.Click += new System.EventHandler(this.btmaihue_Click);
            // 
            // btmenhue
            // 
            this.btmenhue.AutoEllipsis = true;
            this.btmenhue.BackColor = System.Drawing.Color.White;
            this.btmenhue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btmenhue.Location = new System.Drawing.Point(690, 366);
            this.btmenhue.Name = "btmenhue";
            this.btmenhue.Size = new System.Drawing.Size(35, 23);
            this.btmenhue.TabIndex = 144;
            this.btmenhue.Text = "-";
            this.btmenhue.UseVisualStyleBackColor = false;
            this.btmenhue.Click += new System.EventHandler(this.btmenhue_Click);
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
            this.groupBox2.Location = new System.Drawing.Point(152, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 96);
            this.groupBox2.TabIndex = 143;
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
            // pbMiniI
            // 
            this.pbMiniI.BackColor = System.Drawing.Color.White;
            this.pbMiniI.Location = new System.Drawing.Point(429, 241);
            this.pbMiniI.Name = "pbMiniI";
            this.pbMiniI.Size = new System.Drawing.Size(150, 100);
            this.pbMiniI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMiniI.TabIndex = 140;
            this.pbMiniI.TabStop = false;
            // 
            // pbMiniS
            // 
            this.pbMiniS.BackColor = System.Drawing.Color.White;
            this.pbMiniS.Location = new System.Drawing.Point(429, 135);
            this.pbMiniS.Name = "pbMiniS";
            this.pbMiniS.Size = new System.Drawing.Size(150, 100);
            this.pbMiniS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMiniS.TabIndex = 141;
            this.pbMiniS.TabStop = false;
            // 
            // pbMiniH
            // 
            this.pbMiniH.BackColor = System.Drawing.Color.White;
            this.pbMiniH.Location = new System.Drawing.Point(429, 29);
            this.pbMiniH.Name = "pbMiniH";
            this.pbMiniH.Size = new System.Drawing.Size(150, 100);
            this.pbMiniH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMiniH.TabIndex = 142;
            this.pbMiniH.TabStop = false;
            // 
            // btLuminancia
            // 
            this.btLuminancia.BackColor = System.Drawing.Color.White;
            this.btLuminancia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLuminancia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLuminancia.Location = new System.Drawing.Point(311, 361);
            this.btLuminancia.Name = "btLuminancia";
            this.btLuminancia.Size = new System.Drawing.Size(112, 23);
            this.btLuminancia.TabIndex = 136;
            this.btLuminancia.Text = "Luminância";
            this.btLuminancia.UseVisualStyleBackColor = false;
            this.btLuminancia.Click += new System.EventHandler(this.btLuminancia_Click);
            // 
            // pbmodified
            // 
            this.pbmodified.BackColor = System.Drawing.Color.White;
            this.pbmodified.Location = new System.Drawing.Point(585, 29);
            this.pbmodified.Name = "pbmodified";
            this.pbmodified.Size = new System.Drawing.Size(400, 312);
            this.pbmodified.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbmodified.TabIndex = 137;
            this.pbmodified.TabStop = false;
            // 
            // pbOriginal
            // 
            this.pbOriginal.BackColor = System.Drawing.Color.White;
            this.pbOriginal.Location = new System.Drawing.Point(23, 29);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(400, 312);
            this.pbOriginal.TabIndex = 138;
            this.pbOriginal.TabStop = false;
            this.pbOriginal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbOriginal_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAbrirImagem);
            this.groupBox1.Controls.Add(this.btLimpar);
            this.groupBox1.Location = new System.Drawing.Point(26, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 96);
            this.groupBox1.TabIndex = 139;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagem";
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
            // tabseg
            // 
            this.tabseg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(172)))), ((int)(((byte)(188)))));
            this.tabseg.Controls.Add(this.groupBox3);
            this.tabseg.Controls.Add(this.gbcirculo);
            this.tabseg.Controls.Add(this.gbreta);
            this.tabseg.Controls.Add(this.pbsegmentos);
            this.tabseg.Location = new System.Drawing.Point(4, 22);
            this.tabseg.Name = "tabseg";
            this.tabseg.Padding = new System.Windows.Forms.Padding(3);
            this.tabseg.Size = new System.Drawing.Size(1011, 476);
            this.tabseg.TabIndex = 1;
            this.tabseg.Text = "Segmentação";
            // 
            // gbcirculo
            // 
            this.gbcirculo.Controls.Add(this.rbpontomedio);
            this.gbcirculo.Controls.Add(this.rbtrigonometria);
            this.gbcirculo.Controls.Add(this.rbeqcircunferencia);
            this.gbcirculo.Location = new System.Drawing.Point(9, 130);
            this.gbcirculo.Name = "gbcirculo";
            this.gbcirculo.Size = new System.Drawing.Size(195, 121);
            this.gbcirculo.TabIndex = 2;
            this.gbcirculo.TabStop = false;
            this.gbcirculo.Text = "Circuferência";
            // 
            // gbreta
            // 
            this.gbreta.Controls.Add(this.rbBres);
            this.gbreta.Controls.Add(this.rbddareta);
            this.gbreta.Controls.Add(this.rbeqreta);
            this.gbreta.Location = new System.Drawing.Point(8, 6);
            this.gbreta.Name = "gbreta";
            this.gbreta.Size = new System.Drawing.Size(196, 117);
            this.gbreta.TabIndex = 1;
            this.gbreta.TabStop = false;
            this.gbreta.Text = "Reta";
            // 
            // rbBres
            // 
            this.rbBres.AutoSize = true;
            this.rbBres.Location = new System.Drawing.Point(15, 84);
            this.rbBres.Name = "rbBres";
            this.rbBres.Size = new System.Drawing.Size(78, 17);
            this.rbBres.TabIndex = 2;
            this.rbBres.TabStop = true;
            this.rbBres.Text = "Bresenham";
            this.rbBres.UseVisualStyleBackColor = true;
            this.rbBres.CheckedChanged += new System.EventHandler(this.rbBres_CheckedChanged);
            // 
            // rbddareta
            // 
            this.rbddareta.AutoSize = true;
            this.rbddareta.Location = new System.Drawing.Point(15, 51);
            this.rbddareta.Name = "rbddareta";
            this.rbddareta.Size = new System.Drawing.Size(48, 17);
            this.rbddareta.TabIndex = 1;
            this.rbddareta.TabStop = true;
            this.rbddareta.Text = "DDA";
            this.rbddareta.UseVisualStyleBackColor = true;
            this.rbddareta.CheckedChanged += new System.EventHandler(this.rbddareta_CheckedChanged);
            // 
            // rbeqreta
            // 
            this.rbeqreta.AutoSize = true;
            this.rbeqreta.Location = new System.Drawing.Point(15, 19);
            this.rbeqreta.Name = "rbeqreta";
            this.rbeqreta.Size = new System.Drawing.Size(134, 17);
            this.rbeqreta.TabIndex = 0;
            this.rbeqreta.TabStop = true;
            this.rbeqreta.Text = "Equação Real da Reta";
            this.rbeqreta.UseVisualStyleBackColor = true;
            this.rbeqreta.CheckedChanged += new System.EventHandler(this.rbeqreta_CheckedChanged);
            // 
            // pbsegmentos
            // 
            this.pbsegmentos.BackColor = System.Drawing.Color.White;
            this.pbsegmentos.Location = new System.Drawing.Point(210, 6);
            this.pbsegmentos.Name = "pbsegmentos";
            this.pbsegmentos.Size = new System.Drawing.Size(795, 462);
            this.pbsegmentos.TabIndex = 0;
            this.pbsegmentos.TabStop = false;
            this.pbsegmentos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbsegmentos_MouseDown);
            this.pbsegmentos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbsegmentos_MouseMove);
            this.pbsegmentos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbsegmentos_MouseUp);
            // 
            // rbeqcircunferencia
            // 
            this.rbeqcircunferencia.AutoSize = true;
            this.rbeqcircunferencia.Location = new System.Drawing.Point(6, 19);
            this.rbeqcircunferencia.Name = "rbeqcircunferencia";
            this.rbeqcircunferencia.Size = new System.Drawing.Size(182, 17);
            this.rbeqcircunferencia.TabIndex = 0;
            this.rbeqcircunferencia.TabStop = true;
            this.rbeqcircunferencia.Text = "Equação Geral da Circunferência";
            this.rbeqcircunferencia.UseVisualStyleBackColor = true;
            this.rbeqcircunferencia.CheckedChanged += new System.EventHandler(this.rbeqcircunferencia_CheckedChanged);
            // 
            // rbtrigonometria
            // 
            this.rbtrigonometria.AutoSize = true;
            this.rbtrigonometria.Location = new System.Drawing.Point(7, 54);
            this.rbtrigonometria.Name = "rbtrigonometria";
            this.rbtrigonometria.Size = new System.Drawing.Size(166, 17);
            this.rbtrigonometria.TabIndex = 1;
            this.rbtrigonometria.TabStop = true;
            this.rbtrigonometria.Text = "Trigonometria (seno/cosseno)";
            this.rbtrigonometria.UseVisualStyleBackColor = true;
            this.rbtrigonometria.CheckedChanged += new System.EventHandler(this.rbtrigonometria_CheckedChanged);
            // 
            // rbpontomedio
            // 
            this.rbpontomedio.AutoSize = true;
            this.rbpontomedio.Location = new System.Drawing.Point(6, 87);
            this.rbpontomedio.Name = "rbpontomedio";
            this.rbpontomedio.Size = new System.Drawing.Size(85, 17);
            this.rbpontomedio.TabIndex = 2;
            this.rbpontomedio.TabStop = true;
            this.rbpontomedio.Text = "Ponto Médio";
            this.rbpontomedio.UseVisualStyleBackColor = true;
            this.rbpontomedio.CheckedChanged += new System.EventHandler(this.rbpontomedio_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Location = new System.Drawing.Point(9, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(195, 54);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elipse";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ponto Médio";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1019, 502);
            this.Controls.Add(this.tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.Text = "Trabalho CG - 1º Bimestre";
            this.tabs.ResumeLayout(false);
            this.tabcolors.ResumeLayout(false);
            this.tabcolors.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiniH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmodified)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabseg.ResumeLayout(false);
            this.gbcirculo.ResumeLayout(false);
            this.gbcirculo.PerformLayout();
            this.gbreta.ResumeLayout(false);
            this.gbreta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbsegmentos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabcolors;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btmaibri;
        private System.Windows.Forms.Button btmenbri;
        private System.Windows.Forms.Button btmaihue;
        private System.Windows.Forms.Button btmenhue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbI;
        private System.Windows.Forms.TextBox tbM;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbG;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbMiniI;
        private System.Windows.Forms.PictureBox pbMiniS;
        private System.Windows.Forms.PictureBox pbMiniH;
        private System.Windows.Forms.Button btLuminancia;
        private System.Windows.Forms.PictureBox pbmodified;
        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAbrirImagem;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.TabPage tabseg;
        private System.Windows.Forms.GroupBox gbreta;
        private System.Windows.Forms.PictureBox pbsegmentos;
        private System.Windows.Forms.GroupBox gbcirculo;
        private System.Windows.Forms.RadioButton rbddareta;
        private System.Windows.Forms.RadioButton rbeqreta;
        private System.Windows.Forms.RadioButton rbBres;
        private System.Windows.Forms.RadioButton rbpontomedio;
        private System.Windows.Forms.RadioButton rbtrigonometria;
        private System.Windows.Forms.RadioButton rbeqcircunferencia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

