using System.IO;
namespace classOOP
{
    public class TAFileHandler
    {
        private string FileName;


        public TAFileHandler(string fileName)
        {
            this.FileName = fileName;
        }

        public TA[] GetAllTAs()
        {
            TA[] myTas = new TA[50];
            StreamReader inFile = new StreamReader("input.txt");
            string line = inFile.ReadLine();
            TA.SetCount(0);
            while(line != null)
            {
                
                string[] temp = line.Split("#");
                myTas[TA.GetCount] = new TA(temp[0], double.Parse(temp));
                TA.IncCount();
                line = inFile.ReadLine();
            }

            inFile.Close();
            
            return myTas;
        }
    }
}