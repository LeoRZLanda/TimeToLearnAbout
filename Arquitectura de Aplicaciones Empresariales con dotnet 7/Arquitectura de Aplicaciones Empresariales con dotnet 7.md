

# Sección 1: Acerca del curso

## Introducción al curso

### Que aprenderemos

1. Fundamentos de arquitectura de aplicaciones empresariales
2. Proceso de diseño de una arquitectura
3. Principios de diseño a seguir
4. Principales estilos de arquitectura
5. Diseñar un arquetipo orientado al dominio
6. Construir una aplicacion de ejemplo utilizando .Net Core
7. Utilizar herramientas como;
	* Dapper
	* AutoMapper
	* Swagger
	* JWT
	* Web API
	* Pruebas unitarias
	* Cobertura de código
	* Inyección de dependencias


### 1. Fundamentos de Arq. de aplicaciones

El objetivo final de la **arquitectura** es identificar los requisitos que producen un impacto en la estructura de la aplicación y reducir los riesgos asociados con la construcción.

La arquitectura debe soportarlos cambios futuros de a aplicación, tanto del hardware y de funcionalidad demandada por los clientes.

### 2. Proceso de diseño

* Identificar los objetivos de la iteración
* Seleccionar los casos de uso importantes.
* Realizar un esquema de la aplicación.
* Identificar los principales riesgos.
* Crear arquitecturas candidatos.

### 3. Principios de diseño SOLID

**S**ingle responsability Principle
**O**pen/Closed Principle
**L**iskov substitution principle
**I**nterface segregation principle
**D**ependency inversion principle

### 4. Estilos de arquitectura

* N-Niveles
* Web-Queue-work
* Microservicios
* CQRS
* Basado en eventos.


### 5. Arquetipo orientado al dominio

que tenga las siguientes capas

1. Transversal
2. Servicio
3. Aplicación
4. Dominio
5. Infraestructura de datos

![[Pasted image 20231205165450.png]]

Asegurando que la comunicación entre capas sea mediante interfaces y utilizando inyección de dependencias.

### 6. Construir Aplicación .net core

Como resultado final haremos una webAPI, que se integrara con swagger, y para la seguridad utilizara JWT

### 7. Herramientas case

Aplicaremos las herramientas anteriores y aprenderemos a como diseñar y documentar las webAPI en OpenAPI 

# Sección 2: Fundamentos de arquitectura de aplicaciones

## Definición

El diseño de la **arquitectura**  de una aplicación es el proceso por el cual se defina una solución para los requisitos técnicos y operacionales del mismo.

La **arquitectura** define qué componentes conforman la aplicación cómo se relacionan entre ellos, y cómo mediante su interacción llevan a cabo una funcionalidad especifica, cumpliendo con los criterios de calidad como seguridad, eficiencia, usabilidad, etc.

Durante el diseño de la **arquitectura** se tratan los temas que pueden tener un impacto importante en el éxito o fracaso de la aplicación.

Algunas preguntas a considerar:
* ¿En qué entorno va a ser desplegado nuestra aplicación?
* ¿Cómo va a ser el despliegue de nuestra aplicación en producción?
* ¿Cómo van a utilizar los usuarios nuestra aplicación?
* ¿Qué otros requisitos debe cumplir el sistema? (seguridad, rendimiento, concurrencia, configuración, escalabilidad, interoperabilidad, etc.)
* ¿Qué cambios en la arquitectura pueden impactar a la aplicación ahora o una vez desplegado?

Para diseñar la **arquitectura** de un sistema es importante tener en cuenta los intereses de los distintos stakeholders. Estos stakeholders son los usuarios del sistema, el propio sistema y los objetivos del negocio.

Cada uno de ellos impone requisitos que deben ser considerados en el diseño dela arquitectura y que pueden desencadenar algún conflicto, por lo que se debe alcanzar in compromiso entre los intereses de cada stakeholders.

El objetivo final de la **arquitectura** es identificar los requisitos que producen un impacto en la estructura de la aplicación y reducir los riesgos asociados con la construcción. La arquitectura debe soportar los cambios futuros de la aplicación, del hardware y de funcionalidad demandada por los clientes.

