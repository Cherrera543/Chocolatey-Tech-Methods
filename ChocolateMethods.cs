using System;
public class ChocolateMethods{
	public static void Main(string[] args){
		char redo = 'y';
		while (redo=='y'){
			int option;
			Console.WriteLine("Possible Methods:");
			Console.WriteLine("Method 1: Reverse the word order in a phrase.");
			Console.WriteLine("Method 2: Find the second largest integer in an array.");
			Console.WriteLine("Method 3: Find if an integer is a prime number.");
			Console.WriteLine("What method would you like to try? (Ex. 1, 2, 3)");
			string input = Console.ReadLine();
			while(!input.Equals("1") && !input.Equals("2") && !input.Equals("3")){
				Console.WriteLine("Not a method option. Please enter 1, 2, or 3");
				input = Console.ReadLine();
				Console.WriteLine("-"+ input +"-");
			}
			option = Convert.ToInt32(input);
			switch(option){
				case 1:
					Console.WriteLine("What phrase would you like to reverse?");
					string phrase = Console.ReadLine();
					ReverseWordOrder(phrase);
					break;
				case 2:
					Console.WriteLine("Please enter your list of numbers seperated by spaces:");		
					int[] array = CreateIntArr(Console.ReadLine());
					FindSecondLargeInArray(array);
					break;
				case 3:
					Console.WriteLine("Please enter the number you would like to check:");
					int number = CheckifNumber(Console.ReadLine());
					if(FindPrime(number)) Console.WriteLine("Prime");
					else Console.WriteLine("Not Prime");
					break;
			}
			Console.WriteLine("Would you like to try another method? Y or N");
			string answer = Console.ReadLine();
			redo = char.ToLower(answer[0]);
			while(redo != 'y' && redo != 'n'){ 
				Console.WriteLine("Please reenter: ");
				answer = Console.ReadLine();
				redo = char.ToLower(answer[0]);
			}
				
		}
	}
		
	internal static void ReverseWordOrder(string str){
			
	}
	private static int[] CreateIntArr(string str){
		bool works = false;
		while (!works){
			try{
				string[] arrstr = str.Split(" ");
				int[] arr = new int[arrstr.Length];
				for(int i =0; i<arrstr.Length; i++){
					arr[i] = Convert.ToInt32(arrstr[i]);
				}
				works = true;
				return arr;
			}catch {
				Console.WriteLine("Please enter only integers seperated by spaces:");
				str = Console.ReadLine();
			}
		}
			
	}
	internal static void FindSecondLargeInArray(int[] arr){
			
	}
	private static int CheckifNumber(string str){
		int num;
		int works = false;
		while (!works){
			try{
				num = Convert.ToInt32(str);
				works = true;
			}catch {
				Console.WriteLine("Please reenter an integer: ");
				str = Console.ReadLine();
			}
		}
		return num;
	}
	internal static bool FindPrime(int number){
		bool prime = true;
		return prime;
	}
		
	
}