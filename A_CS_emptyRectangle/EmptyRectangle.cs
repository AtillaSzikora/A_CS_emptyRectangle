using System;

namespace A_CS_emptyRectangle {

    internal class EmptyRectangle {

        //Draws an empty rectangle from given character and entered num of rows and cols.
        private static void Main(string[] args) {

            Console.Write("Enter a character to draw a rectangle: ");
            var c = char.Parse(Console.ReadLine());
            Console.Write("Enter how many columns should the rectangle has: ");
            var col = int.Parse(Console.ReadLine());
            Console.Write("Enter how many rows should the rectangle has: ");
            var row = int.Parse(Console.ReadLine());

            var colTimesChar = new string(c, col);
            var colTimesSpace = new string(' ', col - 2);

            Console.WriteLine(colTimesChar);
            for (var i = 0; i < row - 2; i++) { Console.WriteLine(c + colTimesSpace + c); }
            Console.WriteLine(colTimesChar);
        }
    }
}