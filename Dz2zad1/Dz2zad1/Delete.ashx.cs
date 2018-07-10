using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dz2zad1
{
    /// <summary>
    /// Summary description for Delete
    /// </summary>
    public class Delete : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            foreach (string VARIABLE in Show_users.list)
            {
                int id = Convert.ToInt32(VARIABLE);
                var Fin_id = Singleton.Instens.UsersList.Find(User => User.Id == id);
                if (Fin_id != null)
                {
                    Singleton.Instens.UsersList.Remove(Fin_id);
                }
            }
            context.Server.Transfer("Show_users.aspx");
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