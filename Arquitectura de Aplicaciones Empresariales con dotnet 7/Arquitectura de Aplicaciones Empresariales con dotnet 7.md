

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

### Consideraciones iniciales

* Localizar los cambios en una parte especifica de la solución minimiza el impacto en otras partes, reduce el trabajo requerido en arreglar defectos, facilita el mantenimiento de la aplicación y mejora la flexibilidad general de la aplicación.

* La separación de responsabilidades entre componentes (por ejemplo, separar la interfaz de usuario de la lógica de negocio, y la lógica de negocio del acceso a la base de datos, etc.) aumenta la flexibilidad, la mantenibilidad y la escalabilidad.

* Ciertos componentes deben ser reutilizables entre diferentes módulos de una aplicación o incluso entre diferentes aplicaciones.

* Equipos diferentes deben poder trabajar en partes de la solución con mínimas dependencias, para ello, deben desarrollar contra interfaces bien definidas.

* Los componentes individuales deben ser cohesivos.

* Los componentes no relacionados directamente deben estar
débilmente acoplados.

* Los diferentes componentes de una solución deben poder ser
desplegados de una forma independiente, e incluso mantenidos y
actualizados en diferentes momentos.

* Para asegurar estabilidad y calidad, cada capa debe contener sus propias pruebas unitarias.

### Capas

Las **capas** son agrupaciones horizontales lógicas de componentes de software que forman la aplicación.

Nos ayudan a diferenciar entre los diferentes tipos de tareas a ser realizadas por los componentes, ofreciendo un diseño que maximiza la reutilización y, especialmente, la mantenibilidad.

En definitiva, se trata de aplicar el principio de "Separación de Responsabilidades" (SoC - Separation of Concerns principle) dentro de una Arquitectura.

El dividir una aplicación en capas separadas que desempeñan diferentes roles y funcionalidades, nos ayuda a mejorar el mantenimiento del código; nos permite también diferentes tipos de despliegue y, sobre todo, nos proporciona una clara delimitación y situación de dónde debe estar cada tipo de componente funcional e incluso cada tipo de tecnología.

### Consideraciones relativas a pruebas

Una aplicación basado en una Arquitectura N-Capas mejora considerablemente la capacidad de implementar pruebas de una forma apropiada:

* Debido a que cada capa interactúa con otras capas solo mediante interfaces bien definidos, es fácil añadir implementaciones alternativas a cada capa (Mock y Stubs). Esto permite realizar pruebas unitarias de una capa incluso cuando las capas de las que depende no están finalizadas o, incluso, porque se quiera poder ejecutar mucho más rápido un conjunto muy grande de pruebas unitarias.

* Es más fácil realizar pruebas sobre componentes individuales porque las dependencias entre ellos están limitadas de forma que los componentes de capas de alto nivel solo pueden interactuar con los de niveles inferiores. Esto ayuda a aislar componentes individuales para poder probarlos adecuadamente y nos facilita el poder cambiar unos componentes de capas inferiores por otros diferentes con un impacto muy pequeño en la aplicación (siempre y cuando cumplan los mismos interfaces).

### Beneficios

Beneficios del uso de una arquitectura N-Capas

* El mantenimiento en una solución será mucho más fácil porque las funciones están localizadas. Además las capas deben estar débilmente acopladas entre ellas y con alta cohesión internamente, lo cual posibilita variar de una forma sencilla diferentes implementaciones de capas.

* Otras soluciones deberían poder reutilizar funcionalidad expuesta por diferentes capas, especialmente si se han diseñado para ello.

* Los desarrollos distribuidos son mucho más sencillos de implementar si el trabajo se ha distribuido previamente en diferentes capas lógicas.

## Principios de Base de diseño a seguir

### Principios de diseño SOLID

#### S: Principio de Única Responsabilidad

Una clase debe tener una única responsabilidad o característica. Dicho de otra manera, una clase
debe de tener una única razón por la que está justificado realizar cambios sobre su código fuente. Una consecuencia de este principio es que, de forma general, las clases deberían tener pocas dependencias con otras clases/tipos.

