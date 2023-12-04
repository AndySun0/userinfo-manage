namespace userinfo_manage
{
    partial class UserInfo
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
            components = new System.ComponentModel.Container();
            userNametext = new TextBox();
            phoneNumbertext = new TextBox();
            studentIDtext = new TextBox();
            dataGridView1 = new DataGridView();
            bookIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            borrowDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookInfoBindingSource = new BindingSource(components);
            userName = new Label();
            studentID = new Label();
            phoneNumber = new Label();
            User_Info = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookInfoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // userNametext
            // 
            userNametext.Font = new Font("Consolas", 10.5F);
            userNametext.Location = new Point(403, 80);
            userNametext.Name = "userNametext";
            userNametext.ReadOnly = true;
            userNametext.Size = new Size(292, 32);
            userNametext.TabIndex = 0;
            // 
            // phoneNumbertext
            // 
            phoneNumbertext.Font = new Font("Consolas", 10.5F);
            phoneNumbertext.Location = new Point(403, 204);
            phoneNumbertext.Multiline = true;
            phoneNumbertext.Name = "phoneNumbertext";
            phoneNumbertext.ReadOnly = true;
            phoneNumbertext.Size = new Size(292, 97);
            phoneNumbertext.TabIndex = 1;
            // 
            // studentIDtext
            // 
            studentIDtext.Font = new Font("Consolas", 10.5F);
            studentIDtext.Location = new Point(403, 141);
            studentIDtext.Name = "studentIDtext";
            studentIDtext.ReadOnly = true;
            studentIDtext.Size = new Size(292, 32);
            studentIDtext.TabIndex = 2;
            studentIDtext.Tag = "";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { bookIdDataGridViewTextBoxColumn, bookNameDataGridViewTextBoxColumn, borrowDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bookInfoBindingSource;
            dataGridView1.Location = new Point(226, 336);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1048, 379);
            dataGridView1.TabIndex = 6;
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            bookIdDataGridViewTextBoxColumn.HeaderText = "BookId";
            bookIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            bookIdDataGridViewTextBoxColumn.ReadOnly = true;
            bookIdDataGridViewTextBoxColumn.Width = 300;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            bookNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            bookNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // borrowDateDataGridViewTextBoxColumn
            // 
            borrowDateDataGridViewTextBoxColumn.DataPropertyName = "BorrowDate";
            borrowDateDataGridViewTextBoxColumn.HeaderText = "BorrowDate";
            borrowDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            borrowDateDataGridViewTextBoxColumn.Name = "borrowDateDataGridViewTextBoxColumn";
            borrowDateDataGridViewTextBoxColumn.ReadOnly = true;
            borrowDateDataGridViewTextBoxColumn.Width = 300;
            // 
            // bookInfoBindingSource
            // 
            bookInfoBindingSource.DataSource = typeof(BookInfo);
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Location = new Point(226, 83);
            userName.Name = "userName";
            userName.Size = new Size(96, 24);
            userName.TabIndex = 7;
            userName.Text = "Username";
            // 
            // studentID
            // 
            studentID.AutoSize = true;
            studentID.Location = new Point(226, 144);
            studentID.Name = "studentID";
            studentID.Size = new Size(105, 24);
            studentID.TabIndex = 8;
            studentID.Text = "Student_ID";
            // 
            // phoneNumber
            // 
            phoneNumber.AutoSize = true;
            phoneNumber.Location = new Point(226, 207);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(136, 24);
            phoneNumber.TabIndex = 9;
            phoneNumber.Text = "PhoneNumber";
            // 
            // User_Info
            // 
            User_Info.Location = new Point(51, 30);
            User_Info.Name = "User_Info";
            User_Info.Size = new Size(112, 34);
            User_Info.TabIndex = 10;
            User_Info.Text = "UserInfo";
            User_Info.UseVisualStyleBackColor = true;
            User_Info.Click += User_Info_Click;
            // 
            // UserInfo
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 844);
            Controls.Add(User_Info);
            Controls.Add(phoneNumber);
            Controls.Add(studentID);
            Controls.Add(userName);
            Controls.Add(dataGridView1);
            Controls.Add(studentIDtext);
            Controls.Add(phoneNumbertext);
            Controls.Add(userNametext);
            Name = "UserInfo";
            Text = "UserInfo";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookInfoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userNametext;
        private TextBox phoneNumbertext;
        private TextBox studentIDtext;
        private DataGridView dataGridView1;
        private Label userName;
        private Label studentID;
        private Label phoneNumber;
        private Button User_Info;
        private BindingSource bookInfoBindingSource;
        private DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn borrowDateDataGridViewTextBoxColumn;
    }
}