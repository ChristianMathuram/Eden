using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Skeleton : MonoBehaviour {

    private Animator anim;
    public Transform player;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = player.position - this.transform.position;
        float angle = Vector3.Angle(direction, this.transform.forward);
        
        if(Vector3.Distance(player.position,this.transform.position) < 30 && angle < 180)
        {
            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                        Quaternion.LookRotation(direction), 0.1f);
            anim.SetBool("isIdle", false);

            if (direction.magnitude >= 20)
            {
                this.transform.Translate(0, 0, 0.10f);
                anim.SetBool("IsRunning", true);
                anim.SetBool("isAttacking", false);
                
            }
           
           else if (direction.magnitude > 5)
            {
                this.transform.Translate(0, 0, 0.05f);
                anim.SetBool("isWalking", true);
                anim.SetBool("IsRunning", false);
                anim.SetBool("isAttacking", false);
                anim.SetBool("IsRunning", false);
            }
            else
            {
                anim.SetBool("isAttacking", true);
                anim.SetBool("isWalking", false);
                anim.SetBool("IsRunning", false);
            }
        }
        else
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isAttacking", false);
            anim.SetBool("IsRunning", false);
        }
	}
}
