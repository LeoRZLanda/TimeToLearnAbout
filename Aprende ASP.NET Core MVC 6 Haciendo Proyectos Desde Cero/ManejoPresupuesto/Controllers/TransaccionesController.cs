using AutoMapper;
using ManejoPresupuesto.Interfaces;
using ManejoPresupuesto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ManejoPresupuesto.Controllers{
    public class TransaccionesController : Controller {

        private readonly IServicioUsuarios servicioUsuarios;
        private readonly IRepositorioCuentas repositorioCuentas;
        private readonly IRepositorioCategorias repositorioCategorias;
        private readonly IRepositorioTransacciones repositorioTransacciones;
        private readonly IMapper mapper;

        public TransaccionesController(IServicioUsuarios servicioUsuarios, IRepositorioCuentas repositorioCuentas, IRepositorioCategorias repositorioCategorias, IRepositorioTransacciones repositorioTransacciones, IMapper mapper){
            this.servicioUsuarios = servicioUsuarios;
            this.repositorioCuentas = repositorioCuentas;
            this.repositorioCategorias = repositorioCategorias;
            this.repositorioTransacciones = repositorioTransacciones;
            this.mapper = mapper;
        }

        public IActionResult Index(){
            return View();
        }

        public async Task<IActionResult> Crear(){
            var UsuarioId = servicioUsuarios.ObtenerUsuarioId();
            var modelo = new TransaccionCreacionViewModel();
            modelo.Cuentas = await ObtenerCuentas(UsuarioId);
            modelo.Categorias = await ObtenerCategorias(UsuarioId, modelo.TipoTransacciónId); 

            return View(modelo);
        }


        [HttpPost]
        public async Task<IActionResult> Crear(TransaccionCreacionViewModel modelo){
            var UsuarioId = servicioUsuarios.ObtenerUsuarioId();

            if(!ModelState.IsValid){
                modelo.Cuentas = await ObtenerCuentas(UsuarioId);
                modelo.Categorias = await ObtenerCategorias(UsuarioId, modelo.TipoTransacciónId);
                return View(modelo);
            }

            var cuenta = await repositorioCuentas.ObtenerPorId(modelo.CuentaId, UsuarioId);

            if(cuenta is null){
                return RedirectToAction("NoEncontrado","Home");
            }

            var categoria = await repositorioCategorias.ObtenerPorId(modelo.CategoriaId, UsuarioId);

            if(categoria is null){
                return RedirectToAction("NoEncontrado","Home");
            }

            modelo.UsuarioId = UsuarioId;

            if(modelo.TipoTransacciónId == TipoTransacción.Gasto){
                modelo.Monto *= -1;
            }

            await repositorioTransacciones.Crear(modelo);

            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Editar(int Id){
            var UsuarioId = servicioUsuarios.ObtenerUsuarioId();
            var transaccion = await repositorioTransacciones.ObtenerPorId(Id, UsuarioId);

            if (transaccion is null){
                return RedirectToAction("Noencontrado","Home");
            }

            var modelo = mapper.Map<TransaccionActualizacionViewModel>(transaccion);

            modelo.MontoAnterior = modelo.Monto;

            if (modelo.TipoTransacciónId == TipoTransacción.Gasto){
                modelo.MontoAnterior = modelo.Monto * -1;
            }

            modelo.CuentaAnteriorId = transaccion.CuentaId;
            modelo.Categorias = await ObtenerCategorias(UsuarioId, transaccion.TipoTransacciónId);
            modelo.Cuentas = await ObtenerCuentas(UsuarioId);

            return View(modelo);
        }


        [HttpPost]
        public async Task<IActionResult> Editar(TransaccionActualizacionViewModel modelo){
            var UsuarioId = servicioUsuarios.ObtenerUsuarioId();

            if(!ModelState.IsValid){
                modelo.Cuentas = await ObtenerCuentas(UsuarioId);
                modelo.Categorias = await ObtenerCategorias(UsuarioId, modelo.TipoTransacciónId);
                return View(modelo);
            }

            var cuenta = await repositorioCuentas.ObtenerPorId(modelo.CuentaId, UsuarioId);

            if(cuenta is null) {
                return RedirectToAction("NoEncontrado","Home");
            }

            var categoria = await repositorioCategorias.ObtenerPorId(modelo.CategoriaId, UsuarioId);

            if(categoria is null) {
                return RedirectToAction("NoEncontrado","Home");
            }

            var transaccion = mapper.Map<Transaccion>(modelo);

            //modelo.montoAnterior = modelo.Monto;

            if(modelo.TipoTransacciónId == TipoTransacción.Gasto){
                transaccion.Monto *= -1;
            }

            await repositorioTransacciones.Actualizar(transaccion, modelo.MontoAnterior, modelo.CuentaAnteriorId);

            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<IActionResult> Borrar(int Id){
            var UsuarioId = servicioUsuarios.ObtenerUsuarioId();

            var transaccion = await repositorioTransacciones.ObtenerPorId(Id, UsuarioId);

            if (transaccion is null){
                return RedirectToAction("NoEncontrado","Home");
            }

            await repositorioTransacciones.Borrar(Id);

            return RedirectToAction("Index");
        }


        private async Task<IEnumerable<SelectListItem>> ObtenerCuentas(int UsuarioId){
            var cuentas = await repositorioCuentas.Buscar(UsuarioId);

            return cuentas.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));
        }


        private async Task<IEnumerable<SelectListItem>> ObtenerCategorias(int UsuarioId, TipoTransacción tipoTransacción){
            var categorias = await repositorioCategorias.Obtener(UsuarioId, tipoTransacción);
            return categorias.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));
        }


        [HttpPost]
        public async Task<IActionResult> ObtenerCategorias([FromBody] TipoTransacción tipoTransacción){
            var UsuarioId = servicioUsuarios.ObtenerUsuarioId();
            var categorias = await ObtenerCategorias(UsuarioId, tipoTransacción);

            return Ok(categorias);
        }
    
    }
}