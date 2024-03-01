using System;
using System.Data.Linq.Mapping;

namespace SqlDataBase.Types;

/// <summary>
/// Отчет исполнителя о проделанной работе
/// </summary>
[Table(Name = "Reports")]
public class Report : EntityObject
{
    /// <summary>
    /// Уникальный номер отчета, первичный ключ
    /// </summary>
    [Column(IsPrimaryKey = true, IsDbGenerated = true)]
    public int Id { get; set; }

    /// <summary>
    /// Дата и время создания отчета
    /// </summary>
    public DateTime Creation
    {
        get => DateTime.Parse(CreationDate);
        set => CreationDate = value.ToString();
    }
    /// <summary>
    /// Дата и время создания
    /// </summary>
    [Column(CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public string CreationDate { get; set; }


    /// <summary>
    /// Номер заявки
    /// </summary>
    [Column(CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public int RequestId { get; set; }

    /// <summary>
    /// Материалы, которые потребовались для устранения проблемы
    /// </summary>
    [Column(CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public string Matherials { get; set; }

    /// <summary>
    /// Затраты на устранение проблемы
    /// </summary>
    [Column(CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public double Cost { get; set; }

    /// <summary>
    /// Причина проблемы
    /// </summary>
    [Column(CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public string Reason { get; set; }

    /// <summary>
    /// Проделланная работа, чтобы устранить проблему 
    /// </summary>
    [Column(CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public string WorkDone { get; set; }


}
