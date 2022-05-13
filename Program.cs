

int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);
int respuesta = 0;
int contador = 0;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine();
Console.WriteLine("**************************************************************************");
Console.WriteLine("*                                                                        *");
Console.WriteLine("*          Saludos humano!!, hoy tenemos un pequeño juego......          *");
Console.WriteLine("*                                                                        *");
Console.WriteLine("* voy a pensar en un número del 1 al 20 y TENDRÁS que adivinarlo....     *");
Console.WriteLine("*                                                                        *");
Console.WriteLine("* ...PORQUE EL PROGRAMA NO SE CERRARÁ HASTA QUE LO HAGAS MUAAAJAJAJA...  *");
Console.WriteLine("*                                                                        *");
Console.WriteLine("**************************************************************************");
Console.WriteLine();
Console.WriteLine("ya lo tengo.... ingresa el numero en el que crees que estoy pensando");

while (respuesta != numeroSecreto)
{
    
    contador++;
    respuesta = int.Parse(Console.ReadLine());
    Console.Clear();
    

    if (respuesta < 1 || respuesta > 20)
    {
       
        contador--;
       Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine("**********************************");
        Console.WriteLine("* TE DIJE ENTRE 1 y 20 ANIMAL!!! *");
        Console.WriteLine("**********************************");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("ingresa una nueva opcion entre 1 y 20");
    }
    else if (respuesta > numeroSecreto)
    {
       Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine("************************************************************");
        Console.WriteLine("* el numero " + respuesta + " es MAYOR al numero en el que estoy pensando *");
        Console.WriteLine("************************************************************");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("ingresa una nueva opcion entre 1 y 20");
        
    }
    else if (respuesta < numeroSecreto)
    {
       Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine("***********************************************************");
        Console.WriteLine("* el numero " + respuesta + " es MENOR al numero en el que estoy pensando *");
        Console.WriteLine("***********************************************************");
        Console.ForegroundColor = ConsoleColor.Yellow;
        
        Console.WriteLine("ingresa una nueva opcion entre 1 y 20");
        
    }
    else if (respuesta == numeroSecreto)
    {
       Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Felicitaciones, has adivinado el número secreto que era: " + numeroSecreto + " ");
        Console.WriteLine(" Lo has logrado en " + contador + " intentos!!                            ");
        Console.WriteLine("***************************************************************************");
        
    }



}
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine();
Console.WriteLine("***************************************************************");
Console.WriteLine("* ahora el programa se cerrará, me has ganado esta vez humano *");
Console.WriteLine("***************************************************************");
Console.ResetColor();  
