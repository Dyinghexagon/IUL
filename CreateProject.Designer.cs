
namespace IUL
{
    partial class CreateProject
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
            this.GroupBoxChoosingTyoeProject = new System.Windows.Forms.GroupBox();
            this.RadioButtonCapital = new System.Windows.Forms.RadioButton();
            this.RadioButtonLinear = new System.Windows.Forms.RadioButton();
            this.CheckedListBoxResearchs = new System.Windows.Forms.CheckedListBox();
            this.LabelResearch = new System.Windows.Forms.Label();
            this.ComboBoxChoosingGIP = new System.Windows.Forms.ComboBox();
            this.LabelGIP = new System.Windows.Forms.Label();
            this.LabelNkontr = new System.Windows.Forms.Label();
            this.ComboBoxChoosingNkontr = new System.Windows.Forms.ComboBox();
            this.TextBoxProjectId = new System.Windows.Forms.TextBox();
            this.LabelProjectId = new System.Windows.Forms.Label();
            this.LabelProjectName = new System.Windows.Forms.Label();
            this.TextBoxProjectName = new System.Windows.Forms.TextBox();
            this.LabelNameCustomer = new System.Windows.Forms.Label();
            this.TextBoxNameCustomer = new System.Windows.Forms.TextBox();
            this.ButtonChoosingMainFolder = new System.Windows.Forms.Button();
            this.ButtonAddProject = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ButtonCrossCreateNewChapter = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.GroupBoxChoosingTyoeProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxChoosingTyoeProject
            // 
            this.GroupBoxChoosingTyoeProject.Controls.Add(this.RadioButtonCapital);
            this.GroupBoxChoosingTyoeProject.Controls.Add(this.RadioButtonLinear);
            this.GroupBoxChoosingTyoeProject.Location = new System.Drawing.Point(318, 38);
            this.GroupBoxChoosingTyoeProject.Name = "GroupBoxChoosingTyoeProject";
            this.GroupBoxChoosingTyoeProject.Size = new System.Drawing.Size(233, 76);
            this.GroupBoxChoosingTyoeProject.TabIndex = 20;
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
            this.RadioButtonCapital.CheckedChanged += new System.EventHandler(this.RadioButtonCapital_CheckedChanged);
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
            this.RadioButtonLinear.CheckedChanged += new System.EventHandler(this.RadioButtonLinear_CheckedChanged);
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
            "Археологические изыскания",
            "Техническое обсследование здания"});
            this.CheckedListBoxResearchs.Location = new System.Drawing.Point(10, 47);
            this.CheckedListBoxResearchs.Name = "CheckedListBoxResearchs";
            this.CheckedListBoxResearchs.Size = new System.Drawing.Size(302, 130);
            this.CheckedListBoxResearchs.TabIndex = 19;
            // 
            // LabelResearch
            // 
            this.LabelResearch.AutoSize = true;
            this.LabelResearch.Location = new System.Drawing.Point(10, 30);
            this.LabelResearch.Name = "LabelResearch";
            this.LabelResearch.Size = new System.Drawing.Size(68, 15);
            this.LabelResearch.TabIndex = 18;
            this.LabelResearch.Text = "Изыскания";
            // 
            // ComboBoxChoosingGIP
            // 
            this.ComboBoxChoosingGIP.FormattingEnabled = true;
            this.ComboBoxChoosingGIP.Location = new System.Drawing.Point(556, 47);
            this.ComboBoxChoosingGIP.Name = "ComboBoxChoosingGIP";
            this.ComboBoxChoosingGIP.Size = new System.Drawing.Size(176, 23);
            this.ComboBoxChoosingGIP.TabIndex = 21;
            this.ComboBoxChoosingGIP.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChoosingGIP_SelectedIndexChanged);
            // 
            // LabelGIP
            // 
            this.LabelGIP.AutoSize = true;
            this.LabelGIP.Location = new System.Drawing.Point(556, 29);
            this.LabelGIP.Name = "LabelGIP";
            this.LabelGIP.Size = new System.Drawing.Size(31, 15);
            this.LabelGIP.TabIndex = 22;
            this.LabelGIP.Text = "ГИП";
            // 
            // LabelNkontr
            // 
            this.LabelNkontr.AutoSize = true;
            this.LabelNkontr.Location = new System.Drawing.Point(556, 73);
            this.LabelNkontr.Name = "LabelNkontr";
            this.LabelNkontr.Size = new System.Drawing.Size(57, 15);
            this.LabelNkontr.TabIndex = 24;
            this.LabelNkontr.Text = "Н. контр.";
            // 
            // ComboBoxChoosingNkontr
            // 
            this.ComboBoxChoosingNkontr.FormattingEnabled = true;
            this.ComboBoxChoosingNkontr.Location = new System.Drawing.Point(556, 91);
            this.ComboBoxChoosingNkontr.Name = "ComboBoxChoosingNkontr";
            this.ComboBoxChoosingNkontr.Size = new System.Drawing.Size(176, 23);
            this.ComboBoxChoosingNkontr.TabIndex = 23;
            this.ComboBoxChoosingNkontr.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChoosingNkontr_SelectedIndexChanged);
            // 
            // TextBoxProjectId
            // 
            this.TextBoxProjectId.Location = new System.Drawing.Point(316, 154);
            this.TextBoxProjectId.Name = "TextBoxProjectId";
            this.TextBoxProjectId.Size = new System.Drawing.Size(416, 23);
            this.TextBoxProjectId.TabIndex = 25;
            // 
            // LabelProjectId
            // 
            this.LabelProjectId.AutoSize = true;
            this.LabelProjectId.Location = new System.Drawing.Point(316, 136);
            this.LabelProjectId.Name = "LabelProjectId";
            this.LabelProjectId.Size = new System.Drawing.Size(88, 15);
            this.LabelProjectId.TabIndex = 26;
            this.LabelProjectId.Text = "Шифр проекта";
            // 
            // LabelProjectName
            // 
            this.LabelProjectName.AutoSize = true;
            this.LabelProjectName.Location = new System.Drawing.Point(8, 181);
            this.LabelProjectName.Name = "LabelProjectName";
            this.LabelProjectName.Size = new System.Drawing.Size(137, 15);
            this.LabelProjectName.TabIndex = 28;
            this.LabelProjectName.Text = "Наименование проекта";
            // 
            // TextBoxProjectName
            // 
            this.TextBoxProjectName.Location = new System.Drawing.Point(10, 199);
            this.TextBoxProjectName.Multiline = true;
            this.TextBoxProjectName.Name = "TextBoxProjectName";
            this.TextBoxProjectName.Size = new System.Drawing.Size(722, 90);
            this.TextBoxProjectName.TabIndex = 27;
            // 
            // LabelNameCustomer
            // 
            this.LabelNameCustomer.AutoSize = true;
            this.LabelNameCustomer.Location = new System.Drawing.Point(8, 292);
            this.LabelNameCustomer.Name = "LabelNameCustomer";
            this.LabelNameCustomer.Size = new System.Drawing.Size(147, 15);
            this.LabelNameCustomer.TabIndex = 30;
            this.LabelNameCustomer.Text = "Наименование заказчика";
            // 
            // TextBoxNameCustomer
            // 
            this.TextBoxNameCustomer.Location = new System.Drawing.Point(10, 310);
            this.TextBoxNameCustomer.Multiline = true;
            this.TextBoxNameCustomer.Name = "TextBoxNameCustomer";
            this.TextBoxNameCustomer.Size = new System.Drawing.Size(722, 90);
            this.TextBoxNameCustomer.TabIndex = 29;
            // 
            // ButtonChoosingMainFolder
            // 
            this.ButtonChoosingMainFolder.Location = new System.Drawing.Point(528, 406);
            this.ButtonChoosingMainFolder.Name = "ButtonChoosingMainFolder";
            this.ButtonChoosingMainFolder.Size = new System.Drawing.Size(99, 58);
            this.ButtonChoosingMainFolder.TabIndex = 31;
            this.ButtonChoosingMainFolder.Text = "Выбрать папку проекта";
            this.ButtonChoosingMainFolder.UseVisualStyleBackColor = true;
            this.ButtonChoosingMainFolder.Click += new System.EventHandler(this.ButtonChoosingMainFolder_Click);
            // 
            // ButtonAddProject
            // 
            this.ButtonAddProject.Location = new System.Drawing.Point(633, 406);
            this.ButtonAddProject.Name = "ButtonAddProject";
            this.ButtonAddProject.Size = new System.Drawing.Size(99, 58);
            this.ButtonAddProject.TabIndex = 32;
            this.ButtonAddProject.Text = "Добавить новый проект";
            this.ButtonAddProject.UseVisualStyleBackColor = true;
            this.ButtonAddProject.Click += new System.EventHandler(this.ButtonAddProject_Click);
            // 
            // ButtonCrossCreateNewChapter
            // 
            this.ButtonCrossCreateNewChapter.Location = new System.Drawing.Point(423, 406);
            this.ButtonCrossCreateNewChapter.Name = "ButtonCrossCreateNewChapter";
            this.ButtonCrossCreateNewChapter.Size = new System.Drawing.Size(99, 58);
            this.ButtonCrossCreateNewChapter.TabIndex = 33;
            this.ButtonCrossCreateNewChapter.Text = "Перейти к добавлению разделов";
            this.ButtonCrossCreateNewChapter.UseVisualStyleBackColor = true;
            this.ButtonCrossCreateNewChapter.Click += new System.EventHandler(this.ButtonCreateNewChapter_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(318, 406);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(99, 58);
            this.ButtonBack.TabIndex = 34;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(744, 24);
            this.MenuStrip.TabIndex = 35;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 473);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonCrossCreateNewChapter);
            this.Controls.Add(this.ButtonAddProject);
            this.Controls.Add(this.ButtonChoosingMainFolder);
            this.Controls.Add(this.LabelNameCustomer);
            this.Controls.Add(this.TextBoxNameCustomer);
            this.Controls.Add(this.LabelProjectName);
            this.Controls.Add(this.TextBoxProjectName);
            this.Controls.Add(this.LabelProjectId);
            this.Controls.Add(this.TextBoxProjectId);
            this.Controls.Add(this.LabelNkontr);
            this.Controls.Add(this.ComboBoxChoosingNkontr);
            this.Controls.Add(this.LabelGIP);
            this.Controls.Add(this.ComboBoxChoosingGIP);
            this.Controls.Add(this.GroupBoxChoosingTyoeProject);
            this.Controls.Add(this.CheckedListBoxResearchs);
            this.Controls.Add(this.LabelResearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CreateProject";
            this.Text = "Создать новый проект";
            this.GroupBoxChoosingTyoeProject.ResumeLayout(false);
            this.GroupBoxChoosingTyoeProject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.GroupBox GroupBoxChoosingTyoeProject;
        private System.Windows.Forms.RadioButton RadioButtonCapital;
        private System.Windows.Forms.RadioButton RadioButtonLinear;
        private System.Windows.Forms.CheckedListBox CheckedListBoxResearchs;
        private System.Windows.Forms.Label LabelResearch;
        private System.Windows.Forms.ComboBox ComboBoxChoosingGIP;
        private System.Windows.Forms.Label LabelGIP;
        private System.Windows.Forms.Label LabelNkontr;
        private System.Windows.Forms.ComboBox ComboBoxChoosingNkontr;
        private System.Windows.Forms.TextBox TextBoxProjectId;
        private System.Windows.Forms.Label LabelProjectId;
        private System.Windows.Forms.Label LabelProjectName;
        private System.Windows.Forms.TextBox TextBoxProjectName;
        private System.Windows.Forms.Label LabelNameCustomer;
        private System.Windows.Forms.TextBox TextBoxNameCustomer;
        private System.Windows.Forms.Button ButtonChoosingMainFolder;
        private System.Windows.Forms.Button ButtonAddProject;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button ButtonCrossCreateNewChapter;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.MenuStrip MenuStrip;
    }
}