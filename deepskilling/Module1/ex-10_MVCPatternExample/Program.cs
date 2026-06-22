Student student =
    new Student("Subramanyam", 101, "A");

StudentView view = new StudentView();

StudentController controller =
    new StudentController(student, view);

Console.WriteLine("Initial Details:");
controller.UpdateView();

controller.SetStudentName("Gnana");
controller.SetStudentGrade("A+");

Console.WriteLine("\nUpdated Details:");
controller.UpdateView();