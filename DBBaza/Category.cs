using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DBBaza
{
    public class Category
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public ObservableCollectionListSource<Product> products { get;} = new();
    }
}
