
Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();
Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good girl");

Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("Bad boy");

while (myDog.levelOfHappiness != 5)
{
    myDog.Bark();
}
myDog.Wagtail();

class Dog
{

    private string _name;
    private int _levelOfHappiness = 0;
    public Dog(string name)
    {
        _name = name;
        _levelOfHappiness = 0;
    }

    public string Name
    { 
        get { return _name; }
    }

    public int levelOfHappiness
    {
        get { return _levelOfHappiness; }
    }
    public void Rename(string newname)
    { 
        _name = newname;
        Console.WriteLine($"The dog has been renamed to: {newname}");
    }

    public void Bark()
    {
        Console.WriteLine("Woof-Woof!");
        _levelOfHappiness++;
    }

    public void Wagtail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }


}
