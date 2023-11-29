using System;

namespace RomanoAEntero{

    class Program
    {

        // Crear objeto con números romanos y sus correspondientes valores numéricos
        private static Dictionary<char, int> TablaRomanos = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };


        static bool EsNumeroRomanoValido(string numeroRomano)
        {

            char letraAnterior = '\0'; // Inicializar con un valor que no sea un número romano válido
            int repeticionContador = 1; // Contador para controlar la repetición

            // Recorrer número romano letra a letra
            foreach (char letra in numeroRomano)
            {
                // Verificar si la letra es un carácter romano válido
                if (!TablaRomanos.ContainsKey(letra))
                {
                    Console.WriteLine("Número romano no válido. Carácter inválido: " + letra);
                    return false;
                }

                // Verificar reglas de repetición de caracteres
                if (letra == letraAnterior)
                {
                    repeticionContador++;

                    Console.WriteLine("La letra " + letra + " se esta repitiendo por " + repeticionContador + " veces");

                    if (letra == 'V' || letra == 'L' || letra == 'D')
                    {
                        Console.WriteLine("Número romano no válido. El carácter '" + letra + "' no puede repetirse.");
                        return false;
                    }
                    if (repeticionContador > 3)
                    {
                        Console.WriteLine("Número romano no válido. El carácter '" + letra + "' se repite más de tres veces.");
                        return false;
                    }
                }
                else{
                    repeticionContador = 1;
                }



                // Verificar reglas de sustracción
                if (letraAnterior != '\0' && TablaRomanos[letra] > TablaRomanos[letraAnterior])
                {
                    if (!EsSustraccionValida(letraAnterior, letra))
                    {
                        Console.WriteLine("Número romano no válido. Regla de sustracción no cumplida: " + letraAnterior + letra);
                        return false;
                    }
                }

                letraAnterior = letra; // Actualizar la letra anterior
            }

            // Si no se encontraron problemas, el número romano es válido
            return true;
        }

        static bool EsSustraccionValida(char izquierda, char derecha)
        {
            // Definir pares de caracteres permitidos para sustracción
            HashSet<string> paresValidos = new HashSet<string> { "IV", "IX", "XL", "XC", "CD", "CM" };
            
            // Formar el par a partir de los caracteres dados
            string par = izquierda.ToString() + derecha.ToString();
            
            // Verificar si el par es válido
            return paresValidos.Contains(par);
        }

        public static int RomanoAEntero(string Romano)
        {
            // Crear variable para almacenar resultado
            int resultado = 0;

            if(!EsNumeroRomanoValido(Romano)){
                Console.WriteLine("El número romano " + Romano + " no es válido.");
                resultado = -1;
                return resultado;
            }
            else{
                Console.WriteLine("El número romano " + Romano + " es válido.");
                // Recorrer número romano letra a letra con foreach
                
                for(int i = 0; i < Romano.Length; i++){
                    if(i == Romano.Length - 1 || TablaRomanos[Romano[i+1]] <= TablaRomanos[Romano[i]]){
                        resultado += TablaRomanos[Romano[i]];
                    }
                    else{
                        resultado -= TablaRomanos[Romano[i]];
                    }
                }

                // Devolver el resultado
                return resultado;
            }

        }

        static void Main()
        {
            string numeroRomano = "MDCCCLXXXXIV";

            Console.WriteLine(RomanoAEntero(numeroRomano));
        }
    }
}