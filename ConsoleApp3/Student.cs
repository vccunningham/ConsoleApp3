using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3 {
    class Student {

        public int Id;
        public string Firstname;
        public string Lastname;
        public double GPA;
        public int SAT;
        public Major Major;
        

        // constructor
        public Student(int id, string firstname, string lastname, double gpa, int sat, Major majorid) {

            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            GPA = gpa;
            SAT = sat;
            Major = majorid;
            }
        public void Print() {
            Console.WriteLine($"Id = {Id}, Name= {Firstname} {Lastname}, GPA = {GPA}, SAT = {SAT}, Major = {Major.Description}, MinSat Required = {Major.MinSat}");

            }

            }
    }
