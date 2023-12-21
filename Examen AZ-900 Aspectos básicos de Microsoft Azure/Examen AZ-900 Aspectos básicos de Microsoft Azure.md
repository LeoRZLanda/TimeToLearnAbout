# Info

Este examen es un punto de partida común en un recorrido hacia una carrera profesional en Azure.

Puede describir los componentes arquitectónicos de Azure y los servicios de Azure, como:

- Compute
- Redes
- Storage

También pueden describir las características y herramientas para proteger, gobernar y administrar Azure.

Debe tener aptitudes y experiencia trabajando con un área de TI, como:

- Administración de la infraestructura
- Administración de bases de datos
- Desarrollo de software

Si aprueba este examen de certificación, es posible que pueda optar al crédito universitario de ACE. Consulte [Crédito universitario de ACE para exámenes de certificación](https://learn.microsoft.com/es-es/credentials/certifications/college-credit) para obtener más información.

## Aptitudes evaluadas

- Descripción de los conceptos de la nube (25-30 %)
- Descripción de la arquitectura y los servicios de Azure (35-40 %)
- Descripción de la administración y la gobernanza de Azure (30-35 %)

Si te interesa mas información [Examen AZ-900: Microsoft Azure Fundamentals - Certifications | Microsoft Learn](https://learn.microsoft.com/es-es/credentials/certifications/exams/az-900/)

# Aspectos básicos de Microsoft Azure: Descripción de los conceptos de nube

## Descripción de la informática en la nube

### Introducción a los aspectos básicos de Microsoft Azure

Microsoft Azure es una plataforma de informática en la nube con un conjunto de servicios que se amplía continuamente. 

Los servicios de Azure admiten todo, desde lo simple hasta lo complejo.

Tales como; servicios web sencillos para hospedar su presencia empresarial en la nube, equipos totalmente virtualizados que administran las soluciones de software personalizadas, almacenamiento remoto, hospedaje de bases de datos, administración centralizada de cuentas, inteligencia artificial (IA) y servicios centrados en el Internet de las cosas (IoT).

#### ¿De qué va Aspectos básicos de Azure?

Ya sea que esté interesado en los servicios de proceso, red o almacenamiento, en aprender sobre los procedimientos recomendados de seguridad en la nube o explorar las opciones de gobernanza y gestión, piense en desarrollar los ejercicios interactivos que ofrecen experiencia práctica con Azure.

### Introducción a la informática en la nube

Se le presentarán los conceptos generales de la nube.
#### Objetivos de aprendizaje

Después de completar este módulo, podrá:

- Definir la informática en la nube.
- Describir el modelo de responsabilidad compartida.
- Definir modelos de nube, incluidos públicos, privados e híbridos.
- Identificar los casos de uso adecuados para cada modelo de nube.
- Describir el modelo basado en el consumo.
- Comparar los modelos de precios en la nube.

## ¿Qué es la informática en la nube?

La informática en la nube es la prestación de servicios informáticos a través de Internet.

Servicios informáticos comunes:

* Maquinas virtuales
* Almacenamiento
* bases de datos
* Redes
* IoT
* ML
* IA

A razón de que usa Internet para ofrecer estos servicios, no es necesario que la infraestructura física la limite, y pueda expandir rápidamente la infraestructura de TI.

## Descripción del modelo de responsabilidad compartida

Comience con un centro de datos corporativo tradicional. La empresa es la responsable de mantener el espacio físico, garantizar la seguridad, y mantener o reemplazar los servidores si ocurre algo.

Con el modelo de responsabilidad compartida, estas responsabilidades se comparten entre el proveedor de servicios en la nube y el consumidor.

La seguridad física, la alimentación, la refrigeración y la conectividad de red son responsabilidad del proveedor de servicios en la nube. A razón de el consumidor no tiene acceso al centro de datos.

Así mismo el consumidor es el responsable de los datos y la información almacenados en la nube. También es el responsable de la seguridad de acceso, lo que significa que solo da acceso a aquellos que lo necesitan.

Entonces, para algunas cosas, la responsabilidad depende de la situación.

El modelo de responsabilidad compartida está muy vinculado a los tipos de servicio en la nube;

* **IaaS** infraestructura como servicio
* **PaaS** plataforma como servicio
* **SaaS** software como servicio

![[Pasted image 20231221113147.png]]


Como podemos apreciar  IaaS sitúa la mayor responsabilidad en el consumidor y el proveedor de servicios en la nube es el responsable de los conceptos básicos de seguridad física, energía y conectividad. 

En el extremo opuesto, SaaS sitúa la mayor parte de la responsabilidad en el proveedor de servicios en la nube. PaaS, siendo un punto intermedio entre IaaS y SaaS, se encuentra en algún lugar del medio y distribuye uniformemente la responsabilidad entre el proveedor de nube y el consumidor.

Siempre será responsabilidad suya lo siguiente:

- La información y los datos almacenados en la nube.
- Los dispositivos que pueden conectarse a la nube (teléfonos móviles, equipos, etc.).
- Las cuentas e identidades de las personas, servicios y dispositivos de la organización

El proveedor de nube siempre es el responsable de lo siguiente:

- El centro de datos físico
- La red física
- Los hosts físicos

El modelo de servicio determinará la responsabilidad de cosas como lo siguiente:

- Sistemas operativos
- Controles de red
- APLICACIONES
- Identidad e infraestructura


## Definición de modelos en la nube

Los modelos en la nube definen el tipo de implementación de recursos en la nube. Los tres principales modelos en la nube son: privados, públicos e híbridos.

### Nube privada

Nube que brinda servicios de TI a través de Internet y es utilizada por una sola entidad.

Proporciona un control mucho mayor para la empresa, sin embargo incluye un mayor costo y menos ventajas que una implementación en la nube pública.

### Nube pública 

Un proveedor de nube de terceros crea, controla y mantiene una nube pública. Cualquier persona que quiera comprar servicios en la nube puede acceder a los recursos y usarlos. La disponibilidad pública general es una diferencia clave entre las nubes públicas y privadas.

### Nube híbrida

Entorno informático que usa nubes públicas y privadas en un entorno interconectado. Permite el incremento de una nube privada y acomodarse al aumento de la demanda temporal mediante la implementación de recursos de nube pública. La nube híbrida se puede usar para proporcionar una capa adicional de seguridad.

En la tabla siguiente se resaltan algunos aspectos comparativos clave entre los modelos de nube.

|Nube pública|Nube privada|Nube híbrida|
| - | - | - |
|No hay gastos de capital para escalar verticalmente.|Las organizaciones tienen un control total de los recursos y  la seguridad|Proporciona la máxima flexibilidad|
|Las aplicaciones pueden aprovisionarse y desaprovisionarse rápidamente.|Los datos no se colocan con los datos de otras organizaciones.|Las organizaciones determinan dónde se van a ejecutar sus aplicaciones.|
|Las organizaciones solo pagan por lo que usan.|Debe adquirirse hardware para la puesta en funcionamiento y el mantenimiento.|Las organizaciones controlan la seguridad, el cumplimiento o los requisitos legales.|
|Las organizaciones no tienen un control total de los recursos y la seguridad.|Las organizaciones son responsables del mantenimiento y las actualizaciones del hardware.||

### Nubes múltiples

Se usan varios proveedores de nube pública.

Quizás haya iniciado su recorrido en la nube con un proveedor y esté en proceso de migración a otro proveedor.

### Azure Arc

Conjunto de tecnologías que ayudan a administrar el entorno en la nube.

### Azure VMware Solution

le permite ejecutar las cargas de trabajo de VMware en Azure con una integración y escalabilidad perfectas.

## Descripción del modelo basado en el consumo

Al comparar los modelos de infraestructura de TI, hay dos tipos de gastos que se deben tener en cuenta. Gastos de capital y gastos operativos.

Los gastos de capital suelen ser un gasto por adelantado único para comprar o proteger recursos tangibles.

Los gastos operativos es gastar dinero en servicios o productos a lo largo del tiempo.

La nube se encuentra en la partida de gastos operativos porque funciona en un modelo basado en el consumo.

Este modelo aporta muchas ventajas, por ejemplo:

- Sin costes por adelantado.
- No es necesario comprar ni administrar infraestructuras costosas que es posible que los usuarios no aprovechen todo su potencial.
- Se puede pagar para obtener más recursos cuando se necesiten.
- Se puede dejar de pagar por los recursos que ya no se necesite

### Comparación de los modelos de precios en la nube

La informática en la nube es la prestación de servicios informáticos a través de Internet mediante un modelo de precios de pago por uso. Normalmente solo se paga por los servicios en la nube que se usan, lo que permite:

- Planificar y administrar los costos operativos.
- Ejecutar la infraestructura de forma más eficaz.
- Escalar a medida que cambien las necesidades empresariales.


## Comprobación de conocimientos

1. ¿Qué es la informática en la nube?

<details>
	<summary>Respuesta</summary>
	<p>La información en la nube es la presentación de servicios informáticos a través de internet</p>
</details>

2. ¿Qué modelo de nube usa algunos centros de datos centrados en proporcionar servicios en la nube a cualquier persona que los quiera y algunos centros de datos centrados en un solo cliente?

<details>
	<summary>Respuesta</summary>
	<p>El modelo de nube híbrida es una combinación de la nube pública y la nube privada, con ambos centros de datos dedicados únicamente a un cliente y a centros de datos que se comparten con el público.</p>
</details>

3. Según el modelo de responsabilidad compartida, ¿qué tipo de servicio en la nube sitúa la mayor responsabilidad en el cliente?

<details>
	<summary>Respuesta</summary>
	<p>IaaS sitúa la mayor responsabilidad en el consumidor y el proveedor de servicios en la nube es el responsable de los conceptos básicos de seguridad física, energía y conectividad.</p>
</details>

## Resumen

* Comprendimos lo que es la informática en la nube

* Descubrir el modelo de responsabilidad compartida y cómo usted y su proveedor de nube comparten la responsabilidad de mantener protegida la información en la nube.

* Las diferencias entre los modelos de nube. 

* Tipos de gastos en TI

### Objetivos de aprendizaje

Ahora debería ser capaz de hacer lo siguiente:

- Definir la informática en la nube.
- Describir el modelo de responsabilidad compartida.
- Definir modelos de nube, incluidos públicos, privados e híbridos.
- Identificar los casos de uso adecuados para cada modelo de nube.
- Describir el modelo basado en el consumo.
- Comparar los modelos de precios en la nube.

### Recursos adicionales

Los recursos siguientes proporcionan más información sobre los temas de este módulo o relacionados con este módulo.

- [Modelo de responsabilidad compartida](https://learn.microsoft.com/es-es/azure/security/fundamentals/shared-responsibility): el modelo de responsabilidad compartida es el uso compartido de responsabilidades para la nube entre usted y su proveedor de nube.
- [Introducción a Azure VMware Solution](https://learn.microsoft.com/es-es/learn/modules/intro-azure-vmware-solution/) es un curso de Microsoft Learn que profundiza en Azure VMware Solution.
- [Introducción a los servicios en la nube híbrida de Azure](https://learn.microsoft.com/es-es/learn/modules/intro-to-azure-hybrid-services/) es un curso de Microsoft Learn que explica la nube híbrida con mayor detalle.

# Descripción de las ventajas de usar servicios en la nube

## Introducción 

Descubriremos cómo la informática en la nube puede ayudar a satisfacer la demanda variable al tiempo que proporciona una buena experiencia para el cliente. Aunado sobre la seguridad, la gobernanza y la capacidad de administración general en la nube.

### Objetivos de aprendizaje

Después de completar este módulo, podrá:

- Describir las ventajas de la alta disponibilidad y escalabilidad en la nube.
- Describir las ventajas de la confiabilidad y la previsibilidad en la nube.
- Describir las ventajas de la seguridad y la gobernanza en la nube.
- Describir las ventajas de la capacidad de administración en la nube.
## Descripción de las ventajas de la alta disponibilidad y la escalabilidad en la nube

dos de las consideraciones más importantes son el tiempo de actividad (o la disponibilidad) y la capacidad de controlar la demanda (o escala).

### Alta disponibilidad

Al implementar cualquier recurso de TI es importante que los recursos estén disponibles cuando sea necesario.

Al diseñar la solución, deberá tener en cuenta las garantías de disponibilidad del servicio.

Azure es un entorno de nube de alta disponibilidad con garantías de tiempo de actividad en función del servicio. Estas garantías forman parte de los contratos de nivel de servicio, **SLA** service level agreement.


### Escalabilidad

Hace referencia a la capacidad de ajustar los recursos para satisfacer la demanda.

La otra ventaja de la escalabilidad es que no está pagando de más por los servicios.


El escalado suele tener dos variedades: vertical y horizontal. El escalado vertical se centra en aumentar o disminuir las capacidades de los recursos. El escalado horizontal agrega o resta el número de recursos.

#### Escalado vertical

Si necesitáramos desarrollar una aplicación y sea necesario más o menos potencia de procesamiento, podría escalar verticalmente para agregar o disminuir la CPU o RAM de la máquina virtual.

#### Escalado horizontal

Si de repente hay un salto elevado en la demanda, los recursos implementados se podrían escalar horizontalmente (ya sea de forma automática o manual). Por ejemplo, podríamos agregar o disminuir máquinas virtuales o contenedores adicionales.

## Descripción de las ventajas de la confiabilidad y la previsibilidad en la nube

La confiabilidad y la previsibilidad son dos ventajas cruciales de la nube que le ayudan a desarrollar soluciones con confianza.

### Confiabilidad

La confiabilidad es la capacidad de un sistema de recuperarse de los errores y seguir funcionando.

La nube, debido a su diseño descentralizado, admite de forma natural una infraestructura confiable y resistente. Y gracias a ello, la nube le permite implementar recursos en regiones de todo el mundo.

### Predicción

La previsibilidad en la nube le permite avanzar con confianza. La previsibilidad se puede centrar en el rendimiento o los costos.

### Rendimiento

La previsibilidad del rendimiento se centra en predecir los recursos necesarios para ofrecer una experiencia positiva para los clientes. El escalado automático, el equilibrio de carga y la alta disponibilidad son solo algunos de los conceptos de nube que admiten la previsibilidad del rendimiento.

### Coste

Con la nube, se puede realizar el seguimiento del uso de recursos en tiempo real.



## Descripción de las ventajas de la seguridad y la gobernanza en la nube

la nube admiten el cumplimiento y la **gobernanza**. Aspectos como las plantillas de conjunto ayudan a garantizar que todos los recursos implementados cumplan los estándares corporativos y los requisitos normativos de gobierno. 

Además, puede actualizar todos los recursos implementados a nuevos estándares a medida que estos cambien. La auditoría basada en la nube ayuda a marcar cualquier recurso que no cumpla los estándares corporativos y proporciona estrategias de mitigación. 

En función del modelo operativo, las revisiones de software y las actualizaciones también se pueden aplicar automáticamente, lo que ayuda tanto a la gobernanza como a la seguridad.

Aunado a esto, puede encontrar una solución en la nube que coincida con sus necesidades de **seguridad**. 

Si quiere tener un control máximo de la seguridad, la infraestructura como servicio le proporciona recursos físicos, pero le permite administrar los sistemas operativos y el software instalado, incluidas las revisiones y el mantenimiento. 

Si quiere que las revisiones y el mantenimiento se administren automáticamente, las implementaciones de plataforma como servicio o software como servicio pueden ser las mejores estrategias en la nube.


## Descripción de las ventajas de la capacidad de administración en la nube

Una ventaja importante de la informática en la nube son las opciones de administración. Hay dos tipos de administración:

### Administración de la nube

La administración de la nube trata sobre administrar los recursos en la nube. En la nube, puede hacer lo siguiente:

- Escalar automáticamente la implementación de recursos en función de las necesidades.

- Implementar recursos basados en una plantilla preconfigurada, lo que elimina la necesidad de realizar la configuración manual.

- Supervisar el estado de los recursos y reemplazar automáticamente los recursos con errores.

- Recibir alertas automáticas basadas en métricas configuradas, de modo que esté informado del rendimiento en tiempo real.

### Administración en la nube

La administración en la nube trata sobre cómo puede administrar el entorno y los recursos en la nube. Puede administrarlos de las siguientes maneras:

- Mediante un portal web.

- Con una interfaz de línea de comandos básica.

- Mediante las API.

- Mediante PowerShell.

## Prueba de conocimiento

1. ¿Qué tipo de escalado implica agregar o quitar recursos (como máquinas virtuales o contenedores) para satisfacer la demanda?

<details>
	<summary>Respuesta</summary>
	<p>El escalado horizontal agrega o resta el número de recursos.</p>
</details>

2. ¿Qué se describe como la capacidad de un sistema de recuperarse de los errores y seguir funcionando?

<details>
	<summary>Respuesta</summary>
	<p>La confiabilidad es la capacidad de un sistema para recuperarse de errores y seguir en funcionamiento y es uno de los pilares del Marco de buena arquitectura de Microsoft Azure.</p>
</details>


## Resumen 

 * Ventajas de trabajar en la nube. 
 
 * la alta disponibilidad y la fiabilidad, y cómo funcionan para mantener las aplicaciones en ejecución. 
 
 * Un entorno más seguro, gracias a la nube. 
 
 * Como la nube proporciona un entorno muy administrable para los recursos.

### Objetivos de aprendizaje

Ahora debería ser capaz de hacer lo siguiente:

- Describir las ventajas de la alta disponibilidad y escalabilidad en la nube.
- Describir las ventajas de la confiabilidad y la previsibilidad en la nube.
- Describir las ventajas de la seguridad y la gobernanza en la nube.
- Describir las ventajas de la capacidad de administración en la nube.

### Recursos adicionales

Los recursos siguientes proporcionan más información sobre los temas de este módulo o relacionados con este módulo.

- [Creación de excelentes soluciones con el Marco de buena arquitectura de Microsoft Azure](https://learn.microsoft.com/es-es/learn/paths/azure-well-architected-framework/) es un curso de Microsoft Learn que presenta el Marco de buena arquitectura de Microsoft Azure.



# # Descripción de los tipos de servicio en la nube

## Introducción

Se verán los distintos tipos de servicio en la nube y se comparten algunos de los casos de uso y las ventajas alineados con cada tipo de servicio.

### Objetivos de aprendizaje

Al finalizar este módulo:

- Describir la infraestructura como servicio (IaaS).
- Describir la plataforma como servicio (PaaS).
- Describir el software como servicio (SaaS).
- Identificar los casos de uso adecuados para cada servicio en la nube (IaaS, PaaS, SaaS).

## Descripción de la infraestructura como servicio (IaaS)

Siendo la categoría más flexible de servicios en la nube, ya que proporciona el máximo control para los recursos en la nube.

El proveedor de nube es el responsable de mantener el hardware, la conectividad de red (a Internet) y la seguridad física.

Todo lo demás será responsabilidad nuestra: instalación, configuración y mantenimiento del sistema operativo, configuración de red, configuración de base de datos y almacenamiento, etc.

básicamente es alquilar el hardware en un centro de datos en la nube, pero puedes hacer lo que quieras con ese hardware.

### Modelo de responsabilidad compartida

Como previamente se ha mencionado, se aplica a todos los tipos de servicio en la nube. IaaS sitúa la mayor parte de responsabilidad en nosotros. El proveedor de nube es el responsable de mantener la infraestructura física y su acceso a Internet. La instalación y configuración, la aplicación de revisiones y las actualizaciones y la seguridad serán responsabilidad nuestra.

![[Pasted image 20231221113147.png]]


### Escenarios

Algunos escenarios comunes en los que IaaS puede tener sentido incluyen los siguientes:

- Migración mediante lift-and-shift: estás poniendo en marcha recursos en la nube similares al centro de datos local y, después, simplemente mover las cosas que se ejecutan localmente para que se ejecuten en la infraestructura IaaS.

- Pruebas y desarrollo: has establecido configuraciones para entornos de desarrollo y pruebas que necesita para replicar rápidamente. Puedes poner en marcha o apagar rápidamente los diferentes entornos con una estructura IaaS, a la vez que mantiene un control total.


## Descripción de la plataforma como servicio (PaaS)

es un punto intermedio entre alquilar espacio en un centro de datos (infraestructura como servicio) y pagar por una solución completa e implementada (software como servicio).