using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    interface ISearchable
    {
        List<Product> SearchByPriceRange(double minPrice, double maxPrice);
        List<Product> SearchByCategory(string category);
    }
}
