namespace RequestSystem.Forms;

partial class WorkerForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.RequestTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChangeReuestButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CreateReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RequestTable
            // 
            this.RequestTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader7,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader9});
            this.RequestTable.FullRowSelect = true;
            this.RequestTable.GridLines = true;
            this.RequestTable.HideSelection = false;
            this.RequestTable.Location = new System.Drawing.Point(13, 82);
            this.RequestTable.Margin = new System.Windows.Forms.Padding(4);
            this.RequestTable.Name = "RequestTable";
            this.RequestTable.Size = new System.Drawing.Size(1234, 436);
            this.RequestTable.TabIndex = 1;
            this.RequestTable.UseCompatibleStateImageBehavior = false;
            this.RequestTable.View = System.Windows.Forms.View.Details;
            this.RequestTable.SelectedIndexChanged += new System.EventHandler(this.RequestTable_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер";
            this.columnHeader1.Width = 124;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Приоритет";
            this.columnHeader7.Width = 153;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Дата создания";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата окончания";
            this.columnHeader3.Width = 168;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Оборудование";
            this.columnHeader4.Width = 180;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Описание проблемы";
            this.columnHeader5.Width = 180;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Тип неисправности";
            this.columnHeader6.Width = 170;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Статус";
            this.columnHeader9.Width = 137;
            // 
            // ChangeReuestButton
            // 
            this.ChangeReuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeReuestButton.Location = new System.Drawing.Point(13, 571);
            this.ChangeReuestButton.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeReuestButton.Name = "ChangeReuestButton";
            this.ChangeReuestButton.Size = new System.Drawing.Size(345, 60);
            this.ChangeReuestButton.TabIndex = 2;
            this.ChangeReuestButton.Text = "Изменить";
            this.ChangeReuestButton.UseVisualStyleBackColor = true;
            this.ChangeReuestButton.Click += new System.EventHandler(this.ChangeReuestButton_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(12, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(139, 32);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.Location = new System.Drawing.Point(1108, 554);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(139, 32);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CreateReport
            // 
            this.CreateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateReport.Location = new System.Drawing.Point(393, 571);
            this.CreateReport.Margin = new System.Windows.Forms.Padding(4);
            this.CreateReport.Name = "CreateReport";
            this.CreateReport.Size = new System.Drawing.Size(345, 60);
            this.CreateReport.TabIndex = 7;
            this.CreateReport.Text = "Создать отчет";
            this.CreateReport.UseVisualStyleBackColor = true;
            this.CreateReport.Click += new System.EventHandler(this.CreateReport_Click);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 653);
            this.Controls.Add(this.CreateReport);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ChangeReuestButton);
            this.Controls.Add(this.RequestTable);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkerForm";
            this.Text = "Форма исполнителя";
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListView RequestTable;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.ColumnHeader columnHeader6;
    private System.Windows.Forms.ColumnHeader columnHeader9;
    private System.Windows.Forms.Button ChangeReuestButton;
    private System.Windows.Forms.Button Exit;
    private System.Windows.Forms.Button UpdateButton;
    private System.Windows.Forms.ColumnHeader columnHeader7;
    private System.Windows.Forms.Button CreateReport;
}