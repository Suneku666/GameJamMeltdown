using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reactor_Controller : MonoBehaviour
{
    public float radiationDamage = 10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //handleCollisionWithTheReactor
    void OnTriggerStay2D(Collider2D player)
    {
        float periodicDamage = radiationDamage * Time.deltaTime;
        player.GetComponent<Player_Controller>().health -= periodicDamage;
        Debug.Log("Dealing radiation damage = " + periodicDamage);
    }
}