/// <summary>
/// This script, when attached to a game object (bucket), destroys all game objects that interact with it and changes a text descriptor
/// to reflect how many points the player has earned this happens.
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{
    //Variables that create the changing text and points counter
    public int score = 0;
    public Text scoreText;
    int endScore;

    public AudioSource Pop;

    public Text HighScore1;
    public Text HighScore2;
    public Text HighScore3;
    public Text HighScore4;
    public Text HighScore5;
    public Text HighScore6;
    public Text HighScore7;
    public Text HighScore8;
    public Text HighScore9;
    public Text HighScore10;

    private int NewScore1;
    private int NewScore2;
    private int NewScore3;
    private int NewScore4;
    private int NewScore5;
    private int NewScore6;
    private int NewScore7;
    private int NewScore8;
    private int NewScore9;
    private int NewScore10;

    int defaultScore1 = 1000;
    int defaultScore2 = 900;
    int defaultScore3 = 800;
    int defaultScore4 = 700;
    int defaultScore5 = 600;
    int defaultScore6 = 500;
    int defaultScore7 = 400;
    int defaultScore8 = 300;
    int defaultScore9 = 200;
    int defaultScore10 = 100;

    //Class that keeps track of high scores
    public void StartGame()
    {

        //HighScore = GameObject.Find("textScoreinCanvas").GetComponent<Text>();
        int High1 = PlayerPrefs.GetInt("High Score 1");
        int High2 = PlayerPrefs.GetInt("High Score 2");
        int High3 = PlayerPrefs.GetInt("High Score 3");
        int High4 = PlayerPrefs.GetInt("High Score 4");
        int High5 = PlayerPrefs.GetInt("High Score 5");
        int High6 = PlayerPrefs.GetInt("High Score 6");
        int High7 = PlayerPrefs.GetInt("High Score 7");
        int High8 = PlayerPrefs.GetInt("High Score 8");
        int High9 = PlayerPrefs.GetInt("High Score 9");
        int High10 = PlayerPrefs.GetInt("High Score 10");

        if (!PlayerPrefs.HasKey("End Score"))
            PlayerPrefs.SetInt("End Score", 0);

        if (!PlayerPrefs.HasKey("High Score 1"))
        {
            PlayerPrefs.SetInt("High Score 1", defaultScore1);
            HighScore1.text = string.Format("1: {0}", defaultScore1);
        }
        else
        {
            HighScore1.text = string.Format("1: {0}", High1);
            if (High1 < PlayerPrefs.GetInt("End Score"))
            {
                NewScore1 = PlayerPrefs.GetInt("End Score");
                PlayerPrefs.SetInt("High Score 1", NewScore1);
                HighScore1.text = string.Format("1: {0}", NewScore1);
            }
        }

        if (!PlayerPrefs.HasKey("High Score 2"))
        {
            PlayerPrefs.SetInt("High Score 2", defaultScore2);
            HighScore2.text = string.Format("2: {0}", defaultScore2);
        }
        else
        {
            HighScore2.text = string.Format("2: {0}", High2);
            if (High2 < PlayerPrefs.GetInt("End Score") && PlayerPrefs.GetInt("End Score") < High1)
            {
                NewScore2 = PlayerPrefs.GetInt("End Score");
                PlayerPrefs.SetInt("High Score 2", NewScore2);
                HighScore2.text = string.Format("2: {0}", NewScore2);
            }
        }


        if (!PlayerPrefs.HasKey("High Score 3"))
        {
            PlayerPrefs.SetInt("High Score 2", defaultScore3);
            HighScore3.text = string.Format("3: {0}", defaultScore3);
        }
        else
        {
            HighScore3.text = string.Format("3: {0}", High3);
            if (High3 < PlayerPrefs.GetInt("End Score") && PlayerPrefs.GetInt("End Score") < High2)
            {
                NewScore3 = PlayerPrefs.GetInt("End Score");
                PlayerPrefs.SetInt("High Score 3", NewScore3);
                HighScore3.text = string.Format("3: {0}", NewScore3);
            }
        }

        if (!PlayerPrefs.HasKey("High Score 4"))
        {
            PlayerPrefs.SetInt("High Score 4", defaultScore4);
            HighScore4.text = string.Format("4: {0}", defaultScore4);
        }
        else
        {
            HighScore4.text = string.Format("4: {0}", High4);
            if (High4 < PlayerPrefs.GetInt("End Score") && PlayerPrefs.GetInt("End Score") < High3)
            {
                NewScore4 = PlayerPrefs.GetInt("End Score");
                PlayerPrefs.SetInt("High Score 4", NewScore4);
                HighScore4.text = string.Format("4: {0}", NewScore4);
            }
        }

        if (!PlayerPrefs.HasKey("High Score 5"))
        {
            PlayerPrefs.SetInt("High Score 5", defaultScore5);
            HighScore5.text = string.Format("5: {0}", defaultScore5);
        }
        else
        {
            HighScore5.text = string.Format("5: {0}", High5);
            if (High5 < PlayerPrefs.GetInt("End Score") && PlayerPrefs.GetInt("End Score") < High4)
            {
                NewScore5 = PlayerPrefs.GetInt("End Score");
                PlayerPrefs.SetInt("High Score 5", NewScore5);
                HighScore5.text = string.Format("5: {0}", NewScore5);
            }
        }

        if (!PlayerPrefs.HasKey("High Score 6"))
        {
            PlayerPrefs.SetInt("High Score 6", defaultScore6);
            HighScore6.text = string.Format("6: {0}", defaultScore6);
        }
        else
        {
            HighScore6.text = string.Format("6: {0}", High6);
            if (High6 < PlayerPrefs.GetInt("End Score") && PlayerPrefs.GetInt("End Score") < High5)
            {
                NewScore6 = PlayerPrefs.GetInt("End Score");
                PlayerPrefs.SetInt("High Score 6", NewScore6);
                HighScore6.text = string.Format("6: {0}", NewScore6);
            }
        }

        if (!PlayerPrefs.HasKey("High Score 7"))
        {
            PlayerPrefs.SetInt("High Score 7", defaultScore7);
            HighScore7.text = string.Format("7: {0}", defaultScore7);
        }
        else
        {
            HighScore7.text = string.Format("7: {0}", High7);
            if (High7 < PlayerPrefs.GetInt("End Score") && PlayerPrefs.GetInt("End Score") < High6)
            {
                NewScore7 = PlayerPrefs.GetInt("End Score");
                PlayerPrefs.SetInt("High Score 7", NewScore7);
                HighScore7.text = string.Format("7: {0}", NewScore7);
            }
        }

        if (!PlayerPrefs.HasKey("High Score 8"))
        {
            PlayerPrefs.SetInt("High Score 8", defaultScore8);
            HighScore8.text = string.Format("8: {0}", defaultScore8);
        }
        else
        {
            HighScore8.text = string.Format("8: {0}", High8);
            if (High8 < PlayerPrefs.GetInt("End Score") && PlayerPrefs.GetInt("End Score") < High7)
            {
                NewScore8 = PlayerPrefs.GetInt("End Score");
                PlayerPrefs.SetInt("High Score 8", NewScore8);
                HighScore8.text = string.Format("8: {0}", NewScore8);
            }
        }

        if (!PlayerPrefs.HasKey("High Score 9"))
        {
            PlayerPrefs.SetInt("High Score 9", defaultScore9);
            HighScore9.text = string.Format("9: {0}", defaultScore9);
        }
        else
        {
            HighScore9.text = string.Format("9: {0}", High9);
            if (High9 < PlayerPrefs.GetInt("End Score") && PlayerPrefs.GetInt("End Score") < High8)
            {
                NewScore9 = PlayerPrefs.GetInt("End Score");
                PlayerPrefs.SetInt("High Score 9", NewScore9);
                HighScore9.text = string.Format("9: {0}", NewScore9);
            }
        }

        if (!PlayerPrefs.HasKey("High Score 10"))
        {
            PlayerPrefs.SetInt("High Score 10", defaultScore10);
            HighScore10.text = string.Format("10: {0}", defaultScore10);
        }
        else
        {
            HighScore10.text = string.Format("10: {0}", High10);
            if (High10 < PlayerPrefs.GetInt("End Score") && PlayerPrefs.GetInt("End Score") < High9)
            {
                NewScore10 = PlayerPrefs.GetInt("End Score");
                PlayerPrefs.SetInt("High Score 10", NewScore10);
                HighScore10.text = string.Format("10: {0}", NewScore10);
            }
        }
    }


    /**public void EndGame()
    {
        if (score > highScore)
        {
            PlayerPrefs.SetInt("High Score", score);
        }
    }**/

    //Class that transitions into the play scene when called
    public void Restart()
    {
        SceneManager.LoadScene("Play");
    }

    public void StartScreen()
    {
        SceneManager.LoadScene("Start");
    }

    public void Awake()
    {
        StartGame();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //When a prefab collides with the bucket edge collider, it is destroyed and the score text is incremented by 10
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Kernel")
        {
            Pop.Play();
            Destroy(collision.gameObject);
            score += 10;
            endScore = score;
            PlayerPrefs.SetInt("End Score", endScore);
            scoreText.text = string.Format("Score: {0}", score);
        }
    }
}
