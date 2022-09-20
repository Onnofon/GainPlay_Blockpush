using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour
{
   public void Save(SaveObject so)
    {
        SaveManager.Save(so);
    }
}
