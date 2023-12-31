

1. ¿Qué dos escenarios comunes hay para usar etiquetas de recursos? Cada respuesta correcta presenta una solución completa.

<details>
	<summary>Respuesta</summary>
	<p>asociación de costos con diferentes entornos y categorización de costos por departamento</p>
	<small>Puede usar etiquetas para clasificar los costos por departamento (como recursos humanos, marketing o finanzas) o por entorno (como pruebas o producción). Cambiar el tamaño de las máquinas virtuales infrautilizadas es una buena medida de ahorro de costos y el aprovisionamiento de recursos en regiones de menor costo es un procedimiento recomendado, aunque las etiquetas de recursos no ayudan con esto.</small>
</details>

2. Su organización planea implementar varias máquinas virtuales de producción que tendrán un uso coherente de los recursos durante todo el año.

¿Qué puede usar para minimizar los costos de las máquinas virtuales sin reducir su funcionalidad?

<details>
	<summary>Respuesta</summary>
	<p>Reservas de Azure</p>
	<small>Reservas de Azure ofrecen precios con descuento en determinados servicios de Azure. Azure Reservations puede ahorrarle hasta un 72 % en comparación con los precios de pago por uso. Para recibir un descuento, puede reservar servicios y recursos pagando por adelantado. Los límites de gasto pueden suspender una suscripción cuando se alcanza el límite de gasto.</small>
</details>

3. ¿Qué puede usar para asegurarse de que los recursos de Azure nuevos y existentes cumplan los estándares corporativos?

<details>
	<summary>Respuesta</summary>
	<p>Azure Policy</p>
	<small>Azure Policy es un servicio de Azure que permite crear, asignar y administrar directivas que controlan o auditan recursos. Dichas directivas aplican distintas reglas en las configuraciones de recursos para que esas configuraciones sigan cumpliendo con los estándares corporativos.</small>
</details>

4. Debe recomendar una solución para las implementaciones de máquinas virtuales de Azure. La solución debe aplicar los estándares de la empresa en las máquinas virtuales.

¿Qué debería incluir en la recomendación?

<details>
	<summary>Respuesta</summary>
	<p>Azure Policy</p>
	<small>Las directivas de Azure le permitirán aplicar estándares de empresa en nuevas máquinas virtuales cuando se combinan con Azure VM Image Builder y Azure Compute Gallery. Mediante el uso de Azure Policy y las asignaciones de control de acceso basado en roles (RBAC), las empresas pueden aplicar estándares en los recursos de Azure. Pero en las máquinas virtuales, estos mecanismos solo afectan al plano de control o a la ruta a la máquina virtual.</small>
</details>

5. Debe asegurarse de que la autenticación multifactor (MFA) esté habilitada en las cuentas con permisos de escritura en una suscripción de Azure.

¿Qué debe implementar?

<details>
	<summary>Respuesta</summary>
	<p>Azure Policy</p>
	<small>Azure Policy es un servicio de Azure que permite crear, asignar y administrar directivas que controlan o auditan recursos.</small>
</details>

6. ¿Qué puede usar para asegurarse de que un equipo de desarrollo solo pueda crear máquinas virtuales de un tamaño determinado?

<details>
	<summary>Respuesta</summary>
	<p>Azure Policy</p>
	<small>Azure Policy permite definir tanto directivas individuales como grupos de directivas relacionadas, lo que se conoce como iniciativas. Azure Policy evalúa los recursos y resalta los que no cumplen con las directivas que creó. Azure Policy también puede impedir que se creen recursos no conformes.</small>
</details>

7. ¿Qué puede usar para crear recursos en Azure e incluye un paso de validación para asegurarse de que todos los recursos se crean en un orden específico en función de las dependencias, en paralelo e idempotentes?

<details>
	<summary>Respuesta</summary>
	<p>Plantillas de Azure Resource Manager (ARM)</p>
	<small>Las plantillas de ARM definen los requisitos de infraestructura de la aplicación para una implementación repetible que se realiza de forma coherente. Un paso de validación garantiza que se puedan crear todos los recursos en el orden adecuado, en función de las dependencias, en paralelo y de forma idempotente.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-features-tools-manage-deploy-azure-resources/">Descripción de características y herramientas para administrar e implementar recursos de Azure: Formación | Microsoft Learn</a></small>
</details>

8. ¿Qué dos herramientas puede usar para crear una nueva máquina virtual de Azure desde un dispositivo móvil que ejecuta Android? Cada respuesta correcta presenta la solución completa.

<details>
	<summary>Respuesta</summary>
	<p>PowerShell en Azure Cloud Shell y Azure Portal</p>
	<small>Azure Portal se puede ejecutar en dispositivos que tengan instalado el sistema operativo Android. El explorador puede ser de cualquier tipo, como Internet Explorer 11, Chrome, Firefox o Safari (todas las versiones más recientes). Al visitar el portal, verá Cloud Shell. Los usuarios pueden acceder a Bash y PowerShell desde Cloud Shell. Puede usar Bash y PowerShell para crear máquinas virtuales de Azure.
	<a href = "https://learn.microsoft.com/azure/virtual-desktop/users/connect-android-chrome-os" >Conexión a Azure Virtual Desktop con el cliente de Escritorio remoto para los sistemas operativos Android y Chrome: Azure Virtual Desktop | Microsoft Learn</a>
	<a href = "https://learn.microsoft.com/training/modules/describe-features-tools-manage-deploy-azure-resources/" >Descripción de características y herramientas para administrar e implementar recursos de Azure: Formación | Microsoft Learn</a>
	</small>
</details>

9. ¿Qué proporciona recomendaciones para reducir el costo de los recursos de Azure?

<details>
	<summary>Respuesta</summary>
	<p>Azure Advisor</p>
	<small>Azure Advisor analiza el uso de la cuenta y realiza recomendaciones basadas en sus reglas establecidas y configuradas.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-monitoring-tools-azure/">Descripción de las herramientas de supervisión en Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

10. Tiene un equipo de administradores de Linux que necesitan administrar los recursos en Azure. El equipo quiere usar el shell de Bash para realizar la administración.

¿Qué debería recomendar?

