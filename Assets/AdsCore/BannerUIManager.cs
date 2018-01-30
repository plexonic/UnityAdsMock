using UnityEngine;
using UnityEngine.UI;

public class BannerUIManager : MonoBehaviour
{
    public Image bannerImage;
    
    void Awake()
    {
        Hide();
    }

    public void Show()
    {
        bannerImage.gameObject.SetActive(true);

    }

    public void Hide()
    {
        bannerImage.gameObject.SetActive(false);
    }
}