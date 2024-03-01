using System.Data.Linq.Mapping;

namespace SqlDataBase.Types;

/// <summary>
/// Приоритетность заявки
/// </summary>
[Table(Name = "RequestPriority")]
public class RequestPriority : EntityObject
{
    /// <summary>
    /// Название приоритетности заявки, является ключевым полем, not null
    /// </summary>
    [Column(IsPrimaryKey = true, CanBeNull = false)]
    public string Title { get; set; }

}