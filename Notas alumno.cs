
    Double Nota1;
    Double Nota2;
    Double Nota3;
    Double NotaFinal;
    object value2 = Console.WriteLine("Suma de notas y calculo de promedio");
    //Entrada
    Console.Writeline("Ingrese la Nota de matematica");
    Nota1 = Double.Parse(Console.ReadLine());
    Console.Writeline("Ingrese la Nota de Lengua");
    Nota2 = Double.Parse (Console.ReadLine());
    object value3 = Console.WriteLine ("""Ingrese la Nota de Ingles""");
    Nota3 = Double.Parse (Console.ReadLine());
    //Proceso
    NotaFinal = (Nota1+Nota2+Nota3) / 3;
    //Salida
    object value1 = Console.WriteLine("su resultado es igual a " + NotaFinal);
    if (NotaFinal > 7)
    {
        Console.WriteLine("El alumno aprobo");
    }
    else
        object value = Console.WriteLine("El alumno no aprobo");
      
