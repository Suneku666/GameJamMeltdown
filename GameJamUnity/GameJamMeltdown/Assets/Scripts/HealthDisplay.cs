using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDisplay : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.GetComponent<UnityEngine.UI.Text>().text = "Health : " + player.GetComponent<Player_Controller>().health + "/100";
	}
}