<details>
	<summary>Respuesta</summary>
	<p>CLI de Azure</p>
	<small>La CLI de Azure permite usar el shell de Bash para realizar tareas administrativas. Bash se usa en entornos de Linux, por lo que un administrador de Linux probablemente estará más cómodo realizando la administración de línea de comandos desde la CLI de Azure.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-features-tools-manage-deploy-azure-resources/">Descripción de características y herramientas para administrar e implementar recursos de Azure: Formación | Microsoft Learn</a>
	</small>
</details>

11. Debe revisar el informe de análisis de causa principal (RCA) para ver una interrupción del servicio que se produjo la semana pasada.

¿Dónde debe buscar el informe?

<details>
	<summary>Respuesta</summary>
	<p>Azure Service Health</p>
	<small>Después de una interrupción, Service Health proporciona informes de incidentes oficiales, llamados análisis de la causa principal (RCA), que puede compartir con las partes interesadas.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-monitoring-tools-azure/">Descripción de las herramientas de supervisión en Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

12. Debe crear una solución personalizada que use umbrales para desencadenar la funcionalidad de escalado automático para escalar o reducir verticalmente una aplicación para satisfacer la demanda del usuario.

¿Qué debe incluir en la solución?

<details>
	<summary>Respuesta</summary>
	<p>Azure Monitor</p>
	<small>Azure Monitor es una plataforma que recopila datos de métricas y de registro, como porcentajes de CPU. Los datos se pueden usar para desencadenar el escalado automático.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-monitoring-tools-azure/">Descripción de las herramientas de supervisión en Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

13. ¿Qué puede usar para detectar automáticamente anomalías de rendimiento en las aplicaciones web?

<details>
	<summary>Respuesta</summary>
	<p>Azure Application Insights</p>
	<small>Application Insights es una característica de Azure Monitor que permite supervisar las aplicaciones en ejecución, detectar automáticamente anomalías de rendimiento y usar herramientas de análisis integradas para ver qué hacen los usuarios en una aplicación.
	<a href = "https://learn.microsoft.com/training/modules/monitoring-fundamentals/2-identify-product-options">Descripción de las herramientas de supervisión en Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

14. ¿Qué servicio de Azure puede generar una alerta si el uso de la máquina virtual supera el 80 % durante cinco minutos?

<details>
	<summary>Respuesta</summary>
	<p>Azure Monitor</p>
	<small>Azure Monitor es una plataforma para recopilar, analizar, visualizar y alertar en función de las métricas. Azure Monitor puede registrar datos desde un entorno completo de Azure y en el entorno local.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-monitoring-tools-azure/">Descripción de las herramientas de supervisión en Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

15. ¿Qué puede usar para encontrar información sobre el mantenimiento planeado para los servicios de Azure que son críticos para su organización?

<details>
	<summary>Respuesta</summary>
	<p>Azure Service Health</p>
	<small>Puede profundizar en los servicios, las regiones y los detalles afectados para mostrar cómo influirá un evento y qué debe hacer. La mayoría de estos eventos se producen sin ningún impacto en el usuario y no se mostrarán aquí. En el caso excepcional de que se requiera un reinicio, Service Health le permitirá elegir cuándo realizar el mantenimiento para minimizar el tiempo de inactividad.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-monitoring-tools-azure/">Descripción de las herramientas de supervisión en Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

16. ¿Qué puede aplicar a una máquina virtual de Azure para asegurarse de que los usuarios no puedan cambiar o eliminar el recurso?

<details>
	<summary>Respuesta</summary>
	<p>Un bloqueo</p>
	<small>Incorrecto: Una identidad administrada asignada por el usuario: Agregar una identidad no añade la capacidad de cambiar o eliminar el recurso.
	<b>Correcto: Un bloqueo: Un bloqueo de recursos cumplirá ambos requisitos.</b>
	Incorrecto: Una etiqueta: Una etiqueta no cumplirá los requisitos.
	Incorrecto: Acceso condicional: El acceso condicional no cumplirá los requisitos.
	<a href="https://learn.microsoft.com/azure/azure-resource-manager/management/lock-resources?tabs=json">Protección de los recursos de Azure con un bloqueo: Azure Resource Manager | Microsoft Learn</a>
	<a href = "https://learn.microsoft.com/training/modules/describe-features-tools-azure-for-governance-compliance/">Descripción de las características y las herramientas de Azure para la gobernanza y el cumplimiento: Formación | Microsoft Learn</a>
</small>
</details>

17. ¿Qué característica del Portal de gobernanza de Microsoft Purview debe usar para administrar el acceso a los orígenes de datos y los conjuntos de datos?

<details>
	<summary>Respuesta</summary>
	<p>Directiva de Datos</p>
	<small>Incorrecto: Data Catalog: Esto habilita la detección de datos.
	Incorrecto: Uso compartido de datos: Comparte datos dentro y entre organizaciones.
	Incorrecto: Data Estate Insights: Accede al estado del patrimonio de datos.
	Correcto: Directiva de datos: Esto rige el acceso a los datos.
	<a href = "https://learn.microsoft.com/azure/purview/overview">Introducción a las soluciones de gobernanza de Microsoft Purview: Microsoft Purview | Microsoft Learn</a>
	<a href = "https://learn.microsoft.com/training/modules/describe-features-tools-azure-for-governance-compliance/">Descripción de las características y las herramientas de Azure para la gobernanza y el cumplimiento: Formación | Microsoft Learn</a>
	</small>
</details>

18. ¿Qué dos atributos son característicos del modelo de implementación de nube privada? Cada respuesta correcta presenta una solución completa.

<details>
	<summary>Respuesta</summary>
	<p>El hardware debe comprarse, La empresa tiene el control total sobre los recursos físicos y la seguridad</p>
	<small>En una nube privada, debe adquirirse hardware para el inicio y el mantenimiento. En una nube privada, las organizaciones controlan los recursos y la seguridad. El aprovisionamiento rápido es una característica del modelo de implementación en la nube pública. Pagar solo por lo que se usa es una característica del modelo de implementación en la nube pública.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-cloud-compute/">Descripción de la informática en la nube: formación | Microsoft Learn</a>
	</small>
</details>

19. ¿Cuáles son dos servicios básicos proporcionados por todos los proveedores de nube? Cada respuesta correcta presenta una solución completa.