#### O: Principio Abierto Cerrado

Una clase debe estar abierta para la extensión y cerrada para
la modificación. Es decir, el comportamiento de una clase debe poder ser extendido necesidad de realizar modificaciones sobre el código de la misma.

#### L: Principio de sustitución de Liskov

Los subtipos deben poder ser sustituibles por sus tipos base (interfaz o clase base). Este hecho se deriva de que el comportamiento de un programa que trabaja con abstracciones (interfaces o clases base) no debe cambiar porque se sustituya una implementación concreta por otra. Los programas deben hacer referencia a las abstracciones, y no a las implementaciones.

#### I:Principio de segregación de Interfaces

Las implementaciones de las Interfaces en las clases no deben estar obligados a implementar métodos que no se usan. Es decir, los interfaces de clases deben ser específicos dependiendo de quién los consume y por lo tanto, tienen que estar granularizados / segregados en diferentes interfaces no debiendo crear nunca grandes interfaces.

#### D: Principio de Inversión de dependencias

Las abstracciones no deben depender de los detalles - Los detalles deben depender de las abstracciones. Las dependencias directas entre clases deben ser reemplazadas por abstracciones (interfaces) para permitir diseños top-down sin requerir primer el diseño de los niveles inferiores.

### Otros Principios Clave de Diseño

* **El diseño de componentes debe ser altamente cohesivo**: No sobrecargar los componentes añadiendo funcionalidad mezclada o no relacionada. Por ejemplo, evitar mezclar lógica de acceso a datos con lógica de negocio perteneciente al Modelo del Dominio.

* **Mantener el código transversal abstraído de la lógica específica de la aplicación:** El código transversal se refiere a código de aspectos horizontales, cosas como la seguridad, gestión de operaciones, logging, instrumentalización, etc.

* **Separación de Preocupaciones/Responsabilidades**: Dividir la aplicación en distintas partes minimizando las funcionalidades superpuestas ente dichas partes. El factor fundamental es minimizar los puntos de interacción para conseguir una alta cohesión y un bajo acoplamiento.

• **No repetirse (DRY)**: Se debe especificar "la intención" en un único sitio en el sistema. Por ejemplo, en términos del diseño de una aplicación, una funcionalidad específica se debe implementar en un único componente; esta misma funcionalidad no debe estar implementada en otros componentes.

## Principales Estilos de Arquitectura

### Definición de Estilo de Arquitectura

Un estilo de arquitectura es una familia de arquitecturas que comparten determinadas características.

Por ejemplo, **de n niveles** es un estilo de arquitectura común. Últimamente, las **arquitecturas de microservicios** se han empezado a hacer más populares.

Los estilos de arquitectura no requieren el uso de tecnologías concretas, pero algunas tecnologías son adecuadas para ciertas arquitecturas. Por ejemplo, los contenedores son una opción natural para los microservicios.

### Principales Estilos de Arquitectura

#### N-Niveles

Es una arquitectura tradicional para aplicaciones empresariales. Las dependencias se administran mediante la división de la aplicación en capas que realizan funciones lógicas como presentaciones, lógica de negocios y acceso a datos. Una capa solo puede llamar a las capas que se encuentran por debajo de ella.

#### Web-Queue-Work

En este estilo, la aplicación tiene un Front-End web que controla las solicitudes HTTP y un trabajo de back-end que realiza tareas de uso intensivo de la CPU u operaciones de larga duración. El Front-End se comunica con el través de una cola de mensajes asincrónicos. 

La arquitectura Web-Cola-Trabajo es adecuada para dominios relativamente sencillos con algunas tareas que consumen muchos recursos.

#### Microservicios

Una aplicación de microservicios se compone de muchos servicios pequeños e independientes. Cada servicio implementa una sola función empresarial. Los servicios están acoplados de forma flexible y se comunican a través de contratos de API.

Una arquitectura de microservicios es más compleja a la hora de compilar y administrar.

