using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.OrmLite;

namespace SS1
{
    public class Data
    {
        System.Data.IDbConnection _dbConnection;

        public Data(System.Data.IDbConnection dbConnection)
        {
            dbConnection = dbConnection;
        }

        public int addPerson(Person p)
        {
            return (int)_dbConnection.Insert<Person>(p, selectIdentity: true);
        }
        public List<Person> GetPeopleList()
        {
            return _dbConnection.Select<Person>();
        }
        public Person GetPersonById(int id)
        {
            return _dbConnection.SingleById<Person>(id);
        }
        public Person UpdatePerson(Person p)
        {
            _dbConnection.Update<Person>(p);
            return p;
        }
        public int DeletePersonByID(int id)
        {
            return _dbConnection.Delete(id);
        }
    }

}