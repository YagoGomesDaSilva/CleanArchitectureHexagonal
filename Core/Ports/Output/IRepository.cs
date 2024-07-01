namespace Core.Ports.Output;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAll();
    Task<T> GetById(Guid id);
    Task<T> Add(T entity);
    Task<T> Update(T entity);
    Task<T> Delete(T entity);
}