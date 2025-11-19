using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            UpdateTotalPrice();
            if (rbSmall.Checked)
            {
                lbChoosenSize.Text = "Small";
                return;
            }

            if (rbMeduim.Checked)
            {
                lbChoosenSize.Text = "Meduim";
                return;
            }
            if (rbLarg.Checked)
            {
                lbChoosenSize.Text = "Larg";
                return;
            }
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbThinCrust.Checked)
            {
                lbChoosenCrustType.Text = "Thin Crust";
                return;
            }
            else
            {
                lbChoosenCrustType.Text = "thick Crust";
                return;
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";
            if (cbExtraChees.Checked)
            {
                sToppings = "Extra Chees";
            }

            if (cbOnions.Checked)
            {
                sToppings += ", Onions";
            }

            if (cbMushrooms.Checked)
            {
                sToppings += ", Mushrooms Chees";
            }

            if (cbOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (cbTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }

            if (cbGreenPeppers.Checked)
            {
                sToppings += ", Green Peppers";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1,sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
            {
                sToppings = "No Toppings";
            }

            lbTopings.Text = sToppings;
        }

        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lbChoosenWhereToEat.Text = "Eat In";
                return;
            }
            else
            {
                lbChoosenWhereToEat.Text = "Take Out";
                return;
            }
        }

        void ResetForm()
        {
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;

            btmOrderPizza.Enabled = true;

            rbMeduim.Checked = true;
            cbExtraChees.Checked = false;
            cbGreenPeppers.Checked = false;
            cbMushrooms.Checked = false;
            cbOlives.Checked = false;
            cbOnions.Checked = false;
            cbTomatoes.Checked = false;

            rbThinCrust.Checked = true;

            rbEatIn.Checked = true;

            numericUpDown1.Enabled = true;

            numericUpDown1.Value = 1;

        }

        void UpdateOrderSummary()
        {
           
            UpdateSize();
            UpdateToppings();
            UpdateWhereToEat();
            UpdateTotalPrice();
            
        }

        float GetSelectedCrustPrice()
        {
            if (rbThinCrust.Checked)
            {
                return Convert.ToSingle(rbThinCrust.Tag);
            }
            else
            {
                return Convert.ToSingle(rbThinkCrust.Tag);
            }
        }

        float CalculateToppingsPrice()
        {
            float ToppingsTotalPrice = 0;
            if (cbExtraChees.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(cbExtraChees.Tag);
            }

            if (cbGreenPeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(cbGreenPeppers.Tag);
            }

            if (cbMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(cbMushrooms.Tag);
            }

            if (cbOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(cbOlives.Tag);
            }

            if (cbOnions.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(cbOnions.Tag);
            }

            if (cbTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(cbTomatoes.Tag);
            }
            return ToppingsTotalPrice;

        }

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            else if (rbMeduim.Checked)
            {
                return Convert.ToSingle(rbMeduim.Tag);
            }
            else
            {
                return Convert.ToSingle(rbLarg.Tag);
            }
        }

        float CalculateTotalPrice()
        {
            float NumberOfPizza = Convert.ToSingle(numericUpDown1.Value);
            return NumberOfPizza*(GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice());
        }

        void UpdateTotalPrice()
        {

            lbChoosenTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }

        private void cbExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void cbOnions_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void cbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void cbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void cbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbTackOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void btmOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Place Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btmOrderPizza.Enabled = false;
                numericUpDown1.Enabled = false;
            }
            else
            {

            }
        }

        private void btmResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime systemtime = new DateTime();
            systemtime = DateTime.Now;
            label1.Text = systemtime.ToString("HH:mm:ss");
            UpdateOrderSummary();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            DateTime systemtime = new DateTime();
            systemtime = DateTime.Now;
            label1.Text = systemtime.ToString("HH:mm:ss");
            if (systemtime.ToString("HH:mm:ss") == "00:00:00")
            {
                MessageBox.Show("The Work Time Is END !!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

       
        

       

        

       
    }
}
