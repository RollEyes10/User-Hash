# 🧑‍💻 User Management App (C# WinForms)

Tento projekt je desktopová aplikace v **C# Windows Forms**, která ukazuje práci s:
- **OOP (dědičnost)** – uživatelé dědí od společné třídy `User` (Admin, Guest)  
- **XML serializací** – uživatelé a jejich hesla se ukládají do `users.xml`  
- **Zabezpečením hesel** – hesla jsou uložená zakódovaná (Base64)  
- **Více formuláři** – formulář pro přihlášení a samostatný formulář pro administrátora  

---

## ✨ Funkcionality

- **Přihlášení uživatele**
  - Ověření podle jména a hesla.
  - Defaultně existují účty:  
    - `Admin / heslo`  
    - `Guest / heslo`

- **Guest (běžný uživatel)**
  - Po přihlášení může měnit své heslo.  

- **Admin**
  - Po přihlášení se otevře speciální formulář (`PasswordForm`).
  - Vidí seznam uživatelů.
  - Může:
    - vybranému uživateli přenastavit heslo,  
    - přidat nového uživatele (jméno, heslo, role).  

- **Soubor s uživateli (`users.xml`)**
  - Vytvoří se automaticky při prvním spuštění.
  - Je uložený ve formátu Base64 (hesla nejsou čitelná přímo v souboru).

---

## 🛠️ Použité technologie
- **C# .NET (Windows Forms)**  
- **XML serializace**  
- **Base64 encoding**  
- **OOP principy (dědičnost, polymorfismus, zapouzdření)**  

---

## 🚀 Spuštění
1. Naklonuj repozitář:
   ```bash
   git clone https://github.com/uzivatel/repozitar.git
