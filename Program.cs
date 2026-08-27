

using ClaseGelatina_2027_I;

Console.WriteLine("Ingresa el Sabor que deseas de la gelatina");
string sabor = Console.ReadLine();



Gelatina miGelatina = new Gelatina( sabor == "" ? "Fresa" : sabor );
