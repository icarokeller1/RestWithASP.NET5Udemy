using System.Collections.Generic;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Model.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long person);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);

    }
}
