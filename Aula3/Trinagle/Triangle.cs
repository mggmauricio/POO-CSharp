using System;

namespace MyApp
{
  public class Triangle
  {
    private double A, B, C;

    public void get_sides(){
      Console.WriteLine("Digite a medida do lado x do triângulo:");
      this.A = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite a medida do lado y do triângulo:");
      this.B = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite a medida do lado z do triângulo:");
      this.C = double.Parse(Console.ReadLine());
    }

    private double calculate_p(){
      double p = (A + B + C) / 2;
      return p;
    }

    public double calculate_area()
    {
      get_sides();
      double p = calculate_p();
      return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
  }
  
}