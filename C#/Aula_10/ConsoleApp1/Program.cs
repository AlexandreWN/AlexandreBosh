using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class DisciplinasMatriculadas
    {
        string nomedisc;
        string horario;
        int creditos;

        public DisciplinasMatriculadas(string nome,string horario, int creditos)
        {
            this.nomedisc = nome;
            this.horario = horario;
            this.creditos = creditos;
        }

        public string GetNomedisc()
        {
            return nomedisc;
        }

        public string GetHorario()
        {
            return horario;
        }
        
        public int GetCreditos()
        {
            return creditos;
        }

        public void SetNomeDisc(string nome)
        {
            this.nomedisc = nome;
        }
        public void SetHorario(string horario)
        {
            this.horario = horario;
        }
        public void SetCreditos(int creditos)
        {
            this.creditos = creditos;
        }
    }
    class Endereco
    {

        string rua;
        int numerorua;
        string cidade;
        public string Getrua()
        {
            return rua;
        }

        public string GetCidade()
        {
            return cidade;
        }

        public int GetNumerorua()
        {
            return numerorua;
        }

        public void SetRua(string rua)
        {
            this.rua = rua;
        }
        public void SetCidade(string cidade)
        {
            this.cidade = cidade;
        }
        public void SetNumerorua(int numerorua)
        {
            this.numerorua = numerorua;
        }
    }

    class Aluno
    {
        string nome;
        int matricula;
        string curso;
        int periodo;
        int idade;
        DisciplinasMatriculadas disciplinas;
        public Aluno(string nome, int matricula, string curso, int periodo, int idade,DisciplinasMatriculadas disciplinas)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.curso = curso;
            this.periodo = periodo;
            this.idade = idade;
            this.disciplinas = disciplinas;


        }
        public DisciplinasMatriculadas GetDisciplinas()
        {
            return disciplinas;
        }
        public void SetDisciplinas(string nome, string horario, int creditos)
        {
            this.disciplinas = new DisciplinasMatriculadas(nome, horario, creditos);
        }

        public string GetNome()
        {
            return nome;
        }

        public int GetMatricula()
        {
            return matricula;
        }

        public string GetCurso()
        {
            return curso;
        }

        public int GetPeriodo()
        {
            return periodo;
        }

        public int GetIdade()
        {
            return idade;
        }

        public void SetNome(string n)
        {
            this.nome = n;
        }

        public void SetMatricula(int m)
        {
            this.matricula = m;
        }

        public void SetCurso(string cu)
        {
            this.curso = cu;
        }

        public void SetPeriodo(int p)
        {
            this.periodo = p;
        }

        public void SetIdade(int id)
        {
            this.idade = id;
        }


    }

    class Program
    {   
        static void Main(string[] args)
        {
            List<Aluno> lista = new List<Aluno>();
            int op = 0;
            while (true)
            {
                Console.WriteLine("Digite 1 para cadastrar, 2 para listar alunos, 3 para atulaizar dados, 4 para listar alunos e 5 excluir aluno e 6 para parar o programa ");
                op = int.Parse(Console.ReadLine());
                if (op == 6)
                {
                    break;
                }
                else if (op == 1)
                {
                    Console.WriteLine("Bem Vindo Ao Cadastrador");
                    Console.WriteLine("Digite o nome do aluno: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Digite a matricula: ");
                    int m = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o curso: ");
                    string c = Console.ReadLine();
                    Console.WriteLine("Digite o periodo: ");
                    int p = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a idade: ");
                    int i = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o nome da disciplina ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite a hora");
                    string horario = Console.ReadLine();
                    Console.WriteLine("Digite os creditos");
                    int creditos = int.Parse(Console.ReadLine());

                    DisciplinasMatriculadas disc = new DisciplinasMatriculadas(nome, horario, creditos);
                    Aluno jose = new Aluno(n, m, c, p, i, disc);
                    
                    lista.Add(jose);
                }
                else if (op == 2)
                {
                    Console.WriteLine("Bem Vindo Ao Buscador especifico");
                    Console.WriteLine("Digite o nome do aluno que deseja: ");
                    string buscar = Console.ReadLine();
                    int i = -1;
                    foreach(Aluno c in lista)
                    {
                        if (buscar == c.GetNome())
                        {
                            i = lista.IndexOf(c);
                        }
                    }
                    Console.WriteLine(lista[i].GetMatricula());
                    Console.WriteLine(lista[i].GetCurso());
                    Console.WriteLine(lista[i].GetPeriodo());
                    Console.WriteLine(lista[i].GetIdade());
                    Console.WriteLine(lista[i].GetDisciplinas().GetNomedisc());
                    Console.WriteLine(lista[i].GetDisciplinas().GetHorario());
                    Console.WriteLine(lista[i].GetDisciplinas().GetCreditos());
                }
                else if (op == 3)
                {
                    Console.WriteLine("Bem Vindo Ao Atualizador");
                    Console.WriteLine("Digite o nome do aluno que deseja: ");
                    string buscar = Console.ReadLine();
                    int i = -1;
                    foreach (Aluno c in lista)
                    {
                        if (buscar == c.GetNome())
                        {
                            i = lista.IndexOf(c);
                        }
                    }
                    Console.WriteLine("Digite a nova matriculua");
                    int m = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o curso");
                    string cu = Console.ReadLine();
                    Console.WriteLine("Digite o periodo");
                    int p = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a idade");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o nome do curso");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Digite o horario");
                    string horario = Console.ReadLine();
                    Console.WriteLine("Digite o credito");
                    int creditos = int.Parse(Console.ReadLine());

                    lista[i].SetMatricula(m);
                    lista[i].SetCurso(cu);
                    lista[i].SetPeriodo(p);
                    lista[i].SetIdade(id);
                    lista[i].SetDisciplinas(nome,horario,creditos);
                }
                else if (op == 5)
                {
                    Console.WriteLine("Bem Vindo Ao Apagador de Aluno");
                    Console.WriteLine("Digite o nome do aluno que deseja: ");
                    string buscar = Console.ReadLine();
                    int i = -1;
                    foreach (Aluno c in lista)
                    {
                        if (buscar == c.GetNome())
                        {
                            i = lista.IndexOf(c);
                        }
                    }
                    lista.Remove(lista[i]);
                }
                else if (op == 4)
                {
                    foreach (Aluno c in lista)
                    {
                        Console.WriteLine(c.GetNome());
                    }
                }
            }
        }
    }
}
