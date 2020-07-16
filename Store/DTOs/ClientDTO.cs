using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.DTOs
{
    public class ClientDTO
    {
        public int idClient { get; set;}
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
    }
}