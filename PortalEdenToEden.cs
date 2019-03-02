using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalEdenToEden : MonoBehaviour {

    public GameObject Player;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Portel");
            Player.transform.position = new Vector3(302f, 2f, 80f);
        }
    }

}
