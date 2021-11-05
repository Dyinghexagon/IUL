
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LabelNameChapters = new System.Windows.Forms.Label();
            this.LabelCodeProject = new System.Windows.Forms.Label();
            this.GroupBoxChoosingTyoeProject = new System.Windows.Forms.GroupBox();
            this.RadioButtonCapital = new System.Windows.Forms.RadioButton();
            this.RadioButtonLinear = new System.Windows.Forms.RadioButton();
            this.TextBoxCodeChapter = new System.Windows.Forms.TextBox();
            this.LabelChapter = new System.Windows.Forms.Label();
            this.LabelNameSubChapter = new System.Windows.Forms.Label();
            this.TextBoxSubChapter = new System.Windows.Forms.TextBox();
            this.ButtonSelecFileChapter = new System.Windows.Forms.Button();
            this.GroupBoxChoosingTyoeProject.SuspendLayout();
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
            this.ComboBoxNameProjects.Size = new System.Drawing.Size(598, 23);
            this.ComboBoxNameProjects.TabIndex = 2;
            // 
            // ButtonAddNewChapter
            // 
            this.ButtonAddNewChapter.Location = new System.Drawing.Point(855, 12);
            this.ButtonAddNewChapter.Name = "ButtonAddNewChapter";
            this.ButtonAddNewChapter.Size = new System.Drawing.Size(81, 53);
            this.ButtonAddNewChapter.TabIndex = 3;
            this.ButtonAddNewChapter.Text = "Добавить раздел к проекту";
            this.ButtonAddNewChapter.UseVisualStyleBackColor = true;
            // 
            // LabelCodeProjectHint
            // 
            this.LabelCodeProjectHint.AutoSize = true;
            this.LabelCodeProjectHint.Location = new System.Drawing.Point(616, 9);
            this.LabelCodeProjectHint.Name = "LabelCodeProjectHint";
            this.LabelCodeProjectHint.Size = new System.Drawing.Size(159, 15);
            this.LabelCodeProjectHint.TabIndex = 5;
            this.LabelCodeProjectHint.Text = "Шифр выбранного проекта";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(598, 23);
            this.comboBox1.TabIndex = 7;
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
            this.LabelCodeProject.Location = new System.Drawing.Point(616, 35);
            this.LabelCodeProject.Name = "LabelCodeProject";
            this.LabelCodeProject.Size = new System.Drawing.Size(159, 15);
            this.LabelCodeProject.TabIndex = 9;
            this.LabelCodeProject.Text = "Шифр выбранного проекта";
            // 
            // GroupBoxChoosingTyoeProject
            // 
            this.GroupBoxChoosingTyoeProject.Controls.Add(this.RadioButtonCapital);
            this.GroupBoxChoosingTyoeProject.Controls.Add(this.RadioButtonLinear);
            this.GroupBoxChoosingTyoeProject.Location = new System.Drawing.Point(616, 117);
            this.GroupBoxChoosingTyoeProject.Name = "GroupBoxChoosingTyoeProject";
            this.GroupBoxChoosingTyoeProject.Size = new System.Drawing.Size(233, 76);
            this.GroupBoxChoosingTyoeProject.TabIndex = 21;
            this.GroupBoxChoosingTyoeProject.TabStop = false;
            this.GroupBoxChoosingTyoeProject.Text = "Проектная документация";
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
            // 
            // TextBoxCodeChapter
            // 
            this.TextBoxCodeChapter.Location = new System.Drawing.Point(616, 72);
            this.TextBoxCodeChapter.Name = "TextBoxCodeChapter";
            this.TextBoxCodeChapter.Size = new System.Drawing.Size(233, 23);
            this.TextBoxCodeChapter.TabIndex = 4;
            // 
            // LabelChapter
            // 
            this.LabelChapter.AutoSize = true;
            this.LabelChapter.Location = new System.Drawing.Point(616, 54);
            this.LabelChapter.Name = "LabelChapter";
            this.LabelChapter.Size = new System.Drawing.Size(87, 15);
            this.LabelChapter.TabIndex = 6;
            this.LabelChapter.Text = "Шифр раздела";
            // 
            // LabelNameSubChapter
            // 
            this.LabelNameSubChapter.AutoSize = true;
            this.LabelNameSubChapter.Location = new System.Drawing.Point(12, 99);
            this.LabelNameSubChapter.Name = "LabelNameSubChapter";
            this.LabelNameSubChapter.Size = new System.Drawing.Size(87, 15);
            this.LabelNameSubChapter.TabIndex = 23;
            this.LabelNameSubChapter.Text = "Шифр раздела";
            // 
            // TextBoxSubChapter
            // 
            this.TextBoxSubChapter.Location = new System.Drawing.Point(12, 117);
            this.TextBoxSubChapter.Multiline = true;
            this.TextBoxSubChapter.Name = "TextBoxSubChapter";
            this.TextBoxSubChapter.Size = new System.Drawing.Size(598, 91);
            this.TextBoxSubChapter.TabIndex = 22;
            // 
            // ButtonSelecFileChapter
            // 
            this.ButtonSelecFileChapter.Location = new System.Drawing.Point(855, 72);
            this.ButtonSelecFileChapter.Name = "ButtonSelecFileChapter";
            this.ButtonSelecFileChapter.Size = new System.Drawing.Size(81, 53);
            this.ButtonSelecFileChapter.TabIndex = 24;
            this.ButtonSelecFileChapter.Text = "Выбрать файл раздела";
            this.ButtonSelecFileChapter.UseVisualStyleBackColor = true;
            // 
            // CreateChapter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 218);
            this.Controls.Add(this.ButtonSelecFileChapter);
            this.Controls.Add(this.LabelNameSubChapter);
            this.Controls.Add(this.TextBoxSubChapter);
            this.Controls.Add(this.GroupBoxChoosingTyoeProject);
            this.Controls.Add(this.LabelCodeProject);
            this.Controls.Add(this.LabelNameChapters);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LabelChapter);
            this.Controls.Add(this.LabelCodeProjectHint);
            this.Controls.Add(this.TextBoxCodeChapter);
            this.Controls.Add(this.ButtonAddNewChapter);
            this.Controls.Add(this.ComboBoxNameProjects);
            this.Controls.Add(this.LabelNameProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateChapter";
            this.Text = "Добавление раздела";
            this.Load += new System.EventHandler(this.CreateChapter_Load);
            this.GroupBoxChoosingTyoeProject.ResumeLayout(false);
            this.GroupBoxChoosingTyoeProject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNameProject;
        private System.Windows.Forms.ComboBox ComboBoxNameProjects;
        private System.Windows.Forms.Button ButtonAddNewChapter;
        private System.Windows.Forms.Label LabelCodeProjectHint;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LabelNameChapters;
        private System.Windows.Forms.Label LabelCodeProject;
        private System.Windows.Forms.GroupBox GroupBoxChoosingTyoeProject;
        private System.Windows.Forms.RadioButton RadioButtonCapital;
        private System.Windows.Forms.RadioButton RadioButtonLinear;
        private System.Windows.Forms.TextBox TextBoxCodeChapter;
        private System.Windows.Forms.Label LabelChapter;
        private System.Windows.Forms.Label LabelNameSubChapter;
        private System.Windows.Forms.TextBox TextBoxSubChapter;
        private System.Windows.Forms.Button ButtonSelecFileChapter;
    }
}