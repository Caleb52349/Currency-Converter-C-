using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = int.Parse(aAmount.Text);

            if (aFromCombo1.SelectedItem == "Zlote" && aToCombo2.SelectedItem == "Qar")
            {
                double conver = i * 0.86;
                aDisplay.Text = "Converted Amount : " + conver + "\t Qar";
            }
            if (aFromCombo1.SelectedItem == "Qar" && aToCombo2.SelectedItem == "Zlote")
            {
                double conver = i / 0.86;
                aDisplay.Text = "Converted Amount : " + conver +"\t Zlote";
            }

            if (aFromCombo1.SelectedItem == "Zlote" && aToCombo2.SelectedItem == "Euro")
            {
                double conver = i * 0.22;
                aDisplay.Text = "Converted Amount : " + conver+"\t Euro";
            }

            if (aFromCombo1.SelectedItem == "Euro" && aToCombo2.SelectedItem == "Zlote")
            {
               double conver = i / 0.22;
                aDisplay.Text = "Converted Amount : " + conver + "\t Zlote";
               
            }

            if (aFromCombo1.SelectedItem == "Qar" && aToCombo2.SelectedItem == "Euro")
            {
                double conver = i * 0.26;
                aDisplay.Text = "Converted Amount : " + conver +"\t Euro";
            }
            if (aFromCombo1.SelectedItem == "Euro" && aToCombo2.SelectedItem == "Qar")
            {
                double conver = i / 0.26;
                aDisplay.Text = "Converted Amount : " + conver + "\t Qar";
            }
            
        }
    }
}
