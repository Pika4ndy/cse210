// Scripture Memorizer Project
/* 
Description:
    This program displays a random scripture at first and hide some words
    every time the user press <Enter> until all words are hidden and then it
    quits. User can also quit by typing 'quit'.

Exceeding requirements:
    - Reveal a word when the user type it
    - Select a random scripture from a scripture library
*/

// Scripture list: John 3:16 ; 1 Cor 6:19-20 ; 1 Ne 3:7 ; Mat 5:3-5 ; Mos 2:41 ; 2 Ne 2:25 ; Hel 5:12 ; Proverbs 3:5-6
using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureList= new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("1 Corinthians", 6, 19, 20), "What? know ye not that your body is the temple of the Holy Ghost which is in you, which ye have of God, and ye are not your own? For ye are bought with a price: therefore glorify God in your body, and in your spirit, which are God's."),
            new Scripture(new Reference("Matthew", 5, 3, 5), "3 Blessed are the poor in spirit: for theirs is the kingdom of heaven. Blessed are they that mourn: for they shall be comforted. Blessed are the meek: for they shall inherit the earth."),
            new Scripture(new Reference("1 Nephi", 3, 5), "And now, behold thy brothers murmur, saying it is a hard thing which I have required of them; but behold I have not required it of them, but it is a commandment of the Lord."),
            new Scripture(new Reference("Mosiah", 2, 41), "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("Helaman", 5, 12), "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."),
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths")
        };

        Random random = new Random();

        int randomIndex = random.Next(scriptureList.Count);

        Scripture scripture = scriptureList[randomIndex];
        
        string userInput;
        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText() + "\n");
            
            Console.WriteLine("Press <Enter> to continue / type a hidden word to reveal it / type 'quit' to finish:");
            userInput = Console.ReadLine().Trim().ToLower();

            if (userInput == "" && !scripture.IsCompletlyHidden())
            {
                scripture.HideRandomWords(3);
            } else if (userInput == "quit" || userInput == "q" || (scripture.IsCompletlyHidden() && userInput == ""))
            {
                break;
            } else
            {
                scripture.TryRevealWord(userInput);
            }

        } while (!(userInput == "quit"));
    }
}