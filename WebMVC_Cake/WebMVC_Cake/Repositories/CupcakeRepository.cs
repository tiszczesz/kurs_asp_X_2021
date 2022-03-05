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
            if (cupcake.PhotoAvatar != null && cupcake.PhotoAvatar.Length > 0)
            {
                cupcake.ImageMimeType = cupcake.PhotoAvatar.ContentType;
                cupcake.ImageName = Path.GetFileName(cupcake.PhotoAvatar.FileName);
                using (var memoryStream = new MemoryStream())
                {
                    cupcake.PhotoAvatar.CopyTo(memoryStream);
                    cupcake.PhotoFile = memoryStream.ToArray();
                }

                _context.Add(cupcake);
                _context.SaveChanges();
            }
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
