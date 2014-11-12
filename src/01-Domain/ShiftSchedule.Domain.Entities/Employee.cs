using System;
//NTD change the name of the class to general name like 'User' (this app can be manage also by students and some other types of users)


namespace ShiftSchedule.Domain.Entities
{
    public class Employee 
    {
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime DateCreated { get; set; }
        public virtual bool AdminRights { get; set; }

       public Employee()
        {
            DateCreated = DateTime.Now;
        }

        public Employee(string firstName, string lastName, string email, DateTime dateCreated)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateCreated = dateCreated;
        }

        public Boolean IsAdmin()
        {
            return AdminRights;
        }
        public string GetFullName()
        {
            return (FirstName + " " + LastName);
        }

        public bool IsValidFirstName()
        {
            if (string.IsNullOrEmpty(FirstName))
                return false;
            return true;
        } 
         
    }
}