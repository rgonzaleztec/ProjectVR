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
        this.value = "Curry";
    }
    if (val==1){
        output.text = "Hotdog";
         this.value = "Hotdog";
    }
    if (val==2){
        output.text = "Pizza";
         this.value = "Pizza";
    }
    if(val==3){
        output.text = "Salmon";
         this.value = "Salmon";
    
    if( this.value != ""){
        SaveData();
    }
    }
}

private void SaveData(){
    PlayerPrefs.SetString(selectedPrefsFood, this.value);
}

private void OnDestroy(){
    SaveData();
}
private void LoadData(){
    string valuePref = PlayerPrefs.GetString(selectedPrefsFood, "orderFood");
}

}
