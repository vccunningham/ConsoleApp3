using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3 {//==================================
    class Major {//====================================

        public int Id;
        public string Description;
        public int MinSat;

       
        // constructor
        public Major(int majorId, string description, int minSat) {
       
                Id = majorId;
                Description = description;
                MinSat = minSat;
        } public void Print() {
            Console.WriteLine($"Id = {Id}, Desc= {Description}, Min = {MinSat}");
            }
    }// class===============================================
        }// namespace=========================================
