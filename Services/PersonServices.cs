using Scholar.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholar.Services
{
    public class PersonServices : IPersonServices

    {
        public SQLiteAsyncConnection _DbConnection;
        public PersonServices() {
            SetUpDatabase();
        }

        public void SetUpDatabase()
        {
            if (_DbConnection == null) {
                //data source=C:\Users\OZO\source\repos\Scholar\database\file.db3
                //string connectionString = @"data source=../../../database/file.db3";
                 string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Scholarship.db3");
                //string dbPath = Path.Combine("../database", "file.db3");
                _DbConnection = new SQLiteAsyncConnection(dbPath);
                _DbConnection.CreateTableAsync<Person>();
                _DbConnection.CreateTableAsync<Country>();
            }


        }
        //Add Country 
       

        //check existing Country
        public Task<Country> CheckExistingCountry(Country country)
        {
            var CountryResponse = _DbConnection.Table<Country>().Where(c => c.Name == country.Name).FirstOrDefaultAsync();
            return CountryResponse;
        }
        public  Task<Person> GetOneUserById(int userId)
        {
           var response = _DbConnection.Table<Person>().Where(s=>s.Id == userId).FirstOrDefaultAsync();
            return response;
        }
        public Task<Person> LogUserIn(string email, string password)
        {
            return _DbConnection.Table<Person>().Where(s=>s.Email == email && s.Password == password).FirstOrDefaultAsync();
        }

        public Task<int> AddPerson(Person person)
        {
            return _DbConnection.InsertAsync(person);
        }

        public Task<int> AddCountry(Country country)
        {
            return _DbConnection.InsertAsync(country);
        }

        public Task<int> DeletePerson(Person person)
        {
            return _DbConnection.DeleteAsync(person);
        }

        public Task<List<Person>>GetPersonList()
        {
            var personList = _DbConnection.Table<Person>().ToListAsync();
            return personList;
        }

        public Task<int> UpdatePersonList(Person person)
        {
            return _DbConnection.UpdateAsync(person);
        }
    }
}
