namespace userinfo_manage
{
    partial class Manage
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox7 = new TextBox();
            Add_button = new Button();
            Delete_button = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 10.5F);
            textBox1.Location = new Point(105, 138);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 50);
            textBox1.TabIndex = 0;
            textBox1.Text = "book_name";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Consolas", 10.5F);
            textBox2.Location = new Point(105, 213);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 50);
            textBox2.TabIndex = 1;
            textBox2.Text = "book_author";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Consolas", 10.5F);
            textBox3.Location = new Point(105, 288);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 50);
            textBox3.TabIndex = 2;
            textBox3.Text = "book_publisher";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Consolas", 10.5F);
            textBox4.Location = new Point(105, 363);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 50);
            textBox4.TabIndex = 3;
            textBox4.Text = "book_isbn";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Consolas", 10.5F);
            textBox5.Location = new Point(105, 438);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 50);
            textBox5.TabIndex = 4;
            textBox5.Text = "book_price";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Consolas", 10.5F);
            textBox6.Location = new Point(105, 515);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(568, 245);
            textBox6.TabIndex = 5;
            textBox6.Text = "book_description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(105, 68);
            label1.Name = "label1";
            label1.Size = new Size(143, 26);
            label1.TabIndex = 6;
            label1.Text = "Add Book Here";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(852, 77);
            label2.Name = "label2";
            label2.Size = new Size(162, 26);
            label2.TabIndex = 7;
            label2.Text = "Delete Book Here";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Consolas", 10.5F);
            textBox7.Location = new Point(852, 138);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(250, 50);
            textBox7.TabIndex = 8;
            textBox7.Text = "book_name";
            // 
            // Add_button
            // 
            Add_button.Location = new Point(542, 438);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(112, 34);
            Add_button.TabIndex = 9;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = true;
            Add_button.Click += Add_button_Click;
            // 
            // Delete_button
            // 
            Delete_button.Location = new Point(852, 229);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(112, 34);
            Delete_button.TabIndex = 10;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = true;
            Delete_button.Click += Delete_button_Click;
            // 
            // Manage
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1578, 844);
            Controls.Add(Delete_button);
            Controls.Add(Add_button);
            Controls.Add(textBox7);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Manage";
            Text = "Manage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private TextBox textBox7;
        private Button Add_button;
        private Button Delete_button;
    }
}