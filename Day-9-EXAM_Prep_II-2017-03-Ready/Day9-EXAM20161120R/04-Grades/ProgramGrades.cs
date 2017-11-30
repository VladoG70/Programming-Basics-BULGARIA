using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Grades
    {
    class ProgramGrades
        {
        static void Main(string[] args)
            {
            int studentsNumber = int.Parse(Console.ReadLine());
            double grade = 0.00;
            int gradeTop = 0, grade4 = 0, grade3 = 0, grade2 = 0;
            double averageGrade = 0.00;

            for (int i = 0; i < studentsNumber; i++)
                {
                grade = double.Parse(Console.ReadLine());
                averageGrade += grade;
                if (grade < 3.00)
                    {
                    grade2++;
                    }
                else
                    {
                    if (grade >= 3.00 && grade < 4.00)
                        {
                        grade3++;
                        }
                    else
                        {
                        if (grade >= 4.00 && grade < 5.00)
                            {
                            grade4++;
                            }
                        else
                            {
                            gradeTop++;
                            }
                        }
                    }
                } // End for

            Console.WriteLine("Top students: {0:F2}%", (gradeTop / (double)studentsNumber) * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", (grade4 / (double)studentsNumber) * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", (grade3 / (double)studentsNumber) * 100);
            Console.WriteLine("Fail: {0:F2}%", (grade2 / (double)studentsNumber) * 100);
            Console.WriteLine("Average: {0:F2}", (averageGrade / (double)studentsNumber));

            }
        }
    }
