
namespace UI
{
    partial class frmRegistrarCandidato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarCandidato));
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblCedula = new System.Windows.Forms.Label();
            this.iconCandidato = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.lblPartido = new System.Windows.Forms.Label();
            this.cbPartido = new System.Windows.Forms.ComboBox();
            this.lblDefaultImage = new System.Windows.Forms.Label();
            this.btnSubirImagen = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(1, 1);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(98, 34);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Image = ((System.Drawing.Image)(resources.GetObject("lblCedula.Image")));
            this.lblCedula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCedula.Location = new System.Drawing.Point(127, 170);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(89, 21);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "       Cédula:";
            this.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iconCandidato
            // 
            this.iconCandidato.AutoSize = true;
            this.iconCandidato.Image = ((System.Drawing.Image)(resources.GetObject("iconCandidato.Image")));
            this.iconCandidato.Location = new System.Drawing.Point(195, 43);
            this.iconCandidato.Name = "iconCandidato";
            this.iconCandidato.Padding = new System.Windows.Forms.Padding(50);
            this.iconCandidato.Size = new System.Drawing.Size(100, 113);
            this.iconCandidato.TabIndex = 2;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.SystemColors.Control;
            this.txtCedula.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(131, 194);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(223, 29);
            this.txtCedula.TabIndex = 3;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Image = ((System.Drawing.Image)(resources.GetObject("lblPuesto.Image")));
            this.lblPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPuesto.Location = new System.Drawing.Point(127, 240);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(92, 21);
            this.lblPuesto.TabIndex = 4;
            this.lblPuesto.Text = "        Puesto:";
            // 
            // cbPuesto
            // 
            this.cbPuesto.BackColor = System.Drawing.SystemColors.Control;
            this.cbPuesto.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Location = new System.Drawing.Point(131, 265);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(223, 29);
            this.cbPuesto.TabIndex = 5;
            // 
            // lblPartido
            // 
            this.lblPartido.AutoSize = true;
            this.lblPartido.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartido.Image = ((System.Drawing.Image)(resources.GetObject("lblPartido.Image")));
            this.lblPartido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPartido.Location = new System.Drawing.Point(128, 308);
            this.lblPartido.Name = "lblPartido";
            this.lblPartido.Size = new System.Drawing.Size(91, 21);
            this.lblPartido.TabIndex = 6;
            this.lblPartido.Text = "       Partido:";
            // 
            // cbPartido
            // 
            this.cbPartido.BackColor = System.Drawing.SystemColors.Control;
            this.cbPartido.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPartido.FormattingEnabled = true;
            this.cbPartido.Location = new System.Drawing.Point(132, 333);
            this.cbPartido.Name = "cbPartido";
            this.cbPartido.Size = new System.Drawing.Size(222, 29);
            this.cbPartido.TabIndex = 7;
            // 
            // lblDefaultImage
            // 
            this.lblDefaultImage.AutoSize = true;
            this.lblDefaultImage.Image = ((System.Drawing.Image)(resources.GetObject("lblDefaultImage.Image")));
            this.lblDefaultImage.Location = new System.Drawing.Point(466, 73);
            this.lblDefaultImage.Name = "lblDefaultImage";
            this.lblDefaultImage.Padding = new System.Windows.Forms.Padding(110, 123, 110, 120);
            this.lblDefaultImage.Size = new System.Drawing.Size(220, 256);
            this.lblDefaultImage.TabIndex = 8;
            // 
            // btnSubirImagen
            // 
            this.btnSubirImagen.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubirImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirImagen.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSubirImagen.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubirImagen.Location = new System.Drawing.Point(466, 325);
            this.btnSubirImagen.Name = "btnSubirImagen";
            this.btnSubirImagen.Size = new System.Drawing.Size(220, 37);
            this.btnSubirImagen.TabIndex = 9;
            this.btnSubirImagen.Text = "Subir imagen";
            this.btnSubirImagen.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(253)))));
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(253)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegistrar.Location = new System.Drawing.Point(340, 392);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 34);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // frmRegistrarCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnSubirImagen);
            this.Controls.Add(this.lblDefaultImage);
            this.Controls.Add(this.cbPartido);
            this.Controls.Add(this.lblPartido);
            this.Controls.Add(this.cbPuesto);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.iconCandidato);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.btnVolver);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrarCandidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar candidato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label iconCandidato;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.Label lblPartido;
        private System.Windows.Forms.ComboBox cbPartido;
        private System.Windows.Forms.Label lblDefaultImage;
        private System.Windows.Forms.Button btnSubirImagen;
        private System.Windows.Forms.Button btnRegistrar;
    }
}