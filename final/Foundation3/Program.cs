using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("Avenida Guayaquil y Francisco Pachecho", "Portoviejo", "Manabi", "1990-365", "Ecuador");
        string lectureAddress = address1.GetAddress();
        Lectures lecture = new Lectures("Stake Conference", "Church meeting with members of the Portoviejo Stake.", "June 5, 2024", "10:00 am - 12:00 pm", $"{lectureAddress}", "Lecture", "Elder Pozo", 400);

        //display lecture event details
        Console.WriteLine("______________________________________________________________________________");
        lecture.DisplayShortDescription();
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayLectureFullDetails();


        Address address2 = new Address ("640 w 86", "Manhattan", "NYC", "2700-144", "USA");
        string receptionAddress = address2.GetAddress();
        Receptions reception = new Receptions("Sandy and Jimena", "Sandy and Jimena's wedding ceremony and reception", "September 5, 2024", "5:00 pm - 12:00am", $"{receptionAddress}", "Reception", "dancar@gmail.com");
        //display reception event details
        Console.WriteLine("_______________________________________________________________________________");
        reception.DisplayShortDescription();
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayReceptionsFullDetails();


        Address address3 = new Address ("Pedro Gual 1 de octubre", "Bosa", "Bogota", "43017", "Colombia");
        string outdoorAddress = address3.GetAddress();
        Outdoor outdoor = new Outdoor("Jumping", "Jumping at the park for all youth.", "July 24, 2024", "7:00 pm", $"{outdoorAddress}", "Outdoor", "Night");
        //display outdoor event details
        Console.WriteLine("_______________________________________________________________________________");
        
        outdoor.DisplayShortDescription();
        Console.WriteLine();
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.DisplayOutdoorFullDetails();
        Console.WriteLine("_______________________________________________________________________________");
        
    }
}