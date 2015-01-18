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
    public partial class BookSearch : Form
    {
        MySqlConnection con;
        String bookId;
        String title;
        String queryString;
        String authorName;
        public BookSearch()
        {
            InitializeComponent();
        }
        private void getConnection() {
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
        private void BookSearch_Load(object sender, EventArgs e) {
           
        }

        private void subSearch_Click(object sender, EventArgs e)
        {

            if (txtBookId.Text == String.Empty && txtTitle.Text == String.Empty)
                MessageBox.Show("Please enter BookId/Title");
            else if (txtBookId.Text != String.Empty && txtTitle.Text == String.Empty)
            {
                bookId = txtBookId.Text;
                if (txtAuthor.Text != String.Empty)
                    authorName = txtAuthor.Text;
                String noAuthorQuery = "select * from ((select b.book_id as BOOK_ID ,b.title as BOOK_TITLE,r.Branch_id as BRANCH_ID,r.Branch_name as BRANCH_NAME,c.No_of_copies as TOTAL_NO_OF_COPIES ,count(*) as LENT_COPIES,(c.No_of_copies - count(*)) as AVAILABLE_COPIES from book b natural join book_copies c natural join library_branch r natural join book_loans l where b.book_id = '" + bookId + "' group by r.Branch_id) union (select b.book_id as BOOK_ID ,b.title as BOOK_TITLE,r.Branch_id as BRANCH_ID,r.Branch_name as BRANCH_NAME,c.No_of_copies as TOTAL_NO_OF_COPIES ,0 as LENT_COPIES,c.No_of_copies as AVAILABLE_COPIES from book b natural join book_copies c natural join library_branch r where b.book_id = '" + bookId + "' and ((r.branch_id) not in (select r.Branch_id from book b natural join book_copies c natural join library_branch r natural join book_loans l where b.book_id = '" + bookId + "')) group by r.Branch_id)) as t order by t.BRANCH_ID;";
                String authorQuery = "select * from ((select b.book_id as BOOK_ID ,b.title as BOOK_TITLE,r.Branch_id as BRANCH_ID,r.Branch_name as BRANCH_NAME,c.No_of_copies as TOTAL_NO_OF_COPIES ,count(*) as LENT_COPIES,(c.No_of_copies - count(*)) as AVAILABLE_COPIES from book b natural join book_authors a natural join book_copies c natural join library_branch r natural join book_loans l where b.book_id = '" + bookId + "' and a.author_name like '%" + authorName + "%' group by r.Branch_id) union (select b.book_id as BOOK_ID ,b.title as BOOK_TITLE,r.Branch_id as BRANCH_ID,r.Branch_name as BRANCH_NAME,c.No_of_copies as TOTAL_NO_OF_COPIES ,0 as LENT_COPIES,c.No_of_copies as AVAILABLE_COPIES from book b natural join book_authors a natural join book_copies c natural join library_branch r where b.book_id = '" + bookId + "' and a.author_name like '%" + authorName + "%' and ((r.branch_id,b.book_id) not in (select r.Branch_id,b.book_id from book b natural join book_authors a natural join book_copies c natural join library_branch r natural join book_loans l where b.book_id = '" + bookId + "' and a.author_name like '%" + authorName + "%')) group by r.Branch_id)) as t order by t.BRANCH_ID;";
                queryString = (txtAuthor.Text == String.Empty) ? noAuthorQuery : authorQuery;
                Console.WriteLine(queryString);
                queryExecutor(queryString);
            }
            else if (txtTitle.Text != String.Empty && txtBookId.Text == String.Empty)
            {
                title = txtTitle.Text;
                if (txtAuthor.Text != String.Empty)
                    authorName = txtAuthor.Text;
                String noAuthorQuery = "select * from ((select b.book_id as BOOK_ID ,b.title as BOOK_TITLE,r.Branch_id as BRANCH_ID,r.Branch_name as BRANCH_NAME,c.No_of_copies as TOTAL_NO_OF_COPIES ,count(*) as LENT_COPIES,(c.No_of_copies - count(*)) as AVAILABLE_COPIES from book b natural join book_copies c natural join library_branch r natural join book_loans l where b.title like '%" + title + "%' group by b.title,r.Branch_id) union (select b.book_id as BOOK_ID ,b.title as BOOK_TITLE,r.Branch_id as BRANCH_ID,r.Branch_name as BRANCH_NAME,c.No_of_copies as TOTAL_NO_OF_COPIES ,0 as LENT_COPIES,c.No_of_copies as AVAILABLE_COPIES from book b natural join book_copies c natural join library_branch r where b.title like '%" + title + "%' and ((r.branch_id,b.title) not in (select r.Branch_id,b.title from book b natural join book_copies c natural join library_branch r natural join book_loans l where b.title like '%" + title + "%')) group by b.title,r.Branch_id)) as t order by t.BOOK_TITLE,t.BRANCH_ID;";
                String authorQuery = "select * from ((select b.book_id as BOOK_ID ,b.title as BOOK_TITLE,r.Branch_id as BRANCH_ID,r.Branch_name as BRANCH_NAME,c.No_of_copies as TOTAL_NO_OF_COPIES ,count(*) as LENT_COPIES,(c.No_of_copies - count(*)) as AVAILABLE_COPIES from book b natural join book_authors a natural join book_copies c natural join library_branch r natural join book_loans l where b.title like '%" + title + "%' and a.author_name like '%" + authorName + "%' group by b.title ,r.Branch_id) union (select b.book_id as BOOK_ID ,b.title as BOOK_TITLE,r.Branch_id as BRANCH_ID,r.Branch_name as BRANCH_NAME,c.No_of_copies as TOTAL_NO_OF_COPIES ,0 as LENT_COPIES,c.No_of_copies as AVAILABLE_COPIES from book b natural join book_authors a natural join book_copies c natural join library_branch r where b.title like '%" + title + "%' and a.author_name like '%" + authorName + "%' and ((r.branch_id,b.title) not in (select r.Branch_id,b.title from book b natural join book_authors a natural join book_copies c natural join library_branch r natural join book_loans l where b.title like '%" + title + "%' and a.author_name like '%" + authorName + "%')) group by b.title,r.Branch_id)) as t order by t.BOOK_TITLE,t.BRANCH_ID;";
                queryString = (txtAuthor.Text == String.Empty) ? noAuthorQuery : authorQuery;
                Console.WriteLine(queryString);
                queryExecutor(queryString);
            }
                
            else {
                bookId = txtBookId.Text;
                title = txtTitle.Text;
                if (txtAuthor.Text != String.Empty)
                    authorName = txtAuthor.Text;
                String noAuthorQuery = "select * from ((select b.book_id as BOOK_ID ,b.title as BOOK_TITLE,r.Branch_id as BRANCH_ID,r.Branch_name as BRANCH_NAME,c.No_of_copies as TOTAL_NO_OF_COPIES ,count(*) as LENT_COPIES,(c.No_of_copies - count(*)) as AVAILABLE_COPIES from book b natural join book_copies c natural join library_branch r natural join book_loans l where b.book_id = '" + bookId + "' and b.title like '%" + title + "%' group by r.Branch_id) union (select b.book_id as BOOK_ID ,b.title as BOOK_TITLE,r.Branch_id as BRANCH_ID,r.Branch_name as BRANCH_NAME,c.No_of_copies as TOTAL_NO_OF_COPIES ,0 as LENT_COPIES,c.No_of_copies as AVAILABLE_COPIES from book b natural join book_copies c natural join library_branch r where b.book_id = '" + bookId + "' and b.title like '%" + title + "%' and ((r.branch_id,b.title) not in (select r.Branch_id,b.title from book b natural join book_copies c natural join library_branch r natural join book_loans l where b.book_id = '" + bookId + "' and b.title like '%" + title + "%')) group by r.Branch_id))as t order by t.BRANCH_ID;";
                String authorQuery = "select * from ((select b.book_id as BOOK_ID ,b.title as BOOK_TITLE,r.Branch_id as BRANCH_ID,r.Branch_name as BRANCH_NAME,c.No_of_copies as TOTAL_NO_OF_COPIES ,count(*) as LENT_COPIES,(c.No_of_copies - count(*)) as AVAILABLE_COPIES from book b natural join book_authors a natural join book_copies c natural join library_branch r natural join book_loans l where b.book_id = '" + bookId + "' and b.title like '%" + title + "%' and a.author_name like '%" + authorName + "%' group by r.Branch_id) union (select b.book_id as BOOK_ID ,b.title as BOOK_TITLE,r.Branch_id as BRANCH_ID,r.Branch_name as BRANCH_NAME,c.No_of_copies as TOTAL_NO_OF_COPIES ,0 as LENT_COPIES,c.No_of_copies as AVAILABLE_COPIES from book b natural join book_authors a natural join book_copies c natural join library_branch r where b.book_id = '" + bookId + "' and b.title like '%" + title + "%' and a.author_name like '%" + authorName + "%' and ((r.branch_id,b.title) not in (select r.Branch_id,b.title from book b natural join book_authors a natural join book_copies c natural join library_branch r natural join book_loans l where b.book_id = '" + bookId + "' and b.title like '%" + title + "%' and a.author_name like '%" + authorName + "%')) group by r.Branch_id))as t order by t.BRANCH_ID;";
                queryString =  (txtAuthor.Text == String.Empty) ?  noAuthorQuery : authorQuery;
                Console.WriteLine(queryString);
                queryExecutor(queryString);
            }
            
        }

        private void dgBookSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row =  dgBookSearch.Rows[e.RowIndex];
            MessageBox.Show(row.Cells[1].Value + " " + row.Cells[2].Value + " " + row.Cells[3].Value);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void queryExecutor(String queryString){
                try {
                getConnection();
                using (MySqlDataAdapter bookIdAdapter = new MySqlDataAdapter(
                queryString, con))
                {
                    // 3
                    // Use DataAdapter to fill DataTable
                    // Form2 fm = new Form2();
                    DataTable bookIdData = new DataTable();
                    bookIdAdapter.Fill(bookIdData);
                    Control[] ctrls = this.Controls.Find("dgBookSearch", false);
                    if (ctrls.Length > 0)
                    {
                        DataGridView dgBookSearch = (DataGridView)ctrls[0];
                        dgBookSearch.DataSource = bookIdData;
                        dgBookSearch.Visible = true;
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
    }
}
