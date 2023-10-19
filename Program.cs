using System;

{
    string[] nomes = { "matheus", "davi", "valentina", "andrea" };


    Console.WriteLine("escreva um nome");

    {
        if (Console.ReadLine() == "matheus" || Console.ReadLine() == "davi")
        {
            Console.WriteLine("este nome esta listado e o sujeito e homem");
        }

        else if (Console.ReadLine() == "andrea" || Console.ReadLine() == "valentina")
        {

            Console.WriteLine("este nome esta listado e o sujeito e mulher");
        }
        else
        {

            Console.WriteLine("o nome nao esta listado");
        }
    }
}





            //int matheus;
            //int davi;
            //int andrea;
            //int valentina;      
