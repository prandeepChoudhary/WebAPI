using WebAPI.Data;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class HomeService :IHome
    {
        private TrainingDbContext _dbContext;
        public HomeService(TrainingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<State> states()
        {
            return _dbContext.States.ToList();
        }
        public State AddState(State state)
        {
            _dbContext.States.Add(state);
            _dbContext.SaveChanges();
            return state;
        }

        public List<Customer> customers()
        {
            return _dbContext.Customers.ToList();
        }

        public Customer AddCustomer (Customer customer)
        {
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
            return customer;
        }
    }
}
