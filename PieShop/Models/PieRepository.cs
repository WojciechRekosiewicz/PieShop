using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDBContext;

        public PieRepository(AppDbContext appDBContext)
        {
            _appDBContext = appDBContext;
        }


        public IEnumerable<Pie> GetAllPies()
        {
            return _appDBContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _appDBContext.Pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
