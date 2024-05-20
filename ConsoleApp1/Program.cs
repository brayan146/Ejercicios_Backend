// See https://aka.ms/new-console-template for more information
Console.WriteLine("Primer ejercicio");
List<int> list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);
list.Add(4);
list.Add(5);
list.Add(6);
list.Add(7);
list.Add(8);
list.Add(9);
list.Add(10);

Console.WriteLine("Primera lista");
foreach (int i in list)
{
    
    Console.WriteLine(i);
}

list.Remove(0);
list.Remove(9);

Console.WriteLine("Segunda lista lista");

foreach (int i in list)
{
    
    Console.WriteLine(i);
}

Console.WriteLine("Segundo ejercicio");

Dictionary<string, int> diccionario = new Dictionary<string, int>();
diccionario.Add("Jose", 9);
diccionario.Add("Juan", 6);
diccionario.Add("Pedro", 4);
diccionario.Add("Maria", 3);
diccionario.Add("Ana", 7);

foreach (var item in diccionario)
{
    if(item.Value%2 == 0)
    {
        Console.WriteLine(item.Key);
    }
}
diccionario["Jose"] = 10;
diccionario.Remove("Pedro");
foreach (var item in diccionario)
{
    Console.WriteLine(item);
}

Console.WriteLine("Tercer ejercicio");

Queue<string> cola = new Queue<string>();
cola.Enqueue("Jose");
cola.Enqueue("Juan");
cola.Enqueue("Pedro");
cola.Enqueue("Maria");
cola.Enqueue("Ana");

foreach (var item in cola)
{
    Console.WriteLine(item);
}

cola.Dequeue();
cola.Dequeue();

foreach (var item in cola)
{
    Console.WriteLine(item);
}


Console.WriteLine("Cuarto ejercicio");

Stack<string> pila = new Stack<string>();

pila.Push("Odisea");
pila.Push("Iliada");
pila.Push("La divina comedia");
pila.Push("El señor de los anillos");
pila.Push("Cien años de soledad");

foreach (var item in pila)
{
    Console.WriteLine(item);
}

pila.Pop();
pila.Pop();

foreach (var item in pila)
{
    Console.WriteLine(item);
}


Console.WriteLine("Quinto ejercicio");


