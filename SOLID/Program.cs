using System;
using System.Threading.Tasks;
using SingleResponsibilityPrinciple;
using OpenClosedPrinciple;
using LiskovSubstitutionPrinciple;
using InterfaceSegregationPrinciple;
using DependencyInversionPrinciple;

namespace SOLID
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var singleResponsibilityPrinciple = new SingleResponsibilityPrinciple.Run();
            singleResponsibilityPrinciple.Print();

            var openClosedPrinciple = new OpenClosedPrinciple.Run();
            openClosedPrinciple.Print();

            var liskovSubstitutionPrinciple = new LiskovSubstitutionPrinciple.Run();
            liskovSubstitutionPrinciple.Print();

            var interfaceSegregationPrinciple = new InterfaceSegregationPrinciple.Run();
            interfaceSegregationPrinciple.Print();

            var dependencyInversionPrinciple = new DependencyInversionPrinciple.Run();
            dependencyInversionPrinciple.Print();
        }
    }
}
