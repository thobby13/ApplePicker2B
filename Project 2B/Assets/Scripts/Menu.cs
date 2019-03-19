using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject Panel;
    int counter;

    public void Activate()
    {
        counter++;

        if (counter % 2 == 1)
        {
            Panel.gameObject.SetActive(false);
        }
        else
        {
            Panel.gameObject.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Panel.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }
}