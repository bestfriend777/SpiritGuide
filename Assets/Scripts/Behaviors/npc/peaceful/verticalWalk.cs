using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verticalWalk : MonoBehaviour
{
    bool walkingUp = true;
    float walkSpeed = 5.0f;
    int maxDistance = 10;
    int currentDistance = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += gameObject.transform.forward * walkSpeed * Time.deltaTime;
        
        if(currentDistance > maxDistance)
        {
            walkSpeed = walkSpeed * -1;
        }
    }
}
