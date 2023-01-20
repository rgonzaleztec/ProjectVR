using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//using text mesh pro;
using TMPro;


public class MealToCook : MonoBehaviour
{
    public TMP_Text textM;
    public TMP_Text falta;
    int ingredientesEncontrados = 0;
    public GameObject plato;
    List<GameObject> ingredientes = new List<GameObject>();
    List<List<string>> ingredientesString = new List<List<string>>()
    {
        new List<string>()
        {
            "Pizza",
            "Salsa de tomate",
            "Salami"
        },
        new List<string>()
        {
            "Hotdog",
            "Salami entero",
            "Salsa de tomate"
        },
        new List<string>()
        {
            "Curry",
            "Chile dulce en rodajas",
            "Salsa de Tomate"
        },
        new List<string>()
        {
            "Salmon",
            "Salmon",
            "Sal"
        },

    };
    List<string> listaAPreparar;


    // Start is called before the first frame update
    void Start()
    {
        string text = System.IO.File.ReadAllText("Assets/Scripts/meal.txt");
        textM.text = "Tienes que cocinar: " + text;

        for (int i = 0; i < ingredientesString.Count; i++)
        {
            if (ingredientesString[i][0] == text)
            {
                listaAPreparar = ingredientesString[i];
            }
        }
        
        for (int i = 1; i < listaAPreparar.Count; i++)
        {
            falta.text += "\n" + listaAPreparar[i];
        }
        
    }

    bool verificaIngrediente(string ingredient){
        bool encontrado = false;
        //for each child
        for(int i = 0; i < listaAPreparar.Count; i++){
            //if child name is ingredient
            if(listaAPreparar[i] == ingredient){
                //set child active
                Debug.Log("Ingrediente: " + ingredient + " encontrado");
                ingredientesEncontrados++;
                encontrado = true;
                break;

            }
        }
        return encontrado;
    }
    bool verificaPlato(){
    
        Debug.Log("ingredientesEncontrados: " + ingredientesEncontrados);
        Debug.Log("listaAPreparar.Count: " + (listaAPreparar.Count -1));
        if(ingredientesEncontrados == (listaAPreparar.Count - 1)){
            Debug.Log("Plato listo");
            plato.SetActive(true);
            textM.text = "Plato listo, revisa el mostrador";
            //color textM green success
            textM.color = new Color32(0,255,0,255);
            GameObject comida = GameObject.Find(listaAPreparar[0]);
            comida.transform.SetParent(plato.transform);
            comida.transform.localPosition = new Vector3(0f,0.05f,0f);
            return true;
        }
        return false;

    }

    //on trigger enter
    void OnTriggerEnter(Collider other){
        //if tag is meal
        if(other.tag == "meal"){
           if(verificaIngrediente(other.name)){
                ingredientes.Add(other.gameObject);
                Debug.Log(other.transform.localScale);
                other.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
                Debug.Log(other.transform.localScale);
                other.transform.position= new Vector3(5.09899998f,2.14129996f,-8.95602131f);
                Debug.Log(other.transform.localPosition);

                verificaPlato();
            }
            
        }
        
        
    }

    public void cambiarDeEscena(){
        //cambiar de escena
        SceneManager.LoadScene("ThirdSceneRestaurant");

    }
}
