namespace File_IO_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region StringReader

            string stringToRead = "This is a plain text string";
            StringReader sr = new StringReader(stringToRead);
            string filepath = "../../../NewTextFile.txt";

            string input = sr.ReadToEnd();
            Console.WriteLine(input);

            #endregion


            #region Reading Text Files

            try
            {
                // reader1 uses the close method to close the file after reading it
                // you should always release your file resources by issuing the close statement
                StreamReader reader1 = new StreamReader(filepath);
                string contents = reader1.ReadToEnd();
                reader1.Close();
                Console.WriteLine(contents);
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            #endregion

            #region Writing Text Files

            string textToWrite = "This is text that will be written to a new text file";
            try
            {
                StreamWriter writer1 = new StreamWriter(filepath);
                writer1.Write(textToWrite);
                writer1.Close();
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not not be written:");
                Console.WriteLine(e.Message);
            }

            #endregion

            #region Appending Text

            string moreText = "We will add this line of text to an existing file.";
            try
            {
                StreamWriter writer1 = File.AppendText(filepath);
                writer1.WriteLine();
                writer1.WriteLine(moreText);
                writer1.Close();
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not not be written:");
                Console.WriteLine(e.Message);
            }

            #endregion

        }
    }
}
