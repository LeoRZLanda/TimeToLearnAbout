
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