using SqlDataBase;
using SqlDataBase.Types;
using System;
using System.Windows.Forms;

namespace RequestSystem.Forms
{
    public partial class AdminChangeRequestForm : Form
    {
        private readonly Request _request;
        public AdminChangeRequestForm(int requestId)
        {
            InitializeComponent();
            Load += AdminChangeRequestForm_Load;
            _request = DataBase.Requests.FindById(requestId);
            workers.Text = _request.Worker;
            priorities.Text = _request.RequestPriority;
        }

        private void AdminChangeRequestForm_Load(object sender, EventArgs e)
        {
            foreach (User user in DataBase.Users.Items)
                if (user.UserType == "Worker")
                    workers.Items.Add(user.UserLogin);

            foreach (RequestPriority priority in DataBase.RequestPriorities.Items)
                priorities.Items.Add(priority.Title);
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if(UIHelper.IsNullOrEpmty(_request.Worker)) 
            {
                MessageBox.Show("Заполните все данные");
                return;
            }

            DataBase.Requests.Save();
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Workers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _request.Worker = workers.Text;
        }

        private void priority_SelectedIndexChanged(object sender, EventArgs e)
        {
            _request.RequestPriority = priorities.Text;
        }
    }
}
