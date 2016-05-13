namespace ПроектВП
{
    partial class GameForm
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
            this.tRibaDvizhenje = new System.Windows.Forms.Timer(this.components);
            this.tPridvizhi = new System.Windows.Forms.Timer(this.components);
            this.pbRiba = new System.Windows.Forms.PictureBox();
            this.pInfo = new System.Windows.Forms.Panel();
            this.lblPoeni = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbRiba)).BeginInit();
            this.pInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tRibaDvizhenje
            // 
            this.tRibaDvizhenje.Interval = 1;
            this.tRibaDvizhenje.Tick += new System.EventHandler(this.tRibaDvizhenje_Tick);
            // 
            // tPridvizhi
            // 
            this.tPridvizhi.Interval = 500;
            this.tPridvizhi.Tick += new System.EventHandler(this.tPridvizhi_Tick);
            // 
            // pbRiba
            // 
            this.pbRiba.Image = global::ПроектВП.Properties.Resources.fish;
            this.pbRiba.Location = new System.Drawing.Point(12, 147);
            this.pbRiba.Name = "pbRiba";
            this.pbRiba.Size = new System.Drawing.Size(140, 94);
            this.pbRiba.TabIndex = 0;
            this.pbRiba.TabStop = false;
            // 
            // pInfo
            // 
            this.pInfo.BackgroundImage = global::ПроектВП.Properties.Resources.greenbutton;
            this.pInfo.Controls.Add(this.lblStatus);
            this.pInfo.Controls.Add(this.lblPoeni);
            this.pInfo.Controls.Add(this.label1);
            this.pInfo.Location = new System.Drawing.Point(1, 366);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(886, 100);
            this.pInfo.TabIndex = 1;
            // 
            // lblPoeni
            // 
            this.lblPoeni.AutoSize = true;
            this.lblPoeni.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.lblPoeni.Location = new System.Drawing.Point(183, 34);
            this.lblPoeni.Name = "lblPoeni";
            this.lblPoeni.Size = new System.Drawing.Size(0, 38);
            this.lblPoeni.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.label1.Location = new System.Drawing.Point(41, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поени:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Comic Sans MS", 20F);
            this.lblStatus.Location = new System.Drawing.Point(452, 34);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 38);
            this.lblStatus.TabIndex = 2;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ПроектВП.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 469);
            this.Controls.Add(this.pInfo);
            this.Controls.Add(this.pbRiba);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameForm";
            this.Text = "Игра Риба";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbRiba)).EndInit();
            this.pInfo.ResumeLayout(false);
            this.pInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRiba;
        private System.Windows.Forms.Timer tRibaDvizhenje;
        private System.Windows.Forms.Timer tPridvizhi;
        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPoeni;
        private System.Windows.Forms.Label lblStatus;
    }
}