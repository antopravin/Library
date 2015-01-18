using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LMSMainForAdmin : Form
    {
        public LMSMainForAdmin()
        {
            InitializeComponent();
        }

        private void checkoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckoutBook checkoutBook = new CheckoutBook();
            checkoutBook.MdiParent = this;
            checkoutBook.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bookSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookSearch bookSearch = new BookSearch();
            bookSearch.MdiParent = this;
            bookSearch.Visible = true;
        }

        private void checkinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckinBooks checkInBooks = new CheckinBooks();
            checkInBooks.MdiParent = this;
            checkInBooks.Visible = true;
        }

        private void addBorrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBorrower addBorrower = new AddBorrower();
            addBorrower.MdiParent = this;
            addBorrower.Visible = true;
        }

        private void removeBorrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyBorrower removeBorrower = new ModifyBorrower();
            removeBorrower.Visible = true;
        }

        private void modifyBorrowerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ModifyBorrower editBorrower = new ModifyBorrower();
            editBorrower.MdiParent = this;
            editBorrower.Visible = true;
        }

        private void bookKeepingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookKeeping bookKeeping = new BookKeeping();
            bookKeeping.MdiParent = this;
            bookKeeping.Visible = true;
        }

    }
}
