using WebMVC_Cake.Models;

namespace WebMVC_Cake.Repositories
{
    public interface ICupcakeRepository {
        IEnumerable<Cupcake> GetCupcakes();
        Cupcake GetCupcake(int id);
        void CreateCupcake(Cupcake cupcake);

        void UpdateCupcake(Cupcake cupcake);
        void DeleteCupcake(int id);
        void SaveChanges();
        IQueryable<Bakery> PopulateBakeriesDropDownList();
    }
}