* Mostrar la estrucutra del sistema pero ocultar los detalles.
* Realizar todos los casos de uso
* Satisfacer en la medida de lo posible los intereses de los stakeholders.
* Ocuparse de los requisitos funcionales y de calidad (no funcionales).
* Determinar el tipo de aplicación a desarrollar
* Determinar los estilos arquitecturales que se usarán principales cuestiones transversales.

## Proceso de diseño de la arquitectura

### Importancia

El proceso de diseño de la **arquitectura** juega un rol muy importante en el ciclo de vida de la aplicación.

La diferencia entre un excelente proceso de diseño de arquitectura y uno deficiente puede suponer el éxito o fracaso de nuestro proyecto.

Durante el proceso de diseño de la **arquitectura** se tratan y decine temas importantes con la finalidad de crear un **arquetipo o una plantilla básica** de nuestra aplicación.

* ¿Qué tipo de aplicación se va a construir? (Web, RIA, Escritorio, etc)
* ¿Qué estructura lógica va a tener la aplicación? (N-Capas, Componentes, etc.)
* ¿Qué estructura física va a tener la aplicación? (Cliente/Servidor, N-Tier, etc.)
* ¿Qué riesgos hay que afrontar y cómo hacerlo?(Seguridad, rendimiento, interoperabilidad, Mantenibilidad,etc.)
* ¿Qué tecnologías vamos a usar? (WCF, WPF, Web API, Dapper, Entity Framework, .Net Core, JWT, etc.)

### Requisitos previos

Para realizar de manera eficiente todo el proceso de diseño partiremos de la información que ha generado el proceso de captura de requisitos:

* Casos de uso o historias de usuario.
* Requisitos funcionales y no funcionales
* Restricciones tecnológicas y de diseño en general.
* Entorno de despliegue propuesto.

### Etapas del proceso

El proceso de diseño de Arquitectura es iterativo e incremental y consta de 5 etapas, este proceso se repite hasta completar el desarrollo de la aplicación.

