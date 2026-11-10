using System;
using UnityEngine;

public enum ResourceType
{
    Money
}
public class ResourceManager : MonoBehaviour
{
    [SerializeField] private UImanager uiManager;
    public int Money { get; private set; }

    public void ChangeMoney(int value)
    {
        Money += value;
        uiManager.UpdateUI(ResourceType.Money, Money);
    }
}
