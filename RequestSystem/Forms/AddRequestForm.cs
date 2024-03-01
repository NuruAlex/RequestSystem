using SqlDataBase;
using SqlDataBase.Types;
using System;
using System.Windows.Forms;

namespace RequestSystem.Forms;

public partial class AddRequestForm : Form
{
    private readonly User _user;
    private readonly Request _request;

    public AddRequestForm(User user)
    {
        InitializeComponent();
        _user = user;
        _request = new Request();
        UIHelper.SetHideButton(this, ExitButton);
    }


    private void Equipment_TextChanged(object sender, EventArgs e)
    {
        _request.Equipment = Equipment.Text;
    }

    private void ProblemDescription_TextChanged(object sender, EventArgs e)
    {
        _request.ProblemDescription = problemDescription.Text;
    }

    private void ProblemType_SelectedIndexChanged(object sender, EventArgs e)
    {
        _request.ProblemType = ProblemType.Text;
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        if (UIHelper.IsNullOrEpmty(_request.Equipment, 
                                   _request.ProblemDescription, 
                                   _request.ProblemType))
        {
            MessageBox.Show("Введите все данные");
            return;
        }

        _request.Creation = DateTime.Now;
        _request.Client = _user.UserLogin;
        _request.RequestStatus = "В ожидании";

        DataBase.Requests.Insert(_request);

        Hide();
    }

    private void AddRequestForm_Load(object sender, EventArgs e)
    {
        foreach (ProblemType problem in DataBase.ProblemTypes.Items)
            ProblemType.Items.Add(problem.Title);
    }
}
