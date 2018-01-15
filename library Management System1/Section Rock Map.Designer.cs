namespace library_Management_System1
{
    partial class Section_Rock_Map
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SecRockGrid = new System.Windows.Forms.DataGridView();
            this.SecRockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecRockSecName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecRockPrintOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSecRockUpdate = new System.Windows.Forms.Button();
            this.BtnSecRockDelete = new System.Windows.Forms.Button();
            this.BtnSecRockSave = new System.Windows.Forms.Button();
            this.BtnSecRockNew = new System.Windows.Forms.Button();
            this.SecRockCmbRockName = new System.Windows.Forms.ComboBox();
            this.lblSecRockStatus = new System.Windows.Forms.Label();
            this.lblSecName = new System.Windows.Forms.Label();
            this.TxtSecRockId = new System.Windows.Forms.TextBox();
            this.lblSecRockId = new System.Windows.Forms.Label();
            this.SecRockCmbStatus = new System.Windows.Forms.ComboBox();
            this.SecRockCmbSecName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsecrock = new System.Windows.Forms.Label();
            this.TxtSecRockPrintOrder = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SecRockGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SecRockGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SecRockGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SecRockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecRockGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SecRockId,
            this.SecName,
            this.SecRockSecName,
            this.SecRockPrintOrder,
            this.SecStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SecRockGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.SecRockGrid.Location = new System.Drawing.Point(66, 275);
            this.SecRockGrid.Name = "SecRockGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SecRockGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SecRockGrid.Size = new System.Drawing.Size(643, 155);
            this.SecRockGrid.TabIndex = 36;
            // 
            // SecRockId
            // 
            this.SecRockId.HeaderText = "Sec Rock ID";
            this.SecRockId.Name = "SecRockId";
            this.SecRockId.Width = 120;
            // 
            // SecName
            // 
            this.SecName.HeaderText = "Rock Name";
            this.SecName.Name = "SecName";
            this.SecName.Width = 120;
            // 
            // SecRockSecName
            // 
            this.SecRockSecName.HeaderText = "Sec Name";
            this.SecRockSecName.Name = "SecRockSecName";
            this.SecRockSecName.Width = 120;
            // 
            // SecRockPrintOrder
            // 
            this.SecRockPrintOrder.HeaderText = "Print Order";
            this.SecRockPrintOrder.Name = "SecRockPrintOrder";
            this.SecRockPrintOrder.Width = 120;
            // 
            // SecStatus
            // 
            this.SecStatus.HeaderText = "Status";
            this.SecStatus.Name = "SecStatus";
            this.SecStatus.Width = 120;
            // 
            // BtnSecRockUpdate
            // 
            this.BtnSecRockUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSecRockUpdate.Location = new System.Drawing.Point(538, 91);
            this.BtnSecRockUpdate.Name = "BtnSecRockUpdate";
            this.BtnSecRockUpdate.Size = new System.Drawing.Size(90, 27);
            this.BtnSecRockUpdate.TabIndex = 35;
            this.BtnSecRockUpdate.Text = "Update";
            this.BtnSecRockUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnSecRockDelete
            // 
            this.BtnSecRockDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSecRockDelete.Location = new System.Drawing.Point(538, 147);
            this.BtnSecRockDelete.Name = "BtnSecRockDelete";
            this.BtnSecRockDelete.Size = new System.Drawing.Size(90, 27);
            this.BtnSecRockDelete.TabIndex = 34;
            this.BtnSecRockDelete.Text = "Delete";
            this.BtnSecRockDelete.UseVisualStyleBackColor = true;
            // 
            // BtnSecRockSave
            // 
            this.BtnSecRockSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSecRockSave.Location = new System.Drawing.Point(538, 202);
            this.BtnSecRockSave.Name = "BtnSecRockSave";
            this.BtnSecRockSave.Size = new System.Drawing.Size(90, 27);
            this.BtnSecRockSave.TabIndex = 33;
            this.BtnSecRockSave.Text = "Save";
            this.BtnSecRockSave.UseVisualStyleBackColor = true;
            // 
            // BtnSecRockNew
            // 
            this.BtnSecRockNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSecRockNew.Location = new System.Drawing.Point(538, 33);
            this.BtnSecRockNew.Name = "BtnSecRockNew";
            this.BtnSecRockNew.Size = new System.Drawing.Size(90, 27);
            this.BtnSecRockNew.TabIndex = 32;
            this.BtnSecRockNew.Text = "New";
            this.BtnSecRockNew.UseVisualStyleBackColor = true;
            // 
            // SecRockCmbRockName
            // 
            this.SecRockCmbRockName.FormattingEnabled = true;
            this.SecRockCmbRockName.Items.AddRange(new object[] {
            "Urdu ",
            "English ",
            "Islamyat"});
            this.SecRockCmbRockName.Location = new System.Drawing.Point(279, 88);
            this.SecRockCmbRockName.Name = "SecRockCmbRockName";
            this.SecRockCmbRockName.Size = new System.Drawing.Size(212, 21);
            this.SecRockCmbRockName.TabIndex = 31;
            // 
            // lblSecRockStatus
            // 
            this.lblSecRockStatus.AutoSize = true;
            this.lblSecRockStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecRockStatus.Location = new System.Drawing.Point(134, 227);
            this.lblSecRockStatus.Name = "lblSecRockStatus";
            this.lblSecRockStatus.Size = new System.Drawing.Size(56, 18);
            this.lblSecRockStatus.TabIndex = 30;
            this.lblSecRockStatus.Text = "Status";
            // 
            // lblSecName
            // 
            this.lblSecName.AutoSize = true;
            this.lblSecName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecName.Location = new System.Drawing.Point(134, 91);
            this.lblSecName.Name = "lblSecName";
            this.lblSecName.Size = new System.Drawing.Size(101, 18);
            this.lblSecName.TabIndex = 28;
            this.lblSecName.Text = "Rock_Name";
            // 
            // TxtSecRockId
            // 
            this.TxtSecRockId.Location = new System.Drawing.Point(279, 33);
            this.TxtSecRockId.Multiline = true;
            this.TxtSecRockId.Name = "TxtSecRockId";
            this.TxtSecRockId.Size = new System.Drawing.Size(212, 27);
            this.TxtSecRockId.TabIndex = 27;
            // 
            // lblSecRockId
            // 
            this.lblSecRockId.AutoSize = true;
            this.lblSecRockId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecRockId.Location = new System.Drawing.Point(134, 42);
            this.lblSecRockId.Name = "lblSecRockId";
            this.lblSecRockId.Size = new System.Drawing.Size(103, 18);
            this.lblSecRockId.TabIndex = 26;
            this.lblSecRockId.Text = "Sec Rock ID";
            // 
            // SecRockCmbStatus
            // 
            this.SecRockCmbStatus.FormattingEnabled = true;
            this.SecRockCmbStatus.Items.AddRange(new object[] {
            "Active",
            "UnActive"});
            this.SecRockCmbStatus.Location = new System.Drawing.Point(279, 224);
            this.SecRockCmbStatus.Name = "SecRockCmbStatus";
            this.SecRockCmbStatus.Size = new System.Drawing.Size(212, 21);
            this.SecRockCmbStatus.TabIndex = 37;
            // 
            // SecRockCmbSecName
            // 
            this.SecRockCmbSecName.FormattingEnabled = true;
            this.SecRockCmbSecName.Items.AddRange(new object[] {
            "Urdu ",
            "English ",
            "Islamyat"});
            this.SecRockCmbSecName.Location = new System.Drawing.Point(279, 136);
            this.SecRockCmbSecName.Name = "SecRockCmbSecName";
            this.SecRockCmbSecName.Size = new System.Drawing.Size(212, 21);
            this.SecRockCmbSecName.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Sec Name";
            // 
            // lblsecrock
            // 
            this.lblsecrock.AutoSize = true;
            this.lblsecrock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsecrock.Location = new System.Drawing.Point(134, 187);
            this.lblsecrock.Name = "lblsecrock";
            this.lblsecrock.Size = new System.Drawing.Size(91, 18);
            this.lblsecrock.TabIndex = 40;
            this.lblsecrock.Text = "Print Order";
            // 
            // TxtSecRockPrintOrder
            // 
            this.TxtSecRockPrintOrder.Location = new System.Drawing.Point(279, 178);
            this.TxtSecRockPrintOrder.Multiline = true;
            this.TxtSecRockPrintOrder.Name = "TxtSecRockPrintOrder";
            this.TxtSecRockPrintOrder.Size = new System.Drawing.Size(212, 27);
            this.TxtSecRockPrintOrder.TabIndex = 41;
            // 
            // Section_Rock_Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 445);
            this.Controls.Add(this.TxtSecRockPrintOrder);
            this.Controls.Add(this.lblsecrock);
            this.Controls.Add(this.SecRockCmbSecName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecRockCmbStatus);
            this.Controls.Add(this.SecRockGrid);
            this.Controls.Add(this.BtnSecRockUpdate);
            this.Controls.Add(this.BtnSecRockDelete);
            this.Controls.Add(this.BtnSecRockSave);
            this.Controls.Add(this.BtnSecRockNew);
            this.Controls.Add(this.SecRockCmbRockName);
            this.Controls.Add(this.lblSecRockStatus);
            this.Controls.Add(this.lblSecName);
            this.Controls.Add(this.TxtSecRockId);
            this.Controls.Add(this.lblSecRockId);
            this.Name = "Section_Rock_Map";
            this.Text = "Section_Rock_Map";
            ((System.ComponentModel.ISupportInitialize)(this.SecRockGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SecRockGrid;
        private System.Windows.Forms.Button BtnSecRockUpdate;
        private System.Windows.Forms.Button BtnSecRockDelete;
        private System.Windows.Forms.Button BtnSecRockSave;
        private System.Windows.Forms.Button BtnSecRockNew;
        private System.Windows.Forms.ComboBox SecRockCmbRockName;
        private System.Windows.Forms.Label lblSecRockStatus;
        private System.Windows.Forms.Label lblSecName;
        private System.Windows.Forms.TextBox TxtSecRockId;
        private System.Windows.Forms.Label lblSecRockId;
        private System.Windows.Forms.ComboBox SecRockCmbStatus;
        private System.Windows.Forms.ComboBox SecRockCmbSecName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsecrock;
        private System.Windows.Forms.TextBox TxtSecRockPrintOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecRockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecRockSecName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecRockPrintOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecStatus;
    }
}