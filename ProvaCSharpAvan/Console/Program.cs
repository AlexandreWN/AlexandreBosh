using System;
using System.Text;
using DAO;

string nome;
int idheroi, x = 0, op, idA;
while(x != 1){
    Console.WriteLine("|---------------------------------------|");
    Console.WriteLine("| Para cadastrar uma nova arma digite 1 |");
    Console.WriteLine("| Para trazer armas do banco digite 2   |");
    Console.WriteLine("| Para alterar armas do banco digite 3  |");
    Console.WriteLine("| Para sair do programa digite 4        |");
    Console.WriteLine("|---------------------------------------|");
    op = int.Parse(Console.ReadLine());
    switch(op){
        case 1:
            Console.WriteLine("Digite o nome da arma: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o id do Heroi: ");
            idheroi = int.Parse(Console.ReadLine());

            using (var context = new EFCoreContext())
            {
                context.Database.EnsureCreated();
            }

            using (var context = new EFCoreContext())
            {
                context.Armas.Add(new Armas
                {
                    name = nome,
                    IDheroi = idheroi,
                });
                context.SaveChanges();
            }
            break;
        case 2:
            using (var context = new EFCoreContext())
            {
                var dados = context.Armas;
                foreach(var dado in dados)
                {
                    var data = new StringBuilder();
                    data.AppendLine($"Id da Arma: {dado.id}");
                    data.AppendLine($"Id do Heroi: {dado.IDheroi}");
                    data.AppendLine($"Nome da arma: {dado.name}");
                    Console.WriteLine(data.ToString());
                }
            }
            break;
        case 3:
            using(var context = new EFCoreContext())
            {
                Console.WriteLine("Digite o id da arma que deseja alterar: ");
                idA = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome da arma: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite o id do Heroi: ");
                idheroi = int.Parse(Console.ReadLine());
                var dados = context.Armas.Where(a => a.id.Equals(idA)).SingleOrDefault();
                dados.name = nome;
                dados.IDheroi = idheroi;
                context.SaveChanges();
            }
            break;
        case 4:
            x = 1;
            break;
    }
}
