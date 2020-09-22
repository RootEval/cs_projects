﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookupCollection {
    class Program {
        static void Main(string[] args) {
            // Создать Словарь, нечувствительный к регистру 
            ListDictionary list = new ListDictionary(new CaseInsensitiveComparer(CultureInfo.InvariantCulture));
            // Добавить несколько элементов
            list["Estados Unidos"] = "United States of America";
            list["Canada"] = "Canada";
            list["Espana"] = "Spain";
            //  Показать результаты
            Console.WriteLine(list["espana"]);
            Console.WriteLine(list["CANADA"]);
            Console.Read();
        }

    }
}
