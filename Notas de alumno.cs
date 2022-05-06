// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class promedio {

		static void Main(string[] args) {
			double nota1;
			double nota2;
			double nota3;
			double nota4;
			double notafinal;
			Console.WriteLine("Suma de notas y calculo de promedio");
			// Entrada
			Console.WriteLine("ingrese la Nota de Matematica");
			nota1 = Double.Parse(Console.ReadLine());
			Console.WriteLine("ingrese la Nota de Lengua");
			nota2 = Double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese la Nota de Ingles");
			nota3 = Double.Parse(Console.ReadLine());
			Console.WriteLine("ingrese la Nota de Historia");
			nota4 = Double.Parse(Console.ReadLine());
			// Proceso 
			notafinal = (nota1+nota2+nota3+nota4)/4;
			// Salida
			Console.WriteLine("su resultado es de: "+notafinal);
			if (notafinal>7) {
				Console.WriteLine("el alumno aprobo");
			} else {
				Console.WriteLine("el alumno no aprobo");
			}
		}

	}

}

