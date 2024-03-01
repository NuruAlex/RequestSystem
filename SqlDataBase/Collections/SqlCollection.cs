using SqlDataBase.Types;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace SqlDataBase.Collections;

/// <summary>
/// Класс реализует взаимодейтие с Sql объектами
/// </summary>
/// <typeparam name="T">Тип, реализующий mapping записи в таблицу SQL,
/// класс должен наследоваться от <see cref="EntityObject"/></typeparam>
public class SqlCollection<T> where T : EntityObject
{
    private List<T> _data;
    private readonly DataContext _context;

    /// <summary>
    /// Таблица из контекста
    /// </summary>
    private Table<T> Table => _context.GetTable<T>();

    /// <summary>
    /// Число элементов в таблице
    /// </summary>
    public int Count => _data.Count;

    /// <summary>
    /// Событие обновления коллекции
    /// </summary>
    public static event Action<List<T>> OnRefresh;

    /// <summary>
    /// Список элементов таблицы из базы данных
    /// </summary>
    public List<T> Items => _data;

    /// <summary>
    /// При вызове конструкота подгружаются данные из базы данных
    /// </summary>
    public SqlCollection()
    {
        _context = new(DataBase.ConnectionString);

        _data = Select();
    }

    /// <summary>
    /// Данные сохраняются в базе данный и вызывается событие <see cref="OnRefresh"/>
    /// </summary>
    public void Save()
    {
        _context.SubmitChanges();
        _data = Select();
        OnRefresh?.Invoke(_data);
    }

    /// <summary>
    /// Метод загружает данные из таблице в виде списка объектов
    /// </summary>
    /// <returns>Возвращает список объектов соответсующих записям в таблце</returns>
    public List<T> Select() => Table.ToList();

    /// <summary>
    /// Добавляет одну запись в таблицу
    /// </summary>
    /// <param name="item">Объект для добавления</param>
    public void Insert(T item)
    {
        if (item == null) return;
        Table.InsertOnSubmit(item);
        Save();
    }

    /// <summary>
    /// Удаляет запись из таблицы
    /// </summary>
    /// <param name="item">Объект для удаления</param>
    public void Delete(T item)
    {
        if (item == null) return;

        Table.DeleteOnSubmit(item);
        Save();
    }

    /// <summary>
    /// Метод считает количество объектов, удовлетворяющих условию
    /// </summary>
    /// <param name="match">условие для подсчета</param>
    /// <returns>количество объектов, удовлетворяющих условию; в противном случае - 0</returns>
    public int CountOf(Predicate<T> match) => _data.FindAll(match).Count;

    /// <summary>
    /// Метод выполняет поиск в таблице и возвращает первое совпадение
    /// </summary>
    /// <param name="predicate">Условия для поиска</param>
    /// <returns>Первый элемент, удовлетворяющий условиям указанного предиката, если такой элемент
    /// найден; в противном случае — значение по умолчанию для типа T </returns>
    public T Find(Predicate<T> predicate) => _data.Find(predicate);
}
