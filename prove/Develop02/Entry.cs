using System;
using System.Collections.Generic;

public class Entry
{
   List<string> promts = new List<string>(){
      "What is your favorite color?", 
      "What is your favorite movie?", 
      "What is your favorite animal?",
      "What is your favorite food?",
      "What is your favorite place to vacation?"
   };
   public string getPrompt() {
      Random random = new Random();
      return promts.ElementAt(random.Next(0, promts.Count));
   }

   public string date() {
      DateTime date = DateTime.Now;
      return date.ToString("MM/dd/yyyy");
   }
}