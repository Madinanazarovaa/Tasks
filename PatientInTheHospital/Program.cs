using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInTheHospital
{
    class Form
    {
        public List <string> gender;
        public List<int> age;
        public List<string> name;
        public List<string> address;
    }
    internal class Program
    {
        static Form Patients()
        {
            Form form = new Form();
            form.gender = new List<string>() {"мужской", "женский"};
            form.age = new List<int>() {35, 55, 38, 115, 11, 71 };
            form.name = new List<string>() {"Римус Люпин", "Минерва Макгонагалл", "Северус Снегг", 
                                            "Альбус Дамблдор", "Гарри Поттер"};
            form.address = new List<string>() {"Школа Чародейства и волшебства Хогвартс", 
                                            "Чулан под лестницей, ул.Тисовая, 4, графство Суррей"};

            return form;
        }

        static void PrintForm(Form form)
        {
            Console.WriteLine("Информация о больном №1");
            Console.WriteLine($"Пол: {form.gender[0]}");
            Console.WriteLine($"Возраст: {form.age[0]}");
            Console.WriteLine($"Имя: {form.name[0]}");
            Console.WriteLine($"Адрес: {form.address[0]}");
            Console.WriteLine();

            Console.WriteLine("Информация о больном №2");
            Console.WriteLine($"Пол: {form.gender[1]}");
            Console.WriteLine($"Возраст: {form.age[1]}");
            Console.WriteLine($"Имя: {form.name[1]}");
            Console.WriteLine($"Адрес: {form.address[0]}");
            Console.WriteLine();

            Console.WriteLine("Информация о больном №3");
            Console.WriteLine($"Пол: {form.gender[0]}");
            Console.WriteLine($"Возраст: {form.age[2]}");
            Console.WriteLine($"Имя: {form.name[2]}");
            Console.WriteLine($"Адрес: {form.address[0]}");
            Console.WriteLine();

            Console.WriteLine("Информация о больном №4");
            Console.WriteLine($"Пол: {form.gender[0]}");
            Console.WriteLine($"Возраст: {form.age[3]}");
            Console.WriteLine($"Имя: {form.name[3]}");
            Console.WriteLine($"Адрес: {form.address[0]}");
            Console.WriteLine();

            Console.WriteLine("Информация о больном №5");
            Console.WriteLine($"Пол: {form.gender[0]}");
            Console.WriteLine($"Возраст: {form.age[4]}");
            Console.WriteLine($"Имя: {form.name[4]}");
            Console.WriteLine($"Адрес: {form.address[1]}");
        }

        static void Main(string[] args)
        {
            var firstPatient = Patients();
            PrintForm(firstPatient);
        }
    }
}
