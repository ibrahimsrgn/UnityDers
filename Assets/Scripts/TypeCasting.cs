using System;
using UnityEngine;

public class TypeCasting : MonoBehaviour
{
    // Implicit Casting

    // Explicit Casting
    /*K���k �apl� bir data t�r�nden b�y�k �apl� bir data t�r�ne ge�i� yaparken kulland���m�z kod dili otomatik olarak ge�i�i yapar
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
