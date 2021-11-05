
namespace IUL
{
    partial class CreateFolderProject
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
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButtonCreateFolder = new System.Windows.Forms.Button();
            this.ButtonSelectAllReseach = new System.Windows.Forms.Button();
            this.ButtonSelectAllChapters = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Изыскания";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Инженерно-геодезические изыскания",
            "Инженерно-геологические изыскания",
            "Инженерно-экологические изыскания",
            "Инженерно-гидрометеорологические изыскания",
            "Инженерно-геотехнические изыскания",
            "Техническое обсследование здания"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 22);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(302, 112);
            this.checkedListBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Разделы проектной документации";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(12, 153);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(640, 22);
            this.checkedListBox2.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButton2);
            this.groupBox1.Controls.Add(this.RadioButton1);
            this.groupBox1.Location = new System.Drawing.Point(320, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 76);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Проектная документация";
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(6, 47);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(226, 19);
            this.RadioButton2.TabIndex = 11;
            this.RadioButton2.Text = "Объект капитального строительства";
            this.RadioButton2.UseVisualStyleBackColor = true;
            this.RadioButton2.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Location = new System.Drawing.Point(6, 22);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(210, 19);
            this.RadioButton1.TabIndex = 10;
            this.RadioButton1.Text = "Объект линейного строительства";
            this.RadioButton1.UseVisualStyleBackColor = true;
            this.RadioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Наименование папки";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(320, 112);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 22);
            this.textBox1.TabIndex = 16;
            // 
            // ButtonCreateFolder
            // 
            this.ButtonCreateFolder.Location = new System.Drawing.Point(559, 12);
            this.ButtonCreateFolder.Name = "ButtonCreateFolder";
            this.ButtonCreateFolder.Size = new System.Drawing.Size(94, 41);
            this.ButtonCreateFolder.TabIndex = 18;
            this.ButtonCreateFolder.Text = "Создать папку проекта";
            this.ButtonCreateFolder.UseVisualStyleBackColor = true;
            this.ButtonCreateFolder.Click += new System.EventHandler(this.ButtonCreateFolder_Click);
            // 
            // ButtonSelectAllReseach
            // 
            this.ButtonSelectAllReseach.Location = new System.Drawing.Point(558, 106);
            this.ButtonSelectAllReseach.Name = "ButtonSelectAllReseach";
            this.ButtonSelectAllReseach.Size = new System.Drawing.Size(94, 41);
            this.ButtonSelectAllReseach.TabIndex = 20;
            this.ButtonSelectAllReseach.Text = "Выбрать все изыскания";
            this.ButtonSelectAllReseach.UseVisualStyleBackColor = true;
            this.ButtonSelectAllReseach.Click += new System.EventHandler(this.ButtonSelectAllReseach_Click);
            // 
            // ButtonSelectAllChapters
            // 
            this.ButtonSelectAllChapters.Location = new System.Drawing.Point(558, 59);
            this.ButtonSelectAllChapters.Name = "ButtonSelectAllChapters";
            this.ButtonSelectAllChapters.Size = new System.Drawing.Size(94, 41);
            this.ButtonSelectAllChapters.TabIndex = 19;
            this.ButtonSelectAllChapters.Text = "Выбрать все разделы";
            this.ButtonSelectAllChapters.UseVisualStyleBackColor = true;
            this.ButtonSelectAllChapters.Click += new System.EventHandler(this.ButtonSelectAllChapters_Click);
            // 
            // CreateFolderProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.ButtonSelectAllReseach);
            this.Controls.Add(this.ButtonSelectAllChapters);
            this.Controls.Add(this.ButtonCreateFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateFolderProject";
            this.Text = "Создание папки проекта";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FilingComboBoxCapitalChapter()
        {
            this.checkedListBox2.Items.Clear();
            this.checkedListBox2.Items.AddRange(new object[]
            {
                "Раздел 1. Пояснительная записка",
                "Раздел 2. Схема планировочной организации земельного участка",
                "Раздел 3. Архитектурные решения",
                "Раздел 4. Конструктивные и объемно-планировочные решения",
                "Раздел 5. Подраздел 5.1 Система электроснабжения",
                "Раздел 5. Подраздел 5.2 Система водоснабжения",
                "Раздел 5. Подраздел 5.3 Система водоотведения",
                "Раздел 5. Подраздел 5.4 Отопление, вентиляция и кондиционирование воздуха, тепловые сети",
                "Раздел 5. Подраздел 5.5 Сети связи",
                "Раздел 5. Подраздел 5.6 Система газоснабжения",
                "Раздел 5. Подраздел 5.7 Технологические решения",
                "Раздел 6. Проект организации строительства",
                "Раздел 7. Проект организации работ по сносу или демонтажу объектов капитального строительства",
                "Раздел 8. Перечень мероприятий по охране окружающей среды",
                "Раздел 9. Мероприятия по обеспечению пожарной безопасности",
                "Раздел 10. Мероприятия по обеспечению доступа инвалидов",
                "Раздел 10_1. Мероприятия по обеспечению соблюдения требований энергетической эффективности",
                "Раздел 11. Смета на строительство объектов капитального строительства",
                "Раздел 12. Иная документация в случаях, предусмотренных федеральными законами"
            });
            this.checkedListBox2.Size = new System.Drawing.Size(605, 350);
            this.ClientSize = new System.Drawing.Size(checkedListBox2.Size.Width + 55,
                                                    checkedListBox2.Size.Height + 170);
        }

        private void FilingComboBoxLinearChapter()
        {
            this.checkedListBox2.Items.Clear();
            this.checkedListBox2.Items.AddRange(new object[]
            {
                "Раздел 1. Пояснительная записка",
                "Раздел 2. Проект полосы отвода",
                "Раздел 3. Технологические и конструктивные решения линейного объекта. Искусственные сооружения",
                "Раздел 4. Здания, строения и сооружения, входящие в инфраструктуру линейного объекта",
                "Раздел 5. Проект организации строительства",
                "Раздел 6. Проект организации работ по сносу (демонтажу) линейного объекта",
                "Раздел 7. Мероприятия по охране окружающей среды",
                "Раздел 8. Мероприятия по обеспечению пожарной безопасности",
                "Раздел 9. Смета на строительство"
            });
            this.checkedListBox2.Size = new System.Drawing.Size(605, 166);
            this.ClientSize = new System.Drawing.Size(checkedListBox2.Size.Width + 55,
                checkedListBox2.Size.Height + 170);
        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButton2;
        private System.Windows.Forms.RadioButton RadioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ButtonCreateFolder;
        private System.Windows.Forms.Button ButtonSelectAllReseach;
        private System.Windows.Forms.Button ButtonSelectAllChapters;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }

}