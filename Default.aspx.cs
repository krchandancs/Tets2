using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMatrix.WebData;
using WebMatrix.Data;

namespace SDFDB_Demo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                var db = Database.Open("User");
                var data = db.Query("SELECT * FROM tbUser");
            }
        }
    }
}