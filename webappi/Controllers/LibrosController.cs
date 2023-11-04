using Microsoft.AspNetCore.Mvc;
using webappi.Data;
using webappi.Models;
using webappi.Models;

public class LibrosController : Controller
{
    private readonly BibliotecaContext _context;

    public LibrosController(BibliotecaContext context)
    {
        _context = context;
    }

    public IActionResult Ingresar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Ingresar(Libro libro)
    {
        if (ModelState.IsValid)
        {
            _context.Libros.InsertOne(libro);
            return RedirectToAction("Index", "Home"); // Redirige a la página principal después de guardar el libro.
        }
        return View(libro);
    }
}
