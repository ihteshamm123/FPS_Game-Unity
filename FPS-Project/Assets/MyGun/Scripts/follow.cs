using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public int health = 100;
    Transform tr_Player;
    float f_RotSpeed = 3.0f, f_MoveSpeed = 3.0f;

    // Use this for initialization
    void Start()
    {

        tr_Player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.z > 20)
        //{
        /* Look at Player*/
        transform.rotation = Quaternion.Slerp(transform.rotation
                                          , Quaternion.LookRotation(tr_Player.position - transform.position)
                                          , f_RotSpeed * Time.deltaTime);
        // }
        /* Move at Player*/
        transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;
        if (transform.position.z < -20)
        {
            Destroy(gameObject);
        }

    }
    void OnTriggerEnter(Collider other)
    {

        if(health == 0)
        {
            Destroy(this.gameObject);
        }
        else
        {
            health = health - 10;
        }
        /*PlayerHealth player = other.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.Hurt(damage);
        }*/
        

    }
}