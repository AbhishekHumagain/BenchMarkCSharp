using Microsoft.Extensions.Caching.Memory;

namespace MemoryIntensivePoc;

public class InMemoryDataProcessor
{
    private readonly Dictionary<string, LargeObject> _dataStore;
    private readonly MemoryCache _cache;

    public InMemoryDataProcessor()
    {
        _dataStore = new Dictionary<string, LargeObject>();
        _cache = new MemoryCache(new MemoryCacheOptions
        {
            SizeLimit = 1024 * 1024 * 1024 // 1 GB cache limit
        });
    }

    public void AddOrUpdateData(string key, LargeObject data)
    {
        _dataStore[key] = data;
        _cache.Set(key, data, new MemoryCacheEntryOptions
        {
            Size = data.CalculateSize(),
            SlidingExpiration = TimeSpan.FromMinutes(10)
        });
    }

    public LargeObject GetData(string key)
    {
        if (_cache.TryGetValue(key, out LargeObject cachedData))
        {
            return cachedData;
        }

        if (_dataStore.TryGetValue(key, out LargeObject data))
        {
            _cache.Set(key, data, new MemoryCacheEntryOptions
            {
                Size = data.CalculateSize(),
                SlidingExpiration = TimeSpan.FromMinutes(10)
            });
            return data;
        }

        return null;
    }
}
