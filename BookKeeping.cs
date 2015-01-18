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
    public partial class BookKeeping : Form
    {
        String cardNo;
        MySqlConnection con;
        public BookKeeping()
        {
            InitializeComponent();
        }
        private bool cardNoValidator()
        {
            bool cardNoFound = true;
            cardNo = txtCardNo.Text;
            MySqlCommand cardNoValidation = new MySqlCommand("select count(*) from book_history where card_no = '" + cardNo + "'", con);
            using (MySqlDataReader reader = cardNoValidation.ExecuteReader())
            {
                reader.Read();
                if (Convert.ToInt32(reader[0].ToString()) > 0)
                {
                    Console.WriteLine("Card Number Found in History");
                }
                else
                {
                    MessageBox.Show("Given Card no does not exist in History , So please enter valid Card No ");
                    cardNoFound = false;
                }

            }
            Console.WriteLine(cardNoFound);
            return cardNoFound;
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
        private void btnModify_Click(object sender, EventArgs e)
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
                        Console.WriteLine("select book_id,card_no,date_out,date_in from book_history where card_no = '" + cardNo + "';");
                        using (MySqlDataAdapter borrowerDetails = new MySqlDataAdapter("select book_id,card_no,date_out,date_in from book_history where card_no = '" + cardNo + "';", con))
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

        private void BookKeeping_Load(object sender, EventArgs e)
        {

        }
    }
}
