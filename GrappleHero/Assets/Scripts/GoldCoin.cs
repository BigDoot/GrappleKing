using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCoin : MonoBehaviour
{
    private PlayerMovement player;
    private throwhook throwHook;
    private bool collected = false;

    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
        throwHook = FindObjectOfType<throwhook>(); // find throwhook script
    }

    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (!collected)
            {
                collected = true;
                AudioManager.instance.Play("Coin");
                Destroy(gameObject);
                player.goldCoins++;
            }
        }
        else if (other.tag == "Grappling Hook")
        {
            if (!collected)
            {
                collected = true;
                AudioManager.instance.Play("Coin");
                Destroy(gameObject);
                player.goldCoins++;
                //Destroy(throwHook.curHook);
                //throwHook.ropeActive = false;
            }
        }
    }
}
