namespace knightmoves;

public class Car{
    public string Make {get;}
    public string Model {get;}

    public Car(string make, string model)
    {
        Make = make;
        Model = model;
    }
}

Car firstCar = new Car ("Ford", "Camry");
Car secondCar = new Car ("Ford", "Camry");

public override bool Equals (object obj){
    return obj is Car && this == (Car) obj;
}

public override int getHashCode(){
   return HashCode.Combine(Make, Model);
}

public static bool operator ==(Car first, Car second){
    return first.Make == second.Make && first.Model == second.Model;
}

public static bool operator !=(Car first, Car second){
    return !(first == second);
}





