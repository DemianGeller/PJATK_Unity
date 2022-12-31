using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMove : MonoBehaviour
{

    public float MovementSpeed;

    public bool hasStarted;

    // Start is called before the first frame update
    void Start()
    {
        MovementSpeed = MovementSpeed / 60f; 
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted)
        {
            if(Input.anyKeyDown)
            {
                hasStarted = true;
            }
        } else
        {
            transform.position -= new Vector3(MovementSpeed * Time.deltaTime, MovementSpeed * Time.deltaTime, MovementSpeed * Time.deltaTime);
        }
    }
}
