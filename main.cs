using System;
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Give number!");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine (sum(n));
  }
  static int sum(int a){
      if (a == 0){
          return a;
      }
      return (a + sum(a-1));
  }
}