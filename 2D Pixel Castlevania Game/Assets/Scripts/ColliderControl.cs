using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderControl : MonoBehaviour
{
    public BoxCollider2D stand;
    public CircleCollider2D crouch;

    Player playerC;

    // Start is called before the first frame update
    void Start()
    {
        playerC = GetComponent<Player>();
        stand.enabled = true;
        crouch.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerC.crouching == true)
        {
            stand.enabled = false;
            crouch.enabled = true;
        }
        else
        {
            stand.enabled = true;
            crouch.enabled = true;
        }
    }
}
