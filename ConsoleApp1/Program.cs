
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abasteça seu carro");


            float valorAbastecer, precoCombustivel, litrosCalculo, podeRodarKms, valorKmtragem, distanciaIda, distanciaVolta, diasTrampo;
          
            // Captura de valores

            Console.WriteLine("digite o valor R$ que deseja abastecer \n");
            valorAbastecer = float.Parse(Console.ReadLine());
            Console.WriteLine("digite o preco do combustivel \n");
            precoCombustivel = float.Parse(Console.ReadLine());
            
            // conversão de valores

            litrosCalculo = valorAbastecer / precoCombustivel;

            // Expressão resultados

            Console.WriteLine("Você abastecerá " + litrosCalculo + " Litros de combustivel \n");

            // kmtragem Percorridos

            Console.WriteLine("digite a media de quilometragem rodada por litro  \n");
            valorKmtragem  = float.Parse(Console.ReadLine());
            podeRodarKms = valorKmtragem * litrosCalculo;
            Console.WriteLine("Seu veiculo percorrerá " + podeRodarKms + " quilometros com " + litrosCalculo + " litros de combustivel \n") ;
            
            // Dias que poderá ir e voltar do trabalho.

            Console.WriteLine("Digite a Distancia de IDA do seu trabalho ex:(25) \n");            
            distanciaIda = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Distancia de VOLTA do seu trabalho ex:(25)\n");
            distanciaVolta = float.Parse(Console.ReadLine());
            diasTrampo = podeRodarKms / (distanciaIda + distanciaVolta);
            Console.WriteLine("Voce podera ir e voltar do seu trabalho " + diasTrampo + " dias \n");

            // Quantidade de combustivel para o mês de 22 dias uteis e total de gastos. 

            float valor31, restaAbastecer, ltsFaltam, totalPreco, totalLitros; 

            valor31 = (distanciaIda + distanciaVolta) * 22;
            Console.WriteLine("Para um mês de 22 dias úteis você percorrerá " + valor31 + " quilometros" );
            restaAbastecer = valor31 - podeRodarKms;
            ltsFaltam = restaAbastecer / valorKmtragem;            
            totalPreco = (ltsFaltam + litrosCalculo) * precoCombustivel;
            totalLitros = litrosCalculo + ltsFaltam; 
            Console.WriteLine("resta abastecer " + ltsFaltam + " litros de combustivel \nGastará um Total de R$: " + totalPreco + " a cada 22 dias íteis\nUsando ao todo "+ totalLitros + " litros de Combustivel");





            /*
                        if (soma >= 6)
                        {
                            Console.WriteLine("Aluno Aprovado");
                        }
                        else
                        {
                            Console.WriteLine("Aluno Reprovado");
                        }

                       // Console.WriteLine("A media da soma de " + valor1 + " e " + valor2 + " " + "eh igual a : " + resultado );
            */


        }
    }
