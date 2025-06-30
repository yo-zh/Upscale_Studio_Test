using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsTabsManager : MonoBehaviour
{
    [SerializeField] private GameObject[] Tabs;
    [SerializeField] private Image[] TabButtons;
    [SerializeField] private Sprite ActiveTabButtonSprite, InactiveTabButtonSprite;

    public void SwitchToTab(int TabID)
    {
        foreach (GameObject tab in Tabs)
        {
            tab.SetActive(false);
        }
        Tabs[TabID].SetActive(true);

        foreach (Image tabImage in TabButtons)
        {
            tabImage.sprite = InactiveTabButtonSprite;
        }
        TabButtons[TabID].sprite = ActiveTabButtonSprite;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
