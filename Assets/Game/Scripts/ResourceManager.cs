using System;
using System.Collections.Generic;
using UnityEngine;

public enum ResourceType
{
    Money,
    Soldier,
    Drone,
    Tank,
    Helicopter,
    WarShip,
    AntiAir,
    AirForce,
    GroundForce,
    NavalForce
}

[Serializable]
public class Resource
{
    public int Amount;
    public int Level;
    public int Force;
}
public class ResourceManager : MonoBehaviour
{
    [SerializeField] private UImanager uiManager;
    [SerializeField] private Resource[] resourcesMassive;
    private Dictionary<ResourceType, Resource> resources;

    private void Awake()
    {
        resources = new Dictionary<ResourceType, Resource>();
        foreach (int res in Enum.GetValues(typeof(ResourceType)))
        {
            resources.Add((ResourceType)res, resourcesMassive[res]);
        }
    }
    public void AddResource(ResourceType resourceType, int value)
    {
        if (resources.ContainsKey(resourceType))
        {
            resources[resourceType].Amount += value;
            uiManager.UpdateUIAmount(resourceType, resources[resourceType].Amount);
            uiManager.UpdateUILevel(resourceType, resources[resourceType].Level);
            uiManager.UpdateUIForce(resourceType, resources[resourceType].Force);
        }
    }
    public int GetResource(ResourceType resourceType)
    {
        if (resources.ContainsKey(resourceType))
            return resources[resourceType].Amount;
        return 0;
    }
    public void AddLevel(ResourceType resourceType, int value)
    {
        if (resources.ContainsKey(resourceType))
        {
            resources[resourceType].Level += value;
            uiManager.UpdateUILevel(resourceType, resources[resourceType].Level);
            uiManager.UpdateUILevel(resourceType, resources[resourceType].Force);
        }
    }
    public int GetLevel(ResourceType resourceType)
    {
        if (resources.ContainsKey(resourceType))
            return resources[resourceType].Level;
        return 0;
    }
    public void AddForce(ResourceType resourceType, int value)
    {
        if (resources.ContainsKey(resourceType))
        {
            resources[resourceType].Force += value;
            uiManager.UpdateUIForce(resourceType, resources[resourceType].Force);
        }
    }
    public int GetForce(ResourceType resourceType)
    {
        if (resources.ContainsKey(resourceType))
            return resources[resourceType].Force;
        return 0;
    }
}
