using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class irisControllerUp : MonoBehaviour
{

    private SpriteRenderer iris3;
    public Sprite defaultImage;
    public Sprite pressedUpImage;

    public KeyCode keyToPress;
    // Start is called before the first frame update
    void Start()
    {
        iris3 = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            iris3.sprite = pressedUpImage;
        }

        if (Input.GetKeyUp(keyToPress))
        {
            iris3.sprite = defaultImage;
        }
    }

}