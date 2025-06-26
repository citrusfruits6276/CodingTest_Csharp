using System;

public class Solution {
    public int solution(int[] numbers) {
        Array.Sort(numbers);
        int n = numbers.Length;
        int answer = numbers[n-1] * numbers[n-2];
        return answer;
    }
}