<details>
	<summary>Respuesta</summary>
	<p>Compute y Storage</p>
	<small>Todos los proveedores de nube proporcionan servicios de proceso y almacenamiento. Coubicación es cuando una empresa alquila espacio en un centro de datos físico compartido. El desarrollo de aplicaciones es responsabilidad del cliente y normalmente se realiza internamente o a través de un tercero.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-cloud-compute/">Descripción de la informática en la nube: formación | Microsoft Learn</a>
	</small>
</details>

20. ¿Cuáles son dos características de un modelo basado en el consumo? Cada respuesta correcta presenta una solución completa.

<details>
	<summary>Respuesta</summary>
	<p>Sin costos iniciales y la capacidad de dejar de pagar por los recursos que ya no se usen</p>
	<small>En un modelo basado en el consumo, no paga por nada hasta que empiece a usar recursos y solo paga por lo que usa. Si deja de usar un recurso, deja de pagar por él. Normalmente, los gastos elevados se asocian a la compra de la infraestructura física, que no es necesaria en un modelo basado en el consumo.
	<a href = "https://learn.microsoft.com/training/modules/describe-cloud-compute/">Descripción de la informática en la nube: formación | Microsoft Learn</a>
	</small>
</details>

21. ¿Por qué la informática en la nube suele ser menos costosa que los centros de datos locales? Cada respuesta correcta presenta una solución completa.

<details>
	<summary>Respuesta</summary>
	<p>Solo se factira por lo que use</p>
	<small>Alquilar servicios de proceso y almacenamiento y facturar solo por lo que se usa a menudo reduce los gastos operativos. Según el servicio y el tipo de ancho de banda de red, se puede incurrir en cargos. Las ofertas de servicios en la nube suelen proporcionar funcionalidades que pueden ser difíciles o prohibitivas de implementar en el entorno local, especialmente para organizaciones más pequeñas. Los principales proveedores de nube ofrecen servicios en todo el mundo. Lo que facilita y hace relativamente más barato implementar servicios cerca de donde residan los usuarios.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-cloud-compute/">Descripción de la informática en la nube: formación | Microsoft Learn</a>
	</small>
</details>

22. ¿Cuál es una ventaja de la informática en la nube en comparación con las implementaciones locales?

<details>
	<summary>Respuesta</summary>
	<p>Puede escalar más rápidamente</p>
	<small>La informática en la nube le permite escalar más rápidamente. Poseer sus propias CPU y tener acceso total en caso de una interrupción de Internet no son características de la informática en la nube. Trabajar desde varias estaciones de trabajo no es específico de la informática en la nube en comparación con una implementación local.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-cloud-compute/">Descripción de la informática en la nube: formación | Microsoft Learn</a>
	</small>
</details>

23. Seleccione la respuesta que complete correctamente la oración.

El aumento de la capacidad de proceso de una aplicación mediante la adición de RAM o CPU a una máquina virtual se denomina [elija la respuesta].

<details>
	<summary>Respuesta</summary>
	<p>Escalado vertical</p>
	<small>Escale verticalmente para aumentar la capacidad de proceso mediante la incorporación de RAM o CPU adicionales a una máquina virtual. El escalado horizontal aumenta la capacidad de proceso mediante la adición de instancias de recursos, como la incorporación de máquinas virtuales a la configuración. La recuperación ante desastres mantiene los datos y otros recursos seguros en caso de desastre. La alta disponibilidad minimiza el tiempo de inactividad cuando las cosas salen mal.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-benefits-use-cloud-services/">https://learn.microsoft.com/en-us/training/modules/describe-benefits-use-cloud-services/</a>
	</small>
</details>

24. Seleccione la respuesta que complete correctamente la oración.

La implementación y configuración rápidas de recursos basados en la nube a medida que cambian los requisitos empresariales se denomina [elija la respuesta].

<details>
	<summary>Respuesta</summary>
	<p>agilidad</p>
	<small><b>Agilidad</b>: significa que puede implementar y configurar recursos basados en la nube rápidamente a medida que cambian los requisitos de la aplicación. 
	La escalabilidad: significa que puede agregar memoria RAM, CPU o máquinas virtuales completas a una configuración. 
	Elasticidad: quiere decir que puede configurar aplicaciones basadas en la nube para aprovechar el escalado automático, de forma que las aplicaciones siempre dispongan de los recursos que necesiten. 
	Alta disponibilidad: significa que las aplicaciones basadas en la nube pueden proporcionar una experiencia de usuario continua sin tiempo de inactividad aparente, incluso cuando las cosas salen mal.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-benefits-use-cloud-services/">Descripción de las ventajas de usar servicios en la nube: formación | Microsoft Learn</a>
	</small>
</details>

25. ¿De qué son característicos los servicios de copia de seguridad basados en la nube, la replicación de datos y las características de distribución geográfica?

<details>
	<summary>Respuesta</summary>
	<p>un plan de recuperación ante desastres</p>
	<small>La recuperación ante desastres usa servicios, como la copia de seguridad basada en la nube, la replicación de datos y la distribución geográfica, para mantener los datos y el código seguros en caso de desastre.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-benefits-use-cloud-services/">Descripción de las ventajas de usar servicios en la nube: formación | Microsoft Learn</a>
	</small>
</details>

26. Seleccione la respuesta que complete correctamente la oración.

Un ejemplo de [elija la respuesta] es el escalado automático de una aplicación para asegurarse de que la aplicación tenga los recursos necesarios para satisfacer las demandas del cliente.

<details>
	<summary>Respuesta</summary>
	<p></p>
	<small><b>La elasticidad</b> hace referencia a la capacidad de escalar los recursos según sea necesario, como durante las horas laborables, para asegurarse de que una aplicación pueda mantenerse al día a petición y luego, reducir los recursos disponibles durante las horas de poca actividad. 
	Agilidad hace referencia a la capacidad de implementar rápidamente nuevas aplicaciones y servicios. 
	La alta disponibilidad hace referencia a la capacidad de asegurarse de que un servicio o una aplicación permanezcan disponibles en caso de error. 
	La distribución geográfica hace que un servicio o una aplicación estén disponibles en varias ubicaciones geográficas que suelen estar cerca de los usuarios.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-benefits-use-cloud-services/">Descripción de las ventajas de usar servicios en la nube: formación | Microsoft Learn</a>
	</small>
</details>

