using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Repositorys
{
    public class ClientsRepository
    {
        public List<Clients> GetClients()
        {
            using (var db = new LojaVirtualEntities3())
            {
                var query = from c in db.Clients
                            select c;
                return  query.ToList();
            }
        }
    }
}