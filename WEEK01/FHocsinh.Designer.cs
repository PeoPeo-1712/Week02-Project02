namespace WEEK01
{
    partial class FHocsinh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblID = new Label();
            lblAdress = new Label();
            txtName = new TextBox();
            txtID = new TextBox();
            txtAdress = new TextBox();
            lblBirthday = new Label();
            dtpDoB = new DateTimePicker();
            btnAdd = new Button();
            btnDelete = new Button();
            btnModify = new Button();
            gvHsinh = new DataGridView();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)gvHsinh).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(56, 65);
            lblName.Name = "lblName";
            lblName.Size = new Size(85, 23);
            lblName.TabIndex = 0;
            lblName.Text = "Họ và Tên";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(56, 143);
            lblID.Name = "lblID";
            lblID.Size = new Size(61, 23);
            lblID.TabIndex = 0;
            lblID.Text = "CMND";
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdress.Location = new Point(56, 221);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(62, 23);
            lblAdress.TabIndex = 0;
            lblAdress.Text = "Địa chỉ";
            // 
            // txtName
            // 
            txtName.Location = new Point(267, 64);
            txtName.Name = "txtName";
            txtName.Size = new Size(197, 27);
            txtName.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Location = new Point(267, 142);
            txtID.Name = "txtID";
            txtID.Size = new Size(197, 27);
            txtID.TabIndex = 1;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(267, 220);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(197, 27);
            txtAdress.TabIndex = 1;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblBirthday.Location = new Point(56, 288);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(175, 23);
            lblBirthday.TabIndex = 0;
            lblBirthday.Text = "Ngày tháng năm sinh";
            // 
            // dtpDoB
            // 
            dtpDoB.Location = new Point(267, 285);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(246, 27);
            dtpDoB.TabIndex = 2;
            dtpDoB.Value = new DateTime(2023, 12, 17, 0, 0, 0, 0);
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(99, 375);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(187, 50);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(363, 375);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(187, 50);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(627, 375);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(187, 50);
            btnModify.TabIndex = 3;
            btnModify.Text = "Sửa";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // gvHsinh
            // 
            gvHsinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvHsinh.Location = new Point(554, 34);
            gvHsinh.Name = "gvHsinh";
            gvHsinh.RowHeadersWidth = 51;
            gvHsinh.RowTemplate.Height = 29;
            gvHsinh.Size = new Size(357, 304);
            gvHsinh.TabIndex = 4;
            gvHsinh.CellContentClick += gvHsinh_CellContentClick;
            gvHsinh.SelectionChanged += gvHsinh_SelectionChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(798, 439);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(113, 20);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Giảng viên >>>";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FHocsinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 468);
            Controls.Add(linkLabel1);
            Controls.Add(gvHsinh);
            Controls.Add(btnModify);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dtpDoB);
            Controls.Add(txtAdress);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(lblBirthday);
            Controls.Add(lblAdress);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Name = "FHocsinh";
            Text = "Login";
            Load += FHocsinh_Load;
            ((System.ComponentModel.ISupportInitialize)gvHsinh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblID;
        private Label lblAdress;
        private TextBox txtName;
        private TextBox txtID;
        private TextBox txtAdress;
        private Label lblBirthday;
        private DateTimePicker dtpDoB;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnModify;
        private DataGridView gvHsinh;
        private LinkLabel linkLabel1;
    }
}