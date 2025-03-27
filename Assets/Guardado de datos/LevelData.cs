using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class LevelData
{
    [SerializeField] bool _completed;
    [SerializeField] int _playerId;

    public bool Cpltd { get => _completed; set => _completed = value; }
    public int PlyrId { get => _playerId; set => _playerId = value; }
}
