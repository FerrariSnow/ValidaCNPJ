using System;

namespace CNPJ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pesos1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] pesos2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] vcnpj = new int[13];
            string cnpj = "";
            int soma1 = 0;
            int soma2 = 0;
            int resto1 = 0;
            int resto2 = 0;
            int dig1 = 0;
            int dig2 = 0;

            //recebendo o valor do CNPJ
            Console.WriteLine("-----VALIDADOR CNPJ-----");
            Console.WriteLine("Informe apenas os 11 números do CNPJ: ");
            cnpj = Console.ReadLine();

            if (cnpj.Length != 12)
            {
                Console.WriteLine("CNPJ Inválido !");
            }
            else
            {//começo do digito 1
                for (int x = 0; x < 12; x++)
                {
                    vcnpj[x] = int.Parse(cnpj.Substring(x, 1));
                }

                for (int i = 0; i < 12; i++)
                {
                    soma1 += (vcnpj[i] * pesos1[i]);
                    resto1 = soma1 % 11;
                }
                if (resto1 < 2)
                {
                    dig1 = 0;
                }
                else dig1 = 11 - resto1;
                //fim do digito 1
                Console.WriteLine("O primeiro digito verificador do seu CNPJ é: {0}", dig1);
                vcnpj[12] = dig1;
                //começo do digito 2
                for (int z = 0; z < 13; z++)
                {
                    soma2 += (vcnpj[z] * pesos2[z]);
                    resto2 = soma2 % 11;
                }
                if (resto2 < 2)
                {
                    dig2 = 0;
                }
                else dig2 = 11 - resto2;
                //fim do digito 2 
                Console.WriteLine("O segundo digito verificador do seu CNPJ é: {0}", dig2);
                Console.WriteLine("O CNPJ é: {0}-{1}{2}", cnpj, dig1, dig2);
            }

        }
    }
}

