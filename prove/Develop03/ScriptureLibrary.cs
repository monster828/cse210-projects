public class ScriptureLibrary
{
    // Scriptures
    private Scripture[] scriptures =
    {
        new Scripture(new ScriptureReference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
        new Scripture(new ScriptureReference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
        new Scripture(new ScriptureReference("1 Nephi", 1, 1), "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days."),
        new Scripture(new ScriptureReference("1 Nephi", 3, 7), "I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
        new Scripture(new ScriptureReference("Moroni", 10, 4, 5), "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things."),
        new Scripture(new ScriptureReference("D&C", 1, 38), "What I the Lord have spoken, I have spoken, and I excuse not myself; and though the heavens and the earth pass away, my word shall not pass away, but shall all be fulfilled, whether by mine own voice or by the voice of my servants, it is the same."),
        new Scripture(new ScriptureReference("D&C", 8,2,3), "Yea, behold, I will tell you in your mind and in your heart, by the Holy Ghost, which shall come upon you and which shall dwell in your heart. Now, behold, this is the spirit of revelation; behold, this is the spirit by which Moses brought the children of Israel through the Red Sea on dry ground."),
        new Scripture(new ScriptureReference("Moses", 1, 39), "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man"),
        new Scripture(new ScriptureReference("James", 1, 5), "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him."),
    };

    // Get and return random scripture from the array
    public Scripture GetScripture()
    {
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(0, scriptures.Length)];
        return scripture;
    }
}