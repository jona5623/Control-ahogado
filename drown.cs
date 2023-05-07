using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drown : MonoBehaviour
{

    public int player_live;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (player_live <= 0)
        {

            Debug.Log("You are drowning ");

        }

    }
}
