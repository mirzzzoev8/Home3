namespace Task1;

public class Person
{
    public int Age { get; set; }
    public void Greet(){
        System.Console.WriteLine("Hello");
    }
    public void SetAge(int age){
      this.Age = age;
    }
}
