using SqlDataBase.Types;

namespace SqlDataBase.Collections;

/// <summary>
/// Коллекция заявок в таблице Requests
/// </summary>
public class RequestCollection : SqlCollection<Request>
{
    /// <summary>
    /// Метод выполняет поиск заявки по id
    /// </summary>
    /// <param name="id">Параметр для поиска</param>
    /// <returns> Первый элемент, удовлетворяющий условиям указанного предиката, если такой элемент
    /// найден; в противном случае — значение по умолчанию для типа T </returns>
    public Request FindById(int id) => Find(i => i.Id == id);

    /// <summary>
    /// Метод подсчитывает количество элементов, у которых тип неисправности совпадает с параметром
    /// </summary>
    /// <param name="type">Тип неисправности</param>
    /// <returns>Количество совпадений</returns>
    public int CountByProblemType(string type) => CountOf(i => i.ProblemType == type);


    /// <summary>
    /// Метод удаляет заявку по id
    /// </summary>
    /// <param name="id">Параметр для поиска</param>
    /// <returns>Первый элемент, удовлетворяющий условиям указанного предиката, если такой элемент
    /// найден; в противном случае — значение по умолчанию для типа T </returns>
    public void Delete(int id) => Delete(FindById(id));
}
