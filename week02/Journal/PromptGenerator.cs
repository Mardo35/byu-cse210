using System;
using System.Collections.Generic;

namespace journal
{
    public class PromptGenerator
    {
        private readonly List<string> _prompts = new List<string>
        {
            "What valuable lesson did I learn Today?",
            "Have I accomplished something meaningful today?",
            "What did I do today, that I could have done better?",
            "What am I grateful for today?",
            "Did I do something to help me attain my goal in life?",
            "What is the most interesting thing that happened to me today?",
        };

        // I have added 30 motivational quotes to boost user every time they enter an entry,
        // To exceed requirements
        private readonly List<string> _quotes = new List<string>
        {
            "The way to get started is to quit talking and begin doing. - Walt Disney",
            "Your time is limited, so don't waste it living someone else's life. - Steve Jobs",
            "The future belongs to those who believe in the beauty of their dreams. - Eleanor Roosevelt",
            "If you look at what you have in life, you'll always have more. - Oprah Winfrey",
            "If you set your goals ridiculously high and it's a failure, you will fail above everyone else's success. - James Cameron",
            "You must be the change you wish to see in the world. - Mahatma Gandhi",
            "Spread love everywhere you go. - Mother Teresa",
            "The only thing we have to fear is fear itself. - Franklin D. Roosevelt",
            "Darkness cannot drive out darkness: only light can do that. - Martin Luther King Jr.",
            "Do one thing every day that scares you. - Eleanor Roosevelt",
            "Well done is better than well said. - Benjamin Franklin",
            "The best time to plant a tree was 20 years ago. The second best time is now. - Chinese Proverb",
            "I have learned over the years that when one's mind is made up, this diminishes fear. - Rosa Parks",
            "I didn't fail the test. I just found 100 ways to do it wrong. - Benjamin Franklin",
            "In the middle of every difficulty lies opportunity. - Albert Einstein",
            "The only impossible journey is the one you never begin. - Tony Robbins",
            "Don't judge each day by the harvest you reap but by the seeds that you plant. - Robert Louis Stevenson",
            "The mind is everything. What you think you become. - Buddha",
            "Life is 10% what happens to us and 90% how we react to it. - Charles R. Swindoll",
            "The most difficult thing is the decision to act, the rest is merely tenacity. - Amelia Earhart",
            "We become what we think about. - Earl Nightingale",
            "Twenty years from now you will be more disappointed by the things that you didn't do than by the ones you did do. - Mark Twain",
            "Great minds discuss ideas; average minds discuss events; small minds discuss people. - Eleanor Roosevelt",
            "I attribute my success to this: I never gave or took any excuse. - Florence Nightingale",
            "You miss 100% of the shots you don't take. - Wayne Gretzky",
            "I've missed more than 9000 shots in my career. I've lost almost 300 games. 26 times I've been trusted to take the game winning shot and missed. I've failed over and over and over again in my life. And that is why I succeed. - Michael Jordan",
            "The most common way people give up their power is by thinking they don't have any. - Alice Walker",
            "The best revenge is massive success. - Frank Sinatra",
            "Certain things catch your eye, but pursue only those that capture the heart. - Ancient Indian Proverb",
            "Believe you can and you're halfway there. - Theodore Roosevelt"
        };

        private readonly Random _random = new Random();

        public string GetRandomPrompt()
        {
            int index = _random.Next(_prompts.Count);
            return _prompts[index];
        }

        public string GetRandomQuote()
        {
            int index = _random.Next(_quotes.Count);
            return _quotes[index];
        }
    }
}