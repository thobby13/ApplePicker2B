/// <summary>
/// This script, when attached to a game object (popcorn machine), affects the spawn rate of falling
/// prefabs and the movement of thhe object across the top of a screen
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //Allows the speed of the machine to be changed in the editor
    [Header("Change Speed of Machine")]
    [Range(1, 25)]
    [Tooltip("This is the speed of the object.")]
    public int speed;
    [Space]

    //Initial position of the machine
    public Vector3 machinePosition = new Vector3(0, 0, 0);

    //Variables that affect the machine's movement patterns and constrain it to the game screen
    float directionChangeChance = 0.001f;
    private bool moving = false;
    public float boundaryEdge = 8f;

    //Variables that affect the kernel prefab and its spawning
    public GameObject kernelPrefab;
    private float randomNumber = 0f;
    private int timer = 0;
    private float chanceOfspawn = .95f;

    //Class that spawns kernel prefabs
    public void DropKernel()
    {
        if (Random.value > chanceOfspawn || timer > 100)
        {
            Instantiate(kernelPrefab, machinePosition, Quaternion.identity);
            timer = 0;
        }
        else
            timer += 1;

        transform.position += new Vector3(Random.Range(0f, 1f), 0f, 0f) * speed * Time.deltaTime;
        machinePosition = transform.position;

        if (machinePosition.x > boundaryEdge || machinePosition.x < -boundaryEdge)
            speed *= -1;
 
        else
            if (Random.value <= directionChangeChance)
            {
                speed *= -1;
            }

        randomNumber = Random.value;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Starts the game on first click
        if (moving == false)
            if (Input.GetMouseButtonDown(0))
                moving = true;

        if (moving == true)
            DropKernel();
    }
}
