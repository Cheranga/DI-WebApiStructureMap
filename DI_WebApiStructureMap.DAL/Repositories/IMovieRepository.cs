using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DI_WebApiStructureMap.DAL.Repositories
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        Movie GetById(int id);
    }
}
