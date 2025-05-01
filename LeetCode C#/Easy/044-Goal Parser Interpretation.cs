Link: https://leetcode.com/problems/goal-parser-interpretation/
Language: C#



public class Solution {
public string Interpret(string command) {
            StringBuilder sb = new StringBuilder(); 
            for (int i = 0; i < command.Length; i++) {
                if (command[i]=='G'|| command[i] == 'a'|| command[i]=='l')
                    sb.Append(command[i]);
                if (i<command.Length-1 && command[i] == '(' && command[i + 1] == ')')
                        {sb.Append('o');
                        i++;}
            }
            return sb.ToString();
            // return command.Replace("()", "o").Replace("(al)", "al");
        }
}