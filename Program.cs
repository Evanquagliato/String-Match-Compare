using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace String_Match_Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Holds the final list of strings
            string finalList = "";
            // Pull all text from the file into a list
            List<string> fileList = File.ReadAllLines("ListOfStates.txt").ToList();
            // Create a list to hold our State objects
            List<StateObj> stateList = new List<StateObj> { };

            // Loop through each line in the file to create an object and add to list
            for (int i = 0; i < fileList.Count; i++)
            {
                StateObj state = new StateObj(fileList[i]);
                stateList.Add(state);
            }

            // Ask the user a word to compare - sets to lower case and removes
            // duplicate letters to prevent checking the same letter multiple times
            string userInput = new string(Console.ReadLine().ToLower().Distinct().ToArray());

            // Loops through each object in the list and verifies if its a duplicate or not
            for (int i = 0; i < stateList.Count(); i++)
            {
                finalList += stateList[i].CompareState(userInput);
            }
            // Prints the final list of objects
            System.Console.WriteLine(finalList.Trim());
        }
    }

}