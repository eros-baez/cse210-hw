using System;
using System.Collections.Generic;

public class Scripture
{
    public List<string> _scriptures = ["And all thy children shall be taught of the Lord;" +
    "and great shall be the peace of thy children.", "And it came to pass that I, Nephi," +
    "said unto my father: I will go and do the things which the Lord hath commanded," +
    "for I know that the Lord giveth no commandments unto the children of men," +
    "save he shall prepare a way for them that they may accomplish the thing which he commandeth them."];
    

    
    public int GetRandomItem()
    {
        Random random = new Random();
        int randomItem = random.Next(_scriptures.Count);
        
        return randomItem;
    }




}


