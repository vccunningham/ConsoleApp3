using System;

namespace ConsoleApp3 {
    class Program {
        static void Main(string[] args) {

            var majors = new Major[] {
                new Major(100, "Accounting", 1000),
                new Major(200, "Business", 1000),
                new Major(300, "Engineering", 1200),
                new Major(400, "Mathematics", 1300),
                new Major(500, "Education", 1100)

                };
            //majors[0] = accounting;
            //majors[1] = business;
            //majors[2] = engineering;
            //majors[3] = mathematics;
            
            for(var idx = 0; idx < majors.Length; idx++) {
                var major = majors[idx];
                major.Print();
                }

            var students = new Student[] { 
                new Student(1, "Vaughn", "Cunningham", 3.2, 1500, majors[0]),
                new Student(2, "Chris", "Mullens", 3.5, 1500, majors[2]),
                new Student(3, "Shawn", "John", 3.4, 1400, majors[1]),
                new Student(4, "Fred", "Flinstone", 1.0, 1000, majors[1])

                
                };

            foreach (var student in students) {
                student.Print();
                }

            //accounting.Print();
            //business.Print();
            //engineering.Print();

            //vaughn.Print();
            //chris.Print();
            //shawn.Print();
            //fred.Print();
        }
        }
    }
