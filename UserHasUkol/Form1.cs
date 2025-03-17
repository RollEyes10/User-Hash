using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace UserHasUkol
{
    public partial class Form1 : Form
    {
        private User currentUser; // Uchovává aktuálně přihlášeného uživatele ahoj

        public Form1()
        {
            InitializeComponent();
            buttonSave.Enabled = false; // Tlačítko pro změnu hesla bude zpočátku neaktivní
            buttonSave.Visible = false; // Skryjeme tlačítko pro změnu hesla

            if (!File.Exists(Data.filePath))
            {
                MessageBox.Show("Soubor neexistuje, vytvářím nový...", "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);

                List<Data> defaultUsers = new List<Data>
                {
                    new Data("Admin", "heslo", "Admin"),
                    new Data("Guest", "heslo", "Guest")
                };

                Data.SaveToXML(defaultUsers);

                MessageBox.Show("Soubor byl úspěšně vytvořen na cestě:\n" + Path.GetFullPath(Data.filePath), "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Soubor již existuje:\n" + Path.GetFullPath(Data.filePath), "Informace", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username = textBoxUserName.Text;
            string password = textBoxPassword.Text;

            User user = User.SearchUser(username, password);

            if (user == null)
            {
                MessageBox.Show("Chyba přihlášení. Zkuste to znovu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentUser = user;

            if (user is Guest)
            {
                MessageBox.Show("Přihlášení jako Guest úspěšné!", "Přihlášení", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonSave.Enabled = true;
                buttonSave.Visible = true; // Zobrazí tlačítko pro změnu hesla
            }
            else if (user is Admin)
            {
                MessageBox.Show("Přihlášení jako Admin úspěšné!", "Přihlášení", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonSave.Visible = false; // Admin nemůže měnit heslo tady

                // Otevření okna pro administrátora
                PasswordForm passwordForm = new PasswordForm((Admin)user);
                passwordForm.ShowDialog();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Zkontrolujte, že uživatel je přihlášený a je to Guest
            if (currentUser is Guest guest)
            {
                string newPassword = textBoxPassword.Text;
                if (string.IsNullOrEmpty(newPassword))
                {
                    MessageBox.Show("Heslo nemůže být prázdné!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                guest.ChangePassword(newPassword); // Změní heslo pro hosta

                // Aktualizace v souboru
                List<Data> usersList = Data.LoadFromXML();
                var userToUpdate = usersList.FirstOrDefault(u => u.userName == guest.name);
                if (userToUpdate != null)
                {
                    userToUpdate.password = newPassword;
                    Data.SaveToXML(usersList);
                    MessageBox.Show("Heslo bylo úspěšně změněno!", "Změna hesla", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void checkBoxVision_CheckedChanged(object sender, EventArgs e)
        {
            // Přepínání viditelnosti hesla
            textBoxPassword.UseSystemPasswordChar = !checkBoxVision.Checked;
        }
    }
}
