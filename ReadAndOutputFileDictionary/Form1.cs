using System.Text;

namespace ReadAndOutputFileDictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "Marina`s File.txt";
            string filePath = CreateFileWithContent(fileName);

            if (filePath != null)
            {
                Dictionary<char, int> characterCounts = CountCharactersInFile(filePath);

                if (characterCounts != null)
                {
                    DisplayCharacterCounts(characterCounts);
                }
            }
        }
        //method to create a file
        private string CreateFileWithContent(string fileName)
        {
            try
            {
                // Combine the current working directory with the specified file name to get the full file path
                string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

                // Define the content to be written to the file
                string content = "In C#, dictionaries are a fundamental data structure used for storing and retrieving key-value pairs efficiently. These key-value pairs are organized in such a way that they provide rapid access to the associated values based on their unique keys. Dictionaries in C# are part of the System.Collections.Generic namespace and offer a versatile way to manage data. You can use them to store various types of data, ranging from simple data types to complex objects. This makes dictionaries a valuable tool for tasks like caching, indexing, and managing configuration settings within C# applications. Overall, C# dictionaries simplify the process of mapping keys to values and are an essential component of many C# programs.";

                // Convert the content to bytes using UTF-8 encoding when you write this content to a file, you need to represent it as a sequence of bytes because files store data in binary format.
                byte[] contentBytes = Encoding.UTF8.GetBytes(content);

                // Create a new file at the specified file path and open it for writing (File.Create creates or overwrites the file)
                using (FileStream fs = File.Create(filePath))
                {
                    // Write the content bytes to the file
                    fs.Write(contentBytes, 0, contentBytes.Length);
                }

                // Set the text of textBox1 to the file name without its extension
                textBox1.Text = Path.GetFileNameWithoutExtension(fileName);

                // Return the full file path where the file was created
                return filePath;
            }
            //handle an exception
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating the file: {ex.Message}");
                return null;
            }
        }

        // Define a method named CountCharactersInFile that takes a file path as input and returns a dictionary
        private Dictionary<char, int> CountCharactersInFile(string filePath)
        {
            try
            {    //Create a new dictionary to store character counts
                Dictionary<char, int> characterCounts = new Dictionary<char, int>();

                // Open a stream reader to read the content of the file at the specified filePath
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Continue reading characters from the file until the end of the stream is reached
                    while (!reader.EndOfStream)
                    {
                        // Read a character from the file and store it in the 'character' variable
                        char character = (char)reader.Read();

                        // Check if the character is already a key in the dictionary
                        if (characterCounts.ContainsKey(character))
                        {
                            // If the character is already in the dictionary, increment its count by 1
                            characterCounts[character]++;
                        }
                        else
                        {
                            // If the character is not in the dictionary, add it as a key with a count of 1
                            characterCounts[character] = 1;
                        }
                    }
                }

                // Return the dictionary containing character counts
                return characterCounts;
            } //exception handle
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}");
                return null;
            }
        }

        //display character method
        private void DisplayCharacterCounts(Dictionary<char, int> characterCounts)
        {
            var sortedCharacterCounts = characterCounts
                .OrderBy(kvp => kvp.Key);

            foreach (var kvp in sortedCharacterCounts)
            {
                listBox1.Items.Add($"Char: '{kvp.Key}' || {kvp.Value}");
            }
        }


        // Handle the button click event to generate a file and count characters
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the file path entered by the user from the TextBox
                string filePath = textBox2.Text;


                // Extract the file name without extension
                string fileName = ExtractFileName(filePath);


                // Extract the file name without extension
                string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);



                // Check if the file name is empty or if an error occurred
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("File does not exist or an error occurred.");
                    return;
                }


                // Display the file name without extension in a TextBox
                textBox3.Text = fileNameWithoutExtension;


                // Count the characters in the file and store the counts in a dictionary
                Dictionary<char, int> characterCounts = CountCharacters(filePath);

                // Display the character counts in the second ListBox by method
                DisplayCharacterCounts2(characterCounts);
            }// error handle
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        // Extract the file name from a file path, returns null if the file does not exist
        private string ExtractFileName(string filePath)
        {
            // Check if the file exists
            if (!File.Exists(filePath))
            {
                return null; // File does not exist
            }

            // Extract and return the file name from the file path
            return Path.GetFileName(filePath);
        }


        // Count the characters in a file and return the counts as a dictionary
        private Dictionary<char, int> CountCharacters(string filePath)
        {
            // Create a dictionary to store character counts
            Dictionary<char, int> characterCounts = new Dictionary<char, int>();


            // Open a stream reader to read the content of the file at the specified filePath
            using (StreamReader reader = new StreamReader(filePath))
            {

                // Continue reading characters from the file until the end of the stream is reached
                while (!reader.EndOfStream)
                {
                    char character = (char)reader.Read();


                    // Check if the character is already in the dictionary
                    if (characterCounts.ContainsKey(character))
                    {
                        //if yes incriment
                        characterCounts[character]++;
                    }
                    else
                    {
                        //if no add it with a count of one
                        characterCounts[character] = 1;
                    }
                }
            }

            //// Return the dictionary containing character counts
            return characterCounts;
        }

        // Define a method to display character counts in alphabetical order
        private void DisplayCharacterCounts2(Dictionary<char, int> characterCounts)
        {
            // Use LINQ to sort character counts by character key in ascending order
            var sortedCharacterCounts = characterCounts.OrderBy(kvp => kvp.Key);

            // Clear the items in the first ListBox before adding new items
            listBox2.Items.Clear();

            // Iterate through the sorted character counts and add them to the first ListBox
            foreach (var kvp in sortedCharacterCounts)
            {
                listBox2.Items.Add($"Char: '{kvp.Key}' || {kvp.Value}");
            }
        }


    }
}







