using Store.Repositorys;
using System.Web.Http;

namespace Store.Controllers
{
    public class ClientsController : ApiController
    {
        public IHttpActionResult Get()
        {
            ClientsRepository repo = new ClientsRepository();
            var clients = repo.GetClients();
            return Json(clients);

        }



    }
}