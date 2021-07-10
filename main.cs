using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Functions");

    print();
    print();
    print();

    int total = 0;

    total = add(1,5);
    Console.WriteLine(total);

    total = add(10,51);
    Console.WriteLine(total);

    int x = 10;

    multiply(x);//passing input by value
    Console.WriteLine("X is " + x);

    multiplyByRef(ref x);//passing input by value
    Console.WriteLine("X is " + x);
  }


  public static void print() //This function takes no input and returns no output
  {
    Console.WriteLine("Hello");
  }

  public static int add(int num1, int num2)//define function
  {
    int sum=0;

    sum = num1+num2;

    return sum;
  }

  //Void means a regular method that does not return any value
  //Public means it can be accessed by anyone
  //static means you can call it without having an object
  public static void multiply(int num)
  {
    int product = num * num;
    num = product;
    Console.WriteLine("Result of multiply = " + num);
  }

   public static void multiplyByRef(ref int num)
  {
    int product = num * num;
    num = product;
    Console.WriteLine("Result of multiply: num = " + num);
  }





}