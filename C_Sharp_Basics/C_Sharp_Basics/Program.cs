// See https://aka.ms/new-console-template for more information

class Person
{
	public string name;
	public int age;

	public Person(string name, int age)
	{
		this.name = name;
		this.age = age;
	}

	public string Getname()
	{
		return name;
	}

	public int Getage()
	{
		return age;
	}

	~Person()
	{
		Console.WriteLine("Destructor is Involke")

	}

}

class Program
{
	static void main(string[] args)
	{
		Person p1 = new Person("Mithlesh,", 21);
		p1.Getname();
		Console.WriteLine(p1.name);
	}
}
