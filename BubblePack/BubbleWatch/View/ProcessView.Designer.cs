namespace BubbleWatch.View
{
	partial class ProcessView
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
			this.cbxProcessType = new System.Windows.Forms.ComboBox();
			this.dgvSettings = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvSettings)).BeginInit();
			this.SuspendLayout();
			// 
			// cbxProcessType
			// 
			this.cbxProcessType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbxProcessType.FormattingEnabled = true;
			this.cbxProcessType.Location = new System.Drawing.Point(3, 3);
			this.cbxProcessType.Name = "cbxProcessType";
			this.cbxProcessType.Size = new System.Drawing.Size(374, 21);
			this.cbxProcessType.TabIndex = 0;
			this.cbxProcessType.SelectedIndexChanged += new System.EventHandler(this.cbxProcessType_SelectedIndexChanged);
			// 
			// dgvSettings
			// 
			this.dgvSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSettings.Location = new System.Drawing.Point(4, 31);
			this.dgvSettings.Name = "dgvSettings";
			this.dgvSettings.Size = new System.Drawing.Size(374, 150);
			this.dgvSettings.TabIndex = 1;
			// 
			// ProcessView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dgvSettings);
			this.Controls.Add(this.cbxProcessType);
			this.Name = "ProcessView";
			this.Size = new System.Drawing.Size(380, 228);
			((System.ComponentModel.ISupportInitialize)(this.dgvSettings)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxProcessType;
		private System.Windows.Forms.DataGridView dgvSettings;
	}
}
