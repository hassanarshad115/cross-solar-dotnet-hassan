using CrossSolar.Domain;

namespace CrossSolar.Repository
{
    public class DayAnalyticsRepository : GenericRepository<OneDayElectricityModel>, IDayAnalyticsRepository
    {
        public DayAnalyticsRepository(CrossSolarDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}