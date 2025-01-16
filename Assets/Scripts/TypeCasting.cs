using System;
using UnityEngine;

public class TypeCasting : MonoBehaviour
{
    // Implicit Casting

    // Explicit Casting
    /*Küçük çaplý bir data türünden büyük çaplý bir data türüne geçiþ yaparken kullandýðýmýz kod dili otomatik olarak geçiþi yapar
     * 
     * 
     */
    int a = 5;
    string b = "2";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(a + Int32.Parse(b));
    }
}
