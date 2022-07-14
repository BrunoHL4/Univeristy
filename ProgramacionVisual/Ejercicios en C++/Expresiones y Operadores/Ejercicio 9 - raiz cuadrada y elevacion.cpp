/*9. Realice un programa que calcule el valor que toma la siguiente función para 
unos valores dados de x e y: f(x,y) = sqrt(x) / (pow(y,2)-1)*/

#include<iostream>
#include<math.h>

using namespace std;

int main(){
	float x,raiz,potencia = 0;
	
	cout<<"Digite el valor de x: "; cin>>x;
		
	raiz = sqrt(x);
	potencia=(pow(x,2));
	
	cout<<"La raiz es: "<<raiz<<endl;
	cout<<"La potencia es: "<<potencia;
	
	return 0;
}
