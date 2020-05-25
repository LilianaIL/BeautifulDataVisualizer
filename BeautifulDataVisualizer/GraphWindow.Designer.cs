namespace BeautifulDataVisualizer
{
    partial class GraphWindow
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
            this.tlpMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tlpStatusBar = new System.Windows.Forms.TableLayoutPanel();
            this.tlpGeneralContent = new System.Windows.Forms.TableLayoutPanel();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.graph = new BeautifulDataVisualizer.GraphControl();
            this.tlpMenu.SuspendLayout();
            this.tlpGeneralContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMenu
            // 
            this.tlpMenu.ColumnCount = 1;
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenu.Controls.Add(this.btnUpload, 0, 0);
            this.tlpMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMenu.Location = new System.Drawing.Point(0, 0);
            this.tlpMenu.Name = "tlpMenu";
            this.tlpMenu.RowCount = 1;
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMenu.Size = new System.Drawing.Size(984, 50);
            this.tlpMenu.TabIndex = 0;
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUpload.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpload.Location = new System.Drawing.Point(3, 9);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 31);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload Files";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tlpStatusBar
            // 
            this.tlpStatusBar.ColumnCount = 1;
            this.tlpStatusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStatusBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpStatusBar.Location = new System.Drawing.Point(0, 400);
            this.tlpStatusBar.Name = "tlpStatusBar";
            this.tlpStatusBar.RowCount = 1;
            this.tlpStatusBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStatusBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStatusBar.Size = new System.Drawing.Size(984, 50);
            this.tlpStatusBar.TabIndex = 1;
            // 
            // tlpGeneralContent
            // 
            this.tlpGeneralContent.ColumnCount = 2;
            this.tlpGeneralContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpGeneralContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpGeneralContent.Controls.Add(this.tlpContent, 0, 0);
            this.tlpGeneralContent.Controls.Add(this.graph, 1, 0);
            this.tlpGeneralContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeneralContent.Location = new System.Drawing.Point(0, 50);
            this.tlpGeneralContent.Name = "tlpGeneralContent";
            this.tlpGeneralContent.RowCount = 1;
            this.tlpGeneralContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGeneralContent.Size = new System.Drawing.Size(984, 350);
            this.tlpGeneralContent.TabIndex = 2;
            // 
            // tlpContent
            // 
            this.tlpContent.AutoScroll = true;
            this.tlpContent.ColumnCount = 1;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(3, 3);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContent.Size = new System.Drawing.Size(387, 344);
            this.tlpContent.TabIndex = 0;
            // 
            // graph
            // 
            this.graph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graph.Location = new System.Drawing.Point(396, 3);
            this.graph.Name = "graph";
            this.graph.Size = new System.Drawing.Size(585, 344);
            this.graph.TabIndex = 1;
            // 
            // GraphWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.tlpGeneralContent);
            this.Controls.Add(this.tlpStatusBar);
            this.Controls.Add(this.tlpMenu);
            this.Name = "GraphWindow";
            this.Text = "GraphWindow";
            this.tlpMenu.ResumeLayout(false);
            this.tlpGeneralContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMenu;
        private System.Windows.Forms.TableLayoutPanel tlpStatusBar;        
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TableLayoutPanel tlpGeneralContent;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private GraphControl graph;
    }
}

