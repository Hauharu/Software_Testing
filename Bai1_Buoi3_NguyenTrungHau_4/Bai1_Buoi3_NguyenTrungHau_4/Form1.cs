using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Bai1_Buoi3_NguyenTrungHau_4
{
    public partial class Form1 : Form
    {
        private IWebDriver driver;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đảm bảo khi khởi tạo không có lỗi màn hình đen (thiết lập ứng dụng không hiển thị màn hình đen)
            Application.EnableVisualStyles();
        }

        private void bt_hau_4_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu textbox không rỗng
                string url = string.IsNullOrEmpty(tbox_hau_4.Text.ToString()) ? "https://www.google.com" : tbox_hau_4.Text.ToString();

                // Khởi tạo ChromeDriver
                driver = new ChromeDriver();
                driver.Url = url;

                // Điều hướng đến trang web
                driver.Navigate();

                // Lấy URL hiện tại và hiển thị lên TextBox
                string link_hientai = driver.Url;
                tbox_hau_4.Text = link_hientai;  // Cập nhật URL vào TextBox

                // Lấy Title và hiển thị lên TextBox hoặc Console nếu cần
                string pageTitle = driver.Title;
                Console.WriteLine(pageTitle);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }



        // Đảm bảo không có màn hình đen khi ứng dụng chạy
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (driver != null)
            {
                driver.Quit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Đóng tất cả các cửa sổ liên kết
                driver.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi đóng trình duyệt: " + ex.Message);
            }
        }
    }
}
