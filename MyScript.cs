using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class MyScript : MonoBehaviour {

  

    // Use this for initialization
    void Start () {
		
	}

    

    // Update is called once per frame
    void Update () {


        var playerposition = GameObject.FindGameObjectWithTag("Player").transform.position;
        //Debug.Log("Player Position " + playerposition);
        transform.position = playerposition;

    }
    public void Load()
    {
        transform.position =SaveGame.Instance.PlayerPosition;
        SaveGame.Load();
    }
    public void Save()
    {
        SaveGame.Instance.PlayerPosition = transform.position;
        SaveGame.Save();
    }
}
