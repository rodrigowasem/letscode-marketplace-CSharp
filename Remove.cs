using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLetsCode2
{
    public class Remove
    {        
        public static void RemoveUser() {
            Console.WriteLine("Informe o ID do usuário que deseja remover:");
            int id = Int32.Parse(Console.ReadLine());

            var user = Database.Users.Single(user => user.id == id); 

            if (user != null)
                Database.Users.Remove(user);
            else
                Console.WriteLine("Usuário não encontrado!");
        }

        public static void RemoveSeller()
        {
            Console.WriteLine("Informe o ID do vendedor que deseja remover:");
            int id = Int32.Parse(Console.ReadLine());

            var seller = Database.Users.Single(user => user.id == id);

            if (seller != null)
                Database.Users.Remove(seller);
            else
                Console.WriteLine("Nenhum vendedor encontrado com o ID fornecido!");
        }

        public static void RemoveClient()
        {
            Console.WriteLine("Informe o ID do cliente que deseja remover:");
            int id = Int32.Parse(Console.ReadLine());

            var client = Database.Users.Single(user => user.id == id);

            if (client != null)
                Database.Users.Remove(client);
            else
                Console.WriteLine("Nenhum cliente encontrado com o ID fornecido!");
        }
    }
}
