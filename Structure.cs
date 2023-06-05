using System.Globalization;
using System;
namespace Structure

{
    public struct Cage
    {

        public int CageNumber{get;set;}    
        public string  NameOfAnimal{get;set;}

        public Cage(int number, string name)
        {
            
            NameOfAnimal = name;
            CageNumber = number;
        }
        
        
        public void PrintCage()
        {
            Console.WriteLine($"NameOfAnimal:{ NameOfAnimal} The CageNumber {CageNumber}");
        }
    
        

       
    }
}