

# ¿Qué son las buenas practicas y el código limpio?

## Buenas prácticas-Best practices

- Nos permiten resolver conflictos de escenarios comunes.
- Brindan guías que son sencillas de comprender, aprender y aplicar.
- Permiten contar con una estructura similar para múltiples proyectos.

### Diferencia entre buenas prácticas y estándares

- Las buenas prácticas ya están comprobadas; pues han sido utilizadas muchas veces y esto comprueba su funcionalidad. Estas ayudan a tener un mejor código, arquitectura y a comprender fácilmente el código.

## Código limpio- Clean code

- Se refiere a buenas prácticas dirigidas al código.
- Es fácil de entender, analizar, mantener, actualizar y escalar.

### ¿Cómo lograr código limpio?_

Algunas reglas a seguir son:

- Mantener bajo acoplamiento. Se busca que no exista dependencia entre componentes.
- Uso de sintaxis simple y actual.
- Evitar incorporar muchas librerías de terceros. Para evitar dependencias y mantener el control del código.
- Distribución de responsabilidades. Cada componente debe contar con una sola responsabilidad específica.
- Crear componentes pequeños.

## Libro recomendado

![[Pasted image 20240607191834.png]]


 **SOLID** nos ayuda a **tener código limpio y buenas practicas**

#  ¿Que son los principios SOLID?

## SOLID
### S. Single responsibility principle-Principio de responsabilidad única.

Debemos asignar una única responsabilidad a cada uno de los componentes.

### O. Open/closed principle- Principio de abierto/cerrado.

El código debe estar abierto a extensiones y cerrado a cambios.

### L. Liskov substitution principle-Principio de sustitución de Liskov.

Relación entre tipos y subtipos dentro del sistema.

### I. Interface segregation principle- Principio de segregación de la interfaz

Ayuda a asignar una responsabilidad específica a cada una de las interfaces que tiene el sistema.

### D. Dependency inversion principle- Principio de inversión de la dependencia.

Inyección de dependencias y el evitar el acoplamiento.

## Características de SOLID

- Orientado al paradigma de orientación a objetos (POO)
    
- Se le atribuye a Robert C. Martin
    
- Diseño y refactorización de código
    
- Se debe implementar desde el inicio del proyecto cuando se crean los componentes.
    

## SOLID Ayuda a:

- Lograr código escalable
    
- Evitar deuda técnica (Technical debt)
    
- Plantear los fundamentos para el desarrollo guiado por pruebas (TDD)
    
- Tener un estándar claro en cada uno de los proyectos de un portafolio


# Recursos

https://learn.microsoft.com/es-es/archive/msdn-magazine/2014/may/csharp-best-practices-dangers-of-violating-solid-principles-in-csharp

