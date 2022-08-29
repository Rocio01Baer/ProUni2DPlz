using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TernaryOp : MonoBehaviour
{
    public int a;
    public int b;

    void Start()
    {
        string sum = a == b ? "Es igual" : "No es igual";
        Debug.Log(sum);
    }
}
