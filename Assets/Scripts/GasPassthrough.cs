﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasPassthrough : MonoBehaviour
{
    private GameController gameController;
    public AudioClip sound;
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        gameController = gameControllerObject.GetComponent<GameController>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (gameController.HasItem("BioSuite"))
            {
                AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);
                Destroy(gameObject);
            }
        }
    }
}
