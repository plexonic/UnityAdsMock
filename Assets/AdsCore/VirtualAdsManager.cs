using System;
using UnityEngine;

public class VirtualAdsManager : MonoBehaviour
{
    public static VirtualAdsManager Instance { get; private set; }
    
    public event Action<string> InterstitialAdClosedEvent = delegate { };
    public event Action<string> VideolAdClosedEvent = delegate { };

    public BannerUIManager bannerAd;
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
        bannerAd.Show();
    }
    
    public void HideBannerAd()
    {
        bannerAd.Hide();
    }

    public void ShowInterstitialAd()
    {
        interstitialAd.Show();
    }

    public void OnInterstitialAdClosedEvent(string status)
    {
        interstitialAd.Hide();
        InterstitialAdClosedEvent(status);
    }
    
    public void ShowVideoAd()
    {
        videoAd.Show();
    }
    
    public void OnVideoAdClosedEvent(string status)
    {
        videoAd.Hide();
        VideolAdClosedEvent(status);
    }
}
