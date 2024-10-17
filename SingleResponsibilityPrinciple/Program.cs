namespace SingleResponsibilityPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Responsibility Principle(SCP): A class should have only one responsibility," +
                " and that responsibility should cover all functions of the class.");
        }
    }
    public class Report_Correct
    {
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public class ReportPrinter
    {
        public void Print(Report_Correct report)
        {
            // print code
        }
    }

    public class ReportSaver
    {
        public void Save(Report_Correct report)
        {
            // code save to database
        }
    }

    // Report_Correct class only stores the report data, ReportPrinter does the printing process,
    // and ReportSaver does the saving process. Each class has only one responsibility.
}
