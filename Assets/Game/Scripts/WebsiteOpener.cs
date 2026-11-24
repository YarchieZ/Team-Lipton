using UnityEngine;
using UnityEngine.UI;

public class WebsiteOpener : MonoBehaviour
{
    [SerializeField] private Button openButton;
    private string websiteUrl = "https://avatars.mds.yandex.net/i?id=f9065058b7f54d0915bcef64317b7e98_sr-12491025-images-thumbs&n=13";

    void Awake()
    {
        if (openButton != null)
            openButton.onClick.AddListener(OpenSite);
    }

    void OpenSite()
    {
        Application.OpenURL(websiteUrl);
    }
}
