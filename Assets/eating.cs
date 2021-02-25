using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eating : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject point;
    public GameObject text;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == point)
        {
            Debug.Log("detection");
            Destroy(collision.collider.gameObject);
            text.SetActive(true);
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
