
namespace mathchingGame2
{
    partial class VideoJuego
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoJuego));
            this.panelJuego = new System.Windows.Forms.TableLayoutPanel();
            this.pbxatrapame = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblFallas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxatrapame)).BeginInit();
            this.SuspendLayout();
            // 
            // panelJuego
            // 
            this.panelJuego.BackColor = System.Drawing.Color.Transparent;
            this.panelJuego.ColumnCount = 3;
            this.panelJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelJuego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelJuego.Location = new System.Drawing.Point(131, 112);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.RowCount = 3;
            this.panelJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelJuego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelJuego.Size = new System.Drawing.Size(339, 265);
            this.panelJuego.TabIndex = 0;
            // 
            // pbxatrapame
            // 
            this.pbxatrapame.BackColor = System.Drawing.Color.Transparent;
            this.pbxatrapame.Image = global::mathchingGame2.Properties.Resources.a1;
            this.pbxatrapame.Location = new System.Drawing.Point(476, 167);
            this.pbxatrapame.Name = "pbxatrapame";
            this.pbxatrapame.Size = new System.Drawing.Size(120, 122);
            this.pbxatrapame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxatrapame.TabIndex = 1;
            this.pbxatrapame.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stay Gracious", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Puntos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stay Gracious", 26.25F);
            this.label2.Location = new System.Drawing.Point(7, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fallas";
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntos.Font = new System.Drawing.Font("Spicy Chips", 24F);
            this.lblPuntos.ForeColor = System.Drawing.Color.White;
            this.lblPuntos.Location = new System.Drawing.Point(38, 167);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(32, 36);
            this.lblPuntos.TabIndex = 4;
            this.lblPuntos.Text = "0";
            // 
            // lblFallas
            // 
            this.lblFallas.AutoSize = true;
            this.lblFallas.BackColor = System.Drawing.Color.Transparent;
            this.lblFallas.Font = new System.Drawing.Font("Spicy Chips", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFallas.ForeColor = System.Drawing.Color.White;
            this.lblFallas.Location = new System.Drawing.Point(38, 249);
            this.lblFallas.Name = "lblFallas";
            this.lblFallas.Size = new System.Drawing.Size(32, 36);
            this.lblFallas.TabIndex = 5;
            this.lblFallas.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 50000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Spicy Chips", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(70, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(476, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aplasta la Marmota";
            // 
            // VideoJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mathchingGame2.Properties.Resources.Paisajes_Fondos_Escenarios_ilustraciones_gratis___My_Little_House;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(620, 377);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFallas);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxatrapame);
            this.Controls.Add(this.panelJuego);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VideoJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplasta la marmota";
            this.Load += new System.EventHandler(this.VideoJuego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxatrapame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelJuego;
        private System.Windows.Forms.PictureBox pbxatrapame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblFallas;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
    }
}