using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlayer : MonoBehaviour
{
    public GameObject Player;

    // Update is called once per frame
    void DestroyPlayer()
    {
        Player.SetActive(false);   
    }
}
