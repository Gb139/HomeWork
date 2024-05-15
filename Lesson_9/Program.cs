namespace Lesson_9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = (10 + 3) * 2 - 2 / 1;
            // Скобки -> умножения -> деление -> вычетание -> присваивание 
            int d = a * 2 + ++a;
            // Инкремент -> умножение -> сложение -> присваивание
            var s = !false && true;
            //!false(Логическое не) -> логическое И -> присваивание
            int g = a ^ d;
            //Исключающие ИЛИ -> присваивание 
            
        }
    }
}