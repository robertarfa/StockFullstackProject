using Server.Models;

namespace Server.Repositories
{
    public interface ICustomer
    {
        // Método para criar um novo cliente
        public void Create(Customer customer);

        // Método para obter um cliente por número de telefone
        public void GetByPhone(string phoneNumber);
    }
}
