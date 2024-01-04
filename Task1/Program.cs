using Task1;

var person1 = new Student();
person1.Study();
person1.ShowAge();

var person2 = new Person();
person2.Age = Convert.ToInt32(Console.ReadLine());
person2.Greet();
person2.SetAge(20);

var person3 = new Teacher();
person3.Explain();