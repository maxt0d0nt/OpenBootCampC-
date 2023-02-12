/*
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


//TEMA 3
Cliente cliente = new Cliente("Max", 123456, "varsovia", "Max@email.com", "si");
Console.WriteLine(cliente);

public struct Cliente 
{

 public Cliente(string x, int y, string z, string i, string j)
{
NombreCompleto = x;
Telefono = y;
Direccion = z;
Email = i;
EsNuevoCliente = j;
    }
    public string NombreCompleto { get; set; }
    public int Telefono { get; set; }
    public string Direccion { get; set; }
    public string Email { get; set; }
    public string EsNuevoCliente { get; set; }


public override string ToString() => $"{NombreCompleto} {Telefono} {Direccion} {Email} {EsNuevoCliente}";

 }
*/
/*
//Tema 4
// ejercicio 1 - while
Console.WriteLine("¿que tabla de multiplicar desea obtener? escriba numero:");
int tabla = Convert.ToInt32(Console.ReadLine());

int i = 0;

while (i <= 10) {
    int resultado = 0;
    resultado = tabla * i;
    Console.WriteLine(tabla + " X " + i + " = " + resultado);
    i++;
} 

//ejercicio 2 - do-while
Console.WriteLine("escriba un numero:");
int numA = Convert.ToInt32(Console.ReadLine());
bool positivo = (numA > 0);
Console.WriteLine("el numero positivo: " + (numA > 0));
bool negativo = (numA < 0);
Console.WriteLine("el numero negativo: " + (numA < 0));
Console.WriteLine("el numero es cero: " + (numA == 0));
int cont = 0;
while (positivo && cont <= numA)

{
    
    do
{
Console.WriteLine(cont);
    cont++;
} 
while (cont <= numA);
}

while (negativo && cont >= numA)

{
    
    do
{
Console.WriteLine(cont);
    cont--;
} 
while (cont >= numA);
}

//ejercicio 3
Escribe un programa que realice estos pasos:

Reciba 3 datos:

ancho

alto

relleno o no

Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.

En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos que se deben dibujar en la pantalla. Ejemplos:

Input: 2,2,2, relleno = true

Output:

** **

** **

Input: 3, 4, 1, relleno = false

Output:

***

* *

* *

***

*/
Console.WriteLine("escriba el largo que desee tener en su figura:");
int large = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("escriba el ancho que desee tener en su figura::");
int width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("escriba 1 si desea sea reeleno; escriba 2 si desea sea vacio");
int fill = Convert.ToInt32(Console.ReadLine());

//borde superior
for (int i = 0; i < large; i++)
{
    Console.Write("*");
}
Console.WriteLine("");
int p = 0;

//vacio
while (fill == 1 && p < width - 2)

    do
    {

        Console.Write("*");
        for (int h = 0; h < large - 2; h++)
        {
            Console.Write(" ");
        }
        Console.WriteLine("*");
        p++;
    } while (p < width - 2);

//relleno
while (fill == 2 && p < width)
    do
    {

        for (int z = 0; z < width; z++)
            p++;
        {
            for (int k = 0; k < width - 2; k++)
            {


                for (int h = 0; h < large; h++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }
    } while (p < width);

//borde inferior

for (int j = 0; j < large; j++)
{
    Console.Write("*");
}

