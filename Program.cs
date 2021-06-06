using System;

namespace Projeto_em_c_
{
    class Program
    {
        static void Main(string[] args){
            double x, y, media;
            Console.Write("digite primeiro numero");
            x=double.Parse(Console.ReadLine());
            Console.Write("digite o segundo numero");
            y=double.Parse(Console.ReadLine());
            media = (x + y) / 2.0;
            Console.WriteLine("Media = "+ media);
        }
    }
}

