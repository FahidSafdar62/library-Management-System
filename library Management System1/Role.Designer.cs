namespace library_Management_System1
{
    partial class Role
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
            this.TxtRole = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.TxtRoleId = new System.Windows.Forms.TextBox();
            this.lblRoleId = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnRoleNew = new System.Windows.Forms.Button();
            this.BtnRoleSave = new System.Windows.Forms.Button();
            this.BtnRoleDelete = new System.Windows.Forms.Button();
            this.BtnRoleUpdate = new System.Windows.Forms.Button();
            this.RoleGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.RoleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtRole
            // 
            this.TxtRole.Location = new System.Drawing.Point(183, 70);
            this.TxtRole.Multiline = true;
            this.TxtRole.Name = "TxtRole";
            this.TxtRole.Size = new System.Drawing.Size(212, 24);
            this.TxtRole.TabIndex = 7;
            this.TxtRole.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(38, 76);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(43, 18);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Role";
            this.lblRole.Click += new System.EventHandler(this.Password_Click);
            // 
            // TxtRoleId
            // 
            this.TxtRoleId.Location = new System.Drawing.Point(183, 18);
            this.TxtRoleId.Multiline = true;
            this.TxtRoleId.Name = "TxtRoleId";
            this.TxtRoleId.Size = new System.Drawing.Size(212, 27);
            this.TxtRoleId.TabIndex = 5;
            this.TxtRoleId.TextChanged += new System.EventHandler(this.TxtUserName_TextChanged);
            // 
            // lblRoleId
            // 
            this.lblRoleId.AutoSize = true;
            this.lblRoleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleId.Location = new System.Drawing.Point(38, 27);
            this.lblRoleId.Name = "lblRoleId";
            this.lblRoleId.Size = new System.Drawing.Size(64, 18);
            this.lblRoleId.TabIndex = 4;
            this.lblRoleId.Text = "Role ID";
            this.lblRoleId.Click += new System.EventHandler(this.UserName_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(38, 129);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 18);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Active",
            "UnActive"});
            this.comboBox1.Location = new System.Drawing.Point(183, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // BtnRoleNew
            // 
            this.BtnRoleNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoleNew.Location = new System.Drawing.Point(442, 18);
            this.BtnRoleNew.Name = "BtnRoleNew";
            this.BtnRoleNew.Size = new System.Drawing.Size(90, 27);
            this.BtnRoleNew.TabIndex = 10;
            this.BtnRoleNew.Text = "New";
            this.BtnRoleNew.UseVisualStyleBackColor = true;
            // 
            // BtnRoleSave
            // 
            this.BtnRoleSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoleSave.Location = new System.Drawing.Point(442, 121);
            this.BtnRoleSave.Name = "BtnRoleSave";
            this.BtnRoleSave.Size = new System.Drawing.Size(90, 27);
            this.BtnRoleSave.TabIndex = 11;
            this.BtnRoleSave.Text = "Save";
            this.BtnRoleSave.UseVisualStyleBackColor = true;
            // 
            // BtnRoleDelete
            // 
            this.BtnRoleDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoleDelete.Location = new System.Drawing.Point(442, 84);
            this.BtnRoleDelete.Name = "BtnRoleDelete";
            this.BtnRoleDelete.Size = new System.Drawing.Size(90, 27);
            this.BtnRoleDelete.TabIndex = 12;
            this.BtnRoleDelete.Text = "Delete";
            this.BtnRoleDelete.UseVisualStyleBackColor = true;
            // 
            // BtnRoleUpdate
            // 
            this.BtnRoleUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRoleUpdate.Location = new System.Drawing.Point(442, 51);
            this.BtnRoleUpdate.Name = "BtnRoleUpdate";
            this.BtnRoleUpdate.Size = new System.Drawing.Size(90, 27);
            this.BtnRoleUpdate.TabIndex = 13;
            this.BtnRoleUpdate.Text = "Update";
            this.BtnRoleUpdate.UseVisualStyleBackColor = true;
            // 
            // RoleGrid
            // 
            this.RoleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.RoleGrid.Location = new System.Drawing.Point(41, 189);
            this.RoleGrid.Name = "RoleGrid";
            this.RoleGrid.Size = new System.Drawing.Size(491, 205);
            this.RoleGrid.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Role ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Role";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Role
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 406);
            this.Controls.Add(this.RoleGrid);
            this.Controls.Add(this.BtnRoleUpdate);
            this.Controls.Add(this.BtnRoleDelete);
            this.Controls.Add(this.BtnRoleSave);
            this.Controls.Add(this.BtnRoleNew);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.TxtRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.TxtRoleId);
            this.Controls.Add(this.lblRoleId);
            this.Name = "Role";
            this.Text = "Role";
            this.Load += new System.EventHandler(this.Role_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoleGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox TxtRoleId;
        private System.Windows.Forms.Label lblRoleId;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnRoleNew;
        private System.Windows.Forms.Button BtnRoleSave;
        private System.Windows.Forms.Button BtnRoleDelete;
        private System.Windows.Forms.Button BtnRoleUpdate;
        private System.Windows.Forms.DataGridView RoleGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}