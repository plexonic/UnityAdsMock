using System;
using UnityEngine;
using UnityEngine.UI;

public class InterstitialUIManager : MonoBehaviour
{
    public static event Action<string> InterstitialAdClosedEvent = delegate { };
    public Button btnClose;
    public Image interstitialImage;

    void Awake()
    {
        AddListeners();
        Hide();
    }

    private void AddListeners()
    {
        btnClose.onClick.AddListener(OnBtnClose);
    }
    
    public void Show()
    {
        interstitialImage.gameObject.SetActive(true);   
        btnClose.gameObject.SetActive(true);   
    }
    
    public void Hide()
    {
        interstitialImage.gameObject.SetActive(false);   
        btnClose.gameObject.SetActive(false);   
    }

    private void OnBtnClose()
    {
        InterstitialAdClosedEvent("Success");
    }
}