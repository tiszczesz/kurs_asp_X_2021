using Microsoft.EntityFrameworkCore;
using WebMVC_Cake.Data;
using WebMVC_Cake.Models;

namespace WebMVC_Cake.Repositories
{
    public class CupcakeRepository :ICupcakeRepository {
        private readonly CupcakeContext _context;

        public CupcakeRepository(CupcakeContext context) {
            _context = context;
        }
        public IEnumerable<Cupcake> GetCupcakes() {
            return _context.Cupcakes.ToList();
        }

        public Cupcake GetCupcake(int id) {
            return _context.Cupcakes.Include(c=>c.Bakery).SingleOrDefault(c => c.CupcakeId == id);
        }

        public void CreateCupcake(Cupcake cupcake) {
            throw new NotImplementedException();
        }

        public void UpdateCupcake(Cupcake cupcake) {
            throw new NotImplementedException();
        }

        public void DeleteCupcake(int id) {
            throw new NotImplementedException();
        }

        public void SaveChanges() {
            throw new NotImplementedException();
        }

        public IQueryable<Bakery> PopulateBakeriesDropDownList() {
            var bakeriesQuery = _context.Bakeries.OrderBy(b => b.BakeryName);
            return bakeriesQuery;
        }
    }
}
