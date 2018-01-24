using System;
using UnityEngine;
using UnityEngine.UI;

public class InterstitialUIManager : MonoBehaviour
{
    public static event Action<string> InterstitialAdClosedEvent = delegate { };
    public Button btnClose;

    void Start()
    {
        AddListeners();
    }

    private void AddListeners()
    {
        btnClose.onClick.AddListener(OnBtnClose);
    }

    private void OnBtnClose()
    {
        gameObject.SetActive(false);
        InterstitialAdClosedEvent("Success");
    }
}