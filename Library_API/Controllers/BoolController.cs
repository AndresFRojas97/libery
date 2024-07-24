using Microsoft.AspNetCore.Mvc;

namespace Library_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoolController : Controller
    {

        //1. que este metodo retorne una lista de objetos mockeados

        [HttpGet]
        [Route("GetAllBooks")]
        public string ReturnTest(int numero)
        {
            var result = ($"Has Ingresado el numero: {numero * 5}");

            return result;

        }

        //crear un metodo llamado addBook y otro DeleteBook
        //investigar sobre LINQ y DTOs
        // hacer un commit y subir cambios hechos 
        
    }
}
