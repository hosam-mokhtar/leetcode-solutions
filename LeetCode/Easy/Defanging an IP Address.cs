Link: https://leetcode.com/problems/defanging-an-ip-address/
Language: C#


public class Solution {
public string DefangIPaddr(string address)  {       
         return address.Replace(".","[.]");
        }
}