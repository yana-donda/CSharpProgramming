using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

/*Зчитує дані з файлу employees.xml. Файл містить список співробітників у форматі XML, де кожен співробітник має такі властивості: Name, Position, HireDate.
Сортує співробітників за датою прийому на роботу (від найстаріших до найновіших) за допомогою LINQ.
Зберігає відсортований список співробітників у новий XML файл sorted_employees.xml.
Записує інформацію про співробітників в текстовий файл employees.txt у наступному форматі:

Name: [Name] Position: [Position] HireDate: [HireDate]*/

public class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }
    public DateTime HireDate { get; set; }

    public Employee() { }

    public Employee(string Name, string Position, DateTime HireDate)
    {
        this.Name = Name;
        this.Position = Position;
        this.HireDate = HireDate;
    }

    public override string ToString()
    {
        return $"Name: {Name}\nPosition: {Position}\nHireDate: {HireDate}\n";
    }
}

internal class Program
{
    static void Main()
    {
        string file = "C:\\Домашнє завдання\\ЛНУ\\Програмування C#\\Модуль\\modul2\\modul2.employees.xml";
        string file_save = "C:\\Домашнє завдання\\ЛНУ\\Програмування C#\\Модуль\\modul2\\sorted_employees.xml";
        string file_save_txt = "C:\\Домашнє завдання\\ЛНУ\\Програмування C#\\Модуль\\modul2\\employees.txt";


        List<Employee> employees = new List<Employee>();
        employees = LoadFromXml(file);
        foreach(Employee employee in employees)
        {
            Console.WriteLine(employee);
        }

        employees = (from e in employees
                     orderby e.HireDate
                     select e).ToList();

        SaveToXml(employees, file_save);

        using (StreamWriter writer = new StreamWriter(file_save_txt))
        {
            foreach (var employee in employees)
            {
                writer.WriteLine($"Name: {employee.Name} Position: {employee.Position} HireDate: {employee.HireDate:yyyy-MM-dd}");
            }
        }
    }

    static void SaveToXml(List<Employee> employees, string file)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
        using (FileStream f = new FileStream(file, FileMode.Create))
        {
            serializer.Serialize(f, employees);
        }
    }

    static List<Employee> LoadFromXml(string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
        using (FileStream f = new FileStream(filePath, FileMode.Open))
        {
            return (List<Employee>)serializer.Deserialize(f);
        }
    }
}






