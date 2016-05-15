namespace ПроектВП
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            this.dgvPodatoci = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodatoci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPodatoci
            // 
            this.dgvPodatoci.AllowUserToAddRows = false;
            this.dgvPodatoci.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.dgvPodatoci.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPodatoci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPodatoci.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPodatoci.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPodatoci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodatoci.Location = new System.Drawing.Point(12, 12);
            this.dgvPodatoci.MultiSelect = false;
            this.dgvPodatoci.Name = "dgvPodatoci";
            this.dgvPodatoci.ReadOnly = true;
            this.dgvPodatoci.ShowEditingIcon = false;
            this.dgvPodatoci.Size = new System.Drawing.Size(226, 329);
            this.dgvPodatoci.TabIndex = 0;
            this.dgvPodatoci.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvPodatoci_UserDeletingRow);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ПроектВП.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(253, 361);
            this.Controls.Add(this.dgvPodatoci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatisticsForm";
            this.Text = "Ранг листа";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodatoci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPodatoci;
    }
}