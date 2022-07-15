
namespace UI
{
    partial class frmDashboardVotante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboardVotante));
            this.btnVolver = new System.Windows.Forms.Button();
            this.gpbIcono = new System.Windows.Forms.GroupBox();
            this.lblIcon = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbIcono.SuspendLayout();
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
            this.btnVolver.Location = new System.Drawing.Point(2, 1);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 34);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "      Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // gpbIcono
            // 
            this.gpbIcono.BackColor = System.Drawing.SystemColors.Control;
            this.gpbIcono.Controls.Add(this.lblIcon);
            this.gpbIcono.Location = new System.Drawing.Point(2, 41);
            this.gpbIcono.Name = "gpbIcono";
            this.gpbIcono.Size = new System.Drawing.Size(798, 144);
            this.gpbIcono.TabIndex = 1;
            this.gpbIcono.TabStop = false;
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Image = ((System.Drawing.Image)(resources.GetObject("lblIcon.Image")));
            this.lblIcon.Location = new System.Drawing.Point(347, 16);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Padding = new System.Windows.Forms.Padding(50);
            this.lblIcon.Size = new System.Drawing.Size(100, 113);
            this.lblIcon.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(253)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(253)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(334, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Votar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmDashboardVotante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpbIcono);
            this.Controls.Add(this.btnVolver);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashboardVotante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.gpbIcono.ResumeLayout(false);
            this.gpbIcono.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox gpbIcono;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Button button1;
    }
}