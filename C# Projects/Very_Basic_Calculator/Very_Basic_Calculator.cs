using System;
namespace MyCalculator {
	class CalculatorApp {
		public static void Main(string[] args){
			int operation_number, first_number, Second_number, sum, subtract, multiplication, division;
			Console.WriteLine("NOTE: This Calculator for the basic operation on two intgers only.");
			Console.Write("Please  Enter First Number: ");
			first_number = int.Parse(Console.ReadLine());
			Console.Write("Please Enter Second Number: ");
			Second_number = int.Parse(Console.ReadLine());
			Console.WriteLine("Choose your Operation: ");
			Console.WriteLine("1- + \n2- - \n3- * \n4- /");
			Console.Write("Please enter the number of your operation: ");
			operation_number = int.Parse(Console.ReadLine());
			if(operation_number == 1){
				sum = first_number + Second_number;
				Console.WriteLine("Sum is: {0} + {1} = {2}", first_number, Second_number, sum);
			}else if(operation_number == 2){
				subtract = first_number - Second_number;
				Console.WriteLine("subtract is: {0} - {1} = {2}", first_number, Second_number, subtract);
			}else if(operation_number == 3){
				multiplication = first_number * Second_number;
				Console.WriteLine("multiplication is: {0} * {1} = {2}",first_number, Second_number, multiplication);
			}else if(operation_number == 4){
				division = first_number / Second_number;
				Console.WriteLine("division is: {0} / {1} = {2}",first_number, Second_number, division);
			}else{
				Console.WriteLine("please Choose one of four");
			}
		}
	}
}