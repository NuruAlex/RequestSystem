using SqlDataBase.Types;

namespace SqlDataBase.Collections;

/// <summary>
/// Коллекция отчетов исполнителей в таблице Reports
/// </summary>
public class ReportCollection : SqlCollection<Report>
{
    /// <summary>
    /// Метод ищет отчет по номеру заявки
    /// </summary>
    /// <param name="requestId">Номер заявки</param>
    /// <returns>Отчет который удовлетворяет условию; В противном случае - null</returns>
    public Report FindByRequestId(int requestId) => Find(i => i.RequestId == requestId);
}
