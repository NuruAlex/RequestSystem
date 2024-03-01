using System.Data.Linq.Mapping;

namespace SqlDataBase.Types;

/// <summary>
/// Статус заявки
/// </summary>
[Table(Name = "RequestStatus")]
public class RequestStatus : EntityObject
{
    /// <summary>
    /// Название статуса заявки, является ключевым полем, not null
    /// </summary>
    [Column(IsPrimaryKey = true, CanBeNull = false)]
    public string Title { get; set; }
}
