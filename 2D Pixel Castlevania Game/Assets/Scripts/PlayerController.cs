using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /// <summary>
    /// This will be used in case the CharacterController script dosn't work,
    /// becasue i keep getting warnning in the console of unity that says there is a thing with that name already and i can't do that.
    /// </summary>
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("horizontal", Mathf.Abs(Input.GetAxis("Horizontal")));
        animator.SetFloat("vertical", Input.GetAxis("Vertical"));
    }
}
