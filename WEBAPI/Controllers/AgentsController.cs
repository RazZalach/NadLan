using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Newtonsoft.Json;

namespace WEBAPI.Controllers
{
    public class AgentsController : ApiController
    {
        // GET: api/V1/Agents
        public string Get()
        {
            List<Agents> lstagent = Agents.GetAgents();
            return JsonConvert.SerializeObject(lstagent);
        }

        // GET: api/V1/Agents/5
        public string Get(int id)
        {
            Agents newAgent = Agents.GetAgentsById(id);
            return JsonConvert.SerializeObject(newAgent);
        }

        // POST: api/V1/Agents
        public string Post([FromBody] Agents newagent)
        {
            newagent.Apassword = Hash.ComputeSha256Hash(newagent.Apassword);
            newagent.SaveAgent();
            return JsonConvert.SerializeObject(newagent);
        }

        // PUT: api/V1/Agents/5
        public string Put(int id, [FromBody] Agents newagent)
        {
            newagent.Apassword = Hash.ComputeSha256Hash(newagent.Apassword);
            newagent.Aid = id;
            newagent.SaveAgent();
            return JsonConvert.SerializeObject(newagent);
        }

        // DELETE: api/V1/Agents/5
        public string Delete(int id)
        {
            if (Agents.RemoveUserById(id))
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
