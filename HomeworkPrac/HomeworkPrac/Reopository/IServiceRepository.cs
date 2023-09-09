using HomeworkPrac.Models;

namespace HomeworkPrac.Reopository
{
    public interface IServiceRepository: IGenericRepository<Service>
    {
        Service GetMostRecentService();
    }
}
