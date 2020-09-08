using System;

namespace CheckTypes {
    class Program {
        static void Main(string[] args) {
            Int16 i16 = 1; // 16-bits
            Int32 i32 = 1; // 32-bits
            double db = 1; // 64-bits

            //i16 = i32; // error
            //i16 = db; // error
            i32 = i16;
            //i32 = db; // error
            db = i16; 
            db = i32;

            // ошибки возникают при попытке записать переменную типа, 
            // требующего для хранения больше памяти, чем доступно
            // типу, в который эта переменная должна быть записана
        }
    }
}
