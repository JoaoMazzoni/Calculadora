while (true) { 

    float num1 = 0;
    float num2 = 0;
    float num3 = 0;
    float num4 = 0;
    float resultadoSoma;
    float resultadoSub;
    float resultadoMulti;
    float resultadoDivisao;
    int operacao;
    bool controleTrueFalse;

    Console.WriteLine("\n---==== CALCULADORA ====----\n\n");
    Console.Write("\nDigite o primeiro número: ");
    num1 = float.Parse(Console.ReadLine());

  
        Console.Write("\nDigite o segundo número: ");
        num2 = float.Parse(Console.ReadLine());
        if(num2 == 0)
        {
            controleTrueFalse = false; 
        } 

        Console.Write("\nDigite o terceiro número: ");
        num3 = float.Parse(Console.ReadLine());
        if (num3 == 0)
        {
            controleTrueFalse = false;
        }

        Console.Write("\nDigite o quarto número: ");
        num4 = float.Parse(Console.ReadLine());
        if (num4 == 0)
        {
            controleTrueFalse = false;
        }
   


    do {

        Console.WriteLine("\n\n===========================================\n");
        Console.WriteLine("| 1 | Soma");
        Console.WriteLine("| 2 | Subtração");
        Console.WriteLine("| 3 | Multiplicação");
        Console.WriteLine("| 4 | Divisão");
        Console.WriteLine("\n===========================================\n\n");
        Console.Write("\n|Digite o número da operação matemática: ");
        operacao = int.Parse(Console.ReadLine());


        switch (operacao)
        {

            case 1:
                resultadoSoma = num1 + num2 + num3 + num4;
                Console.WriteLine("\nA soma de {0} + {1} + {2} + {3} é: {4}", num1, num2, num3, num4, resultadoSoma);
                controleTrueFalse = true;
                break;

            case 2:

                resultadoSub = num1 - num2 - num3 - num4;
                Console.WriteLine("\nA subtração de {0} - {1} - {2} - {3} é: {4} ", num1, num2, num3, num4, resultadoSub);
                controleTrueFalse = true;
                break;

            case 3:

                resultadoMulti = num1 * num2 * num3 * num4;
                Console.WriteLine("\nA multiplicação de {0} * {1} * {2} * {3} é: {4} ", num1, num2, num3, num4, resultadoMulti);
                controleTrueFalse = true;
                break;

            case 4:

                if (num2 == 0 || num3 == 0 || num4 == 0)
                {
                    controleTrueFalse = false;
                    Console.WriteLine("\nImpossivel dividir por zero!");
                    
                }

                else
                {
                    controleTrueFalse = true;
                    resultadoDivisao = num1 / num2 / num3 / num4;
                    Console.WriteLine("\nA divisão de {0} / {1} / {2} / {3} é: {4}", num1, num2, num3, num4, resultadoDivisao);
                    
                }
                break;



            default:

                Console.WriteLine("\n\n|Operação inválida!|");
                controleTrueFalse = false;
                break;

        }
        

    } while (controleTrueFalse ==  false);

    Console.WriteLine("\n\nAperte qualquer tecla para voltar do ínico.");
    Console.ReadKey();
    Console.Clear();
}

