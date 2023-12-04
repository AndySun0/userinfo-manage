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
        private async void User_Info_Click(object sender, EventArgs e) //HomePage
        {
            UserInfo UserInfo = new UserInfo();
            PublicOperations.OpenForm(this, UserInfo);//接到点击信号，打开info窗口
           
            string userName = e.ToString(); //记得读取username////////////////////////////////
            var data = new Dictionary<string, string>
            {
                { "username", userName }
            };   //data作为输入，内含《username，username》
            var dictionary = new Dictionary<string, List<string>>(); //dictionary是函数networklist的返回值
            dictionary = await PublicOperations.NetWorkList("personal_info", data);   

            //上方接收数据，下方展示
            UserInfo.userNametext.Text = dictionary["username"][0];
            UserInfo.studentIDtext.Text = dictionary["student_id"][0];
            if (dictionary.ContainsKey("phone_number") && dictionary["phone_number"] != null)
            {
                // 将电话号码列表拼接为一个字符串，每个号码占一行
                string phoneNumbers = string.Join("\r\n", dictionary["phone_number"]);
                UserInfo.phoneNumbertext.Text = phoneNumbers;
            }
            else
            {
                // 如果没有电话号码，可以选择清空TextBox或显示默认文本
                UserInfo.phoneNumbertext.Text = "No Phone Numbers";
            }

            var bookInfoList = new List<BookInfo>();

            for (int i = 0; i < dictionary["book_id"].Count; i++)
            {
                var bookInfo = new BookInfo
                {
                    BookId = dictionary["book_id"][i],
                    BookName = dictionary["book_name"][i],
                    BorrowDate = dictionary["borrow_date"][i]
                };
                bookInfoList.Add(bookInfo);
            }
            //  DataGridView1
            UserInfo.dataGridView1.DataSource = bookInfoList;
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
    public static class common // static 不是必须
    {
        public static string userName
        {
            get { return userName; }
            set { userName = value; }
        }
    }
}
