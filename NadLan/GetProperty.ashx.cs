using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLL;
using Newtonsoft;
using Newtonsoft.Json;

namespace NadLan
{
    /// <summary>
    /// Summary description for GetProperty
    /// </summary>
    public class GetProperty : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            List<Property> LstProp = Property.GetProperty();
            string str = JsonConvert.SerializeObject(LstProp);
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