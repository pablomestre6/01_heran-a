using System;

namespace _01_herança
{
    class Program
    {
        static void Main(string[] args)
        {
            carro c = new carro();
            c.modelo = "Fuscão";

            c.QuantidadeDePorta = 6;
            
            c.ano = 1970;

            Console.WriteLine("carro");

            Console.WriteLine("modelo:"+c.modelo);
            
            Console.WriteLine("portas:"+c.QuantidadeDePorta);

            Console.WriteLine("ano:" + c.ano);
              
              //MOTO

              moto a = new moto();

            a.modelo = "bizz 125";
            
            a.ano = 1970;

            Console.WriteLine("moto");

            Console.WriteLine("modelo:" + a.modelo);
            
            Console.WriteLine("ano:" + a.ano);

        
        }
    }
}
