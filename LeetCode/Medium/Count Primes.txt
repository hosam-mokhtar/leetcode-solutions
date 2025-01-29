Link: https://leetcode.com/problems/count-primes/description/
Language: C#


class Solution {
    public int CountPrimes(int n) {
      if (n <= 2)    return 0;
        int count = 0;
        bool[] isPrime = new bool[n];
        for (int i = 2; i < n; i++) {
            isPrime[i] = true;
            count++;
        }

        for (int i = 2; i * i < n; i++) {
            if (isPrime[i]) {
                for (int j = i * i; j < n; j += i) {
                    if(isPrime[j]==true)  count--;
                    isPrime[j] = false;
                }
            }
        }
        return count;
    }
}