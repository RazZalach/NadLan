using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NadLan.Manage1
{
    public partial class AssetsList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                FillData();
            }
        }
        public void FillData()
        {
            string Aid = Application["Aid"] + "";
            string sql = $"Select * from Property where Aid={Aid}";
            DbContext db = new DbContext();
            DataTable DT = db.Excute(sql);
            db.Close();
            rptprod.DataSource = DT;
            rptprod.DataBind();

        }
    }
}