using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPieRepository()
        {
            if(_pies == null)
            {
                InitializePies();
            }
        }

        private void InitializePies()
        {
            _pies = new List<Pie>
            {
                new Pie {Id = 1, Name = "Pie", Price = 12.96M, ShortDescription ="Super Pie", LongDescription="Super Super Pie" },
                new Pie {Id = 2, Name = "SPie", Price = 12.96M, ShortDescription ="Super Pie", LongDescription="Super Super Pie" },
                new Pie {Id = 3, Name = "APie", Price = 12.96M, ShortDescription ="Super Pie", LongDescription="Super Super Pie" },
                new Pie {Id = 4, Name = "CPie", Price = 12.96M, ShortDescription ="Super Pie", LongDescription="Super Super Pie" },
                new Pie {Id = 5, Name = "XPie", Price = 12.96M, ShortDescription ="Super Pie", LongDescription="Super Super Pie" }
            };
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