27. En un modelo de plataforma como servicio (PaaS), ¿cuáles dos componentes son responsabilidad del proveedor de servicios en la nube? Cada respuesta correcta presenta una solución completa.

<details>
	<summary>Respuesta</summary>
	<p>sistema operativo y red física</p>
	<small>En la PaaS, el proveedor de nube es responsable del sistema operativo, el centro de datos físico, los hosts físicos y la red física. En las PaaS, el cliente es responsable de las cuentas e identidades.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-cloud-service-types/">Descripción de los tipos de servicio en la nube: aprendizaje | Microsoft Learn</a>
	</small>
</details>

28. ¿En qué modelo de servicio en la nube es el cliente responsable de administrar el sistema operativo?

<details>
	<summary>Respuesta</summary>
	<p>Infraestructura como servicio (IaaS)</p>
	<small>IaaS consta de máquinas virtuales y redes proporcionadas por el proveedor de nube. El cliente es responsable del sistema operativo y las aplicaciones. El proveedor de nube es responsable del sistema operativo en PaaS y SaaS.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-cloud-service-types/">Descripción de los tipos de servicio en la nube: aprendizaje | Microsoft Learn</a>
	</small>
</details>

29. Su organización está creando una aplicación personalizada.

Debe centrarse en el desarrollo de aplicaciones en lugar de en la configuración y administración de servidores.

¿Qué modelo de servicio en la nube se debería usar?

<details>
	<summary>Respuesta</summary>
	<p>plataforma como servicio (PaaS)</p>
	<small>Con PaaS, los usuarios se pueden centrar en el desarrollo de aplicaciones, ya que el proveedor de nube lleva a cabo toda la administración de plataformas. 
	En SaaS, el proveedor de servicios en la nube administra todos los aspectos del entorno de la aplicación, como las máquinas virtuales, los recursos de red, el almacenamiento de datos y las aplicaciones. 
	IaaS es el modelo de servicio más cercano para administrar servidores físicos.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-cloud-service-types/">Descripción de los tipos de servicio en la nube: aprendizaje | Microsoft Learn</a>
	</small>
</details>

30. ¿Qué usa el modelo de servicio en la nube de infraestructura como servicio (IaaS)?

<details>
	<summary>Respuesta</summary>
	<p>Azure Virtual Machines</p>
	<small>Azure Virtual Machines es una oferta de IaaS. El cliente es responsable de la configuración de la máquina virtual, así como de todas las configuraciones del sistema operativo. 
	Azure App Services y Azure Cosmos DB son ofertas de PaaS. 
	Microsoft Office 365 es una oferta de SaaS.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-cloud-service-types/">Descripción de los tipos de servicio en la nube: aprendizaje | Microsoft Learn</a>
	</small>
</details>

31. ¿Qué tipos de servicios en la nube son redes virtuales?

<details>
	<summary>Respuesta</summary>
	<p>infraestructura como servicio (IaaS)</p>
	<small>IaaS le ayuda a reducir el costo y la complejidad de mantener un servidor físico y su infraestructura en el centro de datos. Las redes virtuales forman parte del servicio en la nube de IaaS.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-cloud-service-types/">Descripción de los tipos de servicio en la nube: aprendizaje | Microsoft Learn</a>
	</small>
</details>

32. Seleccione la respuesta que complete correctamente la oración.

[Elija la respuesta] es el contenedor lógico que se usa para combinar y organizar recursos de Azure.

<details>
	<summary>Respuesta</summary>
	<p>un grupo de recursos</p>
	<small>Los recursos se combinan en grupos de recursos, que actúan como contenedor lógico en el que se implementan y administran recursos de Azure como las aplicaciones web, las bases de datos y las cuentas de almacenamiento.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-core-architectural-components-of-azure/">Descripción de los principales componentes arquitectónicos de Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

33. Seleccione la respuesta que complete correctamente la oración.

En un par de regiones, una región se empareja con otra en la misma [elegir respuesta].

<details>
	<summary>Respuesta</summary>
	<p>geography</p>
	<small>
	Cada región de Azure se empareja siempre con otra región de la misma zona geográfica (por ejemplo, EE. UU., Europa o Asia) que se encuentre como mínimo a 500 km de distancia.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-core-architectural-components-of-azure/">Descripción de los principales componentes arquitectónicos de Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

34. ¿Qué ejemplifica una cuenta de Azure Storage denominada storage001?

<details>
	<summary>Respuesta</summary>
	<p>Un recurso</p>
	<small>Un recurso es un elemento administrable que está disponible mediante Azure. Las máquinas virtuales, cuentas de almacenamiento, aplicaciones web, bases de datos y redes virtuales son ejemplos de recursos.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-core-architectural-components-of-azure/">Descripción de los principales componentes arquitectónicos de Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

35. ¿Qué componente de Azure le permite replicar recursos en una geografía para garantizar la continuidad empresarial durante un desastre natural en el sitio primario?

<details>
	<summary>Respuesta</summary>
	<p>pares de región</p>
	<small>Los pares de regiones permiten la replicación de recursos de Azure entre zonas geográficas para garantizar que una región secundaria esté disponible en caso de desastre en la región primaria.
	<a href = "https://learn.microsoft.com/training/modules/azure-architecture-fundamentals/regions-availability-zones">Descripción de los principales componentes arquitectónicos de Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

36. Seleccione la respuesta que complete correctamente la oración.

[Elija la respuesta] es el servicio de implementación y administración de Azure.

<details>
	<summary>Respuesta</summary>
	<p>Azure Resource Manager (ARM)</p>
	<small>ARM es el servicio de implementación y mantenimiento para Azure. Proporciona una capa de administración que le permite crear, actualizar y eliminar recursos de su suscripción de Azure. Puede usar características de administración, como el control de acceso, los bloqueos de recursos y las etiquetas de recursos, para proteger y organizar los recursos después de la implementación.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-core-architectural-components-of-azure/">Descripción de los principales componentes arquitectónicos de Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

37. ¿Qué dos recursos de Azure pueden usar las zonas de disponibilidad? Cada respuesta correcta presenta una solución completa.

<details>
	<summary>Respuesta</summary>
	<p>Bases de datos de Azure SQL y máquinas virtuales</p>
	<small>Las zonas de disponibilidad son principalmente para las máquinas virtuales, los discos administrados, los equilibradores de carga y las bases de datos SQL.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-core-architectural-components-of-azure/">Descripción de los principales componentes arquitectónicos de Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

