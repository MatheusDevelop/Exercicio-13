using System;

namespace ex2
{
    public class Viajem:Mapa
    {
        private string motorista="Fabio assunção";

        public string DetectarRota(){
            string Rota="xyz";
            Console.WriteLine("Seu motorista é :{0}",motorista);
            MostrarMapa(Rota);
            return Rota;
        }

        

        

    }
}