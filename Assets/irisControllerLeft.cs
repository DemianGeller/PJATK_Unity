using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class irisControllerLeft : MonoBehaviour
{

    private SpriteRenderer iris2;
    public Sprite defaultImage;
    public Sprite pressedLeftImage;

    public KeyCode keyToPress;
    // Start is called before the first frame update
    void Start()
    {
        iris2 = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            iris2.sprite = pressedLeftImage;
        }

        if(Input.GetKeyUp(keyToPress))
        {
            iris2.sprite = defaultImage;
        }
    }

}