namespace EmployeeWageComputationProblem;
class Employee is Present or Absent
   {
public static void main(String args[])
    {
        System.out.println("Welcome to Employee Wage Computation in Java");
        final int FULL_TIME = 1;
        int empType = (int) (Math.random() * 100) % 2;
        if (empType == FULL_TIME)
        {
            System.out.println("Employee is Present");

        } else
        {
            System.out.println("Employee is Absent");

        }
    }
}
