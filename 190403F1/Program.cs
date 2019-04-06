using System;
using System.Collections.Generic;

namespace _190403F1
{
    internal static class Program
    {
        #region Private Methods

        private static double MerTaniKozep(double a, double b)
        {
            return Math.Sqrt(a * b);
        }
        private static double SzamTaniKozep(double a, double b)
        {
            return (a + b) / 2;
        }

        #endregion Private Methods

        #region Private Fields

        private static readonly Dictionary<char, Func<double, double, double>> dictionary = new Dictionary<char, Func<double, double, double>>();

        #endregion Private Fields

        #region Private Methods

        private static void Main(string[] args)
        {
            dictionary.Add('s', SzamTaniKozep);
            dictionary.Add('m', SzamTaniKozep);
            double szam1 = AdatBekeres.EllenorzottBekeres<double>("Add meg a számot!");
            double szam2 = AdatBekeres.EllenorzottBekeres<double>("Add meg a számot!");
            string input = "Ha számtani közepet szeretnél akkor az ENTER előtt nyomd meg az s billentyűt\n" +
                "Ha számtani közepet szeretnél akkor az ENTER előtt nyomd meg az m billentyűt";
            char ch = AdatBekeres.EllenorzottBekeres(dictionary.ContainsKey, input);
            dictionary.TryGetValue(ch, out Func<double, double, double> func);
            Console.WriteLine(func(szam1, szam2));
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        #endregion Private Methods
    }
}
