
namespace IUL
{
    partial class CreateChapter
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
            this.LabelNameProject = new System.Windows.Forms.Label();
            this.ComboBoxNameProjects = new System.Windows.Forms.ComboBox();
            this.ButtonAddNewChapter = new System.Windows.Forms.Button();
            this.LabelCodeProjectHint = new System.Windows.Forms.Label();
            this.ComboBoxChapters = new System.Windows.Forms.ComboBox();
            this.LabelNameChapters = new System.Windows.Forms.Label();
            this.LabelCodeProject = new System.Windows.Forms.Label();
            this.LabelChapterHint = new System.Windows.Forms.Label();
            this.LabelNumberSubChapter = new System.Windows.Forms.Label();
            this.TextBoxSubChapter = new System.Windows.Forms.TextBox();
            this.ButtonSelecFileChapter = new System.Windows.Forms.Button();
            this.LabelChapter = new System.Windows.Forms.Label();
            this.LabelNameSubChapter = new System.Windows.Forms.Label();
            this.TextBoxNameSubChapter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelNameProject
            // 
            this.LabelNameProject.AutoSize = true;
            this.LabelNameProject.Location = new System.Drawing.Point(12, 8);
            this.LabelNameProject.Name = "LabelNameProject";
            this.LabelNameProject.Size = new System.Drawing.Size(102, 15);
            this.LabelNameProject.TabIndex = 1;
            this.LabelNameProject.Text = "Выберите проект";
            // 
            // ComboBoxNameProjects
            // 
            this.ComboBoxNameProjects.FormattingEnabled = true;
            this.ComboBoxNameProjects.Location = new System.Drawing.Point(12, 27);
            this.ComboBoxNameProjects.Name = "ComboBoxNameProjects";
            this.ComboBoxNameProjects.Size = new System.Drawing.Size(699, 23);
            this.ComboBoxNameProjects.TabIndex = 2;
            this.ComboBoxNameProjects.SelectedIndexChanged += new System.EventHandler(this.ComboBoxNameProjects_SelectedIndexChanged);
            // 
            // ButtonAddNewChapter
            // 
            this.ButtonAddNewChapter.Location = new System.Drawing.Point(15, 203);
            this.ButtonAddNewChapter.Name = "ButtonAddNewChapter";
            this.ButtonAddNewChapter.Size = new System.Drawing.Size(111, 50);
            this.ButtonAddNewChapter.TabIndex = 3;
            this.ButtonAddNewChapter.Text = "Добавить раздел к проекту";
            this.ButtonAddNewChapter.UseVisualStyleBackColor = true;
            // 
            // LabelCodeProjectHint
            // 
            this.LabelCodeProjectHint.AutoSize = true;
            this.LabelCodeProjectHint.Location = new System.Drawing.Point(717, 9);
            this.LabelCodeProjectHint.Name = "LabelCodeProjectHint";
            this.LabelCodeProjectHint.Size = new System.Drawing.Size(159, 15);
            this.LabelCodeProjectHint.TabIndex = 5;
            this.LabelCodeProjectHint.Text = "Шифр выбранного проекта";
            // 
            // ComboBoxChapters
            // 
            this.ComboBoxChapters.FormattingEnabled = true;
            this.ComboBoxChapters.Location = new System.Drawing.Point(12, 72);
            this.ComboBoxChapters.Name = "ComboBoxChapters";
            this.ComboBoxChapters.Size = new System.Drawing.Size(699, 23);
            this.ComboBoxChapters.TabIndex = 7;
            this.ComboBoxChapters.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChapters_SelectedIndexChanged);
            // 
            // LabelNameChapters
            // 
            this.LabelNameChapters.AutoSize = true;
            this.LabelNameChapters.Location = new System.Drawing.Point(12, 54);
            this.LabelNameChapters.Name = "LabelNameChapters";
            this.LabelNameChapters.Size = new System.Drawing.Size(114, 15);
            this.LabelNameChapters.TabIndex = 8;
            this.LabelNameChapters.Text = "Перечень разделов";
            // 
            // LabelCodeProject
            // 
            this.LabelCodeProject.AutoSize = true;
            this.LabelCodeProject.Location = new System.Drawing.Point(717, 35);
            this.LabelCodeProject.Name = "LabelCodeProject";
            this.LabelCodeProject.Size = new System.Drawing.Size(159, 15);
            this.LabelCodeProject.TabIndex = 9;
            this.LabelCodeProject.Text = "Шифр выбранного проекта";
            // 
            // LabelChapterHint
            // 
            this.LabelChapterHint.AutoSize = true;
            this.LabelChapterHint.Location = new System.Drawing.Point(717, 54);
            this.LabelChapterHint.Name = "LabelChapterHint";
            this.LabelChapterHint.Size = new System.Drawing.Size(158, 15);
            this.LabelChapterHint.TabIndex = 6;
            this.LabelChapterHint.Text = "Шифр выбранного раздела";
            // 
            // LabelNumberSubChapter
            // 
            this.LabelNumberSubChapter.AutoSize = true;
            this.LabelNumberSubChapter.Location = new System.Drawing.Point(15, 100);
            this.LabelNumberSubChapter.Name = "LabelNumberSubChapter";
            this.LabelNumberSubChapter.Size = new System.Drawing.Size(111, 15);
            this.LabelNumberSubChapter.TabIndex = 23;
            this.LabelNumberSubChapter.Text = "Номер подраздела";
            // 
            // TextBoxSubChapter
            // 
            this.TextBoxSubChapter.Location = new System.Drawing.Point(15, 118);
            this.TextBoxSubChapter.Name = "TextBoxSubChapter";
            this.TextBoxSubChapter.Size = new System.Drawing.Size(111, 23);
            this.TextBoxSubChapter.TabIndex = 22;
            // 
            // ButtonSelecFileChapter
            // 
            this.ButtonSelecFileChapter.Location = new System.Drawing.Point(15, 147);
            this.ButtonSelecFileChapter.Name = "ButtonSelecFileChapter";
            this.ButtonSelecFileChapter.Size = new System.Drawing.Size(111, 50);
            this.ButtonSelecFileChapter.TabIndex = 24;
            this.ButtonSelecFileChapter.Text = "Выбрать файл раздела";
            this.ButtonSelecFileChapter.UseVisualStyleBackColor = true;
            // 
            // LabelChapter
            // 
            this.LabelChapter.AutoSize = true;
            this.LabelChapter.Location = new System.Drawing.Point(717, 80);
            this.LabelChapter.Name = "LabelChapter";
            this.LabelChapter.Size = new System.Drawing.Size(158, 15);
            this.LabelChapter.TabIndex = 25;
            this.LabelChapter.Text = "Шифр выбранного раздела";
            // 
            // LabelNameSubChapter
            // 
            this.LabelNameSubChapter.AutoSize = true;
            this.LabelNameSubChapter.Location = new System.Drawing.Point(132, 99);
            this.LabelNameSubChapter.Name = "LabelNameSubChapter";
            this.LabelNameSubChapter.Size = new System.Drawing.Size(156, 15);
            this.LabelNameSubChapter.TabIndex = 27;
            this.LabelNameSubChapter.Text = "Наименование подраздела";
            // 
            // TextBoxNameSubChapter
            // 
            this.TextBoxNameSubChapter.Location = new System.Drawing.Point(132, 118);
            this.TextBoxNameSubChapter.Multiline = true;
            this.TextBoxNameSubChapter.Name = "TextBoxNameSubChapter";
            this.TextBoxNameSubChapter.Size = new System.Drawing.Size(744, 135);
            this.TextBoxNameSubChapter.TabIndex = 26;
            // 
            // CreateChapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 261);
            this.Controls.Add(this.TextBoxNameSubChapter);
            this.Controls.Add(this.LabelNameSubChapter);
            this.Controls.Add(this.LabelChapter);
            this.Controls.Add(this.ButtonSelecFileChapter);
            this.Controls.Add(this.LabelNumberSubChapter);
            this.Controls.Add(this.TextBoxSubChapter);
            this.Controls.Add(this.LabelCodeProject);
            this.Controls.Add(this.LabelNameChapters);
            this.Controls.Add(this.ComboBoxChapters);
            this.Controls.Add(this.LabelChapterHint);
            this.Controls.Add(this.LabelCodeProjectHint);
            this.Controls.Add(this.ButtonAddNewChapter);
            this.Controls.Add(this.ComboBoxNameProjects);
            this.Controls.Add(this.LabelNameProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateChapter";
            this.Text = "Добавление раздела";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void InitializeProjects() 
        {
            this.ComboBoxNameProjects.Items.AddRange(Project.GetProjectsArray());
        }
        private void FilingComboBoxCapitalChapter()
        {
            this.ComboBoxChapters.Items.Clear();
            this.ComboBoxChapters.Items.AddRange(new object[]
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
        }

        private void FilingComboBoxLinearChapter()
        {
            this.ComboBoxChapters.Items.Clear();
            this.ComboBoxChapters.Items.AddRange(new object[]
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
        }
        #endregion

        private System.Windows.Forms.Label LabelNameProject;
        private System.Windows.Forms.ComboBox ComboBoxNameProjects;
        private System.Windows.Forms.Button ButtonAddNewChapter;
        private System.Windows.Forms.Label LabelCodeProjectHint;
        private System.Windows.Forms.ComboBox ComboBoxChapters;
        private System.Windows.Forms.Label LabelNameChapters;
        private System.Windows.Forms.Label LabelCodeProject;
        private System.Windows.Forms.Label LabelChapterHint;
        private System.Windows.Forms.Label LabelNumberSubChapter;
        private System.Windows.Forms.TextBox TextBoxSubChapter;
        private System.Windows.Forms.Button ButtonSelecFileChapter;
        private System.Windows.Forms.Label LabelChapter;
        private System.Windows.Forms.Label LabelNameSubChapter;
        private System.Windows.Forms.TextBox TextBoxNameSubChapter;
    }
}