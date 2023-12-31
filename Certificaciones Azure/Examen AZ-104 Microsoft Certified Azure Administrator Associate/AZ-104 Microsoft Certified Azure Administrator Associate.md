[AZ-104: Administración de identidades y gobernanza en Azure - Training | Microsoft Learn](https://learn.microsoft.com/es-es/training/paths/az-104-manage-identities-governance/)
# Detalles de certificación

Los candidatos a esta certificación deben tener experiencia en la implementación, la administración y la supervisión del entorno de Microsoft Azure de una organización, incluido lo siguiente:

- Redes virtuales
- Storage
- Compute
- Identidad
- Seguridad
- Gobernanza

Como administrador de Azure, suele formar parte de un equipo más amplio dedicado a implementar la infraestructura en la nube de una organización. También se coordina con otros roles para ofrecer soluciones de red, seguridad, base de datos, desarrollo de aplicaciones y DevOps de Azure.

Debería estar familiarizado con lo siguiente:

- Sistemas operativos
- Redes
- Servidores
- Virtualización

Además, debe tener experiencia con:

- PowerShell
- CLI de Azure
- Portal de Azure
- Plantillas del Administrador de recursos de Azure
- Microsoft Entra ID


	 Importante
	
	La versión en inglés de esta certificación se actualizó el 26 de octubre de 2023. Examine la guía de estudio vinculada en la [página del examen AZ-104](https://learn.microsoft.com/es-es/credentials/certifications/exams/az-104) para obtener más información sobre los cambios recientes.

## Aptitudes evaluadas

- Administración de identidades y gobernanza en Azure
- Implementación y administración del almacenamiento
- Implementación y administración de recursos de proceso de Azure
- Implementación y administración de redes virtuales
- Supervisión y mantenimiento de recursos de Azure

**Rol de trabajo:** Administrador

**Exámenes requeridos:** [AZ-104](https://learn.microsoft.com/es-es/credentials/certifications/azure-administrator/#certification-exams)

[Ir al perfil de Learn](https://www.microsoft.com/learning/dashboard.aspx)

## Elementos de esta colección

* [AZ-104: Requisitos previos para administradores de Azure](https://learn.microsoft.com/es-es/training/paths/az-104-administrator-prerequisites/)
* [AZ-104: Administración de identidades y gobernanza en Azure](https://learn.microsoft.com/es-es/training/paths/az-104-manage-identities-governance/)
* [AZ-104: Implementación y administración del almacenamiento en Azure](https://learn.microsoft.com/es-es/training/paths/az-104-manage-storage/)
* [AZ-104: Implementación y administración de recursos de procesos de Azure](https://learn.microsoft.com/es-es/training/paths/az-104-manage-compute-resources/)
* [AZ-104: Configuración y administración de redes virtuales para administradores de Azure](https://learn.microsoft.com/es-es/training/paths/az-104-manage-virtual-networks/)
* [AZ-104: Supervisión y copia de seguridad de recursos de Azure](https://learn.microsoft.com/es-es/training/paths/az-104-monitor-backup-resources/)

# AZ-104: Requisitos previos para administradores de Azure

## Configuración de los recursos de Azure con herramientas

### Escenario

Los administradores de Azure usan herramientas para interactuar con el entorno en la nube y completar tareas como las siguientes:

- Implementar decenas o cientos de recursos a la vez.
- Configuración de servicios individuales mediante scripts.
- Ver informes enriquecidos relativos al uso, el mantenimiento, los costos y mucho más.

Debe seleccionar y usar una opción de herramientas. Las opciones pueden ser Azure Portal, Azure PowerShell, la CLI de Azure o Azure Cloud Shell.

#### Aptitudes evaluadas

Estas herramientas administrativas no se prueban directamente en el [Examen AZ-104: Microsoft Azure Administrator](https://learn.microsoft.com/es-es/certifications/exams/az-104). Sin embargo, pueden usarse durante las pruebas basadas en el rendimiento.

#### Objetivos de aprendizaje

En este módulo aprenderá a:

- Administrar recursos con Azure Portal.
- Administrar recursos con Azure Cloud Shell.
- Administrar recursos con Azure PowerShell.
- Administrar recursos con la CLI de Azure.

#### Prerrequisitos

Ninguno

### Uso de Azure Portal

**Azure Portal le permite crear, administrar y supervisar todos los elementos**, desde aplicaciones web simples hasta aplicaciones complejas en la nube en una única consola unificada.

![[Pasted image 20231228095602.png]]

- Buscar recursos, servicios y documentos.
- Administrar recursos.
- Crear paneles y favoritos personalizados.
- Acceder a Cloud Shell.
- Recibir notificaciones.
- Vincula a la documentación de Azure.

Nota

Puede acceder al portal desde [https://portal.azure.com](https://portal.azure.com/).

### Uso de Azure Cloud Shell

Azure Cloud Shell es un **shell interactivo, accesible desde el explorador**, para administrar recursos de Azure. Ofrece la flexibilidad de poder elegir la experiencia de shell que mejor se adapte a la forma de trabajar. Los usuarios de Linux pueden elegir una experiencia de Bash, mientras que los de Windows pueden optar por PowerShell.

Cloud Shell permite el acceso a una experiencia de línea de comandos basada en explorador compilada con las tareas de administración de Azure en mente. Puede usar Cloud Shell para trabajar de forma autónoma desde una máquina local de una forma que solo puede permitir la nube.

![[Pasted image 20231228095809.png]]

#### Características de Azure Cloud Shell

- Es temporal y requiere que se monte un recurso compartido de Azure Files nuevo o existente.
- Ofrece un editor de texto gráfico integrado basado en el editor Monaco Editor de código abierto.
- Se autentica automáticamente para el acceso instantáneo a los recursos.
- Se ejecuta en un host temporal que se proporciona por cada sesión y usuario.
- Agota el tiempo de espera tras 20 minutos sin actividad interactiva.
- Requiere un grupo de recursos, una cuenta de almacenamiento y un recurso compartido de archivos de Azure.
- Usa el mismo recurso compartido de archivos de Azure para Bash y para PowerShell.
- Se asigna a un equipo por cuenta de usuario.
- Conserva $HOME con una imagen de 5 GB en el recurso compartido de archivos.
- Los permisos se establecen como usuario de Linux normal en Bash.

### Uso de Azure PowerShell

Azure PowerShell es un módulo que **se agrega a Windows PowerShell o PowerShell Core**, **y** que **permite conectarse a la suscripción de Azure y administrar los recursos**. Azure PowerShell requiere PowerShell para funcionar. PowerShell proporciona servicios como la ventana de shell y análisis de comandos. Azure PowerShell agrega los comandos específicos de Azure.

Por ejemplo, Azure PowerShell proporciona el comando **New-AzVM** que crea una máquina virtual en la suscripción de Azure. Para usarlo, se inicia la aplicación de PowerShell y, luego, se emite un comando como el siguiente:

```PowerShell
New-AzVm `
    -ResourceGroupName "CrmTestingResourceGroup" `
    -Name "CrmUnitTests" `
    -Image "UbuntuLTS"
    ...
```

Azure PowerShell también **está disponible** de dos formas: **en un explorador mediante Azure Cloud Shell o con una instalación local** en Linux, macOS o el sistema operativo Windows. En ambos casos, tiene dos opciones: puede usarlo en modo interactivo, en el que emitirá manualmente un comando cada vez, o bien en modo de scripting, en el que ejecutará un script que consta de varios comandos.

#### ¿Qué es un módulo Az?

**Az** es el nombre formal del **módulo** de Azure PowerShell **que contiene cmdlets para trabajar con las características de Azure**. Contiene cientos de cmdlets que le permiten controlar casi cualquier aspecto de todos los recursos de Azure. Puede trabajar con las siguientes características y muchas más:

- Grupos de recursos
- Almacenamiento
- Máquinas virtuales
- Microsoft Entra ID
- Contenedores
- Machine Learning

Este módulo es un componente de código abierto [disponible en GitHub](https://github.com/Azure/azure-powershell).

	 Nota

	Es posible que haya visto o usado comandos de Azure PowerShell con un formato **-AzureRM**. En diciembre de 2018, Microsoft publicó con disponibilidad general el reemplazo del módulo AzureRM por el módulo Az. Este nuevo módulo tiene varias características, en particular el prefijo de nombre de cmdlet abreviado de **-Az**, que reemplaza a **AzureRM**. El módulo **Az** se suministra con compatibilidad con versiones anteriores para el módulo de AzureRM, por lo que el formato del cmdlet **-AzureRM** funcionará.

Adición como marcador de la [referencia de Azure PowerShell](https://learn.microsoft.com/es-es/powershell/azure/?view=azps-6.5.0).

### Simulación de laboratorio interactiva (Azure PowerShell)

#### Escenario del laboratorio

Es el administrador de Azure para su organización. Decide automatizar algunas tareas de administración comunes mediante Azure PowerShell.

- Cree grupos de recursos.
- Cree discos administrados.
- Cambie la configuración de discos administrados.

#### Diagrama de la arquitectura

![[Pasted image 20231228105312.png]]

#### Objetivos

- **Tarea 1:** inicio de una sesión de PowerShell en Azure Cloud Shell
- **Tarea 2**: creación de un grupo de recursos y un disco administrado mediante PowerShell.
    - Cree un grupo de recursos.
    - Cree un disco administrado en el grupo de recursos.
- **Tarea 3**: configuración del disco administrado mediante Azure PowerShell.
    - Aumente el tamaño del disco administrado.
    - Cambie la SKU de rendimiento del disco.

 Nota

Haga clic en la imagen en miniatura para iniciar la simulación de laboratorio. Cuando haya terminado, asegúrese de volver a esta página para continuar con el aprendizaje.

[AZ-104 Exam Guide - Microsoft Azure Administrator Exercise 6 (cloudguides.com)](https://mslabs.cloudguides.com/guides/AZ-104%20Exam%20Guide%20-%20Microsoft%20Azure%20Administrator%20Exercise%206)

### Uso de CLI de Azure

La CLI de Azure es un **programa de línea de comandos para conectarse a Azure y ejecutar comandos administrativos en recursos de Azure**. Se ejecuta en Linux, macOS y Windows, y permite que los administradores y desarrolladores ejecuten sus comandos a través de un terminal, una solicitud de línea de comandos o un script en lugar de un explorador web. Por ejemplo, para reiniciar una máquina virtual, podría usar un comando similar al siguiente:

```Azure CLI
az vm restart -g MyResourceGroup -n MyVm
```

La CLI de Azure proporciona herramientas de línea de comandos para administrar los recursos de Azure. **Puede** instalar la CLI **localmente** en equipos que ejecuten Linux, macOS **o** sistemas operativos Windows. La CLI de Azure también se puede **usar desde un explorador a través de Azure Cloud Shell**.

En ambos casos, la CLI de Azure se puede usar de forma interactiva o mediante scripts:

- **Interactiva**. En primer lugar, para los sistemas operativos Windows, inicie un shell, como cmd.exe, o para Linux o macOS, use Bash. Después, emita el comando en la solicitud del shell.
- **Mediante scripts**. Ensamble los comandos de la CLI de Azure en un script de shell utilizando la sintaxis de script del shell elegido. A continuación, ejecute el script.

La CLI de Azure le permite controlar casi todos los aspectos de cada recurso de Azure. Puede trabajar con grupos de recursos, almacenamiento, máquinas virtuales, Microsoft Entra ID, contenedores, aprendizaje automático, etc.

Los comandos de la CLI se estructuran en _grupos_ y _subgrupos_. Cada grupo representa un servicio suministrado por Azure y los subgrupos dividen los comandos para estos servicios en agrupaciones lógicas. Por ejemplo, el grupo `storage` contiene subgrupos como **cuenta**, **blob**, **recurso compartido** y **cola**.

Por tanto, ¿cómo puede encontrar los comandos específicos que necesita? Una manera consiste en usar `az find`. Por ejemplo, si quiere buscar los comandos que pueden ayudarle a administrar un blob de almacenamiento, puede usar el comando de búsqueda siguiente:

```Azure CLI
az find blob
```

Si ya conoce el nombre del comando que quiere, el argumento `--help` para ese comando obtendrá información más detallada sobre el comando y, para un grupo de comandos, una lista de los subcomandos disponibles. Por ejemplo, a continuación se muestra cómo se puede obtener una lista de los comandos y subgrupos para administrar el almacenamiento de blobs:

```Azure CLI
az storage blob --help
```

 Nota

Guarde como marcador la [referencia de la CLI de Azure](https://learn.microsoft.com/es-es/cli/azure/).

### Simulación de laboratorio interactiva (CLI de Azure)

#### Escenario del laboratorio

Es el administrador de Azure para su organización. Decide automatizar algunas tareas de administración comunes mediante la interfaz de la línea de comandos (CLI) de Azure.

- Cree grupos de recursos.
- Cree discos administrados.
- Cambie la configuración de discos administrados.

#### Diagrama de la arquitectura

![[Pasted image 20231228112050.png]]

#### Objetivos

- **Tarea 1**: inicio de una sesión de Bash en Azure Cloud Shell.
- **Tarea 2**: creación de un grupo de recursos y un disco administrado mediante la CLI de Azure.
    - Cree un grupo de recursos.
    - Cree un disco administrado en el grupo de recursos.
- **Tarea 3**: configuración del disco administrado mediante la CLI de Azure.
    - Aumente el tamaño del disco administrado.
    - Cambie la SKU de rendimiento del disco.

 Nota

Haga clic en el siguiente enlace para iniciar la simulación de laboratorio. Cuando haya terminado, asegúrese de volver a esta página para continuar con el aprendizaje.

[AZ-104 Exam Guide - Microsoft Azure Administrator Exercise 7 (cloudguides.com)](https://mslabs.cloudguides.com/guides/AZ-104%20Exam%20Guide%20-%20Microsoft%20Azure%20Administrator%20Exercise%207)

### Prueba de conocimientos

1. Su compañía está creando una aplicación de edición de vídeos que ofrecerá almacenamiento en línea para el contenido de vídeo que generan los usuarios. Los vídeos se almacenarán en Azure Blobs. Una cuenta de almacenamiento de Azure contendrá los blobs. Es poco probable que la cuenta de almacenamiento tenga que quitarse y volver a crearse. ¿Qué herramienta es probable que ofrezca la forma más rápida y sencilla de crear la cuenta de almacenamiento?

<details>
	<summary>Respuesta</summary>
	<p><b>Azure portal</b> es una buena elección para operaciones únicas como la creación de una cuenta de almacenamiento duradera. El portal ofrece una interfaz gráfica de usuario que contiene todas las propiedades de la cuenta de almacenamiento y proporciona información sobre herramientas para ayudarle a seleccionar las opciones que se adecúen a las necesidades de la organización.</p>
</details>

2. ¿En cuál de las siguientes opciones se puede instalar la CLI de Azure?

<details>
	<summary>Respuesta</summary>
	<p>La CLI es multiplataforma y se puede instalar en Linux, macOS y Windows. Después de la instalación, los comandos de la CLI serán los mismos en todas las plataformas.</p>
</details>

3. Otro administrador administra Azure localmente mediante PowerShell. Ha iniciado PowerShell como administrador. ¿Cuál de los siguientes comandos debe ejecutarse primero? 

<details>
	<summary>Respuesta</summary>
	<p><b>Connect-AzAccount</b>lo primero que hay que hacer es conectarse a Azure y proporcionar las credenciales de usuario.</p>
</details>

### Resumen y recursos

Los administradores de Azure tienen muchas herramientas en lo que respecta a la administración de recursos. Entre estas herramientas, se incluyen Azure Portal, Azure Cloud Shell, Azure PowerShell y la CLI de Azure.

Ahora deberíamos ser capaces de hacer lo siguiente:

- Administrar recursos con Azure Portal.
- Administrar recursos con Azure Cloud Shell.
- Administrar recursos con Azure PowerShell.
- Administrar recursos con la CLI de Azure.

#### Más información

Si desea obtener más información, revise los siguientes recursos. Un _espacio aislado_ indica un ejercicio práctico.

- [Documentación de Azure Portal](https://learn.microsoft.com/es-es/azure/azure-portal/)
- [Introducción a Azure Cloud Shell](https://learn.microsoft.com/es-es/azure/cloud-shell/overview)
- [Documentación de Azure PowerShell](https://learn.microsoft.com/es-es/powershell/azure)
- [Referencia de la CLI de Azure](https://learn.microsoft.com/es-es/cli/azure/?view=azure-cli-latest)
- [Administración de servicios con Azure Portal (espacio aislado)](https://learn.microsoft.com/es-es/training/modules/tour-azure-portal/)
- [Introducción a PowerShell (espacio aislado)](https://learn.microsoft.com/es-es/training/modules/introduction-to-powershell/)
- [Control de los servicios de Azure con la CLI (espacio aislado)](https://learn.microsoft.com/es-es/training/modules/control-azure-services-with-cli/)
- [Control y organización de los recursos de Azure con Azure Resource Manager](https://learn.microsoft.com/es-es/training/modules/control-and-organize-with-azure-resource-manager/)

## Uso de Azure Resource Manager

### Introducción

Su empresa está empezando a crear recursos en Azure. No hay ningún plan organizativo para estandarizar el trabajo. Ha habido varios casos en los que se han eliminado por accidente recursos críticos. Resulta difícil determinar a quién pertenece determinado recurso.

Debe usar grupos de recursos para organizar los recursos de Azure de la empresa.

#### Aptitudes evaluadas

La administración de los recursos forma parte del [Examen AZ-104: Administrador de Microsoft Azure](https://learn.microsoft.com/es-es/certifications/exams/az-104).

Administración de identidades y gobernanza en Azure (15-20 %)

Administración de suscripciones y gobernanza

- Configuración de bloqueos de recursos.
- Administración de grupos de recursos.

Implementación y administración de recursos de procesos de Azure (20-25 %)

Configuración de máquinas virtuales

- Mover máquinas virtuales de un grupo de recursos a otro.

#### Objetivos de aprendizaje

En este módulo aprenderá a:

- Identificar las características y los casos de uso de Azure Resource Manager.
- Describir cada componente de Azure Resource Manager y su uso.
- Usar grupos de recursos para organizar sus recursos de Azure.
- Aplicar bloqueos de Azure Resource Manager.
- Mover recursos de Azure entre grupos, suscripciones y regiones.
- Quitar recursos y grupos de recursos.
- Aplicar los límites de recursos y llevar un seguimiento de ellos.

#### Requisitos previos

Ninguno

### Revisión de las ventajas de Azure Resource Manager

**La infraestructura** de la aplicación **está constituida normalmente por varios componentes**: quizás una máquina virtual, una cuenta de almacenamiento y una red virtual, o una aplicación web, una base de datos, un servidor de bases de datos y servicios de terceros. Estos componentes no son entidades independientes, sino que partes relacionadas e interdependientes de una sola entidad. **Desea implementarlos, administrarlos y supervisarlos como grupo**.

**Azure Resource Manager permite trabajar con los recursos de la solución como un grupo**. Todos los recursos de la solución se pueden implementar, actualizar o eliminar en una sola operación coordinada. Para realizar la implementación se usa una plantilla, que puede funcionar en distintos entornos, como producción, pruebas y ensayo. Azure Resource Manager proporciona funciones de seguridad, auditoría y etiquetado que lo ayudan a administrar los recursos después de la implementación.

#### Capa de administración coherente

Azure Resource Manager proporciona una capa de administración coherente para realizar tareas mediante Azure PowerShell, la CLI de Azure, Azure Portal, API REST y los SDK de cliente. Seleccione las herramientas y las API que mejor le funcionen.

La siguiente imagen muestra cómo todas las herramientas interactúan con la misma API de Azure Resource Manager. La API pasa las solicitudes al servicio Azure Resource Manager que las autentica y autoriza. A continuación, Azure Resource Manager enruta las solicitudes a los proveedores de recursos adecuados.

![[Pasted image 20231228120418.png]]

#### Ventajas

Azure Resource Manager ofrece varias ventajas:

- Puede implementar, administrar y supervisar todos los recursos de la solución en grupo, en lugar de controlarlos individualmente.
- Puede implementar la solución repetidamente a lo largo del ciclo de vida del desarrollo y tener la seguridad de que los recursos se implementan de forma coherente.
- Puede administrar la infraestructura mediante plantillas declarativas en lugar de scripts.
- Puede definir las dependencias entre recursos de modo que se implementen en el orden correcto.
- Puede aplicar control de acceso a todos los servicios del grupo de recursos al integrarse de forma nativa Control de acceso basado en rol (RBAC) en la plataforma de administración.
- Puede aplicar etiquetas a los recursos para organizar de manera lógica todos los recursos de la suscripción.
- Puede aclarar la facturación de su organización viendo los costos de un grupo de recursos que compartan la misma etiqueta.

#### Guía

Las sugerencias siguientes ayudan a sacar el máximo partido de Azure Resource Manager cuando lo utilicemos en nuestras soluciones.

- **Defina e implemente la infraestructura mediante** la sintaxis declarativa de **las plantillas** de Azure Resource Manager, en lugar de hacerlo a través de comandos imperativos.
- Defina todos los pasos de **implementación y configuración de la plantilla**. No debería tener ningún paso manual para configurar la solución.
- Ejecute comandos imperativos para administrar los recursos, como iniciar o detener una aplicación o un equipo.
- Organice los recursos con el mismo ciclo de vida en un grupo de recursos. Use etiquetas para organizar los demás recursos.

### Revisión de la terminología de recursos de Azure

Si no conoce Azure Resource Manager, estos son algunos términos con los que puede no estar familiarizado.

- **recurso**: **elemento administrable** que está disponible **a través de Azure**. Algunos recursos comunes son una máquina virtual, una cuenta de almacenamiento, una aplicación web, una base de datos y una red virtual, pero hay muchos más.
- **grupo de recursos**: **contenedor que almacena los recursos relacionados** con una solución de Azure. El grupo de recursos puede incluir todos los recursos de la solución o solo aquellos que se desean administrar como grupo. Para decidir cómo asignar los recursos a los grupos de recursos, tenga en cuenta lo que más conviene a su organización.
- **proveedor de recursos** : **servicio que proporciona los recursos que puede implementar y administrar** mediante Resource Manager. Cada proveedor de recursos ofrece operaciones para trabajar con los recursos que se implementan. Algunos proveedores de recursos comunes son Microsoft.Compute, que suministra el recurso de máquinas virtuales, Microsoft.Storage, que suministra el recurso de cuentas de almacenamiento y Microsoft.Web, que suministra recursos relacionados con aplicaciones web.
- **plantilla**: archivo de notación de objetos JavaScript (**JSON**) **que define uno o varios recursos que se van a implementar en un grupo de recursos**. También define las dependencias entre los recursos implementados. La plantilla se puede usar para implementar los recursos de manera repetida y uniforme.
- **sintaxis declarativa**: **sintaxis que permite** establecer lo que pretende **crear sin tener que escribir la secuencia de comandos** de programación para crearla. La plantilla de Resource Manager es un ejemplo de sintaxis declarativa. En el archivo, puede definir las propiedades de la infraestructura que se va a implementar en Azure.

#### Proveedores de recursos

Cada proveedor de recursos **ofrece un conjunto de recursos y operaciones para trabajar con un servicio de Azure**. Por ejemplo, si quiere almacenar claves y secretos, trabajará con el proveedor de recursos **Microsoft.KeyVault**. Este proveedor de recursos ofrece un tipo de recurso denominado almacenes para crear el almacén de claves.

El nombre de un tipo de recurso tiene el formato: **{proveedor de recursos}/{tipo de recurso}** . Por ejemplo, el tipo de almacén de claves es **Microsoft.KeyVault/vaults**.

 Nota

Antes de implementar los recursos, debe conocer los proveedores de recursos disponibles. Conocer los nombres de los recursos y sus proveedores ayuda a definir los recursos que desea implementar en Azure. Además, es necesario que conozca las ubicaciones y las versiones de API válidas de cada tipo de recurso.

### Crear grupos de recursos

**Los recursos se pueden implementar en cualquier grupo de recursos** nuevo o existente. La implementación de recursos en un grupo de recursos se convierte en un trabajo en el que **puede realizar un seguimiento de la ejecución de la plantilla**. Si se produce un error en la implementación, la salida del trabajo puede describir por qué ocurrió. Ya sea que se implemente un recurso único en un grupo o una plantilla en un grupo, puede usar la información a fin de corregir los errores y volver a realizar la implementación. **Las implementaciones se realizan de manera incremental**; si un grupo de recursos contiene dos aplicaciones web y decide implementar una tercera, no se quitarán las aplicaciones web existentes.

#### Consideraciones

En palabras sencillas, los grupos de recursos **son una colección lógica de recursos**. Hay algunas reglas para los grupos de recursos.

- Los recursos solo pueden existir en un grupo de recursos.
- No se puede cambiar el nombre de los grupo de recursos.
- Los grupos de recursos pueden tener recursos de muchos tipos (servicios) diferentes.
- Los grupos de recursos pueden tener recursos de muchas regiones diferentes.

#### Creación de grupos de recursos

Hay algunos factores importantes que se deben tener en cuenta al definir el grupo de recursos:

- **Todos los recursos del grupo deben compartir el mismo ciclo de vida**. Se implementan, actualizan y eliminan de forma conjunta. Si un recurso, como un servidor de base de datos, debe existir en un ciclo de implementación diferente, debe estar en otro grupo de recursos.
- **Cada recurso solo puede existir en un grupo de recursos**.
- Puede agregar o quitar un recurso de un grupo de recursos en cualquier momento.
- Puede mover un recurso de un grupo de recursos a otro. Las limitaciones se aplican al [traslado de recursos](https://learn.microsoft.com/es-es/azure/azure-resource-manager/management/move-support-resources).
- Un grupo de recursos puede contener recursos que residen en diferentes regiones.
- Un grupo de recursos puede utilizarse para definir el ámbito de control de acceso para las acciones administrativas.
- Un recurso puede interactuar con los recursos de otros grupos. Esta interacción es común cuando ambos recursos están relacionados, pero no comparten el mismo ciclo de vida (por ejemplo, aplicaciones web que se conectan a una base de datos).

Al crear un grupo de recursos, es preciso proporcionar una ubicación para dicho grupo de recursos. Pero puede preguntarse: "¿Por qué necesita un grupo de recursos una ubicación? Y, si los recursos pueden tener ubicaciones diferentes a las del grupo de recursos, ¿por qué importa la ubicación del grupo de recursos?" **El grupo de recursos almacena metadatos sobre los recursos**. Por consiguiente, **al especificar la ubicación del grupo de recursos, se especifica el lugar en que se almacenan dichos metadatos**. Por motivos de compatibilidad, es posible que sea preciso asegurarse de que los datos se almacenan en una región concreta.

	Nota
	
	Al establecer el ámbito de los permisos para un grupo de recursos, puede agregar, quitar y modificar recursos fácilmente sin tener que volver a crear asignaciones y ámbitos.

### Creación de bloqueos de Azure Resource Manager

Un problema común con los recursos aprovisionados en Azure es la facilidad con la que se pueden eliminar. Un administrador excesivamente diligente o descuidado puede borrar accidentalmente meses de trabajo con solo unos pasos. **Los bloqueos** de Resource Manager **permiten** que las organizaciones coloquen una estructura **que impida la eliminación accidental de recursos** en Azure.

- Puede asociar el bloqueo a una suscripción, un grupo de recursos o un recurso.
- Los recursos secundarios heredan los bloqueos.

![[Pasted image 20231228124503.png]]

#### Tipos de bloqueo

Hay dos tipos de bloqueos de recursos.

- **Bloqueos de solo lectura**, que evitan cualquier cambio en el recurso.
- **Bloqueos de eliminación**, que evitan la eliminación.

	Nota
	
	Solo los roles Propietario y Administrador de acceso de usuario pueden crear o eliminar bloqueos de administración.

### Reorganización de recursos de Azure

En algunas ocasiones, es posible que tenga que mover recursos a una suscripción nueva o a un grupo de recursos nuevo en la misma suscripción.

![[Pasted image 20231228124720.png]]

**Al mover los recursos, el grupo de origen y el grupo de destino se bloquean durante la operación**. Las operaciones de escritura y eliminación están bloqueadas en los grupos de recursos hasta que se completa el movimiento. Este bloqueo significa que no puede agregar, actualizar ni eliminar recursos de los grupos de recursos. Los bloqueos no significan que los recursos no estén disponibles. Por ejemplo, si mueve una máquina virtual a un grupo de recursos nuevo, de todos modos una aplicación puede acceder a la máquina virtual.


#### Limitaciones

Antes de empezar este proceso, asegúrese de leer la página [Compatibilidad con la operación de traslado para recursos](https://learn.microsoft.com/es-es/azure/azure-resource-manager/management/move-support-resources). En esta página se detallan los recursos que se pueden mover entre el grupo de recursos, las suscripciones y las regiones.

#### Implementación

Para trasladar recursos, seleccione el grupo de recursos que contiene esos recursos y, después, el botón **Mover**. Seleccione los recursos que trasladar y el grupo de recursos de destino. Confirme que necesita actualizar los scripts.

![[Pasted image 20231228125334.png]]

	 Nota

	El hecho de que un servicio se pueda mover no significa que no existan restricciones. Por ejemplo, puede mover una red virtual, pero también debe mover sus recursos dependientes, como las puertas de enlace.

### Eliminación de recursos y grupos de recursos

Tenga cuidado al eliminar un grupo de recursos. **Al eliminar un grupo de recursos se eliminan todos los recursos contenidos en el mismo**. Ese grupo de recursos podría contener recursos que dependen de recursos de otros grupos de recursos.

![[Pasted image 20231228125607.png]]

#### Uso de PowerShell para eliminar grupos de recursos

Para quitar un grupo de recursos, use **Remove-AzResourceGroup**. En este ejemplo, quitaremos el grupo de recursos ContosoRG01 de la suscripción. El cmdlet le pide confirmación y no devuelve ninguna salida.

```Azure CLI
Remove-AzResourceGroup -Name "ContosoRG01"
```

#### Eliminación de recursos

También puede eliminar recursos individuales de un grupo de recursos. Por ejemplo, aquí eliminaremos una red virtual. En lugar de hacerlo, puede **mover** el recurso a otro grupo de recursos.

![[Pasted image 20231228125730.png]]


### Determinación de los límites de recursos

Azure permite ver el uso de recursos con respecto a los límites. Esto resulta útil para realizar un seguimiento del uso actual y planear su uso futuro.

![[Pasted image 20231228125843.png]]

- Los límites mostrados son los límites de su suscripción.
- Hay un vínculo Solicitar aumento para cuando tenga que aumentar un límite predeterminado.
- Todos los recursos tienen un límite máximo enumerado en los [límites](https://learn.microsoft.com/es-es/azure/azure-subscription-service-limits?toc=%2fazure%2fnetworking%2ftoc.json) de Azure.
- No puede aumentar el límite si alcanzó el límite máximo.

### Comprobación de conocimiento

1. Un nuevo proyecto tiene varios recursos que deben administrarse juntos. ¿Cuál de las estrategias siguientes proporcionaría una buena solución?

<details>
	<summary>Respuesta</summary>
	<p><b>Los Grupos de recursos de Azure</b>facilitan la administración de recursos.</p>
</details>

2. ¿Cuál de las siguientes situaciones sería un buen ejemplo de cuándo usar un bloqueo de recursos?

<details>
	<summary>Respuesta</summary>
	<p><b>Un circuito ExpressRoute con conectividad a la red local.</b>Un circuito ExpressRoute es un recurso crítico. Los bloqueos de recursos impiden que otros usuarios de la organización eliminen o modifiquen recursos críticos por accidente.</p>
</details>

3. ¿Cuál de las siguientes se aplica a los grupos de recursos?

<details>
	<summary>Respuesta</summary>
	<p>Los recursos solo pueden estar en un grupo de recursos.</p>
</details>

### Resumen y recursos

**Azure Resource Manager es el servicio de implementación y administración para Azure**. Proporciona una capa de administración que le **permite crear, actualizar y eliminar recursos de la cuenta** de Azure. Se usan las características de administración, como el control de acceso, la auditoría y las etiquetas, para proteger y organizar los recursos después de la implementación.

Ahora deberíamos ser capaces de hacer lo siguiente:

- Identificar las características y los casos de uso de Azure Resource Manager.
- Describir cada componente de Azure Resource Manager y su uso.
- Usar grupos de recursos para organizar sus recursos de Azure.
- Aplicar bloqueos de Azure Resource Manager.
- Mover recursos de Azure entre grupos, suscripciones y regiones.
- Quitar recursos y grupos de recursos.
- Aplicar los límites de recursos y llevar un seguimiento de ellos.

#### Más información

Si desea obtener más información, revise los siguientes recursos.

- [Documentación de Azure Resource Manager](https://learn.microsoft.com/es-es/azure/azure-resource-manager/management/overview)
- [Learn: Control y organización de los recursos de Azure con Azure Resource Manager](https://learn.microsoft.com/es-es/training/modules/control-and-organize-with-azure-resource-manager/)

## Configuración de recursos con plantillas de Resource Manager

### Introducción

#### Escenario

Su empresa debe asegurarse de que las implementaciones de máquinas virtuales sean coherentes en toda la organización.

**Las plantillas de Resource Manager se usan para implementar recursos**, incluidas las máquinas virtuales.

#### Aptitudes evaluadas

La implementación de recursos mediante plantillas de Resource Manager forma parte del [Examen AZ-104: Administrador de Microsoft Azure](https://learn.microsoft.com/es-es/certifications/exams/az-104).

Implementación y administración de recursos de procesos de Azure (20-25 %)

Automatización de la implementación de máquinas virtuales (VM) mediante plantillas de Azure Resource Manager

- Modificar una plantilla de Resource Manager.
- Implementar a partir de una plantilla.
- Guardar una implementación como una plantilla de Resource Manager.

#### Objetivos de aprendizaje

En este módulo aprenderá a:

- Mostrar una lista de las ventajas de las plantillas de Azure.
- Identificar los componentes del esquema de plantillas de Azure.
- Especificar los parámetros de las plantillas de Azure.
- Buscar y usar plantillas de inicio rápido de Azure.

#### Requisitos previos

Ninguno

### Revisión de las ventajas de las plantillas de Resource Manager

Una **plantilla de Resource Manager** **define con exactitud todos los recursos** de Resource Manager **de una implementación**. Una plantilla de Resource Manager **se puede implementar en un grupo de recursos con una sola operación**.

**Usar plantillas** de Resource Manager le **permitirá realizar implementaciones más rápidas y repetibles**. Por ejemplo, ya no tiene que crear una máquina virtual en el portal, esperar a que finalice y, después, crear la siguiente máquina virtual. **La plantilla de Resource Manager se encarga automáticamente de toda la implementación**.

#### Ventajas de la plantilla

- **Las plantillas mejoran la coherencia**. Las plantillas de Resource Manager **proporcionan un lenguaje común** para que todos describan sus implementaciones. Independientemente de la herramienta o el SDK que use para implementarla, la estructura, el formato y las expresiones dentro de la plantilla siguen siendo las mismas.
- **Las plantillas permiten expresar implementaciones complejas**. **Las plantillas permiten implementar varios recursos en el orden correcto**. Por ejemplo, no es conveniente implementar una máquina virtual antes de crear una interfaz de red o un disco de sistema operativo (SO). Resource Manager asigna cada recurso y sus recursos dependientes y crea los recursos dependientes en primer lugar. La asignación de dependencias ayuda a garantizar que la implementación se lleva a cabo en el orden correcto.
- **Las plantillas reducen las tareas manuales y propensas a errores**. Crear y conectar recursos manualmente puede llevar mucho tiempo y es fácil cometer errores. Resource Manager **garantiza que la implementación se lleva a cabo de la misma manera cada vez**.
- **Las plantillas son código**. Las plantillas expresan sus requisitos mediante código. Considere una plantilla como un tipo de **infraestructura como código** que se puede compartir, probar y versionar como cualquier otro producto de software. Además, dado que las plantillas son código, se puede crear un "rastro" que permita seguirlas. El código de plantilla documenta la implementación. La mayoría de los usuarios somete a sus plantillas a algún tipo de control de revisión, como GIT. Cuando la plantilla cambia, el historial de revisiones también deja constancia de cómo dicha plantilla (y su implementación) ha evolucionado con el tiempo.
- **Las plantillas fomentan la reutilización**. **La plantilla puede contener parámetros que se rellenan cuando la plantilla se ejecuta**. Un parámetro puede definir un nombre de usuario, una contraseña, un nombre de dominio, etc. Los parámetros de plantilla permiten crear varias versiones de la infraestructura, como ensayo y producción, mientras se sigue usando exactamente la misma plantilla.
- **Las plantillas se pueden vincular**. Puede vincular plantillas de Resource Manager **para que estas se puedan modular**. Puede escribir plantillas pequeñas que definan una parte de la solución y, después, combinarlas para crear un sistema completo.
- **Las plantillas simplifican la orquestación**. Para implementar todos los recursos tan **solo se necesita implementar la plantilla**. Normalmente, esto conllevaría varias operaciones.

### Exploración del esquema de plantillas de Resource Manager

Las plantillas de Resource Manager **se escriben en JSON**, lo que permite expresar los datos almacenados como un objeto (como una máquina virtual) en texto. Un documento JSON es, básicamente, una colección de pares clave-valor. Cada clave es una cadena, cuyo valor puede ser lo siguiente:

- Una cadena
- Un número
- Una expresión booleana.
- Una lista de valores.
- Un objeto (que es una colección de otros pares clave-valor).

Una plantilla de Resource Manager puede contener secciones que se expresen mediante la notación JSON, pero no están relacionadas con el propio lenguaje JSON:

```JSON
{
    "$schema": "http://schema.management.​azure.com/schemas/2019-04-01/deploymentTemplate.json#",​
    "contentVersion": "",​
    "parameters": {},​
    "variables": {},​
    "functions": [],​
    "resources": [],​
    "outputs": {}​
}
```

| **Nombre del elemento** | **Obligatorio** | **Descripción** |
| ---- | ---- | ---- |
| $schema | sí | Ubicación del archivo de esquema JSON que describe la versión del idioma de la plantilla. Use la dirección URL que se muestra en el ejemplo anterior. |
| contentVersion | Sí | Versión de la plantilla (por ejemplo, 1.0.0.0). Puede especificar cualquier valor para este elemento. Use este valor para documentar los cambios importantes de la plantilla. Este valor se puede usar para asegurarse de que se está usando la plantilla correcta. |
| parameters | No | Valores que se proporcionan cuando se ejecuta la implementación para personalizar la implementación de recursos. |
| variables | No | Valores que se usan como fragmentos JSON en la plantilla para simplificar expresiones de idioma de la plantilla. |
| functions | No | Funciones definidas por el usuario que están disponibles dentro de la plantilla. |
| resources | Sí | Tipos de servicios que se implementan o actualizan en un grupo de recursos. |
| outputs | No | Valores que se devuelven después de la implementación. |

### Exploración de los parámetros de plantillas de Azure Resource Manager

En la sección de parámetros de la plantilla, especifique los valores que el usuario puede introducir al implementar los recursos. Las propiedades disponibles para un parámetro son:

```JSON
"parameters": {
    "<parameter-name>" : {
        "type" : "<type-of-parameter-value>",
        "defaultValue": "<default-value-of-parameter>",
        "allowedValues": [ "<array-of-allowed-values>" ],
        "minValue": <minimum-value-for-int>,
        "maxValue": <maximum-value-for-int>,
        "minLength": <minimum-length-for-string-or-array>,
        "maxLength": <maximum-length-for-string-or-array-parameters>,
        "metadata": {
        "description": "<description-of-the parameter>"
        }
    }
}
```

Este es un ejemplo que ilustra dos parámetros, uno relacionado con un nombre de usuario de máquina virtual y el otro con su contraseña correspondiente:

```JSON
"parameters": {
  "adminUsername": {
    "type": "string",
    "metadata": {
      "description": "Username for the Virtual Machine."
    }
  },
  "adminPassword": {
    "type": "securestring",
    "metadata": {
      "description": "Password for the Virtual Machine."
    }
  }
}
```

	Nota
	
	Está limitado a 256 parámetros en una plantilla. Puede reducir el número de parámetros mediante el uso de objetos que contienen varias propiedades.

### Consideración de las plantillas de Bicep

[Azure Bicep](https://learn.microsoft.com/es-es/azure/azure-resource-manager/bicep/overview) **es un lenguaje específico de dominio (DSL) que usa una sintaxis declarativa para implementar recursos** de Azure. Brinda sintaxis concisa, seguridad de tipos confiable y compatibilidad con la reutilización de código.

**Puede usar Bicep en lugar de JSON para desarrollar las** plantillas de Azure Resource Manager (**plantillas de ARM**). La sintaxis JSON para crear una plantilla de ARM puede ser detallada y exigir expresiones complicadas. La sintaxis de **Bicep reduce esa complejidad y mejora la experiencia de desarrollo**. Bicep **es una abstracción transparente del código JSON** de plantillas de ARM, y no pierde ninguna de las funcionalidades de las plantillas JSON.

#### ¿Cómo funciona Bicep?

Al implementar un recurso o una serie de recursos en Azure, las herramientas integradas en **Bicep convierten la plantilla de Bicep en una plantilla JSON. Este proceso se conoce como transpilación**. *La transpilación es el proceso de convertir el código fuente escrito de un lenguaje a otro*.


![[Pasted image 20231228135432.png]]

Bicep proporciona muchas mejoras sobre JSON para la creación de plantillas, entre las que se incluyen las siguientes:

- **Sintaxis más sencilla**: Bicep proporciona una sintaxis más sencilla para escribir plantillas. Puede **hace**r **referencia a parámetros y variables directamente**, sin usar funciones complicadas. La interpolación de cadenas se usa en lugar de la concatenación para combinar valores para nombres y otros elementos. Puede hacer referencia a las propiedades de un recurso directamente mediante su nombre simbólico en lugar de instrucciones de referencia complejas. Estas mejoras de sintaxis ayudan tanto con la creación como con la lectura de plantillas de Bicep.
    
- **Módulos**: puede **desglosa**r las **implementaciones de plantillas complejas en archivos de módulo más pequeños y hacer referencia a ellos en una plantilla principal**. Estos módulos proporcionan una **administración más sencilla y una mayor capacidad de uso**.
    
- **Administración automática de dependencias**: en la mayoría de las situaciones, Bicep **detecta automáticamente las dependencias entre los recursos**. Este proceso quita parte del trabajo que implica la creación de plantillas.
    
- **Validación de tipos e IntelliSense**: la extensión Bicep para Visual Studio Code incluye una validación enriquecida e IntelliSense para todas las definiciones de API de tipos de recursos de Azure. Esta característica ayuda a proporcionar una experiencia de creación más sencilla.


### Revisión de plantillas de inicio rápido

Las [plantillas de inicio rápido de Azure](https://azure.microsoft.com/resources/templates/) son plantillas de Azure Resource Manager que proporciona la comunidad de Azure.

![[Pasted image 20231228135851.png]]

Algunas plantillas proporcionan todo lo necesario para implementar la solución, mientras que otras pueden servir como punto de partida para la plantilla. Sea cual sea su caso, puede estudiar estas plantillas para saber cuál es la mejor forma de crear y estructurar sus propias plantillas.

- El archivo README.md proporciona información general de lo que hace la plantilla.
- El archivo azuredeploy.json define los recursos que se implementarán.
- El archivo azuredeploy.parameters.json proporciona los valores que necesita la plantilla.

	Nota
	
	Dedique unos minutos a examinar las plantillas disponibles. ¿Le resulta algo interesante?

### Simulación interactiva de laboratorio: plantillas

#### Escenario

Tailwind Traders está migrando sus necesidades de almacenamiento a Azure. Ha implementado correctamente un disco administrado en un grupo de recursos. Ha decidido crear una plantilla de Azure Resource Manager para simplificar las demás implementaciones de disco.

#### Diagrama de la arquitectura

La primera implementación de disco en el grupo de recursos az104-**03a**-rg1 está completa. Tiene previsto personalizar la plantilla y usarla para implementar otro disco en el grupo de recursos az104-**03b**-rg1.

#### Tareas

**Tarea 1**: Revisar una plantilla de ARM para la implementación de un disco administrado de Azure.

**Tarea 2**:Creación de un disco administrado de Azure mediante una plantilla de ARM.

**Tarea 3:** Revisión de la implementación del disco administrado basada en la plantilla de ARM.

	Nota
	
	Haga clic en la imagen en miniatura para iniciar la simulación de laboratorio. Cuando haya terminado, asegúrese de volver a esta página para continuar con el aprendizaje.

[AZ-104 Exam Guide - Microsoft Azure Administrator Exercise 5 (cloudguides.com)](https://mslabs.cloudguides.com/guides/AZ-104%20Exam%20Guide%20-%20Microsoft%20Azure%20Administrator%20Exercise%205)


### Prueba de conocimientos

1. ¿Qué es una plantilla de Azure Resource Manager?

<details>
	<summary>Respuesta</summary>
	<p>Un archivo de notación de objetos JavaScript (JSON) que define la infraestructura y la configuración de la implementación.</p>
	<small>Una plantilla de Resource Manager es un archivo JSON que define la infraestructura y la configuración de la implementación.</small>
</details>

2. ¿Cuál de los parámetros siguientes es un elemento del esquema de plantilla?

<details>
	<summary>Respuesta</summary>
	<p><b>Salidas</b>Outputs forma parte del esquema de plantilla. Outputs se usa para devolver valores de los recursos implementados.</p>
</details>


3. ¿Qué ocurre si la misma plantilla se ejecuta una segunda vez?

<details>
	<summary>Respuesta</summary>
	<p>Azure Resource Manager no cambia los recursos implementados.</p>
	<small>Si el recurso ya existe y no se detecta ningún cambio en las propiedades, no se realizará ninguna acción. Si el recurso ya existe y se produce un cambio en alguna propiedad, el recurso se actualiza. Si el recurso no existe, se creará.</small>
</details>

### Resumen y recursos

Para implementar la infraestructura como código para las soluciones de Azure, use las plantillas de Azure Resource Manager. La plantilla es un archivo de notación de objetos JavaScript (JSON) que contiene la infraestructura y la configuración del proyecto. La plantilla usa sintaxis declarativa, lo que permite establecer lo que pretende implementar sin tener que escribir la secuencia de comandos de programación para crearla. En la plantilla se especifican los recursos que se van a implementar y las propiedades de esos recursos.

Ahora deberíamos poder realizar las siguientes acciones:

- Mostrar una lista de las ventajas de las plantillas de Azure.
- Identificar los componentes del esquema de plantillas de Azure.
- Especificar los parámetros de las plantillas de Azure.
- Buscar y usar plantillas de inicio rápido de Azure.

#### Más información

Si desea obtener más información, revise los siguientes recursos. Un _espacio aislado_ indica un ejercicio práctico.

- [Documentación sobre plantillas de Azure Resource Manager](https://learn.microsoft.com/es-es/azure/azure-resource-manager/templates/)
- [Plantillas de inicio rápido de Azure](https://azure.microsoft.com/resources/templates/)
- [Implementación de la infraestructura de Azure mediante plantillas de Resource Manager JSON (espacio aislado)](https://learn.microsoft.com/es-es/training/modules/build-azure-vm-templates/)
- [crear recursos de Azure mediante las plantillas de Azure Resource Manager;](https://learn.microsoft.com/es-es/training/modules/create-azure-resources-using-azure-resource-manager-templates/)
- [Compilación de la primera plantilla de Bicep (espacio aislado)](https://learn.microsoft.com/es-es/training/modules/build-first-bicep-template/)

## Automatización de tareas de Azure mediante scripts con PowerShell

### Introducción

La creación de scripts de administración es una **manera eficaz de optimizar el flujo de trabajo**. Puede automatizar tareas comunes y repetitivas. Una vez que se haya comprobado un script, se ejecutará sistemáticamente, lo que reducirá los errores.

Supongamos que trabaja en una empresa en la que se usa Azure Virtual Machines (VM) para probar el software de administración de las relaciones con el cliente (CRM). Las máquinas virtuales se crean a partir de imágenes que incluyen una front-end web, un servicio web que implementa la lógica de negocios y una base de datos SQL.

Ha estado ejecutando varias series de pruebas en una sola máquina virtual, pero ha notado que los cambios en la base de datos y los archivos de configuración pueden causar resultados incoherentes. En un caso, un error creó un registro de llamada telefónica sin un cliente correspondiente en la base de datos. El registro huérfano ocasionó que las pruebas de integración posteriores no se realizaran incluso después de corregir el error. Piensa resolver este problema mediante la implementación de una nueva máquina virtual para cada ciclo de pruebas. Quiere automatizar la instalación de la creación de máquina virtual porque se ejecutará muchas veces por semana.

Aquí, verá cómo administrar recursos de Azure mediante Azure PowerShell. Usará Azure PowerShell de forma interactiva para tareas aisladas y escribirá scripts para automatizar tareas repetitivas.

#### Objetivos de aprendizaje

En este módulo, aprenderá a:

- Decidir si Azure PowerShell es la herramienta adecuada para sus tareas de administración de Azure.
- Instalar Azure PowerShell en Linux, macOS o Windows.
- Conectarse a una suscripción de Azure con Azure PowerShell.
- Crear recursos de Azure con Azure PowerShell.

#### Requisitos previos

- Experiencia con una interfaz de línea de comandos como PowerShell o Bash
- Conocimiento de conceptos básicos de Azure como grupos de recursos y máquinas virtuales
- Experiencia con la administración de recursos de Azure mediante Azure Portal

### Decisión sobre la idoneidad de Azure PowerShell para las tareas

Supongamos que necesita elegir una herramienta para administrar los recursos de Azure que se usarán para probar el sistema de administración de las relaciones con el cliente (CRM). Las pruebas exigen que cree grupos de recursos y aprovisione máquinas virtuales (VM).

Quiere algo que a los administradores les resulte fácil de aprender, pero con la suficiente eficacia como para automatizar la instalación y configuración de varias máquinas virtuales o crear scripts para un entorno de aplicación completo. Hay varias herramientas disponibles y debe encontrar la mejor para su personal y sus tareas.

#### ¿Qué herramientas están disponibles?

Azure proporciona tres herramientas de administración:

- Azure Portal
- La CLI de Azure
- Azure PowerShell

Estas herramientas ofrecen prácticamente el mismo nivel de control; cualquier tarea que pueda hacer con una de las herramientas, probablemente también podrá realizarla con las otras dos. Las tres son multiplataforma, es decir, que se ejecutan en Windows, macOS y Linux. Se diferencian en la sintaxis, los requisitos de configuración y la compatibilidad con la automatización.

En este caso, vamos a describir cada una de las tres opciones y ofrecemos algunos consejos sobre cómo decidir entre ellas.

##### ¿Qué es Azure Portal?

Azure Portal es un **sitio web que le permite crear, configurar y modificar los recursos** de su suscripción de Azure. El portal es una interfaz gráfica de usuario (GUI) que resulta conveniente para localizar el recurso que necesite y ejecutar todos los cambios necesarios. También ofrece orientación para tareas administrativas complejas con asistentes e información sobre herramientas.

**El portal no proporciona ninguna forma de automatizar tareas repetitivas**. Por ejemplo, para configurar quince máquinas virtuales, necesitaría crearlas una a una completando el asistente para cada una de ellas. Este método puede llevar mucho tiempo y ser propenso a errores si se trata de tareas complejas.

##### ¿Qué es la CLI de Azure?

La CLI de Azure es un **programa de línea de comandos multiplataforma** para conectarse a Azure y ejecutar comandos administrativos en recursos de Azure. Por ejemplo, para crear una máquina virtual, puede usar el siguiente comando:

```Azure CLI
az vm create --resource-group CrmTestingResourceGroup --name CrmUnitTests --image Ubuntu2204
  ...
```

La CLI de Azure está disponible de dos formas: dentro de un explorador mediante Azure Cloud Shell o con una instalación local en Linux, Mac o Windows. En ambos casos, **puede usarlo de forma interactiva o usarlo con scripts para automatizar tareas**. Para un uso interactivo, inicie primero un shell (como `cmd.exe` en Windows o Bash en Linux o macOS) y, posteriormente, emita el comando en el símbolo del shell. Para automatizar tareas repetitivas, combine los comandos en un script de shell con la sintaxis de script del shell elegido y, después, ejecute el script.

##### ¿Qué es Azure PowerShell?

Azure PowerShell **es un módulo** que se agrega a PowerShell que le permite conectarse a la suscripción de Azure y administrar recursos. Azure PowerShell requiere PowerShell para funcionar. PowerShell proporciona servicios como la ventana de shell, análisis de comandos y mucho más. El módulo Azure Az de PowerShell agrega los comandos específicos de Azure.

Por ejemplo, Azure PowerShell proporciona el comando **New-AzVM** que crea de forma automática una máquina virtual en la suscripción de Azure. Para usarlo, se inicia la aplicación de PowerShell y se emite el siguiente comando:

```PowerShell
New-AzVm `
    -ResourceGroupName "CrmTestingResourceGroup" `
    -Name "CrmUnitTests" `
    -Image "UbuntuLTS"
    ...
```

Azure PowerShell también está disponible de dos formas: dentro de un explorador mediante Azure Cloud Shell o con una instalación local en Linux, Mac o Windows. En ambos casos, tiene dos modos para elegir. Puede usarlo en modo interactivo, en el que emite manualmente un comando a la vez, o bien en modo de scripting, en el que ejecuta un script que consta de varios comandos.

#### Elección de una herramienta administrativa

Existe una similitud aproximada entre Azure Portal, la CLI de Azure y Azure PowerShell con respecto a los objetos de Azure que pueden administrar y las configuraciones que pueden crear. Todas son también multiplataforma. Normalmente, tendrá en cuenta otros factores diversos al realizar la elección:

- **Automatización**: ¿necesita automatizar un conjunto de tareas repetitivas o complejas? Azure PowerShell y la CLI de Azure admiten la automatización, pero Azure Portal no.
    
- **Curva de aprendizaje**: ¿necesita completar una tarea rápidamente sin aprender nuevos comandos o sintaxis? Azure Portal no requiere el aprendizaje de sintaxis o la memorización de comandos. En Azure PowerShell y en la CLI de Azure, debe conocer la sintaxis detallada de cada comando que use.
    
- **Conjunto de aptitudes del equipo**: ¿el equipo tiene experiencia? Por ejemplo, el equipo puede haber usado PowerShell para administrar Windows. En su caso, sus miembros se familiarizarán rápidamente con el uso de Azure PowerShell.

#### Ejemplo

Recuerde que ha elegido una herramienta administrativa para crear los entornos de prueba para la aplicación de CRM. Los administradores tienen dos tareas de Azure específicas que deberán completar:

1. Crear un grupo de recursos para cada categoría de prueba (unidad, integración y aceptación).
2. Crear varias máquinas virtuales en cada grupo de recursos antes de cada ronda de pruebas.

Para crear los grupos de recursos, Azure Portal es una opción razonable. Estas son tareas de ejecución única, por lo que no necesita scripts para llevarlas a cabo.

Buscar la mejor herramienta para crear las máquinas virtuales es una decisión más complicada. Deberá crear varias máquinas virtuales y necesita hacerlo repetidamente, probablemente varias veces a la semana. Para estas tareas precisará de automatización, por lo que Azure Portal no es una buena opción. En este caso, Azure PowerShell o la CLI de Azure satisfarán sus necesidades. Si los miembros del equipo tienen algunos conocimientos de PowerShell, Azure PowerShell es probablemente la mejor opción. Azure PowerShell está disponible en los sistemas operativos que su equipo de administración utiliza, admite la automatización y a su equipo le debe resultar rápido de aprender.

La primera experiencia que la mayoría de los administradores tienen con Azure es en Azure Portal. Es un excelente lugar para comenzar, ya que proporciona una interfaz gráfica limpia y bien estructurada, pero proporciona opciones limitadas para la automatización. Si necesita automatización, Azure le ofrece dos opciones: Azure PowerShell para administradores con experiencia en PowerShell y la CLI de Azure para todos los demás.

En la práctica, las empresas suelen tener una combinación de tareas puntuales y repetitivas, por lo que es habitual usar Azure Portal y una solución de scripting. En nuestro ejemplo de CRM, es conveniente crear los grupos de recursos en Azure Portal y automatizar la creación de máquinas virtuales con PowerShell.

El resto de este módulo se centra en la instalación y el uso de Azure PowerShell.

### Instale PowerShell.

Supongamos que ha elegido Azure PowerShell como solución de automatización. Los administradores prefieren ejecutar sus scripts localmente en lugar de en Azure Cloud Shell. El equipo usa máquinas que ejecutan Windows, macOS y Linux. Es preciso que la CLI de Azure funcione en todos los dispositivos.

#### ¿Qué hay que instalar?

Repasaremos las instrucciones de instalación en la siguiente unidad, pero veamos los dos componentes que constituyen Azure PowerShell.

- **Producto base de PowerShell** Hay dos variantes: Windows PowerShell y PowerShell 7.x, que puede instalar en Windows, macOS y Linux.
- **Módulo Azure Az de PowerShell**. Debe instalar este módulo adicional para agregar los comandos específicos de Azure a PowerShell.

	 Sugerencia
	
	PowerShell 7.0.6 LTS, PowerShell 7.1.3, o cualquier versión superior, son las versiones que recomendamos para usar con el módulo Azure Az PowerShell en todas las plataformas.

Cuando haya instalado el producto base, agregue el módulo Azure PowerShell a la instalación.

#### Procedimiento para instalar PowerShell

En Linux y macOS, use un administrador de paquetes para instalar PowerShell Core. El administrador de paquetes recomendado varía en función del sistema operativo y la distribución.

	 Nota
	
	PowerShell está disponible en el repositorio de Microsoft, por lo que primero tendrá que agregar ese repositorio al administrador de paquetes.

##### Linux

En Linux, el administrador de paquetes cambiará en función de la distribución de Linux que se elija.

| Distribuciones | Administrador de paquetes |  |
| ---- | ---- | ---- |
| Ubuntu, Debian | `apt-get` |  |
| Red Hat, CentOS | `yum` |  |
| OpenSUSE | `zypper` |  |
| Fedora | `dnf` | ### Mac |
##### Mac

En macOS, use `Homebrew` para instalar PowerShell.

En la sección siguiente, repasaremos los pasos de instalación detallados para algunas plataformas comunes.


### Ejercicio: Instalación de Azure PowerShell

En esta unidad, aprenderá a comprobar la versión de **PowerShell** que está instalada en la máquina local y a instalar la versión más reciente.

	 Nota
	
	Este ejercicio le guía por la creación de una instalación local de las herramientas de PowerShell. En el resto del módulo se usará Azure Cloud Shell para que pueda sacar provecho del soporte técnico de la suscripción gratuita de Microsoft Learn. Si lo prefiere, considere este ejercicio como una actividad opcional y simplemente revise las instrucciones.

#### Windows

Windows PowerShell se incluye con el sistema operativo Windows; pero se recomienda instalar PowerShell 7.0.6 LTS, PowerShell 7.1.3 o posterior para su uso con el módulo de PowerShell Azure Az PowerShell. Puede comprobar qué versión está instalada mediante los pasos siguientes:

1. En el **cuadro de búsqueda de la Bandeja del sistema**, escriba **PowerShell**. Es posible que tenga varios vínculos de acceso directo:

	- PowerShell 7 (x64): la versión de 64 bits. Por lo general, debe elegir este acceso directo.
	- Windows PowerShell: la versión de 64 bits incluida con Windows.
	- Windows PowerShell (x86): una versión de 32 bits instalada en Windows de 64 bits.
	- Windows PowerShell ISE: el entorno de scripting integrado (ISE) se usa para escribir scripts en Windows PowerShell.
	- Windows PowerShell ISE (x86): versión de 32 bits del ISE.

2. Seleccione el icono de PowerShell que mejor coincida.
    
3. Escriba el comando siguiente para determinar la versión instalada de PowerShell.

```PowerShell
$PSVersionTable.PSVersion
```

o

```PowerShell
pwsh -ver
```

Si el número de versión principal es inferior a 7, siga estas instrucciones para [actualizar la versión existente de Windows PowerShell](https://learn.microsoft.com/es-es/powershell/scripting/install/installing-powershell-on-windows#upgrading-an-existing-installation). También es importante instalar el SDK para admitir las herramientas de .NET.

Puedes instalarlo mediante winget con los siguientes comandos

```PowerShell
winget search Microsoft.PowerShell

winget install --id Microsoft.Powershell --source winget
winget install --id Microsoft.Powershell.Preview --source winget
```

Necesita tener [instalado el SDK de .NET](https://learn.microsoft.com/es-es/dotnet/core/sdk) para ejecutar este comando.

```PowerShell
dotnet tool install --global PowerShell
```

Una vez que se instale la herramienta .NET, vuelva a ejecutar el comando version de PowerShell para comprobar la instalación.

#### MacOS

En macOS, instale **PowerShell** con el administrador de paquetes Homebrew.

	Importante
	
	Si el comando **brew** no está disponible, es posible que deba instalar el administrador de paquetes Homebrew. Para obtener más información, consulte el [sitio web de Homebrew](https://brew.sh/).

1. Instale Homebrew-Cask para obtener más paquetes, incluido el de PowerShell:

```Bash
brew install --cask powershell
```

2. Inicie PowerShell para comprobar que está instalado correctamente:

```Bash
pwsh
```

#### Linux

La instalación de PowerShell para Linux implica el uso de un administrador de paquetes. En el ejemplo se usará **Ubuntu 18.04**, pero hay [instrucciones detalladas para otras versiones y distribuciones en la documentación](https://learn.microsoft.com/es-es/powershell/scripting/install/installing-powershell-core-on-linux).

Instale PowerShell en Ubuntu Linux mediante Advanced Packaging Tool (**apt**) y la línea de comandos de Bash.

1. Importe la clave de cifrado del repositorio de Ubuntu de Microsoft. Esta clave permite que el administrador de paquetes compruebe que el paquete de PowerShell que se instala proviene de Microsoft.

```Bash
curl https://packages.microsoft.com/keys/microsoft.asc | sudo apt-key add -
```

2. Registre el **repositorio de Microsoft Ubuntu** para que el administrador de paquetes pueda localizar el paquete de PowerShell:

```Bash
sudo curl -o /etc/apt/sources.list.d/microsoft.list https://packages.microsoft.com/config/ubuntu/18.04/prod.list
```

3. Actualice la lista de paquetes:

```Bash
sudo apt-get update
```

4. Instalar PowerShell

```Bash
sudo apt-get install -y powershell
```

5. Inicie PowerShell para comprobar que está instalado correctamente:

```Bash
pwsh
```



También tendrá que configurar las máquinas locales para que admitan PowerShell. En la siguiente unidad, se revisarán los comandos que puede agregar, incluido el módulo Azure Az de PowerShell.

### Creación de un recurso de Azure mediante scripts en Azure PowerShell


En el **modo interactivo**, PowerShell le permite escribir comandos y ejecutarlos de inmediato.

Recuerde que el objetivo general del ejemplo de Administración de relaciones con los clientes (CRM) es crear tres entornos de prueba que contienen máquinas virtuales. Usa los grupos de recursos para garantizar que las máquinas virtuales se organizan en entornos independientes: uno para las pruebas unitarias, otro para las pruebas de integración y un tercero para las pruebas de aceptación. Solo tiene que crear los grupos de recursos una vez, por lo que, en este caso de uso, el modo interactivo de PowerShell es una buena elección.

Cuando se escribe un comando en PowerShell, este lo hace coincidir con un _cmdlet_ y luego realiza la acción solicitada. En primer lugar, veremos algunos comandos comunes que puede usar, después veremos cómo instalar la compatibilidad de Azure con PowerShell.

#### ¿Qué son los cmdlets de PowerShell?

Un comando de PowerShell se denomina **cmdlet** (que se pronuncia “command-let”). Un cmdlet es un comando que manipula una sola característica. El término **cmdlet** quiere decir "pequeño comando". Por convención, se anima a los autores de cmdlets a hacerlos sencillos y con un único propósito.

El producto base de PowerShell incluye cmdlets que funcionan con características como las sesiones y los trabajos en segundo plano. Puede agregar módulos a la instalación de PowerShell para obtener cmdlets que manipulen otras características. Por ejemplo, hay módulos de terceros para trabajar con FTP, administrar el sistema operativo, acceder al sistema de archivos, etc.

Los cmdlets siguen una convención de nomenclatura verbo-sustantivo; por ejemplo, `Get-Process`, `Format-Table` y `Start-Service`. También hay una convención para la elección del verbo: "get" para recuperar datos, "set" para insertar o actualizar datos, "format" para dar formato a los datos, "out" para dirigir la salida a un destino, etc.

Se recomienda a los creadores de cmdlets incluir un archivo de ayuda con cada cmdlet. El cmdlet `Get-Help` muestra el archivo de ayuda de cualquier cmdlet. Por ejemplo, para obtener ayuda sobre el cmdlet `Get-ChildItem`, escriba la siguiente instrucción en una sesión de Windows PowerShell:

```PoweShell
Get-Help -Name Get-ChildItem -Detailed
```

#### ¿Qué son los módulos de PowerShell?

Los cmdlets se suministran en _módulos_. Un módulo PowerShell es una biblioteca de vínculos dinámicos (DLL) que incluye el código para procesar cada cmdlet disponible. Carga cmdlets en PowerShell mediante la carga del módulo en el que están contenidos. Para obtener una lista de los módulos cargados, use el comando `Get-Module`:

```PowerShell
Get-Module
```

Este comando genera un resultado similar a este:

```Output
ModuleType Version    Name                                ExportedCommands
---------- -------    ----                                ----------------
Manifest   3.1.0.0    Microsoft.PowerShell.Management     {Add-Computer, Add-Content, Checkpoint-Computer, Clear-Con...
Manifest   3.1.0.0    Microsoft.PowerShell.Utility        {Add-Member, Add-Type, Clear-Variable, Compare-Object...}
Binary     1.0.0.1    PackageManagement                   {Find-Package, Find-PackageProvider, Get-Package, Get-Pack...
Script     1.0.0.1    PowerShellGet                       {Find-Command, Find-DscResource, Find-Module, Find-RoleCap...
Script     2.0.0      PSReadline                          {Get-PSReadLineKeyHandler, Get-PSReadLineOption, Remove-PS...
```

#### ¿Qué es el módulo Az de PowerShell?

**Az** es el nombre formal del módulo de Azure PowerShell, que contiene cmdlets para trabajar con las características de Azure. Contiene cientos de cmdlets que le permiten controlar casi cualquier aspecto de todos los recursos de Azure. Puede trabajar con grupos de recursos, almacenamiento, máquinas virtuales, Microsoft Entra ID, contenedores, aprendizaje automático, etc. El módulo **Az** es un componente de código abierto [disponible en GitHub](https://github.com/Azure/azure-powershell).

 Nota

Es posible que haya visto o usado comandos de Azure PowerShell con un formato `-AzureRM`. Como los módulos de Az PowerShell ya tienen todas las funcionalidades de los de AzureRM PowerShell, incluso más, el 29 de febrero de 2024 se van a retirar estos últimos. Para evitar interrupciones del servicio, [actualice los scripts](https://aka.ms/azpsmigrate) que usan los módulos de AzureRM PowerShell para que utilicen los de Az PowerShell antes del 29 de febrero de 2024. Para actualizar automáticamente los scripts, siga la [guía de inicio rápido](https://learn.microsoft.com/es-es/powershell/azure/quickstart-migrate-azurerm-to-az-automatically).

##### Instale el módulo Az de PowerShell.

El módulo Az de PowerShell está disponible en un repositorio global llamado Galería de PowerShell. Se puede instalar en la máquina local por medio del cmdlet `Install-Module`.

Para instalar el módulo Azure Az de PowerShell más reciente, ejecute los comandos siguientes:

1. Abra el menú **Inicio** y escriba **PowerShell**.
    
2. Seleccione el icono de **PowerShell**.
    
3. Escriba el siguiente comando y presione Entrar:

```PowerShell
Install-Module -Name Az -Scope CurrentUser -Repository PSGallery -AllowClobber
```

El comando anterior instala el módulo para el usuario actual (controlado por el parámetro `Scope`).

El comando se basa en NuGet para recuperar componentes. En función de la versión de NuGet que haya instalado, es posible que reciba un mensaje para descargar e instalar la versión más reciente.

```Output
NuGet provider is required to continue
PowerShellGet requires NuGet provider version '2.8.5.201' or newer to interact with NuGet-based repositories. The NuGet
 provider must be available in 'C:\Program Files\PackageManagement\ProviderAssemblies' or
'C:\Users\<username>\AppData\Local\PackageManagement\ProviderAssemblies'. You can also install the NuGet provider by running
'Install-PackageProvider -Name NuGet -MinimumVersion 2.8.5.201 -Force'. Do you want PowerShellGet to install and import
 the NuGet provider now?
 [Y] Yes  [N] No  [S] Suspend  [?] Help (default is "Y"):
```

Escriba **Y** y presione Entrar.

De manera predeterminada, Galería de PowerShell no está configurada como un repositorio de confianza para PowerShellGet. Cada vez que realice una instalación desde un repositorio que no sea de confianza, se le pide que confirme que quiere instalar el módulo con la siguiente salida:

```Output
You are installing the modules from an untrusted repository. If you trust this repository, change its
InstallationPolicy value by running the Set-PSRepository cmdlet. Are you sure you want to install the modules from
'PSGallery'?
[Y] Yes  [A] Yes to All  [N] No  [L] No to All  [S] Suspend  [?] Help (default is "N"):
```

Escriba **Y** o **A**, y luego presione Entrar.

###### Error en la ejecución del script

En función de la configuración de seguridad, es posible que se produzca un error en `Import-Module` como el de la salida siguiente:

```Output
import-module : File C:\Program Files\PowerShell\Modules\az\6.3.0\Az.psm1 cannot be loaded
because running scripts is disabled on this system. For more information, see about_Execution_Policies at
https:/go.microsoft.com/fwlink/?LinkID=135170.
At line:1 char:1
+ import-module Az
+ ~~~~~~~~~~~~~~~~~~~~~
    + CategoryInfo          : SecurityError: (:) [Import-Module], PSSecurityException
    + FullyQualifiedErrorId : UnauthorizedAccess,Microsoft.PowerShell.Commands.ImportModuleCommand
```

También es posible que no responda en absoluto y no se pueda realizar la acción. En este caso, presione Ctrl+C para detener el programa.

Los dos comportamientos normalmente indican que la directiva de ejecución está "restringida", lo que significa que no se pueden ejecutar los módulos que se descarguen de un origen externo (lo que incluye la Galería de PowerShell). Para comprobarlo, ejecute el cmdlet `Get-ExecutionPolicy`. Si el cmdlet devuelve "Restricted (Restringida)", entonces:

1. Use el cmdlet `Set-ExecutionPolicy` para cambiar la directiva a "RemoteSigned":

```PowerShell
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
```

Se le pide permiso:

```Output
The execution policy helps protect you from scripts that you do not trust. Changing the execution policy might expose
you to the security risks described in the about_Execution_Policies help topic at
https:/go.microsoft.com/fwlink/?LinkID=135170. Do you want to change the execution policy?
[Y] Yes  [A] Yes to All  [N] No  [L] No to All  [S] Suspend  [?] Help (default is "N"): Y
```

2. Escriba **Y** o **A**, y luego presione Entrar.
    
3. En el símbolo del sistema, presione la Flecha arriba del teclado y vuelva a ejecutar el comando `Install-Module` para Azure.
    

Debería poder ver que se carga del módulo Az de PowerShell. Cuando termine, podrá usar `Import-Module` para cargar los cmdlets.

##### Actualización de un módulo de PowerShell

Puede recibir una advertencia o un mensaje de error que indique que ya está instalada una versión del módulo Azure PowerShell. Si es así, puede emitir el siguiente comando para actualizar a la versión _más reciente_.

```PowerShell
Update-Module -Name Az
```

Como sucede con el cmdlet `Install-Module`, responda **Sí** o **Sí a todo** cuando se le pregunte si confía en el módulo. Si tiene problemas, también puede usar el comando `Update-Module` para volver a instalar un módulo.

#### Ejemplo: creación de un grupo de recursos con Azure PowerShell

Una vez que haya instalado el módulo de Azure, puede empezar a trabajar con Azure. Vamos a realizar una tarea común: crear un grupo de recursos. Como sabe, los grupos de recursos se usan para administrar conjuntamente los recursos relacionados. La creación de un grupo de recursos es una de las primeras tareas que se realizan al iniciar una nueva solución de Azure.

Debe realizar cuatro pasos:

1. Importar los cmdlets de Azure.
    
2. Conectarse a la suscripción de Azure.
    
3. Crear el grupo de recursos.
    
4. Compruebe que la creación se ha realizado correctamente.
    

En la siguiente ilustración se muestra información general de estos pasos:

![[Pasted image 20231228180719.png]]


##### Importación de los cmdlets de Azure

A partir de PowerShell 3.0, los módulos se cargan automáticamente cuando se usa un cmdlet dentro del módulo. Ya no es necesario importar manualmente módulos de PowerShell a menos que haya cambiado la configuración predeterminada de carga automática de módulos.

##### Conexión

Cuando trabaje con una instalación local de Azure PowerShell, tiene que autenticarse para poder ejecutar los comandos de Azure. El cmdlet `Connect-AzAccount` le pide las credenciales de Azure y luego se conecta a la suscripción de Azure. Tiene muchos parámetros opcionales, pero, si lo único que necesita es un aviso interactivo, no se necesita ningún parámetro:

```Azure PowerShell
Connect-AzAccount
```

##### Trabajo con suscripciones

Si es la primera vez que usa Azure, es probable que solo tenga una suscripción. Pero si ya lleva un tiempo usándolo, puede haber creado varias suscripciones de Azure. Puede configurar Azure PowerShell para ejecutar comandos en una suscripción determinada.

No puede estar en varias suscripciones a la vez. Use el cmdlet `Get-AzContext` para determinar qué suscripción está activa. Si no es la correcta, puede cambiar las suscripciones mediante otro cmdlet.

1. Obtenga una lista de los nombres de todas las suscripciones de la cuenta con el comando `Get-AzSubscription`.
    
2. Cambie la suscripción, para lo que debe usar el nombre de la que va a seleccionar.


``` Azure PowerShell
Set-AzContext -Subscription '00000000-0000-0000-0000-000000000000'
```

Si necesita buscar el **Id. de suscripción**, vaya a Azure Portal y seleccione **Suscripciones** en la página de inicio

##### Obtención de una lista de todos los grupos de recursos

Puede recuperar una lista de todos los grupos de recursos de la suscripción activa.

```Azure PowerShell
Get-AzResourceGroup
```

Para obtener una vista más concisa, puede enviar la salida de `Get-AzResourceGroup` al cmdlet `Format-Table` mediante el signo "| ".

```Azure PowerShell
Get-AzResourceGroup | Format-Table
```

El resultado es parecido a este:

```Output
ResourceGroupName                  Location       ProvisioningState Tags TagsTable ResourceId
-----------------                  --------       ----------------- ---- --------- ----------
cloud-shell-storage-southcentralus southcentralus Succeeded                        /subscriptions/00000000-0000-0000...
ExerciseResources                  eastus         Succeeded                        /subscriptions/00000000-0000-0000...
```

##### Crear un grupo de recursos

Como sabe, cuando vaya a crear recursos en Azure, siempre los pondrá en un grupo de recursos para facilitar su administración. A menudo un grupo de recursos es uno de los primeros elementos que se crean al iniciar una nueva aplicación.

Puede crear grupos de recursos con el cmdlet `New-AzResourceGroup`. Debe especificar un nombre y una ubicación. El nombre debe ser único dentro de su suscripción. La ubicación determina dónde se almacenan los metadatos del grupo de recursos (lo que puede ser importante por motivos de cumplimiento). Use cadenas como "Oeste de EE. UU.", "Europa del Norte" u "Oeste de la India" para especificar la ubicación. Como sucede con la mayoría de los cmdlets de Azure, `New-AzResourceGroup` tiene muchos parámetros opcionales. Sin embargo, la sintaxis principal es la siguiente:

```PowerShell
New-AzResourceGroup -Name <name> -Location <location>
```

	 Nota
	
	Recuerde que se trabajará en un espacio aislado de Azure activo, que crea automáticamente el grupo de recursos. Use el comando anterior si prefiere trabajar en una suscripción propia.

##### Comprobación de los recursos

`Get-AzResource` enumera los recursos de Azure, lo que resulta útil aquí para comprobar que la creación de los recursos y el grupo de recursos se ha realizado correctamente.

```PowerShell
Get-AzResource
```

Al igual que el comando `Get-AzResourceGroup`, puede obtener una vista más concisa a través del cmdlet `Format-Table`:

```PowerShell
Get-AzResource | Format-Table
```

También puede filtrarlo por grupos de recursos específicos para que solo se enumeren los recursos asociados a un grupo concreto:

```PowerShell
Get-AzResource -ResourceGroupName ExerciseResources
```

##### Cree una máquina virtual de Azure.

Otra tarea común que puede hacer con PowerShell es crear máquinas virtuales.

Azure PowerShell proporciona el cmdlet `New-AzVm` para crear una máquina virtual. El cmdlet tiene muchos parámetros para que pueda controlar la gran cantidad de valores de configuración de la máquina virtual. La mayoría de los parámetros tiene valores predeterminados razonables, por lo que solo es necesario especificar cinco elementos:

- **ResourceGroupName**: el grupo de recursos debería ponerse la nueva máquina virtual.
- **Name**: el nombre de la máquina virtual en Azure.
- **Ubicación**: la ubicación geográfica en la que debería aprovisionarse la máquina virtual.
- **Credential**: un objeto que contiene el nombre de usuario y la contraseña de la cuenta de administrador de la máquina virtual. Aquí se usa el cmdlet `Get-Credential`. Este cmdlet pide un nombre de usuario y una contraseña, los empaqueta en un objeto de credencial.
- **Imagen**: la imagen de sistema operativo que se va a usar para la máquina virtual, que normalmente es una distribución de Linux o Windows Server.

```PowerShell
New-AzVm
       -ResourceGroupName <resource group name>
       -Name <machine name>
       -Credential <credentials object>
       -Location <location>
       -Image <image name>
```

Estos parámetros se pueden suministrar directamente al cmdlet como se ha indicado en el ejemplo anterior. Como alternativa, puede usar otros cmdlets para configurar la máquina virtual, como `Set-AzVMOperatingSystem`, `Set-AzVMSourceImage`, `Add-AzVMNetworkInterface` y `Set-AzVMOSDisk`.

Este es un ejemplo de las cadenas del cmdlet `Get-Credential` junto con el parámetro `-Credential`:

```PowerShell
New-AzVM -Name MyVm -ResourceGroupName ExerciseResources -Credential (Get-Credential) ...
```

El sufijo `AzVM` es específico de los comandos basados en máquina virtual de PowerShell. No obstante, se pueden usar otros:

|Comando|Descripción|
|---|---|
|`Remove-AzVM`|Elimina una máquina virtual de Azure|
|`Start-AzVM`|Inicia una máquina virtual detenida|
|`Stop-AzVM`|Detiene una máquina virtual en ejecución|
|`Restart-AzVM`|Reinicia una máquina virtual|
|`Update-AzVM`|Actualiza la configuración de una máquina virtual|

###### Ejemplo: Obtención de información de una máquina virtual

Puede enumerar las máquinas virtuales de la suscripción con el comando `Get-AzVM -Status`. Este comando también admite la especificación de una máquina virtual específica mediante la inclusión de la propiedad `-Name`. Aquí, se asigna a una variable de PowerShell:

```PowerShell
$vm = Get-AzVM  -Name MyVM -ResourceGroupName ExerciseResources
```

Lo interesante es que ahora la máquina virtual es un _objeto_ con el que puede interactuar. Por ejemplo, puede realizar cambios en ese objeto y, después, devolverlos a Azure con el comando `Update-AzVM`:

```PowerShell
$ResourceGroupName = "ExerciseResources"
$vm = Get-AzVM  -Name MyVM -ResourceGroupName $ResourceGroupName
$vm.HardwareProfile.vmSize = "Standard_DS3_v2"

Update-AzVM -ResourceGroupName $ResourceGroupName  -VM $vm
```

El modo interactivo de PowerShell es adecuado para tareas aisladas. En el ejemplo, se usa el mismo grupo de recursos durante todo el proyecto, por lo que crearlo de forma interactiva es razonable. Para esta tarea, el modo interactivo suele ser más rápido y sencillo que escribir un script y ejecutarlo solo una vez.

### Ejercicio: Creación de un recurso de Azure mediante scripts en Azure PowerShell

Recuerde el escenario original: creación de máquinas virtuales para probar el software de CRM. Cada vez que hay una nueva compilación disponible, se pone en marcha una nueva máquina virtual para poder probar la experiencia de instalación completa a partir de una imagen limpia. Cuando haya terminado, querrá eliminar la máquina virtual.

Vamos a probar los comandos para crear una máquina virtual.

#### Creación de una máquina virtual Linux con Azure PowerShell

Como se va a usar el espacio aislado de Azure, no es necesario crear un grupo de recursos. En su lugar, use el grupo de recursos **[nombre del grupo de recursos del espacio aislado]**. Además, tenga en cuenta las restricciones de ubicación.

Vamos a crear una máquina virtual de Azure con PowerShell.

1. Use el cmdlet `New-AzVm` para crear una máquina virtual.

	- Use el grupo de recursos **[nombre del grupo de recursos del espacio aislado]**.
	
	- Asigne un nombre a la máquina virtual. Normalmente se recomienda usar algo significativo que identifique los fines de la máquina virtual, la ubicación y el número de instancia (si hay más de una). Usamos "testvm-eus-01" para "Probar máquina virtual en el Este de EE. UU., instancia 1". Viene su propio nombre, en función de dónde coloque la máquina virtual.
	
	- Seleccione una ubicación cercana en la lista siguiente en el espacio aislado de Azure. Si usa Copiar y Pegar, asegúrese de cambiar el valor en el siguiente comando de ejemplo.
    
	    - westus2
	    - southcentralus
	    - centralus
	    - eastus
	    - westeurope
	    - southeastasia
	    - japaneast
	    - brazilsouth
	    - australiasoutheast
	    - centralindia
    
	- Use "Canonical:0001-com-ubuntu-server-focal:20_04-lts:latest" para la imagen. Esta imagen es Ubuntu Linux.
	    
	- Use el cmdlet `Get-Credential` y especifique los resultados en el parámetro `Credential`.
	
	  Importante
	  
		Vea las [Preguntas frecuentes sobre máquinas virtuales de Linux](https://learn.microsoft.com/es-es/azure/virtual-machines/linux/faq#what-are-the-username-requirements-when-creating-a-vm) para conocer las limitaciones del nombre de usuario y la contraseña. Las contraseñas deben tener entre 12 y 123 caracteres, y deben cumplir tres de estos cuatro requisitos de complejidad:
		
		- Deben incluir caracteres en minúscula.
		- Deben incluir caracteres en mayúscula.
		- Deben incluir un dígito.
		- Deben incluir un carácter especial (REGEX.MATCH [\W_]).
	
	- Agregue el parámetro `-OpenPorts` y pase "22" como el puerto. Este puerto permite usar SSH en la máquina.
    
	- Cree un nombre de dirección IP pública. Usará este nombre para crear y buscar la dirección IP estática para iniciar sesión en la máquina.
	
	``` PowerShell
	New-AzVm -ResourceGroupName [sandbox resource group name] -Name "testvm-eus-01" -Credential (Get-Credential) -Location "eastus" -Image Canonical:0001-com-ubuntu-server-focal:20_04-lts:latest -OpenPorts 22 -PublicIpAddressName "testvm-eus-01"
	```

2. Cree un nombre de usuario y una contraseña y luego presione Escribir. PowerShell comienza a crear la máquina virtual.
    
3. La creación de la máquina virtual tarda unos minutos en completarse. Una vez hecho, puede consultar y asignar el objeto de máquina virtual a una variable (`$vm`).

	```PowerShell
	$vm = (Get-AzVM -Name "testvm-eus-01" -ResourceGroupName [sandbox resource group name])
	```

4. Consulte el valor para volcar la información sobre la máquina virtual.

	```PowerShell
	$vm
	```

	Debería ver algo parecido a la salida siguiente

	```PowerShell
	ResourceGroupName : [sandbox resource group name]
	Id                : /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/[sandbox resource group name]/providers/Microsoft.Compute/virtualMachines/testvm-eus-01
	VmId              : 00000000-0000-0000-0000-000000000000
	Name              : testvm-eus-01
	Type              : Microsoft.Compute/virtualMachines
	Location          : eastus
	Tags              : {}
	HardwareProfile   : {VmSize}
	NetworkProfile    : {NetworkInterfaces}
	OSProfile         : {ComputerName, AdminUsername, LinuxConfiguration, Secrets}
	ProvisioningState : Succeeded
	StorageProfile    : {ImageReference, OsDisk, DataDisks}
	```

5. Puede acceder a objetos complejos mediante una notación de punto (`.`). Por ejemplo, para ver las propiedades del objeto `VMSize` asociado a la sección HardwareProfile, ejecute el comando siguiente:

	```PowerShell
	$vm.HardwareProfile
	```

6. También puede obtener información sobre uno de los discos; para ello, ejecute el comando siguiente:

	```PowerShell
	$vm.StorageProfile.OsDisk
	```

7. Incluso puede pasar el objeto de máquina virtual a otros cmdlets. Por ejemplo, al ejecutar el siguiente comando se mostrarán todos los tamaños disponibles para la máquina virtual:

	```PowerShell
	$vm | Get-AzVMSize
	```

8. Ahora, ejecute el comando siguiente para obtener la dirección IP pública:

	```PowerShell
	Get-AzPublicIpAddress -ResourceGroupName [sandbox resource group name] -Name "testvm-eus-01"
	```

9. Con la dirección IP, puede conectarse a la máquina virtual con SSH. Por ejemplo, si usó el nombre de usuario `bob` y la dirección IP fuera `205.22.16.5`, la ejecución de este comando conectaría a la máquina Linux:

	```PowerShell
	ssh bob@205.22.16.5
	```

	Cierre la sesión escribiendo `exit`.

#### Eliminación de una máquina virtual

Para probar algunos comandos más, vamos a eliminar la máquina virtual. En primer lugar, es necesario apagarlo (escriba **Y** si se le pide que continúe):

```PowerShell
Stop-AzVM -Name $vm.Name -ResourceGroupName $vm.ResourceGroupName
```

Cuando la máquina virtual se haya detenido, elimine la máquina virtual mediante la ejecución del cmdlet `Remove-AzVM` (escriba **Y** si se le pide que continúe):

```PowerShell
Remove-AzVM -Name $vm.Name -ResourceGroupName $vm.ResourceGroupName
```

Ejecute este comando para enumerar todos los recursos del grupo de recursos:

```PowerShell
Get-AzResource -ResourceGroupName $vm.ResourceGroupName | Format-Table
```

Debería ver diferentes recursos (discos, redes virtuales, etc.) que aún existen.

```Output
Microsoft.Compute/disks
Microsoft.Network/networkInterfaces
Microsoft.Network/networkSecurityGroups
Microsoft.Network/publicIPAddresses
Microsoft.Network/virtualNetworks
```

El comando `Remove-AzVM`_solo elimina la máquina virtual_. No limpia ninguno de los demás recursos. En este punto, simplemente eliminaríamos el grupo de recursos y nos libraríamos de él. Pero vamos a continuar el ejercicio para limpiar manualmente. Debería ver un patrón en los comandos.

1. Elimine la interfaz de red:

	```PowerShell
	$vm | Remove-AzNetworkInterface –Force
	```

2. Elimine los discos administrados del SO:

	```PowerShell
	Get-AzDisk -ResourceGroupName $vm.ResourceGroupName -DiskName $vm.StorageProfile.OSDisk.Name | Remove-AzDisk -Force
	```

3. A continuación, elimine la red virtual:

	```PowerShell
	Get-AzVirtualNetwork -ResourceGroupName $vm.ResourceGroupName | Remove-AzVirtualNetwork -Force
	```

4. Elimine el grupo de seguridad de red:

	```PowerShell
	Get-AzNetworkSecurityGroup -ResourceGroupName $vm.ResourceGroupName | Remove-AzNetworkSecurityGroup -Force
	```

5. Por último, elimine la IP pública:

```PowerShell
Get-AzPublicIpAddress -ResourceGroupName $vm.ResourceGroupName | Remove-AzPublicIpAddress -Force
```

Debemos haber detectado todos los recursos creados. Compruebe el grupo de recursos simplemente para asegurarse. Aquí se han usado muchos comandos manuales, pero un enfoque mejor habría sido escribir un _script_. Después, se podría reutilizar esta lógica más adelante para crear o eliminar una máquina virtual. Vamos a examinar la creación de scripts con PowerShell.

### Creación y guardado de scripts en Azure PowerShell

Las tareas complejas o repetitivas suelen consumir una gran cantidad de tiempo administrativo. Las organizaciones prefieren automatizar estas tareas para reducir los costos y evitar errores.

**La automatización es importante** en el ejemplo de la empresa Administración de relaciones con los clientes (CRM). En ese ejemplo, el software se prueba en varias Linux Virtual Machines (VM) que es necesario eliminar y volver a crear de forma continua. Quiere usar un script de PowerShell **para** automatizar **la creación de las máquinas virtuales en lugar de crearlas manualmente cada vez**.

Además de la operación básica para crear una máquina virtual, hay varios requisitos más para el script:

- Creará varias máquinas virtuales, por lo que le interesa colocar la creación dentro de un bucle.
- Tendrá que crear las máquinas virtuales en tres grupos de recursos diferentes, por lo que el nombre del grupo de recursos se debe pasar al script como un parámetro.

En esta sección, verá cómo escribir y ejecutar un script de Azure PowerShell que cumple estos requisitos.

#### ¿Qué es un script de PowerShell?

Un script de PowerShell es un archivo de texto que contiene comandos y construcciones de control. Los comandos son invocaciones de los cmdlets. Las construcciones de control son características de programación como bucles, variables, parámetros, comentarios, etc., proporcionadas por PowerShell.

Los archivos de script de PowerShell tienen la extensión de archivo `.ps1`. Puede crear y guardar estos archivos con cualquier editor de texto.

	 Sugerencia
	
	Si va a escribir scripts de PowerShell en Windows, puede usar el entorno de scripting integrado (ISE) de Windows PowerShell. Este editor proporciona características como color de sintaxis y una lista de los cmdlets disponibles.

La captura de pantalla siguiente muestra Windows PowerShell ISE con un script de ejemplo para conectarse a Azure y crear una máquina virtual en Azure.

![[Pasted image 20231229101419.png]]

Después de escribir el script, para ejecutarlo desde la línea de comandos de PowerShell, pase el nombre del archivo precedido por un punto y una barra diagonal inversa:

```PowerShell
.\myScript.ps1
```

#### Técnicas de PowerShell

PowerShell tiene muchas características que se encuentran en los lenguajes de programación típicos. Se pueden definir variables, usar bifurcaciones y bucles, parámetros de línea de comandos de captura, escribir funciones, agregar comentarios y así sucesivamente. En este script se necesitarán tres características: variables, bucles y parámetros.

##### Variables

Como ha visto en la unidad anterior, PowerShell admite variables. Use `$` para declarar una variable y `=` para asignar un valor. Por ejemplo:

```PowerShell
$loc = "East US"
$iterations = 3
```

Las variables pueden contener objetos. Por ejemplo, en la definición siguiente se establece la variable **adminCredential** para el objeto devuelto por el cmdlet **Get-Credential**.

```PowerShell
$adminCredential = Get-Credential
```


Para obtener el valor almacenado en una variable, use el prefijo `$` y su nombre como se muestra a continuación:

```PowerShell
$loc = "East US"
New-AzResourceGroup -Name "MyResourceGroup" -Location $loc
```

##### Bucles

PowerShell tiene varias estructuras de bucle, como `For`, `Do...While` y `For...Each`. El bucle `For` es la mejor coincidencia para nuestras necesidades ya que ejecutaremos un cmdlet un número fijo de veces.

En el ejemplo siguiente se muestra la sintaxis básica. El ejemplo se ejecuta durante dos iteraciones y, cada vez, se imprime el valor de **i**. Los operadores de comparación se escriben `-lt` para "menor que", `-le` para "menor o igual que", `-eq` para "igual", `-ne` para "no igual", etc.

```PowerShell
For ($i = 1; $i -lt 3; $i++)
{
    $i
}
```

##### Parámetros

Cuando se ejecuta un script, se pueden pasar argumentos en la línea de comandos. Se pueden proporcionar nombres para cada parámetro para ayudar a que el script extraiga los valores. Por ejemplo:

```PowerShell
.\setupEnvironment.ps1 -size 5 -location "East US"
```

Dentro del script, los valores se capturan en variables. En este ejemplo, los parámetros se comparan por nombre:

```PowerSHell
param([string]$location, [int]$size)
```

Puede omitir los nombres de la línea de comandos. Por ejemplo:

```PowerShell
.\setupEnvironment.ps1 5 "East US"
```

Dentro del script, se recurre a la posición para buscar coincidencias cuando los parámetros no tienen nombre:

```PowerShell
param([int]$size, [string]$location)
```

La combinación de PowerShell y Azure PowerShell ofrece todas las herramientas necesarias para la automatización de Azure. En nuestro ejemplo CRM, podremos crear varias máquinas virtuales con Linux con un parámetro para que el script sea genérico y un bucle para evitar código repetido. Este script nos permite ejecutar una operación anteriormente compleja en un solo paso.

### Ejercicio: Creación y guardado de scripts en Azure PowerShell

En esta unidad, continuará con el ejemplo de una empresa que crea herramientas administrativas con Linux. Recuerde que tiene previsto usar máquinas virtuales Linux para permitir que los clientes potenciales prueben el software. Tiene un grupo de recursos listo y ahora es el momento de crear las máquinas virtuales.

La empresa ha pagado por un stand en una gran feria de Linux. Planea habilitar un área de demostración que contiene tres terminales, cada una de ellas conectada a una máquina virtual Linux independiente. Al final de cada día, desea eliminar las máquinas virtuales y volver a crearlas, para empezar de cero cada mañana. Crear las máquinas virtuales manualmente después de trabajar cuando está cansado sería una tarea propensa a errores. Quiere escribir un script de PowerShell para automatizar el proceso de creación de máquinas virtuales.

#### Escritura de un script para crear máquinas virtuales

Siga estos pasos en Cloud Shell a la derecha para escribir el script:

1. Cambie a la carpeta principal en Cloud Shell.

	```PowerShell
	cd $HOME\clouddrive
	```

2. Cree un archivo de texto denominado **ConferenceDailyReset.ps1**.

	```PowerShell
	touch "./ConferenceDailyReset.ps1"
	```

3. Abra el editor integrado y seleccione el archivo **ConferenceDailyReset.ps1**.

	```PowerShell
	code "./ConferenceDailyReset.ps1"
	```

	 Sugerencia
	
	Cloud Shell integrado también admite emacs, vim y nano si prefiere usar uno de esos editores.


4. Empiece por capturar el parámetro de entrada en una variable. Agregue la siguiente línea al script.

```PowerShell
param([string]$resourceGroup)
```

 Nota

Normalmente, tendría que autenticarse en Azure con las credenciales mediante `Connect-AzAccount` y esto se puede hacer en el script. Pero en el entorno de Cloud Shell ya está autenticado, por lo que esto no es necesario.

5. Pida un nombre de usuario y una contraseña para la cuenta de administrador de la máquina virtual y capture el resultado en una variable:

	```PowerShell
	$adminCredential = Get-Credential -Message "Enter a username and password for the VM administrator."
	```

6. Cree un bucle que se ejecute tres veces:

	```PowerShell
	For ($i = 1; $i -le 3; $i++) 
	{
	
	}
	```

7. En el cuerpo del bucle, cree un nombre para cada máquina virtual, almacénelo en una variable y envíelo a la consola:

	```PowerShell
	$vmName = "ConferenceDemo" + $i
	Write-Host "Creating VM: " $vmName
	```

8. Luego cree una máquina virtual con la variable `$vmName`:

	```PowerShell
	New-AzVm -ResourceGroupName $resourceGroup -Name $vmName -Credential $adminCredential -Image Canonical:0001-com-ubuntu-server-focal:20_04-lts:latest
	```

9. Guarde el archivo. Puede usar el menú "..." de la esquina superior derecha del editor. También hay métodos abreviados de teclado comunes para _Guardar_, como `Ctrl + S`.


El script completado debería ser similar al código siguiente:

```PowerShell
param([string]$resourceGroup)

$adminCredential = Get-Credential -Message "Enter a username and password for the VM administrator."

For ($i = 1; $i -le 3; $i++)
{
    $vmName = "ConferenceDemo" + $i
    Write-Host "Creating VM: " $vmName
    New-AzVm -ResourceGroupName $resourceGroup -Name $vmName -Credential $adminCredential -Image Canonical:0001-com-ubuntu-server-focal:20_04-lts:latest
}
```

#### Ejecución del script

1. Guarde el archivo y cierre el editor mediante el menú contextual "..." de la parte superior derecha del editor (o use Ctrl + Q).
    
2. Ejecute el script.

	```PowerShell
	./ConferenceDailyReset.ps1 [sandbox resource group name]
	```

	El script puede tardar varios minutos en completarse. Cuando haya finalizado, examine los recursos que ahora hay en el grupo de recursos para comprobar que se ha ejecutado correctamente:

	```PowerShell
	Get-AzResource -ResourceType Microsoft.Compute/virtualMachines
	```

Debería tener tres máquinas virtuales, cada una con un nombre único.

Ha escrito un script que ha automatizado la creación de tres máquinas virtuales en el grupo de recursos indicado por un parámetro de script. El script es corto y sencillo pero automatiza un proceso que tardaría mucho tiempo en completar manualmente en Azure Portal.

### Resumen

En este módulo, hemos escrito un script para automatizar la creación de varias máquinas virtuales. Aunque el script era relativamente corto, puede ver las posibilidades de combinar bucles, variables y funciones de PowerShell con cmdlets de PowerShell de Azure PowerShell.

Azure PowerShell es una buena opción de automatización para los administradores con experiencia en PowerShell. También merece la pena considerar la combinación de una sintaxis limpia y un eficaz lenguaje de scripting incluso si no está familiarizado con PowerShell. Este nivel de automatización para tareas laboriosas y propensas a errores le ayudará a reducir el tiempo dedicado a la administración y aumentar la calidad.

#### Limpieza

El espacio aislado limpia los recursos automáticamente cuando haya terminado con este módulo.

Al trabajar en una suscripción propia, se recomienda identificar al final de un proyecto si aún necesita los recursos creados. Los recursos que dejas en ejecución pueden costar dinero. Puede eliminar los recursos de forma individual o eliminar el grupo de recursos para eliminar todo el conjunto de recursos.

Cuando se ejecuta en su propia suscripción, puede usar el siguiente cmdlet de PowerShell para eliminar el grupo de recursos y todos los recursos relacionados (reemplazando _MyResourceGroupName_ por el grupo de recursos que creó).

```PowerShell
Remove-AzResourceGroup -Name MyResourceGroupName
```

Cuando se le pida que confirme la eliminación, responda **Sí** o agregue el parámetro `-Force` para omitir el símbolo del sistema. El comando puede tardar varios minutos en completarse.

#### Comprobar los conocimientos

1. Verdadero o falso: Azure Portal, la CLI de Azure y Azure PowerShell ofrecen servicios bastante diferentes, por lo que es poco probable que las tres admitan el funcionamiento que necesita.

<details>
	<summary>Respuesta</summary>
	<p><b>Falso</b> Las tres herramientas ofrecen casi el mismo conjunto de servicios. Por lo general, los servicios no son un factor a la hora de decidir qué herramienta es mejor para sus tareas.</p>
</details>

2. Supongamos que está compilando una aplicación de edición de vídeos que ofrecerá almacenamiento en línea para el contenido de vídeo que generan los usuarios. Almacenará los vídeos en blobs de Azure, por lo que necesitará crear una cuenta de almacenamiento de Azure en la que contener los blogs. Una vez que la cuenta de almacenamiento esté preparada, es poco probable que la vaya a eliminar y volver a crear porque esto eliminaría todos los vídeos de los usuarios. ¿Qué herramienta es probable que ofrezca la forma más rápida y sencilla de crear la cuenta de almacenamiento?

<details>
	<summary>Respuesta</summary>
	<p><b>Azure Portal</b> El portal es una buena elección para operaciones únicas como la creación de una cuenta de almacenamiento duradera. El portal le ofrece una interfaz gráfica de usuario que contiene todas las propiedades de la cuenta de almacenamiento y proporciona información sobre herramientas para ayudarle a seleccionar las opciones adecuadas a sus necesidades.</p>
</details>

3. ¿Qué debe instalar en el equipo para poder ejecutar cmdlets de Azure PowerShell de forma local?

<details>
	<summary>Respuesta</summary>
	<p>Necesita tanto el producto base de <b>PowerShell como el módulo de Az de PowerShell</b>. El producto base ofrece el shell, algunos comandos principales y construcciones de programación, como bucles, variables, etc. El módulo Az de PowerShell agrega los cmdlets que se necesitan para trabajar con recursos de Azure.</p>
</details>

## Control de los servicios de Azure con la CLI

### Introducción

Azure Portal es idóneo para realizar tareas únicas y para ver información general rápida del estado de los recursos. Sin embargo, para tareas que hay que repetir diariamente, o incluso cada hora, el uso de la línea de comandos y un conjunto de comandos o scripts probados puede ayudarle a realizar el trabajo más rápido y evitar errores.

Supongamos que trabaja en una empresa que desarrolla aplicaciones web de Azure. Estas son aplicaciones hospedadas en Azure, con todas las ventajas de configuración automática de seguridad, equilibrio de carga, administración, etc. Está probando actualmente una aplicación web que genera previsiones de ventas, según un intervalo de entradas de diferentes bases de datos y otros orígenes de datos. Los desarrolladores usan equipos Windows, Linux y Mac, junto con un repositorio de GitHub para las compilaciones diarias de las aplicaciones.

Como parte de las pruebas, quiere comparar el rendimiento de la aplicación con diferentes orígenes de datos y diferentes tipos de conexiones de datos. Ha observado que cuando el equipo de desarrollo usa Azure Portal para crear una nueva instancia de prueba de la aplicación, no siempre usan exactamente los mismos parámetros. Para solucionar este problema, piensa usar un conjunto de comandos de implementación estándar para cada prueba de aplicación, que se pueden automatizar si es necesario, y que funcionarán de la misma manera en todos los equipos que usa el equipo de software.

En este módulo, aprenderá cómo administrar recursos de Azure mediante la CLI de Azure.

#### Objetivos de aprendizaje

En este módulo, aprenderemos a:

- Instalar la CLI de Azure en Linux, macOS o Windows.
- Conectarse a una suscripción de Azure mediante la CLI de Azure
- Crear recursos de Azure mediante la CLI de Azure

#### Requisitos previos

- Experimentar con una interfaz de línea de comandos, como PowerShell o Bash
- Conocimiento de conceptos básicos de Azure, como los grupos de recursos
- Experiencia con la administración de recursos de Azure mediante Azure Portal

### ¿Qué es la CLI de Azure?

La CLI de Azure es un programa de **línea de comandos para conectarse a Azure y ejecutar comandos administrativos en recursos de Azure**. Se ejecuta en Linux, macOS y Windows y permite que los administradores y desarrolladores ejecuten sus comandos a través del símbolo del sistema (o script) de la línea de comandos o un terminal, en lugar de hacerlo en un explorador web. Por ejemplo, para reiniciar una máquina virtual (VM), usaría el siguiente comando:

```Azure CLI
az vm restart -g MyResourceGroup -n MyVm
```

La CLI de Azure proporciona herramientas de línea de comandos multiplataforma para administrar recursos de Azure, y puede instalarla de forma sencilla localmente en equipos Windows, Mac o Linux. También puede usar la CLI de Azure desde un explorador mediante Azure Cloud Shell. En ambos casos, puede usarla de forma interactiva o con scripts. Para un uso interactivo, inicie primero un shell (como cmd.exe en Windows o Bash en Linux o macOS), a continuación, emita el comando en el símbolo del shell. Para automatizar tareas repetitivas, combine los comandos de la CLI en un script de shell con la sintaxis de script del shell elegido y luego ejecute el script.

#### Instalación de la CLI de Azure

En Linux y macOS, use un administrador de paquetes para instalar la CLI de Azure. El administrador de paquetes recomendado es diferente en función del sistema operativo y la distribución:

- Linux: **apt-get** en Ubuntu, **yum** en Red Hat y **zypper** en OpenSUSE
- Mac: **Homebrew**

La CLI de Azure está disponible en el repositorio de Microsoft, así que primero tiene que agregar ese repositorio al administrador de paquetes.

En Windows, puede instalar la CLI de Azure mediante la descarga y ejecución de un archivo MSI.

#### Uso de la CLI de Azure en scripts

Si quiere usar los comandos de CLI de Azure en scripts, deberá tener en cuenta los problemas derivados del "shell" (o el entorno) utilizado para ejecutar el script. Por ejemplo, en un shell de Bash, usará esta sintaxis al establecer las variables:

```Azure CLI
variable="value"
variable=integer
```

Si usa un entorno de PowerShell para ejecutar scripts de la CLI de Azure, usará esta sintaxis para las variables:

```PowerShell
$variable="value"
$variable=integer
```

Debe instalar la CLI de Azure para poder usarla para administrar los recursos de Azure desde un equipo local. Los pasos de instalación varían para Windows, Linux y macOS, pero una vez instalada, los comandos son iguales en todas las plataformas.

### Ejercicio: Instalación y ejecución de la CLI de Azure

Vamos a instalar la CLI de Azure en el equipo local y después a ejecutar un comando para comprobar la instalación. El método que se usa para instalar la CLI de Azure depende del sistema operativo del equipo. Elija los pasos correspondientes a su sistema operativo.

	 Nota
	
	Este ejercicio le guiará en el proceso de instalación local de la herramienta de la CLI de Azure. En el resto del módulo se usará Azure Cloud Shell para que pueda aprovechar la compatibilidad de la suscripción gratuita de Microsoft Learn. Puede considerar este ejercicio como una actividad opcional y simplemente revisar las instrucciones si lo prefiere.

#### Instalación de Azure CLI

##### Windows

Aquí instalará la CLI de Azure en Windows con el instalador MSI.

1. Vaya a [https://aka.ms/installazurecliwindows](https://aka.ms/installazurecliwindows) y seleccione**Ejecutar** o **Abrir archivo** en el cuadro de diálogo de seguridad del explorador.
2. En el instalador, acepte los términos de licencia y después seleccione **Instalar**.
3. En el cuadro de diálogo **Control de cuentas de usuario**, seleccione **Sí**.

##### macOS

Aquí instalará la CLI de Azure en macOS con el administrador de paquetes de Homebrew.

 Importante

Si el comando **brew** no está disponible, es posible que deba instalar el administrador de paquetes Homebrew. Para más información, vea el [sitio web de Homebrew](https://brew.sh/).

1. Actualice el repositorio de brew para asegurarse de que obtiene el paquete más reciente de la CLI de Azure:

```Bash
brew update
```

2. Instalar la CLI de Azure:

```Bash
brew install azure-cli
```

##### Linux

Aquí utilizará Advanced Packaging Tool (**apt**) y la línea de comandos de Bash para instalar la CLI de Azure en **Ubuntu Linux**.

 Sugerencia

Los siguientes comandos son para la versión 18.04 de Ubuntu. Otras versiones y distribuciones de Linux tienen instrucciones diferentes. Siga las instrucciones del artículo [Instalación de la CLI de Azure](https://learn.microsoft.com/es-es/cli/azure/install-azure-cli) si usa una versión de Linux diferente o tiene problemas.

1. Modifique la lista de orígenes para que el repositorio de Microsoft quede registrado y el administrador de paquetes pueda localizar el paquete de la CLI de Azure:

	```Bash
	AZ_REPO=$(lsb_release -cs)
	echo "deb [arch=amd64] https://packages.microsoft.com/repos/azure-cli/ $AZ_REPO main" | \
	sudo tee /etc/apt/sources.list.d/azure-cli.list
	```

2. Importe la clave de cifrado del repositorio de Ubuntu de Microsoft. Esto permite que el administrador de paquetes compruebe que el paquete de la CLI de Azure que se instala provenga de Microsoft.

	```Bash
	curl https://packages.microsoft.com/keys/microsoft.asc | sudo apt-key add -
	```

3. Instalar la CLI de Azure:

	```Bash
	sudo apt-get install apt-transport-https
	sudo apt-get update && sudo apt-get install azure-cli
	```

#### Ejecución de la CLI de Azure

Puede ejecutar la CLI de Azure abriendo un shell de bash (Linux y macOS) o desde el símbolo del sistema o PowerShell (Windows).

1. Inicie la CLI de Azure y compruebe la instalación ejecutando la comprobación de versión.
    
	```Azure CLI
	az --version
	```

	 Sugerencia
	
	La ejecución de la CLI de Azure desde PowerShell presenta algunas ventajas con respecto a la ejecución de la CLI de Azure desde el símbolo del sistema de Windows. PowerShell ofrece más características de finalización con tabulación de las que están disponibles en el símbolo del sistema.

Ha configurado las máquinas locales para administrar recursos de Azure con la CLI de Azure. Ahora puede usar la CLI de Azure localmente para especificar comandos o ejecutar scripts. La CLI de Azure reenviará los comandos a los centros de datos de Azure, en donde se ejecutarán dentro de su suscripción de Azure.


### Trabajo con la CLI de Azure

La CLI de Azure permite escribir comandos y ejecutarlos de inmediato desde la línea de comandos. Recuerde que es el objetivo general en el ejemplo de desarrollo de software es implementar nuevas compilaciones de una aplicación web para realizar pruebas. Vamos a hablar sobre los tipos de tareas que se pueden realizar con la CLI de Azure.

#### ¿Qué recursos de Azure se pueden administrar mediante la CLI de Azure?

La CLI de Azure le permite controlar casi todos los aspectos de cualquier recurso de Azure. Puede trabajar con grupos de recursos, almacenamiento, máquinas virtuales, Microsoft Entra ID, contenedores, aprendizaje automático, etc.

Los comandos de la CLI se estructuran en _grupos_ y _subgrupos_. Cada grupo representa un servicio suministrado por Azure y los subgrupos dividen los comandos para estos servicios en agrupaciones lógicas. Por ejemplo, el grupo `storage` contiene subgrupos como **cuenta**, **blob** y **cola**.

Por tanto, ¿cómo puede encontrar los comandos específicos que necesita? Una forma de hacerlo es usar `az find`, el robot de IA que emplea la documentación de Azure para darle más información sobre los comandos y la CLI, entre otros.

**Ejemplo**: encontrar los comandos más populares relacionados con la palabra **blob**:

``` Azure CLI
az find blob
```

**Ejemplo**: mostrarme los comandos más populares para un grupo de comandos de la CLI de Azure, como `az vm`:

```Azure CLI
az find "az vm"
```

**Ejemplo**: mostrarme los parámetros y subcomandos más populares para un comando de la CLI de Azure:


```Azure CLI
az find "az vm create"
```

Si ya conoce el nombre del comando que quiere, el argumento `--help` para ese comando obtendrá información más detallada sobre el comando y una lista de los subcomandos disponibles para un grupo de comandos. Por tanto, en el ejemplo de almacenamiento, se muestra cómo se puede obtener una lista de los comandos y subgrupos para administrar el almacenamiento de blobs:


```Azure CLI
az storage blob --help
```

#### Creación de un recurso de Azure

La creación de un recurso de Azure normalmente consta de tres pasos: la conexión a la suscripción de Azure, la creación del recurso y la comprobación de que se creó correctamente. En la ilustración siguiente se muestra una introducción general del proceso.

![[Pasted image 20231229120717.png]]

Cada paso se corresponde con un comando diferente de la CLI de Azure.

##### Conectar

Puesto que está trabajando con una instalación local de la CLI de Azure, tiene que autenticarse para poder ejecutar comandos de Azure mediante el comando **login** de la CLI de Azure.

```Azure CLI
az login
```

La CLI de Azure normalmente iniciará el explorador predeterminado para abrir la página de inicio de sesión de Azure. Si esto no funciona, siga las instrucciones de la línea de comandos y escriba un código de autorización en [https://aka.ms/devicelogin](https://aka.ms/devicelogin).

Una vez que la sesión se inicie correctamente, estará conectado a la suscripción de Azure.

##### Creación

A menudo, deberá crear un grupo de recursos para crear un servicio de Azure, por lo que vamos a usar grupos de recursos como ejemplo de creación de recursos de Azure desde la CLI.

El comando **group create** de la CLI de Azure crea un grupo de recursos. Debe especificar un nombre y una ubicación. El nombre debe ser único dentro de su suscripción. La ubicación determina dónde se almacenarán los metadatos para el grupo de recursos. Puede usar cadenas como "Oeste de EE. UU.", "Norte de Europa" u "Oeste de la India" para especificar la ubicación; también puede usar los equivalentes de una sola palabra, como westus, northeurope o westindia. La sintaxis básica es la siguiente:

```Azure CLI
az group create --name <name> --location <location>
```

	 Importante
	
	No es necesario crear un grupo de recursos al usar el espacio aislado de Azure gratuito. En su lugar, usará un grupo de recursos creado previamente.

##### Comprobación

Para muchos recursos de Azure, la CLI de Azure proporciona un subcomando **list** que permite ver los detalles de los recursos. Por ejemplo, el comando **group list** de la CLI de Azure enumera los grupos de recursos de Azure. Esto es útil para comprobar si el grupo de recursos se creó correctamente:

```Azure CLI
az group list
```

Para obtener una vista más concisa, puede aplicar al resultado el formato de una tabla sencilla:

```Azure CLI
az group list --output table
```

### Ejercicio: Creación de un sitio web de Azure mediante la CLI

A continuación, se usará la CLI de Azure para crear un grupo de recursos e implementar después una aplicación web en ese grupo de recursos.

El espacio aislado gratuito permite crear recursos en un subconjunto de las regiones globales de Azure. Seleccione una región de la lista al crear los recursos:

- westus2
- southcentralus
- centralus
- eastus
- westeurope

- southeastasia
- japaneast
- brazilsouth
- australiasoutheast
- centralindia

#### Uso de un grupo de recursos

Si va a trabajar con su propia máquina y su suscripción de Azure, primero debe iniciar sesión en Azure con el comando `az login`. Sin embargo, no es necesario iniciar sesión cuando se usa el entorno de espacio aislado de Cloud Shell basado en el explorador.

Normalmente, crearía un grupo de recursos a continuación para todos los recursos relacionados de Azure con un comando `az group create`, pero se ha creado el siguiente grupo de recursos para este ejercicio de forma automática:**[nombre del grupo de recursos de espacio aislado]**.

	Nota
	
	En este ejercicio, se usa la región Este de EE. UU. Si tiene algún problema para crear el plan de App Service, seleccione otra región en la lista anterior.

1. El primer paso de este ejercicio es crear múltiples variables para usarlas en comandos posteriores:
    
    
    ```Bash
    export RESOURCE_GROUP=[sandbox resource group name]
    export AZURE_REGION=eastus
    export AZURE_APP_PLAN=popupappplan-$RANDOM
    export AZURE_WEB_APP=popupwebapp-$RANDOM
    ```

2. Puede solicitar a la CLI de Azure que muestre todos los grupos de recursos en una tabla. Mientras esté en el espacio aislado de Azure gratuito, solo debería haber uno:

	```Azure CLI
	az group list --output table
	```

	 Sugerencia

	Puede usar el botón **Copiar** para copiar los comandos en el Portapapeles. Para pegarlos, haga clic con el botón derecho en una nueva línea en el terminal de Cloud Shell y seleccione **Pegar**, o bien use el método abreviado de teclado Mayús+Insert (⌘+V en macOS).

3. A medida que avance con el desarrollo en Azure, puede acabar con varios grupos de recursos. Si tiene varios elementos en la lista de grupos, puede filtrar los valores devueltos agregando una opción `--query`. Pruebe el siguiente comando:

	```Azure CLI
	az group list --query "[?name == '$RESOURCE_GROUP']"
	```

	El formato de la consulta se establece con **JMESPath**, que es un lenguaje de consulta estándar para las solicitudes JSON. Puede obtener más información sobre este eficaz lenguaje de filtro en [http://jmespath.org/](http://jmespath.org/). También analizaremos con más detalle las consultas en el módulo [**Administración de máquinas virtuales con la CLI de Azure**](https://learn.microsoft.com/es-es/training/modules/manage-virtual-machines-with-azure-cli/).

##### Pasos para crear un plan de servicio

Al ejecutar Web Apps, mediante Azure App Service, paga por los recursos de proceso de Azure que la aplicación usa y los costos de los recursos dependen del plan de App Service asociado con Web Apps. Los planes de servicio determinan la región que se usa para el centro de datos de la aplicación, el número de máquinas virtuales que se usan y el plan de tarifa.

1. Cree un plan de App Service para ejecutar la aplicación. En el siguiente comando se especifica el plan de tarifa gratuito, pero puede ejecutar `az appservice plan create --help` para ver los demás planes de tarifa.

	 Nota

	Los nombres de la aplicación y el plan deben ser _únicos_ en todo Azure. Las variables que ha creado anteriormente asignarán valores aleatorios como sufijos para garantizar que sean únicos. Sin embargo, si recibe un error al crear los recursos, debe ejecutar los comandos enumerados anteriormente para restablecer todas las variables con nuevos valores aleatorios.
	
	Si recibe un error sobre el grupo de recursos, ejecute los comandos enumerados anteriormente con un valor de grupo de recursos diferente.

	```Azure CLI
	az appservice plan create --name $AZURE_APP_PLAN --resource-group $RESOURCE_GROUP --location $AZURE_REGION --sku FREE
	```

	Este comando puede tardar varios minutos en completarse.

2. Muestre todos los planes en una tabla para comprobar que el plan de servicio se haya creado correctamente:

	```Azure CLI
	az appservice plan list --output table
	```

	Debería obtener una respuesta similar a la del siguiente ejemplo:

	```Resultados
	Kind    Location    MaximumNumberOfWorkers    Name                NumberOfSites    ResourceGroup                               Status
	------  ----------  ------------------------  ------------------  ---------------  ------------------------------------------  --------
	app     East US     3                         popupappplan-54321  0                Learn-12345678-1234-1234-1234-123456789abc  Ready
	```

##### Creación de una aplicación web

A continuación, cree la aplicación web en su plan de servicio. Puede implementar el código al mismo tiempo, pero, en nuestro ejemplo, crearemos la aplicación web e implementaremos el código por separado.

1. Para crear la aplicación web, proporcione el nombre de la aplicación web y el nombre del plan de App Service que creó antes. Al igual que el nombre del plan de aplicación, el nombre de la aplicación web debe ser único. Las variables que creó antes asignan valores aleatorios que deberían ser suficientes para este ejercicio. Este comando puede tardar unos minutos en completarse.
    
	```Azure CLI
	az webapp create --name $AZURE_WEB_APP --resource-group $RESOURCE_GROUP --plan $AZURE_APP_PLAN
	```

2. Muestre todas las aplicaciones en una tabla para comprobar que la aplicación se haya creado correctamente:

	```Azure CLI
	az webapp list --output table
	```

	Debería obtener una respuesta similar a la del siguiente ejemplo:

	```Azure CLI
	Name               Location    State    ResourceGroup                               DefaultHostName                      AppServicePlan
	-----------------  ----------  -------  ------------------------------------------  -----------------------------------  ------------------
	popupwebapp-12345  East US  Running  Learn-12345678-1234-1234-1234-123456789abc  popupwebapp-12345.azurewebsites.net  popupappplan-54321
	```

	Anote el valor de **DefaultHostName** mostrado en la tabla; esta dirección es la URL para el nuevo sitio web. Azure hará que su sitio web esté disponible con el nombre de aplicación único en el dominio `azurewebsites.net`. Por ejemplo, si el nombre de la aplicación fuera "popupwebapp-12345", la dirección del sitio web sería: `http://popupwebapp-12345.azurewebsites.net`. También puede usar el siguiente script para devolver la dirección HTTP:

	```Bash
	site="http://$AZURE_WEB_APP.azurewebsites.net"
	echo $site
	```

3. Para obtener el código HTML predeterminado de la aplicación de ejemplo, use CURL con el valor de DefaultHostName:

	```Bash
	curl $AZURE_WEB_APP.azurewebsites.net
	```

	Debería obtener una respuesta similar a la del siguiente ejemplo:

	```Resultados
	<!DOCTYPE html><html lang="en"><head><meta charset="utf-8"/><meta name="viewport" content="width=device-width, initial-scale=1.0"/><meta http-equiv="X-UA-Compatible" content="IE=edge"/><title>Microsoft Azure App Service - Welcome</title><link rel="shortcut icon" href="https://appservice.azureedge.net/images/app-service/v4/favicon.ico" type="image/x-icon"/><link href="https://appservice.azureedge.net/css/app-service/v4/bootstrap.min.css" rel="stylesheet" crossorigin="anonymous"/><style>html, body{height: 100%; background-color: #ffffff; color: #000000; font-size: 13px;}*{border-radius: 0 !important;}</style> ... (continued)
	```

##### Implementación de código desde GitHub

1. El último paso es implementar código de un repositorio GitHub en la aplicación web. Se usará una página PHP básica disponible en el repositorio GitHub de ejemplos de Azure que muestra "¡Hola mundo!" cuando se ejecuta. Asegúrese de usar el nombre de la aplicación web que creó. Este comando puede tardar unos minutos en completarse.

	```Azure CLI
	az webapp deployment source config --name $AZURE_WEB_APP --resource-group $RESOURCE_GROUP --repo-url "https://github.com/Azure-Samples/php-docs-hello-world" --branch master --manual-integration
	```

2. Una vez implementada, use un explorador o CURL para llegar de nuevo al sitio:

	```Bash
	curl $AZURE_WEB_APP.azurewebsites.net
	```

	La página muestra "¡Hola mundo!"

	```Resultados
	Hello World!
	```

En este ejercicio se ha mostrado un patrón típico de una sesión interactiva de la CLI de Azure. Primero ha usado un comando estándar para crear un grupo de recursos. Después ha usado un conjunto de comandos para implementar un recurso (en este ejemplo, una aplicación web) en este grupo de recursos. Podría combinar fácilmente este conjunto de comandos en un script de shell y ejecutarlo cada vez que sea necesario crear el mismo recurso.


### Resumen

La CLI de Azure es una buena elección para los menos familiarizados con la línea de comandos y el scripting de Azure. Su sintaxis simple y la compatibilidad multiplataforma ayudan a reducir el riesgo de errores al realizar tareas repetitivas y regulares. En este módulo, usó los comandos de la CLI de Azure para crear un grupo de recursos e implementar una aplicación web mediante un pequeño grupo de comandos. Puede combinar estos comandos en un script de shell como parte de una solución de automatización.

#### Limpieza

El espacio aislado limpia los recursos automáticamente cuando haya terminado con este módulo.

Al trabajar en una suscripción propia, se recomienda identificar al final de un proyecto si aún necesita los recursos creados. Los recursos que dejas en ejecución pueden costar dinero. Puede eliminar los recursos de forma individual o eliminar el grupo de recursos para eliminar todo el conjunto de recursos.

#### Comprobar los conocimientos

1. ¿Qué es necesario instalar en el equipo para poder ejecutar comandos de la CLI de Azure localmente?

<details>
	<summary>Respuesta</summary>
	<p><b>Solo tiene que instalar la CLI de Azure</b>. Se usa un shell para emitir los comandos de la CLI, pero cada plataforma tiene al menos un shell integrado.</p>
</details>

2. Verdadero o falso: La CLI de Azure se puede instalar en Linux, macOS y Windows. Además, los comandos de la CLI son los mismos en todas las plataformas.

<details>
	<summary>Respuesta</summary>
	<p><b>Verdadero</b>La CLI es multiplataforma y se puede instalar en Linux, macOS y Windows. Después de la instalación, los comandos de la CLI que se ejecutan son los mismos en todas las ubicaciones. Esto significa que puede aprender los comandos una vez y usarlos con todas las instalaciones locales o en Azure Cloud Shell.</p>
</details>

3. ¿Qué valor de parámetro se puede agregar a la mayoría de los comandos de la CLI para obtener una salida concisa con formato?

<details>
	<summary>Respuesta</summary>
	<p>El parámetro <b>table</b> aplica formato de tabla a la salida. Esto puede hacer que la salida de los comandos que generan mucha sea mucho más legible.</p>
</details>

## Implementación de la infraestructura de Azure mediante plantillas de ARM de JSON

### Introducción

Las plantillas de Azure Resource Manager (plantillas de ARM) de JSON le **permiten especificar la infraestructura del proyecto de forma declarativa y reutilizable**. Puede realizar el control de versiones y guardar las plantillas en el mismo control de código fuente que el proyecto de desarrollo.

Imagine que administra un equipo de software que desarrolla un sistema de inventario para empresas asociadas. Tiene planeado implementar este producto en Azure y cada empresa asociada tendrá su propia solución. Las distintas directivas para cada implementación se implementarán a través de diferentes cuentas de almacenamiento de Azure. Decida usar la práctica de _infraestructura como código_ mediante el uso de plantillas de ARM. Este enfoque le permite realizar un seguimiento de las distintas versiones y asegurarse de que las implementaciones de infraestructura para cada entorno son coherentes y flexibles.

En este módulo, le presentaremos la estructura de plantillas de ARM. También practicará con la creación e implementación de una plantilla de ARM en Azure.

<div>
	<b style="font-size: 24;">Nota</b>
	<br>
	<br>
	Bicep es un lenguaje para la definición de recursos de Azure. Ofrece una experiencia de creación más sencilla que JSON, junto con otras características que ayudan a mejorar la calidad de la infraestructura como código. Se recomienda que cualquier usuario nuevo en la infraestructura como código en Azure utilice Bicep en lugar de JSON. Para obtener más información sobre Bicep, consulte la ruta de aprendizaje.
	<a href = "https://learn.microsoft.com/es-es/training/paths/fundamentals-bicep/"> Aspectos básicos de Bicep</a>
</div>

#### Objetivos de aprendizaje

En este módulo, aprenderemos a:

- Implementar una plantilla de ARM de JSON mediante Visual Studio Code.
- Declarar recursos y dotar de flexibilidad a la plantilla mediante la adición de parámetros y salidas.

#### Requisitos previos

- Tener conocimientos de Azure, incluidos Azure Portal, las suscripciones, los grupos de recursos y las definiciones de recursos
- Una cuenta de Azure. Puede obtener una cuenta gratuita [aquí](https://azure.microsoft.com/free)
- [Visual Studio Code](https://code.visualstudio.com/) instalado localmente.
- [Herramientas de Azure Resource Manager para la extensión Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=msazurermtools.azurerm-vscode-tools) instaladas localmente
- Tener instaladas localmente una de las siguientes:
    - Las herramientas más recientes de la [CLI de Azure](https://learn.microsoft.com/es-es/cli/azure/install-azure-cli)
    - Las herramientas más recientes de [Azure PowerShell](https://learn.microsoft.com/es-es/powershell/azure/install-az-ps)

### Exploración de la estructura de plantillas de Azure Resource Manager

En esta unidad, aprenderemos a usar las plantillas de Azure Resource Manager (plantillas de ARM) para implementar la infraestructura como código. Examinará las secciones de una plantilla de ARM, aprenderá a implementarla en Azure y profundizará en los detalles de la sección de _recursos_ de la plantilla.

#### ¿Qué es la infraestructura como código?

La _infraestructura como código_ le permite describir, mediante código, la infraestructura que necesita para la aplicación.

Con la infraestructura como código, puede mantener en un repositorio de código central el código de la aplicación y todo lo que necesita para implementarla. Las **ventajas de la infraestructura como código son** las siguientes:

- **Configuraciones coherentes**
- **Escalabilidad mejorada**
- **Implementaciones más rápidas**
- **Mejor rastreabilidad**

#### ¿Qué es una plantilla de ARM?

Las plantillas de ARM son **archivos** de notación de objetos JavaScript (**JSON**) **que definen la infraestructura y la configuración de la implementación**. La plantilla usa una _sintaxis declarativa_. La sintaxis declarativa es una forma de crear la estructura y los elementos que describen el aspecto que tendrán los recursos sin describir el flujo de control. La sintaxis declarativa es diferente de la _sintaxis imperativa_, en la que se usan comandos que el equipo debe ejecutar. El scripting imperativo se centra en especificar cada paso de la implementación de los recursos.

Las plantillas de ARM le permiten declarar lo que piensa implementar sin tener que escribir la secuencia de comandos de programación para crearlo. En una plantilla de ARM, se especifican los recursos y las propiedades de esos recursos. Después, [Azure Resource Manager](https://learn.microsoft.com/es-es/azure/azure-resource-manager/management/overview) usa esa información para implementar los recursos de forma organizada y coherente.

##### Ventajas del uso de plantillas de ARM

Las plantillas de ARM **permiten automatizar las implementaciones** y usar el procedimiento de infraestructura como código (IaC). El código de plantilla se convierte en parte de los proyectos de infraestructura y desarrollo. Como sucede con el código de la aplicación, puede almacenar los archivos IaC en un repositorio de origen y crear una versión de él.

Las plantillas de ARM son _idempotentes_, lo que significa que puede implementar la misma plantilla muchas veces y obtener los mismos tipos de recursos en el mismo estado.

Resource Manager organiza la implementación de los recursos para que se creen en el orden correcto. Siempre que sea posible, los recursos también se crearán en paralelo, por lo que las implementaciones de plantillas de ARM finalizan más rápido que las implementaciones con scripts.

![[Pasted image 20231229135150.png]]

**Resource Manager también tiene validación integrada**. Comprueba la plantilla antes de iniciar la implementación para asegurarse de que la implementación se realizará correctamente.

Si las implementaciones se vuelven más complejas, puede dividir las plantillas de ARM en componentes más pequeños y reutilizables. Puede vincular estas plantillas más pequeñas juntas en el momento de la implementación. También **puede anidar plantillas** dentro de otras.

En Azure Portal, puede revisar el historial de implementación y obtener información sobre el estado de la implementación. El portal muestra los valores para todos los parámetros y salidas.

También puede integrar las plantillas de ARM en herramientas de integración continua e implementación continua (CI/CD), como [Azure Pipelines](https://azure.microsoft.com/services/devops/pipelines), que permite automatizar las canalizaciones de versión para actualizaciones de aplicaciones e infraestructura rápidas y confiables. Mediante Azure DevOps y las tareas de plantilla de ARM, puede compilar e implementar los proyectos de forma continuada.

##### Estructura de los archivos de plantilla de ARM

Al escribir una plantilla de ARM, debe comprender todos los elementos que la componen y lo que hacen. Los archivos de plantilla de ARM se componen de los elementos siguientes:

|Elemento|Descripción|
|---|---|
|**schema**|una sección obligatoria en la que se define la ubicación del archivo de esquema JSON que describe la estructura de los datos JSON. El número de versión que use dependerá del ámbito de la implementación y del editor de JSON.|
|**contentVersion**|una sección obligatoria en la que se define la versión de la plantilla (por ejemplo, 1.0.0.0). Puede usar este valor para documentar los cambios importantes en la plantilla y asegurarse de que implementa la plantilla correcta.|
|**apiProfile**|una sección opcional en la que se define una colección de versiones de API para los tipos de recurso. Puede usar este valor para evitar tener que especificar las versiones de API para cada recurso de la plantilla.|
|**parameters**|una sección opcional en la que se definen los valores que se proporcionan durante la implementación. Estos valores se pueden proporcionar mediante un archivo de parámetros, con parámetros de la línea de comandos o en Azure Portal.|
|**variables**|una sección opcional en la que se definen los valores que se usan para simplificar las expresiones de lenguaje de plantilla.|
|**functions**|una sección opcional en la que se pueden definir [funciones definidas por el usuario](https://learn.microsoft.com/es-es/azure/azure-resource-manager/templates/template-user-defined-functions) que están disponibles dentro de la plantilla. Las funciones definidas por el usuario pueden simplificar la plantilla cuando se usan repetidamente expresiones complicadas en la plantilla.|
|**resources**|una sección obligatoria en la que se definen los elementos reales que quiere implementar o actualizar en un grupo de recursos o una suscripción.|
|**output**|una sección opcional en la que se especifican los valores que se devolverán al final de la implementación.|

#### Implementación de una plantilla de ARM en Azure

Puede implementar una plantilla de ARM en Azure de una de las siguientes maneras:

- Implementación de una plantilla local
- Implementación de una plantilla vinculada
- Implementación en una canalización de implementación continua

Este módulo se centra en la implementación de una plantilla de ARM local. En módulos Learn futuros obtendrá información sobre cómo implementar una infraestructura más complicada y realizar la integración con Azure Pipelines.

Para implementar una plantilla local, es necesario tener [Azure PowerShell](https://learn.microsoft.com/es-es/powershell/azure/install-az-ps) o la [CLI de Azure](https://learn.microsoft.com/es-es/cli/azure/install-azure-cli) instalado localmente.

En primer lugar, inicie sesión en Azure con la CLI de Azure o Azure PowerShell.

```CLI
az login
```

o

```PowerShell
Connect-AzAccount
```

Después, defina el grupo de recursos. Puede usar un grupo de recursos ya definido o crear uno nuevo con el siguiente comando. Puede obtener los valores de ubicación disponibles en: `az account list-locations` (la CLI) o `Get-AzLocation` (PowerShell). Puede configurar la ubicación predeterminada mediante `az configure --defaults location=<location>`.

```CLI
az group create --name {name of your resource group} --location "{location}"
```

o

```PowerShell
New-AzResourceGroup `
  -Name {name of your resource group} `
  -Location "{location}"
```


Para iniciar una implementación de plantilla en el grupo de recursos, use el comando [az deployment group create](https://learn.microsoft.com/es-es/cli/azure/deployment/group#az-deployment-group-create) de la CLI de Azure o el comando [New-AzResourceGroupDeployment](https://learn.microsoft.com/es-es/powershell/module/az.resources/new-azresourcegroupdeployment) de Azure PowerShell.

 **Sugerencia**

La diferencia entre `az deployment group create` y `az group deployment create` es que `az group deployment create` es un comando antiguo que va a quedar en desuso y se reemplazará por `az deployment group create`. Por lo tanto, se recomienda usar `az deployment group create` para implementar recursos en el ámbito del grupo de recursos.


Ambos comandos requieren el grupo de recursos, la región y el nombre de la implementación para que pueda identificarla fácilmente en el historial de implementación. Para mayor comodidad, los ejercicios crean una variable que almacena la ruta de acceso al archivo de plantilla. Esta variable facilita la ejecución de los comandos de implementación, ya que no es necesario volver a escribir la ruta de acceso cada vez que se implementa. Este es un ejemplo:

```CLI
templateFile="{provide-the-path-to-the-template-file}"
az deployment group create --name blanktemplate --resource-group myResourceGroup --template-file $templateFile
```

o

```PowerShell
$templateFile = "{provide-the-path-to-the-template-file}"
New-AzResourceGroupDeployment `
  -Name blanktemplate `
  -ResourceGroupName myResourceGroup `
  -TemplateFile $templateFile
```

Las plantillas vinculadas se usan para implementar soluciones complejas. Puede dividir una plantilla en muchas e implementarlas a través de una plantilla principal. Cuando se implementa la plantilla principal, se desencadena la implementación de la plantilla vinculada. Puede almacenar y proteger la plantilla vinculada mediante un token de SAS.

Una canalización de CI/CD automatiza la creación e implementación de proyectos de desarrollo, lo que incluye proyectos de plantilla de ARM. Las dos canalizaciones más comunes que se usan para la implementación de plantillas son [Azure Pipelines](https://learn.microsoft.com/es-es/training/paths/deploy-applications-with-azure-devops/) y [Acciones de GitHub](https://learn.microsoft.com/es-es/training/paths/automate-workflow-github-actions/).

En otros módulos se describe más información sobre estos dos tipos de implementación.

#### Adición de recursos a la plantilla

Para agregar un recurso a la plantilla, tiene que conocer el proveedor de recursos y sus tipos de recursos. La sintaxis de esta combinación tiene el formato _{proveedor_de_recursos}/{tipo_de_recurso}_. Por ejemplo, para agregar un recurso de cuenta de almacenamiento a la plantilla, necesitará el proveedor de recursos _Microsoft.Storage_. Uno de los tipos de este proveedor es _storageAccount_. Por tanto, el tipo de recurso se mostrará como _Microsoft.Storage/storageAccounts_. Puede usar una lista de [proveedores de recursos para servicios de Azure](https://learn.microsoft.com/es-es/azure/azure-resource-manager/management/azure-services-resource-providers) para encontrar los proveedores que necesita.

Después de definir el proveedor y el tipo de recurso, debe comprender las propiedades de cada tipo de recurso que desee usar. Par obtener más información, consulte [Definición de recursos en plantillas de Azure Resource Manager](https://learn.microsoft.com/es-es/azure/templates). Vea la lista de la columna izquierda para buscar el recurso. Observe que las propiedades se ordenan por versión de API.

![[Pasted image 20231229152929.png]]

Este es un ejemplo de algunas de las propiedades enumeradas en la página Cuentas de almacenamiento:

![[Pasted image 20231229152941.png]]

Para este ejemplo de almacenamiento, la plantilla podría tener el aspecto siguiente:

```JSON
{
  "$schema": "https://schema.management.azure.com/schemas/2019-04-01/deploymentTemplate.json#",
  "contentVersion": "1.0.0.1",
  "apiProfile": "",
  "parameters": {},
  "variables": {},
  "functions": [],
  "resources": [
    {
      "type": "Microsoft.Storage/storageAccounts",
      "apiVersion": "2019-06-01",
      "name": "learntemplatestorage123",
      "location": "westus",
      "sku": {
        "name": "Standard_LRS"
      },
      "kind": "StorageV2",
      "properties": {
        "supportsHttpsTrafficOnly": true
      }
    }
  ],
  "outputs": {}
}
```


### Ejercicio: Creación e implementación de una plantilla de Azure Resource Manager

En este ejercicio, creará una plantilla de Azure Resource Manager (plantilla de ARM), la implementará en Azure y, a continuación, actualizará esa plantilla de ARM para agregar parámetros y salidas.

En este ejercicio se utilizan las [Herramientas de Azure Resource Manager para Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=msazurermtools.azurerm-vscode-tools). Asegúrese de instalar esta extensión en Visual Studio Code antes de iniciar el ejercicio.

#### Creación de una plantilla de ARM

1. Abra Visual Studio Code y cree un archivo denominado _azuredeploy.json_.
    
2. La extensión de plantilla de ARM de Visual Studio Code viene configurada con fragmentos de código que le ayudarán a desarrollar plantillas. Para empezar, agregará una plantilla en blanco. En la primera línea del archivo, escriba _arm_.
    
3. Visual Studio Code muestra automáticamente varias opciones posibles que comienzan por **arm!**. Seleccione la **plantilla de Azure Resource Manager (ARM)**. Visual Studio Code procesa automáticamente los esquemas y lenguajes de la plantilla.
	
	![[Pasted image 20231229153635.png]]
	
	El archivo ahora tiene este aspecto:
	
	```JSON
	{
	  "$schema": "https://schema.management.azure.com/schemas/2019-04-01/deploymentTemplate.json#",
	  "contentVersion": "1.0.0.0",
	  "parameters": {},
	  "functions": [],
	  "variables": {},
	  "resources": [],
	  "outputs": {}
	}
	```
	
	Observe que este archivo tiene todas las secciones de una plantilla de ARM que se describen en la unidad anterior.

4. Presione Ctrl+S para guardar los cambios en el archivo.

#### Implementación de la plantilla de ARM en Azure

##### Azure CLI

Para implementar esta plantilla en Azure, debe iniciar sesión en la cuenta de Azure desde el terminal de Visual Studio Code. Asegúrese de que tiene instaladas las herramientas de la [CLI de Azure](https://learn.microsoft.com/es-es/cli/azure/install-azure-cli) y de que inicia sesión con la misma cuenta que utilizó para activar el espacio aislado.

1. Seleccione **Terminal > Nuevo terminal** para abrir una ventana de terminal.
    
2. Si la barra de comandos de la ventana de terminal indica **bash**, tiene el shell correcto desde el que trabajar y puede ir a la sección siguiente.
    
3. De lo contrario, seleccione la lista desplegable y elija **Select Default Profile** (Seleccionar el perfil predeterminado).

	![[Pasted image 20231229155242.png]]

4. Seleccione **Git Bash**.

	![[Pasted image 20231229155308.png]]

5. Seleccione **Terminal > Nuevo terminal** para abrir una ventana de terminal del shell de Bash.

###### Inicio de sesión en Azure

1. En la ventana de terminal, ejecute este comando para iniciar sesión en Azure.

	```CLI
	az login
	```

2. Se abre un explorador para que pueda iniciar sesión en su cuenta. Después de iniciar sesión, se muestra en el terminal una lista de las suscripciones asociadas a esta cuenta. Si ha activado el espacio aislado, debería ver una denominada _Suscripción de Concierge_. Úsela para el resto del ejercicio.
    
3. En el shell de Bash, ejecute el siguiente comando para establecer la suscripción predeterminada para todos los comandos de la CLI de Azure que se ejecuten en esta sesión.

	```CLI
	az account set --subscription "Concierge Subscription"
	```

	Si ha usado más de un espacio aislado recientemente, es posible que aparezca más de una _Suscripción de Concierge_. Si es así, use los dos pasos siguientes para identificar y establecer la suscripción predeterminada.
	
	a. Ejecute el siguiente comando para obtener los id. de _Suscripción de Concierge_.

	```CLI
	az account list --refresh --query "[?contains(name, 'Concierge Subscription')].id" --output table
	```
	
	b. Establezca la suscripción predeterminada mediante la ejecución del siguiente comando y reemplace _{your subscription ID}_ por el id. de Suscripción de Concierge más reciente.

	```CLI
	az account set --subscription {your subscription ID}
	```

###### Establecimiento del grupo de recursos predeterminado

Al establecer el grupo de recursos que se creó al activar el espacio aislado como grupo de recursos predeterminado, puede omitir ese parámetro de los comandos de la CLI de Azure en este ejercicio. Para establecer el grupo de recursos, ejecute el siguiente comando.

```CLI
az configure --defaults group=[sandbox resource group name]
```

###### Implementación de la plantilla en Azure

Ejecute los comandos siguientes para implementar la plantilla de ARM en Azure. La plantilla de ARM todavía no tiene ningún recurso, por lo que no verá ningún recurso creado. Debería obtener una implementación correcta.

```CLI
templateFile="azuredeploy.json"
today=$(date +"%d-%b-%Y")
DeploymentName="blanktemplate-"$today

az deployment group create --name $DeploymentName --template-file $templateFile
```

En la sección superior del código anterior establece las variables de la CLI de Azure, que incluyen la ruta de acceso al archivo de la plantilla que se va a implementar, así como el nombre de la implementación. La sección inferior, `az deployment group create`, implementa la plantilla en Azure. Observe que el nombre de la implementación es `blanktemplate` con la fecha como sufijo.

Debería ver `Running...` en el terminal.

Cuando haya implementado la plantilla de ARM en Azure, vaya a [Azure Portal](https://portal.azure.com/) y asegúrese de que se encuentra en la suscripción de espacio aislado. Para ello, seleccione el avatar en la esquina superior derecha de la página. Seleccione **Cambiar directorio**. En la lista, seleccione el directorio **Espacio aislado de Microsoft Learn**.

1. En el menú de recursos, seleccione **Grupos de recursos**.
    
2. Seleccione el grupo de recursos _[nombre del grupo de recursos del espacio aislado]_.
    
3. En el panel **Información general**, verá la implementación realizada correctamente.

	![[Pasted image 20231229160623.png]]

4. Seleccione **1 correcta** para ver los detalles de la implementación.

	![[Pasted image 20231229160729.png]]


5. Seleccione `blanktemplate` para ver qué recursos se han implementado. En este caso, estará vacío porque todavía no ha especificado ningún recurso en la plantilla.

6. Deje la página abierta en el explorador. Tendrá que volver a comprobar las implementaciones.

###### Adición de un recurso a la plantilla de ARM

En la tarea anterior, ha aprendido a crear una plantilla en blanco y a implementarla. Ahora está listo para implementar un recurso real. En esta tarea, agregará un recurso de cuenta de Azure Storage a la plantilla de ARM mediante un fragmento de código de la extensión Herramientas de Azure Resource Manager para Visual Studio Code.

1. En el archivo _azuredeploy.json_ de Visual Studio Code, coloque el cursor entre los corchetes del bloque de recursos `"resources":[],`.
    
2. Escriba _storage_ dentro de los corchetes. Aparece una lista de fragmentos de código relacionados. Seleccione **arm-storage**.

	![[Pasted image 20231229161036.png]]
	El archivo tendrá este aspecto:

	```JSON
	{
	  "$schema": "https://schema.management.azure.com/schemas/2019-04-01/deploymentTemplate.json#",
	  "contentVersion": "1.0.0.0",
	  "parameters": {},
	  "functions": [],
	  "variables": {},
	  "resources": [
	    {
	      "name": "storageaccount1",
	      "type": "Microsoft.Storage/storageAccounts",
	      "apiVersion": "2019-06-01",
	      "tags": {
	        "displayName": "storageaccount1"
	      },
	      "location": "[resourceGroup().location]",
	      "kind": "StorageV2",
	      "sku": {
	        "name": "Premium_LRS",
	        "tier": "Premium"
	      }
	    }
	  ],
	  "outputs": {}
	}
	```

	Los valores que se deben editar se resaltan en la nueva sección del archivo y se puede navegar por ellos mediante la tecla Tabulador.

	Observe que los atributos `tags` y `location` están rellenados. El atributo `location` usa una función para establecer la ubicación del recurso en la del grupo de recursos. Obtendrá información sobre etiquetas y funciones en el módulo siguiente.

3. Cambie los valores _name_ y _displayName_ del recurso por algo único (por ejemplo, **learnexercise12321**). Este nombre debe ser único en todo Azure, por lo que debe elegir algo que sea único para usted.

4. Cambie el valor _name_ de sku de **Premium_LRS** a **Standard_LRS**. Cambie el valor de _tier_ a **Estándar**. Observe que Visual Studio Code proporciona las opciones adecuadas para los valores de atributo en IntelliSense. Elimine el valor predeterminado, incluidas las comillas, y escriba las comillas para ver este trabajo.

	![[Pasted image 20231229161212.png]]

5. La ubicación del recurso se establece en la del grupo de recursos donde se implementará. Mantenga este valor predeterminado.
    
6. Guarde el archivo.

###### Comprobación de la implementación

1. Cuando finalice la implementación, vuelva al Azure Portal en el explorador. Vaya al grupo de recursos y comprobará que ahora hay **2 implementaciones correctas**. Seleccione este vínculo.
    
    Observe que las dos implementaciones están en la lista.

	![[Pasted image 20231229161355.png]]

2. Seleccione **addstorage**.

	![[Pasted image 20231229161409.png]]
Observe que la cuenta de almacenamiento se ha implementado.
##### Azure PowerShell

Para implementar esta plantilla en Azure, debe iniciar sesión en la cuenta de Azure desde el terminal de Visual Studio Code. Asegúrese de haber instalado Azure PowerShell Tools desde las extensiones de Visual Studio Code e inicie sesión en la misma cuenta con la que ha activado el espacio aislado.

1. En la barra de comandos, seleccione **Terminal > Nuevo terminal** para abrir una ventana de PowerShell.
    
2. Si la barra de comandos de la ventana de terminal muestra **PowerShell**, tiene el shell correcto desde el que trabajar y puede ir a la sección siguiente.

	![[Pasted image 20231229164419.png]]

	a. Si no es así, seleccione la flecha abajo y, en la lista desplegable, PowerShell. Si esa opción no aparece, seleccione **Select Default Profile** (Seleccionar el perfil predeterminado).
    
    b.En el campo de entrada, desplácese hacia abajo y seleccione **PowerShell**.

	![[Pasted image 20231229164506.png]]

	c. Seleccione **Terminal > Nuevo terminal** para abrir una ventana de terminal de PowerShell.

###### Inicio de sesión en Azure mediante Azure PowerShell

1. Desde el terminal de Visual Studio Code, ejecute el comando siguiente para iniciar sesión en Azure. Se abre un explorador para que pueda iniciar sesión en su cuenta.

	```PowerShell
	Connect-AzAccount
	```
	
	 Sugerencia
	
	El [módulo Az de PowerShell](https://learn.microsoft.com/es-es/powershell/azure/new-azureps-module-az) reemplaza a AzureRM y es la versión recomendada que se debe usar para interactuar con Azure.


2. Inicie sesión con la cuenta que ha usado para activar el espacio aislado. Después de iniciar sesión, Visual Studio Code enumera las suscripciones asociadas a su cuenta en la ventana de terminal. Si ha activado el espacio aislado, verá un bloque de código que contiene `"name": "Concierge Subscription"`. Esta es la suscripción que se usará para el resto del ejercicio.

###### Establecimiento de la suscripción predeterminada para todos los comandos de PowerShell de esta sesión

1. Ejecute el siguiente comando para obtener las suscripciones y sus id. El identificador de la suscripción es la segunda columna. Busque _Suscripción de Concierge_ y copie el valor de la segunda columna. Es similar a _cf49fbbc-217c-4eb6-9eb5-a6a6c68295a0_:

	```PowerShell
	Get-AzSubscription
	```

2. Ejecute el siguiente comando y reemplace _{Your subscription ID}_ por el id. que ha copiado en el paso anterior para cambiar la suscripción activa por la Suscripción de Concierge.

	```PowerShell
	$context = Get-AzSubscription -SubscriptionId {Your subscription ID}
	Set-AzContext $context
	```

3. Ejecute el siguiente comando para permitir que el grupo de recursos predeterminado sea el grupo de recursos que se ha creado automáticamente en el entorno del espacio aislado. Esta acción le permite omitir ese parámetro del resto de los comandos de Azure PowerShell en este ejercicio.

```PowerShell
Set-AzDefault -ResourceGroupName [sandbox resource group name]
```

###### Implementación de la plantilla en Azure

Implemente la plantilla en Azure mediante la ejecución de los comandos siguientes. La plantilla de ARM todavía no tiene ningún recurso, por lo que no verá recursos creados.

```PowerShell
$templateFile="azuredeploy.json"
$today=Get-Date -Format "MM-dd-yyyy"
$deploymentName="blanktemplate-"+"$today"
New-AzResourceGroupDeployment `
  -Name $deploymentName `
  -TemplateFile $templateFile
```

La sección superior del código anterior establece las variables de Azure PowerShell, que incluyen la ruta de acceso al archivo de la implementación y el nombre de la implementación. Posteriormente, el comando `New-AzResourceGroupDeployment` implementa la plantilla en Azure. Observe que el nombre de la implementación es `blanktemplate` con la fecha como sufijo.

Cuando haya implementado la plantilla de ARM en Azure, vaya a [Azure Portal](https://portal.azure.com/) y asegúrese de que se encuentra en la suscripción de espacio aislado. Para ello, seleccione el avatar en la esquina superior derecha de la página. Seleccione **Cambiar directorio**. En la lista, seleccione el directorio **Espacio aislado de Microsoft Learn**.

1. En el menú de recursos, seleccione **Grupos de recursos**.
    
2. Seleccione el grupo de recursos _[nombre del grupo de recursos del espacio aislado]_.
    
3. En el panel **Información general**, verá la implementación realizada correctamente.

	![[Pasted image 20231229165657.png]]

4. Seleccione **1 correcta** para ver los detalles de la implementación.

	![[Pasted image 20231229165721.png]]

5. Seleccione `blanktemplate` para ver qué recursos se han implementado. En este caso, estará vacío porque todavía no ha especificado ningún recurso en la plantilla.

	![[Pasted image 20231229165747.png]]

6. Deje la página abierta en el explorador. Tendrá que volver a comprobar las implementaciones.

###### Adición de un recurso a la plantilla de ARM

En la tarea anterior, ha aprendido a crear una plantilla en blanco y a implementarla. Ahora está listo para implementar un recurso real. En esta tarea, agregará un recurso de cuenta de Azure Storage a la plantilla de ARM mediante un fragmento de código de la extensión Herramientas de Azure Resource Manager para Visual Studio Code.

1. En el archivo _azuredeploy.json_ de Visual Studio Code, coloque el cursor entre los corchetes del bloque de recursos `"resources":[],`.
    
2. Escriba _storage_ dentro de los corchetes. Aparece una lista de fragmentos de código relacionados. Seleccione **arm-storage**.

	![[Pasted image 20231229165953.png]]
	El archivo tendrá este aspecto:
	
	```JSON
	{
	  "$schema": "https://schema.management.azure.com/schemas/2019-04-01/deploymentTemplate.json#",
	  "contentVersion": "1.0.0.0",
	  "parameters": {},
	  "functions": [],
	  "variables": {},
	  "resources": [
	    {
	      "name": "storageaccount1",
	      "type": "Microsoft.Storage/storageAccounts",
	      "apiVersion": "2019-06-01",
	      "tags": {
	        "displayName": "storageaccount1"
	      },
	      "location": "[resourceGroup().location]",
	      "kind": "StorageV2",
	      "sku": {
	        "name": "Premium_LRS",
	        "tier": "Premium"
	      }
	    }
	  ],
	  "outputs": {}
	}
	```

	Los valores que se deben editar se resaltan en la nueva sección del archivo y se puede navegar por ellos mediante la tecla Tabulador.
	
	Observe que los atributos `tags` y `location` están rellenados. El atributo `location` usa una función para establecer la ubicación del recurso en la del grupo de recursos. Obtendrá información sobre etiquetas y funciones en el módulo siguiente.

3. Cambie los valores _name_ y _displayName_ del recurso por algo único (por ejemplo, **learnexercise12321**). Este nombre debe ser único en todo Azure, por lo que debe elegir algo que sea único para usted.
    
4. Cambie el valor _name_ de sku de **Premium_LRS** a **Standard_LRS**. Cambie el valor de _tier_ a **Estándar**. Observe que Visual Studio Code proporciona las opciones adecuadas para los valores de atributo en IntelliSense. Elimine el valor predeterminado, incluidas las comillas, y escriba las comillas para ver este trabajo.

	![[Pasted image 20231229170151.png]]


5. La ubicación del recurso se establece en la del grupo de recursos donde se implementará. Mantenga este valor predeterminado.
    
6. Guarde el archivo.


###### Implementación de la plantilla de ARM actualizada

Aquí, cambiará el nombre de la implementación para que refleje mejor lo que hace.

Ejecute el siguiente comando de Azure PowerShell en el terminal. Este fragmento de código es el mismo código que ha usado antes, pero se ha cambiado el nombre de la implementación.

```PowerShell
$templateFile="azuredeploy.json"
$today=Get-Date -Format "MM-dd-yyyy"
$deploymentName="addstorage-"+"$today"
New-AzResourceGroupDeployment `
  -Name $deploymentName `
  -TemplateFile $templateFile
```

###### Comprobación de la implementación

1. Cuando finalice la implementación, vuelva al Azure Portal en el explorador. Vaya al grupo de recursos y comprobará que ahora hay **2 implementaciones correctas**. Seleccione este vínculo.
    
    Observe que las dos implementaciones están en la lista.

	![[Pasted image 20231229170341.png]]

2. Seleccione **addstorage**.

	![[Pasted image 20231229170404.png]]

Observe que la cuenta de almacenamiento se ha implementado.

### Adición de flexibilidad a la plantilla de Azure Resource Manager mediante parámetros y salidas

En la unidad anterior, creamos una plantilla de Azure Resource Manager (ARM) y le agregamos una cuenta de Azure Storage. Es posible que haya detectado que hay un problema en la plantilla. El nombre de la cuenta de almacenamiento está codificado de forma rígida. Esta plantilla solo se puede usar para implementar la misma cuenta de almacenamiento cada vez. Para implementar una cuenta de almacenamiento con otro nombre, tendría que crear una plantilla, lo que no es una forma práctica de automatizar las implementaciones. La SKU de la cuenta de almacenamiento también está codificada de forma rígida, lo que significa que no se puede modificar el tipo de cuenta de almacenamiento para otros entornos. Recuerde que en este escenario, cada implementación puede tener un tipo diferente de cuenta de almacenamiento. Puede hacer que la plantilla sea más reutilizable si agrega un parámetro para la SKU de la cuenta de almacenamiento.

En esta unidad, encontrará información sobre las secciones _parameters_ y _outputs_ de la plantilla.

#### Parámetros de la plantilla de ARM

Los parámetros de la plantilla de ARM le permiten personalizar la implementación, ya que proporcionan valores específicos para un entorno concreto. Por ejemplo, puede pasar valores diferentes en función de si realiza la implementación en un entorno para desarrollo, prueba, producción u otros. Por ejemplo, en la plantilla anterior se usa la SKU de cuenta de almacenamiento _Standard_LRS_. Puede volver a usar esta plantilla para otras implementaciones que crean una cuenta de almacenamiento si convierte en un parámetro el nombre de la SKU de la cuenta de almacenamiento. Después, pase el nombre de la SKU que quiere para esta implementación concreta cuando se implemente la plantilla. Puede llevar a cabo este paso en la línea de comandos o mediante un archivo de parámetros.

En la sección `parameters` de la plantilla, especifique los valores que se pueden especificar al implementar los recursos. Está limitado a 256 parámetros por plantilla. Las definiciones de parámetros pueden utilizar la mayoría de las funciones de plantilla.

Las propiedades disponibles para un parámetro son las siguientes:

```JSON
"parameters": {
  "<parameter-name>": {
    "type": "<type-of-parameter-value>",
    "defaultValue": "<default-value-of-parameter>",
    "allowedValues": [
      "<array-of-allowed-values>"
    ],
    "minValue": <minimum-value-for-int>,
    "maxValue": <maximum-value-for-int>,
    "minLength": <minimum-length-for-string-or-array>,
    "maxLength": <maximum-length-for-string-or-array-parameters>,
    "metadata": {
      "description": "<description-of-the-parameter>"
    }
  }
}
```

Los tipos permitidos de parámetros son los siguientes:

- string
- secureString
- integers
- boolean
- object
- secureObject
- array

##### Recomendaciones para el uso de parámetros

Use los parámetros para las configuraciones que varían según el entorno, como, por ejemplo, la SKU, el tamaño o la capacidad. Use los parámetros también para los nombres de recursos que desee especificar para facilitar la identificación o para cumplir las convenciones de nomenclatura internas. Proporcione una descripción para cada parámetro y use valores predeterminados siempre que sea posible.

Por motivos de seguridad, en las plantillas nunca codifique de forma rígida los nombres de usuario o las contraseñas, ni les proporcione valores predeterminados. Use siempre parámetros para los nombres de usuario y las contraseñas (o los secretos). Use _secureString_ para todas las contraseñas y los secretos. Si pasa datos confidenciales en un objeto JSON, use el tipo _secureObject_. Los parámetros de plantilla con los tipos _secureString_ o _secureObject_ no se pueden leer ni recolectar después de la implementación del recurso.

##### Uso de parámetros en una plantilla de ARM

En la sección parameters de la plantilla de ARM, especifique los parámetros que se pueden especificar al implementar los recursos. Está limitado a 256 parámetros en una plantilla.

Este es un ejemplo de un archivo de plantilla con un parámetro para la SKU de la cuenta de almacenamiento definida en la sección `parameters` de la plantilla. Puede proporcionar un valor predeterminado para el parámetro que se usará si no se especifica ningún valor durante la ejecución.

```JSON
"parameters": {
  "storageAccountType": {
    "type": "string",
    "defaultValue": "Standard_LRS",
    "allowedValues": [
      "Standard_LRS",
      "Standard_GRS",
      "Standard_ZRS",
      "Premium_LRS"
    ],
    "metadata": {
      "description": "Storage Account type"
    }
  }
}
```

Después, use el parámetro en la definición del recurso. La sintaxis es `[parameters('name of the parameter')]`. Usará la función `parameters`. Obtendrá más información sobre las funciones en el módulo siguiente.

```JSON
"resources": [
  {
    "type": "Microsoft.Storage/storageAccounts",
    "apiVersion": "2019-04-01",
    "name": "learntemplatestorage123",
    "location": "[resourceGroup().location]",
    "sku": {
      "name": "[parameters('storageAccountType')]"
    },
    "kind": "StorageV2",
    "properties": {
      "supportsHttpsTrafficOnly": true
    }
  }
]
```

Al implementar la plantilla, puede proporcionar un valor para el parámetro. Observe la última línea del comando siguiente:


```CLI
templateFile="azuredeploy.json"
az deployment group create --name testdeployment1 --template-file $templateFile --parameters storageAccountType=Standard_LRS
```

o

```PowerShell
$templateFile="azuredeploy.json"
New-AzResourceGroupDeployment `
  -Name testdeployment1 `
  -TemplateFile $templateFile `
  -storageAccountType Standard_LRS
```

#### Salidas de plantilla de ARM

En la sección outputs de la plantilla de ARM, puede especificar los valores que se devolverán después de una implementación correcta. Estos son los elementos que componen la sección de salidas.

```JSON
"outputs": {
  "<output-name>": {
    "condition": "<boolean-value-whether-to-output-value>",
    "type": "<type-of-output-value>",
    "value": "<output-value-expression>",
    "copy": {
      "count": <number-of-iterations>,
      "input": <values-for-the-variable>
    }
  }
}
```

|Elemento|Descripción|
|---|---|
|**nombre de salida**|Debe ser un identificador válido de JavaScript.|
|**condition**|(opcional) Un valor booleano que indica si se devuelve este valor de salida. Si es true, el valor se incluye en la salida de la implementación. Si es false, el valor de salida se omite para esta implementación. Si no se especifica, el valor predeterminado es true.|
|**type**|el tipo del valor de salida.|
|**value**|(opcional) Una expresión de lenguaje de plantilla que se evalúa y se devuelve como valor de salida.|
|**copy**|(opcional) Se usa para devolver más de un valor para una salida.|

##### Uso de salidas en una plantilla de ARM

Este es un ejemplo para generar los puntos de conexión de la cuenta de almacenamiento:

```JSON
"outputs": {
  "storageEndpoint": {
    "type": "object",
    "value": "[reference('learntemplatestorage123').primaryEndpoints]"
  }
}
```

Observe el elemento `reference` de la expresión. Esta función obtiene el estado de tiempo de ejecución de la cuenta de almacenamiento.

#### Implementación de una plantilla de ARM de nuevo

Recuerde que las plantillas de ARM son _idempotentes_, lo cual significa que puede volver a implementar la plantilla en el mismo entorno y, si no se ha cambiado nada en ella, tampoco se cambiará nada en el entorno. Si se ha producido un cambio en la plantilla (por ejemplo, si ha cambiado el valor de un parámetro), solo se implementará ese cambio. La plantilla puede contener todos los recursos que necesita para la solución de Azure y puede volver a ejecutar una plantilla de forma segura. Los recursos solo se crearán si no existían ya, y solo se actualizarán si se produce un cambio.

### Ejercicio: Adición de parámetros y salidas a la plantilla de Azure Resource Manager

En este ejercicio, agregará un parámetro para definir el nombre de la cuenta de almacenamiento de Azure durante la implementación. Después, agregará un parámetro para definir qué SKU de cuenta de almacenamiento se permiten y definir cuál se va a usar para esta implementación. También agregará utilidad a la plantilla de Azure Resource Manager (plantilla de ARM) mediante la adición de una salida que se puede usar más adelante en el proceso de implementación.

#### Creación de parámetros para la plantilla de ARM

Aquí, puede hacer que la plantilla de ARM sea más flexible si agrega parámetros que se pueden establecer en tiempo de ejecución. Cree un parámetro para el valor `storageName`.

1. En el archivo _azuredeploy.json_ de Visual Studio Code, coloque el cursor entre las llaves del atributo _parameters_. Su aspecto es similar a este: `"parameters":{},`
    
2. Seleccione Entrar y luego **par**. Verá una lista de fragmentos de código relacionados. Elija **new-parameter**, que agrega un parámetro genérico a la plantilla. Tiene este aspecto:

	```JSON
	"parameters": {
	    "parameter1": {
	    "type": "string",
	    "metadata": {
	        "description": "description"
	    }
	  }
	},
	```

3. Cambie el parámetro de **parameter1** a **storageName** y deje el tipo como una cadena. Agregue un valor **minLength** de **3** y un valor **maxLength** de **24**. Agregue un valor de descripción de **Nombre del recurso de almacenamiento de Azure**.
    
4. El bloque de parámetros debería tener este aspecto:

```JSON
"parameters": {
  "storageName": {
    "type": "string",
    "minLength": 3,
    "maxLength": 24,
    "metadata": {
      "description": "The name of the Azure storage resource"
    }
  }
},
```

5. Use el nuevo parámetro del bloque `resources` en los valores `name` y `displayName`. El archivo completo tendrá este aspecto:

```JSON
{
  "$schema": "https://schema.management.azure.com/schemas/2019-04-01/deploymentTemplate.json#",
  "contentVersion": "1.0.0.0",
  "parameters": {
    "storageName": {
      "type": "string",
      "minLength": 3,
      "maxLength": 24,
      "metadata": {
        "description": "The name of the Azure storage resource"
      }
    }
  },
  "functions": [],
  "variables": {},
  "resources": [
    {
      "name": "[parameters('storageName')]",
      "type": "Microsoft.Storage/storageAccounts",
      "apiVersion": "2019-06-01",
      "tags": {
        "displayName": "[parameters('storageName')]"
      },
      "location": "[resourceGroup().location]",
      "kind": "StorageV2",
      "sku": {
        "name": "Standard_LRS",
        "tier": "Standard"
      }
    }
  ],
  "outputs": {}
}
```

6. Guarde el archivo

##### Implementación de la plantilla de ARM con parámetros

Aquí, cambiará el nombre de la implementación para que refleje mejor lo que hace y rellenará un valor para el nuevo parámetro.

Ejecute el siguiente comando de Azure PowerShell o Azure CLI en el terminal. Este fragmento de código es el mismo código que ha usado antes, pero se ha cambiado el nombre de la implementación. Rellene un nombre único para el parámetro `storageName`. Recuerde que este nombre debe ser único en todo Azure. Puede usar el nombre único que ha creado en la última unidad. En ese caso, Azure actualizará el recurso en lugar de crear uno.


```PowerShell
$templateFile="azuredeploy.json"
$today=Get-Date -Format "MM-dd-yyyy"
$deploymentName="addnameparameter-"+"$today"
New-AzResourceGroupDeployment `
  -Name $deploymentName `
  -TemplateFile $templateFile `
  -storageName {your-unique-name}
```

o

```CLI
templateFile="azuredeploy.json"
today=$(date +"%d-%b-%Y")
DeploymentName="addnameparameter-"$today

az deployment group create --name $DeploymentName --template-file $templateFile --parameters storageName={your-unique-name}
```

##### Comprobación de la implementación

1. Cuando finalice la implementación, vuelva al Azure Portal en el explorador. Vaya al grupo de recursos y compruebe que ahora hay **3 implementaciones correctas**. Seleccione este vínculo.
    
    Observe que las tres implementaciones están en la lista.
    
2. Explore la implementación _addnameparameter_ como ha hecho antes.
    

##### Adición de otro parámetro para limitar los valores permitidos

Aquí se usan parámetros para limitar los valores permitidos para un parámetro.

1. Coloque el cursor después de la llave de cierre del parámetro `storageName`. Agregue una coma y seleccione Entrar.
    
2. De nuevo, escriba **par** y seleccione **new-parameter**.
    
3. Cambie el nuevo parámetro genérico por lo siguiente:

	```JSON
	"storageSKU": {
	   "type": "string",
	   "defaultValue": "Standard_LRS",
	   "allowedValues": [
	     "Standard_LRS",
	     "Standard_GRS",
	     "Standard_RAGRS",
	     "Standard_ZRS",
	     "Premium_LRS",
	     "Premium_ZRS",
	     "Standard_GZRS",
	     "Standard_RAGZRS"
	   ]
	 }
	```

	Aquí se muestran los valores que este parámetro permitirá. Si la plantilla se ejecuta con un valor no permitido, se producirá un error en la implementación.
    
4. Agregue un comentario a este parámetro.

	![[Pasted image 20231229175759.png]]

	Las plantillas de ARM admiten comentarios `//` y `/* */`.

5. Actualice **resources** para usar el parámetro `storageSKU`. Aproveche las ventajas de IntelliSense en Visual Studio Code para facilitar esta tarea.

	```JSON
	"sku": {
	     "name": "[parameters('storageSKU')]"
	   }
	```
	
	El archivo completo tendrá este aspecto:
	
	```JSON
	{
	  "$schema": "https://schema.management.azure.com/schemas/2019-04-01/deploymentTemplate.json#",
	  "contentVersion": "1.0.0.0",
	  "parameters": {
	    "storageName": {
	      "type": "string",
	      "minLength": 3,
	      "maxLength": 24,
	      "metadata": {
	        "description": "The name of the Azure storage resource"
	      }
	    },
	    "storageSKU": {
	      "type": "string",
	      "defaultValue": "Standard_LRS",
	      "allowedValues": [
	        "Standard_LRS",
	        "Standard_GRS",
	        "Standard_RAGRS",
	        "Standard_ZRS",
	        "Premium_LRS",
	        "Premium_ZRS",
	        "Standard_GZRS",
	        "Standard_RAGZRS"
	      ]
	    }
	  },
	  "functions": [],
	  "variables": {},
	  "resources": [
	    {
	      "name": "[parameters('storageName')]",
	      "type": "Microsoft.Storage/storageAccounts",
	      "apiVersion": "2019-06-01",
	      "tags": {
	        "displayName": "[parameters('storageName')]"
	      },
	      "location": "[resourceGroup().location]",
	      "kind": "StorageV2",
	      "sku": {
	        "name": "[parameters('storageSKU')]",
	        "tier": "Standard"
	      }
	    }
	  ],
	  "outputs": {}
	}
	```

6. Guarde el archivo.

##### Implementación de la plantilla de ARM

Aquí, se implementará correctamente mediante el uso de un parámetro `storageSKU` que se encuentra en la lista de permitidos. Después, intentará implementar la plantilla mediante un parámetro `storageSKU` que no esté en la lista de permitidos. Se producirá un error en la segunda implementación, como es de esperar.

1. Ejecute los comandos siguientes para implementar la plantilla. Rellene un nombre único para el parámetro `storageName`. Recuerde que este nombre debe ser único en todo Azure. Puede usar el nombre único que ha creado en la última sección. En ese caso, Azure actualizará el recurso en lugar de crear uno.

	```PowerShell
	$today=Get-Date -Format "MM-dd-yyyy"
	$deploymentName="addSkuParameter-"+"$today"
	New-AzResourceGroupDeployment `
	  -Name $deploymentName `
	  -TemplateFile $templateFile `
	  -storageName {your-unique-name} `
	  -storageSKU Standard_GRS
	```

	o

	```CLI
	templateFile="azuredeploy.json"
	today=$(date +"%d-%b-%Y")
	DeploymentName="addSkuParameter-"$today
	
	az deployment group create --name $DeploymentName --template-file $templateFile --parameters storageSKU=Standard_GRS storageName={your-unique-name}
	```

	Deje que finalice esta implementación. Esta implementación se realiza correctamente de la manera esperada. Los valores permitidos impiden que los usuarios de la plantilla pasen valores de parámetro que no funcionan para el recurso. Ahora se verá lo que sucede cuando se proporciona una SKU no válida.

2. Ejecute los comandos siguientes para implementar la plantilla con un parámetro que no está permitido. Aquí ha cambiado el parámetro `storageSKU` por **Basic**. Rellene un nombre único para el parámetro `storageName`. Recuerde que este nombre debe ser único en todo Azure. Puede usar el nombre único que ha creado en la última sección. En ese caso, Azure actualizará el recurso en lugar de crear uno.

	```PowerShell
	$today=Get-Date -Format "MM-dd-yyyy"
	$deploymentName="addSkuParameter-"+"$today"
	New-AzResourceGroupDeployment `
	  -Name $deploymentName `
	  -TemplateFile $templateFile `
	  -storageName {your-unique-name} `
	  -storageSKU Basic
	```


	o

	```CLI
	templateFile="azuredeploy.json"
	today=$(date +"%d-%b-%Y")
	DeploymentName="addSkuParameter-"$today
	
	az deployment group create --name $DeploymentName --template-file $templateFile --parameters storageSKU=Basic storageName={your-unique-name}
	```


	Se produce un error en esta implementación. Observe el error.
	
	![[Pasted image 20231229180252.png]]
#### Adición de salida a la plantilla de ARM

Aquí agregará a la sección `outputs` de la plantilla de ARM para generar los puntos de conexión para el recurso de cuenta de almacenamiento.

1. En el archivo _azuredeploy.json_ de Visual Studio Code, coloque el cursor entre las llaves del atributo outputs `"outputs":{},`.
    
2. Presione Entrar y luego escriba _out_. Obtendrá una lista de fragmentos de código relacionados. Seleccione **new-output**. Esto agrega una salida genérica a la plantilla. Tendrá este aspecto:

	```JSON
	"outputs": {
	  "output1": {
	    "type": "string",
	    "value": "value"
	  }
	```

3. Cambie **"output1"** a **"storageEndpoint"**, y después cambie el valor de `type` a **"object"**. Cambie el valor de `value` a **"[reference(parameters('storageName')).primaryEndpoints]"**. Esta expresión es la que se describe en la unidad anterior que obtiene los datos del punto de conexión. Dado que especificamos _object_ como tipo, devolverá el objeto en formato JSON.


```JSON
"outputs": {
  "storageEndpoint": {
    "type": "object",
    "value": "[reference(parameters('storageName')).primaryEndpoints]"
  }
```

4. Guarda el archivo


##### Implementación de la plantilla de ARM con una salida

Aquí, implementará la plantilla y verá la salida de los puntos de conexión como JSON. Tendrá que rellenar un nombre único para el parámetro `storageName`. Recuerde que este nombre debe ser único en todo Azure. Puede usar el nombre único que ha creado en la última sección. En ese caso, Azure actualizará el recurso en lugar de crear uno.

1. Ejecute los comandos siguientes para implementar la plantilla. Asegúrese de reemplazar _{your-unique-name}_ (el nombre único) por una cadena única.
    
	```PowerShell
	$today=Get-Date -Format "MM-dd-yyyy"
	$deploymentName="addOutputs-"+"$today"
	New-AzResourceGroupDeployment `
	  -Name $deploymentName `
	  -TemplateFile $templateFile `
	  -storageName {your-unique-name} `
	  -storageSKU Standard_LRS
	```

	o

	```CLI
	templateFile="azuredeploy.json"
	today=$(date +"%d-%b-%Y")
	DeploymentName="addoutputs-"$today
	
	az deployment group create --name $DeploymentName --template-file $templateFile --parameters storageSKU=Standard_LRS storageName={your-unique-name}
	```

	Observe la salida.
	
	![[Pasted image 20231229180556.png]]
##### Comprobación de la implementación de salida

En Azure Portal, vaya a la implementación _addOutputs_. Ahí también puede encontrar la salida.

![[Pasted image 20231229180618.png]]

### Prueba de Conocimientos

1. ¿Qué es una plantilla de Azure Resource Manager?

<details>
	<summary>Respuesta</summary>
	<p>Una plantilla de Azure Resource Manager <b>es un archivo JSON</b> que define la infraestructura y la configuración de la implementación. Las plantillas de ARM le permiten declarar lo que piensa implementar sin tener que escribir la secuencia de comandos de programación para crearlo.</p>
</details>

2. ¿Cuál de estos _no_ es un elemento de una plantilla de Azure Resource Manager?

<details>
	<summary>Respuesta</summary>
	<p><b>idempotent</b>Los elementos de una plantilla de Azure Resource Manager son schema, contentVersion, apiProfile, parameters, variables, functions, resources y output.</p>
</details>

3. Las plantillas de Azure Resource Manager son idempotentes. Esto significa que si ejecuta una plantilla sin cambios por segunda vez:

<details>
	<summary>Respuesta</summary>
	<p>Si el recurso ya existe y no se detecta ningún cambio en las propiedades, no se realizará ninguna acción. Si el recurso ya existe y se produce un cambio en alguna propiedad, el recurso se actualiza. Si el recurso no existe, se creará.</p>
</details>


### Resumen

En este módulo, hemos aprendido sobre las plantillas de Azure Resource Manager (plantillas de ARM) y se han usado para implementar una cuenta de almacenamiento en Azure. Hemos aumentado la flexibilidad de la plantilla agregando parámetros y obtenido resultados a raíz de la ejecución de la plantilla.

En resumen:

- Hemos implementado una plantilla de ARM mediante Visual Studio Code.
- Hemos declarado recursos y dotado de flexibilidad a la plantilla mediante la adición de recursos, parámetros y salidas.

#### Saber más

Para obtener más información, consulte los artículos siguientes:

- [Herramientas de Azure Resource Manager para Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=msazurermtools.azurerm-vscode-tools)
- [Descripción de la estructura y la sintaxis de las plantillas de ARM](https://learn.microsoft.com/es-es/azure/azure-resource-manager/templates/template-syntax)
- [Información general sobre Azure Resource Manager](https://learn.microsoft.com/es-es/azure/azure-resource-manager/management/overview)
- [Instalación de la CLI de Azure](https://learn.microsoft.com/es-es/cli/azure/install-azure-cli)
- [Instalación de Azure PowerShell](https://learn.microsoft.com/es-es/powershell/azure/install-az-ps)
- [Proveedores de recursos para servicios de Azure](https://learn.microsoft.com/es-es/azure/azure-resource-manager/management/azure-services-resource-providers)
- [Definición de recursos en plantillas de Azure Resource Manager](https://learn.microsoft.com/es-es/azure/templates)
- [Salidas en las plantillas de Azure Resource Manager](https://learn.microsoft.com/es-es/azure/azure-resource-manager/templates/template-outputs?tabs=azure-powershell)
- [Parámetros en las plantillas de Azure Resource Manager](https://learn.microsoft.com/es-es/azure/azure-resource-manager/templates/template-parameters)

# AZ-104: Administración de identidades y gobernanza en Azure

## Configuración de Microsoft Entra ID

### Introducción

Microsoft Entra ID es un **servicio de administración de identidades y directorios** basado en la nube que admite el acceso de los usuarios a varios recursos y aplicaciones.

Trabaja para una gran empresa multinacional que recientemente ha adoptado Microsoft Entra ID. Como administrador de TI, es responsable de administrar el acceso de los usuarios a diferentes recursos y aplicaciones. Sin embargo, con una fuerza de trabajo tan diversa y distribuida en varias ubicaciones, garantizar un acceso seguro y eficaz puede ser un desafío. Se necesita una solución que proporcione administración de identidades centralizada y ofrezca características de seguridad sólidas. Con Microsoft Entra ID, podrá proporcionar a los usuarios acceso sin problemas a los recursos internos y externos. Al implementar Microsoft Entra ID, **podrá mejorar la seguridad, mejorar la productividad y reducir los costes de su organización**.

En este módulo, obtendrá información sobre los componentes y conceptos clave de Microsoft Entra ID. Los temas tratados incluyen inquilinos, identidades, cuentas y suscripciones de Azure. Explorará las distintas ediciones de Microsoft Entra ID y sus características. Además, descubrirá las ventajas de las características del autoservicio de restablecimiento de contraseña (SSPR) y cómo implementarlas en su organización.

El objetivo de este módulo es proporcionarle una mejor comprensión de Microsoft Entra ID y sus características.

#### Objetivos de aprendizaje

En este módulo aprenderá a:

- Defina los conceptos de Microsoft Entra, incluidas las identidades, las cuentas y los inquilinos.
    
- Describir las características de Microsoft Entra para admitir diferentes configuraciones.
    
- Comprenda las diferencias entre Microsoft Entra ID y Active Directory Domain Services (AD DS).
    
- Elija entre las ediciones admitidas de Microsoft Entra ID.
    
- Descripción de cómo unirse a Microsoft Entra.
    
- Descripción del autoservicio de restablecimiento de contraseña de Microsoft Entra.
    

#### Aptitudes evaluadas

El contenido del módulo le ayuda a prepararse para el [examen AZ-104: Administrador de Microsoft Azure](https://learn.microsoft.com/es-es/certifications/exams/az-104).

#### Requisitos previos

- Comprenda los conceptos básicos de las soluciones de identidad centralizadas. Este conocimiento incluye identidades, cuentas y métodos de autenticación.
    
- Familiaridad con las soluciones de identidad locales frente a las de la nube. Este conocimiento incluye ventajas y características comunes.


### Descripción de las ventajas y características de Microsoft Entra ID

[Microsoft Entra ID](https://learn.microsoft.com/es-es/azure/active-directory/) es el directorio basado en la nube multiinquilino de Microsoft y el servicio de administración de identidades. Microsoft Entra ID ayuda con el acceso de los usuarios a recursos y aplicaciones, por ejemplo:

- Recursos y aplicaciones internos ubicados en la red corporativa.
    
- Recursos externos como Microsoft 365, Azure Portal y aplicaciones SaaS.
    
- Aplicaciones en la nube desarrolladas para la organización.
    

En el diagrama siguiente se muestra un ejemplo de implementación de Microsoft Entra ID. En este escenario, Windows Server AD usa la [autenticación Kerberos](https://learn.microsoft.com/es-es/windows-server/security/kerberos/kerberos-authentication-overview) y [NTLM](https://learn.microsoft.com/es-es/windows-server/security/kerberos/ntlm-overview) en las aplicaciones locales.

![[Pasted image 20240102093042.png]]

#### Aspectos que se deben conocer sobre las características de Microsoft Entra

Vamos a examinar algunas de las características destacadas de Microsoft Entra ID.

|Característica de Azure AD|Descripción|
|---|---|
|**Acceso mediante inicio de sesión único (SSO)**|Microsoft Entra ID proporciona inicio de sesión único (SSO) seguro en aplicaciones web en la nube y en aplicaciones locales. Los usuarios pueden iniciar sesión con el mismo conjunto de credenciales para acceder a todas sus aplicaciones.|
|**Compatibilidad con dispositivos omnipresente**|Microsoft Entra ID funciona con dispositivos iOS, macOS, Android y Windows, y ofrece una experiencia común en todos los dispositivos. Los usuarios pueden iniciar aplicaciones desde un panel de acceso personalizado basado en web, una aplicación móvil, Microsoft 365 o portales de empresa personalizados con sus credenciales de trabajo existentes.|
|**Acceso remoto seguro**|Microsoft Entra ID permite el acceso remoto seguro a aplicaciones web locales. El acceso seguro puede incluir la autenticación multifactor (MFA), las directivas de acceso condicional y la administración de acceso basada en grupos. Los usuarios pueden acceder a aplicaciones web locales desde cualquier lugar, incluido desde el mismo portal.|
|**Extensibilidad a la nube**|Microsoft Entra ID puede extenderse a la nube para ayudarle a administrar un conjunto coherente de usuarios, grupos, contraseñas y dispositivos en todos los entornos.|
|**Protección de datos confidenciales**|Microsoft Entra ID ofrece funcionalidades únicas de protección de identidades para proteger los datos confidenciales y las aplicaciones. Los administradores pueden supervisar si hay actividad de inicio de sesión sospechosa y posibles vulnerabilidades en una vista consolidada de usuarios y recursos en el directorio.|
|**Soporte mediante autoservicio**|Microsoft Entra ID le permite delegar tareas de administrador seleccionadas a los empleados de la empresa. Proporcionar acceso a aplicaciones de autoservicio y administración de contraseñas mediante pasos de comprobación puede reducir las llamadas al departamento de soporte técnico y mejorar la seguridad.|


#### Aspectos que se deben tener en cuenta al usar características de Microsoft Entra

Microsoft Entra ID ofrece muchas características y ventajas. Tenga en cuenta qué características se pueden usar para admitir mejor los escenarios corporativos.

- **Considere la posibilidad de habilitar el acceso con inicio de sesión único**. Habilite el acceso SSO para que los usuarios se conecten a la nube o usen las aplicaciones locales. El inicio de sesión único de Microsoft Entra es compatible con Microsoft 365 y miles de aplicaciones SaaS, como Salesforce, Workday, DocuSign, ServiceNow y Box.
    
- **Tenga en cuenta la experiencia de usuario y la compatibilidad con dispositivos**. Cree una experiencia de usuario coherente que funcione para todos los dispositivos y puntos de acceso de directorio. Puede diseñar portales de empresa personalizados y acceso personalizado basado en web para los empleados que les permita conectarse con sus credenciales de trabajo existentes.
    
- **Tenga en cuenta las ventajas del acceso remoto seguro**. Proteja las aplicaciones web locales mediante la implementación del acceso remoto seguro con MFA y directivas de acceso.
    
- **Tenga en cuenta las ventajas de la extensibilidad a la nube**. Conecte Active Directory y otros directorios locales de la nube a Microsoft Entra en unos pocos pasos. Puede facilitar a los administradores la administración de los mismos usuarios, grupos, contraseñas y dispositivos en todos los entornos admitidos.

- **Considere la posibilidad de usar la protección avanzada para los datos confidenciales**. Mejore la seguridad de los datos confidenciales y de las aplicaciones mediante las características de protección integradas de Microsoft Entra ID. Los administradores pueden utilizar los informes de seguridad avanzados, las notificaciones, las recomendaciones de corrección y las directivas basadas en riesgos.
    
- **Tenga en cuenta las opciones de autoservicio de costo reducido**. Aproveche las ventajas de las características de autoservicio de Microsoft Entra para ayudar a reducir los costos de su organización. Delegue determinadas tareas, como el restablecimiento de contraseñas o la creación y administración de grupos, a los usuarios que no son administradores.
    

En la siguiente unidad, exploraremos los conceptos de Microsoft Entra que hacen posible estas características.

### Descripción de los conceptos de Microsoft Entra

Para implementar Microsoft Entra ID en la configuración corporativa, debe comprender los componentes clave del servicio. En la tabla siguiente se describen los principales componentes y conceptos de Microsoft Entra ID y se explica cómo funcionan conjuntamente para admitir las características de servicio

|Concepto de Azure AD|Descripción|
|---|---|
|**Identidad**|Una _identidad_ es un objeto que se puede autenticar. La identidad puede ser un usuario con un nombre de usuario y una contraseña. Las identidades también pueden ser aplicaciones u otros servidores que requieren autenticación mediante certificados o claves secretas. Microsoft Entra ID es el producto subyacente que proporciona el servicio de identidad.|
|**Cuenta**|Una _cuenta_ es una identidad que tiene datos asociados. Para tener una cuenta, primero debe tener una identidad válida. No puede tener una cuenta sin una identidad.|
|**Cuenta de Microsoft Entra**|Una _cuenta de Azure AD_ es una identidad que se crea mediante Microsoft Entra ID u otro servicio en la nube de Microsoft, como Microsoft 365. Las identidades se almacenan en Microsoft Entra ID y pueden acceder a ellas las suscripciones de servicio en la nube de su organización. La cuenta de Microsoft Entra también se denomina _cuenta profesional o educativa_.|
|**Inquilino (directorio) de Azure**|Un _inquilino_ de Azure es una instancia única, dedicada y de confianza de Microsoft Entra ID. Cada inquilino (también denominado _directorio_) representa una sola organización. Cuando su organización se registra a una suscripción de servicio en la nube de Microsoft, automáticamente se crea un nuevo inquilino. Dado que cada inquilino es una instancia dedicada y de confianza de Microsoft Entra ID, puede crear varios inquilinos o instancias.|
|**Suscripción de Azure**|Una suscripción de Azure se usa para pagar los servicios en la nube de Azure. Cada suscripción se une a un único inquilino. Puede tener varias suscripciones.|


	 Sugerencia
	
	Si es cliente de Microsoft 365, Azure o Dynamics CRM Online, es posible que ya esté usando Microsoft Entra ID. Cada inquilino de Microsoft 365, Azure y Dynamics CRM ya es un inquilino de Microsoft Entra. Puede empezar a usar el inquilino para administrar el acceso a miles de otras aplicaciones en la nube que se integran con Microsoft Entra ID.

### Comparación de Active Directory Domain Services y Microsoft Entra ID

Active Directory Domain Services (AD DS) es la implementación tradicional de Active Directory basado en Windows Server en un servidor físico o virtual. Active Directory Domain Services (AD DS) también incluye Servicios de certificados de Active Directory (AD CS), Active Directory Lightweight Directory Services (AD LDS), Servicios de federación de Active Directory (AD FS) y Active Directory Rights Management Services (AD RMS).

	 Importante
	
	Si bien puede implementar y administrar AD DS en Azure Virtual Machines, se recomienda usar Microsoft Entra ID, a menos que su configuración tenga como destino cargas de trabajo de IaaS que dependan específicamente de AD DS.

#### Aspectos que se deben tener en cuenta al usar Microsoft Entra en lugar de AD DS

**Microsoft Entra ID es similar a AD DS, pero hay diferencias importantes**. Es importante comprender que el uso de Microsoft Entra ID para **la configuración es diferente de implementar** un controlador de dominio de Active Directory en una máquina virtual de Azure y, a continuación, agregarlo al dominio local.

A medida que planee la estrategia de identidad, tenga en cuenta las siguientes **características que distinguen Microsoft Entra ID de AD DS**.

- **Solución de identidad**: **AD DS es principalmente un servicio de directorio, mientras que Microsoft Entra ID es una solución de identidad completa**. Microsoft Entra ID está diseñado para aplicaciones basadas en Internet que usan comunicaciones HTTP y HTTPS. Las características y capacidades de Microsoft Entra ID admiten la administración segura de identidades de destino.
    
- **Protocolos de comunicación**: Dado que **Microsoft Entra ID se basa en HTTP y HTTPS, no usa la autenticación Kerberos**. Microsoft Entra ID implementa los protocolos HTTP y HTTPS, como SAML, WS-Federation y OpenID Connect para la autenticación, así como OAuth para la autorización.
    
- **Servicios de federación**: **Microsoft Entra ID incluye servicios de federación** y muchos servicios de terceros como Facebook.
    
- **Estructura plana**: Los usuarios y grupos de Microsoft Entra se crean en una estructura plana. **No hay unidades organizativas (UO) ni objetos de directiva de grupo (GPO)**.
    
- **Servicio administrado**: Microsoft Entra ID es un servicio administrado. Solo se administran los usuarios, los grupos y las directivas. Si implementa AD DS con máquinas virtuales mediante Azure, administra muchas otras tareas, como la implementación, la configuración, las máquinas virtuales, la aplicación de revisiones y otros procesos de back-end.

### Selección de las ediciones de Microsoft Entra

Microsoft Entra ID incluye cuatro ediciones: **Gratis**, **Aplicaciones de Microsoft 365**, **Premium P1**y **Premium P2**. La edición Free se incluye con una suscripción de Azure. Las ediciones Premium están disponibles mediante un Contrato Enterprise de Microsoft, el programa Licencia por volumen abierto y el programa Proveedores de soluciones en la nube. Los suscriptores de Azure y Microsoft 365 también pueden comprar Microsoft Entra ID P1 y P2 en línea.

#### Aspectos que se deben conocer sobre las ediciones de Microsoft Entra

Tenga en cuenta las siguientes características que distinguen las distintas ediciones de Microsoft Entra ID. Después de revisar las características y descripciones, piense en qué edición funciona mejor para su organización. Un `X` indica que se admite la característica.

|Característica|Gratuito|Aplicaciones de Microsoft 365|Premium P1|Premium P2|
|---|---|---|---|---|
|**Objetos de directorio**|500.000|Sin límite|Sin límite|Sin límite|
|**Single Sign-on** (Inicio de sesión único)|Sin límite|Sin límite|Sin límite|Sin límite|
|**Administración de identidades y acceso principales**|`X`|`X`|`X`|`X`|
|**Colaboración de negocio a negocio**|`X`|`X`|`X`|`X`|
|**Administración de identidades y acceso  <br>para Aplicaciones de Microsoft 365**||`X`|`X`|`X`|
|**Características de la edición Premium**|||`X`|`X`|
|**Identidades híbridas**|||`X`|`X`|
|**Administración avanzada de acceso a grupos**|||`X`|`X`|
|**Acceso condicional**|||`X`|`X`|
|**Identity Protection**||||`X`|
|**Identity Governance**||||`X`|


##### Microsoft Entra ID Free

La edición Gratis proporciona administración de usuarios y grupos, sincronización de directorios locales e informes básicos. El acceso con inicio de sesión único se admite en Azure, Microsoft 365 y muchas aplicaciones SaaS populares.

##### Microsoft Entra Aplicaciones de Microsoft 365

Esta edición se incluye con Microsoft 365. Además de las características de la edición Gratis, esta edición proporciona administración de identidades y acceso para aplicaciones de Microsoft 365. La compatibilidad adicional incluye personalización de marca, MFA, administración de acceso a grupos y autoservicio de restablecimiento de contraseña para los usuarios en la nube.

##### Microsoft Entra ID P1

Además de las características de la edición Gratis, la edición Premium P1 permite a los usuarios de entornos híbridos acceder a recursos locales y en la nube. Esta edición admite la administración avanzada, como los grupos dinámicos, la administración de grupos de autoservicio y capacidades de escritura diferida en la nube. La edición P1 también incluye Microsoft Identity Manager, un conjunto de administración de identidades y acceso local. Las características adicionales de la edición P1 permiten el autoservicio de restablecimiento de contraseña para los usuarios locales.

##### Microsoft Entra ID P2

Además de incluir las características de las ediciones Gratis y P1, la edición Premium P2 ofrece Microsoft Entra ID Protection para facilitar el acceso condicional basado en riesgos a las aplicaciones y a los datos críticos de la empresa. Privileged Identity Management se incluye para descubrir, restringir y supervisar a los administradores y su acceso a los recursos, y proporcionar acceso Just-in-Time cuando sea necesario.

 Sugerencia

La [página de precios de Microsoft Entra](https://azure.microsoft.com/pricing/details/active-directory) contiene información detallada sobre lo que se incluye en cada edición.

### Implementación de la unión a Microsoft Entra

Microsoft Entra ID habilita el inicio de sesión único (SSO) en dispositivos, aplicaciones y servicios desde cualquier ubicación. Para admitir el SSO, los administradores de TI deben asegurarse de que los recursos corporativos están protegidos y de que los dispositivos cumplen los estándares de seguridad y cumplimiento.

![[Pasted image 20240102095822.png]]

La característica de unión a Microsoft Entra funciona con SSO para proporcionar acceso a aplicaciones y recursos de la organización, así como simplificar las implementaciones de dispositivos de trabajo Windows.

#### Aspectos que se deben saber sobre la característica de unión a Microsoft Entra

Veamos algunas de las ventajas de usar dispositivos unidos:

|Prestación|Descripción|
|---|---|
|**Inicio de sesión único (SSO)**|Los dispositivos unidos ofrecen acceso SSO a sus servicios y aplicaciones SaaS administrados por Azure. Los usuarios no necesitarán solicitudes de autenticación adicionales cuando accedan a los recursos de trabajo. La función SSO está disponible incluso cuando no están conectados a la red de dominios.|
|**Enterprise State Roaming**|A partir de Windows 10, los usuarios pueden sincronizar de forma segura su configuración de usuario y los datos de configuración de la aplicación con dispositivos unidos. La itinerancia de estado empresarial reduce el tiempo para configurar un nuevo dispositivo.|
|**Windows Hello**|Proporcione a los usuarios un acceso seguro y cómodo a los recursos de trabajo desde dispositivos unidos.|
|**Restricción de acceso**|Restrinja el acceso de los usuarios a las aplicaciones para que solo se produzca desde dispositivos unidos que cumplan las directivas de cumplimiento.|
|**Acceso sin problemas a los recursos locales**|Los dispositivos unidos tienen acceso ininterrumpido a los recursos locales cuando el dispositivo tiene línea de visión al controlador de dominio local.|


#### Aspectos que se deben tener en cuenta al usar dispositivos unidos

Su organización está interesada en usar dispositivos unidos en su estrategia de administración. A medida que planee cómo implementar la característica, revise estos puntos de configuración:

- **Tenga en cuenta las opciones de conexión**. Conecte el dispositivo a Microsoft Entra ID de una de estas dos maneras:
    
    - **Registre** el dispositivo en Microsoft Entra ID para que pueda administrar la identidad del dispositivo. El registro de dispositivos de Microsoft Entra proporciona una identidad al dispositivo que se utiliza para autenticarlo cuando el usuario inicia sesión en Microsoft Entra. Puede utilizar esta identidad para habilitar o deshabilitar el dispositivo.
        
    - **Únase** al dispositivo, que es una extensión del registro de un dispositivo. La unión ofrece las ventajas del registro, y también cambia el estado local del dispositivo. El cambio del estado local permite a los usuarios iniciar sesión en un dispositivo mediante una cuenta profesional o educativa en lugar de con una cuenta personal.
        
- **Considere la posibilidad de combinar el registro con otras soluciones**. Combine el registro con una solución de administración de dispositivos móviles (MDM), como Microsoft Intune para proporcionar otros atributos de dispositivo en Microsoft Entra ID. Puede crear reglas de acceso condicional que obliguen a que el acceso desde dispositivos cumpla con los estándares de seguridad y cumplimiento de la organización.
    
- **Tenga en cuenta otros escenarios de implementación**. Aunque la unión a AD está pensada para organizaciones que tengan una infraestructura de Windows Server Active Directory local, se puede usar en otros escenarios, como sucursales.

### Implementar el autoservicio de restablecimiento de contraseña de Microsoft Entra

Muchas de las llamadas al departamento de soporte técnico son solicitudes a fin de restablecer contraseñas para los usuarios. La característica de **autoservicio de restablecimiento de contraseña** (SSPR) de Microsoft Entra le permite dar a los usuarios la posibilidad de omitir el departamento de soporte técnico y restablecer sus propias contraseñas.

#### Aspectos que se deben conocer sobre la característica SSPR de Microsoft Entra

Examine las siguientes características y requisitos de la característica SSPR:

- SSPR requiere una cuenta de Microsoft Entra con privilegios de administrador global para administrar las opciones de SSPR. Esta cuenta siempre puede restablecer sus propias contraseñas, independientemente de las opciones configuradas.
    
- SSPR usa un grupo de seguridad para limitar los usuarios que tienen privilegios de SSPR.
    
- Todas las cuentas de usuario de la organización deben tener una licencia válida para usar SSPR.
    

#### Aspectos que se deben tener en cuenta al usar SSPR

Su organización quiere implementar la compatibilidad con SSPR en su solución de administración. A medida que planee la configuración, revise los siguientes puntos:

- **Piense en quién puede restablecer sus contraseñas**. Decida qué usuarios de la organización deben tener la posibilidad de usar la característica. En Azure Portal, hay tres opciones para la característica SSPR: **Ninguno**, **Seleccionados** y **Todos**.

![[Pasted image 20240102102542.png]]


- La opción **Seleccionados** es útil para crear grupos concretos que tengan SSPR habilitado. Puede crear grupos para pruebas o pruebas de concepto antes de aplicar la característica a un grupo más grande. Cuando esté listo para implementar SSPR en todas las cuentas de usuario del inquilino de Microsoft Entra, puede cambiar la configuración.
    
- **Tenga en cuenta los métodos de autenticación**. Determine cuántos métodos de autenticación se requieren para restablecer una contraseña y seleccione las opciones de autenticación para los usuarios.
    
    - El sistema debe requerir al menos un método de autenticación para restablecer una contraseña.
        
    - Un plan de SSPR seguro ofrece varios métodos de autenticación para el usuario. Las opciones incluyen notificaciones por correo electrónico, mensajes de texto o códigos de seguridad enviados al teléfono móvil o de la oficina del usuario. También puede ofrecer al usuario un conjunto de preguntas de seguridad.
        
    - Puede requerir que las preguntas de seguridad se registren para los usuarios del inquilino de Microsoft Entra.
        
    - Puede configurar las preguntas de seguridad correctamente respondidas que considere necesarias para obtener un restablecimiento de contraseña correcto.
    
- **Considere la posibilidad de combinar métodos para mejorar la seguridad**. Las preguntas de seguridad pueden ser menos seguras que otros métodos de autenticación. Es posible que algunos usuarios conozcan las respuestas de las preguntas de un usuario determinado o que las preguntas sean fáciles de resolver. Si admite preguntas de seguridad, combine esta opción con otros métodos de autenticación.


### Prueba de conocimientos

Supongamos que su empresa busca una solución de identidad sólida. Su trabajo es decidir si la opción óptima es Microsoft Entra ID o Active Directory Domain Services (AD DS). Si elige Microsoft Entra ID, debe seleccionar la edición que mejor satisfaga las necesidades de su organización y determinar qué características se van a implementar.

A continuación se indican algunos requisitos para el diseño:

- **Los usuarios deben poder iniciar sesión en dispositivos, aplicaciones y servicios desde cualquier lugar**.
    
- **El equipo de TI quiere que los usuarios administren sus propias contraseñas y realicen tareas relacionadas**.
    
- **El departamento legal solicita protección para los datos confidenciales para cumplir los estándares de cumplimiento de gobernanza**.

1. ¿Qué opción describe correctamente Microsoft Entra ID?

<details>
	<summary>Respuesta</summary>
	<p>Microsoft Entra ID <b>es principalmente una solución de identidad</b>. Está diseñado para aplicaciones basadas en Internet mediante comunicaciones HTTP y HTTPS.</p>
</details>


2. ¿Qué término define una instancia dedicada y de confianza de Microsoft Entra ID?

<details>
	<summary>Respuesta</summary>
	<p><b>Un inquilino de Azure</b> es una instancia dedicada y de confianza de Microsoft Entra ID. Un inquilino se crea automáticamente cuando una organización se registra en una suscripción de servicio en la nube de Microsoft</p>
</details>


3. Sus usuarios quieren tener la posibilidad de iniciar sesión en dispositivos, aplicaciones y servicios desde cualquier lugar. Los usuarios quieren iniciar sesión mediante una cuenta profesional o educativa en lugar de con una cuenta personal. ¿Qué debe hacer primero?

<details>
	<summary>Respuesta</summary>
	<p><b>Unir el dispositivo a Microsoft Entra ID</b> La unión del dispositivo proporciona las características que necesita.</p>
</details>

### Resumen y Recursos

Los administradores de Azure deben estar familiarizados con Microsoft Entra ID y sus conceptos.

En este módulo, hemos obtenido información sobre las características de Microsoft Entra y explorado los escenarios de implementación. Junto a la revisión de los componentes principales de Microsoft Entra ID, incluidos los inquilinos, las identidades y las cuentas, y hemos aprendido cómo están relacionados. También hemos comparado Active Directory Domain Services con Microsoft Entra ID y descubierto cómo las diferentes ediciones de Microsoft Entra admiten características. Aunado a la exploración de las ventajas de las características de unión a Microsoft Entra y autoservicio de restablecimiento de contraseña (SSPR) y ha pensado en cómo implementarlas para su organización.

Las principales conclusiones de este módulo son:

- Microsoft Entra ID es un servicio de administración de identidades y directorios basado en la nube que permite el acceso de los usuarios a varios recursos y aplicaciones.
- Microsoft Entra ID proporciona ventajas como seguridad mejorada, experiencia del usuario coherente, costos reducidos y productividad mejorada.
- Microsoft Entra ID incluye varios componentes y conceptos clave, como identidades, cuentas, inquilinos y suscripciones.
- Microsoft Entra ID ofrece una alternativa basada en la nube a Active Directory Domain Services (AD DS).
- Microsoft Entra ID está disponible en cuatro ediciones, cada una de las cuales ofrece diferentes características y funcionalidades.
- El autoservicio de restablecimiento de contraseña ofrece a los usuarios la posibilidad de omitir el departamento de soporte técnico y restablecer sus propias contraseñas.

#### Más información con la documentación de Azure

- [¿Qué es Microsoft Entra ID?](https://learn.microsoft.com/es-es/entra/fundamentals/whatis). En este artículo, se revisan las características, las licencias y la terminología de Microsoft Entra ID.
    
- [Comparación de Active Directory con Microsoft Entra ID](https://learn.microsoft.com/es-es/entra/fundamentals/compare). En este artículo, se describen las diferencias y similitudes entre los conceptos de Active Directory y Microsoft Entra ID.
    
- [Planeamiento de una implementación de SSPR de Microsoft Entra](https://learn.microsoft.com/es-es/entra/identity/authentication/howto-sspr-deployment). En este artículo, se revisan las funcionalidades clave, la arquitectura y las consideraciones de planeación.
    

#### Más información con el aprendizaje autodirigido

- [Explorar Microsoft Entra ID](https://learn.microsoft.com/es-es/training/modules/explore-azure-active-directory). En este módulo de aprendizaje, se presenta Microsoft Entra ID.
    
- [Permitir que los usuarios restablezcan sus contraseñas con el autoservicio de restablecimiento de contraseña de Microsoft Entra](https://learn.microsoft.com/es-es/training/modules/allow-users-reset-their-password). En este módulo de aprendizaje, se describe SSPR y cómo se implementa.

## Configuración de cuentas de usuario y de grupo

### Introducción

El acceso a los recursos de Azure se controla mediante cuentas de usuario e identidades definidas en Microsoft Entra ID. Microsoft Entra ID admite cuentas de grupo para ayudarle a organizar las cuentas de usuario y facilitar la administración.

En este módulo, su empresa quiere aprovechar las características de la cuenta de usuario y grupo en Microsoft Entra ID. Debe **comprender los conceptos de cuentas de usuario y cuentas de grupo**. Busca información sobre cómo crear, configurar y administrar estas cuentas. La organización necesita compatibilidad con la configuración masiva de opciones, la organización de cuentas de grupo y la administración de cuentas en varios directorios.

En este módulo, obtendrá información sobre las cuentas de usuario y las cuentas de grupo. Obtendrá información sobre un acceso directo de administrador para la creación masiva de cuentas de usuario. Obtenga información sobre cómo controlar el acceso de administrador a través de unidades administrativas. También simula la creación de usuarios y grupos en Azure Portal.

El objetivo de este módulo es crear y administrar correctamente cuentas de usuario y grupo.

#### Objetivos de aprendizaje

En este módulo aprenderá a:

- Cree y configure cuentas de usuario, incluidas las propiedades de la cuenta y las actualizaciones masivas.
    
- Cree y configure cuentas de grupo, incluida la asignación de miembros del grupo.
    
- Use unidades administrativas para controlar el acceso de administrador.
    

#### Aptitudes evaluadas

El contenido del módulo le ayuda a prepararse para el [examen AZ-104: Administrador de Microsoft Azure](https://learn.microsoft.com/es-es/credentials/certifications/exams/az-104/).

#### Requisitos previos

- Comprenda los conceptos básicos de las soluciones de identidad centralizadas. Este conocimiento incluye identidades, cuentas y métodos de autenticación.
    
- Familiaridad con la administración de cuentas de usuario y grupo, incluido el principio de privilegios mínimos.

### Crear las cuentas de usuario

Cada usuario que desee acceso a los recursos de Azure precisa una cuenta de usuario de Azure. Una cuenta de usuario contiene toda la información necesaria para autenticar al usuario durante el proceso de inicio de sesión. **Microsoft Entra ID admite tres tipos de cuentas de usuario**. Los tipos indican dónde se define el usuario (en la nube o en el entorno local) y si el usuario es interno o externo a la organización de Microsoft Entra.

#### Aspectos que se deben conocer sobre las cuentas de usuario

En la tabla siguiente se describen las cuentas de usuario admitidas en Microsoft Entra ID. A medida que revise estas opciones, tenga en cuenta qué tipos de cuentas de usuario se adaptan a su organización.

|Cuenta de usuario|Descripción|
|---|---|
|**Identidad en la nube**|Las cuentas de usuario con una _identidad en la nube_ solo se definen en Microsoft Entra ID. Este tipo de cuenta de usuario incluye cuentas de administrador y usuarios que se administran como parte de la organización. Una identidad en la nube puede ser para las cuentas de usuario definidas en la organización de Microsoft Entra y también para las cuentas de usuario definidas en una instancia externa de Microsoft Entra. Cuando se quita una identidad en la nube del directorio principal, se elimina la cuenta de usuario.|
|**Identidades sincronizadas con Directory**|Las cuentas de usuario que tienen una _identidad sincronizada con Directory_ se definen en una instancia local de Active Directory. Se realiza una actividad de sincronización a través de Microsoft Entra Connect para incorporar estos usuarios a Azure. El origen de estas cuentas es Windows Server Active Directory.|
|**Usuario invitado**|Las cuentas de _usuario invitado_ se definen fuera de Azure. Algunos ejemplos son las cuentas de usuario de otros proveedores de nube y cuentas de Microsoft, como una cuenta de Xbox Live. El origen de las cuentas de usuario invitado es Usuario invitado. Las cuentas de usuario invitado son útiles cuando los proveedores externos o los contratistas necesitan acceso a sus recursos de Azure.|


#### Aspectos que se deben tener en cuenta al elegir cuentas de usuario

- **Tenga en cuenta dónde se definen los usuarios**. Determine dónde se definen los usuarios. ¿Se definen todos los usuarios dentro de la organización de Microsoft Entra o algunos de ellos se definen en instancias externas de Microsoft Entra? ¿Tiene usuarios externos a su organización? Es habitual que las empresas admitan dos o más tipos de cuenta en su infraestructura.
    
- **Considere la posibilidad de admitir colaboradores externos**. Permita que los colaboradores externos accedan a los recursos de Azure de su organización al admitir el tipo de cuenta de **usuario invitado**. Cuando el colaborador externo ya no requiera acceso, puede eliminar la cuenta de usuario y sus privilegios de acceso.
    
- **Considere usar una combinación de cuentas de usuario**. Implemente los tipos de cuenta de usuario que permiten a su organización satisfacer sus necesidades empresariales. Admita cuentas de usuario de identidad sincronizada con Directory para los usuarios definidos en Windows Server Active Directory. Admita identidades en la nube para los usuarios definidos en la estructura interna de Microsoft Entra o para usuarios definidos en una instancia externa de Microsoft Entra.

### Administrar cuentas de usuario

Hay varias maneras de agregar cuentas de usuario de identidad en la nube en Microsoft Entra ID. Un enfoque común consiste en usar Azure Portal. **También se pueden agregar cuentas de usuario a Microsoft Entra ID mediante el Centro de administración de Microsoft 365, la consola de administración de Microsoft Intune y la CLI de Azure**.

#### Aspectos que se deben conocer sobre las cuentas de identidad en la nube

Vamos a revisar cómo se definen las cuentas de usuario de identidad en la nube en Microsoft Entra ID. Este es un ejemplo de la nueva página **Usuario** en Azure Portal. El administrador puede **crear** un usuario dentro de la organización o **invitar** a un usuario invitado para proporcionarle acceso a los recursos de la organización:

![[Pasted image 20240105113519.png]]

- La nueva cuenta de usuario debe tener un nombre para mostrar y un nombre de cuenta de usuario asociado. Un ejemplo de nombre para mostrar es `Aran Sawyer-Miller`, y el nombre de la cuenta de usuario asociada podría ser `asawmill@contoso.com`.
    
- La información y la configuración que describen a un usuario se almacenan en el perfil de la cuenta de usuario.
    
- El perfil puede incluir otros parámetros, como el puesto de un usuario y su dirección de correo electrónico de contacto.
    
- Un usuario con privilegios de administrador global o administrador de usuarios puede predefinir los datos del perfil en las cuentas de usuario, como el número de teléfono principal de la empresa.
    
- Los usuarios que no son administradores pueden establecer algunos de sus datos del perfil, pero no pueden cambiar su nombre para mostrar ni el nombre de la cuenta.

#### Aspectos que se deben tener en cuenta al administrar cuentas de identidad en la nube

Hay varios puntos que se deben tener en cuenta sobre la administración de cuentas de usuario. A medida que revise esta lista, piense en cómo puede agregar cuentas de usuario de identidad en la nube para su organización.

- **Considere los datos del perfil de usuario**. Permita que los usuarios establezcan la información de perfil en sus cuentas, según sea necesario. Los datos del perfil de usuario, incluida la foto, el trabajo y la información de contacto del usuario, son opcionales. También puede proporcionar determinadas opciones de configuración del perfil para cada usuario en función de los requisitos de su organización.
    
- **Considere las opciones de restauración para las cuentas eliminadas**. Incluya escenarios de restauración en el plan de administración de cuentas. Las operaciones de restauración de una cuenta eliminada están disponibles hasta 30 días después de eliminar la cuenta. Después de 30 días, no se puede restaurar una cuenta de usuario eliminada.
    
- **Considere la recopilación de datos de cuentas**. Recopile información de inicio de sesión y registro de auditoría para las cuentas de usuario. Microsoft Entra ID le permite recopilar estos datos para ayudarle a analizar y mejorar la infraestructura.

### Creación masiva de cuentas de usuario

Microsoft Entra ID admite varias operaciones masivas, como la creación y eliminación masivas de cuentas de usuario. El enfoque más común para este tipo de operaciones es usar Azure Portal. Se puede usar Azure PowerShell para la carga masiva de cuentas de usuario.

#### Aspectos que se deben conocer sobre las operaciones de cuentas masivas

Vamos a examinar algunas características de las operaciones masivas Azure Portal. Este es un ejemplo que muestra la opción **Creación masiva de usuarios** para nuevas cuentas de usuario en Microsoft Entra ID:

![[Pasted image 20240105113951.png]]

- Solo los administradores globales o los administradores de usuarios tienen privilegios para crear y eliminar cuentas de usuario en Azure Portal.
    
- Para completar operaciones de creación o eliminación masivas, el administrador rellena una plantilla de valores separados por comas (CSV) de los datos de las cuentas de usuario.
    
- Las plantillas de operación masiva se pueden descargar desde el Centro de administración de Microsoft Entra.
    
- Se pueden descargar listas masivas de cuentas de usuario.

#### Aspectos que se deben tener en cuenta al crear cuentas de usuario

Estas son algunas consideraciones de diseño para crear y eliminar cuentas de usuario. Piense en qué convenciones y procesos de cuenta de usuario podrían ser necesarios para su organización.

- **Considere el uso de convenciones de nomenclatura**. Establezca o implemente una convención de nomenclatura para las cuentas de usuario. Aplique convenciones a los nombres de cuenta de usuario, los nombres para mostrar y los alias de usuario para que haya coherencia en toda la organización. Las convenciones para nombres y alias pueden simplificar el proceso de creación masiva mediante la reducción de áreas de unicidad en el archivo CSV. Una convención para los nombres de usuario podría comenzar con el apellido del usuario seguido de un punto y terminar con el nombre del usuario, como en `Sawyer-Miller.Aran@contoso.com`.
    
- **Considere la posibilidad de usar contraseñas iniciales**. Implante una convención para la contraseña inicial de un usuario recién creado. Diseñe un sistema para notificar a los nuevos usuarios sobre sus contraseñas de forma segura. Puede generar una contraseña aleatoria y enviarla por correo electrónico al nuevo usuario o a su administrador.
    
- **Considere las estrategias para minimizar errores**. Vea y solucione los errores; para ello, descargue el archivo de resultados en la página **Resultados de la operación masiva** en Azure Portal. El archivo de resultados contiene el motivo de cada error. Un error puede ser una cuenta de usuario que ya se ha creado o una cuenta duplicada. Por lo general, es más fácil cargar y solucionar problemas de grupos de usuarios más pequeños.

### Creación de cuentas de grupo

Microsoft Entra ID permite a su organización definir dos tipos diferentes de cuentas de grupo. Los **grupos de seguridad** se usan para administrar el acceso de miembros y equipos a los recursos compartidos de un grupo de usuarios. Puede crear un grupo de seguridad para una directiva de seguridad específica y aplicar los mismos permisos a todos los miembros del grupo. Los **grupos de Microsoft 365** proporcionan oportunidades de colaboración. Los miembros del grupo tienen acceso a un buzón, un calendario, archivos, un sitio de SharePoint y muchos más recursos compartidos.

#### Aspectos que debe conocer sobre la creación de cuentas de grupo

Revise las siguientes características de las cuentas de grupo en Microsoft Entra ID. En la captura de pantalla siguiente se muestra una lista de grupos en Azure Portal:

![[Pasted image 20240105121856.png]]

- **Use grupos de seguridad** para establecer permisos para todos los miembros del grupo al mismo tiempo, en lugar de agregar permisos para cada miembro individualmente.
    
- Agregue grupos de Microsoft 365 para habilitar el acceso de grupo para usuarios invitados fuera de la organización de Microsoft Entra.
    
- Un administrador de Microsoft Entra solo puede implementar grupos de seguridad.
    
- Los usuarios normales y los administradores de Microsoft Entra pueden usar grupos de Microsoft 365.

#### Aspectos que se deben tener en cuenta al agregar miembros a grupos

Al agregar miembros a un grupo, hay diferentes maneras de asignar derechos de acceso a miembros. A medida que lea estas opciones, tenga en cuenta qué grupos son necesarios para el funcionamiento de su organización y qué derechos de acceso se deben aplicar a los miembros del grupo.

|Derechos de acceso|Descripción|
|---|---|
|**Asignado**|Agregue usuarios específicos como miembros de un grupo, donde cada usuario puede tener permisos únicos.|
|**Usuario dinámico**|Use reglas de pertenencia dinámicas para agregar y quitar miembros de un grupo automáticamente. Cuando los atributos de un miembro cambian, Azure revisa las reglas de grupos dinámicos del directorio. Si los atributos del miembro cumplen los requisitos de la regla, el miembro se agrega al grupo. Si los atributos del miembro ya no cumplen los requisitos de la regla, el miembro se elimina.|
|**Dispositivo dinámico**|(_Solo para grupos de seguridad_) Aplique reglas de grupos dinámicos para agregar y quitar automáticamente dispositivos en grupos de seguridad. Si los atributos de un dispositivo cambian, Azure revisa las reglas de grupos dinámicos del directorio. Si los atributos de un dispositivo cumplen los requisitos de la regla, el dispositivo se agrega al grupo de seguridad. Si los atributos del dispositivo ya no cumplen los requisitos de la regla, el dispositivo se elimina.|


### Crear unidades administrativas


A medida que diseña la estrategia para la administración de identidades y la gobernanza en Azure, es fundamental planificar la administración completa de la infraestructura de Microsoft Entra. Puede ser útil restringir el ámbito administrativo mediante unidades administrativas para su organización. **La división de roles y responsabilidades es especialmente útil para las organizaciones que tienen muchas divisiones independientes**.

Pensemos en las tareas de administración de una universidad grande compuesta por varias escuelas diferentes, por ejemplo, de Negocios, Ingeniería y Medicina. La universidad cuenta con oficinas administrativas, edificios académicos, edificios sociales y dormitorios estudiantiles. Con fines de seguridad, cada oficina de negocios tiene su propia red interna para recursos como servidores, impresoras y máquinas de fax. Todos los edificios académicos están conectados a la red universitaria, para que tanto instructores como alumnos puedan acceder a sus cuentas. La red también está disponible para estudiantes y decanos en las habitaciones compartidas y los edificios sociales. En toda la universidad, los usuarios invitados necesitan acceso a Internet a través de la red universitaria.

La universidad tiene un equipo de administradores de TI que trabajan juntos para controlar el acceso a los recursos, administrar usuarios y establecer directivas para la escuela. Algunos administradores tienen privilegios mayores que otros en función del ámbito de sus responsabilidades. Se necesita una autoridad central para planificar, administrar y supervisar la estructura completa. En este escenario, puede asignar unidades administrativas para facilitar la administración de la organización.

![[Pasted image 20240105122930.png]]

#### Aspectos que hay que tener en cuenta en las unidades administrativas

Veamos cómo un rol de administrador central puede usar unidades administrativas para dar soporte al departamento de Ingeniería en nuestro escenario:

- Cree un rol que tenga permisos administrativos solo para los usuarios de Microsoft Entra en la unidad administrativa del departamento de Ingeniería.
    
- Cree una unidad administrativa para el departamento de Ingeniería.
    
- Rellene la unidad administrativa solo con los alumnos, el personal y los recursos del departamento de Ingeniería.
    
- Agregue el equipo de TI del departamento de Ingeniería al rol, junto con su ámbito.

#### Aspectos que se deben tener en cuenta al trabajar con unidades administrativas

Piense en cómo puede implementar unidades administrativas en su organización. A continuación, se indican algunas consideraciones:

- **Considere la posibilidad de usar herramientas de administración**. Revise las opciones para administrar las unidades administrativas. Puede usar Azure Portal, cmdlets y scripts de PowerShell o Microsoft Graph.
    
- **Considere los requisitos de rol de Azure Portal**. Planifique su estrategia para unidades administrativas según los privilegios de rol. En Azure Portal, solo los usuarios con el rol Administrador global o Administrador de roles con privilegios pueden administrar las unidades administrativas.
    
- **Considere el ámbito de las unidades administrativas**. Tenga en cuenta que el ámbito de una unidad administrativa solo se aplica a los permisos de _administración_. Los miembros y administradores de una unidad administrativa pueden ejercer sus permisos de _usuario_ predeterminados para examinar otros usuarios, grupos o recursos fuera de su unidad administrativa.


### Simulación interactiva de laboratorio

#### Escenario del laboratorio

Su organización usará la autenticación de Microsoft Entra. Se le ha encargado el aprovisionamiento de las cuentas de usuario y grupo necesarias. La pertenencia a los grupos debe actualizarse automáticamente en función de los puestos de trabajo del usuario. También debe invitar a usuarios invitados de otro inquilino. Estos usuarios invitados solo deben tener permisos limitados para los recursos de la suscripción.

Su organización tiene estos requisitos específicos:

- Cualquier usuario con el puesto de administrador en la nube debe asignarse al grupo administrador de la nube de TI.
- Cualquier usuario con el puesto de administrador del sistema debe asignarse al grupo administrador del sistema de TI.
- Cualquier usuario que sea miembro del grupo administrador de la nube de TI o del grupo administrador del sistema de TI debe asignarse al grupo administrador del laboratorio de TI.
- Se debe invitar a un administrador del sistema en otro inquilino de Active Directory como usuario invitado con permisos limitados.

#### Diagrama de la arquitectura

![[Pasted image 20240105123522.png]]

#### Objetivos

- **Tarea 1**: Crear y configurar usuarios de Microsoft Entra.
    - El usuario **AZ104-01a-aaduser1** será un administrador en la nube asignado al rol Administrador de usuarios.
    - El usuario **AZ104-01a-aaduser2** será administrador del sistema.
- **Tarea 2**: creación de grupos de AD con pertenencia asignada y dinámica.
    - El grupo **administrador en la nube de TI** debe asignarse al grupo administrador en la nube.
    - El grupo **administrador en el sistema de TI** debe incluir a cualquier usuario con el puesto de administrador del sistema.
    - El grupo **administrador del laboratorio de TI** debe incluir cualquier usuario en el grupo administrador de la nube de TI o en el grupo administrador del sistema de TI.
- **Tarea 3**: Cree un inquilino de Microsoft Entra. Este inquilino se usará para demostrar a los usuarios invitados.
- **Tarea 4**: Administrar usuarios invitados de Microsoft Entra.
    - En el nuevo inquilino de Microsoft Entra, cree un usuario administrador del sistema, **az104-01b-aaduser1**.
    - Invite al nuevo usuario como usuario invitado a su suscripción.

 Nota

Haga clic [aqui](https://mslabs.cloudguides.com/guides/AZ-104%20Exam%20Guide%20-%20Microsoft%20Azure%20Administrator%20Exercise%201) para iniciar la simulación de laboratorio. Cuando haya terminado, asegúrese de volver a esta página para continuar con el aprendizaje.

### Prueba de conocimiento

1. ¿Qué tipo de cuenta de usuario permite a una organización externa acceder a los recursos?

<details>
	<summary>Respuesta</summary>
	<p><b>Una cuenta de usuario invitado para cada miembro del equipo externo.</b> Una cuenta de usuario invitado restringe el acceso de los usuarios a únicamente el que necesitan.</p>
</details>

2. ¿Qué tipo de cuenta de grupo puede crear para que pueda aplicar los mismos permisos a todos los miembros del grupo?

<details>
	<summary>Respuesta</summary>
	<p>Puede crear un <b>grupo de seguridad</b> para una directiva de seguridad específica y aplicar los mismos permisos a todos los miembros del grupo.</p>
</details>

3. ¿Qué rol de Microsoft Entra permite a un usuario administrar todos los grupos en los inquilinos de Teams y asignar también otros roles de administrador?

<details>
	<summary>Respuesta</summary>
	<p>El rol <b>Administrador global</b> administra todos los aspectos de Microsoft Entra ID y los servicios de Microsoft que usan identidades de Microsoft Entra. Este rol puede administrar grupos entre inquilinos y asignar otros roles de administrador.</p>
</details>

### Resumen y recursos

Los administradores de Azure deben estar familiarizados con la configuración de cuentas de usuario y grupo en Microsoft Entra ID.

En este módulo, hemos aprendido que todos los usuarios que desean acceder a los recursos de Azure necesitan una cuenta de usuario de Azure. Microsoft Entra ID admite el acceso a los recursos de la organización mediante la asignación de derechos de acceso a usuarios y grupos. Ha descubierto cómo se crean las cuentas de usuario y grupo en Microsoft Entra ID. Ha explorado cómo configurar y administrar cuentas de usuario y grupo, incluida la configuración masiva. Ha revisado cómo puede admitir su organización la organización de cuentas de grupo y administrar cuentas en varios directorios.

Las principales conclusiones de este módulo son las siguientes:

- Microsoft Entra ID admite tres tipos de cuentas de usuario: identidades en la nube, identidades sincronizadas por directorios e identidades de usuario invitado.
    
- Las identidades en la nube tienen información de perfil, como el puesto de trabajo y la ubicación de la oficina. Esta información puede adaptarse a las necesidades de su organización.
    
- Puede crear de forma masiva cuentas de usuario y grupo. El proceso usa un archivo de plantilla administrado a través del portal.
    
- Hay dos tipos de cuentas de grupo: Seguridad y Microsoft 365.
    
- Las unidades administrativas le ayudan a controlar el acceso de administrador a los recursos.

#### Más información con la documentación de Azure

- [Documentación de la administración de usuarios empresariales](https://learn.microsoft.com/es-es/entra/identity/users/). Esta colección de artículos que tratan diversos temas relacionados con la autenticación de usuarios en Microsoft Entra. Aprenderá a usar grupos, nombres de dominio y licencias para administrar el acceso de los usuarios a aplicaciones y recursos3.
    
- [Administrar grupos y pertenencia a grupos de Microsoft Entra](https://learn.microsoft.com/es-es/entra/fundamentals/how-to-manage-groups). En este artículo se explica cómo crear, editar y eliminar grupos en Microsoft Entra. También aprenderá a agregar o quitar miembros y propietarios, asignar roles y usar reglas dinámicas para la pertenencia a grupos2.
    

#### Más información con el aprendizaje autodirigido

- [Administración de usuarios y grupos en Microsoft Entra ID](https://learn.microsoft.com/es-es/training/modules/manage-users-and-groups-in-aad/). En este módulo de entrenamiento se describen los principios básicos del usuario y los grupos.
    
- [Crear usuarios y grupos de Azure en Microsoft Entra ID (ejercicio, suscripción necesaria)](https://learn.microsoft.com/es-es/training/modules/create-users-and-groups-in-azure-active-directory/). En este módulo de aprendizaje se explica cómo crear usuarios y asignarlos a grupos.

## Configuración de suscripciones

### Introducción

En este módulo se proporciona información general sobre las suscripciones de Azure y su **importancia en la administración de costos** para las organizaciones.

Trabaja para una empresa multinacional que recientemente ha decidido migrar su infraestructura a la nube. Como parte de esta migración, se le ha encargado administrar los costos asociados a los recursos de Azure de la empresa. Debe comprender cómo funcionan las suscripciones de Azure y cómo pueden ayudarle a administrar y optimizar los costos de forma eficaz.

El objetivo de este módulo es dotarle de los conocimientos y aptitudes para **administrar correctamente las suscripciones de Azure y controlar los costos de su organización**. Aprenderá cómo funcionan las suscripciones de Azure y cómo usan las herramientas y técnicas de administración de costos. Optimice el uso de recursos, evite el gasto excesivo y tome decisiones fundamentadas para lograr el ahorro de costos.

#### Objetivos de aprendizaje

En este módulo aprenderemos a:

- Determinar la región correcta para buscar los servicios de Azure
    
- Revise las características y los casos de uso de las suscripciones de Azure.
    
- Obtener una suscripción de Azure.
    
- Comprender la facturación y las características de las distintas suscripciones de Azure
    
- Use Microsoft Cost Management and Billing para el análisis de costos.
    
- Descubra cuándo usar el etiquetado de recursos de Azure.
    
- Identificar formas de reducir los costos
    

#### Aptitudes evaluadas

El contenido del módulo le ayuda a prepararse para el [examen AZ-104: Administrador de Microsoft Azure](https://learn.microsoft.com/es-es/credentials/certifications/exams/az-104/).

#### Requisitos previos

- Familiaridad con la informática en la nube y los servicios en la nube de Azure.
- Familiaridad con los modelos de facturación de servicios en la nube y los métodos de suscripción.
- Familiaridad con técnicas de administración de costos, como informes y presupuestos.

### Identificación de regiones de Azure

Microsoft Azure está formado por centros de datos ubicados en todo el mundo. Estos centros de datos están organizados y se ponen a disposición de los usuarios finales por **región**. Una [región](https://azure.microsoft.com/global-infrastructure/regions/) **es un área geográfica del planeta que contiene al menos un centros de datos**, aunque podrían ser varios. Los centros de datos son cercanos y están conectados mediante una red de baja latencia. Algunos ejemplos de regiones son: Oeste de EE. UU., Centro de Canadá, Europa Occidental, Este de Australia y Japón Occidental.

#### Aspectos que conviene saber sobre las regiones

Estos son algunos puntos que tener en cuenta sobre las regiones:

- Azure está disponible con carácter general en más de 60 regiones en 140 países.
    
- Azure cuenta con más regiones globales que cualquier otro proveedor de nube.
    
- Las regiones le proporcionan la flexibilidad y la escala necesarias para acercar las aplicaciones a los usuarios.
    
- Las regiones conservan la residencia de los datos y ofrecen opciones completas de cumplimiento y resistencia para los clientes.
    

#### Aspectos que conviene saber sobre los pares de regiones

La mayoría de las regiones de Azure se emparejan con otra región dentro de la misma geografía para crear un _par regional_ (o _regiones emparejadas_). Los pares regionales ayudan a admitir la disponibilidad siempre activa de los recursos de Azure que usa la infraestructura. En la tabla siguiente se describen algunas características destacadas de las regiones emparejadas:

|Característica|Descripción|
|---|---|
|**Aislamiento físico**|Azure prefiere al menos 500 km (aproximadamente) de separación entre centros de datos en un par regional. Este principio no es práctico ni posible en todas las zonas geográficas. La separación del centro de datos físico reduce la probabilidad de que los desastres naturales, los disturbios civiles, los cortes del suministro eléctrico o las interrupciones de la red física afecten simultáneamente a ambas regiones.|
|**Replicación proporcionada por la plataforma**|Algunos servicios, como el almacenamiento con redundancia geográfica, proporcionan replicación automática a la región emparejada.|
|**Orden de recuperación de las regiones**|Durante una interrupción amplia, tiene prioridad la recuperación de una región de cada par. Se garantiza que, si las aplicaciones se implementan en regiones emparejadas, se dará prioridad a la recuperación de una de las regiones.|
|**Actualizaciones secuenciales**|Las actualizaciones del sistema de Azure que estén previstas se implementan en las regiones emparejadas de forma secuencial, no a la vez. La implementación gradual minimiza el tiempo de inactividad, los errores y los errores lógicos en el caso excepcional de que una actualización sea incorrecta.|
|**Residencia de datos**|Las regiones residen dentro de la misma geografía que su conjunto habilitado (excepto las de Sur de Brasil y Singapur).|


#### Aspectos que se deben tener en cuenta al usar regiones y pares regionales

Ha revisado las consideraciones importantes sobre las regiones y los pares regionales. Ahora piense en cómo puede implementar regiones en las organización.

- **Considere la posibilidad de implementar recursos y regiones**. Planee las regiones en las que quiera implementar los recursos. En la mayoría de los servicios de Azure, cuando implemente un recurso en Azure, elegirá la región en la que quiere que se implemente el recurso.
    
- **Considere la posibilidad de admitir el servicio por región**. Investigue la disponibilidad de regiones y servicios. Algunos servicios o características de Azure Virtual Machines solo están disponibles en determinadas regiones, por ejemplo, determinados tipos de almacenamiento o tamaños de Virtual Machines.
    
- **Considere los servicios que no necesitan regiones**. Identifique los servicios que no necesitan compatibilidad con regiones. Algunos servicios globales de Azure no requieren que se seleccione una región. Entre estos servicios se incluyen Microsoft Entra ID, Microsoft Azure Traffic Manager y Azure DNS.
    
- **Considere las excepciones al emparejamiento de regiones**. Compruebe el sitio web de Azure para ver la disponibilidad y las excepciones de la región actual. Si tiene previsto admitir la región Sur de Brasil, tenga en cuenta que está emparejada con una región fuera de su geografía. La región de Singapur también tiene una excepción al emparejamiento regional estándar.
    
- **Considere las ventajas de la residencia de datos**. Aproveche las ventajas de la residencia de datos que ofrecen los pares regionales. Esta característica puede ayudar a satisfacer los requisitos de cumplimiento y las obligaciones fiscales de cada jurisdicción.

#### Búsqueda de regiones para la geografía empresarial

Visite el sitio web de la infraestructura global de Azure para encontrar las regiones admitidas para la geografía empresarial. Puede buscar por nombre de país o región o por producto de Microsoft. También hay disponible una lista de pares de regiones y excepciones admitidos.

![[Pasted image 20240105132805.png]]


|Por geografía|Por producto|Regiones emparejadas|
|---|---|---|
|Busque [Regiones de Azure](https://azure.microsoft.com/global-infrastructure/geographies/#geographies) por geografía.|Busque [Productos de Azure](https://azure.microsoft.com/global-infrastructure/services/) por región o geografía.|Busque por [Regiones emparejadas](https://learn.microsoft.com/es-es/azure/best-practices-availability-paired-regions#azure-cross-region-replication-pairings-for-all-geographies) y excepciones.|
|[![Screenshot that shows how to search for available regions by geographic location.](https://learn.microsoft.com/es-es/training/wwl-azure/configure-subscriptions/media/regions-select-by-geography.png)](https://learn.microsoft.com/es-es/training/wwl-azure/configure-subscriptions/media/regions-select-by-geography-expanded.png#lightbox)|[![Screenshot that shows how to find products available according to region or geographic location.](https://learn.microsoft.com/es-es/training/wwl-azure/configure-subscriptions/media/regions-select-by-product.png)](https://learn.microsoft.com/es-es/training/wwl-azure/configure-subscriptions/media/regions-select-by-product-expanded.png#lightbox)|[![Screenshot that shows how to search for regional pairs.](https://learn.microsoft.com/es-es/training/wwl-azure/configure-subscriptions/media/search-region-pairs.png)](https://learn.microsoft.com/es-es/training/wwl-azure/configure-subscriptions/media/search-region-pairs-expanded.png#lightbox)|

### Implementación de suscripciones de Azure

Una suscripción de Azure **es una unidad lógica de servicios de Azure que está vinculada a una cuenta de Azure**. Una cuenta de Azure es una identidad en Microsoft Entra ID o en un directorio de confianza para Microsoft Entra ID, como una cuenta profesional o educativa. Las suscripciones le ayudan a organizar el acceso a los recursos de servicios en la nube de Azure y a controlar cómo se notifica, factura y paga el uso de recursos.

![[Pasted image 20240105133036.png]]

#### Aspectos que debe saber sobre las suscripciones

A medida que piense en las suscripciones que se van a implementar para la empresa, tenga en cuenta los puntos siguientes:

- Todos los servicios en la nube de Azure pertenecen a una suscripción.
    
- Cada suscripción puede tener una configuración de pago y facturación diferente.
    
- Se pueden vincular varias suscripciones a la misma cuenta de Azure.
    
- Se puede vincular más de una cuenta de Azure a la misma suscripción.
    
- La facturación de los servicios de Azure se realiza por suscripción.
    
- Si la cuenta de Azure es la única asociada a una suscripción, será responsable de los requisitos de facturación.
    
- Es posible que para las operaciones de programación para un servicio en la nube se necesite un identificador de suscripción.
    

#### Aspectos que se deben tener en cuenta al usar suscripciones

Tenga en cuenta cuántas suscripciones necesita la organización para admitir los escenarios empresariales. A medida que realice la planificación, piense en cómo puede organizar los recursos en grupos de recursos.

- **Considere los tipos de cuentas de Azure necesarias**. Determine los tipos de cuentas de Azure que los usuarios vincularán con las suscripciones de Azure. Puede usar una cuenta de Microsoft Entra o un directorio de confianza para Microsoft Entra ID como una cuenta profesional o educativa. Si usted no pertenece a ninguna de estas organizaciones, puede registrarse para obtener una cuenta de Azure con su cuenta de Microsoft, que también es de confianza para Microsoft Entra ID.
    
- **Considere la posibilidad de varias suscripciones**. Configure diferentes suscripciones y opciones de pago según los departamentos, proyectos, oficinas regionales de la empresa, etc. Un usuario puede tener más de una suscripción vinculada a su cuenta de Azure, donde cada suscripción pertenece a recursos, privilegios de acceso, límites y facturación para un proyecto específico.
    
- **Considere la posibilidad de usar una suscripción de servicios compartidos dedicada.** Planifique cómo los usuarios pueden compartir recursos asignados en una sola suscripción. Use una suscripción de servicios compartidos para garantizar que todos los recursos de red comunes se facturen juntos y se aíslen de otras cargas de trabajo. Entre los ejemplos de suscripciones de servicios compartidos se incluyen Azure ExpressRoute y Virtual WAN.
    
- **Considere el acceso a los recursos**. Cada suscripción de Azure se puede asociar a una instancia de Microsoft Entra ID. Los usuarios y los servicios se autentican con Microsoft Entra ID antes de acceder a los recursos.


### Obtención de una suscripción a Azure

Para usar Azure, debe tener una suscripción de Azure. Hay varias maneras de adquirir una suscripción de Azure. Puede obtener una suscripción de Azure como parte de un contrato Enterprise o mediante un revendedor o un partner de Microsoft. Los usuarios también pueden abrir una cuenta gratuita personal para obtener una suscripción de prueba.

#### Aspectos que debe saber sobre cómo obtener una suscripción de Azure

Revise las siguientes formas de obtener una suscripción de Azure y tenga en cuenta qué opciones funcionarían para la organización.

|Opción de adquisición|Descripción|
|---|---|
|![](https://learn.microsoft.com/es-es/training/wwl-azure/configure-subscriptions/media/enterprise-icon.png)|**Contrato Enterprise**  <br>  <br>Cualquier cliente con un [contrato Enterprise](https://azure.microsoft.com/pricing/enterprise-agreement/) puede agregar Azure a su contrato previo si establece de antemano un compromiso monetario con Azure. El compromiso se materializa a lo largo del año mediante cualquier combinación de los diversos servicios en la nube que ofrece Azure.|
|![](https://learn.microsoft.com/es-es/training/wwl-azure/configure-subscriptions/media/resellers-icon.png)|**Revendedor de Microsoft**  <br>  <br>Compre Azure mediante el [programa de licencia Open](https://www.microsoft.com/licensing/licensing-programs/open-license.aspx), que proporciona una manera sencilla y flexible de comprar servicios en la nube de su revendedor de Microsoft. Si ya ha comprado una clave de licencia de Azure bajo licencia Open, [active una nueva suscripción o agregue más créditos ahora](https://azure.microsoft.com/offers/ms-azr-0111p/).|
|![](https://learn.microsoft.com/es-es/training/wwl-azure/configure-subscriptions/media/partners-icon.png)|**Partner de Microsoft**  <br>  <br>Busque un [asociado de Microsoft](https://azure.microsoft.com/partners/directory/) que pueda diseñar e implementar la solución en la nube de Azure que le interese. Estos asociados cuentan con experiencia empresarial y tecnológica para recomendar soluciones que satisfagan las necesidades únicas de su negocio.|
|![](https://learn.microsoft.com/es-es/training/wwl-azure/configure-subscriptions/media/personal-icon.png)|**Cuenta gratuita personal**  <br>  <br>Cualquier usuario se puede suscribir a una [cuenta de prueba gratuita](https://azure.microsoft.com/free/). Puede empezar a usar Azure de inmediato y no se le cobrará hasta que decida actualizar.|

### Identificación del uso de la suscripción de Azure

Se han revisado las posibles formas de obtener una suscripción de Azure. Ahora se examinarán los tipos de suscripciones de Azure que están disponibles.

Azure ofrece opciones de suscripción gratuitas y de pago para satisfacer diferentes necesidades y requisitos. Las suscripciones más comunes son **Gratis**, **Pago por uso**, **Contrato Enterprise** y **Estudiante**. Para la organización, puede elegir una combinación de opciones de adquisición y de suscripción a fin de satisfacer los escenarios empresariales.

#### Aspectos que se deben tener en cuenta al elegir suscripciones de Azure

A medida que piense en qué tipos de suscripciones de Azure funcionarían para la organización, tenga en cuenta estos escenarios:

- **Considere la posibilidad de probar Azure de forma gratuita**. Una suscripción gratuita de Azure incluye un crédito monetario para gastar en cualquier servicio durante los primeros 30 días. Obtendrá acceso gratuito a los productos más populares de Azure durante 12 meses y acceso a más de 25 productos que siempre son gratuitos. La suscripción gratuita de Azure es una manera excelente de empezar para los nuevos usuarios.
    
    - Para configurar una suscripción gratuita, necesita un número de teléfono, una tarjeta de crédito y una cuenta de Microsoft.
    - La información de la tarjeta de crédito solo se usa para la verificación de identidad. No se le cobra por ningún servicio hasta que actualice a una suscripción de pago.
- **Considere la posibilidad de pagar mensualmente por los servicios usados**. Una suscripción de pago por uso (PAYG) carga mensualmente a su tarjeta los servicios que use durante ese período de facturación. Este tipo de suscripción es adecuado para una amplia variedad de usuarios, desde particulares y pequeñas empresas hasta organizaciones muy grandes.
    
- **Considere la posibilidad de usar un Contrato Enterprise de Azure**. Un Contrato Enterprise proporciona flexibilidad para comprar servicios en la nube y licencias de software bajo un contrato. El contrato incluye descuentos para nuevas licencias y Software Assurance. Este tipo de suscripción tiene como destino organizaciones de escala empresarial.
    
- **Considere la posibilidad de admitir Azure for Students**. Las suscripciones de Azure for Students incluyen un crédito monetario que se puede usar durante los primeros 12 meses.
    
    - Los alumnos pueden seleccionar servicios gratuitos sin tener que proporcionar una tarjeta de crédito durante el proceso de registro.
    - Debe comprobar su estado de estudiante mediante la dirección de correo electrónico profesional.

 Nota

Para obtener una lista completa de las opciones de suscripción de Azure, vea las [ofertas actuales de Microsoft Azure](https://azure.microsoft.com/support/legal/offer-details/).

### Implementación de Microsoft Cost Management

Con los productos y servicios de Azure, solo paga por lo que usa. A medida que cree y use recursos de Azure, se le cobrará por ellos.

Microsoft Cost Management proporciona compatibilidad con las tareas de facturación administrativa y le ayuda a administrar el acceso de facturación a los costos. También puede usar el producto para supervisar y controlar el gasto de Azure, y optimizar el uso de los recursos de Azure.

![[Pasted image 20240105134059.png]]

#### Aspectos que se deben conocer sobre Microsoft Cost Management

La organización está interesada en las ventajas de usar Microsoft Cost Management para supervisar la facturación de suscripción y el uso de recursos. A medida que planea la implementación, revisa las siguientes características del producto:

- Microsoft Cost Management muestras los costos de organización y los patrones de uso con análisis avanzados. Los costos dependen de los precios negociados y del factor de reserva y los descuentos de Ventaja híbrida de Azure. Los análisis predictivos también están disponibles.
    
- En los informes de Microsoft Cost Management se muestran los costos basados en el uso consumidos por los servicios de Azure y las ofertas de Marketplace de terceros. En conjunto, en los informes se muestran los costos internos y externos del uso y los cargos de Azure Marketplace. Los informes le ayudan a comprender los gastos y el uso de recursos, y pueden ayudar a identificar anomalías de gastos. Es posible que en los informes no sean visibles cargos como los de compras de reservas, soporte técnico e impuestos.
    
- El producto usa grupos de administración de Azure, presupuestos y recomendaciones para mostrar con claridad cómo se organizan los gastos y cómo se pueden reducir los costos.
    
- Puede usar Azure Portal o varias API para la automatización de la exportación, de manera que se integren los datos de costos con los procesos y sistemas externos. También están disponibles la exportación de datos de facturación automatizada y los informes programados.


#### Aspectos que se deben tener en cuenta al usar Microsoft Cost Management

Microsoft Cost Management puede ayudarle a planificar y controlar los costos de la organización. Tenga en cuenta cómo se pueden implementar las características del producto para admitir los escenarios empresariales:

- **Considere el análisis de costos**. Aproveche las características de análisis de costos de Microsoft Cost Management para explorar y analizar los costos de la organización. Puede ver los costos agregados por organización para saber dónde se acumulan e identificar las tendencias de gasto. Supervise los costos acumulados en el tiempo para estimar las tendencias de costos mensuales, trimestrales o incluso anuales con respecto a un presupuesto.
    
- **Considere las opciones de presupuesto**. Use las características de Microsoft Cost Management para establecer y mantener presupuestos. El producto le ayuda a planificar y cumplir con las responsabilidades financieras de la organización. Los presupuestos ayudan a evitar que se superen los umbrales o los límites de costos. Puede usar datos de análisis para informar a otros usuarios sobre sus gastos a fin de administrar los costos de forma proactiva. Las características presupuestarias le ayudan a ver cómo avanza el gasto de la empresa en el tiempo.
    
- **Considere las recomendaciones**. Revise las recomendaciones de Microsoft Cost Management para obtener información sobre cómo puede optimizar y mejorar la eficacia mediante la identificación de recursos inactivos e infrautilizados. Las recomendaciones pueden revelar opciones de recursos menos costosas. Al implementar las recomendaciones, puede cambiar la forma en que usa sus recursos para ahorrar dinero. El uso de recomendaciones es un proceso sencillo:
    
    1. Vea las recomendaciones de optimización de costos para identificar posibles deficiencias de uso.
    2. Actúe de acuerdo a una recomendación para modificar el uso del recurso de Azure e implementar una opción más rentable.
    3. Compruebe la nueva acción para asegurarse de que el cambio tiene el efecto deseado.
    
- **Considere la exportación de los datos de administración de costos**. Microsoft Cost Management le ayuda a trabajar con la información de facturación. Si usa los sistemas externos para acceder o revisar los datos de administración de costos, puede exportar los datos fácilmente desde Azure.
    
    - Establezca una exportación programada diariamente en formato de valores separados por comas (CSV) y almacene los archivos de datos en el almacenamiento de Azure.
    - Acceda a los datos exportados desde el sistema externo.

### Aplicación de etiquetas de recursos

Puede aplicar etiquetas a los recursos de Azure para organizarlos de forma lógica por categorías. Las etiquetas son útiles para ordenar, buscar, administrar y realizar análisis en los recursos.

Cada etiqueta de recurso se compone de un nombre y un valor. Podría tener el nombre de etiqueta `Server` y el valor `Production` o `Development`, y después aplicar el par etiqueta-valor a los recursos del equipo de ingeniería.

Este es un ejemplo en el que se muestra cómo agregar etiquetas para un grupo de recursos en Azure Portal:

![[Pasted image 20240105134748.png]]

#### Aspectos que debe saber sobre las etiquetas de recursos

A medida que planifique las suscripciones, los recursos y los servicios de Azure, revise estas características de las etiquetas de recursos de Azure:

- Cada etiqueta de recurso tiene un nombre y un valor.
    
- El nombre de la etiqueta permanece constante para todos los recursos que tienen aplicada la etiqueta.
    
- El valor de la etiqueta se puede seleccionar a partir de un conjunto definido de valores, o bien puede ser único para una instancia de recurso específica.
    
- Un recurso o un grupo de recursos puede tener un máximo de 50 pares nombre-valor de etiqueta.
    
- Los recursos del grupo no heredan las etiquetas aplicadas al grupo de recursos.
    

#### Aspectos que se deben tener en cuenta al usar etiquetas de recursos

Estas son algunas cosas que puede hacer con las etiquetas de recursos:

- **Considere la posibilidad de buscar por datos de etiquetas**. Consulte el nombre y el valor de la etiqueta para buscar recursos en la suscripción.
    
- **Considere la posibilidad de buscar recursos relacionados**. Recupere los recursos relacionados de otros grupos de recursos mediante la búsqueda por el nombre o el valor de la etiqueta.
    
- **Considere la posibilidad de agrupar los datos de facturación**. Agrupe recursos como máquinas virtuales por centro de costos y entorno de producción. Al descargar el archivo de valores separados por comas (CSV) de uso de recursos para los servicios, las etiquetas aparecen en la columna `Tags`.
    
- **Considere la posibilidad de crear etiquetas con PowerShell o la CLI de Azure**. Cree muchas etiquetas de recursos mediante programación con Azure PowerShell o la CLI de Azure.

#### Cómo mantener la suscripción de Azure limpia



### Ahorro de gastos

Azure tiene varias opciones que pueden ayudarle a ahorrar costos significativos para la organización. A medida que prepara el plan de implementación para suscripciones, servicios y recursos de Azure, tenga en cuenta las siguientes ventajas de ahorro de costos.

|Ahorro de costos|Descripción|
|---|---|
|**Reservas**|Ahorre dinero pagando por adelantado. Puede pagar uno o tres años de máquina virtual, capacidad de proceso de SQL Database, rendimiento de Azure Cosmos DB u otros recursos de Azure. El pago adelantado le permite obtener un descuento en los recursos que utiliza. Reservations puede reducir considerablemente los costos en máquinas virtuales, capacidad de proceso de SQL Database, Azure Cosmos DB u otros recursos en hasta un 72 % en precios de pago por uso. Reservations ofrece un descuento en la facturación y no afecta al estado del entorno de ejecución de los recursos.|
|**Ventajas híbridas de Azure**|Acceda a las ventajas de precios si tiene una licencia que incluya _Software Assurance_. Con la Ventaja híbrida de Azure, podrá maximizar el valor de las inversiones en licencias existentes de Windows Server o SQL Server al migrar a Azure. La Calculadora de ahorros de la Ventaja híbrida de Azure le ayudará a determinar el ahorro.|
|**Créditos de Azure**|Use la ventaja de crédito mensual para desarrollar, probar y experimentar con nuevas soluciones en Azure. Como suscriptor de Visual Studio, podría usar Microsoft Azure sin cargo adicional. Con el crédito de Azure mensual, dispone de Azure como espacio aislado personal para el desarrollo y las pruebas.|
|**Regiones de Azure**|Compare los precios entre regiones. Los precios pueden variar de una región a otra, incluso en Estados Unidos. Compruebe los precios en varias regiones para ver si puede ahorrar al seleccionar otra región para la suscripción.|
|**Budgets**|Aplique las características presupuestarias de Microsoft Cost Management para ayudar a planificar y promover la responsabilidad de la organización. Con presupuestos, puede tener en cuenta los servicios de Azure que consume o a los que se suscribe durante un período específico. Supervise el gasto en el tiempo e informe a otros sobre sus gastos para administrar de forma proactiva los costos. Use presupuestos para comparar y realizar el seguimiento del gasto mientras analiza los costos.|
|**Calculadora de precios**|La [Calculadora de precios](https://azure.microsoft.com/pricing/calculator/) proporciona estimaciones en todas las áreas de Azure, incluidas las de procesos, redes, almacenamiento, sitios web y bases de datos.|

En la imagen siguiente se muestra un escenario para usar la Calculadora de precios. El cliente tiene una instancia de una máquina virtual de la serie D1 en Windows. La instancia se ejecuta en la región Oeste de EE. UU. en el nivel estándar.

![[Pasted image 20240105135107.png]]


### Prueba de conocimiento

1. El controlador financiero de la empresa quiere recibir una notificación cada vez que la empresa esté a medio camino de gastar el dinero asignado a los servicios en la nube. ¿Qué enfoque admite esta solicitud?

<details>
	<summary>Respuesta</summary>
	<p><b>Crear un presupuesto y un umbral de gasto.</b> Las alertas de facturación ayudan a supervisar y administrar la actividad de facturación de las cuentas de Azure. Los umbrales de presupuesto se pueden evaluar y se restablecen automáticamente al final de un período.</p>
</details>

2. El controlador financiero de la empresa quiere identificar a qué departamento de facturación pertenece cada recurso de Azure. ¿Qué enfoque habilita este requisito?

<details>
	<summary>Respuesta</summary>
	<p><b>Usar una etiqueta en cada recurso que incluya el departamento de facturación asociado</b> Las etiquetas proporcionan información extra, o metadatos, sobre los recursos. El equipo podría crear una etiqueta denominada `BillingDept`, donde el valor es el nombre del departamento de facturación. Azure Policy garantiza que se asignan las etiquetas adecuadas cuando se aprovisionan recursos.</p>
</details>

3. ¿Qué opción conserva la residencia de datos y ofrece opciones completas de cumplimiento y resistencia?

<details>
	<summary>Respuesta</summary>
	<p><b>Las regiones</b> conservan la residencia de datos y ofrecen opciones completas de cumplimiento y resistencia para los clientes.</p>
</details>

### Resumen y recursos

Los administradores de Azure suelen obtener y administrar suscripciones de Azure. Las suscripciones de Azure le ayudan a identificar y administrar eficazmente los costos de la organización, a fin de que pueda proporcionar servicios y recursos para escenarios específicos.

En este módulo, hemos obtenido información sobre las regiones de Azure admitidas y cómo localizar los servicios de Azure. También sobre las características y los casos de uso de las suscripciones de Azure y cómo obtener suscripciones. Hemos explorado las características y la facturación de los diferentes tipos de suscripciones de Azure y cómo aplicar el etiquetado de recursos. Hemos descubierto cómo se puede usar Microsoft Cost Management para el análisis de costos. Hemos aprendido a identificar formas de reducir los costos de facturación.

Las principales conclusiones de este módulo son:

- Las regiones de Azure proporcionan flexibilidad, residencia de datos, cumplimiento y opciones de resistencia.
    
- Las suscripciones de Azure son esenciales para administrar el acceso a los recursos y la facturación de Azure.
    
- Azure ofrece varias opciones de suscripción, como Gratis, Pago por uso, Contrato Enterprise y Estudiante.
    
- Azure ofrece opciones de ahorro de costos, como reservas, ventajas híbridas de Azure y créditos de Azure.
    
- El etiquetado de recursos permite organizar y analizar recursos en Azure.
    
- Microsoft Cost Management ayuda a supervisar y controlar los gastos de Azure.
    
- La calculadora de precios proporciona estimaciones de facturación para distintos casos de uso.
    

#### Más información con la documentación de Azure

- [Cost Management](https://learn.microsoft.com/es-es/azure/cost-management-billing/#cost-management). En esta colección de artículos se tratan los precios, los informes, los análisis, la supervisión y la optimización de los costos.
    
- [Administración de facturas y suscripciones](https://learn.microsoft.com/es-es/azure/cost-management-billing/#billing---subscriptions). En esta colección de artículos se tratan la administración de cuenta, las suscripciones, las facturas y los pagos.
    
- [Calculadora de precios](https://azure.microsoft.com/pricing/calculator/). Esta herramienta calcula los costos por mes u hora del uso de Azure.
    

#### Más información con el aprendizaje autodirigido

- [Control del gasto de Azure y administración de facturas con Microsoft Cost Management y Facturación](https://learn.microsoft.com/es-es/training/paths/control-spending-manage-bills/). Aprenda a supervisar y controlar el gasto de Azure y a optimizar el uso de los recursos de Azure.
    
- [Introducción al análisis de costos y creación de presupuestos con Microsoft Cost Management (ejercicio, suscripción necesaria)](https://learn.microsoft.com/es-es/training/modules/analyze-costs-create-budgets-azure-cost-management/). Obtenga más información sobre cómo usar el análisis de costos para comprender cómo estos se acumulan cada mes. Use este conocimiento para crear un presupuesto de Azure para supervisar los costos y crear alertas al respecto.
    
- [Descripción de la administración de costos en Azure (ejercicio, suscripción necesaria)](https://learn.microsoft.com/es-es/training/modules/describe-cost-management-azure/). Explore los métodos para calcular, realizar un seguimiento y administrar los costos en Azure.

## Configuración de Azure Policy

### Introducción

[Azure Policy](https://azure.microsoft.com/services/azure-policy/) es un servicio de Azure que **permite crear, asignar y administrar directivas para controlar o auditar recursos**. Dichas directivas aplican distintas reglas a las configuraciones de los recursos de modo que estas configuraciones sigan cumpliendo con los estándares corporativos.

Su empresa está sujeta a muchas regulaciones y reglas de cumplimiento. La empresa quiere asegurarse de que cada departamento implementa los recursos correctamente. Es responsable de investigar cómo usar Azure Policy y grupos de administración para implementar medidas de cumplimiento.

En este módulo, aprenderemos a implementar directivas de Azure. El contenido incluye ejemplos de definiciones de directiva y de iniciativa. Aprenderá a definir el ámbito de las directivas y a los recursos no conformes de identidad. También aprenderá las ventajas y el uso de los grupos de administración.

El objetivo de este módulo es garantizar que los administradores puedan utilizar la directiva de Azure para garantizar el cumplimiento de los recursos.

#### Objetivos de aprendizaje

En este módulo aprenderemos a:

- Implementar Azure Policy con definiciones de directivas e iniciativas.
    
- Definir el ámbito de las directivas de Azure y determinar el cumplimiento.
    
- Crear grupos de administración destinados a directivas y presupuestos de gastos.
    

#### Aptitudes evaluadas

El contenido del módulo le ayuda a prepararse para el [examen AZ-104: Administrador de Microsoft Azure](https://learn.microsoft.com/es-es/certifications/exams/az-104).

#### Requisitos previos

- Conocimientos básicos de los conceptos de Azure, como suscripciones, grupos de recursos y recursos.
- Conocimientos prácticos de los conceptos de gobernanza, como el cumplimiento y los informes.
- Familiaridad con Azure Resource Manager y cómo usarlo para implementar y administrar recursos.
- Conocimiento de la sintaxis JSON para poder crear definiciones de directiva y asignaciones de directivas.

### Creación de grupos de administración

Las organizaciones que usan varias suscripciones necesitan una manera eficaz de administrar el acceso, las directivas y el cumplimiento. [Los grupos de administración de Azure](https://learn.microsoft.com/es-es/azure/governance/management-groups/overview) ofrecen un nivel de ámbito y control que está por encima de las suscripciones. Puede usar grupos de administración como contenedores para administrar el acceso, la directiva y el cumplimiento en todas las suscripciones.

#### Aspectos que debe saber sobre los grupos de administración

Tenga en cuenta las características siguientes de los grupos de administración de Azure:

- De manera predeterminada, todas las suscripciones nuevas se colocan en el grupo de administración de nivel superior o _grupo raíz_.
    
- Todas las suscripciones dentro de un grupo de administración heredan automáticamente las condiciones aplicadas a ese grupo de administración.
    
- Un árbol de grupo de administración puede admitir hasta seis niveles de profundidad.
    
- La autorización de control de acceso basado en rol de Azure para las operaciones del grupo de administración no está habilitada de manera predeterminada.
    

En el diagrama siguiente se muestra cómo se pueden usar los grupos de administración de Azure para organizar las suscripciones en una jerarquía de administración unificada de directivas y acceso. En este escenario, la organización tiene un único grupo de administración de nivel superior. Todos los directorios del grupo raíz se contraen en el grupo de nivel superior.

![[Pasted image 20240105184334.png]]

#### Aspectos que se deben tener en cuenta al usar grupos de administración

Revise las siguientes formas de usar grupos de administración en Azure Policy para administrar las suscripciones:

- **Considere las jerarquías y grupos personalizados**. Alinee las suscripciones de Azure mediante jerarquías personalizadas y agrupaciones que satisfagan la estructura organizativa y los escenarios empresariales de la empresa. Puede usar grupos de administración para dirigirse a directivas y presupuestos de gasto entre suscripciones.
    
- **Considere la herencia de directivas**. Controle la herencia jerárquica de acceso y privilegios en las definiciones de directiva. Todas las suscripciones dentro de un grupo de administración heredan las condiciones que se aplican al grupo de administración. Puede aplicar directivas a un grupo de administración para limitar las regiones disponibles para crear máquinas virtuales (VM). La directiva se puede aplicar a todos los grupos de administración, suscripciones y recursos del grupo de administración inicial, para asegurarse de que las máquinas virtuales solo se crean en las regiones especificadas.
    
- **Considere las reglas de cumplimiento**. Organice las suscripciones en grupos de administración para ayudar a satisfacer las reglas de cumplimiento de departamentos y equipos individuales.
    
- **Considere los informes de costos**. Use grupos de administración para realizar informes de costos por departamento o para escenarios empresariales específicos. Puede usar grupos de administración para informar sobre los detalles presupuestarios entre suscripciones.


#### Creación de grupos de administración

Puede crear un grupo de administración con Azure Policy mediante Azure Portal, PowerShell o la CLI de Azure. Este es un ejemplo de lo que verá en Azure Portal:

![[Pasted image 20240105184609.png]]

Un grupo de administración tiene un identificador (id.) único de directorio y un nombre para mostrar. El id. se usa para enviar comandos en el grupo de administración. El valor del id. no se puede cambiar después de crearlo porque se usa en todo el sistema de Azure para identificar el grupo de administración. El nombre para mostrar del grupo de administración es opcional y se puede cambiar en cualquier momento.

### Implementación de directivas de Azure


Azure Policy es un servicio de Azure que se usa para crear, asignar y administrar directivas. Puede usar directivas para aplicar reglas en los recursos a fin de cumplir los estándares de cumplimiento corporativo y los contratos de nivel de servicio. Azure Policy ejecuta evaluaciones y exámenes en los recursos para asegurarse de que son compatibles.

#### Aspectos que debe saber sobre Azure Policy

Las ventajas principales de Azure Policy se encuentran en las áreas de aplicación y cumplimiento, escalado y corrección. Azure Policy también es importante para los equipos que ejecutan un entorno en el que se necesitan diferentes formas de gobernanza.

|Ventaja|Descripción|
|---|---|
|**Aplicación de reglas y cumplimiento**|Habilite directivas integradas, o bien cree directivas personalizadas para todos los tipos de recursos. Admita la evaluación y aplicación de directivas en tiempo real y la evaluación periódica o a petición del cumplimiento.|
|**Aplicación de directivas a gran escala**|Aplicar directivas a un grupo de administración con control en toda la organización. Aplique varias directivas y agregue estados de directiva con la iniciativa de directiva. Defina un ámbito de exclusión.|
|**Corrección**|Realice la corrección en tiempo real y en los recursos existentes.|
|**Ejercicio de la gobernanza**|Implemente tareas de gobernanza para el entorno:  <br>- Admita varios equipos de ingeniería (implementación y funcionamiento en el entorno)  <br>- Administre varias suscripciones  <br>- Estandarice y aplique la configuración de los recursos en la nube  <br>- Administre el cumplimiento normativo, el control de costos, la seguridad y la coherencia de diseño|


#### Aspectos que se deben tener en cuenta al usar Azure Policy

Revise los escenarios siguientes para usar Azure Policy. Tenga en cuenta cómo puede implementar el servicio en la organización.

- **Considere la posibilidad de implementar recursos**. Especifique los tipos de recursos que la organización puede implementar mediante Azure Policy. Puede especificar un conjunto de SKU de máquina virtual que la organización puede implementar.
    
- **Considere las restricciones de ubicación**. Limite las ubicaciones que los usuarios pueden especificar al implementar los recursos. Puede elegir las ubicaciones geográficas o las regiones que están disponibles para la organización.
    
- **Considere la posibilidad de aplicar reglas**. Aplique reglas de cumplimiento y opciones de configuración para ayudar a administrar los recursos y las opciones de usuario. Puede aplicar una etiqueta obligatoria en los recursos y definir los valores permitidos.
    
- **Considere la posibilidad de realizar auditorías de inventario**. Use Azure Policy con el servicio Azure Backup en las máquinas virtuales y ejecute auditorías de inventario.

### Creación de directivas de Azure

Los administradores de Azure usan Azure Policy para crear directivas que definan convenciones para los recursos. Una _definición de directiva_ describe las condiciones de cumplimiento de un recurso y las acciones que se deben completar cuando se cumplen las condiciones. Una o varias definiciones de directiva se agrupan en una _definición de iniciativa_, para controlar el ámbito de las directivas y evaluar el cumplimiento de los recursos.

![Diagram that shows an initiative definition for a group of policy definitions that are applied to resources.](https://learn.microsoft.com/es-es/training/wwl-azure/configure-azure-policy/media/implement-azure-policy-b4a4a47c.png)

Hay cuatro pasos básicos para crear y trabajar con definiciones de directiva en Azure Policy.

#### Paso 1: Creación de definiciones de directiva

Una definición de directiva expresa una condición para evaluar y las acciones que se deben realizar cuando se cumple la condición. Puede crear definiciones de directiva propias, o bien elegir entre definiciones integradas en Azure Policy. Puede crear una definición de directiva para evitar que las máquinas virtuales de la organización se implementen, si se exponen a una dirección IP pública.

#### Paso 2: Creación de una definición de iniciativa

Una definición de iniciativa es un conjunto de definiciones de directiva que facilita el seguimiento del estado de cumplimiento del recurso para satisfacer un objetivo mayor. Puede crear definiciones de iniciativa propias, o bien usar las definiciones integradas en Azure Policy. Puede usar una definición de iniciativa para asegurarse de que los recursos cumplen las normativas de seguridad.

#### Paso 3: Ámbito de la definición de iniciativa

Azure Policy le permite controlar cómo se aplican las definiciones de iniciativa a los recursos de la organización. Puede limitar el ámbito de una definición de iniciativa a grupos de administración, suscripciones o grupos de recursos concretos.

#### Paso 4: Determinación del cumplimiento

Una vez que se asigna una definición de iniciativa, puede evaluar el estado de cumplimiento de todos los recursos. Los recursos individuales, los grupos de recursos y las suscripciones de un ámbito se pueden excluir del efecto de las reglas de directiva. Las exclusiones se controlan individualmente para cada asignación.

### Creación de definiciones de directiva


Azure Policy ofrece definiciones de directivas integradas para ayudarle a configurar rápidamente las condiciones de control de los recursos. Además de las directivas integradas, también puede crear definiciones propias o importarlas desde otros orígenes.

#### Acceso a definiciones de directiva integradas

Puede ordenar la [lista de definiciones integradas](https://learn.microsoft.com/es-es/azure/governance/policy/samples/built-in-policies) por categoría para buscar directivas que satisfagan las necesidades empresariales.

![[Pasted image 20240105190001.png]]

Estos son algunos ejemplos de definiciones de directivas integradas:

- **SKU de tamaño de máquina virtual permitidas**: se especifica un conjunto de SKU de tamaño de máquina virtual que la organización puede implementar. Esta directiva se encuentra en la categoría Proceso.
    
- **Ubicaciones permitidas**: se restringen las ubicaciones que los usuarios pueden especificar al implementar los recursos. Use esta directiva para aplicar los requisitos de cumplimiento de replicación geográfica. Esta directiva se encuentra en la categoría General.
    
- **Configurar cuentas de Azure Device Update for IoT Hub para deshabilitar el acceso a la red pública**: se deshabilita el acceso a la red pública para recursos de Device Update for IoT Hub. Esta directiva se encuentra en la categoría Internet de las cosas.

#### Adición de nuevas definiciones de directiva

Si no encuentra una directiva integrada que satisfaga las necesidades empresariales, puede agregar una definición o crearla. Las definiciones de directiva también se pueden importar en Azure Policy desde [GitHub](https://github.com/Azure/azure-policy/tree/master/samples). Las nuevas definiciones de directiva se agregan al repositorio de ejemplos casi a diario.

![Screenshot that shows how to add a new policy definition, and the option to import a sample policy definition from GitHub.](https://learn.microsoft.com/es-es/training/wwl-azure/configure-azure-policy/media/new-policy-definition-46cb3ecb.png)

 Nota

Al agregar o crear una definición de iniciativa, asegúrese de que la definición usa el formato JSON específico necesario para Azure. Para más información, vea [Estructura de definiciones de Azure Policy](https://learn.microsoft.com/es-es/azure/governance/policy/concepts/definition-structure).

### Creación de una definición de iniciativa

Después de determinar las definiciones de directiva, el siguiente paso consiste en crear una definición de iniciativa para las directivas. Una definición de iniciativa tiene una o varias definiciones de directiva. Un ejemplo de uso de definiciones de iniciativa es asegurarse de que los recursos cumplen las normativas de seguridad.

 Sugerencia

Incluso si solo tiene algunas definiciones de directiva en la organización, se recomienda crear y aplicar una definición de iniciativa.

#### Adición de una nueva definición de iniciativa

Al crear una definición de iniciativa, asegúrese de que la definición usa el formato JSON específico requerido por Azure. Para más información, vea [Estructura de la definición de iniciativa de Azure Policy](https://learn.microsoft.com/es-es/azure/governance/policy/concepts/initiative-definition-structure).

Este es un ejemplo de cómo crear una definición de iniciativa en Azure Portal:

![[Pasted image 20240105190510.png]]

#### Uso de una definición de iniciativa integrada

Puede crear definiciones de iniciativa propias, o bien usar las definiciones integradas en Azure Policy. Puede ordenar la [lista de iniciativas integradas](https://learn.microsoft.com/es-es/azure/governance/policy/samples/built-in-initiatives) por categoría a fin de buscar definiciones para la organización.

Estos son algunos ejemplos de definiciones de iniciativa integradas:

- **Auditar las máquinas con configuración de seguridad de contraseña no segura**: use esta iniciativa para implementar una directiva de auditoría en los recursos especificados de la organización. La definición evalúa los recursos para comprobar si hay una configuración de seguridad de contraseña no segura. Esta iniciativa se encuentra en la categoría Configuración de invitado.
    
- **Configurar máquinas Windows para ejecutar el agente de Azure Monitor y asociarlas a una regla de recopilación de datos**: use esta iniciativa para supervisar y proteger las máquinas virtuales Windows, los conjuntos de escalado de máquinas virtuales y las máquinas de Arc. La definición implementa la extensión Agente de Azure Monitor y asocia los recursos a una regla de recopilación de datos especificada. Esta iniciativa se encuentra en la categoría Supervisión.
    
- **Configuración de Azure Defender para habilitarlo en servidores SQL**: habilite Azure Defender en las instancias de Azure SQL Server para detectar actividades anómalas que indiquen intentos inusuales y potencialmente peligrosos de acceder a las bases de datos o aprovechar sus vulnerabilidades de seguridad. Esta iniciativa se encuentra en la categoría SQL.

### Ámbito de la definición de iniciativa

Después de crear la definición de la iniciativa, el siguiente paso consiste en asignar la iniciativa para establecer el ámbito de las directivas. El ámbito determina qué recursos o agrupación de recursos se ven afectados por las condiciones de las directivas.

Este es un ejemplo en el que se muestra cómo configurar la asignación del ámbito:

![Screenshot that shows how to assign an initiative definition to resources or groups or resources to establish the scope.](https://learn.microsoft.com/es-es/training/wwl-azure/configure-azure-policy/media/assign-definition-87bc203c.png)

Para establecer el ámbito, seleccione las suscripciones afectadas. Como opción, también puede elegir los grupos de recursos afectados.

En el ejemplo siguiente se muestra cómo aplicar el ámbito:

![Screenshot that shows how a scope is applied to a subscription, and optionally applied to a resource group.](https://learn.microsoft.com/es-es/training/wwl-azure/configure-azure-policy/media/scope-initiative-9fbf59d5.png)


### Determinación del cumplimiento

Ha definido las directivas, ha creado la definición de iniciativa y ha asignado las directivas a los recursos afectados. El último paso consiste en evaluar el estado de cumplimiento de los recursos con ámbito.

En el ejemplo siguiente se muestra cómo puede usar la característica **Cumplimiento** para buscar iniciativas, directivas y recursos no compatibles.

![Screenshot that shows how to use the compliance feature to look for non-compliant initiatives, policies, and resources.](https://learn.microsoft.com/es-es/training/wwl-azure/configure-azure-policy/media/determine-compliance-c198f4ba.png)

Las condiciones de la directiva se evalúan en función de los recursos con ámbito existentes. Aunque en Azure Portal no se muestra la lógica de evaluación, se muestran los resultados del estado de cumplimiento. El resultado del estado de cumplimiento puede ser compatible o no compatible.

### Simulación interactiva de laboratorio: Manage governance via Azure Policy


#### Escenario del laboratorio

Su organización está pilotando un nuevo proyecto de infraestructura. El director de tecnología quiere saber qué recursos de Azure se usan en el nuevo proyecto. Sus tareas específicas son:

- Cree una manera de etiquetar los recursos del proyecto.
- No permitir crear recursos sin la etiqueta de recurso.
- Si se crea un recurso sin la etiqueta, agregue automáticamente la etiqueta.

#### Diagrama de la arquitectura

![[Pasted image 20240108094111.png]]


#### Objetivos

- **Tarea 1**: crear y asignar etiquetas a través de Azure Portal.
    - Con fines de prueba, identifique el grupo de recursos Cloud Shell.
    - Agregue una etiqueta al grupo de recursos. Asigne el valor de la etiqueta.
    - Compruebe que la cuenta de almacenamiento del grupo de recursos no tiene la etiqueta.
- **Tarea 2**: exija el etiquetado a través de Azure Policy.
    - Localice la directiva integrada **Requerir una etiqueta y su valor en los recursos** y revise la definición.
    - Asigne la directiva al grupo de recursos.
    - Configure la etiqueta requerida: **Rol** con un valor de **Infra**.
    - Cree una nueva cuenta de almacenamiento en el grupo de recursos y compruebe sin la etiqueta que no puede crear el recurso.
- **Tarea 3**: aplique automáticamente el etiquetado mediante una directiva de Azure.
    - Asigne la **etiqueta Heredar una etiqueta del grupo de recursos si falta** la directiva integrada al grupo de recursos.
    - Configure la corrección para agregar automáticamente la etiqueta **Rol** si falta en un nuevo recurso.
    - Cree una nueva cuenta de almacenamiento y compruebe que se agregan la etiqueta y el valor.



Click al siguiente link para acceder a [Manage governance via Azure Policy](https://mslabs.cloudguides.com/guides/AZ-104%20Exam%20Guide%20-%20Microsoft%20Azure%20Administrator%20Exercise%203)

### Prueba de Conocimiento

La empresa va a implementar Azure Policy para administrar la gobernanza en varias suscripciones de Azure. Va a explorar cómo usar directivas, iniciativas y definiciones de Azure para los distintos departamentos. Va a investigar cómo los grupos de administración pueden admitir los escenarios empresariales.

El equipo financiero solicita que los recursos y la facturación se clasifiquen por departamento, por ejemplo, Marketing, Investigación y Recursos Humanos. Les gustaría que la facturación se consolidara en varios grupos de recursos para asegurarse de que todos los usuarios cumplen la solución.

#### Responda a las siguientes preguntas

1. Hay varias directivas de Azure que deben aplicarse a una sucursal nueva. Enfoque óptimo

<details>
	<summary>Respuesta</summary>
	<p><b>Crear una iniciativa de directiva.</b> Una iniciativa de directiva es un conjunto de definiciones de directiva que se podrían aplicar a la sucursal nueva.</p>
</details>

2. Para satisfacer la solicitud del equipo financiero de facturación por departamento, se han creado varios grupos de recursos y se han aplicado las etiquetas de recursos. ¿Cuál es el paso siguiente?

<details>
	<summary>Respuesta</summary>
	<p><b>Crear una directiva de Azure.</b> Una directiva de Azure necesite que se aplique una etiqueta de recurso antes de crear el recurso.</p>
</details>

3. ¿Cómo asegurarse de que solo se implementan tamaños de SKU de máquina virtual rentables?

<details>
	<summary>Respuesta</summary>
	<p><b>Crear una directiva en Azure Policy que especifique los tamaños de SKU permitidos.</b> Hay una directiva de Azure integrada para especificar los tamaños de SKU de máquina virtual permitidos. Una vez que se habilita la directiva, se aplica siempre que se cree o se cambie el tamaño de una máquina virtual</p>
</details>

4. ¿Qué opción puede usar para administrar la gobernanza en varias suscripciones de Azure?

<details>
	<summary>Respuesta</summary>
	<p>Los <b>grupos de administración</b> facilitan la ordenación jerárquica de los recursos de Azure en colecciones, en un nivel de ámbito superior al de las suscripciones. Mediante Azure Policy y los controles de acceso basado en roles de Azure, se pueden aplicar condiciones de gobernanza distintas a cada grupo de administración para administrar las suscripciones de Azure de forma eficaz. Los recursos y las suscripciones asignados a un grupo de administración heredan automáticamente las condiciones que se aplican al grupo de administración.</p>
</details>

### Resumen y recursos

Azure Policy es un servicio de Azure que permite crear, asignar y administrar directivas. Azure Policy le ayuda a definir e implementar la estrategia de gobernanza mediante directivas para controlar y auditar los recursos.

En este módulo, hemos aprendido sobre Azure Policy y cómo nos permite controlar y auditar los recursos. Hemos explorado cómo implementar definiciones e iniciativas de directivas de Azure para los departamentos corporativos. Hemos aprendido a crear grupos de administración, directivas de ámbito y a administrar presupuestos de gasto. Hemos revisado el ámbito de las directivas de Azure para cumplir las normativas de cumplimiento.

Las principales conclusiones de este módulo son:

- Azure Policy es un servicio eficaz de Azure que le permite aplicar reglas y garantizar el cumplimiento de los estándares corporativos y los contratos de nivel de servicio.
- Los grupos de administración proporcionan una manera de administrar de forma eficaz el acceso, las directivas y el cumplimiento en varias suscripciones, lo que permite administrar directivas y acceso de manera unificada.
- La creación de definiciones de directivas y de iniciativas permite definir convenciones para los recursos y controlar el ámbito de las directivas, lo que garantiza el cumplimiento de los recursos.
- La característica Cumplimiento de Azure Policy le ayuda a determinar el estado de los recursos y evaluar si son compatibles o no.

#### Más información con la documentación de Azure

- [Documentación de Azure Policy](https://learn.microsoft.com/es-es/azure/governance/policy/). Esta colección de artículos es el punto de partida de todo lo relacionado con Azure Policy.
    
- [Definiciones de directiva integradas de Azure Policy](https://learn.microsoft.com/es-es/azure/governance/policy/samples/built-in-policies). Esta página es un índice de las definiciones de directiva integradas de Azure Policy.
    
- [iniciativas de directivas integradas de Azure](https://learn.microsoft.com/es-es/azure/governance/policy/samples/built-in-initiatives). Esta página es un índice de las definiciones de iniciativa integradas de Azure Policy.
    
- [Inicio rápido: Creación de una asignación de directivas para identificar recursos no compatibles](https://learn.microsoft.com/es-es/azure/governance/policy/assign-policy-portal). Esta guía de inicio rápido lo guiará por el proceso de creación de una asignación de directiva para identificar las máquinas virtuales que no están usando discos administrados.
    

#### Más información con el aprendizaje autodirigido

- [Introducción a Azure Policy](https://learn.microsoft.com/es-es/training/modules/intro-to-azure-policy/). En este módulo, se ofrece una introducción a Azure Policy y se describen sus características, funcionalidades y casos de uso.


## Configuración del control de acceso basado en rol

### Introducción

Los administradores de Azure necesitan proteger el acceso a sus recursos de Azure, como máquinas virtuales (VM), sitios web, redes y almacenamiento. Los administradores necesitan mecanismos para ayudarles a administrar quién puede acceder a sus recursos y qué acciones se permiten. Las organizaciones que hacen negocios en la nube reconocen que proteger sus recursos es una función crítica de su infraestructura.

En este módulo, su empresa está investigando cómo asegurarse de que sus datos y recursos corporativos están protegidos. Quieren una protección segura que les permita controlar el acceso a sus datos y recursos mediante la especificación de roles y privilegios de acceso para empleados y asociados comerciales. Es responsable de investigar cómo usar el control de acceso basado en rol (RBAC) para realizar estas tareas. Debe asegurarse de que los recursos de la empresa están protegidos y también admitir el acceso de los usuarios a los recursos.

El objetivo de este módulo es comprender las características y los casos de uso del control de acceso basado en roles (RBAC) de Azure. Ha descubierto cómo crear definiciones de roles y asignaciones de roles, y buscar y usar roles RBAC de Azure integrados. Además, explorará cómo usar RBAC para administrar el acceso a las suscripciones. También revisará las diferencias entre los roles RBAC de Azure y Entra ID.

#### Objetivos de aprendizaje

En este módulo aprenderemos a:

- Conocer los conceptos y principios de RBAC de Azure.
- Crear definiciones de roles y asignaciones de roles.
- Identifique las diferencias entre los roles RBAC de Azure y Microsoft Entra.
- Usar RBAC para administrar el acceso a los recursos.
- Revisar y seleccionar el mejor rol integrado de Azure para un escenario.

#### Requisitos previos

- Conocimientos de Azure. Tener un conocimiento general de los servicios, conceptos y terminología de Azure que le ayude a comprender RBAC de forma más eficaz.
    
- Conceptos de identidad. Un conocimiento básico de Microsoft Entra ID, que es el servicio de administración de identidades y acceso basado en la nube de Microsoft, es esencial. Los conocimientos de conceptos como usuarios, grupos, roles y permisos son útiles.
    
- Administración de recursos de Azure. Comprender cómo se organizan, implementan y administran los recursos proporciona contexto para la implementación de RBAC.
    
- Modelos de control de acceso. Conocimiento de los modelos de control de acceso, como el control de acceso discrecional (DAC) y el control de acceso obligatorio (MAC). Este conocimiento le ayuda a comprender los principios subyacentes a RBAC y sus ventajas sobre los mecanismos de control de acceso tradicionales.

### Implementación del control de acceso basado en roles

La administración de acceso seguro para los recursos en la nube es fundamental para las empresas que operan en la nube. El control de acceso basado en rol (RBAC) es un **mecanismo que puede ayudarle a administrar quién puede acceder a los recursos** de Azure. RBAC le permite determinar qué operaciones pueden hacer los usuarios específicos en recursos específicos y controlar a qué áreas de un recurso puede tener acceso cada usuario.

RBAC es un sistema de autorización basado en Azure Resource Manager. El RBAC permite una administración de acceso muy detallado de los recursos en Azure.

#### Aspectos que debe saber sobre RBAC de Azure

Estas son algunas cosas que puede realizar con RBAC de Azure:

- Permitir que una aplicación acceda a todos los recursos de un grupo de recursos.
    
- Permitir que un usuario administre las VM en una suscripción y que otro usuario administre las redes virtuales.
    
- Permitir a un grupo de administradores de base de datos (DBA) administrar bases de datos SQL en una suscripción.
    
- Permitir que un usuario administre todos los recursos de un grupo de recursos, como las máquinas virtuales, los sitios web y las subredes.
    

#### Conceptos de RBAC de Azure

En la tabla siguiente se describen los conceptos básicos de RBAC de Azure.


| Concepto | Descripción | Ejemplos |
| ---- | ---- | ---- |
| **Entidad de seguridad** | Objeto que representa un elemento que solicita acceso a los recursos. | Usuario, grupo, entidad de servicio o identidad administrada |
| **Definición de roles** | Conjunto de permisos que enumera las operaciones permitidas. RBAC de Azure incluye definiciones de roles integradas, pero también puede crear sus propias definiciones de roles personalizados. | Algunas definiciones de roles integradas: _Lector_, _Colaborador_, _Propietario_, _Administracdor de acceso de ususairo_. |
| **Ámbito** | Límite del _nivel_ de acceso solicitado o "cuánto" se concede. | Grupo de administración, subscripción, grupo de recursos, recurso |
| **Cesión** | Una **asignación** añade una **definición de roles** a una **entidad de seguridad**en un ámbito **determinado**. Los usuarios pueden conceder el acceso descrito en una definición de roles mediante la creación (adición) de una asignación al rol. | - Asignar el rol _Administrador de acceso de usuario_ a un grupo de administración con ámbito aun grupo de administración.                    - Asignar el rol _Colaborador_ a un usuario con ámbito a una subscripción. |


#### Aspectos que se deben tener en cuenta al usar RBAC de Azure

A medida que piense en cómo puede implementar roles y asignaciones de ámbito dentro de su organización, tenga en cuenta estos puntos:

- **Tenga en cuenta los solicitantes**. Planee su estrategia para adaptarse a todos los tipos de acceso a los recursos. Las entidades de seguridad se crean para todo lo que solicite acceso a los recursos. Determine quiénes son los solicitantes de su organización. Los solicitantes pueden ser usuarios internos o externos, grupos de usuarios, aplicaciones y servicios, recursos, etc.
    
- **Tenga en cuenta sus roles**. Examine los tipos de responsabilidades de trabajo y los escenarios de trabajo de su organización. Los roles se suelen crear en torno a los requisitos para cumplir las tareas de trabajo o completar los objetivos de trabajo. Algunos usuarios, como administradores, controladores corporativos e ingenieros, pueden requerir un nivel de acceso más allá de lo que la mayoría de los usuarios necesitan. Algunos roles se pueden definir para proporcionar el mismo acceso a todos los miembros de un equipo o departamento para recursos o aplicaciones específicos.
    
- **Considere el ámbito de los permisos**. Piense en cómo puede garantizar la seguridad controlando el ámbito de los permisos para las asignaciones de roles. Describa los tipos de permisos y niveles de ámbito que necesita admitir. Puede aplicar distintos niveles de ámbito para un único rol para admitir solicitantes en distintos escenarios.
    
- **Considere las definiciones integradas o personalizadas**. Revise la lista de definiciones de roles integrado en el RBAC de Azure. Los roles integrados se pueden usar tal y como están o ajustados para satisfacer los requisitos específicos de su organización. También puede crear definiciones de rol personalizadas desde cero.

### Creación de una definición de roles

Una definición de rol consta de un conjunto de permisos definidos en un fichero JSON. Cada conjunto de permisos tiene un nombre, como _Actions_ o _NotActions_, que describe los permisos. Algunos ejemplos de conjunto de permisos son:

- Los permisos _Actions_ especifican qué acciones se permiten.
    
- Los permisos_NotActions_ especifican qué acciones no se permiten.
    
- Los permisos_DataActions_ indican cómo se pueden modificar o usar los datos.
    
- Los permisos_AssignableScopes_ enumeran los ámbitos en los que se puede asignar una definición de rol.
    

En el diagrama siguiente se muestran los detalles del rol _Contributor_ en el RBAC de Azure.

![[Pasted image 20240108111632.png]]

Los permisos _Actions_ indican que el rol _Colaborador_ tiene todos los privilegios de acción. El comodín (carácter asterisco `"*"`) significa "todo". Los permisos _NotActions_ acotan los privilegios que proporciona el conjunto de acciones _Actions_ y prohíben tres acciones:

- `Authorization/*/Delete`: No está autorizado a eliminar o quitar en "todo".
- `Authorization/*/Write`: No está autorizado a escribir o cambiar en "todo".
- `Authorization/elevateAccess/Action`: No está autorizado a subir el nivel o el ámbito de los privilegios de acceso.

El rol _Contributor_ también tiene dos permisos que especifican cómo pueden verse afectados los datos:

- `"NotDataActions": []`: No se enumera ninguna acción concreta. Por tanto, todas las acciones podrán afectar a los datos.
- `"AssignableScopes": ["/"]`: El rol se puede asignar a todos los ámbitos que afecten a los datos.


#### Lo que hay que saber sobre las definiciones de roles

Revise las siguientes características de las definiciones de roles:

- El RBAC de Azure proporciona roles y conjuntos de permisos integrados. También se pueden crear permisos y role personalizados.
    
- El rol integrado _Propietario_ tiene el nivel más alto de privilegios de acceso en Azure.
    
- El sistema resta los permisos _NotActions_ de los permisos _Actions_ para determinar los _permisos efectivos_ de un rol.
    
- Los permisos _AssignableScopes_ de un rol pueden ser grupos de administración, suscripciones, grupos de recursos o recursos.
    

#### Permisos de los roles

Combine los permisos _Actions_ y _NotActions_ para conceder y denegar los privilegios exactos a cada rol. Los permisos _Actions_ pueden dar amplitud de acceso, mientras que los permisos _NotActions_ pueden acotar el acceso.

La tabla siguiente muestra cómo se usan los permisos _Actions_ y _NotActions_ en las definiciones de tres roles integrados: _Propietario_, _Colaborador_ y _Lector_. Los permisos se van acotando desde el rol _Propietario_ a los roles _Colaborador_ y _Lector_ para restringir el acceso.

|Nombre de rol|Descripción|Permisos de Actions|Permisos de NotActions|
|---|---|---|---|
|_Propietario_|Permitir todas las acciones|`*`|N/D|
|_Colaborador_|Permitir todas las acciones menos la asignación de los roles de escritura o borrado|`*`|- `Microsoft.Authorization /*/Delete`                -`Microsoft.Authorization /*/Write`                -`Microsoft.Authorization /elevateAccess/Action`       |
|_Lector_|Permitir todas las acciones de lectura|`/*/read`|N/D|


#### Ámbitos de rol

Una vez definidos los permisos de un rol, use los permisos _AssignableScopes_ para especificar cómo se puede asignar dicho rol. Veamos algunos ejemplos.

- Dé a un rol el ámbito de disponible para su asignación en dos suscripciones:
    
    `"/subscriptions/c276fc76-9cd4-44c9-99a7-4fd71546436e", "/subscriptions/e91d47c4-76f3-4271-a796-21b4ecfe3624"`
    
- Dé a un rol el ámbito de disponible para su asignación solo en el grupo de recursos de Red:
    
    `"/subscriptions/c276fc76-9cd4-44c9-99a7-4fd71546436e/resourceGroups/Network"`
    
- Dé a un rol el ámbito de disponible para su asignación a todos los solicitantes:
    
    `"/"`

#### Aspectos que hay que tener en cuenta al crear roles

Tenga en cuenta los siguientes puntos relativos a la creación de definiciones de rol en el RBAC de Azure:

- **Considere la posibilidad de usar roles integrados**. Consulte la lista de [definiciones de roles integrados](https://learn.microsoft.com/es-es/azure/role-based-access-control/built-in-roles) en el RBAC de Azure. Hay más de 100 definiciones de roles predefinidos entre las que elegir, como, por ejemplo, _Owner_, _Backup Operator_, _Website Contributor_ y _SQL Security Manager_. Los roles integrados se definen para varias categorías de servicios, tareas y usuarios como, por ejemplo, General, Redes, Almacenamiento, Bases de datos, etc.
    
- **Considere la posibilidad de crear definiciones personalizadas**. Defina sus propios [roles personalizados](https://learn.microsoft.com/es-es/azure/role-based-access-control/custom-roles) que respondan a escenarios de negocio específicos de su organización. Puede modificar los permisos de un rol integrado para que se adapte a las necesidades específicas de su organización. También puede crear definiciones de rol personalizadas desde cero.
    
- **Considere la posibilidad de limitar el ámbito de acceso**. Asigne los roles con el nivel mínimo de ámbito necesario para realizar las tareas necesarias. Algunos usuarios como, por ejemplo, los administradores, requieren acceso total a los recursos corporativos para mantener la infraestructura. Otros usuarios de la organización pueden requerir acceso de escritura a recursos personales o del equipo, y acceso de solo lectura a los recursos compartidos de la empresa.
    
- **Considere la posibilidad de controlar los cambios en los datos**. Identifique los datos o recursos que solo se deben modificar en determinados escenarios y aplique un estricto control de acceso. Restrinja el acceso de los usuarios al mínimo necesario para que puedan hacer su trabajo. Una estrategia de administración de acceso bien planeada ayuda a mantener la infraestructura y a evitar problemas de seguridad.
    
- **Considere la posibilidad de aplicar asignaciones de denegación**. Determine si necesita implementar la característica de asignación de denegación. De forma similar a una asignación de roles, una asignación de denegación asocia un conjunto de acciones de denegación a un usuario, grupo o entidad de servicio en un ámbito determinado con el fin de denegar el acceso. Las asignaciones de denegación impiden que los usuarios realicen acciones concretas en recursos de Azure, aunque una asignación de roles les conceda acceso.

### Crear una asignación de rol

Una asignación de roles es el proceso de establecer el ámbito de una definición de roles para limitar permisos a un usuario, un grupo, una entidad de servicio o identidad administrada.

#### Lo que hay que saber sobre las definiciones de roles

Revise las siguientes características de las definiciones de roles:

- El propósito de la asignación de roles es conceder acceso.
    
- Los límites de ámbito que se definen para un rol están disponibles para el solicitante asignado.
    
- El acceso se revoca quitando una asignación de roles.
    
- Un recurso hereda las asignaciones de roles de su recurso principal.
    
- Los permisos efectivos para un solicitante son una combinación de los permisos para los roles asignados del solicitante y los permisos de los roles asignados a los recursos solicitados.
    

### Aspectos que se deben tener en cuenta al asignar niveles de ámbito para roles

En el diagrama siguiente se muestra un ejemplo de cómo se pueden aplicar ámbitos a un rol para conceder distintos niveles de acceso para distintos usuarios. Piense en cómo puede implementar ámbitos para los roles con el fin de crear asignaciones significativas para su organización.