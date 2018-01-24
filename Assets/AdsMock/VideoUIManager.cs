using System;
using UnityEngine;
using UnityEngine.UI;

public class VideoUIManager : MonoBehaviour
{
    public static event Action<string> VideoAdClosedEvent = delegate { };
    public Button btnWatch;
    public Button btnClose;
    
    
    void Start()
    {
        AddListeners();
    }
    
    private void AddListeners()
    {
        btnWatch.onClick.AddListener(OnBtnWatch);
        btnClose.onClick.AddListener(OnBtnClose);
    }

    private void OnBtnWatch()
    {
        VideoAdClosedEvent("Success");
        gameObject.SetActive(false);
    }
    
    private void OnBtnClose()
    {
        VideoAdClosedEvent("Cancel");
        gameObject.SetActive(false);
    }
}