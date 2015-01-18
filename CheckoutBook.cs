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
    public partial class CheckoutBook : Form
    {
        String bookId;
        String branchId;
        String cardNo;
        MySqlConnection con;
        Boolean flagCheckForCardNo = true;
        Boolean alreadyBookTaken = false;
        int no_of_books_left = 0;
        int no_of_books_lent = 0;
        public CheckoutBook()
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
        private void subCheckout_Click(object sender, EventArgs e)
        {
            flagCheckForCardNo = true;
            alreadyBookTaken = false;
            try
            {
                getConnection();
                if (txtBookId.Text == String.Empty)
                    MessageBox.Show("Please enter Book ID");
                else if (txtBranchId.Text == String.Empty)
                    MessageBox.Show("Please enter Branch ID");
                else if (txtCardNo.Text == String.Empty)
                    MessageBox.Show("Please enter Card NO");
                else
                {
                    bookId = txtBookId.Text;
                    branchId = txtBranchId.Text;
                    cardNo = txtCardNo.Text;
                   
                    MySqlCommand cardNoValidation = new MySqlCommand("select count(*) from borrower where card_no = '"+ cardNo +"'", con);
                    using (MySqlDataReader reader = cardNoValidation.ExecuteReader())
                    {
                        reader.Read();
                        if (Convert.ToInt32(reader[0].ToString()) > 0)
                        {
                            Console.WriteLine("Card Number Found");
                            flagCheckForCardNo = false;
                        }

                        else
                            MessageBox.Show("Given Card no does not exist , So please enter valid Card No ");
                    }
                    if (!flagCheckForCardNo)
                    {
                        MySqlCommand duplicateBook = new MySqlCommand("select count(*) from book_loans where card_no = '" + cardNo + "' and book_id = '" + bookId + "' and branch_id = " + branchId + "", con);
                        using (MySqlDataReader reader = duplicateBook.ExecuteReader())
                        {
                            reader.Read();
                            if (Convert.ToInt32(reader[0].ToString()) > 0){
                                MessageBox.Show("You have already taken the same book from the same branch");
                                alreadyBookTaken = true;

                            }
                                
                            else
                                Console.WriteLine("Book is not taken already");
                        }

                        MySqlCommand cardNoCount = new MySqlCommand("select count(*) from book_loans where card_no = '" + cardNo + "'", con);
                        using (MySqlDataReader reader = cardNoCount.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                no_of_books_lent = Convert.ToInt32(reader[0].ToString());
                                Console.WriteLine("no_of_books_lent : " + no_of_books_lent);
                            }
                        }
                        if(!alreadyBookTaken)
                        {
                            if (no_of_books_lent >= 0 && no_of_books_lent < 3)
                            {
                                Console.WriteLine("select g.copies_available from (select b.no_of_copies - (select count(*) from book_loans l where l.book_id = '" + bookId + "' and l.branch_id = " + branchId + ") as copies_available from book_copies b where book_id = '" + bookId + "' and branch_id = " + branchId + ") as g;");
                                MySqlCommand bookAvailability = new MySqlCommand("select g.copies_available from (select b.no_of_copies - (select count(*) from book_loans l where l.book_id = '" + bookId + "' and l.branch_id = " + branchId + ") as copies_available from book_copies b where book_id = '" + bookId + "' and branch_id = " + branchId + ") as g;", con);
                                using (MySqlDataReader reader = bookAvailability.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        no_of_books_left = reader.GetInt32(0);
                                        Console.WriteLine("Available - checked out : " + no_of_books_left);
                                        if (no_of_books_left > 0)
                                        {
                                            reader.Close();
                                            checkoutBook();

                                        }
                                        else
                                            MessageBox.Show("Book with id : " + bookId + " is no more available in the branch ID : " + branchId + "\nKindly select another branch");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Maximum of only 3 books are allowed for each Borrower, Sorry for the inconvenience caused");
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
                Console.WriteLine("Connection closed");
                no_of_books_left = 0;
                no_of_books_lent = 0;
            }
        }
        private void checkoutBook()
        {
            MySqlCommand insertIntoLoan = con.CreateCommand();
            insertIntoLoan.CommandText = "insert into book_loans values('" + bookId + "'," + branchId + ",'" + cardNo + "',CURDATE(),DATE_ADD(CURDATE(), INTERVAL 14 DAY))";
            insertIntoLoan.ExecuteNonQuery();
            MessageBox.Show("Book Details \n" + "Book ID : " + bookId + " has been checked my the Borrower with card no : " + cardNo + " for 14 days from today");
                                
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     }
}
