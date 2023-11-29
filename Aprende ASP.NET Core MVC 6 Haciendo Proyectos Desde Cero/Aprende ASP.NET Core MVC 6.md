

# Introducción 

## ¿Que es .Net?

* Es una plataforma de desarrollo que sirve para desarrollar distintos tipos de aplicaciones

* No es un lenguaje sino un entorno

* C# lenguaje funciona y de objetos como VB

* Fue creado por Microsoft en 2002 para correr en Windows

* Llego hasta la versión 4.8

* .NET CORE es la evolución de .NET

* A la versión vieja es .NET Framework y esta llego hasta la versión 4.8

* .NET Core es la versión nueva y salió en 2016 en su versión 1

* .NET Core 3 => NET 5


## ¿Que es C#?


* Es u lenguaje de programación multiparadigma 

* Se puede desarrollar distintos tipos de aplicaciones

* Es un lenguaje fuertemente tipado

* Es basado en clases

* Nos permite trabajar con funciones de primera clase

* LINQ y expresiones LAMBDA


## ¿Que es ASP.NET Core?


* Es un framework para desarrollar aplicaciones web

* ASP significa Active Server Pages

* Sistemas de ruteo

* Sistemas de usuarios

* Infección de dependencias

* Velocidad


## Tipos de aplicaciones con ASP.Net Core

### ASP.NET Core MVC

* Se refiere al patrón modelo Vista Controlador

* Un modelo se refiere a la data de nuestra aplicación

* Una vista se refiere a la plantilla que muestra la data de un modelo

* El controlador se encara de actualizar los modelos y le pasa los datos a la vista para que muestre el contenido final al usuario. 

### Razor Pages

* Es importante destacar que todo lo que tu hagas en MVC, lo puedes hacer en Razor Pages

* El que recibe la petición es un page handler

### WebAPIs


* Usamos Web APIs cuando no queremos generar interfaces de usuario

*  Si lo ponemos en términos de MVC, un Web API elimina la vista

*  Puedes combinar MVC con WebAPIs

Notas: Tanto como ASP.NET Core y Razor Pages, ambas tecnologías renderizan el HTML en el servidor y se lo envían al cliente, sin embargo  hay una alternativa a esto, es enviar el código de C# al navegador del usuario y a partir de ahí generar el código HTML que se va a visualizar en el navegador.

### Blazor


* Enviar código de C# a navegador del usuario

* Blazor es una tecnología de ASP.NET Core que nos permite crear aplicaciones web interactivas

*  Existen dos tipos de Blazos, Web Assembly y Web Server

* Con Blazor Web Assembly podemos enviar el código de C# al navegador del usuario y ejecutarlo ahí mismo.

* Con Blazor server lo que hacemos es que ejecutamos la aplicación remotamente desde un servidor

PD: Signal AR, más adelante


### gRPC

* gRPC es un framework que permite hacer llamadas de procedimiento remoto

* La idea de gRPC es que nos permite comunicarnos de una manera muy rápida entre distintas aplicaciones







# Introducción a Bootstrap

## ¿Que es bootstrap?


* Es una librería que nos hace la vida más fácil a la hora de desarrollar aplicaciones web

* Cuando hablo de estilos es ante la parte visual

* Cuando se habla de funcionalidad se refiere a las acciones que podemos realizar en nuestra pagina



## Conteiner 

class = "Container "

Nos permite centrar un dvi y su contenido de forma fácil y rápida

![[Pasted image 20231114122539.png]]


## Sistema Grid

Bootstrap nos permite manejar maximo 12 columnas por fila


## Gutters - Espacio entre columnas

class = "row gx-0" 

x = espacio horizontal
0-5 = espacio entre las columnas


## Manejando Imágenes

class = "img-fluid"

<img class =  "img-fluid" >para que se adapte al numero de columnas establecidad por una columna padre

class = "img-thumbnail rounded-circle"

para darle un recuadro y redondeo como en redes sociales


## Colores

![[Pasted image 20231114132615.png]]


## Tablas 

```CSS
class = "table"
```

![[Pasted image 20231114134024.png]]

```CSS
class = "table table-striped"
```

![[Pasted image 20231114134113.png]]

```CSS
class = "table table-hover "
```

![[Pasted image 20231114134156.png]]

``` CSS
<tr class = "table-success" > </tr>
```

![[Pasted image 20231114134437.png]]

```CSS
<table class="table table-hover table-bordered">
```

![[Pasted image 20231114134823.png]]

```CSS
<table class="table table-hover table-borderless">
```

![[Pasted image 20231114134953.png]]


Tambien se le puede implementar los breakpoints


## Manejar el ratio de videos


```CSS
<div class="ratio ratio-16x9">

            <iframe width="560" height="315" src="https://www.youtube.com/embed/G9tScR87hGY" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>

</div>
```


## Tamaños 

### Anchura

```CSS
<div class="w-auto p-3 bg-primary">width auto</div>
```

### Altura


```CSS
<div class="h-auto d-inline-block bg-primary" style="width: 120px;">height auto</div>
```


### Toda la pantalla


```CSS
<div class="vw-100 bg-success">Width 100vw</div>

<div class="vh-100 bg-secondary">height 100vh</div>
```

## Espacios

### Margin 

Espacio del contenedor para afuera

```CSS
<button class="btn btn-primary me-5">Boton 1</button>
```


### Padding

Espacio desde el contenedor para adentro


```CSS
<button class="btn btn-secondary px-2">Boton 2</button>
```



## Utilidades de Texto

### Alineando el texto

```CSS
<p class="text-start">Texto a la izquierda</p>

<p class="text-center">Texto en el centro</p>

<p class="text-end">Texto a la derecha</p>

  

<p class="text-sm-center">Texto centralizado en patallas pequeñas o más grandes</p>

<p class="text-md-center">Texto centralizado en patallas mmedianas o más grandes</p>

<p class="text-lg-center">Texto centralizado en patallas grandes o más grandes</p>

<p class="text-xl-center">Texto centralizado en patallas extra-grandes o más grandes</p>
```

![[Pasted image 20231114165824.png]]

### Texto dentro de su contenedor

```CSS
<div class="badge bg-primary text-wrap" style="width: 6rem;">

    Este texto no se sale de su contenedor

</div>

  

<div class="badge bg-primary text-wrap text-break" style="width:  6rem;">

    mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm

</div>
```

![[Pasted image 20231114165911.png]]

### Transformando texto

```CSS
<p class="text-lowercase">Minusculas</p>

<p class="text-uppercase">Mayusculas texto</p>

<p class="textcapitalize">cada palabra cn mayusculas</p>
```

![[Pasted image 20231114165936.png]]

### Tamaño de Textos 

```CSS
<p class="fs-1">.fs-1</p>

<p class="fs-2">.fs-2</p>

<p class="fs-3">.fs-3</p>

<p class="fs-4">.fs-4</p>

<p class="fs-5">.fs-5</p>

<p class="fs-6">.fs-6</p>
```

![[Pasted image 20231114170135.png]]


### Estilo del texto


```CSS
<p class="fw-bold">Negrita</p>

<p class="fw-bolder">Más negrita</p>

<p class="fw-normal">Normal</p>

  

<p class="fw-light">Texto Light</p>

<p class="fw-lighter">Más Light</p>

<p class="fw-italic">Cursiva</p>

  

<p class="text-decoration-underline">Subrayado</p>

<p class="text-decoration-line-through">Linea a travez del texto</p>

  

<a href="#" class="">Enlace con decoración</a>

  

<a href="#" class="text-decoration-none">Enlace sin decoración</a>
```

![[Pasted image 20231114170222.png]]




## Formularios

### Formulario Normal

```CSS
<form>

    <div class="mb-3">

        <label class="form-label">Email</label>

        <input type="email" class="form-control" />

    </div>

  

    <div class="mb-3">

        <label class="form-label">Descripcion</label>

        <textarea type="email" class="form-control" rows="3"></textarea>

    </div>

  

    <div class="mb-3">

        <label class="form-label">Color Favorito</label>

        <select class="form-select">

            <option value="1">Azul</option>

            <option value="2">Rojo</option>

            <option value="3">Verde</option>

        </select>

    </div>

  

    <div class="form-check">

        <input type="checkbox" class="form-check-input" checked />

        <label class="form-label">Es Empleado</label>

    </div>

  

    <div class="form-check">

        <input type="radio" class="form-check-input" name = "miradio" />

        <label> Opcion1</label>

    </div>

  

    <div class="form-check">

        <input type="radio" class="form-check-input" name = "miradio" />

        <label> Opcion2</label>

    </div>

  

    <div class="form-floating mb-3">

        <input type="email" class="form-control" placeholder="email" />

        <label>Email</label>

    </div>

  

    <div class="form-floating mb-3">

        <input type="email" class="form-control" disabled />

    </div>

  

    <div class="mb-3">

        <label>Color de la camisa</label>

        <input type="color" class="form-control form-control-color" value="#563d7c" />

    </div>

  

    <div>

        <div class="btn btn-primary">Enviar</div>

        <div class="btn btn-secondary">Cancelar</div>

    </div>

</form>
```


![[Pasted image 20231114172924.png]]


### Forulario con Columnas 

```CSS
<div class="row">

    <div class="col">

        <input type="text" class="form-control" placeholder="Primer Nombre">

    </div>

  

    <div class="col">

        <input type="text" class="form-control" placeholder="Primer Apellido">

    </div>

  

    <div class="col">

        <button class="btn btn-primary">Enviar</button>

    </div>

</div>
```

![[Pasted image 20231114173118.png]]




## Acordeón

```CSS
<div class="acordion" id="ejemploAcordeon">

    <div class="accordion-item">

        <h2 class="accordion-header">

            <button data-bs-toggle="collapse" data-bs-target="#elementoacordeon" class="accordion-button">Elemento 1</button>

        </h2>

  

        <div id="elementoacordeon" class="accordion-collapse collapse show" data-bs-parent="#ejemploAcordeon">

            <div class="accordion-body">

                Este es el contenido del primer elemento.

            </div>

        </div>

    </div>

  

    <div class="accordion-item">

        <h2 class="accordion-header">

            <button data-bs-toggle="collapse" data-bs-target="#elemento2acordeon" class="accordion-button">Elemento 2</button>

        </h2>

  

        <div id="elemento2acordeon" class="accordion-collapse collapse" data-bs-parent="#ejemploAcordeon">

            <div class="accordion-body">

                Este es el contenido del segundo elemento.

            </div>

        </div>

    </div>

</div>
```

![[Pasted image 20231114174504.png]]




## Alertas

```CSS
<button onclick="mostrarAlertaExitoso()">Mostra alerta exitosa</button>

<button onclick="mostrarAlertaError()">Mostra alerta de error</button>

  

<div>

    Las alertas se van a mostrar aqui

</div>

  

<div id="contenedor-alertas">

  

</div>

  

@section Scripts{

    <script>

        function mostrarAlertaExitoso(){

            mostrarAlerta("Este es un mensaje exitoso", "success");

        }

  

        function mostrarAlertaError(){

            mostrarAlerta("Este es un mensaje de error", "danger");

        }

  

        function mostrarAlerta(mensaje, tipo){

            const alerta = document.createElement("div");

            alerta.innerHTML = `<div class="alert alert-${tipo}" role="alert">

                                ${mensaje}

                                </div>`;

            cont contenedorAlertas = document.getElementById('contenedor-alertas');

            contenedorAlertas.append(alerta);

        }

    </script>

}

  

<div class="alert alert-primary" role="alert">

  A simple primary alert—check it out!

</div>

<div class="alert alert-secondary" role="alert">

  A simple secondary alert—check it out!

</div>

<div class="alert alert-success" role="alert">

  A simple success alert—check it out!

</div>

<div class="alert alert-danger" role="alert">

  A simple danger alert—check it out!

</div>

<div class="alert alert-warning" role="alert">

  A simple warning alert—check it out!

</div>

<div class="alert alert-info" role="alert">

  A simple info alert—check it out!

</div>

<div class="alert alert-light" role="alert">

  A simple light alert—check it out!

</div>

<div class="alert alert-dark" role="alert">

  A simple dark alert—check it out!

</div>
```

![[Pasted image 20231114180015.png]]


## Carousel

PD: Escoger imágenes con dimensiones similares para evitar el movimiento no deseado de los botones

Junto a ello puedes personalizar cada sub clase de bootstrap

```CSS
<div id="carouselEjemplo" class="carousel slide" data-bs-ride="carousel">

  

    <div class="carousel-inner">

  

        <div class="carousel-item active">

            <img src="https://asset.vg247.com/zenless-zone-zero_obqWbPP.jpg/BROK/thumbnail/1600x900/format/jpg/quality/80/zenless-zone-zero_obqWbPP.jpg" class="d-block w-100">

        </div>

  

        <div class="carousel-item">

            <img src="https://www.pcinvasion.com/wp-content/uploads/2022/06/zenless-zone-zero.jpg" class="d-block w-100">

        </div>

  

        <div class="carousel-item">

            <img src="https://cdnb.artstation.com/p/assets/images/images/051/390/769/large/cruz-vu-zenless-zone-zero-compressed.jpg?1657174322" class="d-block w-100">

        </div>

  

    </div>

  

    <div class="carousel-indicators">

        <button type="button" data-bs-target="#carouselEjemplo" data-bs-slide-to="0" class="active"></button>

        <button type="button" data-bs-target="#carouselEjemplo" data-bs-slide-to="1"></button>

        <button type="button" data-bs-target="#carouselEjemplo" data-bs-slide-to="2"></button>

    </div>

  

    <button class="carousel-control-next" type="button" data-bs-target="#carouselEjemplo" data-bs-slide="next">

        <span class="carousel-control-next-icon"></span>

    </button>

  

</div>
```


![[Pasted image 20231114181717.png]]


## Ventanas Modales

```CSS
<!--Boton abre modal-->

  

<div class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#ejemploModal">Abrir Modal</div>

  

<!--Modal-->

  

<div class="modal fade" id="ejemploModal" tabindex="-1">

  

    <div class="modal-dialog">

        <div class="modal-content">

            <div class="modal-header">

                <h5 class="modal-title">Titulo de modal</h5>

                <button type="button" class="btn-close"></button>

            </div>

            <div class="modal-body">

                <p>Este es un pequño formulario</p>

                <form>

                    <div class="mb-3">

                        <label class="form-label">Nombre</label>

                        <input class="form-control" type="text">

                    </div>

                </form>

            </div>

            <div class="modal-footer">

                <div class="btn btn-secondary" data-bs-dismiss="modal">Cerrar</div>

                <div class="btn btn-primary" data-bs-dismiss="modal">Salvar cambios</div>

            </div>

        </div>

    </div>

  

</div>
```

![[Pasted image 20231114183417.png]]

## Tabs

```CSS
<ul class="nav nav-tabs justify-content-center">

    <li class="nav-item">

        <button class="nav-link active" data-bs-toggle="tab" data-bs-target="#tab1">Tab 1</button>

    </li>

  

    <li class="nav-item">

        <button class="nav-link" data-bs-toggle="tab" data-bs-target="#tab2">Tab 2</button>

    </li>

</ul>

  

<div class="tab-content">

    <div class="tab-pane fade show active" id="tab1">

        Buenos días

    </div>

  

    <div class="tab-pane fade" id="tab2">

        Adíos

    </div>

</div>
```


![[Pasted image 20231114184544.png]]



## Menu lateral con offCanvas

```CSS
<button class="btn btn-primary" data-bs-toggle="offcanvas" data-bs-target="#ejemploOffCanvas">

    Abrir offcanvas

</button>

  
  

<div class="offcanvas offcanvas-start" tabindex="-1" id="ejemploOffCanvas">

  

    <div class="offcanvas-header">

        <h5 class="offcanvas-title">Mi aplicacion</h5>

        <button class="btn-close text-reset" data-bs-dismiss="offcanvas"></button>

    </div>

  

    <div class="offcanvas-body">

        <div>

            Un texto de ejemplo

        </div>

    </div>

</div>
```

![[Pasted image 20231114185237.png]]



## Mostrando los Toasts

```C#
<div class="position-fixed bottom-0 end-0 p-3" style="z-index: 11">

    <div id="miToast" class="toast">

        <div class="toast-header">

            <strong class="me-auto">Mensaje enviado</strong>

            <small>Hace unos instantes</small>

            <button class="btn-close" data-bs-dismiss="toast"></button>

        </div>

        <div class="toast-body">

            El mensaje fue enviado a.

        </div>

    </div>

</div>

@section Scripts2{

    <script>

        function mostrarToast(){

            var ejemmploToast = document.getElementById("miToast");

            var toast = new bootstrap.Toast(ejemmploToast);

            toast.show();

        }

    </script>

}

```


![[Pasted image 20231114191706.png]]



# Proyecto 1 - Portafolio
## Intro

Un landingpage en donde mostraremos nuestras habilidades

Lo que se intenta aprender con este sencillo proyecto es lo siguiente

* Lo basico de ASP .NET Core 
* Acerca de cada concepto de MVC
* Sobre Layouts y vistas parciales
* Intercambio de datos entre C<->V
* Inyección de dependencias
* Ciclo de vida de los servicios, ILogger
* Formulario de contacto

Github para ver todo el codigo

