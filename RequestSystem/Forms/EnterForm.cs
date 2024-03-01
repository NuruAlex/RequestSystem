using SqlDataBase;
using SqlDataBase.Types;
using System;
using System.Windows.Forms;

namespace RequestSystem.Forms;

/// <summary>
/// Форма входа 
/// </summary>
public partial class EnterForm : Form
{
    public EnterForm()
    {
        InitializeComponent();
        UIHelper.SetMainFormProperties(this);
    }
    private void EnterButton_Click(object sender, EventArgs e)
    {
        User user = DataBase.Users.Find(login.Text, password.Text);

        if (user == null)
        {
            MessageBox.Show("Логин либо пароль неверны");
            return;
        }

       
        Form next = UIHelper.GetFormByUserStatus(user);

        if (next == null)
        {
            MessageBox.Show("Кажется произошка ошибка,\n статус пользователя не определен");
            return;
        }

        UIHelper.ChangeForm(this, next);
    }
}
