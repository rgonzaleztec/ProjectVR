using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveMoney : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] AudioSource cashierSound;
    private int coinsQuantity;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            cashierSound.Play();
            Destroy(other);
            coinsQuantity++;
            text.text = "Coins Quantity: " + coinsQuantity;
        }
    }
}
