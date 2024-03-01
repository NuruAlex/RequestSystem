using SqlDataBase;
using SqlDataBase.Types;
using System;
using System.Windows.Forms;

namespace RequestSystem.Forms;

public partial class ChangeUserForm : Form
{
    private readonly User _user;
    public ChangeUserForm(string userLogin)
    {
        InitializeComponent();
        _user = DataBase.Users.Find(userLogin);
        Load += ChangeUserForm_Load;
    }

    private void ChangeUserForm_Load(object sender, EventArgs e)
    {
        password.Text = _user.UserPassword;
        fullname.Text = _user.UserFullName;
        userType.Text = _user.UserType;
    }

    private void password_TextChanged(object sender, EventArgs e)
    {
        _user.UserPassword = password.Text;
    }

    private void fullname_TextChanged(object sender, EventArgs e)
    {
        _user.UserFullName = fullname.Text;
    }

    private void userType_SelectedIndexChanged(object sender, EventArgs e)
    {
        _user.UserType = userType.Text;
    }

    private void ChangeButton_Click(object sender, EventArgs e)
    {
        if (UIHelper.IsNullOrEpmty(_user.UserFullName,
                                    _user.UserPassword,
                                    _user.UserType))
        {
            MessageBox.Show("Заполните все данные");
            return;
        }

        DataBase.Users.Save();
        Hide();
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
        Hide();
    }
}
