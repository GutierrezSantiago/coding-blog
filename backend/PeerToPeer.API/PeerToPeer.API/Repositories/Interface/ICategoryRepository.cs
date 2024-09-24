using PeerToPeer.API.Models.Domain;

namespace PeerToPeer.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
