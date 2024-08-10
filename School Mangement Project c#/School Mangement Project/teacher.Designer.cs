namespace School_Mangement_Project
{
    partial class teacher
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
            this.TDOB = new System.Windows.Forms.DateTimePicker();
            this.back_button = new System.Windows.Forms.Button();
            this.dele_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.TSub = new System.Windows.Forms.ComboBox();
            this.TGender = new System.Windows.Forms.ComboBox();
            this.TPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closepB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TAddress = new System.Windows.Forms.ComboBox();
            this.TName = new System.Windows.Forms.TextBox();
            this.TData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closepB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TData)).BeginInit();
            this.SuspendLayout();
            // 
            // TDOB
            // 
            this.TDOB.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDOB.Location = new System.Drawing.Point(435, 184);
            this.TDOB.Name = "TDOB";
            this.TDOB.Size = new System.Drawing.Size(164, 38);
            this.TDOB.TabIndex = 37;
            this.TDOB.ValueChanged += new System.EventHandler(this.TDOB_ValueChanged);
            // 
            // back_button
            // 
            this.back_button.BackColor = System.Drawing.Color.Gold;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.ForeColor = System.Drawing.Color.Black;
            this.back_button.Location = new System.Drawing.Point(820, 249);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(190, 38);
            this.back_button.TabIndex = 41;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // dele_button
            // 
            this.dele_button.BackColor = System.Drawing.Color.Gold;
            this.dele_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dele_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dele_button.ForeColor = System.Drawing.Color.Black;
            this.dele_button.Location = new System.Drawing.Point(612, 249);
            this.dele_button.Name = "dele_button";
            this.dele_button.Size = new System.Drawing.Size(190, 38);
            this.dele_button.TabIndex = 40;
            this.dele_button.Text = "Delete";
            this.dele_button.UseVisualStyleBackColor = false;
            this.dele_button.Click += new System.EventHandler(this.dele_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.Gold;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.ForeColor = System.Drawing.Color.Black;
            this.edit_button.Location = new System.Drawing.Point(405, 249);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(190, 38);
            this.edit_button.TabIndex = 39;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.Gold;
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.Black;
            this.add_button.Location = new System.Drawing.Point(195, 249);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(190, 38);
            this.add_button.TabIndex = 38;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // TSub
            // 
            this.TSub.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSub.FormattingEnabled = true;
            this.TSub.Items.AddRange(new object[] {
            "قران",
            "أسلامية",
            "لغة عربية",
            "رياضيات",
            "أحياء",
            "English",
            "فيزياء",
            "كيمياء"});
            this.TSub.Location = new System.Drawing.Point(879, 94);
            this.TSub.Name = "TSub";
            this.TSub.Size = new System.Drawing.Size(201, 39);
            this.TSub.TabIndex = 36;
            // 
            // TGender
            // 
            this.TGender.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TGender.FormattingEnabled = true;
            this.TGender.Items.AddRange(new object[] {
            "ذكر",
            "انثى"});
            this.TGender.Location = new System.Drawing.Point(435, 94);
            this.TGender.Name = "TGender";
            this.TGender.Size = new System.Drawing.Size(162, 39);
            this.TGender.TabIndex = 35;
            // 
            // TPhone
            // 
            this.TPhone.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPhone.Location = new System.Drawing.Point(176, 184);
            this.TPhone.Name = "TPhone";
            this.TPhone.Size = new System.Drawing.Size(192, 38);
            this.TPhone.TabIndex = 33;
            this.TPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TPhone_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label8.Location = new System.Drawing.Point(171, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 28);
            this.label8.TabIndex = 30;
            this.label8.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label3.Location = new System.Drawing.Point(639, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(541, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 34);
            this.label7.TabIndex = 28;
            this.label7.Text = "Teachers List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label5.Location = new System.Drawing.Point(431, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "DOB:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(431, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(160, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(874, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 28);
            this.label6.TabIndex = 31;
            this.label6.Text = "Subjects:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.closepB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 44);
            this.panel1.TabIndex = 24;
            // 
            // closepB
            // 
            this.closepB.Image = global::School_Mangement_Project.Properties.Resources._289273cdd8dca5383ded9f74779b4ab3;
            this.closepB.Location = new System.Drawing.Point(1186, 3);
            this.closepB.Name = "closepB";
            this.closepB.Size = new System.Drawing.Size(52, 41);
            this.closepB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closepB.TabIndex = 43;
            this.closepB.TabStop = false;
            this.closepB.Click += new System.EventHandler(this.closepB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(572, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teachers";
            // 
            // TAddress
            // 
            this.TAddress.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAddress.FormattingEnabled = true;
            this.TAddress.Items.AddRange(new object[] {
            "صنعاء",
            "عمران",
            "تعز",
            "عدن",
            "أب",
            "ذمار"});
            this.TAddress.Location = new System.Drawing.Point(640, 95);
            this.TAddress.Name = "TAddress";
            this.TAddress.Size = new System.Drawing.Size(162, 39);
            this.TAddress.TabIndex = 35;
            // 
            // TName
            // 
            this.TName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TName.Location = new System.Drawing.Point(165, 96);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(234, 38);
            this.TName.TabIndex = 44;
            this.TName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TName_KeyPress);
            // 
            // TData
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TData.ColumnHeadersHeight = 25;
            this.TData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TData.DefaultCellStyle = dataGridViewCellStyle3;
            this.TData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TData.Location = new System.Drawing.Point(37, 337);
            this.TData.Name = "TData";
            this.TData.RowHeadersVisible = false;
            this.TData.RowHeadersWidth = 62;
            this.TData.RowTemplate.Height = 29;
            this.TData.Size = new System.Drawing.Size(1183, 248);
            this.TData.TabIndex = 45;
            this.TData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TData.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TData.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.TData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TData.ThemeStyle.HeaderStyle.Height = 25;
            this.TData.ThemeStyle.ReadOnly = false;
            this.TData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.TData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TData.ThemeStyle.RowsStyle.Height = 29;
            this.TData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TData_CellContentClick);
            // 
            // teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 597);
            this.Controls.Add(this.TData);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.TDOB);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.dele_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.TSub);
            this.Controls.Add(this.TAddress);
            this.Controls.Add(this.TGender);
            this.Controls.Add(this.TPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "teacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "teacher";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closepB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker TDOB;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button dele_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ComboBox TSub;
        private System.Windows.Forms.ComboBox TGender;
        private System.Windows.Forms.TextBox TPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox closepB;
        private System.Windows.Forms.ComboBox TAddress;
        private System.Windows.Forms.TextBox TName;
        private Guna.UI2.WinForms.Guna2DataGridView TData;
    }
}