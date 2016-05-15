namespace ПроектВП
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNajava = new System.Windows.Forms.Button();
            this.btnIgraj = new System.Windows.Forms.Button();
            this.btnInstrukcii = new System.Windows.Forms.Button();
            this.pbZvuk = new System.Windows.Forms.PictureBox();
            this.btnRang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbZvuk)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNajava
            // 
            this.btnNajava.BackgroundImage = global::ПроектВП.Properties.Resources.button;
            this.btnNajava.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNajava.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNajava.Location = new System.Drawing.Point(79, 39);
            this.btnNajava.Name = "btnNajava";
            this.btnNajava.Size = new System.Drawing.Size(310, 94);
            this.btnNajava.TabIndex = 0;
            this.btnNajava.Text = "Најави се";
            this.btnNajava.UseVisualStyleBackColor = true;
            this.btnNajava.Click += new System.EventHandler(this.btnNajava_Click);
            this.btnNajava.MouseEnter += new System.EventHandler(this.btnNajava_MouseEnter);
            this.btnNajava.MouseLeave += new System.EventHandler(this.btnNajava_MouseLeave);
            // 
            // btnIgraj
            // 
            this.btnIgraj.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIgraj.BackgroundImage = global::ПроектВП.Properties.Resources.button;
            this.btnIgraj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIgraj.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.btnIgraj.Location = new System.Drawing.Point(79, 184);
            this.btnIgraj.Name = "btnIgraj";
            this.btnIgraj.Size = new System.Drawing.Size(310, 94);
            this.btnIgraj.TabIndex = 1;
            this.btnIgraj.Text = "Играј";
            this.btnIgraj.UseVisualStyleBackColor = false;
            this.btnIgraj.Click += new System.EventHandler(this.btnIgraj_Click);
            this.btnIgraj.MouseEnter += new System.EventHandler(this.btnIgraj_MouseEnter);
            this.btnIgraj.MouseLeave += new System.EventHandler(this.btnIgraj_MouseLeave);
            // 
            // btnInstrukcii
            // 
            this.btnInstrukcii.BackgroundImage = global::ПроектВП.Properties.Resources.button;
            this.btnInstrukcii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInstrukcii.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.btnInstrukcii.Location = new System.Drawing.Point(79, 336);
            this.btnInstrukcii.Name = "btnInstrukcii";
            this.btnInstrukcii.Size = new System.Drawing.Size(310, 94);
            this.btnInstrukcii.TabIndex = 2;
            this.btnInstrukcii.Text = "Инструкции";
            this.btnInstrukcii.UseVisualStyleBackColor = true;
            this.btnInstrukcii.Click += new System.EventHandler(this.btnInstrukcii_Click);
            this.btnInstrukcii.MouseEnter += new System.EventHandler(this.btnInstrukcii_MouseEnter);
            this.btnInstrukcii.MouseLeave += new System.EventHandler(this.btnInstrukcii_MouseLeave);
            // 
            // pbZvuk
            // 
            this.pbZvuk.BackColor = System.Drawing.Color.Transparent;
            this.pbZvuk.Location = new System.Drawing.Point(15, 12);
            this.pbZvuk.Name = "pbZvuk";
            this.pbZvuk.Size = new System.Drawing.Size(32, 35);
            this.pbZvuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbZvuk.TabIndex = 3;
            this.pbZvuk.TabStop = false;
            this.pbZvuk.Click += new System.EventHandler(this.pbZvuk_Click);
            // 
            // btnRang
            // 
            this.btnRang.BackgroundImage = global::ПроектВП.Properties.Resources.button;
            this.btnRang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRang.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.btnRang.Location = new System.Drawing.Point(79, 480);
            this.btnRang.Name = "btnRang";
            this.btnRang.Size = new System.Drawing.Size(310, 94);
            this.btnRang.TabIndex = 4;
            this.btnRang.Text = "Ранг листа";
            this.btnRang.UseVisualStyleBackColor = true;
            this.btnRang.Click += new System.EventHandler(this.btnRang_Click);
            this.btnRang.MouseEnter += new System.EventHandler(this.btnRang_MouseEnter);
            this.btnRang.MouseLeave += new System.EventHandler(this.btnRang_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ПроектВП.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 601);
            this.Controls.Add(this.btnRang);
            this.Controls.Add(this.pbZvuk);
            this.Controls.Add(this.btnInstrukcii);
            this.Controls.Add(this.btnIgraj);
            this.Controls.Add(this.btnNajava);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Риба";
            ((System.ComponentModel.ISupportInitialize)(this.pbZvuk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNajava;
        private System.Windows.Forms.Button btnIgraj;
        private System.Windows.Forms.Button btnInstrukcii;
        private System.Windows.Forms.PictureBox pbZvuk;
        private System.Windows.Forms.Button btnRang;
    }
}

