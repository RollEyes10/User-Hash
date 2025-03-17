using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UserHasUkol
{
    internal partial class PasswordForm : Form
    {
        private Admin currentAdmin; // Přihlášený administrátor

        internal PasswordForm(Admin admin)
        {
            InitializeComponent();
            currentAdmin = admin;

            // Událost pro dvojklik v ListBoxu
            listBoxUsers.DoubleClick += ListBoxUsers_DoubleClick;
        }

        // Načtení uživatelů při spuštění formuláře
        private void PasswordForm_Load(object sender, EventArgs e)
        {
            LoadUserList();
        }

        // Načte seznam uživatelů do ListBox
        private void LoadUserList()
        {
            List<Data> usersList = Data.LoadFromXML();
            listBoxUsers.Items.Clear();
            foreach (var user in usersList)
            {
                listBoxUsers.Items.Add(user.userName);
            }
        }

        // 📌 Dvojklik na uživatele v ListBoxu
        private void ListBoxUsers_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem == null) return;

            string selectedUserName = listBoxUsers.SelectedItem.ToString();
            List<Data> usersList = Data.LoadFromXML();
            var selectedUser = usersList.FirstOrDefault(u => u.userName == selectedUserName);

            if (selectedUser != null)
            {
                textBoxUserName.Text = selectedUser.userName;  // Vyplnění jména
                textBoxPassword.Text = selectedUser.password;  // Zobrazení hesla
                textBoxPassword.UseSystemPasswordChar = false; // Heslo bude viditelné

                // Automaticky nastavíme ComboBox podle role
                comboBoxRole.SelectedItem = selectedUser.role;
            }
        }

        // 📌 Přidání nového uživatele
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string newUserName = textBoxUserName.Text;
            string newPassword = textBoxPassword.Text;
            string selectedRole = comboBoxRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(newUserName) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Vyplňte všechny údaje.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Data> usersList = Data.LoadFromXML();

            // Ověříme, zda uživatel již existuje
            if (usersList.Any(u => u.userName == newUserName))
            {
                MessageBox.Show("Tento uživatel již existuje!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Přidání nového uživatele
            usersList.Add(new Data(newUserName, newPassword, selectedRole));
            Data.SaveToXML(usersList);

            MessageBox.Show("Uživatel byl úspěšně přidán!", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUserList();
        }

        // 📌 Uložení nového hesla
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string selectedUserName = listBoxUsers.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedUserName))
            {
                MessageBox.Show("Vyberte uživatele, jehož heslo chcete změnit.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newPassword = textBoxPassword.Text;
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Zadejte nové heslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Data> usersList = Data.LoadFromXML();
            var userToUpdate = usersList.FirstOrDefault(u => u.userName == selectedUserName);
            if (userToUpdate != null)
            {
                userToUpdate.password = newPassword;
                Data.SaveToXML(usersList); // Uložení změn

                MessageBox.Show("Heslo bylo úspěšně změněno!", "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserList();
            }
            else
            {
                MessageBox.Show("Uživatel nebyl nalezen.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
