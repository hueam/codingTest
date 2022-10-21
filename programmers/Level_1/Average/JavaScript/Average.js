console.log(solution([1,2,3,4]));

function solution(arr) {
    var sum = 0;
    arr.forEach(num => {
        sum += num;
    });
    var answer = sum / arr.length;
    return answer;
}