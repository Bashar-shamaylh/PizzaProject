using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void UpdateSize()
        {
            if (rdbSmall.Checked)
            {
                lblSize.Text = "Small";
            }
            else if (rdbLarge.Checked)
            {
                lblSize.Text = "Meduim";
            }
            else { lblSize.Text = "Large"; }

        }
        void UpdateCrust()
        {
            if (rdbThinCrust.Checked)
            {
                lblCrustType.Text = "Thin Crust";
            }
            else
            {
                lblCrustType.Text = "Thick Crust";
            }
        }
        void UpdateToppings()
        {

        }
    }
}
