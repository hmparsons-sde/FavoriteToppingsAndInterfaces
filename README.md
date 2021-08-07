# FavoriteToppingsAndInterfaces

## Interfaces

An Interface functions as a [contract for a class](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/interfaces/) to implement properties and methods. They are closely tied to the idea of inheritance, but they do ***not*** demand that you use inheritance. For this reason, they are considered more flexible than inheritance.

## How is this different than an `abstract` class?

Unlike abstract classes, they cannot have a defined implementation. They will only contain properties(not initialized) and method signatures.

One of the benefits of using an interface is that a single class can implement multiple interfaces, while it can only inherit from one base class.

```csharp
public class Amphicar : IGroundVehicle, IAquaticVehicle
{	
	// An amphibious automobile
}
```

### References

- [D is for the Dependency Inversion Principle](https://news.realm.io/news/donn-felker-solid-part-5/)
- [I is for the Interface Segregation Principle](https://news.realm.io/news/donn-felker-solid-part-4/)
- [What does “program to interfaces, not implementations” mean?](https://stackoverflow.com/questions/2697783/what-does-program-to-interfaces-not-implementations-mean)
- [An Absolute Beginner's Tutorial on Dependency Inversion Principle](https://www.codeproject.com/Articles/615139/An-Absolute-Beginners-Tutorial-on-Dependency-Inver)
- [Interface Segregation Principle - A Walk Through History](https://www.codeproject.com/Tips/766045/Interface-Segregation-Principle-ISP-of-SOLID-in-Cs)
