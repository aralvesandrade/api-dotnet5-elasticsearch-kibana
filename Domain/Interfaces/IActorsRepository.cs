using ApiElasticSearch.Infrastructure.Elastic;
using ApiElasticSearch.Infrastructure.Indices;

namespace ApiElasticSearch.Domain.Interfaces
{
    public interface IActorsRepository : IElasticBaseRepository<IndexActors>
    {
    }
}