namespace library_Management_System1
{
    partial class section
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
            this.SecGrid = new System.Windows.Forms.DataGridView();
            this.BtnSecUpdate = new System.Windows.Forms.Button();
            this.BtnSecDelete = new System.Windows.Forms.Button();
            this.BtnSecSave = new System.Windows.Forms.Button();
            this.BtnSecNew = new System.Windows.Forms.Button();
            this.SecCmbStatus = new System.Windows.Forms.ComboBox();
            this.lblSecStatus = new System.Windows.Forms.Label();
            this.TxtSecName = new System.Windows.Forms.TextBox();
            this.lblSecName = new System.Windows.Forms.Label();
            this.TxtSecId = new System.Windows.Forms.TextBox();
            this.lblSecId = new System.Windows.Forms.Label();
            this.Sec_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SecGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SecGrid
            // 
            this.SecGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sec_Id,
            this.SecName,
            this.SecStatus});
            this.SecGrid.Location = new System.Drawing.Point(96, 188);
            this.SecGrid.Name = "SecGrid";
            this.SecGrid.Size = new System.Drawing.Size(491, 205);
            this.SecGrid.TabIndex = 25;
            // 
            // BtnSecUpdate
            // 
            this.BtnSecUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSecUpdate.Location = new System.Drawing.Point(497, 50);
            this.BtnSecUpdate.Name = "BtnSecUpdate";
            this.BtnSecUpdate.Size = new System.Drawing.Size(90, 27);
            this.BtnSecUpdate.TabIndex = 24;
            this.BtnSecUpdate.Text = "Update";
            this.BtnSecUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnSecDelete
            // 
            this.BtnSecDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSecDelete.Location = new System.Drawing.Point(497, 83);
            this.BtnSecDelete.Name = "BtnSecDelete";
            this.BtnSecDelete.Size = new System.Drawing.Size(90, 27);
            this.BtnSecDelete.TabIndex = 23;
            this.BtnSecDelete.Text = "Delete";
            this.BtnSecDelete.UseVisualStyleBackColor = true;
            // 
            // BtnSecSave
            // 
            this.BtnSecSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSecSave.Location = new System.Drawing.Point(497, 120);
            this.BtnSecSave.Name = "BtnSecSave";
            this.BtnSecSave.Size = new System.Drawing.Size(90, 27);
            this.BtnSecSave.TabIndex = 22;
            this.BtnSecSave.Text = "Save";
            this.BtnSecSave.UseVisualStyleBackColor = true;
            // 
            // BtnSecNew
            // 
            this.BtnSecNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSecNew.Location = new System.Drawing.Point(497, 17);
            this.BtnSecNew.Name = "BtnSecNew";
            this.BtnSecNew.Size = new System.Drawing.Size(90, 27);
            this.BtnSecNew.TabIndex = 21;
            this.BtnSecNew.Text = "New";
            this.BtnSecNew.UseVisualStyleBackColor = true;
            // 
            // SecCmbStatus
            // 
            this.SecCmbStatus.FormattingEnabled = true;
            this.SecCmbStatus.Items.AddRange(new object[] {
            "Active",
            "UnActive"});
            this.SecCmbStatus.Location = new System.Drawing.Point(238, 125);
            this.SecCmbStatus.Name = "SecCmbStatus";
            this.SecCmbStatus.Size = new System.Drawing.Size(212, 21);
            this.SecCmbStatus.TabIndex = 20;
            // 
            // lblSecStatus
            // 
            this.lblSecStatus.AutoSize = true;
            this.lblSecStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecStatus.Location = new System.Drawing.Point(93, 128);
            this.lblSecStatus.Name = "lblSecStatus";
            this.lblSecStatus.Size = new System.Drawing.Size(56, 18);
            this.lblSecStatus.TabIndex = 19;
            this.lblSecStatus.Text = "Status";
            // 
            // TxtSecName
            // 
            this.TxtSecName.Location = new System.Drawing.Point(238, 69);
            this.TxtSecName.Multiline = true;
            this.TxtSecName.Name = "TxtSecName";
            this.TxtSecName.Size = new System.Drawing.Size(212, 24);
            this.TxtSecName.TabIndex = 18;
            // 
            // lblSecName
            // 
            this.lblSecName.AutoSize = true;
            this.lblSecName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecName.Location = new System.Drawing.Point(93, 75);
            this.lblSecName.Name = "lblSecName";
            this.lblSecName.Size = new System.Drawing.Size(90, 18);
            this.lblSecName.TabIndex = 17;
            this.lblSecName.Text = "Sec_Name";
            // 
            // TxtSecId
            // 
            this.TxtSecId.Location = new System.Drawing.Point(238, 17);
            this.TxtSecId.Multiline = true;
            this.TxtSecId.Name = "TxtSecId";
            this.TxtSecId.Size = new System.Drawing.Size(212, 27);
            this.TxtSecId.TabIndex = 16;
            // 
            // lblSecId
            // 
            this.lblSecId.AutoSize = true;
            this.lblSecId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecId.Location = new System.Drawing.Point(93, 26);
            this.lblSecId.Name = "lblSecId";
            this.lblSecId.Size = new System.Drawing.Size(58, 18);
            this.lblSecId.TabIndex = 15;
            this.lblSecId.Text = "Sec ID";
            // 
            // Sec_Id
            // 
            this.Sec_Id.HeaderText = "Sec_ID";
            this.Sec_Id.Name = "Sec_Id";
            this.Sec_Id.Width = 150;
            // 
            // SecName
            // 
            this.SecName.HeaderText = "Sec_Name";
            this.SecName.Name = "SecName";
            this.SecName.Width = 150;
            // 
            // SecStatus
            // 
            this.SecStatus.HeaderText = "Status";
            this.SecStatus.Name = "SecStatus";
            this.SecStatus.Width = 150;
            // 
            // section
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 405);
            this.Controls.Add(this.SecGrid);
            this.Controls.Add(this.BtnSecUpdate);
            this.Controls.Add(this.BtnSecDelete);
            this.Controls.Add(this.BtnSecSave);
            this.Controls.Add(this.BtnSecNew);
            this.Controls.Add(this.SecCmbStatus);
            this.Controls.Add(this.lblSecStatus);
            this.Controls.Add(this.TxtSecName);
            this.Controls.Add(this.lblSecName);
            this.Controls.Add(this.TxtSecId);
            this.Controls.Add(this.lblSecId);
            this.Name = "section";
            this.Text = "section";
            ((System.ComponentModel.ISupportInitialize)(this.SecGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SecGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sec_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecStatus;
        private System.Windows.Forms.Button BtnSecUpdate;
        private System.Windows.Forms.Button BtnSecDelete;
        private System.Windows.Forms.Button BtnSecSave;
        private System.Windows.Forms.Button BtnSecNew;
        private System.Windows.Forms.ComboBox SecCmbStatus;
        private System.Windows.Forms.Label lblSecStatus;
        private System.Windows.Forms.TextBox TxtSecName;
        private System.Windows.Forms.Label lblSecName;
        private System.Windows.Forms.TextBox TxtSecId;
        private System.Windows.Forms.Label lblSecId;
    }
}