#include <iostream>
#include <string>
#include <vector>

using namespace std;

double solution(vector<int> arr);
int main() {
    
    vector<int> arr = { 1,2,3,4 };
    cout << solution(arr);
	return 0;
}
double solution(vector<int> arr) {
    double sum = 0;
    for(int num : arr)
        sum += num;
    double answer = sum / arr.size();
    return answer;
}