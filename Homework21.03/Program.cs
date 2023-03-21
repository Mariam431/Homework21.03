using static Homework21._03.Expences;
namespace Homework21._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Expences expences = new Expences(); //class instance
            ExDelegat exDelegat = new ExDelegat(expences.mortgage); //Delegat instance
            exDelegat += expences.oil;
            exDelegat += expences.komunal;
            exDelegat += expences.vark2;
            exDelegat += expences.chnaxatesvac;
            exDelegat += expences.snund;
            exDelegat += expences.biznesVark;
            exDelegat += expences.ITcaxser;
            exDelegat(100000);










        }
    }
}