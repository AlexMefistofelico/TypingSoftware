#include<bits/stdc++.h>

using namespace std;
/**
    @AlexAriel
    Monday
    2021-12-06-14.17.59
    NOTAS.-
asad
*/


[[maybe_unused]] int main(int argc,char *argv[],char **env) try {
    //Key 	Codigo
    // + 	SHIFT
    // ^ 	CTRL
    // % 	ALT
    // ´i   í
    // """  "+2"
    freopen("in.txt","r",stdin);
    freopen("leccion.vbs","w",stdout);
    char c;
    int ml;
    scanf("%d",&ml);

    puts("set wshshell = wscript.createobject(\"wscript.shell\")");
    puts("wscript.sleep(3000)");
    getchar();//para eliminar el "\n" de buffer


    while((c=getchar())!=EOF){
        if(c=='\n'){
            printf("wshshell.sendkeys \"{ENTER}\"\n");
        }else{
            printf("wshshell.sendkeys \"%c\"\n",c);
        }
        printf("wscript.sleep(%d)\n",ml);
    }

    return EXIT_SUCCESS;
}catch(exception& e){
    cerr<<"ERROR...!!!: "<<endl<<e.what()<<endl;
    return EXIT_FAILURE;
}
