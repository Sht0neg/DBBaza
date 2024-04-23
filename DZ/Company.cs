using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DZ
{
    public class Company
    {
        public int? CompanyId { get; set; }
        
        public string Name { get; set; }

        public string Data { get; set; }

        public string Specialisation { get; set; }

        public ObservableCollectionListSource<Employee> employees { get; } = new();
    }
}
