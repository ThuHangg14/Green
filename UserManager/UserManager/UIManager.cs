using System;

namespace UserManager
{
    public class UIManager
    {
        private static UIManager _instance = null;

        public static UIManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UIManager();
                }
                return _instance;
            }
        }

        private UIManager() { }

        public void PrintLine(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine(
                );
        }

        public void PrintMessenger(string sms)
        {
            Console.WriteLine(sms);
        }

        public void PrintMessengerFail()
        {
            Console.WriteLine("Fail");
        }

        public void PrintMessengerSuccess()
        {
            Console.WriteLine("Success");
        }

        private UIElement CheckElementByKey(string key, UIElement[] elements)
        {
            foreach (var e in elements)
            {
                if (e.key.Equals(key))
                {
                    return e;
                }
            }

            return null;
        }

        private void ValidateInput(UIElement[] UIElements, out UIElement targetElement) // PrintMenu ( targetElement = null )
        {
            while (true)
            {
                Console.WriteLine("Input key : ");
                string key = Console.ReadLine();
                targetElement = CheckElementByKey(key, UIElements); // targetElement = return choose 

                if (targetElement != null)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }

        public void PrintMenu(string title, UIElement[] element)
        {
            Console.Clear();

            Console.WriteLine(title);

            PrintLine(30);

            for (int i = 0; i < element.Length; i++)
            {
                Console.WriteLine($"{element[i].key} . {element[i].messenger}");
            }
            PrintLine(30);

            UIElement targetElement = null;

            ValidateInput(element, out targetElement); // targetElement = return choose ahead

            if (targetElement.callBack != null)
            {
                targetElement.callBack();
            }
        }
    }
}
