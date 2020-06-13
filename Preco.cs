using System;

namespace ex2
{
    public class Preco:Viajem
    {
        public void mostrarPreco(){
            Console.WriteLine("Ola {0}",usuario);
             string preco="100,00";

            DetectarRota();
            Console.WriteLine("Preço de {0}",preco);

            
        }
    }
}