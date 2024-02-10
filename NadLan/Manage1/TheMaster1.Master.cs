using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NadLan.Manage1
{
    public partial class TheMaster1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["aid"] + "" != "")
            {
                ltl.Text = $"<li class=\"nav - item dropdown\"><h4 class=\"nav - link dropdown - toggle\" id=\"navbarDropdown\" role=\"button\" data-bs-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"false\">ניהול</h4><div class=\"dropdown-menu\"><a class=\"dropdown-item \" href=\"AssetAddEdit.aspx\">הוספת נכס</a><a class=\"dropdown-item \" href=\"AssetsList.aspx\">נכסים</a></div></li>";
            }
        }
    }
}