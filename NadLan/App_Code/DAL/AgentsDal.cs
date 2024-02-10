using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using BLL;
using NadLan;

namespace DAL
{
    public class AgentsDal
    {
        public static List<Agents> GetAgents()
        {
            List<Agents> lstAgents = new List<Agents>();
            string sql = "select * from Agents";
            DbContext db = new DbContext();
            DataTable DT = db.Excute(sql);
            db.Close();
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                Agents tmp = new Agents()
                {
                    Aid = int.Parse(DT.Rows[i]["Aid"] + ""),
                    Aname = DT.Rows[i]["Aname"] + "",
                    Alname = DT.Rows[i]["Alname"] + "",
                    AgentId = DT.Rows[i]["AgentId"] + "",
                    Aaddress=DT.Rows[i]["Aaddress"]+"",
                    Aphone=DT.Rows[i]["Aphone"]+"",
                    Apassword=DT.Rows[i]["Apassword"]+""

                };
                lstAgents.Add(tmp);
            }
            return lstAgents;
        }
        public static Agents GetAgentById(int id)
        {
            DbContext db = new DbContext();
            string sql = $"Select * from Agents where Aid={id}";
            DataTable dt;
            dt = db.Excute(sql);
            db.Close();
            Agents newAgent = null;
            if (dt.Rows.Count > 0)
            {
                newAgent = new Agents()
                {
                 Aid = int.Parse(dt.Rows[0]["Aid"] + ""),
                    Aname = dt.Rows[0]["Aname"] + "",
                    Alname = dt.Rows[0]["Alname"] + "",
                    AgentId = dt.Rows[0]["AgentId"] + "",
                    Aaddress= dt.Rows[0]["Aaddress"]+"",
                    Aphone= dt.Rows[0]["Aphone"]+"",
                    Apassword=dt.Rows[0]["Apassword"]+""
                };
            }
            return newAgent;
        }
        public static void SaveAgent(Agents newAgent)
        {
            DbContext db = new DbContext();
          
            string sql;
            if (newAgent.Aid == 0)
            {
                sql = $"insert into Agents(Aname,Alname,AgentId,Aaddress,Aphone,Apassword) values(N'{newAgent.Aname}',N'{newAgent.Alname}','{newAgent.AgentId}',N'{newAgent.Aaddress}','{newAgent.Aphone}',N'{newAgent.Apassword}')";
             
                //insert into Agents(Aname,Alname,AgentId,Aaddress,Aphone,Apassword) 
               // values(N'סימון', N'זילברמן', '354678223', N'אשדוד קיבוץ גלויות 14', '0507145967', N'123')
            }
            else
            {
                sql = $"update Agents set Aname=N'{newAgent.Aname}',Alname=N'{newAgent.Alname}',AgentId='{newAgent.AgentId}',Aphone='{newAgent.Aphone}',Aaddress=N'{newAgent.Aaddress}',Apassword=N'{newAgent.Apassword}' where Aid={newAgent.Aid}";
            }


            db.ExcutenonQuery(sql);

            if (newAgent.Aid == 0)
            {
                sql = $"Select * from Agents where Aname=N'{newAgent.Aname}'";
                db.Close();
                DataTable dt;
                dt = db.Excute(sql);
                db.Close();
                if (dt.Rows.Count > 0)
                {
                    newAgent.Aid = int.Parse(dt.Rows[0]["Aid"] + "");
                }
            }




        }
        public static bool RemoveAgentById(int id)
        {
            DbContext db = new DbContext();
            string sql = $"delete from Agents where Aid={id}";

            int rowEffected = db.ExcutenonQuery(sql);
            db.Close();
            return rowEffected > 0;
        }
        public static bool CheckLogin(Agents newAgent)
        {
            DbContext db = new DbContext();        
            string sql = $"select * from Agents where AgentId='{newAgent.AgentId}' and Apassword=N'{newAgent.Apassword}'";
            DataTable dt = db.Excute(sql);
            db.Close();
            if (dt.Rows.Count > 0)
            {
                newAgent.Aid = int.Parse(dt.Rows[0]["Aid"] + "");

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}