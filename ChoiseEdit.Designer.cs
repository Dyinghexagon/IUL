namespace IUL
{
    partial class ChoiseEdit
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
            this.ButtonEditProject = new System.Windows.Forms.Button();
            this.GroupBoxChoiseEdit = new System.Windows.Forms.GroupBox();
            this.ButtonEditChapter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.GroupBoxChoiseEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonEditProject
            // 
            this.ButtonEditProject.Location = new System.Drawing.Point(6, 22);
            this.ButtonEditProject.Name = "ButtonEditProject";
            this.ButtonEditProject.Size = new System.Drawing.Size(123, 38);
            this.ButtonEditProject.TabIndex = 0;
            this.ButtonEditProject.Text = "Изменить данные о проекте";
            this.ButtonEditProject.UseVisualStyleBackColor = true;
            this.ButtonEditProject.Click += new System.EventHandler(this.ButtonEditProject_Click);
            // 
            // GroupBoxChoiseEdit
            // 
            this.GroupBoxChoiseEdit.Controls.Add(this.button1);
            this.GroupBoxChoiseEdit.Controls.Add(this.ButtonEditChapter);
            this.GroupBoxChoiseEdit.Controls.Add(this.ButtonEditProject);
            this.GroupBoxChoiseEdit.Location = new System.Drawing.Point(21, 12);
            this.GroupBoxChoiseEdit.Name = "GroupBoxChoiseEdit";
            this.GroupBoxChoiseEdit.Size = new System.Drawing.Size(397, 72);
            this.GroupBoxChoiseEdit.TabIndex = 1;
            this.GroupBoxChoiseEdit.TabStop = false;
            this.GroupBoxChoiseEdit.Text = "Выбрать изменяемый объект";
            // 
            // ButtonEditChapter
            // 
            this.ButtonEditChapter.Location = new System.Drawing.Point(135, 22);
            this.ButtonEditChapter.Name = "ButtonEditChapter";
            this.ButtonEditChapter.Size = new System.Drawing.Size(123, 38);
            this.ButtonEditChapter.TabIndex = 1;
            this.ButtonEditChapter.Text = "Изменить данные о разделе";
            this.ButtonEditChapter.UseVisualStyleBackColor = true;
            this.ButtonEditChapter.Click += new System.EventHandler(this.ButtonEditChapter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Изменить данные о сотрудниках";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Location = new System.Drawing.Point(27, 90);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(75, 23);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ChoiseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 126);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.GroupBoxChoiseEdit);
            this.Name = "ChoiseEdit";
            this.Text = "ChoiseEdit";
            this.GroupBoxChoiseEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonEditProject;
        private System.Windows.Forms.GroupBox GroupBoxChoiseEdit;
        private System.Windows.Forms.Button ButtonEditChapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonBack;
    }
}