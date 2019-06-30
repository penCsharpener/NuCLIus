using NuCLIus.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NuCLIus.Core.Contracts {
    public interface IStorageService {
        string SqliteDatabaseLocation { get; }

        Task SetupStorageSolution(string filePath);
        Task<IEnumerable<T>> GetAll<T>() where T : class, IPrimary;
        Task SaveEntity<T>(T entity) where T : class, IPrimary;
        Task DeleteEntity<T>(T entity) where T : class, IPrimary;
        Task UpdateEntity<T>(T entity) where T : class, IPrimary;
    }
}
