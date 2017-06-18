using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Community_AssistService" in code, svc and config file together.
public class Community_AssistService : ICommunity_AssistService
{
    Community_AssistEntities db = new Community_AssistEntities();

    public void Donate(Donation d)
    {
        int key = (int)d.PersonKey;
        Donation donate = new Donation();
        donate.DonationDate = DateTime.Now;
        donate.DonationAmount = d.DonationAmount;
        donate.PersonKey = key;
        db.Donations.Add(donate);
        db.SaveChanges();
    }

    public List<DonationInfo> GetDonations(int PersonKey)
    {
        List<DonationInfo> donations = new List<DonationInfo>();

        var ds = (from d in db.Donations
                            where d.PersonKey == PersonKey
                            select new { d.DonationAmount, d.DonationDate }).ToList();

        foreach (var d in ds)
        {
            DonationInfo donation = new DonationInfo();
            donation.DonationAmount = d.DonationAmount;
            donation.DonationDate = d.DonationDate.ToShortDateString();

            donations.Add(donation);
        }

        return donations;
    }



    //to create and show the grant list
    public List<GrantInfo> GetGrants(int PersonKey)
    {
        List<GrantInfo> grants = new List<GrantInfo>();
        var ggs = (from grt in db.GrantRequests
                   from gvt in grt.GrantReviews
                   where grt.PersonKey == PersonKey
                   select new
                   {
                       grt.Person.PersonKey,
                       grt.Person.PersonFirstName,
                       grt.Person.PersonLastName,
                       grt.GrantRequestDate,
                       grt.GrantRequestAmount,
                       grt.GrantRequestExplanation,
                       gvt.GrantReviewDate,
                       gvt.GrantRequestStatus,
                       gvt.GrantAllocationAmount
                   });

        foreach (var g in ggs)
        {
            GrantInfo gtgr = new GrantInfo();
            gtgr.Key = g.PersonKey;
            gtgr.FirstName = g.PersonFirstName;
            gtgr.LastName = g.PersonLastName;
            gtgr.RequestDate = g.GrantRequestDate.ToString(); ;
            gtgr.RequestAmount = g.GrantRequestAmount.GetValueOrDefault();
            gtgr.RequestExplanation = g.GrantRequestExplanation;    
            gtgr.ReviewDate = g.GrantReviewDate.ToString();
            gtgr.ReviewStatus = g.GrantRequestStatus;
            gtgr.AllocationAmount = g.GrantAllocationAmount.GetValueOrDefault();



            grants.Add(gtgr);
        }
        return grants;
    }

    //to login
    public int Login(string email, string password)
    {
        int key = 0;
        int result = db.usp_Login(email, password);
        if (result != -1)
        {
            var userKey = (from k in db.People
                           where k.PersonEmail.Equals(email)
                           select k.PersonKey).FirstOrDefault();
            key = (int)userKey;
        }

        return key;
    }

    //to register people
    public bool RegisterPerson(PersonInfo p)
    {
        bool result = true;
        int rp = db.usp_Register(p.LastName, p.FirstName, p.Email,
            p.Password, p.ApartmentNumber, p.Street,
            p.City, p.State, p.Zipcode, p.HomePhone, p.WorkPhone);

        return result;
    }

    //to request a grant
    public bool RequestGrant(GrantRequest rq)
    {
        bool result = true;

        rq.GrantRequestDate = DateTime.Now;
        db.GrantRequests.Add(rq);

        GrantReview rev = new GrantReview()
        {
            GrantRequest = rq,
            GrantRequestStatus = "pending",
            GrantReviewDate = DateTime.Now
        };

        db.GrantReviews.Add(rev);

        db.SaveChanges();

        return result;
    }
}
