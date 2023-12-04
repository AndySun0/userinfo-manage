using LibrarySystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userinfo_manage
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private async void Add_button_Click(object sender, EventArgs e)
        {
            string book_name = textBox1.Text;
            string book_author = textBox2.Text; 
            string book_publisher = textBox3.Text;
            string book_isbn = textBox4.Text;
            string book_price = textBox5.Text;
            string book_description = textBox6.Text;

            var data = new Dictionary<string, string>
            {
                { "book_name", book_name },
                { "book_author", book_author },
                { "book_publisher", book_publisher },
                { "book_isbn", book_isbn },
                { "book_price", book_price },
                { "book_description", book_description }
            };

            Dictionary<string, string> request = new Dictionary<string, string> { { "request", "addbook" } };  //可以简化？
            Dictionary<string, string> nothing_important
                = await PublicOperations.NetWork("request",request);
            Dictionary<string, string> Result = await PublicOperations.NetWork("add_book", data);
            if (Result["status"] == "True" ) { MessageBox.Show("Successfully add book.");}
            else { MessageBox.Show("Add book failed."); }
        }

        private async void Delete_button_Click(object sender, EventArgs e)
        {
            string delete_book_name = textBox7.Text;
            var data = new Dictionary<string, string>
            {
                { "book_name", delete_book_name } };

            Dictionary<string, string> request = new Dictionary<string, string> { { "request", "deletebook" } };  //可以简化？
            Dictionary<string, string> nothing_important
                = await PublicOperations.NetWork("request", request);
            Dictionary<string, string> Result = await PublicOperations.NetWork("delete_book", data);
            if (Result["status"] == "True") { MessageBox.Show("Successfully delete book."); }
            else { MessageBox.Show("Delete book failed."); }
        }
    }
}
