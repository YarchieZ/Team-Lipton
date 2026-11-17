using UnityEngine;
using UnityEngine.UI;

public class UnitBuy : MonoBehaviour
{
    [SerializeField] ResourceManager resourceManager;
    [SerializeField] ResourceType resourceType;
    [SerializeField] private int cost;
    
    private Button buyButton;

    private void OnEnable()
    {
        buyButton = GetComponent<Button>();
        buyButton.onClick.AddListener(OnBuy);
    }

    private void OnBuy()
    {
        if (cost < resourceManager.GetResource(ResourceType.Money))
        {
            resourceManager.AddResource(ResourceType.Money, -cost);
            resourceManager.AddResource(resourceType, 1);
        }
    }

    private void OnDisable()
    {
        buyButton.onClick.RemoveAllListeners();
    }
}
