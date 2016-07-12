using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            public string Language { get; set; }
        }
       

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public static List<Phrase> Phrases;

        public ActionResult GetPhrase(string difficulty, string language)
        {
            Phrases = new List<Phrase>();

            BuildPhrases(1, "Easy", "en_US", @"I'll continue to feel grateful as you continue to love me. Thanks for another amazing year with you.");
            BuildPhrases(2, "Easy", "en_US", @"My time with you is valuable. Today, we get to celebrate the time that we've been blessed to spend together. Thank you for your commitment and investment in our relationship.");
            BuildPhrases(3, "Easy", "en_US", @"Congratulations on your graduation! We know you have worked hard, and we look forward to seeing you reap the benefits.");
            BuildPhrases(4, "Easy", "en_US", @"The cap and gown are just a symbol of the useful education you will wear for the rest of your life.");
            BuildPhrases(5, "Easy", "en_US", @"If you put as much effort into enjoying your retirement as you have all the years you've been working, you’ll have an amazing, productive, dynamic and long lasting retirement. You deserve it!");
            BuildPhrases(6, "Easy", "en_US", @"I'm glad you get to retire while you still have many good and capable years of life left in you! Congratulations!");
            BuildPhrases(7, "Easy", "en_US", @"I don't know who is more blessed. Either you are for having a new little baby, or your baby is for having you as parents. Congratulations to everyone!");
            BuildPhrases(8, "Easy", "en_US", @"Congratulations on your pregnancy! We are looking forward to meeting the newest member of the family!");
            BuildPhrases(9, "Easy", "en_US", @"As you become busy with the holiday festivities, take the time to enjoy those things that are most important.");
            BuildPhrases(10, "Easy", "en_US", @"Hot chocolate, presents, candy canes and family are the things that make Christmas such as special time. Merry Christmas!");
            BuildPhrases(11, "Medium", "en_US", @"Your work is going to fill a large part of your life, and the only way to be truly satisfied is to do what you believe is great work. And the only way to do great work is to love what you do.
If you haven't found it yet, keep looking. Don't settle. As with all matters of the heart, you'll know when you find it.");
            BuildPhrases(12, "Medium", "en_US", @"Your time is limited, so don't waste it living someone else's life. Don't be trapped by dogma - which is living with the results of other people's thinking.
Don't let the noise of others' opinions drown out your own inner voice. And most important, have the courage to follow your heart and intuition.");
            BuildPhrases(13, "Medium", "en_US", @"You can't connect the dots looking forward; you can only connect them looking backwards. So you have to trust that the dots will somehow connect in your future.
You have to trust in something - your gut, destiny, life, karma, whatever. This approach has never let me down, and it has made all the difference in my life.");
            BuildPhrases(14, "Medium", "en_US", @"Say there's a white kid who lives in a nice home, goes to an all-white school, and is pretty much having everything handed to him on a platter - for him to pick up
a rap tape is incredible to me, because what that's saying is that he's living a fantasy life of rebellion.");
            BuildPhrases(15, "Medium", "en_US", @"Infuse your life with action. Don't wait for it to happen. Make it happen. Make your own future. Make your own hope. Make your own love.
And whatever your beliefs, honor your creator, not by passively waiting for grace to come down from upon high, but by doing what you can to make grace happen... yourself, right now, right down here on Earth. ");
            BuildPhrases(16, "Medium", "en_US", @"This life, which had been the tomb of his virtue and of his honour, is but a walking shadow; a poor player, that struts and frets his hour upon the stage,
and then is heard no more: it is a tale told by an idiot, full of sound and fury, signifying nothing. ");
            BuildPhrases(17, "Medium", "en_US", @"Desire is the key to motivation, but it's determination and commitment to an unrelenting pursuit of your
goal - a commitment to excellence - that will enable you to attain the success you seek. ");
            BuildPhrases(18, "Hard", "en_US", @"I really wonder why people suddenly change after they get what they wanted. One day they’re sweet, the next day, they’re not. One day they’re here, the next day they’re not.
One day you’re important to them, the next day you’re worthless. One day they love you, the next day they don’t care about you. That’s how ironic people and things can be.
Pretty shits, pretty lies, pretty fucked up. But it’s still your choice. Cause you choose to get hurt when you choose to be in love.");
            BuildPhrases(19, "Hard", "en_US", @"Am I mad at you? That’s your main concern after shattering my whole world? Mad for what? Breaking my heart? Or for all the lies? Maybe for letting me put all my trust in you only to be betrayed?
How about the fact you didn’t even have the decency to tell me to my face? Or the way you think it’s crazy that I’m crying over it cause to you breaking up is no big deal. Am I mad at you?… no.
More like crushed… did I ever really know you?");
            BuildPhrases(20, "Hard", "en_US", @"Do you want to know what my problem is? I will tell you what my problem is, I LOVE YOU I love your name, I love the way you look at me, I love your gorgeous smile,
I love the way you walk, I love your beautiful eyes, I love what you look like when you are asleep, I love the sound of your laugh, to hear your voice fills my entire
heart with an indescribable feeling. I love the way I can be having the worst day of my life and seeing you completely changes my mood. I love how when you touch me I get weak, that is my problem…");
            BuildPhrases(21, "Hard", "en_US", @"‘I love you’ means that I accept you for the person that you are, and that I do not wish to change you into someone else. It means that I will love you and stand by you
even through the worst of times. It means loving you when you’re in a bad mood or too tired to do things I want to do. It means loving you when you’re down, not just when
you’re fun to be with. I love you means that I know your deepest secrets and do not judge you for them, asking in return only that you do not judge me for mine.
It means that I care enough to fight for what we have and that I love you enough not to let go. It means thinking of you, dreaming of you, wanting and needing you constantly, hoping you feel the same way for me.");
            BuildPhrases(22, "Hard", "en_US", @"A girl asked a boy if she was pretty. He said no. Then she asked him he liked her and he said no. She asked him if he wanted to be with her forever. He said no.
She then asked him if he would cry if she walked away. He again said no. She had heard too much. She needed to leave. As she walked away, he grabbed her arm and told her to stay.
He said “You’re not pretty, you’re beautiful. I don’t like you, I love you. I don’t want to be with you forever, I need to be with you forever, and I wouldn’t cry if you walked away, I would die.");

            BuildPhrases(23, "Easy", "bg_BG", "Всички птици във гората пеят радостно от сутринта: бебе се роди засмяно, да му честитим сега: да е живо, да е здраво, и да слуша мама и тати. Любов в сърцето да прелива и много радости да има!");

            BuildPhrases(23, "Medium", "bg_BG", "Най-хубавият ден от твоето учение в живота е сега, като абитуриентка. Това е твоята вечер, когато ще полееш с радост и едновременно тъга всичките хубави години, които си прекарала в учение.Пожелавам ти да имаш поводи и за в бъдеще да поливаш своите успехи и да бъдеш истински щастлива! ");

            BuildPhrases(23, "Hard", "bg_BG", "Напоследък много хора се отказаха да живеят. Не се отегчават, не плачат, просто стоят в очакване да мине времето. Те не приеха предизвикателството на живота и животът повече не им отправя предизвикателства. Ти рискуваш да станеш като тях, съпротивлявай се, посрещни смело това, което ти поднася животът, не се отказвай.");

            BuildPhrases(24, "Easy", "zh_HK", "样品笔法");
            BuildPhrases(24, "Medium", "zh_HK", "样品笔法");
            BuildPhrases(24, "Hard", "zh_HK", "样品笔法");

            BuildPhrases(25, "Easy", "hi_IN", "ओम, मैं हर दिन योग की बहुत सारी");
            BuildPhrases(25, "Medium", "hi_IN", "ओम, मैं हर दिन योग की बहुत सारी");
            BuildPhrases(25, "Hard", "hi_IN", "ओम, मैं हर दिन योग की बहुत सारी");

            var potentials = Phrases.Where(c => c.Difficulty == difficulty && c.Language == language).ToArray();
            var rand = new Random();
            var result = potentials[rand.Next(potentials.Length)];

            return Content(JsonConvert.SerializeObject(result));
        }

        private void BuildPhrases(int id, string difficulty, string language, string phrase)
        {
            Phrases.Add(new Phrase
            {
                Difficulty = difficulty,
                Id = id,
                Text = phrase,
                Language = language
            });
        }

        public ActionResult HandwritingResult(string jsonData, string language)
        {
            var wc = new System.Net.WebClient();
            wc.Headers["Accept"] = "application/json";
            //wc.Headers["Accept-Encoding"] = "gzip, deflate";
            //wc.Headers["Accept-Language"] = "en-US,bg_BG,zh_HK,en;q=0.8";
            ////wc.Headers["Connection"] = "keep-alive";
            wc.Headers["Content-type"] = "application/x-www-form-urlencoded";
            //wc.Headers["Host"] = "cloud.myscript.com";
            //wc.Headers["Origin"] = "http://cloud.myscript.com";
            //wc.Headers["Referer"] = "http://cloud.myscript.com/";
            //wc.Headers["User-Agent"] = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.84 Safari/537.36";
            wc.Encoding = Encoding.UTF8;
            var inputData = "applicationKey=749e6a68-f4bf-4ede-820e-d94f5b7622f7&textInput=%7B%0A%20%20%20%20%22textParameter%22%3A%20%7B%0A%20%20%20%20%20%20%20%20%22language%22%3A%20%22LANGUAGETAG%22%2C%0A%20%20%20%20%20%20%20%20%22textInputMode%22%3A%20%22CURSIVE%22%0A%20%20%20%20%7D%2C%0A%20%20%20%20%22inputUnits%22%3A%20%5B%0A%20%20%20%20%20%20%20%20%7B%0A%20%20%20%20%20%20%20%20%20%20%20%20%22textInputType%22%3A%20%22MULTI_LINE_TEXT%22%2C%0A%20%20%20%20%20%20%20%20%20%20%20%20%22components%22%3A%20SUPERAREA%0A%20%20%20%20%20%20%20%20%7D%0A%20%20%20%20%5D%0A%7D"
                .Replace("LANGUAGETAG", language).Replace("SUPERAREA", HttpUtility.UrlEncode(jsonData));


            var result =
                wc.UploadString("http://cloud.myscript.com/api/v3.0/recognition/rest/text/doSimpleRecognition.json", "POST",
                    inputData);
            return Content(result);
        }
    }
}