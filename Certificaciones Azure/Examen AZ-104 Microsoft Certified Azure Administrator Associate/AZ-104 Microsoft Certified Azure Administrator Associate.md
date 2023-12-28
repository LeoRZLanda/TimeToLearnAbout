
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