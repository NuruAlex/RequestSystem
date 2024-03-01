using System.Data.Linq.Mapping;

namespace SqlDataBase.Types;

/// <summary>
/// Тип пользователя
/// </summary>
[Table(Name = "UserTypes")]
public class UserType : EntityObject
{
    /// <summary>
    /// Название типа пользователя, является ключевым полем, not null
    /// </summary>
    [Column(IsPrimaryKey = true, CanBeNull = false)]
    public string Title { get; set; }
}
