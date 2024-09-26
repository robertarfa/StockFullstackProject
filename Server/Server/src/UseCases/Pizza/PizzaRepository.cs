
using Server.Data;
using Server.Models;

namespace Server.Repositories
{

    public class PizzaRepository : IPizzaRepository
    {
        private readonly ApplicationDbContext _context;
        public PizzaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Delete(int pizzaId)
        {
            var pizza = _context.Pizzas.Find(pizzaId);

            if (pizza != null)
            {
                _context.Remove(pizza);
            }
        }

        public IEnumerable<Pizza> GetAll()
        {
            return _context.Pizzas;
        }

        public Pizza GetById(int pizzaId)
        {
            var pizza = _context.Pizzas.Find(pizzaId);

            if (pizza != null)
            {
                return pizza;

            }
            else
            {
                throw new Exception("");
            }
        }

        public void Insert(Pizza pizza)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Pizza pizza)
        {
            throw new NotImplementedException();
        }
    }
}
