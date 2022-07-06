using System;

namespace part_1 {

    class Program {
        static void Main() {
        int number =   900000000;
        byte number1= 255; // не более 255
        uint number2 = 10; //нельзя отрицательные
        short number3 = 32000; // не более 32000
        long number4 = 900000000000000000; // огромные числа

        float number5 = 4.54321f;
        double number6 = 5.6578d;
        string word = "Переменная";
        char simbol =':';
      
       Console.WriteLine(word + simbol + " " + number);
        Console.WriteLine(word + simbol + " " + number1);
         Console.WriteLine(word + simbol + " " + number2);
          Console.WriteLine(word + simbol + " " + number3);
           Console.WriteLine(word + simbol + " " + number4);
            Console.WriteLine(word + simbol + " " + number5);
             Console.WriteLine(word + simbol + " " + number6);
            // Console.ReadLine();
        }

    }

}

