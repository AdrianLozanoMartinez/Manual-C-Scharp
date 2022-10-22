/*El punto de ruptura se pone en el lado izquierdo señalando con un círculo rojo y si le damos botón derecho
podemos poner una condición, por ejemplo que acabe antes un ciclo o probar un valor.
Para que funcione le damos a la flecha verde con el nombre del proyecto y para ir viendo los pasos le damos a
continuar*/
class Program
 {
     const int TIRADAS = 50; 
     static readonly DateTime NOW = DateTime.Now; 

     static void Main()
     {
         for (int i=0; i< TIRADAS; i++)  //Si se pone aquí el punto de ruptura, se ve i=0 y TIRADA = 50
                                         //Si da una vuelta sería i=1 y YIRADA = 50 y así va sumando +1
                                         //hasta llegar a 50
         {  //int i=10 -> SI PONEMOS CONDICIÓN DE PUNTO DE RUTURA AQUÍ i==10 SE VERÁ EL VALOR EN EL 1º i como 10
            Console.WriteLine(i);
         }
         Console.WriteLine(NOW);  
     }
 }