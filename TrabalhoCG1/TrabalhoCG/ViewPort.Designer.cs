﻿namespace TrabalhoCG
{
    partial class ViewPort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPort));
			this.pbviewport = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbviewport)).BeginInit();
			this.SuspendLayout();
			// 
			// pbviewport
			// 
			this.pbviewport.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.pbviewport.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbviewport.Location = new System.Drawing.Point(0, 0);
			this.pbviewport.Name = "pbviewport";
			this.pbviewport.Size = new System.Drawing.Size(800, 450);
			this.pbviewport.TabIndex = 0;
			this.pbviewport.TabStop = false;
			// 
			// ViewPort
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pbviewport);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ViewPort";
			this.Text = "ViewPort";
			((System.ComponentModel.ISupportInitialize)(this.pbviewport)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbviewport;
    }
}