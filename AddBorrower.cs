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
    public partial class AddBorrower : Form
    {
        MySqlConnection con;
        String fname;
        String lname;
        String address;
        String phone;
        String cardNo;
        bool duplicate = false;
        public AddBorrower()
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
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lbCardNo.Visible = false;
                getConnection();
                if (txtFirstName .Text == String.Empty)
                    MessageBox.Show("Please enter First Name");
                else if (txtLastName.Text == String.Empty)
                    MessageBox.Show("Please enter Last Name");
                else if (txtAddress.Text == String.Empty)
                    MessageBox.Show("Please enter Address");
                else
                {
                    fname = txtFirstName.Text;
                    lname = txtLastName.Text;
                    address = txtAddress.Text;
                    MySqlCommand duplicateBorrower = new MySqlCommand("select * from borrower where fname = '" +fname  + "' and lname = '"+lname+"' and address = '"+address+"'", con);
                        using (MySqlDataReader reader = duplicateBorrower.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Borrower with \nfname = "+fname+" \nlname = "+lname+" \naddress = "+address+" \n already exist.\nAs per the norms of LMS only one card no is allowed for each borrower");
                                duplicate = true;
                            }
                        }
                        MySqlCommand carNoForBorrower = new MySqlCommand("select max(card_no)+1 from borrower ", con);
                        using (MySqlDataReader reader = carNoForBorrower.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cardNo = reader[0].ToString();
                            }
                        }
                    MySqlCommand insertIntoBorrower = con.CreateCommand();
                    if (!duplicate )
                    {
                        if (txtPhoneNo.Text == String.Empty)
                        {
                            //insertIntoBorrower.CommandText = "insert into borrower(card_no,fname,lname,address) (select max(card_no)+1,'"+fname+"','"+lname+"','"+address+"' from borrower);";
                            insertIntoBorrower.CommandText = "insert into borrower(card_no,fname,lname,address) values ('"+cardNo+"','" + fname + "','" + lname + "','" + address + "');";
                            insertIntoBorrower.ExecuteNonQuery();
                            MessageBox.Show("Borrower Details Added \nFirst Name : " + fname + " \nLast Name : " + lname + "\nAddress : "  + address);
                            lbCardNo.Text = "Kindly make a note of your card no : " + cardNo + "";
                            lbCardNo.Visible = true;
                        }
                        else
                        {
                            phone = txtPhoneNo.Text;
                            insertIntoBorrower.CommandText = "insert into borrower(card_no,fname,lname,address,phone) (select max(card_no)+1,'" + fname + "','" + lname + "','" + address + "','"+phone+"' from borrower);";
                            insertIntoBorrower.ExecuteNonQuery();
                            MessageBox.Show("Borrower Details Added \nFirst Name : " + fname + " \nLast Name : " + lname + "\nAddress : " + address + "\nPhone Number : " + phone);
                            lbCardNo.Text = "Kindly make a note of your card no : [" + cardNo + "]";
                            lbCardNo.Visible = true;
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
                Console.WriteLine("Connection closed");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
