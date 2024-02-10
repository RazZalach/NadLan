using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace NadLan.Manage1
{
    public partial class AC : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["aid"] = "";
            AgentName.Visible = CheckBox1.Checked;
            AgentLname.Visible = CheckBox1.Checked;
            Address.Visible = CheckBox1.Checked;
            Phone.Visible = CheckBox1.Checked;
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            AgentName.Visible = CheckBox1.Checked;
            AgentLname.Visible = CheckBox1.Checked;
            Address.Visible = CheckBox1.Checked;
            Phone.Visible = CheckBox1.Checked;
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            if (!CheckBox1.Checked)
            {


                Agents a1 = new Agents()
                {
                    Aname = AgentName.Text,
                    Alname = AgentLname.Text,
                    AgentId = AgentId.Text,
                    Aaddress = Address.Text,
                    Aphone = Phone.Text,
                    Apassword = Hash.ComputeSha256Hash(passwor.Text)
                };
                if (a1.CheckLogin())
                {
                    Application["Aid"] = a1.Aid;
                    Session["aid"] = a1.Aid;
                    Response.Redirect("AssetsList.aspx");
                }
                else
                {
                    ltllog.Text = "שם משתמש או סיסמא לא נכונים ";
                }
            }
            else
            {


                Agents a1 = new Agents()
                {
                    Aname = AgentName.Text,
                    Alname = AgentLname.Text,
                    AgentId = AgentId.Text,
                    Aaddress = Address.Text,
                    Aphone = Phone.Text,
                    Apassword = Hash.ComputeSha256Hash(passwor.Text)
                };
                if (!a1.CheckLogin())
                {
                    a1.SaveAgent();

                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}