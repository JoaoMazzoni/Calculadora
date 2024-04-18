
using System.Xml;

float num1;
float num2;
float resultadoSoma;
float resultadoSub;
float resultadoMulti;
float resultadoDivisao;
string operacao;

while (true)
{
    Console.Write("Digite o primeiro número: ");
    num1 = float.Parse(Console.ReadLine());

    Console.Write("Digite o segundo número: ");
    num2 = float.Parse(Console.ReadLine());

    Console.Write("\nDigite a operação matemática | Soma (+) | Subtração (-) | Multiplicação (*) | Divisão (/) | : ");
    operacao = Console.ReadLine();


    if (operacao == "Soma" || operacao == "soma" || operacao == "+")
    {
        resultadoSoma = num1 + num2;
        Console.WriteLine("\nA soma de {0} e {1} é: {2}", num1, num2, resultadoSoma);
    }

    else if (operacao == "Subtração" || operacao == "subtração" || operacao == "subtracao" || operacao == "Subtracao" || operacao == "-")
    {
        resultadoSub = num1 - num2;
        Console.WriteLine("\nA subtração de {0} e {1} é: {2} ", num1, num2, resultadoSub);
    }



    else if (operacao == "multiplicação" || operacao == "multiplicacao" || operacao == "Multiplicação" || operacao == "Multiplicacao" || operacao == "*")
    {
        resultadoMulti = num1 * num2;
        Console.WriteLine("\nA multiplicação de {0} e {1} é: {2} ", num1, num2, resultadoMulti);
    }

    else if (operacao == "Divisão" || operacao == "Divisao" || operacao == "divisão" || operacao == "divisao" || operacao == "/")
    {
        if (num2 == 0)
        {
            Console.WriteLine("\nImpossivel dividir por zero!");
        }



        else
        {
            resultadoDivisao = num1 / num2;
            Console.WriteLine("\n|A divisão de {0} e {1} é: {2}|", num1, num2, resultadoDivisao);
        }

    }

    else
    {
        Console.WriteLine("\n|Operação inválida!|");
    }

    Console.WriteLine("\n\nAperte qualquer tecla para voltar do ínico.");
    Console.ReadKey();
    Console.Clear();
}

