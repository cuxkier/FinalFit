using Fitness.Models;

namespace Fitness.DataAccess.Repository.IRepository
{
    public interface IProgressRepository : IRepository<Progress>
    {
        void Update(Progress progress);
    }
}
