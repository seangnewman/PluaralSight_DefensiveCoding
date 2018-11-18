using ACM.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACM.Win
{
    public partial class PedometerWin : Form
    {
        public PedometerWin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            var result = customer.CalculatePercentOfGoalSteps(this.GoalTextBox.Text,this.StepsTextBox.Text);
            ResultLabel.Text = $"You reached {result}%  of your goal!";

        }
    }
}
