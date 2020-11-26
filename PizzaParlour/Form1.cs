using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace PizzaParlour
{
    public partial class Form1 : Form
    {
        Double PizzaTopping = 1.25;
        Double Pizza = 7;
        Double notTopping;
        Double TotalCost;

        public Form1()
        {
            InitializeComponent();
        }

        private void CostButton_Click(object sender, EventArgs e)
        {
            try
            {
                notTopping = Convert.ToDouble(notLabel.Text);
                //costLabel.Text = notTopping.ToString("##");
                TotalCost = notTopping * PizzaTopping + Pizza;
                costLabel.Text = TotalCost.ToString("C");
            }
            catch (global::System.Exception)
            {
                costLabel.Text = "Error";

            }

        }
    }
}






