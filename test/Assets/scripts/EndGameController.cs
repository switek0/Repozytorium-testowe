using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameController : MonoBehaviour
{
    public PlayerController playerController;
    public int iloscPunktowDoZebrania;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (playerController.zebranepunkty == iloscPunktowDoZebrania)
            {
                Debug.Log("Zebrano wszystkie punkty. Koniec gry");
            }
        }
    }
}