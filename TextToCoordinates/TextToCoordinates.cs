using System.Collections.Generic;
using System.IO;
using System.Linq;

class TextToCoordinates
{
    static void Main()
    {
        char[][] field = new char[21][];
        int number = 0;
        List<string> coordinates = new List<string>();
        using (StreamReader reader = new StreamReader("..\\..\\playfield.txt"))
        {
            string line = string.Empty;
            while ((line = reader.ReadLine()) != null)
            {
                field[number] = line.ToCharArray();
                number++;
            }
        }
        using (StreamWriter writer = new StreamWriter("..\\..\\coordinates.txt"))
            for (int i = 0; i < field.Count(); i++)
            {
                for (int j = 0; j < field[i].Count(); j++)
                {
                    if (field[i][j] != ' ')
                    {
                        string validCoordinate = string.Format("{0} {1} {2}", field[i][j], j, i);
                        coordinates.Add(validCoordinate);
                        writer.WriteLine(validCoordinate);
                    }
                }
            }

    }
}
