// ejercicio 1
Console.WriteLine("¿Como te llamas?");
var name = Console.ReadLine();
Console.WriteLine("Tu nombre es " + name);



//ejercicio2
Console.WriteLine("La fecha y hora actual es:");
Console.WriteLine(DateTime.Now);

//TEMA 2
//Ejercicio 1 nombre, apellido, edad, sabe programar, etc.
Console.WriteLine("Escriba su nombre:");
var name = Console.ReadLine();
Console.WriteLine("Escriba su apellido:");
var lastName = Console.ReadLine();
Console.WriteLine("Escriba su edad:");
var age = Console.ReadLine();
Console.WriteLine("Sabe programar:");
var knowDevelope = Console.ReadLine();

Console.WriteLine("Su nombre completo es "+ name + " "+ lastName);
Console.WriteLine("Su edad es " + age);
Console.WriteLine("¿Sabe Programar? " + knowDevelope);

