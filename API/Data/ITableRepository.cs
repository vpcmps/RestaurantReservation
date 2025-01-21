using API.Models;

namespace API.Data;

public interface ITableRepository
{
    Task<Table> AddTable(Table table);
    Task<bool> UpdateTable(Table table);
    Task<bool> DeleteTable(Guid tableId);
    Task<List<Table>> ListTables();
    Task<Table> GetTableById(Guid idTable);
}
