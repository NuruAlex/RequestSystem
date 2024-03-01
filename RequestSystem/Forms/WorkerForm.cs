using SqlDataBase;
using SqlDataBase.Collections;
using SqlDataBase.Types;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RequestSystem.Forms;

public partial class WorkerForm : Form
{
    private int _selectedRequestId = -1;
    private readonly User _user;

    public WorkerForm(User user)
    {
        InitializeComponent();
        _user = user;

        RequestCollection.OnRefresh += RequestCollection_OnRefresh;
        FillRequests(DataBase.Requests.Items);
        UIHelper.SetMainFormProperties(this);
    }

    private void RequestCollection_OnRefresh(List<Request> obj)
    {
        FillRequests(obj);
        MessageBox.Show("Заявки обновлены");
    }

    private void FillRequests(List<Request> requests)
    {
        RequestTable.Items.Clear();

        foreach (Request request in requests)
            if (request.Worker == _user.UserLogin)
                RequestTable.Items.Add(new ListViewItem(request.AsWorkerItem()));
    }

    private void ChangeReuestButton_Click(object sender, EventArgs e)
    {
        if (_selectedRequestId == -1)
        {
            MessageBox.Show("Выберите заявку");
            return;
        }
        new WorkerChangeRequestForm(_selectedRequestId).ShowDialog();
    }

    private void RequestTable_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RequestTable.SelectedItems.Count != 1)
        {
            _selectedRequestId = -1;
            return;
        }

        int.TryParse(RequestTable.SelectedItems[0].SubItems[0].Text, out int id);

        _selectedRequestId = id;
    }

    private void Exit_Click(object sender, EventArgs e)
    {
        UIHelper.ChangeForm(this, new EnterForm());
    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        FillRequests(DataBase.Requests.Items);
    }

    private void CreateReport_Click(object sender, EventArgs e)
    {
        if (_selectedRequestId == -1)
        {
            MessageBox.Show("Выберите заявку");
            return;
        }

        if (DataBase.Reports.FindByRequestId(_selectedRequestId) != null)
        {
            MessageBox.Show("Отчет на эту заявку уже существует");
            return;
        }

        new CreateReportForm(_selectedRequestId).ShowDialog();
    }
}
