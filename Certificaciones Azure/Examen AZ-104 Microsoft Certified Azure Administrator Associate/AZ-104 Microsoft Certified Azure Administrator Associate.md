
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