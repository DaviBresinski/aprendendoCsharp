using System;

{
    string[] nomes = { "matheus", "davi", "valentina", "andrea" };


    Console.WriteLine("escreva um nome");

    string nome = Console.ReadLine();
    {
        if (nome == "matheus" || nome == "davi")
        {
            Console.WriteLine("este nome esta listado e o sujeito e homem");
        }

        else if (nome == "andrea" || nome == "valentina")
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
