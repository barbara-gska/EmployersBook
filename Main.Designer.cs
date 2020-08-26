namespace EmployersBook
{
    partial class Main
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbStuff = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(13, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.YellowGreen;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(108, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.Red;
            this.btnFire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFire.Location = new System.Drawing.Point(204, 12);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(90, 30);
            this.btnFire.TabIndex = 2;
            this.btnFire.Text = "Zwolnij";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // dgvBook
            // 
            this.dgvBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(13, 49);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersVisible = false;
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(1136, 341);
            this.dgvBook.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Location = new System.Drawing.Point(300, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Odśwież";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbStuff
            // 
            this.cmbStuff.Location = new System.Drawing.Point(396, 16);
            this.cmbStuff.Name = "cmbStuff";
            this.cmbStuff.Size = new System.Drawing.Size(121, 24);
            this.cmbStuff.TabIndex = 0;
            this.cmbStuff.SelectedIndexChanged += new System.EventHandler(this.cmbStuff_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 566);
            this.Controls.Add(this.cmbStuff);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Name = "Main";
            this.Text = "Pracownicy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbStuff;
    }
}

