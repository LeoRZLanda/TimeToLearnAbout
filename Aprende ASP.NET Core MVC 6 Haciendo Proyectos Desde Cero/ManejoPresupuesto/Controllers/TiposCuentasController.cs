using ManejoPresupuesto.Interfaces;
using ManejoPresupuesto.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManejoPresupuesto.Controllers{
    public class TiposCuentasController : Controller{
        private readonly IRepositorioTiposCuentas repositorioTiposCuentas;
        private readonly IServicioUsuarios servicioUsuarios;

        public TiposCuentasController(IRepositorioTiposCuentas repositorioTiposCuentas, IServicioUsuarios servicioUsuarios){
            this.repositorioTiposCuentas = repositorioTiposCuentas;
            this.servicioUsuarios = servicioUsuarios;
        }

        public async Task<IActionResult> Index(){
            var usuarioId = servicioUsuarios.ObtenerUsuarioId();
            var TiposCuentas = await repositorioTiposCuentas.Obtener(usuarioId);
            return View(TiposCuentas);
        }

        public IActionResult Crear(){
            return View();
        }
    
        [HttpPost]
        public async Task<IActionResult> Crear(TipoCuenta tipoCuenta){
            
            if(!ModelState.IsValid){
                return View(tipoCuenta);
            }

            tipoCuenta.UsuarioId = servicioUsuarios.ObtenerUsuarioId();

            var yaExisteTipoCuenta = await repositorioTiposCuentas.Existe(tipoCuenta.Nombre, tipoCuenta.UsuarioId);

            if(yaExisteTipoCuenta){
                ModelState.AddModelError(nameof(tipoCuenta.Nombre), $"El nombre {tipoCuenta.Nombre} ya existe.");

                return View(tipoCuenta);
            }

            await repositorioTiposCuentas.Crear(tipoCuenta);
            
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<ActionResult> Editar(int Id){
            var usuarioId = servicioUsuarios.ObtenerUsuarioId();
            var tipoCuenta = await repositorioTiposCuentas.ObtenerPorId(Id,usuarioId);

            if(tipoCuenta is null){
                return RedirectToAction("NoEncontrado", "Home");
            }

            return View(tipoCuenta);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(TipoCuenta tipoCuenta){
            var usuarioId = servicioUsuarios.ObtenerUsuarioId();
            var tipoCuentaExiste = await repositorioTiposCuentas.ObtenerPorId(tipoCuenta.Id, usuarioId);

            if(tipoCuentaExiste is null){
                return RedirectToAction("NoEncontrado", "Home");
            }

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Borrar(int Id){
            var usuarioId = servicioUsuarios.ObtenerUsuarioId();
            var tipoCuenta = await repositorioTiposCuentas.ObtenerPorId(Id, usuarioId);

            if(tipoCuenta is null){
                return RedirectToAction("NoEncontrado", "Home");
            }

            return View(tipoCuenta);
        }

        [HttpPost]

        public async Task<IActionResult> BorrarTipoCuenta(int Id){
            var usuarioId = servicioUsuarios.ObtenerUsuarioId();
            var tipoCuenta = await repositorioTiposCuentas.ObtenerPorId(Id, usuarioId);

            if(tipoCuenta is null){
                return RedirectToAction("NoEncontrado", "Home");
            }

            await repositorioTiposCuentas.Borrar(Id);
            return RedirectToAction("Index");
        }


        [HttpGet]

        public async Task<ActionResult> VerificarExisteTipoCuenta(string nombre){
            var usuarioId = servicioUsuarios.ObtenerUsuarioId();
            var yaExisteTipoCuenta = await repositorioTiposCuentas.Existe(nombre, usuarioId);

            if(yaExisteTipoCuenta){
                return Json($"El nombre {nombre} ya existe");
            }


            return Json(true);
        }
    
        [HttpPost]

        public async Task<IActionResult> Ordenar([FromBody] int[] Ids){
            var usuarioId = servicioUsuarios.ObtenerUsuarioId();
            var tiposCuentas = await repositorioTiposCuentas.Obtener(usuarioId);
            var IdsTiposCuentas = tiposCuentas.Select(x => x.Id);

            var IdsTiposCuentasNoPertenecenAlUsuario = Ids.Except(IdsTiposCuentas).ToList();

            if(IdsTiposCuentasNoPertenecenAlUsuario.Count > 0){
                return Forbid();
            }

            var TiposCuentasOrdenados = Ids.Select((valor, indice) => new TipoCuenta() { Id = valor, Orden = indice +1}).AsEnumerable();

            await repositorioTiposCuentas.Ordenar(TiposCuentasOrdenados);

            return Ok();
        }
    
    }
    
}