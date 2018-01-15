namespace library_Management_System1
{
    partial class Pllan
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
            this.TxtPlanName = new System.Windows.Forms.TextBox();
            this.lblPlanName = new System.Windows.Forms.Label();
            this.planCmbStatus = new System.Windows.Forms.ComboBox();
            this.SecRockGrid = new System.Windows.Forms.DataGridView();
            this.BtnPlanUpdate = new System.Windows.Forms.Button();
            this.BtnPlanDelete = new System.Windows.Forms.Button();
            this.BtnPlanSave = new System.Windows.Forms.Button();
            this.BtnPlanNew = new System.Windows.Forms.Button();
            this.lblPlanStatus = new System.Windows.Forms.Label();
            this.TxtPlanId = new System.Windows.Forms.TextBox();
            this.lblPlanId = new System.Windows.Forms.Label();
            this.TxtPlanAmount = new System.Windows.Forms.TextBox();
            this.lblPlanAmount = new System.Windows.Forms.Label();
            this.TxtPlanValidity = new System.Windows.Forms.TextBox();
            this.lblPlanValidity = new System.Windows.Forms.Label();
            this.TxtBookCanHold = new System.Windows.Forms.TextBox();
            this.lblBookCanHold = new System.Windows.Forms.Label();
            this.TxtDiscount = new System.Windows.Forms.TextBox();
            this.lblPlanDiscount = new System.Windows.Forms.Label();
            this.TxtPlanLimit = new System.Windows.Forms.TextBox();
            this.lblPlanLimit = new System.Windows.Forms.Label();
            this.lblPlanDateOfCreation = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PlanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanDOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanHold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanValidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SecRockGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtPlanName
            // 
            this.TxtPlanName.Location = new System.Drawing.Point(186, 66);
            this.TxtPlanName.Multiline = true;
            this.TxtPlanName.Name = "TxtPlanName";
            this.TxtPlanName.Size = new System.Drawing.Size(212, 27);
            this.TxtPlanName.TabIndex = 56;
            // 
            // lblPlanName
            // 
            this.lblPlanName.AutoSize = true;
            this.lblPlanName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanName.Location = new System.Drawing.Point(41, 75);
            this.lblPlanName.Name = "lblPlanName";
            this.lblPlanName.Size = new System.Drawing.Size(100, 18);
            this.lblPlanName.TabIndex = 55;
            this.lblPlanName.Text = "Plan Name :";
            // 
            // planCmbStatus
            // 
            this.planCmbStatus.FormattingEnabled = true;
            this.planCmbStatus.Items.AddRange(new object[] {
            "Active",
            "UnActive"});
            this.planCmbStatus.Location = new System.Drawing.Point(563, 165);
            this.planCmbStatus.Name = "planCmbStatus";
            this.planCmbStatus.Size = new System.Drawing.Size(212, 21);
            this.planCmbStatus.TabIndex = 52;
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
            this.PlanId,
            this.PlanName,
            this.PlanDOC,
            this.PlanLimit,
            this.PlanHold,
            this.PlanValidity,
            this.PlanAmount,
            this.PlanDiscount,
            this.PlanStatus});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SecRockGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.SecRockGrid.Location = new System.Drawing.Point(0, 292);
            this.SecRockGrid.Name = "SecRockGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SecRockGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.SecRockGrid.Size = new System.Drawing.Size(917, 197);
            this.SecRockGrid.TabIndex = 51;
            // 
            // BtnPlanUpdate
            // 
            this.BtnPlanUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlanUpdate.Location = new System.Drawing.Point(491, 247);
            this.BtnPlanUpdate.Name = "BtnPlanUpdate";
            this.BtnPlanUpdate.Size = new System.Drawing.Size(90, 27);
            this.BtnPlanUpdate.TabIndex = 50;
            this.BtnPlanUpdate.Text = "Update";
            this.BtnPlanUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnPlanDelete
            // 
            this.BtnPlanDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlanDelete.Location = new System.Drawing.Point(608, 247);
            this.BtnPlanDelete.Name = "BtnPlanDelete";
            this.BtnPlanDelete.Size = new System.Drawing.Size(90, 27);
            this.BtnPlanDelete.TabIndex = 49;
            this.BtnPlanDelete.Text = "Delete";
            this.BtnPlanDelete.UseVisualStyleBackColor = true;
            // 
            // BtnPlanSave
            // 
            this.BtnPlanSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlanSave.Location = new System.Drawing.Point(719, 247);
            this.BtnPlanSave.Name = "BtnPlanSave";
            this.BtnPlanSave.Size = new System.Drawing.Size(90, 27);
            this.BtnPlanSave.TabIndex = 48;
            this.BtnPlanSave.Text = "Save";
            this.BtnPlanSave.UseVisualStyleBackColor = true;
            // 
            // BtnPlanNew
            // 
            this.BtnPlanNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPlanNew.Location = new System.Drawing.Point(384, 247);
            this.BtnPlanNew.Name = "BtnPlanNew";
            this.BtnPlanNew.Size = new System.Drawing.Size(90, 27);
            this.BtnPlanNew.TabIndex = 47;
            this.BtnPlanNew.Text = "New";
            this.BtnPlanNew.UseVisualStyleBackColor = true;
            this.BtnPlanNew.Click += new System.EventHandler(this.BtnSecRockNew_Click);
            // 
            // lblPlanStatus
            // 
            this.lblPlanStatus.AutoSize = true;
            this.lblPlanStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanStatus.Location = new System.Drawing.Point(433, 164);
            this.lblPlanStatus.Name = "lblPlanStatus";
            this.lblPlanStatus.Size = new System.Drawing.Size(56, 18);
            this.lblPlanStatus.TabIndex = 45;
            this.lblPlanStatus.Text = "Status";
            // 
            // TxtPlanId
            // 
            this.TxtPlanId.Location = new System.Drawing.Point(186, 19);
            this.TxtPlanId.Multiline = true;
            this.TxtPlanId.Name = "TxtPlanId";
            this.TxtPlanId.Size = new System.Drawing.Size(212, 27);
            this.TxtPlanId.TabIndex = 43;
            // 
            // lblPlanId
            // 
            this.lblPlanId.AutoSize = true;
            this.lblPlanId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanId.Location = new System.Drawing.Point(41, 28);
            this.lblPlanId.Name = "lblPlanId";
            this.lblPlanId.Size = new System.Drawing.Size(72, 18);
            this.lblPlanId.TabIndex = 42;
            this.lblPlanId.Text = "Plan ID :";
            // 
            // TxtPlanAmount
            // 
            this.TxtPlanAmount.Location = new System.Drawing.Point(563, 59);
            this.TxtPlanAmount.Multiline = true;
            this.TxtPlanAmount.Name = "TxtPlanAmount";
            this.TxtPlanAmount.Size = new System.Drawing.Size(212, 27);
            this.TxtPlanAmount.TabIndex = 60;
            // 
            // lblPlanAmount
            // 
            this.lblPlanAmount.AutoSize = true;
            this.lblPlanAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanAmount.Location = new System.Drawing.Point(435, 68);
            this.lblPlanAmount.Name = "lblPlanAmount";
            this.lblPlanAmount.Size = new System.Drawing.Size(65, 18);
            this.lblPlanAmount.TabIndex = 59;
            this.lblPlanAmount.Text = "Amount";
            // 
            // TxtPlanValidity
            // 
            this.TxtPlanValidity.Location = new System.Drawing.Point(563, 12);
            this.TxtPlanValidity.Multiline = true;
            this.TxtPlanValidity.Name = "TxtPlanValidity";
            this.TxtPlanValidity.Size = new System.Drawing.Size(212, 27);
            this.TxtPlanValidity.TabIndex = 58;
            // 
            // lblPlanValidity
            // 
            this.lblPlanValidity.AutoSize = true;
            this.lblPlanValidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanValidity.Location = new System.Drawing.Point(433, 21);
            this.lblPlanValidity.Name = "lblPlanValidity";
            this.lblPlanValidity.Size = new System.Drawing.Size(61, 18);
            this.lblPlanValidity.TabIndex = 57;
            this.lblPlanValidity.Text = "Validity";
            // 
            // TxtBookCanHold
            // 
            this.TxtBookCanHold.Location = new System.Drawing.Point(186, 204);
            this.TxtBookCanHold.Multiline = true;
            this.TxtBookCanHold.Name = "TxtBookCanHold";
            this.TxtBookCanHold.Size = new System.Drawing.Size(212, 27);
            this.TxtBookCanHold.TabIndex = 68;
            // 
            // lblBookCanHold
            // 
            this.lblBookCanHold.AutoSize = true;
            this.lblBookCanHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookCanHold.Location = new System.Drawing.Point(41, 210);
            this.lblBookCanHold.Name = "lblBookCanHold";
            this.lblBookCanHold.Size = new System.Drawing.Size(123, 18);
            this.lblBookCanHold.TabIndex = 67;
            this.lblBookCanHold.Text = "Book Can Hold";
            // 
            // TxtDiscount
            // 
            this.TxtDiscount.Location = new System.Drawing.Point(563, 108);
            this.TxtDiscount.Multiline = true;
            this.TxtDiscount.Name = "TxtDiscount";
            this.TxtDiscount.Size = new System.Drawing.Size(212, 27);
            this.TxtDiscount.TabIndex = 66;
            // 
            // lblPlanDiscount
            // 
            this.lblPlanDiscount.AutoSize = true;
            this.lblPlanDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanDiscount.Location = new System.Drawing.Point(433, 117);
            this.lblPlanDiscount.Name = "lblPlanDiscount";
            this.lblPlanDiscount.Size = new System.Drawing.Size(75, 18);
            this.lblPlanDiscount.TabIndex = 65;
            this.lblPlanDiscount.Text = "Discount";
            // 
            // TxtPlanLimit
            // 
            this.TxtPlanLimit.Location = new System.Drawing.Point(186, 162);
            this.TxtPlanLimit.Multiline = true;
            this.TxtPlanLimit.Name = "TxtPlanLimit";
            this.TxtPlanLimit.Size = new System.Drawing.Size(212, 27);
            this.TxtPlanLimit.TabIndex = 64;
            // 
            // lblPlanLimit
            // 
            this.lblPlanLimit.AutoSize = true;
            this.lblPlanLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanLimit.Location = new System.Drawing.Point(41, 164);
            this.lblPlanLimit.Name = "lblPlanLimit";
            this.lblPlanLimit.Size = new System.Drawing.Size(54, 18);
            this.lblPlanLimit.TabIndex = 63;
            this.lblPlanLimit.Text = "Limit :";
            // 
            // lblPlanDateOfCreation
            // 
            this.lblPlanDateOfCreation.AutoSize = true;
            this.lblPlanDateOfCreation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanDateOfCreation.Location = new System.Drawing.Point(41, 124);
            this.lblPlanDateOfCreation.Name = "lblPlanDateOfCreation";
            this.lblPlanDateOfCreation.Size = new System.Drawing.Size(145, 18);
            this.lblPlanDateOfCreation.TabIndex = 61;
            this.lblPlanDateOfCreation.Text = "Date Of Creation :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(186, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 20);
            this.dateTimePicker1.TabIndex = 69;
            // 
            // PlanId
            // 
            this.PlanId.HeaderText = "Plan ID";
            this.PlanId.Name = "PlanId";
            // 
            // PlanName
            // 
            this.PlanName.HeaderText = "Plan Name";
            this.PlanName.Name = "PlanName";
            // 
            // PlanDOC
            // 
            this.PlanDOC.HeaderText = "DOC";
            this.PlanDOC.Name = "PlanDOC";
            // 
            // PlanLimit
            // 
            this.PlanLimit.HeaderText = "Limit";
            this.PlanLimit.Name = "PlanLimit";
            this.PlanLimit.Width = 90;
            // 
            // PlanHold
            // 
            this.PlanHold.HeaderText = "Hold";
            this.PlanHold.Name = "PlanHold";
            this.PlanHold.Width = 90;
            // 
            // PlanValidity
            // 
            this.PlanValidity.HeaderText = "Validity";
            this.PlanValidity.Name = "PlanValidity";
            // 
            // PlanAmount
            // 
            this.PlanAmount.HeaderText = "Amount";
            this.PlanAmount.Name = "PlanAmount";
            // 
            // PlanDiscount
            // 
            this.PlanDiscount.HeaderText = "Discount";
            this.PlanDiscount.Name = "PlanDiscount";
            // 
            // PlanStatus
            // 
            this.PlanStatus.HeaderText = "Status";
            this.PlanStatus.Name = "PlanStatus";
            // 
            // Pllan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 580);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.TxtBookCanHold);
            this.Controls.Add(this.lblBookCanHold);
            this.Controls.Add(this.TxtDiscount);
            this.Controls.Add(this.lblPlanDiscount);
            this.Controls.Add(this.TxtPlanLimit);
            this.Controls.Add(this.lblPlanLimit);
            this.Controls.Add(this.lblPlanDateOfCreation);
            this.Controls.Add(this.TxtPlanAmount);
            this.Controls.Add(this.lblPlanAmount);
            this.Controls.Add(this.TxtPlanValidity);
            this.Controls.Add(this.lblPlanValidity);
            this.Controls.Add(this.TxtPlanName);
            this.Controls.Add(this.lblPlanName);
            this.Controls.Add(this.planCmbStatus);
            this.Controls.Add(this.SecRockGrid);
            this.Controls.Add(this.BtnPlanUpdate);
            this.Controls.Add(this.BtnPlanDelete);
            this.Controls.Add(this.BtnPlanSave);
            this.Controls.Add(this.BtnPlanNew);
            this.Controls.Add(this.lblPlanStatus);
            this.Controls.Add(this.TxtPlanId);
            this.Controls.Add(this.lblPlanId);
            this.Name = "Pllan";
            this.Text = "plan";
            this.Load += new System.EventHandler(this.plan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SecRockGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPlanName;
        private System.Windows.Forms.Label lblPlanName;
        private System.Windows.Forms.ComboBox planCmbStatus;
        private System.Windows.Forms.DataGridView SecRockGrid;
        private System.Windows.Forms.Button BtnPlanUpdate;
        private System.Windows.Forms.Button BtnPlanDelete;
        private System.Windows.Forms.Button BtnPlanSave;
        private System.Windows.Forms.Button BtnPlanNew;
        private System.Windows.Forms.Label lblPlanStatus;
        private System.Windows.Forms.TextBox TxtPlanId;
        private System.Windows.Forms.Label lblPlanId;
        private System.Windows.Forms.TextBox TxtPlanAmount;
        private System.Windows.Forms.Label lblPlanAmount;
        private System.Windows.Forms.TextBox TxtPlanValidity;
        private System.Windows.Forms.Label lblPlanValidity;
        private System.Windows.Forms.TextBox TxtBookCanHold;
        private System.Windows.Forms.Label lblBookCanHold;
        private System.Windows.Forms.TextBox TxtDiscount;
        private System.Windows.Forms.Label lblPlanDiscount;
        private System.Windows.Forms.TextBox TxtPlanLimit;
        private System.Windows.Forms.Label lblPlanLimit;
        private System.Windows.Forms.Label lblPlanDateOfCreation;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanDOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanHold;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanValidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlanStatus;
    }
}