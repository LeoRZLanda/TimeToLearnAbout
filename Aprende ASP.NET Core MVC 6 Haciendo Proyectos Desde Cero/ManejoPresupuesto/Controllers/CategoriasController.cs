using ManejoPresupuesto.Interfaces;
using ManejoPresupuesto.Models;
using ManejoPresupuesto.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace ManejoPresupuesto.Controllers{
    public class CategoriasController : Controller{
        private readonly IRepositorioCategorias repositorioCategorias;
        private readonly IServicioUsuarios servicioUsuarios;

        public CategoriasController(IRepositorioCategorias repositorioCategorias, IServicioUsuarios servicioUsuarios){
            this.repositorioCategorias = repositorioCategorias;
            this.servicioUsuarios = servicioUsuarios;
        }


        public async Task<IActionResult> Index(){
            var UsuarioId = servicioUsuarios.ObtenerUsuarioId();
            var categorias = await repositorioCategorias.Obtener(UsuarioId);

            return View(categorias);
        } 



        [HttpGet]
        public IActionResult Crear(){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Categoria categoria){
            if(!ModelState.IsValid){
                return View(categoria);
            }

            var UsuarioId = servicioUsuarios.ObtenerUsuarioId();
            categoria.UsuarioId = UsuarioId;
            await repositorioCategorias.Crear(categoria);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Editar(int Id){
            Console.WriteLine("Entrando en editar");
            Console.WriteLine("Id: " + Id);
            var UsuarioId = servicioUsuarios.ObtenerUsuarioId();
            var Categoria = await repositorioCategorias.ObtenerPorId(Id, UsuarioId);

            if(Categoria is null){
                return RedirectToAction("NoEncontrado","Home");
            }

            return View(Categoria);
        }


        [HttpPost]
        public async Task<IActionResult> Editar(Categoria CategoriaEditar){

            if(!ModelState.IsValid){
                return View(CategoriaEditar);
            }


            var UsuarioId = servicioUsuarios.ObtenerUsuarioId();
            var Categoria = await repositorioCategorias.ObtenerPorId(CategoriaEditar.Id, UsuarioId);

            if(Categoria is null){
                return RedirectToAction("NoEncontrado","Home");
            }

            CategoriaEditar.UsuarioId = UsuarioId;
            await repositorioCategorias.Actualizar(CategoriaEditar);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Borrar(int Id){
            var UsuarioId = servicioUsuarios.ObtenerUsuarioId();
            var Categoria = await repositorioCategorias.ObtenerPorId(Id, UsuarioId);

            if(Categoria is null){
                return RedirectToAction("NoEncontrado","Home");
            }

            return View(Categoria);
        }


        [HttpPost]
        public async Task<IActionResult> BorrarCategoria(int Id){
            var UsuarioId = servicioUsuarios.ObtenerUsuarioId();
            var Categoria = await repositorioCategorias.ObtenerPorId(Id, UsuarioId);

            if(Categoria is null){
                return RedirectToAction("NoEncontrado","Home");
            }

            await repositorioCategorias.Borrar(Id);

            return RedirectToAction("Index");
        }

    }
}