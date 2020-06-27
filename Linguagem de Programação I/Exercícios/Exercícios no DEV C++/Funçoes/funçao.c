int soma(int * a, int * b){
*a=(*a)*2;
return (*a)+(*b);

}
int main (){
	int a, b, s;
	a=4;
	b=3;
	s=soma (&a, &b);
	printf ("%i+%i=%i",a,b,s);
