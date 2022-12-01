namespace _25_11_2022
{
    internal class Program
    {


        



            public Perro(string apellido)
            {
                Nombre = apellido;
            }

            public Perro() : this("No se el nombre", -1)
        {

            }

            //Metodo para propiedades, se pone en privado porque no
            private string QuitarTildes(string algo)
            {

            }

            //Metodo que da una acción
            public void Caminar(int x, int y)
            {
                Console.WriteLine("Camino");

                int poxX += x;
                int poxY += y;
            }

        
    }