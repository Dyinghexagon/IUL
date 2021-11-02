using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace IUL
{
    class CreateForm
    {
        private static int _heightForm = 15;
        private static int _widthComboBox = 180;
        public static int WidthComboBox 
        {
            get { return _widthComboBox; }
        }
        public static int HeightForm
        {
            get { return _heightForm; }
        }
        public static Label CreateLabel(string name, Point location, string text)
        {
            Label label = new Label();
            label.Size = new Size(text.Length * 10, _heightForm);
            label.Name = name;
            label.Location = location;
            label.Text = text;
            return label;
        }
        public static Button CreateButton(string name, Point location, string text)
        {
            Button button = new Button();
            button.Name = name;
            button.Location = location;
            button.Text = text;
            return button;
        }
        public static ComboBox CreateComboBox(string name, Point location, object[] arr)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Size = new Size(_widthComboBox, _heightForm);
            comboBox.Name = name;
            comboBox.Location = location;
            comboBox.Items.AddRange(arr);
            return comboBox;
        }
        public static CheckBox CreateCheckBox(string name, Point location, string text) 
        {
            CheckBox checkBox = new CheckBox();
            checkBox.Name = name;
            checkBox.Text = text;
            checkBox.AutoSize = true;
            checkBox.Location = location;
            return checkBox;
        }
        public static TextBox CreateTextBox(string name, Point location, Size size)
        {
            TextBox textBox = new TextBox();
            textBox.Name = name;
            textBox.Location = location;
            textBox.Size = size;
            return textBox;
        }
    }
}