[de LeoRZLanda](https://github.com/LeoRZLanda/Cursos/tree/main/Aprende%20ASP.NET%20Core%20MVC%206%20Haciendo%20Proyectos%20Desde%20Cero/Portafolio)

[del profesor del curso](https://github.com/gavilanch/Aprende-ASP-NET-Core-MVC-Haciendo-Proyectos/tree/main/ASP.NET%20Core%206/Proyecto%201%20-%20Portafolio) 


## Arquitectura del proyecto

Antes de programar hay que poder visualizar cada parte del MVC sobre el proyecto.


### Properties

En donde podremos visualizar la configuración de arranque y poder incorporar nuevos perfiles y la manipulación de las variables de entorno


### wwwroot

Todo lo que el usuario podra ver como

* JS
* CSS
* Imagenes 
* Iconos

### Controlers

Los controladores son las clases que reciben las peticiones HTTP de los usuarios, las procesan y devuelven una respuesta. Se frecuenta que regresen un vista, sin embargo no es fidedigno, logrando tambien ser un JSON, Excel,entre otros.


### Models

Son los datos que queremos mostrar en una vista, no es necesario usar modelos en cada una de las vistas, es común hacerlo a razón de que nos permiten desarrollar aplicaciones web dinámicas.


### Views

En esta sección colocaremos cualquier parte visual del proyecto, como;

* botones
* formularios
* recursos compartidos (sidebar)


#### _ViewStart

Nos permite tener configuracion generalizada de las vistas


### Settings

Para terminar tendremos los archivos

appsettings.json (Para ambiente de producción)

appsettings.Development.json (Para desarrollo)

que nos permite guardar datos de configuración que el proyecto usara sin necesidad de colocarlos en codigo C#


### Program

La pieza central dentro de la arquitectura, en donde se configuran los servicios de nuestra aplicación, como los middlewares

## Ruteo

Esto se define dentro del archivo Program.cs de l siguiente forma 


```C#
app.MapControllerRoute(

    name: "default",

    pattern: "{controller=Home}/{action=Index}/{id?}");
```

Existen varias formas de realizar el ruteo, como por;

* Atributos
* Convencional (Como el ejemplo anterior)

Que indica que por defecto el controlador seria home y su acción sería mostrar la vista index, con posibilidad de insertar un id

## CSS, Cache y Tag Helpers

### CSS

Se recomienda desarrollar y anexarlo a la carpeta respectiva css y que se renderice en los archivos compartidos, en este caso el layout


### Tag Helpers

Nos permite a añadir funcionalidad util a nuestras etiquetas HTML.

Como ejemplo, al intentar anexar un nuevo css en layout, veremos lo siguiente 


```html
<link rel="stylesheet" href="~/css/custom.css" asp-append-version = "true" />
```

en este caso "asp-append-version" permite tener la versión más actualizada del archivo, si cambia el nombre de la referencia no perdera el diseño.

### Cache

Aunado a ello permite tener una mayor eficiencia dentro del uso de la cache, a razón de que los navegadores por defectos guarda los archivos que compone nuestro proyecto ahi, para que no se tarde en cargar nuestro sitio web.



## ViewBag

Nos permite pasar datos del C->V

```C#
public IActionResult Index()

    {

        ViewBag.Nombre = "Leonardo Ramírez";

        return View();

    }
```

Lo malo de ViewBag es que no es fuertemente tipado


## Modelos fuertemente tipados

### recibir un dato del controlador

```C#
@model string

  

@{

    ViewData["Title"] = "Home Page";

}

  

<div class="text-center">

    <h1 class="display-4">Soy @Model @ViewBag.Edad</h1>

    <h2>Futuro desarrollador full stack especializado en tecnologias .NET y JS</h2>

  

    <img id="foto" src="~/images/profile.jpg" alt="Foto de Leo" />

</div>
```


### Recibiendo dos datos del controlador

En en controlador

```CS
public IActionResult Index()

    {

        Persona persona = new Persona(){

            Nombre = "Leonardo Ramírez",

            Edad = 22

        };

  

        return View(persona);

    }
```

en la vista

```C#
@model Persona

  

@{

    ViewData["Title"] = "Home Page";

}

  

<div class="text-center">

    <h1 class="display-4">Soy @Model.Nombre @Model.Edad</h1>

    <h2>Futuro desarrollador full stack especializado en tecnologias .NET y JS</h2>

  

    <img id="foto" src="~/images/profile.jpg" alt="Foto de Leo" />

</div>
```




## Explorando Razor

![[Pasted image 20231115120346.png]]

### Mandar datos de la vista al layout 

En la vista 
```C#
@{

    ViewData["Title"] = "Home Page";

}
```

en el layout

```C#
<title>@ViewData["Title"] - Portafolio</title>
```



### Colocar variables en pantalla

```C#
@{
DateTime hoy = DateTime.Now;
var nombre = new List<string>() {"Felipe", "Claudia", "Tomás"}
}

<div class = "text-center">
	<h4> @hoy.ToString("dd/MM/yyyy hh:mm:ss tt") </h4>

	<ul> 

		@foreach(var nombre in nombres){
			<li> @nombre </li>
		}
	
	</ul>

</div>
```

### Crear funciones en los archivos de las vistas 

```C# 
@{
	srting ConvertirEnMayusculas(string valor){
		return valor.ToUpper() + "ZZZ";
	}
}

<div class = "text-center">
	<h1 class="display-4">Soy @ConvertirEnMayusculas(Model.Nombre) @Model.Edad</h1>
</div>
```

### Vistas variables


```C#
<div class = "text-center">
	<h1 class="display-4">Soy @ConvertirEnMayusculas(Model.Nombre) @Model.Edad</h1>
</div>

@if(Model.edad >= 18){
	<h4>Adelnate, eres mayor</h4>
}
else{
  <h4>Eres menor, hasta la proxima</h4>
}
```




## Vistas Parciales

En index 
```C#
@{

    ViewData["Title"] = "Home Page";

}

  

<partial name="_Presentacion" />

  
  

<partial name="_Habilidades"/>
```


En presentación

```C#
<div class="text-center">

    <h1 class="display-4">Soy Leonardo Ramírez</h1>

    <h2>Futuro desarrollador full stack especializado en tecnologias .NET y JS</h2>

  

    <img id="foto" src="~/images/profile.jpg" alt="Foto de Leo" />

</div>

  

<div class="text-center">

    <img id="img-dotnet" src="~/images/dotnetImagen.png" alt="imagenDotNet">

</div>

  
  

<div class="row justify-content-center text-center bg-primary">

    <div class="col col-md-7 seccion-bienvenida">

        <h1>Te doy la binvenida a mi portafolio</h1>

        <p>

            He estado desarrollando software profesionalmente desde 2023. He tenido el privilegio de trabajar para una empresa donde tuve la oportunidad de realizar proyectos para empresas como Orange, Seguros Universal, Golds Gym, Banco BHD; todo esto trabajando principalmente aplicaciones de C#/ASP.Net, SQL Server, Entity Framework, JavaScript, entre otras tecnologías.

        </p>

    </div>

</div>
```

En Habilidades

```C#
<div style="margin-top: -105px;">

    <div class="row justify-content-md-center text-center">

        <div class="col col-3 bg-white habilidades" style="border-radius: 15px 0 0 15px; box-shadow: 0 5px 5px 0 gray;">

            <i class="bi-hdd-fill"></i>

            <h3>Back-end</h3>

  

            <p>

                Trabajo desde el esarrollo, pruebas automaicas y puesta e producción con etrega continua.

            </p>

  

            <p class="text-primary cabecera">

                Stack;

            </p>

  

            <p>

                ASP.NET Core, SQL Server

            </p>

  

            <p class="text-primary cabecera">

                Experiencia:

            </p>

  

            <ul>

                <li>Web APIs</li>

                <li>ASP.NET Core MVC</li>

                <li>Entity Framework</li>

                <li>Blazor</li>

                <li>Dapper</li>

                <li>Queries espaciales</li>

                <li>Principios SOLID</li>

            </ul>

  

        </div>

  

        <div class="col col-3 bg-white habilidades" style="border-radius: 0 15px 15px 0; box-shadow: 0 5px 5px 0 gray;">

            <i class="bi-code-slash"></i>

            <h3>Front-end</h3>

  

            <p>

                Puedo crear Front-ends robustos lso cuales cumplen con los reuerimientos del negocio.

            </p>

  

            <p class="text-primary cabecera">

                Stack;

            </p>

  

            <p>

                React, Angular, Blazor

            </p>

  

            <p class="text-primary cabecera">

                Experiencia:

            </p>

  

            <ul>

                <li>React Hooks</li>

                <li>Angular Material</li>

                <li>Blazor WASM</li>

                <li>JQuery</li>

                <li>Pruebas automaicas</li>

                <li>Leaflet</li>

                <li>Markdown</li>

            </ul>

        </div>

    </div>

</div>
```




## Pasar Data a vistas parciales

en Home controller

```C#
public IActionResult Index()

    {

        var proyectos = ObtenerProyectos().Take(3).ToList();

        var modelo = new HomeIndexViewModel() {Proyectos = proyectos};

        return View(modelo);

    }

  

    private List<Proyecto> ObtenerProyectos(){

        return new List<Proyecto>() {

            new Proyecto{

                Titulo = "Amazon",

                Descripcion = "E-Commerce realizado en ASP.NET Core",

                Link = "https://amazon.com",

                ImagenURL = "~/images/amazon.png"

            },

  

            new Proyecto{

                Titulo = "New York Times",

                Descripcion = "Página de notcias en React",

                Link = "https://nytimes.com",

                ImagenURL = "~/images/nyt.png"

            },

  

            new Proyecto{

                Titulo = "reddit",

                Descripcion = "Red social para compartir en comunidad",

                Link = "https://amazon.com",

                ImagenURL = "~/images/reddit.png"

            },

  

            new Proyecto{

                Titulo = "Steam",

                Descripcion = "Tienda en línea para comprar videojuegos",

                Link = "https://store.steampowered.com",

                ImagenURL = "~/images/steam.png"

            }

        };

    }
```


En vista parcial proyectos

```C#
@model IEnumerable<Proyecto>

  
  

@if (Model is not null){

    <div class="text-center" style="padding-top: 6rem;">

        <h1>Mis proyectos recientes</h1>

        <p>Aquí puedes ver algunos de mis trabajps más recientes</p>

    </div>

  

    <div class="container">

        <div class="row row-cols row-cols-md-3 g-4">

            @foreach (var proyecto in Model) {

                <div class="col">

                    <div class="card h-100">

                        <img src="@proyecto.ImagenURL" class="card-img-top" alt ="imagen proyecto" />

                        <div class="card-body">

                            <h5 class="card-title">@proyecto.Titulo</h5>

                            <p class="card-text">@proyecto.Descripcion</p>

                        </div>

  

                        <div class="card-footer">

                            <a href="@proyecto.Link" class="btn btn-primary" target="_blank"

                                rel = "noopener noreferrer" > Visitar  </a>

                        </div>

                    </div>

                </div>  

            }

  

        </div>

    </div>

}
```

index

```C#
@model HomeIndexViewModel

  

@{

    ViewData["Title"] = "Home Page";

}

  

<partial name="_Presentacion" />

  
  

<partial name="_Habilidades"/>

  
  

<partial name="_SeccionProyectos" model="Model.Proyectos"/>
```


PD:DTO, Data Transfer Object


## Principio de Responsabilidad Unica

A razón que utilizamos una funcion "ObteerProyects" en el controlador home, con mucha responsbilidad, una mala praxis.

Un controlador debe de servir vistas no en almacenar los datos del proyecto.

Así que crearemos un nuevo directorio llamandolo servicios, junto a una clase RepositorioProyectos.

Ya que tipicamente una clase de repositorio lo que hace es que se encarga de conectar una base de datos para conseguir los daos o realiza rcualquier operacion en la base de datos. 


clase Repositorio Proyectos.cs

```CS
  

using Portafolio.Models;

namespace Portafolio.Servicios{

    public class RepositorioProyectos{

  

    public List<Proyecto> ObtenerProyectos(){

        return new List<Proyecto>() {

            new Proyecto{

                Titulo = "Amazon",

                Descripcion = "E-Commerce realizado en ASP.NET Core",

                Link = "https://amazon.com",

                ImagenURL = "/images/amazon.png"

            },

  

            new Proyecto{

                Titulo = "New York Times",

                Descripcion = "Página de notcias en React",

                Link = "https://nytimes.com",

                ImagenURL = "/images/nyt.png"

            },

  

            new Proyecto{

                Titulo = "Reddit",

                Descripcion = "Red social para compartir en comunidad",

                Link = "https://amazon.com",

                ImagenURL = "/images/reddit.png"

            },

  

            new Proyecto{

                Titulo = "Steam",

                Descripcion = "Tienda en línea para comprar videojuegos",

                Link = "https://store.steampowered.com",

                ImagenURL = "/images/steam.png"

            }

        };

    }  

  

    }

  

}
```


En HomeController.cs

```C#
    public IActionResult Index()

    {

        var RepositorioProyectos = new RepositorioProyectos();

        var proyectos = RepositorioProyectos.ObtenerProyectos().Take(3).ToList();

        var modelo = new HomeIndexViewModel() {Proyectos = proyectos};

        return View(modelo);

    }
```

A partir de aqui se realizo una mejora, sin embargo no se sigue completamente el principio de responsabilidad única, sirve vista e instancia el objeto RepositorioProyectos. a Continuación veremos la solución para poder centralizar dicha acción.

## Inyección de dependencias

Con esto delegamos la instanciación de las dependencias a nuestras clases a otras.

Para poder realizarlo utilizaremos el program.cs

```C#
using Portafolio.Servicios;

  

var builder = WebApplication.CreateBuilder(args);

  

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddTransient<RepositorioProyectos>();
```

ahora utilizamos el nuevo servicio en el HomeController

 ```C#
using Portafolio.Servicios;
using Portafolio.Controller;

//Lo de abajo esta dentro de la clase HomeController


 private readonly ILogger<HomeController> _logger;

    private readonly RepositorioProyectos repositorioProyectos;

  

    public HomeController(ILogger<HomeController> logger, RepositorioProyectos repositorioProyectos)

    {

        _logger = logger;
        this.repositorioProyectos = repositorioProyectos;

    }

  

    public IActionResult Index()

    {

        var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();

        var modelo = new HomeIndexViewModel() {Proyectos = proyectos};

        return View(modelo);

    }
```


Aquí seguimos avanzando, sin embargo podemos darle mayor flexibilidad con

## Inyección de Dependencias con Interfaces

Para poder realizarlo vamos a crear una carpeta de interfaces e incorporar la siguiente

IRepositorioProyectos.cs

```C#
using Portafolio.Models;

  

namespace Portafolio.Interfaces{

    public interface IRepositorioProyectos{

        List<Proyecto> ObtenerProyectos();

    }

}
```

Le anexamos su uso en los siguientes archivos

RepositorioProyectos.cs

```C#

//En la creacion de la clase la ponemos y al inicio del archivo

using Portafolio.Interfaces;

public class RepositorioProyectos : IRepositorioProyectos{

```

en program.cs editamos lo siguiente

```CS
using Portafolio.Interfaces;
using Portafolio.Servicios;

builder.Services.AddTransient<IRepositorioProyectos, RepositorioProyectos>();
```

En si solo se agregamos el directorio de interfaces y la I y el servicio del RepositorioProyectos

Y en HomeController.cs 

```C#
using Portafolio.Interfaces;
//Veras que Portafolio.Servico ya no se usa gracias a la inyección por interfaz

private readonly IRepositorioProyectos repositorioProyectos;

  

    public HomeController(ILogger<HomeController> logger, IRepositorioProyectos repositorioProyectos)

    {

        _logger = logger;

        this.repositorioProyectos = repositorioProyectos;

    }
```

Esto en si es el principio de inversión de dependencias, donde las clases no dependen de clases sino de tipos abstractos, interfaces en nuestro caso.

Permitiéndonos cambiar la implementación de la interfaz, podemos cambiar RepositrioInterfaz em program.cs en otro servicio que ya tenga conexión a una base de datos, sin necesidad de detener o volver a compilar el proyecto.

## Servicios

Anteriormente hemos utilizado AddTransient para poder incorporar nuestra interfaz y servicio IRepositorioProyectos

Sin embargo que es?

Existe a razón de que no todos los servicios son iguales, difieren en su tiempo de vida.

hay los siguientes tipos de servicio.

* Transient
* Scope
* Singleton

### Transient

Son los que duran menos tiempo, la idea es que cada vez que en una clase se ntenta inyectar a un servicio transitorio, se nos sirve una nueva instancia del servicio


### Scope

Seria como delimitado, a razón porque vive delimitado al tiempo de vida de una petición HTTP


### Singleton

Denominado como unico y que vive por siempre, solo se renueva si la aplicación es iniciada

### Ejemplo





Un criterio para decidir el tiempo de vida de nuestros servicios es si necesitan compartir datos entre distintas estancias del servicio.

Ejemplo: El servicio de IRpositorio no necesita compartir datos entre distintas instancias del servicio, por tanto se usa Transient.

Sí necesitáramos compartir datos con tras instancias, digamos de otras peticiones http, utilizaremos Singleton.

Y su se requiere compartir datos con otras instancias pero solamente dentro de la misma petición, usaríamos scope.

![[Pasted image 20231115170316.png]]

Como podemos ver, en los transitorio, siempre cambia, el delimitado si la petición http es diferente y el único, como su nombre indica, no cambia hasta compilar de nuevo.









## ILogger

Es un servicio preconfigurado que nos permite escribir mensajes en Logs

Para poder utilizar algo basico de si, seria lo siguiente

```C#
//Como ejemplo colocarlo en la función index de HomeController
_logger.LogInformation("Este es un mensaje de log");_
```

Además de ello se puede definir categorías de mensajes, a razón de diferente nivel de prioridad, ILogger nos permite clasificar en las siguientes 6 categorias

* Critical
* Error
* Warning
* Information
* Debug
* Trace

Y puedes configurar que solamente se procesen ciertas categorías.

Esto se logra editando appSettings.json

```JSON
{

  "Logging": {

    "LogLevel": {

      "Default": "Information",

      "Microsoft.AspNetCore": "Warning"

    }

  }

}
```


Aquí lo que indica por defecto, nos muestra mensajes de information hacia arriba y si tiene el encabezad del framework .net que solo sea de warning en adelante, para no llenar de mensajes la terminal.


```C#
_logger.LogTrace("Este es un mensaje de trace");
_logger.LogDebug("Este es un mensaje de debug");
_logger.LogInfomation("Este es un mensaje de information");
_logger.LogWarning("Este es un mensaje de warning");
_logger.LogError("Este es un mensaje de error");
_logger.LogCritical("Este es un mensaje de critical");
```

Si colocamos esto en la funcion Index podremos ver lo siguiente

![[Pasted image 20231115172800.png]]

Como podemos ver los mensajes de trace y debug no aparecen


## Proveedores de configuración

Puedes añadir variable de entorno y cambiar el comportamiento en producción o desarrollo


## Enviar datos V->C

para poder realizar un httpPost

Crearemos un simple formulario de contacto, en una vista a parte

Contacto.cshtml

```C#
@{

    ViewData["Title"] = "Contacto";

}

  

<h1>Formulario de Contacto</h1>

  

<form asp-controller="Home" asp-action="Contacto">

    <div class="mb-3">

        <label for="nombre" class="form-label">Nombre</label>

        <input type="text" class="form-control" id="nombre" name="nombre" placeholder="Nombre"/>

    </div>

  

    <div class="mb-3">

        <label for="email" class="form-label"></label>

        <input type="text" class="form-control" id="email" name="email" placeholder="email" />

    </div>

  

    <div class="mb-3">

        <label for="mensaje" class="form-label">Mensaje</label>

        <textarea name="mensaje" id="mensaje" rows="3" class="form-control"></textarea>

    </div>

  

    <button type="submit" class="btn btn-primary">Enviar</button>

</form>
```


editamos el layout para que pueda aparecer nuestra nueva vista en el header

_layout.cshtml
```C#
//Se anexa debajo de Home y Proyecto
<li class="nav-item">

                            <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Contacto">Contacto</a>

                        </li>
```

editaremos lo siguiente en HomeController

```C#
[HttpPost]

  

    public IActionResult Contacto(ContactoViewModel contactoViewModel){

        return View();

    }
```

Ahora ya obtenemos datos, sin embargo si se refresca el navegador, se reenviara de nuevo los datos. para evitar eso tenemos que hacer una redirección get.

Simplemente es redirecciónando a una acción y de ahi a una vista.

HomeController.cs

```C#
[HttpPost]

  

    public IActionResult Contacto(ContactoViewModel contactoViewModel){

        return RedirectToAction("Gracias");

    }

  

    public IActionResult Gracias(){

        return View();

    }
```

En el proyecto se utiliza SendGrid para poder enviar correo, si es de interes recomiendo ver video 66 y/o el github.


# Proyecto 2 - Manejo de Presupuestos

## Base de Datos

### Intro

En este breve proyecto haremos que el usuario pueda manejar sus finanzas, podrá registrarse junto con sus ingresos y gastos, clasificarlo mediante categorías personalizadas por el usuario junto con un reporte de sus movimientos para poder ver como mueve su dinero.

Se vera

* Operaciones básicas en sql server, CRUD
* Procedimientos almacenados
* Creación de base de datos de la app.
* Export a excel


#### Resumen


![[Pasted image 20231116123830.png]]

### ¿Que es una base de datos?

Ubicación en donde se alojan los datos y permite su manejo


### Creación de la DB 

Realmente es muy sencillo, simplemente conéctate usando SSMS crea una nueva DB y de ahí clic derecho en tablas para crear una nueva

#### Tabla transacciones

![[Pasted image 20231115185401.png]]

Asegurarse que el Id se autoIncrementado, se logra en Column Properties y poner Yes en Identity Specification

### Manipulación de datos

#### Manualmente

Clic derecho en la tabla en el Object Explorer y edit top 

![[Pasted image 20231115190052.png]]
#### Código

Clic derecho en la tabla en el Object Explorer y en New Query 


##### Insertar

Ejemplo en codigo para poder realizar una inserción en nuestra DB de ejemplo ManejoPresupuesto

```SQL
INSERT INTO Transacciones (FechaTransaccion, Monto, Nota, TipoTransacciónId, UsuarioId)
VALUES ('2023-11-15', 1500, 'Esto vino de un query', 1, 'Felipe');
```

##### Select

Ejemplo en código para poder seleccionar en nuestra DB de ejemplo ManejoPresupuesto

En este ejemplo seleccionamos cada columna, recomendable solo traer la data de interés para ser más eficiente

```SQL
SELECT * FROM Transacciones
```

##### Ordenando con ORDER BY

Podemos agregarle ordenamiento a la propia selección, en este ejemplo lograremos devolver de modo ascendente en base al monto

```SQL
SELECT Id, UsuarioId, Monto, Nota
FROM Transacciones 
ORDER BY Monto ASC
```

##### Filtrando con WHERE

Además la posibilidad de filtrar, en este caso queremos obtener toda la información del UsuarioId Felipe

```SQL
SELECT Id, UsuarioId, Monto, Nota
FROM Transacciones
WHERE UsuarioId = 'Felipe'
```


##### Actualizar Datos

Ahora para poder editar datos usamos UPDATE .

En este ejemplo actualizamos el Monto de la primera transacción

```SQL
UPDATE Transacciones
SET Monto = 4500
where Id = 1
```


##### Borrar registros

Para poder borrar algún registro simplemente utilizaremos el comando DELETE

```SQL
DELETE Transacciones
WHERE Id = 3
```



##### Operador IN

Ahora podremos tener una selección múltiple gracias a el operador IN.

en este ejemplo sencillo solo solicitamos que nos devuelva todas las transacciones que no sean de 1500

```SQL
SELECT *
FROM Transacciones
WHERE Monto not in ('1500')
```

##### Operador LIKE

Nos permite especificar que tenga un posible contenido los registro.

En este ejemplo solicitamos que nos devuelva todos los datos de la tabla transacciones que dentro de UsuarioId tenga f, sin importar si lo tiene al inicio o al final

```SQL
SELECT *
FROM Transacciones
WHERE UsuarioId like '%f%'
```

##### Combinando Operadores Lógicos

También podemos solicitar query más específicos

Como el ejemplo inferior, nos devolverá la tabla Transacciones donde el UsuarioId termine en pe y alguna de sus transacciones se en una fecha en especifico.

En el siguiente es muy similar, Transacciones de Felipe con monto de 1500.99 en especifico


```SQL
SELECT *
FROM Transacciones
WHERE UsuarioId like '%pe' AND FechaTransaccion = '2023-11-15'

SELECT *
FROM Transacciones
WHERE (UsuarioId = 'Felipe' AND Monto = 1500.99) OR UsuarioId = 'abc'
```


##### Filtrar por Fechas

Este código nos enseña como poder retornar transacciones dentro de un rango de fechas, en este ejemplo son dentro de Noviembre

```SQL
SELECT *
FROM Transacciones
WHERE FechaTransaccion > '2023-11-1' AND FechaTransaccion < '2023-11-30'
```

También tenemos la forma de poder utilizar funciones definidas como MONTH() darle como parámetro la comuna de FechasTRnsacciones e igualarlo al mes de nuestro interés.


```SQL
SELECT *
FROM Transacciones
WHERE MONTH(FechaTransaccion) = 11
```

PD: También hay par día, DAY() y año YEAR()

##### Operador BETWEEN

El ejemplo anterior podemos simplificarlo de la siguiente forma

```SQL
SELECT *
FROM Transacciones
WHERE FechaTransaccion BETWEEN '2023-11-1' AND '2023-11-30'
```

##### Operador TOP

Para poder regresar los primeros n elementos usaremos lo siguiente

Se puede utilizar cantidad o porcentaje de la tabla


```SQL
SELECT TOP 1 *
FROM Transacciones
WHERE Monto <= 1500

SELECT TOP 50 PERCENT *
FROM Transacciones
WHERE Monto <= 1500
```



##### Utilizando GROUP BY y Suma

El futuro código nos permite retornar la suma mensual de cada tipo de transacción por cada Usuario


```SQL
SELECT UsuarioId, SUM(Monto) as Suma, TipoTransacciónId, MONTH(FechaTransaccion) as MES
FROM Transacciones
GROUP BY UsuarioId, TipoTransacciónId, MONTH(FechaTransaccion)
```


##### Conteo y Promedio

A continuación podemos apreciar como poder contar la cantidad de transacciones que tiene cada Usuario

```SQL
SELECT UsuarioId, Count(Id) as Total
FROM Transacciones
GROUP BY UsuarioId
```

A ello también podemos obtener el promedio, como ejemplo, lo siguiente nos muestra El monto promedio por tipo de transacción, su total de transacciones de cada tipo de cada mes por cada usuario

```SQL
SELECT UsuarioId, AVG(Monto) as Monto, TipoTransacciónId, Count(Id) as Total, MONTH(FechaTransaccion) as Mes
FROM Transacciones
GROUP BY UsuarioId, TipoTransacciónId, MONTH(FechaTransaccion)
```


##### Tabla Tipo Operación - Llaves Foráneas 

Esto nos permite hacer referencia a la llave primaria de otra tabla, en nuestro caso nos importa que TipoTransacciónId se 1 o 2, ingreso o Gasto, y que por error coloquemos 3.

Antes que nada creamos la tabla TiposTransacciones, le seleccionamos su llave primaria Id


Seleccionando la tabla transacciones y darle clic derech a la carpeta key y crear nueva Fk

![[Pasted image 20231116104407.png]]


Ya podemos tener limitado que solo haya 2 TipoTransacciónId, sin embargo cuando realizamos una consulta como  preivamente lo hemos hecho, solo veremos 1 o 2, y no da mucha descripción visual, para ello haremos


##### INNER JOIN


Para ello necesitamos realiza runa tabla que combine la data de Transacciones y TiposTransacciones

Gracias al uso de INNER JOIN ahora tenemos acceso a la data de cada una de las tablas, sin embargo se genera una colisión con el elemento Id, a razón de que ambas lo tienen, esto se soluciona simplemente con especificarle antes su tabla procedente.

```SQL
SELECT Transacciones.Id, UsuarioId, Monto, Nota, TiposTransaccion.Descripción
FROM Transacciones
INNER JOIN TiposTransaccion
ON Transacciones.TipoTransacciónId = TiposTransaccion.Id
```

Ahora finalmente podemos visualizar la descripción de TiposTransacción en una tabla aparte


##### Procedimientos Almacenados


De momento hemos escrito codigos individualemnte, sin embargo hay formas de poder reutilizarlos como con

* Vistas
* Procedimientos almacenados
* Funciones

De momento veremos el uso de Procedimientos almacenados


En si son múltiples query encapsulados teniendo la posibilidad de recibir parámetros

PD: El uso de ellos es una buena practica a razón de que centralizar la operación y ahora solo tienes que ejecutarla

###### Creación

```SQL
CREATE PROCEDURE Transacciones_SelectConTipoOperacion

AS
BEGIN

	SET NOCOUNT ON;

	SELECT Transacciones.Id, UsuarioId, Monto, Nota, Descripción
	FROM Transacciones
	INNER JOIN TiposTransaccion
	ON Transacciones.TipoTransacciónId = TiposTransaccion.Id
END
```

###### Uso

```SQL
EXEC Transacciones_SelectConTipoOperacion
```


###### Alteración

```SQL
ALTER PROCEDURE Transacciones_SelectConTipoOperacion

AS
BEGIN

	SET NOCOUNT ON;

	SELECT Transacciones.Id, UsuarioId, Monto, Nota, Descripción
	FROM Transacciones
	INNER JOIN TiposTransaccion
	ON Transacciones.TipoTransacciónId = TiposTransaccion.Id
	ORDER BY UsuarioId DESC
END
```

##### Procedimientos almacenados con parámetros

Una forma de enriquecer nuestros procesos es pasándole parámetros

###### Creación

```SQL
ALTER PROCEDURE Transacciones_SelectConTipoOperacion
	@fecha DATE
AS
BEGIN

	SET NOCOUNT ON;

	SELECT Transacciones.Id, UsuarioId, Monto, Nota, Descripción
	FROM Transacciones
	INNER JOIN TiposTransaccion
	ON Transacciones.TipoTransacciónId = TiposTransaccion.Id
	WHERE FechaTransaccion = @fecha

END
```



### Creación de tablas para la DB 

Ahora completaremos la estructura de nuestra DB, sin embargo la tabla TiposTransacciones se encuentra en la sección anterior en uso de Llaves foraneas

#### Tablas Cuentas y Tipos Cuentas

##### TiposCuentas

![[Pasted image 20231116113456.png]]

##### Cuentas 

![[Pasted image 20231116113844.png]]

##### Relaciónes

###### FK Cuentas TipoCuentas

![[Pasted image 20231116114235.png]]




###### FK transacciones Cuentas


primero le agregamo la columna CuentaId en tabla Transacción y editaos el UsuarioId a int

![[Pasted image 20231116115008.png]]

PD: Recuerda borrar la data ¿, si tienes, a razón de que la nueva columna que agregamos no es null, y esos datos no tienes dicha info y generara un error

Ahora realizamos su relación

![[Pasted image 20231116115743.png]]



#### Tabla Usuarios

![[Pasted image 20231116120157.png]]

PD: Recuerda establecer el Id de cada tabla como llave primaria y que se auto incremente


##### Relaciones

###### TiposCuentas con Usuarios

![[Pasted image 20231116120453.png]]

###### transacciones con Usuarios

![[Pasted image 20231116120646.png]]



#### Tabla Categorías

Concepto de tipo de transacción definidas por el usuario

![[Pasted image 20231116121134.png]]

PD: No olvides agregar CategoríaId en la tabla transacciones 

![[Pasted image 20231116122155.png]]

#### Relaciones

##### Categorías con TiposTransaccion

![[Pasted image 20231116121221.png]]

##### Categorías con Usuarios

![[Pasted image 20231116121259.png]]



##### Transacciones con Categorías

![[Pasted image 20231116122830.png]]

### Visualización de la DB

![[Pasted image 20231116123355.png]]




## CRUD con Dapper

### Intro

Lo que podremos realiza en esta sección sera

* Simple formulario
* Validaciones
* Conectarnos con la DB
* CRUD
* Fetch API

#### Resumen

* tag Helpers
* Validaciones
* No confiar en la data que viene del cliente
* Programación asíncrona
* CRUD
* Conectarnos a la DB
* Arrastre
* Fetch API

### Formulario Tipos de Cuentas

Empezaremos con ello a razón de que tenemos que saber en ingreso y egreso de cada cuenta

Empezaremos con
#### TiposCuentasController

Añadimos un nuevo controller en la carpeta

```CS
using ManejoPresupuesto.Models;

using Microsoft.AspNetCore.Mvc;

  

namespace ManejoPresupuesto.Controllers{

    public class TiposCuentasController : Controller{

        public IActionResult Crear(){

            return View();

        }

        [HttpPost]

        public IActionResult Crear(TipoCuenta tipoCuenta){

            return View();

        }

    }

}
```

#### Tipo Cuenta

Añadimos un nuevo modelo en la carpeta, realmente creamos la clase TipoCuenta de a DB

```CS
namespace ManejoPresupuesto.Models{

    public class TipoCuenta{

        public int Id { get; set; }

        public string Nombre { get; set; }

        public int UsuarioId { get; set; }

        public int Orden { get; set; }

    }

}
```

#### Crear

Desarrollaremos la vista Crear dentro de una carpeta TiposCuentas dentro de las vistas


```CS
@model TipoCuenta

  

@{

    ViewData["Title"] = "Crear Tipo Cuenta";

}

  

<h1>Crear Tipo de Cuenta</h1>

<h5>El tipo de cuenta se refiere a cómo podemos agrupar cuentas.

    Ejemplo: Préstamos, tarjetas de crédito, etc.

</h5>

  

<form asp-controller="TiposCuentas" asp-action="Crear">

    <div class="mb-3">

        <label for="Nombre" class="form-label">Nombre</label>

        <label type="text" id="Nombre" name="Nombre" class="form-control"></label>

    </div>

  

    <button type="submit" class="btn btn-primary">Enviar</button>

</form>
```

Como podemos apreciar ya nos permite pasarle al controller el nombre de la categoria del usuario, sin embargo se le puede poner enviar y tener un valor NULL, lo evitaremos haciendo


### Validando el formulario

nunca hay que confiar en la data que venga del usuario, por ende siempre hay que validar y restringir que puede entrar al sistema para que solo sea usando en la función requerida

En .NET Core se puede realizar de varias formas, una de ellas es utilizando anotaciones de datos.

Estas anotaciones vienen en forma de atributos que podemos anexar a las propiedades de nuestros modelos, para indicar las variaciones que queremos que cumplan.

Ejemplo: Required, como su nombre menciona indica que es requerido dicho dato

TipoCuenta.cs
```CS
using System.ComponentModel.DataAnnotations;

//Anexamos la anotación para Nombre
[Required]

        public string Nombre { get; set; }
```

Sin embargo se envía la información. Lo que sucede es que no se evita que la acción se ejecute su el modelo es invalido.

TipoCuentasController.cs
```CS
[HttpPost]

        public IActionResult Crear(TipoCuenta tipoCuenta){
			// Revisa si no es vaido el estado del modelo
            if(!ModelState.IsValid){
				// Le reenviamos la vista con los datos previos del usuario para que no los tenga que volver a poner
                return View(tipoCuenta)

            }

            return View();

        }
```


Ahora toca relizar


### Visualizando los errores de Validación

Para ello podemos ayudarnos con el #Tag-helper asp-validation-sumarry, que puede detectar todos los errores o solo del modelo


Crear.cshtml
```CS
//arriba se encuentra los h's

<div asp-validation-summary="All" class="text-danger"></div>

// Abajo El formulario
```


ahora podremos obtener un mensaje de error similar al siguiente

![[Pasted image 20231116151854.png]]


Como podemos ver esta en ingles, a continuación veremos como poder personalizar los mensajes de error

TipoCuenta.cs
```CS
[Required(ErrorMessage = "El campo {0} es requerido")]

public string Nombre { get; set; }
```

Ahora podemos apreciar nuestro mensaje personalizado

![[Pasted image 20231116152240.png]]


Además de la anotación Required, tenemos StringLength, que nos permite definir la longitud mínima y máxima de un string.

TipoCuenta.cs
```CS
[Required(ErrorMessage = "El campo {0} es requerido")]

        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "La Longuitud del campo {0} debe estar entre {2} y {1} ")]

        public string Nombre { get; set; }
```


![[Pasted image 20231116154646.png]]


Como podemos apreciar la anotación de longitud de campo funciona 

### Tag Helpers para los campos

El siguiente Tag Helper nos ayudara a sincronizar el valor del modelo que enviamos desde el controlador a a vista con los valores del formulario.

Esto se resuelve muy sencillo.

Crear.cshtml

 <div class="mb-3">

        <label asp-for="Nombre" class="form-label"></label>

        <label type="text" class="form-control"></label>

    </div>
```CS

<div class="mb-3">

        <label asp-for="Nombre" class="form-label"></label>

        <input type="text" asp-for="Nombre" class="form-control"></input>

    </div>

```

Con el asp-for, con ello ya recibira cualquier cambio del controllador, si se cambia el nombre de la variable

Como anotacion adicional esta

Display que no permite cambiar el texto de la vista


TipoCuntas.cs
```CS
[Display(Name = "Nombre del tipo cuenta")]
```


### Otras validaciones por Defecto



TipoCuenta.cs
```CS
/*Pruebas de otras validaciones por defecto*/

  

        [Required(ErrorMessage = "El campo {0} es requerido")]

        [EmailAddress(ErrorMessage = "El campo debe ser un correo electrónico válido")]

        public string Email { get; set; }

        [Range(minimum: 18, maximum: 130, ErrorMessage = "El valor debe estar entr {1} y {2}")]

        public int  Edad { get; set; }

        [URL(ErrorMessage = "El campo debe tener una URL válida")]

        public string URL { get; set; }

        [CreditCard(ErrorMessage = "La tarjeta de credito no es valida")]
        [Display(nameof = "Tarjeta de Credito")]

        public string TarjetaDeCredito { get; set; }
```


Crear.cshtml
```CS
[CreditCard(ErrorMessage = "La tarjeta de credito no es valida")]

        [Display(name = "Tarjeta de Credito")]

        public string TarjetaDeCredito { get; set; }
```

PD: Colocamos la anotación display a razón de que sin ella aparecería el campo con nombre TarjetaDeCredito


Crear.cshtml
```CS
<!--Formulario para probar los otros tipos de anotaciones por defecto-->

  

    <div class="mb-3">

        <label asp-for="Email" class="form-label"></label>

        <input type="Email" asp-for="Email" class="form-control">

    </div>

  

    <div class="mb-3">

        <label asp-for="Edad" class="form-label"></label>

        <input type="Edad" asp-for="Edad" class="form-control">

    </div>

  

    <div class="mb-3">

        <label asp-for="URL" class="form-label"></label>

        <input type="URL" asp-for="URL" class="form-control">

    </div>

  

    <div class="mb-3">

        <label asp-for="TarjetaDeCredito" class="form-label"></label>

        <input type="TarjetaDeCredito" asp-for="TarjetaDeCredito" class="form-control">

    </div>
```

Al terminar tendremos algo por el estilo

![[Pasted image 20231116160553.png]]

Como podemos ver los errores se encuentran en la parte superior del formulario, a continuación podremos colocarlos en su respectivo campo.

Antes que nada hay que hablar sobre Front y Back-end




### Front-End y Back-End

#### Front-End

* Estamos hablando de la parte que el usuario visualiza
* HTML, CSS y JavaScript
* Con JS podeos ejecutar un lenguaje de programación en el navegador del usuario

#### Back-End

* Mientras que el back viene siendo la parte trasera de la aplicación
* para el usuario ejecutar código de JavaScript no tiene que esperar nada



### Validaciones en el Front-End

Para poder realizar dichas validadción en .NET Core se utiliza la librería de jQuery.

La primero será colocar un conjunto de spans al lado de cada campo del formulario en donde aparecerán los errores

Después incluiremos el archivo JS que realizara la validación por nosotros.


Crear.cshtml
```CS
<span asp-validation-for="Nombre" class="text-danger"></span>
```

Este es un ejemplo de span a colocar para el campo Nombre, recuerda colocarlo debajo de cada campo.

Ahora incluiremos el js dentro de la vista

Crear.cshtml
```CS
@section Scripts{

    <partial name= "_ValidationScriptsPartial" />

}
```

Ahora iremos dentro de esa vista parcial para añadirle
a razón de que usamos tarjeta de crédito necesitaos añadirle otras validaciones

ValidationScriptsPartial.cshtml
```CS
<script src="~/lib/jquery-validation/dist/additional-methods.min.js"></script>
```


y Finalmente podemos mencionar que las validaciones ya esta realizadas para dichos campos en nuestro formulario, además de ello gracias a la vista parcial de validaciones, ya que si hay una falla no permitirá que llegue a ejecutarse la acción de HttpPost

### Validaciones personalizadas por atributo

A pesar de que .NET tenga varias validacione por defecto, es imposible abarcar todas los posibles resultados.

En este caso haremos nuestra propia validación que revisara si la primera letra de un string sea mayuscula


empezamos creando una carpeta donde guardaremos las validaciones.

PrimeraLetraMayusculaAttribute.cs

```CS
using System.ComponentModel.DataAnnotations;

  

namespace ManejoPresupuesto.Validaciones{

    public class PrimeraLetraMayusculaAttribute : validationAttribute{

  

        protected override ValidationResult IsValid(object value, ValidationContext validationContext){

            if(value == null || string.IsNullOrEmpty(value.ToString())){

                return ValidationResult.Success;

            }

  

            var primerLetra = value.ToString()[0].ToString();

  

            if(primerLetra != primerLetra.ToUpper() ){

                return new ValidationResult("La primera letra debe ser mayúsculas"):

            }

  

            return ValidationResult.Success;

        }

    }

}
```


TipoCuenta.cs
```CS
using ManejoPresupuesto.Validaciones;

[PrimeraLetraMayuscula]
 public string Nombre { get; set; }
```

Recuerda para que no se te dupliquen las notificaiones de errores cambiar el resumen de ellas a solo recibir de errores del modelo

Crear.cshtml
```CS
<div asp-validation-summary="ModelOnly" class="text-danger"></div>
```


Como podemos ver a continuación nuestra validación ya esta funcionando

![[Pasted image 20231116170749.png]]


### Validaciones personalizadas por Modelo

Este tipo de validaciones nos permite realizarlas dentro de la clase

Una de sus ventajas es que permiten realizar validaciones complejas de varios campos.

Y la desventaja es que este tipo de validaciones esta acoplada al modelo en cuestión, es decir no puedes reciclar mucho código.

Repetiremos el ejemplo anterior con este tipo de validación.

Tenemos que agregarle la interfaz a nuetsra clase TipoCuenta IValidatableObject y la siguiente clase

TipoCuenta.cs
```CS
public IEnumerable<ValidationResult> Validate(ValidationContext validationContext){

            if( Nombre != null && Nombre.Length > 0) {

                var primeraLetra = Nombre[0].ToString();

  

                if(primeraLetra != primeraLetra.ToUpper()){

                    yield return new ValidationResult("La primera letra debe ser en mayúscula", new[] {nameof(Nombre)});

                }

            }

        }
```

Y como podemos apreciar el resultado es el mismo

![[Pasted image 20231116172909.png]]


### Comunicación con la DB - Connection Settings

Ahora lo que nos falta es cuando se reciba el post de tipo cuenta se cree en la DB

Y como primer paso hay que realizar la conexión con la DB

Para ello necesitamos un Conection String, es un conjunto de valores relacionados con una base de datos, y colocarlo en un proveedor de configuración.

appsettings.Development.json
```JSON
"ConnectionStrings":{

    "DefaultConnection": "Server=DESKTOP-KPI2L3M;Database=ManejoPresupuesto;Integrated Security=True"

//PD: De mi parte le agregue TrustServerCertificate=true, a razón de un error de confianza de SSL

  }
```

Ahora necesitamos ver como nos vamos a conectar con la DB, hay varias formas de hacerlo, como;

* ado.NET ??
* Dapper
* Entity Framework Core


En este caso utilizaremos

#### Dapper

Una librería que nos permite trabajar la capa de acceso a datos de nuestras aplicaciones, e si nos ayuda a mapear los resultados de un query a clases de C#.

Para instalarlo usaremos dotnet CLI y ejecutaremos los siguientes comando

```CLI
dotnet add package Dapper

dotnet add package Microsoft.Data.SqlClient
```

Ahora realizaremos una conexión de prueba solamente

TiposCuentasController.cs

```CS
using Dapper;

using ManejoPresupuesto.Models;

using Microsoft.AspNetCore.Mvc;

using Microsoft.Data.SqlClient;

private readonly string connectionString;


public TiposCuentasController(IConfiguration configuration){

            connectionString = configuration.GetConnectionString("DefaultConnection");

        }

public IActionResult Crear(){

  

            using (var connection = new SqlConnection(connectionString)){

                var query = connection.Query("SELECT 1").FirstOrDefault();

            }

  

            return View();

        }
```

### Insertando un Tipo de Cuenta en la DB

para esto crearemos un servicio, es decir una clase que vamos a poder utilizar con el sistema de inyección de dependencias.

La idea, recuerda, de que no queremos colocar el código de acceso a datos en nuestro controlador, ellos solo muestran vistas.

De antemano creamos un directorio de Servicios e Interfaces, recordando el principio de ""

RepositorioTiposCuentas.cs
```CS
using Dapper;

using ManejoPresupuesto.Interfaces;

using ManejoPresupuesto.Models;

using Microsoft.Data.SqlClient;

  

namespace ManejoPresupuesto.Servicios

{

    public class RepositorioTiposCuentas : IRepositorioTiposCuentas{

  

        private readonly string connectionString;

  

        public RepositorioTiposCuentas(IConfiguration configuration){

            connectionString = configuration.GetConnectionString("DefaultConnection");

        }

  

        public void  Crear(TipoCuenta tipoCuenta){

            using var connection = new SqlConnection(connectionString);

            var id = connection.QuerySingle<int>($@"INSERT INTO TiposCuentas (Nombre, UsuarioId, Orden)

                                                    VALUES (@Nombre, @UsuarioId, 0);

                                                    SELECT SCOPE_IDENTITY();", tipoCuenta);

            tipoCuenta.Id = id;

        }

  

    }

}

```


IRepositorioTiposCuentas.cs
```CS
using ManejoPresupuesto.Models;

  

namespace ManejoPresupuesto.Interfaces{

    public interface IRepositorioTiposCuentas{

        void Crear(TipoCuenta tipoCuenta);

    }

}
```

No se te olvide agregar el servicio al sistema

Program.cs
```CS
using ManejoPresupuesto.Interfaces;

using ManejoPresupuesto.Servicios;

builder.Services.AddTransient<IRepositorioTiposCuentas, RepositorioTiposCuentas>();
```

Ahora nos falta utilizar el nuevo servicio creando

TiposCuentasControler.cs
```CS
using ManejoPresupuesto.Interfaces;

using ManejoPresupuesto.Models;

using Microsoft.AspNetCore.Mvc;

private readonly IRepositorioTiposCuentas repositorioTiposCuentas;

  

        public TiposCuentasController(IRepositorioTiposCuentas repositorioTiposCuentas){

            this.repositorioTiposCuentas = repositorioTiposCuentas;

        }

[HttpPost]

        public IActionResult Crear(TipoCuenta tipoCuenta){

            if(!ModelState.IsValid){

                return View(tipoCuenta);

            }

  

            repositorioTiposCuentas.Crear(tipoCuenta);

            return View();

        }

```


Ahora para probar necesitamos un usuario, de momento agreguemos uno usando SMSS

![[Pasted image 20231116190356.png]]

ahora seleccionaremos el usuario

```CS
[HttpPost]

        public IActionResult Crear(TipoCuenta tipoCuenta){

            if(!ModelState.IsValid){

                return View(tipoCuenta);

            }

  

            tipoCuenta.UsuarioId = 1;

            repositorioTiposCuentas.Crear(tipoCuenta);

            return View();

        }
```

Al probarlo podremos ver que finalmente logramos tener nuestro primer registro en la DB

![[Pasted image 20231116190847.png]]

Sin embargo realizamos una mala praxis al conectarnos con la DB, deberíamos haber usado


### Programación Asíncrona

Un método puede ser síncrono o asíncrono, de momento todos nuestros métodos han sido síncronos.

* Un método síncrono es aquel el cual, al ser ejecutado, debemos esperar a que termine y no podemos hacer nada mientras tanto.


* Las funciones asíncronas se ejecutan y de inmediato retornan, aún si no han terminado de ejecutarse.
* La programación asíncrona la debemos utilizar cuando realizamos operaciones I/O.
* La ventaja de usar programación asíncrona e que nuestros sistemas son así mas eficientes.
* En C#, para utilizar programación asíncrona utilizamos async-await.
* Task representa una operación nueva a finalizar en el futuro.


Ahora que conocemos sobre programación asíncrona, editaremos nuestro código en nuestra operación I/O.


#### Aplicando la programación asíncrona

RepositorioTiposCuentas.cs
```CS
public async Task  Crear(TipoCuenta tipoCuenta){

            using var connection = new SqlConnection(connectionString);

            var id = await connection.QuerySingleAsync<int>($@"INSERT INTO TiposCuentas (Nombre, UsuarioId, Orden)

                                                    VALUES (@Nombre, @UsuarioId, 0);

                                                    SELECT SCOPE_IDENTITY();", tipoCuenta);

            tipoCuenta.Id = id;

        }
```

IRepositorioTiposCuentas.cs
```CS
public interface IRepositorioTiposCuentas{

        Task Crear(TipoCuenta tipoCuenta);

    }
```

TiposCuentasControler.cs
```CS
[HttpPost]

        public async Task<IActionResult> Crear(TipoCuenta tipoCuenta){

            if(!ModelState.IsValid){

                return View(tipoCuenta);

            }

  

            tipoCuenta.UsuarioId = 1;

            await repositorioTiposCuentas.Crear(tipoCuenta);

            return View();

        }
```

PD: Task, no retorna nada en especifico, sin embargo en este caso hay que indicarle que tomara un IActionResult ya que nos retornara una vista.

### Validaciones Personalizadas a Nivel del Controlador

Ya hemos visto #validaciones a nivel del modelo y #validaciones por atributo.

Es hora de hablar de validaciones a nivel del controlador. Estas las usamos típicamente cuando las validaciones involucran DB.

En estos momento lo que pasa es que se permite tener el mismo nombre de TipoCuenta más de una vez.

Para evitar esto haremos lo siguiente.

Realizaemos un metodo en donde revise si ya exite un TipoCuenta con el nombr indicado.


RepositorioTiposCuentas.cs
```CS
public async Task<bool> Existe(string nombre, int usuarioId){

            using var connection = new SqlConnection(connectionString);

            var existe = await connection.QueryFirstOrDefaultAsync<int>(@"SELECT 1

                                                                    FROM TiposCuentas

                                                                    WHERE Nombre = @Nombre AND UsuarioId = @UsuarioId;

                                                                    ", new {nombre, usuarioId});

            return existe == 1;

        }
```

IRepositorioTiposCuentas.cs
```CS
Task<bool> Existe(string nombre, int usuarioId);
```

Ahora tenemos que añadir la validación en la acción

TiposCuentasControler.cs
```CS
var yaExisteTipoCuenta = await repositorioTiposCuentas.Existe(tipoCuenta.Nombre, tipoCuenta.UsuarioId);

  

            if(yaExisteTipoCuenta){

                ModelState.AddModelError(nameof(tipoCuenta.Nombre), $"El nombre {tipoCuenta.Nombre} ya existe.");

  

                return View(tipoCuenta);

            }

  

            await repositorioTiposCuentas.Crear(tipoCuenta);
```

Como podemos ver al ejecutar el proyecto a validación por controlador ya esta funcionando

![[Pasted image 20231117095202.png]]

Sin embargo, tenemos una situación, la validación se realiza cuando el usuario presiona el botón enviar, cuando para mejorar la UX tendría que ser al terminar de llenar el campo.


### Validaciones Personalizadas con JS Utilizando Remote

Para ello vamos a realizar una validación con JS del servidor. Después utilizaremos el atributo Remote para llamar dicha acción desde el navegador del usuario.

Como su nombre lo indica, es un atributo que nos permite realizar validaciones de forma remota, desde JS.

Para lograr que JS se comunique con C#, nos vemos forzados a hacer una pertición HTTP del front al back.


TiposCuentasController.cs
```CS
[HttpGet]

  

        public async Task<ActionResult> VerificarExisteTipoCuenta(string nombre){

            var usuarioId = 1;

            var yaExisteTipoCuenta = await repositorioTiposCuentas.Existe(nombre, usuarioId);

  

            if(yaExisteTipoCuenta){

                return Json($"El nombre {nombre} ya existe");

            }

  
  

            return Json(true);

        }
```

Ahora tenemos que enlazar la acción a una propiedad de tipo cuenta, en este caso Nombre.


TipoCuentas.cs
```CS
[Required(ErrorMessage = "El campo {0} es requerido")]

        //[StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "La Longuitud del campo {0} debe estar entre {2} y {1} ")]

        [PrimeraLetraMayuscula]

        [Remote(action:"VerificarExisteTipoCuenta", controller:"TiposCuentas")]

        public string Nombre { get; set; }
```

Como era esperado el resultado es el mismo, sin embargo podemos apreciar al salir del textbox ya nos indica que la validación se implemento de forma correcta.


### Listado leyendo TiposCuentas

Ya podemos agregar a la DB varios Tipos de Cuenta, ahora hay que poder visualizarlos


RepositorioTiposCuentas.cs
```CS
public async Task<IEnumerable<TipoCuenta>> Obtener(int usuarioId){

            using var connection = new SqlConnection(connectionString);

  

            return await connection.QueryAsync<TipoCuenta>(@"SELECT Id, Nombre, Orden

                                                            FROM TiposCuentas

                                                            WHERE UsuarioId = @UsuarioId

                                                            ", new {usuarioId});

        }
```

IRepositorioTipoCuentas.cs
```CS
Task<IEnumerable<TipoCuenta>> Obtener(int usuarioId);
```


Ahora haremos la acción en tiposCuentasControler.cs

```CS
public async Task<IActionResult> Index(){

            var usuarioId = 1;

            var TiposCuentas = await repositorioTiposCuentas.Obtener(usuarioId);

            return View(TiposCuentas);

        }
```

PD: Como ejemplo usamos nombre Index debido a que regresa un listado

Ahora es momento de crear esa nueva vista

Index.cshtml
```CS
@model IEnumerable<TipoCuenta>

  

@{

    ViewData["Title"] = "Tipos Cuenta";

}

  

<h1>Tipos de Cuenta</h1>

<h5>El tipo de cuenta se refere a cómo podemos agrupar cuentas.

    Ejemplo: Préstamos, tarjetas de crédito, etc.

</h5>

  

    <a asp-action="Crear" class="btn btn-primary mb-3">Crear nuevo</a>

  

    <table class="table">

        <thead>

            <tr>

                <th>Acciones</th>

                <th>Nombre</th>

            </tr>

        </thead>

        <tbody>

            @foreach (var TipoCuenta in Model){

                <tr>

                    <td>

                        <a class="btn btn-primary">Editar</a>

                        <a class="btn btn-danger">Borrar</a>

                    </td>

                    <td>

                        @TipoCuenta.Nombre

                    </td>

                </tr>

            }

        </tbody>

    </table>
```

realizamos un pequeño cambio en 

Crear.cshtml
```CS
//Boton de enviar
<a asp-action="Index" class="btn btn-secondary">Cancelar</a>
```

Lo agregamos por si el usuario no quiere agregar un nuevo tipo de cuenta para poderlo regresar a Index

Tambien un pequeño cambio en TiposCuentasController.cs

```CS
return RedirectToAction("Index");
```

para que cuando el usuario registre un nuevo Tipo de Cuenta sea redirigido a Index, su listado

Aunado a ello modificaremos

\_Layout.cshtml
```CS
<a class="nav-link text-dark" asp-controller="TiposCuentas" asp-action="Index">Tipos Cuenta</a>
```

Solamente para ya tenerlo disponible en el NavBar

![[Pasted image 20231117103833.png]]

Este es el resultado de nuestro avance, ya podemos visualizar los tipos de cuenta del usuario y crear nuevos, junto a un regreso si no desea hacerlo.

Al transcurso de esto hemos repetido y harcodeado el valor UsuarioId, ahora evitaremos hacerlo con


### Evitando Repetir Código

A razón de que hemos estado limitando el UsuarioId en muchas partes del código cuando queramos realizar un cambio, tendremos que hacerlo en cada una de las veces que este en uso.

Así que crearemos un método el cual nos regresara el id del usuario, centralizando la acción cuando tengamos el sistema de usuario solamente tendremos que realizar un cambio.

Asi que creemos el servicio.

ServicioUsuarios.cs
```CS
using ManejoPresupuesto.Interfaces;

  

namespace ManejoPresupuesto.Servicios{

    public class ServicioUsuarios : IServicioUsuarios{

        public int ObtenerUsuarioId(){

            return 1;

        }

    }

}
```

IServicioUsuarios.cs
```CS
namespace ManejoPresupuesto.Interfaces{

    public interface IServicioUsuarios{

        int ObtenerUsuarioId();

    }

}
```

Que no se te olvide colocar el nuevo servicio en

Program.cs
```CS
builder.Services.AddTransient<IServicioUsuarios, ServicioUsuarios>();
```

ahora lo utilizaremos en el controlador

TiposCuentaControler.cs
```CS


private readonly IRepositorioTiposCuentas repositorioTiposCuentas;

        private readonly IServicioUsuarios servicioUsuarios;

  

        public TiposCuentasController(IRepositorioTiposCuentas repositorioTiposCuentas, IServicioUsuarios servicioUsuarios){

            this.repositorioTiposCuentas = repositorioTiposCuentas;

            this.servicioUsuarios = servicioUsuarios;

        }
```

Ahora sustituiremos cada uno por 

TiposCuentasControler.cs
```CS
var usuarioId = servicioUsuarios.ObtenerUsuarioId();
```

Seguirá siendo el mismo resultado sin embargo solamente tendremos que modificar el servicio y listo.


### Actualizar Tipos de Cuentas

Ahora la idea es que una vez un registro haya sido creado este pueda ser actualizado.

Agregaremos dicha acción en

RepositorioTiposCuentas.cs
```CS
public async Task Actualizar(TipoCuenta tipoCuenta){

            using var connection = new SqlConnection(connectionString);

            await connection.ExecuteAsync(@"UPDATE TiposCuenta

                                            SET Nombre = @Nombre

                                            WHERE Id = @Id

                                            ", tipoCuenta);

        }
```

PD: ExecuteAsync en una función que permite ejecutar un query de forma asyncrona sin retornar nada

Junto a ello hay que permitir obtener el tipo de cuenta por Id

RepositorioTiposCuentas.cs
```CS
public async Task<TipoCuenta> ObtenerPorId(int id, int usuarioId){

            using var connection = new SqlConnection(connectionString);

            return await connection.QueryFirstOrDefaultAsync<TipoCuenta>(@"SELECT Id, Nombre, Orden

                                                                    FROM TiposCuentas

                                                                    WHERE Id = @Id AND UsuarioId = @UsuarioId

                                                                    ", new {id, usuarioId});

        }
```

IRepositorioTiposCuentas.cs
```CS
Task Actualizar(TipoCuenta tipoCuenta);

Task<TipoCuenta> ObtenerPorId(int id, int UsuarioId);
```

ahora lo utilizaremos en

TiposCuentasControler.cs
```CS
[HttpGet]

        public async Task<ActionResult> Editar(int Id){

            var usuarioId = servicioUsuarios.ObtenerUsuarioId();

            var tipoCuenta = await repositorioTiposCuentas.ObtenerPorId(Id,usuarioId);

  

            if(tipoCuenta is null){

                return RedirectToAction("NoEncontrado", "Home");

            }

  

            return View(tipoCuenta);

        }
```

Vamos a desarrollar la vista de

Editar.cshtml
```CS
@model TipoCuenta

  

@{

    ViewData["Title"] = "Editar";

}

  

<h1>Editar Tipo Cuenta: @Model.Nombre</h1>

  

<div asp-validation-summary="ModelOnly" class="text-danger"></div>

  

<form asp-action="Editar">

    <input type="hidden" asp-asp-for="Id">

    <div class="mb-3">

        <label asp-for="Nombre" class="form-label"></label>

        <input type="text" asp-for="Nombre" class="form-control"></input>

        <span asp-validation-for="Nombre" class="text-danger"></span>

    </div>

    <button type="submit" class="btn btn-primary">Enviar</button>

    <a asp-action="Index" class="btn btn-secondary">Cancelar</a>

</form>

  

@section Scripts{

    <partial name= "_ValidationScriptsPartial" />

}
```


Ahora editaremos TiposCuntasControler.cs para cuando reciba información de la edición

TiposCuentasControler.cs
```CS
[HttpPost]

        public async Task<IActionResult> Editar(TipoCuenta tipoCuenta){

            var usuarioId = servicioUsuarios.ObtenerUsuarioId();

            var tipoCuentaExiste = await repositorioTiposCuentas.ObtenerPorId(tipoCuenta.Id, usuarioId);

  

            if(tipoCuentaExiste is null){

                return RedirectToAction("NoEncontrado", "Home");

            }

  

            return RedirectToAction("Index");

        }
```


Ahora hay que crear la acción de NoEncontrado por si no existe ese tipoCuenta


HomeControler.cs
```CS
public IActionResult NoEncontrado(){

        return View();

    }
```

Ahora desarrollaremos la vista en la carpeta Home 

NoEncontrado.cshtml
```CS
@{

    ViewData["Title"] = "No Encontrado";

}

  

<h1>El recurso solicitado no ha sido encontrado</h1>

  

<h3>Click aquí para regresar al <a asp-action="Index">home</a></h3>
```

a continuación hay que editar 

Index.cshtml
```CS
<a class="btn btn-primary" asp-action="Editar" asp-route-id="@TipoCuenta.Id">Editar</a>
```

para que tenga una redirección a la vista Editar junto con el parámetro de Id, para saber que usuario esta solicitando dicha acción.

![[Pasted image 20231117115145.png]]

Como podemos apreciar ya podemos editar registros de TipoCuenta.

Además de validar nuestro mecanismos de seguridad por si un Tipo de cuenta no existe o si el usuario intenta acceder a otros de otro usuario

![[Pasted image 20231117120031.png]]


### Borrar Tipos Cuentas

Empezemos creando el metodo de borrado en

RespositorioTiposCuentas.cs
```CS
public async Task Borrar(int Id){

            using var connection = new SqlConnection(connectionString);

            await connection.ExecuteAsync("DELETE TiposCuentas WHERE Id = @Id", new{Id});

        }
```

IRespositorioTiposCuentas.cs
```CS
Task Borrar(int Id);
```

TiposCuentasController.cs
```CS
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
```


Ahora desarrollemos la vista de

Borrar.cshtml
```CS
@model TipoCuenta;

  

@{

    ViewData["Title"] = "Borrar Tipo Cuenta";

}

  

<h3 class="mb-3">¿Estas seguro que desea borrar el tipo cuenta @Model.Nombre?</h3>

  

<form asp-action="BorrarTipoCuenta">

    <input type="hidden" asp-for="Id">

    <button type="submit" class="btn btn-danger">Borrar</button>

    <a asp-action="Index" class="btn btn-secondary">Cancelar</a>

</form>
```

ahora en Index.cshtml
```CS
<a class="btn btn-danger" asp-action="Borrar" asp-route-id="@TipoCuenta.Id">Borrar</a>
```

Como podemos apreciar a continuación cuando seleccionamos que queremos borrar algún registro nos denota lo siguiente

![[Pasted image 20231117122413.png]]


### Arrastrando Filas de una Tabla

Finalmente utilizaremos el campo de Orden para darle más control al usuario dentro de su experiencia.

Ahora le permitiremos al usuario que pueda reorganizar sus Tipos de cuentas a gusto.

Esto lo podremos lograr gracias a la librería de JQueryUI, usando su fnción Sortable o reorganizar en español.

Para poder empezar hay que ir a la siguiente liga para descargar la versión estable [JQueryUI](https://jqueryui.com/)

Al tenerlo lo incorporaremos al directorio lib en wwwroot.

Para más tarde anexarlo en 

\_Layout.cshtml
```CS
<script src="~/lib/jquery-ui/jquery-ui.min.js"></script>
```


Ahora comenzaremos par apoder reorganizar los tipos cuenta editando

Index.cshtml
```CS
<tbody id="reordenable"> //Lo importante es darle el id al tbody

@section Scripts{

        <script>

            $(function(){

                $("#reordenable").sortable();

            })

        </script>

    }
```

Además le incorporaremos un CSS personalizado

custom.css
```CSS
#reordenable{

    cursor: move;

}
```

incorporamos el css a

\_Layout.cshmtl
```CS
<link rel="stylesheet" href="~/css/custom.css" asp-append-version="true">
```

Para poder apreciar su uso incorpore el tipo "Tarjeta de Credito" y podemos ver que podemos reoganizar los Tipos de Cuentas

![[Pasted image 20231117124619.png]]

![[Pasted image 20231117124634.png]]

Lo gracioso es que de momento es solo visual, si refrescas la pagina encontraras que no se mantiene es orden, lo solucionaremos en la DB con

### Haciendo un post con el FETCH API

La razón por la cual se deshace el reordenamiento que hicimos es porque no estamos persistiendo el cambio de orden en la DB.

Para ello vamos hacer una petición Http desde el navegador con JS.

Esto lo lograremos con AJAX, Asynchronous JavaScript and XML.

Una técnica que nos permite comunicarnos con el servidor web utilizando el código de JS sin tener que estar refrescando el navegador, permitiendo que la aplicación sea más fluida.



para empezar hay que crear una acción que se ejecutar cuando arrastremos las filas de la tabla.


TiposCuentasController.cs
```CS
[HttpPost]

  

        public async Task<IActionResult> Ordenar([FromBody] int[] Ids){

            return Ok();

        }
```

Para continuar necesitamos obtener los ids de cada tipo Cuenta en el orden actual

Index.cshtml
```CS
<td>

                        <input type="hidden" value="@TipoCuenta.Id" class="Ids">

@section Scripts{
  

        <script>

			 const urlOrdenar = '@Url.Action("ordenar")';

            $(function(){

                $("#reordenable").sortable({

                    stop: async function(e,ui){

                        await actualizarOrdenes();

                    }

                });

  

                async function actualizarOrdenes(){

                    const ids = obtenerIdsDeElementos();

                    await enviarIdsAlBackend(ids);

                }

  

                function obtenerIdsDeElementos(){

                    const ids = $(".Ids").map(function(){

                        return $(this).val();

                    }).get();

  

                    return ids;

                }

  

                async function enviarIdsAlBackend(ids){

                    var data = JSON.stringify(ids);

  

                    await fecth(urlOrdenar, {

                        method: 'POST',

                        body: data,

                        headers: {

                            'Content-Type':'application/json'

                        }

                    });

                }

  

            })
  

            async function actualizarOrdenes(){

                const ids = obtenerIdsDeElementos();

                await enviarIdsAlBackend(ids);

            };

  

            function obtenerIdsDeElementos(){

                const ids = $(".Ids").map(function(){

                    return $(this).val();

                }).get();

  

                return ids;

            };

  

            async function enviarIdsAlBackend(ids){

                var data = JSON.stringify(ids);

  

                await fetch(urlOrdenar, {

                    method: 'POST',

                    body: data,

                    headers: {

                        'Content-Type':'application/json'

                    }

                });

            }

  
  

        </script>

    }
```

Ya pudimos obtener el orden de los ids ahora falta poderlos poner en la DB

### Aplicando Multiples Queries a la DB

Ahora haremos metodo que recibira los ids orndenados en

RepositorioTiposCuentas.cs
```CS
public async Task Ordenar(IEnumerable<TipoCuenta> tipoCuentasOrdenadas){

            var query = "UPDATE TiposCuentas SET Orden = @Orden WHERE Id = @Id";

            using var connection = new SqlConnection(connectionString);

            await connection.ExecuteAsync(query, tipoCuentasOrdenadas);

        }
```

IRepositorioTiposCuentas.cs
```CS
Task Ordenar(IEnumerable<TipoCuenta> tipoCuentasOrdenados);
```

vamos a implementar dicho metodo

TiposCuentasControler.cs
```CS
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
```

Y para terminar hay que editar un query para desplegarlos en un orden en especifico

RepositorioTiposCuentas.cs
```CS
public async Task<IEnumerable<TipoCuenta>> Obtener(int usuarioId){

            using var connection = new SqlConnection(connectionString);

  

            return await connection.QueryAsync<TipoCuenta>(@"SELECT Id, Nombre, Orden

                                                            FROM TiposCuentas

                                                            WHERE UsuarioId = @UsuarioId

                                                            ORDER BY Orden

                                                            ", new {usuarioId});

        }
```

Y en este momento podremos reorganizar los tipos de cuentas y salvar su orden en la db

![[Pasted image 20231117160809.png]]

![[Pasted image 20231117160753.png]]

Como podemos ver su orden se reestablece en la db de forma correcta

Sin embargo hay algo que nos falta, que es sobre.


### Generando el Orden Correcto al insertar - Procedimiento almacenado con Dapper

Si recuerdas en nuestro método Crear, indicamos que el orden de la inserción es 0, lo que queremos es que sea el mayor, el ultimo en el orden.

Y a razón de que son muchas operaciones lo emplearemos en un procedimiento almacenado.

SP TiposCuentasInsertar.sql
```SQL
CREATE PROCEDURE TiposCuentasInsertar
	-- Add the parameters for the stored procedure here
	@Nombre nvarchar(50),
	@UsuarioId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DECLARE @Orden int;
	SELECT @Orden = COALESCE(MAX(Orden), 0)+1
	FROM TiposCuentas
	WHERE UsuarioId = @UsuarioId
	
	INSERT INTO TiposCuentas(Nombre, UsuarioId, Orden)
	VALUES (@Nombre, @UsuarioId, @Orden);

	SELECT SCOPE_IDENTITY();
END
```

PD: COALESCE recibe un parámetro valida si es diferente de nulo, si es correcto lo usara sino usara el valor siguiente, y le damos 0 para que empiece el orden desde ahí para después sumarle 1 y como resultado tendrá el orden 1.

Lo que nos permite este SP es obtener el ID del elemento creado e insertado en el ultimo orden


Ahora implementemos dicho SP

RepositorioTiposCuentas.cs
```CS
public async Task  Crear(TipoCuenta tipoCuenta){

            using var connection = new SqlConnection(connectionString);

            var id = await connection.QuerySingleAsync<int>("TiposCuentasInsertar", tipoCuenta);

            tipoCuenta.Id = id;

        }
```


Modificamos solamente el query del método Crear, y además no hay que pasarle tipoCuentas, a razón de que esa forma le pasa todos los parámetros del modelo.

Entonces para solucionar eso hay que crear un objeto anónimo con solo los parámetros requeridos

Así que quedaría de esta forma.

RepositorioTiposCuentas.cs
```CS
public async Task  Crear(TipoCuenta tipoCuenta){

            using var connection = new SqlConnection(connectionString);

            var id = await connection.QuerySingleAsync<int>("TiposCuentasInsertar", new {usuarioId = tipoCuenta.UsuarioId, nombre = tipoCuenta.Nombre}, commandType: System.Data.CommandType.StoredProcedure);

            tipoCuenta.Id = id;

        }
```

Para validar el correcto uso de nuestro SP y agregaremos un nuevo dato de tipo de cuentas

![[Pasted image 20231117163149.png]]

![[Pasted image 20231117163207.png]]

Y como podemos ver en su inserción tiene el número de orden 3




## Los Otros CRUD's 

### Intro

En esta parte del proyecto veremos

* CRUD´s
	* Cuentas
	* Categorías
	* Transacciones
	*
* Formularios nuevos
	* Dropdown
	* Uso de fechas

#### Resumen

En este modulo trabajamos

* CRUD's (Cuentas, Categorías y transacciones)
* Dropdown o select
* Aislamiento de CSS
* AutoMapper
* Dropdown cascada o dependiente
* Fecha

### Formulario de Cuentas

Ahora es momento de trabajar con nuestra identidad de cuantas, para que el usuario pueda manejar distintos balances como; Banco, tarjeta de crédito, préstamo.


Empecemos desarrollando el modelo de la cuenta

Cuentas.cs
```CS
using System.ComponentModel.DataAnnotations;

using ManejoPresupuesto.Validaciones;

  

namespace ManejoPresupuesto.Models{

    public class Cuenta{

        public int  Id { get; set; }

        [Required(ErrorMessage="El campo {0} es requerido")]

        [StringLength(maximumLength: 50)]

        [PrimeraLetraMayuscula]

        public string Nombre { get; set; }

        [Display(Name = "Tipo Cuenta")]

        public int TipoCuentaId { get; set; }

        public decimal Balance { get; set; }

        [StringLength(maximumLength: 1000)]

        public string Descripcion { get; set; }

    }

}
```


Ahora necesitamos pensar que vamos a tener en el formulario de insertar Cuenta, porque no es solamente los datos de arriba, vamos a necesitar un SELECT, el cual nos devuelva las opciones posibles de tipos de cuenta, cómo lo tenemos en la clase es un entero sin embargo necesitamos una colección en donde estén todos los tipos de cuenta para mostrárselo al usuario en un select o dropdown.

Para lograr eso empezaremos creando una nueva clase que heredara de Cuenta y esa clase será el modelo de la vista que va a contener el formulario de creación de la cuenta.


CuentaCreacionViewModel.cs
```CS
using Microsoft.AspNetCore.Mvc.Rendering;

  

namespace ManejoPresupuesto.Models{

    public class CuentaCreacionViewModel : Cuenta{

        public IEnumerable<SelectListItem> TiposCuentas { get; set;}

    }

}
```

SelectListItem es una clase especial que nos permite crear SELECTs de una manera muy sencilla

Ahora creemos el controlador de cuentas 

CuentasController.cs
```CS
using Microsoft.AspNetCore.Mvc;

  

namespace ManejoPresupuesto.Controllers{

    public class CuentasController : Controller {

        [HttpGet]

        public IActionResult Crear(){

            return View();

        }

    }

}
```

Ahora necesitamos cargar el modelo que vamos a enviar a la vista, para ello necesitamos el listado de tipos cuenta, lo obtendremos de uno de nuestros servicios.


CuentasController.cs
```CS

using ManejoPresupuesto.Interfaces;

using ManejoPresupuesto.Models;

using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.Rendering;

  

namespace ManejoPresupuesto.Controllers{

    public class CuentasController : Controller {

        private readonly IRepositorioTiposCuentas repositorioTiposCuentas;

        private readonly IServicioUsuarios serviciousuarios;

  

        public CuentasController(IRepositorioTiposCuentas repositorioTiposCuentas, IServicioUsuarios servicioUsuarios){

            this.repositorioTiposCuentas = repositorioTiposCuentas;

            this.serviciousuarios = servicioUsuarios;

        }

  

        [HttpGet]

        public async Task<IActionResult> Crear(){

            var usuarioId = serviciousuarios.ObtenerUsuarioId();

            var TiposCuentas = await repositorioTiposCuentas.Obtener(usuarioId);

            var modelo = new CuentaCreacionViewModel();

            modelo.TiposCuentas = TiposCuentas.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));

            return View(modelo);

        }

    }
}
```

Con esto ya podemos desarrollar la vista

Para mayor legibilidad del proyectos creamos una nueva carpeta dentro de views "Cuentas" y el siguiente archivo, vista.

Crear.cshtml
```CS
@model CuentaCreacionViewModel

  

@{

    ViewData["Title"] = "Crear Cuenta";

}

  

<h1>Crear Cuenta</h1>

<h5>La cuenta se refiere a lso distintos balances que tienes; taretas de credito, cuenta de ahorro, préstamo, etc.</h5>

  

<form asp-action="Crear">

    <div asp-validation-summary="ModelOnly" class="text-danger"></div>

  

    <div class="mb-3">

        <label asp-for="Nombre" class="form-label"></label>

        <input asp-for="Nombre" class="form-control" />

        <span asp-validation-for="Nombre" class="text-danger"></span>

    </div>

  

    <div class="mb-3">

        <label asp-for="TipoCuentaId" class="form-label"></label>

        <select asp-for="TipoCuentaId" asp-items="Model.TiposCuentas" class="form-select"></select>

        <span asp-validation-for="TipoCuentaId" class="text-danger"></span>

    </div>

  

    <div class="mb-3">

        <label asp-for="Balance" class="form-label"></label>

        <input asp-for="Balance" class="form-control" />

        <span asp-validation-for="Balance" class="text-danger"></span>

    </div>

  

    <div class="mb-3">

        <label asp-for="Descripcion" class="form-label"></label>

        <textarea asp-for="Descripcion" class="form-control"></textarea>

        <span asp-validation-for="Descripcion" class="text-danger"></span>

    </div>

  
  

    <button type="submit" class="btn btn primary">Enviar</button>

    <a class="btn btn-secondary" asp-action="Index"></a>

</form>

  

@section Scripts{

    <partial name="_ValidationScriptsPartial" />

}
```

Nuestro formulario se vera algo así



![[Pasted image 20231117173325.png]]

Continuaremos con el backend para

### Insertar Cuenta

para empezar vamos a tener que crear nuestro repositorio de Cuentas 

RepositorioCuentas.cs
```CS
using Dapper;

using ManejoPresupuesto.Interfaces;

using ManejoPresupuesto.Models;

using Microsoft.Data.SqlClient;

  

namespace ManejoPresupuesto.Servicios{

    public class RepositoriCuentas : IRepositorioCuentas{

        private readonly string connectionString;

  

        public RepositoriCuentas(IConfiguration configuration){

            connectionString = configuration.GetConnectionString("DefaultConnection");

        }

  

        public async Task Crear(Cuenta cuenta){

            using var connection = new SqlConnection(connectionString);

            var id = await connection.QuerySingleAsync<int>(@"INSERT INTO Cuentas (Nombre, TipoCuentaId, Descripción, Balance)

                                                        VALUES (@Nombre, @TipoCuentaId, @Descripcion, @Balance);

  

                                                        SELECT SCOPE_IDENTITY();", cuenta);

  

            cuenta.Id = id;

        }

  

    }

}
```

IRepositorioCuentas.cs
```CS
using ManejoPresupuesto.Models;

  

namespace ManejoPresupuesto.Interfaces{

    public interface IRepositorioCuentas{

        Task Crear(Cuenta cuenta);

    }

}
```

agreguemos el servicio en

program.cs
```CS
builder.Services.AddTransient<IRepositorioCuentas, RepositoriCuentas>();
```

Y anexarlo al constructor de controlador

CuentasController.cs
```CS
private readonly IRepositorioTiposCuentas repositorioTiposCuentas;

        private readonly IServicioUsuarios serviciousuarios;

        private readonly IRepositorioCuentas repositorioCuentas;

  

        public CuentasController(IRepositorioTiposCuentas repositorioTiposCuentas, IServicioUsuarios servicioUsuarios, IRepositorioCuentas repositorioCuentas){

            this.repositorioTiposCuentas = repositorioTiposCuentas;

            this.serviciousuarios = servicioUsuarios;

            this.repositorioCuentas = repositorioCuentas;

        }
```

Ya que utilizaremos mucho la obtención de los TiposCuentas, centralicemos dicho proceso.


CuentasController.cs
```CS
private async Task<IEnumerable<SelectListItem>> ObtenerTiposCuentas(int usuarioId){

            var TiposCuentas = await repositorioTiposCuentas.Obtener(usuarioId);

  

            return TiposCuentas.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));

        }
```

El código completo quedaria algo así

CuentasController.cs
```CS
private async Task<IEnumerable<SelectListItem>> ObtenerTiposCuentas(int usuarioId){

            var TiposCuentas = await repositorioTiposCuentas.Obtener(usuarioId);

  

            return TiposCuentas.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));

        }
```

De momento lo que podemos probar es la inserción en Cuentas, al usar nuestro Formulario

![[Pasted image 20231117181601.png]]

al darle clic en enviar revisaremos la db con este resultado

![[Pasted image 20231117181644.png]]

PD: NO te preocupes si te aparece un error de redirección, recuerda que no tenemos la vista Index todavía.

### Índice de Cuentas - Query

ya que podemos grabar cuentas, vamos a crear la funcionalidad de mostrar el listado de cuentas del usuario, estas cuentas van a estar agrupadas por Tipo de Cuentas, además haremos un calculo de sumatoria total y por tipo de cuenta de los distintos balances.


Empecemos creando el query que traer los datos de las cuentas, sus balances y el tipo de cuenta

RepositorioCuenta.cs
```CS
public async Task<IEnumerable<Cuenta>> Buscar(int usuarioId){

            using var connection = new SqlConnection(connectionString);

  

            return await connection.QueryAsync<Cuenta>(@"SELECT Cuentas.Id, Cuentas.Nombre, Balance, tc.Nombre AS TipoCuenta

                                                        FROM Cuentas

                                                        INNER JOIN TiposCuentas tc

                                                        ON tc.Id = Cuentas.TipoCuentaId

                                                        WHERE tc.UsuarioId = @UsuarioId

                                                        ORDER BY tc.Orden", new {usuarioId});

        }
```

No se te olvide agregar el atributo en 

Cuenta.cs
```CS
public string TipoCuenta { get; set; }
```

y en nuestra interface

IRepositorioCuentas.cs
```CS
Task<IEnumerable<Cuenta>> Buscar(int usuarioId);
```

Ahora crearemos una clase que va a representar el modelo de la vista Index que vamos a crear en esta vamos a tener la sumatoria de los balances.

IndiceCuentasViewModel.cs
```CS
namespace ManejoPresupuesto.Models{

    public class IndiceCuentasViewModel{

        public string TipoCuenta { get; set; }

        public IEnumerable<Cuenta> Cuentas { get; set; }

        public decimal Balance => Cuentas.Sum(x => x.Balance);

    }

}
```


Ahora haremos la acción para la vista

CuentasController.cs
```CS
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
```

Ahora vamos a desarrollar de forma sencilla la vista

Index.cshtml
```CS
@model IEnumerable<IndiceCuentasViewModel>

  

@{

    ViewData["Title"] = "Cuentas";

}

  

<h1>Cuentas</h1>

  

<a asp-action="Crear" class="btn btn-primary mb-3">Crear nueva</a>
```

Y anexamos Cuentas en

\_Layout.cshtml
```CS
<li class="nav-item">

                            <a class="nav-link text-dark" asp-controller="Cuentas" asp-action="Index">Cuenta</a>

                        </li>
```


tendremos algo por el estilo

![[Pasted image 20231117190341.png]]

Continuaremos trabajando con


### Índice de Cuentas Vista 21/11/2023 9:03am

Empezaremos mostrando los totales de nuestros activos y pasivos junto al total general

Index.cshtml
```CS
@model IEnumerable<IndiceCuentasViewModel>

  

@{

    ViewData["Title"] = "Cuentas";

}

  

<h1>Cuentas</h1>

  

<a asp-action="Crear" class="btn btn-primary mb-3">Crear nueva</a>

  

<div class="contenedor-totales mb-3">

    <div>

        <div>

            <strong>Activos</strong>

        </div>

        <div class="activo">

            @Model.Where(x => x.Balance > 0).Sum(x => x.Balance)

        </div>

    </div>

    <div>

        <div>

            <strong>Pasivos</strong>

        </div>

        <div class="pasivo">

            @Model.Where(x => x.Balance < 0).Sum(x => x.Balance)

        </div>

    </div>

    <div>

        <div>

            <strong>Total</strong>

        </div>

        <div>

            @Model.Sum(x => x.Balance)

        </div>

    </div>

</div>
```


De momento tendremos algo parecido a lo siguiente.

PD: Agregue una cuenta nueva para tener un pasivo de 500, en mi caso un préstamo

![[Pasted image 20231121091516.png]]


Ahora continuaremos con el estilo

custom.css
```CSS
.contenedor-totales{

    display: flex;

    justify-content: space-between;

    font-size: 26px;

    text-align: center;

} 

.activo{

    color: blue;

}  

.pasivo{

    color: red;

}
```


Gracias a ello tendremos más centrado y por columnas los resultaos y resaltando los pasivos en rojo y activos en azul.

![[Pasted image 20231121091941.png]]


Sim embargo, notamos que no están escrito con una notación fácil de leer, intentemos colocarles una coma cada tres números.


Crearemos una función para poder centralizar los balances.


Index.cshtml
```CS
@{

    ViewData["Title"] = "Cuentas";

  

    string FormatearBalance(decimal balance){

        return Math.Abs(balance).ToString("N");

    }

}

<div class="activo">

            @FormatearBalance(Model.Where(x => x.Balance > 0).Sum(x => x.Balance))

        </div>
       
<div class="pasivo">

            @FormatearBalance(Model.Where(x => x.Balance > 0).Sum(x => x.Balance))

        </div>

<div>

            @FormatearBalance(Model.Sum(x => x.Balance))

        </div>

```

PD: Solo se implemento la función FormatearBalance en su respectivo balance


![[Pasted image 20231121092607.png]]

Y como podemos ver ya se encuentran en un formato correcto los datos

ahora emplearemos las cuentas par poderlas mostrar


Index.cshtml
```CS
<div class="accordion acordeon-cuentas">

    @foreach (var tipoCuenta in Model){

        <div class="accordion-item">

        <h2 class="accordion-header" id="cabeceraUno">

            @{

                var id = tipoCuenta.TipoCuenta.Replace(" ","");

                var dataBSTarget = "#" + id;

                var claseTipoCuenta = ObtenerClaseBalance(tipoCuenta.Balance);

            }

            <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="@dataBSTarget">

                <span class="me-3">

                    <span><strong>@tipoCuenta.TipoCuenta</strong></span>

                    <span class="@claseTipoCuenta">@FormatearBalance(tipoCuenta.Balance)</span>

                </span>

            </button>

        </h2>

        <div id="@id" class="accordion-collapse collapse show">

            <div>

                <ul class="list-group">

                    @foreach (var cuenta in tipoCuenta.Cuentas) {

                        var claseCuenta = ObtenerClaseBalance(cuenta.Balance);

                        <li class="list-group-item">

                            <span><strong>@cuenta.Nombre</strong></span>

                            <span class="@claseCuenta">@FormatearBalance(cuenta.Balance)</span>

                        </li>

                    }

                </ul>

            </div>

        </div>

    </div>

    }

</div>
```


Tendremos un resultado como este, en donde podemos apreciar los tipos de cuenta en cada tipo de balance

![[Pasted image 20231121094822.png]]


Para terminar le daremos un poco más de diseño


custom.css
```CSS
.acordeon-cuentas button {

    color: black !important;

    font-size: 20px;

}

  

.acordeon-cuentas button > span {

    display: flex;

    justify-content: space-between;

    width: 100%;

}

  

.acordeon-cuentas ul li {

    display: flex;

    justify-content: space-between;

}

  

.acordeon-cuentas .accordion-collapse{

    font-size: 18px;

}
```


Y tendremos algo más grande y visible

![[Pasted image 20231121100225.png]]


Sin embargo el CSS que implementamos solo le interesa a esta vista, así que hablaremos de 

### Aislamiento de CSS

Quizás no quieras tener todo el CSS de tu aplicación amontonado en un solo lugar, podemos utilizar aislamiento de CSS para tener reglas de CSS que solo aplican a una vista en especifico.

Eso lo haremos muy simple creando un nuevo archivo css dentro de la misma carpeta de vies/Cuentas

Index.cshmtl.css
```CSS
.acordeon-cuentas button {

    color: black !important;

    font-size: 20px;

}

  

.acordeon-cuentas button > span {

    display: flex;

    justify-content: space-between;

    width: 100%;

}

  

.acordeon-cuentas ul li {

    display: flex;

    justify-content: space-between;

}

  

.acordeon-cuentas .accordion-collapse{

    font-size: 18px;

}
```

No se olviden de incorporar el archvivo en 

\_Layout.cshtml
```CS
<link rel="stylesheet" href="ManejoPresupuesto.styles.css" asp-append-version="true">
```


Tendremos l mismo resultado, sin embargo permitimos que cada vista tenga su css personalizado.


### Editando Cuentas - agregando Íconos a la Aplicación

Continuaremos agregando dos botones para editar y borrar cuentas, para ello necesitaremos agregar iconos.

Como el proyecto anterior, utilizaremos los iconos de Bootstrap.

\_Layout.cshtml
```CS
```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.1/font/bootstrap-icons.css">
```


Para agregar los iconos en

Index.cshtml
```CS
@foreach (var cuenta in tipoCuenta.Cuentas) {

                        var claseCuenta = ObtenerClaseBalance(cuenta.Balance);

                        <li class="list-group-item">

                            <span><strong>@cuenta.Nombre</strong>

                            <a class="btn-primary btn">

                                <i class="bi-pencil-fill"></i>

                            </a>

                            <a class="btn-danger btn">

                                <i class="bi-trash-fill"></i>

                            </a>

                            </span>

                            <span class="@claseCuenta">@FormatearBalance(cuenta.Balance)</span>

                        </li>

                    }
```

Ahora ya tenemos un boton de editar y borrar a lado de cada cuenta.

![[Pasted image 20231121102105.png]]


Ahora necesitamos la acción de editar, sin embargo primero vamos a crear un método en el repositorio de cuentas que nos va a brindar la información de la cuenta a editar.

RepositorioCuentas.cs
```CS
public async Task<Cuenta> ObtenerPorId(int id, int usuarioId){

            using var connection = new SqlConnection(connectionString);

            return await connection.QueryFirstOrDefaultAsync<Cuenta>(

                @"SELECT Cuentas.Id, Cuentas.Nombre, Balance, Descripcion, TipoCuentaId

                FROM Cuentas

                INNER JOIN TiposCuentas tc

                ON tc.Id = Cuentas.TipoCuentaId

                WHERE tc.UsuarioId = @UsuarioId AND Cuentas.TipoCuentaId = @TipoCuentaId", new {id, usuarioId}

            );

        }
```

IRepositorioCuentas.cs
```CS
Task<Cuenta> ObtenerPorId(int id, int usuarioId);
```



CuentasController.cs
```CS
public async Task<IActionResult> Editar(int id){

            var usuarioId = serviciousuarios.ObtenerUsuarioId();

            var cuenta = await repositorioCuentas.ObtenerPorId(id, usuarioId);

  

            if (cuenta is null){

                return RedirectToAction("NoEncontrado","Home");

            }

  

            var modelo = new CuentaCreacionViewModel(){

                Id = cuenta.Id,

                Nombre = cuenta.Nombre,

                TipoCuentaId = cuenta.TipoCuentaId,

                Descripcion = cuenta.Descripcion,

                Balance = cuenta.Balance

            };

  

            modelo.TiposCuentas = await ObtenerTiposCuentas(usuarioId);

            return View(modelo);

        }
```

ahora crearemos la vista para editar 

Editar.cshtml
```CS
@model CuentaCreacionViewModel

  

@{

    ViewData["Title"] = "Editar Cuenta";

}

  
  

<h1>Editar cuenta: @Model.Nombre</h1>

  

<form asp-action="Editar">

    <div asp-validation-summary="ModelOnly" class="text-danger"></div>

    <input type="hidden" asp-for="Id">

  
  

    <div class="mb-3">

        <label asp-for="Nombre" class="form-label"></label>

        <input asp-for="Nombre" class="form-control" />

        <span asp-validation-for="Nombre" class="text-danger"></span>

    </div>

  

    <div class="mb-3">

        <label asp-for="TipoCuentaId" class="form-label"></label>

        <select asp-for="TipoCuentaId" asp-items="Model.TiposCuentas" class="form-select"></select>

        <span asp-validation-for="TipoCuentaId" class="text-danger"></span>

    </div>

  

    <div class="mb-3">

        <label asp-for="Balance" class="form-label"></label>

        <input asp-for="Balance" class="form-control" />

        <span asp-validation-for="Balance" class="text-danger"></span>

    </div>

  

    <div class="mb-3">

        <label asp-for="Descripcion" class="form-label"></label>

        <textarea asp-for="Descripcion" class="form-control"></textarea>

        <span asp-validation-for="Descripcion" class="text-danger"></span>

    </div>

  
  

    <button type="submit" class="btn btn-primary">Enviar</button>

    <a class="btn btn-secondary" asp-action="Index">Cancelar</a>

</form>

  

@section Scripts{

    <partial name="_ValidationScriptsPartial" />

}
```

Ponemos la redirección en

Index.cshtml
```CS
<a asp-action="Editar"  asp-route-id="@cuenta.Id" class="btn-primary btn">

                                <i class="bi-pencil-fill"></i>

                            </a>
```

Ahora hay que trabajar en la acción que va a recibr el posteo del formulario

CuentasController.cs
```CS
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
```


RepositorioCuentas.cs
```CS
public async Task Actualizar(CuentaCreacionViewModel cuenta){

            using var connection = new SqlConnection(connectionString);

            await connection.ExecuteAsync(@"UPDATE Cuentas

                                            SET Nombre = @Nombre, Balance = @Balance, Descripcion = @Descripción,

                                            TipoCuentaId = @TipoCuentaId

                                            WHERE Id = @Id;", cuenta);

        }
```

IRepositorioCuentas.cs
```CS
Task Actualizar(CuentaCreacionViewModel cuenta);
```

Vamos a crear un duplicado de Tarjeta del Banco X como un préstamo

![[Pasted image 20231121111745.png]]


Como podemos ver ya podemos editar nuestras cuentas

Y cuando hagamos la prueba de borrar la quitaremos en un futuro.


Sin embargo, antes de eso, hay que aprender una mejor manera de realizar un mapeo que no sea haciéndolo a mano.


### Utilizando AutoMapper

En el paso anterior nos vimos en la necesidad de mapear de un objeto a otro, esta es una operación mu frecuenta, ya que distintos objetos tienen distintas responsabilidades 

Esta buena practica puede dar pie a tener que estar repitiendo mucho código en el cual vamos a estar copiando los datos de un objeto a otro.

Una mejora a esto es utilizar un mappeador que busca centralizar la lógica de copiado datos entre objetos.

En este caso utilizaremos automapper, primero iremos a instalar dicha librería.

```cli
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
```

Configuramos automapper

program.cs
```CS
builder.Services.AddAutoMapper(typeof(Program));
```

Ahora necesitamos configurar los mapeos a otro mapa, pero tenemos que indicarle de que clase a que clase podemos mapear. Esto lo hacemos e lo que se conoce como una clase profile.

Es aquella que hereda de la clase profile.

Para esto vamos  crear una nueva clase en servicios

AutoMapperProfiles.cs
```CS
using AutoMapper;

using ManejoPresupuesto.Models;

  

namespace ManejoPresupuesto.Servicios{

    public class AutoMapperProfiles : Profile{

        public AutoMapperProfiles(){

            CreateMap<Cuenta,CuentaCreacionViewModel>();

        }

    }

}
```


Ahora vamos a utilizar en

CuentasController.cs
```CS
using AutoMapper;

private readonly IMapper mapper;

  

        public CuentasController(IRepositorioTiposCuentas repositorioTiposCuentas, IServicioUsuarios servicioUsuarios, IRepositorioCuentas repositorioCuentas, IMapper mapper){

            this.repositorioTiposCuentas = repositorioTiposCuentas;

            this.serviciousuarios = servicioUsuarios;

            this.repositorioCuentas = repositorioCuentas;

            this.mapper = mapper;

        }

var modelo = mapper.Map<CuentaCreacionViewModel>(cuenta);
```


Como podemos ver simplificamos cada atributo manual en una linea automatizada de Cuenta a CuentaCreacionViewModel



### Borrando Cuentas

Vamos a implementar la función de borrar cuentas, para ello vamos a hacer lo mismo que hicimos en Tipos Cuentas, vamos a redirigir el usuario a una pantalla donde podrá visualizar a detalle de la cuenta y luego confirmar si desea borrar el registro. 

Empezaremos modificando nuestro repositorio para agregar un método que nos permita borra una cuenta.

RepositorioCuentas.cs
```CS
public async Task Borrar(int id){

            using var connection = new SqlConnection(connectionString);

            await connection.ExecuteAsync("DELETE Cuentas WHERE Id = @Id", new {id});

        }
```

IRepositorioCuentas.cs
```CS
Task Borrar(int id);
```



CuentasController.cs
```CS
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
```


Ahora para terminar nos falta crear la vista de borrar para el usuario


Borrar.cshtml
```CS
@model Cuenta

  

@{

    ViewData["Title"] = "Borrar Cuenta";

}

  

<h3 class="mb-3">¿Estás seguro deseas borrar la cuenta @Model.Nombre?</h3>

  

<form asp-action="BorrarCuenta">

    <input type="hidden" asp-for="Id">

    <button class="btn btn-danger" type="submit">Borrar</button>

    <a asp-action="Index" class="btn btn-secondary">Cancelar</a>

</form>
```

Solo falta agregar la redireción de la vista en

Index.cshtml
```CS
<a asp-action="Borrar" class="btn-danger btn" asp-route-id="@cuenta.Id">

                                <i class="bi-trash-fill"></i>

                            </a>
```

Y tendremos algo como esto

![[Pasted image 20231121120123.png]]


### Creando categorías

Estas mismas nos permitirán indicar maneras de agrupar transacciones.

Es importante que nuestros usuarios puedan no solamente registrar sus gastos, sino que deben poder registrar en que gastan su dinero y también lo mismo para los ingresos.

Lo primero que haremos será crear un enum que va a contener los dos tipos de categorías que vamos a tener.

Crearemos nuestro nuevo modelo.

TipoTransacción.cs
```CS
namespace ManejoPresupuesto.Models{

    public enum TipoTransacción{

        Ingreso = 1,

        Gasto = 2

    }

}
```

Después crearemos una case que represente una categoría 


Categoria.cs
```CS
using System.ComponentModel.DataAnnotations;

  

namespace ManejoPresupuesto.Models{

    public class Categoria{

        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]

        [StringLength(maximumLength: 50, ErrorMessage = "No puede se mayor a {1} caracteres")]

        public string Nombre { get; set; }

		[Display(Name = "Tipo Transacción")]
        public TipoTransacción TipoTransacciónId { get; set; }

        public int UsuarioId { get; set; }

    }

}
```

Ahora creamos nuestro repositorio de categorías

RepositorioCategorias.cs
```CS
using Dapper;

using ManejoPresupuesto.Interfaces;

using ManejoPresupuesto.Models;

using Microsoft.Data.SqlClient;

  

namespace ManejoPresupuesto.Servicios{

    public class RepositorioCategorias : IRepositorioCategorias{

  

        private readonly string connectionString;

  

        public RepositorioCategorias(IConfiguration configuration){

            connectionString = configuration.GetConnectionString("DefaultConnection");

        }

  

        public async Task Crear(Categoria categoria){

            using var connection = new SqlConnection(connectionString);

            var id = await connection.QuerySingleAsync<int>(@"INSERT INTO Categorías (Nombre, TipoTransacciónId, UsuarioId)

                                                            VALUES (@Nombre, @TipoTransacciónId, @UsuarioId);

  

                                                            SELECT SCOPE_IDENTITY()"

                                                            , categoria);

            categoria.Id = id;

        }

    }

}
```

IRepositorioCategorias.cs
```CS
using ManejoPresupuesto.Models;

  

namespace ManejoPresupuesto.Interfaces{

    public interface IRepositorioCategorias{

        Task Crear(Categoria categoria);

    }

}
```

NO se te olvide anexar el nuevo servicio qe creamos 

Program.cs
```CS
builder.Services.AddTransient<IRepositorioCategorias, RepositorioCategorias>();
```


Ahora vamos a crear un controlador de categorias

CategoriasController.cs
```CS
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

  

    }

}
```

Ahora construiremos el 

### Formulario Categorías - Creando un select de un Enum

Nuestro formulario para crear categorías empezaría algo así

Crear.cshtml
```CS
@model Categoria

  

@{

    ViewData["Title"] = "Crear categoría";

}

  

<h1>Crear categoría</h1>

<h5>L categoría nos permite ndicar en qué gastamos nuestro dinero, también de donde provienen nuestros ingresos</h5>

  

<form asp-action="Crear">

    <div class="text-danger" asp-validation-summary="ModelOnly"></div>

  

    <div class="mb-3">

        <label asp-for="Nombre" class="form-label"></label>

        <input asp-for="Nombre" class="form-control" />

        <span asp-validation-for="Nombre" class="text-danger"></span>

    </div>

  

    <div class="mb-3">

        <label asp-for="TipoTransacciónId" class="form-label"></label>

        <select asp-for="TipoTransacciónId" asp-items="Html.GetEnumSelectList<TipoTransacción>()" class="form-select"></select>

        <span asp-validation-for="TipoTransacciónId" class="text-danger"></span>

    </div>

  

    <button class="btn btn-primary">Enviar</button>

    <a class="btn btn-secondary" asp-action="Index">Cancelar</a>

</form>

  

@section Scripts{

    <partial name="=_ValidationScriptsPartial" />

}
```

Tendrías a partir de aquí un formulario con la capacidad de crear categorías, crearemos la categoría libro con tipo gasto como ejemplo.

![[Pasted image 20231121131018.png]]


PD: No te preocupes si al darle clic al botono en enviar salta un error 404, recuerda que aun no desarrollamos la vista index.

Sin embargo, si quieres validar bien su funcionamiento, realiza un select de tu tabla de categorías en tu DB y deberías de tener un resultado parecido a este.

![[Pasted image 20231121131201.png]]



### Índice de categorías

Empezaremos haciendo un método para obtener las categorías dentro de nuestro repositorio.

RepositorioCategorias.cs
```CS
public async Task<IEnumerable<Categoria>> Obtener(int UsuarioId){

            using var connection = new SqlConnection(connectionString);

            return await connection.QueryAsync<Categoria>("SELECT * FROM Categorías WHERE UsuarioId = @UsuarioId", new {UsuarioId});

        }
```

IRepositorioCategorias.cs
```CS
Task<IEnumerable<Categoria>> Obtener(int UsuarioId);
```


Ahora vamos a desarrollar una acción en 

CategoriasController.cs
```CS
public async Task<IActionResult> Index(){

            var UsuarioId = servicioUsuarios.ObtenerUsuarioId();

            var categorias = await repositorioCategorias.Obtener(UsuarioId);

  
  

            return View(categorias);

        }
```

Para depues poder crear una vista para esa acción


Index.cshtml
```CS
@model IEnumerable<Categoria>

  

@{

    ViewData["Title"] = "Categorías";

}

  

<h1>Categorías</h1>

<h5>La categpría ms permite indicar en qué gastamos, nuestro dinero, también, en dónde provienen nuestros ingresos.</h5>

  
  

<a asp-action="Crear" class="btn btn-primary mb-3">Crear nuevo</a>

  

<table class="table">

    <thead>

        <tr>

            <th>Acciones</th>

            <th>Nombre</th>

            <th>Tipo</th>

        </tr>

    </thead>

    <tbody>

        @foreach (var categoria in Model){

            <tr>

                <td>

                    <a class="btn btn-primary" asp-action="Editar" asp-route-id="@categoria.Id">Editar</a>

                    <a class="btn btn-danger" asp-action="Borrar" asp-route-id="@categoria.Id">Borrar</a>

                </td>

                <td>

                    @categoria.Nombre

                </td>

                <td>

                    @categoria.TipoTransacciónId.ToString()

                </td>

            </tr>

        }

    </tbody>

</table>
```

No olvidar de anexar la redireción en 

\_Layout.cshtml
```CS
<li class="nav-item">

                            <a class="nav-link text-dark" asp-controller="Categorias" asp-action="Index">Categorías</a>

                        </li>
```

Tendremos algo por el estilo.

![[Pasted image 20231121183229.png]]

Como podemos apreciar se encuentra la categoría que previamente creamos.


### Editar Categorías

Para esto vamos a crear dos métodos en el repositorio de categorías

RepositorioCategorias.cs
```CS
public async Task<Categoria> ObtenerPorId(int Id, int UsuarioId){

            using var connection = new SqlConnection(connectionString);

            return await connection.QueryFirstOrDefaultAsync<Categoria>(@"SELECT * FROM Categorías WHERE Id = @Id AND UsuarioId = @UsuarioId", new {Id, UsuarioId});

        }

  
  

        public async Task Actualizar(Categoria Categoria){

            using var connection = new SqlConnection(connectionString);

            await connection.ExecuteAsync(@"UPDATE Categorías SET Nombre = @Nombre, TipoTransacciónId = @TipoTransacciónId WHERE Id = @Id", Categoria);

        }
```

IRepositorioCategorias.cs
```CS
Task Actualizar(Categoria categoria);

Task<Categoria> ObtenerPorId(int Id, int UsuarioId);
```


empleemos dichas funciónes en nuestro controlador

CategoriasController.cs
```CS
public async Task<IActionResult> Editar(int Id){

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
```

Ahora desarrollaremos la vista de

Editar.cshtml
```CS
@model Categoria

  

@{

    ViewData["Title"] = "Editar categoría";

}

  

<h1>Editar categoría</h1>

<h5>La categoría nos permite ndicar en qué gastamos nuestro dinero, también de donde provienen nuestros ingresos</h5>

  

<form asp-action="Editar">

    <div class="text-danger" asp-validation-summary="ModelOnly"></div>

    <input type="hidden" asp-for="Id">

  

    <div class="mb-3">

        <label asp-for="Nombre" class="form-label"></label>

        <input asp-for="Nombre" class="form-control" />

        <span asp-validation-for="Nombre" class="text-danger"></span>

    </div>

  

    <div class="mb-3">

        <label asp-for="TipoTransacciónId" class="form-label"></label>

        <select asp-for="TipoTransacciónId" asp-items="Html.GetEnumSelectList<TipoTransacción>()" class="form-select"></select>

        <span asp-validation-for="TipoTransacciónId" class="text-danger"></span>

    </div>

  

    <button class="btn btn-primary">Enviar</button>

    <a class="btn btn-secondary" asp-action="Index">Cancelar</a>

</form>

  

@section Scripts{

    <partial name="_ValidationScriptsPartial" />

}
```


Tendremos el siguiente resultado

![[Pasted image 20231121185603.png]]


### Borrar Categorías


Empleemos la función en nuestro repositorio


RespositorioCategorias.cs
```CS
public async Task Borrar(int Id){

            using var connection = new SqlConnection(connectionString);

            await connection.ExecuteAsync(@"DELETE Categorías WHERE Id = @Id", new {Id});

        }
```

RespositorioCategorias.cs
```CS
Task Borrar(int Id);
```


Ahora toca poner las dos acciones en nuestro

CategoriasController.cs
```CS
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
```


Finalmente nos falta desarrollar la vista para borrar

Borrar.cshtml
```CS
@model Categoria

  

@{

    ViewData["Title"] = "Borrar categoría";

}

  

<h3 class="mb-3">¿Está seguro que desea borrar la categoría @Model.Nombre?</h3>

  

<form asp-action="BorrarCategoria">

    <input type="hidden" asp-for="Id" />

    <button type="submit" class="btn btn-danger">Borrar</button>

    <a asp-action="Index" class="btn btn-primary">Cancelar</a>

</form>
```

Para terminar del CRUD de Categorías finalmete podremos borrarlas, en el siguiente ejemplo se mostraria como

![[Pasted image 20231121191303.png]]


### Creando Transacciones

Gracias a ellas nuestro usuarios podrá registrar ingresos y gastos, también deben de poder indicar la cuenta en la cual quieren reflejar y también deben de poder indicar la categoría del ingreso o gasto.

Empecemos creando nuestro servicio y repositorio


RepositorioTransacciones.cs
```CS
using System.Data.Common;

using ManejoPresupuesto.Interfaces;

  

namespace ManejoPresupuesto.Servicios{

    public class RepositorioTransaccion : IRepositorioTransacciones{

  

        private readonly string ConnectionString;

  

        public RepositorioTransaccion(IConfiguration configuration){

            ConnectionString = configuration.GetConnectionString("DefaultConnection");

        }

  

    }

}
```

IRepositorioTransacciones.cs
```CS
namespace ManejoPresupuesto.Interfaces{

    public interface IRepositorioTransacciones{

    }

}
```

Construyamos el modelo de transacciones

Transaccion.cs
```CS
using System.ComponentModel.DataAnnotations;

  

namespace ManejoPresupuesto.Models{

    public class Transaccion{

        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public DateTime FechaTransaccion { get; set; } = DateTime.Today;

        public decimal Monto { get; set; }

        [Display(Name = "Categoría")]
        [Range(1, maximum: int.MaxValue, ErrorMessage = "Debe seleccionar una categoria")]

        public int CategoriaId { get; set; }

        [StringLength(maximumLength: 1000, ErrorMessage = "La nota no puede pasar de {1} caracteres")]

        public string Nota { get; set; }

        [Range(1, maximum: int.MaxValue, ErrorMessage = "Debe seleccionar una cuenta")]

        [Display(Name = "Cuenta")]
        public int CuentaId { get; set; }

    }

}
```

Ahora continuaremos con el metodo para crear transacciones

RepositorioTransacciones.cs
```CS
public async Task Crear(Transaccion transaccion){

            using var connection = new SqlConnection(connectionString);

            var id = await connection.QuerySingleAsync<int>("Transacciones_Insertar",

            new {

                transaccion.UsuarioId,

                transaccion.FechaTransaccion,

                transaccion.Monto,

                transaccion.CategoriaId,

                transaccion.Nota

            },

           commandType: System.Data.CommandType.StoredProcedure);

  

           transaccion.Id = id;

        }
```

IRepositorioTransacciones.cs
```CS
Task Crear(Transaccion transaccion);
```

Desarrollemos el stored procedure

SPTransacciones_Insertar.sql
```CS
CREATE PROCEDURE Transacciones_Insertar

    @UsuarioId int,

    @FechaTransaccion date,

    @Monto decimal(18,2),

    @CategoriaId int,

    @CuentaId int,

    @Nota nvarchar(1000)

  

AS

BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from

    -- interfering with SELECT statements.

    SET NOCOUNT ON;

  

    -- Insert statements for procedure here

    INSERT INTO Transacciones(UsuarioId, FechaTransacción, Monto, CategoriaId, CuentaId, Nota)

    VALUES (@UsuarioId, @FechaTransaccion, ABS(@Monto), @CategoriaId, @CuentaId, @Nota)

  

    UPDATE Cuentas

    SET Balance += @Monto

    WHERE Id = @CuentaId;

  

    SELECT SCOPE_IDENTITY();

END

GO
```


PD: Como análisis de nuestra DB, vemos que Categorías ya abarca TipoTransacciónId, entonces quitare ese campo de la tabla de transacciones para evitar redundancia.


Ahora vamos a trabajar con la vista para crear una transacción.

Empecemos con su modelo

TransaccionCreacionViewModel.cs
```CS
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

  

namespace ManejoPresupuesto.Models{

    public class TransaccionCreacionViewModel : Transaccion {

        public IEnumerable<SelectListItem> Cuentas { get; set; }

        public IEnumerable<SelectListItem> Categorias { get; set; }
       [Display(Name = "Tipo Transacción")]
       public TipoTransacción TipoTransacciónId { get; set; }

    }

}
```

Para más adelante desarrollar nuestro controlador

TransaccionesController.cs
```CS
using ManejoPresupuesto.Interfaces;

using ManejoPresupuesto.Models;

using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.Rendering;

  

namespace ManejoPresupuesto.Controllers{

    public class TransaccionesController : Controller {

  

        private readonly IServicioUsuarios servicioUsuarios;

        private readonly IRepositorioCuentas repositorioCuentas;

  

        public TransaccionesController(IServicioUsuarios servicioUsuarios, IRepositorioCuentas repositorioCuentas){

            this.servicioUsuarios = servicioUsuarios;

            this.repositorioCuentas = repositorioCuentas;

        }

  
  

        public async Task<IActionResult> Crear(){

            var UsuarioId = servicioUsuarios.ObtenerUsuarioId();

            var modelo = new TransaccionCreacionViewModel();

            modelo.Cuentas = await ObtenerCuentas(UsuarioId);

  

            return View(modelo);

        }

  

        private async Task<IEnumerable<SelectListItem>> ObtenerCuentas(int UsuarioId){

            var cuentas = await repositorioCuentas.Buscar(UsuarioId);

  

            return cuentas.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));

        }

  

    }

}
```

Para terminar toca la vista


### Trabajando con fechas en un Formulario

Crear.cshtml
```CS
@model TransaccionCreacionViewModel

  

