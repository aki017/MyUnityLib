using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CaptureUtils
{
    public static byte[] TakeScreenShot()
    {
        var img = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        img.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        return img.EncodeToPNG();
    }
}
