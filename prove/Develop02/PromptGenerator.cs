using System.Runtime.CompilerServices;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompt;
    public string GetRandomPrompt()
    {
        _prompt = new List<string>
        {
            "Who was the most intersting person I interacted with today? ",
            "What was the best part of my day? ",
            "How did I see the hand of the Lord in my life today? ",
            "If I had one thing I could do over today, what would it be? "
            
            
        };
        
        Random random = new Random();
        int randomIndex = random.Next(_prompt.Count);
        return _prompt[randomIndex];
    }
}
