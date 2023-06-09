using System;

namespace UserManager
{
    public class UIElement
    {
        public string key;
        public string messenger;
        public Action callBack;

        public UIElement(string key, string messenger, Action callBack)
        {
            this.key = key;
            this.messenger = messenger;
            this.callBack = callBack;
        }
    }
}
