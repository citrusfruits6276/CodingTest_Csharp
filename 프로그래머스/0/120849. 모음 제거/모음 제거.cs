using System;

public class Solution {
    public string solution(string my_string) {
        string[] vewols = new string[] {"a", "e", "i", "o", "u"};
        foreach(string c in vewols){
            my_string = my_string.Replace(c, "");
        }
        return my_string;
    }
}