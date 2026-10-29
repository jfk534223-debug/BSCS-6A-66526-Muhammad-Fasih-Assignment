using System;

class LeapYear {
    static void Main() {
        Console.WriteLine("BSCS-6A-66526-Muhammad-Fasih - Date: 29-Oct-2026");
        Console.Write("Enter the year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year % 400 == 0) {
            Console.WriteLine("Leap year");
        } else if (year % 100 == 0) {
            Console.WriteLine("Not a leap year");
        } else if (year % 4 == 0) {
            Console.WriteLine("Leap year");
        } else {
            Console.WriteLine("Not a leap year");
        }
    }
}
