using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace HandWritingImprover.Controllers
{
    public class HomeController : Controller
    {
        public class Phrase
        {
            public int Id { get; set; }
            public string Difficulty { get; set; }
            public string Text { get; set; }
        }
       

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public static List<Phrase> Phrases;

        public ActionResult GetPhrase(string difficulty)
        {
            Phrases = new List<Phrase>();

            BuildPhrases(1, "Easy", @"I'll continue to feel grateful as you continue to love me. Thanks for another amazing year with you.");
            BuildPhrases(2, "Easy", @"My time with you is valuable. Today, we get to celebrate the time that we've been blessed to spend together. Thank you for your commitment and investment in our relationship.");
            BuildPhrases(3, "Easy", @"Congratulations on your graduation! We know you have worked hard, and we look forward to seeing you reap the benefits.");
            BuildPhrases(4, "Easy", @"The cap and gown are just a symbol of the useful education you will wear for the rest of your life.");
            BuildPhrases(5, "Easy", @"If you put as much effort into enjoying your retirement as you have all the years you've been working, you’ll have an amazing, productive, dynamic and long lasting retirement. You deserve it!");
            BuildPhrases(6, "Easy", @"I'm glad you get to retire while you still have many good and capable years of life left in you! Congratulations!");
            BuildPhrases(7, "Easy", @"I don't know who is more blessed. Either you are for having a new little baby, or your baby is for having you as parents. Congratulations to everyone!");
            BuildPhrases(8, "Easy", @"Congratulations on your pregnancy! We are looking forward to meeting the newest member of the family!");
            BuildPhrases(9, "Easy", @"As you become busy with the holiday festivities, take the time to enjoy those things that are most important.");
            BuildPhrases(10, "Easy", @"Hot chocolate, presents, candy canes and family are the things that make Christmas such as special time. Merry Christmas!");
            BuildPhrases(11, "Medium", @"Your work is going to fill a large part of your life, and the only way to be truly satisfied is to do what you believe is great work. And the only way to do great work is to love what you do.
If you haven't found it yet, keep looking. Don't settle. As with all matters of the heart, you'll know when you find it.");
            BuildPhrases(12, "Medium", @"Your time is limited, so don't waste it living someone else's life. Don't be trapped by dogma - which is living with the results of other people's thinking.
Don't let the noise of others' opinions drown out your own inner voice. And most important, have the courage to follow your heart and intuition.");
            BuildPhrases(13, "Medium", @"You can't connect the dots looking forward; you can only connect them looking backwards. So you have to trust that the dots will somehow connect in your future.
You have to trust in something - your gut, destiny, life, karma, whatever. This approach has never let me down, and it has made all the difference in my life.");
            BuildPhrases(14, "Medium", @"Say there's a white kid who lives in a nice home, goes to an all-white school, and is pretty much having everything handed to him on a platter - for him to pick up
a rap tape is incredible to me, because what that's saying is that he's living a fantasy life of rebellion.");
            BuildPhrases(15, "Medium", @"Infuse your life with action. Don't wait for it to happen. Make it happen. Make your own future. Make your own hope. Make your own love.
And whatever your beliefs, honor your creator, not by passively waiting for grace to come down from upon high, but by doing what you can to make grace happen... yourself, right now, right down here on Earth. ");
            BuildPhrases(16, "Medium", @"This life, which had been the tomb of his virtue and of his honour, is but a walking shadow; a poor player, that struts and frets his hour upon the stage,
and then is heard no more: it is a tale told by an idiot, full of sound and fury, signifying nothing. ");
            BuildPhrases(17, "Medium", @"Desire is the key to motivation, but it's determination and commitment to an unrelenting pursuit of your
goal - a commitment to excellence - that will enable you to attain the success you seek. ");
            BuildPhrases(18, "Hard", @"I really wonder why people suddenly change after they get what they wanted. One day they’re sweet, the next day, they’re not. One day they’re here, the next day they’re not.
One day you’re important to them, the next day you’re worthless. One day they love you, the next day they don’t care about you. That’s how ironic people and things can be.
Pretty shits, pretty lies, pretty fucked up. But it’s still your choice. Cause you choose to get hurt when you choose to be in love.");
            BuildPhrases(19, "Hard", @"Am I mad at you? That’s your main concern after shattering my whole world? Mad for what? Breaking my heart? Or for all the lies? Maybe for letting me put all my trust in you only to be betrayed?
How about the fact you didn’t even have the decency to tell me to my face? Or the way you think it’s crazy that I’m crying over it cause to you breaking up is no big deal. Am I mad at you?… no.
More like crushed… did I ever really know you?");
            BuildPhrases(20, "Hard", @"Do you want to know what my problem is? I will tell you what my problem is, I LOVE YOU I love your name, I love the way you look at me, I love your gorgeous smile,
I love the way you walk, I love your beautiful eyes, I love what you look like when you are asleep, I love the sound of your laugh, to hear your voice fills my entire
heart with an indescribable feeling. I love the way I can be having the worst day of my life and seeing you completely changes my mood. I love how when you touch me I get weak, that is my problem…");
            BuildPhrases(21, "Hard", @"‘I love you’ means that I accept you for the person that you are, and that I do not wish to change you into someone else. It means that I will love you and stand by you
even through the worst of times. It means loving you when you’re in a bad mood or too tired to do things I want to do. It means loving you when you’re down, not just when
you’re fun to be with. I love you means that I know your deepest secrets and do not judge you for them, asking in return only that you do not judge me for mine.
It means that I care enough to fight for what we have and that I love you enough not to let go. It means thinking of you, dreaming of you, wanting and needing you constantly, hoping you feel the same way for me.");
            BuildPhrases(22, "Hard", @"A girl asked a boy if she was pretty. He said no. Then she asked him he liked her and he said no. She asked him if he wanted to be with her forever. He said no.
She then asked him if he would cry if she walked away. He again said no. She had heard too much. She needed to leave. As she walked away, he grabbed her arm and told her to stay.
He said “You’re not pretty, you’re beautiful. I don’t like you, I love you. I don’t want to be with you forever, I need to be with you forever, and I wouldn’t cry if you walked away, I would die.");

            var potentials = Phrases.Where(c => c.Difficulty == difficulty).ToArray();
            var rand = new Random();
            var result = potentials[rand.Next(potentials.Length)];

            return Content(JsonConvert.SerializeObject(result));
        }

        private void BuildPhrases(int id, string difficulty, string phrase)
        {
            Phrases.Add(new Phrase
            {
                Difficulty = difficulty,
                Id = id,
                Text = phrase
            });
        }

        public ActionResult HandwritingResult(string jsonData)
        {
            var wc = new System.Net.WebClient();
            wc.Headers["Accept"] = "application/json";
            wc.Headers["Accept-Encoding"] = "gzip, deflate";
            wc.Headers["Accept-Language"] = "en-US,en;q=0.8";
            //wc.Headers["Connection"] = "keep-alive";
            wc.Headers["Content-type"] = "application/x-www-form-urlencoded";
            wc.Headers["Host"] = "webdemo.myscript.com";
            wc.Headers["Origin"] = "http://webdemo.myscript.com";
            wc.Headers["Referer"] = "http://webdemo.myscript.com/";
            wc.Headers["User-Agent"] = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.84 Safari/537.36";

            var inputData = "apiKey=f3469740-d247-11e1-acbf-0025648c5362&instanceId=d08ced1c-2e27-4e26-a6f0-c95d38432db3&hwrInput=%7B+++++%22hwrParameter%22%3A+%7B+++++++++%22hwrInputMode%22%3A+%22CURSIVE%22%2C+++++++++%22resultDetail%22%3A+%22TEXT%22%2C+++++++++%22hwrProperties%22%3A+%7B%7D%2C+++++++++%22language%22%3A+%22en_US%22%2C+++++++++%22contentTypes%22%3A+%5B%5D+++++%7D%2C+++++%22inputUnits%22%3A+%5B+++++++++%7B+++++++++++++%22hwrInputType%22%3A+%22MULTI_LINE_TEXT%22%2C+++++++++++++%22components%22%3A++++++++SUPERAREA++++++++++++++++++++++%+++++++++%7D+++++%5D%2C+++++%22switchToChildren%22%3A+true+%7D"
                .Replace("SUPERAREA", HttpUtility.UrlEncode(jsonData));

            return Content(wc.UploadString("http://webdemo.myscript.com/api/myscript/v2.0/hwr/doSimpleRecognition.json", "POST", inputData));
        }
    }
}