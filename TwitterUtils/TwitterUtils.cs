using UnityEngine;

namespace MyUnityLib
{
    public static class TwitterUtils
    {
        public static void Tweet(string text)
        {
            Application.ExternalEval(
                "window.addEventListener('mouseup', function (e) {"+
                "  window.removeEventListener(e.type, arguments.callee);"+
                "  window.open('https://twitter.com/intent/tweet?url='+document.referrer.replace('/webgl','')+'&text="+
                WWW.EscapeURL(text) + "&via=uni_rm&related=uni_rm', '_blank')" +
                "});");
        }
    }
}
