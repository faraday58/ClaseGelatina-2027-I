using System;
namespace ClaseGelatina_2027_I
{
    internal class Gelatina
    {
        private string sabor;
        private byte contenido;
        private float precio;


        internal Gelatina()
        {
            sabor = "Mora Azul";
            contenido = 40;
            precio = 12.5f;

            Console.WriteLine($"Preparando gelatina de \n sabor: {sabor} \n contenido: {contenido} g \n precio: ${precio} ");
            ElevarTemperaturaAgua();
            AgregarGelatinaEnPolvo();
            MezclarIngredientes();
            Templar();
            Refrigerar();
        }

        internal Gelatina(string sabor)
        {
           this.sabor = sabor;
           contenido = 50;
           precio = 12.5f;
           Console.WriteLine($"Preparando gelatina de \n sabor: {sabor} \n contenido: {contenido} g \n precio: ${precio} ");

        }


        private void ElevarTemperaturaAgua()
        {
            Console.WriteLine("Elevando la temperatura del agua...");
        }

        private void AgregarGelatinaEnPolvo()
        {
            Console.WriteLine("Agregando gelatina en polvo...");
        }
        private void MezclarIngredientes()
        {
            Console.WriteLine("Mezclando Ingredientes...");
        }

        private void Templar()
        {
            Console.WriteLine("Templando...");
        }

        private void Refrigerar()
        {
            Console.WriteLine("Refrigerando...");
        }

    }
}
