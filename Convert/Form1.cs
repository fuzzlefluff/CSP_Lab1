using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert_MatthewPrindleSummer2017
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConvertBttn_Click(object sender, EventArgs e)
        {
            if (FarhConvRadBtn.Checked == true)
            {
                try
                {
                    Console.WriteLine("Farenheit to Celsius");
                    MainFrm.ActiveForm.Text = "Farenheit to Celsius";
                    int temperature = Convert.ToInt16(FarhTxtB.Text);
                    temperature = temperature - 32;
                    temperature = (int)(temperature * 0.5556);
                    CelsiusTxtB.Text = Convert.ToString(temperature);
                }
                catch (Exception E)
                {
                    MessageBox.Show("Please Put in a Farenheit Temperature!");
                }

            }
            if (CelsiusConvRadBtn.Checked == true)
            {
                try
                {
                    Console.WriteLine("Celsius to Farenheit");
                    MainFrm.ActiveForm.Text = "Celsius to Farenheit";
                    int temperature = Convert.ToInt16(CelsiusTxtB.Text);
                    temperature = (int)(temperature * 1.8);
                    temperature = temperature + 32;
                    FarhTxtB.Text = Convert.ToString(temperature);
                }
                catch (Exception E)
                {
                    MessageBox.Show("Please Put in a Celsius Temperature!");
                }

            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            FarhTxtB.Text = "";
            CelsiusTxtB.Text = "";
        }
    }
}
