namespace ПроектВП
{
    partial class LoginForm
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
            this.pnlPanela = new System.Windows.Forms.Panel();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnOtkazhi = new System.Windows.Forms.Button();
            this.epIme = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlPanela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epIme)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPanela
            // 
            this.pnlPanela.BackColor = System.Drawing.SystemColors.Info;
            this.pnlPanela.Controls.Add(this.tbIme);
            this.pnlPanela.Controls.Add(this.lblIme);
            this.pnlPanela.Location = new System.Drawing.Point(22, 12);
            this.pnlPanela.Name = "pnlPanela";
            this.pnlPanela.Size = new System.Drawing.Size(312, 116);
            this.pnlPanela.TabIndex = 0;
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(10, 42);
            this.tbIme.MaxLength = 8;
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(259, 45);
            this.tbIme.TabIndex = 2;
            this.tbIme.Validating += new System.ComponentModel.CancelEventHandler(this.tbIme_Validating);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.BackColor = System.Drawing.Color.Transparent;
            this.lblIme.Location = new System.Drawing.Point(3, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(211, 38);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Име на рибата:";
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = global::ПроектВП.Properties.Resources.button;
            this.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOK.Location = new System.Drawing.Point(22, 144);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(128, 50);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            this.btnOK.MouseEnter += new System.EventHandler(this.btnOK_MouseEnter);
            this.btnOK.MouseLeave += new System.EventHandler(this.btnOK_MouseLeave);
            // 
            // btnOtkazhi
            // 
            this.btnOtkazhi.BackgroundImage = global::ПроектВП.Properties.Resources.button;
            this.btnOtkazhi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOtkazhi.CausesValidation = false;
            this.btnOtkazhi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOtkazhi.Location = new System.Drawing.Point(206, 144);
            this.btnOtkazhi.Name = "btnOtkazhi";
            this.btnOtkazhi.Size = new System.Drawing.Size(128, 50);
            this.btnOtkazhi.TabIndex = 2;
            this.btnOtkazhi.Text = "Откажи";
            this.btnOtkazhi.UseVisualStyleBackColor = true;
            this.btnOtkazhi.Click += new System.EventHandler(this.btnOtkazhi_Click);
            this.btnOtkazhi.MouseEnter += new System.EventHandler(this.btnOtkazhi_MouseEnter);
            this.btnOtkazhi.MouseLeave += new System.EventHandler(this.btnOtkazhi_MouseLeave);
            // 
            // epIme
            // 
            this.epIme.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ПроектВП.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnOtkazhi;
            this.ClientSize = new System.Drawing.Size(384, 195);
            this.ControlBox = false;
            this.Controls.Add(this.btnOtkazhi);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlPanela);
            this.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "LoginForm";
            this.Text = "Најава";
            this.pnlPanela.ResumeLayout(false);
            this.pnlPanela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epIme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPanela;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnOtkazhi;
        private System.Windows.Forms.ErrorProvider epIme;
    }
}