using System;
using System.Collections.Generic;
using OfficeOpenXml;

//string filePath =
//"Z:\\Gaziev\\excelBook.xlsx";

////ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
//ExcelPackage.License.SetNonCommercialPersonal("heio");
//ExcelPackage newBook = new ExcelPackage(filePath);
//var list1 = newBook.Workbook.Worksheets.Add("Лист1");
//var albibek = newBook.Workbook.Worksheets.Add("albibek");

//if (list1 != null)
//{
//    newBook.Workbook.Worksheets.Delete(list1);
//    newBook.Save();
//}


//var fileInfo = new FileInfo(filePath);
//newBook.SaveAs(fileInfo);


//namespace EpplusApp
//{
//    using OfficeOpenXml;
//    using System.IO;

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            ExcelWorksheet currentWorkSheep;
//            var listsNames = new List<string>() { "Лист1", "фдишиул", "Лист3", "Лист4", "Лист5" };
//            var list = new List<ExcelWorksheet>();
//            ExcelPackage.License.SetNonCommercialPersonal("Daniil");
//            string filePath = "Z:\\Gaziev\\excelBook.xlsx";
//            ExcelPackage newBook = new ExcelPackage(filePath);
//            foreach (var listName in listsNames)
//            {
//                if (newBook.Workbook.Worksheets[listName] == null)
//                    list.Add(newBook.Workbook.Worksheets.Add(listName));
//                else
//                    list.Add(newBook.Workbook.Worksheets[listName]);
//            }

//            //if (lists[4] != null)
//            //{
//            //    newBook.Workbook.Worksheets.Delete(lists[4]);
//            //    newBook.Save();
//            //}

//            currentWorkSheep = list[1];
//            currentWorkSheep.Cells["A1"].Value = $"Hello, world из листа фдишиул";
//            var fileInfo = new FileInfo(filePath);
//            newBook.SaveAs(fileInfo);
//        }
//    }
//}


//public enum ProductType
//{
//    WallpaperVinyl,
//    WallpaperFlizelin,
//    WallpaperPaper,
//    WallpaperLiquid,
//    Plaster,
//    Putty,
//    Drill,
//    Hammer,
//    Juice,
//    Chips
//}

//public class Product
//{
//    public string Name { get; set; }
//    public ProductType Type { get; set; }
//    public decimal Price { get; set; }
//    public int Quantity { get; set; }

//    public Product(string name, ProductType type, decimal price, int quantity)
//    {
//        Name = name;
//        Type = type;
//        Price = price;
//        Quantity = quantity;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Product[] products = new Product[]
//        {
//                new Product("Обои виниловые", ProductType.WallpaperVinyl, 1200.50m, 50),
//                new Product("Обои флизелиновые", ProductType.WallpaperFlizelin, 1500.75m, 30),
//                new Product("Обои бумажные", ProductType.WallpaperPaper, 800.00m, 100),
//                new Product("Обои жидкие", ProductType.WallpaperLiquid, 2000.00m, 20),
//                new Product("Штукатурка “Соседи не услышат”", ProductType.Plaster, 2500.00m, 15),
//                new Product("Шпатлевка “Сладко да гладко”", ProductType.Putty, 900.00m, 25),
//                new Product("Дрель “Буровик 3000”", ProductType.Drill, 5000.00m, 10),
//                new Product("Молоток “Тор”", ProductType.Hammer, 300.00m, 40),
//                new Product("Сок апельсиновый", ProductType.Juice, 150.00m, 200),
//                new Product("Чипсы со вкусом зелени", ProductType.Chips, 70.00m, 150)
//        };
//        string filePath = "Z:\\Gaziev\\excelBook.xlsx";
//        ExcelPackage.License.SetNonCommercialPersonal("Daniil");
//        using (ExcelPackage excelPackage = new ExcelPackage(filePath))
//        {
//            var worksheet = excelPackage.Workbook.Worksheets.Add("Складской учет");

//            worksheet.Cells[1, 1].Value = "Наименование";
//            worksheet.Cells[1, 2].Value = "Тип товара";
//            worksheet.Cells[1, 3].Value = "Стоимость";
//            worksheet.Cells[1, 4].Value = "Количество";

//            for (int i = 0; i < products.Length; i++)
//            {
//                worksheet.Cells[i + 2, 1].Value = products[i].Name;
//                worksheet.Cells[i + 2, 2].Value = products[i].Type.ToString();
//                worksheet.Cells[i + 2, 3].Value = products[i].Price;
//                worksheet.Cells[i + 2, 4].Value = products[i].Quantity;
//            }
//            excelPackage.Save();

//            FileInfo excelFile = new FileInfo(filePath);
//            excelPackage.SaveAs(excelFile);
//        }

//        Console.WriteLine("Файл успешно создан!");
//    }
//}



//string filePath =
//"Z:\\Gaziev\\excelBook.xlsx";
//ExcelPackage newBook = new ExcelPackage(filePath);
//newBook.Workbook.Worksheets.Add("Functions");
//ExcelWorksheet currentWorksheet =
//newBook.Workbook.Worksheets["Functions"];
///**********Стандартные действия создания листа и его выбора***********/
//// Заполнение ячеек первых слагаемых
//currentWorksheet.Cells["A1"].Value = 10;
//currentWorksheet.Cells["A2"].Value = 20;
//currentWorksheet.Cells["A3"].Value = 30;
//// Заполнение ячеек вторых слагаемых
//currentWorksheet.Cells["B1"].Value = 2;
//currentWorksheet.Cells["B2"].Value = 5;
//currentWorksheet.Cells["B3"].Value = 10;
//// Используем функцию SUM() для суммирования значений
//currentWorksheet.Cells["C1"].Formula = "SUM(A1:B1)";
//currentWorksheet.Cells["C2"].Formula = "SUM(A2:B2)";
//currentWorksheet.Cells["C3"].Formula = "SUM(A3:B3)";
//newBook.Save();


//Объектно ориентированное
//программирование на C#
//Тема 28. Урок 3. Практика. Работа с формулами.
//Задача 1.
//Анализ данных о продажах:
//Подготовьте таблицу с данными о продажах и используйте функции SUM,
//AVERAGE, MAX и MIN для анализа и визуализации ключевых метрик, таких
//как общая выручка, средний чек, максимальная и минимальная продажа.
//Задача 2.
//Создайте таблицу для поиска должников на основе характеристик, таких
//как фамилия, имя и обслуживающее предприятие. Используйте функцию
//VLOOKUP для нахождения стоимости по заданным параметрам.
//Пример формулы для GoogleSheets: = ВПР(B8 ; B2: E5; 2; 0 )
//Пример формулы для OpenOffice: =VLOOKUP( B8 ; B2:E5 ; 2 ; 0 )

//1
ExcelPackage.License.SetNonCommercialPersonal("Daniil");
string filePath = "Z:\\Gaziev\\excelBook.xlsx";
ExcelPackage excelPackage = new ExcelPackage(filePath);
var worksheet = excelPackage.Workbook.Worksheets.Add("listtt");
worksheet.Cells[1, 1].Value = "Фамилия";
worksheet.Cells[1, 2].Value = "Имя";
worksheet.Cells[1, 3].Value = "Обсл. компания";
worksheet.Cells[1, 4].Value = "Задолженность";

worksheet.Cells["F15"].Formula = "VLOOKUP( B8 ; B2:E5 ; 2 ; 0 )";
excelPackage.Save();
FileInfo excelFile = new FileInfo(filePath);
excelPackage.SaveAs(excelFile);
