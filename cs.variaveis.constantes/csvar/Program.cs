string[] nomes = { "matheus", "davi", "valentina", "andrea" };


    Console.WriteLine("escreva um nome");

    string nomePesquisa = Console.ReadLine();

    bool existe = false;

    foreach (string nome1 in nomes)
    {
        if (nomePesquisa == nome1)
        {
            // if (nome1 == "matheus" || nome1 == "davi")
            // {
            //     Console.WriteLine("este nome esta listado e o sujeito e homem");
            // }
            // else if(nome1 == "andrea" || nome1 == "valentina")
            // {
            //     Console.WriteLine("este nome esta listado e o sujeito e mulher");
            // }   
            //Console.WriteLine("o nome esta listado");
            
            existe = true;
            
        }
        // else{
        //     Console.WriteLine("o nome nao esta listado");
           
        // }

    }
    if(existe)
    {
        Console.WriteLine("o nome esta listado");

    }
    else
    {
        Console.WriteLine("o nome nao esta listado");
    }
            
        
    //     {
    //         Console.WriteLine("este nome esta listado e o sujeito e homem");
    //     }

    //     else if (nomePesquisa == "andrea" || nomePesquisa == "valentina")
    //     {

    //         Console.WriteLine("este nome esta listado e o sujeito e mulher");
    //     }
    //     else
    //     {

    //     }





    // }


    // string nomePesquisa = Console.ReadLine();
    
    //     if (nomePesquisa == nome1)
    //     {
    //         Console.WriteLine("este nome esta listado e o sujeito e homem");
    //     }

    //     else if (nomePesquisa == "andrea" || nomep
    //      == "valentina")
    //     {

    //         Console.WriteLine("este nome esta listado e o sujeito e mulher");
    //     }
    //     else
    //     {

    //         Console.WriteLine("o nome nao esta listado");
    //     }
    































//  string[] nomes = { "matheus", "davi", "valentina", "andrea" };
     
// Console.WriteLine("escreva um nome");
// string? nomePesquisa =  Console.ReadLine();

//     for (int i = 0; i < nomes.Length; i++)
//     {
//         if (nomes[i] == nomePesquisa)
//         {
//             Console.WriteLine("Existe");
//         }
//         else
//         {
//             Console.WriteLine("Existe");
//         }
//     }
    // for (int i = 0; i < nomes.Length; i++)
    // {
    //     if (nomes[1] == "andrea" || nomes[1] == "valentina")
    //     {

    //         Console.WriteLine("este nome esta listado e o sujeito é mulher");
    //     }
    // }

        // else
        // {

        //     Console.WriteLine("o nome nao esta listado");
        // }
















    // string[] nomes = { "matheus", "davi", "valentina", "andrea" };
     

    // Console.WriteLine("escreva um nome");
    // for (int i = 0; i < nomes.Length; i++)
    // {
    //     if (nomes[i] == "matheus" || nomes[i] == "davi")
    //     {
    //         Console.WriteLine("este nome esta listado e o sujeito é homem");
    //     }

    // }

    // string? nome = Console.ReadLine();
    // {
        
    //     if (nome == "matheus" || nome == "davi")
    //     {
    //         Console.WriteLine("este nome esta listado e o sujeito é homem");
    //     }

    //     else if (nome == "andrea" || nome == "valentina")
    //     {

    //         Console.WriteLine("este nome esta listado e o sujeito é mulher");
    //     }
    //     else
    //     {

    //         Console.WriteLine("o nome nao esta listado");
    //     }
    // }






//         foreach (string nome1 in nomes)
// {
//     Console.WriteLine(nome1);
// }

// List<string> nome3 = new()
// {
//     "matheus",
//     "Andrea"
// };

// foreach (var item in nome3)
// {
//     Console.WriteLine(item);  
// };