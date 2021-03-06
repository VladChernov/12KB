﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MModelService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : IService1
    {
        public void DoWork()
        {
        }

        public void A_Button_Click(string Category, List<string> Magaz)
        {
            Category = "A";
            Magaz.Add(DateTime.Now + "  Пользователь зашел в систему под уровнем " + Category);
            Console.WriteLine(DateTime.Now + "  Пользователь зашел в систему под уровнем " + Category);
        }

        public void B_Button_Click(string Category, List<string> Magaz)
        {
            Category = "B";
            Magaz.Add(DateTime.Now + "  Пользователь зашел в систему под уровнем " + Category);
            Console.WriteLine(DateTime.Now + "  Пользователь зашел в систему под уровнем " + Category);
        }

        public void C_Button_Click(string Category, List<string> Magaz)
        {
            Category = "C";
            Magaz.Add(DateTime.Now + "  Пользователь зашел в систему под уровнем " + Category);
            Console.WriteLine(DateTime.Now + "  Пользователь зашел в систему под уровнем " + Category);
        }

        public void D_Button_Click(string Category, List<string> Magaz)
        {
            Category = "D";
            Magaz.Add(DateTime.Now + "  Пользователь зашел в систему под уровнем " + Category);
            Console.WriteLine(DateTime.Now + "  Пользователь зашел в систему под уровнем " + Category);
        }

        public void PasIsNotCor(string Category, List<string> Magaz)
        {
            Magaz.Add(DateTime.Now + "  Пользователь пытался зайти под уровнем "+Category+", но ввел неправильный пароль");
            Console.WriteLine(DateTime.Now + "  Пользователь пытался зайти под уровнем " + Category + ", но ввел неправильный пароль");
        }

        public void SaveMagazine(List<string> Magaz)
        {
            StreamWriter fs = new StreamWriter("1.txt", true, Encoding.Default);
            foreach (var i in Magaz)
            {
                fs.WriteLine(i);
            }
            fs.WriteLine(DateTime.Now + "  Закрытие программы");
            fs.Close();
            Console.WriteLine(DateTime.Now + "  Закрытие программы");
        }

        public void FileRead(StreamReader fs,List<string> FileName)
        {
            for (int i = 0; !fs.EndOfStream; i++)
            {
                FileName.Add(fs.ReadLine());
            }
        }

        public void FileReadOpen(StreamReader fs, List<string> Magaz, string text,string filename)
        {
            for (int j = 0; !fs.EndOfStream; j++)
            {
                text += fs.ReadLine();
            }
            Magaz.Add(DateTime.Now + "  Пользователь открыл файл " + filename);
            Console.WriteLine(DateTime.Now + "  Пользователь открыл файл " + filename);
        }

        public void FileReadOpenIsReadonly(StreamReader fs, List<string> Magaz, string text, string filename)
        {
            for (int j = 0; !fs.EndOfStream; j++)
            {
                text += fs.ReadLine();
            }
            Magaz.Add(DateTime.Now + "  Пользователь открыл файл " + filename + " с ограничением на запись и сохранение");
        }

        public void AccessDenied(List<string> Magaz, string filename)
        {
            Magaz.Add(DateTime.Now + "  Попытка доступа к файлу " + filename);
            Magaz.Add(DateTime.Now + "  Доступ запрещен!!!");
            Console.WriteLine(DateTime.Now + "  Попытка доступа к файлу " + filename);
            Console.WriteLine(DateTime.Now + "  Доступ запрещен!!!");
        }

        public void Save(List<string> Magaz, string text, string filename)
        {
            StreamWriter fs = new StreamWriter(filename, false, Encoding.Default);
            fs.WriteLine(text);
            fs.Close();
            Magaz.Add(DateTime.Now + "  Пользователь изменил документ " + filename);
            Console.WriteLine(DateTime.Now + "  Пользователь изменил документ " + filename);
        }

        public void New(string filePath, string nameFile, string category, string text, List<string> Magaz)
        {
            Magaz.Add(DateTime.Now + "  Пользователь создал новый файл " + filePath + "\\" + nameFile + ".txt");
            string path = filePath + "\\" + nameFile + ".txt";
            File.WriteAllText(path, text, Encoding.Default);
            if (category.Equals("A"))
            {
                File.AppendAllText("A.txt", Environment.NewLine + path, Encoding.Default);
            }
            if (category.Equals("B"))
            {
                File.AppendAllText("B.txt", Environment.NewLine + path, Encoding.Default);
            }
            if (category.Equals("C"))
            {
                File.AppendAllText("C.txt", Environment.NewLine + path, Encoding.Default);
            }
            if (category.Equals("D"))
            {
                File.AppendAllText("D.txt", Environment.NewLine + path, Encoding.Default);
            }
            Console.WriteLine(DateTime.Now + "  Пользователь создал новый файл " + filePath + "\\" + nameFile + ".txt");
        }
    }
}
