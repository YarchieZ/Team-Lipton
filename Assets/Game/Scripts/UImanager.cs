using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[Serializable]
public class ResourceUI
{
    public ResourceType type;
    public string stringAmount;
    public string stringLevel;
    public string stringForce;
    public TextMeshProUGUI textAmount;
    public TextMeshProUGUI textLevel;
    public TextMeshProUGUI textForce;
}
public class UImanager : MonoBehaviour
{
    [SerializeField] private List<ResourceUI> units = new List<ResourceUI>();

    public void UpdateUIAmount(ResourceType selectedType, int value)
    {
        foreach (ResourceUI item in units)
        {
            if (selectedType == item.type)
            {
                if (item.textAmount == null)
                    return;
                if (item.stringAmount != null)
                {
                    item.textAmount.text = $"{item.stringAmount}{value}";
                }
                else
                {
                    item.textAmount.text = value.ToString();
                }
            }
        }
    }
    public void UpdateUILevel(ResourceType selectedType, int value)
    {
        foreach (ResourceUI item in units)
        {
            if (selectedType == item.type)
            {
                if (item.textLevel == null)
                    return;
                if (item.stringLevel != null)
                {
                    item.textLevel.text = $"{item.stringLevel}{value}";
                }
                else
                {
                    item.textLevel.text = value.ToString();
                }
            }
        }
    }
    public void UpdateUIForce(ResourceType selectedType, int value)
    {
        foreach (ResourceUI item in units)
        {
            if (selectedType == item.type)
            {
                if (item.textForce == null)
                    return;
                if (item.stringForce != null)
                {
                    item.textForce.text = $"{item.stringForce}{value}";
                }
                else
                {
                    item.textForce.text = value.ToString();
                }
            }
        }
    }
}