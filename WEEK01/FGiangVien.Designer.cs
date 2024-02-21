namespace WEEK01
{
    partial class FGiangVien
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
            gvHsinh2 = new DataGridView();
            btnModify = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dtpDoB = new DateTimePicker();
            txtAdress = new TextBox();
            txtID = new TextBox();
            txtName = new TextBox();
            lblBirthday = new Label();
            lblAdress = new Label();
            lblID = new Label();
            lblName = new Label();
            lblMove = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)gvHsinh2).BeginInit();
            SuspendLayout();
            // 
            // gvHsinh2
            // 
            gvHsinh2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvHsinh2.Location = new Point(541, 22);
            gvHsinh2.Name = "gvHsinh2";
            gvHsinh2.RowHeadersWidth = 51;
            gvHsinh2.RowTemplate.Height = 29;
            gvHsinh2.Size = new Size(357, 304);
            gvHsinh2.TabIndex = 17;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(614, 363);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(187, 50);
            btnModify.TabIndex = 14;
            btnModify.Text = "Sửa";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(350, 363);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(187, 50);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(86, 363);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(187, 50);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtpDoB
            // 
            dtpDoB.Location = new Point(254, 273);
            dtpDoB.Name = "dtpDoB";
            dtpDoB.Size = new Size(246, 27);
            dtpDoB.TabIndex = 13;
            dtpDoB.Value = new DateTime(2023, 12, 17, 0, 0, 0, 0);
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(254, 208);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(197, 27);
            txtAdress.TabIndex = 10;
            // 
            // txtID
            // 
            txtID.Location = new Point(254, 130);
            txtID.Name = "txtID";
            txtID.Size = new Size(197, 27);
            txtID.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(254, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(197, 27);
            txtName.TabIndex = 12;
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblBirthday.Location = new Point(43, 276);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(175, 23);
            lblBirthday.TabIndex = 6;
            lblBirthday.Text = "Ngày tháng năm sinh";
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAdress.Location = new Point(43, 209);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new Size(62, 23);
            lblAdress.TabIndex = 7;
            lblAdress.Text = "Địa chỉ";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblID.Location = new Point(43, 131);
            lblID.Name = "lblID";
            lblID.Size = new Size(61, 23);
            lblID.TabIndex = 8;
            lblID.Text = "CMND";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(43, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(85, 23);
            lblName.TabIndex = 9;
            lblName.Text = "Họ và Tên";
            // 
            // lblMove
            // 
            lblMove.AutoSize = true;
            lblMove.LinkColor = Color.Black;
            lblMove.Location = new Point(785, 427);
            lblMove.Name = "lblMove";
            lblMove.Size = new Size(102, 20);
            lblMove.TabIndex = 18;
            lblMove.TabStop = true;
            lblMove.Text = "Học Sinh >>>";
            // 
            // FGiangVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 468);
            Controls.Add(lblMove);
            Controls.Add(gvHsinh2);
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
            Name = "FGiangVien";
            Text = "Login";
            Load += FGiangVien_Load;
            ((System.ComponentModel.ISupportInitialize)gvHsinh2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvHsinh2;
        private Button btnModify;
        private Button btnDelete;
        private Button btnAdd;
        private DateTimePicker dtpDoB;
        private TextBox txtAdress;
        private TextBox txtID;
        private TextBox txtName;
        private Label lblBirthday;
        private Label lblAdress;
        private Label lblID;
        private Label lblName;
        private LinkLabel lblMove;
    }
}