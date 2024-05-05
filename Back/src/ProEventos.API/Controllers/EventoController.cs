using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly ILogger<EventoController> _logger;

        public EventoController(ILogger<EventoController> logger)
        {
            
        }

        private IEnumerable<Evento> _evento = new Evento[] 
        {
            new Evento()
            {
               EventoId = 1,
               Local = "São Paulo",
               DataEvento = DateTime.Now.AddDays(2),
               Tema = "Rock",
               Lote = "Lote1",
               QtdPessoas = 250,
               ImagemUrl = "Foto.png"
            },
            new Evento()
            {
               EventoId = 2,
               Local = "Rio de Janeiro",
               DataEvento = DateTime.Now.AddDays(3),
               Tema = "Pagode",
               Lote = "Lote2",
               QtdPessoas = 350,
               ImagemUrl = "Foto1.png"
            }

        };
        

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

         [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {   
           return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {   
           return $"Exemplo de Put com o id = {id}.";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {   
           return $"Exemplo de Delete com o id = {id}";
        }
    }
}
