
int i=0,j;
char palvra [20]

     print (Digite a palavra: );
     scanf ("%s", palavra);
     j=0;
     
     while (palavra [i]1='10'){
     j++;
     }
j=j-i
while (palavra [i]!='10'){
      if (palavra [i]!=palvra[j]){
      palindroma=0;
      }
      i++;
      J--;
      }
if (palindroma){
                printf ("palavra palindroma");
}else{
      printf ("não palindroma");
      }
