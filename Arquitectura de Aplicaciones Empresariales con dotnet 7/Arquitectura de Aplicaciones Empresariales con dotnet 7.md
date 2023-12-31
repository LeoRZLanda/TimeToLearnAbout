

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
	* [Azure Data Studio](https://learn.microsoft.com/en-us/azure-data-studio/download-azure-data-studio?view=sql-server-2017&tabs=win-install%2Cwin-user-install%2Credhat-install%2Cwindows-uninstall%2Credhat-uninstall#download-azure-data-studio)

* IDE
	* Visual Studio 2019

* Framework
	* [.NET SDK 2.2](https://dotnet.microsoft.com/en-us/download/dotnet/2.2)


PD: para que lo tengas en consideración más adelante se mostrara como ir actualizando el proyecto hasta .NET 8

### Comenzemos 

#### DB

Al tener el entorno preparado empezaremos estableciendo conexión a sql server mediante Azure Data Studio. Al abrirlo tenremos una interfaz similar a esta 

![[Pasted image 20231206154213.png]]


Le daremos clic en nueva conexión y lo llenaremos con nuestras respectivas credenciales

Al entablar conexión daremos clic derecho a la conexión y le daremos a new query, copiamos y pegamos el documento sql llamado instnwnd y tendremos la base de datos con nombre northwind

![[Pasted image 20231206160309.png]]

# Sección 5: Capa de Infraestructura de Persistencia de Datos

## Creación de Objetos en MS SQL Server

Lo que vamos a realizar seran procesos almacenado que nos permita realizar CRUD ante la Customers de la DB Northwind


Si quieres visualizar el codigo se encuentra en recursos con el nombre objects, simplemente ejecutalo en azure data studio y puedes validar si ves la carpeta programmability

## Construcción de la Capa de Infraestructura de Persistencia de Datos

En esta sección construiremos: 


la Capa de Infraestructura de Datos
* Data
* Interface
* Repository

La capa Transversal
* Common

La capa de dominio
* Entity

Es hora de crear nuestro proyecto en visual studio

Ya que empezaremos con la capa transversal, ya que quremos que nuestro proyecto sea reutilizable en cualquier .NET y xamarin utilizaremos .NET Standard, creando nuestra libreria.

Solo para recordar que los proyectos de la capa de percistencia de datos, la capa transversal, dominio y aplicación usaran .NET Standard y solamente nuestro proyecto web API usara .NET Core.

![[Pasted image 20231206162510.png]]



Algo importante al colocar el nombre a una librería, se recomienda lo siguiente.

Empresa.NombreDeAplicación.NombreDeLaCapa.Caacteristica.

En este caso usaremos


DarkShop.Ecommerce.Transversal.Common

![[Pasted image 20231206164018.png]]


![[Pasted image 20231206164041.png]]

Al Terminar de crear el proyecto lo tendremos por defecto con Class1

Y añadiremos una interface

![[Pasted image 20231206164345.png]]


Y la llamaremos IConnectionFactory.cs

![[Pasted image 20231206164458.png]]

Para empezar quedaría algo así

IConnectionFactory.cs
```CS
using System.Data;

namespace DarkShop.Ecommerce.Transversal.Common
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }
    }
}

```

Para organizar mejor nuestra solución vamos a crear carpetas de acuerdo a nuestras capas.

Para ello le daremos clic derecho a nuestra solución y darle clic en añadir nueva carpeta, les pondremos como nombre Transversal, Aplicacion, Infraestructura y Servicio

![[Pasted image 20231206165052.png]]

Así para cuando desarrollemos nuevos proyectos los podamos incorporar en la carpeta de su capa respectiva para un mejor orden.

Antes que nada arrastremos el proyecto previo a su carpeta respectiva.

Ahora vamos a proceder a crear el proyecto que va implementar nuestra interfaz IConnectionFactory.

En este caso como va a administrar la instancia de conexión a nuestra base de datos, lo vamos a colocar dentro de la capa de Infraestructura.

Sera otra libreria .NET standard 2.0 con nombre

y le crearemos la siguiente clase.

El siguiente proyecto tiene como responsabilidad conectarse a la base de datos y devolver la instancia de la conexión.

Para ello vamos a necesitar dos componentes adicionales que los consigueremos a travez de NuGet.

El primero es System.Data.SqlClient que nos permite interacturar con SQL Server.

Y el otro es Microsoft.Extension.Configuration, es un simil al .Configuration de .NET Framework que nos permite acceder a los archivos de configuración, como web.config o appsettings.

Para ello le daremos clic derecho y clic en adnministrar paquetes NuGet.

![[Pasted image 20231206171706.png]]

Los buscamos e instalamos 

![[Pasted image 20231206171951.png]]

![[Pasted image 20231206172228.png]]

Continuando, ahora implementaremos la referencia de IConnectionFactory a la capa de infraestrucura.

![[Pasted image 20231206175642.png]]



Y lo importamos en la siguiente clase

ConnectionFactory.cs
```CS
using System;
using DarkShop.Ecommerce.Transversal.Common;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace DarkShop.Ecommerce.Infraestructure.Data
{
    public class ConnectionFactory :IConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public ConnectionFactory(IConfiguration configuration) {
            _configuration = configuration;
        }

        public IDbConnection GetConnection{
            get {
                var SqlConnection = new SqlConnection();
                if (SqlConnection == null) return null;

                SqlConnection.ConnectionString = _configuration.GetConnectionString("NorthwindConnection");
                SqlConnection.Open();
                return SqlConnection;
            }
        }

    }
}

```

Con esto ya tenemos el metodo que accede a nuestra DB y nos devuelve una conexión activa.

Ahora vamos a crear el proyecto de interfacez e el proyecto de infraestructura en donde vamos a declarar todos los metodos CRUD

Lo llamaremos DarkShop.Ecommerce.Infrastructure.Interface Y le añadiremos su interfaz IConstumersRepository.cs.

Junto a ello crearemos el proyecto Domain.Entity en donde definiremos nuestra clase Customer.

Procederemos a declarar cada un de los atributos de la clase:

Customer.cs
```CS
namespace DarkShop.Ecommerce.Domain.Entity
{
    public class Customers
    {
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
}

```


Agregáremos referencia en la capa infraestrucutra.interface sobre el proyecto anterior domain.entity

Ahora si podremos continuar con

ICostumersRepository.cs
```CS
using DarkShop.Ecommerce.Domain.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DarkShop.Ecommerce.Infrastructure.Interface
{
    public interface IConstumersRepository
    {
        #region Métodos Sincronos
        bool Insert(Customers customer);
        bool Update(Customers customer);
        bool Delete(string customerId);
        Customers Get(string customerId);
        IEnumerable<Customers> GetAll();
        #endregion

        #region Métodos Asincronos
        Task<bool> InsertAsync(Customers customer);
        Task<bool> UpdateAsync(Customers customer);
        Task<bool> DeleteAsync(string customerId);
        Task<Customers> GetAsync(string customerId);
        Task<IEnumerable<Customers>> GetAllAsync();
        #endregion

    }
}


```

Ahora vamos a crear el proyecto Repository que va a implementar la interfaz ICostumerRepository.cs

Le incorporamos las referencias de Interface, Common y Data.

Y renombramos el archivo class1.cs a CustomerRepository.cs


Como hemos indicado previamente para acceder al motor de base de datos vamos a utilizar un Micro ORM, llamado Dapper, lo instalaremos mediante NuGet dentro del proyecto Repository.

Y para finalizar desarrollamos los métodos CRUD en 

CustomerRepository.cs
```CS
using System;
using DarkShop.Ecommerce.Domain.Entity;
using DarkShop.Ecommerce.Infrastructure.Interface;
using DarkShop.Ecommerce.Transversal.Common;
using Dapper;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DarkShop.Ecommerce.Infrastructure.Repository
{
    public class CustomersRepository : ICostumersRepository
    {
        private readonly IConnectionFactory _connectionFactory;
        public CustomersRepository(IConnectionFactory connectionFactory) {
            _connectionFactory = connectionFactory;
        }

        #region Métodos Síncronos

        public bool Insert(Customer customer) {
            using (var connection = _connectionFactory.GetConnection) {
                var query = "CustomersInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customer.CustomerId);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address",customer.Address);
                parameters.Add("City",customer.City);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            } 
        }

        public bool Update(Customer customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customer.CustomerId);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public bool Delete(string CustomerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersDelete";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", CustomerId);

                var result = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public Customer Get(string CustomerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersGetById";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", CustomerId);

                var customer = connection.QuerySingle<Customer>(query, param: parameters, commandType: CommandType.StoredProcedure);

                return customer;
            }
        }

        public IEnumerable<Customer> GetAll()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersGetById";

                var customers = connection.Query<Customer>(query, commandType: CommandType.StoredProcedure);

                return customers;
            }
        }

        #endregion

        #region Métodos Asincronos

        public async Task<bool> InsertAsync(Customer customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersInsert";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customer.CustomerId);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public async Task<bool> UpdateAsync(Customer customer)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", customer.CustomerId);
                parameters.Add("CompanyName", customer.CompanyName);
                parameters.Add("ContactName", customer.ContactName);
                parameters.Add("ContactTitle", customer.ContactTitle);
                parameters.Add("Address", customer.Address);
                parameters.Add("City", customer.City);
                parameters.Add("PostalCode", customer.PostalCode);
                parameters.Add("Country", customer.Country);
                parameters.Add("Phone", customer.Phone);
                parameters.Add("Fax", customer.Fax);

                var result = await connection.ExecuteAsync(query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public async Task<bool> DeleteAsync(string CustomerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersDelete";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", CustomerId);

                var result = await connection.ExecuteAsync (query, param: parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public async Task<Customer> GetAsync(string CustomerId)
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersGetById";
                var parameters = new DynamicParameters();
                parameters.Add("CustomerID", CustomerId);

                var customer = await connection.QuerySingleAsync<Customer>(query, param: parameters, commandType: CommandType.StoredProcedure);

                return customer;
            }
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            using (var connection = _connectionFactory.GetConnection)
            {
                var query = "CustomersGetById";

                var customers = await connection.QueryAsync<Customer>(query, commandType: CommandType.StoredProcedure);

                return customers;
            }
        }

        #endregion
    }
}

```

# Sección 6: Capa de Modelo de Dominio

## Construir la capa de Dominio 

* Interface
	Definición de los Métodos de negocio
* Core
	Implementación de las interfaces y lógica de negocio

* Entity
	Entidades de Negocio
	Limites de Contexto (Microservicio)

## Construcción de la capa de Dominio

Como previamente mencionamos crearemos dos proyectos en la capa de dominio, interfaz y core en donde estarán sus implementaciones.

Tendrá como nombre

DarkShop.Ecommerce.Domain.Interface

y su interface sera, no hay que olvidar de agregar la referencia a Domain.Entity

ICostumersDomain.cs
```CS
using System;
using System.Collections.Generic;
using System.Text;
using DarkShop.Ecommerce.Domain.Entity;
using System.Threading.Tasks;

namespace DarkShop.Ecommerce.Domain.Interface
{
    public interface ICostumersDomain
    {
        #region Métodos Sincronos
        bool Insert(Customer customer);
        bool Update(Customer customer);
        bool Delete(string customerId);
        Customer Get(string customerId);
        IEnumerable<Customer> GetAll();
        #endregion

        #region Métodos Asincronos
        Task<bool> InsertAsync(Customer customer);
        Task<bool> UpdateAsync(Customer customer);
        Task<bool> DeleteAsync(string customerId);
        Task<Customer> GetAsync(string customerId);
        Task<IEnumerable<Customer>> GetAllAsync();
        #endregion
    }
}

```

Ahora crearemos el proyecto Core, con el siguiente nombre

DarkShop.ecommerce.Domain.Core

Como previamente mencionamos aquí se alojara la lógica y reglas del negocio.

Y crear una clase con nombre CustomerDomain, y a continuación incorporarle las recencias de Domain.Entity  e Interface junto con Infrastructure.Iterface

CustomersDomain.cs
```CS
using System;
using DarkShop.Ecommerce.Domain.Entity;
using DarkShop.Ecommerce.Domain.Interface;
using DarkShop.Ecommerce.Infrastructure.Interface;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DarkShop.Ecommerce.Domain.Core
{
    public class CustomersDomain : ICustomersDomain
    {
        private readonly ICustomersRepository _customersRepository;

        public CustomersDomain(ICustomersRepository CustomersRepository)
        {

            _customersRepository = CustomersRepository;

        }

        #region Métodos Síncronos

        public bool Insert(Customer customer){
            return _customersRepository.Insert(customer);
        }

        public bool Update(Customer customer)
        {
            return _customersRepository.Update(customer);
        }

        public bool Delete(string customerId)
        {
            return _customersRepository.Delete(customerId);
        }

        public Customer Get(string customerId)
        {
            return _customersRepository.Get(customerId);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customersRepository.GetAll();
        }


        #endregion

        #region Métodos Asincronos

        public async Task<bool> InsertAsync(Customer customer)
        {
            return await  _customersRepository.InsertAsync(customer);
        }

        public async Task<bool> UpdateAsync(Customer customer)
        {
            return await _customersRepository.UpdateAsync(customer);
        }

        public async Task<bool> DeleteAsync(string customerId)
        {
            return await _customersRepository.DeleteAsync(customerId);
        }

        public async Task<Customer> GetAsync(string customerId)
        {
            return await _customersRepository.GetAsync(customerId);
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _customersRepository.GetAllAsync();
        }

        #endregion
    }
}

```

# Sección 7: Capa de Aplicación

## Construir la capa de aplicación

* DTO
	Objetos de transferencia de Datos

*  Interface
	Definición de los Métodos de aplicación

* Main
	* Implementación de las interfaces y gestión de cuestiones técnicas
	* Gestión de excepciones
	* Transformación de Objetos
	* Manejo de Transacciones


## Contrucción de la capa de Aplicación

Comenzaremos creando el proyecto

DarkShop.Ecommerce.Aplication.DTO

Cuando una entidad de negocio tiene 50 campos y solo quieres mostrar 10 en la WebAPI para ello se usa DTO, donde se colocan los atributos expuestos.

Renombraremos la clase Class1.cs a CustomerDTO.cs

CustomerDTO.cs
```CS
using System;

namespace DarkShop.Ecommerce.Aplication.DTO
{
    public class CustomerDTO
    {
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
}

```

Continuaremos con el proyecto mapper en la <a href="#CapaTransversal1">capa transversal</a>.

Regresando a la capa de aplicación desarrollaremos el proyecto <p id ="Interface">Interface</p>.

DarkShop.Ecommerce.Aplication.Interface

Le brindamos las referencias de DTO y common

Creamos la interfaz.

ICustomersApplication.cs
```CS
using System;
using System.Collections.Generic;
using System.Text;
using DarkShop.Ecommerce.Aplication.DTO;
using DarkShop.Ecommerce.Transversal.Common;
using System.Threading.Tasks;

namespace DarkShop.Ecommerce.Aplication.Interface
{
    public interface ICustomersApplication
    {
        #region Métodos Sincronos
        Response<bool> Insert(CustomerDTO customerDTO);
        Response<bool> Update(CustomerDTO customerDTO);
        Response<bool> Delete(string customerId);
        Response<CustomerDTO> Get(string customerId);
        Response<IEnumerable<CustomerDTO>> GetAll();
        #endregion

        #region Métodos Asincronos
        Task<Response<bool>> InsertAsync(CustomerDTO customerDTO);
        Task<Response<bool>> UpdateAsync(CustomerDTO customerDTO);
        Task<Response<bool>> DeleteAsync(string customerId);
        Task<Response<CustomerDTO>> GetAsync(string customerId);
        Task<Response<IEnumerable<CustomerDTO>>> GetAllAsync();
        #endregion
    }
}

```

Al terminar podremos construir Main, en donde se encontraran las implementaciones de la interfaz

DarkShop.Ecommerce.Application.Main

Ya que aqui es donde haremos los mapeos hay que instalar AutoMapper. Además bindarle las referencias requeridas ante DTO, application.Interface, Domain.Entity, Domain.Interface y common

CustomersApplication.cs
```CS
using System;
using AutoMapper;
using DarkShop.Ecommerce.Application.DTO;
using DarkShop.Ecommerce.Application.Interface;
using DarkShop.Ecommerce.Domain.Entity;
using DarkShop.Ecommerce.Domain.Interface;
using DarkShop.Ecommerce.Transversal.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DarkShop.Ecommerce.Application.Main
{
    public class CustomersApplication : ICustomersApplication
    {
        private readonly ICustomersDomain _customersDomain;
        private readonly IMapper _mapper;
        public CustomersApplication(ICustomersDomain customersDomain, IMapper mapper){
            _customersDomain = customersDomain;
            _mapper = mapper;
        }

        #region Métodos Sincronos
        public Response<bool> Insert(CustomerDTO customerDTO){
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customer>(customerDTO);
                response.Data = _customersDomain.Insert(customer);
                if (response.Data){
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        public Response<bool> Update(CustomerDTO customerDTO){
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customer>(customerDTO);
                response.Data = _customersDomain.Update(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        public Response<bool> Delete(string customerId){
            var response = new Response<bool>();
            try
            {
                response.Data = _customersDomain.Delete(customerId);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        public Response<CustomerDTO> Get(string customerId){
            var response = new Response<CustomerDTO>();
            try
            {
                var customer = _customersDomain.Get(customerId);
                response.Data = _mapper.Map<CustomerDTO>(customer);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        public Response<IEnumerable<CustomerDTO>> GetAll(){
            var response = new Response<IEnumerable<CustomerDTO>>();
            try
            {
                var customers = _customersDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<CustomerDTO>>(customers);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        #endregion

        #region Métodos Asincronos
        public async Task<Response<bool>> InsertAsync(CustomerDTO customerDTO){
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customer>(customerDTO);
                response.Data = await _customersDomain.InsertAsync(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        public async Task<Response<bool>> UpdateAsync(CustomerDTO customerDTO){
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customer>(customerDTO);
                response.Data = await _customersDomain.UpdateAsync(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        public async Task<Response<bool>> DeleteAsync(string customerId){
            var response = new Response<bool>();
            try
            {
                response.Data = await _customersDomain.DeleteAsync(customerId);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        public async Task<Response<CustomerDTO>> GetAsync(string customerId){
            var response = new Response<CustomerDTO>();
            try
            {
                var customer = await _customersDomain.GetAsync(customerId);
                response.Data = _mapper.Map<CustomerDTO>(customer);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        public async Task<Response<IEnumerable<CustomerDTO>>> GetAllAsync(){
            var response = new Response<IEnumerable<CustomerDTO>>();
            try
            {
                var customers = await _customersDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<CustomerDTO>>(customers);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        #endregion
    }
}

```

De aquí continuaremos con [la construcción de la capa de servicios](#Sección-8:-Capa-de-servicios)

## Construir la capa Transversal

* Common (Lista)
	Clases base, interfaces y funciones comunes

*  Mapper
	Mapeo de objetos (DTO/Entidades y viceversa)

* Logging
	Trazabilidad (stack trace)

## Construcción de la capa Transversal

Al realizar el CustomerDTO continuaremos con el proyecto<p id="CapaTransversal1">Mapper</p>

DarkShop.Ecommerce.Transversal.Mapper

Recordar que esto nos permitirá realizar el mapeo de forma automática entre los objetos DTO y las entidades de negocio, o viceversa, siempre y cuando el nombre y tipo de dato sea el mismo.

Intalemos AutoMapper mediante NuGet

Y renombraremos la class1 que se creo a MappingsProfile.cs.

No hay que olvidar hacer referencia a los proyectos que queremos mapear, en este caso DTO y entity

MappingsProfile.cs
```CS
using System;
using AutoMapper;
using DarkShop.Ecommerce.Domain.Entity;
using DarkShop.Ecommerce.Aplication.DTO;

namespace DarkShop.Ecommerce.Transversal.Mapper
{
    public class MappingsProfile : Profile
    {
        
        public MappingsProfile() {
            // Si ambas perfiles tienen los mismos atributos
            CreateMap<Customer, CustomerDTO>().ReverseMap();

            // Si no
            //CreateMap<Customer, CustomerDTO>().ReverseMap()
            //    .ForMember(destination => destination.CustomerId, source => source.MapFrom(src => src.CustomerId))
            //    .ForMember(destination => destination.CompanyName, source => source.MapFrom(src => src.CompanyName))
            //    .ForMember(destination => destination.ContactName, source => source.MapFrom(src => src.ContactName))
            //    .ForMember(destination => destination.ContactTitle, source => source.MapFrom(src => src.ContactTitle))
            //    .ForMember(destination => destination.Address, source => source.MapFrom(src => src.Address))
            //    .ForMember(destination => destination.City, source => source.MapFrom(src => src.City))
            //    .ForMember(destination => destination.Region, source => source.MapFrom(src => src.Region))
            //    .ForMember(destination => destination.PostalCode, source => source.MapFrom(src => src.PostalCode))
            //    .ForMember(destination => destination.Country, source => source.MapFrom(src => src.Country))
            //    .ForMember(destination => destination.Phone, source => source.MapFrom(src => src.Phone))
            //    .ForMember(destination => destination.Fax, source => source.MapFrom(src => src.Fax));
        }

    }
}

```

Ahora crearemos una entidad con nombre Response para nuestra WebAPI

Response.cs
```CS
namespace DarkShop.Ecommerce.Transversal.Common
{
    public class Response<T>
    {
        public T Data { get; set; }
        public bool IsSuccess { get; set; }
        public string  Message { get; set; }
    }
}

```


La entidad response es la que contendrá toda la información que van a exponer los diversos recursos de nuestra web api, por ejemplo en el atributo data, genérico, tendrá la información de los diversos métodos de la capa de dominio, es decir tendrá la respuesta del método insert, etc, el atributo IsSuccess, guardara el estado de la ejecución y en messge se almacenara el tipo de error o validación de una correcta ejecución.


Ahora continuremos con el proyecto <a href = "#Interface">Interface</a> en la capa de aplicación

# Sección 8: Capa de servicios

## Construir la capa de Servicios

* WebAPI
	* Crear recursos HTTP Restful
	* Crear las rutas de acceso (URI)
	* Inyección de dependencias
	* Configurar appsettings.json

</br>

* Principios de diseño
	* Las API REST se diseñan en función de los recursos (**cualquier tipo de objeto, datos o servicio a los que el cliente puede acceder**). 
	</br>
	* Un recurso tiene un identificador, que es una URI que identifica de forma única al recurso (http://darkshop.com/api/Customers/GetAIl).
	</br>
	* Los clientes interactúan con el servicio intercambiando representaciones de recursos (JSON como formato de intercambio).
	</br>	
	* Las API REST utilizan un modelo de solicitud sin estado. Las solicitudes HTTP deben ser independientes y pueden ocurrir en cualquier orden, por lo que no es factible mantener información de estado transitoria entre solicitudes.
	</br>

* Tipos de Retorno de acciones del controlador
	* Specific Type
		```CS
		public IEnumerable<Product> Get(){
			return _repository.GetProducts();_
		}
		```
	* IActionResult
		```CS
		public IActionResult GetById(){
			if (!_repository.TryGetProduct(id, out var product)) {
				return NotFound();
			}
			return Ok(product);
		}
		```
	* ActionResult\<T>
		```CS
		public ActionResult<IEnumerable<Product>> Get(){
			return _repository.GetProducts();_
		}
		```


PD: De momento usaremos las siguientes versiones la algunas librerias

automapper.extensions.Microsoft.DependencyIncetion 6.0.0

automaper 8.0.0

SqlClient 4.6.0

Dapper 1.50.5


## Construcción de la capa de Servicios <a id = "Sección-8:-Capa-de-servicios"> </a>

Ahora como vamos a desarrollar nuestro proyecto web API, en la capa de servicio, hay que seleccionar .NET Core y ASP.NET Core Web Application.

![[Pasted image 20231208162453.png]]


Le pondremos el siguiente nombre

DarkShop.Ecommerce.Services.WebApi

Y como target framework usaremos .NET Core 2.2

![[Pasted image 20231208162954.png]]

Y añadiremos un nuevo controlador, clic derecho en la carpeta controllers y añadir 

![[Pasted image 20231208163132.png]]


No aseguramos que este vacio

![[Pasted image 20231208163213.png]]

y le pondremos el nombre CustomersController

Empezaremos estableciendo la ruta de nuestro recurso, empezaremos con api, despues el nombre del controlador y al final el nombre de la acción, y con el decordor ApiController, indicamos que vamos a trabajar con recursos http.

Tambien hay que añadirle las referencias a los archivo que dependa, como; Application.DTO e interface.



CustomersController.cs
```CS
using DarkShop.Ecommerce.Application.DTO;
using DarkShop.Ecommerce.Application.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DarkShop.Ecommerce.Services.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomersController : Controller
    {
        private readonly ICustomersApplication _customersApplicaton;
        public CustomersController(ICustomersApplication customersApplication){
            _customersApplicaton = customersApplication;
        }

        #region Métodos Sincronos
        [HttpPost]
        public IActionResult Insert([FromBody] CustomerDTO customerDTO)
        {
            if (customerDTO == null)
            {
                return BadRequest();
            }
            var response = _customersApplicaton.Insert(customerDTO);
            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }

        [HttpPut]
        public IActionResult Update([FromBody] CustomerDTO customerDTO)
        {
            if (customerDTO == null)
            {
                return BadRequest();
            }
            var response = _customersApplicaton.Update(customerDTO);
            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }

        [HttpDelete("{customerId}")]
        public IActionResult Delete(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                return BadRequest();
            }
            var response = _customersApplicaton.Delete(customerId);
            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }

        [HttpGet("{customerId}")]
        public IActionResult Get(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                return BadRequest();
            }
            var response = _customersApplicaton.Get(customerId);
            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _customersApplicaton.GetAll();
            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }
        #endregion

        #region Métodos Asincronos
        [HttpPost]
        public async Task<IActionResult> InsertAsync([FromBody] CustomerDTO customerDTO)
        {
            if (customerDTO == null)
            {
                return BadRequest();
            }
            var response = await _customersApplicaton.InsertAsync(customerDTO);
            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] CustomerDTO customerDTO)
        {
            if (customerDTO == null)
            {
                return BadRequest();
            }
            var response = await _customersApplicaton.UpdateAsync(customerDTO);
            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }

        [HttpDelete("{customerId}")]
        public async Task<IActionResult> DeleteAsync(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                return BadRequest();
            }
            var response = await _customersApplicaton.DeleteAsync(customerId);
            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }

        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetAsync(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
            {
                return BadRequest();
            }
            var response = await _customersApplicaton.GetAsync(customerId);
            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _customersApplicaton.GetAllAsync();
            if (response.IsSuccess)
            {
                return Ok(response);
            }

            return BadRequest(response.Message);
        }
        #endregion

    }
}

```

A continuación agregaremos la cadena de conexión en el archivo appsetings.json

appsettings.json
```JSON
{
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "NorthwindConnection": "server=.; database=Northwind; Integrated Security = true;"
  }
}

```


Para más adelante editaremos la clase de inicio startup.cs

No hay que olvidar incorporar automapper en el proyecto y AutoMapper.Extensions.Microsoft.DependencyInjection.

Y añadirle referencia a todos los proyectos de la app.

Además hay que editar el método configuration ConfigureServices, extrayendo el comonente mappingprofile del proyecto transversal.mapper para incluir el mapeo de entidades de negocio a DTO.

startup.cs
```CS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using AutoMapper;
using DarkShop.Ecommerce.Transversal.Mapper;
using DarkShop.Ecommerce.Transversal.Common;
using DarkShop.Ecommerce.Infrastructure.Data;
using DarkShop.Ecommerce.Infrastructure.Repository;
using DarkShop.Ecommerce.Infrastructure.Interface;
using DarkShop.Ecommerce.Domain.Interface;
using DarkShop.Ecommerce.Domain.Core;
using DarkShop.Ecommerce.Application.Interface;
using DarkShop.Ecommerce.Application.Main;

// agregarlo dentro de la class startup

public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(x => x.AddProfile(new MappingsProfile()));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options => { options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver(); });

            services.AddSingleton<IConfiguration>(Configuration);
            services.AddSingleton<IConnectionFactory, ConnectionFactory>();
            services.AddScoped<ICustomersApplication, CustomersApplication>();
            services.AddScoped<ICustomersDomain, CustomersDomain>();
            services.AddScoped<ICustomersRepository, CustomersRepository>();
        }
```





Y listo, para poder validar que nuestra web api funciona correctamente haremos lo siguiente. 

Le daremos clic derecho y seleccionaremos el proyecto de web api como inicio

![[Pasted image 20231211171907.png]]

de ahi le daremos la siguiente liga

http://localhost:49327/api/Customers/Get/ANTON

Y si todo funciona correctamente tendremos el siguiente resultado

![[Pasted image 20231211172038.png]]

Como podemos apreciar fue una consulta exitosa.

Puedes validar si prefieres uno por uno los métodos mediante postman.



## Integración Web API con Swagger

### Especificación Open API y Swagger

⬛ ¿Qué es Open API?

**La especificación Open API** es un formato de descripción de API para REST. Un archivo Open API permite describir una API de manera completa, incluyendo:

* Endpoints disponibles (/api/Customers) y operaciones en cada Endpoint (GET/api/Customers/GetAll,POST /api/Customers/Insert)

* Parametros de entrada y salida para cada operación

* Métodos de autenticación

* Información de contacto, licencia, términos de uso y otra información.

⬛ ¿Qué es Swagger?

**Swagger** es un conjunto de herramientas de código abierto creadas alrededor de la especificación Open API que ayuda a diseñar, construir, documentar y consumir **API REST**. Las principales herramientas de Swagger incluyen:

• Swagger Editor: Editor basado en navegador donde se puede escribir especificaciones de Open API.

* Swagger UI: Representa las especificaciones de Open API como la, documentación de API de manera interactiva.

• Swagger Codegen: Genera Stubs de servidor y librerías de lado cliente a partir de la especificación de Open APL

⬛ ¿Por qué usar Open API?

La capacidad de las API para describir su propia estructura es la raíz de todo lo genial en **Open API**. Una vez escrito, una especificación Open API y herramientas Swagger pueden impulsar su desarrollo de API de varias maneras:

• **Swagger Codegen** genera código auxiliar de servidor para la API. Lo único que queda es implementar la lógica del servidor, ¡y su API está lista para funcionar!

• **Swagger Codegen** genera librerías cliente para la API en más de 4o lenguajes.

• Se integra con otras herramientas por ejemplo con SOAP Ul para crear pruebas
automatizadas.

⬛ Componentes Swashbuckle

**Swashbuckle.AspNetCore** permite agregar Swagger de manera
sencilla a los proyectos Web API, consta de 3 componentes:

* **Swashbuckle.AspNetCore.Swagger**: Modelo de objeto Swagger y middleware para exponer los objetos SwaggerDocument como Endpoints JSON.
 
* **Swashbuckle.AspNetCore.SwaggerGen**: Generador Swagger que construye objetos SwaggerDocument directamente desde sus rutas, controladores y modelos. Genera Swagger JSON.

* **Swashbuckle.AspNetCore.SwaggerUl**: Versión incrustada de la herramienta Swagger Ul. Interpreta Swagger JSON para crear una experiencia ruta y personalizable para describir la funcionalidad de la API web.

⬛ Intgración Web API con Swagger

Tendremos un resultado similar a este






Para comenzar vamos a installar los en nuestro proyecto web api, en este caso usaremos la version 4.0.1.

Despues de tenerlo instalado vamos a editar el archivo.

Startup.cs
```CS
using Swashbuckle.AspNetCore.Swagger;
using System.Reflection;
using System.IO;


// justo debajo de lo ultimo dentro de ConfigureServices
//Register the swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "DarkShop Technology Services API Market",
                    Description = "A simple example ASP.NET Core Web API",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "Alex Espejo",
                        Email = "alex.espejo@gmail.com",
                        Url = "https://darkshop.com"
                    },
                    License = new License
                    {
                        Name = "Use under LICK",
                        Url = "https://example.com/license"
                    }
                });
                //Set the comments path for the Swagger JSON and UI
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });


// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Enable midleware to serve generated Swagger as a JSON endpoint
            app.UseSwagger();

            //Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.)
            // Specigying the Swagger JSON endpoint
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API Ecomerce V1");
            });

            app.UseMvc();
        }
```

Como podemos apreciar mediante una función lambda creamos el documento swagger.

Swagger para construir la documentación, se basa en la documentación que genera el proyecto Web API en momento de la compilación.

Para ello hay que darle clic derecho al proyecto, y darle en propedades.

![[Pasted image 20231212101004.png]]



De ahi nos iremos a Build/Compilación y marcaremos la opción de XML document File

![[Pasted image 20231212101103.png]]

Al terminar borraremos el controlador por defecto llamado ValuesController.cs


De ahi regresaremos a la s propiedades y seleccionaremos depurar y a un costado de la marca Launch browser colocar api/Customers/GetAll

![[Pasted image 20231212102318.png]]

Ahora ejecutaremos el proyecto y veremos que realiza la consulta previa de forma predeterminada.

![[Pasted image 20231212102517.png]]


Ahora si colocamos la uri raiz con swagger

localhost:49327/api/swagger

![[Pasted image 20231212103351.png]]

Como podemos apreciar ya tenemos documentada los métodos de nuestra Web API

y si te gustaría editar y/o agregarle alguna descripción en especifico a cada método puede ir a [swagger editor](https://editor.swagger.io/)

![[Pasted image 20231212104118.png]]


## Habilitar Solicitudes de Origen Cruzado (CORS)

### Contexto

La seguridad del navegador impide que una página web realice solicitudes a un dominio **diferente**. Esta restricción se llama
**política del mismo origen**.

La **política del mismo origen** impide que un sitio malicioso lea datos confidenciales de otro sitio.

En muchos casos, es posible que sea necesario permitir que otros sitios realicen solicitudes de origen cruzado a su aplicación (Ejemplo: Cuando se exponen APIs).

### Intercambios de recursos de Orígenes Cruzados (CORS)

⬛ CORS
	✔ **CORS** es un estándar W3C que permite a un servidor flexibilizar la política del mismo origen.
	✔ **CORS** permite que un servidor habilite explícitamente algunas solicitudes de origen cruzado mientras rechaza otras.
	✔ **CORS** es más seguro y más flexible que las técnicas anteriores, como **JSONP**.
	✔ **CORS** no es una característica de seguridad, **CORS** flexibiliza la seguridad. Una API no es más segura al permitir CORS.

⬛ Política Mismo Origen
	✔ Dos URL tienen el mismo origen si tienen esquemas, hosts y puertos idénticos.
		https://example.com/foo.html
		https://example.com/bar.html
	✔ URLs que tienen orígenes diferentes
		https://example.net - Dominio diferente
		https://example.com/foo.html - Subdominio diferente
		http://example.com/foo.html - Esquema diferente
		https://example.com:9000/foo.html - puerto diferente


### Opciones de políticas de CORS

**Establecer Orígenes Permitidos**

* **AllowAnyOrigin**: Permite solicitudes CORS desde todos los orígenes con cualquier esquema (http o https).

* **AllowAnyOrigin** es inseguro porque cualquier sitio web puede realizar solicitudes de origen cruzado a la aplicación.

* **WithOrigins**: Permite solicitudes CORS desde orígenes específicos.


**Establecer los Métodos Permitidos**

• **AllowAnyMethod**: Permite cualquier método HTTP(GET, POST, etc.)
• **WithMethods**: Permite especificar método HTTP.

**Establecer Encabezados de Solicitud Permitidos**

• **AllowAnyHeader**: Permite todos los encabezados en la solicitud.
• **WithHeaders**: Permite que se envíen encabezados específicos en una solicitud CORS.


**Establecer Encabezados de Respuesta Expuesto**

• Los encabezados de respuesta que están disponibles de forma predeterminada son (Cache-Control, Content-Language, Content-Type, Expires, Lost-Modified, Pragma).

* **WithExposedHeaders**: Permite que otros encabezados esten disponibles  para la aplicación (por ejemplo: "x-customer-header").

**Credenciales en Solicitudes de Origen Cruzado**

* De forma predeterminada, el navegador no envía credenciales con una solicitud de origen cruzado.

* **AllowCredentials**: Permite credenciales de origen cruzado.

* NOTA: Permitir credenciales de origen cruzado es un riesgo de seguridad.

### Implementar CORS en Web API

Agregaremos lo siguiente en nuestro archivo

```CS
"Config": {
    "OriginCors": "http://localhost:60468"
  }
```

después añadiremos lo siguiente en.

Startup.cs
```CS
readonly string myPolicy = "policyApiEcommerce";

// dentro de configure services
services.AddCors(options => options.AddPolicy(myPolicy, builder => builder.WithOrigins(Configuration["Config:OriginCors"])
                                                                                        .AllowAnyHeader()
                                                                                        .AllowAnyMethod()
            ));

// dentro de configure y antes de UseMvc
app.UseCors(myPolicy);
```


## Definición de JSON Web Token (JWT)

### ¿Que es un Token?

Un **token** es una cadena alfanumérica con caracteres aparentemente aleatorios, como el siguiente:


eyJhbGciOiJIUz/1NilsInR5cCI6|kpXVCJ9.eyJzdWIiOil×MjMONTY300kwliwibmFtZS|6|kpvaG4gRG9|liwiYW
RtaW4iOnRydWV9.TJVA950rM7E2cBab30RMHrHDcEfxjoYZgeFONFh7HgQ

o como el siguiente 123456


Estas cadenas de texto, aparentemente no tienen un significado, sin embargo, tiene un significado real para el servidor o institución que lo emitió y además pueden entender y así, validar al usuario que intenta acceder a la información. Un token puede tener datos adicionales.

### ¿Que son los JSOn Web Tokens (JWT)?

Podemos decir que los JWT son un tipo de token el cual engloba una estructura, la cual puede ser desencriptada por el servidor y de esta forma, autenticarnos como usuario en la aplicación.


**Estructura de un JWT** (3 secciones separadas por un punto)
eyJhbGciOiJIUz/1NilsInR5cC|6|kpXVCJ9.eyJzdWIiOil×MjMONTY30DkwliwibmFtZSi6|kpvaG4gRG9|liwiYWRtaW4iOnRydWV9.TJVA950rM7E2cBab30RMHrHDcEfxjoYZgeFONFh7HgQ

HEADER: Contiene el tipo de token y algoritmo de encriptamiento.

PAYLOAD: Contiene los datos que identifican al usuario (id, nombre , etc.).

FIRMA: Es la firma digital, la cual se genera con las secciones anteriores y sirve para validar que el contenido no haya sido alterado. (header y el payload en base64 y despues encriptado)


### Como se utiliza los JWT

* Los **JWT** se utilizan para autenticar a los usuarios, para ello, el usuario requiere de un login tradicional como es el usuario y password.

* Una vez, que el sistema de Backend valida que el usuario y contraseña son correctos, este retorna un **token** al usuario.

* El **token** lo deberá guardar el cliente, pues de aquí en adelante, todas las peticiones que realice al servidor, deberá llevar el token.

Nota: El **token** es por lo general almacenado en Cookies o en el LocalStorage del navegador, y cuando se requiere enviar un request al servidor, se recupere y se envía como header.

### Ciclo de Vida de un JWT

1. El usuario requiere de una autenticación tradicional con el servidor, es decir usuario y password.
2. El servidor validará que los datos introducidos sean correctos y generará un **Token**.
3. El servidor enviará el token al usuario y este lo tendrá que almacenar de cualquier forma.
4. Una vez con el **token**, el usuario realiza una petición al servidor, enviando en el header el token.
5. El servidor validará que el **token** sea correcto, desencriptándolo mediante la misma llave que utilizo para encriptarlo.
6. Si el **token** es correcto, entonces el servidor retornará los datos solicitados.


## Habilitar seguridad en Web API utilizando JWT - Parte 1

### Implementar JWT en WebAPI

Para empezar vamos a necesitar en nuestra base de datos una tabla de ususarios.

Users.sql
```SQL
SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

CREATE TABLE [dbo].[Users](

    [UserId] [int] NOT NULL,

    [FirstName] [varchar](50) NOT NULL,

    [LastName] [varchar](50) NOT NULL,

    [UserName] [varchar](50) NOT NULL,

    [Password] [varchar](50) NOT NULL,

CONSTRAINT [PK_Users] PRIMARY KEY NONCLUSTERED

(

    [UserId] ASC

) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

) ON [PRIMARY]

GO
```

Agregaremos un usuario.



Después realizaremos un procedimiento almacenado que le pasaremos el usuario y password para que lo valide y nos regrese la información del usuario.

UsersGetByUserAndPassword.sql
```SQL
SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO

  

CREATE PROCEDURE [dbo].[UsersGetByUserAndPassword]

(

    @UserName VARCHAR(50),

    @Password VARCHAR(50)

)

AS

BEGIN

  

    SELECT UserID, FirstName, LastName, UserName, NULL AS PASSWORD

    FROM Users

    WHERE UserName = @UserName AND Password = @Password

  

END

GO
```

Para continuar crearemos la entidad User en la carpeta domain.Entity

User.cs
```CS
using System;
using System.Collections.Generic;
using System.Text;

namespace DarkShop.Ecommerce.Domain.Entity
{
    class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}

```

Después desarrollaremos una interface en la capa de infraestructura

IUserRepository.cs
```CS
using System;
using System.Collections.Generic;
using System.Text;
using DarkShop.Ecommerce.Domain.Entity;

namespace DarkShop.Ecommerce.Infrastructure.Interface
{
    public interface IUserRepository
    {
        User Authenticate(string username, string password);
    }
}

```

Ahora crearemos en Repository

UserRepository.cs
```CS
using Dapper;
using DarkShop.Ecommerce.Domain.Entity;
using DarkShop.Ecommerce.Infrastructure.Interface;
using DarkShop.Ecommerce.Transversal.Common;

namespace DarkShop.Ecommerce.Infrastructure.Repository
{
    class UserRepository : IUserRepository
    {

        private readonly IConnectionFactory _connectionFactory;

        public UserRepository(IConnectionFactory connectionFactory) {
            _connectionFactory = connectionFactory;
        }

        public User Authenticate(string UserName, string password) {
            using (var connection = _connectionFactory.GetConnection) {
                var query = "UsersGetByUserAndPassword";
                var parameters = new DynamicParameters();
                parameters.Add("UserName", UserName);
                parameters.Add("Password", password);

                var user = connection.QuerySingle<User>(query, param: parameters, commandType: System.Data.CommandType.StoredProcedure);
                return user;
            }
        }
    }
}

```


Después realizaremos otra interfaz en la capa Domain

IUserDomain.cs
```CS
using DarkShop.Ecommerce.Domain.Entity;

namespace DarkShop.Ecommerce.Domain.Interface
{
    public interface IUserDomain
    {
        User Authenticate(string username, string password);
    }
}

```

Ahora en Core agregaremos

UserDomain.cs
```CS
using System;
using System.Collections.Generic;
using System.Text;
using DarkShop.Ecommerce.Domain.Entity;
using DarkShop.Ecommerce.Domain.Interface;
using DarkShop.Ecommerce.Infrastructure.Interface;

namespace DarkShop.Ecommerce.Domain.Core
{
    public class UserDomain : IUserDomain
    {
        private readonly IUserRepository _userRepository;

        public UserDomain(IUserRepository userRepository) {
            _userRepository = userRepository;
        }

        public User Authenticate(string username, string password) {
            return _userRepository.Authenticate(username, password);
        }
    }
}

```

Continuaremos con la capa de aplicación, creando un nuevo dto.

UserDTO.cs
```CS
namespace DarkShop.Ecommerce.Application.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}

```


desarrollaremos su interfaz

IUserApplication.cs
```CS
using DarkShop.Ecommerce.Application.DTO;
using DarkShop.Ecommerce.Transversal.Common;

namespace DarkShop.Ecommerce.Application.Interface
{
    public interface IUserApplication
    {
        Response<UserDTO> Authenticate(string username, string password);
    }
}

```

Ahora implementaremos dicha interfaz.

UserApplication.cs
```CS
using DarkShop.Ecommerce.Application.Interface;
using DarkShop.Ecommerce.Application.DTO;
using DarkShop.Ecommerce.Domain.Interface;
using DarkShop.Ecommerce.Transversal.Common;
using AutoMapper;
using System;

namespace DarkShop.Ecommerce.Application.Main
{
    class UserApplication : IUserApplication
    {

        private readonly IUserDomain _userDomain;
        private readonly IMapper _mapper;

        public UserApplication(IUserDomain userDomain, IMapper IMapper)
        {
            _userDomain = userDomain;
            _mapper = IMapper;
        }

        public Response<UserDTO> Authenticate(string username, string password) {
            var response = new Response<UserDTO>();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                response.Message = "Parámetros no pueden ser vacios.";
                return response;
            }
            try
            {
                var user = _userDomain.Authenticate(username, password);
                response.Data = _mapper.Map<UserDTO>(user);
                response.IsSuccess = true;
                response.Message = "Autenticación exitosa!!!";
            }
            catch (InvalidOperationException) {
                response.IsSuccess = true;
                response.Message = "Usuario no existe";
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

    }
}

```

Con esto solo faltaría modificar la capa de servicio

empezaremos realizando un cambio en:

appsettings.json
```JSON
"Config": {
    "OriginCors": "http://localhost:60468",
    "Secret": "+_)(*&^%$#@!)(JJGGG$$##+____*",
    "Issuer": "DarkShop.com",
    "Audience":  "DarkShop.com"
  }
```


añadiremo una nueva carpeta llamada helpers dentro del proyecto Web API y pondremos una clase llamada:

AppSettings.cs
```CS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkShop.Ecommerce.Services.WebApi.Helpers
{
    public class AppSettings
    {
        public string OriginCors { get; set; }
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
    }
}

```

A partir de ahi crearemos un nuevo controlador:

UserController.cs
```CS
using DarkShop.Ecommerce.Application.DTO;
using DarkShop.Ecommerce.Application.Interface;
using DarkShop.Ecommerce.Services.WebApi.Helpers;
using DarkShop.Ecommerce.Transversal.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DarkShop.Ecommerce.Services.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserApplication _userApplication;
        private readonly AppSettings _appSettings;

        public UserController(IUserApplication userApplication, IOptions<AppSettings> appSettings) {
            _userApplication = userApplication;
            _appSettings = appSettings.Value;
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Authenticate([FromBody] UserDTO userDTO) {
            var response = _userApplication.Authenticate(userDTO.UserName, userDTO.Password);
            if (response.IsSuccess) {
                if (response.Data != null)
                {
                    response.Data.Token = BuildToken(response);
                    return Ok(response);
                }
                else {
                    return NotFound(response.Message);
                }
            }
            return BadRequest(response.Message);
        }

        private string BuildToken(Response<UserDTO> userDTO) {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Name, userDTO.Data.UserId.ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = _appSettings.Issuer,
                Audience = _appSettings.Audience
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return tokenString;
        }

    }
}

```


y para finalizar hay que avisarle a startup.cs que se le incorporara un instrumento de seguridad

Startup.cs
```CS

//Dentro de IConfiguration
var appSettingsSection = Configuration.GetSection("Config");
            services.Configure<AppSettings>(appSettingsSection);

//Añdir las dependencias
services.AddScoped<IUserApplication, UserApplication>();
            services.AddScoped<IUserDomain, UserDomain>();
            services.AddScoped<IUserRepository, UserRepository>();

//Debajo de UseCors()

app.UseAuthentication();
```



Vamos a revisar su funcionamiento

Si nos vamos a swagger veremos que ya estan incorporadas

![[Pasted image 20231213180235.png]]


y al intentar probar la nueva funcion authenticate

![[Pasted image 20231213180547.png]]

podemos apreciar su correcto funcionamiento y el token, ya con esto podríamos utilizarlo para llamar a los siguientes métodos, vamos a realizar la validación del token

## Habilitar Seguridad en Web API utilizando JSOn Web Token (JWT) parte 2

### Implementar JWT en WEB API

⬛Crear API de Autenticación y generación de Token✔
⬛ Crear validador de Token en la Web API


### Implentación

Comenzaremos modificando el nivel de autorización  nivel de clase en 

CustomersController.cs
```CS
	[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CustomersController : Controller
```

Continuando en

Startup.cs
```CS
//debajo de la declarasción de appSettingsSection y su servicio

//configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();

// Debajo de los servicios

var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            var Issuer = appSettings.Issuer;
            var Audience = appSettings.Audience;
services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x => {
                x.Events = new JwtBearerEvents
                {
                    OnTokenValidated = context =>
                    {
                        var userId = int.Parse(context.Principal.Identity.Name);
                        return Task.CompletedTask;
                    },

                    OnAuthenticationFailed = context =>
                    {
                        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                        {
                            context.Response.Headers.Add("Token-Expired", "true");
                        }
                        return Task.CompletedTask;
                    }
                };
                x.RequireHttpsMetadata = false;
                x.SaveToken = false;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidIssuer = Issuer,
                    ValidateAudience = true,
                    ValidAudience = Audience,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
            });

//Ahora al final del metodo swagger
c.AddSecurityDefinition("Authorization", new ApiKeyScheme{
                    Description = "Authorization by API Key",
                    In = "header",
                    Type = "apikey",
                    Name = "Authorization"
                });

                c.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>>
                {
                    {"Authorization", new string[0]}
                });

```

Ahora vayamos a probar la validación del token

Si todo salio bien deberiamos de tener el siguiente error

![[Pasted image 20231213184410.png]]

indicando que necesitamos tener un token para poder realizar la petición.

Para ello iremos a nuestra documentación en swagger realizaremos una petición al metodo authenticate.


![[Pasted image 20231213184732.png]]


Copiaremos el token y le daremos clic al nuevo boton en la esquina superior derecha 

![[Pasted image 20231213184900.png]]

de ahi nos solicitara ponerle el token, antes que nada poner Bearer ya que es un token por usuario

![[Pasted image 20231213190241.png]]

y si intentamos  ejecutar algún método podremos ver que ya nos responde

![[Pasted image 20231213190344.png]]


# Section 9: Capa Transversal

## Construcción de la capa transversal

* Common
	Clases base, interfaces y funciones comunes.

* Mapper
	Mapeo de objetos (DTO/Entidades & viceversa)

* Logging
	Trazabiidad (stack trace)

## Construyendo la capa transversal

Empezaremos agregando una nueva interfaz de el proyecto transversal.common

IAppLogger.cs
```CS
namespace DarkShop.Ecommerce.Transversal.Common
{
    public interface IAppLogger<T>
    {
        void LogInformation(string message, params object[] args);
        void LogWarning(string message, params object[] args);
        void LogError(string message, params object[] args);
    }
}

```

A continuación crearemos el proyecto Logging para poder realizar la implementación de la interfaz, no olvides realizar la referencia al proyecto .common.

A razón de que en este proyecto se gestionara  la trazabilidad de las excepciones también es necesario descargar Microsoft.Extensions.Logging, en este caso instalare la version 2.2.

A continuación nos iremos a 

CustomersApplication.cs
```CS
using System;
using AutoMapper;
using DarkShop.Ecommerce.Application.DTO;
using DarkShop.Ecommerce.Application.Interface;
using DarkShop.Ecommerce.Domain.Entity;
using DarkShop.Ecommerce.Domain.Interface;
using DarkShop.Ecommerce.Transversal.Common;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DarkShop.Ecommerce.Application.Main
{
    public class CustomersApplication : ICustomersApplication
    {
        private readonly ICustomersDomain _customersDomain;
        private readonly IMapper _mapper;
        private readonly IAppLogger<CustomersApplication> _logger;
        public CustomersApplication(ICustomersDomain customersDomain, IMapper mapper, IAppLogger<CustomersApplication> logger)
        {
            _customersDomain = customersDomain;
            _mapper = mapper;
            _logger = logger;
        }

        #region Métodos Síncronos

        public Response<bool> Insert(CustomersDto customersDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customersDto);
                response.Data = _customersDomain.Insert(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<bool> Update(CustomersDto customersDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customersDto);
                response.Data = _customersDomain.Update(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<bool> Delete(string customerId)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = _customersDomain.Delete(customerId);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<CustomersDto> Get(string customerId)
        {
            var response = new Response<CustomersDto>();
            try
            {
                var customer = _customersDomain.Get(customerId);
                response.Data = _mapper.Map<CustomersDto>(customer);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<IEnumerable<CustomersDto>> GetAll()
        {
            var response = new Response<IEnumerable<CustomersDto>>();
            try
            {
                var customers = _customersDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<CustomersDto>>(customers);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                    _logger.LogInformation("Consulta Exitosa!!!");
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                _logger.LogError(e.Message);
            }
            return response;
        }

        #endregion

        #region Métodos Asíncronos
        public async Task<Response<bool>> InsertAsync(CustomersDto customersDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customersDto);
                response.Data = await _customersDomain.InsertAsync(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro Exitoso!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        public async Task<Response<bool>> UpdateAsync(CustomersDto customersDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customersDto);
                response.Data = await _customersDomain.UpdateAsync(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public async Task<Response<bool>> DeleteAsync(string customerId)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _customersDomain.DeleteAsync(customerId);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public async Task<Response<CustomersDto>> GetAsync(string customerId)
        {
            var response = new Response<CustomersDto>();
            try
            {
                var customer = await _customersDomain.GetAsync(customerId);
                response.Data = _mapper.Map<CustomersDto>(customer);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        public async Task<Response<IEnumerable<CustomersDto>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<CustomersDto>>();
            try
            {
                var customers = await _customersDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<CustomersDto>>(customers);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta Exitosa!!!";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
        #endregion
    }
}

```

y como podemos ver solo agregamos el logger en el construcotr y en el método getAll síncrono

Después nos iremos a 


Startup.cs
```CS
//Solo agregamos lo siguiente en las dependencias
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
```

No hay que olvidar de colocarle la dependencia de Logging

Con esto puedes realizar una prueba 

Para validar que esto funciono, deberemos que validar que al ejecutar get all tengamos el siguiente resultado en la terminal

![[Pasted image 20231219155251.png]]

Como se indica previamente ahí esta Consulta exitosa

# Section 10: Actualización a .NET Core 3.0

## Prerrequisitos

* Visual Studio .NET 2019 Build 16.3.4 o superior
* Framework .NET Core 3.0
	* .NET Core SDK
	* .NET Core Runtime

## Actualización a .NET Core 3.0

* Actualizar la versión de la plataforma del proyecto Web API a .NET Core 3.0
* Descargar y actualizar librerías desde NuGet
* Actualizar el código para la inyección de dependencias de la librería AutoMapper
* Actualiza la clase program con las nuevas interfaces de .NET Core 3.0
* Actualizar la clase Startup


Empezando con actualizar nuestro proyecto web api, le damos clic derecho y le damos a propiedades y cambiaremos a .NET Core 3.0

![[Pasted image 20231219161905.png]]



Después vamos a descargar las librerias de JWT en NuGet

intalaremos 

Microsoft.IdentityModel.Tokens 5.6.0
System.IdentityModel.Tokens.Jwt 5.6.0
Microsoft.AspNetCore.Authentication.JwtBearer 3.0.0


AHora vamos a actualizar las libreías o dependencias

AutoMapper de 8.0.0 -> 9.0.0
Microsoft.Extensions.Logging 2.2.0 -> 3.0.0
Microsoft.Extensions.Configuration 2.0.0 -> 3.0.0
System.Data.SqlClient 4.6.0 -> 4.7.0
Dapper 1.50.5 -> 2.0.30
AutoMapper.Extensions.Microsoft.DependencyInjection 6.0.0 -> 7.0.0
Microsoft.VisualStudio.Web.CodeGeneration.Design 2.2.0 -> 3.0.0


como cuarto cambio hay que quitar la dependencia de Newtonsoft.json de nuestro código, en NET core 3.0, el tema del serializado y desserializado, lo hace de forma nativa .
En mi caso eliminaremos la linea 57.


También se necesita actualizar la ultima versión de compatibilidad de ASP .NET Core MVC 3.0 para la aplicación

Vamos a remplazar la porción de código para agregar los perfiles en auto mapper, la linea 49 


y borrar el metodo sumvc en configure linea 184

Startup.cs
```CS
var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingsProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddCors(options => options.AddPolicy(myPolicy, builder => builder.WithOrigins(Configuration["Config:OriginCors"])
                                                                                        .AllowAnyHeader()
                                                                                        .AllowAnyMethod()
            ));
```

Tambien le añadiremos a 

MappingProfiles.cs
```CS
CreateMap<User, UserDTO>().ReverseMap();
```


Y dentro de 

Program.cs
```CS
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;

namespace DarkShop.Ecommerce.Services.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        //2.2
        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //        .UseStartup<Startup>();
        //3.0
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

```

ahora regresaremos a agregar en

Startup.cs
```CS
public void Configure(IApplicationBuilder app, IHostingEnvironment env) //de IHostingEnvironment a IWebHostEnvironment


app.UseRouting();

//ariba de appp.UseSwagger();

// abajo de app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints => {
	endpoints.MapControllers();
});
```



## Actualización de Swagger al Estandar OpenAPI

### ¿Qué es OpenAPI?

* **OpenAPI** es un estándar para definir contratos de API
* El objetivo de **OpenAPI** es construir un estándar en la definición de las API para humanos, pero haciendo hincapié en la interfaz  para maquinas, facilitando que se configuren e integren de forma autónoma.


### Actualizar swagger al estándar OpenAPI

* Actualizar los endpoints de los controladores
* Migrar los componentes de swagger al estándar OpenAPI


actualizar los componentes swagger del proyecto web api

Swashbuckle.AspNetCore.SwaggerGen 4.0.1 -> 5.0.0-rc4
Swashbuckle.AspNetCore.SwaggerUI 4.0.1 -> 5.0.0-rc4
Swashbuckle.AspNetCore.Swagger 4.0.1 -> 5.0.0-rc4

ahora realizaremos cambios dentro de 

UserController.cs
```CS
[Route("api/[controller]")] // eliminar la acción de la ruta porque en cada metodo ya se especifico


```

tambien hacer lo mismo en CustomerController.cs

además mdificar

Startup.cs
```CS
using Microsoft.OpenApi.Models;

services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "DarkShop Technology Services API Market",
                    Description = "A simple example ASP.NET Core Web API",
                    TermsOfService = new Uri("https://DarkShop.com/rerms"),
                    Contact = new OpenApiContact
                    {
                        Name = "LeoRZLanda",
                        Email = "LeoRZLanda@gmail.com",
                        Url = new Uri("https://DarkShop.com/contact")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICK",
                        Url = new Uri("https://DarkShop.com/license")
                    }
                });
                //Set the comments path for the Swagger JSON and UI
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme{
                    Description = "Authorization by API Key",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Name = "Authorization"
                });

                //2.2
                //c.AddSecurityRequirement(new Dictionary<string, IEnumerable<string>>
                //{
                //    {"Authorization", new string[0]}
                //});

                //3.0
                c.AddSecurityRequirement(new OpenApiSecurityRequirement{
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] { }
                    }
                });
            });
```

# Sección 11: Métricas de Calidad de Código

## Métricas de Calidad de Código con Visual Studio .NET

* Las métricas de código son un conjunto de medidas de software que brindan a los desarrolladores una mejor comprensión del código que están desarrollando.

• Al aprovechar las métricas de código, los desarrolladores pueden comprender qué clases y/o métodos deben refactorizar o realizar pruebas más a fondo.

* Los equipos de desarrollo pueden identificar riesgos potenciales, comprender el estado actual de un proyecto y realizar un seguimiento del progreso durante el desarrollo de software.

* Visual Studio .NET 2019 o superior calcula las siguientes métricas:
	* Índice de mantenibilidad del código
	* Complejidad ciclomatica
	* Acoplamiento de clases
	* Profundidad de herencia
	* Líneas de código

* Métricas

	* Índice de mantenibilidad: Calcula un valor de índice entre 0 y 100, lo cual representa la relativa facilidad de mantener el código. Un valor alto significa una mejor  mantenibilidad del código.

		* Umbrales
			* 0-9 = rojo
			* 10-19 = amarillo
			* 20-100 = verde

	* Complejidad Ciclomática: Mide la complejidad estructural del código. Se obtiene calculando el número de diferentes rutas de código en el flujo del programa. Un programa que tiene un flujo de control complejo requiere más pruebas para lograr una buena cobertura de código y es menos mantenible.

		*  Umbrales
			* Valores Bajos < 50

	* Profundidad de la Herencia: Indica la cantidad de clases diferentes que se heredan entre sí, hasta la clase base. La profundidad de herencia es similar al acoplamiento de clases en que un cambio en una clase base puede afectar a cualquiera de sus clases heredadas. Cuanto mayor sea este número, mayor será la herencia y mayor será la posibilidad de que las modificaciones de la clase base produzcan un cambio radical.

		* Umbrales
			* Valores Bajos < 40

	* Acoplamiento de Clases: Mide el acoplamiento a clases únicas a través de parámetros, variables locales, tipos de retorno, llamadas a métodos, etc. Un buen diseño de software dicta que los tipos y métodos deben tener una alta cohesión y un bajo acoplamiento. El alto acoplamiento indica un diseño que es difícil de reutilizar y mantener debido a sus muchas interdependencias con otros tipos.

		* Umbrales
			* Valores Bajos < 40

	* Líneas de Código: Indica el número exacto de líneas de código fuente que están presentes en su archivo fuente, incluidas las líneas en blanco. Esta métrica está disponible a partir de Visual Studio 2019 versión 16.4 y Microsoft.CodeAnalysis.Metrics (2.9.5).

		* Umbrales
			* 30 líneas max por método

## Demo

Hay dos formas de analizar las métricas de código uno es a nivel de la solución y otro a nivel de cada proyecto.

Recomendación: Realizarlo de forma global

Dando clic derecho a la solución y seleccionar análisis y limpieza de código para después seleccionar la opción de calcular métricas de código

![[Pasted image 20231220121826.png]]

Y tendríamos un resultado similar al próximo

![[Pasted image 20231220122023.png]]



# Sección 12: Despliegue en Contenedores Docker

## Construcción de la Imagen Docker

* Construir la imagen Docker a partir del archivo Dockerfile


Antes que nada hay que asegurarnos tener instalado [Docker](https://docs.docker.com/desktop/install/windows-install/) y una imagen de .NET Core 3.0, descargaremos en especifico el .NET Core sdk y el ASP.NET Core Runetime.

Lo haremos con los siguientes comandos

.NET Core SDK
```CLI
docker pull mcr.microsoft.com/dotnet/core/sdk:3.0
```

ASP.NET Core Runetime
```CLI
docker pull mcr.microsoft.com/dotnet/core/sdk:3.0
```


De ahi nos iremos a visual studio, le damos clic derecho a nuestro proyecto web API, para darle a supporte docker

![[Pasted image 20231220130403.png]]

Seleccionamos como SO destino linux

![[Pasted image 20231220130445.png]]


Seleccionamos a ISS Express para que la imagen no se genere

![[Pasted image 20231220130550.png]]

y como podemos apreciar en la carpeta del proyecto se creo un archivo dockerfile

![[Pasted image 20231220130630.png]]


Borraremos lo que tienes para realizarla de forma manual

Dockerfile
```DOCKERFILE
FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build-env
WORKDIR /src
COPY . .
WORKDIR /src/DarkShop.Ecommerce.Services.WebApi
Run dotnet restore
Run dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0
WORKDIR /app
COPY --from=build-env /src/DarkShop.Ecommerce.Services.WebApi/out ./

ENTRYPOINT ["dotnet","DarkShop.Ecommerce.Services.WebApi.dll"]
```

Cambiamos a release

![[Pasted image 20231220131655.png]]

ir a las propiedades del proyecto y activar la opcion de xml

![[Pasted image 20231220131758.png]]

Para poder generar la documentación y se pueda visualizar en swagger

Ahora ya estamos listos para crear nuestra imagen de docker

vamos a una terminal y nos vamos al directorio en donde esta la solución



de ahi ejecutaremos el siguiente comando

```CLI
docker image build -t DarkShop.Ecommerce:1.0.0 -f .\DarkShop.Ecommerce.Services.WebApi\Dockerfile .
```

y para validar que exista al ejecutar el siguiente comando 

```CLI
docker image ls
```

debemos tener el siguiente resultado
![[Pasted image 20231220165658.png]]


Si te interesaria borrarla seria con el siguiente comando

```CLI
docker image rm -f eb26e587c6b8
```

claro, selecciona el image id correspondiente para ti


A continuación desarrollaremos el contenedor para desplegar la imagen

## Creación del contenedor Docker

Para crear nuestro contenedor ejecutaremos el siguiente comando 

```CLI
docker container run --name darkshop.ecommerce -d -p 8050:80 eb26e587c6b8
```

y para revisar que este en ejecución con el siguiente comando

```CLI
docker container ls
```

en donde validaremos lo siguiente 

![[Pasted image 20231220172142.png]]

ahora para validar su funcionamiento 

entraremos en un navegador a la siguiente liga

localhost:8050/swagger

Por si hay algun error puedes visualizar los lgs con

```CLI
docker container logs ID
```

