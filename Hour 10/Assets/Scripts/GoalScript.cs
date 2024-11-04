using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;
    void OnTriggerEnter (Collider Collider)
        {
            GameObject collidedWith = GetComponent<Collider>().gameObject;
            if (collidedWith.tag == gameObject.tag)
            {
                isSolved = true;
                GetComponent<Light>().enabled = false;
                Destroy (collidedWith);
            }
        }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
