using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kill: MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
            Debug.Log("detection");
            Destroy(collision.collider.gameObject);

        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
