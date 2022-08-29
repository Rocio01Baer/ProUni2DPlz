using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributesExample : MonoBehaviour
{
    [Space] // visualiza atributos agrupados en Unity
    [Header("numbers")] //nombre del grupo
    public int score;

    [SerializeField] //visualiza en unity atributo privado en Unity
    private int money;

    [Space]
    [Header("Other values")]
    [SerializeField]
    private int password;

    [HideInInspector] //esconde atributo publico 
    public int numbersRand;

    [Space]
    [Header("Slides")]
    [Range(0, 5)]//Establece el rango de valores que puede tener una variable
    public int lifes;
    [SerializeField]
    [Min(0)] //Establece el valor mínimo de la variable
    private int numberRan;

    [Space]
    [Header("Texts")]
    public string name; //Una línea para escribir desde el inspector
    [TextArea]//Permite escribir muchas líneas desde el inspector (caja más grande de texto)
    public string dialogue;

    [Header("Tools")]
    //Tooltip: Muestra un mensaje al colocar el mouse por encima
    [Tooltip("Esta es la id del jugador, cambiar con cuidado")]
    [SerializeField]
    private string id;

    [ContextMenu("Call Function")]//Permite ejecutar una función desde el inspector a través del nombre dado
    public void MyFunction()
    {
        Debug.Log("MyFunction fue ejecutada");
    }

    public Jugador jugador;
}



[System.Serializable]
public class Jugador
{
    public int idPlayer;
    public string namePlayer;
}