using System;
using System.Windows.Forms;

namespace UserHasUkol
{
    internal class Admin : User
    {
        public Admin(string userName, string password) : base(userName, password, "Admin")
        {
        }

        // Metoda pro správu uživatelů
        public void ManageUsers()
        {
            MessageBox.Show("Admin může spravovat uživatele.", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
