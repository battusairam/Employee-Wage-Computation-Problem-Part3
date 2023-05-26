namespace EmployeeWageComputation
{
    internal class Program
    {
        final int PART_TIME = 1;
        final int FULL_TIME = 2;
        final int WAGE_PER_HR = 20;
        final int MAX_WORKING_DAYS = 20;
        final int MAX_WORKING_HRS = 100;

        int totalWage = 0;
        int workingHrs = 0;
        Console.WriteLine("%5s     %5s     %5s     %5s\n", "Day", "Workinghrs", "Wage", "Total working hrs");
        for (int day = 1, totalWorkingHrs = 0; day <= MAX_WORKING_DAYS
                && totalWorkingHrs<MAX_WORKING_HRS; day++, totalWorkingHrs += workingHrs)
        {

            int empType = (int)(Math.random() * 100) % 3;
            switch (empType)
            {
            case FULL_TIME:
                workingHrs = 8;
                break;
            case PART_TIME:
                workingHrs = 4;
                break;
            default:
                workingHrs = 0;
                break;
            }
    int wage = workingHrs * WAGE_PER_HR;
    totalWage += wage;
     Console.WriteLine("%5d       %5d      %5d      %5d\n", day, workingHrs, wage, totalWorkingHrs + workingHrs);

}
Console.WriteLine"Total wage for a month is " + totalWage);
    }

    public static void main(String args[])
{
    calculateTotalWage();
}
}
