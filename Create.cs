using System;
using System.Globalization;

namespace ProjetoLetsCode2
{
    public class Create
    {
        public static void CreateUser()
        {
            var name = ReadName();
            var username = ReadUser();
            var password = ReadPassword();
            var birthdate = ReadBirthdate();

            var deliveryAddress = ReadAddress();
            var billingAddress = ReadBillingAddress(deliveryAddress);
            
            var user = new User
            {
                id = Database.Users.Count + 1,
                name = name,
                user = username,
                password = password,
                birthDate = birthdate,
                deliveryAddress = deliveryAddress,
                billingAddress = billingAddress
            };

            Database.Users.Add(user);
        }

        private static Address ReadBillingAddress(Address deliveryAddress)
        {
            Console.WriteLine("Deseja utilizar como endereço de cobrança o mesmo endereço de entrega?");
            Console.WriteLine(deliveryAddress);

            System.Console.WriteLine("S - SIM, N - Não");
            var option = Console.ReadLine();

            if (option == "S")
                return deliveryAddress;
            
            return ReadAddress();
        }

        public static void CreateSeller()
        {
            var name = ReadName();
            var username = ReadUser();
            var password = ReadPassword();
            var birthdate = ReadBirthdate();

            var deliveryAddress = ReadAddress();
            var billingAddress = ReadBillingAddress(deliveryAddress);

            var user = new User
            {
                id = Database.Users.Count + 1,
                IsSeller = true,
                name = name,
                user = username,
                password = password,
                birthDate = birthdate,
                deliveryAddress = deliveryAddress,
                billingAddress = billingAddress
            };

            Database.Users.Add(user);
        }

        public static void CreateClient()
        {
            var name = ReadName();
            var username = ReadUser();
            var password = ReadPassword();
            var birthdate = ReadBirthdate();

            var deliveryAddress = ReadAddress();
            var billingAddress = ReadBillingAddress(deliveryAddress);

            var user = new User
            {
                id = Database.Users.Count + 1,
                IsClient = true,
                name = name,
                user = username,
                password = password,
                birthDate = birthdate,
                deliveryAddress = deliveryAddress,
                billingAddress = billingAddress
            };

            Database.Users.Add(user);
        }

        private static string ReadName()
        {
            Console.WriteLine("Digite o Nome do Usuário:");
            return Console.ReadLine();
        }
        private static string ReadUser()
        {
            Console.WriteLine("Digite o Username:");
            return Console.ReadLine();
        }
        
        private static string ReadPassword()
        {
            Console.WriteLine("Digite a Senha:");
            return Console.ReadLine();
        }

        private static DateTime ReadBirthdate()
        {
            Console.WriteLine("Digite a Data de Nascimento (dd/mm/aaaa):");
            var entrada = Console.ReadLine();
            return Convert.ToDateTime(entrada, new CultureInfo("pt-BR"));
        }

        private static Address ReadAddress()
        {
            Console.WriteLine("Digite a primeira linha do endereço:");
            var address = Console.ReadLine();

            Console.WriteLine("Digite a segunda linha do endereço:");
            var secondAddress = Console.ReadLine();

            Console.WriteLine("Digite o número:");
            int.TryParse(Console.ReadLine(), out var number);

            Console.WriteLine("Digite o CEP do endereço:");
            var zip = Console.ReadLine();

            Console.WriteLine("Digite a cidade:");
            var city = Console.ReadLine();

            Console.WriteLine("Digite o estado:");
            var state = Console.ReadLine();

            Console.WriteLine("Digite o país:");
            var country = Console.ReadLine();

            return new Address()
            {
                address = address,
                secondAddress = secondAddress, 
                number = number,
                zipCode = zip,
                city = city,
                state = state, 
                country = country
            };
        }
    }
}