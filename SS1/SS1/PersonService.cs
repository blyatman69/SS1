using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using static SS1.Requests;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.MySql;
using ServiceStack.Data;


namespace SS1
{
    public class PersonService : Service
    {
        public List<Person> Get(GetPeopleRequest request)
        {
            Data D = new Data(Db);
            return D.GetPeopleList();
        }
        public int Post(PersonRequest request)
        {
            var p = new Person()
            {
                name = request.name

            };
            Data D = new Data(Db);
            return D.addPerson(p);
        }
        public void Delete(PersonIDRequest request)
        {
            Data D = new Data(Db);
            D.DeletePersonByID(request.ID);
        }
    }
}