38. ¿Qué recurso de Azure es una emulación de software de un equipo físico que incluye un procesador virtual, memoria, almacenamiento y recursos de red?

<details>
	<summary>Respuesta</summary>
	<p>una máquina virtual</p>
	<small>Las máquinas virtuales son emulaciones de software de equipos físicos. Incluyen un procesador virtual, memoria, almacenamiento y recursos de red. Hospedan un sistema operativo, y se puede instalar y ejecutar software, al igual que en un equipo físico.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-azure-compute-networking-services/">Descripción de los servicios de proceso y redes de Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

39. ¿Qué servicio de proceso de Azure puede usar para implementar y administrar un conjunto de máquinas virtuales idénticas?

<details>
	<summary>Respuesta</summary>
	<p>Conjuntos de escalado de máquinas virtuales de Azure</p>
	<small>Las instancias de Azure Virtual Machine Scale Sets son un recurso que puede utilizar para implementar y administrar un conjunto de máquinas virtuales idénticas.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-azure-compute-networking-services/">Descripción de los servicios de proceso y redes de Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

40. Debe permitir que los recursos de dos redes virtuales de Azure diferentes se comuniquen entre sí.

¿Qué debe configurar?

<details>
	<summary>Respuesta</summary>
	<p>emparejamiento</p>
	<small>Puede vincular redes virtuales entre sí mediante el emparejamiento de red virtual. El emparejamiento permite que los recursos de cada red virtual se comuniquen entre sí.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-azure-compute-networking-services/">Descripción de los servicios de proceso y redes de Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

41. ¿Qué puede usar para conectar recursos de Azure, como bases de datos de Azure SQL, a una red virtual de Azure?

<details>
	<summary>Respuesta</summary>
	<p>puntos de conexión del servicio</p>
	<small>Los puntos de conexión de servicio se usan para exponer los servicios de Azure a una red virtual, lo que proporciona comunicación entre los dos. ExpressRoute se usa para conectar una red local a Azure. Los NSG permiten configurar reglas de entrada y de salida para redes virtuales y máquinas virtuales. El emparejamiento permite conectar redes virtuales juntas.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-azure-compute-networking-services/">Descripción de los servicios de proceso y redes de Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

42. ¿Qué dos servicios puede usar para establecer la conectividad de red entre una red local y los recursos de Azure? Cada respuesta correcta presenta una solución completa.

<details>
	<summary>Respuesta</summary>
	<p>Azure VPN Gateway y ExpressRoute</p>
	<small>Las conexiones de ExpressRoute y Azure VPN Gateway son dos servicios que puede usar para conectar una red local a Azure. Bastion proporciona una interfaz web para administrar de forma remota máquinas virtuales de Azure mediante SSH/RDP. Azure Firewall es un servicio de firewall con estado que se usa para proteger las redes virtuales.
	<a href = "https://learn.microsoft.com/azure/expressroute/expressroute-connectivity-models">Azure ExpressRoute: Modelos de conectividad | Microsoft Learn</a>
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-azure-compute-networking-services/">Descripción de los servicios de proceso y redes de Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

43. ¿Qué servicio de almacenamiento debe usar para almacenar miles de archivos que contienen texto e imágenes? 

<details>
	<summary>Respuesta</summary>
	<p>Azure Blob Storage</p>
	<small>Azure Blob Storage es una solución de almacenamiento de objetos optimizada para el almacenamiento de cantidades masivas de datos no estructurados, como texto o datos binarios.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-azure-storage-services/">Descripción de los servicios de almacenamiento de Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

44. ¿Qué nivel de servicio de Azure Blob Storage tiene los costos de almacenamiento más altos y los tiempos de acceso más rápidos para leer y escribir datos?

<details>
	<summary>Respuesta</summary>
	<p>Acceso frecuente</p>
	<small>El nivel de almacenamiento de acceso frecuente está optimizado para almacenar datos que se consultan con frecuencia. 
	En el caso del nivel de almacenamiento de acceso esporádico, un Acuerdo de Nivel de Servicio con una disponibilidad ligeramente inferior y unos costos de acceso mayores, en comparación con los datos de acceso frecuente, es aceptable a cambio de unos costos de almacenamiento menores. 
	El almacenamiento de archivo almacena datos sin conexión y ofrece los menores costos de almacenamiento, pero los mayores costos de acceso y rehidratación de datos.
	<a href = "Descripción de los servicios de almacenamiento de Azure: aprendizaje | Microsoft Learn"></a>
	</small>
</details>

45. ¿Qué dos protocolos se pueden usar para acceder a los recursos compartidos de archivos de Azure? Cada respuesta correcta presenta una solución completa.

<details>
	<summary>Respuesta</summary>
	<p>Network File System (NFS) y Bloque de mensajes del servidor (SMB)</p>
	<small>Azure Files proporciona recursos compartidos de archivos totalmente administrados en la nube a los que se puede acceder mediante los protocolos SMB y NFS estándar del sector.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-azure-storage-services/">Descripción de los servicios de almacenamiento de Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

46. ¿Cuál es el propósito de la defensa en profundidad?

<details>
	<summary>Respuesta</summary>
	<p>para usar varios niveles de protección y evitar que los usuarios no autorizados accedan a la información</p>
	<small>El objetivo de la defensa en profundidad es usar varias capas de protección para evitar que los usuarios no autorizados accedan a la información o la roben.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-azure-identity-access-security/">Descripción de la identidad, el acceso y la seguridad en Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

47. ¿Qué puede usar para asegurarse de que un usuario solo pueda acceder a las aplicaciones desde dispositivos compatibles?

<details>
	<summary>Respuesta</summary>
	<p>Acceso condicional</p>
	<small>El acceso condicional es una característica que usa Microsoft Entra para permitir o denegar el acceso a los recursos en función de señales de identidad, como el dispositivo que se está usando. 
	El inicio de sesión único permite a los usuarios iniciar sesión una vez y utilizar esa credencial para acceder a varios recursos y aplicaciones de distintos proveedores. 
	La MFA es un proceso en el que durante el inicio de sesión de un usuario se le solicita una forma adicional de identificación. 
	Las soluciones de identidad híbrida crean una identidad de usuario común para la autenticación y autorización en todos los recursos, independientemente de la ubicación.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-azure-identity-access-security/">Descripción de la identidad, el acceso y la seguridad en Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

