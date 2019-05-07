using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataBase
/// </summary>
public class DataBase
{
    private List<Person> _dataBase;
    public Person this[int index]
    {
        get
        {
            return _dataBase[index];
        }
    }
    public DataBase()
    {
        _dataBase = new List<Person>();
        _dataBase.Add(new Person()
        {
            BirthDate = DateTime.Today.AddYears(-20).AddMonths(-3).AddDays(-11),
            Name = "Jan",
            Surname = "Czochralski"
        });
        _dataBase.Add(new Person()
        {
            BirthDate = DateTime.Today.AddYears(-18).AddMonths(-7).AddDays(-21),
            Name = "Maria",
            Surname = "Skłodowska"
        });
        _dataBase.Add(new Person()
        {
            BirthDate = DateTime.Today.AddYears(-20).AddMonths(-3).AddDays(-11),
            Name = "Wisława",
            Surname = "Szymborska"
        });
        _dataBase.Add(new Person()
        {
            BirthDate = DateTime.Today.AddYears(-22).AddMonths(-3).AddDays(-11),
            Name = "Marian",
            Surname = "Smoluchowski"
        });
    }
}