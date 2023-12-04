using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using LibrarySystem;



namespace userinfo_manage
{

    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private async void User_Info_Click(object sender, EventArgs e) //写在HomePage中的 并非本文件
        {
            UserInfo UserInfo = new UserInfo();
            PublicOperations.OpenForm(this, UserInfo);//接到点击信号，打开info窗口
            /*
                        string userName = "ggt"; //记得读取username////////////////////////////////
                        var dictionary = new Dictionary<string, List<string>>();

                        var data = new Dictionary<string, string>();
                        data.Add("username", userName);

                        dictionary = await PublicOperations.NetWorkList("personal_info", data);*/
            //dictionary.Add("userName", [userName]);
            var dictionarytest = new Dictionary<string, List<string>>
            {
                { "username", new List<string> { "12109090003" } },
                { "student_id", new List<string> { "1idididi" } },
                { "phone_number", new List<string> { "101", "102", "103", "101", "102", "103", "101", "102", "103" } },
                { "book_id", new List<string> { "101", "102", "103", "101", "102", "103", "101", "102", "103" , "101", "102", "103", "101", "102", "103"} },
                { "book_name", new List<string> { "C# Programming", "Mastering Python", "Data Structures" , "101", "102", "103", "101", "102", "103", "101", "102", "103", "101", "102", "103"} },
                { "borrow_date", new List<string> { "2023-01-01", "2023-01-15", "2023-02-01", "101", "102", "103", "101", "102", "103", "101", "102", "103", "101", "102", "103" } }
            };

            //上方接收数据，下方展示
            UserInfo.userNametext.Text = dictionarytest["username"][0];
            UserInfo.studentIDtext.Text = dictionarytest["student_id"][0];
            if (dictionarytest.ContainsKey("phone_number") && dictionarytest["phone_number"] != null)
            {
                // 将电话号码列表拼接为一个字符串，每个号码占一行
                string phoneNumbers = string.Join("\r\n", dictionarytest["phone_number"]);
                UserInfo.phoneNumbertext.Text = phoneNumbers;
            }
            else
            {
                // 如果没有电话号码，可以选择清空TextBox或显示默认文本
                UserInfo.phoneNumbertext.Text = "No Phone Numbers";
            }

            var bookInfoList = new List<BookInfo>();

            for (int i = 0; i < dictionarytest["book_id"].Count; i++)
            {
                var bookInfo = new BookInfo
                {
                    BookId = dictionarytest["book_id"][i],
                    BookName = dictionarytest["book_name"][i],
                    BorrowDate = dictionarytest["borrow_date"][i]
                };

                bookInfoList.Add(bookInfo);


            }
            //  DataGridView1
            UserInfo.dataGridView1.DataSource = bookInfoList;
            /* UserInfo.Book_ID.DataPropertyName = dictionary["book_id"];
             UserInfo.Book_name.DataPropertyName = dictionary["book_name"];
             UserInfo.Borrow_date.DataPropertyName = dictionary["borrow_date"];*/

        }

        private void UserInfo_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    public class BookInfo
    {
        public string BookId { get; set; }
        public string BookName { get; set; }
        public string BorrowDate { get; set; }
    }
}
