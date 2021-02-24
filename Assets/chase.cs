using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    void Start()
    {
        
}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F) == false)
        {
            //this.transform.position += (this.transform.position - target.position).normalized * speed * Time.deltaTime;
            //this.transform.position = Vector3.Lerp(this.transform.position, target.position, 0.1f);
            this.transform.Translate(Vector3.Normalize(target.position - this.transform.position) * 0.03f);
        }
    }
}
