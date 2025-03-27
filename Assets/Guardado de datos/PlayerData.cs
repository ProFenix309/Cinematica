using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerData 
{
    [SerializeField] int _life;
    [SerializeField] int _score;
    [SerializeField] int _coins;
    [SerializeField] List<int> _items = new List<int>();

    public int Lf { get => _life; set => _life = value; }
    public int Scr { get => _score; set => _score = value; }
    public int Cns { get => _coins; set => _coins = value; }
    public List<int> Itms { get => _items; set => _items = value; }
}
