
namespace UI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnLoginAdmin = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoginAdmin
            // 
            this.btnLoginAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoginAdmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoginAdmin.BackgroundImage")));
            this.btnLoginAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoginAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginAdmin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginAdmin.Location = new System.Drawing.Point(488, 240);
            this.btnLoginAdmin.Name = "btnLoginAdmin";
            this.btnLoginAdmin.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btnLoginAdmin.Size = new System.Drawing.Size(30, 26);
            this.btnLoginAdmin.TabIndex = 1;
            this.btnLoginAdmin.UseVisualStyleBackColor = false;
            this.btnLoginAdmin.Click += new System.EventHandler(this.btnLoginAdmin_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnIniciarSesion.Image")));
            this.btnIniciarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarSesion.Location = new System.Drawing.Point(2, 2);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(140, 30);
            this.btnIniciarSesion.TabIndex = 2;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimer.Location = new System.Drawing.Point(2, 232);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(88, 34);
            this.btnTimer.TabIndex = 3;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = false;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(520, 270);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnLoginAdmin);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voto CR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoginAdmin;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnTimer;
    }
}

