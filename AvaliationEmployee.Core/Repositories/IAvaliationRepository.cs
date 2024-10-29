using _5W2H.Core.Entities;
using Action = System.Action;

namespace _5W2H.Core.Repositories;

public interface IAvaliationRepository
{
    Task<List<Avaliation>> GetAllAsync();
    Task<Avaliation> GetByIdAsync(int id);
    Task<Avaliation> StartAsync(int id);
    Task<int> AddAsync(Avaliation avaliation);
    Task UpdateAsync(Avaliation avaliation);
    Task<int> DeleteAsync(int id);
    Task SaveChangesAsync();
    IQueryable<Avaliation> Query();
    
}