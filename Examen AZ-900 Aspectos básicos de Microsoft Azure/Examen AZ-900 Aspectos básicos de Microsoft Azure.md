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

### ¿Qué es la informática en la nube?

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

### Descripción del modelo de responsabilidad compartida

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


### Definición de modelos en la nube

Los modelos en la nube definen el tipo de implementación de recursos en la nube. Los tres principales modelos en la nube son: privados, públicos e híbridos.

#### Nube privada

Nube que brinda servicios de TI a través de Internet y es utilizada por una sola entidad.

Proporciona un control mucho mayor para la empresa, sin embargo incluye un mayor costo y menos ventajas que una implementación en la nube pública.

#### Nube pública 

Un proveedor de nube de terceros crea, controla y mantiene una nube pública. Cualquier persona que quiera comprar servicios en la nube puede acceder a los recursos y usarlos. La disponibilidad pública general es una diferencia clave entre las nubes públicas y privadas.

#### Nube híbrida

Entorno informático que usa nubes públicas y privadas en un entorno interconectado. Permite el incremento de una nube privada y acomodarse al aumento de la demanda temporal mediante la implementación de recursos de nube pública. La nube híbrida se puede usar para proporcionar una capa adicional de seguridad.

En la tabla siguiente se resaltan algunos aspectos comparativos clave entre los modelos de nube.

|Nube pública|Nube privada|Nube híbrida|
| - | - | - |
|No hay gastos de capital para escalar verticalmente.|Las organizaciones tienen un control total de los recursos y  la seguridad|Proporciona la máxima flexibilidad|
|Las aplicaciones pueden aprovisionarse y desaprovisionarse rápidamente.|Los datos no se colocan con los datos de otras organizaciones.|Las organizaciones determinan dónde se van a ejecutar sus aplicaciones.|
|Las organizaciones solo pagan por lo que usan.|Debe adquirirse hardware para la puesta en funcionamiento y el mantenimiento.|Las organizaciones controlan la seguridad, el cumplimiento o los requisitos legales.|
|Las organizaciones no tienen un control total de los recursos y la seguridad.|Las organizaciones son responsables del mantenimiento y las actualizaciones del hardware.||

#### Nubes múltiples

Se usan varios proveedores de nube pública.

Quizás haya iniciado su recorrido en la nube con un proveedor y esté en proceso de migración a otro proveedor.

#### Azure Arc

Conjunto de tecnologías que ayudan a administrar el entorno en la nube.

#### Azure VMware Solution

le permite ejecutar las cargas de trabajo de VMware en Azure con una integración y escalabilidad perfectas.

### Descripción del modelo basado en el consumo

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


### Comprobación de conocimientos

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

### Resumen

* Comprendimos lo que es la informática en la nube

* Descubrir el modelo de responsabilidad compartida y cómo usted y su proveedor de nube comparten la responsabilidad de mantener protegida la información en la nube.

* Las diferencias entre los modelos de nube. 

* Tipos de gastos en TI

#### Objetivos de aprendizaje

Ahora debería ser capaz de hacer lo siguiente:

- Definir la informática en la nube.
- Describir el modelo de responsabilidad compartida.
- Definir modelos de nube, incluidos públicos, privados e híbridos.
- Identificar los casos de uso adecuados para cada modelo de nube.
- Describir el modelo basado en el consumo.
- Comparar los modelos de precios en la nube.

#### Recursos adicionales

Los recursos siguientes proporcionan más información sobre los temas de este módulo o relacionados con este módulo.

