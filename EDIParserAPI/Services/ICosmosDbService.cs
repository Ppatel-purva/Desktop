using EDIParserAPIService.Models;
using EDIParserAPIService.Services;
using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace EDIParserAPIService.Services
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<EDI>> GetMultipleAsync(string query);
        Task<EDI> GetAsync(string id);
        Task AddAsync(EDI edi);
        Task UpdateAsync(string id, EDI edi);
        Task DeleteAsync(string id);
    }
}