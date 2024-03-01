using SqlDataBase;
using SqlDataBase.Types;
using System;
using System.Windows.Forms;

namespace RequestSystem.Forms;

public partial class WorkerChangeRequestForm : Form
{
    private readonly Request _request;
    public WorkerChangeRequestForm(int requestId)
    {
        InitializeComponent();
        _request = DataBase.Requests.FindById(requestId);
        requestStatus.Text = _request.RequestStatus;
        requestStatus.SelectedIndexChanged += RequestStatus_SelectedIndexChanged;
        UIHelper.SetHideButton(this, ExitButton);
        FillComboBox();

    }
    private void FillComboBox()
    {
        foreach (RequestStatus type in DataBase.RequestStatuses.Items)
            requestStatus.Items.Add(type.Title);
    }

    private void RequestStatus_SelectedIndexChanged(object sender, EventArgs e)
    {
        _request.RequestStatus = requestStatus.Text;

        if (_request.RequestStatus == "Выполнено")
            _request.End = DateTime.Now;
        else
            _request.EndTime = null;
    }

    private void ChangeButton_Click(object sender, EventArgs e)
    {
        if (UIHelper.IsNullOrEpmty(_request.RequestStatus))
        {
            MessageBox.Show("Заполните данные");
            return;
        }

        DataBase.Requests.Save();
        Hide();
    }

    private void Comments_TextChanged(object sender, EventArgs e)
    {
        _request.Comments = Comments.Text;
    }
}
