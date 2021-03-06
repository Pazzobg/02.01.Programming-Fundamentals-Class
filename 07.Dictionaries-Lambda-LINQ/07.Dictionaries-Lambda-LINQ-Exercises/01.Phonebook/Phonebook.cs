﻿namespace _01.Phonebook
{
    using System;
    using System.Collections.Generic;

    public class Phonebook
    {
        public static void Main()
        {
            var phonebook = new SortedDictionary<string, string>();

            string[] input = Console.ReadLine().Split(' ');

            while (input[0] != "END")
            {
                string command = input[0];

                switch (command)
                {
                    case "A": AddNumberToPhonebook(input, phonebook); break;
                    case "S": SearchNumberInPhonebook(input, phonebook); break;
                }

                input = Console.ReadLine().Split(' ');
            }
        }

        public static void AddNumberToPhonebook(string[] input, SortedDictionary<string, string> phonebook)
        {
            string name = input[1];
            string number = input[2];

            if (!phonebook.ContainsKey(name))
            {
                phonebook[name] = string.Empty;
            }

            phonebook[name] = number;
        }

        public static void SearchNumberInPhonebook(string[] input, SortedDictionary<string, string> phonebook)
        {
            string name = input[1];

            Console.WriteLine(
                phonebook.ContainsKey(name) ? $"{name} -> {phonebook[name]}" : $"Contact {name} does not exist.");
        }
    }
}
