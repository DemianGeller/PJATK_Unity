using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class irisControllerDown : MonoBehaviour
{

    private SpriteRenderer iris3;
    public Sprite defaultImage;
    public Sprite pressedDownImage;

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
            iris3.sprite = pressedDownImage;
        }

        if (Input.GetKeyUp(keyToPress))
        {
            iris3.sprite = defaultImage;
        }
    }

}
