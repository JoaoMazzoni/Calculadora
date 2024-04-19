
float num1 = 0;
float num2 = 0;
float num3 = 0;
float num4 = 0;
float resultadoSoma;
float resultadoSub;
float resultadoMulti;
float resultadoDivisao;
string operacao;
bool controleTrueFalse;

while (true)
{

    Console.Write("\nDigite o primeiro número: ");
    num1 = float.Parse(Console.ReadLine());

    while (num2 == 0)
    {
        Console.Write("\nDigite o segundo número: ");
        num2 = float.Parse(Console.ReadLine());
        if(num2 == 0)
        {
            controleTrueFalse = false; 

            if (controleTrueFalse == false) 
            {
                Console.WriteLine("\nO número não pode ser zero!");
            }
        }
    } 

    do
    {
        Console.Write("\nDigite o terceiro número: ");
        num3 = float.Parse(Console.ReadLine());
        if (num3 == 0)
        {
            controleTrueFalse = false;

            if (controleTrueFalse == false)
            {
                Console.WriteLine("\nO número não pode ser zero!");
            }
        }

    } while (num3 == 0);


    for (num4 = 0 ; num4 == 0;)
    {
        Console.Write("\nDigite o quarto número: ");
        num4 = float.Parse(Console.ReadLine());
        if (num4 == 0)
        {
            controleTrueFalse = false;

            if (controleTrueFalse == false)
            {
                Console.WriteLine("\nO número não pode ser zero!");
            }
        }
    }


    do {
        Console.Write("\nDigite a operação matemática | Soma (+) | Subtração (-) | Multiplicação (*) | Divisão (/) | : ");
        operacao = Console.ReadLine();


        if (operacao == "Soma" || operacao == "soma" || operacao == "+")
        {
            resultadoSoma = num1 + num2 + num3 + num4;
            Console.WriteLine("\nA soma de {0} + {1} + {2} + {3} é: {4}", num1, num2, num3, num4, resultadoSoma);
            controleTrueFalse = true;
        }

        else if (operacao == "Subtração" || operacao == "subtração" || operacao == "subtracao" || operacao == "Subtracao" || operacao == "-")
        {
            resultadoSub = num1 - num2 - num3 - num4;
            Console.WriteLine("\nA subtração de {0} - {1} - {2} - {3} é: {4} ", num1, num2, num3, num4, resultadoSub);
            controleTrueFalse = true;
        }


        else if (operacao == "multiplicação" || operacao == "multiplicacao" || operacao == "Multiplicação" || operacao == "Multiplicacao" || operacao == "*")
        {
            resultadoMulti = num1 * num2 * num3 * num4;
            Console.WriteLine("\nA multiplicação de {0} * {1} * {2} * {3} é: {4} ", num1, num2, num3, num4, resultadoMulti);
            controleTrueFalse = true;
        }

        else if (operacao == "Divisão" || operacao == "Divisao" || operacao == "divisão" || operacao == "divisao" || operacao == "/")
        {
            if (num2 == 0 || num3 == 0 || num4 == 0)
            {
                Console.WriteLine("\nImpossivel dividir por zero!");
                controleTrueFalse = false;
            }


            else
            {
                resultadoDivisao = num1 / num2 / num3 / num4;
                Console.WriteLine("\nA divisão de {0} / {1} / {2} / {3} é: {4}", num1, num2, num3, num4, resultadoDivisao);
                controleTrueFalse = true;
            }
        }

        else
        {
            Console.WriteLine("\n|Operação inválida!|");
            controleTrueFalse = false;
        }

    } while (controleTrueFalse ==  false);

    Console.WriteLine("\n\nAperte qualquer tecla para voltar do ínico.");
    Console.ReadKey();
    Console.Clear();
}

