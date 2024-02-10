using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using BLL;
using NadLan;

namespace DAL
{
    public class PropertyDal
    {
        public static List<Property> GetProperty()
        {
            List<Property> lstProperty = new List<Property>();
            string sql = "select * from Property";
            DbContext db = new DbContext();
            DataTable DT = db.Excute(sql);
            db.Close();
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                Property tmp = new Property()
                {
                    Pid=int.Parse(DT.Rows[i]["Pid"]+""),
                    Aid = int.Parse(DT.Rows[i]["Aid"] + ""),
                    Pname = DT.Rows[i]["Pname"] + "",
                   RoomNumber = int.Parse(DT.Rows[i]["RoomNumber"] + ""),
                    PFloor = int.Parse(DT.Rows[i]["PFloor"] + ""),
                    PAddress = DT.Rows[i]["PAddress"] + "",
                   City = DT.Rows[i]["City"] + "",
                   Area = DT.Rows[i]["Area"] + "",
                   TypeDeal = DT.Rows[i]["TypeDeal"] + "",
                   PriceReq = int.Parse(DT.Rows[i]["PriceReq"] + ""),
                   Pic = DT.Rows[i]["Pic"] + ""


                };
                lstProperty.Add(tmp);
            }
            return lstProperty;
        }
        public static Property GetPropById(int id)
        {
            DbContext db = new DbContext();
            string sql = $"Select * from Property where Pid={id}";
            DataTable DT;
            DT = db.Excute(sql);
            db.Close();
            Property newProp = null;
            if (DT.Rows.Count > 0)
            {
                newProp = new Property()
                {
                    Pid = int.Parse(DT.Rows[0]["Pid"] + ""),
                    Aid = int.Parse(DT.Rows[0]["Aid"] + ""),
                    Pname = DT.Rows[0]["Pname"] + "",
                    RoomNumber = int.Parse(DT.Rows[0]["RoomNumber"] + ""),
                    PFloor = int.Parse(DT.Rows[0]["PFloor"] + ""),
                    PAddress = DT.Rows[0]["PAddress"] + "",
                    City = DT.Rows[0]["City"] + "",
                    Area = DT.Rows[0]["Area"] + "",
                    TypeDeal = DT.Rows[0]["TypeDeal"] + "",
                    PriceReq = int.Parse(DT.Rows[0]["PriceReq"] + ""),
                    Pic = DT.Rows[0]["Pic"] + ""
                };
            }
            return newProp;
        }
        public static void SaveProperty(Property newProp)
        {
            DbContext db = new DbContext();

            string sql;
            if (newProp.Pid == 0)
            {
                sql = $"insert into Property(Aid,Pname,RoomNumber,PFloor,PAddress,City,Area,TypeDeal,PriceReq,Pic) values({newProp.Aid},N'{newProp.Pname}',{newProp.RoomNumber},{newProp.PFloor},N'{newProp.PAddress}',N'{newProp.City}',{newProp.Area},N'{newProp.TypeDeal}',{newProp.PriceReq},N'{newProp.Pic}')";
            }
            else
            {
                sql = $"update Property set Pname=N'{newProp.Pname}',RoomNumber={newProp.RoomNumber},PFloor={newProp.PFloor},PAddress=N'{newProp.PAddress}',City=N'{newProp.City}',Area={newProp.Area},TypeDeal=N'{newProp.TypeDeal}',PriceReq={newProp.PriceReq},Pic=N'{newProp.Pic}' where Pid={newProp.Pid}";
            }


            db.ExcutenonQuery(sql);

            if (newProp.Pid == 0)
            {
                sql = $"select * from Property where Aid={newProp.Aid}";
                db.Close();
                DataTable dt;
                dt = db.Excute(sql);
                db.Close();
                if (dt.Rows.Count > 0)
                {
                    newProp.Pid = int.Parse(dt.Rows[0]["Pid"] + "");
                }
            }




        }
        public static bool RemovePropById(int id)
        {
            DbContext db = new DbContext();
            string sql = $"delete from Property where Pid={id}";

            int rowEffected = db.ExcutenonQuery(sql);
            db.Close();
            return rowEffected > 0;
        }
        public static bool CheckLogin(Property newProp)
        {
            DbContext db = new DbContext();
         
            string sql = $"select * from Property where ";
            DataTable dt = db.Excute(sql);
            db.Close();
            if (dt.Rows.Count > 0)
            {
                newProp.Pid = int.Parse(dt.Rows[0]["Pid"] + "");

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}