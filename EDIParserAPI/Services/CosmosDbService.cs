using EDIParserAPIService.Services;
using EDIParserAPIService.Models;
using Microsoft.Azure.Cosmos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EDIParserAPIService.Services
{
    public class CosmosDbService : ICosmosDbService
    {
        private readonly Container _container;
        public CosmosDbService(CosmosClient CosmosDbClient, string databaseName, string containerName)
        {
            _container = CosmosDbClient.GetContainer(databaseName, containerName);
        }
        public async Task AddAsync(EDI edi)
        {
            await _container.CreateItemAsync(edi, new PartitionKey(edi.id));
        }
        public async Task DeleteAsync(string id)
        {
            await _container.DeleteItemAsync<EDI>(id, new PartitionKey(id));
        }

        public async Task<EDI> GetAsync(string id)
        {
            try
            {
                var response = await _container.ReadItemAsync<EDI>(id, new PartitionKey(id));
                return response.Resource;

            }
            catch (CosmosException)
            {
                return null;
            }
        }

        public async Task<IEnumerable<EDI>> GetMultipleAsync(string query)
        {
            var queryString = _container.GetItemQueryIterator<EDI>(new QueryDefinition(query));
            var results = new List<EDI>();
            while (queryString.HasMoreResults)
            {
                var response = await queryString.ReadNextAsync();
                results.AddRange(response.ToList());
            }

            return results;
        }

        public async Task UpdateAsync(string id, EDI edi)
        {
            await _container.UpsertItemAsync<EDI>(edi, new PartitionKey(id));
        }

    }
}
