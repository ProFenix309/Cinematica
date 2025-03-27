using System.IO;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class DataManager : MonoBehaviour
{
    [SerializeField] GameData _game;

    string filepath;

    public GameData Gm { get => _game; set => _game = value; }

    private void Awake()
    {
        filepath = Application.persistentDataPath + "/GameData";
        Debug.Log(filepath);
        ValidarData();
    }

    public void ValidarData()
    {
        if (!File.Exists(filepath))
        {
            File.CreateText(filepath).Close();
            SaveData();
        }
        else
        {
            LoadData();
        }
    }


    public void SaveData()
    {
       

        string json = JsonUtility.ToJson(_game);

        File.WriteAllText(filepath, json);

    }

    public void LoadData()
    {
        string json = File.ReadAllText(filepath);
        JsonUtility.FromJson<GameData>(json);
    }

}
