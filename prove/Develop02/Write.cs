using System;

public class Write1
{
        public string _entry;
        public string _prompt;
        public string _date;

        public void WritePrompt()
        {
                DateTime today = DateTime.Now;
                _date = today.ToString("MM/dd/yyyy");

                PromptGenerator prompt1 = new PromptGenerator();
                _prompt = prompt1.PromptQuestion();

                _entry = Console.ReadLine();
        }

        public void Display()
        {
                Console.WriteLine($"\nDate: {_date}\nPrompt: {_prompt}\nAnnotation: {_entry}");
        }

        public string Something()
        {
                return $"{_date},{_prompt},{_entry}";
        }

        public void CreateList(string[] entrySomething)
        {
                _date = entrySomething[0];
                _prompt = entrySomething[1];
                _entry = entrySomething[2];
        }
}