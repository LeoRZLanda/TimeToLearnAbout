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

### Introducción a las cuentas de Azure

Para crear y usar los servicios de Azure, necesita una suscripción de Azure. Al completar los módulos de Microsoft Learn, la mayoría de las veces se crea una suscripción temporal de forma automática, que se ejecuta en un entorno denominado espacio aislado de Microsoft Learn.


#### Creación de una cuenta de Azure

Para comprar el acceso a Azure directamente desde Microsoft, regístrate en el sitio web de Azure o hágalo a través de un representante de Microsoft. 

#### ¿Qué es la cuenta gratuita de Azure?

La cuenta gratuita de Azure incluye lo siguiente:

- Acceso gratuito a productos populares de Azure durante 12 meses.
- Crédito para gastar durante los primeros 30 días.
- Acceso a más de 25 productos que siempre son gratuitos.

La [cuenta gratuita de Azure](https://azure.microsoft.com/free) ofrece de forma óptima un comienzo y exploración a los nuevos usuarios. Para registrarse, necesita un número de teléfono, una tarjeta de crédito y una cuenta de Microsoft o de GitHub. La información de la tarjeta de crédito solo se usa para la verificación de identidad. No se te cobrará por ningún servicio hasta que actualice a una suscripción de pago.

#### ¿Qué es la cuenta de estudiante gratuita de Azure?

La oferta de la cuenta de estudiante gratuita de Azure incluye lo siguiente:

- Acceso gratuito a determinados servicios de Azure durante 12 meses.
- Un crédito para usar en los primeros 12 meses.
- Acceso gratuito a determinadas herramientas de desarrollo de software.

La [cuenta de estudiante gratuita de Azure](https://azure.microsoft.com/free/students/) es una oferta para estudiantes que ofrece 100 USD de crédito y herramientas de desarrollo gratuitas. Además, puedes registrarse sin tarjeta de crédito.


#### ¿Qué es el espacio aislado de Microsoft Learn?

En muchos de los ejercicios de Learn se usa una tecnología denominada espacio aislado, que crea una suscripción temporal que se agrega a la cuenta de Azure. Esta suscripción temporal le permite crear recursos de Azure para la duración de un módulo de Learn. Learn limpia de forma automática los recursos temporales una vez que hayas completado el módulo.

Cuando completas un módulo de Learn, puedes usar la suscripción personal para finalizar los ejercicios que incluye. Pero el espacio aislado es el método preferido, ya que permite crear y probar recursos de Azure sin costo alguno.

### Ejercicio: Exploración del espacio aislado de Learn

#### Tarea 1: Uso de la CLI de PowerShell

Una vez que se inicie el espacio aislado, la mitad de la pantalla estará en modo de interfaz de línea de comandos (CLI) de PowerShell. Si estás familiarizado con PowerShell, puedes administrar el entorno de Azure mediante comandos de PowerShell.

Usa el comando Get-date de PowerShell para obtener la fecha y hora actuales.

``` AZURE CLI
Get-date
```

La mayoría de los comandos específicos de Azure comenzarán con las letras az. El comando Get-date que acaba de ejecutar es específico de PowerShell. Ahora se probará un comando de Azure para comprobar qué versión de la CLI usa en este momento.

``` AZURE CLI
az version
```

#### Tarea 2: Uso de la CLI de BASH

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

#### Tarea 3: Uso del modo interactivo de la CLI de Azure

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

#### Tarea 4: Uso de Azure Portal

Durante los ejercicios del espacio aislado también tendrás la opción de usar Azure Portal. Debes usar el vínculo proporcionado en el ejercicio para acceder a Azure Portal. Con el vínculo proporcionado, en lugar de abrir el portal personalmente, se asegura de usar la suscripción correcta y poder completar el ejercicio como quieras.

Inicie sesión en [Azure Portal](https://portal.azure.com/learn.docs.microsoft.com) para comprobar la interfaz web de Azure. Una vez en el portal, puedes ver todos los servicios que ofrece Azure, así como echar un vistazo a los grupos de recursos, etc.

#### Continuar

Todo listo por ahora. Volverás a este espacio aislado más adelante en este módulo y crearás un recurso real de Azure.

### Descripción de la infraestructura física de Azure

A lo largo del recorrido con Microsoft Azure, escucharás y usarás términos como regiones, zonas de disponibilidad, recursos, suscripciones, etc. Este módulo se centra en los principales componentes arquitectónicos de Azure. Los componentes arquitectónicos principales de Azure se pueden dividir en dos grandes grupos: la infraestructura física y la infraestructura de administración.

La infraestructura física de Azure comienza con los centros de datos. Conceptualmente, los centros de datos son iguales que los grandes centros de datos corporativos. Son instalaciones con recursos organizados en bastidores, con potencia dedicada, refrigeración e infraestructura de red.

#### Regions

Una región es un área geográfica del planeta que contiene al menos un centro de datos, aunque podrían ser varios cercanos y conectados mediante una red de baja latencia. Azure asigna y controla los recursos de forma inteligente dentro de cada región para garantizar que las cargas de trabajo están bien compensadas.

Al implementar un recurso en Azure, es habitual tener que elegir la región en la que quiere que se implemente el recurso.

#### Availability Zones

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

#### Pares de región

La mayoría de las regiones de Azure se emparejan con otra región de la misma zona geográfica (por ejemplo, EE. UU., Europa o Asia) que se encuentre como mínimo a 500 km de distancia. Este enfoque permite la replicación de recursos en una zona geográfica que ayuda a reducir la probabilidad de que se produzcan interrupciones provocadas por eventos como desastres naturales, disturbios sociales, cortes del suministro eléctrico o interrupciones de la red física que afecten a una región completa. Por ejemplo, si una región de un par se ve afectada por un desastre natural, los servicios conmutarán por error automáticamente a la otra región de su par de regiones.

Algunos pares de regiones de ejemplo en Azure son Oeste de EE. UU. y Este de EE. UU., y Sudeste Asiático y Asia Pacífico. Como las dos regiones están directamente conectadas y lo suficientemente lejos como para estar aisladas contra desastres regionales, puede usarlas para proporcionar redundancia de datos y servicios de confianza.

##### Ventajas adicionales de los pares de región:

- Si se produce una gran interrupción de Azure, se da prioridad a una región de cada par para asegurarse de que al menos una se restaure lo más rápido posible para las aplicaciones hospedadas en ese par de regiones.

- Las actualizaciones planeadas de Azure se implementan una a una en regiones emparejadas para minimizar el tiempo de inactividad y el riesgo de interrupción de la aplicación.

- Los datos siguen residiendo en la misma zona geográfica que su pareja (excepto Sur de Brasil) con fines de jurisdicción fiscal y de aplicación de la ley.
#### Regiones soberanas

Además de las regiones normales, Azure también tiene regiones soberanas. Las regiones soberanas son instancias de Azure que están aisladas de la instancia principal de Azure. Es posible que tenga que usar una región soberana con fines legales o de cumplimiento.

Entre las regiones soberanas de Azure se incluyen las siguientes:

- US DoD (centro), US Gov Virginia, US Gov Iowa y más: Estas regiones son instancias físicas y lógicas con aislamiento de red de Azure para asociados y agencias de la administración pública de EE. UU. Estos centros de datos están operados por personal estadounidense sometido a evaluación e incluyen certificaciones de cumplimiento adicionales.
- Este de China, Norte de China y más: Estas regiones están disponibles gracias a una asociación exclusiva entre Microsoft y 21Vianet, por la cual Microsoft no mantiene directamente los centros de datos.

### Descripción de la infraestructura de administración de Azure

La infraestructura de administración incluye recursos de Azure y grupos de recursos, suscripciones y cuentas. Comprender la organización jerárquica le ayudará a planear los proyectos y productos dentro de Azure.

#### Recursos y grupos de recursos de Azure

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


#### Suscripciones de Azure

En Azure, las suscripciones son una unidad de administración, facturación y escala. Al igual que los grupos de recursos son una manera de organizar lógicamente los recursos, las suscripciones permiten organizar lógicamente los grupos de recursos y facilitar la facturación.

Una cuenta puede tener varias suscripciones, pero solo es obligatorio tener una. En una cuenta de varias suscripciones, puede usarlas para configurar diferentes modelos de facturación y aplicar diferentes directivas de administración de acceso. 

Hay dos tipos de límites de suscripción que puede utilizar:

- **Límite de facturación**: Este tipo de suscripción determina cómo se factura una cuenta de Azure por el uso de Azure. Puede crear varias suscripciones para diferentes tipos de requisitos de facturación. Azure genera facturas e informes de facturación independientes para cada suscripción, de modo que pueda organizar y administrar los costos.

- **Límite de control de acceso**: Azure aplica las directivas de administración de acceso en el nivel de suscripción, por lo que puede crear suscripciones independientes para reflejar distintas estructuras organizativas. Por ejemplo, dentro de una empresa hay diferentes departamentos a los que se pueden aplicar directivas de suscripción de Azure distintas. Este modelo de facturación le permite administrar y controlar el acceso a los recursos que los usuarios aprovisionan con suscripciones específicas.
#### Creación de una suscripción de Azure adicional

De forma similar al uso de grupos de recursos para separar los recursos por función o acceso, es posible que quiera crear suscripciones adicionales con fines de administración de recursos o facturación. Por ejemplo, puedes optar por crear suscripciones adicionales para separar lo siguiente:

- **Entornos**: puedes optar por crear suscripciones con el fin de configurar entornos independientes para el desarrollo y las pruebas, para seguridad o para aislar los datos por motivos de cumplimiento. Este diseño es especialmente útil porque el control de acceso a los recursos se produce en el nivel de suscripción.
- **Estructuras organizativas**: puedes crear suscripciones para reflejar las distintas estructuras organizativas. Por ejemplo, podría limitar un equipo a recursos de bajo costo, al tiempo que permite que el departamento de TI tenga un alcance completo. Este diseño permite administrar y controlar el acceso a los recursos que los usuarios aprovisionan en cada suscripción.
- **Facturación**: puedes crear suscripciones adicionales con fines de facturación. Dado que los costos se agregan primero en el nivel de suscripción, es posible que quieras crear suscripciones para administrar y realizar un seguimiento de los costos en función de sus necesidades. Por ejemplo, puede que quieras crear una suscripción para las cargas de trabajo de producción, y otra suscripción para las cargas de trabajo de desarrollo y pruebas.
#### Grupos de administración de Azure

La última pieza es el grupo de administración. Los recursos se recopilan en grupos de recursos y los grupos de recursos se recopilan en suscripciones. Si acaba de empezar en Azure, podría parecer una jerarquía suficiente para mantener las cosas organizadas. Pero imagine que trabaja con varias aplicaciones, varios equipos de desarrollo, en varias zonas geográficas.

Si tienes muchas suscripciones, es posible que necesite una forma de administrar con eficacia el acceso, las directivas y el cumplimiento para esas suscripciones. Los grupos de administración de Azure proporcionan un nivel de ámbito por encima de las suscripciones. Las suscripciones se organizan en contenedores llamados grupos de administración, a los que se aplican condiciones de gobernanza. Todas las suscripciones de un grupo de administración heredan automáticamente las condiciones que tenga aplicadas, de la misma manera que los grupos de recursos heredan la configuración de las suscripciones y los recursos heredan de los grupos de recursos. Los grupos de administración proporcionan capacidad de administración de nivel empresarial a gran escala con independencia del tipo de suscripciones que tenga. Los grupos de administración se pueden anidar.

#### Jerarquía de grupo de administración, suscripciones y grupo de recursos

Puede compilar una estructura flexible de grupos de administración y suscripciones para organizar los recursos en una jerarquía para una administración unificada de las directivas y el acceso. El diagrama siguiente muestra un ejemplo de creación de una jerarquía para la gobernanza mediante grupos de administración.

![[Pasted image 20231221190908.png]]

Algunos ejemplos de cómo podría usar los grupos de administración podrían ser los siguientes:

- **Crear una jerarquía que aplique una directiva**. Podría limitar las ubicaciones de las máquinas virtuales a la región Oeste de EE. UU. en un grupo denominado Producción. Esta directiva se heredará en todas las suscripciones descendientes de ese grupo de administración y se aplicará a todas las máquinas virtuales de esas suscripciones. El propietario de los recursos o las suscripciones no puede modificar esta directiva de seguridad, lo que permite una gobernanza mejorada.

- **Proporcionar acceso de usuario a varias suscripciones**. Al mover varias suscripciones bajo un grupo de administración, puede crear una asignación del control de acceso basado en roles (RBAC) en el grupo de administración. La asignación de RBAC de Azure en el nivel de grupo de administración significa que todos los grupos de administración secundaria, las suscripciones, los grupos de recursos y los recursos bajo ese grupo de administración también heredarían esos permisos. Una asignación en el grupo de administración puede permitir a los usuarios tener acceso a todo lo que necesitan, en lugar de crear scripts de Azure RBAC sobre las distintas suscripciones.

Datos importantes sobre los grupos de administración:

- Se admiten 10 000 grupos de administración en un único directorio.

- Un árbol de grupo de administración puede admitir hasta seis niveles de profundidad. Este límite no incluye el nivel raíz ni el nivel de suscripción.

- Cada grupo de administración y suscripción solo puede admitir un elemento primario.

### Ejercicio: Creación de un recurso de Azure

#### Tarea 1: Creación de una máquina virtual

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

#### Tarea 2: Comprobación de los recursos creados

Una vez que se cree la implementación, puedes comprobar que Azure ha creado no solo una máquina virtual, sino todos los recursos asociados que necesita la máquina virtual.

1. Selecciona Inicio.
2. Selecciona Grupos de recursos.

Selecciona el grupo de recursos learn-4341860d-fe8b-41f5-b69e-45554d561751.

Deberías ver una lista de recursos en el grupo de recursos. La cuenta de almacenamiento y la red virtual están asociadas al espacio aislado de Learn. Pero el resto de los recursos se han creado al crear la máquina virtual. De manera predeterminada, Azure les ha asignado un nombre similar para ayudar con la asociación y los ha agrupado en el mismo grupo de recursos.

Felicidades. Has creado un recurso en Azure y ha tenido la oportunidad de ver cómo se agrupan los recursos en la creación.

#### Limpieza

El espacio aislado limpia los recursos automáticamente cuando haya terminado con este módulo.

Al trabajar en una suscripción propia, se recomienda identificar al final de un proyecto si aún necesita los recursos creados. Los recursos que dejas en ejecución pueden costar dinero. Puede eliminar los recursos de forma individual o eliminar el grupo de recursos para eliminar todo el conjunto de recursos.


### Prueba de conocimientos

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

### Resumen

En este módulo, ha obtenido información sobre la estructura física y de administración de Microsoft Azure. Se le han presentado la relación entre los centros de datos, las zonas de disponibilidad y las regiones. Ha explorado cómo la infraestructura admite las ventajas de la nube, como la alta disponibilidad y la confiabilidad. También ha obtenido información sobre la infraestructura de administración de Azure. Ha explorado cómo se relacionan los recursos y los grupos de recursos, y cómo las suscripciones y los grupos de administración pueden ayudar a administrar los recursos.

#### Objetivos de aprendizaje

Ahora debería ser capaz de hacer lo siguiente:

- Describir las regiones de Azure, los pares de regiones y las regiones soberanas.
- Describir las zonas de disponibilidad.
- Describir los centros de datos de Azure.
- Describir los recursos y grupos de recursos de Azure.
- Describir las suscripciones.
- Describir los grupos de administración.
- Describir la jerarquía de grupos de recursos, suscripciones y grupos de administración.

## Descripción de los servicios de proceso y redes de Azure

### Introducción 

En este módulo, se le presentarán los servicios de proceso y redes de Azure. Obtendrá información sobre tres de las opciones de proceso (máquinas virtuales, contenedores y funciones de Azure). También obtendrá información sobre algunas de las características de red, como redes virtuales de Azure, Azure DNS y Azure ExpressRoute.

#### Objetivos de aprendizaje

Después de completar este módulo, podrá:

- Comparar los tipos de proceso, incluidas las instancias de contenedor, las máquinas virtuales y las funciones.
- Describir las opciones de máquina virtual, incluidas las máquinas virtuales (VM), los conjuntos de escalado de máquinas virtuales, los conjuntos de disponibilidad de máquinas virtuales y Azure Virtual Desktop.
- Describir los recursos necesarios para las máquinas virtuales.
- Describir las opciones de hospedaje de aplicaciones, incluidos Azure Web Apps, contenedores y máquinas virtuales.
- Describir las redes virtuales, incluido el propósito de Azure Virtual Networks, las subredes virtuales de Azure, el emparejamiento, Azure DNS, VPN Gateway y ExpressRoute.
- Definir puntos de conexión públicos y privados.


### Descripción de Azure Virtual Machines

Con Azure Virtual Machines (VM), puedes crear y usar máquinas virtuales en la nube. Estas máquinas virtuales proporcionan una infraestructura como servicio (IaaS) en forma de un servidor virtualizado.

Las máquinas virtuales son una opción ideal cuando necesitas lo siguiente:

- Control total sobre el sistema operativo (SO).
- Capacidad de ejecutar software personalizado.
- Usar configuraciones de hospedaje personalizadas.

Una máquina virtual de Azure te ofrece la flexibilidad de la virtualización sin necesidad de adquirir y mantener el hardware físico que ejecuta la máquina virtual. Pero, como oferta de **IaaS**, tendrá que configurar, actualizar y mantener el software que se ejecuta en la máquina virtual.

Incluso puedes crear o usar una imagen ya creada para aprovisionar rápidamente máquinas virtuales. Al seleccionar una imagen de máquina virtual preconfigurada, podrás crear y aprovisionar una máquina virtual en cuestión de minutos. 

Una imagen es una plantilla que se usa para crear una máquina virtual y puede que ya incluya un sistema operativo y otro software, como herramientas de desarrollo o entornos de hospedaje web.

#### Escalado de máquinas virtuales en Azure

Se pueden ejecutar máquinas virtuales únicas para pruebas, desarrollo o tareas secundarias. También se pueden agrupar las máquinas virtuales para proporcionar alta disponibilidad, escalabilidad y redundancia. Azure también puede administrar la agrupación de máquinas virtuales con características como conjuntos de escalado y conjuntos de disponibilidad.

##### Conjuntos de escalado de máquinas virtuales

Los conjuntos de escalado de máquinas virtuales permiten crear y administrar un grupo de máquinas virtuales idénticas, de carga equilibrada.

Si simplemente ha creado varias máquinas virtuales con el mismo propósito, tendría que asegurarse de que todas se han configurado de forma idéntica y, después, configurar parámetros de enrutamiento de red para garantizar la eficacia. También tendría que supervisar el uso para determinar si necesita aumentar o disminuir el número de máquinas virtuales.

En su lugar, con los conjuntos de escalado de máquinas virtuales, Azure automatiza la mayor parte de ese trabajo. **Los conjuntos de escalado le permiten administrar, configurar y actualizar de forma centralizada** un gran número de máquinas virtuales en cuestión de minutos.

El número de instancias de máquina virtual puede aumentar o disminuir automáticamente según la demanda, o bien puede establecerlo para que se escale en función de una programación definida. Los conjuntos de escalado de máquinas virtuales también **implementan automáticamente un equilibrador de carga** para asegurarse de que los recursos se usan de forma eficaz. Con los conjuntos de escalado de máquinas virtuales, puede crear servicios a gran escala para áreas como proceso, macrodatos y cargas de trabajo de contenedor.


##### Conjuntos de disponibilidad de máquinas virtuales

Los conjuntos de disponibilidad de máquinas virtuales son otra herramienta que le ayudará a crear un entorno más **resistente y de alta disponibilidad**. Los conjuntos de disponibilidad están diseñados para garantizar que las máquinas virtuales escalen las actualizaciones y tengan una conectividad de red y potencia variadas, lo que **evita que se pierdan** todas las máquinas virtuales **debido a un solo fallo de energía o de la red**.

Los conjuntos de disponibilidad lo hacen mediante la agrupación de las máquinas virtuales de dos maneras: dominio de actualización y dominio de error.

- **Dominio de actualización**: **agrupa las máquinas virtuales que se pueden reiniciar al mismo tiempo**. Esto le permite aplicar actualizaciones mientras sabe que solo una agrupación de dominios de actualización estará sin conexión a la vez. Se actualizarán todas las máquinas de un dominio de actualización. A un grupo de actualizaciones que realiza el proceso de actualización se le asigna un tiempo de 30 minutos de recuperación antes de que se inicie el mantenimiento en el siguiente dominio de actualización.

- **Dominio de error**: **agrupa las máquinas virtuales por fuente de alimentación común y conmutador de red**. De forma predeterminada, un conjunto de disponibilidad dividirá las máquinas virtuales en un máximo de tres dominios de error. Esto ayuda a **protegerse frente a un error de alimentación física o de la red** al tener las máquinas virtuales en dominios de error diferentes (por tanto, conectadas a diferentes recursos de alimentación y red).

Lo mejor de todo es que la configuración de un conjunto de disponibilidad no supone ningún costo adicional. Solo paga por las instancias de máquina virtual que cree.

#### Ejemplos de cuándo usar máquinas virtuales

Algunos ejemplos comunes o casos de uso para máquinas virtuales son los siguientes:

- **Durante las pruebas y el desarrollo**. Las máquinas virtuales proporcionan una manera rápida y sencilla de crear distintas configuraciones de sistema operativo y de aplicación. El personal encargado de las pruebas y del desarrollo puede eliminar fácilmente las máquinas virtuales cuando ya no las necesite.

- **Al ejecutar aplicaciones en la nube**. La capacidad de ejecutar determinadas aplicaciones en la nube pública, en lugar de crear una infraestructura tradicional para ejecutarlas, puede proporcionar importantes beneficios económicos. Por ejemplo, es posible que una aplicación necesite controlar las fluctuaciones en la demanda. Apagar las máquinas virtuales cuando no las necesite o iniciarlas rápidamente para satisfacer un aumento repentino de la demanda significa que solo paga por los recursos que se usan.

- **Al ampliar el centro de datos a la nube**: una organización puede extender las capacidades de su propia red local mediante la creación de una red virtual en Azure y la adición de máquinas virtuales a esa red virtual. Las aplicaciones como SharePoint se pueden ejecutar en una máquina virtual de Azure en lugar de hacerlo de forma local. Esta disposición hace que sea más sencilla o menos costosa de implementar que en un entorno local.

- **Durante la recuperación ante desastres**: como sucede con la ejecución de ciertos tipos de aplicaciones en la nube y la ampliación de una red local a la nube, puede obtener un ahorro considerable en costos si se usa un enfoque basado en IaaS para la recuperación ante desastres. Si se produce un error en un centro de datos principal, puede crear máquinas virtuales que se ejecuten en Azure para ejecutar las aplicaciones críticas y, después, puede apagarlas cuando el centro de datos principal vuelva a estar operativo.

#### Traslado a la nube con máquinas virtuales

Las máquinas virtuales también son una opción excelente cuando se mueve de un servidor físico a la nube (también conocido como Lift-and-shift). Puedes crear una imagen del servidor físico y hospedarla en una máquina virtual con pocos o ningún cambio. Al igual que un servidor local físico, debes mantener la máquina virtual: es responsable de mantener el sistema operativo y el software instalados.

#### Recursos de máquina virtual

Al aprovisionar una máquina virtual, también tendrás la oportunidad de elegir los recursos asociados a esa máquina virtual, como los siguientes:

- Tamaño (propósito, número de núcleos de procesador y cantidad de RAM)
- Discos de almacenamiento (unidades de disco duro, unidades de estado sólido, etc.)
- Redes (red virtual, dirección IP pública y configuración de puertos)

### Ejercicio: Creación de una máquina virtual de Azure

En este ejercicio, crearemos una máquina virtual (VM) de Azure e instalar Nginx, un servidor web popular.

Por ejemplo, puedemos usar Azure Portal, la CLI de Azure, Azure PowerShell o una plantilla de Azure Resource Manager (ARM).

En este caso, usaremos la CLI de Azure.

#### Tarea 1: Creación de una máquina virtual Linux e instalación de Nginx

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

### Descripción de Azure Virtual Desktop

Otro tipo de máquina virtual es Azure Virtual Desktop. Azure Virtual Desktop es un servicio de virtualización de escritorios y aplicaciones que se ejecuta en la nube. **Te permite usar una versión hospedada en la nube de Windows desde cualquier ubicación.** Azure Virtual Desktop funciona en dispositivos y sistemas operativos, y funciona con aplicaciones que puede usar para acceder a escritorios remotos o a la mayoría de exploradores modernos.

#### Aumento de la seguridad

Azure Virtual Desktop proporciona administración centralizada de seguridad para los escritorios de los usuarios con Microsoft Entra ID. Puedes habilitar la autenticación multifactor para proteger los inicios de sesión de los usuarios. También puedes proteger el acceso a los datos mediante la asignación a los usuarios de controles de acceso basados en roles (RBAC) detallados.

Con Azure Virtual Desktop, los datos y las aplicaciones se separan del hardware local y El escritorio y las aplicaciones reales se ejecutan en la nube, lo que significa que se reduce el riesgo de dejar datos confidenciales en un dispositivo personal. Además, las sesiones de usuario están aisladas en entornos de una o varias sesiones.

#### Implementación de sesión múltiple de Windows 10 o Windows 11

Azure Virtual Desktop permite usar la sesión múltiple de Windows 10 o Windows 11 Enterprise, el único sistema operativo basado en cliente de Windows que permite varios usuarios simultáneos en una sola máquina virtual. Azure Virtual Desktop también proporciona una experiencia más coherente gracias a la compatibilidad más amplia con las aplicaciones en comparación con los sistemas operativos basados en Windows Server.

#### Implementación de sesión múltiple de Windows 10 o Windows 11

Azure Virtual Desktop permite usar la sesión múltiple de Windows 10 o Windows 11 Enterprise, el único sistema operativo basado en cliente de Windows que permite varios usuarios simultáneos en una sola máquina virtual. 


Azure Virtual Desktop también proporciona una experiencia más coherente gracias a la compatibilidad más amplia con las aplicaciones en comparación con los sistemas operativos basados en Windows Server.

### Descripción de contenedores de Azure

A pesar de que las máquinas virtuales son una excelente manera de reducir los costos frente a las inversiones que son necesarias para el hardware físico, están limitadas a un solo sistema operativo por máquina virtual. Los contenedores son una excelente opción si quiere ejecutar varias instancias de una aplicación en un solo equipo host.

#### ¿Qué son los contenedores?

Los contenedores son un entorno de virtualización. Al igual que la ejecución de varias máquinas virtuales en un solo host físico, **se pueden ejecutar varios contenedores en un solo host físico o virtual**. 

A diferencia de las máquinas virtuales, no se administra el sistema operativo de un contenedor. Las máquinas virtuales son similares a una instancia de sistema operativo que se puede conectar y administrar.

**Los contenedores son ligeros y se han diseñado para crearse, escalarse horizontalmente y detenerse de forma dinámica.**

Los contenedores son ligeros y se han diseñado para crearse, escalarse horizontalmente y detenerse de forma dinámica. 

Es posible crear e implementar máquinas virtuales a medida que aumenta la demanda de aplicaciones, pero los contenedores son un método más ligero y ágil. 

Los contenedores están diseñados para permitirle responder a petición a los cambios. Con los contenedores puede reiniciar rápidamente en caso de bloqueo o interrupción del hardware.

#### Comparación de máquinas virtuales con contenedores

|VM|Contenedores|
| - | - |
|Virtualizan el harware|virtualizan el sistema operativo|
|Control competo|Portabilidad y rendimiento|

#### Azure Container Instances

Azure Container Instances ofrece la forma más rápida y sencilla de ejecutar un contenedor en Azure sin tener que administrar máquinas virtuales o adoptar servicios adicionales. Azure Container Instances es una oferta de plataforma como servicio (PaaS). Azure Container Instances le permite **cargar los contenedores**. A continuación, el servicio ejecutará los contenedores por usted.

#### Azure Container Apps

Azure Container Apps son similares de muchas maneras a una instancia de contenedor. Le permiten ponerse en marcha de inmediato, quitan la pieza de administración de contenedores y son una oferta de PaaS. Container Apps tienen ventajas adicionales, como la capacidad de **incorporar el equilibrio de carga y el escalado**. Estas otras funciones le permiten ser más elásticas en el diseño.

#### Azure Kubernetes Service

Azure Kubernetes Service (AKS) es un servicio de orquestación de contenedores. Un servicio de orquestación **administra el ciclo de vida de los contenedores**. Al implementar una flota de contenedores, AKS puede hacer que la administración de flotas sea más sencilla y eficaz.

#### Uso de contenedores en las soluciones

Los contenedores se usan normalmente para **crear soluciones mediante una arquitectura de microservicios**. Esta arquitectura es donde se dividen las soluciones en **partes más pequeñas e independientes**. 

Por ejemplo, se puede dividir un sitio web en un contenedor que hospeda el front-end, otro que hospeda el back-end y un tercero para el almacenamiento. De esta forma, puede separar partes de la aplicación en secciones lógicas que se pueden mantener, escalar o actualizar independientemente.

Imagine que el back-end de su sitio web ha alcanzado el límite de su capacidad, pero el front-end y el almacenamiento no están sobrecargados. Con los contenedores puede escalar el back-end por separado para mejorar el rendimiento. Si algo requiere este cambio, también puede optar por cambiar el servicio de almacenamiento o modificar el front-end sin afectar a ninguno de los otros componentes.

### Descripción de Azure Functions

Azure Functions es una opción de **proceso sin servidor controlada por eventos** que no necesita el mantenimiento de máquinas virtuales ni contenedores. Si compila una aplicación mediante máquinas virtuales o contenedores, esos recursos deben "ejecutarse" para que la aplicación funcione. 

Con Azure Functions, un evento activa la función, lo que reduce la necesidad de mantener los recursos aprovisionados cuando no hay ningún evento.

#### Informática sin servidor en Azure (serverless computing)

Aunque si se usen servidores, significa que nosotros no nos hacemos cargo de la responsabilidad de administrar los.

En otras palabras, es una abstracción de los servidores para que podamos despreocuparnos de la infraestructura y centrarnos en las tareas de desarrollo.


Hay tres grandes ventajas:

* No hay administración de infraestructura
* Escalabilidad
* Solo pagas por lo que usas

#### Ventajas de Azure Functions

El uso de Azure Functions es idóneo si solo le interesa el código que ejecuta el servicio y no la infraestructura o la plataforma subyacente. Las funciones se usan normalmente cuando se debe realizar un trabajo en respuesta a un evento (a menudo a través de una solicitud REST), un temporizador o un mensaje de otro servicio de Azure, y cuando ese trabajo puede completarse rápidamente, en segundos o en menos tiempo.

Functions se **escala** automáticamente según la demanda, por lo que es una opción correcta cuando la demanda es variable.

Azure Functions ejecuta el código cuando se desencadena y desasigna recursos automáticamente cuando la función finaliza. En este modelo, solo se le cobrará por el tiempo de CPU usado mientras se ejecuta la función.

Las funciones pueden ser sin estado o con estado. Cuando son sin estado (valor predeterminado), se comportan como si se reiniciaran cada vez que responden a un evento.

Cuando son con estado (denominado Durable Functions), se pasa un contexto a través de la función para realizar el seguimiento antes de la actividad.

Las funciones son un componente clave de la informática sin servidor. También son una plataforma de proceso general para ejecutar cualquier tipo de código. Si cambian las necesidades de la aplicación del desarrollador, se puede implementar el proyecto en un entorno que no sea sin servidor. Esta flexibilidad permite administrar el escalado, ejecutar en redes virtuales e incluso aislar por completo las funciones.

### Descripción de las opciones de hospedaje de aplicaciones

Si necesita hospedar la aplicación en Azure, es posible que cambie inicialmente a una máquina virtual (VM) o a contenedores. 

Tanto las máquinas virtuales como los contenedores proporcionan excelentes soluciones de hospedaje. Las **máquinas virtuales proporcionan el máximo control** del entorno de hospedaje y le permiten configurarlo exactamente como desea. Las máquinas virtuales también pueden ser el método de hospedaje más conocido si no está familiarizado con la nube. **Los contenedores, con la capacidad de aislar y administrar individualmente** diferentes aspectos de la solución de hospedaje, también pueden ser una opción sólida y atractiva.

Hay otras opciones de hospedaje que puede usar con Azure, incluido Azure App Service.

#### Azure App Service

App Service permite **crear y hospedar aplicaciones web, trabajos en segundo plano, back-ends móviles y API RESTful** en el lenguaje de programación que prefiera, sin tener que administrar la infraestructura. Ofrece **escalado automático y alta disponibilidad**. 

App Service admite Windows y Linux. Permite implementaciones automatizadas desde GitHub, Azure DevOps o cualquier repositorio Git para admitir un modelo de implementación continua.

Azure App Service es una opción de hospedaje sólida que puede usar para hospedar las aplicaciones en Azure. Azure App Service le permite **centrarse en la creación y el mantenimiento de la aplicación**, y Azure se centra en mantener el entorno en funcionamiento.

Azure App Service es un servicio basado en HTTP para hospedar aplicaciones web, API de REST y back-ends para dispositivos móviles. Admite varios lenguajes, incluidos .NET, .NET Core, Java, Ruby, Node.js, PHP o Python. También admite entornos de Windows y Linux.

#### Tipos de servicios de aplicaciones

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

##### Aplicaciones web

App Service incluye compatibilidad completa para hospedar aplicaciones web mediante ASP.NET, ASP.NET Core, Java, Ruby, Node.js, PHP o Python. Puede elegir Windows o Linux como sistema operativo del host.

##### Aplicaciones de API

Al igual que al hospedar un sitio web, puede compilar API web basadas en REST mediante el lenguaje y el marco que prefiera. Se obtiene compatibilidad completa con Swagger y la posibilidad de empaquetar y publicar la API en Azure Marketplace. Las aplicaciones producidas se pueden consumir desde cualquier cliente basado en HTTP o HTTPS.

##### Trabajos web

Se puede usar la característica WebJobs para ejecutar un programa (.exe, Java, PHP, Python o Node.js) o un script (.cmd, .bat, PowerShell o Bash) en el mismo contexto que una aplicación web, aplicación de API o aplicación móvil. Los puede programar o ejecutar un desencadenador. Los trabajos web suelen usarse para ejecutar tareas en segundo plano como parte de la lógica de aplicación.

##### Aplicaciones móviles

Use la característica Mobile Apps de App Service a fin de compilar rápidamente un back-end para aplicaciones iOS y Android. Con unos pocos clics en el Portal de Azure, puede realizar lo siguiente:

- Almacenar los datos de aplicaciones móviles en una base de datos SQL basada en la nube.
- Autenticar a clientes con proveedores sociales comunes, como MSA, Google, Twitter y Facebook.
- Enviar notificaciones de inserción.
- Ejecutar lógica de back-end personalizada en C# o Node.js.

En el lado de la aplicación móvil, hay compatibilidad con el SDK para aplicaciones nativas de iOS y Android, Xamarin y React.


### Descripción de las redes virtuales de Azure

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
#### Aislamiento y segmentación

La red virtual de Azure **permite crear varias redes virtuales aisladas**.

Al configurar una red virtual, se define un espacio de direcciones IP privadas con intervalos de direcciones IP públicas o privadas. El intervalo IP solo existe dentro de la red virtual y no es enrutable en Internet. 

Después, puede dividir ese espacio de direcciones IP en subredes y asignar parte del espacio de direcciones definido a cada subred con nombre.

Para la resolución de nombres, puede usar el servicio de resolución de nombres integrado en Azure. También puede configurar la red virtual para que use un servidor DNS interno o externo.

#### Comunicación con Internet

Puede permitir conexiones entrantes desde Internet mediante la asignación de una dirección IP pública a un recurso de Azure o la colocación del recurso detrás de un equilibrador de carga público.

#### Comunicación entre los recursos de Azure

Le interesará habilitar los recursos de Azure para que se comuniquen entre sí de forma segura. Puede hacerlo de dos maneras:

- **Las redes virtuales no solo pueden conectar máquinas virtuales**, sino también otros recursos de Azure, como App Service Environment para Power Apps, Azure Kubernetes Service y conjuntos de escalado de máquinas virtuales de Azure.

- **Los puntos de conexión de servicio se pueden conectar a otros tipos de recursos** de Azure, como cuentas de almacenamiento y bases de datos de Azure SQL. Este enfoque permite vincular varios recursos de Azure con las redes virtuales para mejorar la seguridad y proporcionar un enrutamiento óptimo entre los recursos.

#### Comunicación con recursos locales

Las redes virtuales de Azure permiten vincular entre sí los recursos del entorno local y dentro de la suscripción de Azure. De hecho, puede crear una red que abarque tanto el entorno local como el entorno en la nube. Existen tres mecanismos para lograr esta conectividad:

- Las conexiones de red privada virtual de **punto a sitio** se establecen desde un equipo ajeno a la organización a la red corporativa. En este caso, el equipo cliente inicia una conexión VPN cifrada para conectarse a la red virtual de Azure.

- Las redes virtuales privadas de **sitio a sitio** vinculan el dispositivo o puerta de enlace de VPN local con la puerta de enlace de VPN de Azure en una red virtual. De hecho, puede parecer que los dispositivos de Azure están en la red local. La conexión se cifra y funciona a través de Internet.

- **Azure ExpressRoute** proporciona una conectividad privada dedicada a Azure que no se desplaza por Internet. ExpressRoute es útil para los entornos donde se necesita más ancho de banda e incluso mayores niveles de seguridad.

#### Enrutamiento del tráfico de red

De forma predeterminada, Azure enruta el tráfico entre las subredes de todas las redes virtuales conectadas, las redes locales e Internet. También puede **controlar el enrutamiento** e invalidar esa configuración del siguiente modo:

- Las **tablas de rutas** permiten definir reglas sobre cómo se debe dirigir el tráfico. Puede crear tablas de rutas personalizadas que controlen cómo se enrutan los paquetes entre las subredes.
- El Protocolo de puerta de enlace de borde (**BGP**) funciona con puertas de enlace de VPN de Azure, Azure Route Server o Azure ExpressRoute para propagar las rutas BGP locales a las redes virtuales de Azure.

#### Filtrado del tráfico de red

Las redes virtuales de Azure **permiten filtrar el tráfico** entre las subredes mediante los métodos siguientes:

- Los **grupos de seguridad** de red son recursos de Azure que pueden contener varias reglas de seguridad de entrada y salida. Estas reglas se pueden definir para permitir o bloquear el tráfico en función de factores como el protocolo, el puerto y las direcciones IP de destino y origen.

- Las aplicaciones virtuales de red son máquinas virtuales especializadas que se pueden comparar con un dispositivo de red protegido. Una **aplicación virtual** de red ejerce una **función de red determinada**, como ejecutar un firewall o realizar la optimización de la red de área extensa (WAN).

#### Conexión de redes virtuales

Puede vincular redes virtuales entre sí mediante el emparejamiento de red virtual. **El emparejamiento permite que dos redes virtuales se conecten directamente entre sí**. El tráfico de red entre redes emparejadas es privado y se desplaza por la red troncal de Microsoft, y nunca entra en la red pública de Internet. El emparejamiento permite que los recursos de cada red virtual se comuniquen entre sí. Estas redes virtuales pueden estar en regiones distintas, lo que permite crear una red global interconectada con Azure.

Las rutas definidas por el usuario (**UDR**) permiten **controlar las tablas de enrutamiento** entre subredes dentro de una red virtual o entre redes virtuales. Esto permite un mayor control sobre el flujo de tráfico de red.

### Ejercicio: Configuración del acceso de red

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

#### Tarea 1: Acceso al servidor web

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


#### Tarea 2: Enumeración de las reglas de grupo de seguridad de red actuales

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


#### Tarea 3: Creación de la regla de seguridad de red

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

#### Tarea 4: Nuevo acceso al servidor web

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

#### Limpieza

El espacio aislado limpia los recursos automáticamente cuando haya terminado con este módulo.

Al trabajar en una suscripción propia, se recomienda identificar al final de un proyecto si aún necesita los recursos creados. Los recursos que dejas en ejecución pueden costar dinero. Puede eliminar los recursos de forma individual o eliminar el grupo de recursos para eliminar todo el conjunto de recursos.

### Descripción de redes privadas virtuales de Azure

Una red privada virtual (VPN) **usa un túnel cifrado** en otra red. Normalmente, las VPN se implementan para conectar entre sí dos o más redes privadas de confianza a través de una red que no es de confianza (normalmente, la red pública de Internet). El tráfico se cifra mientras viaja por la red que no es de confianza para evitar ataques de interceptación o de otro tipo. Las VPN pueden permitir que las redes compartan información confidencial de forma segura.

#### Puertas de enlace de VPN

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

#### Escenarios de alta disponibilidad

Si va a configurar una VPN para mantener la información segura, también querrá asegurarse de que es una configuración de VPN de alta disponibilidad y tolerante a errores. Hay varias maneras de maximizar la resistencia de la puerta de enlace de VPN.

##### Configuración de activo-en espera

De forma predeterminada, las instancias de VPN Gateway se implementan como dos instancias en una configuración de activo-en espera, incluso si solo ve un recurso de VPN Gateway en Azure. **Cuando el mantenimiento planeado o la interrupción imprevista afectan a la instancia activa, la instancia en espera asume de forma automática la responsabilidad** de las conexiones sin ninguna intervención del usuario. Durante esta conmutación por error, las conexiones se interrumpen, pero por lo general se restauran en cuestión de segundos si se trata del mantenimiento planeado y en un plazo de 90 segundos en el caso de las interrupciones imprevistas.

##### Activo/activo

Al incorporar compatibilidad con el protocolo de enrutamiento de BGP, también puede implementar puertas de enlace VPN en una configuración del tipo activo/activo. En esta configuración, **se asigna una IP pública única a cada instancia. Después, se crean túneles independientes desde el dispositivo local a cada dirección IP**. Se puede ampliar la alta disponibilidad mediante la implementación de un dispositivo VPN local adicional.

##### Conmutación por error de ExpressRoute

Otra opción de alta disponibilidad consiste en configurar una **instancia de VPN Gateway como una ruta segura de conmutación por error para las conexiones ExpressRoute**. Los circuitos ExpressRoute tienen resistencia integrada. Sin embargo, no son inmunes a los problemas físicos que afectan a los cables que entregan conectividad ni a las interrupciones que afectan a la ubicación completa de ExpressRoute. En escenarios de alta disponibilidad, en los que existe un riesgo asociado a una interrupción de un circuito ExpressRoute, también puede aprovisionar una instancia de VPN Gateway que usa Internet como un método alternativo de conectividad. De este modo, puede garantizar que siempre haya una conexión a las redes virtuales.

##### Puertas de enlace con redundancia de zona

En las regiones que admiten zonas de disponibilidad, se pueden implementar puertas de enlace VPN y ExpressRoute en una configuración con redundancia de zona. Esta configuración aporta una mayor disponibilidad, escalabilidad y resistencia a las puertas de enlace de red virtual. Implementar puertas de enlace en Azure Availability Zones **separa de forma física y lógica las puertas de enlace dentro de una región**, al mismo tiempo que protege la conectividad de red local en Azure de errores de nivel de zona. Estas puertas de enlace requieren diferentes referencias de almacén (SKU) de puerta de enlace y usan direcciones IP públicas estándar en lugar de direcciones IP públicas básicas.

### Describir Azure ExpressRoute

ExpressRoute le **permite ampliar las redes locales** a la nube de Microsoft mediante una conexión privada con la ayuda de un proveedor de conectividad. Esta conexión se denomina circuito ExpressRoute. Con ExpressRoute, puede establecer conexiones con servicios en la nube de Microsoft, como Microsoft Azure y Microsoft 365. Esto le permite conectar oficinas, centros de datos u otras instalaciones a la nube de Microsoft. Cada ubicación tendría su propio circuito ExpressRoute.

La conectividad puede ser desde una red de conectividad universal (IP VPN), una red Ethernet de punto a punto o una conexión cruzada virtual a través de un proveedor de conectividad en una instalación de ubicación compartida. Las conexiones de ExpressRoute no pasan por la red pública de Internet. Esto permite a las conexiones de ExpressRoute ofrecer más confiabilidad, más velocidad, latencia coherentes y mayor seguridad que las conexiones normales a través de Internet.

#### Características y ventajas de ExpressRoute

El uso de ExpressRoute como servicio de conexión entre Azure y las redes locales tiene varias ventajas.

- Conectividad a servicios en la nube de Microsoft en todas las regiones dentro de la región geopolítica.
- Conectividad global a los servicios de Microsoft en todas las regiones con Global Reach de ExpressRoute.
- Enrutamiento dinámico entre la red y Microsoft a través del Protocolo de puerta de enlace de borde (BGP).
- Redundancia integrada en todas las ubicaciones de configuración entre pares para una mayor confiabilidad.

##### Conectividad con los Servicios en la nube de Microsoft

ExpressRoute permite el acceso directo a los siguientes servicios en todas las regiones:

- Microsoft Office 365
- Microsoft Dynamics 365
- Servicios de proceso de Azure, como Azure Virtual Machines
- Servicios en la nube de Azure, como Azure Cosmos DB y Azure Storage

##### Conectividad global

Puede permitir que Global Reach de ExpressRoute intercambie datos entre los sitios locales si conecta los diferentes circuitos ExpressRoute. Por ejemplo, supongamos que tiene una oficina en Asia y un centro de datos en Europa, ambos con circuitos ExpressRoute que los conectan a la red de Microsoft. Puede usar Global Reach de ExpressRoute para conectar esas dos instalaciones, lo que les **permite comunicarse sin transferir datos a través de la red pública de Internet**.

##### Enrutamiento dinámico

ExpressRoute usa el BGP. BGP se usa para **intercambiar rutas entre las redes locales y los recursos que se ejecutan en Azure**. Este protocolo permite el enrutamiento dinámico entre la red local y los servicios que se ejecutan en la nube de Microsoft.

##### Redundancia integrada

Cada proveedor de conectividad usa dispositivos redundantes para garantizar que las conexiones establecidas con Microsoft tengan **alta disponibilidad**. Puede configurar varios circuitos para complementar esta característica.

#### Modelos de conectividad de ExpressRoute

ExpressRoute admite cuatro modelos que puede usar para conectar la red local con la nube de Microsoft:

- Ubicación de CloudExchange
- Conexión Ethernet de punto a punto
- Conexión universal
- Directamente desde sitios de ExpressRoute

##### Ubicación compartida en un intercambio en la nube

La ubicación conjunta hace referencia al centro de datos, la oficina u otras instalaciones que se encuentran físicamente en un intercambio en la nube, como un ISP. Si la instalación tiene la ubicación compartida en un intercambio en la nube, puede solicitar una conexión cruzada virtual a la nube de Microsoft.

##### Conexión Ethernet de punto a punto

La conexión Ethernet de punto a punto hace referencia al uso de una conexión punto a punto para conectar la instalación a la nube de Microsoft.

##### Redes universales

Con la conectividad universal, puede integrar la red de área extensa (WAN) con Azure si proporciona conexiones a las oficinas y los centros de datos. Azure se integra con la conexión WAN para proporcionarle una conexión, como la que tendría entre el centro de datos y las sucursales.

##### Directamente desde sitios de ExpressRoute

Puede conectarse directamente a la red global de Microsoft en una ubicación de emparejamiento distribuida estratégicamente por todo el mundo. ExpressRoute Direct proporciona conectividad dual de 100 Gbps o 10 Gbps, que es compatible con la conectividad activa/activa a escala.

#### Consideraciones sobre la seguridad

Con ExpressRoute **los datos no viajan a través de la red pública de Internet** y, por tanto, no se exponen a los posibles riesgos asociados a las comunicaciones de Internet. ExpressRoute es una conexión privada de la infraestructura local a la infraestructura de Azure. Incluso si tiene una conexión ExpressRoute, las consultas de DNS, la comprobación de la lista de revocación de certificados y las solicitudes de Azure Content Delivery Network se siguen enviando a través de la red pública de Internet.

### Describir Azure DNS

Azure DNS es un servicio de hospedaje para dominios DNS que ofrece resolución de nombres mediante la infraestructura de Microsoft Azure. Al hospedar dominios en Azure, puede administrar los registros DNS con las mismas credenciales, API, herramientas y facturación que con los demás servicios de Azure.

#### Ventajas de Azure DNS

Azure DNS saca provecho del ámbito y la escala de Microsoft Azure para proporcionar numerosas ventajas, incluidas las siguientes:

- Confiabilidad y rendimiento
- Seguridad
- Facilidad de uso
- Redes virtuales personalizables
- Registros de alias

##### Confiabilidad y rendimiento

Los dominios DNS de Azure DNS se hospedan en la red global de servidores de nombres DNS de Azure, y proporcionan resistencia y alta disponibilidad. Azure DNS usa **redes de difusión por proximidad** para que el servidor DNS más próximo disponible responda a cada consulta de DNS para proporcionar un mejor rendimiento y una mayor disponibilidad para el dominio.

##### Seguridad

Azure DNS se basa en Azure Resource Manager, que proporciona características tales como:

- Control de acceso basado en rol de Azure (**Azure RBAC**) para controlar quién accede a acciones específicas en la organización.
- **Registros de actividad**: para supervisar cómo un usuario de su organización modificó un recurso o para encontrar errores al solucionar problemas.
- **Bloqueo de recursos** para bloquear una suscripción, un grupo de recursos o un recurso. Los bloqueos impiden que otros usuarios de la organización eliminen o modifiquen de forma accidental recursos críticos.

##### Facilidad de uso

Azure DNS puede administrar registros DNS para los servicios de Azure y también proporciona el servicio de nombres de dominio para los recursos externos. Azure DNS está integrado en Azure Portal y usa las mismas credenciales, la misma facturación y el mismo contrato de soporte técnico que los demás servicios de Azure.

Como Azure DNS se ejecuta en Azure, significa que puede administrar los dominios y registros con Azure Portal, cmdlets de Azure PowerShell y la CLI de Azure multiplataforma. Las aplicaciones que requieren la administración automática de DNS se pueden integrar con el servicio mediante las API REST y los SDK.

##### Redes virtuales personalizables con dominios privados

Azure DNS es compatible con dominios DNS privados. Esta característica permite usar nombres de dominio personalizados propios en las redes virtuales privadas, en lugar de limitarse a los nombres proporcionados por Azure.

##### Registros de alias

Azure DNS también admite conjuntos de registros de alias. Puede usar un conjunto de registros de alias que haga referencia a un recurso de Azure, como una dirección IP pública de Azure, un perfil de Azure Traffic Manager o un punto de conexión de Azure Content Delivery Network (CDN). Si cambia la dirección IP del recurso subyacente, el conjunto de registros de alias se actualiza sin problemas durante la resolución DNS. El conjunto de registros de alias apunta a la instancia de servicio, y la instancia de servicio está asociada con una dirección IP.

	Importante
	
	No se puede usar Azure DNS para comprar un nombre de dominio. Por una tarifa anual, puede comprar un nombre de dominio mediante dominios de App Service o un registrador de nombres de dominio de terceros. Después de comprarlos, los dominios se pueden hospedar en Azure DNS para la administración de registros.


### Prueba de conocimientos

1. ¿Qué característica de máquina virtual de Azure escalona las actualizaciones en todas las máquinas virtuales en función de sus dominios de actualización y error?

<Details>
	<summary>Respuesta</summary>
	<p><b>Los conjuntos de disponibilidad</b> escalonan las actualizaciones de máquina virtual en función de sus dominios de actualización y error.</p>
</Details>

2. ¿Qué servicio de Azure permite a los usuarios utilizar una versión hospedada en la nube de Windows desde cualquier ubicación y conectarse desde los exploradores más modernos?

<Details>
	<summary>Respuesta</summary>
	<p><b>Azure Virtual Desktop</b> proporciona acceso a una versión hospedada en la nube de Windows y funciona con la mayoría de los exploradores modernos.</p>
</Details>

### Resumen

En este módulo hemos visto información sobre algunos de los servicios de proceso y red que forman parte de Azure.

Hemos aprendido sobre las máquinas virtuales y las distintas opciones que se asocian a ellas (como Virtual Machine Scale Sets y conjuntos de disponibilidad de máquinas virtuales).

También se han presentado algunas de las funcionalidades de red, incluidas las redes virtuales, ExpressRoute y las redes privadas virtuales.

#### Objetivos de aprendizaje

Ahora deberíamos ser capaces de hacer lo siguiente:

- Comparación de los tipos de proceso, incluidas las instancias de contenedor, las máquinas virtuales y las funciones.
- Describir las opciones de máquina virtual, incluidas las máquinas virtuales (VM), los conjuntos de escalado de máquinas virtuales, los conjuntos de disponibilidad de máquinas virtuales y Azure Virtual Desktop.
- Describir los recursos necesarios para las máquinas virtuales.
- Describir las opciones de hospedaje de aplicaciones, incluidos Azure Web Apps, contenedores y máquinas virtuales.
- Describir las redes virtuales, incluido el propósito de Azure Virtual Networks, las subredes virtuales de Azure, el emparejamiento, Azure DNS, VPN Gateway y ExpressRoute.
- Definición de puntos de conexión públicos y privados.

#### Recursos adicionales

Los siguientes recursos adicionales están diseñados para proporcionar más información sobre los temas de este módulo o sobre temas adicionales relacionados con este módulo.

- [Hospedaje de una aplicación web con Azure App Service](https://learn.microsoft.com/es-es/learn/modules/host-a-web-app-with-azure-app-service/) es un módulo de Microsoft Learn que explora el proceso de hospedaje de una aplicación web en Azure.
- [Introducción a los servicios de base de red de Azure](https://learn.microsoft.com/es-es/learn/paths/intro-to-azure-network-foundation-services/) es un curso de Microsoft Learn que proporciona más información sobre las redes con Azure.

## Descripción de los servicios de almacenamiento de Azure

### Introducción

En este módulo, **veremos los servicios de Azure Storage**. 

Información sobre la cuenta de Azure Storage y cómo se relaciona con los distintos servicios de almacenamiento que hay disponibles. También descubrirá los niveles de almacenamiento de blobs, las opciones de redundancia de datos y las formas de mover datos o incluso infraestructuras completas a Azure.

#### Objetivos de aprendizaje

Después de completar este módulo, podrá:

- Comparación de los servicios de almacenamiento de Azure.
- Describir los niveles de almacenamiento.
- Describir las opciones de redundancia.
- Describir las opciones de la cuenta de almacenamiento y los tipos de almacenamiento.
- Identificar opciones para mover archivos, incluidos AzCopy, Explorador de Azure Storage y Azure File Sync.
- Descripción de las opciones de migración, incluidas Azure Migrate y Azure Data Box

### Descripción de las cuentas de almacenamiento de Azure

**Una cuenta de almacenamiento proporciona un espacio de nombres único para los datos de Azure Storage** al que se puede acceder desde cualquier lugar del mundo a través de HTTP o HTTPS. Los datos de esta cuenta son seguros, de alta disponibilidad, duraderos y escalables de forma masiva.

Al crear la cuenta de almacenamiento, primero seleccionará el **tipo de cuenta de almacenamiento**. El tipo de cuenta **determina los servicios de almacenamiento y las opciones de redundancia**, y afecta a los casos de uso. A continuación se muestra una lista de opciones de redundancia que se describirán más adelante en este módulo:

- Almacenamiento con redundancia local (LRS)
- Almacenamiento con redundancia geográfica (GRS)
- Almacenamiento con redundancia geográfica con acceso de lectura (RA-GRS).
- Almacenamiento con redundancia de zona (ZRS)
- Almacenamiento con redundancia de zona geográfica (GZRS)
- Almacenamiento con redundancia de zona geográfica con acceso de lectura (RA-GZRS)

|**Tipo**|**Servicios admitidos**|**Opciones de redundancia**|**Uso**|
|---|---|---|---|
|De uso general estándar, v2|Blob Storage (incluido Data Lake Storage), Queue Storage, Table Storage y Azure Files|LRS, GRS, RA-GRS, ZRS, GZRS, RA-GZRS|Tipo de cuenta de almacenamiento estándar para blobs, archivos, colas y tablas. Se recomienda para la mayoría de los escenarios con Azure Storage. Si desea compatibilidad con el sistema de archivos de red (NFS) en Azure Files, utilice el tipo de cuenta de recursos compartidos de archivos Premium.|
|Blobs en bloques Premium|Blob Storage (incluido Data Lake Storage)|LRS, ZRS|Tipo de cuenta de almacenamiento Prémium para blobs en bloques y blobs en anexos. Se recomiendan para escenarios con altas tasas de transacciones, que utilizan objetos más pequeños o que requieren una latencia de almacenamiento constantemente baja.|
|Recursos compartidos de archivos Prémium|Azure Files|LRS, ZRS|Tipo de cuenta de almacenamiento Prémium solo para recursos compartidos de archivos. Se recomienda para empresas y aplicaciones de escalado de alto rendimiento. Use este tipo de cuenta si desea una cuenta de almacenamiento que admita recursos compartidos de archivos de Bloque de mensajes del servidor (SMB) y NFS.|
|Blobs en páginas Premium|Solo blobs en páginas|LRS|Tipo de cuenta de almacenamiento prémium solo para blobs en páginas.|

#### Puntos de conexión de cuenta de almacenamiento

Una de las ventajas de usar una cuenta de Azure Storage es tener un espacio de nombres único en Azure para los datos. Para ello, todas las cuentas de almacenamiento de Azure deben tener un nombre de cuenta único en Azure. La combinación del nombre de la cuenta y el punto de conexión del servicio de Azure Storage forma los puntos de conexión de su cuenta de almacenamiento.

Cuando especifique un nombre para la cuenta de almacenamiento, tenga en cuenta estas reglas:

- Los nombres de las cuentas de almacenamiento deben tener entre 3 y 24 caracteres, y solo pueden incluir números y letras en minúscula.
- El nombre de la cuenta de almacenamiento debe ser único dentro de Azure. No puede haber dos cuentas de almacenamiento con el mismo nombre. Esto admite la capacidad de tener un espacio de nombres único y accesible en Azure.

En la tabla siguiente se muestra el formato de punto de conexión para los servicios de Azure Storage.

|**Servicio de Storage**|**Punto de conexión**|
|---|---|
|Blob Storage|https://\<storage-account-name\>.blob.core.windows.net|
|Data Lake Storage Gen2|https://\<storage-account-name\>.dfs.core.windows.net|
|Azure Files|https://\<storage-account-name\>.file.core.windows.net|
|Queue Storage|https://\<storage-account-name\>.queue.core.windows.net|
|Table Storage|https://\<storage-account-name\>.table.core.windows.net|
#### Servicios de almacenamiento

##### Azure Blob storage

Es una solución de almacenamiento de objetos que se puede usar para almacenar grandes cantidades de datos no estructurados, como texto o datos binarios.

Ideal para enviar imágenes o documentos directamente a un explorador, almacenar datos para archivos o el acceso distribuido, emitir video y audio y escenarios de recuperación ante desastres.

##### Azure File Storage

Ofrece recursos compartidos de archivos totalmente administrados en la nube, a los que se pueden acceder mediante protocolos de red estándar del sector.


Supervisar recursos compartidos de Azure es como conectarse a recursos compartidos de la red local.

##### Azure Disk Storage 

Proporciona discos para que las maquinas virtuales y las aplicaciones accedan a ellos y los usen cuando sea necesario, igual que harían con discos locales.

Azure ofrece unidades de estado sólido para cargas de trabajo de más alto rendimiento y discos duros convencionales para escenarios empresariales menos críticos.



##### Azure Table Storage

Ofrece un almacén de datos NoSQL para pares clave-valor con conjuntos de datos a gran escala.

puedes usarlo para almacenar petabytes de datos semiestructurados y reducir los costos.

##### Azure Queue Storage

Proporciona una puesta en cola de mensajes asincrónicos para la comunicación entre los componentes de las aplicaciones, independientemente de su se ejecutan en la nube, escritorio, de forma local o dispositivos móviles.


#### Niveles de acceso

Puedes usar tres niveles de acceso de Azure para equilibrar los costos: 

|Nivel|Descripción |
| - | - |
|Frecuenta|Esta optimizado para datos que se consultan con frecuencia, como las imágenes de su sitio web|
|Esporadico|Para datos a los que se accede con poca frecuencia y que se guardan al menos durante 30 días, como facturas de clientes.|
|Archivo|Adecuado para datos a los que rara vez se accede y que se guardan durante al menos 180 días, como copias de seguridad a largo plazo.|

### Descripción de la redundancia de almacenamiento de Azure

Azure Storage siempre almacena varias copias de los datos, con el fin de protegerlos de eventos planeados y no planeados, lo que incluye errores transitorios del hardware, interrupciones del suministro eléctrico o cortes de la red, y desastres naturales. **La redundancia garantiza** que la cuenta de almacenamiento cumple sus objetivos de **disponibilidad y durabilidad**, aunque se produzcan errores.  

A la hora de decidir qué opción de redundancia es la más adecuada para su escenario, intente buscar un equilibrio entre bajo costo y alta disponibilidad. Entre los factores que ayudan a determinar qué opción de redundancia debe elegir se incluye:

- Cómo se replican los datos en la región primaria.
- Si los datos se replican en una segunda ubicación que está alejada geográficamente de la región primaria, para protegerse frente a desastres regionales.
- Si la aplicación necesita acceso de lectura a los datos replicados en la región secundaria en caso de que la región primaria deje de estar disponible.

#### Redundancia en la región primaria

Los datos de una cuenta de **Azure Storage siempre se replican tres veces en la región primaria**. **Azure Storage ofrece** dos opciones para replicar los datos en la región primaria, el almacenamiento con redundancia local (LRS) y el almacenamiento con redundancia de zona (ZRS).

##### Almacenamiento con redundancia local

El almacenamiento con redundancia local (LRS) replica los datos tres veces dentro de un único centro de datos en la región primaria. LRS ofrece una durabilidad mínima de 11 nueves (99,999999999 %) de los objetos en un año determinado.

![[Pasted image 20231226113724.png]]

LRS es la opción de redundancia de costo más bajo y ofrece la menor durabilidad en comparación con otras opciones. LRS protege los datos frente a errores en la estantería de servidores y en la unidad. No obstante, si se produce un desastre como un incendio o una inundación en el centro de datos, es posible que todas las réplicas de una cuenta de almacenamiento con LRS se pierdan o no se puedan recuperar. Para mitigar este riesgo, Microsoft recomienda el uso del almacenamiento con redundancia de zona (ZRS), el almacenamiento con redundancia geográfica (GRS) o el almacenamiento con redundancia de zona geográfica (GZRS).

##### Almacenamiento con redundancia de zona

Para las regiones con zona de disponibilidad habilitada, el almacenamiento con redundancia de zona (ZRS) **replica los datos de Azure Storage sincrónicamente en tres zonas de disponibilidad de Azure en la región primaria**. ZRS proporciona a los objetos de datos de Azure Storage una durabilidad de al menos 12 nueves (99,9999999999 %) durante un año determinado.

![[Pasted image 20231226114014.png]]

Con ZRS, **los datos son accesibles para las operaciones de escritura y lectura incluso si una zona deja de estar disponible**. No es necesario volver a montar los recursos compartidos de archivos de Azure de los clientes conectados. Si alguna zona deja de estar disponible, Azure realiza las actualizaciones de la red, como el redireccionamiento de DNS. Estas actualizaciones pueden afectar a la aplicación si se accede a los datos antes de que se completen dichas actualizaciones.

Microsoft recomienda usar ZRS en la región primaria para **escenarios que requieren de alta disponibilidad**. También se recomienda ZRS para **restringir la replicación** de datos dentro de un país o región para cumplir los requisitos de gobernanza de datos.

#### Redundancia en una región secundaria

En el caso de las aplicaciones que requieren de **alta durabilidad**, puede optar por copiar los datos de la cuenta de almacenamiento **en una región secundaria** que esté a cientos de kilómetros de distancia de la región primaria. Si los datos de la cuenta de almacenamiento se copian en una región secundaria, los datos serán duraderos incluso en caso de un error catastrófico que impida que se recuperen los datos de la región primaria.

Al crear una cuenta de almacenamiento, seleccione la región principal de la cuenta. La región secundaria emparejada **se determina en función de los Pares de regiones de Azure** y no se puede cambiar.

Azure Storage ofrece dos **opciones para copiar** los datos en una región secundaria: almacenamiento con redundancia geográfica (**GRS**) y almacenamiento con redundancia de zona geográfica (**GZRS**). **GRS es similar a ejecutar LRS en dos regiones, y GZRS es similar a ejecutar ZRS en la región primaria y LRS en la región secundaria.**

**De manera predeterminada, los datos de la región secundaria no están disponibles para el acceso de lectura o escritura a menos que haya una conmutación por error a la región secundaria**. Si la región primaria deja de estar disponible, puede conmutar por error a la región secundaria. Una vez completada la conmutación por error, la región secundaria se convierte en la región primaria y se pueden leer y escribir datos de nuevo.

#### Almacenamiento con redundancia geográfica

**GRS copia los datos de manera sincrónica tres veces dentro de una ubicación física única en la región primaria mediante LRS.  Luego copia los datos de forma asincrónica en una única ubicación física en la región secundaria (el par de regiones) mediante LRS.** GRS proporciona a los objetos de datos de Azure Storage una durabilidad de al menos 16 nueves (99,99999999999999 %) durante un año determinado.

![[Pasted image 20231226115447.png]]

#### Almacenamiento con redundancia de zona geográfica

**GZRS combina la alta disponibilidad que proporciona la redundancia entre zonas (ZRS) de disponibilidad con la protección frente a interrupciones regionales que proporciona la replicación geográfica (GRS)**. Los datos de una cuenta de almacenamiento de GZRS se almacenan en tres zonas de disponibilidad de Azure en la región primaria (de manera similar a ZRS) y también se replican en una región geográfica secundaria para protegerlos frente a desastres regionales. Microsoft recomienda el uso de GZRS en aplicaciones que requieran de coherencia, durabilidad y disponibilidad máximas, además de rendimiento excelente y resistencia para la recuperación ante desastres.

![[Pasted image 20231226120152.png]]

GZRS está diseñado para proporcionar una durabilidad mínima de 16 nueves (99,99999999999999 %) de los objetos en un año determinado.

#### Acceso de lectura a los datos de la región secundaria

El almacenamiento con redundancia geográfica (con GRS o GZRS) replica los datos en otra ubicación física de la región secundaria para protegerlos frente a los apagones regionales. **Sin embargo, los datos están disponibles para su lectura solo si el cliente o Microsoft inician una conmutación por error de la región primaria** a la secundaria. Sin embargo, si habilita el acceso de lectura a la región secundaria, los datos siempre están disponibles, incluso cuando la región primaria se ejecuta de forma óptima. **Para obtener acceso de lectura a la región secundaria, habilite** el almacenamiento con redundancia geográfica con acceso de lectura **(RA-GRS**) **o** el almacenamiento con redundancia de zona geográfica con acceso de lectura (**RA-GZRS**).

	 Importante

	Recuerde que es posible que los datos de la región secundaria no estén actualizados debido al RPO.

### Descripción de los servicios de almacenamiento de Azure

La plataforma de Azure Storage incluye los servicios de datos siguientes:

|Servicio|Descripción|
| - | - |
|**Blobs de Azure**|un almacén de objetos que se puede escalar de forma masiva para datos de texto y binarios. También incluye compatibilidad con el análisis de macrodatos a través de Data Lake Storage Gen2.|
|**Azure Files**|recursos compartidos de archivos administrados para implementaciones locales y en la nube.|
|**Colas de Azure**|un almacén de mensajería para mensajería confiable entre componentes de aplicación.|
|**Azure Disks**|volúmenes de almacenamiento en el nivel de bloque para máquinas virtuales de Azure.|
|**Tablas de Azure**|Opción tabla NoSQL para datos estructurados y no relacionales.|

#### Ventajas de Azure Storage

Los servicios de Azure Storage ofrecen las siguientes ventajas para desarrolladores de aplicaciones y profesionales de TI:

|Ventaja|Justificación|
| - | - |
|**Duradero y altamente disponible**|**La redundancia garantiza** que los datos estén seguros en caso de producirse errores de hardware transitorios. También puede optar por replicar datos entre centros de datos o regiones geográficas para **obtener protección adicional frente a catástrofes locales o desastres naturales**. Los datos replicados de esta manera permanecen con una alta disponibilidad en caso de que se produzca una interrupción inesperada.|
|**Seguro**|Todos los datos escritos en una cuenta de Azure Storage **se cifran mediante el servicio**. Azure Storage proporciona un control pormenorizado sobre quién tiene acceso a los datos.|
|**Escalable**|Azure Storage está diseñado para poderse escalar de forma masiva para satisfacer las necesidades de rendimiento y almacenamiento de datos de las aplicaciones de hoy en día.|
|**Administrado**|Azure controla automáticamente el mantenimiento, las actualizaciones y los problemas críticos del hardware.|
|**Accesible**|Es posible acceder a los datos de Azure Storage desde cualquier parte del mundo a través de HTTP o HTTPS. Microsoft proporciona bibliotecas cliente para Azure Storage en diversos lenguajes, incluidos .NET, Java, Node.js, Python, PHP, Ruby, Go y otros, así como una API REST consolidada. Azure Storage admite la escritura en Azure PowerShell o la CLI de Azure. Y Azure Portal y el Explorador de Azure Storage ofrecen soluciones visuales sencillas para trabajar con los datos.|

#### Servicios de almacenamiento de azure

##### Blobs de Azure

Azure Blob Storage es una solución de almacenamiento de objetos para la nube. **Puede almacenar** grandes cantidades de datos, como **datos de texto o binarios**. Azure Blob Storage **no está estructurada**, lo que significa que no hay ninguna restricción en cuanto a los tipos de datos que puede contener. Blob Storage puede administrar miles de cargas simultáneas, cantidades enormes de datos de vídeo, archivos de registro en constante crecimiento y es accesible desde cualquier lugar con conexión a Internet.

Los blobs no están limitados a formatos de archivo comunes. Un blob podría contener gigabytes de datos binarios transmitidos desde un instrumento científico, un mensaje cifrado para otra aplicación o datos en un formato personalizado para una aplicación que se está desarrollando. Una **ventaja del almacenamiento en blobs** con respecto al almacenamiento en disco es que **no requiere que los desarrolladores piensen en discos o los administren**. Los datos se cargan como blobs y Azure se encarga de las necesidades de almacenamiento físico.

Blob Storage resulta muy conveniente para lo siguiente:

- Visualización de imágenes o documentos directamente en un explorador.
- Almacenamiento de archivos para acceso distribuido.
- Streaming de audio y vídeo.
- Almacenamiento de datos para copia de seguridad y restauración, recuperación ante desastres y archivado.
- Almacenamiento de datos para el análisis en local o en un servicio hospedado de Azure.

###### Acceso a Blob Storage

Se puede acceder a los objetos de Blob Storage desde cualquier parte del mundo a través de HTTP o HTTPS. Los usuarios o las aplicaciones cliente pueden acceder a los blobs mediante direcciones URL, la API REST de Azure Storage, Azure PowerShell, la CLI de Azure o una biblioteca cliente de Azure Storage. Las bibliotecas de cliente de almacenamiento están disponibles para varios lenguajes, como .NET, Java, Node.js, Python, PHP y Ruby.

###### Niveles de Blob Storage

Los datos almacenados en la nube pueden crecer a un ritmo exponencial. **Para administrar los costos** de las crecientes necesidades de almacenamiento, resulta útil organizar los datos en función de atributos como **la frecuencia de acceso y el período de retención planeada**. Los datos almacenados en la nube se pueden controlar de forma distinta según la forma en que se generan, se procesan y se accede a ellos a lo largo de su vigencia. Se puede acceder y modificar ciertos datos de forma activa a lo largo de su duración. Se accede con frecuencia a ciertos datos al inicio de su vida útil hasta que el acceso cae drásticamente a medida que envejecen. Algunos datos permanecen inactivos en la nube y, después de que se almacenan, no se accede a ellos prácticamente nunca. Para dar cabida a estas diferentes necesidades de acceso, Azure proporciona varios niveles de acceso, que puede usar para **equilibra**r **los costos de almacenamiento con sus necesidades de acceso**.

Azure Storage ofrece diferentes niveles de acceso para el almacenamiento de blobs, lo que le ayuda a almacenar datos de objetos de la manera más rentable. **Entre los niveles de acceso disponibles se incluyen**:

- **Nivel de acceso frecuente**: optimizado para almacenar datos a los que se accede con frecuencia (por ejemplo, imágenes para el sitio web).
- **Nivel de acceso esporádico**: optimizado para datos a los que se accede con poca frecuencia y que se almacenan al menos durante 30 días (por ejemplo, las facturas de los clientes).
- **Nivel de acceso aislados**: está optimizado para almacenar datos a los que se accede con poca frecuencia y al menos durante 90 días.
- **Nivel de acceso de archivo**: conveniente para datos a los que raramente se accede y que se almacenan durante al menos 180 días con requisitos de latencia flexibles (por ejemplo, copias de seguridad a largo plazo).


Las siguientes **consideraciones** se aplican a los distintos niveles de acceso:

- Los niveles de **acceso frecuente y esporádico** se pueden **establece**r **en el nivel de cuenta**. Los niveles de acceso **aislados y de archivo no** están disponibles en el nivel de cuenta.
- **Los niveles** frecuente, esporádico, aislados y de archivo **se** pueden **establece**r **en el nivel de blob** durante la carga o después de esta.
- Los datos de los niveles de **acceso esporádico y aislado** pueden **tolera**r **una disponibilidad ligeramente inferior**, pero aun así requieren una gran durabilidad y latencia de recuperación, y unas características de rendimiento similares a las de los datos de acceso frecuente. En el caso de los datos de acceso esporádico y aislado, un contrato de nivel de servicio (SLA) con una disponibilidad ligeramente inferior y unos costes de acceso mayores, en comparación con los datos de acceso frecuente, es aceptable a cambio de unos costes de almacenamiento menores.
- El almacenamiento de archivo almacena datos sin conexión y ofrece los menores costos de almacenamiento, pero los mayores costos de acceso y rehidratación de datos.

##### Azure Files

El almacenamiento de Azure Files **ofrece recursos compartidos** de archivos totalmente administrados en la nube a los **que se puede acceder mediante** los protocolos Bloque de mensajes del servidor (**SMB**) o Sistema de archivos en red (**NFS**) estándar del sector. Los recursos compartido de archivos de Azure Files se pueden montar simultáneamente mediante implementaciones locales o en la nube. 

A los recursos compartidos de archivos SMB de Azure se puede acceder desde clientes Windows, Linux y macOS. A los recursos compartidos de archivos NFS de Azure Files se puede acceder desde clientes Linux y macOS. Además, los recursos compartidos de archivos SMB de Azure Files se pueden almacenar en la caché de los servidores de Windows Server con Azure File Sync, lo que permite un acceso rápido allí donde se utilizan los datos.


###### Ventajas de Azure Files

- **Acceso compartido**: los recursos compartidos de Azure Files admiten los protocolos SMB y NFS estándar del sector, lo que significa que puede **reemplazar perfectamente los recursos compartidos de archivos en local** por recursos compartidos de archivos de Azure **sin preocuparse de compatibilidad de aplicaciones**.
- **Totalmente administrado**: los recursos compartidos de Azure Files **pueden crearse sin necesidad de administrar ni el hardware ni un sistema operativo**. Esto significa que no tiene que tratar con la aplicación de actualizaciones de seguridad críticas en el sistema operativo del servidor ni ocuparse de reemplazar discos duros defectuosos.
- **Scripts y herramientas**: se pueden usar cmdlets de PowerShell y la CLI de Azure para crear, montar y administrar recursos compartidos de archivos de Azure como parte de la administración de las aplicaciones de Azure. Los recursos compartidos de archivos de Azure se pueden crear y administrar mediante Azure Portal y el Explorador de Azure Storage.
- **Resistencia**: Azure Files se creó desde sus orígenes para estar siempre disponible. Reemplazar los recursos compartidos de archivos en el entorno local por Azure Files significa que ya no tendrá que levantarse en mitad de la noche para tratar con problemas de red o interrupciones del suministro eléctrico local.
- **Capacidad de programación intuitiva**: las aplicaciones que se ejecutan en Azure pueden tener acceso a los datos en el recurso compartido mediante las API de E/S del sistema de archivos. Por tanto, los desarrolladores pueden aprovechar el código y los conocimientos que ya tienen para migrar las aplicaciones actuales. Además de las API de E/S del sistema, puede usar las Bibliotecas de cliente de Azure Storage o la API de REST de Azure Storage.


##### Colas de Azure

Azure Queue Storage es un servicio para almacenar grandes cantidades de mensajes, Una vez que están almacenados, se puede acceder a los mensajes desde cualquier lugar del mundo mediante llamadas autenticadas con HTTP o HTTPS. Una cola puede contener tantos mensajes como el espacio que tenga la cuenta de almacenamiento (pueden ser millones). **Cada mensaje individual** de la cola **puede** llegar a **tener un tamaño máximo de 64 KB**. Las colas **se utilizan** normalmente **para crear un trabajo pendiente del trabajo que se va a procesar de forma asincrónica**.

Queue Storage se puede combinar con funciones de proceso como Azure Functions para realizar una acción cuando se recibe un mensaje. Por ejemplo, supongamos que quiere realizar una acción después de que un cliente cargue un formulario en el sitio web. Podría hacer que el botón enviar en el sitio web desencadene un mensaje en Queue Storage. Después, podría usar Azure Functions para desencadenar una acción una vez recibido el mensaje.


##### Tablas de Azure

Azure Table Storage permite almacenar una gran cantidad de datos estructurados. Las tablas de Azure son un almacén de datos NoSQL que acepta llamadas autenticadas desde dentro y fuera de la nube de Azure. Esto le permite usar tablas de Azure para compilar la solución híbrida o de varias nubes y hacer que los datos estén siempre disponibles. **Las tablas de Azure son ideales para el almacenamiento de datos estructurados no relacionales**.

### Ejercicio: Creación de un blob de almacenamiento

#### Crear una cuenta de almacenamiento

En esta tarea, creará una cuenta de almacenamiento.

1. Inicie sesión en Azure Portal en [https://portal.azure.com](https://portal.azure.com/learn.docs.microsoft.com).
    
2. Seleccione **Crear un recurso**.
    
3. En Categorías, seleccione **Almacenamiento**.
    
4. En Cuenta de almacenamiento, seleccione **Crear**.
    
5. En la pestaña **Aspectos básicos** del panel Crear cuenta de almacenamiento, rellene la siguiente información. Deje los valores predeterminados para todo lo demás.

|**Configuración**|**Valor**|
|---|---|
|Subscription|Suscripción de Concierge|
|Grupo de recursos|Seleccione el grupo de recursos que comienza por **learn**.|
|Nombre de la cuenta de almacenamiento|Cree un nombre de cuenta de almacenamiento único|
|Region|Deje el valor predeterminado|
|Rendimiento|Estándar|
|Redundancia|Almacenamiento con redundancia local (LRS)|

6. En la pestaña **Opciones avanzadas** del panel Crear cuenta de almacenamiento, rellene la siguiente información. Deje los valores predeterminados para todo lo demás.


|**Configuración**|**Valor**|
|---|---|
|Permitir la habilitación del acceso anónimo en contenedores individuales|Activada|

![[Pasted image 20231226130811.png]]

7. Seleccione **Revisar** para revisar la configuración de su cuenta de almacenamiento y permitir que Azure valide la configuración.
    
8. Una vez validada, seleccione **Crear**. Espere la notificación de que la cuenta se creó correctamente.
    
9. Haga clic en **Go to resource** (Ir al recurso).


#### Uso con Blob Storage

En esta sección, creará un contenedor de blobs y cargará una imagen.

1. En **Almacenamiento de datos,** seleccione **Contenedores**.

![[Pasted image 20231226131109.png]]


2. Seleccione **+ Contenedor** y complete la información.

|**Configuración**|**Valor**|
|---|---|
|Nombre|Escriba un nombre para el contenedor.|
|Nivel de acceso anónimo|Privado (sin acceso anónimo)|

3. Seleccione Crear

PD: 

El Paso 4 necesitará una imagen. Si quiere cargar una imagen que ya tiene en el equipo, continúe con el Paso 4. De lo contrario, abra una nueva ventana del explorador y busque la imagen de una flor en Bing. Guarde la imagen en el equipo.

4. 1. De nuevo en Azure Portal, seleccione el contenedor que ha creado y luego Cargar.

5. Explore el archivo de la imagen que quiere cargar. Selecciónelo y, luego, seleccione Cargar.

PD: 

Puede cargar tantos blobs como quiera de esta manera. Los nuevos blobs se enumerarán dentro del contenedor.

6. Seleccione el blob (archivo) que acaba de cargar. Debe estar en la pestaña de propiedades.
   
7. Copie la dirección URL del campo URL y péguela en una nueva pestaña.   

Debe recibir un mensaje de error similar al siguiente:

```RESULTADO
<Error>
  <Code>ResourceNotFound</Code>
  <Message>The specified resource does not exist. RequestId:4a4bd3d9-101e-005a-1a3e-84bd42000000</Message>
</Error>
```

![[Pasted image 20231226133224.png]]
#### Cambie el nivel de acceso del blob.

1. Vuelva a Azure Portal.

2. Seleccione Cambiar nivel de acceso.

3. Establezca el Nivel de acceso anónimo en Blob (acceso de lectura anónimo solo para blobs).


![[Pasted image 20231226132214.png]]

4. Seleccione Aceptar.

5. Actualice la pestaña en la que ha intentado acceder al archivo anteriormente.

![[Pasted image 20231226133337.png]]

Enhorabuena, ha completado este ejercicio. Ha creado una cuenta de almacenamiento, ha agregado un contenedor a esta cuenta y, después, ha cargado blobs (archivos) en el contenedor. Luego ha cambiado el nivel de acceso para que pudiera acceder al archivo desde Internet.

#### Limpieza

El espacio aislado limpia los recursos automáticamente cuando haya terminado con este módulo.

Al trabajar en una suscripción propia, se recomienda identificar al final de un proyecto si aún necesita los recursos creados. Los recursos que dejas en ejecución pueden costar dinero. Puede eliminar los recursos de forma individual o eliminar el grupo de recursos para eliminar todo el conjunto de recursos.

### Identificación de las opciones de migración de datos de Azure

Ahora que comprende las distintas opciones de almacenamiento dentro de Azure, es importante comprender también cómo obtener los datos y la información en Azure. **Azure admite la migración en tiempo real de la infraestructura, las aplicaciones y los datos mediante Azure Migrate, así como la migración asincrónica de datos mediante Azure Data Box.**

#### Azure Migrate

Azure Migrate es un servicio que le ayuda a migrar desde un entorno local a la nube. Azure Migrate funciona como centro para ayudarle a administrar la valoración y la migración del centro de datos local a Azure. Ofrece lo siguiente:

- **Plataforma de migración unificada**: un único portal para iniciar, ejecutar y realizar un seguimiento de la migración a Azure.
- **Rango de herramientas**: Rango de herramientas para la evaluación y migración Las herramientas de Azure Migrate incluyen Azure Migrate: Discovery y assessment y Azure Migrate: Server Migration. Azure Migrate también se integra con otros servicios y herramientas de Azure, así como con ofertas de proveedores de software independientes (ISV).
- **Assessment and migration** (Evaluación y migración): en el centro de Azure Migrate, puede evaluar y migrar la infraestructura local a Azure.

##### Herramientas integradas

Además de trabajar con herramientas de ISV, el centro de Azure Migrate también incluye las siguientes herramientas para ayudar con la migración:

- **Azure Migrate: Discovery and assessment** (Azure Migrate: detección y evaluación). Detecte y evalúe servidores locales que se ejecutan en VMware, Hyper-V y servidores físicos para preparar la migración a Azure.
- **Azure Migrate: Server Migration** (Azure Migrate: migración del servidor). Migre máquinas virtuales de VMware, máquinas virtuales de Hyper-V, servidores físicos, otros servidores virtualizados y máquinas virtuales de la nube pública a Azure.
- **Data Migration Assistant**. Data Migration Assistant es una herramienta independiente para evaluar servidores de SQL Server. Ayuda a identificar posibles problemas que bloquean la migración. Identifica características no admitidas, nuevas características que puede aprovechar después de la migración y la ruta de acceso correcta para la migración de la base de datos.
- **Azure Database Migration Service**. Migre bases de datos locales a máquinas virtuales de Azure en las que se ejecutan SQL Server, Azure SQL Database o instancias administradas de SQL.
- **Azure App Service Migration Assistant**. Azure App Service Migration Assistant es una herramienta independiente utilizada para evaluar sitios web locales para la migración a Azure App Service. Use Migration Assistant para migrar aplicaciones web de .NET y PHP a Azure.
- **Azure Data Box**. Use los productos de Azure Data Box para trasladar grandes cantidades de datos sin conexión a Azure.

#### Azure Data Box

Azure Data Box es un servicio de migración física que **ayuda a transferir grandes cantidades de datos de forma rápida**, económica y confiable. La transferencia de datos segura se acelera mediante el envío de un dispositivo de almacenamiento propietario de Data Box que tiene una **capacidad** de almacenamiento utilizable **máxima de 80 terabytes**. Data Box se transporta hacia y desde el centro de datos a través de un transportista regional. Una caja resistente asegura y protege Data Box de daños durante el trayecto.

Puede pedir el dispositivo Data Box a través de Azure Portal para importar o exportar datos desde Azure. Una vez recibido el dispositivo, puede configurarlo rápidamente mediante la interfaz de usuario web local y conectarlo a la red. Una vez que haya terminado de transferir los datos (ya sea dentro o fuera de Azure), simplemente devuelva Data Box. Si va a transferir datos a Azure, los datos se cargan de forma automática una vez que Microsoft vuelve a recibir Data Box. El servicio de Data Box se encarga de realizar el seguimiento de todo el proceso en Azure Portal.

##### Casos de uso

Data Box es ideal para transferir tamaños de datos con más de 40 TB en escenarios sin conectividad de red limitada. El movimiento de datos puede ser único, periódico o una transferencia de datos masiva inicial seguida de transferencias periódicas.

Estos son los **distintos escenarios** donde se puede usar Data Box para importar datos en Azure.

- **Migración única**: cuando se mueve gran cantidad de datos locales a Azure.
- Traslade una biblioteca multimedia de cintas sin conexión a Azure para crear una biblioteca multimedia en línea.
- Migre la granja de máquinas virtuales, SQL Server y las aplicaciones a Azure.
- Traslade los datos históricos a Azure para un análisis exhaustivo y generar informes con HDInsight.
**- Transferencia masiva inicial**: cuando se realiza una transferencia masiva inicial con Data Box (inicialización) seguida de transferencias incrementales a través de la red.
- **Cargas periódicas**: cuando se genera periódicamente una gran cantidad de datos y es necesario moverlos a Azure.

Estos son los distintos escenarios donde se puede usar Data Box para exportar datos a Azure.

- **Recuperación ante desastres**: cuando se restaura una copia de los datos de Azure en una red local. En un escenario de recuperación ante desastres habitual, se exporta una gran cantidad de datos de Azure se exporta a Data Box. Microsoft luego los envía a Data Box y, en poco tiempo, los datos se restauran en un entorno local.
- **Requisitos de seguridad**: cuando necesita poder exportar datos de Azure debido a los requisitos de seguridad o de la administración pública.
- **Migración de vuelta al entorno local o a otro proveedor de servicios en la nube**: cuando quiera mover todos los datos de vuelta al entorno local o a otro proveedor de servicios en la nube, exporte los datos a través de Data Box para migrar las cargas de trabajo.

Una vez que los datos del pedido de importación se cargan en Azure, los discos del dispositivo se limpian, según las normas NIST 800-88r1. Si el pedido es de exportación, los discos se borran una vez que el dispositivo llega al centro de datos de Azure.

### Identificación de las opciones de movimiento de archivos de Azure

Además de la migración a gran escala mediante servicios como Azure Migrate y Azure Data Box, Azure también tiene herramientas diseñadas para ayudarle a **mover o interactuar con archivos individuales o grupos de archivos pequeños**. Entre esas herramientas se encuentran **AzCopy**, **Explorador de Azure Storage** y **Azure File Sync**.

#### AzCopy

AzCopy es una **utilidad de línea de comandos que puede usar para copiar blobs o archivos a una cuenta de almacenamiento o desde una cuenta de almacenamiento**. Con AzCopy, puede copiar archivos entre cuentas de almacenamiento, cargarlos, descargarlos e incluso sincronizarlos. AzCopy incluso se puede configurar para trabajar con otros proveedores de nube para ayudar a mover archivos entre nubes.

	Importante
	
	La sincronización de blobs o archivos con AzCopy es una sincronización unidireccional. Al sincronizar, designó el origen y el destino, y AzCopy copiará archivos o blobs en esa dirección. No se sincroniza bidireccionalmente en función de las marcas de tiempo u otros metadatos.

#### Explorador de Azure Storage

Explorador de Azure Storage es una aplicación independiente que proporciona una **interfaz gráfica para administrar archivos y blobs en la cuenta de Azure Storage**. Funciona en sistemas operativos Windows, macOS y Linux y usa AzCopy en el back-end para realizar todas las tareas de administración de archivos y blobs. Con Explorador de Storage, puede cargar en Azure, descargar desde Azure o moverse entre cuentas de almacenamiento.

#### Azure File Sync

Azure File Sync es una herramienta que **permite centralizar los archivos compartidos en Azure Files** y mantener la flexibilidad, el rendimiento y la compatibilidad de un servidor de archivos de Windows. Es casi como convertir el servidor de archivos de Windows en una red de entrega de contenido en miniatura. **Una vez que instale Azure File Sync en el servidor local de Windows, se mantendrá sincronizado bidireccionalmente con los archivos en Azure de forma automática.**

Con Azure File Sync, puede:

- Usar cualquier protocolo disponible en Windows Server para acceder a sus datos de forma local, como SMB, NFS y FTPS.
- Tener todas las cachés que necesite en todo el mundo.
- Reemplazar un servidor local con errores instalando Azure File Sync en un nuevo servidor del mismo centro de datos.
- Configurar la nube por niveles para que los archivos a los que se accede con más frecuencia se repliquen localmente, mientras que los archivos a los que se accede con poca frecuencia se mantienen en la nube hasta que se soliciten.


### Prueba de Conocimientos

1. ¿Qué herramienta mantiene automáticamente los archivos entre un servidor Windows local y un entorno de nube de Azure actualizado?

<details>
	<summary>Respuesta</summary>
	<p><b>Azure File Sync</b> garantiza la sincronización bidireccional de los archivos entre los servidores de Windows para el entorno local y en la nube.</p>
</details>

2. ¿Qué opción de redundancia de almacenamiento proporciona el mayor grado de durabilidad, con 16 nueves de durabilidad?

<details>
	<summary>Respuesta</summary>
	<p>El almacenamiento con redundancia geográfica (<b>GRS</b>) y el almacenamiento con redundancia de zona geográfica (<b>GZRS</b>) proporcionan 16 nueves de durabilidad.</p>
</details>

3. ¿Qué servicio de Azure Storage admite el análisis de macrodatos, así como el control de tipos de datos binarios y de texto?

<details>
	<summary>Respuesta</summary>
	<p><b>Azure Blobs</b> es un almacén de objetos que se puede escalar de forma masiva para datos de texto y binarios. Azure Blobs también incluye compatibilidad con el análisis de macrodatos mediante Data Lake Storage Gen2.</p>
</details>

### Resumen

En este módulo, hemos aprendido sobre los **servicios de almacenamiento de Azure**. También sobre la cuenta de **Azure Storage** y cómo se relaciona con los distintos **servicios de almacenamiento**. Ha recibido una introducción a los blobs de almacenamiento y las opciones de **redundancia**, y formas de **migrar y mover los datos** tanto a Azure como dentro de Azure.

#### Objetivos de aprendizaje

Ahora deberíamos ser capaces de hacer lo siguiente:

- Comparar los servicios de almacenamiento de Azure.
- Describir los niveles de almacenamiento.
- Describir las opciones de redundancia.
- Describir las opciones de la cuenta de almacenamiento y los tipos de almacenamiento.
- Identificar opciones para mover archivos, incluidos AzCopy, Explorador de Azure Storage y Azure File Sync.
- Describir las opciones de migración, incluidas Azure Migrate y Azure Data Box.

#### Recursos adicionales

Los recursos siguientes proporcionan más información sobre los temas de este módulo o relacionados con este módulo.

- [Almacenamiento de datos en Azure](https://learn.microsoft.com/es-es/learn/paths/store-data-in-azure/) es un curso de Microsoft Learn que cubre más información sobre el almacenamiento de datos en Azure.
- [Microsoft Certified: Azure Data Fundamentals](https://learn.microsoft.com/es-es/learn/certifications/azure-data-fundamentals/) es una certificación completa, con aprendizaje asociado que profundiza en los aspectos básicos de los datos en Azure.



## Descripción de la identidad, el acceso y la seguridad de Azure

### Introducción

En este módulo, se le presentará la **identidad, el acceso, y las herramientas y servicios de seguridad de Azure**. Obtendrá información sobre los **servicios de directorio** en Azure, los **métodos de autenticación y el control de acceso**. También tratará cosas como **Confianza cero** y la defensa en profundidad, y cómo permiten mantener la nube más segura. Terminará con una introducción a **Microsoft Defender** for Cloud.

#### Objetivos de aprendizaje

Después de completar este módulo, podrá:

- Descripción de los servicios de directorio en Azure, incluidos Microsoft Entra ID y Microsoft Entra Domain Services.
- Descripción de los métodos de autenticación en Azure, incluido el inicio de sesión único (SSO), la autenticación multifactor (MFA) y sin contraseña.
- Descripción de identidades externas y acceso de invitado en Azure.
- Describir el acceso condicional de Microsoft Entra.
- Descripción del control de acceso basado en roles (RBAC) de Azure.
- Descripción del concepto de Confianza cero.
- Descripción del propósito del modelo de defensa en profundidad.
- Descripción del propósito de Microsoft Defender for Cloud.


### Descripción de los servicios de directorio de Azure

**Microsoft Entra ID es un servicio de directorio** **que** le **permite** iniciar sesión y **acceder** tanto **a las aplicaciones en la nube** de Microsoft como a las aplicaciones en la nube que desarrolle. Microsoft Entra ID también puede ayudarle a mantener la implementación de Active Directory local.

En el caso de los entornos locales, Active Directory ejecutado en Windows Server proporciona un servicio de administración de acceso e identidades que administra su organización. **Microsoft Entra ID** es el **servicio de administración de identidades y acceso** basada en la nube de Microsoft. Con Microsoft Entra ID, usted controla las cuentas de identidad, pero Microsoft garantiza que el servicio esté disponible globalmente. Si ha trabajado con Active Directory, Microsoft Entra ID le resultará familiar.

Si protege las identidades de forma local con Active Directory, Microsoft no supervisa los intentos de inicio de sesión. Si conecta Active Directory con Microsoft Entra ID, Microsoft puede detectar intentos de inicio de sesión sospechosos para ayudarle a proteger su entorno sin costo adicional. Por ejemplo, Microsoft Entra ID puede detectar intentos de inicio de sesión desde ubicaciones inesperadas o dispositivos desconocidos.

#### ¿Quién usa Microsoft Entra ID?

Microsoft Entra ID es para:

- **Administradores de TI**. Los administradores pueden usar Microsoft Entra ID para controlar el acceso a las aplicaciones y los recursos en función de sus requisitos empresariales.
- **Desarrolladores de aplicaciones**. Con Microsoft Entra ID, los desarrolladores pueden agregar funcionalidad a las aplicaciones que compilan mediante un enfoque basado en estándares. Por ejemplo, pueden agregar funcionalidad de SSO a una aplicación o habilitar una aplicación para que funcione con las credenciales existentes de un usuario.
- **Usuarios**. Los usuarios pueden administrar sus identidades y realizar acciones de mantenimiento como el autoservicio de restablecimiento de contraseña.
- **Suscriptores de servicios en línea**. Los suscriptores de Microsoft 365, Microsoft Office 365, Azure y Microsoft Dynamics CRM Online ya usan Microsoft Entra ID para autenticarse en su cuenta.
- 
#### ¿Qué hace Microsoft Entra ID?

Microsoft Entra ID proporciona servicios como:

- **Autenticación**: esto incluye la **comprobación de** la **identidad** para acceder a aplicaciones y recursos. También incluye funciones como el autoservicio de restablecimiento de contraseña, la **autenticación multifactor**, una lista personalizada de contraseñas prohibidas y servicios de bloqueo inteligente.
- **Inicio de sesión único**: gracias al inicio de sesión único (SSO), los usuarios tienen que recordar un solo nombre de usuario y una sola contraseña para acceder a varias aplicaciones. Una sola identidad está asociada a un usuario, lo que simplifica el modelo de seguridad. Cuando los usuarios cambian de rol o dejan una organización, las modificaciones de acceso se asocian a esa identidad, lo que reduce considerablemente el esfuerzo necesario para cambiar o deshabilitar cuentas.
- **Administración de aplicaciones**: Con Microsoft Entra ID, puede administrar las aplicaciones en la nube y locales. Características como Application Proxy, las aplicaciones SaaS, el portal Aplicaciones y el inicio de sesión único proporcionan una mejor experiencia de usuario.
- **Administración de dispositivos**: Además de cuentas de usuarios individuales, Microsoft Entra ID admite el registro de dispositivos. El registro permite administrar los dispositivos a través de herramientas como Microsoft Intune. También permite que las directivas de acceso condicional basadas en dispositivos limiten los intentos de acceso a solo aquellos que proceden de dispositivos conocidos, independientemente de la cuenta de usuario solicitante.


#### ¿Puedo conectar mi AD local con Microsoft Entra ID?

Si tuviera un entorno local que ejecuta Active Directory y una implementación en la nube mediante Microsoft Entra ID, tendría que mantener dos conjuntos de identidades. Pero puede conectar Active Directory con Microsoft Entra ID, lo que permite una experiencia de identidad coherente entre la nube y el entorno local.

**Un método para conectar Microsoft Entra ID con su AD local es usar Microsoft Entra Connect**. Microsoft Entra Connect sincroniza las identidades de usuario entre Active Directory local y Microsoft Entra ID. Microsoft Entra Connect sincroniza los cambios entre ambos sistemas de identidades, para que pueda usar características como SSO, la autenticación multifactor y el autoservicio de restablecimiento de contraseña en ambos sistemas.

#### ¿Qué es Microsoft Entra Domain Services?

Microsoft Entra Domain Services (Azure AD DS) es un servicio que proporciona servicios de dominio administrados como, por ejemplo, unión a un dominio, directivas de grupo, protocolo ligero de acceso a directorios (LDAP) y autenticación Kerberos o NTLM. Al igual que Microsoft Entra ID le permite usar servicios de directorio sin tener que mantener la infraestructura que lo admite, gracias a Microsoft Entra Domain Services, obtiene la ventaja de los servicios de dominio sin necesidad de implementar, administrar y aplicar revisiones a los controladores de dominio (DC) en la nube.

Un dominio administrado de Microsoft Entra Domain Services le permite ejecutar aplicaciones heredadas en la nube que no pueden usar métodos de autenticación modernos o en las que no quiere que las búsquedas de directorio regresen siempre a un entorno de AD DS local. Esas aplicaciones heredadas se pueden migrar mediante "lift-and-shift" del entorno local a un dominio administrado, sin necesidad de administrar el entorno de AD DS en la nube.

Microsoft Entra Domain Services se integra con el inquilino de Microsoft Entra existente. Esta integración permite a los usuarios iniciar sesión en los servicios y las aplicaciones conectados al dominio administrado con sus credenciales existentes. También puede usar grupos y cuentas de usuario existentes para proteger el acceso a los recursos. Estas características proporcionan una migración mediante lift-and-shift más fluida de los recursos locales a Azure.

#### ¿Cómo funciona Microsoft Entra Domain Services?

Cuando cree un dominio administrado de Microsoft Entra Domain Services, defina un espacio de nombres único. Este espacio de nombres es el nombre de dominio. Después, se implementan dos controladores de dominio de Windows Server en la región de Azure seleccionada. Esta implementación de controladores de dominio se conoce como "conjunto de réplicas".

No es necesario administrar, configurar ni actualizar estos controladores de dominio. La plataforma Azure administra los controladores de dominio como parte del dominio administrado, incluidas las copias de seguridad y el cifrado en reposo mediante Azure Disk Encryption.

#### ¿La información está sincronizada?

Un dominio administrado está configurado para realizar una **sincronización unidireccional** desde Microsoft Entra ID a Microsoft Entra Domain Services. Puede crear los recursos directamente en el dominio administrado, pero no se vuelven a sincronizar con Microsoft Entra ID. En un entorno híbrido con un entorno de AD DS local, Microsoft Entra Connect sincroniza la información de identidad con Microsoft Entra ID, que se sincroniza posteriormente con el dominio administrado.

![[Pasted image 20231226160243.png]]

Las aplicaciones, los servicios y las máquinas virtuales de Azure que se conectan al dominio administrado pueden usar las características de Microsoft Entra Domain Services comunes, como unión a un dominio, directiva de grupo, LDAP y autenticación Kerberos o NTLM.

### Descripción de los métodos de autenticación de Azure

La autenticación es el proceso de establecimiento de la identidad de una persona, servicio y dispositivo. Requiere que la persona, el servicio o el dispositivo proporcionen algún tipo de credencial para demostrar quiénes son. La autenticación es como presentar su documento de identidad cuando viaja. No confirma que está registrado, solo demuestra que es quien dices que es. Azure admite varios **métodos de autenticación, incluidas las contraseñas estándar, el inicio de sesión único (SSO), la autenticación multifactor (MFA) y el acceso sin contraseña.**

Desde hace tiempo, la seguridad y la comodidad parecían estar en conflicto entre sí. Afortunadamente, las nuevas soluciones de autenticación proporcionan seguridad y comodidad.

En el diagrama siguiente se muestra el nivel de seguridad en comparación con la comodidad. Observe que la autenticación sin contraseña es alta seguridad y alta comodidad, mientras que las contraseñas por sí mismas son de baja seguridad pero alta comodidad.

![[Pasted image 20231226161013.png]]

#### ¿Qué es el inicio de sesión único?

El inicio de sesión único (SSO) **permite a los usuarios iniciar sesión una vez y utilizar esa credencial para acceder a varios recursos** y aplicaciones de distintos proveedores. Para que el inicio de sesión único funcione, las distintas aplicaciones y proveedores **deben confiar en el autenticador inicial**.

Más identidades significan más contraseñas para recordar y cambiar. Las directivas de contraseñas pueden variar entre las aplicaciones. A medida que aumentan los requisitos de complejidad, cada vez resultan más difíciles de recordar para los usuarios. Cuantas más contraseñas tenga que administrar un usuario, mayor será el riesgo de que se produzca alguna incidencia de seguridad relacionada con las credenciales.

Piense en el proceso de administrar todas estas identidades. Se ejerce una mayor presión en el departamento de soporte técnico cuando tienen que lidiar con los bloqueos de cuentas y las solicitudes de restablecimiento de contraseñas. Si un usuario deja una organización, puede resultar complicado hacer un seguimiento de todas sus identidades y asegurarse de que están deshabilitadas. Si se pasa por alto una identidad, es posible que se permita el acceso cuando debería haberse eliminado.

Con SSO, tan solo debe recordar un ID y una contraseña. El acceso a todas las aplicaciones se concede a una única identidad que está asociada a un usuario, lo que simplifica el modelo de seguridad. A medida que los usuarios cambian los roles o dejan una organización, el acceso está asociado a una única identidad. Este cambio reduce considerablemente el esfuerzo necesario para cambiar o deshabilitar cuentas. Usar el inicio de sesión único en las cuentas permite a los usuarios administrar su identidad y al equipo de TI gestionar los usuarios con mayor facilidad.

	 Importante

	El inicio de sesión único solo es tan seguro como el autenticador inicial, ya que todas las conexiones posteriores se basan en la seguridad del autenticador inicial.

#### ¿Qué es la autenticación multifactor?

La autenticación multifactor es el **proceso de solicitar a un usuario una forma adicional** (o factor) **de identificación** durante el proceso de inicio de sesión. La MFA ayuda a protegerse frente a las contraseñas en riesgo en situaciones en las que la contraseña se vio comprometida, pero el segundo factor no.

Piense en cómo inicia sesión en los sitios web, el correo electrónico o los servicios en línea. Después de escribir el nombre de usuario y la contraseña, ¿alguna vez ha tenido que escribir un código que ha recibido en el teléfono? Si es así, ha usado la autenticación multifactor para iniciar sesión.

La autenticación multifactor **proporciona seguridad adicional** a las identidades, ya que se requieren dos o más elementos para una autenticación completa. **Estos elementos se dividen en tres categorías**:

- **Algo que el usuario sabe**: puede ser una pregunta de seguridad.
- **Algo que el usuario tiene**: se puede tratar de un código que se envía al teléfono móvil del usuario.
- **Algo que el usuario es**: normalmente, algún tipo de propiedad biométrica, como la huella dactilar o el escaneo facial.

La autenticación multifactor aumenta la seguridad de las identidades al limitar el impacto de la exposición de credenciales (por ejemplo, nombres de usuario y contraseñas robados). Si la autenticación multifactor está habilitada, los atacantes que tengan la contraseña de un usuario también necesitarán su teléfono o su huella dactilar para completar la autenticación.

Compare la autenticación multifactor con la autenticación de un solo factor. En la autenticación de un solo factor, los atacantes solo necesitarían el nombre de usuario y la contraseña para autenticarse. La autenticación multifactor se debe habilitar siempre que sea posible, ya que aporta enormes ventajas a la seguridad.

##### ¿Qué es la autenticación multifactor de Microsoft Entra?

La autenticación multifactor de Microsoft Entra es un servicio de Microsoft que proporciona funcionalidades de autenticación multifactor. La autenticación multifactor de Microsoft Entra permite a los usuarios elegir una forma adicional de autenticación durante el inicio de sesión, como una llamada telefónica o una notificación de aplicación móvil.

#### ¿Qué es la autenticación sin contraseña?

El uso de características como la autenticación multifactor constituye una excelente manera de proteger una organización. Sin embargo, sumar esta capa de seguridad adicional al hecho de tener que recordar las contraseñas suele frustrar a los usuarios. Es más probable que las personas cumplan cuando sea fácil y conveniente hacerlo. Los métodos de autenticación sin contraseña resultan más cómodos, ya que **la contraseña se quita y se reemplaza por algo que se tiene más algo que se es o se sabe**.

La autenticación sin contraseña debe configurarse en un dispositivo para que funcione. Por ejemplo, su ordenador es algo que tiene. Una vez que se haya registrado o inscrito, Azure ahora sabrá que está asociado a usted. **Ahora que se conoce el equipo, una vez que proporcione algo que sepa o sea (por ejemplo, un PIN o una huella digital), se podrá autenticar sin usar una contraseña**.

Cada organización tiene diferentes necesidades en cuanto a la autenticación. Microsoft Azure global y Azure Government ofrecen las siguientes tres opciones de autenticación sin contraseña que se integran con Microsoft Entra ID:

- Windows Hello para empresas
- Aplicación Microsoft Authenticator
- Claves de seguridad FIDO2

##### Windows Hello para empresas

Windows Hello para empresas resulta muy conveniente para los trabajadores de la información que tienen su propio equipo con Windows designado. La información biométrica y las credenciales de PIN están vinculadas directamente al equipo del usuario, lo que impide el acceso de cualquier persona que no sea el propietario. Con la integración de la infraestructura de clave pública (PKI) y la compatibilidad integrada con el inicio de sesión único (SSO), Windows Hello para empresas ofrece un método sencillo y práctico de acceder directamente a los recursos corporativos del entorno local y la nube.

##### Aplicación Microsoft Authenticator

También puede permitir que el teléfono del empleado se convierta en un método de autenticación sin contraseña. Es posible que ya esté utilizando la aplicación Microsoft Authenticator como una opción de autenticación multifactor cómoda, además de una contraseña. También puede usar la aplicación Authenticator como una opción sin contraseña.

La aplicación Authenticator **convierte cualquier teléfono** Android o iOS **en una credencial segura sin contraseña**. Los usuarios pueden iniciar sesión en cualquier plataforma o explorador con este proceso: reciben una notificación en su teléfono, comprueban que el número mostrado en la pantalla coincide con el de su teléfono y, a continuación, usan datos biométricos (huella dactilar o reconocimiento facial) o el PIN para confirmarlo. Consulte Descarga e instalación de la aplicación Microsoft Authenticator para conocer los detalles de la instalación.

##### Claves de seguridad FIDO2

FIDO (Fast IDentity Online) Alliance ayuda a promover los estándares de autenticación abiertos y a reducir el uso de contraseñas como forma de autenticación. FIDO2 es el estándar más reciente que incorpora el estándar de autenticación web (WebAuthn).

Las claves de seguridad FIDO2 son un **método de autenticación sin contraseña basado en estándares** que no permite la suplantación de identidad y que puede venir en cualquier factor de forma. Fast Identity Online (FIDO) es un estándar abierto para la autenticación sin contraseña. FIDO permite a los usuarios y a las organizaciones aprovechar el estándar para iniciar sesión en sus recursos sin un nombre de usuario o una contraseña mediante una clave de seguridad externa o una clave de plataforma integrada en un dispositivo.

Los usuarios pueden registrarse y luego seleccionar una llave de seguridad de FIDO2 en la interfaz de inicio de sesión como medio principal de autenticación. Estas llaves de seguridad de FIDO2 suelen ser dispositivos USB, pero también pueden usar Bluetooth o NFC. Con un dispositivo de hardware que controla la autenticación, se aumenta la seguridad de una cuenta, ya que no hay ninguna contraseña que pueda quedar expuesta ni adivinarse.

### Descripción de identidades externas de Azure

Una identidad externa **es una persona, un dispositivo, un servicio, etc. que está fuera de la organización**. Microsoft Entra External ID hace referencia a todas las formas en las que puede interactuar de forma segura con usuarios fuera de su organización. Si quiere colaborar con asociados, distribuidores o proveedores, puede compartir los recursos y definir cómo los usuarios internos pueden acceder a organizaciones externas. Si es un desarrollador que crea aplicaciones orientadas al consumidor, puede administrar las experiencias de identidad de los clientes.

Las identidades externas pueden parecerse al inicio de sesión único. Con External Identities, los usuarios externos pueden "traer sus propias identidades". Tanto si tienen una identidad digital corporativa o gubernamental, como una identidad social no administrada, como Google o Facebook, pueden usar sus propias credenciales para iniciar sesión. El proveedor de identidades administra la identidad del usuario externo y el usuario administra el acceso a sus aplicaciones con Microsoft Entra ID o Azure AD B2C para mantener protegidos los recursos.

![[Pasted image 20231226164733.png]]

Las siguientes funcionalidades componen External Identities:

- **Colaboración de empresa a empresa (B2B)**: colabore con usuarios externos y permítales usar su identidad preferida para iniciar sesión en las aplicaciones de Microsoft u otras aplicaciones empresariales (aplicaciones SaaS, aplicaciones desarrolladas de forma personalizada, etc.). Los usuarios de colaboración B2B se representan en el directorio, normalmente como usuarios invitados.
- **Conexión directa B2B**: Establezca una confianza mutua y de dos sentidos con otra organización de Microsoft Entra para una colaboración sin problemas. La conexión directa B2B actualmente es compatible con los canales compartidos de Teams, lo que permite a los usuarios externos acceder a sus recursos desde sus instancias principales de Teams. Los usuarios de conexión directa B2B no se representan en el directorio, pero son visibles desde el canal compartido de Teams y se pueden supervisar en Teams informes del centro de administración.
- **Empresa a cliente de Microsoft Entra (B2C)**: publique aplicaciones SaaS modernas o aplicaciones desarrolladas de forma personalizada (excepto aplicaciones de Microsoft) para consumidores y clientes, mientras usa Azure AD B2C para la administración de identidades y acceso.


En función de cómo quiera interactuar con organizaciones externas y los tipos de recursos que necesite compartir, puede usar una combinación de estas funcionalidades.

Con Microsoft Entra ID, puede habilitar fácilmente la colaboración entre distintas organizaciones mediante la característica B2B de Microsoft Entra. Los usuarios invitados de otros inquilinos pueden ser invitados por los administradores o por otros usuarios. Esta capacidad también se aplica a las identidades sociales como las cuentas Microsoft.

También puede asegurarse fácilmente de que los usuarios invitados tengan el acceso adecuado. Puede pedir a los invitados o a quien decida en su lugar que participen en una revisión de acceso y vuelvan a certificar (o atestiguar) el acceso de los invitados. Los revisores pueden dar su aprobación para cada necesidad de acceso continuado de los usuarios, en función de las sugerencias de Microsoft Entra ID. Cuando una revisión de acceso haya terminado, es posible hacer cambios y retirar la concesión de acceso a los invitados que ya no lo necesitan.

### Descripción del acceso condicional de Azure

**El acceso condicional es una herramienta que usa Microsoft Entra ID para permitir (o denegar) el acceso a los recursos en función de señales de identidad**. Estas señales incluyen quién es el usuario, dónde se encuentra y desde qué dispositivo solicita el acceso.

Con el acceso condicional, los administradores de TI pueden:

- permitir a los usuarios ser productivos en cualquier momento y lugar;
- proteger los recursos de la organización.

El acceso condicional también **proporciona una experiencia de autenticación multifactor** más pormenorizada para los usuarios. Por ejemplo, es posible que al usuario no se le solicite un segundo factor de autenticación si está en una ubicación conocida. Pero si sus señales de inicio de sesión son inusuales o su ubicación es inesperada, es posible que se le exija un segundo factor de autenticación.

Durante el inicio de sesión, el acceso condicional recopila señales del usuario, toma decisiones basadas en esas señales y, después, aplica esa decisión para permitir o denegar la solicitud de acceso, o bien exigir una respuesta de autenticación multifactor.

En el diagrama siguiente se muestra este flujo:

![[Pasted image 20231226165710.png]]

En este caso, la señal podría ser la ubicación del usuario, su dispositivo o la aplicación a la que intenta acceder.

En función de estas señales, la decisión puede ser permitir el acceso completo si el usuario inicia sesión desde su ubicación habitual. Si el usuario inicia sesión desde una ubicación inusual o una ubicación marcada como de alto riesgo, el acceso puede bloquearse por completo, o bien podría concederse después de que el usuario proporcione una segunda forma de autenticación.

La aplicación es la acción que lleva a cabo la decisión. Por ejemplo, la acción es permitir el acceso o exigir al usuario que proporcione una segunda forma de autenticación.

#### ¿Cuándo se puede usar el acceso condicional?

El acceso condicional resulta útil en los casos siguientes:

- **Exija la autenticación multifactor (MFA) para acceder a una aplicación en función del rol, la ubicación o la red del solicitante**. Por ejemplo, podría requerir MFA para administradores, pero no para usuarios normales o personas que se conectan desde fuera de la red corporativa.
- **Para requerir el acceso a los servicios solo a través de aplicaciones cliente aprobadas**. Por ejemplo, podría limitar qué aplicaciones de correo electrónico pueden conectarse al servicio de correo electrónico.
- **Exija que los usuarios accedan a la aplicación solo desde dispositivos administrados**. Un dispositivo administrado es un dispositivo que cumple los estándares de seguridad y cumplimiento.
- **Para bloquear el acceso desde orígenes que no son de confianza**, como ubicaciones desconocidas o inesperadas.

### Descripción del control de acceso basado en roles de Azure

Cuando tenemos varios equipos de TI e ingeniería, ¿cómo podemos controlar el acceso que tienen a los recursos del entorno de nube? **El principio de privilegios mínimos indica que solo debe conceder acceso al nivel necesario para completar una tarea**. Si solo necesita acceso de lectura a un blob de almacenamiento, solo se le debe conceder acceso de lectura a ese blob de almacenamiento. No se debe conceder acceso de escritura a ese blob ni debe tener acceso de lectura a otros blobs de almacenamiento. Es una buena práctica de seguridad seguir.

Pero, administrar ese nivel de permisos para todo el equipo se volvería tedioso. En vez de definir los requisitos de acceso detallados de cada individuo y, después, ir actualizándolos a medida que se vayan creando más recursos o se unan nuevos miembros al equipo, **Azure permite controlar el acceso a través del control de acceso basado en roles de Azure (RBAC de Azure)**.

Azure proporciona roles integrados que describen las reglas de acceso comunes de los recursos en la nube. También podemos definir nuestros propios roles. Cada rol tiene un conjunto asociado de permisos de acceso que tienen que ver con ese rol. Cuando se asignan usuarios o grupos a uno o varios roles, reciben todos los permisos de acceso asociados.

Por lo tanto, si contrata a un nuevo ingeniero y los agrega al grupo RBAC de Azure para ingenieros, obtiene de forma automática el mismo acceso que los otros ingenieros del mismo grupo de RBAC de Azure. De forma similar, si agrega recursos adicionales y apunta RBAC de Azure en ellos, todos los usuarios de ese grupo de RBAC de Azure tendrán esos permisos en los nuevos recursos, así como en los recursos existentes.

#### ¿Cómo se aplica el control de acceso basado en roles a los recursos?

El control de acceso basado en roles **se aplica a un ámbito, que es un recurso o un conjunto de recursos** en los que este acceso se permite.

En este diagrama se muestra la relación entre roles y ámbitos. Un grupo de administración, una suscripción o un grupo de recursos podría tener el rol de propietario, por lo que se ha aumentado el control y la autoridad. A un observador, que no se espera que realice ninguna actualización, se le puede asignar un rol de Lector para el mismo ámbito, lo que le permitiría revisar u observar el grupo de administración, la suscripción o el grupo de recursos.

![[Pasted image 20231226171213.png]]

Los ámbitos pueden ser lo siguiente:

- Un grupo de administración (una colección de varias suscripciones)
- Una sola suscripción
- Un grupo de recursos.
- Un solo recurso

Los observadores, los usuarios que administran recursos, los administradores y los procesos automatizados muestran los tipos de usuarios o cuentas que se suelen asignar a cada uno de los distintos roles.

RBAC de Azure es jerárquico, ya que al conceder acceso en un ámbito primario, todos los ámbitos secundarios heredan esos permisos. Por ejemplo:

- Cuando asignamos el rol Propietario a un usuario en el ámbito del grupo de administración, dicho usuario podrá administrar todo el contenido de todas las suscripciones dentro de ese grupo de administración.
- Cuando asignamos el rol Lector a un grupo en el ámbito de suscripción, los miembros de dicho grupo podrán ver todos los grupos de recursos y recursos dentro de esa suscripción.

#### ¿Cómo se aplica RBAC de Azure?

RBAC de Azure se aplica a cualquier acción que se inicie en un recurso de Azure que pasa por Azure Resource Manager. Resource Manager es un servicio de administración que proporciona una forma de organizar y proteger nuestros recursos en la nube.

Normalmente, se accede a Resource Manager a través de Azure Portal, Azure Cloud Shell, Azure PowerShell y la CLI de Azure. **RBAC de Azure no aplica permisos de acceso en el nivel de aplicación ni de datos.** La seguridad de la aplicación debe controlarla la propia aplicación.

RBAC de Azure emplea un modelo de permisos. Cuando se le asigna un rol, RBAC de Azure le permite realizar acciones dentro del ámbito de ese rol. Si una asignación de roles nos concede permisos de lectura a un grupo de recursos y otra asignación de roles nos concede permisos de escritura al mismo grupo de recursos, tendremos permisos tanto de lectura como de escritura en ese grupo de recursos.

### Descripción del modelo de Confianza cero

Confianza cero es un **modelo de seguridad que supone el peor de los escenarios posibles y protege los recursos con esa expectativa**. Confianza cero presupone que hay una vulneración y comprueba todas las solicitudes como si provinieran de una red no controlada.

En la actualidad, las organizaciones necesitan un modelo de seguridad nuevo que se adapte eficazmente a la complejidad del entorno moderno, adopte los recursos móviles y proteja a personas, dispositivos, aplicaciones y datos dondequiera que se encuentren.

Para abordar este nuevo mundo informático, Microsoft recomienda encarecidamente el modelo de seguridad de Confianza cero, que se basa en estos principios rectores:

- **Comprobar explícitamente**: realice siempre las operaciones de autorización y autenticación en función de todos los puntos de datos disponibles.
- **Usar el acceso de privilegios mínimos**: limite el acceso de los usuarios con Just-in-Time y Just-Enough-Access (JIT/JEA), directivas que se adaptan al nivel de riesgo y protección de datos.
- **Asumir que hay ataques**: minimice el radio de expansión y el acceso a los segmentos. Comprobación del cifrado de un extremo a otro. Utilice el análisis para obtener visibilidad, impulsar la detección de amenazas y mejorar las defensas.


#### Ajuste a Confianza cero

Tradicionalmente, las redes corporativas estaban restringidas, protegidas y, por lo general, eran seguras. Solo los equipos administrados se podían unir a la red, el acceso VPN estaba estrechamente controlado y los dispositivos personales estaban restringidos o bloqueados con frecuencia.

El modelo de Confianza cero revoluciona ese escenario. En lugar de suponer que un dispositivo es seguro porque está dentro de la red corporativa, exige que todos los usuarios se autentiquen. Después, concede acceso basado en la autenticación, no de la ubicación.

![[Pasted image 20231226172527.png]]

### Descripción de defensa en profundidad

El objetivo de la defensa en profundidad es **proteger la información y evitar que personas no autorizadas puedan acceder a ella**.

Una estrategia de defensa en profundidad usa una serie de mecanismos para ralentizar el avance de un ataque dirigido a adquirir acceso no autorizado a los datos.

#### Capas de defensa en profundidad

Puede visualizar la defensa en profundidad como un conjunto de capas, con los datos que se van a proteger en el centro y todas las demás capas en funcionamiento para proteger esa capa de datos central.

![[Pasted image 20231226172804.png]]

Cada capa proporciona protección de modo que, si se produce una brecha en una capa, ya existe otra en funcionamiento para evitar una mayor exposición. Este enfoque elimina la dependencia de cualquier capa de protección única. Ralentiza un ataque y proporciona información de alertas sobre la que pueden actuar los equipos de seguridad, ya sea de forma automática o manual.

Aquí tiene una breve descripción del rol de cada capa:

- La capa de seguridad física es la primera línea de defensa para proteger el hardware informático del centro de datos.
- La capa de identidad y acceso controla el acceso a la infraestructura y al control de cambios.
- La capa perimetral usa protección frente a ataques de denegación de servicio distribuido (DDoS) para filtrar los ataques a gran escala antes de que puedan causar una denegación de servicio para los usuarios.
- La capa de red limita la comunicación entre los recursos a través de controles de acceso y segmentación.
- La capa de proceso protege el acceso a las máquinas virtuales.
- La capa de aplicación ayuda a garantizar que las aplicaciones sean seguras y estén libres de vulnerabilidades de seguridad.
- La capa de datos controla el acceso a los datos empresariales y de clientes que es necesario proteger.

Estas capas proporcionan una guía para ayudarle a tomar decisiones de configuración de seguridad en todas las capas de las aplicaciones.

Azure proporciona herramientas y características de seguridad en todas las capas del concepto de defensa en profundidad. Veamos cada capa con más detalle:

##### Seguridad física

La protección física del **acceso a los edificios y el control del acceso al hardware** de proceso del centro de datos son la primera línea de defensa.

La intención de la seguridad física es proporcionar medidas de seguridad físicas contra el acceso a los recursos. Estas medidas garantizan que no se puedan omitir otras capas y se controle apropiadamente la pérdida o el robo. Microsoft usa varios mecanismos de seguridad físicos en sus centros de datos de la nube.

##### Identidad y acceso

La capa de identidad y acceso **consiste en garantizar que las identidades están protegidas**, que solo se otorga el acceso necesario y que se registran los cambios y los eventos de inicio de sesión.

En esta capa, es importante que realice lo siguiente:

- Controle el acceso a la infraestructura y al control de cambios.
- Use el inicio de sesión único (SSO)y la autenticación multifactor.
- Audite los eventos y los cambios.

##### Perímetro

El perímetro de la red **protege frente a ataques basados en red contra los recursos**. Identificar estos ataques, eliminar sus repercusiones y recibir alertas sobre ellos cuando suceden son formas importantes de proteger la red.

En esta capa, es importante que realice lo siguiente:

- Use protección contra DDoS para filtrar los ataques a gran escala antes de que puedan afectar a la disponibilidad de un sistema para los usuarios.
- Use firewalls perimetrales para identificar los ataques malintencionados contra la red y alertar sobre ellos.

##### Red

En esta capa, el enfoque está en **limitar la conectividad de la red en todos los recursos para permitir solo la necesaria**. Al limitar esta comunicación, se reduce el riesgo de que se propaguen los ataques a otros sistemas de la red.

En esta capa, es importante que realice lo siguiente:

- Limite la comunicación entre los recursos.
- Deniegue de forma predeterminada.
- Restrinja el acceso entrante de Internet y limite el saliente cuando sea apropiado.
- Implemente conectividad segura a las redes locales.

##### Compute

El software malintencionado, los sistemas sin revisiones aplicadas y los sistemas protegidos inadecuadamente abren el entorno a los ataques. El enfoque en esta capa es **asegurarse de que sus recursos de proceso estén seguros y de que cuenta con los controles adecuados para minimizar los problemas de seguridad**.

En esta capa, es importante que realice lo siguiente:

- Proteja el acceso a las máquinas virtuales.
- Implemente la protección del punto de conexión de los dispositivos y mantenga los sistemas revisados y actualizados.

##### Aplicación

**La integración de la seguridad** en el ciclo de vida de desarrollo de aplicaciones **ayuda a reducir el número de vulnerabilidades en el código**. Todos los equipos de desarrollo deberían asegurarse de que sus aplicaciones son seguras de forma predeterminada.

En esta capa, es importante que realice lo siguiente:

- Garantice que las aplicaciones son seguras y están libres de vulnerabilidades.
- Almacene los secretos de aplicación confidenciales en un medio de almacenamiento seguro.
- Convierta la seguridad en un requisito de diseño en todo el desarrollo de aplicaciones.

##### Datos

**Los que almacenan y controlan el acceso a los datos son responsables de asegurarse de que están protegidos correctamente**. A menudo, **los requisitos legales dictan los controles y procesos** que deben cumplirse para garantizar la confidencialidad, la integridad y la disponibilidad de los datos.

En casi todos los casos, los atacantes intentan conseguir datos:

- Almacenados en una base de datos.
- Almacenados en discos en máquinas virtuales.
- Almacenados en aplicaciones de software como servicio (SaaS), como Office 365.
- Administrados mediante el almacenamiento en la nube.

### Descripción de Microsoft Defender for Cloud

Microsoft Defender for Cloud es una **herramienta de supervisión para la administración de la posición de seguridad y la protección contra amenazas**. Supervisa los entornos en la nube, locales, híbridos y multinube para ofrecer instrucciones y notificaciones destinadas a reforzar la posición de seguridad.

Defender for Cloud proporciona las herramientas necesarias para proteger los recursos, realizar un seguimiento de su posición de seguridad, protegerse frente a ciberataques y simplificar la administración de la seguridad. La implementación de Defender for Cloud es fácil, ya está integrada de forma nativa en Azure.

#### Protección allá donde se implemente

Dado que Defender for Cloud es un servicio nativo de Azure, muchos servicios de Azure se supervisan y protegen sin necesidad de ninguna implementación. Pero si también tiene un centro de datos local o también está funcionando en otro entorno en la nube, es posible que la supervisión de los servicios de Azure no le proporcione una imagen completa de su situación de seguridad.

Cuando sea necesario, Defender for Cloud **puede implementar automáticamente un agente de Log Analytics para recopilar datos relacionados con la seguridad**. En el caso de las máquinas de Azure, la implementación se controla directamente. Para entornos híbridos y de varias nubes, los planes de **Microsoft Defender se amplían a máquinas que no son de Azure con la ayuda de Azure Arc**. Las características de la Administración de la posición de seguridad en la nube (CSPM) se amplían a máquinas de varias nubes sin necesidad de ningún agente.

##### Protecciones nativas de Azure

Defender for Cloud le **permite detectar amenazas en**:

- **Servicios de PaaS** de Azure: puede **detectar amenazas dirigidas a servicios de Azure** como Azure App Service, Azure SQL, la cuenta de Azure Storage y otros servicios de datos. También puede realizar la detección de anomalías en los registros de actividad de Azure mediante la integración nativa con Microsoft Defender para aplicaciones en la nube (anteriormente conocido como Microsoft Cloud App Security).
- **Servicios de datos** de Azure: Defender for Cloud incluye capacidades que le ayudarán a **clasificar automáticamente los datos en Azure SQL**. También puede obtener evaluaciones de las posibles vulnerabilidades en los servicios de Azure SQL y Azure Storage, además de recomendaciones sobre cómo mitigarlas.
- **Redes**: Defender for Cloud le permite **limitar la exposición a los ataques por fuerza bruta**. Si reduce el acceso a los puertos de las máquinas virtuales mediante el acceso de máquina virtual Just-In-Time, puede proteger la red al prevenir el acceso innecesario. Puede establecer directivas de acceso seguro en los puertos seleccionados, solo para usuarios autorizados, direcciones IP o intervalos de direcciones IP de origen permitidos y durante un período limitado.

##### Defensa de los recursos híbridos

Además de defender el entorno de Azure, puede **agregar funcionalidades** de Defender for Cloud **a su entorno de nube híbrida** para proteger los servidores que no sean de Azure. Obtenga inteligencia personalizada sobre las amenazas y alertas prioritarias según su entorno específico para que pueda centrarse en lo que más le importa.

**Para ampliar la protección a las máquinas locales, implemente Azure Arc y habilite las características de seguridad mejoradas de Defender for Cloud.**

##### Defensa de los recursos que se ejecutan en otras nubes

Defender for Cloud también puede proteger los recursos de otras nubes (como AWS y GCP).

Por ejemplo, si ha conectado una cuenta de Amazon Web Services (AWS) a una suscripción de Azure, puede habilitar cualquiera de estas protecciones:

- Las características de CSPM de Defender for Cloud se extienden a los recursos de AWS. Este plan sin agente evalúa los recursos de AWS según las recomendaciones de seguridad específicas de AWS e incluye los resultados en la puntuación de seguridad. También se evaluará el cumplimiento de los recursos de los estándares integrados específicos de AWS (AWS CIS, AWS PCI DSS y Procedimientos recomendados de seguridad fundamentales de AWS). La página de inventario de recursos de Defender for Cloud es una **característica habilitada para varias nubes que permite administrar los recursos de AWS junto con los de Azure**.
- Microsoft Defender **para contenedores** amplía la detección de amenazas de contenedores y defensas avanzadas a los clústeres Linux de Amazon EKS.
- Microsoft Defender **para servidores** proporciona detección de amenazas y defensas avanzadas en las instancias de EC2 con Windows y Linux.

#### Evaluación, protección y defensa

Defender for Cloud cubre tres necesidades vitales a medida que administra la seguridad de los recursos y las cargas de trabajo en la nube y en el entorno local:

- **Evaluación continua**: conozca la posición de seguridad. Identifique y realice un seguimiento de las vulnerabilidades.
- **Protección**: proteja los recursos y los servicios con Azure Security Benchmark.
- **Defensa**: detecte y resuelva las amenazas a recursos, cargas de trabajo y servicios.

![[Pasted image 20231226181137.png]]

##### Evaluación continua

Defender for Cloud le ayuda a evaluar continuamente su entorno. **Incluye soluciones de evaluación de vulnerabilidades** para las máquinas virtuales, los registros de contenedor y los servidores de SQL.

Microsoft Defender para servidores incluye integración nativa automática con Microsoft Defender para puntos de conexión. Si ha habilitado esta integración, tendrá acceso a los hallazgos relacionados con vulnerabilidades de la administración de amenazas y vulnerabilidades de Microsoft.

Entre estas herramientas de evaluación tendrá exámenes de vulnerabilidades regulares y detallados que cubren el proceso, los datos y la infraestructura. Puede revisar los resultados de estos exámenes desde Defender for Cloud y responder a ellos.

##### Seguridad

Desde los métodos de autenticación hasta el control de acceso y el concepto de Confianza cero, **la seguridad en la nube es un aspecto esencial** que debe realizarse correctamente. Para estar protegido en la nube, **debe asegurarse de que las cargas de trabajo son seguras**. Para proteger las cargas de trabajo, **necesita directivas de seguridad** que se adapten a su entorno y situación. Como **las directivas** de Defender for Cloud **se crean sobre los controles de directivas de Azure**, puede obtener la gama completa y la flexibilidad de una solución de directivas de primer nivel. En Defender for Cloud, **puede establecer que las directivas se ejecuten en grupos de administración**, entre distintas suscripciones e incluso en un inquilino completo.

Una de las ventajas de pasar a la nube es la capacidad de crecer y escalar en función de sus necesidades, lo que agrega nuevos servicios y recursos según sea necesario. Defender for Cloud supervisa constantemente los nuevos recursos que se implementan en las cargas de trabajo. **Defender for Cloud evalúa si los nuevos recursos están configurados según los procedimientos recomendados de seguridad**. Si no es así, se marcan y se obtiene una lista prioritaria de recomendaciones para lo que necesita corregir. Las recomendaciones le permitirán disminuir la superficie expuesta a ataques en cada uno de los recursos.

La lista de recomendaciones está habilitada y es compatible con Azure Security Benchmark. Este punto de referencia es el conjunto de directrices específico de Azure y creado por Microsoft relativo a los procedimientos recomendados de seguridad y cumplimiento basados en marcos de cumplimiento comunes.

De este modo, Defender for Cloud le permite no solo establecer directivas de seguridad, sino también aplicar estándares de configuración segura en todos los recursos.

Para ayudarle a conocer el grado de importancia que tiene cada una de las recomendaciones en su postura global acerca de la seguridad, **Defender for Cloud agrupa las recomendaciones en controles de seguridad y agrega un valor de puntuación de la seguridad a cada control**. La puntuación de seguridad le proporciona un indicador a simple vista del estado de su posición de seguridad, mientras que los controles le proporcionan una lista de trabajo de las cosas que se deben tener en cuenta para mejorar la puntuación de seguridad y la posición de seguridad general.

![[Pasted image 20231226182922.png]]

##### Defensa

Las dos primeras áreas se centraban en evaluar, supervisar y mantener su entorno. Defender for Cloud también le permite defender su entorno proporcionando **alertas de seguridad y características avanzadas de protección contra amenazas**.

###### Alertas de seguridad

**Cuando Defender** para la nube **detecta una amenaza en cualquier área del entorno, genera una alerta de seguridad**. Alertas de seguridad:

- Descripción de los detalles de los recursos afectados
- Sugerencia de pasos para la corrección
- Suministro, en algunos casos, de una opción para desencadenar una aplicación lógica en la respuesta

Tanto si Defender para la nube genera una alerta como si la recibe desde un producto de seguridad integrado, puede exportarla. La protección contra amenazas de **Defender** para la nube **incluye el análisis de la cadena de eliminación de fusión**, que correlaciona de manera automática las alertas del entorno en función del análisis Cyber Kill Chain, para ayudarle a comprender mejor todo el proceso de un ataque, dónde empezó y qué tipo de impacto tuvo en los recursos.

###### Protección contra amenazas avanzada

Defender for Cloud proporciona características avanzadas de protección contra amenazas para muchos de los recursos implementados, incluidas las máquinas virtuales, las bases de datos SQL, los contenedores, las aplicaciones web y la red. Entre las protecciones se incluyen la **protección de los puertos de administración** de las VM con acceso Just-in-Time y **controles de aplicaciones adaptables** para crear listas de permitidos con las aplicaciones que deben o no ejecutarse en las máquinas.

### Prueba de Conocimientos

1. ¿Qué herramienta de Microsoft Entra puede cambiar las credenciales necesarias para iniciar sesión en función de las señales, como dónde se encuentra el usuario?

<details>
	<summary>Respuesta</summary>
	<p>El <b>acceso condicional</b> es una herramienta que usa Microsoft Entra ID para permitir (o denegar) el acceso a los recursos en función de señales de identidad. Acceso condicional puede cuestionar un segundo factor de autenticación si las señales de inicio de sesión son inusuales o proceden desde una ubicación inesperada.</p>
</details>

2. ¿Qué modelo de seguridad supone el peor escenario de seguridad y protege los recursos en consecuencia?

<details>
	<summary>Respuesta</summary>
	<p><b>Confianza cero</b> es un modelo de seguridad que supone el peor de los escenarios posibles y protege los recursos con esa expectativa.</p>
</details>

3. A un usuario se le asignan simultáneamente varios roles que usan el control de acceso basado en rol. ¿Cuáles son sus permisos reales? Los permisos de rol son: Rol 1: leer || Rol 2: escritura || Rol 3: lectura y escritura.

<details>
	<summary>Respuesta</summary>
	<p><b>Lectura y escritura.</b> El control de acceso basado en rol, mediante un modelo de permiso, concede todos los permisos asignados en todos los roles asignados.</p>
</details>

### Resumen

En este módulo, ha obtenido información sobre la identidad, el acceso, y las herramientas y servicios de seguridad de Azure. Ha tratado los métodos de autenticación, incluidos los que son más seguros. Ha descubierto cómo restringir el acceso en función de un rol para ayudar a crear un entorno más seguro. Y ha obtenido información sobre los modelos de defensa en profundidad y Confianza cero.

#### Objetivos de aprendizaje

Ahora debería ser capaz de hacer lo siguiente:

- Descripción de los servicios de directorio en Azure, incluidos Microsoft Entra ID y Microsoft Entra Domain Services.
- Descripción de los métodos de autenticación en Azure, incluido el inicio de sesión único (SSO), la autenticación multifactor (MFA) y sin contraseña.
- Descripción de identidades externas y acceso de invitado en Azure.
- Describir el acceso condicional de Microsoft Entra.
- Descripción del control de acceso basado en roles (RBAC) de Azure.
- Descripción del concepto de Confianza cero.
- Descripción del propósito del modelo de defensa en profundidad.
- Descripción del propósito de Microsoft Defender for Cloud.

#### Recursos adicionales

Los recursos siguientes proporcionan más información sobre los temas de este módulo o relacionados con este módulo.

- [Microsoft Certified: Security, Compliance, and Identity Fundamentals](https://learn.microsoft.com/es-es/learn/certifications/security-compliance-and-identity-fundamentals/) es una certificación completa, con formación asociada dedicada a ayudarle a comprender y administrar mejor la seguridad, el cumplimiento y la identidad.

# Aspectos básicos de Microsoft Azure: Descripción de la administración y la gobernanza de Azure

## Descripción de la administración de costos en Azure

### Introducción

En este módulo, se presentarán los factores que afectan a los costos en Azure y las herramientas para ayudar a predecir los costos potenciales y supervisar y controlar los costos.

#### Objetivos de aprendizaje

Después de completar este módulo, podremos:

- Describir los factores que pueden afectar a los costos en Azure.
- Comparación de la calculadora de precios de Azure y la calculadora del coste total de propiedad (TCO).
- Describir la herramienta Microsoft Cost Management.
- Descripción de la finalidad de las etiquetas.

### Descripción de los factores que pueden afectar a los costos en Azure

Azure desplaza los costos de desarrollo del gasto de capital (CapEx) de la construcción y mantenimiento de la infraestructura y las instalaciones a un gasto operativo (OpEx) de alquiler de la infraestructura según la necesite, ya sea de proceso, de almacenamiento, redes, etc.

Ese costo de OpEx puede verse afectado por muchos factores. Algunos de los factores que afectan son los siguientes:

- Tipo de recurso
- Consumo
- Mantenimiento
- Geografía
- Tipo de suscripción
- Azure Marketplace

#### Tipo de recurso

Varios factores influyen en el costo de los recursos de Azure. El tipo de recursos, la configuración del recurso y la región de Azure afectarán cuánto cuesta un recurso. Al aprovisionar un recurso de Azure, **Azure crea instancias de uso medido para ese recurso. Los medidores realizan el seguimiento del uso de los recursos y generan un registro de uso que se usa para calcular la factura**.

##### Ejemplos

Con una **cuenta de almacenamiento**, se **especifica un tipo** como blob, un **nivel de rendimiento**, un **nivel de acceso**, una **configuración de redundancia** y una **región**. La creación de la misma cuenta de almacenamiento en otras regiones puede mostrar otros costos y el cambio de cualquiera de las opciones de configuración también puede afectar al precio.

![[Pasted image 20231226190304.png]]

Con una **máquina virtual** (VM), es posible que **tenga que considerar** la posibilidad de licencias para el **sistema operativo** u otro software, **el procesador y el número de núcleos** de la máquina virtual, el **almacenamiento** conectado y la interfaz de red. Como sucede con el almacenamiento, el aprovisionamiento de la misma máquina virtual en otras regiones puede dar lugar a otros costos.

![[Pasted image 20231226190504.png]]

#### Consumo

El **pago por uso** ha sido siempre un tema coherente y es el modelo de pago en la nube en el que paga por los recursos que usa durante un ciclo de facturación. Si durante este ciclo usa más proceso, paga más. Si usa menos en el ciclo actual, paga menos. Es un mecanismo de precios directo que permite una máxima flexibilidad.

Pero **Azure también ofrece** la capacidad de **comprometerse a usar una cantidad establecida** de recursos en la nube de antemano **y recibir descuentos por esos recursos "reservados"**. Muchos servicios, incluidas las bases de datos, el proceso y el almacenamiento, proporcionan la opción de comprometerse con un nivel de uso y recibir un descuento, en algunos casos de hasta 72 %.

Al reservar capacidad, se compromete a usar y pagar por una determinada cantidad de recursos de Azure durante un período determinado (normalmente uno o tres años). Con el respaldo del pago por uso, **si se produce un aumento repentino** de la demanda que eclipsa lo que ha reservado previamente, **solo paga por los recursos adicionales** que superen la reserva. Este modelo le permite reconocer ahorros importantes en cargas de trabajo confiables y coherentes, a la vez que tiene la flexibilidad de aumentar rápidamente la superficie de la nube a medida que surge la necesidad.

#### Mantenimiento

La flexibilidad de la nube permite ajustar rápidamente los recursos en función de la demanda. El **uso de grupos de recursos puede ayudar a mantener todos los recursos organizados**. Para controlar los costos, es importante mantener el entorno en la nube. Por ejemplo, cada vez que se aprovisiona una máquina virtual, también se aprovisionan recursos adicionales, como los de almacenamiento y redes. Si desaprovisiona la máquina virtual, es posible que esos recursos adicionales no se desaprovisionen al mismo tiempo, ya sea de forma intencionada o involuntaria. Al vigilar los recursos y asegurarse de que no mantiene los que ya no son necesarios, puede ayudar a controlar los costos de la nube.

#### Geografía

Al aprovisionar la mayoría de los recursos en Azure, debe definir una región donde se implementará el recurso. La infraestructura de Azure se distribuye de forma global, lo que le permite implementar los servicios de manera centralizada, acercarlos a los clientes o una solución intermedia. Esta implementación global tiene diferencias de precios globales. El costo de la energía, la mano de obra, los impuestos y las tarifas varían en función de la ubicación. Debido a estas variaciones, los recursos de Azure pueden diferir en los costos de implementación en función de la región.

**El tráfico de red también se ve afectado por la geografía. Por ejemplo, es menos costoso mover información dentro de Europa que hacerlo de Europa a Asia o Sudamérica.**

##### tráfico de red

Las zonas de facturación son un factor a la hora de determinar el costo de algunos servicios de Azure.

El ancho de banda hace referencia a los datos que entran y salen de los centros de datos de Azure. Algunas transferencias de datos entrantes (datos que se dirigen a los centros de datos de Azure) son gratis. En cuanto a las transferencias de datos salientes (datos que salen de los centros de datos de Azure), e**l precio de la transferencia de datos se basa en las zonas**.

Una zona es una agrupación geográfica de regiones de Azure para fines de facturación. La [página de precios de ancho de banda](https://azure.microsoft.com/pricing/details/bandwidth/) tiene información adicional sobre los precios de la entrada, salida y transferencia de datos.

#### Tipo de suscripción

Algunos tipos de suscripciones de Azure también incluyen provisiones de uso que afectan a los costos.

Por ejemplo, una suscripción de evaluación gratuita de Azure proporciona acceso a una serie de productos de Azure gratis durante 12 meses. También incluye un crédito para gastar en los primeros 30 días de la suscripción. Obtendrá acceso a más de 25 productos que siempre son gratuitos (según la disponibilidad de recursos y regiones).

#### Azure Marketplace

Azure Marketplace le **permite comprar soluciones y servicios basados en Azure** de proveedores de terceros. Podría tratarse de un servidor con software preinstalado y configurado, o dispositivos de firewall de red administrados, o bien conectores para servicios de copia de seguridad de terceros. Al comprar productos desde Azure Marketplace, es posible que no solo pague por los servicios de Azure que usa, sino también por los servicios o la experiencia del proveedor de terceros. El proveedor establece las estructuras de facturación.

Todas las soluciones disponibles en Azure Marketplace están certificadas y son compatibles con las directivas y los estándares de Azure. Las directivas de certificación pueden variar en función del tipo de servicio o solución, y del servicio de Azure implicado. [Las directivas de certificación de Marketplace comercial](https://learn.microsoft.com/es-es/legal/marketplace/certification-policies) tienen información adicional sobre las certificaciones de Azure Marketplace.

### Comparación de las calculadoras de precios y costo total de propiedad

Las calculadoras de precios y de costo total de propiedad (TCO) le ayudan a comprender los posibles gastos de Azure. Las dos calculadoras son accesibles desde Internet y permiten crear una configuración. Pero las dos calculadoras tienen propósitos muy diferentes.

#### Calculadora de precios

La calculadora de precios está **diseñada para proporcionarle un costo estimado** para el aprovisionamiento de recursos en Azure. Puede obtener una estimación de recursos individuales, crear una solución o usar un escenario de ejemplo para ver una estimación del gasto de Azure. La calculadora de precios se centra en el costo de los recursos aprovisionados en Azure.

	 Nota
	
	La calculadora de precios solo tiene fines informativos. Los precios son solo una estimación. No se aprovisiona nada al agregar recursos a la calculadora de precios y no se le cobrará por ningún servicio que seleccione.

Con la calculadora de precios, puede calcular los costos de cualquier recurso aprovisionado, incluidos los de proceso, almacenamiento y red asociados. Incluso puede tener en cuenta diferentes opciones de almacenamiento, como el tipo de almacenamiento, el nivel de acceso y la redundancia.

![[Pasted image 20231227092502.png]]


#### Calculadora de TCO

La calculadora de TCO está **diseñada para ayudarle a comparar los costos de ejecución** de una infraestructura local en comparación con una infraestructura en la nube de Azure. Con la calculadora de TCO, se especifica la configuración de infraestructura actual, incluidos los servidores, las bases de datos, el almacenamiento y el tráfico de red saliente. Después, la calculadora de TCO compara los costos previstos del entorno actual con un entorno de Azure que admite los mismos requisitos de infraestructura.

Con la calculadora de TCO, escribe la configuración, agrega suposiciones como los costos de mano de obra de TI y de energía, y obtiene una estimación de la diferencia de costos para ejecutar el mismo entorno en el centro de datos actual o en Azure.

![[Pasted image 20231227092758.png]]

### Ejercicio: Estimación de los costos de la carga de trabajo con la calculadora de precios

En este ejercicio, usará la calculadora de precios para **calcular el costo de ejecutar una aplicación web básica en Azure**.

Para empezar se definirán los servicios de Azure que necesita.

	 Nota
	
	La calculadora de precios solo tiene fines informativos. Los precios son solo una estimación y no se le cobrará por ningún servicio que seleccione.

