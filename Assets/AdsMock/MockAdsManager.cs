using System;
using UnityEngine;

public class MockAdsManager : MonoBehaviour
{
    public static MockAdsManager Instance { get; private set; }
    
    public static event Action<string> InterstitialAdClosedEvent = delegate { };
    public static event Action<string> VideolAdClosedEvent = delegate { };

    public GameObject bannerAd;
    public InterstitialUIManager interstitialAd;
    public VideoUIManager videoAd;

    private void Awake()
    {
        Instance = this;
        AddListeners();
    }
    
    private void AddListeners()
    {
        InterstitialUIManager.InterstitialAdClosedEvent += OnInterstitialAdClosedEvent;
        VideoUIManager.VideoAdClosedEvent += OnVideoAdClosedEvent;
    }

    public void ShowBannerAd()
    {
        bannerAd.gameObject.SetActive(true);
    }
    
    public void HideBannerAd()
    {
        bannerAd.gameObject.SetActive(false);
    }

    public void ShowInterstitialAd()
    {
        interstitialAd.gameObject.SetActive(true);
    }

    public void OnInterstitialAdClosedEvent(string status)
    {
        InterstitialAdClosedEvent(status);
    }
    
    public void ShowVideoAd()
    {
        videoAd.gameObject.SetActive(true);
    }
    
    public void OnVideoAdClosedEvent(string status)
    {
        VideolAdClosedEvent(status);
    }
}
