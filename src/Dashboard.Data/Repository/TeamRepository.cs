using System.Collections.Generic;
using System.Threading.Tasks;
using Dashboard.Business.Interfaces.Repository;
using Dashboard.Business.Models;
using Dashboard.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Data.Repository
{
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        public TeamRepository(AppDbContext db) : base(db)
        {
        }

        public override async Task<List<Team>> Get()
        {
            return await base.DbSet
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
