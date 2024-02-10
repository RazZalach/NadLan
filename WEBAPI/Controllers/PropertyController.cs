using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft;
using BLL;
using Newtonsoft.Json;

namespace WEBAPI.Controllers
{
    public class PropertyController : ApiController
    {
        // GET: api/V1/Property
        public string Get()
        {
            List<Property> lstprop = Property.GetProperty();
            return JsonConvert.SerializeObject(lstprop);
        }

        // GET: api/V1/Property/5
        public string Get(int id)
        {
            Property newprop = Property.GetPropsById(id);
            return JsonConvert.SerializeObject(newprop);
        }

        // POST: api/V1/Property
        public string Post([FromBody]Property newprop)
        {
            newprop.SaveProperty();
            return JsonConvert.SerializeObject(newprop);
        }

        // PUT: api/V1/Property/5
        public string Put(int id, [FromBody]Property newprop)
        {
            newprop.Pid = id;
            newprop.SaveProperty();
            return JsonConvert.SerializeObject(newprop);
        }

        // DELETE: api/Property/5
        public string Delete(int id)
        {
            if (Property.RemovePropById(id))
            {
                return "Removed";
            }
            else
            {
                return "Not Removed";
            }
        }
    }
}
