namespace classOOP
{
    public class TAReport
    {
        private TA[] myTas;

        public TAReport(TA[] myTas)
        {
            this.myTas = myTas;
        }


        public void printAllTAs()
        {
            for(int i = 0; i < TA.GetCount(); i++)
            {
                System.Console.WriteLine(myTas[i].ToString());
            }
        }

        public void AvgGpa()
        {
            double sum = 0.0;
            for(int i = 0; i < TA.GetCount; i++)
            {
                sum += myTas[I].GetGpa();
            }
            System.Console.WriteLine($"The average GPA is: {sum/TA.Getcount}");
        }
    }
}