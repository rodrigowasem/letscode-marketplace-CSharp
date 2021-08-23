using System;

namespace ProjetoLetsCode2
{
    public class User : ISeller, IClient
    {
        public int id { get; set; }
        public bool IsSeller { get; set; } = false;
        public bool IsClient { get; set; } = false;
        public string name { get; set; }
        public Address deliveryAddress { get; set; }
        public Address billingAddress { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public DateTime birthDate { get; set; }


        public override string ToString()
        {
            return $"Nome: {name}" +
                $"Usuáio: {user}" +
                $"Data de nascimento: {birthDate}" +
                $"Endereço de entrega: {deliveryAddress}" +
                $"Endereço de cobrança: {billingAddress}";
                
        }
    }
}