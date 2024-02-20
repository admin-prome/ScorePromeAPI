using Microsoft.EntityFrameworkCore;

namespace ScorePromeAPI.Models.Context
{
    public class BasesNegativasContext : DbContext
    {

        public BasesNegativasContext() { }

        public BasesNegativasContext(DbContextOptions<BasesNegativasContext> options)
            : base(options) { }
    }
}
