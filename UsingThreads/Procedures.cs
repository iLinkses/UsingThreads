using System;
using System.Collections;
using System.Data;

namespace UsingThreads
{
    class Procedures
    {
        ArrayList ap = new ArrayList();
        internal DataTable GetPersons(DateTime DateStart, DateTime DateEnd)
        {
            /*А КАКОГО ХУАНХЭ НЕ РАБОТАЕТ С полем ap???*/
            //ArrayList apn = new ArrayList();
            ap.Clear();
            ap.Add(DateStart);
            ap.Add(DateEnd);
            return SQLConnection.ExecuteProcedure("[Thread].[GetAllPersons]",
                new string[] { "@DateStart", "@DateEnd" },
                new DbType[] { DbType.DateTime, DbType.DateTime }, ap);
        }
        internal DataTable GetStatus()
        {
            ap.Clear();
            return SQLConnection.ExecuteProcedure("[Thread].[GetStatus]",
                new string[] { },
                new DbType[] { }, ap);
        }
        internal DataTable GetDeps()
        {
            ap.Clear();
            return SQLConnection.ExecuteProcedure("[Thread].[GetDeps]",
                new string[] { },
                new DbType[] { }, ap);
        }
        internal DataTable GetPosts()
        {
            ap.Clear();
            return SQLConnection.ExecuteProcedure("[Thread].[GetPosts]",
                new string[] { },
                new DbType[] { }, ap);
        }
    }
}
