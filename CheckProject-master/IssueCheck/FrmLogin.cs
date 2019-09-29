using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueCheck
{
    public partial class FrmLogin : Form
    {
        C_CRUD objCRUD = new C_CRUD();
        C_Operation objOperation = new C_Operation();

        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtLoginName.Text).Trim()!= "" && (txtPassword.Text).Trim() !="")
            {
                if (objOperation.LoginUser(txtLoginName.Text.Trim(), txtPassword.Text.Trim()))
                {
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("fa-IR"));
                    FrmMain objFrmMain = new FrmMain();
                    this.Hide();
                    objFrmMain.ShowDialog();
                    Close();
    
                    //var list = objCRUD.Test();
                    //objCRUD.InsertCheck("123", "13970512", 1788970000, "Mohammad10", "1951079051", "", "TestinCheck10", "TestMore10", 1, "08:30");
                    //objCRUD.UpdateCheck("123", "13970512", 1788970000, "Mohammad10", "1951079051", "", "TestinCheck10", "TestMore10", 1, "08:30",10);
                    //objCRUD.DeleteCheck("TBL_Checks", 15);
                    //MessageBox.Show("با موفقیت انجام شد");
                }
                else
                {
                    MessageBox.Show("شناسه کاربری یا رمز عبور اشتباه است");
                }
            }
            else
            {
                MessageBox.Show("لطفا شناسه کاربری و رمز عبور را وارد کنید");

            }


        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //objCRUD.ConfigurationApp();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
