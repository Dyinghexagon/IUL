
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
            this.LabelResearchsHint = new System.Windows.Forms.Label();
            this.CheckedListBoxResearchs = new System.Windows.Forms.CheckedListBox();
            this.LabelChapters = new System.Windows.Forms.Label();
            this.CheckedListBoxChapters = new System.Windows.Forms.CheckedListBox();
            this.GroupBoxChoosTypeProject = new System.Windows.Forms.GroupBox();
            this.RadioButtonCapital = new System.Windows.Forms.RadioButton();
            this.RadioButtonLinear = new System.Windows.Forms.RadioButton();
            this.LabelNameMianFolder = new System.Windows.Forms.Label();
            this.TextBoxNameMainFolder = new System.Windows.Forms.TextBox();
            this.ButtonCreateFolder = new System.Windows.Forms.Button();
            this.ButtonSelectAllReseach = new System.Windows.Forms.Button();
            this.ButtonSelectAllChapters = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ButtonCrossCreateProject = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.GroupBoxChoosTypeProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelResearchsHint
            // 
            this.LabelResearchsHint.AutoSize = true;
            this.LabelResearchsHint.Location = new System.Drawing.Point(12, 4);
            this.LabelResearchsHint.Name = "LabelResearchsHint";
            this.LabelResearchsHint.Size = new System.Drawing.Size(68, 15);
            this.LabelResearchsHint.TabIndex = 5;
            this.LabelResearchsHint.Text = "Изыскания";
            // 
            // CheckedListBoxResearchs
            // 
            this.CheckedListBoxResearchs.FormattingEnabled = true;
            this.CheckedListBoxResearchs.Items.AddRange(new object[] {
            "Инженерно-геодезические изыскания",
            "Инженерно-геологические изыскания",
            "Инженерно-экологические изыскания",
            "Инженерно-гидрометеорологические изыскания",
            "Инженерно-геотехнические изыскания",
            "Техническое обсследование здания"});
            this.CheckedListBoxResearchs.Location = new System.Drawing.Point(12, 22);
            this.CheckedListBoxResearchs.Name = "CheckedListBoxResearchs";
            this.CheckedListBoxResearchs.Size = new System.Drawing.Size(302, 112);
            this.CheckedListBoxResearchs.TabIndex = 6;
            // 
            // LabelChapters
            // 
            this.LabelChapters.AutoSize = true;
            this.LabelChapters.Location = new System.Drawing.Point(12, 135);
            this.LabelChapters.Name = "LabelChapters";
            this.LabelChapters.Size = new System.Drawing.Size(197, 15);
            this.LabelChapters.TabIndex = 15;
            this.LabelChapters.Text = "Разделы проектной документации";
            // 
            // CheckedListBoxChapters
            // 
            this.CheckedListBoxChapters.FormattingEnabled = true;
            this.CheckedListBoxChapters.Location = new System.Drawing.Point(12, 153);
            this.CheckedListBoxChapters.Name = "CheckedListBoxChapters";
            this.CheckedListBoxChapters.Size = new System.Drawing.Size(640, 22);
            this.CheckedListBoxChapters.TabIndex = 16;
            // 
            // GroupBoxChoosTypeProject
            // 
            this.GroupBoxChoosTypeProject.Controls.Add(this.RadioButtonCapital);
            this.GroupBoxChoosTypeProject.Controls.Add(this.RadioButtonLinear);
            this.GroupBoxChoosTypeProject.Location = new System.Drawing.Point(320, 12);
            this.GroupBoxChoosTypeProject.Name = "GroupBoxChoosTypeProject";
            this.GroupBoxChoosTypeProject.Size = new System.Drawing.Size(233, 76);
            this.GroupBoxChoosTypeProject.TabIndex = 17;
            this.GroupBoxChoosTypeProject.TabStop = false;
            this.GroupBoxChoosTypeProject.Text = "Проектная документация";
            // 
            // RadioButtonCapital
            // 
            this.RadioButtonCapital.AutoSize = true;
            this.RadioButtonCapital.Location = new System.Drawing.Point(6, 47);
            this.RadioButtonCapital.Name = "RadioButtonCapital";
            this.RadioButtonCapital.Size = new System.Drawing.Size(226, 19);
            this.RadioButtonCapital.TabIndex = 11;
            this.RadioButtonCapital.Text = "Объект капитального строительства";
            this.RadioButtonCapital.UseVisualStyleBackColor = true;
            this.RadioButtonCapital.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // RadioButtonLinear
            // 
            this.RadioButtonLinear.AutoSize = true;
            this.RadioButtonLinear.Location = new System.Drawing.Point(6, 22);
            this.RadioButtonLinear.Name = "RadioButtonLinear";
            this.RadioButtonLinear.Size = new System.Drawing.Size(210, 19);
            this.RadioButtonLinear.TabIndex = 10;
            this.RadioButtonLinear.Text = "Объект линейного строительства";
            this.RadioButtonLinear.UseVisualStyleBackColor = true;
            this.RadioButtonLinear.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // LabelNameMianFolder
            // 
            this.LabelNameMianFolder.AutoSize = true;
            this.LabelNameMianFolder.Location = new System.Drawing.Point(320, 91);
            this.LabelNameMianFolder.Name = "LabelNameMianFolder";
            this.LabelNameMianFolder.Size = new System.Drawing.Size(126, 15);
            this.LabelNameMianFolder.TabIndex = 17;
            this.LabelNameMianFolder.Text = "Наименование папки";
            // 
            // TextBoxNameMainFolder
            // 
            this.TextBoxNameMainFolder.Location = new System.Drawing.Point(320, 112);
            this.TextBoxNameMainFolder.Multiline = true;
            this.TextBoxNameMainFolder.Name = "TextBoxNameMainFolder";
            this.TextBoxNameMainFolder.Size = new System.Drawing.Size(232, 22);
            this.TextBoxNameMainFolder.TabIndex = 16;
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
            // ButtonCrossCreateProject
            // 
            this.ButtonCrossCreateProject.Location = new System.Drawing.Point(558, 181);
            this.ButtonCrossCreateProject.Name = "ButtonCrossCreateProject";
            this.ButtonCrossCreateProject.Size = new System.Drawing.Size(94, 62);
            this.ButtonCrossCreateProject.TabIndex = 21;
            this.ButtonCrossCreateProject.Text = "Перейти к добавлению проекта";
            this.ButtonCrossCreateProject.UseVisualStyleBackColor = true;
            this.ButtonCrossCreateProject.Click += new System.EventHandler(this.ButtonCrossCreateProject_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(558, 245);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(94, 41);
            this.ButtonBack.TabIndex = 22;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // CreateFolderProject
            // 
            this.MaximizeBox = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonCrossCreateProject);
            this.Controls.Add(this.ButtonSelectAllReseach);
            this.Controls.Add(this.ButtonSelectAllChapters);
            this.Controls.Add(this.ButtonCreateFolder);
            this.Controls.Add(this.LabelNameMianFolder);
            this.Controls.Add(this.TextBoxNameMainFolder);
            this.Controls.Add(this.GroupBoxChoosTypeProject);
            this.Controls.Add(this.CheckedListBoxChapters);
            this.Controls.Add(this.LabelChapters);
            this.Controls.Add(this.CheckedListBoxResearchs);
            this.Controls.Add(this.LabelResearchsHint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateFolderProject";
            this.Text = "Создание папки проекта";
            this.GroupBoxChoosTypeProject.ResumeLayout(false);
            this.GroupBoxChoosTypeProject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FilingComboBoxCapitalChapter()
        {
            this.CheckedListBoxChapters.Items.Clear();
            this.CheckedListBoxChapters.Items.AddRange(new object[]
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
            this.CheckedListBoxChapters.Size = new System.Drawing.Size(this.CheckedListBoxChapters.Size.Width, 350);
        }

        private void FilingComboBoxLinearChapter()
        {
            this.CheckedListBoxChapters.Items.Clear();
            this.CheckedListBoxChapters.Items.AddRange(new object[]
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
            this.CheckedListBoxChapters.Size = new System.Drawing.Size(this.CheckedListBoxChapters.Size.Width, 166);

        }

        #endregion

        private System.Windows.Forms.Label LabelResearchsHint;
        private System.Windows.Forms.CheckedListBox CheckedListBoxResearchs;
        private System.Windows.Forms.Label LabelChapters;
        private System.Windows.Forms.CheckedListBox CheckedListBoxChapters;
        private System.Windows.Forms.GroupBox GroupBoxChoosTypeProject;
        private System.Windows.Forms.RadioButton RadioButtonCapital;
        private System.Windows.Forms.RadioButton RadioButtonLinear;
        private System.Windows.Forms.Label LabelNameMianFolder;
        private System.Windows.Forms.TextBox TextBoxNameMainFolder;
        private System.Windows.Forms.Button ButtonCreateFolder;
        private System.Windows.Forms.Button ButtonSelectAllReseach;
        private System.Windows.Forms.Button ButtonSelectAllChapters;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button ButtonCrossCreateProject;
        private System.Windows.Forms.Button ButtonBack;
    }

}