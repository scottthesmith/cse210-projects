using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video _vid1 = new Video("Risk of Rain 2: Full playthrough", "ScottPlayzGamezzz",215);
        Video _vid2 = new Video("How to enter a new world via toilet pipes", "M. Brother", 360);
        Video _vid3 = new Video("Godzilla: Friend or Foe?", "Kai Ju", 445);

        Comment vid1Comment1 = new Comment("Billy Bramble", "Such a great game");
        Comment vid1Comment2 = new Comment("Hugh Huggum", "I really love playing as The Huntress!");
        Comment vid1Comment3 = new Comment("Vidya Gamor", "Such a hard, but fun game!");

        Comment vid2Comment1 = new Comment("Sir Bow", "Wow! I wonder if that really works!");
        Comment vid2Comment2 = new Comment("Peach Toadstool", "So many mushrooms!");
        Comment vid2Comment3 = new Comment("K. Koopa", "Plumbing is more dangerous than I realized!");

        Comment vid3Comment1 = new Comment("G. Zilla", "Seems like he's a pretty great guy!");
        Comment vid3Comment2 = new Comment("Gi Dorah", "I don't know. He seems pretty wimpy to me.");
        Comment vid3Comment3 = new Comment("Ro Dan", "I could take him.");


        _vid1.AddComment(vid1Comment1);
        _vid1.AddComment(vid1Comment2);
        _vid1.AddComment(vid1Comment3);

        _vid2.AddComment(vid2Comment1);
        _vid2.AddComment(vid2Comment2);
        _vid2.AddComment(vid2Comment3);

        _vid3.AddComment(vid3Comment1);
        _vid3.AddComment(vid3Comment2);
        _vid3.AddComment(vid3Comment3);

        List<Video> videoList = new List<Video>();
        videoList.Add(_vid1);
        videoList.Add(_vid2);
        videoList.Add(_vid3);

        foreach (Video video in videoList)
        {
            video.DisplayVideoDetails();

            Console.WriteLine();
        }
        
    }
}