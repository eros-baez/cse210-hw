/*
Eros Baez
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Learning C#", "John", 300);
        v1.AddComment(new Comment("Ana", "Very helpful!"));
        v1.AddComment(new Comment("Luis", "Good explanation"));
        v1.AddComment(new Comment("Maria", "Thanks!"));

        Video v2 = new Video("OOP Basics", "Carlos", 450);
        v2.AddComment(new Comment("Pedro", "Nice video"));
        v2.AddComment(new Comment("Sofia", "I learned a lot"));
        v2.AddComment(new Comment("Lucas", "Clear and simple"));

        Video v3 = new Video("Data Structures", "Laura", 600);
        v3.AddComment(new Comment("Diego", "Great content"));
        v3.AddComment(new Comment("Elena", "Very useful"));
        v3.AddComment(new Comment("Martin", "Well explained"));

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video v in videos)
        {
            v.Display();
        }
    }
}