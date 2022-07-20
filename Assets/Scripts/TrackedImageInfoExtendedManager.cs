using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(ARTrackedImageManager))]
public class TrackedImageInfoExtendedManager : MonoBehaviour
{

    private ARTrackedImageManager m_TrackedImageManager;
    public GameObject InsideATMMenu;
    public GameObject OutsideATMMenu;
    

    void Awake()
    {
        m_TrackedImageManager = GetComponent<ARTrackedImageManager>();
        //display = m_TrackedImageManager.trackedImagePrefab.GetComponent<Button>();
        //display.GetComponentInChildren<Text>().text = "Awake";
    }

    void OnEnable()
    {
        m_TrackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
    }

    void OnDisable()
    {
        m_TrackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
    }

    void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs eventArgs)
    {

        foreach (ARTrackedImage trackedImage in eventArgs.added)
        {
            switch (trackedImage.referenceImage.name.ToUpper())
            {
                case "20210726_110354":
                    // m_TrackedImageManager.trackedImagePrefab = InsideATMMenu;
                    //PromptPanel.SetActive(false);
                    //InsideATMMenu.SetActive(true);
                    Instantiate(OutsideATMMenu, Vector3.zero, Quaternion.identity);
                    //Instantiate(InsideATMMenu);
                    break;
                case "20210726_110408":
                    //PromptPanel.SetActive(false);
                    //InsideATMMenu.SetActive(true);
                    //Instantiate(InsideATMMenu);
                    Instantiate(OutsideATMMenu, Vector3.zero, Quaternion.identity);
                    // m_TrackedImageManager.trackedImagePrefab = InsideATMMenu;
                    break;
                case "20210726_110415":
                    //PromptPanel.SetActive(false);
                    //InsideATMMenu.SetActive(true);
                    //Instantiate(InsideATMMenu);
                    Instantiate(OutsideATMMenu, Vector3.zero, Quaternion.identity);
                    //m_TrackedImageManager.trackedImagePrefab = InsideATMMenu;
                    break;
                case "20210726_110506":
                    //PromptPanel.SetActive(false);
                    //InsideATMMenu.SetActive(true);
                    //Instantiate(InsideATMMenu);
                    Instantiate(OutsideATMMenu, Vector3.zero, Quaternion.identity);
                    //m_TrackedImageManager.trackedImagePrefab = InsideATMMenu;
                    break;
                case "IMG_0330":
                    // PromptPanel.SetActive(false);
                    //OutsideATMMenu.SetActive(true);
                    //Instantiate(OutsideATMMenu);
                    Instantiate(OutsideATMMenu, Vector3.zero, Quaternion.identity);
                    //m_TrackedImageManager.trackedImagePrefab = OutsideATMMenu;
                    break;
                case "IMG_0331":
                   // PromptPanel.SetActive(false);
                    //OutsideATMMenu.SetActive(true);
                    Instantiate(OutsideATMMenu,Vector3.zero,Quaternion.identity);
                    //m_TrackedImageManager.trackedImagePrefab = OutsideATMMenu;
                    break;
                case "IMG_0332":
                    //PromptPanel.SetActive(false);
                    //OutsideATMMenu.SetActive(true);
                    //Instantiate(OutsideATMMenu);
                    Instantiate(OutsideATMMenu, Vector3.zero, Quaternion.identity);
                    //m_TrackedImageManager.trackedImagePrefab = OutsideATMMenu;
                    break;
            }
        }
     }
       
}
