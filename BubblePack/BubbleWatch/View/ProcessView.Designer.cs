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
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.dgvSettings.AllowUserToAddRows = false;
			this.dgvSettings.AllowUserToDeleteRows = false;
			this.dgvSettings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSettings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colValue});
			this.dgvSettings.Location = new System.Drawing.Point(4, 31);
			this.dgvSettings.Name = "dgvSettings";
			this.dgvSettings.RowHeadersVisible = false;
			this.dgvSettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvSettings.Size = new System.Drawing.Size(374, 144);
			this.dgvSettings.TabIndex = 1;
			this.dgvSettings.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSettings_CellValueChanged);
			// 
			// colName
			// 
			this.colName.DataPropertyName = "Key";
			this.colName.FillWeight = 34F;
			this.colName.HeaderText = "Name";
			this.colName.Name = "colName";
			this.colName.ReadOnly = true;
			// 
			// colValue
			// 
			this.colValue.DataPropertyName = "Value";
			this.colValue.HeaderText = "Value";
			this.colValue.Name = "colValue";
			// 
			// ProcessView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dgvSettings);
			this.Controls.Add(this.cbxProcessType);
			this.Name = "ProcessView";
			this.Size = new System.Drawing.Size(380, 178);
			((System.ComponentModel.ISupportInitialize)(this.dgvSettings)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxProcessType;
		private System.Windows.Forms.DataGridView dgvSettings;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
	}
}
