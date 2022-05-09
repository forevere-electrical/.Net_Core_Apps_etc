using System.Collections.Generic;

namespace consoleAppHello
{
    public class Book 
    {
        // define a local field grade of List<double> type
        private List<double> grades;
        private string name;
        public Book(string name){
            this.name = name;
            this.grades=new List<double>();
        }
        
        // add a value to grades list
        public void AddGrade(double num){
            grades.Add(num);
        } 
        //get highest, lowest, average grade in the list
        public void ShowStatistics(){
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (var item in grades)
            {
                result += item;
                if(item>highGrade) highGrade=item;
                if(item<lowGrade) lowGrade=item;
            }

            result /= grades.Count;
            
            System.Console.WriteLine($"The average grade is {result:n2}");
            System.Console.WriteLine($"Highest grade is {highGrade}");
            System.Console.WriteLine($"Lowest grade is {lowGrade}");
        }        
    }
}
