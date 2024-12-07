using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.Windows;

public class Player : MonoBehaviour
{

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var v = Input.GetAxis("Vertical");
        animator.SetFloat("move", v);
    }
}
