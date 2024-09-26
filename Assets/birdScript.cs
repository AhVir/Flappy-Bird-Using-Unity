using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRgBody;
    public float birdVelo = 8;
    public logicScript logic;
    private bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.name = "my Bird";
       logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            myRgBody.velocity = Vector2.up * birdVelo;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
