using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePassthrougManager : MonoBehaviour
{
    private GameController gameController;
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (gameController.HasItem("Fire"))
            {
                Destroy(gameObject);
            }
        }
    }
}
