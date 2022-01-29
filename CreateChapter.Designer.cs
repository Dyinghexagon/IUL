
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
            this.LabelNameProjects = new System.Windows.Forms.Label();
            this.ComboBoxNameProjects = new System.Windows.Forms.ComboBox();
            this.ButtonAddNewChapter = new System.Windows.Forms.Button();
            this.LabelIdProjectHint = new System.Windows.Forms.Label();
            this.ComboBoxChapters = new System.Windows.Forms.ComboBox();
            this.LabelNameChapters = new System.Windows.Forms.Label();
            this.LabelIdProject = new System.Windows.Forms.Label();
            this.LabelChapterHint = new System.Windows.Forms.Label();
            this.LabelIdSubChapter = new System.Windows.Forms.Label();
            this.ButtonSelecFileChapter = new System.Windows.Forms.Button();
            this.LabelNameSubChapter = new System.Windows.Forms.Label();
            this.TextBoxNameSubChapter = new System.Windows.Forms.TextBox();
            this.TextBoxIdChapter = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ButtonCrossCreatePerformer = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelNameProjects
            // 
            this.LabelNameProjects.AutoSize = true;
            this.LabelNameProjects.Location = new System.Drawing.Point(12, 8);
            this.LabelNameProjects.Name = "LabelNameProjects";
            this.LabelNameProjects.Size = new System.Drawing.Size(102, 15);
            this.LabelNameProjects.TabIndex = 1;
            this.LabelNameProjects.Text = "Выберите проект";
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
            this.ButtonAddNewChapter.Location = new System.Drawing.Point(15, 174);
            this.ButtonAddNewChapter.Name = "ButtonAddNewChapter";
            this.ButtonAddNewChapter.Size = new System.Drawing.Size(111, 50);
            this.ButtonAddNewChapter.TabIndex = 3;
            this.ButtonAddNewChapter.Text = "Добавить раздел к проекту";
            this.ButtonAddNewChapter.UseVisualStyleBackColor = true;
            this.ButtonAddNewChapter.Click += new System.EventHandler(this.ButtonAddNewChapter_Click);
            // 
            // LabelIdProjectHint
            // 
            this.LabelIdProjectHint.AutoSize = true;
            this.LabelIdProjectHint.Location = new System.Drawing.Point(717, 9);
            this.LabelIdProjectHint.Name = "LabelIdProjectHint";
            this.LabelIdProjectHint.Size = new System.Drawing.Size(159, 15);
            this.LabelIdProjectHint.TabIndex = 5;
            this.LabelIdProjectHint.Text = "Шифр выбранного проекта";
            // 
            // ComboBoxChapters
            // 
            this.ComboBoxChapters.FormattingEnabled = true;
            this.ComboBoxChapters.Location = new System.Drawing.Point(12, 72);
            this.ComboBoxChapters.Name = "ComboBoxChapters";
            this.ComboBoxChapters.Size = new System.Drawing.Size(699, 23);
            this.ComboBoxChapters.TabIndex = 7;
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
            // LabelIdProject
            // 
            this.LabelIdProject.AutoSize = true;
            this.LabelIdProject.Location = new System.Drawing.Point(717, 35);
            this.LabelIdProject.Name = "LabelIdProject";
            this.LabelIdProject.Size = new System.Drawing.Size(159, 15);
            this.LabelIdProject.TabIndex = 9;
            this.LabelIdProject.Text = "Шифр выбранного проекта";
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
            // LabelIdSubChapter
            // 
            this.LabelIdSubChapter.AutoSize = true;
            this.LabelIdSubChapter.Location = new System.Drawing.Point(15, 100);
            this.LabelIdSubChapter.Name = "LabelIdSubChapter";
            this.LabelIdSubChapter.Size = new System.Drawing.Size(111, 15);
            this.LabelIdSubChapter.TabIndex = 23;
            this.LabelIdSubChapter.Text = "Номер подраздела";
            // 
            // ButtonSelecFileChapter
            // 
            this.ButtonSelecFileChapter.Location = new System.Drawing.Point(15, 118);
            this.ButtonSelecFileChapter.Name = "ButtonSelecFileChapter";
            this.ButtonSelecFileChapter.Size = new System.Drawing.Size(111, 50);
            this.ButtonSelecFileChapter.TabIndex = 24;
            this.ButtonSelecFileChapter.Text = "Выбрать файл раздела";
            this.ButtonSelecFileChapter.UseVisualStyleBackColor = true;
            this.ButtonSelecFileChapter.Click += new System.EventHandler(this.ButtonSelecFileChapter_Click);
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
            this.TextBoxNameSubChapter.Size = new System.Drawing.Size(744, 199);
            this.TextBoxNameSubChapter.TabIndex = 26;
            // 
            // TextBoxIdChapter
            // 
            this.TextBoxIdChapter.Location = new System.Drawing.Point(717, 72);
            this.TextBoxIdChapter.Name = "TextBoxIdChapter";
            this.TextBoxIdChapter.Size = new System.Drawing.Size(159, 23);
            this.TextBoxIdChapter.TabIndex = 28;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ButtonCrossCreatePerformer
            // 
            this.ButtonCrossCreatePerformer.Location = new System.Drawing.Point(15, 230);
            this.ButtonCrossCreatePerformer.Name = "ButtonCrossCreatePerformer";
            this.ButtonCrossCreatePerformer.Size = new System.Drawing.Size(111, 54);
            this.ButtonCrossCreatePerformer.TabIndex = 29;
            this.ButtonCrossCreatePerformer.Text = "Перейти к добавлению исполнителей";
            this.ButtonCrossCreatePerformer.UseVisualStyleBackColor = true;
            this.ButtonCrossCreatePerformer.Click += new System.EventHandler(this.ButtonCrossCreatePerformer_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(15, 290);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(111, 27);
            this.ButtonBack.TabIndex = 30;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // CreateChapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 326);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonCrossCreatePerformer);
            this.Controls.Add(this.TextBoxIdChapter);
            this.Controls.Add(this.TextBoxNameSubChapter);
            this.Controls.Add(this.LabelNameSubChapter);
            this.Controls.Add(this.ButtonSelecFileChapter);
            this.Controls.Add(this.LabelIdSubChapter);
            this.Controls.Add(this.LabelIdProject);
            this.Controls.Add(this.LabelNameChapters);
            this.Controls.Add(this.ComboBoxChapters);
            this.Controls.Add(this.LabelChapterHint);
            this.Controls.Add(this.LabelIdProjectHint);
            this.Controls.Add(this.ButtonAddNewChapter);
            this.Controls.Add(this.ComboBoxNameProjects);
            this.Controls.Add(this.LabelNameProjects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateChapter";
            this.Text = "Добавление раздела";
            this.ResumeLayout(false);
            this.PerformLayout();

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
                "Подраздел 5.1 Система электроснабжения",
                "Подраздел 5.2 Система водоснабжения",
                "Подраздел 5.3 Система водоотведения",
                "Подраздел 5.4 Отопление, вентиляция и кондиционирование воздуха, тепловые сети",
                "Подраздел 5.5 Сети связи",
                "Подраздел 5.6 Система газоснабжения",
                "Подраздел 5.7 Технологические решения",
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

        private System.Windows.Forms.Label LabelNameProjects;
        private System.Windows.Forms.ComboBox ComboBoxNameProjects;
        private System.Windows.Forms.Button ButtonAddNewChapter;
        private System.Windows.Forms.Label LabelIdProjectHint;
        private System.Windows.Forms.ComboBox ComboBoxChapters;
        private System.Windows.Forms.Label LabelNameChapters;
        private System.Windows.Forms.Label LabelIdProject;
        private System.Windows.Forms.Label LabelChapterHint;
        private System.Windows.Forms.Label LabelIdSubChapter;
        private System.Windows.Forms.Button ButtonSelecFileChapter;
        private System.Windows.Forms.Label LabelNameSubChapter;
        private System.Windows.Forms.TextBox TextBoxNameSubChapter;
        private System.Windows.Forms.TextBox TextBoxIdChapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ButtonCrossCreatePerformer;
        private System.Windows.Forms.Button ButtonBack;
    }
}