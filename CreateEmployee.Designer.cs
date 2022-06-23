namespace IUL
{
    partial class CreateEmployee
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
            this.LabelSurname = new System.Windows.Forms.Label();
            this.TextBoxSurname = new System.Windows.Forms.TextBox();
            this.ButtonSign = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxPathomic = new System.Windows.Forms.TextBox();
            this.LabelPathomic = new System.Windows.Forms.Label();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // LabelSurname
            // 
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.Location = new System.Drawing.Point(7, 26);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(58, 15);
            this.LabelSurname.TabIndex = 0;
            this.LabelSurname.Text = "Фамилия";
            // 
            // TextBoxSurname
            // 
            this.TextBoxSurname.Location = new System.Drawing.Point(7, 44);
            this.TextBoxSurname.Name = "TextBoxSurname";
            this.TextBoxSurname.Size = new System.Drawing.Size(300, 23);
            this.TextBoxSurname.TabIndex = 1;
            // 
            // ButtonSign
            // 
            this.ButtonSign.Location = new System.Drawing.Point(121, 159);
            this.ButtonSign.Name = "ButtonSign";
            this.ButtonSign.Size = new System.Drawing.Size(81, 41);
            this.ButtonSign.TabIndex = 2;
            this.ButtonSign.Text = "Выбрать подпись";
            this.ButtonSign.UseVisualStyleBackColor = true;
            this.ButtonSign.Click += new System.EventHandler(this.ButtonSign_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(7, 86);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(300, 23);
            this.TextBoxName.TabIndex = 4;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(7, 68);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(31, 15);
            this.LabelName.TabIndex = 3;
            this.LabelName.Text = "Имя";
            // 
            // TextBoxPathomic
            // 
            this.TextBoxPathomic.Location = new System.Drawing.Point(7, 130);
            this.TextBoxPathomic.Name = "TextBoxPathomic";
            this.TextBoxPathomic.Size = new System.Drawing.Size(300, 23);
            this.TextBoxPathomic.TabIndex = 6;
            // 
            // LabelPathomic
            // 
            this.LabelPathomic.AutoSize = true;
            this.LabelPathomic.Location = new System.Drawing.Point(7, 112);
            this.LabelPathomic.Name = "LabelPathomic";
            this.LabelPathomic.Size = new System.Drawing.Size(58, 15);
            this.LabelPathomic.TabIndex = 5;
            this.LabelPathomic.Text = "Отчество";
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(226, 159);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(81, 41);
            this.ButtonCreate.TabIndex = 7;
            this.ButtonCreate.Text = "Добавить сотрудника";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(7, 159);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(81, 41);
            this.ButtonBack.TabIndex = 8;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MenuStrip
            // 
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(319, 24);
            this.MenuStrip.TabIndex = 33;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // CreateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 204);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.TextBoxPathomic);
            this.Controls.Add(this.LabelPathomic);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.ButtonSign);
            this.Controls.Add(this.TextBoxSurname);
            this.Controls.Add(this.LabelSurname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateEmployee";
            this.Text = "Добавить сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSurname;
        private System.Windows.Forms.TextBox TextBoxSurname;
        private System.Windows.Forms.Button ButtonSign;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBoxPathomic;
        private System.Windows.Forms.Label LabelPathomic;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip MenuStrip;
    }
}