@{

    ViewData["Title"] = "Crear transacción";

}

  

<h1>Crear Transacción</h1>

<h5>Una transacción te permite indicar tus ingresos y gastos</h5>

  

<form asp-action="Crear">

    <div asp-validation-summary="ModelOnly" class="text-danger"></div>

    <div class="mb-3">

        <label asp-for="FechaTransaccion" class="form-label"></label>

        <input asp-for="FechaTransaccion" class="form-control" />

        <span asp-validation-for="FechaTransaccion" class="text-danger"></span>

    </div>

</form>

  

@section Scripts{

    <partial name="_ValidationScriptsPartial" />

}
```

Trendemos algo similar a lo siguiente

![[Pasted image 20231122102455.png]]

Como podemos apreciar nos muestra la hora, y si no queremos simplemente cambiamos el tipo de dato en nuestro modelo

Transaccion.cs
```CS
[Display(Name = "Fecha Transacción")]

        [DataType(DataType.Date)]

        public DateTime FechaTransaccion { get; set; } = DateTime.Today;
```


![[Pasted image 20231122102907.png]]



PD: Si te interesa seleccionar la hora actual en especifico usar

Transaccion.cs
```CS
[Display(Name = "Fecha Transacción")]

        [DataType(DataType.DateTime)]

        public DateTime FechaTransaccion { get; set; } = DateTime.Now;
