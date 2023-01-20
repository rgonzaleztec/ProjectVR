using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstablishPrefabPlate : MonoBehaviour
{

    [SerializeField] GameObject curryPrefab;
    [SerializeField] GameObject salmonPrefab;
    [SerializeField] GameObject hotdogPrefab;
    [SerializeField] GameObject pizzaPrefab;
    [SerializeField] Transform platePos;
    private string plateName;
    private GameObject food;

    // Start is called before the first frame update
    void Start()
    {
        plateName = PlayerPrefs.GetString("orderFood", "Curry");

        if(plateName == "Curry")
        {
            food = Instantiate(curryPrefab, platePos.position, Quaternion.identity);
        } else if (plateName == "Salmon"){
            food = Instantiate(salmonPrefab, platePos.position, Quaternion.identity);
        } else if (plateName == "Hotdog"){
            food = Instantiate(hotdogPrefab, platePos.position, Quaternion.identity);
        } else if (plateName == "Pizza"){
            food = Instantiate(pizzaPrefab, platePos.position, Quaternion.identity);
        } else {
            food = null;
        }
        food.name = "OrderFood";
    }
}
