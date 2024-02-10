using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace NadLan.Manage1
{
    public partial class AssetAddEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            droplist.Items.Add("למכירה");
            droplist.Items.Add("להשכרה");         
            if (!IsPostBack)
            {

                HiddenPid.Value = Request["Pid"] + "";
                if (HiddenPid.Value != "")
                {
                   
                    int id = int.Parse(HiddenPid.Value);
                    Property newprop = Property.GetPropsById(id);           
                        Name.Text = newprop.Pname + "";
                        roomnumber.Text = newprop.RoomNumber + "";
                        Floor.Text = newprop.PFloor + "";
                        Address.Text = newprop.PAddress + "";
                        City.Text = newprop.City + "";
                        Area.Text = newprop.Area + "";
                        Price.Text = newprop.PriceReq + "";
                       ltl.Text=$"<img src=\"/Uploade/Pics/{newprop.Pic}\" class=\"img-a img-fluid\">";
  
                }
                else
                {
                    HiddenPid.Value = "-1";

                }
            }
        }

        protected void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            Name.Visible = !checkbox.Checked;
            Price.Visible = !checkbox.Checked;
            uploade.Visible = !checkbox.Checked;
            roomnumber.Visible = !checkbox.Checked;
            Floor.Visible = !checkbox.Checked;
            Address.Visible = !checkbox.Visible;
            City.Visible = !checkbox.Checked;
            Area.Visible = !checkbox.Checked;
            droplist.Visible = !checkbox.Checked;
        }

        protected void Btn_Add_Click(object sender, EventArgs e)
        {
            string newfilename = GlubFunc.GetRandeomStr(10);
            string extension = Path.GetExtension(uploade.FileName);
            newfilename += extension;
            uploade.SaveAs(Server.MapPath("/Uploade/Pics/") + newfilename);
            Property newprop = new Property()
            {
               
                Aid = int.Parse(Session["aid"] + ""),
                Pname = Name.Text,
                RoomNumber = int.Parse(roomnumber.Text),
                PFloor = int.Parse(Floor.Text),
                PriceReq = int.Parse(Price.Text),
                Area = Area.Text,
                City = City.Text,
                PAddress = Address.Text,
                Pic =  newfilename,
                TypeDeal = droplist.SelectedValue

         
            };
            if (HiddenPid.Value != "-1")
            {
                newprop.Pid = int.Parse(HiddenPid.Value);
            }
            
            if (checkbox.Checked)
            {
                Property.RemovePropById(newprop.Pid);
                Response.Redirect("AssetsList.aspx");
            }
            newprop.SaveProperty();
            Response.Redirect("AssetsList.aspx");


        }
    }
}