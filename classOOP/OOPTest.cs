namespace classOOP
{
    public class TA
    {
        private string name;
        private double gpa;
        private string className;

        static private int count;


        public TA()
        {

        }

        public TA(string name, double gpa, string className)
        {
            this.name = name;
            this.gpa = gpa;
            this.className = className;
        }

        public string getName()
        {
            return name;
        }

        public void SetName(string temp)
        {
            name = temp;
        }

        public string getGpa()
        {
            return gpa;
        }

        public void SetGpa(string temp)
        {
            gpa = temp;
        }

        public string getClassName()
        {
            return ClassName;
        }

        public void SetClassName(string temp)
        {
            ClassName = temp;
        }

        public static void SetCount()
        {
            count = temp;
        }

        public static int GetCount()
        {
            return count;
        }

        public string ToString()
        {
            return
        }

        public static void IncCount()
        {
            count++;
        }


    }
}