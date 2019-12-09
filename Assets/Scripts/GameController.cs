using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private string[] itemList = { "Key1", "Key2", "Key3", "fire", "gas", "bio", "bat" };

    private List<string> playerItem;
    void Start()
    {
        playerItem = new List<string>();
        playerItem.Add("Bat");
        //playerItem.Add("Key2");
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
}
