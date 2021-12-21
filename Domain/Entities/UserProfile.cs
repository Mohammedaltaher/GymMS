using Domain.Common;
using System;

namespace Domain.Entities
{
    public class UserProfile 
    {
        public UserProfile()
        {
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
            IsDeleted = false;
        }
        public int Id { get; set; }
       
        public string FirstName { get; set; }
        public string FirstNameAr { get; set; }
        public string MiddelName { get; set; }
        public string MiddelNameAr { get; set; }
        public string LastName { get; set; }
        public string LastNameAr { get; set; }

        public bool IsDeleted { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
