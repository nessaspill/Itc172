using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICommunity_AssistService" in both code and config file together.
[ServiceContract]
public interface ICommunity_AssistService
{
    [OperationContract]
    int Login(string email, string password);

    [OperationContract]
    bool RegisterPerson(PersonInfo p);

    [OperationContract]
    bool RequestGrant(GrantRequest rq);

    [OperationContract]
    List<GrantInfo> GetGrants(int PersonKey);

    [OperationContract]
    void Donate(Donation d);

    [OperationContract]
    List<DonationInfo> GetDonations(int PersonKey);
}
[DataContract]
public class DonationInfo
{
    [DataMember]
    public decimal DonationAmount { get; set; }

    [DataMember]
    public string DonationDate { get; set; }
}
//to show the list of grants and register a grant
[DataContract]
public class GrantInfo
{
    [DataMember]
    public int Key { get; set; }

    [DataMember]
    public string FirstName { get; set; }

    [DataMember]
    public string LastName { get; set; }

    [DataMember]
    public string RequestDate { get; set; }

    [DataMember]
    public decimal RequestAmount { get; set; }

    [DataMember]
    public string RequestExplanation { get; set; }

    [DataMember]
    public string ReviewDate { get; set; }

    [DataMember]
    public string ReviewStatus { get; set; }

    [DataMember]
    public decimal AllocationAmount { get; set; }
}
//to register a person
[DataContract]
public class PersonInfo
{
    [DataMember]
    public string LastName { get; set; }

    [DataMember]
    public string FirstName { get; set; }

    [DataMember]
    public string Email { get; set; }

    [DataMember]
    public string Password { get; set; }

    [DataMember]
    public string ApartmentNumber { get; set; }

    [DataMember]
    public string Street { get; set; }

    [DataMember]
    public string City { get; set; }

    [DataMember]
    public string State { get; set; }

    [DataMember]
    public string Zipcode { get; set; }

    [DataMember]
    public string HomePhone { get; set; }

    [DataMember]
    public string WorkPhone { get; set; }

}