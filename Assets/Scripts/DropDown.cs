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
        output.text = "Pizza";
         this.value = "Pizza";
    }
    if (val==2){
        output.text = "Burger";
         this.value = "Burger";
    }
    if (val==3){
        output.text = "Pasta";
         this.value = "Pasta";
    }
    if(val==4){
        output.text = "Salad";
         this.value = "Salad";
    }
    if( this.value != ""){
        SaveData(this.value);
    }

}

private void SaveData(){
    PlayerPrefs.SetString(selectedPrefsFood, this.value);
}

private void OnDestroy(){
    SaveData(this.value);
}
private void LoadData(){
    string valuePref = PlayerPrefs.GetString(selectedPrefsFood,0);
}

}