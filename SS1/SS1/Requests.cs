using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SS1
{
    [Route("/Person", Verbs = "GET")]
    public class Requests
    {
        public class GetPeopleRequest { }
        [Route("/Person", Verbs = "POST")]
        public class PersonRequest
        {
            public int ID { get; set; }
            public String name { get; set; }

        }
        [Route("/Person/{PersonID}", Verbs = "GET,DELETE")]
        public class PersonIDRequest
        {
            public int ID { get; set; }


        }
    }
}