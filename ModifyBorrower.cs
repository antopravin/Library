using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagementSystem
{
    public partial class ModifyBorrower : Form
    {
        MySqlConnection con;
        String cardNo;
        public ModifyBorrower()
        {
            InitializeComponent();
        }
        private void getConnection()
        {
            try
            {
                con = new MySqlConnection("server='localhost';database='Library';userid='root';password='Anto9489';");
                con.Open();
                Console.WriteLine("Connection sucessful");


            }
            catch (MySqlException mse)
            {
                Console.WriteLine("Connection error" + mse.Message);
            }
        }
        private bool cardNoValidator()
        {
            bool cardNoFound = true;
            cardNo = txtCardNo.Text;
            MySqlCommand cardNoValidation = new MySqlCommand("select count(*) from borrower where card_no = '" + cardNo + "'", con);
            using (MySqlDataReader reader = cardNoValidation.ExecuteReader())
            {
                reader.Read();
                if (Convert.ToInt32(reader[0].ToString()) > 0)
                {
                    Console.WriteLine("Card Number Found");
                }
                else
                {
                    MessageBox.Show("Given Card no does not exist , So please enter valid Card No ");
                    cardNoFound = false;
                }

            }
            Console.WriteLine(cardNoFound);
            return cardNoFound;
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                getConnection();
                DataGridViewRow row = dgBorrower.Rows[0];
                String fname = row.Cells[0].Value.ToString();
                String lname = row.Cells[1].Value.ToString();
                String address = row.Cells[2].Value.ToString();
                String phone = row.Cells[3].Value.ToString();
                Console.WriteLine(fname + lname + address + phone);
                MySqlCommand updateBorrower = con.CreateCommand();
                Console.WriteLine("Update Borrower set fname = '" + fname + "' , lname = '" + lname + "' , address = '" + address + "' , phone = '" + phone + "' where card_no = '" + cardNo + "';");
                updateBorrower.CommandText = "Update Borrower set fname = '" + fname + "' , lname = '" + lname + "' , address = '" + address + "' , phone = '" + phone + "' where card_no = '" + cardNo + "';";
                updateBorrower.ExecuteNonQuery();
                MessageBox.Show("Borrower details are updated for the card no : " + cardNo);
                dgBorrower.DataSource = null;

            }
            catch (MySqlException mse)
            {
                Console.WriteLine("Connection error" + mse.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                getConnection();
                DataGridViewRow row = dgBorrower.Rows[0];
                String fname = row.Cells[0].Value.ToString();
                String lname = row.Cells[1].Value.ToString();
                String address = row.Cells[2].Value.ToString();
                String phone = row.Cells[3].Value.ToString();
                Console.WriteLine(fname + lname + address + phone);
                MySqlCommand updateBorrower = con.CreateCommand();
                updateBorrower.CommandText = "Delete from  Borrower where card_no = '" + cardNo + "' and fname = '" + fname + "' and lname = '" + lname + "' and address = '" + address + "' and phone = '" + phone + "';";
                updateBorrower.ExecuteNonQuery();
                MessageBox.Show("Borrower with the card no : " + cardNo + " has been removed from the system");
                dgBorrower.DataSource = null;

            }
            catch (MySqlException mse)
            {
                Console.WriteLine("Connection error" + mse.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnModify_Click_1(object sender, EventArgs e)
        {
            try
            {
                getConnection();
                if (txtCardNo.Text == String.Empty)
                    MessageBox.Show("Please enter Card No");
                else
                {
                    if (cardNoValidator())
                    {
                        Console.WriteLine("select fname,lname,address,phone from borrower where card_no = '" + cardNo + "';");
                        using (MySqlDataAdapter borrowerDetails = new MySqlDataAdapter("select fname,lname,address,phone from borrower where card_no = '" + cardNo + "';", con))
                        {
                            Console.WriteLine("inif");
                            DataTable borrowerData = new DataTable();
                            borrowerDetails.Fill(borrowerData);
                            Control[] ctrls = this.pnlDisplay.Controls.Find("dgBorrower", false);
                            if (ctrls.Length > 0)
                            {
                                Console.WriteLine("inifif");
                                DataGridView dgBorrower = (DataGridView)ctrls[0];
                                dgBorrower.DataSource = borrowerData;
                                pnlDisplay.Visible = true;
                            }
                        }
                    }
                }
            }
            catch (MySqlException mse)
            {
                Console.WriteLine("Connection error" + mse.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void lbCardNo_Click(object sender, EventArgs e)
        {

        }

        private void txtCardNo_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
