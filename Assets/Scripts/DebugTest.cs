using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{

    private void Start()
    {
        Debug.Log("Soy un mensaje normal que aparece en consola");
        Debug.LogWarning("Soy un mensaje de advertencia que aparece en consola");
        Debug.LogError("SOY UN MENSAJE DE ERROR D:");

        for (int i = 0; i < 1; i++)
        {
            //El valor de "i" saldrá azul en cosola
            Debug.LogFormat($"<color = blue> {i} </color>");
        }
    }

}