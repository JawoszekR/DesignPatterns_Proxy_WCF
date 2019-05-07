using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
	[OperationContract]
    PersonDto GetPersonById(PersonDto composite, int Id);

	// TODO: Add your service operations here
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
public class PersonDto
{
    string _name;
    string _surname;
    int _age;

	[DataMember]
	public string Name
	{
		get { return _name; }
		set { _name = value; }
	}

	[DataMember]
	public string Surname
	{
		get { return _surname; }
		set { _surname = value; }
	}

    [DataMember]
    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }
}
