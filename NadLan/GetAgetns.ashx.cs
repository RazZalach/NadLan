using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft;
using BLL;
using Newtonsoft.Json;


namespace NadLan
{
    /// <summary>
    /// Summary description for GetAgetns
    /// </summary>
    public class GetAgetns : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            List<Agents> Lstagents = Agents.GetAgents();
            string str = JsonConvert.SerializeObject(Lstagents);
            context.Response.ContentType = "text/plain";
            context.Response.Write(str);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}