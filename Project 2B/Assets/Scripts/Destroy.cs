/// <summary>
/// This script, when attached to a game object (collider), destroys all game objects that interact with it and changes a text descriptor
/// to reflect how many lives the player has remaining whenever this happens.
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{
    public AudioSource Crush;

    //Variables that create the changing text and lives counter
    private int lives = 10;
    public Text livesText;

    //Class that transitions into the game over scene when called
    void GameOver()
    {
        SceneManager.LoadScene("Game_Over");
    }

    private void Awake()
    {
        //When the scene first starts, the lives counter displays the initial text
        livesText.text = string.Format("Lives: {0}", lives);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If the player ever runs out of live, the game transitions to the game over screen
        if (lives == 0)
            GameOver();

    }

    //When a prefab collides with the boundary edge collider, it is destroyed
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Kernel")
        {
            Crush.Play();
            Destroy(collision.gameObject);
            lives -= 1;
            livesText.text = string.Format("Lives: {0}", lives);
        }
    }
}
