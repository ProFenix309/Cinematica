using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GameData 
{
    [SerializeField]List<PlayerData> _playerData;
    [SerializeField]List<WorldData> _worldData;

    public List<PlayerData> PlyrDt { get => _playerData; set => _playerData = value; }
    public List<WorldData> WrldDt { get => _worldData; set => _worldData = value; }
}
