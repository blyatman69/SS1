using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite.MySql;

namespace SS1
{
    public class Person
    {
        [AutoIncrement]
        public int ID { get; set; }
        public String name { get; set; }
    }
}