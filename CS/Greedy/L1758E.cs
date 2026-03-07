// 1758. Minimum Changes To Make Alternating Binary String
public class Solution {
    public int MinOperations(string s) {
        int cnt = 0;
        for (int i = 0; i < s.Length; i++) {
            // when i is even '0',  odd '1'
            char b = (i % 2 == 0) ? '0' : '1';
            if (s[i] != b) {
                cnt++;
            }
        }
        return Math.Min(cnt, s.Length - cnt);
    }
}

/*
You are given a string s consisting only of the characters '0' and '1'. In one operation, you can change any '0' to '1' or vice versa.

The string is called alternating if no two adjacent characters are equal. For example, the string "010" is alternating, while the string "0100" is not.

Return the minimum number of operations needed to make s alternating.
*/