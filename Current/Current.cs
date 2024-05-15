using System;

namespace Current
{
    public class Current
    {
        static void Main()
        {
            Console.WriteLine(GetYear());
        }

        public static int GetYear() => DateTime.Now.Year;
    }
}

namespace TuCurrent
{
    public class Current
    {
        public static int GetYear() => DateTime.Now.Year;
    }
}

//Я так и не понял что просят сделать в задание и в каком классе писать метод написал и в том и в том и в тесте тоже  
//Подходит ли UnitTest как 2 проект я тоже не понял  