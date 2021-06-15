using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class LoginFrm : Form
    {

        public LoginFrm()
        {

            InitializeComponent();

        }




        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        public void User_login()
        {
            using (IDbConnection db = new SqlConnection(SqlConnectionclass.ConnectionString))
            {
                if (db.State == System.Data.ConnectionState.Closed)
                    db.Open();
                var parameters = new DynamicParameters();
                parameters.Add("@email", txtusername.Text.Trim());
                parameters.Add("@password", txtpassword.Text.Trim());
                var b = db.Query<UserModel>("User_Login", parameters, null, true, null, System.Data.CommandType.StoredProcedure);


            }
        }
        private void gplogin_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            using (IDbConnection db = new SqlConnection(SqlConnectionclass.ConnectionString))
            {

                if (db.State == System.Data.ConnectionState.Closed)
                    db.Open();
                var parameters = new DynamicParameters();
                parameters.Add("@email", txtusername.Text.Trim());
                parameters.Add("@password", txtpassword.Text.Trim());
                var b = db.Query<UserModel>("User_Login", parameters, null, true, null, System.Data.CommandType.StoredProcedure);
                var count = b.Count();
                UserModel user = new UserModel();
                if (count == 1)
                {
                    foreach (var b2 in b)
                    {
                        Mainfrm objfrmMain = new Mainfrm(
                            
                            user.full_name=  b2.full_name
                            
                            );
                        this.Hide();
                        objfrmMain.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Sai Email hoặc password !!!!");
                }

            }

        }
    }
}