48. ¿Qué puede usar para permitir que un usuario administre todos los recursos de un grupo de recursos?

<details>
	<summary>Respuesta</summary>
	<p>Control de acceso basado en rol (RBAC) de Azure</p>
	<small>Azure RBAC permite asignar un conjunto de permisos a un usuario o grupo. 
	Las etiquetas de recursos permiten localizar recursos asociados a cargas de trabajo, entornos, unidades de negocio y propietarios específicos y actuar al respecto. 
	Los bloqueos de recursos impiden el cambio accidental o la eliminación de un recurso. 
	Key Vault es un servicio en la nube centralizado para almacenar los secretos de la aplicación en una única ubicación central.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-azure-identity-access-security/">Descripción de la identidad, el acceso y la seguridad en Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

49. ¿A qué objeto o nivel se aplica un rol de control de acceso basado en roles (RBAC) de Azure?

<details>
	<summary>Respuesta</summary>
	<p>scope</p>
	<small>Un rol RBAC de Azure se aplica a un ámbito, que es un recurso o un conjunto de recursos a los que se aplica el acceso. Los bloqueos de recursos impiden el cambio accidental o la eliminación de un recurso. Las etiquetas de recursos permiten localizar recursos asociados a cargas de trabajo, entornos, unidades de negocio y propietarios específicos y actuar al respecto. Las directivas aplican distintas reglas en las configuraciones del recurso para que esas configuraciones sigan cumpliendo con los estándares corporativos.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-azure-identity-access-security/">Descripción de la identidad, el acceso y la seguridad en Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

50. ¿Qué puede usar para asegurarse de que los usuarios se autentiquen mediante la autenticación multifactor (MFA) cuando intenten iniciar sesión desde una ubicación específica?

<details>
	<summary>Respuesta</summary>
	<p>Acceso condicional</p>
	<small>El acceso condicional puede usar señales para determinar información sobre los intentos de autenticación y, a continuación, determinar si se va a bloquear el acceso o requerir comprobaciones adicionales, como la MFA.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-azure-identity-access-security/">Descripción de la identidad, el acceso y la seguridad en Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

51. ¿Qué dos características están disponibles mediante Azure Cost Management + Billing? Cada respuesta correcta presenta una solución completa.

<details>
	<summary>Respuesta</summary>
	<p>Creación y administración de presupuestos, y Genere informes históricos y previsión del uso futuro.</p>
	<small>Azure Cost Management le permite crear y administrar presupuestos de costos y uso mediante la supervisión de tendencias de demanda de recursos, tasas de consumo y patrones de costos. También le permite usar datos históricos para generar informes y predecir el uso y los gastos futuros.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-cost-management-azure/">Descripción de la administración de costos en Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

52. Tiene una máquina virtual de Azure a la que solo se accede entre las 9:00 y las 17:00 cada día.

¿Qué debe hacer para minimizar los costos, pero conservar los discos duros y los datos asociados?

<details>
	<summary>Respuesta</summary>
	<p>Desasignar la máquina virtual cuando no se necesite.</p>
	<small>Si tiene cargas de trabajo de máquina virtual que solo se usan durante determinados periodos, pero las ejecuta cada hora de cada día, está perdiendo dinero. Estas máquinas virtuales son excelentes candidatas para desasignar cuando no están en uso y de empezar de nuevo cuando sea necesario para ahorrar costos de proceso mientras se desasignan las máquinas virtuales.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-cost-management-azure/">Descripción de la administración de costos en Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

53. ¿Qué se puede aplicar a un recurso para evitar la eliminación accidental?

<details>
	<summary>Respuesta</summary>
	<p>un bloqueo de recursos</p>
	<small>Los bloqueos de recursos impiden que se eliminen o modifiquen recursos por error. Las etiquetas de recursos ofrecen agrupación personalizada de recursos. Dichas directivas aplican distintas reglas en todas las configuraciones de los recursos para que esas configuraciones sigan cumpliendo con los estándares corporativos. Una iniciativa es una forma de agrupar las directivas relacionadas.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-features-tools-azure-for-governance-compliance/">Descripción de las características y las herramientas de Azure para la gobernanza y el cumplimiento: Formación | Microsoft Learn</a>
	</small>
</details>

54. ¿Qué puede usar para restringir la implementación de una máquina virtual a una ubicación específica?

<details>
	<summary>Respuesta</summary>
	<p>Azure Policy</p>
	<small>Azure Policy puede ayudar a crear una directiva para las regiones permitidas, lo que le permite restringir la implementación de máquinas virtuales a una ubicación específica.
	<a href = "https://learn.microsoft.com/azure/governance/policy/overview">Información general de Azure Policy: Azure Policy | Microsoft Learn</a>
	<a href = "https://learn.microsoft.com/training/modules/describe-features-tools-azure-for-governance-compliance/3-describe-purpose-of-azure-policy">Descripción del propósito de Azure Policy: Formación | Microsoft Learn</a>
	</small>
</details>

55. ¿Qué puede usar para definir los recursos que desea aprovisionar en un formato JSON declarativo?

<details>
	<summary>Respuesta</summary>
	<p>Plantillas de Azure Resource Manager (ARM)</p>
	<small>Al usar plantillas de ARM, puede describir los recursos que quiere usar en un formato JSON declarativo.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-features-tools-manage-deploy-azure-resources/">Descripción de características y herramientas para administrar e implementar recursos de Azure: Formación | Microsoft Learn</a>
	</small>
</details>

56. ¿Qué capa de administración acepta solicitudes de cualquier herramienta o API de Azure y le permite crear, actualizar y eliminar recursos en una cuenta de Azure?

<details>
	<summary>Respuesta</summary>
	<p>Azure Resource Manager (ARM)</p>
	<small>ARM es el servicio de implementación y mantenimiento para Azure. Proporciona una capa de administración que le permite crear, actualizar y eliminar recursos de la cuenta de Azure.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-features-tools-manage-deploy-azure-resources/">Descripción de características y herramientas para administrar e implementar recursos de Azure: Formación | Microsoft Learn</a>
	</small>
</details>

57. ¿Qué se puede usar para administrar servidores entre entornos locales y plataformas en la nube de terceros?

