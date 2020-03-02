using System;
using System.Collections.Generic;

namespace heist {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Plan Your Heist!");

            Dictionary<string, string> teamMember = new Dictionary<string, string> ();

            Console.Write ("What is the member's name? ");
            string name = Console.ReadLine ();

            Console.Write ("What is the member's skill level? ");
            string skill = Console.ReadLine ();

            Console.Write ("What is the member's courage factor? ");
            string courage = Console.ReadLine ();

            teamMember.Add ("Name", name);
            teamMember.Add ("Skill Level", skill);
            teamMember.Add ("Courage", courage);

            Console.Clear ();
            foreach (KeyValuePair<string, string> attribute in teamMember)
                (
                    Console.WriteLine ($"{attribute.Key}: {attribute.Value}")
                )

        }
    }
}