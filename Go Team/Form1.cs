using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoTeam__MatthewPrindleSummer2017
{
    public partial class Mainfrm : Form
    {
        public Mainfrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClickBtn_Click(object sender, EventArgs e)
        {
            HelloLbl.Text = "Go Eagle Sports Team!";
            Mainfrm.ActiveForm.Text = "Go Eagle Sports Team!";
            ExitBtn.Dispose();
            ClickBtn.Enabled = false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
