// Student Grades 
// Menu 
// 1 - Display All Grades 
// 2 - Display Honours 
// 3 - Stats 
// 4 = Randomize Grades 
// 5 - Exits 


// Display All Grades 
// Create an empty list of grades, get a random number in a range between 0 and 100, and loop through it 35 times 
// empty list 
var grades = new List<int>(); 
Random rnd = new Random(); 
for (int i = 0; i < 35; i++) {
    grades.Add(rnd.Next(0, 100)); 
}

// 1 - Display all Grades
Console.WriteLine("ALL GRADES");
for (int i = 0; i < grades.Count; i++) {
    Console.WriteLine(grades[i]); 
}

// 2 - Display all Honors 
Console.WriteLine("ALL HONOURS");
for (int i = 0; i < grades.Count; i++) {
    if (grades[i] > 80) {
        Console.WriteLine(grades[i]);  
    }
}
// 3 - Stats 
Console.WriteLine("Stats: Highest Grade, Lowest Grade, and Average Grade"); 
    Console.WriteLine("Max: " + grades.Max()); 
    Console.WriteLine("Min: " + grades.Min()); 
    Console.WriteLine("Average: " + grades.Average()); 
// 4 - Randomize Grades 
Console.WriteLine("Assign a each student a random grade in a range between 0 - 100"); 
for (int i = 0; i < 35; i++) {
    Console.WriteLine(rnd.Next(0, 100)); 
}
// 5 - Exit
Console.WriteLine("Goodbye");

