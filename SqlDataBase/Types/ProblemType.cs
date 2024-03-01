using System.Data.Linq.Mapping;

namespace SqlDataBase.Types;

/// <summary>
/// Тип неисправности
/// </summary>
[Table(Name = "ProblemTypes")]
public class ProblemType : EntityObject
{
    /// <summary>
    /// Название типа неисправности, первичный ключ
    /// </summary>
    [Column(IsPrimaryKey = true, CanBeNull = false)]
    public string Title { get; set; }
}
