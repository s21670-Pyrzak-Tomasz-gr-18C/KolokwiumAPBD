using KolokwiumAPBD.Models;
using Microsoft.EntityFrameworkCore;


namespace KolokwiumAPBD.Services
{
    public class Dbservice : IDbservice
    {
        private readonly MainDbContext mainDbContext;

        public Dbservice(MainDbContext mainDbContext)
        {
            this.mainDbContext = mainDbContext;
        }
    }
}
