#include <stdio.h>

using namespace std;



int main()
{
    int N;
    int n;
    cin >> N;
    cin.ignore(numeric_limits<streamsize>::max(), '\n');
    if(n%2==1)
    {
        cout<<"Weird"<<endl;
    }
    for(n=2;n<=5;n++)
    if (n%2==0)
    {
    cout<<"Not Weird"<<endl;
    }
    for(n=6;n<=20;n++)
    if (n%2==0)
    {
    cout<<"Weird"<<endl;
    }
    else
    {
        cout<<"Not Weird"<endl;
    }
    

    return 0;
}
