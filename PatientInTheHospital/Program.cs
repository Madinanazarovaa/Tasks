using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInTheHospital
{
    internal class Patient_Form
    {
        public List<string> gender = new List<string>() { "мужской", "женский", "мужской", "мужской", "мужской" };
        public List<int> age = new List<int>() {35, 55, 38, 115, 11};
        public List<string> name = new List<string>() {"Римус Люпин", "Минерва Макгонагалл", "Северус Снегг", 
                                                    "Альбус Дамблдор", "Гарри Поттер" };
        public List<string> address = new List<string>() {"Хогвартс", "Хогвартс", "Хогвартс", "Хогвартс", 
                                                        "Чулан под лестницей, ул.Тисовая, 4, графство Суррей" };
    }
    internal class Program
    {
        static void PrintForm()
        {
            Patient_Form form = new Patient_Form();
            for (int i = 0; i < form.age.Count; i++)
            {
                Console.WriteLine($"Пол: {form.gender[i]}");
                Console.WriteLine($"Возраст: {form.age[i]}");
                Console.WriteLine($"Имя: {form.name[i]}");
                Console.WriteLine($"Адрес: {form.address[i]}");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            PrintForm();
        }
    }
}
