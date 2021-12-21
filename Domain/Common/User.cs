using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Common;
public class User : IdentityUser
{
    public int? UserProfileId { get; set; }
    public UserProfile UserProfile { get; set; }

    //public List<Product> Products { get; set; }
    //public List<AdditionalFeature> AdditionalFeatures { get; set; }
    //public List<Client> Clients { get; set; }
    //public List<Condition> Conditions { get; set; }
    //public List<Employee> Employees { get; set; }
    //public List<Hall> Halls { get; set; }
    //public List<Leave> Leaves { get; set; }
    //public List<Period> Periods { get; set; }
    //public List<Receipt> Receipts { get; set; }
    //public List<Receivable> Receivables { get; set; }
    //public List<Requirement> Requirements { get; set; }
    //public List<Reservation> Reservations { get; set; }
    //public List<ReservationCondition> ReservationConditions { get; set; }
    //public List<ReservationAdditionalFeatureRequirement> ReservationAdditionalFeatureRequirements { get; set; }
    //public List<ReservationAdditionalFeature> ReservationAdditionalFeatures { get; set; }
    //public List<ReservationReceipt> ReservationReceipts { get; set; }
    //public List<Nationality> Nationalitys { get; set; }
    //public List<AdditionalFeatureTypeNew> AdditionalFeatureTypeNews { get; set; }
    //public List<Expense> Expenses { get; set; }
    //public List<Withdraw> Withdraws { get; set; }
    //public List<Insurance> Insurances { get; set; }
    //public List<FreeRequirement> FreeRequirements { get; set; }
    //public List<ReservationFreeRequirement> ReservationFreeRequirements { get; set; }
    //public List<Party> Parties { get; set; }
    //public List<Vat> Vats { get; set; }
    //public List<Bank> Banks { get; set; }
    //public List<BankAccount> BankAccounts { get; set; }

}
