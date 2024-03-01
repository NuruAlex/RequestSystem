using SqlDataBase.Collections;
using System;

namespace SqlDataBase;

/// <summary>
/// Класс, содержащий коллекции, каждая из которыйх представляет собой таблицу в базе данных.
/// Класс является proxy, коллекции инициализируются 1 раз
/// </summary>
public static class DataBase
{
    /// <summary>
    /// Имя базы данных для подключения
    /// </summary>
    public static string Name { get; set; }

    /// <summary>
    /// Строка подключения к базе данных
    /// </summary>
    public static string ConnectionString => $"data source = {Environment.MachineName}\\sqlexpress;" +
                                                            $"database = {Name};" +
                                                                $"trusted_connection = true";

    #region PrivateFields

    private static UserCollection _users;
    private static UserTypeCollection _userTypes;
    private static RequestStatusCollection _requestStatuses;
    private static RequestCollection _requests;
    private static ProblemTypeCollection _problemTypes;
    private static RequestPriorityCollection _priorities;
    private static ReportCollection _reports;

    #endregion

    /// <summary>
    /// Коллекция пользователей в таблицe Users
    /// </summary>
    public static UserCollection Users => _users ??= new();

    /// <summary>
    /// Коллекция типов пользователей в таблице UsersTypes
    /// </summary>
    public static UserTypeCollection UsersTypes => _userTypes ??= new();

    /// <summary>
    /// Коллекциия статусов заявок в таблице RequestStatuses
    /// </summary>
    public static RequestStatusCollection RequestStatuses => _requestStatuses ??= new();

    /// <summary>
    /// Коллекция заявок в таблице Requests
    /// </summary>
    public static RequestCollection Requests => _requests ??= new();

    /// <summary>
    /// Классификация проблем в таблице ProblemTypes
    /// </summary>
    public static ProblemTypeCollection ProblemTypes => _problemTypes ??= new();

    /// <summary>
    /// Коллекция приоритетностей заявок RequestPriorities
    /// </summary>
    public static RequestPriorityCollection RequestPriorities => _priorities ??= new();

    /// <summary>
    /// Коллекция отчетов исполнителей в таблице Reports
    /// </summary>
    public static ReportCollection Reports => _reports ??= new();
}
