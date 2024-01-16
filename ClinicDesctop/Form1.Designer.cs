namespace ClinicDesctop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewClients = new ListView();
            columnHeaderId = new ColumnHeader();
            columnHeaderSurName = new ColumnHeader();
            columnHeaderFirstName = new ColumnHeader();
            columnHeaderPatronymic = new ColumnHeader();
            columnHeaderDocument = new ColumnHeader();
            buttonLoadClients = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listViewClients
            // 
            listViewClients.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderSurName, columnHeaderFirstName, columnHeaderPatronymic, columnHeaderDocument });
            listViewClients.FullRowSelect = true;
            listViewClients.GridLines = true;
            listViewClients.Location = new Point(10, 9);
            listViewClients.Margin = new Padding(3, 2, 3, 2);
            listViewClients.MultiSelect = false;
            listViewClients.Name = "listViewClients";
            listViewClients.Size = new Size(680, 198);
            listViewClients.TabIndex = 0;
            listViewClients.UseCompatibleStateImageBehavior = false;
            listViewClients.View = View.Details;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "#";
            // 
            // columnHeaderSurName
            // 
            columnHeaderSurName.Text = "Фамилия";
            columnHeaderSurName.Width = 120;
            // 
            // columnHeaderFirstName
            // 
            columnHeaderFirstName.Text = "Имя";
            columnHeaderFirstName.Width = 200;
            // 
            // columnHeaderPatronymic
            // 
            columnHeaderPatronymic.Text = "Отчество";
            columnHeaderPatronymic.Width = 200;
            // 
            // columnHeaderDocument
            // 
            columnHeaderDocument.Text = "Документ";
            columnHeaderDocument.Width = 200;
            // 
            // buttonLoadClients
            // 
            buttonLoadClients.Location = new Point(10, 211);
            buttonLoadClients.Margin = new Padding(3, 2, 3, 2);
            buttonLoadClients.Name = "buttonLoadClients";
            buttonLoadClients.Size = new Size(94, 33);
            buttonLoadClients.TabIndex = 1;
            buttonLoadClients.Text = "Загрузить";
            buttonLoadClients.UseVisualStyleBackColor = true;
            buttonLoadClients.Click += buttonLoadClients_Click;
            // 
            // button1
            // 
            button1.Location = new Point(110, 211);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 2;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(210, 211);
            button2.Name = "button2";
            button2.Size = new Size(94, 33);
            button2.TabIndex = 3;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 269);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(buttonLoadClients);
            Controls.Add(listViewClients);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Моя клиника";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewClients;
        private Button buttonLoadClients;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderSurName;
        private ColumnHeader columnHeaderFirstName;
        private ColumnHeader columnHeaderPatronymic;
        private ColumnHeader columnHeaderDocument;
        private Button button1;
        private Button button2;
    }
}
