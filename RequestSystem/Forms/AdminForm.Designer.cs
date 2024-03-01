namespace RequestSystem.Forms
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.RequestTable = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.посчитатьСреднееВремяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаПоТипамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоВыполненыхЗаявокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeReuestButton = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabControl();
            this.по = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.client = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.worker = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.ChangeUserButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.UserTable = new System.Windows.Forms.ListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.по.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RequestTable
            // 
            this.RequestTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader10,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.RequestTable.ContextMenuStrip = this.contextMenuStrip1;
            this.RequestTable.FullRowSelect = true;
            this.RequestTable.GridLines = true;
            this.RequestTable.HideSelection = false;
            this.RequestTable.Location = new System.Drawing.Point(8, 62);
            this.RequestTable.Name = "RequestTable";
            this.RequestTable.Size = new System.Drawing.Size(1319, 318);
            this.RequestTable.TabIndex = 0;
            this.RequestTable.UseCompatibleStateImageBehavior = false;
            this.RequestTable.View = System.Windows.Forms.View.Details;
            this.RequestTable.SelectedIndexChanged += new System.EventHandler(this.RequestTable_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер";
            this.columnHeader1.Width = 124;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Приоритетность";
            this.columnHeader10.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Дата создания";
            this.columnHeader2.Width = 186;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата окончания";
            this.columnHeader3.Width = 183;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Оборудование";
            this.columnHeader4.Width = 131;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Описание проблемы";
            this.columnHeader5.Width = 206;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Тип неисправности";
            this.columnHeader6.Width = 172;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Логин клиента";
            this.columnHeader7.Width = 148;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ответственный";
            this.columnHeader8.Width = 162;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Статус";
            this.columnHeader9.Width = 137;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посчитатьСреднееВремяToolStripMenuItem,
            this.статистикаПоТипамToolStripMenuItem,
            this.количествоВыполненыхЗаявокToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(304, 76);
            // 
            // посчитатьСреднееВремяToolStripMenuItem
            // 
            this.посчитатьСреднееВремяToolStripMenuItem.Name = "посчитатьСреднееВремяToolStripMenuItem";
            this.посчитатьСреднееВремяToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.посчитатьСреднееВремяToolStripMenuItem.Text = "Посчитать среднее время";
            this.посчитатьСреднееВремяToolStripMenuItem.Click += new System.EventHandler(this.посчитатьСреднееВремяToolStripMenuItem_Click);
            // 
            // статистикаПоТипамToolStripMenuItem
            // 
            this.статистикаПоТипамToolStripMenuItem.Name = "статистикаПоТипамToolStripMenuItem";
            this.статистикаПоТипамToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.статистикаПоТипамToolStripMenuItem.Text = "Статистика по типам";
            this.статистикаПоТипамToolStripMenuItem.Click += new System.EventHandler(this.статистикаПоТипамToolStripMenuItem_Click);
            // 
            // количествоВыполненыхЗаявокToolStripMenuItem
            // 
            this.количествоВыполненыхЗаявокToolStripMenuItem.Name = "количествоВыполненыхЗаявокToolStripMenuItem";
            this.количествоВыполненыхЗаявокToolStripMenuItem.Size = new System.Drawing.Size(303, 24);
            this.количествоВыполненыхЗаявокToolStripMenuItem.Text = "Количество выполненых заявок";
            this.количествоВыполненыхЗаявокToolStripMenuItem.Click += new System.EventHandler(this.количествоВыполненыхЗаявокToolStripMenuItem_Click);
            // 
            // ChangeReuestButton
            // 
            this.ChangeReuestButton.Location = new System.Drawing.Point(6, 429);
            this.ChangeReuestButton.Name = "ChangeReuestButton";
            this.ChangeReuestButton.Size = new System.Drawing.Size(276, 44);
            this.ChangeReuestButton.TabIndex = 1;
            this.ChangeReuestButton.Text = "Изменить ";
            this.ChangeReuestButton.UseVisualStyleBackColor = true;
            this.ChangeReuestButton.Click += new System.EventHandler(this.ChangeReuestButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.по);
            this.tabPage1.Controls.Add(this.tabPage2);
            this.tabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.SelectedIndex = 0;
            this.tabPage1.Size = new System.Drawing.Size(1355, 626);
            this.tabPage1.TabIndex = 2;
            // 
            // по
            // 
            this.по.Controls.Add(this.label4);
            this.по.Controls.Add(this.client);
            this.по.Controls.Add(this.label3);
            this.по.Controls.Add(this.worker);
            this.по.Controls.Add(this.label2);
            this.по.Controls.Add(this.description);
            this.по.Controls.Add(this.label1);
            this.по.Controls.Add(this.id);
            this.по.Controls.Add(this.UpdateButton);
            this.по.Controls.Add(this.Exit);
            this.по.Controls.Add(this.RequestTable);
            this.по.Controls.Add(this.ChangeReuestButton);
            this.по.Location = new System.Drawing.Point(4, 31);
            this.по.Name = "по";
            this.по.Padding = new System.Windows.Forms.Padding(3);
            this.по.Size = new System.Drawing.Size(1347, 591);
            this.по.TabIndex = 0;
            this.по.Text = "Заявки";
            this.по.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(743, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Поиск по логину клиента";
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(747, 531);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(265, 28);
            this.client.TabIndex = 13;
            this.client.TextChanged += new System.EventHandler(this.client_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Поиск по логину исполнителя";
            // 
            // worker
            // 
            this.worker.Location = new System.Drawing.Point(434, 531);
            this.worker.Name = "worker";
            this.worker.Size = new System.Drawing.Size(255, 28);
            this.worker.TabIndex = 11;
            this.worker.TextChanged += new System.EventHandler(this.worker_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(743, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Поиск по описанию";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(747, 464);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(265, 28);
            this.description.TabIndex = 9;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Поиск по номеру";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(434, 464);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(255, 28);
            this.id.TabIndex = 7;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.Location = new System.Drawing.Point(1186, 411);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(139, 32);
            this.UpdateButton.TabIndex = 6;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(8, 6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(139, 32);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DeleteUserButton);
            this.tabPage2.Controls.Add(this.ChangeUserButton);
            this.tabPage2.Controls.Add(this.AddUserButton);
            this.tabPage2.Controls.Add(this.UserTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1347, 591);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Пользователи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteUserButton.Location = new System.Drawing.Point(446, 392);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(167, 45);
            this.DeleteUserButton.TabIndex = 6;
            this.DeleteUserButton.Text = "Удалить";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // ChangeUserButton
            // 
            this.ChangeUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeUserButton.Location = new System.Drawing.Point(273, 392);
            this.ChangeUserButton.Name = "ChangeUserButton";
            this.ChangeUserButton.Size = new System.Drawing.Size(167, 45);
            this.ChangeUserButton.TabIndex = 5;
            this.ChangeUserButton.Text = "Изменить";
            this.ChangeUserButton.UseVisualStyleBackColor = true;
            this.ChangeUserButton.Click += new System.EventHandler(this.ChangeUserButton_Click);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddUserButton.Location = new System.Drawing.Point(100, 392);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(167, 45);
            this.AddUserButton.TabIndex = 4;
            this.AddUserButton.Text = "Добавить";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // UserTable
            // 
            this.UserTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22});
            this.UserTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserTable.FullRowSelect = true;
            this.UserTable.GridLines = true;
            this.UserTable.HideSelection = false;
            this.UserTable.Location = new System.Drawing.Point(40, 36);
            this.UserTable.Name = "UserTable";
            this.UserTable.Size = new System.Drawing.Size(961, 318);
            this.UserTable.TabIndex = 1;
            this.UserTable.UseCompatibleStateImageBehavior = false;
            this.UserTable.View = System.Windows.Forms.View.Details;
            this.UserTable.SelectedIndexChanged += new System.EventHandler(this.UserTable_SelectedIndexChanged);
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Логин";
            this.columnHeader19.Width = 145;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Пароль";
            this.columnHeader20.Width = 115;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Полное имя";
            this.columnHeader21.Width = 177;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Статус";
            this.columnHeader22.Width = 129;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 626);
            this.Controls.Add(this.tabPage1);
            this.Name = "AdminForm";
            this.Text = "Форма администратора";
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.по.ResumeLayout(false);
            this.по.PerformLayout();
            this.tabPage2.ResumeLayout(false);
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
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button ChangeReuestButton;
        private System.Windows.Forms.TabControl tabPage1;
        private System.Windows.Forms.TabPage по;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView UserTable;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button ChangeUserButton;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem посчитатьСреднееВремяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаПоТипамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоВыполненыхЗаявокToolStripMenuItem;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox worker;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}