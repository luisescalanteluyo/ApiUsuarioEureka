using Entidades;
using Logica;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        [HttpGet]
        [Route("UsuariosById")]
        public object UsuariosById(int id)
        {

            UsuarioLogica logic = new UsuarioLogica();

            return logic.UsuariosById(id); ;//    return JsonConvert.SerializeObject(objResult);
        }


        [HttpGet]
        [Route("ListarUsuarios")]
        public object ListarUsuarios()
        {

            UsuarioLogica logic = new UsuarioLogica();


            return logic.ListarUsuarios(); ;//    return JsonConvert.SerializeObject(objResult);
        }


        [HttpPost]
        [Route("GrabarUsuario")]
        public object GrabarUsuario([FromBody] Usuario value)
        {
            UsuarioLogica logic = new UsuarioLogica();

            return logic.GrabarUsuario(value);
        }


        [HttpPut]
        [Route("ActualizarUsuario")]
        public object ActualizarUsuario([FromBody] Usuario value)
        {
            UsuarioLogica logic = new UsuarioLogica();

            return logic.ActualizarUsuario(value);
        }



        // GET: api/<UsuarioController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
