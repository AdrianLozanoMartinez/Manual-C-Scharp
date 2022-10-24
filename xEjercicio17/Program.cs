namespace xEjercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 17.
            Diseña un algoritmo que lea un texto de longitud indefinida formado por letras mayúsculas
            (que termina con un punto) y muestre por pantalla la frecuencia con la que aparece cada
            una de las letras del texto.
            Nota: Usa el método Contains(char) de los string*/

            Console.WriteLine("Introduzca un texto y cuando finalice ponga \".\"");
            string text = Console.ReadLine();
            string resultText = "";
            bool isTrue = true;
            int cont = 0;
            int contador = 0;
            char save = ' ';

            for (int i = text.Length - 1; i >= 0 && isTrue; i--)
            {
                for (int j = 0; j < text.Length - 1 && isTrue; j++)
                {
                    resultText += text[text.Length - 1]; //Metemos el caracter de la última posición y lo metemos en la variable para
                                                         //luego comparar con el .
                                                         //takeLetter;
                                                         //StringComparison comparison = StringComparison.OrdinalIgnoreCase;

                    if (text == text.ToUpper() && resultText.Contains('.'))
                    {
                        if (text[i] == text[j] && text[i] != ' ')
                        {
                            cont++;
                            contador = cont;
                            save = text[i];

                        }
                    }
                    else
                    {
                        Console.WriteLine("Introduzca letras mayúsculas y ponga un punto al final");
                        isTrue = false;
                    }
                }
                cont = 0;

                if (contador > 0)
                {
                    Console.WriteLine($"La letra {save} se repite {contador} veces");

                }
            }
        }
    }
}