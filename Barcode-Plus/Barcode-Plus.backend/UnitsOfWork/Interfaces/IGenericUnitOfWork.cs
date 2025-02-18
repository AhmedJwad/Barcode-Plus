using Barcode_Plus.Shared.DTOs;
using Barcode_Plus.Shared.Responses;

namespace Barcode_Plus.backend.UnitsOfWork.Interfaces
{
    public interface IGenericUnitOfWork<T> where T:class
    {
        Task<ActionResponse<int>> GetRecordsNumberAsync(PaginationDTO paginationDTO);
        Task<ActionResponse<IEnumerable<T>>> GetAsync();
        Task<ActionResponse<IEnumerable<T>>> GetAsync(PaginationDTO pagination);
        Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO pagination);
        Task<ActionResponse<T>> AddAsync(T model);
        Task<ActionResponse<T>> UpdateAsync(T model);
        Task<ActionResponse<T>> DeleteAsync(int id);
        Task<ActionResponse<T>> GetAsync(int id);
    }
}