#### CQRS

El estilo **CQRS** (Segregación de responsabilidades de consultas y comandos) separa las operaciones de lectura y escritura en modelos independientes. Esto permite aislar las partes del sistema que actualizan los datos de las leen los datos. 

Se debería tenerlo en cuenta para dominios colaborativos en los que muchos usuarios acceden a los mismos datos.
#### Arquitectura basada en eventos

Usa un modelo de publicación-suscripción (pub-sub), en el que los productores publican eventos y los consumidores se suscriben a ellos. Los productores son independientes de los consumidores y estos, a su vez, son independientes entre sí.

Se debería tenerlo en cuenta para aplicaciones que consumen y procesan un gran volumen de datos con una latencia muy baja.

# Sección 3: Arquitectura N-Capas con Orientación al Dominio

## Definición de Arquitectura con orientación al domino (DDD)

### Definición

Esta compuesta por tres niveles

1. Vista
2. Aplicación
	* Se realiza la transformaciones de objetos a través de DTO, control de excepciones, las transacciones  
3. Modelo
	* La lógica del negocio 
4. Infraestructura / sistema
	* Respecto al Login, a la persistencia con una base de datos, la interacción con otros servicios.

El objetivo de esta arquitectura marco es proporcionar una base consolidada para un tipo concreto de aplicaciones: **"Aplicaciones empresariales complejas"**. 

Este tipo de aplicaciones se caracterizan por tener una vida relativamente larga y un volumen de cambios evolutivos considerable.

Por lo tanto, en estas aplicaciones es muy importante todo lo relativo al mantenimiento de la aplicación, la facilidad de actualización, o la sustitución de tecnologías y frameworks/ORMs por otras versiones más modernas o incluso por otros diferentes, etc. 

El **objetivo** es que todo esto se pueda realizar con el menor impacto posible sobre el resto de la aplicación.

**Ejemplo:** En las aplicaciones complejas, el comportamiento de las reglas de negocio (lógica del Dominio/modelo) está sujeto a muchos cambios y es muy importante poder modificar, construir y realizar pruebas sobre dichas capas de lógica del dominio de una forma fácil e independiente. 

Debido a esto, un objetivo importante es tener el mínimo acoplamiento entre el Modelo del Dominio (lógica y reglas de negocio) y el resto de capas del sistema (Capa de presentación, Capa de Aplicación, Capa de Infraestructura de persistencia de datos, etc.).

### Diseño de un microservicio (DDD)

El diseño guiado por el dominio (**DDD**) propone un modelado basado en la realidad de negocio con relación a sus casos de uso. 

En el contexto de la creación de aplicaciones, DDD hace referencia a los problemas como dominios. Describe áreas con problemas independientes como contextos delimitados (cada contexto delimitado está correlacionado con un microservicio) y resalta un lenguaje común para hablar de dichos problemas.

También sugiere muchos patrones y conceptos técnicos, pero lo importante no son los patrones en sí, sino organizar el código para que esté en línea con los problemas del negocio y utilizar los mismos términos empresariales (lenguaje ubicuo).

La clave está en dónde situar los límites al diseñar y definir un microservicio. Los patrones de DDD le ayudan a comprender la complejidad del dominio. 

Si dos microservicios necesitan colaborar mucho entre sí, probablemente sean el mismo microservicio.

### Niveles en Microservicios de DDD

