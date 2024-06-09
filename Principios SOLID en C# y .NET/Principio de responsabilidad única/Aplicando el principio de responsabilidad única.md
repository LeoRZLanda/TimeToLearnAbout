

# Escenario

Tenemos una clase StudentRepository encargada de administrar los datos para el modelo student, pero en este momento no cumple con el principio de responsabilidad única, debe solucionarse.


## Prerequisitos

Hay que clonar el siguiente repositorio [curso principios solid csharp](https://github.com/platzi/curso-principios-solid-csharp) de ahi abrir una terminal e ir al directorio correspondinte del principio SingleResponsability y ejecutarlo con dotnet run para ver lo que hace, en este caso exporta en csv las calificaciones de los alumnos


## Situación

Como podemos apreciar la función encargada de exportar a csv se encuentra en la clase StudentRepository, en donde ahi solamente deberia de tener la responsabilidad de administrar los datos de los estudiantes.


## Solución

A continuación recomendare dos opciones que pueden ayudar a administrar mejor las responsabilidades de las clases.

Para poder solucionar este principio, es crear un StudentExport, por ejemplo una clase que tenga como responsabilidad exportar los datos, o si querer crear un componente más genérico podríamos crear un ExportHelper, que se encargue de exportar todos los posibles modelos de datos del sistema.

ExportHelper.cs
```CS

```