```


![[Pasted image 20231122103025.png]]

Aunque es demasiado especifico xD.

En fin, no creo que el usuario quiere ver sus milésimas por ende modificaremos hasta donde

Transaccion.cs
```CS
[Display(Name = "Fecha Transacción")]

        [DataType(DataType.DateTime)]

        public DateTime FechaTransaccion { get; set; } = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:MM tt"));
```

PD: Esto solo fue demostrativo par apoder aprender que lo anterior se puede resumir como

Transaccion.cs
```CS
[Display(Name = "Fecha Transacción")]

        [DataType(DataType.DateTime)]

        public DateTime FechaTransaccion { get; set; } = DateTime.Parse(DateTime.Now.ToString("g"));
```


En el proyecto seguiremos con

Transacciones.cs
```CS
[Display(Name = "Fecha Transacción")]

        [DataType(DataType.Date)]

        public DateTime FechaTransaccion { get; set; } = DateTime.Today;
```

### Agregando los demás campos del formulario Crear


Nos falta que el usuario pueda seleccionar la cuenta, el Tipo de transacción, el monto y una nota.

Crear.cshtml
```CS
<div class="mb-3">

        <label asp-for="CuentaId" class="form-label"></label>

        <select asp-for="CuentaId" asp-items="Model.Cuentas" class="form-select"></select>

        <span asp-validation-for="CuentaId" class="text-danger"></span>

    </div>

  

    <div class="mb-3">

        <label asp-for="TipoTransacciónId" class="form-label"></label>

        <select asp-for="TipoTransacciónId" asp-items="Html.GetEnumSelectList<TipoTransacción>()" class="form-select"></select>

        <span asp-validation-for="TipoTransacciónId" class="text-danger"></span>

    </div>

  

    <div class="mb-3">

        <label asp-for="CategoriaId" class="form-label"></label>

        <select asp-for="CategoriaId" asp-items="Model.Categorias" class="form-select"></select>

        <span asp-validation-for="CategoriaId" class="text-danger"></span>

    </div>

  

    <div class="mb-3">

        <label asp-for="Monto" class="form-label"></label>

        <input asp-for="Monto" class="form-control" />

        <span asp-validation-for="Monto" class="text-danger"></span>

    </div>

  

    <div class="mb-3">

        <label asp-for="Nota" class="form-label"></label>

        <textarea asp-for="Nota" class="form-control" > </textarea>

        <span asp-validation-for="Nota" class="text-danger"></span>

    </div>

  

    <button class="btn btn-primary">Enviar</button>

    <a class="btn btn-primary" asp-action="Index">Cancelar</a>
