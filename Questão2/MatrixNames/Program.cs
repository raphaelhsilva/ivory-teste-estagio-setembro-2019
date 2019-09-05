using System;

namespace ProgramaDeEstagioIvory
{
    class Program
    {
 
        static void Main(string[] args)
        {
            string name;
            string[,] m;
            char[] splitName = new char[1];
            
            //Entrada do Usuário
            Console.WriteLine("Escreva um nome: ");

            name = Console.ReadLine();
            splitName = name.ToCharArray();
            m = new string[3, name.Length+3];
            int n1 = 0;

            //Criação da implementação na Matriz

            //Eixo X da Matriz (linhas)
            for(int i = 0; i<3; i++)
            {
                //Eixo Y da Matriz (Colunas
                for(int o = 0; o<name.Length * 3; o++)
                {   
                    //Atribuindo Valores dentro dos campos da Matriz na primeira Linha
                    if (i < 1 && o < name.Length + 2)
                    {
                        n1++;
                        string n2 = Convert.ToString(n1);
                        Console.Write(m[i, o] = n2 + "\t");
                    }
                    //Quebra de Linha
                    else if(i < 1 && o == name.Length + 2)
                    {
                        Console.WriteLine();
                    }

                    //Atribuindo Valor dentro do campo da Segunda Linha Primeira Coluna
                    if (i == 1 && o < 2)
                    {
                        int n3 = n1;
                        n3 = (name.Length + 2)*2 + 2;
                        string n2 = Convert.ToString(n3);
                        Console.Write(m[i,o] = n2 +"\t");
                    }

                    //Atribuindo Valores na Segunda linha da Matriz
                    if (i == 1 && o < name.Length-1)
                    {
                        n1++;
                        string n2 = Convert.ToString(n1);
                        int a = -1;

                        //Atribuindo o Nome escolhido na Matriz
                        while (a < name.Length -1)
                        {
                            a++;
                            Console.Write(splitName[a].ToString()+ "\t");
                        }

                        //Atribuindo o Valor na Ultima coluna da Segunda linha
                        if (i == 1)
                        {
                            n2 = Convert.ToString(n1);
                            Console.Write(m[i, o] = n2);
                        }

                        //Atribundo Valores da Ultima linha da Matriz
                        Console.WriteLine();
                        int n4 = (name.Length +2)* 2 + 2;

                        for (int y = 0; y < name.Length + 2; y++)
                        {
                            n4--;
                            n2 = Convert.ToString(n4);
                            Console.Write(m[i, o] = n2 + "\t");
                        }
                        break;
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
