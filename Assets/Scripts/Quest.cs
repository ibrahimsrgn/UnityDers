using UnityEngine;

public class Quest : MonoBehaviour
{
    string unityname= "Unity6";
    string questName = "The Lost Sword";
    string questObj;
    void Start()
    {
        foreach (char letter in questName)
        {
            questObj += letter+" ";
        }
        Debug.Log(questObj);
        Debug.Log(unityname.Substring(0,unityname.Length-1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
