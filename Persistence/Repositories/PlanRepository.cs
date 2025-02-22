using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class PlanRepository : IPlanRepository
    {
        private readonly AppDbContext _context;

        public PlanRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Plan>> GetAllPlans()
        {
            return await _context.Plans.ToListAsync();
        }
    }
}
