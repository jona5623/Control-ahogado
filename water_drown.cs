using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_drown : MonoBehaviour
{

    public int drown_damage = 1;
    public GameObject Player;

    private void OnTrtiggerdEnter(Collider other)
    {

        if (other.tag == "Player")
        {

            Player.GetComponent<drown>().player_live -= drown_damage;

        }

    }



}
