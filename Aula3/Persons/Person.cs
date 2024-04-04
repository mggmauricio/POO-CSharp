using System;

namespace MyApp
{
  public class Person
  {
    public string name;
    public int age;
    public void SetName(){
    Console.WriteLine("Digite o nome: ");
    this.name = Console.ReadLine();
  }
  public void SetAge(){
    Console.WriteLine("Digite a idade: ");
    this.age = int.Parse(Console.ReadLine());
  }

  public void getPersonData(){
    SetName();
    SetAge();
  }
  }


  
}