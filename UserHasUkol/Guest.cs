using System;
using System.Windows.Forms;

namespace UserHasUkol
{
    internal class Guest : User
    {
        // Konstruktor pro inicializaci Guest uživatele
        public Guest(string userName, string password) : base(userName, password, "Guest")
        {
            // Volání základního konstruktora třídy User s role "Guest"
        }

        // Specifická metoda pro hosta - změna hesla
        public void ChangePassword(string newPassword)
        {
            MessageBox.Show($"Heslo bylo úspěšně změněno na: {newPassword}", "Změna hesla", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.password = newPassword; // Uložení nového hesla
        }

    }
}
