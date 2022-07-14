using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private TMP_Text _label;
    [SerializeField] private Button _selectionButton;

    private ItemData _itemData;

    public event UnityAction<ItemData> ItemSelected;
    public event UnityAction<Item> ItemDisabled;

    private void OnEnable()
    {
        _selectionButton.onClick.AddListener(OnSelectionButtonClick);    
    }

    private void OnDisable()
    {
        ItemDisabled?.Invoke(this);
        _selectionButton.onClick.RemoveListener(OnSelectionButtonClick);
    }


    private void OnSelectionButtonClick()
    {
        ItemSelected?.Invoke(_itemData);
    }

    public void Initialize(ItemData itemData)
    {
        _itemData = itemData;
        _image.sprite = itemData.Prewiew;
        _label.text = itemData.Label;
        Debug.Log(itemData.Label);
    }
}