<details>
	<summary>Respuesta</summary>
	<p>Azure Arc</p>
	<small>Azure Arc simplifica el gobierno y la administración al ofrecer una plataforma de administración local y multinube coherente.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-features-tools-manage-deploy-azure-resources/">Descripción de características y herramientas para administrar e implementar recursos de Azure: Formación | Microsoft Learn</a>
	<a href = "https://learn.microsoft.com/training/modules/describe-features-tools-manage-deploy-azure-resources/3-describe-purpose-of-azure-arc">Descripción del propósito de Azure Arc: Formación | Microsoft Learn</a>
	</small>
</details>

58. Seleccione la respuesta que complete correctamente la oración.

[Elija la respuesta] son centros de datos separados físicamente dentro de una región de Azure.

<details>
	<summary>Respuesta</summary>
	<p>Zonas de disponibilidad</p>
	<small>Las zonas de disponibilidad son centros de datos separados físicamente dentro de una región de Azure. Cada zona de disponibilidad consta de uno o varios centros de datos equipados con alimentación, refrigeración y redes independientes.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-core-architectural-components-of-azure/">Descripción de los principales componentes arquitectónicos de Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

59. ¿Qué puede usar para proporcionar a los usuarios de Mac y Android acceso a un entorno de Windows que ejecutará aplicaciones basadas en Windows?

<details>
	<summary>Respuesta</summary>
	<p>Azure Virtual Desktop</p>
	<small>Azure Virtual Desktop es un servicio de virtualización de escritorios y aplicaciones que se ejecuta en la nube. Permite que los usuarios usen una versión hospedada en la nube de Windows desde cualquier ubicación. Azure Virtual Desktop funciona en dispositivos como Windows, Mac, iOS, Android y Linux. Funciona con aplicaciones que se pueden usar para acceder a aplicaciones y Escritorios remotos. También puede usar la mayoría de los exploradores modernos para acceder a experiencias hospedadas en Azure Virtual Desktop.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-azure-compute-networking-services/">Descripción de los servicios de proceso y redes de Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

60. ¿Qué puede usar para proporcionar a los usuarios de Mac y Android acceso a un entorno de Windows que ejecutará aplicaciones basadas en Windows?

<details>
	<summary>Respuesta</summary>
	<p>Azure Container Instances y Azure Kubernetes Service (AKS)</p>
	<small>Los contenedores son un entorno de virtualización. Al igual que la ejecución de varias máquinas virtuales en un solo host físico, se pueden ejecutar varios contenedores en un solo host físico o virtual. A diferencia de las máquinas virtuales, no se administra el sistema operativo de un contenedor.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-azure-compute-networking-services/">Descripción de los servicios de proceso y redes de Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

61. ¿Qué nivel de almacenamiento de blobs de Azure almacena los datos sin conexión y ofrece los costos de almacenamiento más bajos y los costos más altos para acceder a los datos?

<details>
	<summary>Respuesta</summary>
	<p>Archivar</p>
	<small>El nivel de almacenamiento de archivo almacena datos sin conexión y ofrece los menores costos de almacenamiento, pero los mayores costos de acceso y rehidratación de datos.
	El nivel de almacenamiento de acceso frecuente está optimizado para almacenar datos a los que se accede con frecuencia.
	Los datos del nivel de acceso esporádico pueden tolerar una disponibilidad ligeramente inferior, pero aun así requieren una gran durabilidad, una latencia de recuperación y unas características de rendimiento similares a las de los datos de acceso frecuente.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-azure-storage-services/">Descripción de los servicios de almacenamiento de Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

62. ¿Qué tipo de estrategia usa una serie de mecanismos para ralentizar el avance de un ataque que pretende obtener acceso no autorizado a los datos?

<details>
	<summary>Respuesta</summary>
	<p>defensa en profundidad</p>
	<small>Una estrategia de defensa en profundidad usa una serie de mecanismos para ralentizar el avance de un ataque dirigido a adquirir acceso no autorizado a los datos. El principio de privilegios mínimos significa restringir el acceso a la información solo al nivel que los usuarios necesitan para realizar su trabajo. Un ataque DDoS intenta sobrecargar y agotar los recursos de una aplicación. La capa perimetral trata sobre la protección de los recursos de su organización frente a ataques basados en la red.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-azure-identity-access-security/">Descripción de la identidad, el acceso y la seguridad en Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

63. ¿Qué característica de Microsoft Entra se puede usar para configurar la autenticación de seguridad que requiere que los usuarios usen su teléfono móvil para iniciar sesión?

<details>
	<summary>Respuesta</summary>
	<p>autenticación multifactor (MFA)</p>
	<small>La MFA es el concepto de requerir algo más que una contraseña para iniciar sesión en una aplicación. Puede usar el teléfono móvil para recibir una llamada telefónica, un mensaje de texto o un código para autenticarse.
	<a href = "https://learn.microsoft.com/training/modules/secure-aad-users-with-mfa/2-azure-multi-factor-authentication">Descripción de la identidad, el acceso y la seguridad en Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

64. ¿Qué dos servicios proporciona Microsoft Entra? Cada respuesta correcta presenta una solución completa.

<details>
	<summary>Respuesta</summary>
	<p>autenticación y inicio de sesión único (SSO)</p>
	<small>Azure AD proporciona servicios para comprobar la identidad y el acceso a las aplicaciones y los recursos. El inicio de sesión único le permite recordar un único nombre de usuario y una contraseña para acceder a varias aplicaciones y está disponible en Azure AD.
	<a href = "https://learn.microsoft.com/training/modules/secure-aad-users-with-mfa/2-azure-multi-factor-authentication">Descripción de la identidad, el acceso y la seguridad en Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

65. ¿Qué se puede usar para sincronizar identidades desde un dominio de Active Directory Domain Services (AD DS) local con Microsoft Entra?

<details>
	<summary>Respuesta</summary>
	<p>Microsoft Entra Connect</p>
	<small>Microsoft Entra Connect sincroniza las identidades de usuario desde un dominio de Active Directory Domain Services (AD DS) local a Microsoft Entra. Microsoft Entra Connect permite usar características, como el inicio de sesión único (SSO), la MFA y el autoservicio de restablecimiento de contraseña (SSPR) en ambos sistemas. SSPR impide que los usuarios usen contraseñas en peligro conocidas.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-azure-identity-access-security/">Descripción de la identidad, el acceso y la seguridad en Azure: aprendizaje | Microsoft Learn</a>
	</small>
