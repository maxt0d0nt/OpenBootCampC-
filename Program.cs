// ejercicio 1
Console.WriteLine("¿Como te llamas?");
var name = Console.ReadLine();
Console.WriteLine("Tu nombre es " + name);



//ejercicio2
Console.WriteLine("La fecha y hora actual es:");
Console.WriteLine(DateTime.Now);




//TEMA 2
//Ejercicio 1 

Console.WriteLine("Escriba su nombre:");
var name2 = Console.ReadLine();
Console.WriteLine("Escriba su apellido:");
var lastName = Console.ReadLine();
Console.WriteLine("Escriba su edad:");
var age = Console.ReadLine();
Console.WriteLine("Sabe programar:");
var knowDevelope = Console.ReadLine();

Console.WriteLine("Su nombre completo es "+ name + " "+ lastName);
Console.WriteLine("Su edad es " + age);
Console.WriteLine("¿Sabe Programar? " + knowDevelope);

//Ejercicio 2
//Coche: 

Console.WriteLine("A continuacion le haremos varias preguntas sobre su coche");
Console.WriteLine("¿Cuantas puertas tiene su coche?");
int doors = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("¿Cuantas ruedas tiene su coche?");
int wheels = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("¿Que marca es su coche?");
string brand = Console.ReadLine();
Console.WriteLine("¿tiene la ITV vigente?");
string itv = Console.ReadLine();

Console.WriteLine("Su coche es marca "+ brand + " tiene " + doors + " puertas y tiene " + wheels + " ruedas, la ITV " + itv + " esta vigente.");


//Mesa: 

Console.WriteLine("A continuacion le haremos varias preguntas sobre la mesa:");
Console.WriteLine("¿Peso de la mesa(kg)?");
int peso = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("¿largo de la mesa(cm)?");
int largo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("¿De que material es la mesa?");
string material = Console.ReadLine();
Console.WriteLine("¿De que color es la mesa?");
string color = Console.ReadLine();

Console.WriteLine("Su mesa pesa " + peso + " kg y tiene un largo de " + largo + " cm, el material de la mesa es " + material + " y es de color " + color);


//Ejercicio 3
//Un número es mayor o igual a 18
Console.WriteLine("Escriba un numero:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num + " ¿es mayor o igual que 18? " + (num >=18));

//Un char es ‘a’
string var = "a";
char letter = Convert.ToChar(var);
Console.WriteLine(letter + " es una variable char");

//Se cumplen dos conciones a la vez (ambas verdaderas)

Console.WriteLine("Escriba un numero mayor a 0:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escriba otro numero diferente mayor a 0:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("El primer numero es mayor a cero (" + num +"), por lo que la suma de ambos (" + (num +num2) + ") es mayor a cero tambien => " + (num + num2 > 0 && num > 0));


//Se cumple una de dos condiciones a la vez (una true y otra false)
Console.WriteLine("Escriba un numero:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escriba otro numero diferente:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("El primer numero es mayor a cero (" + num +"), por lo que la suma de ambos es (" + (num +num2) + ") y se cumple el OR, primer numero mayor a cero o la suma de ambos menor a 0 =>" + (num + num2 < 0 || num > 0));



