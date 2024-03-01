using SqlDataBase;
using SqlDataBase.Collections;
using SqlDataBase.Types;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RequestSystem.Forms
{
    public partial class UserForm : Form
    {
        private readonly User _user;
        private int _selectedReqestId = -1;

        public UserForm(User user)
        {
            InitializeComponent();
            _user = user;
            RequestCollection.OnRefresh += RequestCollection_OnRefresh;
            FillRequests(DataBase.Requests.Items);
            UIHelper.SetMainFormProperties(this);
        }

        private void FillRequests(List<Request> requests)
        {
            RequestTable.Items.Clear();

            foreach (Request request in requests)
                if (request.Client == _user.UserLogin)
                    RequestTable.Items.Add(new ListViewItem(request.AsClientItem()));
        }

        private void RequestCollection_OnRefresh(List<Request> obj)
        {
            FillRequests(obj);
            MessageBox.Show("Заявки обновились");
        }

        private void RequestTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RequestTable.SelectedIndices.Count == 0)
            {
                _selectedReqestId = -1;
                return;
            }

            if (int.TryParse(RequestTable.SelectedItems[0].SubItems[0].Text, out int id))
                _selectedReqestId = id;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_selectedReqestId == -1)
            {
                MessageBox.Show("Выберите заявку");
                return;
            }

            DataBase.Requests.Delete(_selectedReqestId);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (_selectedReqestId == -1)
            {
                MessageBox.Show("Выберите заявку");
                return;
            }
            new ClientChangeRequestForm(_selectedReqestId).Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new AddRequestForm(_user).Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            UIHelper.ChangeForm(this, new EnterForm());
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            FillRequests(DataBase.Requests.Items);
        }

        private void Report_Click(object sender, EventArgs e)
        {
            if (_selectedReqestId == -1)
            {
                MessageBox.Show("Выберите заявку");
                return;
            }

            Report report = DataBase.Reports.FindByRequestId(_selectedReqestId);

            if (report == null)
            {
                MessageBox.Show("Отчет по этой заявке еще не составлен");
                return;
            }

            string info = $"Отчет от {report.Creation}\n" +
                $"Материалы: {report.Matherials}\n" +
                $"Причина неисправности:{report.Reason}\n" +
                $"Проделанная работа:{report.WorkDone}\n" +
                $"Итоговая стоимость:{report.Cost} рублей\n";

            MessageBox.Show(info);

        }
    }
}
