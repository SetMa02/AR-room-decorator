using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New ItemDate", menuName ="ItemDate", order =51)]
public class ItemData : ScriptableObject
{
    [SerializeField] private Sprite _prewiew;
    [SerializeField] private string _label;
    [SerializeField] private GameObject _prefab;

    public Sprite Prewiew => _prewiew;
    public string Label => _label;
    public GameObject Prefab => _prefab;
}
