using System;
using System.Collections.Generic;
using System.Text;

namespace PetElevator.CRM
{
   public class Pet
    {
        string PetName { get; set; }

        string Species { get; set; }
       public List<string> Vaccinations { get; set; } = new List<string>(); //

        public Pet(string PetName, string Species) {
            this.PetName = PetName;
            this.Species = Species; 

        }
   
    public string ListVaccination() 
        {

            string[] vaccArray = new string[this.Vaccinations.Count];
            int i = 0; 
            foreach(var item in this.Vaccinations)
            {
                vaccArray[i] = item.ToString();
                i++; 
            }

            string vaccString = String.Join(", ", vaccArray);
            return vaccString; 
            //string diseaseVaccinations; //need variable to store the accumulated string values output by the ToString method
            //diseaseVaccinations
            //for (int i = 0; i < Vaccinations.Count; i++)
            //{
            //    string[] words = { "One", "Two", "Three", "Four" };
            //    string singleString = String.Join(",", words); // singleString = "One,Two,Three,Four"
            //    string help = diseaseVaccinations; 
            //    string diseaseVaccinations = $"{diseaseVaccinations}, {item.ToString()} ";           
            //}
            //foreach (string item in Vaccinations) 
            //{
            //    diseaseVaccinations =$"{diseaseVaccinations}, {item.ToString()} " ;
            //    // ToString() is method available to collections which returns string 
            //    //return null; //needs changed
                
            //}

            //return null; //this return needs changed
        }

        
    }
}
