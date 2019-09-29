using IssueCheck.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IssueCheck
{
    public partial class FrmMain : Form
    {
        C_Control objC_Control = new C_Control();
      public FrmMain()
        {
            InitializeComponent();
         
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmAddEditCheck objFrmAddEditCheck = new IssueCheck.FrmAddEditCheck(0, 1);
            objFrmAddEditCheck.ShowDialog();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            //tSSLTimeInSystem.Text = DateTime.Now.Hour + ":" + System.DateTime.Now.Minute + ":" + System.DateTime.Now.Second;
            tSSLTimeInSystem.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        public void InitializeDateTime()
        {

            tSSLDateSystem.Text = objC_Control.DateToday();
            //tSSLDateSystem.Text = DateTime.Now.ToString("dd/MM/yyyy");//tarikh feli ro mide
            //tSSLDateSystem.Text = DateTime.Now.ToString("yyyy/MM/dd");//tarikh feli ro mide
            tSSLTimeInSystem.Text = DateTime.Now.ToString("HH:mm:ss tt");
            timerMain.Tick += new EventHandler(timerMain_Tick);
            timerMain.Interval = 800;
            timerMain.Start();
        }
        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //FrmLogin objFrmLogin = new FrmLogin();
            //objFrmLogin.ShowDialog();

            tSSLUserLogin.Text = objC_Control.Loginname();
            InitializeDateTime();
            InitializeAllControlofMainForm();
       
        }
        public void InitializeAllControlofMainForm()
        {
            int height = SystemInformation.VirtualScreen.Height;

            int _width = SystemInformation.VirtualScreen.Width/2;
            groupBoxMainForm.Location = new Point(_width - (groupBoxMainForm.Width/2),1 );
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }
      
        private void groupBoxMainForm_Enter(object sender, EventArgs e)
        {
      
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            FrmManageChecks objFrmManageChecks = new IssueCheck.FrmManageChecks();
            objFrmManageChecks.ShowDialog();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

        }
    }
}
