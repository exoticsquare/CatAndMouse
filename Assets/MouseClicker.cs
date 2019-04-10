using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseClicker : MonoBehaviour
{
    public int numberOfHearts;
    public int health;
    public Image[] hearts;
    public Sprite FullHearts;
    public Sprite EmptyHearts;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = FullHearts;
            }
            else
            {
                hearts[i].sprite = EmptyHearts;
            }

            if (i < numberOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            //Get the mouse position on the screen and send a raycast into the game world from that position.
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

             //If something was hit, the RaycastHit2D.collider will not be null.
             if (hit.collider != null)
             {
                Destroy(GameObject.Find("Player"));
             }
             else
             {
                 health = health-1;
                 Debug.Log(health);
             }
        }
        
    }
}