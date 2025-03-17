using System;
using System.Collections.Generic;
using System.Linq;
using UserHasUkol;

public class User
{
    public string name { get; set; }
    public string password { get; set; }
    public int id { get; set; }
    public string userRole { get; set; } // Role uživatele, může být Admin, Guest atd.

    // Konstruktor
    public User() { }

    public User(string name, string password, string role)
    {
        this.name = name;
        this.password = password;
        this.userRole = role;
    }

    // Metoda prohledávající seznam uživatelů podle uživatelského jména a hesla
    public static User SearchUser(string username, string password)
    {
        List<Data> usersList = Data.LoadFromXML(); // Načte seznam uživatelů
        var user = usersList.FirstOrDefault(u => u.userName == username && u.password == password);

        if (user != null)
        {
            // Vytvoříme správnou instanci podle role
            if (user.role == "Admin")
                return new Admin(user.userName, user.password);
            else if (user.role == "Guest")
                return new Guest(user.userName, user.password);
            else
                return new User(user.userName, user.password, user.role); // Pro případ dalších rolí
        }

        return null; // Uživatel nenalezen
    }
}
