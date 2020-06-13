using System;

namespace ex2
{
    public class Mapa:App
    {

        public string localizacao="Rua xyz";
        public void MostrarMapa(string rota){

            Console.WriteLine(" ---------------------");
            Console.WriteLine("|                      |");
            Console.WriteLine("|                      |");
            Console.WriteLine("|       Mapa           |");
            Console.WriteLine("|                      |");
            Console.WriteLine("|                      |");
            Console.WriteLine("|                      |");
            Console.WriteLine("|                      |");
            Console.WriteLine(" ----------------------");
            Console.WriteLine(" Rota {0}",rota);

        }
    }
}