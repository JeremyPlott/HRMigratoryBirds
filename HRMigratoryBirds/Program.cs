using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace HRMigratoryBirds {
    class Program {
        static void Main(string[] args) {

            List<int> arr = new List<int> { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4, 3, 4 };
            // should output 3

            Dictionary<int, int> sightings = new Dictionary<int, int>();

            foreach(var i in arr) {
                if(!sightings.ContainsKey(i)) {
                    sightings.Add(i, 1);
                } else {
                    sightings[i]++;
                }
            }
            //foreach(var s in sightings) {
            //    Console.WriteLine(s);
            //}
            int most = sightings.Values.Max();
            var bird = sightings.Where(b => b.Value == most).Min(b => b.Key);

            Console.WriteLine(bird);
        }
    }
}
