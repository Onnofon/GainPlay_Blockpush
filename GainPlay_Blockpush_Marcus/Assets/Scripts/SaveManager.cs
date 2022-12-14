using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class SaveManager
{
    public static string directory = "/SaveData/";
    public static string filename = "MyData.txt";

    public static void Save(SaveObject so)
    {
        string dir = Application.dataPath + directory;

        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        string json = JsonUtility.ToJson(so);
        File.WriteAllText(dir + filename, json);
    }
}
