using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace MediaPlayer
{
    public partial class Setting : Form
    {
        private bool[] result;

        public bool[] Result
        {
            get { return result; }
        }

        public Setting()
        {
            InitializeComponent();
            result = new bool[3] { false, false, false };
            if (Global.isDark)
                darkmodeButton.Text = "Tắt";
            else
                darkmodeButton.Text = "Bật";
            if (Global.haveIntro)
                introButton.Text = "Tắt";
            else
                introButton.Text = "Bật";
            tabSetting.Appearance = TabAppearance.FlatButtons;
            tabSetting.ItemSize = new Size(0, 1);
            tabSetting.SizeMode = TabSizeMode.Fixed;
            oldpassText.UseSystemPasswordChar = true;
            newpassText.UseSystemPasswordChar = true;
            if (Global.isNonUser)
            {
                passwordchangeButton.Enabled = false;
                darkmodeButton.Enabled = false;
                introButton.Enabled = false;
            }
            this.DialogResult = DialogResult.No;
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
        private void deleteDataMusic_Click(object sender, EventArgs e)
        {
            result[0] = message("Xóa dữu liệu bài hát?");
        }

        private void deleteDataVideo_Click(object sender, EventArgs e)
        {
            result[1] = message("Xóa dữu liệu video?");
        }

        private void deleteDataPicture_Click(object sender, EventArgs e)
        {
            result[2] = message("Xóa dữu liệu hình ảnh?");
        }


        private bool message(string ex)
        {
            DialogResult dialogResult = MessageBox.Show(ex, "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dialogResult == DialogResult.Yes;
        }

        private void darkmodeButton_Click(object sender, EventArgs e)
        {
            if (Global.isDark)
            {
                darkmodeButton.Text = "Bật";
                Global.isDark = false;
                Global.UpdateHistory(Global.currentusername, "đã tắt Darkmode!");
            }
            else
            {
                darkmodeButton.Text = "Tắt";
                Global.isDark = true;
                Global.UpdateHistory(Global.currentusername, "đã bật Darkmode!");
            }
        }

        private void introButton_Click(object sender, EventArgs e)
        {
            if (Global.haveIntro)
            {
                introButton.Text = "Bật";
                Global.haveIntro = false;
                Global.UpdateHistory(Global.currentusername, "đã tắt intro!");
            }
            else
            {
                introButton.Text = "Tắt";
                Global.haveIntro = true;
                Global.UpdateHistory(Global.currentusername, "đã bật intro!");
            }
        }       
        private void passwordchangeButton_Click(object sender, EventArgs e)
        {
            tabSetting.SelectedIndex = 1;
        }
        private bool isNumberPass(string x)
        {
            foreach (Char a in x)
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
                if ((a < 'a' || a > 'z') || (a < 'A' || a > 'Z'))
                    return false;
            }
            return true;
        }
        private void changeButton_Click(object sender, EventArgs e)
        {
            if (GetMD5(oldpassText.Text) == Global.currentpassword)
            {
                if (!string.IsNullOrEmpty(newpassText.Text) && !string.IsNullOrEmpty(confirmpassText.Text))
                {
                    if (newpassText.Text.Length >= 6)
                    {
                        if (!isNumberPass(newpassText.Text) && !isDigitPass(newpassText.Text))
                        {
                            if (newpassText.Text == confirmpassText.Text)
                            {
                                dbControl sql = new dbControl();
                                sql.param("@username", Global.currentusername);
                                sql.param("@password", GetMD5(newpassText.Text));
                                sql.query("update usrif set password=@password where username=@username");
                                Global.currentpassword = newpassText.Text;
                                oldpassText.Clear();
                                newpassText.Clear();
                                tabSetting.SelectedIndex = 0;
                                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu không trùng khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu phải có cả chữ và số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không được ít hơn 6 chữ số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Thông tin không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                oldpassText.Clear();
                newpassText.Clear();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            oldpassText.Clear();
            newpassText.Clear();
            tabSetting.SelectedIndex = 0;
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
