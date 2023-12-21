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

