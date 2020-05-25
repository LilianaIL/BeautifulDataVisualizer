namespace BeautifulDataVisualizer
{
    partial class GraphControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartGeneral = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tlpActions = new System.Windows.Forms.TableLayoutPanel();
            this.btnAction = new System.Windows.Forms.Button();
            this.cmbFiles = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.scbSpeed = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneral)).BeginInit();
            this.tlpActions.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chartGeneral, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tlpActions, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(438, 354);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chartGeneral
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGeneral.ChartAreas.Add(chartArea1);
            this.chartGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartGeneral.Location = new System.Drawing.Point(3, 3);
            this.chartGeneral.Name = "chartGeneral";
            this.chartGeneral.Size = new System.Drawing.Size(432, 241);
            this.chartGeneral.TabIndex = 0;
            this.chartGeneral.Text = "chart1";
            // 
            // tlpActions
            // 
            this.tlpActions.ColumnCount = 3;
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpActions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpActions.Controls.Add(this.btnAction, 1, 0);
            this.tlpActions.Controls.Add(this.cmbFiles, 0, 0);
            this.tlpActions.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tlpActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpActions.Location = new System.Drawing.Point(3, 250);
            this.tlpActions.Name = "tlpActions";
            this.tlpActions.RowCount = 1;
            this.tlpActions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpActions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpActions.Size = new System.Drawing.Size(432, 101);
            this.tlpActions.TabIndex = 1;
            this.tlpActions.Visible = false;
            // 
            // btnAction
            // 
            this.btnAction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAction.Location = new System.Drawing.Point(167, 41);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(75, 23);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "Pause";
            this.btnAction.UseVisualStyleBackColor = true;
            // 
            // cmbFiles
            // 
            this.cmbFiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbFiles.FormattingEnabled = true;
            this.cmbFiles.Location = new System.Drawing.Point(4, 42);
            this.cmbFiles.Name = "cmbFiles";
            this.cmbFiles.Size = new System.Drawing.Size(121, 21);
            this.cmbFiles.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.scbSpeed, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(283, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(146, 100);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // scbSpeed
            // 
            this.scbSpeed.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.scbSpeed.Location = new System.Drawing.Point(11, 39);
            this.scbSpeed.Name = "scbSpeed";
            this.scbSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.scbSpeed.Size = new System.Drawing.Size(123, 21);
            this.scbSpeed.TabIndex = 0;
            this.scbSpeed.Value = 50;
            this.scbSpeed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scbSpeed_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Play Speed Slider";
            // 
            // GraphControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GraphControl";
            this.Size = new System.Drawing.Size(438, 354);
            this.Load += new System.EventHandler(this.GraphControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneral)).EndInit();
            this.tlpActions.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGeneral;
        private System.Windows.Forms.TableLayoutPanel tlpActions;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ComboBox cmbFiles;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.HScrollBar scbSpeed;
        private System.Windows.Forms.Label label1;
    }
}
