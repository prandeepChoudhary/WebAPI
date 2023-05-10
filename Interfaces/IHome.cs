using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface IHome
    {
        List<State> states();
        State AddState(State state);
        List<Customer> customers();
        Customer AddCustomer(Customer customer);
    }
}
