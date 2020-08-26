namespace EmployersBook
{
    partial class FireEmployee
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
            this.lbFiringDate = new System.Windows.Forms.Label();
            this.dtpFiringDate = new System.Windows.Forms.DateTimePicker();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbFiringDate
            // 
            this.lbFiringDate.AutoSize = true;
            this.lbFiringDate.Location = new System.Drawing.Point(39, 46);
            this.lbFiringDate.Name = "lbFiringDate";
            this.lbFiringDate.Size = new System.Drawing.Size(111, 17);
            this.lbFiringDate.TabIndex = 0;
            this.lbFiringDate.Text = "Data zwolnienia:";
            // 
            // dtpFiringDate
            // 
            this.dtpFiringDate.Location = new System.Drawing.Point(157, 46);
            this.dtpFiringDate.Name = "dtpFiringDate";
            this.dtpFiringDate.Size = new System.Drawing.Size(200, 22);
            this.dtpFiringDate.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(157, 98);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(90, 30);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Zatwierdź";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(267, 98);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FireEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 172);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dtpFiringDate);
            this.Controls.Add(this.lbFiringDate);
            this.MaximumSize = new System.Drawing.Size(452, 219);
            this.MinimumSize = new System.Drawing.Size(452, 219);
            this.Name = "FireEmployee";
            this.Text = "FireEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFiringDate;
        private System.Windows.Forms.DateTimePicker dtpFiringDate;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}