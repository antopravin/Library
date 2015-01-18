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
    public partial class CheckinBooks : Form
    {
        MySqlConnection con;
       // String branchId;
        String bookId;
        String cardNo;
        String branchId;
        String firstName;
        String lastName;
        String queryString;
        String errorMessage;
        DateTime date_out;
        public CheckinBooks()
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
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtBookId.Text.Equals(String.Empty) && txtCardNo.Text.Equals(String.Empty) )
                MessageBox.Show("Please Enter BookID or Card No to check in");
            else if (txtBookId.Text != String.Empty && txtCardNo.Text.Equals(String.Empty)){
                bookId = txtBookId.Text;
                firstName = txtBorrowerFirstName.Text;
                lastName = txtBorrowerLastName.Text;
                queryString = "Select book_id,card_no,branch_id,date_out from book_loans natural join borrower where book_id = '" + bookId + "'";
                errorMessage = "Book with book id : "+ bookId +" is not checked in yet";
                if (!firstName.Equals(String.Empty))
                {
                    queryString += "and fname like'%" + firstName + "%'";
                    errorMessage += ", \nor Borrower's First Name is wrong";
                }
                if (!lastName.Equals(String.Empty))
                {
                    queryString += "and lname like '%" + lastName + "%'";
                    errorMessage += ", \nor Borrower's Last Name is wrong";
                }
                queryString += ";";
                errorMessage += ", \nSo kindly enter valid details.";
                Console.WriteLine(queryString);
                queryExecutor(queryString,errorMessage);
        }
            else if (txtCardNo.Text != String.Empty && txtBookId.Text.Equals(String.Empty)){
                cardNo = txtCardNo.Text;
                firstName = txtBorrowerFirstName.Text;
                lastName = txtBorrowerLastName.Text;
                queryString = "Select book_id,card_no,branch_id,date_out from book_loans natural join borrower where card_no = '" + cardNo + "'";
                errorMessage = "Borrower with card number : " + cardNo + " hasn't checked in any book yet";
                 if (!firstName.Equals(String.Empty))
                {
                    queryString += "and fname like'%" + firstName + "%'";
                    errorMessage += ", \nor Borrower's First Name is wrong";
                }
                if (!lastName.Equals(String.Empty))
                {
                    queryString += "and lname like '%" + lastName + "%'";
                    errorMessage += ", \nor Borrower's Last Name is wrong";
                }
                queryString += ";";
                errorMessage += ", \nSo kindly enter valid details";
                Console.WriteLine(queryString);
                queryExecutor(queryString,errorMessage);
            }
            else
            {
                bookId = txtBookId.Text;
                cardNo = txtCardNo.Text;
                firstName = txtBorrowerFirstName.Text;
                lastName = txtBorrowerLastName.Text;
                queryString = "Select book_id,card_no,branch_id,date_out from book_loans natural join borrower where book_id = '" + bookId + "' and card_no = '" + cardNo + "'";
                errorMessage = "Book with book id : " + bookId + " is not checked in by the Borrower with card number : " + cardNo;
                if (!firstName.Equals(String.Empty))
                {
                    queryString += "and fname like'%" + firstName + "%'";
                    errorMessage += ", \nor Borrower's First Name is wrong";
                }
                if (!lastName.Equals(String.Empty))
                {
                    queryString += "and lname like '%" + lastName + "%'";
                    errorMessage += ", \nor Borrower's Last Name is wrong";
                }
                queryString += ";";
                errorMessage += ", \nSo kindly enter valid details";
                Console.WriteLine(queryString);
                queryExecutor(queryString, errorMessage);
            }
            
        }
        private void queryExecutor(String queryString,String errorMessage)
        {
            try
            {
                getConnection();
                using (MySqlDataAdapter booksToCheckIn = new MySqlDataAdapter(
                queryString, con))
                {
                    // 3
                    // Use DataAdapter to fill DataTable
                    // Form2 fm = new Form2();
                    DataTable bookCheckInData = new DataTable();
                    booksToCheckIn.Fill(bookCheckInData);
                    Control[] ctrls = this.Controls.Find("dgCheckInBooks", false);
                        if (ctrls.Length > 0)
                        {
                            DataGridView dgBookSearch = (DataGridView)ctrls[0];
                            dgBookSearch.DataSource = bookCheckInData;
                            Console.WriteLine("dgBookSearch.Rows.Count : " + dgBookSearch.Rows.Count + "--"+dgBookSearch.RowCount);                    
                            if (dgBookSearch.RowCount == 1)
                                MessageBox.Show(errorMessage);
                            else
                            {
                                dgBookSearch.Visible = true;
                                lbText.Visible = true;
                            }
                        }
                    // 4
                    // Render data onto the screen


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
        private void dgCheckInBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           DataGridViewRow row = dgCheckInBooks.Rows[e.RowIndex];
           bookId = row.Cells[0].Value.ToString();
           cardNo = row.Cells[1].Value.ToString();
           branchId = row.Cells[2].Value.ToString();
           try
           {
               getConnection();
               MySqlCommand insertIntoLoan = con.CreateCommand();
               bookKeeping();
               insertIntoLoan.CommandText = "Delete from book_loans where book_id = '" + bookId + "' and branch_id = " + branchId + " and card_no = '" + cardNo + "'";
               insertIntoLoan.ExecuteNonQuery();
               MessageBox.Show("Book Check in Details \n" + "Book ID : " + bookId + " taken from Branch ID : " + branchId + " has been checked in by the card no holder : " + cardNo + ".");
               dgCheckInBooks.Visible = false;
               lbText.Visible = false;

           }
           catch (FormatException fe) {
               Console.WriteLine("Format Exception" + fe.Message);
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
        private void bookKeeping()
        {
            MySqlCommand insertIntoLoan = con.CreateCommand();
            insertIntoLoan.CommandText = "insert into book_History select book_id,branch_id,card_no,date_out,curdate() from book_loans where card_no = '" + cardNo + "';";
            Console.WriteLine("insert into book_History select book_id,branch_id,card_no,date_out,curdate() from book_loans where card_no = '" + cardNo + "';");
            insertIntoLoan.ExecuteNonQuery();
           Console.WriteLine("Book Keeping \n" + "Book ID : " + bookId + " has been added to the history of Borrower with card no : " + cardNo);

        }
        private void lblBookid_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
