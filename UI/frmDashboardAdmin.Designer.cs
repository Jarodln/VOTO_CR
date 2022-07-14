
namespace UI
{
    partial class frmDashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboardAdmin));
            this.btnVolver = new System.Windows.Forms.Button();
            this.gpbIcon = new System.Windows.Forms.GroupBox();
            this.lblIconAdmin = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnArchivo = new System.Windows.Forms.Button();
            this.btnMantenimientos = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.gpbIcon.SuspendLayout();
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
            this.btnVolver.Size = new System.Drawing.Size(103, 35);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "       Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // gpbIcon
            // 
            this.gpbIcon.BackColor = System.Drawing.SystemColors.Control;
            this.gpbIcon.Controls.Add(this.lblAdmin);
            this.gpbIcon.Controls.Add(this.lblIconAdmin);
            this.gpbIcon.Location = new System.Drawing.Point(1, 33);
            this.gpbIcon.Name = "gpbIcon";
            this.gpbIcon.Size = new System.Drawing.Size(801, 157);
            this.gpbIcon.TabIndex = 1;
            this.gpbIcon.TabStop = false;
            // 
            // lblIconAdmin
            // 
            this.lblIconAdmin.AutoSize = true;
            this.lblIconAdmin.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIconAdmin.Image = ((System.Drawing.Image)(resources.GetObject("lblIconAdmin.Image")));
            this.lblIconAdmin.Location = new System.Drawing.Point(340, 16);
            this.lblIconAdmin.Name = "lblIconAdmin";
            this.lblIconAdmin.Padding = new System.Windows.Forms.Padding(50, 40, 50, 40);
            this.lblIconAdmin.Size = new System.Drawing.Size(100, 105);
            this.lblIconAdmin.TabIndex = 0;
            this.lblIconAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(329, 111);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(135, 25);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Administrador";
            // 
            // btnArchivo
            // 
            this.btnArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(253)))));
            this.btnArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(253)))));
            this.btnArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchivo.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnArchivo.Location = new System.Drawing.Point(176, 247);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(144, 38);
            this.btnArchivo.TabIndex = 2;
            this.btnArchivo.Text = "Archivo";
            this.btnArchivo.UseVisualStyleBackColor = false;
            // 
            // btnMantenimientos
            // 
            this.btnMantenimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(253)))));
            this.btnMantenimientos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMantenimientos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(253)))));
            this.btnMantenimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMantenimientos.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMantenimientos.Location = new System.Drawing.Point(492, 247);
            this.btnMantenimientos.Name = "btnMantenimientos";
            this.btnMantenimientos.Size = new System.Drawing.Size(144, 38);
            this.btnMantenimientos.TabIndex = 3;
            this.btnMantenimientos.Text = "Mantenimientos";
            this.btnMantenimientos.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(253)))));
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(253)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReportes.Location = new System.Drawing.Point(176, 337);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(144, 38);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(253)))));
            this.btnAcercaDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcercaDe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(253)))));
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcercaDe.Location = new System.Drawing.Point(492, 337);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(144, 38);
            this.btnAcercaDe.TabIndex = 5;
            this.btnAcercaDe.Text = "Acerca de...";
            this.btnAcercaDe.UseVisualStyleBackColor = false;
            // 
            // frmDashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnMantenimientos);
            this.Controls.Add(this.btnArchivo);
            this.Controls.Add(this.gpbIcon);
            this.Controls.Add(this.btnVolver);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashboardAdmin";
            this.Text = "Dashboard";
            this.gpbIcon.ResumeLayout(false);
            this.gpbIcon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox gpbIcon;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label lblIconAdmin;
        private System.Windows.Forms.Button btnArchivo;
        private System.Windows.Forms.Button btnMantenimientos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnAcercaDe;
    }
}