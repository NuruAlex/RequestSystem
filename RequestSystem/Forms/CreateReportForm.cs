using SqlDataBase;
using SqlDataBase.Types;
using System;
using System.Windows.Forms;

namespace RequestSystem.Forms;

public partial class CreateReportForm : Form
{
    private readonly Report _report = new();
    public CreateReportForm(int requestId)
    {
        InitializeComponent();
        _report.RequestId = requestId;
        _report.Creation = DateTime.Now;
    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        if (_report.Cost == -1f || UIHelper.IsNullOrEpmty(_report.Matherials,
                                                        _report.WorkDone,
                                                        _report.Reason))
        {
            MessageBox.Show("Введите все данные");
            return;
        }
        DataBase.Reports.Insert(_report);
        MessageBox.Show("Отчет добавлен");
        Hide();
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
        Hide();
    }

    private void workDone_TextChanged(object sender, EventArgs e)
    {
        _report.WorkDone = workDone.Text;
    }

    private void matherials_TextChanged(object sender, EventArgs e)
    {
        _report.Matherials = matherials.Text;
    }

    private void reason_TextChanged(object sender, EventArgs e)
    {
        _report.Reason = reason.Text;
    }

    private void Cost_TextChanged(object sender, EventArgs e)
    {
        if (!float.TryParse(cost.Text, out float value))
        {
            MessageBox.Show("Стоимость должна быть вещественным числом");
            _report.Cost = -1f;
            return;
        }
        if (value < 0f)
        {
            MessageBox.Show("Стоимость должна быть положительным числом");
            _report.Cost = -1f;
            return;
        }

        _report.Cost = value;
    }
}
