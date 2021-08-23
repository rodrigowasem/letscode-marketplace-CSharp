using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLetsCode2
{
    public class Search
    {
        public static void SearchUser() {

            Console.WriteLine("Informe o ID do usuário:");
            int id = Int32.Parse(Console.ReadLine());

            var user = (from u in Database.Users
                        where u.id == id 
                        select u).FirstOrDefault();

            if(user != null)            
                user.ToString();     
            else
                Console.WriteLine("Usuário não encontrado!");
        }

        public static void SearchSeller()
        {
            Console.WriteLine("Informe o ID do vendedor:");
            int id = Int32.Parse(Console.ReadLine());

            var user = (from u in Database.Users
                        where u.id == id && u.IsSeller == true
                        select u).FirstOrDefault();

            if (user != null)
                user.ToString();
            else
                Console.WriteLine("Vendedor não encontrado!");
        }

        public static void SearchClient()
        {
            Console.WriteLine("Informe o ID do cliente:");
            int id = Int32.Parse(Console.ReadLine());

            var user = (from u in Database.Users
                        where u.id == id && u.IsClient == true
                        select u).FirstOrDefault();

            if (user != null)
                user.ToString();
            else
                Console.WriteLine("Cliente não encontrado!");
        }

        public static void ListhUsers()
        {

            Console.WriteLine("Usuários cadastrados no sistemas:");

            if(Database.Users.Any())
                foreach (User user in Database.Users) {
                    user.ToString();
                }
            else
                Console.WriteLine("Nenhum usuário cadastrado até o momento!");
        }

        public static void ListSellers()
        {
            Console.WriteLine("Vendedores cadastrados no sistemas:");

            var sellers = Database.Users.Where(user => user.IsSeller == true);

            if (sellers.Any())
                foreach (User user in sellers)
                {
                    user.ToString();
                }
            else
                Console.WriteLine("Nenhum vendedor cadastrado até o momento!");
        }

        public static void ListClients()
        {
            Console.WriteLine("Clientes cadastrados no sistemas:");

            var clients = Database.Users.Where(user => user.IsClient == true);

            if (clients.Any())
                foreach (User user in clients)
                {
                    user.ToString();
                }
            else
                Console.WriteLine("Nenhum cliente cadastrado até o momento!");
        }

    }
}
