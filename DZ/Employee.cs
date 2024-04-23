
namespace DZ
{
    public class Employee
    {
        public int? EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public int Age { get; set; }

        public string Position { get; set; }


        public bool Married { get; set; }

        public bool HadChildren { get; set; }

        public int CompanyId { get; set; }

        public virtual Company Company { get; set; } = null!;
    }
}
