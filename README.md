# User Management Application (C# WinForms)

Tento projekt je jednoduchá desktopová aplikace v **C# WinForms**, která umožňuje správu uživatelských účtů s využitím:

- **Serializace do XML** (uživatelé a jejich hesla jsou ukládána v souboru `users.xml`)  
- **Dědičnosti** (Admin a Guest dědí od základní třídy User)  
- **Hashování hesel** (hesla nejsou ukládána v čitelné podobě)  
- **Více formulářů** (hlavní přihlášení, správa uživatelů, změna hesla)  

---

## ✨ Funkcionality

- **Přihlášení uživatele**  
  - Aplikace kontroluje jméno a heslo proti datům uloženým v XML.  
  - Defaultní účty po prvním spuštění:  
    - `Admin / heslo` (má práva spravovat uživatele)  
    - `Guest / heslo` (běžný uživatel)  

- **Změna hesla (Guest)**  
  - Po přihlášení se zobrazí možnost změny hesla.  
  - Nové heslo se uloží do XML.  

- **Správa uživatelů (Admin)**  
  - Admin má přístup k samostatnému formuláři.  
  - Může zobrazit seznam všech uživatelů.  
  - Může vybranému uživateli nastavit nové heslo.  

---

## 🛠️ Použité technologie
- **C# .NET (Windows Forms)**  
- **XML serializace**  
- **Hashing (pro bezpečné ukládání hesel)**  
- **OOP principy (dědičnost, zapouzdření, polymorfismus)**  

---

## 🚀 Spuštění projektu
1. Naklonuj repozitář:
   ```bash
   git clone https://github.com/uzivatel/repozitar.git
