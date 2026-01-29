using System;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public bool flag;

    public void Start()
    {
        if (flag == false)
        {
            print("Boolean flag isn’t set");
        }
        else
        {
            print("Boolean flag is set");
        }
        
        for (int i = 1; i <=10; i++)
        { 
            int result = (int)Math.Pow(2, i);
            Debug.Log($"The {i} power of 2 is {result}");
        }
    }

}
