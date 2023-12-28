

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

27. s

<details>
	<summary>Respuesta</summary>
	<p></p>
	<small></small>
</details>

28. s

<details>
	<summary>Respuesta</summary>
	<p></p>
	<small></small>
</details>

29. s

<details>
	<summary>Respuesta</summary>
	<p></p>
	<small></small>
</details>

30. s

<details>
	<summary>Respuesta</summary>
	<p></p>
	<small></small>
</details>

31. s

<details>
	<summary>Respuesta</summary>
	<p></p>
	<small></small>
</details>