namespace MNJ_CRUD_OPERATION_FINAL.Repository
{
    public interface IGenericRepo<T> where T : class
    {
        //Create
        Task<T> AddAsync(T entity);
        //Get the Record by ID
        Task<T> GetByIdAsync(long id);
        //Get List of Data
        Task<IEnumerable<T>> GetAllAsync();
        //Update the Data
        Task<T> UpdateAsync(T entity);
        //Delete the data by ID
        Task<bool> DeleteAsync(long id);
    }
}
