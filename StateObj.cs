using System;
using System.Linq;

namespace String_Match_Compare
{
    public class StateObj
    {
        // Properties
        // Display name
        public string Name { get; set; }
        // Name with duplicate letters eliminated
        private string TrimName;
        // Constructor 
        public StateObj(string name)
        {
            // Holds a display name
            this.Name = name;
            // Strip extra characters from the input for quicker looping
            this.TrimName = new string(name.ToLower().Distinct().ToArray());
        }

        public string CompareState(string userInput)
        {
            // Splits the letters of the words
            char[] state = TrimName.ToCharArray();
            char[] input = userInput.ToCharArray();

            // Compare the letters of each word to one another.
            for (int i = 0; i < state.Count(); i++)
            {
                for (int j = 0; j < input.Count(); j++)
                {
                    if (state[i] == input[j])
                    {
                        return "";
                    }
                }
            }
            return Name + ", ";
        }
    }
}