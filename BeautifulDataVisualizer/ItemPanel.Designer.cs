namespace BeautifulDataVisualizer
{
    partial class ItemPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbItem = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.Low = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.High = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // grbItem
            // 
            this.grbItem.Controls.Add(this.dgvData);
            this.grbItem.Location = new System.Drawing.Point(22, 24);
            this.grbItem.Name = "grbItem";
            this.grbItem.Size = new System.Drawing.Size(298, 185);
            this.grbItem.TabIndex = 0;
            this.grbItem.TabStop = false;
            this.grbItem.Text = "groupBox1";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Low,
            this.High,
            this.Volume});
            this.dgvData.Location = new System.Drawing.Point(6, 19);
            this.dgvData.Name = "dgvData";
            this.dgvData.Size = new System.Drawing.Size(282, 150);
            this.dgvData.TabIndex = 0;
            // 
            // Low
            // 
            this.Low.DataPropertyName = "Low";
            this.Low.HeaderText = "Low";
            this.Low.MinimumWidth = 6;
            this.Low.Name = "Low";
            this.Low.Width = 80;
            // 
            // High
            // 
            this.High.DataPropertyName = "High";
            this.High.HeaderText = "High";
            this.High.MinimumWidth = 6;
            this.High.Name = "High";
            this.High.Width = 80;
            // 
            // Volume
            // 
            this.Volume.DataPropertyName = "Volume";
            this.Volume.HeaderText = "Volume";
            this.Volume.MinimumWidth = 6;
            this.Volume.Name = "Volume";
            this.Volume.Width = 80;
            // 
            // NewItemPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbItem);
            this.Name = "ItemPanel";
            this.Size = new System.Drawing.Size(346, 233);
            this.Load += new System.EventHandler(this.ItemPanel_Load);
            this.grbItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbItem;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Low;
        private System.Windows.Forms.DataGridViewTextBoxColumn High;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
    }
}
