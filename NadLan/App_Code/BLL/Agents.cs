using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class Agents
    {
        public int Aid { get; set; }
        public string Aname { get; set; }
        public string Alname { get; set; }
        public string AgentId { get; set; }
        public string Aaddress { get; set; }
        public string Aphone { get; set; }
        public string Apassword { get; set; }
        public static List<Agents> GetAgents()
        {

            return AgentsDal.GetAgents();
        }
        public static Agents GetAgentsById(int id)
        {
            return AgentsDal.GetAgentById(id);
        }
        public void SaveAgent()
        {
            AgentsDal.SaveAgent(this);
        }
        public static bool RemoveUserById(int id)
        {
            return AgentsDal.RemoveAgentById(id);
        }

        public bool CheckLogin()
        {
            return AgentsDal.CheckLogin(this);
        }

    }
}