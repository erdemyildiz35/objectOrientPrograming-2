// See https://aka.ms/new-console-template for more information


var mazda = new Car();
mazda.Brand = "Mazda";
mazda.Model = "X";
mazda.Color = "Red";
mazda.isHybrid = true;

mazda.Menu();

var opel = new Car();
opel.Brand = "Opel";
opel.Model = "Y";
opel.Color = "red";
opel.isHybrid = true;

opel.Menu();


class Car
{
    public string Brand { get; set; }
    public string Model{ get; set; }
    public string Color{ get; set; }
    public bool isHybrid {  get; set; }

    public void Start()
    {
        Console.WriteLine($"{this.Brand} {this.Model} Start");
    }
    public void Stop() 
    {
        Console.WriteLine($"{this.Brand} {this.Model} is Stoped");
    }


    public void SlowDown()
    {
        Console.WriteLine($"{this.Brand} {this.Model} is Slowdown");
    }

    public void GetFaster()
    {
        Console.WriteLine($"{this.Brand} {this.Model} Get Faster");

    }

    public void Menu()
    {
        string Command = "";

        Console.WriteLine("1-Start 2-Stop 3-SlowDown 4- Get Faster");
        Console.Write("Your command:");
        Command = Console.ReadLine();
        switch(Command)
        {
            case "1":
                this.Start();
                break;
                case "2": this.Stop(); break;
                case "3": this.SlowDown(); break;
            case "4": this.GetFaster(); break;
               default: Console.WriteLine("Wrong Command");
                break;

        }




    }


}