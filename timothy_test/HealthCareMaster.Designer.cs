namespace timothy_test
{
    partial class HealthCareMaster
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_description = new System.Windows.Forms.RichTextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lst_disease = new System.Windows.Forms.ListBox();
            this.btn_showall = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lst_grid = new System.Windows.Forms.DataGridView();
            this.serial_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_record_id = new System.Windows.Forms.TextBox();
            this.txt_Value = new System.Windows.Forms.TextBox();
            this.btn_delete_record = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.data_grid = new System.Windows.Forms.DataGridView();
            this.serial_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_mainmenuname = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_description);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btn_new);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.lst_disease);
            this.panel1.Controls.Add(this.btn_showall);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Location = new System.Drawing.Point(76, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 246);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(237, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "NOTE: Insert Text in (#) to treat as MENU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ImageLocation = "E:\\abc\\aks\\timothy_test\\search.jpg";
            this.pictureBox1.InitialImage = global::timothy_test.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(9, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 24);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.Location = new System.Drawing.Point(255, 109);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(495, 125);
            this.txt_description.TabIndex = 2;
            this.txt_description.Text = "";
            this.txt_description.TextChanged += new System.EventHandler(this.txt_description_TextChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_delete.Location = new System.Drawing.Point(630, 47);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 32);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_save.Location = new System.Drawing.Point(549, 47);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 32);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_new.Location = new System.Drawing.Point(468, 47);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 32);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(305, 51);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(124, 24);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(251, 51);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(48, 18);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Name";
            // 
            // lst_disease
            // 
            this.lst_disease.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_disease.FormattingEnabled = true;
            this.lst_disease.ItemHeight = 18;
            this.lst_disease.Location = new System.Drawing.Point(41, 68);
            this.lst_disease.Name = "lst_disease";
            this.lst_disease.Size = new System.Drawing.Size(190, 166);
            this.lst_disease.TabIndex = 8;
            this.lst_disease.Click += new System.EventHandler(this.lst_disease_Click);
            // 
            // btn_showall
            // 
            this.btn_showall.BackColor = System.Drawing.Color.Transparent;
            this.btn_showall.BackgroundImage = global::timothy_test.Properties.Resources.clear12;
            this.btn_showall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_showall.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showall.ForeColor = System.Drawing.Color.Black;
            this.btn_showall.Location = new System.Drawing.Point(188, 33);
            this.btn_showall.Name = "btn_showall";
            this.btn_showall.Size = new System.Drawing.Size(35, 29);
            this.btn_showall.TabIndex = 6;
            this.btn_showall.UseVisualStyleBackColor = false;
            this.btn_showall.Click += new System.EventHandler(this.btn_showall_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(41, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(138, 24);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lst_grid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_record_id);
            this.panel2.Controls.Add(this.txt_Value);
            this.panel2.Controls.Add(this.btn_delete_record);
            this.panel2.Controls.Add(this.btn_update);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.data_grid);
            this.panel2.Controls.Add(this.txt_mainmenuname);
            this.panel2.Location = new System.Drawing.Point(76, 293);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 320);
            this.panel2.TabIndex = 0;
            // 
            // lst_grid
            // 
            this.lst_grid.AllowUserToAddRows = false;
            this.lst_grid.AllowUserToResizeColumns = false;
            this.lst_grid.AllowUserToResizeRows = false;
            this.lst_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lst_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lst_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serial_no});
            this.lst_grid.Location = new System.Drawing.Point(42, 50);
            this.lst_grid.Name = "lst_grid";
            this.lst_grid.RowHeadersVisible = false;
            this.lst_grid.Size = new System.Drawing.Size(189, 185);
            this.lst_grid.TabIndex = 16;
            this.lst_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lst_grid_CellClick_1);
            // 
            // serial_no
            // 
            this.serial_no.HeaderText = "Sr.No.";
            this.serial_no.MaxInputLength = 100;
            this.serial_no.MinimumWidth = 2;
            this.serial_no.Name = "serial_no";
            this.serial_no.ReadOnly = true;
            this.serial_no.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(42, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(252, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID";
            this.label2.Visible = false;
            // 
            // txt_record_id
            // 
            this.txt_record_id.Enabled = false;
            this.txt_record_id.Location = new System.Drawing.Point(63, 263);
            this.txt_record_id.Name = "txt_record_id";
            this.txt_record_id.Size = new System.Drawing.Size(100, 20);
            this.txt_record_id.TabIndex = 12;
            this.txt_record_id.Visible = false;
            // 
            // txt_Value
            // 
            this.txt_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Value.Location = new System.Drawing.Point(302, 257);
            this.txt_Value.Name = "txt_Value";
            this.txt_Value.Size = new System.Drawing.Size(116, 24);
            this.txt_Value.TabIndex = 11;
            // 
            // btn_delete_record
            // 
            this.btn_delete_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_delete_record.Location = new System.Drawing.Point(631, 255);
            this.btn_delete_record.Name = "btn_delete_record";
            this.btn_delete_record.Size = new System.Drawing.Size(75, 33);
            this.btn_delete_record.TabIndex = 10;
            this.btn_delete_record.Text = "Delete";
            this.btn_delete_record.UseVisualStyleBackColor = true;
            this.btn_delete_record.Click += new System.EventHandler(this.btn_delete_record_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_update.Location = new System.Drawing.Point(550, 255);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 33);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Save";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btn_add.Location = new System.Drawing.Point(469, 255);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 33);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "New";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // data_grid
            // 
            this.data_grid.AllowDrop = true;
            this.data_grid.AllowUserToAddRows = false;
            this.data_grid.AllowUserToDeleteRows = false;
            this.data_grid.BackgroundColor = System.Drawing.Color.White;
            this.data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serial_number});
            this.data_grid.GridColor = System.Drawing.Color.Maroon;
            this.data_grid.Location = new System.Drawing.Point(254, 43);
            this.data_grid.Name = "data_grid";
            this.data_grid.ReadOnly = true;
            this.data_grid.RowHeadersVisible = false;
            this.data_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_grid.Size = new System.Drawing.Size(495, 188);
            this.data_grid.TabIndex = 7;
            this.data_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_grid_CellClick);
            // 
            // serial_number
            // 
            this.serial_number.HeaderText = "Sr. No";
            this.serial_number.Name = "serial_number";
            this.serial_number.ReadOnly = true;
            this.serial_number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // txt_mainmenuname
            // 
            this.txt_mainmenuname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mainmenuname.Location = new System.Drawing.Point(42, 20);
            this.txt_mainmenuname.Name = "txt_mainmenuname";
            this.txt_mainmenuname.Size = new System.Drawing.Size(189, 24);
            this.txt_mainmenuname.TabIndex = 6;
            // 
            // HealthCareMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "HealthCareMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Health Care Master";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lst_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.ListBox lst_disease;
        private System.Windows.Forms.RichTextBox txt_description;
        private System.Windows.Forms.TextBox txt_mainmenuname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_record_id;
        private System.Windows.Forms.TextBox txt_Value;
        private System.Windows.Forms.Button btn_delete_record;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView data_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_showall;
        private System.Windows.Forms.DataGridView lst_grid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_number;
    }
}

