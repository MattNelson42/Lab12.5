using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab12
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                lblError.Text = "Please enter valid search keyword!";
                return;
            }

            lblError.Text = string.Empty;

                var books = Books.GetBooks();

                var sortedBooks = from bookItem in books
                                  where bookItem.Title.Contains(txtSearch.Text)
                                  orderby bookItem.Price descending
                                  select bookItem;

                GridView1.DataSource = sortedBooks;
                GridView1.DataBind(); // must always call this after setting data source

        }
    }
}