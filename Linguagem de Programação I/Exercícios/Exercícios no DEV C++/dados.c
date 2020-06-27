int main(){

FILE *entrada, *saida;
entrada=fopen("C:\\temp\\dados.txt", "")
if (entrada==NULL){
	printf ("erro na abertura do arquivo");
	exit (1);
}

Saida=fopen("copia text", "w");

if (saida==NULL){
	printf ("erro na criaçao do arquivo");
	exit(1);
}

while (!feof(entrada)){
ch=fgetc(entrada);
printf(ch, saida);

}
flose(entrada);
flose(saida);





8

}
