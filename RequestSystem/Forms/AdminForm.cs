using SqlDataBase;
using SqlDataBase.Collections;
using SqlDataBase.Types;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RequestSystem.Forms;

public partial class AdminForm : Form
{
    private int _selectedRequestId = -1;
    private string _selectedUserLogin = null;

    public AdminForm()
    {
        InitializeComponent();
        UIHelper.SetMainFormProperties(this);

        RequestCollection.OnRefresh += RequestCollection_OnRefresh;
        UserCollection.OnRefresh += UserCollection_OnRefresh;

        FillUsers(DataBase.Users.Items);
        FillRequests(DataBase.Requests.Items);
    }

    #region Users

    public void FillUsers(List<User> obj)
    {
        UserTable.Items.Clear();

        foreach (User user in obj)
            UserTable.Items.Add(new ListViewItem(user.AsItem()));
    }

    private void UserCollection_OnRefresh(List<User> obj)
    {
        FillUsers(obj);

        MessageBox.Show("Пользователи обновлены");
    }

    private void UserTable_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        if (UserTable.SelectedItems.Count != 1)
        {
            _selectedUserLogin = null;
            return;
        }
        _selectedUserLogin = UserTable.SelectedItems[0].SubItems[0].Text;
    }

    private void ChangeUserButton_Click(object sender, System.EventArgs e)
    {
        if (_selectedUserLogin == null)
        {
            MessageBox.Show("Выберите пользователя");
            return;
        }

        new ChangeUserForm(_selectedUserLogin).ShowDialog();
    }

    private void DeleteUserButton_Click(object sender, System.EventArgs e)
    {
        if (_selectedUserLogin == null)
        {
            MessageBox.Show("Выберите пользователя");
            return;
        }
        User user = DataBase.Users.Find(_selectedUserLogin);
        DataBase.Users.Delete(user);
    }

    private void AddUserButton_Click(object sender, System.EventArgs e)
    {
        new AddUserForm().ShowDialog();
    }



    #endregion//users

    #region Requests
    public void FillRequests(List<Request> obj)
    {
        RequestTable.Items.Clear();

        foreach (Request request in obj)
            RequestTable.Items.Add(new ListViewItem(request.AsAdminItem()));
    }


    private void RequestCollection_OnRefresh(List<Request> obj)
    {
        FillRequests(obj);
        MessageBox.Show("Заявки обновились");
    }

    private void RequestTable_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        if (RequestTable.SelectedIndices.Count == 0)
        {
            _selectedRequestId = -1;
            return;
        }

        int.TryParse(RequestTable.SelectedItems[0].SubItems[0].Text, out int id);
        _selectedRequestId = id;
    }

    private void ChangeReuestButton_Click(object sender, System.EventArgs e)
    {
        if (_selectedRequestId == -1)
        {
            MessageBox.Show("Выберите заявку");
            return;
        }
        new AdminChangeRequestForm(_selectedRequestId).ShowDialog();
    }


    #endregion

    private void Exit_Click(object sender, System.EventArgs e)
    {
        UIHelper.ChangeForm(this, new EnterForm());
    }

    private void UpdateButton_Click(object sender, System.EventArgs e)
    {
        FillRequests(DataBase.Requests.Items);
        FillUsers(DataBase.Users.Items);
    }

    private void посчитатьСреднееВремяToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
        List<Request> requests = DataBase.Requests.Items.FindAll(i => i.EndTime != null);

        if (requests.Count == 0)
        {
            MessageBox.Show("Ни одна заявка не выполнена");
            return;
        }

        double averageTime = 0;

        requests.ForEach(i => { averageTime += i.ExecutionTime; });

        averageTime /= requests.Count;

        MessageBox.Show($"Среднее время выполнения заявки, {averageTime} часов");
    }

    private void статистикаПоТипамToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
        string statistics = "";
        foreach (ProblemType type in DataBase.ProblemTypes.Items)
            statistics += $"{type.Title} - {DataBase.Requests.CountByProblemType(type.Title)}\n";
        MessageBox.Show(statistics);
    }

    private void количествоВыполненыхЗаявокToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
        MessageBox.Show($"Количество выполненых заявок - {DataBase.Requests.CountOf(i => i.EndTime != null)}");
    }

    private void id_TextChanged(object sender, System.EventArgs e)
    {
        int.TryParse(this.id.Text, out int id);

        FillRequests(DataBase.Requests.Items.FindAll(i => i.Id == id));
    }

    private void client_TextChanged(object sender, System.EventArgs e)
    {
        FillRequests(DataBase.Requests.Items.FindAll(i => i.Client.ToLower().StartsWith(client.Text.ToLower())));
    }

    private void worker_TextChanged(object sender, System.EventArgs e)
    {
        FillRequests(DataBase.Requests.Items.FindAll(i => i.Worker != null && i.Worker.ToLower().StartsWith(worker.Text.ToLower())));
    }

    private void description_TextChanged(object sender, System.EventArgs e)
    {
        FillRequests(DataBase.Requests.Items.FindAll(i => i.ProblemDescription.ToLower().StartsWith(worker.Text.ToLower())));

    }
}