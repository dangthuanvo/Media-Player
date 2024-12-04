using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace MediaPlayer
{
    class dbControl
    {
        SqlConnection cn;
        SqlCommand cm;
        public SqlDataAdapter da;
        List<SqlParameter> Params = new List<SqlParameter>();
        public DataTable dt;
        public int recordcount;
        public string exception;
        public dbControl()   
        {
            string x = Directory.GetCurrentDirectory();
            x = x + @"\UserInfo.mdf";
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + x + ";Integrated Security=True");
        }
        public void query(string name)
        {
            recordcount = 0;
            exception = null;
            try
            {
                cn.Open();
                cm = new SqlCommand(name, cn);
                Params.ForEach(p => cm.Parameters.Add(p));
                Params.Clear();
                dt = new DataTable();
                da = new SqlDataAdapter();
                da.SelectCommand = cm;
                recordcount = da.Fill(dt);
            }
            catch (Exception e)
            {
                exception = "Problem: " + e.Message;
            }
            finally 
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();             
                }
            }
        }
        public void param(string name, string value)
        {
            SqlParameter newparam = new SqlParameter(name, value);
            Params.Add(newparam);
        }
        public bool checkforerror(bool err = false)
        {
            if (string.IsNullOrEmpty(exception))
                return false;
            if (err == true)
            {
                MessageBox.Show(exception, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        public void getinfo(string username)
        {
            cn.Open();
            cm = new SqlCommand("select lastname, videopath, photopath, musicpath, historypath, password from usrif where username = @username", cn);
            cm.Parameters.AddWithValue("@username", username);
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                Global.currentusername = username;
                Global.currentlastname = dr.GetValue(0).ToString();
                Global.currentvideopath = dr.GetValue(1).ToString();
                Global.currentphotopath = dr.GetValue(2).ToString();
                Global.currentmusicpath = dr.GetValue(3).ToString();
                Global.currenthistorypath = dr.GetValue(4).ToString();
                Global.currentpassword = dr.GetValue(5).ToString();
            }
            cn.Close();
        }
    }
}