<ol>
	<li>
		<details>
			<summary>Identificar los objetivos de la iteración</summary>
			<p>
				<ul>
					<li>
						En esta etapa es muy importante analizar las restricciones que tiene nuestra aplicación en cuanto a tecnologías, topología de despliegue, uso del sistema, etc.
					</li>
					</br>
					<li>
						También es muy importante marcar cuales van a ser los objetivos de la arquitectura, tenemos que decidir si estamos construyendo un prototipo, realizando un diseño completo o probando posibles vías de desarrollo de la arquitectura.
					</li>
					</br>
					<li>
						El tipo de documentación a generar, así como el formato dependerá de si nos dirigimos a otros arquitectos, a desarrolladores, o a personas sin conocimientos técnicos.
					</li>
					</br>
					<li>
						El objetivo de esta fase del proceso de diseño de la arquitectura es entender por el entorno que rodea a nuestro sistema.
					</li>
					</br>
					<li>
						Al término de esta fase deberemos tener una lista de los objetivos de la iteración preferiblemente con planes para afrontarlos y métricas para determinar el tiempo y esfuerzo que requerirá completarlos.
					</li>
				</ul>
			</p>
		</details>
	</li>
	<li>
		<details>
			<summary>Seleccionar los casos de uso arquitectualmente importantes</summary>
			<p>
				</br>
				Significa que desarrollaremos primero los casos de uso (funcionalidad) que más
				valor tengan para el cliente y mitigaremos en primer lugar los riesgos más
				importantes que afronte nuestra arquitectura (requisitos de calidad).
				<ul>
					<li>
						Lo importante que es el caso de uso dentro de la lógica de negocio.
					</li>
					</br>
					<li>
						El desarrollo del caso de uso implica un desarrollo importante de la Arquitectura.
					</li>
					</br>
					<li>
						El desarollo del caso de uso implica tratar algún requisito de calidad.
					</li>
					</br>
					<li>
						Lo que se adapte el caso de uso a los objetivos de la iteración.
					</li>
					</br>
				</ul>
			</p>
		</details>
	</li>
	<li>
		<details>
			<summary>Realizar un esquema de la aplicación</summary>
			<p>
				</br>
				Llegados a este punto, el primer paso es decidir qué tipo de aplicación vamos a
				desarrollar. El tipo de aplicación que elegiremos dependerá de las restricciones de
				despliegue, de conectividad, de lo compleja que sea la interfaz de usuario y de las
				restricciones de interoperabilidad, flexibilidad y tecnologías que imponga el cliente.
				<ul>
					<li>
						Aplicaciones para dispositivos móviles.
					</li>
					</br>
					<li>
						Aplicaciones de escritorio.
					</li>
					</br>
					<li>
						Servicios
					</li>
					</br>
					<li>
						Aplicaciones web, SPA, etc.
					</li>
					</br>
				</ul>
			</p>
		</details>
	</li>
	<li>
		<details>
			<summary>Identificar los principales riesgos y definir una solución</summary>
			<p>
				</br>
				En esta etapa mitigamos los principales riesgos creando planes para solventarlos y planes de contingencia para el caso de que no puedan ser solventados.
				</br>
				</br>
				¿Cómo identificar los riesgos de la arquitectura?.. Con el entendimiento de los requisitos no funcionales.
				</br>
				</br>
				Los requisitos no funcionales son aquellas propiedades que debe tener aplicación, como por ejemplo: Alta disponibilidad, flexibilidad, interoperabilidad mantenimiento, gestión operacional, rendimiento, fiabilidad, reusabilidad escalabilidad, seguridad, robustez, capacidad de testeo y experiencia de usuario.
			</p>
		</details>
	</li>
	<li>
		<details>
			<summary>Crear arquitecturas candidatas</summary>
			<p>
				</br>
				Una vez realizadas las etapas anteriores, tendremos una arquitectura candidata
				que podremos evaluar. Si tenemos varias arquitecturas candidatas, realizaremos
				la evaluación de cada una de ellas e implementaremos la arquitectura mejor
				valorada, las cuales deberían responder:
				<ul>
					<li>
						¿Qué funcionalidad implementa?
					</li>
					</br>
					<li>
						¿Qué riesgos mitiga?
					</li>
					</br>
					<li>
						¿Cumple las restricciones impuestas por el cliente?
					</li>
					</br>
					<li>
						¿Qué cuestiones deja en el aire?
					</li>
					</br>
				</ul>
			</p>
		</details>
	</li>
</ol>


## Desacoplamiento entre componentes


El desacoplamiento debería realizarse entre todos los objetos (con lógica de ejecución y dependencias) pertenecientes a las diferentes capas, pues existen ciertas capas que se deben integrar a la aplicación de una forma desacoplada.

En definitiva, desacoplar componentes es conseguir un "state of the art" del diseño interno de nuestra aplicación: "Tener preparada toda la estructura de la Arquitectura de la aplicación de forma desacoplada y en cualquier momento poder inyectar funcionalidad para cualquier área o grupo de objetos, no tiene por qué ser solo entre capas diferentes".

Las técnicas de desacoplamiento están basadas en el **Principio de Inversión de Dependencias**. El propósito es conseguir disponer de capas de alto nivel que sean independientes de la implementación y detalles concretos de las capas de más bajo nivel, y por lo tanto también, independientes de las tecnologías subyacentes.

* Las capas de alto nivel no deben depender de las capas de bajo nivel. Ambas capas deben depender de abstracciones (Interfaces).
* Las abstracciones no deben depender de los detalles. Son los detalles (Implementación) los que deben depender de las abstracciones (Interfaces).

![[Pasted image 20231205165450.png]]


## Principales Técnicas

Las técnicas principales que se utilizar para habilitar el
desacoplamiento entre capas, son:

* Inversión de control (loC).
* Inyección de dependencias (DI).
* Interfaces de Servicios Distribuidos (para consumo/acceso remoto a capas).

El uso correcto de estas técnicas, gracias al desacoplamiento
que aportan, potencia los siguientes puntos:

