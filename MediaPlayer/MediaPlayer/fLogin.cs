using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using MediaPlayer.Properties;
using System.Security.Cryptography;
namespace MediaPlayer
{
    public partial class fLogin : Form
    {
        dbControl sql;
        public fLogin()
        {
            InitializeComponent();
            sql = new dbControl();
        }
        private void fLogin_Load(object sender, EventArgs e)
        {
            string x = System.IO.Directory.GetCurrentDirectory();
            Global.currentpath = x + @"\Users";
            pnlRes.Hide();
            pnlLogin.Show();
            pnlLogin.BringToFront();
        }
        public string GetMD5(string chuoi)
        {
            string str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }
            return str_md5;
        }
        private void OnFocus(object sender, EventArgs e)
        {
            passBox.UseSystemPasswordChar = true;
        }
        void Clearcache()
        {
            usrnameBox.Clear();
            passBox.Clear();
            confirmpassBox.Clear();
            fnameBox.Clear();
            lnameBox.Clear();
        }
        void Updatepath(string username)
        {
            string x = System.IO.Directory.GetCurrentDirectory();
            Global.currentpath = x + @"\Users";
            Global.currentpath += @"\" + username;
            sql.param("@username", username);
            sql.param("@musicpath", Global.currentpath + @"\musicpath");
            sql.param("@videopath", Global.currentpath + @"\videopath");
            sql.param("@photopath", Global.currentpath + @"\photopath");
            sql.param("@historypath", Global.currentpath + @"\historypath");
            sql.query("update usrif set musicpath=@musicpath, videopath=@videopath, photopath=@photopath, historypath=@historypath where username=@username");
        }
        private bool isNumberPass(string x)
        {
            foreach(Char a in x)
            {
                if (a < '0' || a > '9')
                    return false;
            }
            return true;
        }
        private bool isDigitPass(string x)
        {
            foreach (Char a in x)
            {
                if ((a < 'a' || a > 'z')||(a < 'A' || a > 'Z'))
                    return false;
            }
            return true;
        }
        bool register()
        {
            if(string.IsNullOrEmpty(usrnameBox.Text)|| string.IsNullOrEmpty(passBox.Text)|| string.IsNullOrEmpty(confirmpassBox.Text) || string.IsNullOrEmpty(fnameBox.Text) || string.IsNullOrEmpty(lnameBox.Text))
            {
                MessageBox.Show("Thông tin không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (passBox.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu không được ít hơn 6 kí tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (confirmpassBox.Text != passBox.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if(isDigitPass(passBox.Text)||isNumberPass(passBox.Text))
            {
                MessageBox.Show("Mật khẩu phải chứa cả chữ và số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            sql.param("@username", usrnameBox.Text);
            sql.query("select count(*) from usrif where username=@username");
            if ((int)sql.dt.Rows[0][0] == 1)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            sql.param("@username", usrnameBox.Text);
            sql.param("@password", GetMD5(passBox.Text));
            sql.param("@firstname", fnameBox.Text);
            sql.param("@lastname", lnameBox.Text);
            sql.query("insert into usrif (firstname, lastname, username, password) values (@firstname, @lastname, @username, @password)");
            string x = System.IO.Directory.GetCurrentDirectory();
            Global.currentpath = x + @"\Users";
            Global.currentpath += @"\" + usrnameBox.Text;
            System.IO.Directory.CreateDirectory(Global.currentpath);
            FileStream fs1 = new FileStream(Global.currentpath + @"\musicpath", FileMode.Create);
            FileStream fs2 = new FileStream(Global.currentpath + @"\videopath", FileMode.Create);
            FileStream fs3 = new FileStream(Global.currentpath + @"\photopath", FileMode.Create);
            FileStream fs4 = new FileStream(Global.currentpath + @"\historypath", FileMode.Create);
            sql.param("@username", usrnameBox.Text);
            sql.param("@musicpath", Global.currentpath + @"\musicpath");
            sql.param("@videopath", Global.currentpath + @"\videopath");
            sql.param("@photopath", Global.currentpath + @"\photopath");
            sql.param("@historypath", Global.currentpath + @"\historypath");
            sql.query("update usrif set musicpath=@musicpath, videopath=@videopath, photopath=@photopath, historypath=@historypath where username=@username");
            if (sql.checkforerror(true))
            {
                Clearcache();
                return false;
            }
            Global.currenthistorypath = Global.currentpath + @"\historypath";
            Clearcache();
            MessageBox.Show("Đăng kí thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        bool login()
        {
            sql.param("@username", username.Text);
            sql.param("@password", GetMD5(password.Text));
            sql.query("select count(*) from usrif where username=@username and password=@password");
            if ((int)sql.dt.Rows[0][0] == 1)
                return true;
            MessageBox.Show("Tài khoản hoặc mật khẩu sai", "Không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        public void DfsDispose(Control u)
        {
            foreach (Control v in u.Controls)
                DfsDispose(v);
            u.Dispose();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            pnlLogin.Show();
            pnlRes.Hide();
        }


        private void resButton_Click(object sender, EventArgs e)
        {
            if (register())
            {
                Global.UpdateHistory(usrnameBox.Text, "đã tạo tài khoản!");
                pnlLogin.Show();
                pnlRes.Hide();
            }
            else
            {
                pnlLogin.Hide();
                pnlRes.Show();
            }
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (login() == true)
            {
                Updatepath(username.Text);
                sql.getinfo(username.Text);
                Global.UpdateHistory(username.Text, "đã đăng nhập!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void topageResButton_Click_1(object sender, EventArgs e)
        {
            pnlLogin.Hide();
            pnlRes.Show();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        private void guestButton_Click(object sender, EventArgs e)
        {
            Global.isNonUser = true;
            Global.UpdateHistory("guest", "đã đăng nhập!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

