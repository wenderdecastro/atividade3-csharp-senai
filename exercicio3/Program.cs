int num = 0;
bool valorValido = false;

do
{

    Console.WriteLine("Insira um numero: ");

    string input = (Console.ReadLine());

    if (int.TryParse(input, out num))
    {
        valorValido = true;
    }


} while (valorValido == false);

Console.WriteLine(@$"A tabuada do numero {num} é:
{num} . 1 = {num * 1}
{num} . 2 = {num * 2}
{num} . 3 = {num * 3}
{num} . 4 = {num * 4}
{num} . 5 = {num * 5}
{num} . 6 = {num * 6}
{num} . 7 = {num * 7}
{num} . 8 = {num * 8}
{num} . 9 = {num * 9}
{num} . 10 = {num * 10}
");

