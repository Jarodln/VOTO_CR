﻿
namespace UI
{
    partial class frmRegistrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarUsuario));
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblIconoUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(1, 1);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(95, 34);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblIconoUsuario
            // 
            this.lblIconoUsuario.AutoSize = true;
            this.lblIconoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("lblIconoUsuario.Image")));
            this.lblIconoUsuario.Location = new System.Drawing.Point(341, 31);
            this.lblIconoUsuario.Name = "lblIconoUsuario";
            this.lblIconoUsuario.Padding = new System.Windows.Forms.Padding(60, 50, 60, 50);
            this.lblIconoUsuario.Size = new System.Drawing.Size(120, 113);
            this.lblIconoUsuario.TabIndex = 1;
            // 
            // frmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIconoUsuario);
            this.Controls.Add(this.btnVolver);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrarse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblIconoUsuario;
    }
}