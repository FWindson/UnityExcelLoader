using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class LevelTableLoader : MonoBehaviour
{
    private void Start()
    {
        TextAsset txtLevelTable = Resources.Load<TextAsset>("LevelTable.xml");
        
    }
}
