using System.Data.Linq.Mapping;

namespace SqlDataBase.Types;
/// <summary>
/// Тип, реализующий данные пользователя в базе данных
/// </summary>
[Table(Name = "Users")]
public class User : EntityObject
{
    /// <summary>
    /// Логин пользователя, является ключевым полем, not null
    /// </summary>
    [Column(IsPrimaryKey = true, CanBeNull = false)]
    public string UserLogin { get; set; }

    /// <summary>
    /// Пароль пользователя, not null   
    /// </summary>
    [Column(CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public string UserPassword { get; set; }


    /// <summary>
    /// Полное Имя пользователя, not null
    /// </summary>
    [Column(CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public string UserFullName { get; set; }

    /// <summary>
    /// Тип пользователя, not null, поле из таблицы UsersTypes
    /// </summary>

    [Column(CanBeNull = false, UpdateCheck = UpdateCheck.Never)]
    public string UserType { get; set; }

    public string[] AsItem() => new string[]
    {
        UserLogin,
        UserPassword,
        UserFullName,
        UserType
    };

    public override bool Equals(object obj)
    {
        if (obj == null || obj.GetType() != typeof(User))
            return false;

        return UserLogin == (obj as User).UserLogin;
    }

    public override int GetHashCode() => base.GetHashCode();
}
