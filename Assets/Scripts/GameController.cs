using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Sprite FireExtingusher;
    public Sprite GasMask;
    public Sprite BioSuite;
    public Sprite Key1;
    public Sprite Key2;
    public Sprite Key3;
    public Sprite HeartFull;
    public Sprite HeartDrained;

    public GameObject FireExImage;
    public GameObject GasMaskImage;
    public GameObject BioSuiteImage;
    public GameObject Key1Image;
    public GameObject Key2Image;
    public GameObject Key3Image;
    public GameObject[] Health;

    private int PlayerHealth;

    private SceneLoader sc;

    private List<string> playerItem;
    void Start()
    {
        playerItem = new List<string>();
        playerItem.Add("Bat");
        //playerItem.Add("Key2");
        PlayerHealth = 100;
        sc = GetComponent<SceneLoader>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddItem(string itemName)
    {
        playerItem.Add(itemName);
        //Debug.Log("Added");
    }

    public bool HasItem(string itemName)
    {
        bool isMatch = false;
        foreach (var item in playerItem)
        {
            if (item.ToString().Equals(itemName))
            {
                //Debug.Log("" + item.ToString());
                isMatch = true;
            }
        }
        //Debug.Log(isMatch + "");
        return isMatch;
    }

    public bool Combat()
    {
        if (PlayerHealth == 100)
        {
            PlayerHealth = 75;
            Health[3].GetComponent<Image>().sprite = HeartDrained;
            return true;
        }
        else if(PlayerHealth == 75)
        {
            PlayerHealth = 50;
            Health[2].GetComponent<Image>().sprite = HeartDrained;
            return true;
        }
        else if(PlayerHealth == 50)
        {
            PlayerHealth = 25;
            Health[1].GetComponent<Image>().sprite = HeartDrained;
            return true;
        }
        else if (PlayerHealth == 25)
        {
            PlayerHealth = 0;
            Health[0].GetComponent<Image>().sprite = HeartDrained;
            return false;
        }
        else
        {
            return false;
        }
    }

    public bool AddHealth()
    {
        if (PlayerHealth == 100)
        {
            return false;
        }
        else if (PlayerHealth == 75)
        {
            PlayerHealth = 100;
            Health[3].GetComponent<Image>().sprite = HeartFull;
            return true;
        }
        else if (PlayerHealth == 50)
        {
            PlayerHealth = 75;
            Health[2].GetComponent<Image>().sprite = HeartFull;
            return true;
        }
        else if (PlayerHealth == 25)
        {
            PlayerHealth = 50;
            Health[1].GetComponent<Image>().sprite = HeartFull;
            return true;
        }
        else
        {
            return true;
        }
    }

    public void AddFireEx()
    {
        FireExImage.GetComponent<Image>().sprite = FireExtingusher;
    }
    public void AddGasMask()
    {
        GasMaskImage.GetComponent<Image>().sprite = GasMask;
    }
    public void AddBioSuite()
    {
        BioSuiteImage.GetComponent<Image>().sprite = BioSuite;
    }
    public void AddKey1()
    {
        Key1Image.GetComponent<Image>().sprite = Key1;
    }
    public void AddKey2()
    {
        Key2Image.GetComponent<Image>().sprite = Key2;
    }
    public void AddKey3()
    {
        Key3Image.GetComponent<Image>().sprite = Key3;
    }

    public void WinGame()
    {
        sc.LoadWinScene();
    }

    public void LoseGame()
    {
        sc.LoadLoseScene();
    }
}
