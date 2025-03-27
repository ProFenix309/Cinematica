using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class WorldData
{
    [SerializeField] bool _completed;
    [SerializeField] List<LevelData> _levelDatas = new List<LevelData>();

    public List<LevelData> LvlDts { get => _levelDatas; set => _levelDatas = value; }
    public bool Cmplt0d { get => _completed; set => _completed = value; }
}
