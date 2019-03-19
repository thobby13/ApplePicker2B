/// <summary>
/// This script, when attached to a game object (popcorn bucket), calls for the game object to follow the player's mouse once the
/// game starts/the screen has been clicked.
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    //Variables that constrain the movements of the bucket and affect when it starts moving
    private Vector3 position = new Vector3 (0f, -2.5f, 0f);
    private Vector3 mousePosition;
    public float worldEdge = 1366f;
    public float boundaryEdge = 8f;
    private bool start = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Tells the bucket to follow the mouse once the game has been clicked on
        if (start == false)
            if (Input.GetMouseButtonDown(0))
                start = true;

        if (start == true)
        {
            var mousePosition = (Input.mousePosition);
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, 0f, 0f));
        }

    }
}
