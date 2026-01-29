public class ScriptureLibrary
{
    private List<Scripture> _scriptures = new List<Scripture>();

    public ScriptureLibrary()
    {   
        //  Exceeding requirements, this is a list of 10 Scriptures from the book of Mormon, one will be displayed at Random
        //  Does not matter if it is single verse or not.
        // 1. 1 Nephi 3:7 
        _scriptures.Add(new Scripture(new Reference("1 Nephi", 3, 7), 
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));

        // 2. 2 Nephi 2:25 
        _scriptures.Add(new Scripture(new Reference("2 Nephi", 2, 25), 
            "Adam fell that men might be; and men are, that they might have joy."));

        // 3. 2 Nephi 25:23 
        _scriptures.Add(new Scripture(new Reference("2 Nephi", 25, 23), 
            "For we labor diligently to write, to persuade our children, and also our brethren, to believe in Christ, and to be reconciled to God; for we know that it is by grace that we are saved, after all we can do."));

        // 4. 2 Nephi 31:20 
        _scriptures.Add(new Scripture(new Reference("2 Nephi", 31, 20), 
            "Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men."));

        // 5. Mosiah 2:17 
        _scriptures.Add(new Scripture(new Reference("Mosiah", 2, 17), 
            "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."));

        // 6. Mosiah 18:8-9
        _scriptures.Add(new Scripture(new Reference("Mosiah", 18, 8, 9), 
            "And now, as ye are desirous to come into the fold of God, and to be called his people... to stand as witnesses of God at all times and in all things, and in all places."));

        // 7. Alma 7:11-12 
        _scriptures.Add(new Scripture(new Reference("Alma", 7, 11, 12), 
            "And he shall go forth, suffering pains and afflictions and temptations of every kind... that he may know according to the flesh how to succor his people."));

        // 8. Alma 32:21 
        _scriptures.Add(new Scripture(new Reference("Alma", 32, 21), 
            "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."));

        // 9. Helaman 5:12 
        _scriptures.Add(new Scripture(new Reference("Helaman", 5, 12), 
            "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation."));

        // 10. Moroni 10:4-5 
        _scriptures.Add(new Scripture(new Reference("Moroni", 10, 4, 5), 
            "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true... And by the power of the Holy Ghost ye may know the truth of all things."));
    }

    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}