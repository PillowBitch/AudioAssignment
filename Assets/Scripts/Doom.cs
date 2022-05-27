using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doom : MonoBehaviour
{
    public static Doom instance;
    public SpriteRenderer bg;
    Color32 defColor;
    public Color32 doomColor;

    bool doomed = false;
    float timer = 0;
    public float timerSeconds = 5;
    private void Awake()
    {
        if(instance == null)
            instance = this;

        defColor = bg.color;
    }

    // Update is called once per frame
    void Update()
    {
        if(doomed)
        {
            timer += Time.deltaTime;
            float progress = timer / timerSeconds;
            bg.color = Color32.Lerp(defColor, doomColor, progress);
        }
    }

    public void DoomTime()
    {
        doomed = true;
    }
}
