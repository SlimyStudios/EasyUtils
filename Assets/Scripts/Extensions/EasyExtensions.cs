using UnityEngine;

public static class EasyExtensions
{
    public static Camera cam;
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    private static void Init()
    {
        cam = Camera.main;
    }
}