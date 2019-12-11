using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUpManager : MonoBehaviour
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
            gameController.AddItem(this.tag);
            if (tag == "Medkit")
            {
                if (gameController.AddHealth())
                {
                    Destroy(gameObject);
                }
            }
            else
            {
                if (tag == "Fire")
                {
                    gameController.AddFireEx();
                }
                else if(tag == "GasMask")
                {
                    gameController.AddGasMask();
                }
                else if(tag == "BioSuite")
                {
                    gameController.AddBioSuite();
                }
                else if(tag == "Key1")
                {
                    gameController.AddKey1();
                }
                else if (tag == "Key2")
                {
                    gameController.AddKey2();
                }
                else if (tag == "Key3")
                {
                    gameController.AddKey3();
                }
                Destroy(gameObject);
            }
        }
    }
}
