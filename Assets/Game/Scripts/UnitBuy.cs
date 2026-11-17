using UnityEngine;
using UnityEngine.UI;

public class UnitBuy : MonoBehaviour
{
    [SerializeField] ResourceManager resourceManager;
    [SerializeField] ResourceType resourceType;
    [SerializeField] private int cost;
    [SerializeField] private bool addForce;
    [SerializeField] private int forceAmount;
    
    private Button buyButton;

    private void OnEnable()
    {
        buyButton = GetComponent<Button>();
        buyButton.onClick.AddListener(OnBuy);
    }

    private void OnBuy()
    {
        if (cost <= resourceManager.GetResource(ResourceType.Money))
        {
            resourceManager.AddResource(ResourceType.Money, -cost);
            resourceManager.AddResource(resourceType, 1);
            if (addForce)
            {
                resourceManager.AddForce(resourceType, forceAmount);
            }
        }
    }

    private void OnDisable()
    {
        buyButton.onClick.RemoveAllListeners();
    }
}
