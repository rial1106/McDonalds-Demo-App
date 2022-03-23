using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace McDonalds
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btn_make_order_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form orderForm = new OrderForm();
            orderForm.Show();
        }

        private void btn_view_previous_Click(object sender, EventArgs e)
        {
            try

            {

                String str = "server=ML-RefVm-631348\\SQLEXPRESS;database=Orders;Integrated Security=True";

                String query = "select * from MacOrders";

                SqlConnection con = new SqlConnection(str);

                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();

                MessageBox.Show("Connecting with sql server...");
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MessageBoxButtons db_buttons = MessageBoxButtons.OKCancel;
                        String db_message = "ID: " + reader.GetInt32(0)
                        + "\nNumber of Burgers: " + reader.GetInt32(1)
                        + "\nNumber of Chips: " + reader.GetInt32(2)
                        + "\nNumber of Nuggets: " + reader.GetInt32(3)
                        + "\nNumber of Drinks: " + reader.GetInt32(4)
                        + "\nTotal Cost: " + reader.GetInt32(5);


                        DialogResult db_result = MessageBox.Show(db_message, "RESULTS", db_buttons);
                    }


                }


                con.Close();

            }

            catch (Exception es)

            {

                MessageBox.Show(es.Message);

            }
        }
    }
}
