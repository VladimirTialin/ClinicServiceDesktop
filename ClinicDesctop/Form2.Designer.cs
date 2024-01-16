
namespace ClinicDesctop
{
    partial class Form2
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
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SureName = new TextBox();
            FirstName = new TextBox();
            Document = new TextBox();
            Partonic = new TextBox();
            button_add = new Button();
            button_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 0;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(20, 53);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 1;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 85);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 2;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 117);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 3;
            label4.Text = "Документ";
            // 
            // SureName
            // 
            SureName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SureName.Location = new Point(120, 20);
            SureName.Name = "SureName";
            SureName.Size = new Size(170, 26);
            SureName.TabIndex = 4;
            // 
            // FirstName
            // 
            FirstName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FirstName.Location = new Point(120, 52);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(170, 26);
            FirstName.TabIndex = 5;
            // 
            // Document
            // 
            Document.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Document.Location = new Point(120, 116);
            Document.Name = "Document";
            Document.Size = new Size(170, 26);
            Document.TabIndex = 7;
            // 
            // Partonic
            // 
            Partonic.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Partonic.Location = new Point(120, 84);
            Partonic.Name = "Partonic";
            Partonic.Size = new Size(170, 26);
            Partonic.TabIndex = 6;
            // 
            // button_add
            // 
            button_add.Location = new Point(200, 160);
            button_add.Name = "button_add";
            button_add.Size = new Size(90, 32);
            button_add.TabIndex = 8;
            button_add.Text = "Сохранить";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(104, 160);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(90, 32);
            button_exit.TabIndex = 9;
            button_exit.Text = "Отменить";
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 204);
            Controls.Add(button_exit);
            Controls.Add(button_add);
            Controls.Add(Document);
            Controls.Add(Partonic);
            Controls.Add(FirstName);
            Controls.Add(SureName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox SureName;
        private TextBox FirstName;
        private TextBox Document;
        private TextBox Partonic;
        private Button button_add;
        private Button button_exit;
    }
}