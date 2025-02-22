Link: https://leetcode.com/problems/convert-the-temperature/
Language: C#



public class Solution {
           public double[] ConvertTemperature(double celsius)
        {
            double kelvin = celsius + 273.15;
            double fahrenheit = celsius * 1.80 + 32.00;
            double[]ConvertTemperature=new double[2];
            //ConvertTemperature[0]=kelvin;
            //ConvertTemperature[1] = fahrenheit;
            //return ConvertTemperature;
            return new double[] {kelvin,fahrenheit};
        }
}