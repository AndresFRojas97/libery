using Library_API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoolController : Controller
    {

        List<Book> books = new List<Book>
        {
            new Book { Id = 1, Name = "Principito", Copies = 5, IsCreated = true},
            new Book { Id = 2, Name = "Harry Potter", Copies = 10, IsCreated = true},
            new Book { Id = 3, Name = "Principito", Copies = 3},
            new Book { Id = 4, Name = "Señor de los anillos", Copies = 12},
        };

        [HttpGet]
        [Route("GetAllBooks")]
        public List<Book> ReturnGetAllBooks ()
        {
           
            return books;

            //var result = ($"Has Ingresado el numero: {numero * 5}");

            //return result;
        }

        [HttpGet]
        [Route("GetBookById")]
        public Book GetBookById(int bookId)
        {
            var bookFilterById = books.FirstOrDefault(i => i.Id == bookId);

            return bookFilterById;
        }



        //crear un metodo llamado addBook y otro DeleteBook
        //investigar sobre LINQ y DTOs
        // hacer un commit y subir cambios hechos 

    }

}
