Algoritmo Promedio
	Mostrar "Suma de notas y calculo de promedio"
	//Entrada
	Definir Nota1 Como Real
	Definir Nota2 Como Real
	Definir Nota3 Como Real
	Definir Nota4 Como Real
	Escribir "ingrese la Nota de Matematica"
	Leer Nota1
	Escribir "ingrese la Nota de Lengua"
	Leer Nota2
	Escribir "Ingrese la Nota de Ingles"
	Leer Nota3
	Escribir "ingrese la Nota de Historia"
	Leer Nota4
	//Proceso 
	NotaFinal = (Nota1 + Nota2 + Nota3 + Nota4) / 4
	//Salida
	Mostrar "su resultado es de: " NotaFinal
	si NotaFinal >7 Entonces
		Mostrar "el alumno aprobo"
	SiNo 
		Mostrar "el alumno no aprobo"
	FinSi
FinAlgoritmo
