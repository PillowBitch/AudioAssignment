using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(this.gameObject);
        }
    }
}