- [Modelo de responsabilidad compartida](https://learn.microsoft.com/es-es/azure/security/fundamentals/shared-responsibility): el modelo de responsabilidad compartida es el uso compartido de responsabilidades para la nube entre usted y su proveedor de nube.
- [Introducción a Azure VMware Solution](https://learn.microsoft.com/es-es/learn/modules/intro-azure-vmware-solution/) es un curso de Microsoft Learn que profundiza en Azure VMware Solution.
- [Introducción a los servicios en la nube híbrida de Azure](https://learn.microsoft.com/es-es/learn/modules/intro-to-azure-hybrid-services/) es un curso de Microsoft Learn que explica la nube híbrida con mayor detalle.

## Descripción de las ventajas de usar servicios en la nube

### Introducción 

Descubriremos cómo la informática en la nube puede ayudar a satisfacer la demanda variable al tiempo que proporciona una buena experiencia para el cliente. Aunado sobre la seguridad, la gobernanza y la capacidad de administración general en la nube.

#### Objetivos de aprendizaje

Después de completar este módulo, podrá:

- Describir las ventajas de la alta disponibilidad y escalabilidad en la nube.
- Describir las ventajas de la confiabilidad y la previsibilidad en la nube.
- Describir las ventajas de la seguridad y la gobernanza en la nube.
- Describir las ventajas de la capacidad de administración en la nube.
### Descripción de las ventajas de la alta disponibilidad y la escalabilidad en la nube

dos de las consideraciones más importantes son el tiempo de actividad (o la disponibilidad) y la capacidad de controlar la demanda (o escala).

#### Alta disponibilidad

Al implementar cualquier recurso de TI es importante que los recursos estén disponibles cuando sea necesario.

Al diseñar la solución, deberá tener en cuenta las garantías de disponibilidad del servicio.

Azure es un entorno de nube de alta disponibilidad con garantías de tiempo de actividad en función del servicio. Estas garantías forman parte de los contratos de nivel de servicio, **SLA** service level agreement.


#### Escalabilidad

Hace referencia a la capacidad de ajustar los recursos para satisfacer la demanda.

La otra ventaja de la escalabilidad es que no está pagando de más por los servicios.


El escalado suele tener dos variedades: vertical y horizontal. El escalado vertical se centra en aumentar o disminuir las capacidades de los recursos. El escalado horizontal agrega o resta el número de recursos.

#### Escalado vertical

Si necesitáramos desarrollar una aplicación y sea necesario más o menos potencia de procesamiento, podría escalar verticalmente para agregar o disminuir la CPU o RAM de la máquina virtual.

#### Escalado horizontal

Si de repente hay un salto elevado en la demanda, los recursos implementados se podrían escalar horizontalmente (ya sea de forma automática o manual). Por ejemplo, podríamos agregar o disminuir máquinas virtuales o contenedores adicionales.

### Descripción de las ventajas de la confiabilidad y la previsibilidad en la nube

La confiabilidad y la previsibilidad son dos ventajas cruciales de la nube que le ayudan a desarrollar soluciones con confianza.

#### Confiabilidad

La confiabilidad es la capacidad de un sistema de recuperarse de los errores y seguir funcionando.

La nube, debido a su diseño descentralizado, admite de forma natural una infraestructura confiable y resistente. Y gracias a ello, la nube le permite implementar recursos en regiones de todo el mundo.

#### Predicción

La previsibilidad en la nube le permite avanzar con confianza. La previsibilidad se puede centrar en el rendimiento o los costos.

#### Rendimiento

La previsibilidad del rendimiento se centra en predecir los recursos necesarios para ofrecer una experiencia positiva para los clientes. El escalado automático, el equilibrio de carga y la alta disponibilidad son solo algunos de los conceptos de nube que admiten la previsibilidad del rendimiento.

#### Coste

Con la nube, se puede realizar el seguimiento del uso de recursos en tiempo real.



### Descripción de las ventajas de la seguridad y la gobernanza en la nube

la nube admiten el cumplimiento y la **gobernanza**. Aspectos como las plantillas de conjunto ayudan a garantizar que todos los recursos implementados cumplan los estándares corporativos y los requisitos normativos de gobierno. 

Además, puede actualizar todos los recursos implementados a nuevos estándares a medida que estos cambien. La auditoría basada en la nube ayuda a marcar cualquier recurso que no cumpla los estándares corporativos y proporciona estrategias de mitigación. 

En función del modelo operativo, las revisiones de software y las actualizaciones también se pueden aplicar automáticamente, lo que ayuda tanto a la gobernanza como a la seguridad.

Aunado a esto, puede encontrar una solución en la nube que coincida con sus necesidades de **seguridad**. 

Si quiere tener un control máximo de la seguridad, la infraestructura como servicio le proporciona recursos físicos, pero le permite administrar los sistemas operativos y el software instalado, incluidas las revisiones y el mantenimiento. 

Si quiere que las revisiones y el mantenimiento se administren automáticamente, las implementaciones de plataforma como servicio o software como servicio pueden ser las mejores estrategias en la nube.


### Descripción de las ventajas de la capacidad de administración en la nube

Una ventaja importante de la informática en la nube son las opciones de administración. Hay dos tipos de administración:

#### Administración de la nube

La administración de la nube trata sobre administrar los recursos en la nube. En la nube, puede hacer lo siguiente:

- Escalar automáticamente la implementación de recursos en función de las necesidades.

- Implementar recursos basados en una plantilla preconfigurada, lo que elimina la necesidad de realizar la configuración manual.

- Supervisar el estado de los recursos y reemplazar automáticamente los recursos con errores.

- Recibir alertas automáticas basadas en métricas configuradas, de modo que esté informado del rendimiento en tiempo real.

#### Administración en la nube

La administración en la nube trata sobre cómo puede administrar el entorno y los recursos en la nube. Puede administrarlos de las siguientes maneras:

- Mediante un portal web.

- Con una interfaz de línea de comandos básica.

- Mediante las API.

- Mediante PowerShell.

### Prueba de conocimiento

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


### Resumen 

 * Ventajas de trabajar en la nube. 
 
 * la alta disponibilidad y la fiabilidad, y cómo funcionan para mantener las aplicaciones en ejecución. 
 
 * Un entorno más seguro, gracias a la nube. 
 
 * Como la nube proporciona un entorno muy administrable para los recursos.

#### Objetivos de aprendizaje

Ahora debería ser capaz de hacer lo siguiente:

- Describir las ventajas de la alta disponibilidad y escalabilidad en la nube.
- Describir las ventajas de la confiabilidad y la previsibilidad en la nube.
- Describir las ventajas de la seguridad y la gobernanza en la nube.
- Describir las ventajas de la capacidad de administración en la nube.

#### Recursos adicionales

Los recursos siguientes proporcionan más información sobre los temas de este módulo o relacionados con este módulo.

- [Creación de excelentes soluciones con el Marco de buena arquitectura de Microsoft Azure](https://learn.microsoft.com/es-es/learn/paths/azure-well-architected-framework/) es un curso de Microsoft Learn que presenta el Marco de buena arquitectura de Microsoft Azure.



## Descripción de los tipos de servicio en la nube

### Introducción

Se verán los distintos tipos de servicio en la nube y se comparten algunos de los casos de uso y las ventajas alineados con cada tipo de servicio.

#### Objetivos de aprendizaje

Al finalizar este módulo:

- Describir la infraestructura como servicio (IaaS).
- Describir la plataforma como servicio (PaaS).
- Describir el software como servicio (SaaS).
- Identificar los casos de uso adecuados para cada servicio en la nube (IaaS, PaaS, SaaS).

### Descripción de la infraestructura como servicio (IaaS)

Siendo la categoría más flexible de servicios en la nube, ya que proporciona el máximo control para los recursos en la nube.

El proveedor de nube es el responsable de mantener el hardware, la conectividad de red (a Internet) y la seguridad física.

Todo lo demás será responsabilidad nuestra: instalación, configuración y mantenimiento del sistema operativo, configuración de red, configuración de base de datos y almacenamiento, etc.

básicamente es alquilar el hardware en un centro de datos en la nube, pero puedes hacer lo que quieras con ese hardware.

#### Modelo de responsabilidad compartida

Como previamente se ha mencionado, se aplica a todos los tipos de servicio en la nube. IaaS sitúa la mayor parte de responsabilidad en nosotros. El proveedor de nube es el responsable de mantener la infraestructura física y su acceso a Internet. La instalación y configuración, la aplicación de revisiones y las actualizaciones y la seguridad serán responsabilidad nuestra.

![[Pasted image 20231221113147.png]]


#### Escenarios

Algunos escenarios comunes en los que IaaS puede tener sentido incluyen los siguientes:

- Migración mediante lift-and-shift: estás poniendo en marcha recursos en la nube similares al centro de datos local y, después, simplemente mover las cosas que se ejecutan localmente para que se ejecuten en la infraestructura IaaS.

- Pruebas y desarrollo: has establecido configuraciones para entornos de desarrollo y pruebas que necesita para replicar rápidamente. Puedes poner en marcha o apagar rápidamente los diferentes entornos con una estructura IaaS, a la vez que mantiene un control total.


### Descripción de la plataforma como servicio (PaaS)

es un punto intermedio entre alquilar espacio en un centro de datos (infraestructura como servicio) y pagar por una solución completa e implementada (software como servicio).

PaaS es ideal para proporcionar un entorno de desarrollo completo sin el molesto de mantener toda la infraestructura de desarrollo.

#### Modelo de responsabilidad compartida

PaaS divide la responsabilidad entre usted y el proveedor de nube. El proveedor de nube es responsable de mantener la infraestructura física y su acceso a Internet, al igual que en IaaS. En el modelo PaaS, el proveedor de nube también mantendrá los sistemas operativos, las bases de datos y las herramientas de desarrollo. 

Piense en PaaS como usar una máquina unida a un dominio: TI mantiene el dispositivo con actualizaciones y revisiones periódicas.

En función de la configuración, usted o el proveedor de nube pueden ser responsables de la configuración de red y la conectividad dentro del entorno de nube, la seguridad de red y la aplicación y la infraestructura de directorios.

![[Pasted image 20231221113147.png]]

#### Escenarios

Algunos escenarios comunes en los que PaaS pueden encajar incluyen:

- Marco de desarrollo: PaaS ofrece un marco que los desarrolladores pueden usar para desarrollar o personalizar aplicaciones basadas en la nube. De una manera similar a como se crea una macro de Excel, PaaS permite que los desarrolladores creen aplicaciones a través de componentes de software integrados. Se incluyen características de la nube, como escalabilidad, alta disponibilidad y funcionalidad multiinquilino, lo que permite reducir la cantidad de codificación que deben realizar los desarrolladores.

- Análisis o inteligencia empresarial: las herramientas proporcionadas como servicio con PaaS permiten a las organizaciones analizar y extraer sus datos, buscar información y patrones y predecir resultados para mejorar la previsión, las decisiones de diseño de productos, las devoluciones de inversión y otras decisiones empresariales.

### Descripción del software como servicio (SaaS)

Es el modelo de servicio en la nube más completo desde el punto de vista del producto. 

Con SaaS, básicamente la que hace es alquilar o usar una aplicación totalmente desarrollada. El correo electrónico, el software financiero, las aplicaciones de mensajería y el software de conectividad son ejemplos comunes de una implementación de SaaS.

Aunque el modelo de SaaS puede ser el menos flexible, también es el más sencillo de poner en marcha. Requiere la menor cantidad de conocimientos técnicos o experiencia para utilizarlo en toda su dimensión.

#### Modelo de responsabilidad compartida

SaaS es el modelo que sitúa la mayor responsabilidad en el proveedor de nube y la menor responsabilidad en el usuario.

En un entorno de SaaS, serán responsabilidad suya los datos que ha puesto en el sistema, los dispositivos que le permiten conectarse al sistema y los usuarios que tienen acceso.

De casi todo lo demás se encargará el proveedor de nube. Este será el responsable de la seguridad física de los centros de datos, la potencia, la conectividad de red, así como del desarrollo y la aplicación de revisiones.

![[Pasted image 20231221113147.png]]

#### Escenarios

Algunos escenarios comunes para SaaS son los siguientes:

- Correo electrónico y mensajería
- Aplicaciones de productividad empresarial
- Seguimiento de finanzas y gastos

### Prueba de conocimientos

1. ¿Qué tipo de servicio en la nube es más adecuado para una migración mediante lift-and-shift de un centro de datos local a una implementación en la nube?

<Details>
	<Summary>Respuesta</Summary>
	<p>Con un tipo de servicio <b>IaaS</b>, puede aproximarse a su entorno local, lo que hace que realizar una transición a la nube mediante lift-and-shift sea relativamente sencillo.</p>
</Details>

2. ¿En qué tipo de servicio en la nube se encuentra normalmente una solución de seguimiento de finanzas y gastos?

<Details>
	<Summary>Respuesta</Summary>
	<p><b>SaaS</b> proporciona acceso a soluciones de software, como el seguimiento de finanzas y gastos, el correo electrónico o los sistemas de vales.</p>
</Details>


### Resumen

hemos aprendido sobre los tipos de servicio en la nube y algunos escenarios comunes para cada tipo. También ha reforzado la forma en que el modelo de responsabilidad compartida determina sus responsabilidades con diferentes tipos de servicios en la nube.

#### Objetivos de aprendizaje

Ahora debería ser capaz de hacer lo siguiente:

- Describir la infraestructura como servicio (Iaas).
- Describir la plataforma como servicio (Paas).
- Describir el software como servicio (SaaS).
- Identificar los casos de uso adecuados para cada servicio en la nube (IaaS, PaaS, SaaS).

# Aspectos básicos de Microsoft Azure: Descripción de la arquitectura y los servicios de Azure

## Describir los componentes arquitectónicos principales de Azure

### Introducción

En este módulo, se presentarán los principales componentes arquitectónicos de Azure. Obtendrás información sobre la organización física de Azure: centros de datos, zonas de disponibilidad y regiones; y también sobre la estructura organizativa de Azure: recursos y grupos de recursos, suscripciones y grupos de administración.

#### Objetivos de aprendizaje

Después de completar este módulo, podrás:

- Describir las regiones de Azure, los pares de regiones y las regiones soberanas.
- Describir las zonas de disponibilidad.
- Describir los centros de datos de Azure.
- Describir los recursos y grupos de recursos de Azure.
- Describir las suscripciones.
- Describir los grupos de administración.
- Describir la jerarquía de grupos de recursos, suscripciones y grupos de administración.




### ¿Qué es Microsoft Azure?

Azure es un conjunto de servicios en la nube en expansión constante que le ayudan a cumplir los desafíos empresariales actuales y futuros. Azure le ofrece la libertad de compilar, administrar e implementar aplicaciones en una red global masiva mediante sus herramientas y plataformas favoritas.


#### ¿Qué ofrece azure?

A continuación se enumeran algunas de las ventajas que proporciona Azure, para que inventar con un objetivo sea más sencillo:

- **Prepararse para el futuro**: la innovación continua de Microsoft apoya el desarrollo actual y los proyectos de productos para el futuro.

- **Crear según términos propios**: tienes varias opciones. Si mantiene un compromiso con el código abierto y admite todos los lenguajes y marcos, puede compilar como quiera e implementar donde quiera.

- **Funcionamiento sin problemas en el entorno híbrido**: ya sea en el entorno local, en la nube o en el entorno perimetral, le apoyaremos donde esté.

- **Confianza en la nube**


#### ¿Qué puedo hacer con Azure?


Azure proporciona más de 100 servicios que permiten hacer todo tipo de cosas: desde ejecutar las aplicaciones existentes en máquinas virtuales hasta explorar nuevos paradigmas de software, como bots inteligentes y realidad mixta.

Azure proporciona servicios de inteligencia artificial (IA) y aprendizaje automático (ML) que pueden comunicarse de forma natural con los usuarios mediante la vista, el oído y la voz. También facilita soluciones de almacenamiento que crecen dinámicamente para dar cabida a grandes cantidades de datos. Los servicios de Azure permiten soluciones que no son factibles sin la potencia de la nube.

## Introducción a las cuentas de Azure

Para crear y usar los servicios de Azure, necesita una suscripción de Azure. Al completar los módulos de Microsoft Learn, la mayoría de las veces se crea una suscripción temporal de forma automática, que se ejecuta en un entorno denominado espacio aislado de Microsoft Learn.


### Creación de una cuenta de Azure

Para comprar el acceso a Azure directamente desde Microsoft, regístrate en el sitio web de Azure o hágalo a través de un representante de Microsoft. 

### ¿Qué es la cuenta gratuita de Azure?

La cuenta gratuita de Azure incluye lo siguiente:

- Acceso gratuito a productos populares de Azure durante 12 meses.
- Crédito para gastar durante los primeros 30 días.
- Acceso a más de 25 productos que siempre son gratuitos.

La [cuenta gratuita de Azure](https://azure.microsoft.com/free) ofrece de forma óptima un comienzo y exploración a los nuevos usuarios. Para registrarse, necesita un número de teléfono, una tarjeta de crédito y una cuenta de Microsoft o de GitHub. La información de la tarjeta de crédito solo se usa para la verificación de identidad. No se te cobrará por ningún servicio hasta que actualice a una suscripción de pago.

### ¿Qué es la cuenta de estudiante gratuita de Azure?

La oferta de la cuenta de estudiante gratuita de Azure incluye lo siguiente:

- Acceso gratuito a determinados servicios de Azure durante 12 meses.
- Un crédito para usar en los primeros 12 meses.
- Acceso gratuito a determinadas herramientas de desarrollo de software.

La [cuenta de estudiante gratuita de Azure](https://azure.microsoft.com/free/students/) es una oferta para estudiantes que ofrece 100 USD de crédito y herramientas de desarrollo gratuitas. Además, puedes registrarse sin tarjeta de crédito.


### ¿Qué es el espacio aislado de Microsoft Learn?

En muchos de los ejercicios de Learn se usa una tecnología denominada espacio aislado, que crea una suscripción temporal que se agrega a la cuenta de Azure. Esta suscripción temporal le permite crear recursos de Azure para la duración de un módulo de Learn. Learn limpia de forma automática los recursos temporales una vez que hayas completado el módulo.

Cuando completas un módulo de Learn, puedes usar la suscripción personal para finalizar los ejercicios que incluye. Pero el espacio aislado es el método preferido, ya que permite crear y probar recursos de Azure sin costo alguno.

## Ejercicio: Exploración del espacio aislado de Learn

### Tarea 1: Uso de la CLI de PowerShell

Una vez que se inicie el espacio aislado, la mitad de la pantalla estará en modo de interfaz de línea de comandos (CLI) de PowerShell. Si estás familiarizado con PowerShell, puedes administrar el entorno de Azure mediante comandos de PowerShell.

Usa el comando Get-date de PowerShell para obtener la fecha y hora actuales.

``` AZURE CLI
Get-date
```

La mayoría de los comandos específicos de Azure comenzarán con las letras az. El comando Get-date que acaba de ejecutar es específico de PowerShell. Ahora se probará un comando de Azure para comprobar qué versión de la CLI usa en este momento.

``` AZURE CLI
az version
```

### Tarea 2: Uso de la CLI de BASH

Si estás más familiarizado con BASH, puedes usar el comando BASH en su lugar mediante el cambio a la CLI de BASH.

Escribe bash para cambiar a la CLI de BASH.

```AZURE CLI
bash
```

![[Pasted image 20231221182056.png]]

De nuevo, usa el comando Get-date para obtener la fecha y hora actuales.

``` AZURE CLI
Get-date
```

Se produce un error porque Get-date es un comando específico de PowerShell.

![[Pasted image 20231221182015.png]]

Usa el comando date para obtener la fecha y hora actuales.

``` BASH
date
```

Al igual que en el modo PowerShell de la CLI, puedes usar las letras az para iniciar un comando de Azure en el modo BASH. Intenta ejecutar una actualización en la CLI con az upgrade.

``` AZURE CLI
az upgrade
```

Puedes volver al modo de PowerShell si escribe pwsh en la línea de comandos de BASH.

### Tarea 3: Uso del modo interactivo de la CLI de Azure

Otra manera de interactuar consiste en usar el modo interactivo de la CLI de Azure. Esto cambia el comportamiento de la CLI para parecerse más a un entorno de desarrollo integrado (IDE). El modo interactivo proporciona autocompletar, descripciones de comandos e incluso ejemplos. Si no estás familiarizado con BASH y PowerShell, pero quiere usar la línea de comandos, el modo interactivo puede ayudarte.

``` AZURE CLI
az interactive
```

Decide si quiere enviar datos de telemetría y escribe SÍ o NO.

Es posible que tengas que esperar uno o dos minutos para permitir que el modo interactivo se inicialice por completo. Después, escribe la letra "a" y la finalización automática debería empezar a funcionar. Si la finalización automática no funciona, borra lo que has escrito, espera un poco más y vuelve a intentarlo.

![[Pasted image 20231221182412.png]]

``` AZURE CLI
version
```

``` AZURE CLI
upgrade
```

Los comandos deben haber funcionado igual que antes y generar los mismos resultados. Usa el comando exit para salir del modo interactivo.

``` AZURE CLI
exit
```

### Tarea 4: Uso de Azure Portal

Durante los ejercicios del espacio aislado también tendrás la opción de usar Azure Portal. Debes usar el vínculo proporcionado en el ejercicio para acceder a Azure Portal. Con el vínculo proporcionado, en lugar de abrir el portal personalmente, se asegura de usar la suscripción correcta y poder completar el ejercicio como quieras.

Inicie sesión en [Azure Portal](https://portal.azure.com/learn.docs.microsoft.com) para comprobar la interfaz web de Azure. Una vez en el portal, puedes ver todos los servicios que ofrece Azure, así como echar un vistazo a los grupos de recursos, etc.

### Continuar

Todo listo por ahora. Volverás a este espacio aislado más adelante en este módulo y crearás un recurso real de Azure.

## Descripción de la infraestructura física de Azure

A lo largo del recorrido con Microsoft Azure, escucharás y usarás términos como regiones, zonas de disponibilidad, recursos, suscripciones, etc. Este módulo se centra en los principales componentes arquitectónicos de Azure. Los componentes arquitectónicos principales de Azure se pueden dividir en dos grandes grupos: la infraestructura física y la infraestructura de administración.

La infraestructura física de Azure comienza con los centros de datos. Conceptualmente, los centros de datos son iguales que los grandes centros de datos corporativos. Son instalaciones con recursos organizados en bastidores, con potencia dedicada, refrigeración e infraestructura de red.

### Regions

Una región es un área geográfica del planeta que contiene al menos un centro de datos, aunque podrían ser varios cercanos y conectados mediante una red de baja latencia. Azure asigna y controla los recursos de forma inteligente dentro de cada región para garantizar que las cargas de trabajo están bien compensadas.

Al implementar un recurso en Azure, es habitual tener que elegir la región en la que quiere que se implemente el recurso.

### Availability Zones

Las zonas de disponibilidad son centros de datos separados físicamente dentro de una región de Azure. Cada zona de disponibilidad consta de uno o varios centros de datos equipados con alimentación, refrigeración y redes independientes. Una zona de disponibilidad se configura para constituir un límite de aislamiento. Si una zona deja de funcionar, la otra continúa trabajando. Las zonas de disponibilidad están conectadas a través de redes de fibra óptica de alta velocidad privadas.

![[Pasted image 20231221184225.png]]

#### Uso de las zonas de disponibilidad en sus aplicaciones

A fin de proteger la información en caso de error, deberá asegurarse de que los servicios y datos son redundantes. Si hospeda su infraestructura, configurar su propia redundancia requiere la creación de entornos de hardware duplicados. Azure puede ayudar a que la aplicación tenga alta disponibilidad a través de zonas de disponibilidad.

Puede usar zonas de disponibilidad para ejecutar aplicaciones críticas y conseguir una alta disponibilidad en la arquitectura de sus aplicaciones si coloca los recursos de proceso, almacenamiento, red y datos dentro de una zona y los replica en otras. Recuerde que la duplicación de los servicios y la transferencia de datos entre zonas de disponibilidad podrían suponer un costo.

Las zonas de disponibilidad son principalmente para las máquinas virtuales, los discos administrados, los equilibradores de carga y las bases de datos SQL. Los servicios de Azure que admiten zonas de disponibilidad se dividen en tres categorías:

- Servicios de zona: ancle el recurso a una zona específica (por ejemplo, máquinas virtuales, discos administrados, direcciones IP).
- Servicios de redundancia de zona: la plataforma se replica automáticamente entre zonas (por ejemplo, almacenamiento con redundancia de zona, SQL Database).
- Servicios no regionales: los servicios siempre están disponibles en las ubicaciones geográficas de Azure y son resistentes a las interrupciones de toda la zona, así como a las de toda la región.

Incluso con la resistencia adicional que proporcionan las zonas de disponibilidad, es posible que un evento pueda ser tan grande que afecte a varias zonas de disponibilidad en una sola región. Para proporcionar una mayor resistencia, Azure tiene pares de regiones.

### Pares de región

La mayoría de las regiones de Azure se emparejan con otra región de la misma zona geográfica (por ejemplo, EE. UU., Europa o Asia) que se encuentre como mínimo a 500 km de distancia. Este enfoque permite la replicación de recursos en una zona geográfica que ayuda a reducir la probabilidad de que se produzcan interrupciones provocadas por eventos como desastres naturales, disturbios sociales, cortes del suministro eléctrico o interrupciones de la red física que afecten a una región completa. Por ejemplo, si una región de un par se ve afectada por un desastre natural, los servicios conmutarán por error automáticamente a la otra región de su par de regiones.

Algunos pares de regiones de ejemplo en Azure son Oeste de EE. UU. y Este de EE. UU., y Sudeste Asiático y Asia Pacífico. Como las dos regiones están directamente conectadas y lo suficientemente lejos como para estar aisladas contra desastres regionales, puede usarlas para proporcionar redundancia de datos y servicios de confianza.

#### Ventajas adicionales de los pares de región:

- Si se produce una gran interrupción de Azure, se da prioridad a una región de cada par para asegurarse de que al menos una se restaure lo más rápido posible para las aplicaciones hospedadas en ese par de regiones.

- Las actualizaciones planeadas de Azure se implementan una a una en regiones emparejadas para minimizar el tiempo de inactividad y el riesgo de interrupción de la aplicación.

- Los datos siguen residiendo en la misma zona geográfica que su pareja (excepto Sur de Brasil) con fines de jurisdicción fiscal y de aplicación de la ley.
### Regiones soberanas

Además de las regiones normales, Azure también tiene regiones soberanas. Las regiones soberanas son instancias de Azure que están aisladas de la instancia principal de Azure. Es posible que tenga que usar una región soberana con fines legales o de cumplimiento.

Entre las regiones soberanas de Azure se incluyen las siguientes:

- US DoD (centro), US Gov Virginia, US Gov Iowa y más: Estas regiones son instancias físicas y lógicas con aislamiento de red de Azure para asociados y agencias de la administración pública de EE. UU. Estos centros de datos están operados por personal estadounidense sometido a evaluación e incluyen certificaciones de cumplimiento adicionales.
- Este de China, Norte de China y más: Estas regiones están disponibles gracias a una asociación exclusiva entre Microsoft y 21Vianet, por la cual Microsoft no mantiene directamente los centros de datos.

## Descripción de la infraestructura de administración de Azure

La infraestructura de administración incluye recursos de Azure y grupos de recursos, suscripciones y cuentas. Comprender la organización jerárquica le ayudará a planear los proyectos y productos dentro de Azure.

### Recursos y grupos de recursos de Azure

Un recurso es el bloque de creación básico de Azure. Todo lo que cree, aprovisione, implemente, etc., es un recurso;

* Máquinas virtuales (VM)
* redes virtuales
* bases de datos
* servicios cognitivos
* etc.

![[Pasted image 20231221185932.png]]


Los grupos de recursos son simplemente agrupaciones de recursos. Al crear un recurso, es necesario colocarlo en un grupo de recursos. Aunque un grupo de recursos puede contener muchos recursos, un único recurso solo puede estar en un grupo de recursos a la vez. Es posible que algunos recursos se muevan entre grupos de recursos, pero al mover un recurso a un nuevo grupo, ya no estará asociado al grupo anterior. Además, los grupos de recursos no se pueden anidar, lo que significa que no se puede colocar el grupo de recursos B dentro del grupo de recursos A.

Los grupos de recursos proporcionan una manera cómoda de agrupar recursos. Al aplicar una acción a un grupo de recursos, se aplicará a todos los recursos que contiene. Si elimina un grupo de recursos, se eliminarán todos los recursos que contiene. Si concede o deniega el acceso a un grupo de recursos, habrá concedido o denegado acceso a todos los recursos que contiene.

Al aprovisionar recursos, es conveniente pensar en la estructura del grupo de recursos que mejor se adapte a las necesidades.

Por ejemplo, si vas a configurar un entorno de desarrollo temporal, agrupar todos los recursos significa que puede desaprovisionar todos los recursos asociados a la vez si elimina el grupo de recursos. Si vas a aprovisionar recursos de proceso que necesitarán tres esquemas de acceso diferentes, puede ser mejor agruparlos en función del esquema de acceso y, después, asignar acceso en el nivel de grupo de recursos.

No hay reglas rígidas sobre cómo se usan los grupos de recursos, por lo que debe tener en cuenta cómo configurarlos para maximizar su utilidad.


### Suscripciones de Azure

En Azure, las suscripciones son una unidad de administración, facturación y escala. Al igual que los grupos de recursos son una manera de organizar lógicamente los recursos, las suscripciones permiten organizar lógicamente los grupos de recursos y facilitar la facturación.

Una cuenta puede tener varias suscripciones, pero solo es obligatorio tener una. En una cuenta de varias suscripciones, puede usarlas para configurar diferentes modelos de facturación y aplicar diferentes directivas de administración de acceso. 

Hay dos tipos de límites de suscripción que puede utilizar:

- **Límite de facturación**: Este tipo de suscripción determina cómo se factura una cuenta de Azure por el uso de Azure. Puede crear varias suscripciones para diferentes tipos de requisitos de facturación. Azure genera facturas e informes de facturación independientes para cada suscripción, de modo que pueda organizar y administrar los costos.

- **Límite de control de acceso**: Azure aplica las directivas de administración de acceso en el nivel de suscripción, por lo que puede crear suscripciones independientes para reflejar distintas estructuras organizativas. Por ejemplo, dentro de una empresa hay diferentes departamentos a los que se pueden aplicar directivas de suscripción de Azure distintas. Este modelo de facturación le permite administrar y controlar el acceso a los recursos que los usuarios aprovisionan con suscripciones específicas.
### Creación de una suscripción de Azure adicional

De forma similar al uso de grupos de recursos para separar los recursos por función o acceso, es posible que quiera crear suscripciones adicionales con fines de administración de recursos o facturación. Por ejemplo, puedes optar por crear suscripciones adicionales para separar lo siguiente:

- **Entornos**: puedes optar por crear suscripciones con el fin de configurar entornos independientes para el desarrollo y las pruebas, para seguridad o para aislar los datos por motivos de cumplimiento. Este diseño es especialmente útil porque el control de acceso a los recursos se produce en el nivel de suscripción.
- **Estructuras organizativas**: puedes crear suscripciones para reflejar las distintas estructuras organizativas. Por ejemplo, podría limitar un equipo a recursos de bajo costo, al tiempo que permite que el departamento de TI tenga un alcance completo. Este diseño permite administrar y controlar el acceso a los recursos que los usuarios aprovisionan en cada suscripción.
- **Facturación**: puedes crear suscripciones adicionales con fines de facturación. Dado que los costos se agregan primero en el nivel de suscripción, es posible que quieras crear suscripciones para administrar y realizar un seguimiento de los costos en función de sus necesidades. Por ejemplo, puede que quieras crear una suscripción para las cargas de trabajo de producción, y otra suscripción para las cargas de trabajo de desarrollo y pruebas.
### Grupos de administración de Azure

La última pieza es el grupo de administración. Los recursos se recopilan en grupos de recursos y los grupos de recursos se recopilan en suscripciones. Si acaba de empezar en Azure, podría parecer una jerarquía suficiente para mantener las cosas organizadas. Pero imagine que trabaja con varias aplicaciones, varios equipos de desarrollo, en varias zonas geográficas.

Si tienes muchas suscripciones, es posible que necesite una forma de administrar con eficacia el acceso, las directivas y el cumplimiento para esas suscripciones. Los grupos de administración de Azure proporcionan un nivel de ámbito por encima de las suscripciones. Las suscripciones se organizan en contenedores llamados grupos de administración, a los que se aplican condiciones de gobernanza. Todas las suscripciones de un grupo de administración heredan automáticamente las condiciones que tenga aplicadas, de la misma manera que los grupos de recursos heredan la configuración de las suscripciones y los recursos heredan de los grupos de recursos. Los grupos de administración proporcionan capacidad de administración de nivel empresarial a gran escala con independencia del tipo de suscripciones que tenga. Los grupos de administración se pueden anidar.

### Jerarquía de grupo de administración, suscripciones y grupo de recursos

Puede compilar una estructura flexible de grupos de administración y suscripciones para organizar los recursos en una jerarquía para una administración unificada de las directivas y el acceso. El diagrama siguiente muestra un ejemplo de creación de una jerarquía para la gobernanza mediante grupos de administración.

![[Pasted image 20231221190908.png]]

Algunos ejemplos de cómo podría usar los grupos de administración podrían ser los siguientes:

- **Crear una jerarquía que aplique una directiva**. Podría limitar las ubicaciones de las máquinas virtuales a la región Oeste de EE. UU. en un grupo denominado Producción. Esta directiva se heredará en todas las suscripciones descendientes de ese grupo de administración y se aplicará a todas las máquinas virtuales de esas suscripciones. El propietario de los recursos o las suscripciones no puede modificar esta directiva de seguridad, lo que permite una gobernanza mejorada.

- **Proporcionar acceso de usuario a varias suscripciones**. Al mover varias suscripciones bajo un grupo de administración, puede crear una asignación del control de acceso basado en roles (RBAC) en el grupo de administración. La asignación de RBAC de Azure en el nivel de grupo de administración significa que todos los grupos de administración secundaria, las suscripciones, los grupos de recursos y los recursos bajo ese grupo de administración también heredarían esos permisos. Una asignación en el grupo de administración puede permitir a los usuarios tener acceso a todo lo que necesitan, en lugar de crear scripts de Azure RBAC sobre las distintas suscripciones.

Datos importantes sobre los grupos de administración:

- Se admiten 10 000 grupos de administración en un único directorio.

- Un árbol de grupo de administración puede admitir hasta seis niveles de profundidad. Este límite no incluye el nivel raíz ni el nivel de suscripción.

- Cada grupo de administración y suscripción solo puede admitir un elemento primario.

## Ejercicio: Creación de un recurso de Azure

### Tarea 1: Creación de una máquina virtual

En esta tarea, creará una máquina virtual mediante Azure Portal.

1. Inicie sesión en [Azure Portal](https://portal.azure.com/learn.docs.microsoft.com).
    
2. Selecciona Crear un recurso > Proceso > Máquina virtual > Crear.
    
3. El panel Crear una máquina virtual se abre en la pestaña Aspectos básicos.
    
4. Comprueba o escribe los valores siguientes para cada opción. Si no se especifica un valor, deje el predeterminado.
    
    **Pestaña Aspectos básicos**

|**Configuración**|**Valor**|
|---|---|
|Suscripción|Suscripción de Concierge|
|Grupo de recursos|Seleccione el nombre del grupo de recursos que comienza con **learn**.|
|Nombre de la máquina virtual|my-VM|
|Region|Deje el valor predeterminado.|
|Opciones de disponibilidad|Deje el valor predeterminado.|
|Tipo de seguridad|Deje el valor predeterminado.|
|Imagen|Deje el valor predeterminado.|
|Arquitectura VM|Deje el valor predeterminado.|
|Ejecución de Azure Spot con descuento|No activado|
|Size|Deje el valor predeterminado.|
|Tipo de autenticación|Contraseña|
|Nombre de usuario|azureuser|
|Contraseña|Escribe una contraseña personalizada|
|Confirmación de la contraseña|Vuelve a escribir la contraseña personalizada|
|Puertos de entrada públicos|Ninguno|

### Tarea 2: Comprobación de los recursos creados

Una vez que se cree la implementación, puedes comprobar que Azure ha creado no solo una máquina virtual, sino todos los recursos asociados que necesita la máquina virtual.

1. Selecciona Inicio.
2. Selecciona Grupos de recursos.

Selecciona el grupo de recursos learn-4341860d-fe8b-41f5-b69e-45554d561751.

Deberías ver una lista de recursos en el grupo de recursos. La cuenta de almacenamiento y la red virtual están asociadas al espacio aislado de Learn. Pero el resto de los recursos se han creado al crear la máquina virtual. De manera predeterminada, Azure les ha asignado un nombre similar para ayudar con la asociación y los ha agrupado en el mismo grupo de recursos.

Felicidades. Has creado un recurso en Azure y ha tenido la oportunidad de ver cómo se agrupan los recursos en la creación.

### Limpieza

El espacio aislado limpia los recursos automáticamente cuando haya terminado con este módulo.

Al trabajar en una suscripción propia, se recomienda identificar al final de un proyecto si aún necesita los recursos creados. Los recursos que dejas en ejecución pueden costar dinero. Puede eliminar los recursos de forma individual o eliminar el grupo de recursos para eliminar todo el conjunto de recursos.


## Prueba de conocimientos

1. ¿En cuántos grupos de recursos puede estar un recurso al mismo tiempo?

<Details>
	<summary>Respuesta</summary>
	<p>Un recurso sólo puede estar en un grupo a la vez.</p>
</Details>

2. ¿Qué ocurre con los recursos de un grupo de recursos cuando se aplica una acción o configuración en el nivel de grupo de recursos?

<Details>
	<summary>Respuesta</summary>
	<p>Los recursos heredan los permisos de su grupo de recursos.</p>
</Details>

3. ¿Qué característica de Azure replica los recursos entre regiones que están al menos a 300 millas de distancia entre sí?

<Details>
	<summary>Respuesta</summary>
	<p>La mayoría de las regiones de Azure se emparejan con otra región de la misma zona geográfica (por ejemplo, EE. UU., Europa o Asia) que esté como mínimo a 300 millas de distancia.</p>
</Details>

## Resumen

En este módulo, ha obtenido información sobre la estructura física y de administración de Microsoft Azure. Se le han presentado la relación entre los centros de datos, las zonas de disponibilidad y las regiones. Ha explorado cómo la infraestructura admite las ventajas de la nube, como la alta disponibilidad y la confiabilidad. También ha obtenido información sobre la infraestructura de administración de Azure. Ha explorado cómo se relacionan los recursos y los grupos de recursos, y cómo las suscripciones y los grupos de administración pueden ayudar a administrar los recursos.

## Objetivos de aprendizaje

Ahora debería ser capaz de hacer lo siguiente:

- Describir las regiones de Azure, los pares de regiones y las regiones soberanas.
- Describir las zonas de disponibilidad.
- Describir los centros de datos de Azure.
- Describir los recursos y grupos de recursos de Azure.
- Describir las suscripciones.
- Describir los grupos de administración.
- Describir la jerarquía de grupos de recursos, suscripciones y grupos de administración.

# Descripción de los servicios de proceso y redes de Azure

## Introducción 

En este módulo, se le presentarán los servicios de proceso y redes de Azure. Obtendrá información sobre tres de las opciones de proceso (máquinas virtuales, contenedores y funciones de Azure). También obtendrá información sobre algunas de las características de red, como redes virtuales de Azure, Azure DNS y Azure ExpressRoute.

### Objetivos de aprendizaje

Después de completar este módulo, podrá:

- Comparar los tipos de proceso, incluidas las instancias de contenedor, las máquinas virtuales y las funciones.
- Describir las opciones de máquina virtual, incluidas las máquinas virtuales (VM), los conjuntos de escalado de máquinas virtuales, los conjuntos de disponibilidad de máquinas virtuales y Azure Virtual Desktop.
- Describir los recursos necesarios para las máquinas virtuales.
- Describir las opciones de hospedaje de aplicaciones, incluidos Azure Web Apps, contenedores y máquinas virtuales.
- Describir las redes virtuales, incluido el propósito de Azure Virtual Networks, las subredes virtuales de Azure, el emparejamiento, Azure DNS, VPN Gateway y ExpressRoute.
- Definir puntos de conexión públicos y privados.


## Descripción de Azure Virtual Machines

Con Azure Virtual Machines (VM), puedes crear y usar máquinas virtuales en la nube. Estas máquinas virtuales proporcionan una infraestructura como servicio (IaaS) en forma de un servidor virtualizado.

Las máquinas virtuales son una opción ideal cuando necesitas lo siguiente:

- Control total sobre el sistema operativo (SO).
- Capacidad de ejecutar software personalizado.
- Usar configuraciones de hospedaje personalizadas.

Una máquina virtual de Azure te ofrece la flexibilidad de la virtualización sin necesidad de adquirir y mantener el hardware físico que ejecuta la máquina virtual. Pero, como oferta de **IaaS**, tendrá que configurar, actualizar y mantener el software que se ejecuta en la máquina virtual.

Incluso puedes crear o usar una imagen ya creada para aprovisionar rápidamente máquinas virtuales. Al seleccionar una imagen de máquina virtual preconfigurada, podrás crear y aprovisionar una máquina virtual en cuestión de minutos. 

Una imagen es una plantilla que se usa para crear una máquina virtual y puede que ya incluya un sistema operativo y otro software, como herramientas de desarrollo o entornos de hospedaje web.

### Escalado de máquinas virtuales en Azure

Se pueden ejecutar máquinas virtuales únicas para pruebas, desarrollo o tareas secundarias. También se pueden agrupar las máquinas virtuales para proporcionar alta disponibilidad, escalabilidad y redundancia. Azure también puede administrar la agrupación de máquinas virtuales con características como conjuntos de escalado y conjuntos de disponibilidad.

### Conjuntos de escalado de máquinas virtuales

Los conjuntos de escalado de máquinas virtuales permiten crear y administrar un grupo de máquinas virtuales idénticas, de carga equilibrada.

Si simplemente ha creado varias máquinas virtuales con el mismo propósito, tendría que asegurarse de que todas se han configurado de forma idéntica y, después, configurar parámetros de enrutamiento de red para garantizar la eficacia. También tendría que supervisar el uso para determinar si necesita aumentar o disminuir el número de máquinas virtuales.

En su lugar, con los conjuntos de escalado de máquinas virtuales, Azure automatiza la mayor parte de ese trabajo. **Los conjuntos de escalado le permiten administrar, configurar y actualizar de forma centralizada** un gran número de máquinas virtuales en cuestión de minutos.

El número de instancias de máquina virtual puede aumentar o disminuir automáticamente según la demanda, o bien puede establecerlo para que se escale en función de una programación definida. Los conjuntos de escalado de máquinas virtuales también **implementan automáticamente un equilibrador de carga** para asegurarse de que los recursos se usan de forma eficaz. Con los conjuntos de escalado de máquinas virtuales, puede crear servicios a gran escala para áreas como proceso, macrodatos y cargas de trabajo de contenedor.


### Conjuntos de disponibilidad de máquinas virtuales

Los conjuntos de disponibilidad de máquinas virtuales son otra herramienta que le ayudará a crear un entorno más **resistente y de alta disponibilidad**. Los conjuntos de disponibilidad están diseñados para garantizar que las máquinas virtuales escalen las actualizaciones y tengan una conectividad de red y potencia variadas, lo que **evita que se pierdan** todas las máquinas virtuales **debido a un solo fallo de energía o de la red**.

Los conjuntos de disponibilidad lo hacen mediante la agrupación de las máquinas virtuales de dos maneras: dominio de actualización y dominio de error.

- **Dominio de actualización**: **agrupa las máquinas virtuales que se pueden reiniciar al mismo tiempo**. Esto le permite aplicar actualizaciones mientras sabe que solo una agrupación de dominios de actualización estará sin conexión a la vez. Se actualizarán todas las máquinas de un dominio de actualización. A un grupo de actualizaciones que realiza el proceso de actualización se le asigna un tiempo de 30 minutos de recuperación antes de que se inicie el mantenimiento en el siguiente dominio de actualización.

- **Dominio de error**: **agrupa las máquinas virtuales por fuente de alimentación común y conmutador de red**. De forma predeterminada, un conjunto de disponibilidad dividirá las máquinas virtuales en un máximo de tres dominios de error. Esto ayuda a **protegerse frente a un error de alimentación física o de la red** al tener las máquinas virtuales en dominios de error diferentes (por tanto, conectadas a diferentes recursos de alimentación y red).

Lo mejor de todo es que la configuración de un conjunto de disponibilidad no supone ningún costo adicional. Solo paga por las instancias de máquina virtual que cree.

### Ejemplos de cuándo usar máquinas virtuales

Algunos ejemplos comunes o casos de uso para máquinas virtuales son los siguientes:

- **Durante las pruebas y el desarrollo**. Las máquinas virtuales proporcionan una manera rápida y sencilla de crear distintas configuraciones de sistema operativo y de aplicación. El personal encargado de las pruebas y del desarrollo puede eliminar fácilmente las máquinas virtuales cuando ya no las necesite.

- **Al ejecutar aplicaciones en la nube**. La capacidad de ejecutar determinadas aplicaciones en la nube pública, en lugar de crear una infraestructura tradicional para ejecutarlas, puede proporcionar importantes beneficios económicos. Por ejemplo, es posible que una aplicación necesite controlar las fluctuaciones en la demanda. Apagar las máquinas virtuales cuando no las necesite o iniciarlas rápidamente para satisfacer un aumento repentino de la demanda significa que solo paga por los recursos que se usan.

- **Al ampliar el centro de datos a la nube**: una organización puede extender las capacidades de su propia red local mediante la creación de una red virtual en Azure y la adición de máquinas virtuales a esa red virtual. Las aplicaciones como SharePoint se pueden ejecutar en una máquina virtual de Azure en lugar de hacerlo de forma local. Esta disposición hace que sea más sencilla o menos costosa de implementar que en un entorno local.

- **Durante la recuperación ante desastres**: como sucede con la ejecución de ciertos tipos de aplicaciones en la nube y la ampliación de una red local a la nube, puede obtener un ahorro considerable en costos si se usa un enfoque basado en IaaS para la recuperación ante desastres. Si se produce un error en un centro de datos principal, puede crear máquinas virtuales que se ejecuten en Azure para ejecutar las aplicaciones críticas y, después, puede apagarlas cuando el centro de datos principal vuelva a estar operativo.

### Traslado a la nube con máquinas virtuales

Las máquinas virtuales también son una opción excelente cuando se mueve de un servidor físico a la nube (también conocido como Lift-and-shift). Puedes crear una imagen del servidor físico y hospedarla en una máquina virtual con pocos o ningún cambio. Al igual que un servidor local físico, debes mantener la máquina virtual: es responsable de mantener el sistema operativo y el software instalados.

### Recursos de máquina virtual

Al aprovisionar una máquina virtual, también tendrás la oportunidad de elegir los recursos asociados a esa máquina virtual, como los siguientes:

- Tamaño (propósito, número de núcleos de procesador y cantidad de RAM)
- Discos de almacenamiento (unidades de disco duro, unidades de estado sólido, etc.)
- Redes (red virtual, dirección IP pública y configuración de puertos)

## Ejercicio: Creación de una máquina virtual de Azure

En este ejercicio, crearemos una máquina virtual (VM) de Azure e instalar Nginx, un servidor web popular.

Por ejemplo, puedemos usar Azure Portal, la CLI de Azure, Azure PowerShell o una plantilla de Azure Resource Manager (ARM).

En este caso, usaremos la CLI de Azure.

### Tarea 1: Creación de una máquina virtual Linux e instalación de Nginx

Usa los siguientes comandos de la CLI de Azure para crear una máquina virtual Linux e instalar Nginx. Una vez creada la máquina virtual, usará la extensión de script personalizado para instalar Nginx. 

La extensión de script personalizado es una manera fácil de descargar y ejecutar scripts en máquinas virtuales de Azure. Es solo una de las numerosas formas de configurar el sistema después de que la máquina virtual esté en funcionamiento.

1. Desde Cloud Shell, ejecuta el siguiente comando `az vm create` para crear una máquina virtual Linux:
    
    
``` AZURE CLI
    az vm create \
      --resource-group [sandbox resource group name] \
      --name my-vm \
      --public-ip-sku Standard \
      --image Ubuntu2204 \
      --admin-username azureuser \
      --generate-ssh-keys
    
```
    
La máquina virtual tardará unos minutos en aparecer. Ha asignado el nombre **my-vm** a la máquina virtual. Use este nombre para hacer referencia a la máquina virtual en los pasos posteriores.

Te respondera con algo por el estilo

```AZURE CLI
{
  "fqdns": "",
  "id": "/subscriptions/c9c4cc6e-2adb-4f59-bbd1-4f966e547bd0/resourceGroups/learn-e0401e2d-376b-4ff8-a3a5-f09c2c30ea72/providers/Microsoft.Compute/virtualMachines/my-vm",
  "location": "westus",
  "macAddress": "00-0D-3A-36-DD-74",
  "powerState": "VM running",
  "privateIpAddress": "10.0.0.4",
  "publicIpAddress": "13.88.8.48",
  "resourceGroup": "learn-e0401e2d-376b-4ff8-a3a5-f09c2c30ea72",
  "zones": ""
}
```

guardaremos la ip publica para después

2. Ejecuta el siguiente comando `az vm extension set` para configurar Nginx en la máquina virtual:


``` AZURE CLI
az vm extension set \
  --resource-group [sandbox resource group name] \
  --vm-name my-vm \
  --name customScript \
  --publisher Microsoft.Azure.Extensions \
  --version 2.1 \
  --settings '{"fileUris":["https://raw.githubusercontent.com/MicrosoftDocs/mslearn-welcome-to-azure/master/configure-nginx.sh"]}' \
  --protected-settings '{"commandToExecute": "./configure-nginx.sh"}'
```

Nos respondera 

```AZURE CLI
{
  "autoUpgradeMinorVersion": true,
  "enableAutomaticUpgrade": null,
  "forceUpdateTag": null,
  "id": "/subscriptions/c9c4cc6e-2adb-4f59-bbd1-4f966e547bd0/resourceGroups/learn-e0401e2d-376b-4ff8-a3a5-f09c2c30ea72/providers/Microsoft.Compute/virtualMachines/my-vm/extensions/customScript",
  "instanceView": null,
  "location": "westus",
  "name": "customScript",
  "protectedSettings": null,
  "protectedSettingsFromKeyVault": null,
  "provisioningState": "Succeeded",
  "publisher": "Microsoft.Azure.Extensions",
  "resourceGroup": "learn-e0401e2d-376b-4ff8-a3a5-f09c2c30ea72",
  "settings": {
    "fileUris": [
      "https://raw.githubusercontent.com/MicrosoftDocs/mslearn-welcome-to-azure/master/configure-nginx.sh"
    ]
  },
  "suppressFailures": null,
  "tags": null,
  "type": "Microsoft.Compute/virtualMachines/extensions",
  "typeHandlerVersion": "2.1",
  "typePropertiesType": "customScript"
}
```


Este comando usa la extensión de script personalizado para ejecutar un script de Bash en la máquina virtual. El script se almacena en GitHub. Mientras se ejecuta el comando, puede optar por [examinar el script de Bash](https://raw.githubusercontent.com/MicrosoftDocs/mslearn-welcome-to-azure/master/configure-nginx.sh) en una pestaña independiente del explorador. 

Ahora nos conectaremos a la maquina virtual con, aqui usaremos la ip publica de nuestra VM

```BASH
ssh azureuser@13.88.8.48
```

Continuaremos con: 
	a. Ejecutar `sudo apt-get update` para descargar la información más reciente del paquete desde Internet. Este paso ayuda a garantizar que el siguiente comando pueda encontrar la versión más reciente del paquete Nginx.
	b. Instala Nginx con `sudo apt-get -y install nginx`.
	c. Establece la página principal, _/var/www/html/index.html_, para que imprima un mensaje de bienvenida en el que se incluye el nombre de host de la máquina virtual.

Para el punto c nos dirigimos a dicho directrio y ejecutaremos `cat index.html` y veremos que incluye el mensaje solicitado

##"" Continuar

Eso es todo para este ejercicio. El espacio aislado seguirá ejecutándose y volverás a este punto en algunas unidades para actualizar la configuración de red para que puedas acceder al sitio web.

## Descripción de Azure Virtual Desktop

Otro tipo de máquina virtual es Azure Virtual Desktop. Azure Virtual Desktop es un servicio de virtualización de escritorios y aplicaciones que se ejecuta en la nube. Te permite usar una versión hospedada en la nube de Windows desde cualquier ubicación. Azure Virtual Desktop funciona en dispositivos y sistemas operativos, y funciona con aplicaciones que puede usar para acceder a escritorios remotos o a la mayoría de exploradores modernos.

### Aumento de la seguridad

Azure Virtual Desktop proporciona administración centralizada de seguridad para los escritorios de los usuarios con Microsoft Entra ID. Puedes habilitar la autenticación multifactor para proteger los inicios de sesión de los usuarios. También puedes proteger el acceso a los datos mediante la asignación a los usuarios de controles de acceso basados en roles (RBAC) detallados.

Con Azure Virtual Desktop, los datos y las aplicaciones se separan del hardware local y El escritorio y las aplicaciones reales se ejecutan en la nube, lo que significa que se reduce el riesgo de dejar datos confidenciales en un dispositivo personal. Además, las sesiones de usuario están aisladas en entornos de una o varias sesiones.

### Implementación de sesión múltiple de Windows 10 o Windows 11

Azure Virtual Desktop permite usar la sesión múltiple de Windows 10 o Windows 11 Enterprise, el único sistema operativo basado en cliente de Windows que permite varios usuarios simultáneos en una sola máquina virtual. Azure Virtual Desktop también proporciona una experiencia más coherente gracias a la compatibilidad más amplia con las aplicaciones en comparación con los sistemas operativos basados en Windows Server.

### Implementación de sesión múltiple de Windows 10 o Windows 11

Azure Virtual Desktop permite usar la sesión múltiple de Windows 10 o Windows 11 Enterprise, el único sistema operativo basado en cliente de Windows que permite varios usuarios simultáneos en una sola máquina virtual. 


Azure Virtual Desktop también proporciona una experiencia más coherente gracias a la compatibilidad más amplia con las aplicaciones en comparación con los sistemas operativos basados en Windows Server.

## Descripción de contenedores de Azure

A pesar de que las máquinas virtuales son una excelente manera de reducir los costos frente a las inversiones que son necesarias para el hardware físico, están limitadas a un solo sistema operativo por máquina virtual. Los contenedores son una excelente opción si quiere ejecutar varias instancias de una aplicación en un solo equipo host.

### ¿Qué son los contenedores?

Los contenedores son un entorno de virtualización. Al igual que la ejecución de varias máquinas virtuales en un solo host físico, **se pueden ejecutar varios contenedores en un solo host físico o virtual**. 

A diferencia de las máquinas virtuales, no se administra el sistema operativo de un contenedor. Las máquinas virtuales son similares a una instancia de sistema operativo que se puede conectar y administrar.

**Los contenedores son ligeros y se han diseñado para crearse, escalarse horizontalmente y detenerse de forma dinámica.**

Los contenedores son ligeros y se han diseñado para crearse, escalarse horizontalmente y detenerse de forma dinámica. 

Es posible crear e implementar máquinas virtuales a medida que aumenta la demanda de aplicaciones, pero los contenedores son un método más ligero y ágil. 

Los contenedores están diseñados para permitirle responder a petición a los cambios. Con los contenedores puede reiniciar rápidamente en caso de bloqueo o interrupción del hardware.

### Comparación de máquinas virtuales con contenedores

|VM|Contenedores|
| - | - |
|Virtualizan el harware|virtualizan el sistema operativo|
|Control competo|Portabilidad y rendimiento|

### Azure Container Instances

Azure Container Instances ofrece la forma más rápida y sencilla de ejecutar un contenedor en Azure sin tener que administrar máquinas virtuales o adoptar servicios adicionales. Azure Container Instances es una oferta de plataforma como servicio (PaaS). Azure Container Instances le permite **cargar los contenedores**. A continuación, el servicio ejecutará los contenedores por usted.

### Azure Container Apps

Azure Container Apps son similares de muchas maneras a una instancia de contenedor. Le permiten ponerse en marcha de inmediato, quitan la pieza de administración de contenedores y son una oferta de PaaS. Container Apps tienen ventajas adicionales, como la capacidad de **incorporar el equilibrio de carga y el escalado**. Estas otras funciones le permiten ser más elásticas en el diseño.

### Azure Kubernetes Service

Azure Kubernetes Service (AKS) es un servicio de orquestación de contenedores. Un servicio de orquestación **administra el ciclo de vida de los contenedores**. Al implementar una flota de contenedores, AKS puede hacer que la administración de flotas sea más sencilla y eficaz.

### Uso de contenedores en las soluciones

Los contenedores se usan normalmente para **crear soluciones mediante una arquitectura de microservicios**. Esta arquitectura es donde se dividen las soluciones en **partes más pequeñas e independientes**. 

Por ejemplo, se puede dividir un sitio web en un contenedor que hospeda el front-end, otro que hospeda el back-end y un tercero para el almacenamiento. De esta forma, puede separar partes de la aplicación en secciones lógicas que se pueden mantener, escalar o actualizar independientemente.

Imagine que el back-end de su sitio web ha alcanzado el límite de su capacidad, pero el front-end y el almacenamiento no están sobrecargados. Con los contenedores puede escalar el back-end por separado para mejorar el rendimiento. Si algo requiere este cambio, también puede optar por cambiar el servicio de almacenamiento o modificar el front-end sin afectar a ninguno de los otros componentes.

## Descripción de Azure Functions

Azure Functions es una opción de **proceso sin servidor controlada por eventos** que no necesita el mantenimiento de máquinas virtuales ni contenedores. Si compila una aplicación mediante máquinas virtuales o contenedores, esos recursos deben "ejecutarse" para que la aplicación funcione. 

Con Azure Functions, un evento activa la función, lo que reduce la necesidad de mantener los recursos aprovisionados cuando no hay ningún evento.

### Informática sin servidor en Azure (serverless computing)

Aunque si se usen servidores, significa que nosotros no nos hacemos cargo de la responsabilidad de administrar los.

En otras palabras, es una abstracción de los servidores para que podamos despreocuparnos de la infraestructura y centrarnos en las tareas de desarrollo.


Hay tres grandes ventajas:

* No hay administración de infraestructura
* Escalabilidad
* Solo pagas por lo que usas

### Ventajas de Azure Functions

El uso de Azure Functions es idóneo si solo le interesa el código que ejecuta el servicio y no la infraestructura o la plataforma subyacente. Las funciones se usan normalmente cuando se debe realizar un trabajo en respuesta a un evento (a menudo a través de una solicitud REST), un temporizador o un mensaje de otro servicio de Azure, y cuando ese trabajo puede completarse rápidamente, en segundos o en menos tiempo.

Functions se **escala** automáticamente según la demanda, por lo que es una opción correcta cuando la demanda es variable.

Azure Functions ejecuta el código cuando se desencadena y desasigna recursos automáticamente cuando la función finaliza. En este modelo, solo se le cobrará por el tiempo de CPU usado mientras se ejecuta la función.

Las funciones pueden ser sin estado o con estado. Cuando son sin estado (valor predeterminado), se comportan como si se reiniciaran cada vez que responden a un evento.

Cuando son con estado (denominado Durable Functions), se pasa un contexto a través de la función para realizar el seguimiento antes de la actividad.

Las funciones son un componente clave de la informática sin servidor. También son una plataforma de proceso general para ejecutar cualquier tipo de código. Si cambian las necesidades de la aplicación del desarrollador, se puede implementar el proyecto en un entorno que no sea sin servidor. Esta flexibilidad permite administrar el escalado, ejecutar en redes virtuales e incluso aislar por completo las funciones.

## Descripción de las opciones de hospedaje de aplicaciones

Si necesita hospedar la aplicación en Azure, es posible que cambie inicialmente a una máquina virtual (VM) o a contenedores. 

Tanto las máquinas virtuales como los contenedores proporcionan excelentes soluciones de hospedaje. Las **máquinas virtuales proporcionan el máximo control** del entorno de hospedaje y le permiten configurarlo exactamente como desea. Las máquinas virtuales también pueden ser el método de hospedaje más conocido si no está familiarizado con la nube. **Los contenedores, con la capacidad de aislar y administrar individualmente** diferentes aspectos de la solución de hospedaje, también pueden ser una opción sólida y atractiva.

Hay otras opciones de hospedaje que puede usar con Azure, incluido Azure App Service.

### Azure App Service

App Service permite **crear y hospedar aplicaciones web, trabajos en segundo plano, back-ends móviles y API RESTful** en el lenguaje de programación que prefiera, sin tener que administrar la infraestructura. Ofrece **escalado automático y alta disponibilidad**. 

App Service admite Windows y Linux. Permite implementaciones automatizadas desde GitHub, Azure DevOps o cualquier repositorio Git para admitir un modelo de implementación continua.

Azure App Service es una opción de hospedaje sólida que puede usar para hospedar las aplicaciones en Azure. Azure App Service le permite **centrarse en la creación y el mantenimiento de la aplicación**, y Azure se centra en mantener el entorno en funcionamiento.

Azure App Service es un servicio basado en HTTP para hospedar aplicaciones web, API de REST y back-ends para dispositivos móviles. Admite varios lenguajes, incluidos .NET, .NET Core, Java, Ruby, Node.js, PHP o Python. También admite entornos de Windows y Linux.

### Tipos de servicios de aplicaciones

Con App Service, puede hospedar la mayoría de los estilos de servicio de aplicación más comunes, como los siguientes:

- Aplicaciones web
- Aplicaciones de API
- Trabajos web
- Aplicaciones móviles

App Service controla la mayoría de las decisiones sobre la infraestructura que se tratan en el hospedaje de aplicaciones accesibles desde la web:

- La implementación y administración se integran en la plataforma.
- Los puntos de conexión se pueden proteger.
- Los sitios se pueden escalar rápidamente para controlar cargas de tráfico elevado.
- El equilibrio de carga integrado y el administrador de tráfico proporcionan alta disponibilidad.

Todos estos estilos de aplicación se hospedan en la misma infraestructura y comparten estas ventajas. Esto convierte a App Service en la elección ideal para hospedar aplicaciones orientadas a la web.

#### Aplicaciones web

App Service incluye compatibilidad completa para hospedar aplicaciones web mediante ASP.NET, ASP.NET Core, Java, Ruby, Node.js, PHP o Python. Puede elegir Windows o Linux como sistema operativo del host.

#### Aplicaciones de API

Al igual que al hospedar un sitio web, puede compilar API web basadas en REST mediante el lenguaje y el marco que prefiera. Se obtiene compatibilidad completa con Swagger y la posibilidad de empaquetar y publicar la API en Azure Marketplace. Las aplicaciones producidas se pueden consumir desde cualquier cliente basado en HTTP o HTTPS.

#### Trabajos web

Se puede usar la característica WebJobs para ejecutar un programa (.exe, Java, PHP, Python o Node.js) o un script (.cmd, .bat, PowerShell o Bash) en el mismo contexto que una aplicación web, aplicación de API o aplicación móvil. Los puede programar o ejecutar un desencadenador. Los trabajos web suelen usarse para ejecutar tareas en segundo plano como parte de la lógica de aplicación.

#### Aplicaciones móviles

Use la característica Mobile Apps de App Service a fin de compilar rápidamente un back-end para aplicaciones iOS y Android. Con unos pocos clics en el Portal de Azure, puede realizar lo siguiente:

- Almacenar los datos de aplicaciones móviles en una base de datos SQL basada en la nube.
- Autenticar a clientes con proveedores sociales comunes, como MSA, Google, Twitter y Facebook.
- Enviar notificaciones de inserción.
- Ejecutar lógica de back-end personalizada en C# o Node.js.

En el lado de la aplicación móvil, hay compatibilidad con el SDK para aplicaciones nativas de iOS y Android, Xamarin y React.


## Descripción de las redes virtuales de Azure

**Las redes virtuales** y las subredes virtuales de Azure **permiten a los recursos de Azure**, como las máquinas virtuales, las aplicaciones web y las bases de datos, **comunicarse entre sí**, con los usuarios de Internet y con los equipos cliente en el entorno local. Una red de Azure se puede considerar una extensión de la red local con recursos que vinculan otros recursos de Azure.

Las redes virtuales de Azure proporcionan las importantes funcionalidades de red siguientes:

- Aislamiento y segmentación
- Comunicación con Internet
- Comunicación entre recursos de Azure
- Comunicación con los recursos locales
- Enrutamiento del tráfico de red
- Filtrado del tráfico de red
- Conexión de redes virtuales

Las redes virtuales de Azure admiten puntos de conexión públicos y privados para permitir la comunicación entre recursos externos o internos con otros recursos internos.

- Los puntos de conexión públicos tienen una dirección IP pública y son accesibles desde cualquier parte del mundo.
- Los puntos de conexión privados existen dentro de una red virtual y tienen una dirección IP privada en el espacio de direcciones de esa red virtual.
### Aislamiento y segmentación

La red virtual de Azure **permite crear varias redes virtuales aisladas**.

Al configurar una red virtual, se define un espacio de direcciones IP privadas con intervalos de direcciones IP públicas o privadas. El intervalo IP solo existe dentro de la red virtual y no es enrutable en Internet. 

Después, puede dividir ese espacio de direcciones IP en subredes y asignar parte del espacio de direcciones definido a cada subred con nombre.

Para la resolución de nombres, puede usar el servicio de resolución de nombres integrado en Azure. También puede configurar la red virtual para que use un servidor DNS interno o externo.

### Comunicación con Internet

Puede permitir conexiones entrantes desde Internet mediante la asignación de una dirección IP pública a un recurso de Azure o la colocación del recurso detrás de un equilibrador de carga público.

### Comunicación entre los recursos de Azure

Le interesará habilitar los recursos de Azure para que se comuniquen entre sí de forma segura. Puede hacerlo de dos maneras:

- **Las redes virtuales no solo pueden conectar máquinas virtuales**, sino también otros recursos de Azure, como App Service Environment para Power Apps, Azure Kubernetes Service y conjuntos de escalado de máquinas virtuales de Azure.

- **Los puntos de conexión de servicio se pueden conectar a otros tipos de recursos** de Azure, como cuentas de almacenamiento y bases de datos de Azure SQL. Este enfoque permite vincular varios recursos de Azure con las redes virtuales para mejorar la seguridad y proporcionar un enrutamiento óptimo entre los recursos.

### Comunicación con recursos locales

Las redes virtuales de Azure permiten vincular entre sí los recursos del entorno local y dentro de la suscripción de Azure. De hecho, puede crear una red que abarque tanto el entorno local como el entorno en la nube. Existen tres mecanismos para lograr esta conectividad:

- Las conexiones de red privada virtual de **punto a sitio** se establecen desde un equipo ajeno a la organización a la red corporativa. En este caso, el equipo cliente inicia una conexión VPN cifrada para conectarse a la red virtual de Azure.

- Las redes virtuales privadas de **sitio a sitio** vinculan el dispositivo o puerta de enlace de VPN local con la puerta de enlace de VPN de Azure en una red virtual. De hecho, puede parecer que los dispositivos de Azure están en la red local. La conexión se cifra y funciona a través de Internet.

- **Azure ExpressRoute** proporciona una conectividad privada dedicada a Azure que no se desplaza por Internet. ExpressRoute es útil para los entornos donde se necesita más ancho de banda e incluso mayores niveles de seguridad.

### Enrutamiento del tráfico de red

De forma predeterminada, Azure enruta el tráfico entre las subredes de todas las redes virtuales conectadas, las redes locales e Internet. También puede **controlar el enrutamiento** e invalidar esa configuración del siguiente modo:

- Las **tablas de rutas** permiten definir reglas sobre cómo se debe dirigir el tráfico. Puede crear tablas de rutas personalizadas que controlen cómo se enrutan los paquetes entre las subredes.
- El Protocolo de puerta de enlace de borde (**BGP**) funciona con puertas de enlace de VPN de Azure, Azure Route Server o Azure ExpressRoute para propagar las rutas BGP locales a las redes virtuales de Azure.

### Filtrado del tráfico de red

Las redes virtuales de Azure **permiten filtrar el tráfico** entre las subredes mediante los métodos siguientes:

- Los **grupos de seguridad** de red son recursos de Azure que pueden contener varias reglas de seguridad de entrada y salida. Estas reglas se pueden definir para permitir o bloquear el tráfico en función de factores como el protocolo, el puerto y las direcciones IP de destino y origen.

- Las aplicaciones virtuales de red son máquinas virtuales especializadas que se pueden comparar con un dispositivo de red protegido. Una **aplicación virtual** de red ejerce una **función de red determinada**, como ejecutar un firewall o realizar la optimización de la red de área extensa (WAN).

### Conexión de redes virtuales

Puede vincular redes virtuales entre sí mediante el emparejamiento de red virtual. **El emparejamiento permite que dos redes virtuales se conecten directamente entre sí**. El tráfico de red entre redes emparejadas es privado y se desplaza por la red troncal de Microsoft, y nunca entra en la red pública de Internet. El emparejamiento permite que los recursos de cada red virtual se comuniquen entre sí. Estas redes virtuales pueden estar en regiones distintas, lo que permite crear una red global interconectada con Azure.

Las rutas definidas por el usuario (**UDR**) permiten **controlar las tablas de enrutamiento** entre subredes dentro de una red virtual o entre redes virtuales. Esto permite un mayor control sobre el flujo de tráfico de red.

## Configuración del acceso de red

En este ejercicio, configurarás el acceso a la máquina virtual (VM) que has creado antes en este módulo.

	 Importante
	
	El espacio aislado de Microsoft Learn debe seguir en ejecución. Si se ha agotado el tiempo de espera del espacio aislado, tendrá que repetir el ejercicio anterior (**Ejercicio: Creación de una máquina virtual de Azure**).

Para comprobar que la máquina virtual que creó anteriormente todavía se está ejecutando, use el siguiente comando:

``` AZURE CLI
az vm list
```

Si recibe una respuesta vacía `[]`, debe completar de nuevo el primer ejercicio de este módulo. Si el resultado muestra la máquina virtual actual y su configuración, puede continuar.

En este momento, la máquina virtual que ha creado y en la que ha instalado Nginx no es accesible desde Internet.

Crearás un grupo de seguridad de red que lo cambiará y permitirá el acceso HTTP de entrada en el puerto 80.

### Tarea 1: Acceso al servidor web

En este procedimiento se obtiene la dirección IP de la máquina virtual y se intenta acceder a la página principal del servidor web.

1. Ejecute el siguiente comando `az vm list-ip-addresses` para obtener la dirección IP de la máquina virtual y almacenar el resultado como una variable de Bash:

```AZIRE CLI
IPADDRESS="$(az vm list-ip-addresses --resource-group [sandbox resource group name] --name my-vm --query "[].virtualMachine.network.publicIpAddresses[*].ipAddress" --output tsv)"
```

2. Ejecuta el siguiente comando `curl` para descargar la página principal:

``` BASH
    curl --connect-timeout 5 http://$IPADDRESS
```

El argumento `--connect-timeout` especifica que se conceden hasta cinco segundos para que se produzca la conexión. Después de cinco segundos, verás un mensaje de error que indica que se ha agotado el tiempo de espera de la conexión:
 
   
```Resultado
curl: (28) Connection timed out after 5001 milliseconds
```

Este mensaje significa que no se pudo acceder a la máquina virtual dentro del tiempo de espera.

3. Como paso opcional, intenta acceder al servidor web desde un explorador: 

	a. Ejecuta lo siguiente para imprimir la dirección IP de la máquina virtual en la consola:
	```BASH
	echo $IPADDRESS
```

	Verás una dirección IP, por ejemplo, 

	b. Copia en el portapapeles la dirección IP que vea.
    
	c. Abre una nueva pestaña del explorador y vayas al servidor web. Transcurridos unos instantes, verás que la conexión no se está produciendo.
    
    Si esperas a que se agote el tiempo de espera del explorador, verás algo parecido a esto:

	![[Pasted image 20231222173510.png]]

	d. Mantén la pestaña abierta para usarla más tarde.


### Tarea 2: Enumeración de las reglas de grupo de seguridad de red actuales

No se pudo acceder al servidor web. Para averiguar el motivo, vamos a examinar las reglas actuales del grupo de seguridad de red.

1. Ejecuta el siguiente comando `az network nsg list` para que muestre los grupos de seguridad de red asociados a la máquina virtual:

```AZURE CLI
az network nsg list --resource-group [sandbox resource group name] --query '[].name' --output tsv
```

Veremos lo siguiente:

```Resultado
my-vmNSG
```

Cada máquina virtual de Azure está asociada a, al menos, un grupo de seguridad de red. En este caso, Azure te creó un grupo de seguridad de red denominado_my-vmNSG_.

2. Ejecuta el siguiente comando `az network nsg rule list` mostrar las reglas asociadas al grupo de seguridad de red denominado _my-vmNSG_:

```AZURE CLI
az network nsg rule list --resource-group [sandbox resource group name] --nsg-name my-vmNSG
```

Verás un bloque grande de texto en formato JSON en la salida. En el paso siguiente, ejecutarás un comando similar que facilita la lectura de este resultado.

3. Ejecuta por segunda vez el comando `az network nsg rule list`. Esta vez, use el argumento `--query` para recuperar solo el nombre, la prioridad, los puertos afectados y el acceso (**Permitir** o **Denegar**) para cada regla. El argumento `--output` da formato a la salida como una tabla para que sea fácil de leer.

```AZURE CLI
az network nsg rule list --resource-group [sandbox resource group name] --nsg-name my-vmNSG --query '[].{Name:name, Priority:priority, Port:destinationPortRange, Access:access}' --output table
```

Verá lo siguiente:

```RESULTADO
Name              Priority    Port    Access
-----------------  ----------  ------  --------
default-allow-ssh  1000        22      Allow
```

Verás la regla predeterminada _default-allow-ssh_. Esta regla permite conexiones entrantes a través del puerto 22 (SSH). SSH (Secure Shell) es un protocolo que se usa en Linux para permitir que los administradores accedan al sistema de forma remota. La prioridad de esta entrada es 1000. Las reglas se procesan en orden de prioridad, donde los números más bajos se procesan antes que los números más altos.
    

De forma predeterminada, un grupo de seguridad de red de una máquina virtual de una máquina virtual Linux solo permite el acceso a la red en el puerto 22. Esto permite que los administradores accedan al sistema. También debe permitir las conexiones entrantes en el puerto 80, que permite el acceso a través de HTTP.


### Tarea 3: Creación de la regla de seguridad de red

En este caso, crearás una regla de seguridad de red que permita el acceso de entrada en el puerto 80 (HTTP).

1. Ejecute el siguiente comando `az network nsg rule create` para crear una regla denominada _allow-http_ que permita el acceso entrante en el puerto 80:

```AZURE LI
az network nsg rule create --resource-group [sandbox resource group name] --nsg-name my-vmNSG --name allow-http --protocol tcp --priority 100 --destination-port-range 80 --access Allow
```

Con fines de aprendizaje, aquí establecerá la prioridad en 100. En este caso, la prioridad no importa. Tendriás que tener en cuenta la prioridad si tuvieras intervalos de puertos superpuestos.
    
2. Para comprobar la configuración, ejecuta `az network nsg rule list` para ver la lista actualizada de reglas:

```AZURE CLI
az network nsg rule list --resource-group [sandbox resource group name] --nsg-name my-vmNSG --query '[].{Name:name, Priority:priority, Port:destinationPortRange, Access:access}' --output table
```

Verás las dos reglas, _default-allow-ssh_ y la nueva regla _allow-http_:

```RESULTADOS
Name              Priority    Port    Access
-----------------  ----------  ------  --------
default-allow-ssh  1000        22      Allow
allow-http        100        80      Allow
```

### Tarea 4: Nuevo acceso al servidor web

Ahora que has configurado el acceso de red al puerto 80, vamos a intentar acceder al servidor web una segunda vez.

1. Ejecuta el mismo comando `curl` que has ejecutado antes:

```BASH
curl --connect-timeout 5 http://$IPADDRESS
```

Veras lo siguiente

```HTML
<html><body><h2>Welcome to Azure! My name is my-vm.</h2></body></html>
```

2. Como paso opcional, actualiza la pestaña que apunta al servidor web.

Verá lo siguiente:

![[Pasted image 20231222173841.png]]

Buen trabajo. En la práctica, puedes crear un grupo de seguridad de red independiente que incluya las reglas de acceso de red entrantes y salientes que necesite. Si tienes varias máquinas virtuales que tienen el mismo propósito, puedes asignar ese grupo de seguridad de red a cada máquina virtual en el momento de crearla. Esta técnica permite controlar el acceso de red a varias máquinas virtuales en un único conjunto central de reglas.

### Limpieza

El espacio aislado limpia los recursos automáticamente cuando haya terminado con este módulo.

Al trabajar en una suscripción propia, se recomienda identificar al final de un proyecto si aún necesita los recursos creados. Los recursos que dejas en ejecución pueden costar dinero. Puede eliminar los recursos de forma individual o eliminar el grupo de recursos para eliminar todo el conjunto de recursos.

## Descripción de redes privadas virtuales de Azure

Una red privada virtual (VPN) **usa un túnel cifrado** en otra red. Normalmente, las VPN se implementan para conectar entre sí dos o más redes privadas de confianza a través de una red que no es de confianza (normalmente, la red pública de Internet). El tráfico se cifra mientras viaja por la red que no es de confianza para evitar ataques de interceptación o de otro tipo. Las VPN pueden permitir que las redes compartan información confidencial de forma segura.

### Puertas de enlace de VPN

Una puerta de enlace de VPN es un tipo de puerta de enlace de red virtual. Las instancias de Azure VPN Gateway se implementan en una subred dedicada de la red virtual y **permiten** la conectividad siguiente:

- Conectar los centros de datos locales a redes virtuales a través de una conexión de **sitio a sitio**.
- Conectar los dispositivos individuales a redes virtuales a través de una conexión de **punto a sitio**.
- Conectar las redes virtuales a otras redes virtuales a través de una **conexión entre redes**.

Todas las transferencias de datos se cifran en un túnel privado mientras atraviesan Internet. **Solo se puede implementar una única instancia de puerta de enlace de VPN en cada red virtual**. Sin embargo, se puede usar una puerta de enlace para conectarse a varias ubicaciones, que incluye otras redes virtuales o centros de datos locales.  

Al configurar una instancia de VPN Gateway, debe **especificar el tipo de red privada virtual**, es decir, **basada en directivas o basada en rutas**. La distinción principal entre estos dos tipos es cómo determinan qué tráfico necesita cifrado. En Azure, independientemente del tipo de red privada virtual, el método de autenticación que se emplea es una clave previamente compartida.

- Las instancias de VPN Gateway **basadas en directivas** **especifican de forma estática la dirección IP de los paquetes que se deben cifrar a través de cada túnel**. Este tipo de dispositivo evalúa cada paquete de datos en función de los conjuntos de direcciones IP para elegir el túnel a través del cual se va a enviar el paquete.

- En las puertas de enlace **basadas en rutas**, los túneles IPSec se modelan **como una interfaz de red o una interfaz de túnel virtual**. El enrutamiento IP (ya sean rutas estáticas o protocolos de enrutamiento dinámico) decide cuál de estas interfaces de túnel se va a usar al enviar cada paquete. Las redes privadas virtuales basadas en rutas son el **método preferido para conectar dispositivos locales**. Son más resistentes a los cambios de la topología, como la creación de subredes.

Si necesita alguno de los siguientes tipos de conectividad, use una instancia de VPN Gateway **basada en rutas**:

- Conexiones entre redes virtuales
- Conexiones de punto a sitio
- Conexiones de varios sitios
- Coexistencia con una puerta de enlace de Azure ExpressRoute

### Escenarios de alta disponibilidad

Si va a configurar una VPN para mantener la información segura, también querrá asegurarse de que es una configuración de VPN de alta disponibilidad y tolerante a errores. Hay varias maneras de maximizar la resistencia de la puerta de enlace de VPN.

#### Configuración de activo-en espera

De forma predeterminada, las instancias de VPN Gateway se implementan como dos instancias en una configuración de activo-en espera, incluso si solo ve un recurso de VPN Gateway en Azure. **Cuando el mantenimiento planeado o la interrupción imprevista afectan a la instancia activa, la instancia en espera asume de forma automática la responsabilidad** de las conexiones sin ninguna intervención del usuario. Durante esta conmutación por error, las conexiones se interrumpen, pero por lo general se restauran en cuestión de segundos si se trata del mantenimiento planeado y en un plazo de 90 segundos en el caso de las interrupciones imprevistas.

#### Activo/activo

Al incorporar compatibilidad con el protocolo de enrutamiento de BGP, también puede implementar puertas de enlace VPN en una configuración del tipo activo/activo. En esta configuración, **se asigna una IP pública única a cada instancia. Después, se crean túneles independientes desde el dispositivo local a cada dirección IP**. Se puede ampliar la alta disponibilidad mediante la implementación de un dispositivo VPN local adicional.

#### Conmutación por error de ExpressRoute

Otra opción de alta disponibilidad consiste en configurar una **instancia de VPN Gateway como una ruta segura de conmutación por error para las conexiones ExpressRoute**. Los circuitos ExpressRoute tienen resistencia integrada. Sin embargo, no son inmunes a los problemas físicos que afectan a los cables que entregan conectividad ni a las interrupciones que afectan a la ubicación completa de ExpressRoute. En escenarios de alta disponibilidad, en los que existe un riesgo asociado a una interrupción de un circuito ExpressRoute, también puede aprovisionar una instancia de VPN Gateway que usa Internet como un método alternativo de conectividad. De este modo, puede garantizar que siempre haya una conexión a las redes virtuales.

#### Puertas de enlace con redundancia de zona

En las regiones que admiten zonas de disponibilidad, se pueden implementar puertas de enlace VPN y ExpressRoute en una configuración con redundancia de zona. Esta configuración aporta una mayor disponibilidad, escalabilidad y resistencia a las puertas de enlace de red virtual. Implementar puertas de enlace en Azure Availability Zones **separa de forma física y lógica las puertas de enlace dentro de una región**, al mismo tiempo que protege la conectividad de red local en Azure de errores de nivel de zona. Estas puertas de enlace requieren diferentes referencias de almacén (SKU) de puerta de enlace y usan direcciones IP públicas estándar en lugar de direcciones IP públicas básicas.

## Describir Azure ExpressRoute

ExpressRoute le **permite ampliar las redes locales** a la nube de Microsoft mediante una conexión privada con la ayuda de un proveedor de conectividad. Esta conexión se denomina circuito ExpressRoute. Con ExpressRoute, puede establecer conexiones con servicios en la nube de Microsoft, como Microsoft Azure y Microsoft 365. Esto le permite conectar oficinas, centros de datos u otras instalaciones a la nube de Microsoft. Cada ubicación tendría su propio circuito ExpressRoute.

La conectividad puede ser desde una red de conectividad universal (IP VPN), una red Ethernet de punto a punto o una conexión cruzada virtual a través de un proveedor de conectividad en una instalación de ubicación compartida. Las conexiones de ExpressRoute no pasan por la red pública de Internet. Esto permite a las conexiones de ExpressRoute ofrecer más confiabilidad, más velocidad, latencia coherentes y mayor seguridad que las conexiones normales a través de Internet.

### Características y ventajas de ExpressRoute

El uso de ExpressRoute como servicio de conexión entre Azure y las redes locales tiene varias ventajas.

- Conectividad a servicios en la nube de Microsoft en todas las regiones dentro de la región geopolítica.
- Conectividad global a los servicios de Microsoft en todas las regiones con Global Reach de ExpressRoute.
- Enrutamiento dinámico entre la red y Microsoft a través del Protocolo de puerta de enlace de borde (BGP).
- Redundancia integrada en todas las ubicaciones de configuración entre pares para una mayor confiabilidad.

#### Conectividad con los Servicios en la nube de Microsoft

ExpressRoute permite el acceso directo a los siguientes servicios en todas las regiones:

- Microsoft Office 365
- Microsoft Dynamics 365
- Servicios de proceso de Azure, como Azure Virtual Machines
- Servicios en la nube de Azure, como Azure Cosmos DB y Azure Storage

#### Conectividad global

Puede permitir que Global Reach de ExpressRoute intercambie datos entre los sitios locales si conecta los diferentes circuitos ExpressRoute. Por ejemplo, supongamos que tiene una oficina en Asia y un centro de datos en Europa, ambos con circuitos ExpressRoute que los conectan a la red de Microsoft. Puede usar Global Reach de ExpressRoute para conectar esas dos instalaciones, lo que les **permite comunicarse sin transferir datos a través de la red pública de Internet**.

#### Enrutamiento dinámico

ExpressRoute usa el BGP. BGP se usa para **intercambiar rutas entre las redes locales y los recursos que se ejecutan en Azure**. Este protocolo permite el enrutamiento dinámico entre la red local y los servicios que se ejecutan en la nube de Microsoft.

#### Redundancia integrada

Cada proveedor de conectividad usa dispositivos redundantes para garantizar que las conexiones establecidas con Microsoft tengan **alta disponibilidad**. Puede configurar varios circuitos para complementar esta característica.

### Modelos de conectividad de ExpressRoute

ExpressRoute admite cuatro modelos que puede usar para conectar la red local con la nube de Microsoft:

- Ubicación de CloudExchange
- Conexión Ethernet de punto a punto
- Conexión universal
- Directamente desde sitios de ExpressRoute

#### Ubicación compartida en un intercambio en la nube

La ubicación conjunta hace referencia al centro de datos, la oficina u otras instalaciones que se encuentran físicamente en un intercambio en la nube, como un ISP. Si la instalación tiene la ubicación compartida en un intercambio en la nube, puede solicitar una conexión cruzada virtual a la nube de Microsoft.

#### Conexión Ethernet de punto a punto

La conexión Ethernet de punto a punto hace referencia al uso de una conexión punto a punto para conectar la instalación a la nube de Microsoft.

#### Redes universales

Con la conectividad universal, puede integrar la red de área extensa (WAN) con Azure si proporciona conexiones a las oficinas y los centros de datos. Azure se integra con la conexión WAN para proporcionarle una conexión, como la que tendría entre el centro de datos y las sucursales.

#### Directamente desde sitios de ExpressRoute

Puede conectarse directamente a la red global de Microsoft en una ubicación de emparejamiento distribuida estratégicamente por todo el mundo. ExpressRoute Direct proporciona conectividad dual de 100 Gbps o 10 Gbps, que es compatible con la conectividad activa/activa a escala.

### Consideraciones sobre la seguridad

Con ExpressRoute **los datos no viajan a través de la red pública de Internet** y, por tanto, no se exponen a los posibles riesgos asociados a las comunicaciones de Internet. ExpressRoute es una conexión privada de la infraestructura local a la infraestructura de Azure. Incluso si tiene una conexión ExpressRoute, las consultas de DNS, la comprobación de la lista de revocación de certificados y las solicitudes de Azure Content Delivery Network se siguen enviando a través de la red pública de Internet.

## Describir Azure DNS

Azure DNS es un servicio de hospedaje para dominios DNS que ofrece resolución de nombres mediante la infraestructura de Microsoft Azure. Al hospedar dominios en Azure, puede administrar los registros DNS con las mismas credenciales, API, herramientas y facturación que con los demás servicios de Azure.

### Ventajas de Azure DNS

Azure DNS saca provecho del ámbito y la escala de Microsoft Azure para proporcionar numerosas ventajas, incluidas las siguientes:

- Confiabilidad y rendimiento
- Seguridad
- Facilidad de uso
- Redes virtuales personalizables
- Registros de alias

#### Confiabilidad y rendimiento

Los dominios DNS de Azure DNS se hospedan en la red global de servidores de nombres DNS de Azure, y proporcionan resistencia y alta disponibilidad. Azure DNS usa **redes de difusión por proximidad** para que el servidor DNS más próximo disponible responda a cada consulta de DNS para proporcionar un mejor rendimiento y una mayor disponibilidad para el dominio.

#### Seguridad

Azure DNS se basa en Azure Resource Manager, que proporciona características tales como:

- Control de acceso basado en rol de Azure (**Azure RBAC**) para controlar quién accede a acciones específicas en la organización.
- **Registros de actividad**: para supervisar cómo un usuario de su organización modificó un recurso o para encontrar errores al solucionar problemas.
- **Bloqueo de recursos** para bloquear una suscripción, un grupo de recursos o un recurso. Los bloqueos impiden que otros usuarios de la organización eliminen o modifiquen de forma accidental recursos críticos.

#### Facilidad de uso

Azure DNS puede administrar registros DNS para los servicios de Azure y también proporciona el servicio de nombres de dominio para los recursos externos. Azure DNS está integrado en Azure Portal y usa las mismas credenciales, la misma facturación y el mismo contrato de soporte técnico que los demás servicios de Azure.

Como Azure DNS se ejecuta en Azure, significa que puede administrar los dominios y registros con Azure Portal, cmdlets de Azure PowerShell y la CLI de Azure multiplataforma. Las aplicaciones que requieren la administración automática de DNS se pueden integrar con el servicio mediante las API REST y los SDK.