using DDCC.API.Model;

namespace DDCC.API.Services
{
    public interface IDDCC
    {
        Task<IEnumerable<monthly_data>> GetMonthlyData();
       
    }
}
