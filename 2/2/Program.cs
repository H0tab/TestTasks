var car1 = new Car {Model = "Chevrolet", Color = "Blue", Description = "Some description"};
var car2 = new Car {Model = "Chevrolet", Color = "Blue", Description = "Some description 2"};
var car3 = new Car {Model = "Tesla model x", Color = "White", Description = "Some description for tesla"};

Console.WriteLine(car1.Equals(car2)); //true
Console.WriteLine(car2.Equals(car3)); //false
Console.WriteLine(car2.Equals(car2)); //true

public class Car
{
    public string Model { get; set; }
    public string Color { get; set; }
    public string Description { get; set; }

    public override bool Equals(object? obj) => this.Equals(obj as Car);

    public bool Equals(Car car)
    {
        if (car is null)
        {
            return false;
        }

        if (Object.ReferenceEquals(this, car))
        {
            return true;
        }

        if (this.GetType() != car.GetType())
        {
            return false;
        }

        return (Model.ToLower() == car.Model.ToLower()) && (Color.ToLower() == car.Color.ToLower());
    }

    public override int GetHashCode() => (Model, Color).GetHashCode();
}