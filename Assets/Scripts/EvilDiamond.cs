using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilDiamond : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioController.PlayAudio("Rasmus");
        Doom.instance.DoomTime();

        Destroy(this.gameObject);

    }
}
