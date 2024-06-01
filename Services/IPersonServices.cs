using Scholar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar.Services
{
    public interface IPersonServices
    {
        Task<int> AddCountry(Country country);
        Task<Country> CheckExistingCountry(Country country);
        Task<List<Person>> GetPersonList();
        Task<int> AddPerson( Person person);
        Task<int> DeletePerson(Person person);
        Task<int> UpdatePersonList(Person person);
        Task<Person> LogUserIn(string email, string password);
        Task<Person> GetOneUserById(int userId);
    }
}
