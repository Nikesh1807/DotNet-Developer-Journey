using StudentManagementSystem.Services;

System.Console.WriteLine("=========================");
System.Console.WriteLine("  Student Management System    ");
System.Console.WriteLine("=========================");

System.Console.WriteLine("Welcome to Student Management System!");
System.Console.WriteLine("Manage your students records easily");


bool isRunning = true;
StudentServices studentServices = new StudentServices();
while(isRunning){
System.Console.WriteLine("\n===========Main Menu=============");
System.Console.WriteLine("1. Add Students");
System.Console.WriteLine("2. View All Students");
System.Console.WriteLine("3. Search Student");
System.Console.WriteLine("4. Update Student");
System.Console.WriteLine("5. Delete Student");
System.Console.WriteLine("6. Search By Course");
System.Console.WriteLine("7. Calculate Average Marks");
System.Console.WriteLine("8. Exit");

System.Console.Write("\nEnter your choice:-");
string choice = System.Console.ReadLine();

switch(choice){
    
    case "1":
    studentServices.AddStudent();
    break;

    case "2":
    studentServices.ViewAllStudents();
    break;

    case "3":
    studentServices.SearchStudent();
    break;

    case "4":
    studentServices.UpdateStudents();
    break;

    case "5":
    studentServices.DeleteStudents();
    break;

    case "6":
    studentServices.SearchByCourse();
    break;

    case "7":
    studentServices.CalculateAverageMarks();
    break;

    case "8":
    System.Console.WriteLine("Thank you for using student management system");
    isRunning = false;
    break;

    default:
    System.Console.WriteLine("Invalid Choice! please select between 1 to 8");
    break;
}
}