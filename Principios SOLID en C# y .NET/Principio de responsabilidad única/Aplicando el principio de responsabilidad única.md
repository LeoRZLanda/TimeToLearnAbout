

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
using System.Text;

  

namespace SingleResponsability{

    public class ExportHelper{

        public void ExportHelper(IEnumerable<Student> students){

            IEnumerable<Student> students = this.GetAll();

            string csv = String.Join(",", students.Select(x => x.ToString()).ToArray());

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine("Id;Fullname;Grades");

            foreach (var item in students)

            {

                sb.AppendLine($"{item.Id};{item.Fullname};{string.Join("|", item.Grades)}");

            }

            System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Students.csv"), sb.ToString(), Encoding.Unicode);

        }

    }

}
```


Eliminaremos de StudentRepository la función de export y añadiremos lo siguiente en:

Program.cs
```cs
using SingleResponsability;

StudentRepository studentRepository = new();
ExportHelper exportHelper = new();
exportHelper.ExportStudents(studentRepository.GetAll());
Console.WriteLine("Proceso Completado");
```



y ahora usando generics podemos mejorar el código para que el componente de ExportHelper quede genérico para todos los posibles modelos que pueda tener la aplicación.


```cs
using System.Collections;

using System.Text;

  

namespace SingleResponsability

{

    public class ExportHelper<T>

    {

        public void ExportToCSV(IEnumerable<T> items)

        {

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            string header = "";

            string[] dataRows = new string[items.Count()];

            foreach (var prop in typeof(T).GetProperties())

            {

                header += $"{prop.Name};";

                for (int i = 0; i < items.Count(); i++)

                {

                    var propValue = prop.GetValue(items.ToArray()[i]);

                    var propType = propValue.GetType();

                    if(propType.Name != nameof(String)

                        && propType.GetInterface(nameof(IEnumerable)) != null)

                    {

                        dataRows[i] += $"{String.Join("|", (propValue as IEnumerable).Cast<object>().Select(x => x.ToString()))};";

  

                    }

                    else

                    {

                        dataRows[i] += $"{propValue};";

                    }

                }

            }

            sb.AppendLine(header.Trim(';'));

            foreach (var dataRow in dataRows)

            {

                sb.AppendLine(dataRow.Trim(';'));

            }

            System.IO.File.WriteAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Export_{typeof(T).ToString()}.csv"), sb.ToString(), Encoding.Unicode);

        }

    }

}
```