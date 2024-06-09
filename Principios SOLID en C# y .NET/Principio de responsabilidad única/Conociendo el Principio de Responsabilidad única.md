

# Definición

El **principio de responsabilidad única (SRP)** establece que cada clase o módulo en un programa debe tener una única responsabilidad. En otras palabras, una clase solo debe tener una razón para cambiar.

# Beneficios

- **Mejora la modularidad:** Permite dividir el código en unidades más pequeñas y cohesivas.
- **Facilita el mantenimiento:** Hace que el código sea más fácil de entender y modificar.
- **Reduce la acoplamiento:** Limita la dependencia entre diferentes partes del código.
- **Mejora la testabilidad:** Permite escribir pruebas unitarias más precisas.

# Cómo aplicar el SRP en C\#

- **Identificar las responsabilidades:** Divide la funcionalidad del programa en responsabilidades discretas.
- **Agrupar las responsabilidades:** Agrupa las responsabilidades relacionadas en clases o módulos.
- **Utilizar interfaces:** Define interfaces para abstraer las responsabilidades.
- **Evitar la dependencia mutua:** Minimiza la dependencia entre diferentes clases o módulos.

## Ejemplos de aplicación del SRP

Como usuario luego de confirmar la compra espero ver un **mensaje de confirmación**, tener la posibilidad de **descargar la factura** y un **correo electrónico de confirmación**.

- **Clase** `Persona`**:** Tiene la responsabilidad de almacenar información personal (nombre, dirección, etc.).
- **Clase** `Calculadora`**:** Tiene la responsabilidad de realizar operaciones matemáticas (suma, resta, etc.).
- **Clase** `Repositorio`**:** Tiene la responsabilidad de acceder y modificar datos en una base de datos.

# Violaciones del SRP

- **Clases con múltiples responsabilidades:** Una clase que gestiona la interfaz de usuario y la lógica de negocio.
- **Clases con responsabilidades no relacionadas:** Una clase que calcula impuestos y también envía correos electrónicos.

