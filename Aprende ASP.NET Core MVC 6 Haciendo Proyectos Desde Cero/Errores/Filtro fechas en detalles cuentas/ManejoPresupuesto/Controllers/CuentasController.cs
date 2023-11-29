using AutoMapper;
using ManejoPresupuesto.Interfaces;
using ManejoPresupuesto.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ManejoPresupuesto.Controllers{
    public class CuentasController : Controller {
        private readonly IRepositorioTiposCuentas repositorioTiposCuentas;
        private readonly IServicioUsuarios serviciousuarios;
        private readonly IRepositorioCuentas repositorioCuentas;
        private readonly IMapper mapper;
        private readonly IRepositorioTransacciones repositorioTransacciones;

        public CuentasController(
            IRepositorioTiposCuentas repositorioTiposCuentas, 
            IServicioUsuarios servicioUsuarios, 
            IRepositorioCuentas repositorioCuentas, 
            IMapper mapper,
            IRepositorioTransacciones repositorioTransacciones
            ){
            this.repositorioTiposCuentas = repositorioTiposCuentas;
            this.serviciousuarios = servicioUsuarios;
            this.repositorioCuentas = repositorioCuentas;
            this.mapper = mapper;
            this.repositorioTransacciones = repositorioTransacciones;
        }


        public async Task<IActionResult> Index(){
            var usuarioId = serviciousuarios.ObtenerUsuarioId();
            var cuentasConTipoCuentas = await repositorioCuentas.Buscar(usuarioId);
        
            var modelo = cuentasConTipoCuentas
            .GroupBy(x => x.TipoCuenta).
            Select(grupo => new IndiceCuentasViewModel{ 
                TipoCuenta = grupo.Key, 
                Cuentas = grupo.AsEnumerable()
                }).ToList();
            
            
            return View(modelo);
        }


        public async Task<IActionResult> Detalles(int id, int mes, int año){

            Console.WriteLine("\n..... Detalles .....\n");
            Console.WriteLine("\nDatos recibidos: \nId: " + id + "\nmes: " + mes + "\naño: " + año);
            
            var usuarioId = serviciousuarios.ObtenerUsuarioId();
            var cuenta = await repositorioCuentas.ObtenerPorId(id, usuarioId);

            Console.WriteLine("\n....Revisando cuenta....");

            if( cuenta is null){ // No se porque la vista se ejecuta dos veces y la segunda el id lo pone como 0
                Console.WriteLine("\nCuenta no encontrada");
                return RedirectToAction("NoEncontrado","Home");
            }

            Console.WriteLine("\ncuenta obtenida");

            DateTime fechaInicio;
            DateTime fechaFin;

            Console.WriteLine("\n..... Validando fecha .....");

            if(mes <= 0 || mes > 12 || año >= 1900){
                Console.WriteLine("\nFecha valida");
                var Hoy = DateTime.Today;
                fechaInicio = new DateTime(Hoy.Year, Hoy.Month, 1);
            }
            else{
                Console.WriteLine("Fecha restablecida\n");
                fechaInicio = new DateTime(año, mes, 1);
            }

            fechaFin = fechaInicio.AddMonths(1).AddDays(-1);

            var ObtenerTransaccionPorCuenta = new ObtenerTransaccionesPorCuenta(){
                CuentaId = id,
                UsuarioId = usuarioId,
                FechaInicio = fechaInicio,
                FechaFin = fechaFin
            };

            var transacciones = await repositorioTransacciones.ObtenerPorCuentaId(ObtenerTransaccionPorCuenta);

            var modelo = new ReporteTransaccionesDetalladas();
            ViewBag.Cuenta = cuenta.Nombre;

            var TransaccionesPorFecha = transacciones.OrderByDescending(x => x.FechaTransaccion)
                            .GroupBy( x => x.FechaTransaccion)
                            .Select( grupo => new ReporteTransaccionesDetalladas.TransaccionesPorFecha()
                            {
                                FechaTransaccion = grupo.Key,
                                Transacciones = grupo.AsEnumerable()
                            });

            modelo.TransaccionesAgrupadas = TransaccionesPorFecha;
            modelo.FechaInicio = fechaInicio;
            modelo.FechaFin = fechaFin;

            Console.WriteLine("\nFecha \nDía: "+ modelo.FechaInicio.Day.ToString() + "\nMes: " + modelo.FechaInicio.Month.ToString() + "\nAño: " + modelo.FechaInicio.Year.ToString());

            ViewBag.mesAnterior = fechaInicio.AddMonths(-1).Month;
            ViewBag.añoAnterior = fechaInicio.AddMonths(-1).Year;

            ViewBag.mesPosterior = fechaInicio.AddMonths(1).Month;
            ViewBag.añoPosterior = fechaInicio.AddMonths(1).Year;

            Console.WriteLine("\n.....Datos en el ViewBag.....\nId: " + id + "\nmesAnterior: " + ViewBag.mesAnterior + "\nañoAnterior: " + ViewBag.añoAnterior + "\nmesPosterior: " + ViewBag.mesPosterior + "\nañoPosterior: " + ViewBag.añoPosterior);


            return View(modelo);
        }


        [HttpGet]
        public async Task<IActionResult> Crear(){
            var usuarioId = serviciousuarios.ObtenerUsuarioId();
            
            var modelo = new CuentaCreacionViewModel();
            modelo.TiposCuentas = await ObtenerTiposCuentas(usuarioId);
            return View(modelo);
        }

        [HttpPost]
        public async Task<ActionResult> Crear(CuentaCreacionViewModel cuenta){
            var usuarioId = serviciousuarios.ObtenerUsuarioId();
            var tipoCuenta = await repositorioTiposCuentas.ObtenerPorId(cuenta.TipoCuentaId, usuarioId);

            if(tipoCuenta is null){
                return RedirectToAction("NoEncontrado", "Home");
            }

            if(!ModelState.IsValid){
                cuenta.TiposCuentas = await ObtenerTiposCuentas(usuarioId);
                return View(cuenta);
            }

            await repositorioCuentas.Crear(cuenta);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Editar(int id){
            var usuarioId = serviciousuarios.ObtenerUsuarioId();
            var cuenta = await repositorioCuentas.ObtenerPorId(id, usuarioId);

            if (cuenta is null){
                return RedirectToAction("NoEncontrado","Home");
            }

            var modelo = mapper.Map<CuentaCreacionViewModel>(cuenta);

            modelo.TiposCuentas = await ObtenerTiposCuentas(usuarioId);
            return View(modelo);
        }


        [HttpPost]
        public async Task<IActionResult> Editar(CuentaCreacionViewModel cuentaEditar){
            var usuarioId = serviciousuarios.ObtenerUsuarioId();
            var cuenta = await repositorioCuentas.ObtenerPorId(cuentaEditar.Id, usuarioId);

            if(cuenta is null){
                return RedirectToAction("NoEncontrado","Home");
            }

            var tipoCuenta = await repositorioCuentas.ObtenerPorId(cuentaEditar.TipoCuentaId, usuarioId);

            if (tipoCuenta is null){
                return RedirectToAction("NoEncontrado","Home");
            }

            await repositorioCuentas.Actualizar(cuentaEditar);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Borrar(int id){
            var usuarioId = serviciousuarios.ObtenerUsuarioId();
            var cuenta = await repositorioCuentas.ObtenerPorId(id, usuarioId);

            if (cuenta is null) {
                return RedirectToAction("NoEncontrado", "Home");
            }

            return View(cuenta);
        }

        [HttpPost]
        public async Task<IActionResult> BorrarCuenta(int id){
            var usuarioId = serviciousuarios.ObtenerUsuarioId();
            var cuenta = await repositorioCuentas.ObtenerPorId(id, usuarioId);

            if (cuenta is null) {
                return RedirectToAction("NoEncontrado", "Home");
            }

            await repositorioCuentas.Borrar(id);
            return RedirectToAction("Index");
        }

        private async Task<IEnumerable<SelectListItem>> ObtenerTiposCuentas(int usuarioId){
            var TiposCuentas = await repositorioTiposCuentas.Obtener(usuarioId);

            return TiposCuentas.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));
        }


    
    }
}