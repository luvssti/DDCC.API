using DDCC.API.Data;
using DDCC.API.Model;
using Microsoft.EntityFrameworkCore;

namespace DDCC.API.Services
{
    public class RDDCC : IDDCC
    {
        private readonly MyDbContext MyDbContext;

        public RDDCC(MyDbContext _MyDbContext) 
        { 
            MyDbContext = _MyDbContext;
        }

        public async Task<IEnumerable<monthly_data>> GetMonthlyData()
        {
            MyDbContext.Database.SetCommandTimeout(300);
            var result = await MyDbContext.monthly_data.FromSqlRaw("EXEC sp_GetMonthlyData").AsNoTracking().ToListAsync();
            return result;
        }
    }
}
