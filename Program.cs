// See https://aka.ms/new-console-template for more information
// Punto 1 --------------------------------------------------------------------
/*Console.WriteLine("Ingrese el valor del primer trimestre ");
double trimestreuno = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor del segundo trimestre ");
double trimestredos = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor del tercer trimestre ");
double trimestretres = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el valor del cuarto trimestre ");
double trimestrecuatro = double.Parse(Console.ReadLine());

double suma, valorPorcentaje = 0, porcentaje = 0;


suma = trimestreuno + trimestredos + trimestretres + trimestrecuatro;

if (suma < 10000)
{
    valorPorcentaje = suma * 0.05;
    porcentaje = 5;

}
if (suma >= 10000 && suma < 20000)
{
    valorPorcentaje = suma * 0.10;
    porcentaje = 10;
}
if (suma >= 20000 && suma < 35000)
{
    valorPorcentaje = suma * 0.15;
    porcentaje = 15;
}
if (suma >= 35000 && suma < 45000)
{
    valorPorcentaje = suma * 0.20;
    porcentaje = 20;
}
if (suma >= 45000)
{
    valorPorcentaje = suma * 0.30;
    porcentaje = 30;
}



Console.WriteLine("El valor de su renta anual es: " + suma);
Console.WriteLine("El valor impuesto agregado es: " + porcentaje + "%");
Console.WriteLine("Es valor a pagar de su renta es: " + valorPorcentaje);
*/
//-----------------------------------------------------------------------
//Punto 2-------------------------------------------------------------------


/*  Console.Write("\nIngrese el nombre completo: ");
string nombre = Console.ReadLine();

Console.Write("\nIngrese la edad: ");
int edad = int.Parse(Console.ReadLine());

double valor_entretrada = 15000;
double descuento = 0;

 if (edad < 0 || edad > 100)
{
    Console.WriteLine("\nError. No existe una persona con esa edad\n");
    Environment.Exit(0);
}

if (edad >= 0 && edad < 4)
{
    valor_entretrada = 0;
    descuento = valor_entretrada - 15000;
}

if (edad >= 4 && edad <= 18)
{
    valor_entretrada *= 0.95;
    descuento = 5;
}

if (edad > 18 && edad <= 100)
{
    valor_entretrada *= 0.97;
    descuento = 3;
}

Console.WriteLine("Nombre completo: " + nombre);
Console.WriteLine("valor entrada: " + valor_entretrada+"$ pesos");

if (descuento > 0)
{
    Console.WriteLine("Descuento: " +descuento+"%\n");
} */

//Punto 3--------------------------------------------------------------------
/*Console.WriteLine("Bienvenido a Pizzas el Fercho. ¿Qué tipo de pizza desea?");
Console.WriteLine("1. Vegetariana");
Console.WriteLine("2. No vegetariana");
string opcion_pizza = Console.ReadLine();
string ingredientes = "";
bool es_vegetariana = true;
if (opcion_pizza == "1")
{
    Console.WriteLine("Ha elegido pizza vegetariana. Los ingredientes disponibles son:");
    Console.WriteLine("1. Pimiento");
    Console.WriteLine("2. Champiñones");
    string opcion_ingrediente = Console.ReadLine();
    if (opcion_ingrediente == "1")
    {
        ingredientes = "Mozzarella, tomate, pimiento";
    }

    if (opcion_ingrediente == "2")
    {
        ingredientes = "Mozzarella, tomate, champiñones";
    }

    if (opcion_ingrediente != "1" && opcion_ingrediente != "2")
    {
        Console.WriteLine("Opción no válida.");
    }

    es_vegetariana = true;

}

if (opcion_pizza == "2")
{
    Console.WriteLine("Ha elegido pizza no vegetariana. Los ingredientes disponibles son:");
    Console.WriteLine("1. Pepperoni");
    Console.WriteLine("2. Salami");
    Console.WriteLine("3. Pollo");
string opcion_ingrediente = Console.ReadLine();
    if (opcion_ingrediente == "1")
    {


        ingredientes = "Mozzarella, tomate, pepperoni";
    }
    if (opcion_ingrediente == "2")
    {
        ingredientes = "Mozzarella, tomate, salami";
    }
    if (opcion_ingrediente == "3")
    {
        ingredientes = "Mozzarella, tomate, pollo";
    }

    if (opcion_ingrediente != "1" && opcion_ingrediente != "2" && opcion_ingrediente != "3")
    {
        Console.WriteLine("Opción no válida.");
    }

    es_vegetariana = false;}
if (opcion_pizza != "1" && opcion_pizza != "2")
{
    Console.WriteLine("Opción no válida.");
}

if (es_vegetariana)
{
    Console.WriteLine("Ha elegido una pizza vegetariana con los siguientes ingredientes:");
}
else
{
    Console.WriteLine("Ha elegido una pizza no vegetariana con los siguientes ingredientes:");
}
Console.WriteLine(ingredientes);*/
//---------------------------------------------------------------------------------------------------

//Punto 4------------------------------------------------------------------------------

/* string nivel;
double puntos;
double bonificacion;

Console.Write("\nIngrese la puntuación del empleado ( 0,0 - 0,4 - 0,6): ");
puntos = double.Parse(Console.ReadLine());

if (puntos == 0.0 || puntos == 0.4 || puntos == 0.6)
{
    if (puntos == 0.0)
    {
        nivel = "Inaceptable";
    }
    else if (puntos == 0.4)
    {
        nivel = "Aceptable";
    }
    else
    {
        nivel = "Meritorio";
    }
    
     bonificacion = puntos * 50000;
    Console.WriteLine("El empleado ha obtenido el nivel "+nivel);
    Console.WriteLine("Le corresponde una bonificación de:  $"+bonificacion+"\n");
}
else
{
    Console.WriteLine("La puntuación ingresada no es válida. Por favor, ingrese 0,0, 0,4 o 0,6\n");
}

Console.ReadLine();
 */