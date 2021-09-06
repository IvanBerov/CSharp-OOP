namespace P04.Recharge
{
    using System;

    class Program
    {
        static void Main()
        {
            var robot = new Robot("ABC", 20);
            var employee = new Employee("Cat8989");

            IRechargeable rechargeable = new Robot("889988", 500);
            ISleeper sleeper = new Employee("GT600");

            robot.Recharge();
            employee.Sleep();
            rechargeable.Recharge();
            sleeper.Sleep();
        }
    }
}
