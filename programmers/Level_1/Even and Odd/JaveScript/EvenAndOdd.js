console.log(`${solution(3)}\n ${solution(4)}`);

function solution(num) {
    var answer = '';
    if(num %2 == 0){
            answer = "Even";
        }else{
            answer = "Odd";
        }
    return answer;
}