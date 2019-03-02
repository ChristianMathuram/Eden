using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        MouseRightClick();

    }

    public void MouseRightClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("AttackSword");
        }
    }
}
