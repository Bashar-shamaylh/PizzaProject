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
        void LockFormKeys()
        {
            rdbSmall.Enabled = false;
            rdbLarge.Enabled = false;
            rdbMeduim.Enabled = false;

            rdbThickCrust.Enabled = false;
            rdbThinCrust.Enabled = false;

            ckExtraChees.Enabled = false;
            ckGreenPeppers.Enabled = false;
            ckMashrooms.Enabled = false;
            ckTomatos.Enabled = false;
            ckOnion.Enabled = false;
            ckOlives.Enabled = false;

            rbEatIn.Enabled = false;
            rbEatOut.Enabled = false;
        }
        void UpdateSize()
        {
            if (rdbSmall.Checked)
            {
                lblSize.Text = "Small";
            }
            else if (rdbLarge.Checked)
            {
                lblSize.Text = "Large";
            }
            else { lblSize.Text = "Meduim"; }

        }
        void UpdateCrust()
        {
            if (rdbThinCrust.Checked)
            {
                CrustType.Text = "Thin Crust";
            }
            else
            {
                CrustType.Text = "Thick Crust";
            }
        }
        void UpdateToppings()
        {
            string text = "";
            if (ckExtraChees.Checked)
            {
                text += "Extra Chees ";

            }
            if (ckOlives.Checked)
            {
                text += "Olives ";
            }
            if (ckOnion.Checked)
            {
                text += " Onion ";
            }
            if (ckGreenPeppers.Checked)
            {
                text += "Green Peppers ";
            }
            if (ckTomatos.Checked)
            {
                text += " Tommatos";

            }
            if (ckMashrooms.Checked)
            {
                text += " Mashrooms .";

            }
            if (text == "")
                text="No Toppings" ;
            lblToppings.Text = text;

            
        }
        void UpdateEatingPlace()
        {
            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In ";
            }
            else
                lblWhereToEat.Text = "Take Out";
        }
        void SetFormOnDefult()
        {
            rdbSmall.Checked = true;
            rdbThinCrust.Checked = true;
            rbEatIn.Checked = true;
            //toppings ==false

            ckExtraChees.Checked = false;
            ckOlives.Checked = false;
            ckOnion.Checked = false;
            ckGreenPeppers.Checked = false;
            ckMashrooms.Checked = false;
            ckTomatos.Checked = false;

            //free the form keys
            rdbSmall.Enabled = true;
            rdbLarge.Enabled = true;
            rdbMeduim.Enabled = true;

            rdbThickCrust.Enabled = true;
            rdbThinCrust.Enabled = true;

            ckExtraChees.Enabled = true;
            ckGreenPeppers.Enabled = true;
            ckMashrooms.Enabled = true;
            ckTomatos.Enabled = true;
            ckOnion.Enabled = true;
            ckOlives.Enabled = true;

            rbEatIn.Enabled = true;
            rbEatOut.Enabled = true;
        }
        byte CalculateSizePrice()
        {
            if (rdbSmall.Checked)
            {
                return 5;
            }
            else if (rdbMeduim.Checked)
            {
                return 10;
            }
            else
                return 15;
        }
        byte CalculateCrustPrice()
        {
            if (rdbThickCrust.Checked)
                return 10;
            else
                return 5;
        }
        byte CalculateToppingsPrice()
        {
            byte price = 0;
            if (ckExtraChees.Checked)
                price += 2;
            if (ckOlives.Checked)
                price += 2;
            if(ckGreenPeppers.Checked)
                price += 2;
            if(ckMashrooms.Checked)
                price += 2;
            if( ckTomatos.Checked)
                price += 2;
            if(ckOnion.Checked)
                price += 2;
            return price;
        }
        byte CalculateTotalPrice()
        {
            byte totalPrice = 0;
            totalPrice =(byte) (CalculateCrustPrice() + CalculateSizePrice() + CalculateToppingsPrice());
            return totalPrice;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetFormOnDefult();
        }

        private void rdbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
            lblTotalPrice.Text =Convert.ToString( CalculateTotalPrice());
        }

        private void rdbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
            lblTotalPrice.Text = Convert.ToString(CalculateTotalPrice());

        }

        private void rdbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize() ;
            lblTotalPrice.Text = Convert.ToString(CalculateTotalPrice());

        }

        private void rdbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
            lblTotalPrice.Text = Convert.ToString(CalculateTotalPrice());


        }

        private void rdbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
            lblTotalPrice.Text = Convert.ToString(CalculateTotalPrice());

        }

        private void ckExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            
            UpdateToppings();
            lblTotalPrice.Text = Convert.ToString(CalculateTotalPrice());

        }

        private void ckOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings() ;
            lblTotalPrice.Text = Convert.ToString(CalculateTotalPrice());

        }

        private void ckOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            lblTotalPrice.Text = Convert.ToString(CalculateTotalPrice());


        }

        private void ckGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            lblTotalPrice.Text = Convert.ToString(CalculateTotalPrice());


        }

        private void ckTomatos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            lblTotalPrice.Text = Convert.ToString(CalculateTotalPrice());


        }

        private void ckMashrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            lblTotalPrice.Text = Convert.ToString(CalculateTotalPrice());


        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEatingPlace();

        }

        private void rbEatOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEatingPlace();

        }

        private void bRestForm_Click(object sender, EventArgs e)
        {
            SetFormOnDefult();
        }

        private void bOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm Order1", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order placed Succsesfuly!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LockFormKeys();



            }



        }
    }
}
