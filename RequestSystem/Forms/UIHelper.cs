using SqlDataBase.Types;
using System.Linq;
using System.Windows.Forms;

namespace RequestSystem.Forms;

public static class UIHelper
{
    /// <summary>
    /// Меняет одну открытую форму на другую
    /// </summary>
    /// <param name="from">Форма для закрытия</param>
    /// <param name="to">Форма для открытия</param>
    public static void ChangeForm(Form from, Form to)
    {
        from.Hide();
        to.Show();
    }
    /// <summary>
    /// Назначает событие click у кнопки скрытием формы
    /// </summary>
    /// <param name="form"></param>
    /// <param name="button"></param>
    public static void SetHideButton(Form form, Button button) => button.Click += (s, ev) => form.Hide();
    /// <summary>
    /// Метод устанавливает базовые свойства для главной формы
    /// </summary>
    /// <param name="form">Главная форма</param>
    public static void SetMainFormProperties(Form form)
    {
        form.FormClosed += (s, ev) => Application.Exit();
        form.StartPosition = FormStartPosition.CenterScreen;
    }

    /// <summary>
    /// Метод получает форму после формы входа в зависимости от статуса пользователя
    /// </summary>
    /// <param name="user">пользователь для определения формы</param>
    /// <param name="from">Форма из которой происходит запрос</param>
    /// <returns>Форма после формы входа</returns>
    public static Form GetFormByUserStatus(User user) => user.UserType switch
    {
        "Admin" => new AdminForm(),
        "Default" => new UserForm(user),
        "Worker" => new WorkerForm(user),
        _ => null,
    };
    public static bool IsNullOrEpmty(params string[] values) => values.Contains(null) || values.Contains("");
}
