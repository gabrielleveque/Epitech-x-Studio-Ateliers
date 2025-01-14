using UnityEngine;

public class LoadAndSave : MonoBehaviour
{
    public static LoadAndSave instance;

    public void SaveData()
    {
        PlayerPrefs.SetInt("levelReached", 2);
    }
}
