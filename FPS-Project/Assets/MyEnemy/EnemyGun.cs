using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public GameObject PlayerCamera;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
        void OnTriggerEnter(Collider other)
        {
            //GetComponent<AudioSource>().Play();
            //Debug.Log("Fire!");
            print("Fire!");
            GameObject bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position = PlayerCamera.transform.position
                + PlayerCamera.transform.forward;
            bulletObject.transform.forward = PlayerCamera.transform.forward;


        //}
    }
}