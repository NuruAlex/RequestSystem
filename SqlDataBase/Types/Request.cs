using System;
using System.Data.Linq.Mapping;

namespace SqlDataBase.Types;

/// <summary>
/// Заявка на ремонт
/// </summary>
[Table(Name = "Requests")]
public class Request : EntityObject
{
    /// <summary>
    /// Номер заявки, является ключевым полем, not null, генерируется автоматически
    /// </summary>
    [Column(IsPrimaryKey = true, IsDbGenerated = true)]
    public int Id { get; set; }

    /// <summary>
    /// Время исполнения заявки 
    /// </summary>
    public double ExecutionTime => (End - Creation).TotalHours;


    /// <summary>
    /// Дата добавления
    /// </summary>
    public DateTime Creation
    {
        get => DateTime.Parse(AdditionalTime);
        set => AdditionalTime = value.ToString();
    }
    /// <summary>
    /// Комментарии к заявке
    /// </summary>
    [Column(CanBeNull = true, UpdateCheck = UpdateCheck.Never)]
    public string Comments { get; set; }
    /// <summary>
    /// Дата добавления
    /// </summary>
    [Column(CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public string AdditionalTime { get; set; }

    /// <summary>
    /// Дата окончания
    /// </summary>
    public DateTime End
    {
        get => DateTime.Parse(EndTime);
        set => EndTime = value.ToString();
    }

    /// <summary>
    /// Дата окончания
    /// </summary>
    [Column(CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public string EndTime { get; set; }

    /// <summary>
    /// Оборудование
    /// </summary>
    [Column(CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public string Equipment { get; set; }

    /// <summary>
    /// Описание проблемы
    /// </summary>
    [Column(CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public string ProblemDescription { get; set; }

    /// <summary>
    /// Тип неисправности
    /// </summary>
    [Column(CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public string ProblemType { get; set; }

    /// <summary>
    /// Дщпшт клиента, подавшего заявку
    /// </summary>
    [Column(CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public string Client { get; set; }

    /// <summary>
    /// Логин ответственного 
    /// </summary>
    [Column(CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public string Worker { get; set; }

    /// <summary>
    /// Статус выполнения
    /// </summary>
    [Column(CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public string RequestStatus { get; set; }

    [Column(CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public string RequestPriority { get; set; }
    public string[] AsClientItem() => new string[]
    {
        Id.ToString(),
        ProblemType,
        Worker ?? "Не выбран",
        RequestStatus
    };

    public string[] AsAdminItem() => new string[]
    {
        Id.ToString(),
        RequestPriority??"Не определена",
        AdditionalTime,
        EndTime ?? "Не закончено",
        Equipment,
        ProblemDescription,
        ProblemType,
        Client,
        Worker ?? "Не выбран",
        RequestStatus
    };
    public string[] AsWorkerItem() => new string[]
    {
        Id.ToString(),
        RequestPriority??"Не определена",
        AdditionalTime,
        EndTime ?? "Не закончено",
        Equipment,
        ProblemDescription,
        ProblemType,
        RequestStatus

    };
}
