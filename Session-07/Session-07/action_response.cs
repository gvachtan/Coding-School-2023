using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    public class ActionResponse
    {
        // properties
        public Guid RequestID { get; set; }
        public Guid ResponseID { get; set; }
        public string Output { get; set; }

        // constructor

        public ActionResponse(Guid requestId, Guid responseId, string output)
        {
            RequestID = requestId;
            ResponseID = responseId;
            Output = output;
        }
        public ActionResponse()
        {
            ResponseID = Guid.NewGuid();
        }
    }
}

