namespace  EmployeeWageComputation
{
    internal class Program
    {
        final int PART_TIME = 1;
        final int FULL_TIME = 2;
        final int WAGE_PER_HR = 20;
        int empType = (int)(Math.random() * 100) % 3;
        int workingHours = 0;
        switch (empType)
        {
            case FULL_TIME:
                System.out.println("Employee is Present Full time");
        workingHours = 8;
                break;
            case PART_TIME:
                  Console.writeLine("Employee is Present Part time");
        workingHours = 4;
                break;
            default:
                 Console.writeLine("Employee is Absent");
    }
    int wage = workingHours * WAGE_PER_HR;
  Console.writeLine("Employee Daily Wage is " + wage);
}
}


