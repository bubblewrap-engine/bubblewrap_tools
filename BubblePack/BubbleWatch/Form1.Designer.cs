namespace BubbleWatch
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnAddProcessor = new System.Windows.Forms.Button();
			this.processPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.lstProjects = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.fileTreeView = new System.Windows.Forms.TreeView();
			this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.11621F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.88379F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 422F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.fileTreeView, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.21614F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.78386F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(959, 694);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.btnAddProcessor, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.processPanel, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(539, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.57365F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.426357F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(417, 516);
			this.tableLayoutPanel3.TabIndex = 5;
			// 
			// btnAddProcessor
			// 
			this.btnAddProcessor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAddProcessor.Location = new System.Drawing.Point(3, 491);
			this.btnAddProcessor.Name = "btnAddProcessor";
			this.btnAddProcessor.Size = new System.Drawing.Size(411, 22);
			this.btnAddProcessor.TabIndex = 0;
			this.btnAddProcessor.Text = "Add Processor";
			this.btnAddProcessor.UseVisualStyleBackColor = true;
			this.btnAddProcessor.Click += new System.EventHandler(this.btnAddProcessor_Click);
			// 
			// processPanel
			// 
			this.processPanel.AutoScroll = true;
			this.processPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.processPanel.Location = new System.Drawing.Point(3, 3);
			this.processPanel.Name = "processPanel";
			this.processPanel.Size = new System.Drawing.Size(411, 482);
			this.processPanel.TabIndex = 1;
			// 
			// textBox1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 3);
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(3, 525);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(953, 166);
			this.textBox1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.btnDelete, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.lstProjects, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnAdd, 1, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.99225F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.007752F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(139, 516);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// btnDelete
			// 
			this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDelete.Location = new System.Drawing.Point(3, 488);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(63, 25);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// lstProjects
			// 
			this.tableLayoutPanel2.SetColumnSpan(this.lstProjects, 2);
			this.lstProjects.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstProjects.FormattingEnabled = true;
			this.lstProjects.Location = new System.Drawing.Point(3, 3);
			this.lstProjects.Name = "lstProjects";
			this.lstProjects.Size = new System.Drawing.Size(133, 479);
			this.lstProjects.TabIndex = 1;
			this.lstProjects.SelectedValueChanged += new System.EventHandler(this.lstProjects_SelectedValueChanged);
			// 
			// btnAdd
			// 
			this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnAdd.Location = new System.Drawing.Point(72, 488);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(64, 25);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// fileTreeView
			// 
			this.fileTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fileTreeView.Location = new System.Drawing.Point(148, 3);
			this.fileTreeView.Name = "fileTreeView";
			this.fileTreeView.Size = new System.Drawing.Size(385, 516);
			this.fileTreeView.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(959, 694);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "BubbleWatch";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.ListBox lstProjects;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.FolderBrowserDialog folderDialog;
		private System.Windows.Forms.TreeView fileTreeView;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button btnAddProcessor;
		private System.Windows.Forms.FlowLayoutPanel processPanel;
	}
}