* Posibilidad de sustitución, en tiempo de ejecución, de capas/módulos actuales por otros diferentes (con mismos interfaces y similar comportamiento), sin que impacte a la aplicación.

* Posibilidad de uso de STUBS/MOLES y MOCKS en pruebas unitarias.

## Inyección de dependencias e Inversión de Control

### Patrón de Inversión de Control (IoC)

Consiste en **delegar** a un componente o fuente externa, la función de seleccionar un tipo de implementación concreta de las dependencias de nuestras clases. En definitiva, este patrón describe técnicas para soportar una arquitectura tipo "**plug-in**" donde los objetos pueden buscar instancias de otros objetos que requieren y de los cuales dependen.

### Patrón Inyección de Dependencias (DI)

Es realmente un caso especial de loC. Es un patrón en el que se suplen objetos/dependencias a una clase en lugar de ser la propia clase quien cree los objetos/dependencias que necesita.

La forma más potente de implementar este patrón es mediante un
"**Contenedor DI**". El contenedor Dl inyecta a cada objeto las dependencias/objetos necesarios según las relaciones o registro plasmado bien por código o en ficheros XML de configuración del "**Contenedor DI**".

Típicamente el "**Contenedor DI**" es proporcionado por un
**framework** externo a la aplicación (**como Unity, Castle-
Windsor, Spring.NET**, etc.), por lo cual en la aplicación también se utilizará **Inversión de Control** al ser el contenedor
(almacenado en una biblioteca) quien invoque el código de la aplicación.

Las técnicas de inyección de instancias de objetos son:

• Inyección de interfaz, Inyección de constructor.

* Inyección de propiedad (setter) e Inyección de llamada a método.

La opción más potente relativa al desacoplamiento es hacer uso de loC y DI entre prácticamente todos los objetos pertenecientes a las capas de la arquitectura, esto nos permitirá en cualquier momento inyectar simulaciones de comportamiento o diferentes ejecuciones reales cambiándolo en tiempo de ejecución y/o configuración.


En definitiva, **los contenedores loC** y **la Inyección de dependencias** añaden flexibilidad y conllevan a "tocar" el menor código posible según avanza el proyecto. **Añaden comprensión y mantenibilidad de proyecto**.

Con .Net tenemos inyección de dependencia nativo ya que, básicamente este ha sido construido mediante interfaces.

Vida útil de las dependencias de los servicios en .NET Core:

• Transitorio (addTransient): Se crea una nueva instancia, cada vez que crea un servicio o son solicitadas.

• Ámbito (addScoped): Se genera una nueva instancia para cada ámbito. (Cada solicitud es un alcance). Dentro del ámbito, el servicio es reutilizado.

• Singleton (adSingleton): Se crea solo una vez y se usa en todas partes.

## Capas vs Niveles

Es importante distinguir los conceptos de **"Capas".(Layers)** y
**"Niveles" (Tiers)**, pues es bastante común que se confundan y
o se denominen de forma incorrecta.


Las **Capas (Layers)** se ocupan de la división lógica de componentes y funcionalidad, y no tienen en cuenta la localización física de componentes en diferentes servidores o
en diferentes lugares.

Los **Niveles (Tiers)** se ocupan de la distribución física de
componentes y funcionalidad en servidores separados,
teniendo en cuenta topología de redes y localizaciones
remotas.

Aunque tanto las **Capas (Layers)** como los **Niveles (Tiers)** usan
conjuntos similares de nombres (presentación, servicios, negocio y datos), es importante no confundirlos y recordar
que solo los **Niveles (Tiers)** implican una separación física.

![[Pasted image 20231205190609.png]]

Por último, destacar que todas las aplicaciones con cierta complejidad, deberían implementar una arquitectura lógica de tipo **N-Capas**, pues proporciona una estructuración lógica correcta; sin embargo, no todas las aplicaciones tienen por qué implementarse en modo **N-Tier**, puesto que hay aplicaciones que no requieren de una separación física de sus niveles (Tiers).


## Capas

###