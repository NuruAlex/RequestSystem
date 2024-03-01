using SqlDataBase;
using SqlDataBase.Types;
using System.Windows.Forms;

namespace RequestSystem.Forms;

public partial class AddUserForm : Form
{
    private readonly User _user = new();
    public AddUserForm()
    {
        InitializeComponent();
        Load += AddUserForm_Load;
        UIHelper.SetHideButton(this, ExitButton);
    }

    private void AddUserForm_Load(object sender, System.EventArgs e)
    {
        foreach (UserType type in DataBase.UsersTypes.Items)
            userType.Items.Add(type.Title);
    }

    private void AddUser_Click(object sender, System.EventArgs e)
    {
        if (UIHelper.IsNullOrEpmty(_user.UserLogin,
            _user.UserPassword,
            _user.UserFullName,
            _user.UserType))
        {
            MessageBox.Show("Введите все данные");
            return;
        }

        if (DataBase.Users.Find(_user.UserLogin) != null)
        {
            MessageBox.Show("Пользователь с таким логином уже существует, пожалуйста введите другой логин");
            return;
        }

        DataBase.Users.Insert(_user);
        Hide();
    }

    private void Fullname_TextChanged(object sender, System.EventArgs e)
    {
        _user.UserFullName = fullname.Text;
    }

    private void Login_TextChanged(object sender, System.EventArgs e)
    {
        _user.UserLogin = login.Text;
    }

    private void Password_TextChanged(object sender, System.EventArgs e)
    {
        _user.UserPassword = password.Text;
    }

    private void UserType_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        _user.UserType = userType.Text;
    }
}
