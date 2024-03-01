using SqlDataBase.Types;

namespace SqlDataBase.Collections;

/// <summary>
/// Коллекция пользователей в таблицe Users
/// </summary>
public class UserCollection : SqlCollection<User>
{
    /// <summary>
    /// Выполняет поиск по логину в таблицу пользователе
    /// </summary>
    /// <param name="login">Логин пользователя</param>
    /// <returns> Возвращает первое вхождение; в противном случае - null </returns>
    public User Find(string login) => Find(i => i.UserLogin == login);
    /// <summary>
    /// Метод выполрняет поиск пользователя по логину и паролю
    /// </summary>
    /// <param name="login">Логин пользователя</param>
    /// <param name="password">Пароль пользователя</param>
    /// <returns>Возвращает первое вхождение; в противном случае - null</returns>
    public User Find(string login, string password) => Find(i => i.UserLogin == login && i.UserPassword == password);

}
