/*7.La calificaci�n final de un estudiante es el promedio de tres notas:
la nota de pr�cticas que cuenta un 30% del total, la nota te�rica que cuenta un
60% y la nota de participaci�n que cuenta el 10% restante. Escriba un programa 
que lea las tres notas del alumno y escriba su nota final.*/

#include<iostream>
using namespace std;
int main(){
	float notatarea, notaexamen, notaparticipacion;
	int notaFinal;
	
	cout<<"ingrese la nota de practica: ";
	cin>>notatarea;
	cout<<"Ingrese la nota teoria: ";
	cin>>notaexamen;
	cout<<"Ingrese la nota de participacion: ";
	cin>>notaparticipacion;
	
	notatarea= notatarea* 0.30;
	notaexamen *=0.60;
	notaparticipacion *= 0.10;
	
	notaFinal = notatarea + notaexamen + notaparticipacion;
	 
	 cout<<"La nota final es: "<<notaFinal;
	return 0;
	
	
}
