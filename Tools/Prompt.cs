/*
 * PROMPT DIALOG
 * 
 * A user input dialog inspired by Javascript window.Prompt().
 * 
 *
 */

using System.Windows.Forms;

namespace MapleShark.Tools
{
    public static class window
    {
        /// <summary>
        /// Displays a prompt dialog and returns a value.
        /// </summary>
        /// <returns>Returns user input value. If user enters nothing empty string is returned.</returns>
        public static string prompt()
        {
            return prompt("Prompt", "Input value: ", "");
        }

        /// <summary>
        /// Displays a prompt dialog and returns a value.
        /// </summary>
        /// <param name="title">Text to be shown in the windowbar</param>
        /// <param name="message">Message to get user to input a value</param>
        /// <returns>Returns user input value. If user enters nothing empty string is returned.</returns>
        public static string prompt(string title, string message)
        {
            return prompt(title, message, "");
        }

        /// <summary>
        /// Displays a prompt dialog and returns a value.
        /// </summary>
        /// <param name="title">Text to be shown in the windowbar</param>
        /// <param name="message">Message to get user to input a value</param>
        /// <param name="defaultValue">The default value to assist user input</param>
        /// <returns>Returns user input value. If user enters nothing empty string is returned.</returns>
        public static string prompt(string title, string message, string defaultValue)
        {
            //Create controls and set default values
            Form dialog = new Form() { Width = 300, Height = 129, FormBorderStyle = FormBorderStyle.FixedDialog, Text = title, StartPosition = FormStartPosition.CenterScreen };
            Label label1 = new Label() { Left = 10, Top = 10 };
            TextBox textBox1 = new TextBox() { Left = 10, Top = 30, Width = 260, Height = 20 };
            Button button1 = new Button() { Text = "Ok", Left = 116, Top = 59, Width = 75, Height = 23 };
            Button button2 = new Button() { Text = "Cancel", Left = 197, Top = 59, Width = 75, Height = 23 };

            //Add all the creations to dialog
            dialog.Controls.Add(textBox1);
            dialog.Controls.Add(label1);
            dialog.Controls.Add(button1);
            dialog.Controls.Add(button2);

            //Set behaviours of new controls
            button1.Click += (sender, e) => { dialog.Close(); };
            button1.DialogResult = DialogResult.OK;
            button2.Click += (sender, e) => { dialog.Close(); };
            dialog.AcceptButton = button1; //press enter to accept
            label1.Text = message; //prompt the user to type something
            label1.AutoSize = true; //incase text is longer than label, text don't get chopped off
            textBox1.Text = defaultValue;

            //If ok is pressed, return the user input text, else return empty string
            return dialog.ShowDialog() == DialogResult.OK ? textBox1.Text : "";
        }
    }
}