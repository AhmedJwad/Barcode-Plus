﻿using Barcode_Plus.Shared.DTOs;
using Barcode_Plus.Shared.Responses;

namespace Barcode_Plus.backend.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T :class
    {
        Task<ActionResponse<int>> GetRecordsNumberAsync(PaginationDTO paginationDTO);
        Task<ActionResponse<T>> GetAsync(int Id);
        Task<ActionResponse<IEnumerable<T>>> GetAsync();
        Task<ActionResponse<IEnumerable<T>>> GetAsync(PaginationDTO paginationDTO);
        Task<ActionResponse<int>> GetTotalPagesAsync(PaginationDTO paginationDTO);
        Task<ActionResponse<T>> AddAsync(T Entity);
        Task<ActionResponse<T>> UpdateAsync(T Entity);
        Task<ActionResponse<T>> DeleteAsync(int Id);
    }
}
