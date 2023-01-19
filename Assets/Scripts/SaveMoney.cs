using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveMoney : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    private int coinsQuantity;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other);
            coinsQuantity++;
            text.text = "Coins Quantity: " + coinsQuantity;
        }
    }
}
