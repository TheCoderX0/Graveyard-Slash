using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public Transform vcam;
    public float relativeMove = 0.4f;
    public bool lockY = false;

    // Update is called once per frame
    void Update()
    {
        if (lockY)
        {
            transform.position = new Vector2(vcam.position.x * relativeMove, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(vcam.position.x * relativeMove, vcam.position.y * relativeMove);
        }
    }
}
