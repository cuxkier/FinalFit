using Fitness.DataAccess.Data;
using Fitness.DataAccess.Repository.IRepository;
using Fitness.Models;

namespace Fitness.DataAccess.Repository
{
    public class ProgressRepository : Repository<Progress>, IProgressRepository
    {
        private readonly ApplicationDbContext _db;

        public ProgressRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Progress progress)
        {
            var objFromDb = _db.Progress.FirstOrDefault(p => p.Id == progress.Id);
            if (objFromDb != null)
            {
                objFromDb.Weight = progress.Weight;
                objFromDb.Date = progress.Date;
            }
        }
    }
}
