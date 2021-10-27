using ApiElasticSearch.Domain.Interfaces;
using ApiElasticSearch.Infrastructure.Elastic;
using ApiElasticSearch.Infrastructure.Indices;
using Nest;

namespace ApiElasticSearch.Domain.Repositories
{
    public class ActorsRepository : ElasticBaseRepository<IndexActors>, IActorsRepository
    {
        public ActorsRepository(IElasticClient elasticClient) 
            : base(elasticClient)
        {
        }

        public override string IndexName { get; } = "indexactors";
    }
}