using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "LevelsData", menuName = "ScriptableObjects/LevelsData")]
public class LevelsData_UrbanEnigma : ScriptableObject
{
    //[FormerlySerializedAs("levels_")]
    public Level_UrbanEnigma[] levels_UrbanEnigma;

    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    // Unused integer variables
    int unusedInt1 = 42;
    int unusedInt2 = -10;
    int unusedInt3 = 987;

    // Unused float variables
    float unusedFloat1 = 3.14f;
    float unusedFloat2 = -2.5f;
    float unusedFloat3 = 1.618f;

    // Unused boolean variables
    bool unusedBool1 = true;
    bool unusedBool2 = false;
    bool unusedBool3 = true;

    // Unused string variables
    string unusedString1 = "Hello, world!";
    string unusedString2 = "Unity is awesome";
    string unusedString3 = "Garbage variables";

    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<





    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<


    void UnusedMethod1()
    {
        int randomInt = UnityEngine.Random.Range(0, 100);
        float randomFloat = UnityEngine.Random.Range(-10f, 10f);
        bool randomBool = UnityEngine.Random.value > 0.5f;

        Debug.Log($"UnusedMethod1: randomInt={randomInt}, randomFloat={randomFloat}, randomBool={randomBool}");
    }

    int UnusedMethod2(int param1, float param2)
    {
        int result = param1 * Mathf.FloorToInt(param2);
        Debug.Log($"UnusedMethod2: param1={param1}, param2={param2}, result={result}");
        return result;
    }

    bool UnusedMethod3(string param1)
    {
        bool result = param1.Length > 5;
        Debug.Log($"UnusedMethod3: param1='{param1}', result={result}");
        return result;
    }

    void UnusedMethod4(GameObject param1, Transform param2)
    {
        if (param1 != null && param2 != null)
        {
            param1.transform.position = param2.position + Vector3.up * UnityEngine.Random.Range(1f, 5f);
            Debug.Log($"UnusedMethod4: param1={param1.name}, param2={param2.name}, new position={param1.transform.position}");
        }
        else
        {
            Debug.Log("UnusedMethod4: One or both parameters are null.");
        }
    }

    float UnusedMethod5(int[] param1, float[] param2)
    {
        float result = 0f;
        for (int i = 0; i < param1.Length; i++)
        {
            result += param1[i] * param2[i];
        }
        Debug.Log($"UnusedMethod5: result={result}");
        return result;
    }
    void UnusedMethod7()
{
    Debug.Log("UnusedMethod7: This method does nothing.");
}

int UnusedMethod8(bool param1)
{
    int result = param1 ? 42 : -42;
    Debug.Log($"UnusedMethod8: param1={param1}, result={result}");
    return result;
}

bool UnusedMethod9(string param1, string param2)
{
    bool result = !string.IsNullOrEmpty(param1) && !string.IsNullOrEmpty(param2) && param1.Equals(param2);
    Debug.Log($"UnusedMethod9: param1='{param1}', param2='{param2}', result={result}");
    return result;
}

void UnusedMethod10(GameObject param1)
{
    if (param1 != null)
    {
        param1.SetActive(!param1.activeSelf);
        Debug.Log($"UnusedMethod10: param1={param1.name}, new state={param1.activeSelf}");
    }
    else
    {
        Debug.Log("UnusedMethod10: Parameter is null.");
    }
}

    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

}

[Serializable]
public class Level_UrbanEnigma
{
    //[FormerlySerializedAs("level")]
    public int level_UrbanEnigma;
    //[FormerlySerializedAs("spritesLevel")]
    public Sprite[] spritesLevel_UrbanEnigma;


    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    // Unused integer variables
    int unusedInt1 = 42;
    int unusedInt2 = -10;
    int unusedInt3 = 987;

    // Unused float variables
    float unusedFloat1 = 3.14f;
    float unusedFloat2 = -2.5f;
    float unusedFloat3 = 1.618f;

    // Unused boolean variables
    bool unusedBool1 = true;
    bool unusedBool2 = false;
    bool unusedBool3 = true;

    // Unused string variables
    string unusedString1 = "Hello, world!";
    string unusedString2 = "Unity is awesome";
    string unusedString3 = "Garbage variables";

    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
}
