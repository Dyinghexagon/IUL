
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
            this.CheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.LabelResearch = new System.Windows.Forms.Label();
            this.ComboBoxChoosingGIP = new System.Windows.Forms.ComboBox();
            this.LabelGIP = new System.Windows.Forms.Label();
            this.LabelNkontr = new System.Windows.Forms.Label();
            this.ComboBoxChoosingNkontr = new System.Windows.Forms.ComboBox();
            this.TextBoxCodeProject = new System.Windows.Forms.TextBox();
            this.LabelCodeProject = new System.Windows.Forms.Label();
            this.LabelNameProject = new System.Windows.Forms.Label();
            this.TextBoxNameProject = new System.Windows.Forms.TextBox();
            this.LabelNameCustomer = new System.Windows.Forms.Label();
            this.TextBoxNameCustomer = new System.Windows.Forms.TextBox();
            this.ButtonChoosingMainFolder = new System.Windows.Forms.Button();
            this.ButtonAddProject = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.GroupBoxChoosingTyoeProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxChoosingTyoeProject
            // 
            this.GroupBoxChoosingTyoeProject.Controls.Add(this.RadioButtonCapital);
            this.GroupBoxChoosingTyoeProject.Controls.Add(this.RadioButtonLinear);
            this.GroupBoxChoosingTyoeProject.Location = new System.Drawing.Point(320, 17);
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
            // CheckedListBox1
            // 
            this.CheckedListBox1.FormattingEnabled = true;
            this.CheckedListBox1.Items.AddRange(new object[] {
            "Инженерно-геодезические изыскания",
            "Инженерно-геологические изыскания",
            "Инженерно-экологические изыскания",
            "Инженерно-гидрометеорологические изыскания",
            "Инженерно-геотехнические изыскания",
            "Археологические изыскания",
            "Техническое обсследование здания"});
            this.CheckedListBox1.Location = new System.Drawing.Point(12, 27);
            this.CheckedListBox1.Name = "CheckedListBox1";
            this.CheckedListBox1.Size = new System.Drawing.Size(302, 130);
            this.CheckedListBox1.TabIndex = 19;
            // 
            // LabelResearch
            // 
            this.LabelResearch.AutoSize = true;
            this.LabelResearch.Location = new System.Drawing.Point(12, 9);
            this.LabelResearch.Name = "LabelResearch";
            this.LabelResearch.Size = new System.Drawing.Size(68, 15);
            this.LabelResearch.TabIndex = 18;
            this.LabelResearch.Text = "Изыскания";
            // 
            // ComboBoxChoosingGIP
            // 
            this.ComboBoxChoosingGIP.FormattingEnabled = true;
            this.ComboBoxChoosingGIP.Location = new System.Drawing.Point(558, 26);
            this.ComboBoxChoosingGIP.Name = "ComboBoxChoosingGIP";
            this.ComboBoxChoosingGIP.Size = new System.Drawing.Size(121, 23);
            this.ComboBoxChoosingGIP.TabIndex = 21;
            this.ComboBoxChoosingGIP.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChoosingGIP_SelectedIndexChanged);
            // 
            // LabelGIP
            // 
            this.LabelGIP.AutoSize = true;
            this.LabelGIP.Location = new System.Drawing.Point(558, 8);
            this.LabelGIP.Name = "LabelGIP";
            this.LabelGIP.Size = new System.Drawing.Size(31, 15);
            this.LabelGIP.TabIndex = 22;
            this.LabelGIP.Text = "ГИП";
            // 
            // LabelNkontr
            // 
            this.LabelNkontr.AutoSize = true;
            this.LabelNkontr.Location = new System.Drawing.Point(558, 52);
            this.LabelNkontr.Name = "LabelNkontr";
            this.LabelNkontr.Size = new System.Drawing.Size(57, 15);
            this.LabelNkontr.TabIndex = 24;
            this.LabelNkontr.Text = "Н. контр.";
            // 
            // ComboBoxChoosingNkontr
            // 
            this.ComboBoxChoosingNkontr.FormattingEnabled = true;
            this.ComboBoxChoosingNkontr.Location = new System.Drawing.Point(558, 70);
            this.ComboBoxChoosingNkontr.Name = "ComboBoxChoosingNkontr";
            this.ComboBoxChoosingNkontr.Size = new System.Drawing.Size(121, 23);
            this.ComboBoxChoosingNkontr.TabIndex = 23;
            this.ComboBoxChoosingNkontr.SelectedIndexChanged += new System.EventHandler(this.ComboBoxChoosingNkontr_SelectedIndexChanged);
            // 
            // TextBoxCodeProject
            // 
            this.TextBoxCodeProject.Location = new System.Drawing.Point(320, 134);
            this.TextBoxCodeProject.Name = "TextBoxCodeProject";
            this.TextBoxCodeProject.Size = new System.Drawing.Size(465, 23);
            this.TextBoxCodeProject.TabIndex = 25;
            // 
            // LabelCodeProject
            // 
            this.LabelCodeProject.AutoSize = true;
            this.LabelCodeProject.Location = new System.Drawing.Point(320, 116);
            this.LabelCodeProject.Name = "LabelCodeProject";
            this.LabelCodeProject.Size = new System.Drawing.Size(88, 15);
            this.LabelCodeProject.TabIndex = 26;
            this.LabelCodeProject.Text = "Шифр проекта";
            // 
            // LabelNameProject
            // 
            this.LabelNameProject.AutoSize = true;
            this.LabelNameProject.Location = new System.Drawing.Point(12, 164);
            this.LabelNameProject.Name = "LabelNameProject";
            this.LabelNameProject.Size = new System.Drawing.Size(137, 15);
            this.LabelNameProject.TabIndex = 28;
            this.LabelNameProject.Text = "Наименование проекта";
            // 
            // TextBoxNameProject
            // 
            this.TextBoxNameProject.Location = new System.Drawing.Point(12, 182);
            this.TextBoxNameProject.Multiline = true;
            this.TextBoxNameProject.Name = "TextBoxNameProject";
            this.TextBoxNameProject.Size = new System.Drawing.Size(773, 90);
            this.TextBoxNameProject.TabIndex = 27;
            // 
            // LabelNameCustomer
            // 
            this.LabelNameCustomer.AutoSize = true;
            this.LabelNameCustomer.Location = new System.Drawing.Point(12, 278);
            this.LabelNameCustomer.Name = "LabelNameCustomer";
            this.LabelNameCustomer.Size = new System.Drawing.Size(147, 15);
            this.LabelNameCustomer.TabIndex = 30;
            this.LabelNameCustomer.Text = "Наименование заказчика";
            // 
            // TextBoxNameCustomer
            // 
            this.TextBoxNameCustomer.Location = new System.Drawing.Point(12, 296);
            this.TextBoxNameCustomer.Multiline = true;
            this.TextBoxNameCustomer.Name = "TextBoxNameCustomer";
            this.TextBoxNameCustomer.Size = new System.Drawing.Size(773, 90);
            this.TextBoxNameCustomer.TabIndex = 29;
            // 
            // ButtonChoosingMainFolder
            // 
            this.ButtonChoosingMainFolder.Location = new System.Drawing.Point(686, 70);
            this.ButtonChoosingMainFolder.Name = "ButtonChoosingMainFolder";
            this.ButtonChoosingMainFolder.Size = new System.Drawing.Size(99, 47);
            this.ButtonChoosingMainFolder.TabIndex = 31;
            this.ButtonChoosingMainFolder.Text = "Выбрать папку проекта";
            this.ButtonChoosingMainFolder.UseVisualStyleBackColor = true;
            this.ButtonChoosingMainFolder.Click += new System.EventHandler(this.ButtonChoosingMainFolder_Click);
            // 
            // ButtonAddProject
            // 
            this.ButtonAddProject.Location = new System.Drawing.Point(686, 17);
            this.ButtonAddProject.Name = "ButtonAddProject";
            this.ButtonAddProject.Size = new System.Drawing.Size(99, 47);
            this.ButtonAddProject.TabIndex = 32;
            this.ButtonAddProject.Text = "Добавить новый проект";
            this.ButtonAddProject.UseVisualStyleBackColor = true;
            this.ButtonAddProject.Click += new System.EventHandler(this.ButtonAddProject_Click);
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 397);
            this.Controls.Add(this.ButtonAddProject);
            this.Controls.Add(this.ButtonChoosingMainFolder);
            this.Controls.Add(this.LabelNameCustomer);
            this.Controls.Add(this.TextBoxNameCustomer);
            this.Controls.Add(this.LabelNameProject);
            this.Controls.Add(this.TextBoxNameProject);
            this.Controls.Add(this.LabelCodeProject);
            this.Controls.Add(this.TextBoxCodeProject);
            this.Controls.Add(this.LabelNkontr);
            this.Controls.Add(this.ComboBoxChoosingNkontr);
            this.Controls.Add(this.LabelGIP);
            this.Controls.Add(this.ComboBoxChoosingGIP);
            this.Controls.Add(this.GroupBoxChoosingTyoeProject);
            this.Controls.Add(this.CheckedListBox1);
            this.Controls.Add(this.LabelResearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateProject";
            this.Text = "Создать новый проект";
            this.GroupBoxChoosingTyoeProject.ResumeLayout(false);
            this.GroupBoxChoosingTyoeProject.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FillingComboBoxGIP()
        {
            this.ComboBoxChoosingGIP.Items.AddRange(Employee.GetSurnameEmployees());
        }

        private void FillingComboBoxNkontr()
        {
            this.ComboBoxChoosingNkontr.Items.AddRange(Employee.GetSurnameEmployees());
        }
        #endregion

        private System.Windows.Forms.GroupBox GroupBoxChoosingTyoeProject;
        private System.Windows.Forms.RadioButton RadioButtonCapital;
        private System.Windows.Forms.RadioButton RadioButtonLinear;
        private System.Windows.Forms.CheckedListBox CheckedListBox1;
        private System.Windows.Forms.Label LabelResearch;
        private System.Windows.Forms.ComboBox ComboBoxChoosingGIP;
        private System.Windows.Forms.Label LabelGIP;
        private System.Windows.Forms.Label LabelNkontr;
        private System.Windows.Forms.ComboBox ComboBoxChoosingNkontr;
        private System.Windows.Forms.TextBox TextBoxCodeProject;
        private System.Windows.Forms.Label LabelCodeProject;
        private System.Windows.Forms.Label LabelNameProject;
        private System.Windows.Forms.TextBox TextBoxNameProject;
        private System.Windows.Forms.Label LabelNameCustomer;
        private System.Windows.Forms.TextBox TextBoxNameCustomer;
        private System.Windows.Forms.Button ButtonChoosingMainFolder;
        private System.Windows.Forms.Button ButtonAddProject;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}