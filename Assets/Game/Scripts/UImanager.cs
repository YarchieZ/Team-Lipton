using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[Serializable]
public class ResourceUI
{
    public ResourceType type;
    public string stringValue;
    public TextMeshProUGUI textUI;
}
public class UImanager : MonoBehaviour
{
    [SerializeField] private List<ResourceUI> units = new List<ResourceUI>();

    public void UpdateUI(ResourceType selectedType, int value)
    {
        foreach (ResourceUI item in units)
        {
            if (selectedType == item.type)
            {
                if (item.stringValue != null)
                {
                    item.textUI.text = $"{item.stringValue}{value}";
                }
                else
                {
                    item.textUI.text = value.ToString();
                }
            }
        }
    }
}