using Microsoft.AspNetCore.Mvc;
using ApiCSherpas.Models;
using System.Net;

namespace ApiCSherpas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        List<Clientes> listaClientes = new List<Clientes>();



        public ClientesController()

        {

            Clientes p = new Clientes { Id = 1, Name = "Fernando", Surname = "Morales", Email = "Fernando@gmail.com", Birthday = new DateTime(1976, 08, 22) };

            this.listaClientes.Add(p);

            p = new Clientes { Id = 2, Name = "Laura", Surname = "Toribio", Email = "Laura@gmail.com", Birthday = new DateTime(1978, 11, 15) };

            this.listaClientes.Add(p);

            p = new Clientes { Id = 3, Name = "Iria", Surname = "Morales", Email = "Iria@gmail.com", Birthday = new DateTime(2011, 12, 25) };

            this.listaClientes.Add(p);

            p = new Clientes { Id = 4, Name = "Natalia", Surname = "Morales", Email = "Natalia@gmail.com", Birthday = new DateTime(2013, 12, 24) };

            this.listaClientes.Add(p);

        }
        [HttpGet]
        public List<Clientes> GetClientes()

        {

            return this.listaClientes;

        }
    }
}
