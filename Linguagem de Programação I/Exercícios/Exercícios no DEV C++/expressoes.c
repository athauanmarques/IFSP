int main(){
    int i=1,j=2,k=3,n=2;
    float x=3.3,y=4.4;
    
    printf("a. %i",i<j+3);
    printf("\nb. %i",2*i-7<=j-8);
    printf("\nc. %i",-x+y>=2.0*y);
    printf("\nd. %i",x==y);
    printf("\ne. %i",x!=y);
    printf("\nf. %i",i+j+k==-2*-k);
    printf("\ng. %i",!(n-j));
    printf("\nh. %i",!n-j);
    printf("\ni. %i",!x*!x);
    printf("\nj. %i",i&&j&&k);
    printf("\nk. %i",i||j-3&&0);
    printf("\nl. %i",i<j&&2>=k);
    printf("\nm. %i",i<j||2>=k);
    printf("\nn. %i",i==2||j==4||k==5);
    printf("\no. %i",i=2||j==4||k==5);
    printf("\np. %i",x<=5&&x!=1.0||i>j);
    
    getch();
    return 0;
}
