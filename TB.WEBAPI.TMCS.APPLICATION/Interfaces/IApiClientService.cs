using TB.WEBAPI.TMCS.APPLICATION.DTOs;

namespace TB.WEBAPI.TMCS.APPLICATION.Interfaces
{
    public interface IApiClientService
    {
        Task<ApiResponseDto<TResponse>> GetAsync<TResponse>(string endpoint);

        Task<ApiResponseDto<TResponse>> PostAsync<TRequest, TResponse>(string endpoint, TRequest request);

        Task<ApiResponseDto<TResponse>> PostAsync<TResponse>(string endpoint);
    }
}