</details>

66. ¿Qué dos características son beneficios comunes de la informática en la nube? Cada respuesta correcta presenta una solución completa.

<details>
	<summary>Respuesta</summary>
	<p>distribución geográfica y alta disponibilidad</p>
	<small>Las aplicaciones basadas en la nube pueden proporcionar una experiencia de usuario continua sin tiempo de inactividad aparente, incluso cuando las cosas van mal. puede implementar aplicaciones y datos en centros de datos regionales de todo el mundo, lo que garantiza que sus clientes siempre tendrán el mejor rendimiento de su región. Las aplicaciones de informática en la nube se pueden escalar vertical y horizontalmente. En un modelo de nube pública, no obtiene acceso físico a los servidores, ya que los administra el proveedor de nube.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-cloud-compute/">Descripción de la informática en la nube: formación | Microsoft Learn</a>
	</small>
</details>

67. ¿Qué modelo de implementación en la nube usa si tiene servidores ubicados físicamente en el centro de datos del sitio de su organización y migra algunos de los servidores a la nube?

<details>
	<summary>Respuesta</summary>
	<p>nube híbrida</p>
	<small>Una nube híbrida es un entorno informático que combina una nube pública y una nube privada, lo que permite compartir datos y aplicaciones entre ellas.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-cloud-compute/">Descripción de la informática en la nube: formación | Microsoft Learn</a>
	</small>
</details>

68. ¿De qué depende la alta disponibilidad de un entorno en la nube pública?

<details>
	<summary>Respuesta</summary>
	<p>el contrato de nivel de servicio (SLA) que elija</p>
	<small>Los diferentes servicios tienen distintos Acuerdos de Nivel de Servicio. A veces, diferentes niveles del mismo servicio ofrecerán contratos de nivel de servicio diferentes, lo que puede aumentar o disminuir la disponibilidad prometida.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-benefits-use-cloud-services/">Descripción de las ventajas de usar servicios en la nube: formación | Microsoft Learn</a>
	</small>
</details>

69. Seleccione la respuesta que complete correctamente la oración.

En la informática en la nube, [elija la respuesta] permite implementar aplicaciones en centros de datos regionales de todo el mundo.

<details>
	<summary>Respuesta</summary>
	<p>geoubicación</p>
	<small>puede implementar aplicaciones y datos en centros de datos regionales de todo el mundo, lo que garantiza que sus clientes siempre tendrán el mejor rendimiento de su región. Esto se conoce como distribución geográfica.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-benefits-use-cloud-services/">Descripción de las ventajas de usar servicios en la nube: formación | Microsoft Learn</a>
	</small>
</details>

70. Seleccione la respuesta que complete correctamente la oración.

El aumento de la capacidad de una aplicación mediante la adición de una máquina virtual adicional se denomina [elija la respuesta].

<details>
	<summary>Respuesta</summary>
	<p>escalado horizontal</p>
	<small>El escalado horizontal aumenta la capacidad de proceso mediante la adición de instancias de recursos, como la incorporación de máquinas virtuales a la configuración.
	Escale verticalmente para aumentar la capacidad de proceso mediante la incorporación de RAM o CPU adicionales a una máquina virtual. 
	Agilidad hace referencia a la capacidad de implementar rápidamente nuevas aplicaciones y servicios.
	La alta disponibilidad minimiza el tiempo de inactividad cuando las cosas salen mal.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-benefits-use-cloud-services/">Descripción de las ventajas de usar servicios en la nube: formación | Microsoft Learn</a>
	</small>
</details>

71. ¿En qué dos modelos de implementación son los clientes responsables de administrar sistemas operativos que hospedan aplicaciones? Cada respuesta correcta presenta una solución completa.

<details>
	<summary>Respuesta</summary>
	<p>infraestructura como servicio (IaaS) y entorno local</p>
	<small>Los clientes administran los sistemas operativos cuando se usan IaaS o implementaciones locales. Los sistemas operativos no son accesibles en las implementaciones de PaaS y SaaS.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-cloud-service-types/">Descripción de los tipos de servicio en la nube: aprendizaje | Microsoft Learn</a>
	</small>
</details>

72. ¿Qué modelo de servicio en la nube proporciona el mayor control sobre el hardware que ejecuta aplicaciones?

<details>
	<summary>Respuesta</summary>
	<p>infraestructura como servicio (IaaS)/p>
	<small>IaaS es la categoría más flexible de servicios en la nube. Su objetivo es ofrecer un control completo sobre el hardware que ejecuta las aplicaciones. Los usuarios no controlan el sistema operativo y no configuran los servidores subyacentes en las PaaS. Con el SaaS, está usando el software tal como está hospedado en la nube, en lugar de crear una plataforma para hospedar un software usted mismo.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-cloud-service-types/">Descripción de los tipos de servicio en la nube: aprendizaje | Microsoft Learn</a>
	</small>
</details>

73. ¿Qué tipo de modelo de servicio en la nube normalmente se licencia a través de una suscripción mensual o anual?

<details>
	<summary>Respuesta</summary>
	<p>software como servicio (SaaS)/p>
	<small>SaaS es software que se hospeda y administra de forma centralizada para usted y sus usuarios o clientes. Normalmente se usa una versión de la aplicación para todos los clientes y la licencia se obtiene mediante una suscripción mensual o anual. PaaS e IaaS usan un modelo basado en el consumo, por lo que solo se paga por lo que se usa.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-cloud-service-types/">Descripción de los tipos de servicio en la nube: aprendizaje | Microsoft Learn</a>
	</small>
</details>

74. ¿Qué modelo de servicio en la nube usa Microsoft Office 365?

<details>
	<summary>Respuesta</summary>
	<p>software como servicio (SaaS)/p>
	<small>El software como servicio (SaaS) permite que los usuarios se conecten y usen aplicaciones basadas en la nube a través de Internet. Algunos ejemplos comunes son el correo electrónico, el calendario y las herramientas de Office, como Office 365.
	<a href = "https://learn.microsoft.com/en-us/training/modules/describe-cloud-service-types/">Descripción de los tipos de servicio en la nube: aprendizaje | Microsoft Learn</a>
	</small>
</details>