* [Nivel de aplicación](#nivel-de-aplicación)
* [Nivel de Modelo del Dominio](#nivel-de-modelo-del-dominio)
* [Nivel de Infraestructura](#nivel-de-infraestructura)

### Nivel de aplicación

Define los trabajos que se supone que el software debe hacer y dirige los objetos de dominio expresivo para que resuelvan problemas. 

Este nivel debe mantenerse estrecho. No contiene reglas de negocios ni conocimientos, sino que solo coordina tareas y delega trabajo a colaboraciones de objetos de dominio en el siguiente nivel.

### Nivel de Modelo del Dominio

Responsable de representar conceptos del negocio, información sobre la situación del negocio y reglas de negocios. El estado que refleja la situación empresarial está controlado y se usa aquí, aunque los detalles técnicos de su almacenaje se delegan a la infraestructura. Este nivel es el núcleo del software empresarial.
### Nivel de Infraestructura

El nivel de infraestructura es la forma en que los datos que inicialmente se conservan en las entidades de dominio (en la memoria) se guardan en bases de datos o en otro almacén permanente.

## Arquetipo con Orientación al Dominio (DDD)

### Diseñar arquetipo

</br>

* **Capa de Infraestructura de Datos**
</br>
	✔ **Data**
		Conexión a la base de datos
		</br>
	✔ **Interface**
		Definición de métodos CRUD
		</br>
	✔ **Reposiroty**
		Implementación de las interfaces, métodos CRUD

</br>


* **Capa de Dominio**
</br>
	✔ **Entity**
		Entidades de Negocio
		Limites de Contexto (Microservicio)
		</br>
	✔ **Interface**
		Definición de los métodos de negocio
		</br>
	✔ **Core**
		Implementación de las interfaces, lógica de Negocio
</br>

* **Capa de Aplicación**
</br>
	✔ **DTO**
		Objetos de Transferencia de Datos
		</br>
	✔ **Interface**
		Definición de los métodos de aplicación
		</br>
	✔ **Main**
		Implementación de las interfaces y gestión de cuestiones técnicas
		Gestion de excepciones
		Manejo de transacciones
		Transformacón de Objetos
</br>

* **Capa de Servicio**
</br>
	✔ **Web API**
		Servicios HTTP RESTful
		CORS
		Inyección de dependencias
		Seguridad JSON Web Token
		Swagger (Especificación openAPI)
</br>

* **Capa de Transversal**
</br>
	✔ **Common**
		Clases base, interfaces y funciones comunes.
		</br>
	✔ **Mapper**
		Mapeo de objetos (DTO / entidades y viceversa)
		</br>
	✔ **Logging**
		Trazabilidad(stack trace)
</br>


### Definir tecnología por capa

* **Capa de Infraestructura de datos**
</br>
	✔ NETStandard.Library
	✔ Micro ORM Dapper
	✔ Microsoft.Extensions.Configuration
	✔ System.Data.SqlClient
</br>

* **Capa de Dominio**
</br>
	✔ NETStandard.Library
</br>

* **Capa de aplicación
</br>
	✔ NETStandard.Library
	✔ AutoMapper
</br>

* **Capa de servicios**
</br>
	✔ Microsoft.AspNetCore.App
	✔ Microsoft.NetCore.App
	✔ AutoMapper
	✔ AutoMapper.Extensions.Microsoft.DependencyInjection
	✔ Swashbuckle.AspNetCore (Swagger)
	✔ System.IdentityModel.Tokens.Jwt (JWT)
</br>

* **Capa Transversal**
</br>
	✔ NETStandard.Library
	✔ AutoMapper
</br>

# Sección 4: Configuración del entorno de desarrollo

La configuración del entorno en donde comenzare a desarrollar este proyecto son los siguientes:

* Sistema Operativo
	* Windows 10

* Motor de base de datos
	* MS SQL Server 19
	* [Azure Data Studio]([Download and install Azure Data Studio - Azure Data Studio | Microsoft Learn](https://learn.microsoft.com/en-us/azure-data-studio/download-azure-data-studio?view=sql-server-2017&tabs=win-install%2Cwin-user-install%2Credhat-install%2Cwindows-uninstall%2Credhat-uninstall#download-azure-data-studio))

* IDE
	* Visual Studio 2019

* Framework
	* [.NET SDK 2.2]([Download .NET Core 2.2 (Linux, macOS, and Windows) (microsoft.com)](https://dotnet.microsoft.com/en-us/download/dotnet/2.2))


PD: para que lo tengas en consideración más adelante se mostrara como ir actualizando el proyecto hasta .NET 8