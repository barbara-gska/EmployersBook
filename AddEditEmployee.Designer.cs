namespace EmployersBook
{
    partial class AddEditEmployee
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
            this.lbId = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbFireDate = new System.Windows.Forms.Label();
            this.lbHireDate = new System.Windows.Forms.Label();
            this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFireDate = new System.Windows.Forms.DateTimePicker();
            this.lbIsFired = new System.Windows.Forms.Label();
            this.chbIsFired = new System.Windows.Forms.CheckBox();
            this.rtbComments = new System.Windows.Forms.RichTextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(14, 21);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(23, 17);
            this.lbId.TabIndex = 0;
            this.lbId.Text = "Id:";
            this.lbId.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(13, 51);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(37, 17);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "Imię:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(142, 23);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(187, 22);
            this.tbId.TabIndex = 2;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(142, 51);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(187, 22);
            this.tbFirstName.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(142, 79);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(187, 22);
            this.tbLastName.TabIndex = 6;
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Location = new System.Drawing.Point(13, 108);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(43, 17);
            this.lbDepartment.TabIndex = 5;
            this.lbDepartment.Text = "Dział:";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(14, 78);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(71, 17);
            this.lbLastName.TabIndex = 4;
            this.lbLastName.Text = "Nazwisko:";
            // 
            // tbSalary
            // 
            this.tbSalary.Location = new System.Drawing.Point(142, 264);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(187, 22);
            this.tbSalary.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Wynagrodzenie:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Uwagi:";
            // 
            // lbFireDate
            // 
            this.lbFireDate.AutoSize = true;
            this.lbFireDate.Location = new System.Drawing.Point(13, 358);
            this.lbFireDate.Name = "lbFireDate";
            this.lbFireDate.Size = new System.Drawing.Size(111, 17);
            this.lbFireDate.TabIndex = 13;
            this.lbFireDate.Text = "Data zwolnienia:";
            this.lbFireDate.Visible = false;
            // 
            // lbHireDate
            // 
            this.lbHireDate.AutoSize = true;
            this.lbHireDate.Location = new System.Drawing.Point(13, 294);
            this.lbHireDate.Name = "lbHireDate";
            this.lbHireDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbHireDate.Size = new System.Drawing.Size(124, 17);
            this.lbHireDate.TabIndex = 12;
            this.lbHireDate.Text = "Data zatrudnienia:";
            // 
            // dtpHireDate
            // 
            this.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHireDate.Location = new System.Drawing.Point(142, 292);
            this.dtpHireDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpHireDate.Name = "dtpHireDate";
            this.dtpHireDate.Size = new System.Drawing.Size(114, 22);
            this.dtpHireDate.TabIndex = 15;
            this.dtpHireDate.Value = new System.DateTime(2020, 8, 12, 0, 0, 0, 0);
            // 
            // dtpFireDate
            // 
            this.dtpFireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFireDate.Location = new System.Drawing.Point(142, 353);
            this.dtpFireDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFireDate.Name = "dtpFireDate";
            this.dtpFireDate.Size = new System.Drawing.Size(114, 22);
            this.dtpFireDate.TabIndex = 15;
            this.dtpFireDate.Value = new System.DateTime(2020, 8, 12, 0, 0, 0, 0);
            this.dtpFireDate.Visible = false;
            // 
            // lbIsFired
            // 
            this.lbIsFired.AutoSize = true;
            this.lbIsFired.Location = new System.Drawing.Point(13, 324);
            this.lbIsFired.Name = "lbIsFired";
            this.lbIsFired.Size = new System.Drawing.Size(79, 17);
            this.lbIsFired.TabIndex = 16;
            this.lbIsFired.Text = "Zwolniony?";
            // 
            // chbIsFired
            // 
            this.chbIsFired.AutoSize = true;
            this.chbIsFired.Location = new System.Drawing.Point(142, 320);
            this.chbIsFired.Name = "chbIsFired";
            this.chbIsFired.Size = new System.Drawing.Size(54, 21);
            this.chbIsFired.TabIndex = 17;
            this.chbIsFired.Text = "Tak";
            this.chbIsFired.UseVisualStyleBackColor = true;
            this.chbIsFired.CheckedChanged += new System.EventHandler(this.chbIsFired_CheckedChanged);
            // 
            // rtbComments
            // 
            this.rtbComments.Location = new System.Drawing.Point(142, 136);
            this.rtbComments.Name = "rtbComments";
            this.rtbComments.Size = new System.Drawing.Size(187, 122);
            this.rtbComments.TabIndex = 18;
            this.rtbComments.Text = "";
            // 
            // btnConfirm
            // 
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Location = new System.Drawing.Point(142, 401);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(90, 25);
            this.btnConfirm.TabIndex = 19;
            this.btnConfirm.Text = "Zatwierdz";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(253, 401);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(142, 108);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 24);
            this.cmbDepartment.TabIndex = 21;
            // 
            // AddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 464);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.rtbComments);
            this.Controls.Add(this.chbIsFired);
            this.Controls.Add(this.lbIsFired);
            this.Controls.Add(this.dtpFireDate);
            this.Controls.Add(this.dtpHireDate);
            this.Controls.Add(this.lbFireDate);
            this.Controls.Add(this.lbHireDate);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.lbDepartment);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbId);
            this.Name = "AddEditEmployee";
            this.Text = "AddEditEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbFireDate;
        private System.Windows.Forms.Label lbHireDate;
        private System.Windows.Forms.DateTimePicker dtpHireDate;
        private System.Windows.Forms.DateTimePicker dtpFireDate;
        private System.Windows.Forms.Label lbIsFired;
        private System.Windows.Forms.CheckBox chbIsFired;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbDepartment;
    }
}