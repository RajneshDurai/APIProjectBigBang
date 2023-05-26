using APIProjectBigBang.Authorization;
using APIProjectBigBang.Model;
using Microsoft.EntityFrameworkCore;

namespace APIProjectBigBang.Data
{
    public class HotelContext:DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Register> Register { get; set; }
        public HotelContext(DbContextOptions<HotelContext> options) : base(options) { }
    }
}
