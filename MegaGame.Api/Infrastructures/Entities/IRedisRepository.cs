using Redis.OM.Searching;

namespace MegaGame.Api.Infrastructures.Entities
{
    public interface IRedisRepository<TDoc, TKey>
    {
        RedisCollection<TDoc> GetCollection();

        TDoc Add(TDoc doc);

        TDoc FindById(string key);

        void DeleteById(string id);

        TDoc Update(TDoc doc);
    }
}
