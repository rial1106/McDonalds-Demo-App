using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace McDonalds
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            int numBurgers = (int)numericUpDownBurgers.Value;
            int numChips = (int)numericUpDownChips.Value;
            int numNuggets = (int)numericUpDownNuggets.Value;
            int numDrinks = (int)numericUpDownDrinks.Value;

            string message = "You are ordering:\n"
                + numBurgers + " Burgers\n"
                + numChips + " Chips\n"
                + numNuggets + " Nuggets\n"
                + "and " + numDrinks + " Drinks\n"
                + "for a total of R" + getTotal();
            string title = "Confirm or Cancel";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                try

                {

                    //Connect to Databse
                    String str = "server=ML-RefVm-631348\\SQLEXPRESS;database=Orders;Integrated Security=True";

                    String query = "INSERT INTO MacOrders (Number_Of_Burgers, Number_Of_Chips, Number_Of_Nuggets, Number_Of_Drinks, TotalPrice) VALUES(@numBurgers,@numChips,@numNuggets,@numDrinks,@totalCost)";


                    SqlConnection con = new SqlConnection(str);
 
                    SqlCommand cmd = new SqlCommand(query, con);


                    // AddWithValue avoid SQL Injection
                    cmd.Parameters.AddWithValue("@numBurgers", Convert.ToInt32(numBurgers));
                    cmd.Parameters.AddWithValue("@numChips", Convert.ToInt32(numChips));
                    cmd.Parameters.AddWithValue("@numNuggets", Convert.ToInt32(numNuggets));
                    cmd.Parameters.AddWithValue("@numDrinks", Convert.ToInt32(numDrinks));
                    cmd.Parameters.AddWithValue("@totalCost", Convert.ToInt32(getTotal()));
                    con.Open();

                    MessageBox.Show("Connecting with sql server...");


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Success!");


                    con.Close();

                }

                catch (Exception es)

                {
                    MessageBox.Show(es.Message);
                }




            }
    
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            numericUpDownBurgers.Value = 0;
            numericUpDownChips.Value = 0;
            numericUpDownNuggets.Value = 0;
            numericUpDownDrinks.Value = 0;
        }

        private void numericUpDownBurgers_ValueChanged(object sender, EventArgs e)
        {
            label_cost.Text = "Total: R" + getTotal();
        }

        private void numericUpDownChips_ValueChanged(object sender, EventArgs e)
        {
            label_cost.Text = "Total: R" + getTotal();

        }

        private void numericUpDownNuggets_ValueChanged(object sender, EventArgs e)
        {
            label_cost.Text = "Total: R" + getTotal();

        }

        private void numericUpDownDrinks_ValueChanged(object sender, EventArgs e)
        {
            label_cost.Text = "Total: R" + getTotal();

        }

        public ulong getTotal()
        {
            ulong cost = 0;

            cost += (ulong)numericUpDownBurgers.Value * 35;
            cost += (ulong)numericUpDownChips.Value * 15;
            cost += (ulong)numericUpDownNuggets.Value * 25;
            cost += (ulong)numericUpDownDrinks.Value * 20;

            return cost;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

    }

}
