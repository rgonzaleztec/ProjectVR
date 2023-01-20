using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DropDown : MonoBehaviour
{

public TMP_Text output;

public void HandleDropDown(int val)
{
    if (val==0){
        output.text = "Curry";
    }
    if (val==1){
        output.text = "Pizza";
    }
    if (val==2){
        output.text = "Burger";
    }
    if (val==3){
        output.text = "Pasta";
    }
    if(val==4){
        output.text = "Salad";
    }

}

}