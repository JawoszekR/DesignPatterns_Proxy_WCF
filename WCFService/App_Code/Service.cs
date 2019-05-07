using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    DataBase _context;
    public Service()
    {
        _context = new DataBase();
    }

    public PersonDto GetPersonById(PersonDto composite, int Id)
    {
        var person = _context[Id];
        var personDto = new PersonDto()
        {
            Age = (DateTime.Today - person.BirthDate).Days / 365,
            Name = person.Name,
            Surname = person.Surname
        };
        return personDto;
    }
}
