
float num1;
float num2;
float resultadoSoma;
float resultadoSub;
float resultadoMulti;
float resultadoDivisao;
string operacao;


Console.Write("Digite o primeiro número: ");
num1 = float.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
num2 = float.Parse(Console.ReadLine());

Console.Write("\nDigite a operação matemática | Soma (+) | Subtração (-) | Multiplicação (*) | Divisão (/) | : ");
operacao = Console.ReadLine();


if (operacao == "Soma" || operacao == "soma")
{
    resultadoSoma = num1 + num2;
    Console.WriteLine("\nA soma de {0} e {1} é: {2}", num1, num2, resultadoSoma);
}

else if (operacao == "Subtração" || operacao == "subtração" || operacao == "subtracao" || operacao == "Subtracao")
{
    resultadoSub = num1 - num2;
    Console.WriteLine("A subtração de {0} e {1} é: {2} ", num1, num2, resultadoSub);
}



else if (operacao == "multiplicação" || operacao == "multiplicacao" || operacao == "Multiplicação" || operacao == "Multiplicacao")
{
    resultadoMulti = num1 * num2;
    Console.WriteLine("A multiplicação de {0} e {1} é: {2} ", num1, num2, resultadoMulti);
}

else if (operacao == "Divisão" || operacao == "Divisao" || operacao == "divisão" || operacao == "divisao")
{
    if (num2 == 0)
    {
        Console.WriteLine("Impossivel dividir por zero!");
    }


    else if (num2 < 0)
    {
        Console.WriteLine("Impossivel dividir por números negativos");
    }


    else
    {
        resultadoDivisao = num1 / num2;
        Console.WriteLine("A divisão de {0} e {1} é: {2}", num1, num2, resultadoDivisao);
    }

}

else
{
    Console.WriteLine("Operação inválida.");
}
    
    Console.ReadLine();