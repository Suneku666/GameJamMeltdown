using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {
    //Key Bindings
    private KeyCode down    = KeyCode.S;
    private KeyCode up      = KeyCode.W;
    private KeyCode left    = KeyCode.A;
    private KeyCode right   = KeyCode.D;

    private KeyCode sprint = KeyCode.LeftShift;

    //Game-Play Variables
    public float speed              = 0.8f;
    public float defaultSprinting   = 2f;
    public float rotationSpeed      = 150f;

    public float health = 100;

    private float sprinting;
    // Use this for initialization
    void Start () {
        sprinting = defaultSprinting;
    }
	
	// Update is called once per frame
	void Update () {
        //move player forwards/backwards
        if (Input.GetKey(down))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = transform.up * -speed * sprinting;
        }
        if (Input.GetKey(up))
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = transform.up * speed * sprinting;
        }
        //rotatePlayer left/right
        if (Input.GetKey(left))
        {
            gameObject.GetComponent<Rigidbody2D>().rotation += rotationSpeed * Time.deltaTime;
        }
        if (Input.GetKey(right))
        {
            gameObject.GetComponent<Rigidbody2D>().rotation -= rotationSpeed * Time.deltaTime;
        }

        //sprint
        if (Input.GetKeyDown(sprint))
        {
            sprinting = defaultSprinting;
        }
        if (Input.GetKeyUp(sprint)) 
        {
            sprinting = 1f;
        }
    }
    //Debug.Log(reactor.gameObject.GetComponent<Reactor_Controller>().radiationDamage);


}
