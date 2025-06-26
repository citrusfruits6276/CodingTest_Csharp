using System;

public class Solution {
    public int solution(int n) {
        int answer;
        int i = (int)Math.Sqrt(n);
        if(i * i == n){
            answer = 1;
        }else{
            answer = 2;
        }
        return answer;
    }
}