#include <iostream>

using namespace std;

string solution(int num);

int main()
{
    cout<<solution(3)<<"\n"<< solution(4);
}

string solution(int num) {
    string answer = "";
    if (num % 2 == 0) {
        answer = "Even";
    }
    else {
        answer = "Odd";
    }
    return answer;
}