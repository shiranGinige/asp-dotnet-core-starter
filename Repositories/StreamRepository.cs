using System.Collections.Generic;
using System.Linq;
using AspNetStarter.Models;
using AspNetStarter.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetStarter.Repositories
{
    public class StreamRepository : IStreamRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public StreamRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Stream>> ListAll()
        {
            return await _dbContext.Streams.ToListAsync();
        }

        public async Task Add(Stream character)
        {
            _dbContext.Streams.Add(character);
            await _dbContext.SaveChangesAsync();
        }
    }
}