using SqlDataBase;
using SqlDataBase.Types;
using System.Windows.Forms;

namespace RequestSystem.Forms;

public partial class ClientChangeRequestForm : Form
{
    private readonly Request _request;
    public ClientChangeRequestForm(int requestId)
    {
        InitializeComponent();
        _request = DataBase.Requests.FindById(requestId);
        problemDescription.Text = _request.ProblemDescription;
    }

    private void ProblemDescription_TextChanged(object sender, System.EventArgs e)
    {
        _request.ProblemDescription = problemDescription.Text;
    }

    private void ExitButton_Click(object sender, System.EventArgs e)
    {
        Hide();
    }

    private void ChangeButton_Click(object sender, System.EventArgs e)
    {
        if(UIHelper.IsNullOrEpmty(_request.ProblemDescription)) 
        {
            MessageBox.Show("Заполните все данные");
            return;
        }

        DataBase.Requests.Save();
        MessageBox.Show("Заявка изменена");
        Hide();
    }
}
