using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace UserHasUkol
{
    public class Data
    {
        public static string filePath = "users.xml";
        public string userName { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public Data() { }

        public Data(string userName, string password, string role)
        {
            this.userName = userName;
            this.password = password;
            this.role = role;
        }

        // Uložení dat do souboru XML a zašifrování (Base64)
        public static void SaveToXML(List<Data> dataList)
        {
            try
            {
                MessageBox.Show("Ukládám data do souboru...", "Ukládání", MessageBoxButtons.OK, MessageBoxIcon.Information);

                XmlSerializer serializer = new XmlSerializer(typeof(List<Data>));
                using (StringWriter stringWriter = new StringWriter())
                {
                    serializer.Serialize(stringWriter, dataList);
                    string xmlString = stringWriter.ToString();

                    // Zakódování do Base64
                    string base64Encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(xmlString));

                    // Uložení do souboru
                    File.WriteAllText(filePath, base64Encoded);

                    MessageBox.Show("Data byla úspěšně uložena do:\n" + Path.GetFullPath(filePath), "Úspěch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chyba při ukládání do souboru:\n" + ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Načtení dat ze souboru (Base64 dekódování)
        public static List<Data> LoadFromXML()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string base64String = File.ReadAllText(filePath);
                    byte[] xmlBytes = Convert.FromBase64String(base64String);
                    string xmlString = Encoding.UTF8.GetString(xmlBytes);

                    XmlSerializer serializer = new XmlSerializer(typeof(List<Data>));
                    using (StringReader stringReader = new StringReader(xmlString))
                    {
                        return (List<Data>)serializer.Deserialize(stringReader);
                    }
                }
                else
                {
                    Console.WriteLine("Soubor neexistuje.");
                    return new List<Data>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Chyba při načítání ze souboru: {ex.Message}");
                return new List<Data>();
            }
        }
    }
}
