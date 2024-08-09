namespace EXERCICIOS_ESTRUTURA_CONDICIONAIS_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8 - Crie um programa que peça ao usuário para inserir três números e, em seguida, verifique se eles 
            //podem formar um triângulo válido(a soma de dois lados é maior que o terceiro lado).

            Console.WriteLine("Preciso que insira 3 números para formar um triângulo.");
            Console.WriteLine("Para formar o triângulo é preciso que os dois lado sejam maiores do que o ultimo lado digitado.");
            Console.WriteLine("Ex: \n(primeiro número) 5, (segundo número) 7, (terceiro número) 3");


            Console.WriteLine("Insira o primeiro número: ");
            int num1 = int.Parse (Console.ReadLine());

            Console.WriteLine("Insira o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro número: ");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 + num2 > num3) 
            {
                Console.WriteLine("O triangulo foi concluido!!");
            }
            else
            {
                Console.WriteLine("Não foi possível concluir o triangulo. Tente novamente.");
            }
        }
    }
}
