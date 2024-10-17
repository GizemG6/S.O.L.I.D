namespace InterfaceSegregationPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface Segregation Principle(ISP): " +
                "A class should not depend on interfaces that contain methods that it does not use.");
        }

        // RobotWorker_Wrong class can not use the Eat method,
        // in this case the Worker interface is not suitable for extension and the interfaces must be separated.
        public class HumanWorker_Wrong : IWorkerWrong
        {
            public void Work()
            {
                // work code
            }

            public void Eat()
            {
                // eat code
            }
        }

        public class RobotWorker_Wrong : IWorkerWrong
        {
            public void Work()
            {
                // work code
            }

            public void Eat()
            {
                // Wrong!!! The robot can't eat
            }
        }

        // HumanWorker_Correct and RobotWorker_Correct implement different interfaces
        // and implement only the relevant methods, which provides interface separation.

        public class HumanWorker_Correct : IWorkerCorrect, IEater
        {
            public void Work()
            {
                // work code
            }

            public void Eat()
            {
                // eat code
            }
        }

        public class RobotWorker_Correct : IWorkerCorrect
        {
            public void Work()
            {
                // work code
            }
        }
    }
}
