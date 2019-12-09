using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private GameController gameController;
    private Collider2D[] c;
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
        c = GetComponents<Collider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (tag == "Key1")
            {
                if (gameController.HasItem("Key1"))
                {
                    foreach(var cc in c)
                    {
                        cc.enabled = false;
                    }
                }
            }
            else if(tag == "Key2")
            {
                Debug.Log(tag);
                if (gameController.HasItem("Key2"))
                {
                    foreach (var cc in c)
                    {
                        cc.enabled = false;
                    }
                }
            }
            else if (tag == "Key3")
            {
                if (gameController.HasItem("Key3"))
                {
                    foreach (var cc in c)
                    {
                        cc.enabled = false;
                    }
                }
            }
        }
    }
}
