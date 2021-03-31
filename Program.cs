using System;

namespace Revisao
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToLower() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        // TODO: Adicionarr Aluno
                        Console.WriteLine("Informe nome do aluno ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Imforme nota do aluno");

                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor deve ser decimal ");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;


                        break;

                    case "2":
                        // TODO: Adicionarr Lista de aluno
                        foreach (var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {

                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                            }
                        }


                        break;

                    case "3":
                        // TODO: Adicionarr  Media geral do aluno 
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for (int i = 0; i < alunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }
                        }
                        var mediaGeral = notaTotal / nrAlunos;

                        conceito conceitoGeral;

                        if(mediaGeral < 2)
                        {
                            conceitoGeral = conceito.E;
                        }
                        else if(mediaGeral < 4)
                        {
                            conceitoGeral = conceito.D;
                        }
                           else if(mediaGeral < 6)
                        {
                            conceitoGeral = conceito.C;
                        }
                           else if(mediaGeral < 8)
                        {
                            conceitoGeral = conceito.B;
                        }
                           else 
                        {
                            conceitoGeral = conceito.A;
                        }
                        Console.WriteLine($"MEDIA GERAL:   {mediaGeral} - CONCEITO:  {conceitoGeral}");

                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Infome a Opção Desejada");
            Console.WriteLine("1 - Insirar novo Aluno");
            Console.WriteLine("2 - Listas de alunos");
            Console.WriteLine("3 - Calcular Média de geral ");
            Console.WriteLine("X - Sair ");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

            Console.WriteLine();
            return opcaoUsuario;

        }
    }


}
