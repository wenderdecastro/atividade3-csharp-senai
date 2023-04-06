for (var pessoas = 0; pessoas <= 10; pessoas++)
{
    do
    {
        Console.WriteLine($" Qual o seu sexo? Pressione 1 para homem e 2 para mulher. \r \n");

        ConsoleKeyInfo inputSexo = Console.ReadKey();

        if (inputSexo.Key == ConsoleKey.D1 || inputSexo.Key == ConsoleKey.D2)
        {
            sexoValido = true;
        }
        else
        {
            sexoValido = false;
        }


        switch (inputSexo.Key)
        {
            case ConsoleKey.D1:

                inputValido = false;

                Console.WriteLine($"Você selecionou a opção homem.");

                numHomens++;

                Console.WriteLine($"Qual a sua idade?");
                int idade = int.Parse(Console.ReadLine());
                

                break;
            case ConsoleKey.D2:

                inputValido = false;

                Console.WriteLine($"Você selecionou a opção mulher.");

                numMulheres++;

                break;
        }
    } while (sexoValido == false);






}