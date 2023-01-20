using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DropDown : MonoBehaviour
{

public TMP_Text output;
private string selectedPrefsFood="orderFood";
private string value = "";
private void Awake(){
    LoadData();
}
public void HandleDropDown(int val)
{
    
    if (val==0){
        output.text = "Curry";
        value = "Curry";
    }
    if (val==1){
        output.text = "Pizza";
        value = "Pizza";
    }
    if (val==2){
        output.text = "Burger";
        value = "Burger";
    }
    if (val==3){
        output.text = "Pasta";
        value = "Pasta";
    }
    if(val==4){
        output.text = "Salad";
        value = "Salad";
    }
    if(value != ""){
        SaveData(value);
    }

}

private void SaveData(string value){
    PlayerPrefs.SetString(selectedPrefsFood, value);
}

private void OnDestroy(){
    SaveData(value);
}
pritvate void LoadData(){
    string value = PlayerPrefs.GetString(selectedPrefsFood,0);


}

}