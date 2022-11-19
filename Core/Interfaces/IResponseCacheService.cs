using System;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IResponseCacheService
    {
        Task CachResponseAsync(string cacheKey, object response, TimeSpan timeTolive);

        Task<string> GetCachedResponseAsync(string cacheKey);
    }
}