```


Agregando lo anterior tendremos algo como lo siguiente

![[Pasted image 20231122105716.png]]

Ahora lo que nos faltaría sería mostrar las categorías dependiendo del tipo de transacción que seleccione previamente el usuario.


### Dropdown Cascada o dependiente

Para ello necesitaremos usar JS para ejecutar una petición http al servidor para obtener las categorías adecuadas

Crear.cshtml
```CS
//insertarlo en la section de scripts
<script>

		const urlObtenerCategorias = '@Url.Action("ObtenerCategorias")';

        $(function () {

            $("#TipoTransacci_nId").change(async function(){

                const valorSeleccionado = $(this).val();

  

                const respuesta = await fetch(urlObtenerCategorias, {

                    method: 'POST',

                    body: valorSeleccionado,

                    headers: {

                        'Content-Type': 'application/json'

                    }

                });

  

                const json = await respuesta.json();

                console.log(json);

            })

        })

    </script>
```

PD: como puedes ver uso \#TipoTransacci_nId a razón de que tiene acento, si el tu no usaste haz caso omiso del tema xD


ahora vamos a crear el endpoint o acción en el controlador para devolver las categorías.

TransaccionesController.cs
```CS
private readonly IRepositorioCategorias repositorioCategorias;

  

        public TransaccionesController(IServicioUsuarios servicioUsuarios, IRepositorioCuentas repositorioCuentas, IRepositorioCategorias repositorioCategorias){

            this.servicioUsuarios = servicioUsuarios;

            this.repositorioCuentas = repositorioCuentas;

            this.repositorioCategorias = repositorioCategorias;

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

```


Método para obtener categorías mediante tipo de transacción

RepositorioCategorias.cs
```CS
public async Task<IEnumerable<Categoria>> Obtener(int UsuarioId, TipoTransacción tipoTransacciónId){

            using var connection = new SqlConnection(connectionString);

            var categorias = await connection.QueryAsync<Categoria>(@"SELECT * FROM Categorías

                                                                    WHERE UsuarioId = @UsuarioId

                                                                    AND TipoTransacciónId = @TipoTransacciónId" ,

                                                                    new {UsuarioId, tipoTransacciónId});

  

            return categorias;

        }
```


IRepositorioCategorias.cs
```CS
Task<IEnumerable<Categoria>> Obtener(int UsuarioId, TipoTransacción tipoTransacción);
```


Si quieres validar su uso utiliza el inspector web de tu navegador para visualizar la respuesta, no se te olvide seleccionar algún tipo de transacción, deberías de tener una respuesta similar a esta.

![[Pasted image 20231122121517.png]]


Sin embargo necesitamos que se llenen las categorías también cuando recién cargamos el formulario


Le añadiremos un poco a

TransaccionesController.cs
```CS
public async Task<IActionResult> Crear(){

            var UsuarioId = servicioUsuarios.ObtenerUsuarioId();

            var modelo = new TransaccionCreacionViewModel();

            modelo.Cuentas = await ObtenerCuentas(UsuarioId);

            modelo.Categorias = await ObtenerCategorias(UsuarioId, modelo.TipoTransacciónId);

  

            return View(modelo);

        }
```

Y definir un valor predeterminado de tipo transacción en ingreso

TransaccionCreacionViewModel.cs
```CS
public TipoTransacción TipoTransacciónId { get; set; } = TipoTransacción.Ingreso;
```


De momento tendríamos algo así

![[Pasted image 20231122170032.png]]


Sin embargo al querer cambiar de tipo de transacción no cambia la categorías


pare ello modificaremos lo siguiente para llenar el select con dicha información

Crear.cshtml
```CS
//anexarlo debajo de const json = await respuesta.json();
const opciones = json.mao(categoria => `<option value=${categoria.value}>${categoria.text}</option>`);

                $(#CategoriaId).html(opciones);
```

Con ello al cambiar de tipo de transacción la categoría cambia en paralelo.

Ahora toca trabajar en la persistencia de la transacción en la DB
### Insertando la transacción

Ahora vamos a crear una acción para insertar transacciones.

TransaccionesController.cs
```CS
private readonly IRepositorioTransacciones repositorioTransacciones;

  

        public TransaccionesController(IServicioUsuarios servicioUsuarios, IRepositorioCuentas repositorioCuentas, IRepositorioCategorias repositorioCategorias, IRepositorioTransacciones repositorioTransacciones){

            this.servicioUsuarios = servicioUsuarios;

            this.repositorioCuentas = repositorioCuentas;

            this.repositorioCategorias = repositorioCategorias;

            this.repositorioTransacciones = repositorioTransacciones;

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
```


Si probamos si funciona hay que revisar en sql, recuerda que aun no tenemos vista index

![[Pasted image 20231122171940.png]]

Y puedes revisar en cuenta el balance todal

![[Pasted image 20231122172108.png]]

Como podemos ver si se sumo el 10 y sucede lo mismo si hacemos un gasto

![[Pasted image 20231122172222.png]]

![[Pasted image 20231122172234.png]]


Perfecto, ahora al validar que funciona desarrollemos la vista índice para las transacciones.

Vamos agregar

TransaccionesController.cs
```CS
public IActionResult Index(){

            return View();

        }
```


Ahora la vista

Index.cshtml
```CS
@{

    ViewData["Title"] = "Transacciones";

}

  

<h1>Indice de TRansacciones</h1>
```

Esto es algo que veremos cuando hablemos de los reporte, ya que no simplemente colocaremos un listado de transaccione sino que haremos varios tipos  de reporte, diario, semanal, etc.

### Actualizar Transacciones


Comenzaremos creando un procedimiento almacenado que nos ayude a encapsular las operaciones necesarias


SPTransacciones_Actualizar.sql
```SQL
CREATE PROCEDURE Transacciones_Actualizar

	@Id int,
	@FechaTransaccion datetime,
	@Monto decimal(18,2),
	@MontoAnterior decimal(18,2),
	@CuentaId int,
	@CuentaAnteriorId int,
	@CategoriaId int,
	@Nota nvarchar(1000) = NULL

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Revertir transacción anterior
	UPDATE Cuentas
	SET Balance -= @MontoAnterior
	WHERE Id = @CuentaAnteriorId;

	--Realizar nueva transacción
	UPDATE Cuentas
	SET Balance += @Monto
	WHERE Id = @CuentaId;

	UPDATE Transacciones
	SET Monto = ABS(@Monto), FechaTransacción = @FechaTransaccion, 
	CategoriaId = @CategoriaId, CuentaId = @CuentaId, Nota = @Nota
	WHERE Id = @Id;
	
END
GO
```

Ahora llamemos ese procedimiento

RespositorioTransacciones.cs
```CS
public async Task Actualizar(Transaccion transaccion, decimal montoAnterior, int CuentaAnteriorId){

            using var connection = new SqlConnection(connectionString);

            await connection.ExecuteAsync("Transacciones_Actualizar",

                new {

                    transaccion.Id,

                    transaccion.FechaTransaccion,

                    transaccion.Monto,

                    transaccion.CategoriaId,

                    transaccion.CuentaId,

                    transaccion.Nota,

                    montoAnterior,

                    cuentaAnteriorId

                }, commandType: System.Data.CommandType.StoredProcedure

            );

        }
```

IRespositorioTransacciones.cs
```CS
Task Actualizar(Transaccion transaccion, decimal montoAnterior, int CuentaAnterior);
```

Luego necesitamos un método para obtener una transacción en base a un Id, otro seria el tipo de operación, así podremos mostrar el listado de categorías adecuado en el formulario.

Por ende hay que actualizar.

Transaccion.cs
```CS
[Display(Name = "Tipo Transacción")]

        public TipoTransacción TipoTransacciónId { get; set; } = TipoTransacción.Ingreso;
```

PD: NO se te olvide eliminar el mismo código en TransaccionCreacionViewModel


Ahora haremos el metodo para obtener una transacción por ID



RepositorioTransacciones.cs
```CS
public async Task<Transaccion> ObtenerPorId(int Id, int UsuarioId){

          using var connection = new SqlConnection(connectionString);

  

            return await connection.QueryFirstOrDefaultAsync<Transaccion>(@"SELECT Transacciones.*, cat.TipoTransacciónId

                                                                            FROM Transacciones

                                                                            INNER JOIN Categorías cat

                                                                            ON cat.Id = Transacciones.CategoriaId

                                                                            WHERE Transacciones.Id = @Id AND

                                                                            Transacciones.UsuarioId = @UsuarioId",

            new {Id, UsuarioId});

        }



```

IRepositorioTransacciones.cs
```CS
Task<Transaccion> ObtenerPorId(int Id, int UsuarioId);


```

Ahora crearemos un nuevo view model para poder trabajar con la vista de actualizar transacciones.

TransaccionActualizacionViewModel.cs
```CS
namespace ManejoPresupuesto.Models{

    public class TransaccionActualizacionViewModel : TransaccionCreacionViewModel{

  

        public int CuentaAnteriorId { get; set; }

        public decimal montoAnterior { get; set; }

    }

}
```

Ahora vamos a crear nuestros métodos de actualizar.

TransaccionesController.cs
```CS
private readonly IMapper mapper;

  
public TransaccionesController(IServicioUsuarios servicioUsuarios, IRepositorioCuentas repositorioCuentas, IRepositorioCategorias repositorioCategorias, IRepositorioTransacciones repositorioTransacciones, IMapper mapper){

            this.servicioUsuarios = servicioUsuarios;

            this.repositorioCuentas = repositorioCuentas;

            this.repositorioCategorias = repositorioCategorias;

            this.repositorioTransacciones = repositorioTransacciones;
            
           this.mapper = mapper;

        }


[HttpGet]

        public async Task<IActionResult> Editar(int Id){

            var UsuarioId = servicioUsuarios.ObtenerUsuarioId();

            var transaccion = await repositorioTransacciones.ObtenerPorId(Id, UsuarioId);

  

            if (transaccion is null){

                return RedirectToAction("Noencontrado","Home");

            }

  

            var modelo = mapper.Map<TransaccionActualizacionViewModel>(transaccion);

			modelo.montoAnterior = modelo.Monto;

            if (modelo.TipoTransacciónId == TipoTransacción.Gasto){

                modelo.montoAnterior = modelo.Monto * -1;

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

  

            if(modelo.TipoTransacciónId == TipoTransacción.Gasto){

                transaccion.Monto *= -1;

            }

  

            await repositorioTransacciones.Actualizar(transaccion, modelo.montoAnterior, modelo.CuentaAnteriorId);

  
  
  

            return RedirectToAction("Index");

        }

```

No hay que olvidar de importar el autommapper en el perfil usado

AutoMapperProfiles.cs
```CS
CreateMap<TransaccionActualizacionViewModel, Transaccion>().ReverseMap();
```


PD: el reverseMap nos permite establecer  ambos mapeos en una sola linea de un sentido y a otro.


### Vista actualización de Transacciones

El formulario de editar es muy similar al de crear, comencemos

Editar.cshtml
```CS
@model TransaccionActualizacionViewModel

  

@{

    ViewData["Title"] = "Editar transacción";

}

  

<h1>Editar Transacción</h1>

<h5>Una transacción te permite indicar tus ingresos y gastos</h5>

  

<form asp-action="Editar">

    <div asp-validation-summary="ModelOnly" class="text-danger"></div>

    <input type="hidden" asp-for="Id" />

    <input type="hidden" asp-for="MontoAnterior" />

    <input type="hidden" asp-for="CuentaAnteriorId" />

    <div class="mb-3">

        <label asp-for="FechaTransaccion" class="form-label"></label>

        <input asp-for="FechaTransaccion" class="form-control" />

        <span asp-validation-for="FechaTransaccion" class="text-danger"></span>

    </div>

  

    <div class="mb-3">

        <label asp-for="CuentaId" class="form-label"></label>

        <select asp-for="CuentaId" asp-items="Model.Cuentas" class="form-select"></select>

        <span asp-validation-for="CuentaId" class="text-danger"></span>

    </div>

  

    <div class="mb-3">

        <label asp-for="TipoTransacciónId" class="form-label"></label>

        <select asp-for="TipoTransacciónId" asp-items="Html.GetEnumSelectList<TipoTransacción>()" class="form-select"></select>

        <span asp-validation-for="TipoTransacciónId" class="text-danger"></span>

    </div>

  

    <div class="mb-3">

        <label asp-for="CategoriaId" class="form-label"></label>

        <select asp-for="CategoriaId" asp-items="Model.Categorias" class="form-select"></select>

        <span asp-validation-for="CategoriaId" class="text-danger"></span>

    </div>

  

    <div class="mb-3">

        <label asp-for="Monto" class="form-label"></label>

        <input asp-for="Monto" class="form-control" />

        <span asp-validation-for="Monto" class="text-danger"></span>

    </div>

  

    <div class="mb-3">

        <label asp-for="Nota" class="form-label"></label>

        <textarea asp-for="Nota" class="form-control"> </textarea>

        <span asp-validation-for="Nota" class="text-danger"></span>

    </div>

  

    <button class="btn btn-primary">Enviar</button>

    <a class="btn btn-secondary" asp-action="Index">Cancelar</a>

</form>

  

@section Scripts{

    <partial name="_ValidationScriptsPartial" />

    <script src="~/js/FormularioTransacciones.js" asp-append-version="true"></script>

  
  

    <script>

  
  

        const urlObtenerCategorias = '@Url.Action("ObtenerCategorias")';

  
  

        $(function () {

            InicializarFormularioTransacciones(urlObtenerCategorias);    

        })

    </script>

}
```

A razón de que utilizamos el mimo codigo JS vamos a ponerlo en un archivo aparte

PD: Tambien en crear utilice el nuevo documento JS

FormularioTransacciones.js
```JS
function InicializarFormularioTransacciones(urlObtenerCategorias){

    $("#TipoTransacci_nId").change(async function(){

        const valorSeleccionado = $(this).val();

  

        const respuesta = await fetch(urlObtenerCategorias, {

            method: 'POST',

            body: valorSeleccionado,

            headers: {

                'Content-Type': 'application/json'

            }

        });

  

        const json = await respuesta.json();

        const opciones = json.map(categoria => `<option value=${categoria.value}>${categoria.text}</option>`);

        $("#CategoriaId").html(opciones);

    })

}
```

Listo podemos comenzar a probar

Tenemos las siguientes transacciones

![[Pasted image 20231122185959.png]]

Y el siguiente balance
![[Pasted image 20231122190016.png]]

vamos a editar el gasto y lo pondremos como ingreso


![[Pasted image 20231122190524.png]]

Y como podemos ver a continuación

![[Pasted image 20231122193358.png]]

El gasto cambio a ingreso y en nuestro balance se sumo a 20

![[Pasted image 20231122193346.png]]

### Borrado de Transacciones - Un formulario con dos acciones

Ahora vamos a trabajar con el borrado de las transacciones, igual que hicimos con actualización, debemos de revertir el balance realizado por la transacción, desarrollemos un procedimiento almacenado para ello.

SPTransacciones_Borrar.sql
```CS
CREATE PROCEDURE Transacciones_Borrar

    -- Add the parameters for the stored procedure here

    @Id int

AS

BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from

    -- interfering with SELECT statements.

    SET NOCOUNT ON;

  

    DECLARE @Monto decimal (18,2);

    DECLARE @CuentaId int;

    DECLARE @TipoTransacciónId int;

  

    SELECT @Monto = Monto, @CuentaId = CuentaId, @TipoTransacciónId = cat.TipoTransacciónId

    FROM Transacciones

    INNER JOIN Categorías cat

    ON cat.Id = Transacciones.CategoriaId

    WHERE Transacciones.Id = @Id;

  

    DECLARE @FactorMultiplicativo int = 1;

  

    IF (@TipoTransacciónId = 2)

        SET @FactorMultiplicativo = -1;

  

    SET @Monto = @Monto * @FactorMultiplicativo;

  

    UPDATE Cuentas

    SET Balance -= @Monto

    WHERE id = @CuentaId;

  

    DELETE Transacciones

    WHERE Id = @Id;

END
```


Ahora vamos a crear el metodo en

RepositorioTransacciones.cs
```CS
public async Task Borrar(int Id){

            using var connection = new SqlConnection(connectionString);

            await connection.ExecuteAsync("Transacciones_Borrar", new {Id}, commandType: System.Data.CommandType.StoredProcedure);

        }
```


IRepositorioTransacciones.cs
```CS
Task Borrar(int Id);
```

Ahora para continuar hay que permitirle al usuario poder tener acceso a dicha funcion previa.


TransaccionesControler.cs
```CS
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
```


Ahora vamos hacia su vista

Editar.cshtml
```CS
<button class="btn btn-primary">Actualizar</button>

    <button class="btn btn-danger" asp-action="Borrar">Borrar</button>

    <a class="btn btn-secondary" asp-action="Index">Cancelar</a>
```

Si gustas poder revisar su funcionamiento vamos a crear una nueva transacción 

 ![[Pasted image 20231124100802.png]]

![[Pasted image 20231124100833.png]]

Como podemos ver su id es 3

y si intentamos entrar a editarlo

![[Pasted image 20231124100923.png]]

ahí tenemos nuestro botón borrar y si le damos clic

![[Pasted image 20231124101030.png]]

Exitosamente podemos apreciar su correcto funcionamiento.

## Reportes

### Intro

Finalmente vamos a la parte más importante para nuestros usuarios, los reportes van a poder ver los resúmenes de sus movimientos para así saber a dónde se va su dinero.

Lo que veremos:

* Movimientos de cuentas
* Reporte diario
* Reporte Semanal
* Reporte Mensual
* Excel
* Calendario

#### Resumen

### Movimientos de cuentas

Vamos a trabajar con la funcionalidad de ver las transacciones por cuentas. Lo que haremos es que al darle clic a alguna de las cuentas, nos lleve a una pagina en donde podamos visualizar todas las transacciones de esa cuenta agrupadas por fecha, con capacidad de indicar una fecha de inicio y final para visualizar dichas transacciones.

Empezaremos definiendo una nueva clase para usarla como parámetro del método que me va a  ayudar a obtener las transacciones por cuenta.

ObtenerTransaccionPorCuenta.cs
```CS
namespace ManejoPresupuesto.Models{

    public class ObtenerTransaccionPorCuenta{

        public int UsuarioId { get; set; }

        public int CuentaId { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

    }

}
```

Ahora vamos a crear un método para que busque esas transacciones por cuenta

RepositorioTransacciones.cs
```CS
public async Task<IEnumerable<Transaccion>> ObtenerPorCuentaId(ObtenerTransaccionPorCuenta modelo){

            using var connection = new SqlConnection(connectionString);

  

            return await connection.QueryAsync<Transaccion>

            (@"SELECT t.Id, t.Monto, t.FechaTransacción, c.Nombre as Categoria,

            cu.Nombre as Cuenta, c.TipoTransacciónId

            FROM Transacciones t

            INNER JOIN Categorías c

            ON c.Id = t.CategoriaId

            INNER JOIN Cuentas cu

            ON cu.id = t.CuentaId

            WHERE t.CuentaId = @CuentaId AND t.UsuarioId = @UsuarioId

            AND FechaTransacción BETWEEN @FechaInicio AND @FechaFin",

            modelo

            );

        }
```


IRepositorioTransacciones.cs
```CS
Task<IEnumerable<Transaccion>> ObtenerPorCuentaId(ObtenerTransaccionPorCuenta modelo);
```

Por euso de cuenta y categoria dento del script sql hay que añadir cierto parametros

Transaccion.cs
```CS
public string Cuenta { get; set; }

public string Categoria { get; set; }

```


Después vamos a necesitar un modelo el cual va a representar la data que le vamos a mostrar al usuario.

ReporteTransaccionesDetalladas.cs
```CS

namespace ManejoPresupuesto.Models{

    public class ReporteTransaccionesDetalladas{

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public IEnumerable<TransaccionesPorFecha> TransaccionesAgrupadas { get; set; }

        public decimal BalanceDepositos => TransaccionesAgrupadas.Sum(x => x.BalanceDepositos);

        public decimal BalanceRetiros => TransaccionesAgrupadas.Sum(x => x.BalanceRetiros);

        public decimal Total => BalanceDepositos - BalanceRetiros;

  
  
  

        public class TransaccionesPorFecha{

  

            public DateTime FechaTransaccion { get; set; }

            public IEnumerable<Transaccion> Transacciones { get; set; }

            public decimal BalanceDepositos =>

            Transacciones.Where(x => x.TipoTransacciónId == TipoTransacción.Ingreso)

            .Sum(x => x.Monto);

  

            public decimal BalanceRetiros =>

            Transacciones.Where(x => x.TipoTransacciónId == TipoTransacción.Gasto)

            .Sum(x => x.Monto);

  

        }

    }

}

```



Ahora trabajaremos con ello en

CuentasController.cs
```CS
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

		public async Task<IActionResult> Detalles(int Id, int Mes, int Año){

            var UsuarioId = serviciousuarios.ObtenerUsuarioId();

            var cuenta = await repositorioCuentas.ObtenerPorId(Id, UsuarioId);

  

            if( cuenta is null){

                return RedirectToAction("NoEncontrado","Home");

            }

  

            DateTime FechaInicio;

            DateTime FechaFin;

  

            if(Mes <= 0 || Mes > 12 || Año >= 1900){

                var Hoy = DateTime.Today;

                FechaInicio = new DateTime(Hoy.Year, Hoy.Month, 1);

            }

            else{

                FechaInicio = new DateTime(Año, Mes, 1);

            }

  

            FechaFin = FechaInicio.AddMonths(1).AddDays(-1);

  

            var ObtenerTransaccionPorCuenta = new ObtenerTransaccionesPorCuenta(){

                CuentaId = Id,

                UsuarioId = UsuarioId,

                FechaInicio = FechaInicio,

                FechaFin = FechaFin

            };

  

            var transacciones = await repositorioTransacciones.ObtenerPorCuentaId(ObtenerTransaccionPorCuenta);

  

            var modelo = new ReporteTransaccionesDetalladas();

            ViewBag.Cuenta = cuenta.Nombre;

  

            var TransaccionesPorFecha =transacciones.OrderByDescending(x => x.FechaTransaccion)

                            .GroupBy( x => x.FechaTransaccion)

                            .Select( grupo => new ReporteTransaccionesDetalladas.TransaccionesPorFecha()

                            {

                                FechaTransaccion = grupo.Key,

                                Transacciones = grupo.AsEnumerable()

                            });

  

            modelo.TransaccionesAgrupadas = TransaccionesPorFecha;

            modelo.FechaInicio = FechaInicio;

            modelo.FechaFin = FechaFin;

			ViewBag.mesAnterior = FechaInicio.AddMonths(-1).Month;

            ViewBag.añoAnterior = FechaInicio.AddMonths(-1).Year;

  

            ViewBag.mesPosterior = FechaInicio.AddMonths(1).Month;

            ViewBag.añoPosterior = FechaInicio.AddMonths(1).Year;

            return View(modelo);

        }

```

Ahora continuaremos con 

### Vista de movimientos de cuentas

Detalles.cshtml
```CS
@model ReporteTransaccionesDetalladas

  

@{

    ViewData["Title"] = "Movimietos Cuenta";

}

  

<h1>Movimientos @ViewBag.Nombre</h1>
```

No hay que olvidar de hacer el link en

Index.cshtml
```CS
<span><strong><a asp-action="Detalle" asp-route-id="@cuenta.Id">@cuenta.Cuenta</a></strong>
```



Para validar su funcionamiento veremos los cambios en index

![[Pasted image 20231124121742.png]]

Podemos ver que ya tienen una liga y si le dan clic

![[Pasted image 20231124122340.png]]

Como podemos ver de momento tenemos la redirección de forma correcta

Continuando vamos a darle la opción al usuario que pueda navegar por mes

Detalles.cshtml
```CS
<h4>

    <a asp-route-mes="@ViewBag.mesAnterior" asp-route-año="@ViewBag.añoAnterior"

    class="btn btn-secondary"><i class="bi-chevron-left"></i></a>

    @Model.FechaInicio.ToString("MMM")-@Model.FechaInicio.Year

    <a asp-route-mes="@ViewBag.mesPosterior" asp-route-año="@ViewBag.añoPosterior"

    class="btn btn-secondary"><i class="bi-chevron-right"></i></a>

</h4>
```

Al agregarle dicha porción de código podemos apreciar lo siguiente

// Imagen de movimiento de filtro de fechas


continuando con


Detalles.cshtml
```CS

```